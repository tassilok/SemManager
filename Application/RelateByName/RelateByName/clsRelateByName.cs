using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Sem_Manager;
using Sem_Manager.ds_DBWorkTableAdapters;
using Sem_Manager.ds_SemDBTableAdapters;

namespace RelateByName
{
    class clsRelateByName
    {
        private semtbl_TokenTableAdapter semtblA_Token = new semtbl_TokenTableAdapter();
        private ds_SemDB.semtbl_TokenDataTable semtblT_Token = new ds_SemDB.semtbl_TokenDataTable();
        private semproc_DBWork_Save_TokenTableAdapter semprocA_DBWork_Save_Token = new semproc_DBWork_Save_TokenTableAdapter();
        private semproc_DBWork_Save_TokenRelTableAdapter semprocA_DBWork_Save_TokenRel = new semproc_DBWork_Save_TokenRelTableAdapter();
        

        private clsGlobals objGlobals;

        public clsRelateByName(clsGlobals Globals)
        {
            objGlobals = Globals;
            SetDBConnection();
        }

        private void SetDBConnection()
        {
            semtblA_Token.Connection = new SqlConnection(objGlobals.ConnectionString_User);
            semprocA_DBWork_Save_TokenRel.Connection = new SqlConnection(objGlobals.ConnectionString_User);
            semprocA_DBWork_Save_Token.Connection = new SqlConnection(objGlobals.ConnectionString_User);
        }



        public clsSemItem RelateByName_Split(Guid GUID_Type_Source, string strSeperator, Guid GUID_Type_Relate, Guid GUID_RelationType, int ixRight, string strSearchPattern = null, string strReplace = null)
        {
            semtblA_Token.Fill_Token_TypeChilds(semtblT_Token, GUID_Type_Relate);
            DataRowCollection objDRC_Source = semtblA_Token.GetData_Token_TypeChilds(GUID_Type_Source).Rows;
            DataRowCollection objDRC_LogState;

            clsSemItem objSemItem_Result = objGlobals.LogState_Success;

            var intToDo = objDRC_Source.Count;
            var intDone = 0;

            foreach (DataRow dataRow in objDRC_Source)
            {
                var splitted = dataRow["Name_Token"].ToString().Split(strSeperator.ToCharArray());
                var strName = splitted[ixRight];
                if (strSearchPattern != null && strReplace != null)
                {
                    strName = Regex.Replace(strName, strSearchPattern, strReplace);
                }
                if (splitted.Count() > ixRight)
                {
                    DataRow[] dataRowDst = semtblT_Token.Select("Name_Token='" + strName + "'");
                    if (dataRowDst.Any())
                    {
                        objDRC_LogState =
                            semprocA_DBWork_Save_TokenRel.GetData(new Guid(dataRow["GUID_Token"].ToString()), new Guid(dataRowDst[0]["GUID_Token"].ToString()),
                                                                  GUID_RelationType, 1).Rows;

                        if (objDRC_LogState[0]["GUID_Token"].ToString() != objGlobals.LogState_Error.GUID.ToString())
                        {
                            intDone++;
                        }    
                    }
                    else
                    {
                        var GUID_Token = Guid.NewGuid();
                        objDRC_LogState = semprocA_DBWork_Save_Token.GetData(GUID_Token, strName,
                                                                                               GUID_Type_Relate, false)
                                                                                      .Rows;

                        if (objDRC_LogState[0]["GUID_Token"].ToString() != objGlobals.LogState_Error.GUID.ToString())
                        {
                            objDRC_LogState =
                            semprocA_DBWork_Save_TokenRel.GetData(new Guid(dataRow["GUID_Token"].ToString()), new Guid(dataRowDst[0]["GUID_Token"].ToString()),
                                                                  GUID_RelationType, 1).Rows;

                            if (objDRC_LogState[0]["GUID_Token"].ToString() != objGlobals.LogState_Error.GUID.ToString())
                            {
                                intDone++;
                            }    
                        }
                    }
                    
                }
            }

            objSemItem_Result.Level = intToDo - intDone;

            return objSemItem_Result;
        }

    }
}
