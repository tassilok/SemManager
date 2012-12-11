CREATE DATABASE sem_db_work_change_module
GO
use [sem_db_change]
use [sem_db_work_change_module]
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Procedures]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_Procedures

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Ticket]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Ticket](
	[GUID_Ticket] [uniqueidentifier] NOT NULL,
	[Name_Ticket] [varchar](255) NOT NULL,
	[GUID_Group] [uniqueidentifier] NOT NULL,
	[Name_Group] [varchar](255) NOT NULL,
 CONSTRAINT [PK_chngtbl_Ticket] PRIMARY KEY CLUSTERED 
(
	[GUID_Ticket] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Procedures]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Procedures]

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Procedures]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Procedures]

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Procedures]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_Procedures

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Procedures]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Procedures]

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Procedures]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_Procedures

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_RelationType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_RelationType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_RelationType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Real]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Real] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Real]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Varchar255]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_varchar255] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_varchar255]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Int]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Int] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Int]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_AttributeType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_AttributeType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_AttributeType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Datetime]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_attribute_datetime] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_attribute_datetime]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Bit]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Bit] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Bit]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type_OR]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Time]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_attribute_time] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_attribute_time]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Real]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Real] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Real]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Bit]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Bit] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Bit]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_AttributeType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_AttributeType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_AttributeType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_OR]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Type_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Type_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Varchar255]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Varchar255] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Varchar255]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_VARCHARMAX] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Int]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Int] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Int]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Datetime]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Datetime] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Datetime]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_RelationType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_RelationType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_RelationType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Date]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Date] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Date]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_VarcharMax]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_varcharMAX] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_varcharMAX]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_ORType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_ORType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_ORType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Date]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Date] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Date]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Type_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Type_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Time]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Time] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Time]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Type]'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_TicketList]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_TicketList](
	[GUID_TicketList] [uniqueidentifier] NOT NULL,
	[Name_TicketList] [varchar](255) NOT NULL,
	[GUID_TicketList_Parent] [uniqueidentifier] NULL,
	[StartStamp] [datetime] NULL,
	[EndStamp] [datetime] NULL,
	[GUID_Group] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_TicketList] PRIMARY KEY CLUSTERED 
(
	[GUID_TicketList] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Procedures]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Procedures]

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_correlated_Process_Ticket_Creation]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_correlated_Process_Ticket_Creation] 

(	

	-- Add the parameters for the function here

	@GUID_Type_correlated_Process_Ticket_Creation		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_correlated_Process_Ticket_Creation, Name_Token AS Name_correlated_Process_Ticket_Creation, GUID_Type AS GUID_Type_correlated_Process_Ticket_Creation

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_correlated_Process_Ticket_Creation)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_is_described_by]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_is_described_by]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''is described by'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Process_Ticket_Lists]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Process_Ticket_Lists]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Process-Ticket Lists'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Process_Ticket]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Process_Ticket]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Process-Ticket'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_provides]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_provides]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''provides'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Group]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Group]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Group'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_user]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_user] 

(	

	-- Add the parameters for the function here

	@GUID_Type_user		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_user, Name_Token AS Name_user, GUID_Type AS GUID_Type_user

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_user)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Work_Day]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Work_Day]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Work-Day'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_Done]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_Done]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''belonging Done'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_Error_Queue]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_Error_Queue]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''Error-Queue'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_superordinate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_superordinate]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''superordinate'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_ID]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_ID](
	[GUID_Ticket] [uniqueidentifier] NOT NULL,
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_chngtbl_ID] PRIMARY KEY CLUSTERED 
(
	[GUID_Ticket] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_ID]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_ID_chngtbl_Ticket] FOREIGN KEY([GUID_Ticket])
REFERENCES [dbo].[chngtbl_Ticket] ([GUID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_ID] CHECK CONSTRAINT [FK_chngtbl_ID_chngtbl_Ticket];
'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Process_Log]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Process_Log]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Process-Log'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Named_GUIDType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_Named_GUIDType]

(

	-- Add the parameters for the function here

	@Name_Type		varchar(255)

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_Type		uniqueidentifier



	SET @GUID_Type = (SELECT     GUID_Type

		FROM         semtbl_Type

		WHERE     (Name_Type = @Name_Type));

	RETURN @GUID_Type;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Incident]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Incident]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Incident'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Logstate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Logstate] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Logstate		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Logstate, Name_Token AS Name_Logstate, GUID_Type AS GUID_Type_Logstate

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Logstate)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_user]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_user] 

(	

	-- Add the parameters for the function here

	@GUID_Type_user		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_user, Name_Token AS Name_user, GUID_Type AS GUID_Type_user

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_user)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_System]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_System]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''System'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Process_Management]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Process_Management]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Process-Management'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Codepage]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Codepage]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Codepage'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Process]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Process]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Process'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Group]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Group] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Group		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Group, Name_Token AS Name_Group, GUID_Type AS GUID_Type_Group

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Group)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Log_Management]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Log_Management] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Log_Management		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Log_Management, Name_Token AS Name_Log_Management, GUID_Type AS GUID_Type_Log_Management

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Log_Management)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Master_Password]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Master_Password]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Master-Password'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Logentry]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Logentry] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Logentry		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Logentry, Name_Token AS Name_Logentry, GUID_Type AS GUID_Type_Logentry

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Logentry)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_finished_with]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_finished_with]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''finished with'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Ticket_TicketList]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Ticket_TicketList](
	[GUID_TicketList] [uniqueidentifier] NOT NULL,
	[GUID_Ticket] [uniqueidentifier] NOT NULL,
	[OrderID] [int] NOT NULL,
 CONSTRAINT [PK_chngtbl_Ticket_TicketList] PRIMARY KEY CLUSTERED 
(
	[GUID_TicketList] ASC,
	[GUID_Ticket] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Ticket_TicketList]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Ticket_TicketList_chngtbl_Ticket] FOREIGN KEY([GUID_Ticket])
REFERENCES [dbo].[chngtbl_Ticket] ([GUID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Ticket_TicketList] CHECK CONSTRAINT [FK_chngtbl_Ticket_TicketList_chngtbl_Ticket];

ALTER TABLE [dbo].[chngtbl_Ticket_TicketList]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Ticket_TicketList_chngtbl_TicketList] FOREIGN KEY([GUID_TicketList])
REFERENCES [dbo].[chngtbl_TicketList] ([GUID_TicketList])
ON UPDATE CASCADE
ON DELETE CASCADE;
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_LastProcess]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_LastProcess](
	[GUID_Ticket] [uniqueidentifier] NOT NULL,
	[GUID_LastProcess] [uniqueidentifier] NOT NULL,
	[Name_LastProcess] [varchar](255) NOT NULL,
	[GUID_Type_LastProcess] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_LastProcess] PRIMARY KEY CLUSTERED 
(
	[GUID_Ticket] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_LastProcess]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_LastProcess_chngtbl_Ticket] FOREIGN KEY([GUID_Ticket])
REFERENCES [dbo].[chngtbl_Ticket] ([GUID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_LastProcess] CHECK CONSTRAINT [FK_chngtbl_LastProcess_chngtbl_Ticket];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Item_Token]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Item_Token](
	[GUID_Ticket] [uniqueidentifier] NOT NULL,
	[GUID_Token] [uniqueidentifier] NOT NULL,
	[Name_Token] [varchar](255) NOT NULL,
	[GUID_Type] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_Item_Token] PRIMARY KEY CLUSTERED 
(
	[GUID_Ticket] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Item_Token]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Item_Token_chngtbl_Ticket] FOREIGN KEY([GUID_Ticket])
REFERENCES [dbo].[chngtbl_Ticket] ([GUID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Item_Token] CHECK CONSTRAINT [FK_chngtbl_Item_Token_chngtbl_Ticket];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Feiertage]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Feiertage] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Feiertage		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Feiertage, Name_Token AS Name_Feiertage, GUID_Type AS GUID_Type_Feiertage

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Feiertage)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_Last_Done]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_Last_Done]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''Last Done'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Item_Type]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Item_Type](
	[GUID_Ticket] [uniqueidentifier] NOT NULL,
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[Name_Type] [varchar](255) NOT NULL,
	[GUID_Type_Parent] [uniqueidentifier] NULL,
	[IsParent] [bit] NOT NULL,
 CONSTRAINT [PK_chngtbl_Item_Type] PRIMARY KEY CLUSTERED 
(
	[GUID_Ticket] ASC,
	[GUID_Type] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Item_Type]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Item_Type_chngtbl_Ticket] FOREIGN KEY([GUID_Ticket])
REFERENCES [dbo].[chngtbl_Ticket] ([GUID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Item_Type] CHECK CONSTRAINT [FK_chngtbl_Item_Type_chngtbl_Ticket];

ALTER TABLE [dbo].[chngtbl_Item_Type] ADD  CONSTRAINT [DF_chngtbl_Item_Type_IsParent]  DEFAULT ((0)) FOR [IsParent];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Process_Last_Done]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Process_Last_Done]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Process-Last Done'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Logentry_Start]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Logentry_Start](
	[GUID_Ticket] [uniqueidentifier] NOT NULL,
	[GUID_LogEntry] [uniqueidentifier] NOT NULL,
	[dateTime_TimeStamp] [datetime] NOT NULL,
 CONSTRAINT [PK_chngtbl_Logentry_Start] PRIMARY KEY CLUSTERED 
(
	[GUID_Ticket] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Logentry_Start]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Logentry_Start_chngtbl_Ticket] FOREIGN KEY([GUID_Ticket])
REFERENCES [dbo].[chngtbl_Ticket] ([GUID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Logentry_Start] CHECK CONSTRAINT [FK_chngtbl_Logentry_Start_chngtbl_Ticket];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Datetime__To_Do_List_]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Datetime__To_Do_List_]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Datetime (To-Do-List)'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Language]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Language]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Language'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Item_Attribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Item_Attribute](
	[GUID_Ticket] [uniqueidentifier] NOT NULL,
	[GUID_Attribute] [uniqueidentifier] NOT NULL,
	[Name_Attribute] [varchar](255) NOT NULL,
 CONSTRAINT [PK_chngtbl_Item_Attribute] PRIMARY KEY CLUSTERED 
(
	[GUID_Ticket] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Item_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Item_Attribute_chngtbl_Ticket] FOREIGN KEY([GUID_Ticket])
REFERENCES [dbo].[chngtbl_Ticket] ([GUID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Item_Attribute] CHECK CONSTRAINT [FK_chngtbl_Item_Attribute_chngtbl_Ticket];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Standard]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Standard]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Standard'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Log]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Log] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Log		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Log, Name_Token AS Name_Log, GUID_Type AS GUID_Type_Log

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Log)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Startdate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Startdate]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Startdate'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Named_GUIDRelationType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_Named_GUIDRelationType]

(

	-- Add the parameters for the function here

	@Name_RelationType		varchar(255)

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType		uniqueidentifier



	SET @GUID_RelationType = (SELECT     GUID_RelationType

		FROM         semtbl_RelationType

		WHERE     (Name_RelationType = @Name_RelationType));

	RETURN @GUID_RelationType;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Log]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Log]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Log'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semfunc_ObjectReference]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'

-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE FUNCTION [dbo].[semfunc_ObjectReference]

(	

	-- Add the parameters for the function here

	

)

RETURNS @tmptbl_Token_Or TABLE 

(

	GUID_ObjectReference		uniqueidentifier,

	Name_Token					varchar(255),

	GUID_Ref					uniqueidentifier,

	GUID_ItemType				uniqueidentifier

)

AS

BEGIN

	DECLARE @GUID_OR_Type_Attribute uniqueidentifier;

	DECLARE @GUID_OR_Type_AttributeType uniqueidentifier;

	DECLARE @GUID_OR_Type_RelationType uniqueidentifier;

	DECLARE @GUID_OR_Type_Token uniqueidentifier;

	DECLARE @GUID_OR_Type_Token_Attribute_Bit uniqueidentifier;

	DECLARE @GUID_OR_Type_Token_Attribute_Date uniqueidentifier;

	DECLARE @GUID_OR_Type_Token_Attribute_Datetime uniqueidentifier;

	DECLARE @GUID_OR_Type_Token_Attribute_Int uniqueidentifier;

	DECLARE @GUID_OR_Type_Token_Attribute_Real uniqueidentifier;

	DECLARE @GUID_OR_Type_Token_Attribute_Time uniqueidentifier;

	DECLARE @GUID_OR_Type_Token_Attribute_VARCHAR255 uniqueidentifier;

	DECLARE @GUID_OR_Type_Token_Attribute_VARCHARMax uniqueidentifier;

	DECLARE @GUID_OR_Token_Token	uniqueidentifier;

	DECLARE @GUID_OR_Type			uniqueidentifier;

	DECLARE @GUID_OR_Type_Type_Attribute	uniqueidentifier;

	DECLARE @GUID_OR_Type_Type			uniqueidentifier;



	DECLARE @GUID_ObjectReference	uniqueidentifier;

	DECLARE @Name_Token				varchar(255);

	DECLARE @GUID_Ref				uniqueidentifier;

	DECLARE @GUID_ItemType			uniqueidentifier;

	

	SET @GUID_OR_Type_Attribute = (SELECT     GUID_ObjectReferenceType		

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Attribute''));

	SET @GUID_OR_Type_AttributeType = (SELECT     GUID_ObjectReferenceType

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''AttributeType''));

	SET @GUID_OR_Type_RelationType = (SELECT     GUID_ObjectReferenceType 

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''RelationType''));

	SET @GUID_OR_Type_Token = (SELECT     GUID_ObjectReferenceType 

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Token''));

	SET @GUID_OR_Type_Token_Attribute_Bit = (SELECT     GUID_ObjectReferenceType 

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Token-Attribute-Bit''));

	SET @GUID_OR_Type_Token_Attribute_Date = (SELECT     GUID_ObjectReferenceType 

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Token-Attribute-Date''));

	SET @GUID_OR_Type_Token_Attribute_Datetime = (SELECT     GUID_ObjectReferenceType

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Token-Attribute-Datetime''));

	SET @GUID_OR_Type_Token_Attribute_Int = (SELECT     GUID_ObjectReferenceType 

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Token-Attribute-Int''));

	SET @GUID_OR_Type_Token_Attribute_Real = (SELECT     GUID_ObjectReferenceType 

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Token-Attribute-Real''));

	SET @GUID_OR_Type_Token_Attribute_Time = (SELECT     GUID_ObjectReferenceType 

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Token-Attribute-Time''));

	SET @GUID_OR_Type_Token_Attribute_VARCHAR255 = (SELECT     GUID_ObjectReferenceType 

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Token-Attribute-Varchar255''));

	SET @GUID_OR_Type_Token_Attribute_VARCHARMAX = (SELECT     GUID_ObjectReferenceType

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Token-Attribute-VarcharMax''));

	SET @GUID_OR_Token_Token = (SELECT     GUID_ObjectReferenceType

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Token-Token''));

	SET @GUID_OR_Type = (SELECT     GUID_ObjectReferenceType

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Type''));

	SET @GUID_OR_Type_Type_Attribute = (SELECT     GUID_ObjectReferenceType 

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Type-Attribute''));

	SET @GUID_OR_Type_Type = (SELECT     GUID_ObjectReferenceType 

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Type-Type''));



	-- Attribute

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT  semtbl_OR_Attribute.GUID_ObjectReference, 

				semtbl_Attribute.GUID_Attribute, 

				semtbl_Attribute.Name_Attribute

			FROM         semtbl_OR_Attribute INNER JOIN

								  semtbl_Attribute ON semtbl_OR_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute;

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@GUID_Ref,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''Attribute: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_Ref,

			@GUID_OR_Type_Attribute)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@GUID_Ref,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;

	

	-- Attribute-Type

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT  semtbl_OR_AttributeType.GUID_ObjectReference, 

				semtbl_AttributeType.GUID_AttributeType, 

				semtbl_AttributeType.Name_AttributeType

			FROM         semtbl_OR_AttributeType INNER JOIN

                      semtbl_AttributeType ON semtbl_OR_AttributeType.GUID_AttributeType = semtbl_AttributeType.GUID_AttributeType

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@GUID_Ref,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''Attribute-Type: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_Ref,

			@GUID_OR_Type_AttributeType)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@GUID_Ref,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;



	-- RelationType

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT  semtbl_OR_RelationType.GUID_ObjectReference, 

				semtbl_RelationType.GUID_RelationType, 

				semtbl_RelationType.Name_RelationType

			FROM         semtbl_OR_RelationType INNER JOIN

                      semtbl_RelationType ON semtbl_OR_RelationType.GUID_RelationType = semtbl_RelationType.GUID_RelationType

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@GUID_Ref,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''RelationType: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_Ref,

			@GUID_OR_Type_RelationType)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@GUID_Ref,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;



	-- Token

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT  semtbl_OR_Token.GUID_ObjectReference, 

				semtbl_Token.GUID_Token, 

				semtbl_Token.Name_Token + ''\'' + semtbl_Type.Name_Type AS Name_Token_With_Type

			FROM         semtbl_OR_Token INNER JOIN

								  semtbl_Token ON semtbl_OR_Token.GUID_Token = semtbl_Token.GUID_Token INNER JOIN

								  semtbl_Type ON semtbl_Token.GUID_Type = semtbl_Type.GUID_Type

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@GUID_Ref,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''Token: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_Ref,

			@GUID_OR_Type_Token)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@GUID_Ref,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;



	-- Token-Attribute-Bit

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT  semtbl_OR_Token_Attribute_Bit.GUID_ObjectReference, semtbl_Token_Attribute.GUID_TokenAttribute, 

                      semtbl_Token.Name_Token + ''\'' + semtbl_Attribute.Name_Attribute AS Name_Ref

				FROM         semtbl_Token INNER JOIN

									  semtbl_Token_Attribute ON semtbl_Token.GUID_Token = semtbl_Token_Attribute.GUID_Token INNER JOIN

									  semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN

									  semtbl_OR_Token_Attribute_Bit ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_OR_Token_Attribute_Bit.GUID_TokenAttribute

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@GUID_Ref,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''Token-Attribute: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_Ref,

			@GUID_OR_Type_Token_Attribute_Bit)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@GUID_Ref,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;

	

	-- Token-Attribute-Date

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT     semtbl_OR_Token_Attribute_Date.GUID_ObjectReference, semtbl_Token_Attribute.GUID_TokenAttribute, 

                      semtbl_Token.Name_Token + ''\'' + semtbl_Attribute.Name_Attribute AS Name_Ref

FROM         semtbl_Token INNER JOIN

                      semtbl_Token_Attribute ON semtbl_Token.GUID_Token = semtbl_Token_Attribute.GUID_Token INNER JOIN

                      semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN

                      semtbl_OR_Token_Attribute_Date ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_OR_Token_Attribute_Date.GUID_TokenAttribute

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@GUID_Ref,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''Token-Attribute: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_Ref,

			@GUID_OR_Type_Token_Attribute_Date)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@GUID_Ref,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;

	

	-- Token-Attribute-Datetime

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT  semtbl_OR_Token_Attribute_Datetime.GUID_ObjectReference, 

				semtbl_Token_Attribute.GUID_TokenAttribute, 

                semtbl_Token.Name_Token + ''\'' + semtbl_Attribute.Name_Attribute AS Name_Ref

				FROM         semtbl_Token INNER JOIN

									  semtbl_Token_Attribute ON semtbl_Token.GUID_Token = semtbl_Token_Attribute.GUID_Token INNER JOIN

									  semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN

									  semtbl_OR_Token_Attribute_Datetime ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_OR_Token_Attribute_Datetime.GUID_TokenAttribute

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@GUID_Ref,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''Token-Attribute: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_Ref,

			@GUID_OR_Type_Token_Attribute_Datetime)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@GUID_Ref,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;

	

	-- Token-Attribute-Int

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT     semtbl_OR_Token_Attribute_Int.GUID_ObjectReference, semtbl_Token_Attribute.GUID_TokenAttribute, 

                      semtbl_Token.Name_Token + ''\'' + semtbl_Attribute.Name_Attribute AS Name_Ref

FROM         semtbl_Token INNER JOIN

                      semtbl_Token_Attribute ON semtbl_Token.GUID_Token = semtbl_Token_Attribute.GUID_Token INNER JOIN

                      semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN

                      semtbl_OR_Token_Attribute_Int ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_OR_Token_Attribute_Int.GUID_TokenAttribute

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@GUID_Ref,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''Token-Attribute: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_Ref,

			@GUID_OR_Type_Token_Attribute_Int)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@GUID_Ref,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;

	

	-- Token-Attribute-Real

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT     semtbl_OR_Token_Attribute_Real.GUID_ObjectReference, semtbl_Token_Attribute.GUID_TokenAttribute, 

                      semtbl_Token.Name_Token + ''\'' + semtbl_Attribute.Name_Attribute AS Name_Ref

FROM         semtbl_Token INNER JOIN

                      semtbl_Token_Attribute ON semtbl_Token.GUID_Token = semtbl_Token_Attribute.GUID_Token INNER JOIN

                      semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN

                      semtbl_OR_Token_Attribute_Real ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_OR_Token_Attribute_Real.GUID_TokenAttribute

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@GUID_Ref,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''Token-Attribute: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_Ref,

			@GUID_OR_Type_Token_Attribute_Real)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@GUID_Ref,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;

	

	-- Token-Attribute-Time

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT     semtbl_OR_Token_Attribute_Time.GUID_ObjectReference, semtbl_Token_Attribute.GUID_TokenAttribute, 

                      semtbl_Token.Name_Token + ''\'' + semtbl_Attribute.Name_Attribute AS Name_Ref

FROM         semtbl_Token INNER JOIN

                      semtbl_Token_Attribute ON semtbl_Token.GUID_Token = semtbl_Token_Attribute.GUID_Token INNER JOIN

                      semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN

                      semtbl_OR_Token_Attribute_Time ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_OR_Token_Attribute_Time.GUID_TokenAttribute

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@GUID_Ref,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''Token-Attribute: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_Ref,

			@GUID_OR_Type_Token_Attribute_Time)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@GUID_Ref,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;

	

	-- Token-Attribute-Varchar255

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT     semtbl_OR_Token_Attribute_Varchar255.GUID_ObjectReference, semtbl_Token_Attribute.GUID_TokenAttribute, 

                      semtbl_Token.Name_Token + ''\'' + semtbl_Attribute.Name_Attribute AS Name_Ref

FROM         semtbl_Token INNER JOIN

                      semtbl_Token_Attribute ON semtbl_Token.GUID_Token = semtbl_Token_Attribute.GUID_Token INNER JOIN

                      semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN

                      semtbl_OR_Token_Attribute_Varchar255 ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_OR_Token_Attribute_Varchar255.GUID_TokenAttribute

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@GUID_Ref,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''Token-Attribute: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_Ref,

			@GUID_OR_Type_Token_Attribute_VARCHAR255)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@GUID_Ref,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;

	

	-- Token-Attribute-VarcharMAX

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT     semtbl_OR_Token_Attribute_VARCHARMAX.GUID_ObjectReference, semtbl_Token_Attribute.GUID_TokenAttribute, 

                      semtbl_Token.Name_Token + ''\'' + semtbl_Attribute.Name_Attribute AS Name_Ref

FROM         semtbl_Token INNER JOIN

                      semtbl_Token_Attribute ON semtbl_Token.GUID_Token = semtbl_Token_Attribute.GUID_Token INNER JOIN

                      semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN

                      semtbl_OR_Token_Attribute_VARCHARMAX ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_OR_Token_Attribute_VARCHARMAX.GUID_TokenAttribute

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@GUID_Ref,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''Token-Attribute: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_Ref,

			@GUID_OR_Type_Token_Attribute_VARCHARMax)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@GUID_Ref,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;

	

	-- Token-Token

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT     semtbl_OR_Token_Token.GUID_ObjectReference, 

                      semtbl_Token.Name_Token + ''\'' + semtbl_Type.Name_Type + ''/'' + semtbl_RelationType.Name_RelationType + ''/'' + semtbl_Token_1.Name_Token + ''\'' + semtbl_Type_1.Name_Type

                       AS Name_Ref

			FROM         semtbl_Token AS semtbl_Token_1 INNER JOIN

                      semtbl_Token INNER JOIN

                      semtbl_RelationType INNER JOIN

                      semtbl_OR_Token_Token ON semtbl_RelationType.GUID_RelationType = semtbl_OR_Token_Token.GUID_RelationType ON 

                      semtbl_Token.GUID_Token = semtbl_OR_Token_Token.GUID_Token_Left ON semtbl_Token_1.GUID_Token = semtbl_OR_Token_Token.GUID_Token_Right INNER JOIN

                      semtbl_Type ON semtbl_Token.GUID_Type = semtbl_Type.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_1 ON semtbl_Token_1.GUID_Type = semtbl_Type_1.GUID_Type

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''Token-Token: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or (GUID_ObjectReference,Name_Token,GUID_ItemType)VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_OR_Token_Token)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;

	-- Type

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT     semtbl_OR_Type.GUID_ObjectReference, semtbl_Type.GUID_Type, semtbl_Type.Name_Type

FROM         semtbl_OR_Type INNER JOIN

                      semtbl_Type ON semtbl_OR_Type.GUID_Type = semtbl_Type.GUID_Type

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@GUID_Ref,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''Type: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_Ref,

			@GUID_OR_Type)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@GUID_Ref,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;



	-- Type-Attribute

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT     semtbl_OR_Type_Attribute.GUID_ObjectReference, semtbl_Type.Name_Type + ''\[Name_Attribute]'' AS Name_Ref

FROM         semtbl_OR_Type_Attribute INNER JOIN

                      semtbl_Type ON semtbl_OR_Type_Attribute.GUID_Type = semtbl_Type.GUID_Type INNER JOIN

                      semtbl_Attribute ON semtbl_OR_Type_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''Type-Attribute: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or (GUID_ObjectReference,Name_Token,GUID_ItemType)VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_OR_Type_Type_Attribute)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;



	-- Type-Type

	DECLARE cur_ObjectReference CURSOR FOR

		SELECT   semtbl_OR_Type_Type.GUID_ObjectReference, 

                 semtbl_Type.Name_Type + ''/'' + semtbl_RelationType.Name_RelationType + semtbl_Type_1.Name_Type AS Name_Ref

			FROM         semtbl_Type INNER JOIN

                      semtbl_RelationType INNER JOIN

                      semtbl_OR_Type_Type ON semtbl_RelationType.GUID_RelationType = semtbl_OR_Type_Type.GUID_RelationType INNER JOIN

                      semtbl_Type AS semtbl_Type_1 ON semtbl_OR_Type_Type.GUID_Type_Right = semtbl_Type_1.GUID_Type ON 

                      semtbl_Type.GUID_Type = semtbl_OR_Type_Type.GUID_Type_Left

	OPEN cur_ObjectReference;

	FETCH NEXT FROM cur_ObjectReference INTO

		@GUID_ObjectReference,

		@Name_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @Name_Token = ''Type-Attribute: '' + @Name_Token;

		

		INSERT INTO @tmptbl_Token_Or (GUID_ObjectReference,Name_Token,GUID_ItemType)VALUES(

			@GUID_ObjectReference,

			@Name_Token,

			@GUID_OR_Type_Type)

			

		FETCH NEXT FROM cur_ObjectReference INTO

			@GUID_ObjectReference,

			@Name_Token;

	END

	CLOSE cur_ObjectReference;

	DEALLOCATE cur_ObjectReference;

	RETURN

END




'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Feiertage]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Feiertage]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Feiertage'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Logentry]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Logentry] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Logentry		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Logentry, Name_Token AS Name_Logentry, GUID_Type AS GUID_Type_Logentry

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Logentry)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Message]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Message]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Message'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Item_belongsTo]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Item_belongsTo](
	[GUID_Ticket] [uniqueidentifier] NOT NULL,
	[GUID_Item_belongsTo] [uniqueidentifier] NOT NULL,
	[Name_Item_belongsTo] [varchar](255) NOT NULL,
	[GUID_ItemType_belongsTo] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chgtbl_Item_belongsTo] PRIMARY KEY CLUSTERED 
(
	[GUID_Ticket] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Item_belongsTo]  WITH CHECK ADD  CONSTRAINT [FK_chgtbl_Item_belongsTo_chngtbl_Ticket] FOREIGN KEY([GUID_Ticket])
REFERENCES [dbo].[chngtbl_Ticket] ([GUID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Item_belongsTo] CHECK CONSTRAINT [FK_chgtbl_Item_belongsTo_chngtbl_Ticket];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Process_Ticket]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Process_Ticket] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Process_Ticket		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Process_Ticket, Name_Token AS Name_Process_Ticket, GUID_Type AS GUID_Type_Process_Ticket

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Process_Ticket)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_obligatory]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_obligatory]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''obligatory'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_System]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_System] 

(	

	-- Add the parameters for the function here

	@GUID_Type_System		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_System, Name_Token AS Name_System, GUID_Type AS GUID_Type_System

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_System)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Language]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Language] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Language		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Language, Name_Token AS Name_Language, GUID_Type AS GUID_Type_Language

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Language)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_User_Work_Config]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_User_Work_Config] 

(	

	-- Add the parameters for the function here

	@GUID_Type_User_Work_Config		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_User_Work_Config, Name_Token AS Name_User_Work_Config, GUID_Type AS GUID_Type_User_Work_Config

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_User_Work_Config)

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_correlated_Process_Ticket_Creation]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_correlated_Process_Ticket_Creation]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''correlated Process-Ticket-Creation'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_Done]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_Done]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''belonging Done'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Process]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Process](
	[GUID_Ticket] [uniqueidentifier] NOT NULL,
	[GUID_Process] [uniqueidentifier] NOT NULL,
	[Name_Process] [varchar](255) NOT NULL,
 CONSTRAINT [PK_chngtbl_Process] PRIMARY KEY CLUSTERED 
(
	[GUID_Ticket] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Process]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Process_chngtbl_Ticket] FOREIGN KEY([GUID_Ticket])
REFERENCES [dbo].[chngtbl_Ticket] ([GUID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Process] CHECK CONSTRAINT [FK_chngtbl_Process_chngtbl_Ticket];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Process_Management]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Process_Management] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Process_Management		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Process_Management, Name_Token AS Name_Process_Management, GUID_Type AS GUID_Type_Process_Management

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Process_Management)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Hours]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Hours]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Hours'';

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_user]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_user]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''user'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_DateTimeStamp]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_DateTimestamp]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''DateTimestamp'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_user]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_user]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''user'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_ID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_ID]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''ID'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_Time_Measuring]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_Time_Measuring]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''Time-Measuring'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Language]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Language]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Language'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Public]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Public]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Public'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Time_Period]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Time_Period] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Time_Period		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Time_Period, Name_Token AS Name_Time_Period, GUID_Type AS GUID_Type_Time_Period

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Time_Period)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_needs]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_needs]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''needs'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_finished_with]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_finished_with]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''finished with'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Process_Last_Done]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Process_Last_Done] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Process_Last_Done		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Process_Last_Done, Name_Token AS Name_Process_Last_Done, GUID_Type AS GUID_Type_Process_Last_Done

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Process_Last_Done)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_started_with]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_started_with]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''started with'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Language]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Language]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Language'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Work_Day]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Work_Day] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Work_Day		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Work_Day, Name_Token AS Name_Work_Day, GUID_Type AS GUID_Type_Work_Day

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Work_Day)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_is_in_State]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_is_in_State]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''is in State'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Incident]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Incident] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Incident		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Incident, Name_Token AS Name_Incident, GUID_Type AS GUID_Type_Incident

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Incident)

)
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Ort]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Ort]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Ort'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Log_Management]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Log_Management]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Log-Management'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_correlation_Done]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_correlation_Done]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''correlation Done'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_validity_period]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_validity_period]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''belonging validity-period'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Logentry]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Logentry]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Logentry'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_User_Work_Config]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_User_Work_Config]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''User-Work-Config'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_User_Of_Ticket]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_User_Of_Ticket](
	[GUID_Ticket] [uniqueidentifier] NOT NULL,
	[GUID_User] [uniqueidentifier] NOT NULL,
	[Name_User] [varchar](255) NOT NULL,
 CONSTRAINT [PK_chngtbl_User_Of_Ticket] PRIMARY KEY CLUSTERED 
(
	[GUID_Ticket] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_User_Of_Ticket]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_User_Of_Ticket_chngtbl_Ticket] FOREIGN KEY([GUID_Ticket])
REFERENCES [dbo].[chngtbl_Ticket] ([GUID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_User_Of_Ticket] CHECK CONSTRAINT [FK_chngtbl_User_Of_Ticket_chngtbl_Ticket];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TicketList_Of_Tickets]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_TicketList_Of_Tickets]

	-- Add the parameters for the stored procedure here

	@GUID_Group			uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT chngtbl_TicketList.GUID_TicketList, chngtbl_TicketList.Name_TicketList, chngtbl_TicketList.GUID_TicketList_Parent, 

                      chngtbl_TicketList.EndStamp, chngtbl_TicketList.StartStamp, GUID_Group

FROM         chngtbl_TicketList 

WHERE     (chngtbl_TicketList.GUID_Group = @GUID_Group)

END
'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Language]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Language] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Language		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Language, Name_Token AS Name_Language, GUID_Type AS GUID_Type_Language

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Language)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Process]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Process] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Process		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Process, Name_Token AS Name_Process, GUID_Type AS GUID_Type_Process

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Process)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_is_described_by]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_is_described_by]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''is described by'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Logentry_LastDone]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Logentry_LastDone](
	[GUID_Ticket] [uniqueidentifier] NOT NULL,
	[GUID_LogEntry_LastDone] [uniqueidentifier] NOT NULL,
	[Val_LogEntry_LastDone] [datetime] NOT NULL,
	[Msg_LogEntry_LastDone] [varchar](255) NOT NULL,
	[GUID_LogState_LastDone] [uniqueidentifier] NOT NULL,
	[Name_LogState_LastDone] [varchar](255) NOT NULL,
 CONSTRAINT [PK_chngtbl_Logentry_LastDone] PRIMARY KEY CLUSTERED 
(
	[GUID_Ticket] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Logentry_LastDone]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Logentry_LastDone_chngtbl_Ticket] FOREIGN KEY([GUID_Ticket])
REFERENCES [dbo].[chngtbl_Ticket] ([GUID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Logentry_LastDone] CHECK CONSTRAINT [FK_chngtbl_Logentry_LastDone_chngtbl_Ticket];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_was_created_by]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_was_created_by]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''was created by'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Description]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Description]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Description'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Process_Log]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Process_Log] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Process_Log		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Process_Log, Name_Token AS Name_Process_Log, GUID_Type AS GUID_Type_Process_Log

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Process_Log)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_DateTimeStamp]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_DateTimestamp]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''DateTimestamp'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Ort]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Ort] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Ort		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Ort, Name_Token AS Name_Ort, GUID_Type AS GUID_Type_Ort

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Ort)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_was_created_by]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_was_created_by]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''was created by'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Time_Period]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Time_Period]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Time-Period'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Logentry_FinishedWith]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Logentry_FinishedWith](
	[GUID_Ticket] [uniqueidentifier] NOT NULL,
	[GUID_LogEntry] [uniqueidentifier] NOT NULL,
	[dateTime_TimeStamp] [datetime] NOT NULL,
	[GUID_LogState] [uniqueidentifier] NOT NULL,
	[Name_LogState] [varchar](255) NOT NULL,
 CONSTRAINT [PK_chngtbl_FinishedWith] PRIMARY KEY CLUSTERED 
(
	[GUID_Ticket] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Logentry_FinishedWith]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_FinishedWith_chngtbl_Ticket] FOREIGN KEY([GUID_Ticket])
REFERENCES [dbo].[chngtbl_Ticket] ([GUID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Logentry_FinishedWith] CHECK CONSTRAINT [FK_chngtbl_FinishedWith_chngtbl_Ticket];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Enddate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Enddate]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Enddate'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_Attribute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_Attribute]

(

	-- Add the parameters for the function here

	@strGUID_ObjectReferenceType	uniqueidentifier

)

RETURNS bit

AS

BEGIN

	-- Declare the return variable here

	DECLARE @strGUID_Token_ObjectReferenceType	uniqueidentifier;

	DECLARE @bitResult							bit;



	SET @bitResult = 0;



	-- Add the T-SQL statements to compute the return value here

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT GUID_Token FROM semtbl_Token WHERE GUID_Type=dbo.func_TypeGUID_ObjectReferenceType() AND Name_Token=''Attribute'');



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_needs]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_needs]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''needs'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_LCID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_LCID]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''LCID'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_started_with]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_started_with]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''started with'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_is_described_by]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_is_described_by]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''is described by'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Process_Ticket_Lists]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Process_Ticket_Lists] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Process_Ticket_Lists		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Process_Ticket_Lists, Name_Token AS Name_Process_Ticket_Lists, GUID_Type AS GUID_Type_Process_Ticket_Lists

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Process_Ticket_Lists)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_defines]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_defines]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''defines'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_ID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_ID]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''ID'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Language]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Language] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Language		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Language, Name_Token AS Name_Language, GUID_Type AS GUID_Type_Language

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Language)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Logentry]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Logentry]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Logentry'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Datetime_ToDoList]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Datetime_ToDoList](
	[GUID_Ticket] [uniqueidentifier] NOT NULL,
	[DateTimeToDoList] [datetime] NOT NULL,
 CONSTRAINT [PK_chngtbl_Datetime_ToDoList] PRIMARY KEY CLUSTERED 
(
	[GUID_Ticket] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Datetime_ToDoList]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Datetime_ToDoList_chngtbl_Ticket] FOREIGN KEY([GUID_Ticket])
REFERENCES [dbo].[chngtbl_Ticket] ([GUID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Datetime_ToDoList] CHECK CONSTRAINT [FK_chngtbl_Datetime_ToDoList_chngtbl_Ticket];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Message]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Message]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Message'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Item_RelationType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Item_RelationType](
	[GUID_Ticket] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[Name_RelationType] [varchar](255) NOT NULL,
 CONSTRAINT [PK_chngtbl_Item_RelationType] PRIMARY KEY CLUSTERED 
(
	[GUID_Ticket] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Item_RelationType]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Item_RelationType_chngtbl_Ticket] FOREIGN KEY([GUID_Ticket])
REFERENCES [dbo].[chngtbl_Ticket] ([GUID_Ticket])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Item_RelationType] CHECK CONSTRAINT [FK_chngtbl_Item_RelationType_chngtbl_Ticket];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Short]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Short]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Short'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_needs]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_needs]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''needs'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Named_GUIDAttribute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_Named_GUIDAttribute]

(

	-- Add the parameters for the function here

	@Name_Attribute		varchar(255)

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_Attribute		uniqueidentifier



	SET @GUID_Attribute = (SELECT     GUID_Attribute

		FROM         semtbl_Attribute

		WHERE     (Name_Attribute = @Name_Attribute));

	RETURN @GUID_Attribute;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Logstate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Logstate]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Logstate'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_State_Of_ProcessLog_By_GUIDState]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_State_Of_ProcessLog_By_GUIDState]

	-- Add the parameters for the stored procedure here

	@GUID_Type_LogEntry				uniqueidentifier,

	@GUID_Type_LogState				uniqueidentifier,

	@GUID_RelationType_provides		uniqueidentifier,

	@GUID_RelationType_finishedWith	uniqueidentifier,

	@GUID_LogState					uniqueidentifier,

	@GUID_ProcessLog				uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     func_Token_Logstate_1.GUID_Logstate, func_Token_Logstate_1.Name_Logstate, func_Token_Logstate_1.GUID_Type_Logstate

FROM         dbo.func_Token_Logentry(@GUID_Type_LogEntry) AS func_Token_Logentry_1 INNER JOIN

                      semtbl_Token_Token AS ProcessLog_To_LogEntry ON func_Token_Logentry_1.GUID_Logentry = ProcessLog_To_LogEntry.GUID_Token_Right INNER JOIN

                      semtbl_Token_Token AS LogEntry_To_LogState ON func_Token_Logentry_1.GUID_Logentry = LogEntry_To_LogState.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Logstate(@GUID_Type_LogState) AS func_Token_Logstate_1 ON 

                      LogEntry_To_LogState.GUID_Token_Right = func_Token_Logstate_1.GUID_Logstate

WHERE     (ProcessLog_To_LogEntry.GUID_RelationType = @GUID_RelationType_finishedWith) AND 

                      (LogEntry_To_LogState.GUID_RelationType = @GUID_RelationType_provides) AND (ProcessLog_To_LogEntry.GUID_Token_Left = @GUID_ProcessLog) AND 

                      (func_Token_Logstate_1.GUID_Logstate = @GUID_LogState)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[orgview_Item_Attribute]'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE VIEW dbo.orgview_Item_Attribute

AS

SELECT     dbo.chngtbl_Item_Attribute.GUID_Ticket, dbo.chngtbl_Item_Attribute.GUID_Attribute, dbo.chngtbl_Item_Attribute.Name_Attribute, 

                      dbo.chngtbl_Logentry_FinishedWith.GUID_LogState

FROM         dbo.chngtbl_Item_Attribute LEFT OUTER JOIN

                      dbo.chngtbl_Logentry_FinishedWith ON dbo.chngtbl_Item_Attribute.GUID_Ticket = dbo.chngtbl_Logentry_FinishedWith.GUID_Ticket
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Create_TicketLists]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Create_TicketLists] 

	-- Add the parameters for the stored procedure here

	 @GUID_Attribute_Standard		uniqueidentifier

	,@GUID_Attribute_Startdate		uniqueidentifier

	,@GUID_Attribute_Enddate		uniqueidentifier

	,@GUID_Type_TicketList			uniqueidentifier

	,@GUID_Type_ProcessTickets		uniqueidentifier

	,@GUID_Type_Group				uniqueidentifier

	,@GUID_RelationType_Contains	uniqueidentifier

	,@GUID_RelationType_belongsTo   uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

    	



		DECLARE @tmp_TicketLists TABLE

	(

		 GUID_Ticket_List		uniqueidentifier

		,Name_Ticket_List		varchar(255)

		,StartStamp				datetime

		,EndStamp				datetime

	)



	

	INSERT INTO @tmp_TicketLists (GUID_Ticket_List, Name_Ticket_List)

	SELECT	 tl.GUID_Process_Ticket_Lists

			,tl.Name_Process_Ticket_Lists

	FROM dbo.func_Token_Process_Ticket_Lists(@GUID_Type_TicketList) tl

	INNER JOIN semtbl_Token_Attribute ON semtbl_Token_Attribute.GUID_Token = tl.GUID_Process_Ticket_Lists

	INNER JOIN semtbl_Token_Attribute_Bit ON semtbl_Token_Attribute_Bit.GUID_TokenAttribute = semtbl_Token_Attribute.GUID_TokenAttribute

	WHERE semtbl_Token_Attribute.GUID_Attribute = @GUID_Attribute_Standard

	AND semtbl_Token_Attribute_Bit.Val = 0



	UPDATE tl

	SET StartStamp = semtbl_Token_Attribute_DateTime.Val

	FROM @tmp_TicketLists tl

	INNER JOIN semtbl_Token_Attribute ON tl.GUID_Ticket_List = semtbl_Token_Attribute.GUID_Token

	INNER JOIN semtbl_Token_Attribute_DateTime ON semtbl_Token_Attribute_DateTime.GUID_TokenAttribute = semtbl_Token_Attribute.GUID_TokenAttribute

	WHERE semtbl_Token_Attribute.GUID_Attribute = @GUID_Attribute_Startdate

	

	UPDATE tl

	SET StartStamp = semtbl_Token_Attribute_DateTime.Val

	FROM @tmp_TicketLists tl

	INNER JOIN semtbl_Token_Attribute ON tl.GUID_Ticket_List = semtbl_Token_Attribute.GUID_Token

	INNER JOIN semtbl_Token_Attribute_DateTime ON semtbl_Token_Attribute_DateTime.GUID_TokenAttribute = semtbl_Token_Attribute.GUID_TokenAttribute

	WHERE semtbl_Token_Attribute.GUID_Attribute = @GUID_Attribute_EndDate

	

	DELETE FROM dbo.chngtbl_TicketList



	;WITH hierarchy AS (	

		SELECT	DISTINCT 

				 tl_c.GUID_Ticket_List AS GUID_Ticket_List

				,tl_c.Name_Ticket_List AS Name_Ticket_List

				,tl_p.GUID_Ticket_List AS GUID_Ticket_List_Parent

				,tl_c.StartStamp

				,tl_c.EndStamp

		FROM @tmp_TicketLists tl_c

		LEFT OUTER JOIN semtbl_Token_Token ON semtbl_Token_Token.GUID_Token_Right = tl_c.GUID_Ticket_List AND semtbl_Token_Token.GUID_RelationType = ''e9711603-47db-44d8-a476-fe88290639a4''

		LEFT OUTER JOIN @tmp_TicketLists tl_p ON semtbl_Token_Token.GUID_Token_Left =  tl_p.GUID_Ticket_List

		WHERE tl_p.GUID_Ticket_List IS NULL



		UNION ALL

		

		SELECT	 tl_c.GUID_Ticket_List

				,tl_c.Name_Ticket_List

				,p.GUID_Ticket_List_Parent

				,tl_c.StartStamp

				,tl_c.EndStamp

		FROM hierarchy p

		INNER JOIN semtbl_Token_Token ON p.GUID_Ticket_List_Parent = semtbl_Token_Token.GUID_Token_Left AND semtbl_Token_Token.GUID_RelationType = ''e9711603-47db-44d8-a476-fe88290639a4''

		INNER JOIN @tmp_TicketLists tl_c ON semtbl_Token_Token.GUID_Token_Right = tl_c.GUID_Ticket_List)

		

		INSERT INTO chngtbl_TicketList

		SELECT   GUID_Ticket_List

				,Name_Ticket_List

				,GUID_Ticket_List_Parent

				,StartStamp

				,EndStamp 

				,grp.GUID_Group

		FROM hierarchy

		INNER JOIN semtbl_Token_Token ListGroup ON ListGroup.GUID_Token_left = hierarchy.GUID_Ticket_List AND GUID_RelationType = @GUID_RelationType_belongsTo

		INNER JOIN dbo.func_Token_Group(@GUID_Type_Group) grp ON grp.GUID_Group = ListGroup.GUID_Token_Right 

			

	INSERT INTO chngtbl_Ticket_TicketList

	SELECT GUID_Token_Left, GUID_Token_Right, semtbl_Token_Token.OrderID

	FROM chngtbl_TicketList

	INNER JOIN semtbl_Token_Token ON chngtbl_TicketList.GUID_TicketList = semtbl_Token_Token.GUID_Token_Left

	INNER JOIN dbo.func_Token_Process_Ticket(@GUID_Type_ProcessTickets) t ON semtbl_Token_Token.GUID_Token_Right = t.GUID_Process_Ticket

	WHERE GUID_RelationType = @GUID_RelationType_contains

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Logentries_Of_ProcessLog]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Logentries_Of_ProcessLog]

	-- Add the parameters for the stored procedure here

	

	@GUID_Attribute_DateTimeStamp		uniqueidentifier,

	@GUID_Attribute_Message				uniqueidentifier,

	@GUID_Type_Logentry					uniqueidentifier,

	@GUID_Type_LogState					uniqueidentifier,

	@GUID_Type_Log						uniqueidentifier,

	@GUID_RelationType_belongingDone	uniqueidentifier,

	@GUID_RelationType_provides			uniqueidentifier,

	@GUID_RelationType_TimeMeasuring	uniqueidentifier,

	@GUID_RelationType_contains			uniqueidentifier,

	@GUID_ProcessLog					uniqueidentifier

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	

	

	

	DECLARE @tmptbl_Logentries TABLE

	(

		GUID_Logentry						uniqueidentifier,

		Name_Logentry						varchar(255),

		GUID_Type_Logentry					uniqueidentifier,

		GUID_TokenAttribute_DateTimeStamp	uniqueidentifier,

		DateTimeStamp						datetime,

		GUID_Logstate						uniqueidentifier,

		Name_Logstate						varchar(255),

		GUID_Type_Logstate					uniqueidentifier,

		GUID_TokenAttribute_Message			uniqueidentifier,

		Message								varchar(Max)

	)

    -- Insert statements for procedure here

    INSERT INTO @tmptbl_Logentries

	SELECT  func_Token_Logentry_1.GUID_Logentry, 

			func_Token_Logentry_1.Name_Logentry, 

			func_Token_Logentry_1.GUID_Type_Logentry, 

            Logentry__DateTimeStamp_Val.GUID_TokenAttribute AS GUID_TokenAttribute_DateTimeStamp, 

            Logentry__DateTimeStamp_Val.val AS DateTimeStamp, 

            func_Token_Logstate_1.GUID_Logstate, 

            func_Token_Logstate_1.Name_Logstate, 

            func_Token_Logstate_1.GUID_Type_Logstate, 

			Logentry__Message_Val.GUID_TokenAttribute AS GUID_TokenAttribute_Message, 

			Logentry__Message_Val.val AS Message

		FROM         dbo.func_Token_Logentry(@GUID_Type_Logentry) AS func_Token_Logentry_1 INNER JOIN

							  semtbl_Token_Token AS ProcessLog_To_LogEntry ON func_Token_Logentry_1.GUID_Logentry = ProcessLog_To_LogEntry.GUID_Token_Right INNER JOIN

							  semtbl_Token_Attribute AS Logentry__DateTimeStamp ON func_Token_Logentry_1.GUID_Logentry = Logentry__DateTimeStamp.GUID_Token INNER JOIN

							  semtbl_Token_attribute_datetime AS Logentry__DateTimeStamp_Val ON 

							  Logentry__DateTimeStamp.GUID_TokenAttribute = Logentry__DateTimeStamp_Val.GUID_TokenAttribute INNER JOIN

							  semtbl_Token_Token AS Logentry_To_LogState ON func_Token_Logentry_1.GUID_Logentry = Logentry_To_LogState.GUID_Token_Left INNER JOIN

							  dbo.func_Token_Logstate(@GUID_Type_LogState) AS func_Token_Logstate_1 ON 

							  Logentry_To_LogState.GUID_Token_Right = func_Token_Logstate_1.GUID_Logstate INNER JOIN

							  semtbl_Token_Attribute AS LogEntry__Message ON func_Token_Logentry_1.GUID_Logentry = LogEntry__Message.GUID_Token INNER JOIN

							  semtbl_Token_Attribute_varcharMAX AS Logentry__Message_Val ON 

							  LogEntry__Message.GUID_TokenAttribute = Logentry__Message_Val.GUID_TokenAttribute

		WHERE     (ProcessLog_To_LogEntry.GUID_RelationType = @GUID_RelationType_belongingDone) AND (ProcessLog_To_LogEntry.GUID_Token_Left = @GUID_ProcessLog) AND

							   (Logentry__DateTimeStamp.GUID_Attribute = @GUID_Attribute_DateTimeStamp) AND (Logentry_To_LogState.GUID_RelationType = @GUID_RelationType_provides) 

							  AND (LogEntry__Message.GUID_Attribute = @GUID_Attribute_Message)

		

		

	INSERT INTO @tmptbl_Logentries

	SELECT     func_Token_Logentry_1.GUID_Logentry, func_Token_Logentry_1.Name_Logentry, func_Token_Logentry_1.GUID_Type_Logentry, 

                      Logentry__DateTimeStamp_Val.GUID_TokenAttribute AS GUID_TokenAttribute_DateTimeStamp, Logentry__DateTimeStamp_Val.val AS DateTimeStamp, 

                      func_Token_Logstate_1.GUID_Logstate, func_Token_Logstate_1.Name_Logstate, func_Token_Logstate_1.GUID_Type_Logstate, 

                      Logentry__Message_Val.GUID_TokenAttribute AS GUID_TokenAttribute_Message, Logentry__Message_Val.val AS Message

		FROM         dbo.func_Token_Logentry(@GUID_Type_Logentry) AS func_Token_Logentry_1 INNER JOIN

							  semtbl_Token_Token AS Log_To_LogEntry ON func_Token_Logentry_1.GUID_Logentry = Log_To_LogEntry.GUID_Token_Right INNER JOIN

							  semtbl_Token_Attribute AS Logentry__DateTimeStamp ON func_Token_Logentry_1.GUID_Logentry = Logentry__DateTimeStamp.GUID_Token INNER JOIN

							  semtbl_Token_attribute_datetime AS Logentry__DateTimeStamp_Val ON 

							  Logentry__DateTimeStamp.GUID_TokenAttribute = Logentry__DateTimeStamp_Val.GUID_TokenAttribute INNER JOIN

							  semtbl_Token_Token AS Logentry_To_LogState ON func_Token_Logentry_1.GUID_Logentry = Logentry_To_LogState.GUID_Token_Left INNER JOIN

							  dbo.func_Token_Logstate(@GUID_Type_LogState) AS func_Token_Logstate_1 ON 

							  Logentry_To_LogState.GUID_Token_Right = func_Token_Logstate_1.GUID_Logstate INNER JOIN

							  semtbl_Token_Attribute AS LogEntry__Message ON func_Token_Logentry_1.GUID_Logentry = LogEntry__Message.GUID_Token INNER JOIN

							  semtbl_Token_Attribute_varcharMAX AS Logentry__Message_Val ON 

							  LogEntry__Message.GUID_TokenAttribute = Logentry__Message_Val.GUID_TokenAttribute INNER JOIN

							  dbo.func_Token_Log(@GUID_Type_Log) AS func_Token_Log_1 ON Log_To_LogEntry.GUID_Token_Left = func_Token_Log_1.GUID_Log INNER JOIN

							  semtbl_Token_Token AS ProcessLog_To_Log ON func_Token_Log_1.GUID_Log = ProcessLog_To_Log.GUID_Token_Right

		WHERE     (Log_To_LogEntry.GUID_RelationType = @GUID_RelationType_contains) AND (Logentry__DateTimeStamp.GUID_Attribute = @GUID_Attribute_DateTimeStamp) AND 

							  (Logentry_To_LogState.GUID_RelationType = @GUID_RelationType_provides) AND (LogEntry__Message.GUID_Attribute = @GUID_Attribute_Message) AND 

							  (ProcessLog_To_Log.GUID_RelationType = @GUID_RelationType_TimeMeasuring) AND (ProcessLog_To_Log.GUID_Token_Left = @GUID_ProcessLog)

	SELECT * FROM @tmptbl_Logentries

	ORDER BY DateTimeStamp DESC

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_ProcessLog_Of_Process_And_Ticket]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_ProcessLog_Of_Process_And_Ticket]

	-- Add the parameters for the stored procedure here

	

	@GUID_Process					uniqueidentifier,	

	@GUID_Ticket					uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Type_ProcessLog			uniqueidentifier;

	DECLARE @GUID_RelationType_contains		uniqueidentifier;

	DECLARE @GUID_RelationType_belongsTo	uniqueidentifier;

	

	SET @GUID_Type_ProcessLog			= dbo.dbg_Type_Process_Log();

	SET @GUID_RelationType_contains		= dbo.dbg_RelationType_contains();

	SET @GUID_RelationType_belongsTo	= dbo.dbg_RelationType_belongs_to();

		

	PRINT @GUID_Type_ProcessLog;

	PRINT @GUID_RelationType_contains;

	PRINT @GUID_RelationType_belongsTo;

	

    -- Insert statements for procedure here

	SELECT     func_Token_Process_Log_1.GUID_Process_Log, func_Token_Process_Log_1.Name_Process_Log, func_Token_Process_Log_1.GUID_Type_Process_Log

FROM         dbo.func_Token_Process_Log(@GUID_Type_ProcessLog) AS func_Token_Process_Log_1 INNER JOIN

                      semtbl_Token_Token AS Ticket_To_ProcessLog ON func_Token_Process_Log_1.GUID_Process_Log = Ticket_To_ProcessLog.GUID_Token_Right INNER JOIN

                      semtbl_Token_Token AS ProcessLog_To_Process ON func_Token_Process_Log_1.GUID_Process_Log = ProcessLog_To_Process.GUID_Token_Left

WHERE     (Ticket_To_ProcessLog.GUID_Token_Left = @GUID_Ticket) AND (Ticket_To_ProcessLog.GUID_RelationType = @GUID_RelationType_contains) AND 

                      (ProcessLog_To_Process.GUID_Token_Right = @GUID_Process) AND (ProcessLog_To_Process.GUID_RelationType = @GUID_RelationType_belongsTo)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ProcessLog_Of_Process_And_Ticket]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_ProcessLog_Of_Process_And_Ticket]

	-- Add the parameters for the stored procedure here

	@GUID_Type_ProcessLog			uniqueidentifier,

	@GUID_RelationType_contains		uniqueidentifier,

	@GUID_RelationType_belongsTo	uniqueidentifier,

	@GUID_Process					uniqueidentifier,	

	@GUID_Ticket					uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     func_Token_Process_Log_1.GUID_Process_Log, func_Token_Process_Log_1.Name_Process_Log, func_Token_Process_Log_1.GUID_Type_Process_Log

FROM         dbo.func_Token_Process_Log(@GUID_Type_ProcessLog) AS func_Token_Process_Log_1 INNER JOIN

                      semtbl_Token_Token AS Ticket_To_ProcessLog ON func_Token_Process_Log_1.GUID_Process_Log = Ticket_To_ProcessLog.GUID_Token_Right INNER JOIN

                      semtbl_Token_Token AS ProcessLog_To_Process ON func_Token_Process_Log_1.GUID_Process_Log = ProcessLog_To_Process.GUID_Token_Left

WHERE     (Ticket_To_ProcessLog.GUID_Token_Left = @GUID_Ticket) AND (Ticket_To_ProcessLog.GUID_RelationType = @GUID_RelationType_contains) AND 

                      (ProcessLog_To_Process.GUID_Token_Right = @GUID_Process) AND (ProcessLog_To_Process.GUID_RelationType = @GUID_RelationType_belongsTo)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_ProcessItem_LastDone]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_ProcessItem_LastDone] 

	-- Add the parameters for the stored procedure here

	

	@GUID_ProcessItem			uniqueidentifier,

	@GUID_Ticket				uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	

	DECLARE @GUID_Type_ProcessTicket	uniqueidentifier;

	DECLARE @GUID_Type_ProcessLastDone	uniqueidentifier;

	DECLARE @GUID_RelationType_LastDone	uniqueidentifier;

	

	SET @GUID_Type_ProcessTicket	= dbo.dbg_Type_Process_Ticket();

	SET @GUID_Type_ProcessLastDone	= dbo.dbg_Type_Process_Last_Done();

	SET @GUID_RelationType_LastDone	= dbo.dbg_RelationType_Last_Done();

	

	PRINT @GUID_Type_ProcessTicket;

	PRINT @GUID_Type_ProcessLastDone;

	PRINT @GUID_RelationType_LastDone;



    -- Insert statements for procedure here

	SELECT     func_Token_Process_Last_Done_1.GUID_Process_Last_Done, func_Token_Process_Last_Done_1.Name_Process_Last_Done, 

                      func_Token_Process_Last_Done_1.GUID_Type_Process_Last_Done, ProcessLastDone_To_IncidentOrProcess.GUID_RelationType, 

                      ProcessTicket_To_ProcessLastDone.OrderID

FROM         semtbl_Token_Token AS ProcessTicket_To_ProcessLastDone INNER JOIN

                      dbo.func_Token_Process_Ticket(@GUID_Type_ProcessTicket) AS func_Token_Process_Ticket_1 ON 

                      ProcessTicket_To_ProcessLastDone.GUID_Token_Left = func_Token_Process_Ticket_1.GUID_Process_Ticket INNER JOIN

                      dbo.func_Token_Process_Last_Done(@GUID_Type_ProcessLastDone) AS func_Token_Process_Last_Done_1 INNER JOIN

                      semtbl_Token_Token AS ProcessLastDone_To_IncidentOrProcess ON 

                      func_Token_Process_Last_Done_1.GUID_Process_Last_Done = ProcessLastDone_To_IncidentOrProcess.GUID_Token_Left ON 

                      ProcessTicket_To_ProcessLastDone.GUID_Token_Right = func_Token_Process_Last_Done_1.GUID_Process_Last_Done

WHERE     (ProcessLastDone_To_IncidentOrProcess.GUID_RelationType = @GUID_RelationType_LastDone) AND 

                      (ProcessLastDone_To_IncidentOrProcess.GUID_Token_Right = @GUID_ProcessItem) AND 

                      (ProcessTicket_To_ProcessLastDone.GUID_RelationType = @GUID_RelationType_LastDone) AND 

                      (func_Token_Process_Ticket_1.GUID_Process_Ticket = @GUID_Ticket)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_create_Tables_Group]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_create_Tables_Group] 

	-- Add the parameters for the stored procedure here

	 @GUID_Attribute_ID						uniqueidentifier,

	 @GUID_Attribute_Startdate				uniqueidentifier,

	 @GUID_Attribute_DateTimeToDoList		uniqueidentifier,

	 @GUID_Attribute_DateTimeStamp			uniqueidentifier,

	 @GUID_Attribute_Message				uniqueidentifier,

	 @GUID_Type_ProcessTicket				uniqueidentifier,

	 @GUID_Type_Group						uniqueidentifier,

	 @GUID_Type_Incident					uniqueidentifier,

	 @GUID_Type_ProcessLastDone				uniqueidentifier,

	 @GUID_Type_Process						uniqueidentifier,

	 @GUID_Type_LogState					uniqueidentifier,

	 @GUID_Type_LogEntry					uniqueidentifier,

	 @GUID_RelationType_belongsTo			uniqueidentifier,

	 @GUID_RelationType_LastDone			uniqueidentifier,

	 @GUID_RelationType_isInState			uniqueidentifier,

	 @GUID_RelationType_provides			uniqueidentifier,

	 @GUID_RelationType_belongingDone		uniqueidentifier,

	 @GUID_RelationType_startedWith			uniqueidentifier,

	 @GUID_RelationType_finishedWith		uniqueidentifier,

	 @GUID_Group							uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

    -- Insert statements for procedure here

    DELETE FROM chngtbl_Ticket WHERE GUID_Group=@GUID_Group;

    

        DECLARE @tmp_Tickets TABLE

    (

		 GUID_Ticket		uniqueidentifier

    )

    

    --Tickets

    INSERT INTO chngtbl_Ticket (GUID_Ticket, 

								Name_Ticket,

								GUID_Group,

								Name_Group)		

	OUTPUT inserted.GUID_Ticket INTO @tmp_Tickets						

	SELECT     func_Token_Process_Ticket_1.GUID_Process_Ticket, func_Token_Process_Ticket_1.Name_Process_Ticket, func_Token_Group_1.GUID_Group, 

                      func_Token_Group_1.Name_Group

FROM         dbo.func_Token_Process_Ticket(@GUID_Type_ProcessTicket) AS func_Token_Process_Ticket_1 INNER JOIN

                      semtbl_Token_Token AS ProcessTicket_To_Group ON func_Token_Process_Ticket_1.GUID_Process_Ticket = ProcessTicket_To_Group.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Group(@GUID_Type_Group) AS func_Token_Group_1 ON 

                      ProcessTicket_To_Group.GUID_Token_Right = func_Token_Group_1.GUID_Group

WHERE     (ProcessTicket_To_Group.GUID_RelationType = @GUID_RelationType_belongsTo) AND (func_Token_Group_1.GUID_Group = @GUID_Group)



	INSERT INTO chngtbl_LogEntry_finishedWith

SELECT   tic.GUID_Ticket, func_Token_Logentry_1.GUID_Logentry

		,LogEntry__DateTimeStamp_Val.val AS DateTimeStamp

		,func_Token_Logstate_1.GUID_Logstate

		,func_Token_Logstate_1.Name_Logstate

FROM         @tmp_Tickets tic 

INNER JOIN semtbl_Token_Token AS Ticket_To_Logentry ON tic.GUID_Ticket = Ticket_To_Logentry.GUID_Token_Left 

INNER JOIN dbo.func_Token_Logentry(@GUID_Type_LogEntry) AS func_Token_Logentry_1 ON Ticket_To_Logentry.GUID_Token_Right = func_Token_Logentry_1.GUID_Logentry 

INNER JOIN semtbl_Token_Token AS LogEntry_To_LogState ON func_Token_Logentry_1.GUID_Logentry = LogEntry_To_LogState.GUID_Token_Left 

INNER JOIN dbo.func_Token_Logstate(@GUID_Type_LogState) AS func_Token_Logstate_1 ON LogEntry_To_LogState.GUID_Token_Right = func_Token_Logstate_1.GUID_Logstate 

INNER JOIN semtbl_Token_Attribute AS LogEntry__DateTimeStamp ON func_Token_Logentry_1.GUID_Logentry = LogEntry__DateTimeStamp.GUID_Token 

INNER JOIN semtbl_Token_attribute_datetime AS LogEntry__DateTimeStamp_Val ON LogEntry__DateTimeStamp.GUID_TokenAttribute = LogEntry__DateTimeStamp_Val.GUID_TokenAttribute 

WHERE     (Ticket_To_Logentry.GUID_RelationType = @GUID_RelationType_finishedWith) AND (LogEntry_To_LogState.GUID_RelationType = @GUID_RelationType_provides) AND 

                      (LogEntry__DateTimeStamp.GUID_Attribute = @GUID_Attribute_DateTimeStamp)





	--belonging Items

	INSERT INTO chngtbl_Item_belongsTo

	SELECT     tic.GUID_Ticket, semfunc_ObjectReference_1.GUID_Ref, semfunc_ObjectReference_1.Name_Token, semfunc_ObjectReference_1.GUID_ItemType

FROM         @tmp_Tickets tic INNER JOIN

                      semtbl_Token_OR ON tic.GUID_Ticket = semtbl_Token_OR.GUID_Token_Left INNER JOIN

                      dbo.semfunc_ObjectReference() AS semfunc_ObjectReference_1 ON 

                      semtbl_Token_OR.GUID_ObjectReference = semfunc_ObjectReference_1.GUID_ObjectReference INNER JOIN

                      semtbl_ORType ON semfunc_ObjectReference_1.GUID_ItemType = semtbl_ORType.GUID_ObjectReferenceType

WHERE     (semtbl_Token_OR.GUID_RelationType = @GUID_RelationType_belongsTo)



	-- ID

	INSERt INTO chngtbl_ID

	SELECT     tic.GUID_Ticket, Ticket__ID_Val.val

FROM         @tmp_Tickets tic INNER JOIN

                      semtbl_Token_Attribute AS Ticket__ID ON tic.GUID_Ticket = Ticket__ID.GUID_Token INNER JOIN

                      semtbl_Token_Attribute_Int AS Ticket__ID_Val ON Ticket__ID.GUID_TokenAttribute = Ticket__ID_Val.GUID_TokenAttribute

WHERE     (Ticket__ID.GUID_Attribute = @GUID_Attribute_ID)



	-- Startdate

	INSERT INTO chngtbl_LogEntry_Start

	SELECT     tic.GUID_Ticket, func_Token_Logentry_1.GUID_Logentry, Logentry__DateTimeStamp_Val.val AS DateTimeStamp

		FROM         @tmp_Tickets tic INNER JOIN

							  semtbl_Token_Token AS Ticket_To_Logentry ON tic.GUID_Ticket = Ticket_To_Logentry.GUID_Token_Left INNER JOIN

							  dbo.func_Token_Logentry(@GUID_Type_LogEntry) AS func_Token_Logentry_1 ON 

							  Ticket_To_Logentry.GUID_Token_Right = func_Token_Logentry_1.GUID_Logentry INNER JOIN

							  semtbl_Token_Attribute AS Logentry__DateTimeStamp ON func_Token_Logentry_1.GUID_Logentry = Logentry__DateTimeStamp.GUID_Token INNER JOIN

							  semtbl_Token_attribute_datetime AS Logentry__DateTimeStamp_Val ON 

							  Logentry__DateTimeStamp.GUID_TokenAttribute = Logentry__DateTimeStamp_Val.GUID_TokenAttribute

		WHERE     (Ticket_To_Logentry.GUID_RelationType = @GUID_RelationType_startedWith) AND (Logentry__DateTimeStamp.GUID_Attribute = @GUID_Attribute_DateTimeStamp)

			

	-- Last Process

	INSERT INTO chngtbl_LastProcess

	SELECT     tic.GUID_Ticket, func_Token_Incident_1.GUID_Incident, func_Token_Incident_1.Name_Incident, @GUID_Type_Incident

FROM         semtbl_Token_Token AS Ticket_To_ProcessLastDone INNER JOIN

                      @tmp_Tickets tic ON Ticket_To_ProcessLastDone.GUID_Token_Left = tic.GUID_Ticket INNER JOIN

                      dbo.func_Token_Process_Last_Done(@GUID_Type_ProcessLastDone) AS func_Token_Process_Last_Done_1 ON 

                      Ticket_To_ProcessLastDone.GUID_Token_Right = func_Token_Process_Last_Done_1.GUID_Process_Last_Done INNER JOIN

                      semtbl_Token_Token AS ProcessLastDone_To_Incident ON 

                      func_Token_Process_Last_Done_1.GUID_Process_Last_Done = ProcessLastDone_To_Incident.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Incident(@GUID_Type_Incident) AS func_Token_Incident_1 ON 

                      ProcessLastDone_To_Incident.GUID_Token_Right = func_Token_Incident_1.GUID_Incident

WHERE     (Ticket_To_ProcessLastDone.GUID_RelationType = @GUID_RelationType_LastDone) AND 

                      (ProcessLastDone_To_Incident.GUID_RelationType = @GUID_RelationType_LastDone);

                      

	INSERT INTO chngtbl_LastProcess

	SELECT     tic.GUID_Ticket, func_Token_Process_1.GUID_Process, func_Token_Process_1.Name_Process, @GUID_Type_Process

FROM         semtbl_Token_Token AS Ticket_To_ProcessLastDone INNER JOIN

                      @tmp_Tickets tic ON Ticket_To_ProcessLastDone.GUID_Token_Left = tic.GUID_Ticket INNER JOIN

                      dbo.func_Token_Process_Last_Done(@GUID_Type_ProcessLastDone) AS func_Token_Process_Last_Done_1 ON 

                      Ticket_To_ProcessLastDone.GUID_Token_Right = func_Token_Process_Last_Done_1.GUID_Process_Last_Done INNER JOIN

                      semtbl_Token_Token AS ProcessLastDone_To_Process ON 

                      func_Token_Process_Last_Done_1.GUID_Process_Last_Done = ProcessLastDone_To_Process.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Process(@GUID_Type_Process) AS func_Token_Process_1 ON 

                      ProcessLastDone_To_Process.GUID_Token_Right = func_Token_Process_1.GUID_Process

WHERE     (Ticket_To_ProcessLastDone.GUID_RelationType = @GUID_RelationType_LastDone) AND 

                      (ProcessLastDone_To_Process.GUID_RelationType = @GUID_RelationType_LastDone);

                      

	-- Last Logentry

	INSERT INTO chngtbl_Logentry_LastDone

	SELECT     tic.GUID_Ticket, func_Token_Logentry_1.GUID_Logentry, LogEntry__DateTimeStamp_Val.val AS DateTimeStamp, 

                      CAST(LogEntry__Message_Val.val AS VARCHAR(255)) AS Message, func_Token_Logstate_1.GUID_Logstate, func_Token_Logstate_1.Name_Logstate

FROM         @tmp_Tickets tic INNER JOIN

                      semtbl_Token_Token AS Ticket_To_Logentry ON tic.GUID_Ticket = Ticket_To_Logentry.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Logentry(@GUID_Type_LogEntry) AS func_Token_Logentry_1 ON 

                      Ticket_To_Logentry.GUID_Token_Right = func_Token_Logentry_1.GUID_Logentry INNER JOIN

                      semtbl_Token_Token AS LogEntry_To_LogState ON func_Token_Logentry_1.GUID_Logentry = LogEntry_To_LogState.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Logstate(@GUID_Type_LogState) AS func_Token_Logstate_1 ON 

                      LogEntry_To_LogState.GUID_Token_Right = func_Token_Logstate_1.GUID_Logstate INNER JOIN

                      semtbl_Token_Attribute AS LogEntry__DateTimeStamp ON func_Token_Logentry_1.GUID_Logentry = LogEntry__DateTimeStamp.GUID_Token INNER JOIN

                      semtbl_Token_attribute_datetime AS LogEntry__DateTimeStamp_Val ON 

                      LogEntry__DateTimeStamp.GUID_TokenAttribute = LogEntry__DateTimeStamp_Val.GUID_TokenAttribute INNER JOIN

                      semtbl_Token_Attribute AS LogEntry__Message ON func_Token_Logentry_1.GUID_Logentry = LogEntry__Message.GUID_Token INNER JOIN

                      semtbl_Token_Attribute_varcharMAX AS LogEntry__Message_Val ON 

                      LogEntry__Message.GUID_TokenAttribute = LogEntry__Message_Val.GUID_TokenAttribute

WHERE     (Ticket_To_Logentry.GUID_RelationType = @GUID_RelationType_LastDone) AND (LogEntry_To_LogState.GUID_RelationType = @GUID_RelationType_provides) AND 

                      (LogEntry__DateTimeStamp.GUID_Attribute = @GUID_Attribute_DateTimeStamp) AND (LogEntry__Message.GUID_Attribute = @GUID_Attribute_Message)



	-- Process

	INSERT INTO dbo.chngtbl_Process

	SELECT     tic.GUID_Ticket, func_Token_Process_1.GUID_Process, func_Token_Process_1.Name_Process

FROM         @tmp_Tickets tic INNER JOIN

                      semtbl_Token_Token AS Ticket_To_Process ON tic.GUID_Ticket = Ticket_To_Process.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Process(@GUID_Type_Process) AS func_Token_Process_1 ON 

                      Ticket_To_Process.GUID_Token_Right = func_Token_Process_1.GUID_Process

WHERE     (Ticket_To_Process.GUID_RelationType = @GUID_RelationType_belongsTo)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_State_Of_ProcessLog]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_State_Of_ProcessLog]

	-- Add the parameters for the stored procedure here

	@GUID_Type_LogEntry				uniqueidentifier,

	@GUID_Type_LogState				uniqueidentifier,

	@GUID_RelationType_provides		uniqueidentifier,

	@GUID_RelationType_finishedWith	uniqueidentifier,

	@GUID_ProcessLog				uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     func_Token_Logstate_1.GUID_Logstate, func_Token_Logstate_1.Name_Logstate, func_Token_Logstate_1.GUID_Type_Logstate

FROM         dbo.func_Token_Logentry(@GUID_Type_LogEntry) AS func_Token_Logentry_1 INNER JOIN

                      semtbl_Token_Token AS ProcessLog_To_LogEntry ON func_Token_Logentry_1.GUID_Logentry = ProcessLog_To_LogEntry.GUID_Token_Right INNER JOIN

                      semtbl_Token_Token AS LogEntry_To_LogState ON func_Token_Logentry_1.GUID_Logentry = LogEntry_To_LogState.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Logstate(@GUID_Type_LogState) AS func_Token_Logstate_1 ON 

                      LogEntry_To_LogState.GUID_Token_Right = func_Token_Logstate_1.GUID_Logstate

WHERE     (ProcessLog_To_LogEntry.GUID_RelationType = @GUID_RelationType_finishedWith) AND 

                      (LogEntry_To_LogState.GUID_RelationType = @GUID_RelationType_provides) AND (ProcessLog_To_LogEntry.GUID_Token_Left = @GUID_ProcessLog)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_create_Tables_Items]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_create_Tables_Items]

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

    DELETE FROM chngtbl_Item_Type

    DELETE FROM chngtbl_Item_Token

    DELETE FROM chngtbl_Item_Attribute

    DELETE FROM chngtbl_Item_RelationType

    

	INSERT INTO chngtbl_Item_Type

	SELECT     GUID_Ticket, GUID_Item_belongsTo, Name_Type, GUID_Type_Parent,0

	FROM         chngtbl_Item_belongsTo

	INNER JOIN semtbl_Type ON chngtbl_Item_belongsTo.GUID_Item_belongsTo = semtbl_Type.GUID_Type

	WHERE GUID_ItemType_belongsto = ''5C78451D-FE48-48CC-BD49-0A47F947DFC6''



	INSERT INTO chngtbl_Item_Token

	SELECT     GUID_Ticket, GUID_Item_belongsTo, Name_Token, GUID_Type

	FROM         chngtbl_Item_belongsTo

	INNER JOIN semtbl_Token ON chngtbl_Item_belongsTo.GUID_Item_belongsTo = semtbl_Token.GUID_Token

	WHERE GUID_ItemType_belongsto=''4CEF5745-B03C-4D34-9165-B865A7D384B1''



	INSERT INTO chngtbl_Item_Type

	SELECT chngtbl_Item_Token.GUID_Ticket, semtbl_Type.GUID_Type, semtbl_Type.Name_Type, semtbl_Type.GUID_Type_Parent,1

	FROM chngtbl_Item_Token

	INNER JOIN semtbl_Type ON semtbl_Type.GUID_Type = chngtbl_Item_Token.GUID_Type

	LEFT OUTER JOIN chngtbl_Item_Type ON chngtbl_Item_Type.GUID_Type = semtbl_Type.GUID_Type

	WHERE chngtbl_Item_Type.GUID_Type IS NULL



	INSERT INTO chngtbl_Item_Attribute

	SELECT     GUID_Ticket, GUID_Item_belongsTo, Name_Attribute

	FROM         chngtbl_Item_belongsTo

	INNER JOIN semtbl_Attribute ON chngtbl_Item_belongsTo.GUID_Item_belongsTo = semtbl_Attribute.GUID_Attribute

	WHERE GUID_ItemType_belongsto=''66A7F5C9-BFF6-40DC-A893-15BDB65DBF26''



	INSERT INTO chngtbl_Item_RelationType

	SELECT     GUID_Ticket, GUID_Item_belongsTo, Name_RelationType

	FROM         chngtbl_Item_belongsTo

	INNER JOIN semtbl_RelationType ON chngtbl_Item_belongsTo.GUID_Item_belongsTo = semtbl_RelationType.GUID_RelationType

	WHERE GUID_ItemType_belongsto=''761B8A7E-E65C-428A-804B-8E1D3DEF7C4B''





	;WITH Hierarchy AS (

		SELECT GUID_Ticket, GUID_Type, Name_Type, GUID_Type_Parent

		FROM chngtbl_Item_Type

		

		UNION ALL

		

		SELECT c.GUID_Ticket, p.GUID_Type, p.Name_Type, p.GUID_Type_Parent

		FROM Hierarchy c

		INNER JOIN semtbl_Type p ON c.GUID_Type_Parent = p.GUID_Type)

		

		INSERT INTO chngtbl_Item_Type

		SELECT DISTINCT hierarchy.GUID_Ticket, hierarchy.GUID_Type, hierarchy.Name_Type, hierarchy.GUID_Type_Parent,1

		FROM hierarchy

		LEFT OUTER JOIN chngtbl_Item_Type ON hierarchy.GUID_Ticket = chngtbl_Item_Type.GUID_Ticket AND chngtbl_Item_Type.GUID_Type = hierarchy.GUID_Type

		WHERE chngtbl_Item_Type.GUID_Ticket IS NULL

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Logentries_Of_ProcessLog]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_Logentries_Of_ProcessLog]

	-- Add the parameters for the stored procedure here

	

	@GUID_ProcessLog					uniqueidentifier

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Attribute_DateTimeStamp		uniqueidentifier;

	DECLARE @GUID_Attribute_Message				uniqueidentifier;

	DECLARE @GUID_Type_Logentry					uniqueidentifier;

	DECLARE @GUID_Type_LogState					uniqueidentifier;

	DECLARE @GUID_Type_Log						uniqueidentifier;

	DECLARE @GUID_RelationType_belongingDone	uniqueidentifier;

	DECLARE @GUID_RelationType_provides			uniqueidentifier;

	DECLARE @GUID_RelationType_TimeMeasuring	uniqueidentifier;

	DECLARE @GUID_RelationType_contains			uniqueidentifier;

	

	SET @GUID_Attribute_DateTimeStamp		= dbo.dbg_AttributeType_DateTimestamp();

	SET @GUID_Attribute_Message				= dbo.dbg_AttributeType_Message();

	SET @GUID_Type_Logentry					= dbo.dbg_Type_Logentry();

	SET @GUID_Type_LogState					= dbo.dbg_Type_Logstate();

	SET	@GUID_Type_Log						= dbo.dbg_Type_Log();

	SET @GUID_RelationType_belongingDone	= dbo.dbg_RelationType_belonging_Done();

	SET @GUID_RelationType_provides			= dbo.dbg_RelationType_provides();

	SET @GUID_RelationType_TimeMeasuring	= dbo.dbg_RelationType_Time_Measuring();

	SET @GUID_RelationType_contains			= dbo.dbg_RelationType_contains();

	

	PRINT @GUID_Attribute_DateTimeStamp;

	PRINT @GUID_Attribute_Message;

	PRINT @GUID_Type_Logentry;

	PRINT @GUID_Type_LogState;

	PRINT @GUID_RelationType_belongingDone;

	PRINT @GUID_RelationType_provides;

	PRINT @GUID_RelationType_TimeMeasuring;

	PRINT @GUID_RelationType_contains;

	

	DECLARE @tmptbl_Logentries TABLE

	(

		GUID_Logentry						uniqueidentifier,

		Name_Logentry						varchar(255),

		GUID_Type_Logentry					uniqueidentifier,

		GUID_TokenAttribute_DateTimeStamp	uniqueidentifier,

		DateTimeStamp						datetime,

		GUID_Logstate						uniqueidentifier,

		Name_Logstate						varchar(255),

		GUID_Type_Logstate					uniqueidentifier,

		GUID_TokenAttribute_Message			uniqueidentifier,

		Message								varchar(Max)

	)

    -- Insert statements for procedure here

    INSERT INTO @tmptbl_Logentries

	SELECT  func_Token_Logentry_1.GUID_Logentry, 

			func_Token_Logentry_1.Name_Logentry, 

			func_Token_Logentry_1.GUID_Type_Logentry, 

            Logentry__DateTimeStamp_Val.GUID_TokenAttribute AS GUID_TokenAttribute_DateTimeStamp, 

            Logentry__DateTimeStamp_Val.val AS DateTimeStamp, 

            func_Token_Logstate_1.GUID_Logstate, 

            func_Token_Logstate_1.Name_Logstate, 

            func_Token_Logstate_1.GUID_Type_Logstate, 

			Logentry__Message_Val.GUID_TokenAttribute AS GUID_TokenAttribute_Message, 

			Logentry__Message_Val.val AS Message

		FROM         dbo.func_Token_Logentry(@GUID_Type_Logentry) AS func_Token_Logentry_1 INNER JOIN

							  semtbl_Token_Token AS ProcessLog_To_LogEntry ON func_Token_Logentry_1.GUID_Logentry = ProcessLog_To_LogEntry.GUID_Token_Right INNER JOIN

							  semtbl_Token_Attribute AS Logentry__DateTimeStamp ON func_Token_Logentry_1.GUID_Logentry = Logentry__DateTimeStamp.GUID_Token INNER JOIN

							  semtbl_Token_attribute_datetime AS Logentry__DateTimeStamp_Val ON 

							  Logentry__DateTimeStamp.GUID_TokenAttribute = Logentry__DateTimeStamp_Val.GUID_TokenAttribute INNER JOIN

							  semtbl_Token_Token AS Logentry_To_LogState ON func_Token_Logentry_1.GUID_Logentry = Logentry_To_LogState.GUID_Token_Left INNER JOIN

							  dbo.func_Token_Logstate(@GUID_Type_LogState) AS func_Token_Logstate_1 ON 

							  Logentry_To_LogState.GUID_Token_Right = func_Token_Logstate_1.GUID_Logstate INNER JOIN

							  semtbl_Token_Attribute AS LogEntry__Message ON func_Token_Logentry_1.GUID_Logentry = LogEntry__Message.GUID_Token INNER JOIN

							  semtbl_Token_Attribute_varcharMAX AS Logentry__Message_Val ON 

							  LogEntry__Message.GUID_TokenAttribute = Logentry__Message_Val.GUID_TokenAttribute

		WHERE     (ProcessLog_To_LogEntry.GUID_RelationType = @GUID_RelationType_belongingDone) AND (ProcessLog_To_LogEntry.GUID_Token_Left = @GUID_ProcessLog) AND

							   (Logentry__DateTimeStamp.GUID_Attribute = @GUID_Attribute_DateTimeStamp) AND (Logentry_To_LogState.GUID_RelationType = @GUID_RelationType_provides) 

							  AND (LogEntry__Message.GUID_Attribute = @GUID_Attribute_Message)



		

	INSERT INTO @tmptbl_Logentries

	SELECT     func_Token_Logentry_1.GUID_Logentry, func_Token_Logentry_1.Name_Logentry, func_Token_Logentry_1.GUID_Type_Logentry, 

                      Logentry__DateTimeStamp_Val.GUID_TokenAttribute AS GUID_TokenAttribute_DateTimeStamp, Logentry__DateTimeStamp_Val.val AS DateTimeStamp, 

                      func_Token_Logstate_1.GUID_Logstate, func_Token_Logstate_1.Name_Logstate, func_Token_Logstate_1.GUID_Type_Logstate, 

                      Logentry__Message_Val.GUID_TokenAttribute AS GUID_TokenAttribute_Message, Logentry__Message_Val.val AS Message

		FROM         dbo.func_Token_Logentry(@GUID_Type_Logentry) AS func_Token_Logentry_1 INNER JOIN

							  semtbl_Token_Token AS Log_To_LogEntry ON func_Token_Logentry_1.GUID_Logentry = Log_To_LogEntry.GUID_Token_Right INNER JOIN

							  semtbl_Token_Attribute AS Logentry__DateTimeStamp ON func_Token_Logentry_1.GUID_Logentry = Logentry__DateTimeStamp.GUID_Token INNER JOIN

							  semtbl_Token_attribute_datetime AS Logentry__DateTimeStamp_Val ON 

							  Logentry__DateTimeStamp.GUID_TokenAttribute = Logentry__DateTimeStamp_Val.GUID_TokenAttribute INNER JOIN

							  semtbl_Token_Token AS Logentry_To_LogState ON func_Token_Logentry_1.GUID_Logentry = Logentry_To_LogState.GUID_Token_Left INNER JOIN

							  dbo.func_Token_Logstate(@GUID_Type_LogState) AS func_Token_Logstate_1 ON 

							  Logentry_To_LogState.GUID_Token_Right = func_Token_Logstate_1.GUID_Logstate INNER JOIN

							  semtbl_Token_Attribute AS LogEntry__Message ON func_Token_Logentry_1.GUID_Logentry = LogEntry__Message.GUID_Token INNER JOIN

							  semtbl_Token_Attribute_varcharMAX AS Logentry__Message_Val ON 

							  LogEntry__Message.GUID_TokenAttribute = Logentry__Message_Val.GUID_TokenAttribute INNER JOIN

							  dbo.func_Token_Log(@GUID_Type_Log) AS func_Token_Log_1 ON Log_To_LogEntry.GUID_Token_Left = func_Token_Log_1.GUID_Log INNER JOIN

							  semtbl_Token_Token AS ProcessLog_To_Log ON func_Token_Log_1.GUID_Log = ProcessLog_To_Log.GUID_Token_Right

		WHERE     (Log_To_LogEntry.GUID_RelationType = @GUID_RelationType_contains) AND (Logentry__DateTimeStamp.GUID_Attribute = @GUID_Attribute_DateTimeStamp) AND 

							  (Logentry_To_LogState.GUID_RelationType = @GUID_RelationType_provides) AND (LogEntry__Message.GUID_Attribute = @GUID_Attribute_Message) AND 

							  (ProcessLog_To_Log.GUID_RelationType = @GUID_RelationType_TimeMeasuring) AND (ProcessLog_To_Log.GUID_Token_Left = @GUID_ProcessLog)

		

		

	SELECT * FROM @tmptbl_Logentries

	ORDER BY DateTimeStamp DESC

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Process_subordinate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE FUNCTION [dbo].[func_Process_subordinate]

(	

	-- Add the parameters for the function here

	@GUID_Type_Process					uniqueidentifier,

	@GUID_RelationType_superordinate	uniqueidentifier,

	@GUID_Process_Parent				uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     func_Token_Process_1.GUID_Process, func_Token_Process_1.Name_Process, func_Token_Process_1.GUID_Type_Process

FROM         dbo.func_Token_Process(@GUID_Type_Process) AS func_Token_Process_1 INNER JOIN

                      semtbl_Token_Token AS Process_To_Process ON func_Token_Process_1.GUID_Process = Process_To_Process.GUID_Token_Right

WHERE     (Process_To_Process.GUID_Token_Left = @GUID_Process_Parent) AND (Process_To_Process.GUID_RelationType = @GUID_RelationType_superordinate)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_State_Of_ProcessLog_By_GUIDState]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_State_Of_ProcessLog_By_GUIDState]

	-- Add the parameters for the stored procedure here

	@GUID_LogState					uniqueidentifier,

	@GUID_ProcessLog				uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Type_LogEntry				uniqueidentifier;

	DECLARE @GUID_Type_LogState				uniqueidentifier;

	DECLARE @GUID_RelationType_provides		uniqueidentifier;

	DECLARE @GUID_RelationType_finishedWith	uniqueidentifier;

	

	SET @GUID_Type_LogEntry				= dbo.dbg_Type_Logentry();

	SET @GUID_Type_LogState				= dbo.dbg_Type_Logstate();

	SET @GUID_RelationType_provides		= dbo.dbg_RelationType_provides();

	SET @GUID_RelationType_finishedWith	= dbo.dbg_RelationType_finished_with();

	

	PRINT @GUID_Type_LogEntry;

	PRINT @GUID_Type_LogState;

	PRINT @GUID_RelationType_provides;

	PRINT @GUID_RelationType_finishedWith;

	

    -- Insert statements for procedure here

	SELECT     func_Token_Logstate_1.GUID_Logstate, func_Token_Logstate_1.Name_Logstate, func_Token_Logstate_1.GUID_Type_Logstate

FROM         dbo.func_Token_Logentry(@GUID_Type_LogEntry) AS func_Token_Logentry_1 INNER JOIN

                      semtbl_Token_Token AS ProcessLog_To_LogEntry ON func_Token_Logentry_1.GUID_Logentry = ProcessLog_To_LogEntry.GUID_Token_Right INNER JOIN

                      semtbl_Token_Token AS LogEntry_To_LogState ON func_Token_Logentry_1.GUID_Logentry = LogEntry_To_LogState.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Logstate(@GUID_Type_LogState) AS func_Token_Logstate_1 ON 

                      LogEntry_To_LogState.GUID_Token_Right = func_Token_Logstate_1.GUID_Logstate

WHERE     (ProcessLog_To_LogEntry.GUID_RelationType = @GUID_RelationType_finishedWith) AND 

                      (LogEntry_To_LogState.GUID_RelationType = @GUID_RelationType_provides) AND (ProcessLog_To_LogEntry.GUID_Token_Left = @GUID_ProcessLog) AND 

                      (func_Token_Logstate_1.GUID_Logstate = @GUID_LogState)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[orgview_Item_Token]'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE VIEW dbo.orgview_Item_Token

AS

SELECT     dbo.chngtbl_Item_Token.GUID_Ticket, dbo.chngtbl_Item_Token.GUID_Token, dbo.chngtbl_Item_Token.Name_Token, dbo.chngtbl_Item_Token.GUID_Type, 

                      dbo.chngtbl_Logentry_FinishedWith.GUID_LogState

FROM         dbo.chngtbl_Item_Token LEFT OUTER JOIN

                      dbo.chngtbl_Logentry_FinishedWith ON dbo.chngtbl_Item_Token.GUID_Ticket = dbo.chngtbl_Logentry_FinishedWith.GUID_Ticket
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[chngview_TicketCount]'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE VIEW dbo.chngview_TicketCount

AS

SELECT     GUID_Ticket, COUNT(*) AS TicketCount

FROM         dbo.chngtbl_Ticket_TicketList

GROUP BY GUID_Ticket
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_create_Tables_Group]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_create_Tables_Group] 

	-- Add the parameters for the stored procedure here

	

	@GUID_Group						uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Attribute_ID					uniqueidentifier;

	DECLARE @GUID_Attribute_Startdate			uniqueidentifier;

	DECLARE @GUID_Attribute_DateTimeToDoList	uniqueidentifier;

	DECLARE @GUID_Attribute_DateTimeStamp		uniqueidentifier;

	DECLARE @GUID_Attribute_Message				uniqueidentifier;

	DECLARE @GUID_Type_ProcessTicket			uniqueidentifier;

	DECLARE @GUID_Type_Group					uniqueidentifier;

	DECLARE @GUID_Type_Incident					uniqueidentifier;

	DECLARE @GUID_Type_ProcessLastDone			uniqueidentifier;

	DECLARE @GUID_Type_Process					uniqueidentifier;

	DECLARE @GUID_Type_LogState					uniqueidentifier;

	DECLARE @GUID_Type_LogEntry					uniqueidentifier;

	DECLARE @GUID_RelationType_belongsTo		uniqueidentifier;

	DECLARE @GUID_RelationType_LastDone			uniqueidentifier;

	DECLARE @GUID_RelationType_isInState		uniqueidentifier;

	DECLARE @GUID_RelationType_provides			uniqueidentifier;

	DECLARE @GUID_RelationType_belongingDone	uniqueidentifier;

	DECLARE @GUID_RelationType_startedWith		uniqueidentifier;

	DECLARE @GUID_RelationType_finishedWith		uniqueidentifier

	

	

	SET @GUID_Attribute_ID					= dbo.dbg_AttributeType_ID();

	SET @GUID_Attribute_Startdate			= dbo.dbg_AttributeType_Startdate();

	SET @GUID_Attribute_DateTimeToDoList	= dbo.dbg_AttributeType_Datetime__To_Do_List_();

	SET @GUID_Attribute_DateTimeStamp		= dbo.dbg_AttributeType_DateTimestamp();

	SET @GUID_Attribute_Message				= dbo.dbg_AttributeType_Message();

	SET @GUID_Type_ProcessTicket			= dbo.dbg_Type_Process_Ticket();

	SET @GUID_Type_Group					= dbo.dbg_Type_group();

	SET	@GUID_Type_Incident					= dbo.dbg_Type_Incident();

	SET @GUID_Type_Process					= dbo.dbg_Type_Process();

	SET @GUID_Type_ProcessLastDone			= dbo.dbg_Type_Process_Last_Done();

	SET @GUID_Type_LogState					= dbo.dbg_Type_Logstate();

	SET @GUID_Type_LogEntry					= dbo.dbg_Type_Logentry();

	SET @GUID_RelationType_belongsTo		= dbo.dbg_RelationType_belongs_to();

	SET @GUID_RelationType_LastDone			= dbo.dbg_RelationType_Last_Done();

	SET @GUID_RelationType_isInState		= dbo.dbg_RelationType_is_in_State();

	SET @GUID_RelationType_provides			= dbo.dbg_RelationType_provides();

	SET @GUID_RelationType_belongingDone	= dbo.dbg_RelationType_belonging_Done();

	SET @GUID_RelationType_startedWith		= dbo.dbg_RelationType_started_with();

	SET @GUID_RelationType_finishedWith		= dbo.dbg_RelationType_finished_with()

	

	PRINT @GUID_Attribute_ID;

	PRINT @GUID_Attribute_Startdate;

	PRINT @GUID_Type_ProcessTicket;

	PRINT @GUID_Type_Group;

	PRINT @GUID_Type_Incident;

	PRINT @GUID_Type_ProcessLastDone;

	PRINT @GUID_Type_Process;

	PRINT @GUID_Type_LogState;

	PRINT @GUID_RelationType_belongsTo;

	PRINT @GUID_RelationType_LastDone;

	PRINT @GUID_RelationType_isInState;

	PRINT @GUID_RelationType_belongingDone;

	PRINT @GUID_RelationType_startedWith;

	PRINT @GUID_RelationType_finishedWith

	

    -- Insert statements for procedure here

    DELETE FROM chngtbl_Ticket WHERE GUID_Group=@GUID_Group;

    

    DECLARE @tmp_Tickets TABLE

    (

		 GUID_Ticket		uniqueidentifier

    )

    

    --Tickets

    INSERT INTO chngtbl_Ticket (GUID_Ticket, 

								Name_Ticket,

								GUID_Group,

								Name_Group)		

	OUTPUT inserted.GUID_Ticket INTO @tmp_Tickets						

	SELECT     func_Token_Process_Ticket_1.GUID_Process_Ticket, func_Token_Process_Ticket_1.Name_Process_Ticket, func_Token_Group_1.GUID_Group, 

                      func_Token_Group_1.Name_Group

FROM         dbo.func_Token_Process_Ticket(@GUID_Type_ProcessTicket) AS func_Token_Process_Ticket_1 INNER JOIN

                      semtbl_Token_Token AS ProcessTicket_To_Group ON func_Token_Process_Ticket_1.GUID_Process_Ticket = ProcessTicket_To_Group.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Group(@GUID_Type_Group) AS func_Token_Group_1 ON 

                      ProcessTicket_To_Group.GUID_Token_Right = func_Token_Group_1.GUID_Group

WHERE     (ProcessTicket_To_Group.GUID_RelationType = @GUID_RelationType_belongsTo) AND (func_Token_Group_1.GUID_Group = @GUID_Group)



	INSERT INTO chngtbl_LogEntry_finishedWith

SELECT   tic.GUID_Ticket, func_Token_Logentry_1.GUID_Logentry

		,LogEntry__DateTimeStamp_Val.val AS DateTimeStamp

		,func_Token_Logstate_1.GUID_Logstate

		,func_Token_Logstate_1.Name_Logstate

FROM         @tmp_Tickets tic 

INNER JOIN semtbl_Token_Token AS Ticket_To_Logentry ON tic.GUID_Ticket = Ticket_To_Logentry.GUID_Token_Left 

INNER JOIN dbo.func_Token_Logentry(@GUID_Type_LogEntry) AS func_Token_Logentry_1 ON Ticket_To_Logentry.GUID_Token_Right = func_Token_Logentry_1.GUID_Logentry 

INNER JOIN semtbl_Token_Token AS LogEntry_To_LogState ON func_Token_Logentry_1.GUID_Logentry = LogEntry_To_LogState.GUID_Token_Left 

INNER JOIN dbo.func_Token_Logstate(@GUID_Type_LogState) AS func_Token_Logstate_1 ON LogEntry_To_LogState.GUID_Token_Right = func_Token_Logstate_1.GUID_Logstate 

INNER JOIN semtbl_Token_Attribute AS LogEntry__DateTimeStamp ON func_Token_Logentry_1.GUID_Logentry = LogEntry__DateTimeStamp.GUID_Token 

INNER JOIN semtbl_Token_attribute_datetime AS LogEntry__DateTimeStamp_Val ON LogEntry__DateTimeStamp.GUID_TokenAttribute = LogEntry__DateTimeStamp_Val.GUID_TokenAttribute 

WHERE     (Ticket_To_Logentry.GUID_RelationType = @GUID_RelationType_finishedWith) AND (LogEntry_To_LogState.GUID_RelationType = @GUID_RelationType_provides) AND 

                      (LogEntry__DateTimeStamp.GUID_Attribute = @GUID_Attribute_DateTimeStamp)

	--belonging Items

	INSERT INTO chngtbl_Item_belongsTo

	SELECT     tic.GUID_Ticket, semfunc_ObjectReference_1.GUID_Ref, semfunc_ObjectReference_1.Name_Token, semfunc_ObjectReference_1.GUID_ItemType

FROM         @tmp_Tickets tic INNER JOIN

                      semtbl_Token_OR ON tic.GUID_Ticket = semtbl_Token_OR.GUID_Token_Left INNER JOIN

                      dbo.semfunc_ObjectReference() AS semfunc_ObjectReference_1 ON 

                      semtbl_Token_OR.GUID_ObjectReference = semfunc_ObjectReference_1.GUID_ObjectReference INNER JOIN

                      semtbl_ORType ON semfunc_ObjectReference_1.GUID_ItemType = semtbl_ORType.GUID_ObjectReferenceType

WHERE     (semtbl_Token_OR.GUID_RelationType = @GUID_RelationType_belongsTo)



	-- ID

	INSERt INTO chngtbl_ID

	SELECT     tic.GUID_Ticket, Ticket__ID_Val.val

FROM         @tmp_Tickets tic INNER JOIN

                      semtbl_Token_Attribute AS Ticket__ID ON tic.GUID_Ticket = Ticket__ID.GUID_Token INNER JOIN

                      semtbl_Token_Attribute_Int AS Ticket__ID_Val ON Ticket__ID.GUID_TokenAttribute = Ticket__ID_Val.GUID_TokenAttribute

WHERE     (Ticket__ID.GUID_Attribute = @GUID_Attribute_ID)



	-- Startdate

	INSERT INTO chngtbl_LogEntry_Start

	SELECT     tic.GUID_Ticket, func_Token_Logentry_1.GUID_Logentry, Logentry__DateTimeStamp_Val.val AS DateTimeStamp

		FROM         @tmp_Tickets tic INNER JOIN

							  semtbl_Token_Token AS Ticket_To_Logentry ON tic.GUID_Ticket = Ticket_To_Logentry.GUID_Token_Left INNER JOIN

							  dbo.func_Token_Logentry(@GUID_Type_LogEntry) AS func_Token_Logentry_1 ON 

							  Ticket_To_Logentry.GUID_Token_Right = func_Token_Logentry_1.GUID_Logentry INNER JOIN

							  semtbl_Token_Attribute AS Logentry__DateTimeStamp ON func_Token_Logentry_1.GUID_Logentry = Logentry__DateTimeStamp.GUID_Token INNER JOIN

							  semtbl_Token_attribute_datetime AS Logentry__DateTimeStamp_Val ON 

							  Logentry__DateTimeStamp.GUID_TokenAttribute = Logentry__DateTimeStamp_Val.GUID_TokenAttribute

		WHERE     (Ticket_To_Logentry.GUID_RelationType = @GUID_RelationType_startedWith) AND (Logentry__DateTimeStamp.GUID_Attribute = @GUID_Attribute_DateTimeStamp)

			

	-- Last Process

	INSERT INTO chngtbl_LastProcess

	SELECT     tic.GUID_Ticket, func_Token_Incident_1.GUID_Incident, func_Token_Incident_1.Name_Incident, @GUID_Type_Incident

FROM         semtbl_Token_Token AS Ticket_To_ProcessLastDone INNER JOIN

                      @tmp_Tickets tic ON Ticket_To_ProcessLastDone.GUID_Token_Left = tic.GUID_Ticket INNER JOIN

                      dbo.func_Token_Process_Last_Done(@GUID_Type_ProcessLastDone) AS func_Token_Process_Last_Done_1 ON 

                      Ticket_To_ProcessLastDone.GUID_Token_Right = func_Token_Process_Last_Done_1.GUID_Process_Last_Done INNER JOIN

                      semtbl_Token_Token AS ProcessLastDone_To_Incident ON 

                      func_Token_Process_Last_Done_1.GUID_Process_Last_Done = ProcessLastDone_To_Incident.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Incident(@GUID_Type_Incident) AS func_Token_Incident_1 ON 

                      ProcessLastDone_To_Incident.GUID_Token_Right = func_Token_Incident_1.GUID_Incident

WHERE     (Ticket_To_ProcessLastDone.GUID_RelationType = @GUID_RelationType_LastDone) AND 

                      (ProcessLastDone_To_Incident.GUID_RelationType = @GUID_RelationType_LastDone);

                      

	INSERT INTO chngtbl_LastProcess

	SELECT     tic.GUID_Ticket, func_Token_Process_1.GUID_Process, func_Token_Process_1.Name_Process, @GUID_Type_Process

FROM         semtbl_Token_Token AS Ticket_To_ProcessLastDone INNER JOIN

                      @tmp_Tickets tic ON Ticket_To_ProcessLastDone.GUID_Token_Left = tic.GUID_Ticket INNER JOIN

                      dbo.func_Token_Process_Last_Done(@GUID_Type_ProcessLastDone) AS func_Token_Process_Last_Done_1 ON 

                      Ticket_To_ProcessLastDone.GUID_Token_Right = func_Token_Process_Last_Done_1.GUID_Process_Last_Done INNER JOIN

                      semtbl_Token_Token AS ProcessLastDone_To_Process ON 

                      func_Token_Process_Last_Done_1.GUID_Process_Last_Done = ProcessLastDone_To_Process.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Process(@GUID_Type_Process) AS func_Token_Process_1 ON 

                      ProcessLastDone_To_Process.GUID_Token_Right = func_Token_Process_1.GUID_Process

WHERE     (Ticket_To_ProcessLastDone.GUID_RelationType = @GUID_RelationType_LastDone) AND 

                      (ProcessLastDone_To_Process.GUID_RelationType = @GUID_RelationType_LastDone);

                      

	-- Last Logentry

	INSERT INTO chngtbl_Logentry_LastDone

	SELECT     tic.GUID_Ticket, func_Token_Logentry_1.GUID_Logentry, LogEntry__DateTimeStamp_Val.val AS DateTimeStamp, 

                      CAST(LogEntry__Message_Val.val AS VARCHAR(255)) AS Message, func_Token_Logstate_1.GUID_Logstate, func_Token_Logstate_1.Name_Logstate

FROM         @tmp_Tickets tic INNER JOIN

                      semtbl_Token_Token AS Ticket_To_Logentry ON tic.GUID_Ticket = Ticket_To_Logentry.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Logentry(@GUID_Type_LogEntry) AS func_Token_Logentry_1 ON 

                      Ticket_To_Logentry.GUID_Token_Right = func_Token_Logentry_1.GUID_Logentry INNER JOIN

                      semtbl_Token_Token AS LogEntry_To_LogState ON func_Token_Logentry_1.GUID_Logentry = LogEntry_To_LogState.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Logstate(@GUID_Type_LogState) AS func_Token_Logstate_1 ON 

                      LogEntry_To_LogState.GUID_Token_Right = func_Token_Logstate_1.GUID_Logstate INNER JOIN

                      semtbl_Token_Attribute AS LogEntry__DateTimeStamp ON func_Token_Logentry_1.GUID_Logentry = LogEntry__DateTimeStamp.GUID_Token INNER JOIN

                      semtbl_Token_attribute_datetime AS LogEntry__DateTimeStamp_Val ON 

                      LogEntry__DateTimeStamp.GUID_TokenAttribute = LogEntry__DateTimeStamp_Val.GUID_TokenAttribute INNER JOIN

                      semtbl_Token_Attribute AS LogEntry__Message ON func_Token_Logentry_1.GUID_Logentry = LogEntry__Message.GUID_Token INNER JOIN

                      semtbl_Token_Attribute_varcharMAX AS LogEntry__Message_Val ON 

                      LogEntry__Message.GUID_TokenAttribute = LogEntry__Message_Val.GUID_TokenAttribute

WHERE     (Ticket_To_Logentry.GUID_RelationType = @GUID_RelationType_LastDone) AND (LogEntry_To_LogState.GUID_RelationType = @GUID_RelationType_provides) AND 

                      (LogEntry__DateTimeStamp.GUID_Attribute = @GUID_Attribute_DateTimeStamp) AND (LogEntry__Message.GUID_Attribute = @GUID_Attribute_Message)



	-- Process

	INSERT INTO dbo.chngtbl_Process

	SELECT     tic.GUID_Ticket, func_Token_Process_1.GUID_Process, func_Token_Process_1.Name_Process

FROM         @tmp_Tickets tic INNER JOIN

                      semtbl_Token_Token AS Ticket_To_Process ON tic.GUID_Ticket = Ticket_To_Process.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Process(@GUID_Type_Process) AS func_Token_Process_1 ON 

                      Ticket_To_Process.GUID_Token_Right = func_Token_Process_1.GUID_Process

WHERE     (Ticket_To_Process.GUID_RelationType = @GUID_RelationType_belongsTo)



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[orgview_Item_RelationType]'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE VIEW dbo.orgview_Item_RelationType

AS

SELECT     dbo.chngtbl_Item_RelationType.GUID_Ticket, dbo.chngtbl_Item_RelationType.GUID_RelationType, dbo.chngtbl_Item_RelationType.Name_RelationType, 

                      dbo.chngtbl_Logentry_FinishedWith.GUID_LogState

FROM         dbo.chngtbl_Item_RelationType LEFT OUTER JOIN

                      dbo.chngtbl_Logentry_FinishedWith ON dbo.chngtbl_Item_RelationType.GUID_Ticket = dbo.chngtbl_Logentry_FinishedWith.GUID_Ticket
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ProcessItem_LastDone]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_ProcessItem_LastDone] 

	-- Add the parameters for the stored procedure here

	@GUID_Type_ProcessTicket	uniqueidentifier,

	@GUID_Type_ProcessLastDone	uniqueidentifier,

	@GUID_RelationType_LastDone	uniqueidentifier,

	@GUID_ProcessItem			uniqueidentifier,

	@GUID_Ticket				uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     func_Token_Process_Last_Done_1.GUID_Process_Last_Done, func_Token_Process_Last_Done_1.Name_Process_Last_Done, 

                      func_Token_Process_Last_Done_1.GUID_Type_Process_Last_Done, ProcessLastDone_To_IncidentOrProcess.GUID_RelationType, 

                      ProcessTicket_To_ProcessLastDone.OrderID

FROM         semtbl_Token_Token AS ProcessTicket_To_ProcessLastDone INNER JOIN

                      dbo.func_Token_Process_Ticket(@GUID_Type_ProcessTicket) AS func_Token_Process_Ticket_1 ON 

                      ProcessTicket_To_ProcessLastDone.GUID_Token_Left = func_Token_Process_Ticket_1.GUID_Process_Ticket INNER JOIN

                      dbo.func_Token_Process_Last_Done(@GUID_Type_ProcessLastDone) AS func_Token_Process_Last_Done_1 INNER JOIN

                      semtbl_Token_Token AS ProcessLastDone_To_IncidentOrProcess ON 

                      func_Token_Process_Last_Done_1.GUID_Process_Last_Done = ProcessLastDone_To_IncidentOrProcess.GUID_Token_Left ON 

                      ProcessTicket_To_ProcessLastDone.GUID_Token_Right = func_Token_Process_Last_Done_1.GUID_Process_Last_Done

WHERE     (ProcessLastDone_To_IncidentOrProcess.GUID_RelationType = @GUID_RelationType_LastDone) AND 

                      (ProcessLastDone_To_IncidentOrProcess.GUID_Token_Right = @GUID_ProcessItem) AND 

                      (ProcessTicket_To_ProcessLastDone.GUID_RelationType = @GUID_RelationType_LastDone) AND 

                      (func_Token_Process_Ticket_1.GUID_Process_Ticket = @GUID_Ticket)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Create_TicketLists]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_Create_TicketLists] 

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

    DECLARE @GUID_Attribute_Standard		uniqueidentifier

	DECLARE @GUID_Attribute_Startdate		uniqueidentifier

	DECLARE @GUID_Attribute_Enddate			uniqueidentifier

	DECLARE @GUID_Type_TicketList			uniqueidentifier

	DECLARE @GUID_Type_ProcessTickets		uniqueidentifier

	DECLARE @GUID_Type_Group				uniqueidentifier

	DECLARE @GUID_RelationType_Contains		uniqueidentifier

	DECLARE @GUID_RelationType_belongsTo	uniqueidentifier



	SET @GUID_Attribute_Standard		= dbo.dbg_AttributeType_Standard()

	SET @GUID_Attribute_Startdate		= dbo.dbg_AttributeType_Startdate()

	SET @GUID_Attribute_Enddate			= dbo.dbg_AttributeType_Enddate()

	SET @GUID_Type_TicketList			= dbo.dbg_Type_Process_Ticket_Lists()

	SET @GUID_Type_ProcessTickets		= dbo.dbg_Type_Process_Ticket()

	SET @GUID_Type_Group				= dbo.dbg_Type_Group()

	SET @GUID_RelationType_Contains		= dbo.dbg_RelationType_contains()

	SET @GUID_RelationType_belongsTo	= dbo.dbg_RelationType_belongs_to()

	

	PRINT @GUID_Attribute_Standard

	PRINT @GUID_Attribute_Startdate

	PRINT @GUID_Attribute_Enddate

	PRINT @GUID_Type_TicketList

	PRINT @GUID_Type_ProcessTickets

	PRINT @GUID_RelationType_Contains

	PRINT @GUID_RelationType_belongsTo

	



	DECLARE @tmp_TicketLists TABLE

	(

		 GUID_Ticket_List		uniqueidentifier

		,Name_Ticket_List		varchar(255)

		,StartStamp				datetime

		,EndStamp				datetime

	)



	

	INSERT INTO @tmp_TicketLists (GUID_Ticket_List, Name_Ticket_List)

	SELECT	 tl.GUID_Process_Ticket_Lists

			,tl.Name_Process_Ticket_Lists

	FROM dbo.func_Token_Process_Ticket_Lists(@GUID_Type_TicketList) tl

	INNER JOIN semtbl_Token_Attribute ON semtbl_Token_Attribute.GUID_Token = tl.GUID_Process_Ticket_Lists

	INNER JOIN semtbl_Token_Attribute_Bit ON semtbl_Token_Attribute_Bit.GUID_TokenAttribute = semtbl_Token_Attribute.GUID_TokenAttribute

	WHERE semtbl_Token_Attribute.GUID_Attribute = @GUID_Attribute_Standard

	AND semtbl_Token_Attribute_Bit.Val = 0



	UPDATE tl

	SET StartStamp = semtbl_Token_Attribute_DateTime.Val

	FROM @tmp_TicketLists tl

	INNER JOIN semtbl_Token_Attribute ON tl.GUID_Ticket_List = semtbl_Token_Attribute.GUID_Token

	INNER JOIN semtbl_Token_Attribute_DateTime ON semtbl_Token_Attribute_DateTime.GUID_TokenAttribute = semtbl_Token_Attribute.GUID_TokenAttribute

	WHERE semtbl_Token_Attribute.GUID_Attribute = @GUID_Attribute_Startdate

	

	UPDATE tl

	SET StartStamp = semtbl_Token_Attribute_DateTime.Val

	FROM @tmp_TicketLists tl

	INNER JOIN semtbl_Token_Attribute ON tl.GUID_Ticket_List = semtbl_Token_Attribute.GUID_Token

	INNER JOIN semtbl_Token_Attribute_DateTime ON semtbl_Token_Attribute_DateTime.GUID_TokenAttribute = semtbl_Token_Attribute.GUID_TokenAttribute

	WHERE semtbl_Token_Attribute.GUID_Attribute = @GUID_Attribute_EndDate

	

	DELETE FROM dbo.chngtbl_TicketList



	;WITH hierarchy AS (	

		SELECT	DISTINCT 

				 tl_c.GUID_Ticket_List AS GUID_Ticket_List

				,tl_c.Name_Ticket_List AS Name_Ticket_List

				,tl_p.GUID_Ticket_List AS GUID_Ticket_List_Parent

				,tl_c.StartStamp

				,tl_c.EndStamp

		FROM @tmp_TicketLists tl_c

		LEFT OUTER JOIN semtbl_Token_Token ON semtbl_Token_Token.GUID_Token_Right = tl_c.GUID_Ticket_List AND semtbl_Token_Token.GUID_RelationType = ''e9711603-47db-44d8-a476-fe88290639a4''

		LEFT OUTER JOIN @tmp_TicketLists tl_p ON semtbl_Token_Token.GUID_Token_Left =  tl_p.GUID_Ticket_List

		WHERE tl_p.GUID_Ticket_List IS NULL



		UNION ALL

		

		SELECT	 tl_c.GUID_Ticket_List

				,tl_c.Name_Ticket_List

				,p.GUID_Ticket_List_Parent

				,tl_c.StartStamp

				,tl_c.EndStamp

		FROM hierarchy p

		INNER JOIN semtbl_Token_Token ON p.GUID_Ticket_List_Parent = semtbl_Token_Token.GUID_Token_Left AND semtbl_Token_Token.GUID_RelationType = ''e9711603-47db-44d8-a476-fe88290639a4''

		INNER JOIN @tmp_TicketLists tl_c ON semtbl_Token_Token.GUID_Token_Right = tl_c.GUID_Ticket_List)

		

		INSERT INTO chngtbl_TicketList

		SELECT   GUID_Ticket_List

				,Name_Ticket_List

				,GUID_Ticket_List_Parent

				,StartStamp

				,EndStamp 

				,grp.GUID_Group

		FROM hierarchy

		INNER JOIN semtbl_Token_Token ListGroup ON ListGroup.GUID_Token_left = hierarchy.GUID_Ticket_List AND GUID_RelationType = @GUID_RelationType_belongsTo

		INNER JOIN dbo.func_Token_Group(@GUID_Type_Group) grp ON grp.GUID_Group = ListGroup.GUID_Token_Right 

			

	INSERT INTO chngtbl_Ticket_TicketList

	SELECT GUID_Token_Left, GUID_Token_Right, semtbl_Token_Token.OrderID

	FROM chngtbl_TicketList

	INNER JOIN semtbl_Token_Token ON chngtbl_TicketList.GUID_TicketList = semtbl_Token_Token.GUID_Token_Left

	INNER JOIN dbo.func_Token_Process_Ticket(@GUID_Type_ProcessTickets) t ON semtbl_Token_Token.GUID_Token_Right = t.GUID_Process_Ticket

	WHERE GUID_RelationType = @GUID_RelationType_contains

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[orgview_Item_Type]'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE VIEW dbo.orgview_Item_Type

AS

SELECT DISTINCT 

                      dbo.chngtbl_Item_Type.GUID_Type, dbo.chngtbl_Item_Type.Name_Type, dbo.chngtbl_Item_Type.GUID_Type_Parent, 

                      dbo.chngtbl_Logentry_FinishedWith.GUID_LogState, dbo.chngview_TicketList.GUID_Ticket AS GUID_Ticket_Exist, dbo.chngtbl_Item_Type.IsParent

FROM         dbo.chngtbl_Item_Type LEFT OUTER JOIN

                      dbo.chngview_TicketList ON dbo.chngtbl_Item_Type.GUID_Type = dbo.chngview_TicketList.GUID_Item_belongsTo AND 

                      dbo.chngtbl_Item_Type.GUID_Ticket = dbo.chngview_TicketList.GUID_Ticket LEFT OUTER JOIN

                      dbo.chngtbl_Logentry_FinishedWith ON dbo.chngtbl_Item_Type.GUID_Ticket = dbo.chngtbl_Logentry_FinishedWith.GUID_Ticket
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_State_Of_ProcessLog]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_State_Of_ProcessLog]

	-- Add the parameters for the stored procedure here

	

	@GUID_ProcessLog				uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Type_LogEntry				uniqueidentifier;

	DECLARE @GUID_Type_LogState				uniqueidentifier;

	DECLARE @GUID_RelationType_provides		uniqueidentifier;

	DECLARE @GUID_RelationType_finishedWith	uniqueidentifier;

	

	SET @GUID_Type_LogEntry				= dbo.dbg_Type_Logentry();

	SET @GUID_Type_LogState				= dbo.dbg_Type_Logstate();

	SET @GUID_RelationType_provides		= dbo.dbg_RelationType_provides();

	SET @GUID_RelationType_finishedWith	= dbo.dbg_RelationType_finished_with();

	

	PRINT @GUID_Type_LogEntry;

	PRINT @GUID_Type_LogState;

	PRINT @GUID_RelationType_provides;

	PRINT @GUID_RelationType_finishedWith;

	

    -- Insert statements for procedure here

	SELECT     func_Token_Logstate_1.GUID_Logstate, func_Token_Logstate_1.Name_Logstate, func_Token_Logstate_1.GUID_Type_Logstate

FROM         dbo.func_Token_Logentry(@GUID_Type_LogEntry) AS func_Token_Logentry_1 INNER JOIN

                      semtbl_Token_Token AS ProcessLog_To_LogEntry ON func_Token_Logentry_1.GUID_Logentry = ProcessLog_To_LogEntry.GUID_Token_Right INNER JOIN

                      semtbl_Token_Token AS LogEntry_To_LogState ON func_Token_Logentry_1.GUID_Logentry = LogEntry_To_LogState.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Logstate(@GUID_Type_LogState) AS func_Token_Logstate_1 ON 

                      LogEntry_To_LogState.GUID_Token_Right = func_Token_Logstate_1.GUID_Logstate

WHERE     (ProcessLog_To_LogEntry.GUID_RelationType = @GUID_RelationType_finishedWith) AND 

                      (LogEntry_To_LogState.GUID_RelationType = @GUID_RelationType_provides) AND (ProcessLog_To_LogEntry.GUID_Token_Left = @GUID_ProcessLog)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_related_Logentries_finishedWith]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE FUNCTION func_related_Logentries_finishedWith

(	

	-- Add the parameters for the function here

	 @GUID_Type_LogEntry				uniqueidentifier

	,@GUID_RelationType_finishedWith	uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     func_Token_Logentry_1.GUID_Logentry, func_Token_Logentry_1.Name_Logentry, func_Token_Logentry_1.GUID_Type_Logentry, To_Logentry.GUID_Token_Left

FROM         dbo.func_Token_Logentry(@GUID_Type_LogEntry) AS func_Token_Logentry_1 INNER JOIN

                      semtbl_Token_Token AS To_Logentry ON func_Token_Logentry_1.GUID_Logentry = To_Logentry.GUID_Token_Right

WHERE     (To_Logentry.GUID_RelationType = @GUID_RelationType_finishedWith)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ProcessTree]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_ProcessTree]

	-- Add the parameters for the stored procedure here

	@GUID_Process_Parent				uniqueidentifier,

	@GUID_Type_Process					uniqueidentifier,

	@GUID_RelationType_superordinate	uniqueidentifier,

	@intLevel							int,

	@bitFullTree						bit

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	

	

	DECLARE @GUID_Process	uniqueidentifier;

	DECLARE @tmptbl_Process TABLE(

		id_Process			int IDENTITY(1,1),

		BatGUID_Process		uniqueidentifier,

		Bat_Name			uniqueidentifier,

		GUID_Type_Process	uniqueidentifier,

		get_Subs			bit,

		Level				int);

	

	

    -- Insert statements for procedure here



    SET @intLevel = @intLevel + 1;

    INSERT INTO @tmptbl_Process (BatGUID_Process,Bat_Name,GUID_Type_Process,Level,get_Subs)

		SELECT     GUID_Process, Name_Process, GUID_Type_Process, @intLevel, 1 AS get_Subs

			FROM         dbo.func_Process_subordinate(

				@GUID_Type_Process, 

				@GUID_RelationType_superordinate, 

				@GUID_Process_Parent) AS func_Process_subordinate_1

			ORDER BY Name_Process;

	

	

	IF @bitFullTree = 1

	BEGIN

		SET @intLevel = @intLevel + 1;

		DECLARE cur_Process CURSOR FOR

			SELECT BatGUID_Process FROM @tmptbl_Process WHERE get_subs=1;

			

		OPEN cur_Process;

		FETCH NEXT FROM cur_Process INTO

			@GUID_Process;

		WHILE @@FETCH_STATUS=0

		BEGIN



			UPDATE @tmptbl_Process SET get_Subs=0;

			INSERT INTO @tmptbl_Process (BatGUID_Process,Bat_Name,GUID_Type_Process,Level,get_Subs)

					SELECT     GUID_Process, Name_Process, GUID_Type_Process, @intLevel, 1 AS get_Subs

					FROM         dbo.func_Process_subordinate(

						@GUID_Type_Process, 

						@GUID_RelationType_superordinate, 

						@GUID_Process) AS func_Process_subordinate_1

					ORDER BY Name_Process;

					

			FETCH NEXT FROM cur_Process INTO

				@GUID_Process;

		END

		CLOSE cur_Process;

		DEALLOCATE cur_Process;

	END

	SELECT * FROM @tmptbl_Process ORDER BY id_Process;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_ProcessTree]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_ProcessTree]

	-- Add the parameters for the stored procedure here

	@GUID_Process_Parent				uniqueidentifier,

	@intLevel							int,

	@bitFullTree						bit

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	

	DECLARE @GUID_Type_Process					uniqueidentifier;

	DECLARE @GUID_RelationType_superordinate	uniqueidentifier;

	

	SET @GUID_Type_Process						= dbo.dbg_Type_Process();

	SET @GUID_RelationType_superordinate		= dbo.dbg_RelationType_superordinate();

	

	PRINT @GUID_Type_Process;

	PRINT @GUID_RelationType_superordinate;

	

	DECLARE @bitGoOn	bit;

	DECLARE @tmptbl_Process TABLE(

		id_Process			int,

		BatGUID_Process		uniqueidentifier,

		Bat_Name			varchar(255),

		GUID_Type_Process	uniqueidentifier,

		Level				int);

		

	DECLARE @tmptbl_Process_tmp TABLE(

		id_Process			int IDENTITY(1,1),

		BatGUID_Process		uniqueidentifier,

		Bat_Name			varchar(255),

		GUID_Type_Process	uniqueidentifier,

		Level				int);

	

	

    -- Insert statements for procedure here

    SET @bitGoOn = 1;

	WHILE @bitGoOn = 1

	BEGIN

		SET @intLevel = @intLevel + 1;

		DELETE FROM @tmptbl_Process_tmp;

		INSERT INTO @tmptbl_Process_tmp (BatGUID_Process,Bat_Name,GUID_Type_Process,Level)

			SELECT	GUID_Process, 

					Name_Process, 

					GUID_Type_Process, 

					@intLevel

				FROM         dbo.func_Process_subordinate(

					@GUID_Type_Process, 

					@GUID_RelationType_superordinate, 

					@GUID_Process_Parent) AS func_Process_subordinate_1

				ORDER BY Name_Process;

	

		SET @bitGoOn = 0;

		IF @bitFullTree = 1 

		BEGIN

			DECLARE cur_Processes CURSOR FOR

				SELECT * FROM @tmptbl_Process_tmp;

				

			OPEN cur_Processes;

			-- Jeden Satz der temporären Prozessliste durchgehen

				-- 

			CLOSE cur_Processes;

			DEALLOCATE cur_Processes;

		END

		

	END

	

	SELECT * FROM @tmptbl_Process ORDER BY id_Process;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[chngview_TicketList]'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE VIEW dbo.chngview_TicketList

AS

SELECT     dbo.chngtbl_Ticket.GUID_Ticket, dbo.chngtbl_Ticket.Name_Ticket, dbo.chngtbl_Ticket.GUID_Group, dbo.chngtbl_Ticket.Name_Group, dbo.chngtbl_ID.ID, 

                      dbo.chngtbl_Process.GUID_Process, dbo.chngtbl_Process.Name_Process, dbo.chngtbl_Item_belongsTo.GUID_Item_belongsTo, 

                      dbo.chngtbl_Item_belongsTo.Name_Item_belongsTo, dbo.chngtbl_Item_belongsTo.GUID_ItemType_belongsTo, dbo.chngtbl_LastProcess.GUID_LastProcess, 

                      dbo.chngtbl_LastProcess.Name_LastProcess, dbo.chngtbl_LastProcess.GUID_Type_LastProcess, dbo.chngtbl_Logentry_LastDone.GUID_LogEntry_LastDone, 

                      dbo.chngtbl_Logentry_LastDone.Val_LogEntry_LastDone, dbo.chngtbl_Logentry_LastDone.Msg_LogEntry_LastDone, dbo.chngtbl_Logentry_Start.GUID_LogEntry, 

                      dbo.chngtbl_Logentry_Start.dateTime_TimeStamp, dbo.chngtbl_Logentry_LastDone.GUID_LogState_LastDone, 

                      dbo.chngtbl_Logentry_LastDone.Name_LogState_LastDone, dbo.chngtbl_Logentry_FinishedWith.dateTime_TimeStamp AS dateTime_TimeStamp_Finished, 

                      dbo.chngtbl_Logentry_FinishedWith.GUID_LogState AS GUID_LogState_Finished, dbo.chngtbl_Logentry_FinishedWith.Name_LogState AS Name_LogState_Finished, 

                      ISNULL(dbo.chngview_TicketCount.TicketCount, 0) AS TicketCount

FROM         dbo.chngtbl_Ticket INNER JOIN

                      dbo.chngtbl_ID ON dbo.chngtbl_Ticket.GUID_Ticket = dbo.chngtbl_ID.GUID_Ticket INNER JOIN

                      dbo.chngtbl_Item_belongsTo ON dbo.chngtbl_Ticket.GUID_Ticket = dbo.chngtbl_Item_belongsTo.GUID_Ticket INNER JOIN

                      dbo.chngtbl_LastProcess ON dbo.chngtbl_Ticket.GUID_Ticket = dbo.chngtbl_LastProcess.GUID_Ticket INNER JOIN

                      dbo.chngtbl_Logentry_LastDone ON dbo.chngtbl_Ticket.GUID_Ticket = dbo.chngtbl_Logentry_LastDone.GUID_Ticket INNER JOIN

                      dbo.chngtbl_Process ON dbo.chngtbl_Ticket.GUID_Ticket = dbo.chngtbl_Process.GUID_Ticket INNER JOIN

                      dbo.chngtbl_Logentry_Start ON dbo.chngtbl_Ticket.GUID_Ticket = dbo.chngtbl_Logentry_Start.GUID_Ticket LEFT OUTER JOIN

                      dbo.chngview_TicketCount ON dbo.chngtbl_Ticket.GUID_Ticket = dbo.chngview_TicketCount.GUID_Ticket LEFT OUTER JOIN

                      dbo.chngtbl_Logentry_FinishedWith ON dbo.chngtbl_Logentry_FinishedWith.GUID_Ticket = dbo.chngtbl_Ticket.GUID_Ticket

GROUP BY dbo.chngtbl_Ticket.GUID_Ticket, dbo.chngtbl_Ticket.Name_Ticket, dbo.chngtbl_Ticket.GUID_Group, dbo.chngtbl_Ticket.Name_Group, dbo.chngtbl_ID.ID, 

                      dbo.chngtbl_Process.GUID_Process, dbo.chngtbl_Process.Name_Process, dbo.chngtbl_Item_belongsTo.GUID_Item_belongsTo, 

                      dbo.chngtbl_Item_belongsTo.Name_Item_belongsTo, dbo.chngtbl_Item_belongsTo.GUID_ItemType_belongsTo, dbo.chngtbl_LastProcess.GUID_LastProcess, 

                      dbo.chngtbl_LastProcess.Name_LastProcess, dbo.chngtbl_LastProcess.GUID_Type_LastProcess, dbo.chngtbl_Logentry_LastDone.GUID_LogEntry_LastDone, 

                      dbo.chngtbl_Logentry_LastDone.Val_LogEntry_LastDone, dbo.chngtbl_Logentry_LastDone.Msg_LogEntry_LastDone, dbo.chngtbl_Logentry_Start.GUID_LogEntry, 

                      dbo.chngtbl_Logentry_Start.dateTime_TimeStamp, dbo.chngtbl_Logentry_LastDone.GUID_LogState_LastDone, 

                      dbo.chngtbl_Logentry_LastDone.Name_LogState_LastDone, dbo.chngtbl_Logentry_FinishedWith.dateTime_TimeStamp, 

                      dbo.chngtbl_Logentry_FinishedWith.GUID_LogState, dbo.chngtbl_Logentry_FinishedWith.Name_LogState, ISNULL(dbo.chngview_TicketCount.TicketCount, 0)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[chngview_TicketList_TicketLists]'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE VIEW dbo.chngview_TicketList_TicketLists

AS

SELECT     dbo.chngview_TicketList.GUID_Ticket, dbo.chngview_TicketList.Name_Ticket, dbo.chngview_TicketList.ID, dbo.chngtbl_Ticket_TicketList.OrderID AS [Ticket-Order], 

                      dbo.chngview_TicketList.GUID_Group, dbo.chngview_TicketList.Name_Group, dbo.chngview_TicketList.GUID_Process, dbo.chngview_TicketList.Name_Process, 

                      dbo.chngview_TicketList.GUID_Item_belongsTo, dbo.chngview_TicketList.Name_Item_belongsTo, dbo.chngview_TicketList.GUID_ItemType_belongsTo, 

                      dbo.chngview_TicketList.GUID_LastProcess, dbo.chngview_TicketList.Name_LastProcess, dbo.chngview_TicketList.GUID_Type_LastProcess, 

                      dbo.chngview_TicketList.GUID_LogEntry_LastDone, dbo.chngview_TicketList.Val_LogEntry_LastDone, dbo.chngview_TicketList.Msg_LogEntry_LastDone, 

                      dbo.chngview_TicketList.GUID_LogEntry, dbo.chngview_TicketList.dateTime_TimeStamp, dbo.chngview_TicketList.GUID_LogState_LastDone, 

                      dbo.chngview_TicketList.Name_LogState_LastDone, dbo.chngview_TicketList.dateTime_TimeStamp_Finished, dbo.chngview_TicketList.GUID_LogState_Finished, 

                      dbo.chngview_TicketList.Name_LogState_Finished, dbo.chngtbl_TicketList.GUID_TicketList, dbo.chngtbl_TicketList.Name_TicketList

FROM         dbo.chngview_TicketList INNER JOIN

                      dbo.chngtbl_Ticket_TicketList ON dbo.chngtbl_Ticket_TicketList.GUID_Ticket = dbo.chngview_TicketList.GUID_Ticket INNER JOIN

                      dbo.chngtbl_TicketList ON dbo.chngtbl_TicketList.GUID_TicketList = dbo.chngtbl_Ticket_TicketList.GUID_TicketList
'
END
GO
EXEC sp_addextendedproperty 
		@name = SchemaVersion, @value = '0.0.0.19';
GO
EXEC sp_addextendedproperty 
		@name = SemDB, @value = 'Yes';
GO
