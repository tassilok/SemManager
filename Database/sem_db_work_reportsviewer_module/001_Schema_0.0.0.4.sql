CREATE DATABASE sem_db_work_reportsviewer_module
GO
use [sem_db_change]
use [sem_db_work_reportsviewer_module]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Type_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_Type_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Type_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Int]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Int] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_Token_Attribute_Int]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Time]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_attribute_time] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Token_attribute_time]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Type_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Time]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Time] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_Token_Attribute_Time]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Token_OR]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_VARCHARMAX] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Date]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Date] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Token_Attribute_Date]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_AttributeType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_AttributeType] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_AttributeType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Token_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Bit]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Bit] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Token_Attribute_Bit]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Token_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_ORType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_ORType] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_ORType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Datetime]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Datetime] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_Token_Attribute_Datetime]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_AttributeType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_AttributeType] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_AttributeType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Varchar255]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Varchar255] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_Token_Attribute_Varchar255]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Date]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Date] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_Token_Attribute_Date]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_Token_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Type_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_Type_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Datetime]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_attribute_datetime] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Token_attribute_datetime]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_VarcharMax]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_varcharMAX] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Token_Attribute_varcharMAX]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Int]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Int] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Token_Attribute_Int]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Real]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Real] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Token_Attribute_Real]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_RelationType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_RelationType] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_RelationType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_RelationType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_RelationType] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_RelationType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Real]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Real] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_Token_Attribute_Real]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Bit]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Bit] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR_Token_Attribute_Bit]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_OR]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Type_OR]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Varchar255]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_varchar255] FOR [h3d-kolltass-01\SQLEXPRESS].[].[dbo].[semtbl_Token_Attribute_varchar255]'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_Triggers]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_TSQL_Triggers]

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_Triggers]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_TSQL_Triggers]

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_Views]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_TSQL_Views

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_Synonyms]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_TSQL_Synonyms]

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_Triggers]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_TSQL_Triggers]

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_Tables]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_TSQL_Tables

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_Tables]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_TSQL_Tables

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TSQL_Tables]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_TSQL_Tables

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_is_Sem_DB]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_is_Sem_DB]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''is Sem-DB'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Report_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Report_Type]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Report-Type'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_is_exported]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_is_exported]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''is exported'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_DB_Views]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_DB_Views] 

(	

	-- Add the parameters for the function here

	@GUID_Type_DB_Views		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_DB_Views, Name_Token AS Name_DB_Views, GUID_Type AS GUID_Type_DB_Views

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_DB_Views)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Database_on_Server]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Database_on_Server]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Database on Server'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_DB_Views]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_DB_Views]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''DB-Views'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Database_on_Server]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Database_on_Server] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Database_on_Server		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Database_on_Server, Name_Token AS Name_Database_on_Server, GUID_Type AS GUID_Type_Database_on_Server

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Database_on_Server)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_is_of_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_is_of_Type]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''is of Type'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Database]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Database] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Database		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Database, Name_Token AS Name_Database, GUID_Type AS GUID_Type_Database

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Database)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Report_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Report_Type] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Report_Type		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Report_Type, Name_Token AS Name_Report_Type, GUID_Type AS GUID_Type_Report_Type

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Report_Type)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_DB_Procedure]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_DB_Procedure] 

(	

	-- Add the parameters for the function here

	@GUID_Type_DB_Procedure		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_DB_Procedure, Name_Token AS Name_DB_Procedure, GUID_Type AS GUID_Type_DB_Procedure

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_DB_Procedure)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Report]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Report] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Report		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Report, Name_Token AS Name_Report, GUID_Type AS GUID_Type_Report

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Report)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Database]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Database]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Database'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_is]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_is]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''is'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Report]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Report]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Report'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_located_in]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_located_in]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''located in'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ReportFields]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_ReportFields

	-- Add the parameters for the stored procedure here

	 @GUID_Attribute_Invisible			uniqueidentifier

	,@GUID_Type_ReportField				uniqueidentifier

	,@GUID_Type_Report					uniqueidentifier

	,@GUID_Type_DBColumn				uniqueidentifier

	,@GUID_Type_FieldType				uniqueidentifier

	,@GUID_RelationType_belongsTo		uniqueidentifier

	,@GUID_RelationType_is				uniqueidentifier

	,@GUID_RelationType_isOfType		uniqueidentifier

	,@GUID_RelationType_leads			uniqueidentifier

	,@GUID_Report						uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	

	

	

    -- Insert statements for procedure here

	SELECT	 ReportField.GUID_Token AS GUID_ReportField

		,ReportField.Name_Token AS Name_ReportField

		,Report.GUID_Token AS GUID_Report

		,Report.Name_Token AS Name_Report

		,ReportField__Invisibile_Val.GUID_TokenAttribute AS GUID_TokenAttribute_invisible

		,ReportField__Invisibile_Val.val AS invisible

		,DBColumen.GUID_Token AS GUID_DBColumn

		,DBColumen.Name_Token AS Name_DBColumn

		,FieldType.GUID_Token AS GUID_FieldType

		,FieldType.Name_Token AS Name_FieldType

		,ReportFiel_Let.GUID_Token AS GUID_ReportField_Leaded

		,ReportFiel_Let.Name_Token AS Name_ReportField_Leaded

	FROM semtbl_Token ReportField

	INNER JOIN semtbl_Token_Token AS ReportField_To_Report ON ReportField_To_Report.GUID_Token_Left = ReportField.GUID_Token AND ReportField_To_Report.GUID_RelationType=@GUID_RelationType_belongsTo

	INNER JOIN semtbl_Token Report ON Report.GUID_Token = ReportField_To_Report.GUID_Token_Right

	INNER JOIN semtbl_Token_Attribute ReportField__Invisible ON ReportField__Invisible.GUID_Token = ReportField.GUID_Token

	INNER JOIN semtbl_Token_Attribute_Bit ReportField__Invisibile_Val ON ReportField__Invisibile_Val.GUID_TokenAttribute = ReportField__Invisible.GUID_TokenAttribute

	INNER JOIN semtbl_Token_Token ReportField_To_DBColumn ON ReportField_To_DBColumn.GUID_Token_Left = ReportField.GUID_Token AND ReportField_To_DBColumn.GUID_RelationType = @GUID_RelationType_belongsTo

	INNER JOIN semtbl_Token DBColumen ON DBColumen.GUID_Token = ReportField_To_DBColumn.GUID_Token_Right

	INNER JOIN semtbl_Token_Token DBColumn_To_DBItem ON DBColumn_To_DBItem.GUID_Token_Left = DBColumen.GUID_Token

	INNER JOIN semtbl_Token DBItem ON DBItem.GUID_Token = DBColumn_To_DBItem.GUID_Token_Right AND DBColumn_To_DBItem.GUID_RelationType = @GUID_RelationType_belongsto

	INNER JOIN semtbl_Token_Token Reports_To_DBItem ON Reports_To_DBItem.GUID_Token_Left = Report.GUID_Token AND Reports_To_DBItem.GUID_RelationType = @GUID_RelationType_is

			AND Reports_To_DBItem.GUID_Token_Right = DBItem.GUID_Token

	INNER JOIN semtbl_Token_Token AS ReportField_To_FieldType ON ReportField_To_FieldType.GUID_Token_Left = ReportField.GUID_Token AND ReportField_To_FieldType.GUID_RelationType = @GUID_RelationType_isOfType

	INNER JOIN semtbl_Token FieldType ON FieldType.GUID_Token = ReportField_To_FieldType.GUID_Token_Right

	LEFT OUTER JOIN semtbl_Token_Token ReportField_To_ReportField_Leads ON ReportField_To_ReportField_Leads.GUID_Token_Left = ReportField.GUID_Token AND ReportField_To_ReportField_Leads.GUID_RelationType = @GUID_RelationType_leads

	LEFT OUTER JOIN semtbl_Token ReportFiel_Let ON ReportFiel_Let.GUID_Token = ReportField_To_ReportField_Leads.GUID_Token_Right AND ReportFiel_Let.GUID_Type = @GUID_Type_ReportField

	WHERE ReportField.GUID_Type = @GUID_Type_ReportField

	AND Report.GUID_Type = @GUID_Type_Report

	AND DBColumen.GUID_Type = @GUID_Type_DBColumn

	AND FieldType.GUID_Type = @GUID_Type_FieldType

	AND Report.GUID_Token = @GUID_Report

	AND ReportField__Invisible.GUID_Attribute = @GUID_Attribute_Invisible

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_DB_Procedure]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_DB_Procedure]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''DB-Procedure'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_ReportFields]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE dbg_ReportFields

	-- Add the parameters for the stored procedure here

	@GUID_Report		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	DECLARE @GUID_Attribute_Invisible			uniqueidentifier

	

	DECLARE @GUID_Type_ReportField				uniqueidentifier

	DECLARE @GUID_Type_Report					uniqueidentifier

	DECLARE @GUID_Type_DBColumn					uniqueidentifier

	DECLARE @GUID_Type_FieldType				uniqueidentifier



	DECLARE @GUID_RelationType_belongsTo		uniqueidentifier

	DECLARE @GUID_RelationType_is				uniqueidentifier

	DECLARE @GUID_RelationType_isOfType			uniqueidentifier

	DECLARE @GUID_RelationType_leads			uniqueidentifier

	

	SET @GUID_Attribute_Invisible		= dbo.dbg_AttributeType_invisible()

	

	SET @GUID_Type_ReportField			= dbo.dbg_Type_Report_Field()

	SET @GUID_Type_Report				= dbo.dbg_Type_Report()

	SET @GUID_Type_DBColumn				= dbo.dbg_Type_DB_Columns()

	SET @GUID_Type_FieldType			= dbo.dbg_Type_Field_Type()

	

	SET @GUID_RelationType_belongsTo	= dbo.dbg_RelationType_belongs_to()

	SET @GUID_RelationType_is			= dbo.dbg_RelationType_is()

	SET @GUID_RelationType_isOfType		= dbo.dbg_RelationType_is_of_Type()

	SET @GUID_RelationType_leads		= dbo.dbg_RelationType_leads()

	



    -- Insert statements for procedure here

	SELECT	 ReportField.GUID_Token AS GUID_ReportField

		,ReportField.Name_Token AS Name_ReportField

		,Report.GUID_Token AS GUID_Report

		,Report.Name_Token AS Name_Report

		,ReportField__Invisibile_Val.GUID_TokenAttribute AS GUID_TokenAttribute_invisible

		,ReportField__Invisibile_Val.val AS invisible

		,DBColumen.GUID_Token AS GUID_DBColumn

		,DBColumen.Name_Token AS Name_DBColumn

		,FieldType.GUID_Token AS GUID_FieldType

		,FieldType.Name_Token AS Name_FieldType

		,ReportFiel_Let.GUID_Token AS GUID_ReportField_Leaded

		,ReportFiel_Let.Name_Token AS Name_ReportField_Leaded

	FROM semtbl_Token ReportField

	INNER JOIN semtbl_Token_Token AS ReportField_To_Report ON ReportField_To_Report.GUID_Token_Left = ReportField.GUID_Token AND ReportField_To_Report.GUID_RelationType=@GUID_RelationType_belongsTo

	INNER JOIN semtbl_Token Report ON Report.GUID_Token = ReportField_To_Report.GUID_Token_Right

	INNER JOIN semtbl_Token_Attribute ReportField__Invisible ON ReportField__Invisible.GUID_Token = ReportField.GUID_Token

	INNER JOIN semtbl_Token_Attribute_Bit ReportField__Invisibile_Val ON ReportField__Invisibile_Val.GUID_TokenAttribute = ReportField__Invisible.GUID_TokenAttribute

	INNER JOIN semtbl_Token_Token ReportField_To_DBColumn ON ReportField_To_DBColumn.GUID_Token_Left = ReportField.GUID_Token AND ReportField_To_DBColumn.GUID_RelationType = @GUID_RelationType_belongsTo

	INNER JOIN semtbl_Token DBColumen ON DBColumen.GUID_Token = ReportField_To_DBColumn.GUID_Token_Right

	INNER JOIN semtbl_Token_Token DBColumn_To_DBItem ON DBColumn_To_DBItem.GUID_Token_Left = DBColumen.GUID_Token

	INNER JOIN semtbl_Token DBItem ON DBItem.GUID_Token = DBColumn_To_DBItem.GUID_Token_Right AND DBColumn_To_DBItem.GUID_RelationType = @GUID_RelationType_belongsto

	INNER JOIN semtbl_Token_Token Reports_To_DBItem ON Reports_To_DBItem.GUID_Token_Left = Report.GUID_Token AND Reports_To_DBItem.GUID_RelationType = @GUID_RelationType_is

			AND Reports_To_DBItem.GUID_Token_Right = DBItem.GUID_Token

	INNER JOIN semtbl_Token_Token AS ReportField_To_FieldType ON ReportField_To_FieldType.GUID_Token_Left = ReportField.GUID_Token AND ReportField_To_FieldType.GUID_RelationType = @GUID_RelationType_isOfType

	INNER JOIN semtbl_Token FieldType ON FieldType.GUID_Token = ReportField_To_FieldType.GUID_Token_Right

	LEFT OUTER JOIN semtbl_Token_Token ReportField_To_ReportField_Leads ON ReportField_To_ReportField_Leads.GUID_Token_Left = ReportField.GUID_Token AND ReportField_To_ReportField_Leads.GUID_RelationType = @GUID_RelationType_leads

	LEFT OUTER JOIN semtbl_Token ReportFiel_Let ON ReportFiel_Let.GUID_Token = ReportField_To_ReportField_Leads.GUID_Token_Right AND ReportFiel_Let.GUID_Type = @GUID_Type_ReportField

	WHERE ReportField.GUID_Type = @GUID_Type_ReportField

	AND Report.GUID_Type = @GUID_Type_Report

	AND DBColumen.GUID_Type = @GUID_Type_DBColumn

	AND FieldType.GUID_Type = @GUID_Type_FieldType

	AND Report.GUID_Token = @GUID_Report

	AND ReportField__Invisible.GUID_Attribute = @GUID_Attribute_Invisible

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Report]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE dbg_Report

	-- Add the parameters for the stored procedure here

	 @GUID_Report			uniqueidentifier

	,@GUID_ReportType_View	uniqueidentifier

	,@GUID_ReportType_Proc	uniqueidentifier



AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	DECLARE @GUID_Type_Report				uniqueidentifier

	DECLARE @GUID_Type_ReportType			uniqueidentifier

	DECLARE @GUID_Type_DatabaseOnServer		uniqueidentifier

	DECLARE @GUID_Type_DBView				uniqueidentifier

	DECLARE @GUID_Type_Database				uniqueidentifier

	DECLARE @GUID_Type_Server				uniqueidentifier

	DECLARE @GUID_Type_DBProcedure			uniqueidentifier

	DECLARE @GUID_RelationType_isOfType		uniqueidentifier

	DECLARE @GUID_RelationType_is			uniqueidentifier

	DECLARE @GUID_RelationType_contains		uniqueidentifier

	DECLARE @GUID_RelationType_belongsTo	uniqueidentifier

	DECLARE @GUID_RelationType_locatedIn	uniqueidentifier



	SET @GUID_Type_Report					= dbo.dbg_Type_Report()

	SET @GUID_Type_ReportType				= dbo.dbg_Type_Report_Type()

	SET @GUID_Type_DatabaseOnServer			= dbo.dbg_Type_Database_on_Server()

	SET @GUID_Type_DBView					= dbo.dbg_Type_DB_Views()

	SET @GUID_Type_Database					= dbo.dbg_Type_Database()

	SET @GUID_Type_Server					= dbo.dbg_Type_Server()

	SET @GUID_Type_DBProcedure				= dbo.dbg_Type_DB_Procedure()

	SET @GUID_RelationType_isOfType			= dbo.dbg_RelationType_is_of_Type()

	SET @GUID_RelationType_is				= dbo.dbg_RelationType_is()

	SET @GUID_RelationType_contains			= dbo.dbg_RelationType_contains()

	SET @GUID_RelationType_belongsTo		= dbo.dbg_RelationType_belongs_to()

	SET @GUID_RelationType_locatedIn		= dbo.dbg_RelationType_located_in()



	DECLARE @tmp_Report TABLE

	(

		 GUID_Report			uniqueidentifier

		,Name_Report			varchar(255)

		,GUID_Report_Type		uniqueidentifier

		,Name_Report_Type		varchar(255)

		,GUID_DBItem			uniqueidentifier

		,Name_DBItem			varchar(255)

		,GUID_DBItemType		uniqueidentifier

		,GUID_Database			uniqueidentifier

		,Name_Database			varchar(255)

		,GUID_Server			uniqueidentifier

		,Name_Server			varchar(255)

	)



	INSERT INTO @tmp_Report (GUID_Report

				,Name_Report

				,GUID_Report_Type

				,Name_Report_Type)

	SELECT	 rep.GUID_Report

			,rep.Name_Report

			,reptyp.GUID_Report_Type

			,reptyp.Name_Report_Type

	FROM dbo.func_Token_Report(@GUID_Type_Report) rep

	LEFT OUTER JOIN semtbl_Token_Token ON semtbl_Token_Token.GUID_Token_Left = rep.GUID_Report AND semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_isOfType

	LEFT OUTER JOIN dbo.func_Token_Report_Type(@GUID_Type_ReportType) reptyp ON reptyp.GUID_Report_Type = semtbl_Token_Token.GUID_Token_Right

	WHERE GUID_Report = @GUID_Report



	UPDATE @tmp_Report

	SET  GUID_DBItem = dbview.GUID_DB_Views

		,Name_DBItem = dbview.Name_DB_Views

		,GUID_DBItemType = dbview.GUID_Type_DB_Views

		,GUID_Database = db.GUID_Database

		,Name_Database = db.Name_Database

		,GUID_Server = ser.GUID_Server

		,Name_Server = ser.Name_Server

	FROM @tmp_Report rep

	INNER JOIN semtbl_token_token ON rep.GUID_Report = semtbl_token_token.GUID_Token_Left

	INNER JOIN dbo.func_Token_DB_Views(@GUID_Type_DBView) dbview ON dbview.GUID_DB_Views = semtbl_token_token.GUID_Token_Right

	INNER JOIN semtbl_Token_Token DBONServer_To_DBItem ON DBONServer_To_DBItem.GUID_Token_Right = dbview.GUID_DB_Views

	INNER JOIN dbo.func_Token_Database_on_Server(@GUID_Type_DatabaseOnServer) dbos ON dbos.GUID_Database_on_Server = DBONServer_To_DBItem.GUID_Token_Left

	INNER JOIN semtbl_Token_Token DBONServer_To_DB ON DBONServer_To_DB.GUID_Token_Left = dbos.GUID_Database_on_Server

	INNER JOIN dbo.func_Token_Database(@GUID_Type_Database) db ON db.GUID_Database = DBONServer_To_DB.GUID_Token_Right

	INNER JOIN semtbl_Token_Token DBONServer_To_Server ON DBONServer_To_Server.GUID_Token_Left = dbos.GUID_Database_on_Server

	INNER JOIN dbo.func_Token_Server(@GUID_Type_Server) ser ON ser.GUID_Server = DBONServer_To_Server.GUID_Token_Right

	WHERE GUID_Report_Type = @GUID_ReportType_View

	AND semtbl_token_token.GUID_RelationType = @GUID_RelationType_is

	AND DBONServer_To_DBItem.GUID_RelationType = @GUID_RelationType_contains

	AND DBONServer_To_DB.GUID_RelationType = @GUID_RelationType_belongsTo

	AND DBONServer_To_Server.GUID_RelationType = @GUID_RelationType_locatedIn





	UPDATE @tmp_Report

	SET	 GUID_DBItem = dbproc.GUID_DB_Procedure

		,Name_DBItem = dbproc.Name_DB_Procedure

		,GUID_DBItemType = dbproc.GUID_Type_DB_Procedure

		,GUID_Database = db.GUID_Database

		,Name_Database = db.Name_Database

		,GUID_Server = ser.GUID_Server

		,Name_Server = ser.Name_Server 

	FROM @tmp_Report rep

	INNER JOIN semtbl_token_token ON rep.GUID_Report = semtbl_token_token.GUID_Token_Left

	INNER JOIN dbo.func_Token_DB_Procedure(@GUID_Type_DBProcedure) dbproc ON dbproc.GUID_DB_Procedure = semtbl_token_token.GUID_Token_Right

	INNER JOIN semtbl_Token_Token DBONServer_To_DBItem ON DBONServer_To_DBItem.GUID_Token_Right = dbproc.GUID_DB_procedure

	INNER JOIN dbo.func_Token_Database_on_Server(@GUID_Type_DatabaseOnServer) dbos ON dbos.GUID_Database_on_Server = DBONServer_To_DBItem.GUID_Token_Left

	INNER JOIN semtbl_Token_Token DBONServer_To_DB ON DBONServer_To_DB.GUID_Token_Left = dbos.GUID_Database_on_Server

	INNER JOIN dbo.func_Token_Database(@GUID_Type_Database) db ON db.GUID_Database = DBONServer_To_DB.GUID_Token_Right

	INNER JOIN semtbl_Token_Token DBONServer_To_Server ON DBONServer_To_Server.GUID_Token_Left = dbos.GUID_Database_on_Server

	INNER JOIN dbo.func_Token_Server(@GUID_Type_Server) ser ON ser.GUID_Server = DBONServer_To_Server.GUID_Token_Right

	WHERE GUID_Report_Type = @GUID_ReportType_Proc

	AND semtbl_token_token.GUID_RelationType = @GUID_RelationType_is

	AND DBONServer_To_DBItem.GUID_RelationType = @GUID_RelationType_contains

	AND DBONServer_To_DB.GUID_RelationType = @GUID_RelationType_belongsTo

	AND DBONServer_To_Server.GUID_RelationType = @GUID_RelationType_locatedIn



	SELECT GUID_Report			

		,Name_Report			

		,GUID_Report_Type		

		,Name_Report_Type		

		,GUID_DBItem			

		,Name_DBItem			

		,GUID_DBItemType		

		,GUID_Database			

		,Name_Database			

		,GUID_Server			

		,Name_Server			

	FROM @tmp_Report

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_ReportTree]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_ReportTree]

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	DECLARE @GUID_Type_Report			uniqueidentifier

	DECLARE @GUID_Type_Report_Type		uniqueidentifier

	DECLARE @GUID_RelationType_isOfType	uniqueidentifier

	DECLARE @GUID_RelationType_contains	uniqueidentifier



	SET @GUID_Type_Report			= dbo.dbg_Type_Report()

	SET @GUID_Type_Report_Type		= dbo.dbg_Type_Report_Type()

	SET @GUID_RelationType_isOfType = dbo.dbg_RelationType_is_of_Type()

	SET @GUID_RelationType_contains	= dbo.dbg_RelationType_contains()



	DECLARE @tmp_Media TABLE

	(

		 GUID_Report		uniqueidentifier

		,Name_Report		varchar(255)

		,GUID_Report_Type	uniqueidentifier

		,Name_Report_Type	varchar(255)

	)



	INSERT INTO @tmp_Media

	SELECT	 Rep.GUID_Report

			,Rep.Name_Report

			,RepTyp.GUID_Report_Type

			,RepTyp.Name_Report_Type

	FROM dbo.func_Token_Report(@GUID_Type_Report) Rep

	LEFT OUTER JOIN semtbl_Token_Token ON Rep.GUID_Report = semtbl_Token_Token.GUID_Token_Left AND semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_isOfType

	LEFT OUTER JOIN dbo.func_Token_Report_Type(@GUID_Type_Report_Type) RepTyp ON semtbl_Token_Token.GUID_Token_Right = RepTyp.GUID_Report_Type





	;WITH hierarchy AS (

		SELECT	 media.GUID_Report

				,media.Name_Report

				,media.GUID_Report_Type

				,media.Name_Report_Type

				,mediaP.GUID_Report AS GUID_Report_Parent

				,mediaP.Name_Report AS Name_Report_Parent

				,mediaP.GUID_Report_Type AS GUID_Report_Type_Parent

				,mediaP.Name_Report_Type AS Name_Report_Type_Parent

				,CAST(media.Name_Report AS VARCHAR(MAX)) AS Path

		FROM @tmp_Media media

		LEFT OUTER JOIN semtbl_Token_Token ON media.GUID_Report = semtbl_Token_Token.GUID_Token_Right AND semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_contains

		LEFT OUTER JOIN @tmp_Media mediaP ON mediaP.GUID_Report = semtbl_Token_Token.GUID_Token_Left

		WHERE mediaP.GUID_Report IS NULL

		

		UNION ALL

		

		SELECT	 c.GUID_Report

				,c.Name_Report

				,c.GUID_Report_Type

				,c.Name_Report_Type

				,p.GUID_Report AS GUID_Report_Parent

				,p.Name_Report AS Name_Report_Parent

				,p.GUID_Report_Type AS GUID_Report_Type_Parent

				,p.Name_Report_Type AS Name_Report_Type_Parent

				,p.Path + ''\'' + c.Name_Report AS Path

		FROM hierarchy p

		INNER JOIN semtbl_Token_Token ON semtbl_Token_Token.GUID_Token_Left = p.GUID_Report AND semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_contains

		INNER JOIN @tmp_Media c ON c.GUID_Report = semtbl_Token_Token.GUID_Token_Right)

	

	SELECT	 GUID_Report

			,Name_Report

			,GUID_Report_Type

			,Name_Report_Type

			,GUID_Report_Parent

			,Name_Report_Parent

			,GUID_Report_Type_Parent

			,Name_Report_Type_Parent

	FROM hierarchy

	ORDER BY Path

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Report]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_Report

	-- Add the parameters for the stored procedure here

	 @GUID_Type_Report				uniqueidentifier

	,@GUID_Type_ReportType			uniqueidentifier

	,@GUID_Type_DatabaseOnServer	uniqueidentifier

	,@GUID_Type_DBView				uniqueidentifier

	,@GUID_Type_Database			uniqueidentifier

	,@GUID_Type_Server				uniqueidentifier

	,@GUID_Type_DBProcedure			uniqueidentifier

	,@GUID_RelationType_isOfType	uniqueidentifier

	,@GUID_RelationType_is			uniqueidentifier

	,@GUID_RelationType_contains	uniqueidentifier

	,@GUID_RelationType_belongsTo	uniqueidentifier

	,@GUID_RelationType_locatedIn	uniqueidentifier

	,@GUID_Report					uniqueidentifier

	,@GUID_ReportType_View			uniqueidentifier

	,@GUID_ReportType_Proc			uniqueidentifier



AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	

	DECLARE @tmp_Report TABLE

	(

		 GUID_Report			uniqueidentifier

		,Name_Report			varchar(255)

		,GUID_Report_Type		uniqueidentifier

		,Name_Report_Type		varchar(255)

		,GUID_DBItem			uniqueidentifier

		,Name_DBItem			varchar(255)

		,GUID_DBItemType		uniqueidentifier

		,GUID_Database			uniqueidentifier

		,Name_Database			varchar(255)

		,GUID_Server			uniqueidentifier

		,Name_Server			varchar(255)

	)



	INSERT INTO @tmp_Report (GUID_Report

				,Name_Report

				,GUID_Report_Type

				,Name_Report_Type)

	SELECT	 rep.GUID_Report

			,rep.Name_Report

			,reptyp.GUID_Report_Type

			,reptyp.Name_Report_Type

	FROM dbo.func_Token_Report(@GUID_Type_Report) rep

	LEFT OUTER JOIN semtbl_Token_Token ON semtbl_Token_Token.GUID_Token_Left = rep.GUID_Report AND semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_isOfType

	LEFT OUTER JOIN dbo.func_Token_Report_Type(@GUID_Type_ReportType) reptyp ON reptyp.GUID_Report_Type = semtbl_Token_Token.GUID_Token_Right

	WHERE GUID_Report = @GUID_Report



	UPDATE @tmp_Report

	SET  GUID_DBItem = dbview.GUID_DB_Views

		,Name_DBItem = dbview.Name_DB_Views

		,GUID_DBItemType = dbview.GUID_Type_DB_Views

		,GUID_Database = db.GUID_Database

		,Name_Database = db.Name_Database

		,GUID_Server = ser.GUID_Server

		,Name_Server = ser.Name_Server

	FROM @tmp_Report rep

	INNER JOIN semtbl_token_token ON rep.GUID_Report = semtbl_token_token.GUID_Token_Left

	INNER JOIN dbo.func_Token_DB_Views(@GUID_Type_DBView) dbview ON dbview.GUID_DB_Views = semtbl_token_token.GUID_Token_Right

	INNER JOIN semtbl_Token_Token DBONServer_To_DBItem ON DBONServer_To_DBItem.GUID_Token_Right = dbview.GUID_DB_Views

	INNER JOIN dbo.func_Token_Database_on_Server(@GUID_Type_DatabaseOnServer) dbos ON dbos.GUID_Database_on_Server = DBONServer_To_DBItem.GUID_Token_Left

	INNER JOIN semtbl_Token_Token DBONServer_To_DB ON DBONServer_To_DB.GUID_Token_Left = dbos.GUID_Database_on_Server

	INNER JOIN dbo.func_Token_Database(@GUID_Type_Database) db ON db.GUID_Database = DBONServer_To_DB.GUID_Token_Right

	INNER JOIN semtbl_Token_Token DBONServer_To_Server ON DBONServer_To_Server.GUID_Token_Left = dbos.GUID_Database_on_Server

	INNER JOIN dbo.func_Token_Server(@GUID_Type_Server) ser ON ser.GUID_Server = DBONServer_To_Server.GUID_Token_Right

	WHERE GUID_Report_Type = @GUID_ReportType_View

	AND semtbl_token_token.GUID_RelationType = @GUID_RelationType_is

	AND DBONServer_To_DBItem.GUID_RelationType = @GUID_RelationType_contains

	AND DBONServer_To_DB.GUID_RelationType = @GUID_RelationType_belongsTo

	AND DBONServer_To_Server.GUID_RelationType = @GUID_RelationType_locatedIn





	UPDATE @tmp_Report

	SET	 GUID_DBItem = dbproc.GUID_DB_Procedure

		,Name_DBItem = dbproc.Name_DB_Procedure

		,GUID_DBItemType = dbproc.GUID_Type_DB_Procedure

		,GUID_Database = db.GUID_Database

		,Name_Database = db.Name_Database

		,GUID_Server = ser.GUID_Server

		,Name_Server = ser.Name_Server 

	FROM @tmp_Report rep

	INNER JOIN semtbl_token_token ON rep.GUID_Report = semtbl_token_token.GUID_Token_Left

	INNER JOIN dbo.func_Token_DB_Procedure(@GUID_Type_DBProcedure) dbproc ON dbproc.GUID_DB_Procedure = semtbl_token_token.GUID_Token_Right

	INNER JOIN semtbl_Token_Token DBONServer_To_DBItem ON DBONServer_To_DBItem.GUID_Token_Right = dbproc.GUID_DB_procedure

	INNER JOIN dbo.func_Token_Database_on_Server(@GUID_Type_DatabaseOnServer) dbos ON dbos.GUID_Database_on_Server = DBONServer_To_DBItem.GUID_Token_Left

	INNER JOIN semtbl_Token_Token DBONServer_To_DB ON DBONServer_To_DB.GUID_Token_Left = dbos.GUID_Database_on_Server

	INNER JOIN dbo.func_Token_Database(@GUID_Type_Database) db ON db.GUID_Database = DBONServer_To_DB.GUID_Token_Right

	INNER JOIN semtbl_Token_Token DBONServer_To_Server ON DBONServer_To_Server.GUID_Token_Left = dbos.GUID_Database_on_Server

	INNER JOIN dbo.func_Token_Server(@GUID_Type_Server) ser ON ser.GUID_Server = DBONServer_To_Server.GUID_Token_Right

	WHERE GUID_Report_Type = @GUID_ReportType_Proc

	AND semtbl_token_token.GUID_RelationType = @GUID_RelationType_is

	AND DBONServer_To_DBItem.GUID_RelationType = @GUID_RelationType_contains

	AND DBONServer_To_DB.GUID_RelationType = @GUID_RelationType_belongsTo

	AND DBONServer_To_Server.GUID_RelationType = @GUID_RelationType_locatedIn



	SELECT GUID_Report			

		,Name_Report			

		,GUID_Report_Type		

		,Name_Report_Type		

		,GUID_DBItem			

		,Name_DBItem			

		,GUID_DBItemType		

		,GUID_Database			

		,Name_Database			

		,GUID_Server			

		,Name_Server			

	FROM @tmp_Report

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ReportTree]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'

-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_ReportTree]

	-- Add the parameters for the stored procedure here

	 @GUID_Type_Report			uniqueidentifier

	,@GUID_Type_Report_Type		uniqueidentifier

	,@GUID_RelationType_isOfType	uniqueidentifier

	,@GUID_RelationType_contains	uniqueidentifier



AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	

	DECLARE @tmp_Media TABLE

	(

		 GUID_Report		uniqueidentifier

		,Name_Report		varchar(255)

		,GUID_Report_Type	uniqueidentifier

		,Name_Report_Type	varchar(255)

	)



	INSERT INTO @tmp_Media

	SELECT	 Rep.GUID_Report

			,Rep.Name_Report

			,RepTyp.GUID_Report_Type

			,RepTyp.Name_Report_Type

	FROM dbo.func_Token_Report(@GUID_Type_Report) Rep

	LEFT OUTER JOIN semtbl_Token_Token ON Rep.GUID_Report = semtbl_Token_Token.GUID_Token_Left AND semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_isOfType

	LEFT OUTER JOIN dbo.func_Token_Report_Type(@GUID_Type_Report_Type) RepTyp ON semtbl_Token_Token.GUID_Token_Right = RepTyp.GUID_Report_Type





	;WITH hierarchy AS (

		SELECT	 media.GUID_Report

				,media.Name_Report

				,media.GUID_Report_Type

				,media.Name_Report_Type

				,mediaP.GUID_Report AS GUID_Report_Parent

				,mediaP.Name_Report AS Name_Report_Parent

				,mediaP.GUID_Report_Type AS GUID_Report_Type_Parent

				,mediaP.Name_Report_Type AS Name_Report_Type_Parent

				,CAST(media.Name_Report AS VARCHAR(MAX)) AS Path

		FROM @tmp_Media media

		LEFT OUTER JOIN semtbl_Token_Token ON media.GUID_Report = semtbl_Token_Token.GUID_Token_Right AND semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_contains

		LEFT OUTER JOIN @tmp_Media mediaP ON mediaP.GUID_Report = semtbl_Token_Token.GUID_Token_Left

		WHERE mediaP.GUID_Report IS NULL

		

		UNION ALL

		

		SELECT	 c.GUID_Report

				,c.Name_Report

				,c.GUID_Report_Type

				,c.Name_Report_Type

				,p.GUID_Report AS GUID_Report_Parent

				,p.Name_Report AS Name_Report_Parent

				,p.GUID_Report_Type AS GUID_Report_Type_Parent

				,p.Name_Report_Type AS Name_Report_Type_Parent

				,p.Path + ''\'' + c.Name_Report AS Path

		FROM hierarchy p

		INNER JOIN semtbl_Token_Token ON semtbl_Token_Token.GUID_Token_Left = p.GUID_Report AND semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_contains

		INNER JOIN @tmp_Media c ON c.GUID_Report = semtbl_Token_Token.GUID_Token_Right)

	

	SELECT	 GUID_Report

			,Name_Report

			,GUID_Report_Type

			,Name_Report_Type

			,GUID_Report_Parent

			,Name_Report_Parent

			,GUID_Report_Type_Parent

			,Name_Report_Type_Parent

	FROM hierarchy

	ORDER BY Path

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
