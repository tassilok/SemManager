CREATE DATABASE sem_db_work_splunk_connector_module
GO
use [sem_db_change]
use [sem_db_work_splunk_connector_module]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_VARCHARMAX] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Datetime]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Datetime] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Datetime]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Date]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Date] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Date]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Type_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Type_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_VarcharMax]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_varcharMAX] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_varcharMAX]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Bit]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Bit] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Bit]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Type_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Type_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Varchar255]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_varchar255] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_varchar255]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_AttributeType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_AttributeType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_AttributeType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Bit]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Bit] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Bit]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Real]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Real] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Real]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type_OR]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Datetime]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_attribute_datetime] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_attribute_datetime]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_RelationType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_RelationType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_RelationType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_RelationType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_RelationType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_RelationType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Int]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Int] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Int]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Int]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Int] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Int]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Real]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Real] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Real]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_AttributeType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_AttributeType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_AttributeType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Varchar255]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Varchar255] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Varchar255]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Time]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_attribute_time] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_attribute_time]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_OR]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_ORType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_ORType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_ORType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Time]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Time] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Time]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Date]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Date] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Date]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[splunktbl_XML_Variable]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[splunktbl_XML_Variable](
	[GUID_XML] [uniqueidentifier] NOT NULL,
	[GUID_Variable] [uniqueidentifier] NOT NULL,
	[Name_Variable] [varchar](255) NOT NULL,
 CONSTRAINT [PK_reptbl_XML_Variable] PRIMARY KEY CLUSTERED 
(
	[GUID_XML] ASC,
	[GUID_Variable] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_Views]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================



-- Author:		<Author,,Name>



-- Create date: <Create Date,,>



-- Description:	<Description,,>



-- =============================================



CREATE PROCEDURE [dbo].[proc_TSQL_Views]



	-- Add the parameters for the stored procedure here



	



AS



BEGIN



	-- SET NOCOUNT ON added to prevent extra result sets from



	-- interfering with SELECT statements.



	SET NOCOUNT ON;







    -- Insert statements for procedure here



	SELECT * FROM sys.views ORDER BY name



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_ObjectDefinition]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================



-- Author:		<Author,,Name>



-- Create date: <Create Date,,>



-- Description:	<Description,,>



-- =============================================



CREATE PROCEDURE [dbo].[proc_TSQL_ObjectDefinition]



	-- Add the parameters for the stored procedure here



	@Name_Object		varchar(255)



AS



BEGIN



	-- SET NOCOUNT ON added to prevent extra result sets from



	-- interfering with SELECT statements.



	SET NOCOUNT ON;







    -- Insert statements for procedure here



    execute sp_helptext @Name_object



	--SELECT OBJECT_DEFINITION 



	--	(OBJECT_ID(@Name_Object)) AS ObjectDefinition



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_Synonyms]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================



-- Author:		<Author,,Name>



-- Create date: <Create Date,,>



-- Description:	<Description,,>



-- =============================================



CREATE PROCEDURE proc_TSQL_Synonyms



	-- Add the parameters for the stored procedure here



	



AS



BEGIN



	-- SET NOCOUNT ON added to prevent extra result sets from



	-- interfering with SELECT statements.



	SET NOCOUNT ON;







    -- Insert statements for procedure here



	SELECT * FROM sys.synonyms ORDER BY name



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_Procedures]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================



-- Author:		<Author,,Name>



-- Create date: <Create Date,,>



-- Description:	<Description,,>



-- =============================================



CREATE PROCEDURE [dbo].[proc_TSQL_Procedures]



	-- Add the parameters for the stored procedure here







AS



BEGIN



	-- SET NOCOUNT ON added to prevent extra result sets from



	-- interfering with SELECT statements.



	SET NOCOUNT ON;







    -- Insert statements for procedure here



	SELECT * FROM sys.procedures ORDER By name



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_Functions]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================



-- Author:		<Author,,Name>



-- Create date: <Create Date,,>



-- Description:	<Description,,>



-- =============================================



CREATE PROCEDURE [dbo].[proc_TSQL_Functions] 



	-- Add the parameters for the stored procedure here



	



AS



BEGIN



	-- SET NOCOUNT ON added to prevent extra result sets from



	-- interfering with SELECT statements.



	SET NOCOUNT ON;







    -- Insert statements for procedure here



	SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE Routine_Type=''FUNCTION'' ORDER By ROUTINE_NAME



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_Triggers]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================



-- Author:		<Author,,Name>



-- Create date: <Create Date,,>



-- Description:	<Description,,>



-- =============================================



CREATE PROCEDURE proc_TSQL_Triggers



	-- Add the parameters for the stored procedure here



	



AS



BEGIN



	-- SET NOCOUNT ON added to prevent extra result sets from



	-- interfering with SELECT statements.



	SET NOCOUNT ON;







    -- Insert statements for procedure here



	SELECT * FROM sys.triggers ORDER BY name



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_Tables]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================



-- Author:		<Author,,Name>



-- Create date: <Create Date,,>



-- Description:	<Description,,>



-- =============================================



CREATE PROCEDURE [dbo].[proc_TSQL_Tables]



	-- Add the parameters for the stored procedure here



	



AS



BEGIN



	-- SET NOCOUNT ON added to prevent extra result sets from



	-- interfering with SELECT statements.



	SET NOCOUNT ON;







    -- Insert statements for procedure here



	SELECT * FROM sys.tables ORDER By name



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[splunktbl_XML]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[splunktbl_XML](
	[GUID_BaseConfig] [uniqueidentifier] NOT NULL,
	[GUID_XML_Report] [uniqueidentifier] NOT NULL,
	[Name_XML_Report] [varchar](255) NOT NULL,
	[GUID_TokenAttribute_XMLReport] [uniqueidentifier] NOT NULL,
	[XMLReport] [varchar](max) NOT NULL,
	[GUID_XML_Row] [uniqueidentifier] NOT NULL,
	[Name_XML_Row] [varchar](255) NOT NULL,
	[GUID_TokenAttribute_Row] [uniqueidentifier] NOT NULL,
	[XMLRow] [varchar](max) NOT NULL,
	[GUID_XML_Field] [uniqueidentifier] NOT NULL,
	[Name_XML_Field] [varchar](255) NOT NULL,
	[GUID_TokenAttribute_Field] [uniqueidentifier] NOT NULL,
	[XMLField] [varchar](max) NOT NULL,
 CONSTRAINT [PK_splunktbl_XML] PRIMARY KEY CLUSTERED 
(
	[GUID_BaseConfig] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_Parameters]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================



-- Author:		<Author,,Name>



-- Create date: <Create Date,,>



-- Description:	<Description,,>



-- =============================================



CREATE PROCEDURE [dbo].[proc_TSQL_Parameters] 



	-- Add the parameters for the stored procedure here



	@Name_DBItem		varchar(255)



AS



BEGIN



	-- SET NOCOUNT ON added to prevent extra result sets from



	-- interfering with SELECT statements.



	SET NOCOUNT ON;







    -- Insert statements for procedure here



	SELECT * FROM INFORMATION_SCHEMA.PARAMETERS WHERE specific_Name=@Name_DBItem ORDER by PARAMETER_NAME;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_offered_by]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_offered_by]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''offered by'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Server_Port]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Server_Port]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Server:Port'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Server]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Server]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Server'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Root]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Root]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Root'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Splunk_Connector_Module]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Splunk_Connector_Module] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Splunk_Connector_Module		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Splunk_Connector_Module, Name_Token AS Name_Splunk_Connector_Module, GUID_Type AS GUID_Type_Splunk_Connector_Module

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Splunk_Connector_Module)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Server_Port]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Server_Port] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Server_Port		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Server_Port, Name_Token AS Name_Server_Port, GUID_Type AS GUID_Type_Server_Port

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Server_Port)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Port]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Port] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Port		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Port, Name_Token AS Name_Port, GUID_Type AS GUID_Type_Port

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Port)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_XML]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_XML]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''XML'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belongs_to]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belongs_to]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''belongs to'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_Row_Template]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_Row_Template]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''belonging Row-Template'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Information_Management]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Information_Management]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Information-Management'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_ProcessorID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_ProcessorID]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''ProcessorID'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_BaseboardSerial]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_BaseboardSerial]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''BaseboardSerial'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_db_postfix]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_db_postfix]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''db_postfix'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_Source]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_Source]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''belonging Source'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_XML]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_XML] 

(	

	-- Add the parameters for the function here

	@GUID_Type_XML		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_XML, Name_Token AS Name_XML, GUID_Type AS GUID_Type_XML

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_XML)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_XML_Text]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_XML_Text]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''XML-Text'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Value]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Value]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Value'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Variable]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Variable] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Variable		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Variable, Name_Token AS Name_Variable, GUID_Type AS GUID_Type_Variable

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Variable)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Server]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Server] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Server		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Server, Name_Token AS Name_Server, GUID_Type AS GUID_Type_Server

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Server)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_contains]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_contains]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''contains'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Information_Management]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Information_Management] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Information_Management		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Information_Management, Name_Token AS Name_Information_Management, GUID_Type AS GUID_Type_Information_Management

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Information_Management)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Port]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Port]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Port'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Root]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Root] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Root		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Root, Name_Token AS Name_Root, GUID_Type AS GUID_Type_Root

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Root)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Module]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Module] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Module		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Module, Name_Token AS Name_Module, GUID_Type AS GUID_Type_Module

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Module)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Module]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Module]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Module'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Splunk_Connector_Module]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Splunk_Connector_Module]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Splunk-Connector-Module'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_Report_Template]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_Report_Template]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''belonging Report-Template'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_Field_Template]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_Field_Template]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''belonging Field-Template'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Variable]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Variable]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Variable'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_BaseConfig_XML]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_BaseConfig_XML]

	-- Add the parameters for the stored procedure here

	 @GUID_Attribute_XMLText						uniqueidentifier

	,@GUID_Type_XML									uniqueidentifier

	,@GUID_Type_Variable							uniqueidentifier

	,@GUID_RelationType_belonging_Report_Template	uniqueidentifier

	,@GUID_RelationType_belonging_Row_Template		uniqueidentifier

	,@GUID_RelationType_belonging_Field_Template	uniqueidentifier

	,@GUID_RelationType_contains					uniqueidentifier

	,@GUID_BaseConfig								uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here



	DELETE FROM splunktbl_XML

	DELETE FROM splunktbl_XML_Variable



	INSERT INTO splunktbl_XML

	SELECT	 BaseConfig_To_XMLReport.GUID_Token_Left AS GUID_BaseConfig

			,XML_Report.GUID_XML AS GUID_XML_Report

			,XML_Report.Name_XML AS Name_XML_Report

			,XMLReport__XML_Val.GUID_TokenAttribute AS GUID_TokenAttribute_XMLReport

			,XMLReport__XML_Val.Val AS XMLReport

			,XML_Row.GUID_XML AS GUID_XML_Report

			,XML_Row.Name_XML AS Name_XML_Report

			,XMLRow__XML_Val.GUID_TokenAttribute AS GUID_TokenAttribute_XMLRow

			,XMLRow__XML_Val.Val AS XMLRow

			,XML_Field.GUID_XML AS GUID_XML_Report

			,XML_Field.Name_XML AS Name_XML_Report

			,XMLField__XML_Val.GUID_TokenAttribute AS GUID_TokenAttribute_XMLField

			,XMLField__XML_Val.Val AS XMLField

	FROM semtbl_Token_Token AS BaseConfig_To_XMLReport



	INNER JOIN dbo.func_Token_XML(@GUID_Type_XML) XML_Report ON XML_Report.GUID_XML = BaseConfig_To_XMLReport.GUID_Token_Right

	INNER JOIN semtbl_Token_Attribute AS XMLReport__XML ON XMLReport__XML.GUID_Token = XML_Report.GUID_XML

	INNER JOIN semtbl_Token_Attribute_VARCHARMAX AS XMLReport__XML_Val ON XMLReport__XML_Val.GUID_TokenAttribute = XMLReport__XML.GUID_TokenAttribute



	INNER JOIN semtbl_Token_Token AS BaseConfig_To_XMLRow ON BaseConfig_To_XMLRow.GUID_Token_Left = BaseConfig_To_XMLReport.GUID_Token_Left

	INNER JOIN dbo.func_Token_XML(@GUID_Type_XML) XML_Row ON XML_Row.GUID_XML = BaseConfig_To_XMLRow.GUID_Token_Right

	INNER JOIN semtbl_Token_Attribute AS XMLRow__XML ON XMLRow__XML.GUID_Token = XML_Row.GUID_XML

	INNER JOIN semtbl_Token_Attribute_VARCHARMAX AS XMLRow__XML_Val ON XMLRow__XML_Val.GUID_TokenAttribute = XMLRow__XML.GUID_TokenAttribute



	INNER JOIN semtbl_Token_Token AS BaseConfig_To_XMLField ON BaseConfig_To_XMLField.GUID_Token_Left = BaseConfig_To_XMLReport.GUID_Token_Left

	INNER JOIN dbo.func_Token_XML(@GUID_Type_XML) XML_Field ON XML_Field.GUID_XML = BaseConfig_To_XMLField.GUID_Token_Right

	INNER JOIN semtbl_Token_Attribute AS XMLField__XML ON XMLField__XML.GUID_Token = XML_Field.GUID_XML

	INNER JOIN semtbl_Token_Attribute_VARCHARMAX AS XMLField__XML_Val ON XMLField__XML_Val.GUID_TokenAttribute = XMLField__XML.GUID_TokenAttribute



	WHERE BaseConfig_To_XMLReport.GUID_Token_Left = @GUID_BaseConfig

	AND BaseConfig_To_XMLReport.GUID_RelationType = @GUID_RelationType_belonging_Report_Template

	AND BaseConfig_To_XMLRow.GUID_RelationType = @GUID_RelationType_belonging_Row_Template

	AND BaseConfig_To_XMLField.GUID_RelationType = @GUID_RelationType_belonging_Field_Template

	AND XMLReport__XML.GUID_Attribute = @GUID_Attribute_XMLText

	AND XMLRow__XML.GUID_Attribute = @GUID_Attribute_XMLText

	AND XMLField__XML.GUID_Attribute = @GUID_Attribute_XMLText

	AND BaseConfig_To_XMLReport.OrderID = 1

	AND BaseConfig_To_XMLRow.OrderID = 1

	AND BaseConfig_To_XMLField.OrderID = 1



	INSERT INTO splunktbl_XML_Variable

	SELECT	 splunktbl_XML.GUID_XML_Report

			,Variable.GUID_Variable

			,Variable.Name_Variable

	FROM splunktbl_XML

	INNER JOIN semtbl_Token_Token ON semtbl_Token_Token.GUID_Token_Left = splunktbl_XML.GUID_XML_Report

	INNER JOIN dbo.func_Token_Variable(@GUID_Type_Variable) Variable ON Variable.GUID_Variable = semtbl_Token_Token.GUID_Token_Right

	WHERE semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_contains



	INSERT INTO splunktbl_XML_Variable

	SELECT	 splunktbl_XML.GUID_XML_Row

			,Variable.GUID_Variable

			,Variable.Name_Variable

	FROM splunktbl_XML

	INNER JOIN semtbl_Token_Token ON semtbl_Token_Token.GUID_Token_Left = splunktbl_XML.GUID_XML_Row

	INNER JOIN dbo.func_Token_Variable(@GUID_Type_Variable) Variable ON Variable.GUID_Variable = semtbl_Token_Token.GUID_Token_Right

	WHERE semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_contains



	INSERT INTO splunktbl_XML_Variable

	SELECT	 splunktbl_XML.GUID_XML_Field

			,Variable.GUID_Variable

			,Variable.Name_Variable

	FROM splunktbl_XML

	INNER JOIN semtbl_Token_Token ON semtbl_Token_Token.GUID_Token_Left = splunktbl_XML.GUID_XML_Field

	INNER JOIN dbo.func_Token_Variable(@GUID_Type_Variable) Variable ON Variable.GUID_Variable = semtbl_Token_Token.GUID_Token_Right

	WHERE semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_contains



	SELECT [GUID_BaseConfig]

		  ,[GUID_XML_Report]

		  ,[Name_XML_Report]

		  ,[GUID_TokenAttribute_XMLReport]

		  ,[XMLReport]

		  ,[GUID_XML_Row]

		  ,[Name_XML_Row]

		  ,[GUID_TokenAttribute_Row]

		  ,[XMLRow]

		  ,[GUID_XML_Field]

		  ,[Name_XML_Field]

		  ,[GUID_TokenAttribute_Field]

		  ,[XMLField]

	  FROM [splunktbl_XML]

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_BaseConfig_XML]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_BaseConfig_XML]

	-- Add the parameters for the stored procedure here

	@GUID_BaseConfig		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here



	DECLARE @GUID_Attribute_XMLText							uniqueidentifier

	DECLARE @GUID_Type_XML									uniqueidentifier

	DECLARE @GUID_Type_Variable								uniqueidentifier

	DECLARE @GUID_RelationType_belonging_Report_Template	uniqueidentifier

	DECLARE @GUID_RelationType_belonging_Row_Template		uniqueidentifier

	DECLARE @GUID_RelationType_belonging_Field_Template		uniqueidentifier

	DECLARE @GUID_RelationType_contains						uniqueidentifier



	SET @GUID_Attribute_XMLText							= dbo.dbg_AttributeType_XML_Text()

	SET @GUID_Type_XML									= dbo.dbg_Type_XML()

	SET @GUID_Type_Variable								= dbo.dbg_Type_Variable()

	SET @GUID_RelationType_belonging_Report_Template	= dbo.dbg_RelationType_belonging_Report_Template()

	SET @GUID_RelationType_belonging_Row_Template		= dbo.dbg_RelationType_belonging_Row_Template()

	SET @GUID_RelationType_belonging_Field_Template		= dbo.dbg_RelationType_belonging_Field_Template()

	SET @GUID_RelationType_contains						= dbo.dbg_RelationType_contains()



	DELETE FROM splunktbl_XML

	DELETE FROM splunktbl_XML_Variable



	INSERT INTO splunktbl_XML

	SELECT	 BaseConfig_To_XMLReport.GUID_Token_Left AS GUID_BaseConfig

			,XML_Report.GUID_XML AS GUID_XML_Report

			,XML_Report.Name_XML AS Name_XML_Report

			,XMLReport__XML_Val.GUID_TokenAttribute AS GUID_TokenAttribute_XMLReport

			,XMLReport__XML_Val.Val AS XMLReport

			,XML_Row.GUID_XML AS GUID_XML_Report

			,XML_Row.Name_XML AS Name_XML_Report

			,XMLRow__XML_Val.GUID_TokenAttribute AS GUID_TokenAttribute_XMLRow

			,XMLRow__XML_Val.Val AS XMLRow

			,XML_Field.GUID_XML AS GUID_XML_Report

			,XML_Field.Name_XML AS Name_XML_Report

			,XMLField__XML_Val.GUID_TokenAttribute AS GUID_TokenAttribute_XMLField

			,XMLField__XML_Val.Val AS XMLField

	FROM semtbl_Token_Token AS BaseConfig_To_XMLReport



	INNER JOIN dbo.func_Token_XML(@GUID_Type_XML) XML_Report ON XML_Report.GUID_XML = BaseConfig_To_XMLReport.GUID_Token_Right

	INNER JOIN semtbl_Token_Attribute AS XMLReport__XML ON XMLReport__XML.GUID_Token = XML_Report.GUID_XML

	INNER JOIN semtbl_Token_Attribute_VARCHARMAX AS XMLReport__XML_Val ON XMLReport__XML_Val.GUID_TokenAttribute = XMLReport__XML.GUID_TokenAttribute



	INNER JOIN semtbl_Token_Token AS BaseConfig_To_XMLRow ON BaseConfig_To_XMLRow.GUID_Token_Left = BaseConfig_To_XMLReport.GUID_Token_Left

	INNER JOIN dbo.func_Token_XML(@GUID_Type_XML) XML_Row ON XML_Row.GUID_XML = BaseConfig_To_XMLRow.GUID_Token_Right

	INNER JOIN semtbl_Token_Attribute AS XMLRow__XML ON XMLRow__XML.GUID_Token = XML_Row.GUID_XML

	INNER JOIN semtbl_Token_Attribute_VARCHARMAX AS XMLRow__XML_Val ON XMLRow__XML_Val.GUID_TokenAttribute = XMLRow__XML.GUID_TokenAttribute



	INNER JOIN semtbl_Token_Token AS BaseConfig_To_XMLField ON BaseConfig_To_XMLField.GUID_Token_Left = BaseConfig_To_XMLReport.GUID_Token_Left

	INNER JOIN dbo.func_Token_XML(@GUID_Type_XML) XML_Field ON XML_Field.GUID_XML = BaseConfig_To_XMLField.GUID_Token_Right

	INNER JOIN semtbl_Token_Attribute AS XMLField__XML ON XMLField__XML.GUID_Token = XML_Field.GUID_XML

	INNER JOIN semtbl_Token_Attribute_VARCHARMAX AS XMLField__XML_Val ON XMLField__XML_Val.GUID_TokenAttribute = XMLField__XML.GUID_TokenAttribute



	WHERE BaseConfig_To_XMLReport.GUID_Token_Left = @GUID_BaseConfig

	AND BaseConfig_To_XMLReport.GUID_RelationType = @GUID_RelationType_belonging_Report_Template

	AND BaseConfig_To_XMLRow.GUID_RelationType = @GUID_RelationType_belonging_Row_Template

	AND BaseConfig_To_XMLField.GUID_RelationType = @GUID_RelationType_belonging_Field_Template

	AND XMLReport__XML.GUID_Attribute = @GUID_Attribute_XMLText

	AND XMLRow__XML.GUID_Attribute = @GUID_Attribute_XMLText

	AND XMLField__XML.GUID_Attribute = @GUID_Attribute_XMLText

	AND BaseConfig_To_XMLReport.OrderID = 1

	AND BaseConfig_To_XMLRow.OrderID = 1

	AND BaseConfig_To_XMLField.OrderID = 1



	INSERT INTO splunktbl_XML_Variable

	SELECT	 splunktbl_XML.GUID_XML_Report

			,Variable.GUID_Variable

			,Variable.Name_Variable

	FROM splunktbl_XML

	INNER JOIN semtbl_Token_Token ON semtbl_Token_Token.GUID_Token_Left = splunktbl_XML.GUID_XML_Report

	INNER JOIN dbo.func_Token_Variable(@GUID_Type_Variable) Variable ON Variable.GUID_Variable = semtbl_Token_Token.GUID_Token_Right

	WHERE semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_contains



	INSERT INTO splunktbl_XML_Variable

	SELECT	 splunktbl_XML.GUID_XML_Row

			,Variable.GUID_Variable

			,Variable.Name_Variable

	FROM splunktbl_XML

	INNER JOIN semtbl_Token_Token ON semtbl_Token_Token.GUID_Token_Left = splunktbl_XML.GUID_XML_Row

	INNER JOIN dbo.func_Token_Variable(@GUID_Type_Variable) Variable ON Variable.GUID_Variable = semtbl_Token_Token.GUID_Token_Right

	WHERE semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_contains



	INSERT INTO splunktbl_XML_Variable

	SELECT	 splunktbl_XML.GUID_XML_Field

			,Variable.GUID_Variable

			,Variable.Name_Variable

	FROM splunktbl_XML

	INNER JOIN semtbl_Token_Token ON semtbl_Token_Token.GUID_Token_Left = splunktbl_XML.GUID_XML_Field

	INNER JOIN dbo.func_Token_Variable(@GUID_Type_Variable) Variable ON Variable.GUID_Variable = semtbl_Token_Token.GUID_Token_Right

	WHERE semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_contains



	SELECT [GUID_BaseConfig]

		  ,[GUID_XML_Report]

		  ,[Name_XML_Report]

		  ,[GUID_TokenAttribute_XMLReport]

		  ,[XMLReport]

		  ,[GUID_XML_Row]

		  ,[Name_XML_Row]

		  ,[GUID_TokenAttribute_Row]

		  ,[XMLRow]

		  ,[GUID_XML_Field]

		  ,[Name_XML_Field]

		  ,[GUID_TokenAttribute_Field]

		  ,[XMLField]

	  FROM [splunktbl_XML]

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_BaseConfig_SplunkServer]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_BaseConfig_SplunkServer]

	-- Add the parameters for the stored procedure here

	@GUID_BaseConfig		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here



	DECLARE @GUID_Type_ServerPort				uniqueidentifier

	DECLARE @GUID_Type_Port						uniqueidentifier

	DECLARE @GUID_Type_Server					uniqueidentifier

	DECLARE @GUID_RelationType_belongingSource	uniqueidentifier



	SET @GUID_Type_ServerPort				= dbo.dbg_Type_Server_Port()

	SET @GUID_Type_Port						= dbo.dbg_Type_Port()

	SET @GUID_Type_Server					= dbo.dbg_Type_Server()

	SET @GUID_RelationType_belongingSource	= dbo.dbg_RelationType_belonging_Source()



	SELECT	 BaseConfig_To_ServerPort.GUID_Token_Left AS GUID_BaseConfig

			,ServerPort.GUID_Server_Port

			,ServerPort.Name_Server_Port

			,Port.GUID_Port

			,Port.Name_Port

			,Server.GUID_Server

			,Server.Name_Server

	FROM semtbl_Token_Token BaseConfig_To_ServerPort

	INNER JOIN dbo.func_Token_Server_Port(@GUID_Type_ServerPort) ServerPort ON ServerPort.GUID_Server_Port = BaseConfig_To_ServerPort.GUID_Token_Right

	INNER JOIN semtbl_Token_Token ServerPort_To_Port ON ServerPort_To_Port.GUID_Token_Left = ServerPort.GUID_Server_Port

	INNER JOIN dbo.Func_Token_Port(@GUID_Type_Port) Port ON Port.GUID_Port = ServerPort_To_Port.GUID_Token_Right

	INNER JOIN semtbl_Token_Token ServerPort_To_Server ON ServerPort_To_Server.GUID_Token_Left = ServerPort.GUID_Server_Port

	INNER JOIN dbo.func_Token_Server(@GUID_Type_Server) Server ON Server.GUID_Server = ServerPort_To_Server.GUID_Token_Right

	WHERE BaseConfig_To_ServerPort.GUID_Token_Left = @GUID_BaseConfig

	AND BaseConfig_To_ServerPort.OrderID = 1

	AND BaseConfig_To_ServerPort.GUID_RelationType = @GUID_RelationType_belongingSource

	AND ServerPort_To_Port.GUID_RelationType = @GUID_RelationType_belongingSource

	AND ServerPort_To_Server.GUID_RelationType = @GUID_RelationType_belongingSource

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_BaseConfig_SplunkServer]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_BaseConfig_SplunkServer

	-- Add the parameters for the stored procedure here

	 @GUID_Type_ServerPort				uniqueidentifier

	,@GUID_Type_Port						uniqueidentifier

	,@GUID_Type_Server					uniqueidentifier

	,@GUID_RelationType_belongingSource	uniqueidentifier

	,@GUID_BaseConfig		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

    

	SELECT	 BaseConfig_To_ServerPort.GUID_Token_Left AS GUID_BaseConfig

			,ServerPort.GUID_Server_Port

			,ServerPort.Name_Server_Port

			,Port.GUID_Port

			,Port.Name_Port

			,Server.GUID_Server

			,Server.Name_Server

	FROM semtbl_Token_Token BaseConfig_To_ServerPort

	INNER JOIN dbo.func_Token_Server_Port(@GUID_Type_ServerPort) ServerPort ON ServerPort.GUID_Server_Port = BaseConfig_To_ServerPort.GUID_Token_Right

	INNER JOIN semtbl_Token_Token ServerPort_To_Port ON ServerPort_To_Port.GUID_Token_Left = ServerPort.GUID_Server_Port

	INNER JOIN dbo.Func_Token_Port(@GUID_Type_Port) Port ON Port.GUID_Port = ServerPort_To_Port.GUID_Token_Right

	INNER JOIN semtbl_Token_Token ServerPort_To_Server ON ServerPort_To_Server.GUID_Token_Left = ServerPort.GUID_Server_Port

	INNER JOIN dbo.func_Token_Server(@GUID_Type_Server) Server ON Server.GUID_Server = ServerPort_To_Server.GUID_Token_Right

	WHERE BaseConfig_To_ServerPort.GUID_Token_Left = @GUID_BaseConfig

	AND BaseConfig_To_ServerPort.OrderID = 1

	AND BaseConfig_To_ServerPort.GUID_RelationType = @GUID_RelationType_belongingSource

	AND ServerPort_To_Port.GUID_RelationType = @GUID_RelationType_belongingSource

	AND ServerPort_To_Server.GUID_RelationType = @GUID_RelationType_belongingSource

END
'
END
GO
EXEC sp_addextendedproperty 
		@name = SchemaVersion, @value = '0.0.0.4';
GO
EXEC sp_addextendedproperty 
		@name = SemDB, @value = 'Yes';
GO
