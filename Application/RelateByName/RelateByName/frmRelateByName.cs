using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sem_Manager;

namespace RelateByName
{
    public partial class frmRelateByName : Form
    {
     
        private clsGlobals objGlobals = new clsGlobals();
        private clsRelateByName objRelateByName;
        public frmRelateByName()
        {
            InitializeComponent();
            set_DBConnection();
            objRelateByName.RelateByName_Split(new Guid("34ca1e18-d2ab-4e63-93c5-c7077ae81b23"), "=",
                                               new Guid("c8f06d8d-d6a9-45aa-8dc6-a7867870206d"),
                                               new Guid("e9711603-47db-44d8-a476-fe88290639a4"),0,"sea;","");
        }

        private void set_DBConnection()
        {
            objRelateByName = new clsRelateByName(objGlobals);
        }

    }
}
