CREATE DATABASE sem_db_work_filesystem_manager
GO
use [sem_db_change]
use [sem_db_work_filesystem_manager]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dtbl_CheckedOut]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[dtbl_CheckedOut](
	[GUID_File] [uniqueidentifier] NOT NULL,
	[Name_File] [varchar](255) NOT NULL,
	[Path_File] [varchar](255) NOT NULL,
	[dateChanged] [datetime] NOT NULL,
	[save] [bit] NOT NULL,
 CONSTRAINT [PK_dtbl_CheckedOut] PRIMARY KEY CLUSTERED 
(
	[GUID_File] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fltbl_Compare]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[fltbl_Compare](
	[Path] [nvarchar](500) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[HashString] [varchar](4000) NOT NULL,
	[Found] [bit] NOT NULL,
	[GUID_File] [uniqueidentifier] NULL
) ON [PRIMARY];

ALTER TABLE [dbo].[fltbl_Compare] ADD  DEFAULT ((1)) FOR [Found];
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Real]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Real] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Real]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Bit]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Bit] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Bit]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Time]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_attribute_time] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_attribute_time]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Date]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Date] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Date]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_VARCHARMAX] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_RelationType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_RelationType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_RelationType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Type_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Type_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_AttributeType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_AttributeType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_AttributeType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Datetime]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Datetime] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Datetime]'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Date]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Date] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Date]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Bit]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Bit] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Bit]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_VarcharMax]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_varcharMAX] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_varcharMAX]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_ORType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_ORType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_ORType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Varchar255]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_varchar255] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_varchar255]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_OR]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Datetime]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_attribute_datetime] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_attribute_datetime]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_AttributeType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_AttributeType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_AttributeType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Time]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Time] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Time]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Varchar255]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Varchar255] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Varchar255]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Type_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Type_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type_OR]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Int]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Int] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Int]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_RelationType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_RelationType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_RelationType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Int]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Int] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Int]'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Server_State]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Server_State] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Server_State		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Server_State, Name_Token AS Name_Server_State, GUID_Type AS GUID_Type_Server_State
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Server_State)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_watch]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_watch]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''watch'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Server_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Server_Type] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Server_Type		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Server_Type, Name_Token AS Name_Server_Type, GUID_Type AS GUID_Type_Server_Type
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Server_Type)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_related_Folder_of_Server]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION func_related_Folder_of_Server 
(	
	-- Add the parameters for the function here
	@GUID_Type_Folder				uniqueidentifier,
	@GUID_RelationType_FileShare	uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token_Token.GUID_Token_Left AS GUID_Server, semtbl_Token.GUID_Token AS GUID_Folder, semtbl_Token.Name_Token AS Name_Folder, 
                      semtbl_Token.GUID_Type AS GUID_Type_Folder
FROM         semtbl_Token INNER JOIN
                      semtbl_Token_Token ON semtbl_Token.GUID_Token = semtbl_Token_Token.GUID_Token_Right
WHERE     (semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_FileShare) AND (semtbl_Token.GUID_Type = @GUID_Type_Folder)
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_local_File_By_GUID]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].get_local_File_By_GUID
(
	@GUID_File uniqueidentifier
)
AS
	SET NOCOUNT ON;
SELECT        GUID_File, Name_File, Path_File, dateChanged, [save]
FROM            dtbl_CheckedOut
WHERE        (GUID_File = @GUID_File)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_File]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_File] 

(	

	-- Add the parameters for the function here

	@GUID_Type_File		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_File, Name_Token AS Name_File, GUID_Type AS GUID_Type_File

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_File)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Path]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Path] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Path		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Path, Name_Token AS Name_Path, GUID_Type AS GUID_Type_Path
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Path)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Filesystem_Management]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Filesystem_Management] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Filesystem_Management		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Filesystem_Management, Name_Token AS Name_Filesystem_Management, GUID_Type AS GUID_Type_Filesystem_Management
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Filesystem_Management)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Files_Of_Folder]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Files_Of_Folder] 

	-- Add the parameters for the stored procedure here

	@Path		nvarchar(500)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

    UPDATE fltbl_Compare

    SET Found=0

    WHERE Path LIKE @Path + ''%''

    

	SELECT Path, Name, HashString, Found, GUID_File

	FROM fltbl_Compare

	WHERE Path LIKE @Path + ''%''

END
'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Blob]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Blob]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Blob'';

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
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[flview_Files]'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE VIEW dbo.flview_Files

AS

SELECT     Path, Name, GUID_File, HashString

FROM         dbo.fltbl_Compare
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_File]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_File]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''File'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Filesystem_Management]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Filesystem_Management]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Filesystem-Management'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Extensions]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Extensions] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Extensions		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Extensions, Name_Token AS Name_Extensions, GUID_Type AS GUID_Type_Extensions
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Extensions)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_related_Folder_L2]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_related_Folder_L2] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Folder					uniqueidentifier,
	@GUID_RelationType_isSubordinated	uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token_Token.GUID_Token_Right AS GUID_Folder_Parent, semtbl_Token.GUID_Token AS GUID_Folder, semtbl_Token.Name_Token AS Name_Folder, 
                      semtbl_Token.GUID_Type AS GUID_Type_Folder
FROM         semtbl_Token_Token INNER JOIN
                      semtbl_Token ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token.GUID_Token
WHERE     (semtbl_Token.GUID_Type = @GUID_Type_Folder) AND (semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_isSubordinated)
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_BlobDirWatcher]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_BlobDirWatcher]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''BlobDirWatcher'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_ends_with]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_ends_with]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''ends with'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_related_Drive_of_Server]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_related_Drive_of_Server]
(	
	-- Add the parameters for the function here
	@GUID_Type_Drive					uniqueidentifier,
	@GUID_RelationType_isSubordinated	uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token_Token.GUID_Token_Right AS GUID_Server, semtbl_Token.GUID_Token AS GUID_Drive, semtbl_Token.Name_Token AS Name_Drive, 
                      semtbl_Token.GUID_Type AS GUID_Type_Drive
FROM         semtbl_Token INNER JOIN
                      semtbl_Token_Token ON semtbl_Token.GUID_Token = semtbl_Token_Token.GUID_Token_Left
WHERE     (semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_isSubordinated) AND (semtbl_Token.GUID_Type = @GUID_Type_Drive)
)
'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_related_Attribute_Blob]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION func_related_Attribute_Blob 
(	
	-- Add the parameters for the function here
	@GUID_Attribute_Blob		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     File__Blob.GUID_Token AS GUID_File, File__Blob.GUID_Attribute, File__Blob_Val.GUID_TokenAttribute AS GUID_TokenAttribute_Blob, 
                      File__Blob_Val.val AS [is Blob]
		FROM         semtbl_Token_Attribute AS File__Blob INNER JOIN
							  semtbl_Token_Attribute_Bit AS File__Blob_Val ON File__Blob.GUID_TokenAttribute = File__Blob_Val.GUID_TokenAttribute
		WHERE     (File__Blob.GUID_Attribute = @GUID_Attribute_Blob)
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_BlobDirWatcher]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_BlobDirWatcher] 
(	
	-- Add the parameters for the function here
	@GUID_Type_BlobDirWatcher		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_BlobDirWatcher, Name_Token AS Name_BlobDirWatcher, GUID_Type AS GUID_Type_BlobDirWatcher
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_BlobDirWatcher)
)'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Extensions]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Extensions]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Extensions'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Folder]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Folder] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Folder		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Folder, Name_Token AS Name_Folder, GUID_Type AS GUID_Type_Folder

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Folder)

)
'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Extensions]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Extensions]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Extensions'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[local_get_Files_To_Save]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[local_get_Files_To_Save]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        *
FROM            dtbl_CheckedOut
WHERE        ([Save] = 1)
END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Drive]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Drive] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Drive		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Drive, Name_Token AS Name_Drive, GUID_Type AS GUID_Type_Drive
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Drive)
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Extensions]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Extensions] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Extensions		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Extensions, Name_Token AS Name_Extensions, GUID_Type AS GUID_Type_Extensions

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Extensions)

)'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_File]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_File] 

(	

	-- Add the parameters for the function here

	@GUID_Type_File		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_File, Name_Token AS Name_File, GUID_Type AS GUID_Type_File

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_File)

)
'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Server_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Server_Type]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Server-Type'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_is_checkout_by]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_is_checkout_by]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''is checkout by'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Server_State]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Server_State]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Server-State'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_Fileshare]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_Fileshare]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''Fileshare'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Folder]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Folder]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Folder'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_File]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_File]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''File'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[local_del_File]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE local_del_File
	-- Add the parameters for the stored procedure here
	@GUID_File uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM dtbl_CheckedOut
WHERE        (GUID_File = @GUID_File)
END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[upd_GUIDFile]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[upd_GUIDFile]

	-- Add the parameters for the stored procedure here

	 @Path			nvarchar(500)

	,@Name			nvarchar(255)

	,@GUID_File		uniqueidentifier

	,@HashString	varchar(4000)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	UPDATE fltbl_Compare

	SET GUID_File = @GUID_File, HashString = @HashString, Found = 1

	WHERE Path = @Path

	AND Name=@Name

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Drive]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Drive]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Drive'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[del_NotFound_Files]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'

-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[del_NotFound_Files]

	-- Add the parameters for the stored procedure here

	 @Path		nvarchar(500)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	DELETE FROM fltbl_Compare

	WHERE Path LIKE @Path + ''%''

	AND Found=0

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Path]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Path]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Path'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[local_upd_Save]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE local_upd_Save
	-- Add the parameters for the stored procedure here
	@GUID_File		uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE       dtbl_CheckedOut
SET                [Save] = 1
WHERE        (GUID_File = @GUID_File)
END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_is_subordinated]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_is_subordinated]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''is subordinated'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_PathToWatch_Of_BaseConfig]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'



-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_PathToWatch_Of_BaseConfig] 

	-- Add the parameters for the stored procedure here

	

	@GUID_BaseConfig		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Type_BlobDirWatcher		uniqueidentifier;

	DECLARE @GUID_Type_Path					uniqueidentifier;

	DECLARE @GUID_RelationType_belongsTo	uniqueidentifier;

	DECLARE @GUID_RelationType_Watch		uniqueidentifier;

	

	SET @GUID_Type_BlobDirWatcher		= dbo.dbg_Type_BlobDirWatcher();

	SET @GUID_Type_Path					= dbo.dbg_Type_Path();

	SET @GUID_RelationType_belongsTo	= dbo.dbg_RelationType_belongs_to();

	SET @GUID_RelationType_Watch		= dbo.dbg_RelationType_watch();

	

	PRINT @GUID_Type_BlobDirWatcher;

	PRINT @GUID_Type_Path;

	PRINT @GUID_RelationType_belongsTo;

	PRINT @GUID_RelationType_Watch;

	

    -- Insert statements for procedure here

	SELECT     func_Token_BlobDirWatcher_1.GUID_BlobDirWatcher, func_Token_BlobDirWatcher_1.Name_BlobDirWatcher, 

                      func_Token_BlobDirWatcher_1.GUID_Type_BlobDirWatcher, func_Token_Path_1.GUID_Path, func_Token_Path_1.Name_Path, 

                      func_Token_Path_1.GUID_Type_Path

FROM         dbo.func_Token_BlobDirWatcher(@GUID_Type_BlobDirWatcher) AS func_Token_BlobDirWatcher_1 INNER JOIN

                      semtbl_Token_Token AS BlobDirWatcher_To_Path ON func_Token_BlobDirWatcher_1.GUID_BlobDirWatcher = BlobDirWatcher_To_Path.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Path(@GUID_Type_Path) AS func_Token_Path_1 ON BlobDirWatcher_To_Path.GUID_Token_Right = func_Token_Path_1.GUID_Path

WHERE     (BlobDirWatcher_To_Path.GUID_RelationType = @GUID_RelationType_Watch) AND (func_Token_BlobDirWatcher_1.GUID_BlobDirWatcher = @GUID_BaseConfig)

END




'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_get_GUID_DBOnServer]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_get_GUID_DBOnServer] 
	-- Add the parameters for the stored procedure here
	@GUID_Type_DatabaseOnServer			uniqueidentifier,
	@GUID_Type_Database					uniqueidentifier,
	@GUID_Type_Server					uniqueidentifier,
	@GUID_RelationType_belongsTo		uniqueidentifier,
	@GUID_RelationType_locatedIn		uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @Name_Server	varchar(255);
	DECLARE @Name_DB		varchar(255);
	
	SET @Name_Server = @@SERVERNAME;
	SET @Name_DB = DB_NAME();
	
	
    -- Insert statements for procedure here
	
    -- Insert statements for procedure here
	SELECT     func_Token_Database_on_Server_1.GUID_Database_on_Server
		FROM         dbo.func_Token_Database_on_Server(@GUID_Type_DatabaseOnServer) AS func_Token_Database_on_Server_1 INNER JOIN
							  semtbl_Token_Token AS DatabaseOnServer_To_Database ON 
							  func_Token_Database_on_Server_1.GUID_Database_on_Server = DatabaseOnServer_To_Database.GUID_Token_Left INNER JOIN
							  dbo.func_Token_Database(@GUID_Type_Database) AS func_Token_Database_1 ON 
							  DatabaseOnServer_To_Database.GUID_Token_Right = func_Token_Database_1.GUID_Database INNER JOIN
							  semtbl_Token_Token AS DatabaseOnServer_To_Server ON 
							  func_Token_Database_on_Server_1.GUID_Database_on_Server = DatabaseOnServer_To_Server.GUID_Token_Left INNER JOIN
							  dbo.func_Token_Server(@GUID_Type_Server) AS func_Token_Server_1 ON 
							  DatabaseOnServer_To_Server.GUID_Token_Right = func_Token_Server_1.GUID_Server
		WHERE     (func_Token_Database_1.Name_Database = @Name_DB) AND (func_Token_Server_1.Name_Server+''\SQLEXPRESS'' = @Name_Server) AND 
							  (DatabaseOnServer_To_Database.GUID_RelationType = @GUID_RelationType_belongsTo) AND 
							  (DatabaseOnServer_To_Server.GUID_RelationType = @GUID_RelationType_locatedIn)
END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_File_OutChecked]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[dbg_File_OutChecked]
	-- Add the parameters for the stored procedure here
	
	@GUID_File						uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @GUID_Type_Server				uniqueidentifier;
	DECLARE @GUID_RelationType_isCheckOutBy	uniqueidentifier;
	
	SET @GUID_Type_Server				= dbo.dbg_Type_Server();
	SET @GUID_RelationType_isCheckOutBy	= dbo.dbg_RelationType_is_checkout_by();
	
	PRINT @GUID_Type_Server;
	PRINT @GUID_RelationType_isCheckOutBy;
	
    -- Insert statements for procedure here
	SELECT     func_Token_Server_1.GUID_Server, func_Token_Server_1.Name_Server, func_Token_Server_1.GUID_Type_Server
FROM         semtbl_Token_Token AS File_To_Server INNER JOIN
                      dbo.func_Token_Server(@GUID_Type_Server) AS func_Token_Server_1 ON File_To_Server.GUID_Token_Right = func_Token_Server_1.GUID_Server
WHERE     (File_To_Server.GUID_Token_Left = @GUID_File) AND (File_To_Server.GUID_RelationType = @GUID_RelationType_isCheckOutBy)
END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_related_Folder_L2]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbg_related_Folder_L2 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @GUID_Type_Folder					uniqueidentifier;
	DECLARE @GUID_RelationType_isSubordinated	uniqueidentifier;

	SET @GUID_Type_Folder					= dbo.func_Named_GUIDType(''Folder'');
	SET @GUID_RelationType_isSubordinated	= dbo.func_Named_GUIDRelationType(''is subordinated'');

	PRINT @GUID_Type_Folder;
	PRINT @GUID_RelationType_isSubordinated;

    -- Insert statements for procedure here
	SELECT * FROM func_related_Folder_L2(
		@GUID_Type_Folder,
		@GUID_RelationType_isSubordinated)
END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_related_File_By_GUID_Folder]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_related_File_By_GUID_Folder] 

	-- Add the parameters for the stored procedure here

	@GUID_Attribute_Blob				uniqueidentifier,

	@GUID_Type_File						uniqueidentifier,

	@GUID_Type_Folder					uniqueidentifier,

	@GUID_RelationType_isSubordinated	uniqueidentifier,

	@GUID_Token_Folder					uniqueidentifier = null,

	@GUID_Token_File					uniqueidentifier = null,

	@Name_Token_File					varchar(255) = null

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

    	IF @GUID_Token_Folder IS NOT NULL

    BEGIN

		

		SELECT   semtbl_Token.GUID_Token AS GUID_File

				,semtbl_Token.Name_Token AS Name_File

				,semtbl_Token.GUID_Type AS GUID_Type_File

				,semtbl_Token_Token.GUID_Token_Right AS GUID_Token_Folder

				,func_related_Attribute_Blob_1.GUID_TokenAttribute_Blob

				,func_related_Attribute_Blob_1.[is Blob]

		FROM         semtbl_Token INNER JOIN

							  semtbl_Token_Token ON semtbl_Token.GUID_Token = semtbl_Token_Token.GUID_Token_Left LEFT OUTER JOIN

							  dbo.func_related_Attribute_Blob(@GUID_Attribute_Blob) AS func_related_Attribute_Blob_1 ON semtbl_Token.GUID_Token = func_related_Attribute_Blob_1.GUID_File

		WHERE     (semtbl_Token.GUID_Type = @GUID_Type_File) 

		AND (semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_isSubordinated)

		AND (semtbl_Token_Token.GUID_Token_Right = @GUID_Token_Folder)

	END

	ELSE

	BEGIN

		IF @GUID_Token_File IS NOT NULL

		BEGIN

			SELECT   semtbl_Token.GUID_Token AS GUID_File

				,semtbl_Token.Name_Token AS Name_File

				,semtbl_Token.GUID_Type AS GUID_Type_File

				,CAST(NULL AS uniqueidentifier) AS GUID_Token_Folder

				,func_related_Attribute_Blob_1.GUID_TokenAttribute_Blob

				,func_related_Attribute_Blob_1.[is Blob]

			FROM         semtbl_Token LEFT OUTER JOIN

								  dbo.func_related_Attribute_Blob(@GUID_Attribute_Blob) AS func_related_Attribute_Blob_1 ON semtbl_Token.GUID_Token = func_related_Attribute_Blob_1.GUID_File

			WHERE     (semtbl_Token.GUID_Type = @GUID_Type_File) 

			AND (semtbl_Token.GUID_Token = @GUID_Token_File)

		END

		ELSE

		BEGIN

			IF @Name_Token_File IS NOT NULL 

			BEGIN

				SELECT   semtbl_Token.GUID_Token AS GUID_File

					,semtbl_Token.Name_Token AS Name_File

					,semtbl_Token.GUID_Type AS GUID_Type_File

					,CAST(NULL AS uniqueidentifier) AS GUID_Token_Folder

					,func_related_Attribute_Blob_1.GUID_TokenAttribute_Blob

					,func_related_Attribute_Blob_1.[is Blob]

				FROM         semtbl_Token 

				LEFT OUTER JOIN dbo.func_related_Attribute_Blob(@GUID_Attribute_Blob) AS func_related_Attribute_Blob_1 ON semtbl_Token.GUID_Token = func_related_Attribute_Blob_1.GUID_File

				WHERE     (semtbl_Token.GUID_Type = @GUID_Type_File) 

				AND (semtbl_Token.Name_Token LIKE ''%'' + @Name_Token_File + ''%'')

			END

			ELSE

			BEGIN

				SELECT   semtbl_Token.GUID_Token AS GUID_File

					,semtbl_Token.Name_Token AS Name_File

					,semtbl_Token.GUID_Type AS GUID_Type_File

					,CAST(NULL AS uniqueidentifier) AS GUID_Token_Folder

					,func_related_Attribute_Blob_1.GUID_TokenAttribute_Blob

					,func_related_Attribute_Blob_1.[is Blob]

				FROM         semtbl_Token 

				LEFT OUTER JOIN dbo.func_related_Attribute_Blob(@GUID_Attribute_Blob) AS func_related_Attribute_Blob_1 ON semtbl_Token.GUID_Token = func_related_Attribute_Blob_1.GUID_File

				LEFT OUTER JOIN (SELECT File_To_Folder.GUID_Token_Right AS GUID_File, Folder.GUID_Token AS GUID_Folder, Folder.Name_Token AS Name_Folder

								 FROM semtbl_Token_Token AS File_To_Folder

								 INNER JOIN semtbl_Token AS Folder ON File_To_Folder.GUID_Token_Left = Folder.GUID_Token

								 WHERE Folder.GUID_Type = @GUID_Type_Folder

								 AND File_To_Folder.GUID_RelationType = @GUID_RelationType_isSubordinated) Folder ON semtbl_Token.GUID_Token = Folder.GUID_File

				WHERE     (semtbl_Token.GUID_Type = @GUID_Type_File) 

				AND Folder.GUID_Folder IS NULL

			END

			

		END

	END

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_related_Drive_of_Server]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbg_related_Drive_of_Server
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	DECLARE @GUID_Type_Drive					uniqueidentifier;
	DECLARE @GUID_RelationType_isSubordinated	uniqueidentifier;

	SET @GUID_Type_Drive					= dbo.func_Named_GUIDType(''Drive'');
	SET @GUID_RelationType_isSubordinated	= dbo.func_Named_GUIDRelationType(''is Subordinated'');

	PRINT @GUID_Type_Drive;
	PRINT @GUID_RelationType_isSubordinated;

    -- Insert statements for procedure here
	SELECT * FROM func_related_Drive_of_Server(
		@GUID_Type_Drive,
		@GUID_RelationType_isSubordinated)
END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_get_GUID_DBOnServer]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[dbg_get_GUID_DBOnServer] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @Name_Server	varchar(255);
	DECLARE @Name_DB		varchar(255);
	
	SET @Name_Server = @@SERVERNAME;
	SET @Name_DB = DB_NAME();
	
	DECLARE @GUID_Type_DatabaseOnServer			uniqueidentifier;
	DECLARE @GUID_Type_Database					uniqueidentifier;
	DECLARE @GUID_Type_Server					uniqueidentifier;
	DECLARE @GUID_RelationType_belongsTo		uniqueidentifier;
	DECLARE @GUID_RelationType_locatedIn		uniqueidentifier;
	
	SET @GUID_Type_DatabaseOnServer			= dbo.dbg_Type_Database_on_Server();
	SET @GUID_Type_Database					= dbo.dbg_Type_Database();
	SET @GUID_Type_Server					= dbo.dbg_Type_Server();
	SET @GUID_RelationType_belongsTo		= dbo.dbg_RelationType_belongs_to();
	SET @GUID_RelationType_locatedIn		= dbo.dbg_RelationType_located_in();
	
	PRINT @GUID_Type_DatabaseOnServer;
	PRINT @GUID_Type_Database;
	PRINT @GUID_Type_Server;
	PRINT @GUID_RelationType_belongsTo;
	PRINT @GUID_RelationType_locatedIn;
	PRINT @Name_Server;
	PRINT @Name_DB;
	
	
    -- Insert statements for procedure here
	
    -- Insert statements for procedure here
	SELECT     func_Token_Database_on_Server_1.GUID_Database_on_Server
		FROM         dbo.func_Token_Database_on_Server(@GUID_Type_DatabaseOnServer) AS func_Token_Database_on_Server_1 INNER JOIN
							  semtbl_Token_Token AS DatabaseOnServer_To_Database ON 
							  func_Token_Database_on_Server_1.GUID_Database_on_Server = DatabaseOnServer_To_Database.GUID_Token_Left INNER JOIN
							  dbo.func_Token_Database(@GUID_Type_Database) AS func_Token_Database_1 ON 
							  DatabaseOnServer_To_Database.GUID_Token_Right = func_Token_Database_1.GUID_Database INNER JOIN
							  semtbl_Token_Token AS DatabaseOnServer_To_Server ON 
							  func_Token_Database_on_Server_1.GUID_Database_on_Server = DatabaseOnServer_To_Server.GUID_Token_Left INNER JOIN
							  dbo.func_Token_Server(@GUID_Type_Server) AS func_Token_Server_1 ON 
							  DatabaseOnServer_To_Server.GUID_Token_Right = func_Token_Server_1.GUID_Server
		WHERE     (func_Token_Database_1.Name_Database = @Name_DB) AND (func_Token_Server_1.Name_Server+''\SQLEXPRESS'' = @Name_Server) AND 
							  (DatabaseOnServer_To_Database.GUID_RelationType = @GUID_RelationType_belongsTo) AND 
							  (DatabaseOnServer_To_Server.GUID_RelationType = @GUID_RelationType_locatedIn)
END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_related_Folder_of_Server]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbg_related_Folder_of_Server 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @GUID_Type_Folder				uniqueidentifier;
	DECLARE @GUID_RelationType_FileShare	uniqueidentifier;

	SET @GUID_Type_Folder				= dbo.func_Named_GUIDType(''Folder'');
	SET @GUID_RelationType_FileShare	= dbo.func_Named_GUIDRelationType(''FileShare'');

	PRINT @GUID_Type_Folder;
	PRINT @GUID_RelationType_FileShare;

    -- Insert statements for procedure here
	SELECT * FROM func_related_Folder_of_Server(
		@GUID_Type_Folder,
		@GUID_RelationType_FileShare)
END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_related_File_By_GUID_Folder]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_related_File_By_GUID_Folder] 

	-- Add the parameters for the stored procedure here

	@GUID_Token_Folder					uniqueidentifier = null,

	@GUID_Token_File					uniqueidentifier = null,

	@Name_Token_File					varchar(255) = null

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @GUID_Attribute_Blob				uniqueidentifier

	DECLARE @GUID_Type_File						uniqueidentifier

	DECLARE @GUID_Type_Folder					uniqueidentifier

	DECLARE @GUID_RelationType_isSubordinated	uniqueidentifier

	

	SET @GUID_Attribute_Blob				= dbo.dbg_AttributeType_Blob()

	SET @GUID_Type_File						= dbo.dbg_Type_File()

	SET @GUID_Type_Folder					= dbo.dbg_Type_Folder()

	SET @GUID_RelationType_isSubordinated	= dbo.dbg_RelationType_is_subordinated()

	

	PRINT @GUID_Attribute_Blob				

	PRINT @GUID_Type_File					

	PRINT @GUID_Type_Folder

	PRINT @GUID_RelationType_isSubordinated	

	

	IF @GUID_Token_Folder IS NOT NULL

    BEGIN

		

		SELECT   semtbl_Token.GUID_Token AS GUID_File

				,semtbl_Token.Name_Token AS Name_File

				,semtbl_Token.GUID_Type AS GUID_Type_File

				,semtbl_Token_Token.GUID_Token_Right AS GUID_Token_Folder

				,func_related_Attribute_Blob_1.GUID_TokenAttribute_Blob

				,func_related_Attribute_Blob_1.[is Blob]

		FROM         semtbl_Token INNER JOIN

							  semtbl_Token_Token ON semtbl_Token.GUID_Token = semtbl_Token_Token.GUID_Token_Left LEFT OUTER JOIN

							  dbo.func_related_Attribute_Blob(@GUID_Attribute_Blob) AS func_related_Attribute_Blob_1 ON semtbl_Token.GUID_Token = func_related_Attribute_Blob_1.GUID_File

		WHERE     (semtbl_Token.GUID_Type = @GUID_Type_File) 

		AND (semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_isSubordinated)

		AND (semtbl_Token_Token.GUID_Token_Right = @GUID_Token_Folder)

	END

	ELSE

	BEGIN

		IF @GUID_Token_File IS NOT NULL

		BEGIN

			SELECT   semtbl_Token.GUID_Token AS GUID_File

				,semtbl_Token.Name_Token AS Name_File

				,semtbl_Token.GUID_Type AS GUID_Type_File

				,CAST(NULL AS uniqueidentifier) AS GUID_Token_Folder

				,func_related_Attribute_Blob_1.GUID_TokenAttribute_Blob

				,func_related_Attribute_Blob_1.[is Blob]

			FROM         semtbl_Token LEFT OUTER JOIN

								  dbo.func_related_Attribute_Blob(@GUID_Attribute_Blob) AS func_related_Attribute_Blob_1 ON semtbl_Token.GUID_Token = func_related_Attribute_Blob_1.GUID_File

			WHERE     (semtbl_Token.GUID_Type = @GUID_Type_File) 

			AND (semtbl_Token.GUID_Token = @GUID_Token_File)

		END

		ELSE

		BEGIN

			IF @Name_Token_File IS NOT NULL 

			BEGIN

				SELECT   semtbl_Token.GUID_Token AS GUID_File

					,semtbl_Token.Name_Token AS Name_File

					,semtbl_Token.GUID_Type AS GUID_Type_File

					,CAST(NULL AS uniqueidentifier) AS GUID_Token_Folder

					,func_related_Attribute_Blob_1.GUID_TokenAttribute_Blob

					,func_related_Attribute_Blob_1.[is Blob]

				FROM         semtbl_Token 

				LEFT OUTER JOIN dbo.func_related_Attribute_Blob(@GUID_Attribute_Blob) AS func_related_Attribute_Blob_1 ON semtbl_Token.GUID_Token = func_related_Attribute_Blob_1.GUID_File

				WHERE     (semtbl_Token.GUID_Type = @GUID_Type_File) 

				AND (semtbl_Token.Name_Token LIKE ''%'' + @Name_Token_File + ''%'')

			END

			ELSE

			BEGIN

				SELECT   semtbl_Token.GUID_Token AS GUID_File

					,semtbl_Token.Name_Token AS Name_File

					,semtbl_Token.GUID_Type AS GUID_Type_File

					,CAST(NULL AS uniqueidentifier) AS GUID_Token_Folder

					,func_related_Attribute_Blob_1.GUID_TokenAttribute_Blob

					,func_related_Attribute_Blob_1.[is Blob]

				FROM         semtbl_Token 

				LEFT OUTER JOIN dbo.func_related_Attribute_Blob(@GUID_Attribute_Blob) AS func_related_Attribute_Blob_1 ON semtbl_Token.GUID_Token = func_related_Attribute_Blob_1.GUID_File

				LEFT OUTER JOIN (SELECT File_To_Folder.GUID_Token_Right AS GUID_File, Folder.GUID_Token AS GUID_Folder, Folder.Name_Token AS Name_Folder

								 FROM semtbl_Token_Token AS File_To_Folder

								 INNER JOIN semtbl_Token AS Folder ON File_To_Folder.GUID_Token_Left = Folder.GUID_Token

								 WHERE Folder.GUID_Type = @GUID_Type_Folder

								 AND File_To_Folder.GUID_RelationType = @GUID_RelationType_isSubordinated) Folder ON semtbl_Token.GUID_Token = Folder.GUID_File

				WHERE     (semtbl_Token.GUID_Type = @GUID_Type_File) 

				AND Folder.GUID_Folder IS NULL

			END

			

		END

	END

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Server_w_State_Type_Folder_Drive]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION func_Server_w_State_Type_Folder_Drive
(	
	-- Add the parameters for the function here
	@GUID_Type_Server					uniqueidentifier,
	@GUID_Type_State					uniqueidentifier,
	@GUID_Type_Folder					uniqueidentifier,
	@GUID_Type_Drive					uniqueidentifier,
	@GUID_Type_ServerType				uniqueidentifier,
	@GUID_RelationType_isInState		uniqueidentifier,
	@GUID_RelationType_isOfType			uniqueidentifier,
	@GUID_RelationType_FileShare		uniqueidentifier,
	@GUID_RelationType_isSubordinated	uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token.GUID_Token AS GUID_Server, semtbl_Token.Name_Token AS Name_Server, semtbl_Token.GUID_Type AS GUID_Type_Server, 
                      semtbl_Token_1.GUID_Token AS GUID_State, semtbl_Token_1.Name_Token AS Name_State, semtbl_Token_1.GUID_Type AS GUID_Type_State, 
                      semtbl_Token_2.GUID_Token AS GUID_ServerType, semtbl_Token_2.Name_Token AS Name_ServerType, semtbl_Token_2.GUID_Type AS GUID_Type_ServerType, 
                      func_related_Folder_of_Server_1.GUID_Folder, func_related_Folder_of_Server_1.Name_Folder, func_related_Drive_of_Server_1.GUID_Drive, 
                      func_related_Drive_of_Server_1.Name_Drive
FROM         semtbl_Token INNER JOIN
                      semtbl_Token_Token ON semtbl_Token.GUID_Token = semtbl_Token_Token.GUID_Token_Left INNER JOIN
                      semtbl_Token AS semtbl_Token_1 ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_1.GUID_Token INNER JOIN
                      semtbl_Token_Token AS semtbl_Token_Token_1 ON semtbl_Token.GUID_Token = semtbl_Token_Token_1.GUID_Token_Left INNER JOIN
                      semtbl_Token AS semtbl_Token_2 ON semtbl_Token_Token_1.GUID_Token_Right = semtbl_Token_2.GUID_Token LEFT OUTER JOIN
                      dbo.func_related_Drive_of_Server(@GUID_Type_Drive, @GUID_RelationType_isSubordinated) AS func_related_Drive_of_Server_1 ON 
                      semtbl_Token.GUID_Token = func_related_Drive_of_Server_1.GUID_Server LEFT OUTER JOIN
                      dbo.func_related_Folder_of_Server(@GUID_Type_Folder, @GUID_RelationType_FileShare) AS func_related_Folder_of_Server_1 ON 
                      semtbl_Token.GUID_Token = func_related_Folder_of_Server_1.GUID_Server
WHERE     (semtbl_Token.GUID_Type = @GUID_Type_Server) AND (semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_isInState) AND 
                      (semtbl_Token_1.GUID_Type = @GUID_Type_State) AND (semtbl_Token_Token_1.GUID_RelationType = @GUID_RelationType_isOfType) AND 
                      (semtbl_Token_2.GUID_Type = @GUID_Type_ServerType)
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_related_File]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[func_related_File]
(	
	-- Add the parameters for the function here
	@GUID_Attribute_Blob				uniqueidentifier,
	@GUID_Type_File						uniqueidentifier,
	@GUID_RelationType_isSubordinated	uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token.GUID_Token AS GUID_File, semtbl_Token.Name_Token AS Name_File, semtbl_Token.GUID_Type AS GUID_Type_File, 
                      semtbl_Token_Token.GUID_Token_Right AS GUID_Token_Folder, func_related_Attribute_Blob_1.GUID_TokenAttribute_Blob, 
                      func_related_Attribute_Blob_1.[is Blob]
FROM         semtbl_Token INNER JOIN
                      semtbl_Token_Token ON semtbl_Token.GUID_Token = semtbl_Token_Token.GUID_Token_Left LEFT OUTER JOIN
                      dbo.func_related_Attribute_Blob(@GUID_Attribute_Blob) AS func_related_Attribute_Blob_1 ON semtbl_Token.GUID_Token = func_related_Attribute_Blob_1.GUID_File
WHERE     (semtbl_Token.GUID_Type = @GUID_Type_File) AND (semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_isSubordinated)
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_related_Folder_L1_L2]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[func_related_Folder_L1_L2] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Folder					uniqueidentifier,
	@GUID_RelationType_isSubordinated	uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     func_related_Folder_L2_1.GUID_Folder AS GUID_Folder_L2, func_related_Folder_L2_1.Name_Folder AS Name_Folder_L2, 
                      semtbl_Token.GUID_Token AS GUID_Folder_L1, semtbl_Token.Name_Token AS Name_Folder_L1, 
                      semtbl_Token_Token.GUID_Token_Right AS GUID_Token_Folder_Root
FROM         semtbl_Token_Token INNER JOIN
                      semtbl_Token ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token.GUID_Token LEFT OUTER JOIN
                      dbo.func_related_Folder_L2(@GUID_Type_Folder, @GUID_RelationType_isSubordinated) AS func_related_Folder_L2_1 ON 
                      semtbl_Token.GUID_Token = func_related_Folder_L2_1.GUID_Folder_Parent
WHERE     (semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_isSubordinated) AND (semtbl_Token.GUID_Type = @GUID_Type_Folder)
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_PathToWatch_Of_BaseConfig]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'



-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_PathToWatch_Of_BaseConfig] 

	-- Add the parameters for the stored procedure here

	@GUID_Type_BlobDirWatcher		uniqueidentifier,

	@GUID_Type_Path					uniqueidentifier,

	@GUID_RelationType_belongsTo	uniqueidentifier,

	@GUID_RelationType_Watch		uniqueidentifier,

	@GUID_BaseConfig				uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     func_Token_BlobDirWatcher_1.GUID_BlobDirWatcher, func_Token_BlobDirWatcher_1.Name_BlobDirWatcher, 

                      func_Token_BlobDirWatcher_1.GUID_Type_BlobDirWatcher, func_Token_Path_1.GUID_Path, func_Token_Path_1.Name_Path, 

                      func_Token_Path_1.GUID_Type_Path

FROM         dbo.func_Token_BlobDirWatcher(@GUID_Type_BlobDirWatcher) AS func_Token_BlobDirWatcher_1 INNER JOIN

                      semtbl_Token_Token AS BlobDirWatcher_To_Path ON func_Token_BlobDirWatcher_1.GUID_BlobDirWatcher = BlobDirWatcher_To_Path.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Path(@GUID_Type_Path) AS func_Token_Path_1 ON BlobDirWatcher_To_Path.GUID_Token_Right = func_Token_Path_1.GUID_Path

WHERE     (BlobDirWatcher_To_Path.GUID_RelationType = @GUID_RelationType_Watch) AND (func_Token_BlobDirWatcher_1.GUID_BlobDirWatcher = @GUID_BaseConfig)

END




'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_File_OutChecked]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_File_OutChecked]
	-- Add the parameters for the stored procedure here
	@GUID_Type_Server				uniqueidentifier,
	@GUID_RelationType_isCheckOutBy	uniqueidentifier,
	@GUID_File						uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT     func_Token_Server_1.GUID_Server, func_Token_Server_1.Name_Server, func_Token_Server_1.GUID_Type_Server
FROM         semtbl_Token_Token AS File_To_Server INNER JOIN
                      dbo.func_Token_Server(@GUID_Type_Server) AS func_Token_Server_1 ON File_To_Server.GUID_Token_Right = func_Token_Server_1.GUID_Server
WHERE     (File_To_Server.GUID_Token_Left = @GUID_File) AND (File_To_Server.GUID_RelationType = @GUID_RelationType_isCheckOutBy)
END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Server_w_State_Type_Folder_Drive]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbg_Server_w_State_Type_Folder_Drive
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @GUID_Type_Server					uniqueidentifier;
	DECLARE @GUID_Type_State					uniqueidentifier;
	DECLARE @GUID_Type_Folder					uniqueidentifier;
	DECLARE @GUID_Type_Drive					uniqueidentifier;
	DECLARE @GUID_Type_ServerType				uniqueidentifier;
	DECLARE @GUID_RelationType_isInState		uniqueidentifier;
	DECLARE @GUID_RelationType_isOfType			uniqueidentifier;
	DECLARE @GUID_RelationType_FileShare		uniqueidentifier;
	DECLARE @GUID_RelationType_isSubordinated	uniqueidentifier;

	SET @GUID_Type_Server					= dbo.func_Named_GUIDType(''Server'');
	SET @GUID_Type_State					= dbo.func_Named_GUIDType(''Server-State'');
	SET @GUID_Type_Folder					= dbo.func_Named_GUIDType(''Folder'');
	SET @GUID_Type_Drive					= dbo.func_Named_GUIDType(''Driver'');
	SET @GUID_Type_ServerType				= dbo.func_Named_GUIDType(''Server-Type'');
	SET @GUID_RelationType_isInState		= dbo.func_Named_GUIDRelationType(''is in State'');
	SET @GUID_RelationType_isOfType			= dbo.func_Named_GUIDRelationType(''is of Type'');
	SET @GUID_RelationType_FileShare		= dbo.func_Named_GUIDRelationType(''Fileshare'');
	SET @GUID_RelationType_isSubordinated	= dbo.func_Named_GUIDRelationType(''is subordinated'');

	PRINT @GUID_Type_Server;
	PRINT @GUID_Type_State;
	PRINT @GUID_Type_Folder;
	PRINT @GUID_Type_Drive;
	PRINT @GUID_Type_ServerType;
	PRINT @GUID_RelationType_isInState;
	PRINT @GUID_RelationType_isOfType;
	PRINT @GUID_RelationType_FileShare;
	PRINT @GUID_RelationType_isSubordinated;

    -- Insert statements for procedure here
	SELECT * FROM func_Server_w_State_Type_Folder_Drive(
		@GUID_Type_Server,
		@GUID_Type_State,
		@GUID_Type_Folder,
		@GUID_Type_Drive,
		@GUID_Type_ServerType,
		@GUID_RelationType_isInState,
		@GUID_RelationType_isOfType,
		@GUID_RelationType_FileShare,
		@GUID_RelationType_isSubordinated)
END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_related_Folder_L1_L2]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbg_related_Folder_L1_L2
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @GUID_Type_Folder					uniqueidentifier;
	DECLARE @GUID_RelationType_isSubordinated	uniqueidentifier;

	SET @GUID_Type_Folder					= dbo.func_Named_GUIDType(''Folder'');
	SET @GUID_RelationType_isSubordinated	= dbo.func_Named_GUIDRelationType(''is Subordinated'');

	PRINT @GUID_Type_Folder;
	PRINT @GUID_RelationType_isSubordinated;
    -- Insert statements for procedure here
	SELECT * FROM func_related_Folder_L1_L2(
		@GUID_Type_Folder,
		@GUID_RelationType_isSubordinated)
END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_related_File]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[dbg_related_File] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @GUID_Attribute_Blob				uniqueidentifier;
	DECLARE @GUID_Type_File						uniqueidentifier;
	DECLARE @GUID_RelationType_isSubordinated	uniqueidentifier;

	SET @GUID_Attribute_Blob				= dbo.func_Named_GUIDAttribute(''Blob'');
	SET @GUID_Type_File						= dbo.func_Named_GUIDType(''File'');
	SET @GUID_RelationType_isSubordinated	= dbo.func_Named_GUIDRelationType(''is Subordinated'');

	PRINT @GUID_Attribute_Blob;
	PRINT @GUID_Type_File;
	PRINT @GUID_RelationType_isSubordinated;

    -- Insert statements for procedure here
	SELECT * FROM func_related_File(
		@GUID_Attribute_Blob,
		@GUID_Type_File,
		@GUID_RelationType_isSubordinated)
END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Server_Active_And_Fileserver]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE proc_Server_Active_And_Fileserver 
	-- Add the parameters for the stored procedure here
	@GUID_Type_Server					uniqueidentifier,
	@GUID_Type_State					uniqueidentifier,
	@GUID_Type_Folder					uniqueidentifier,
	@GUID_Type_Drive					uniqueidentifier,
	@GUID_Type_ServerType				uniqueidentifier,
	@GUID_RelationType_isInState		uniqueidentifier,
	@GUID_RelationType_isOfType			uniqueidentifier,
	@GUID_RelationType_FileShare		uniqueidentifier,
	@GUID_RelationType_isSubordinated	uniqueidentifier,
	@GUID_State							uniqueidentifier,
	@GUID_ServerType					uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT     GUID_Server, Name_Server, GUID_Type_Server, GUID_State, Name_State, GUID_Type_State, GUID_ServerType, Name_ServerType, GUID_Type_ServerType, 
                      GUID_Folder, Name_Folder, GUID_Drive, Name_Drive
FROM         dbo.func_Server_w_State_Type_Folder_Drive(@GUID_Type_Server, @GUID_Type_State, @GUID_Type_Folder, @GUID_Type_Drive, @GUID_Type_ServerType, 
                      @GUID_RelationType_isInState, @GUID_RelationType_isOfType, @GUID_RelationType_FileShare, @GUID_RelationType_isSubordinated) 
                      AS func_Server_w_State_Type_Folder_Drive_1
WHERE     (GUID_State = @GUID_State) AND (GUID_ServerType = @GUID_ServerType)
ORDER BY Name_Server, Name_Folder, Name_Drive
END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_related_Folder_L1_L2]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE proc_related_Folder_L1_L2
	-- Add the parameters for the stored procedure here
	@GUID_Type_Folder					uniqueidentifier,
	@GUID_RelationType_isSubordinated	uniqueidentifier,
	@GUID_Token_Folder					uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT     GUID_Token_Folder_Root, GUID_Folder_L1, Name_Folder_L1, GUID_Folder_L2, Name_Folder_L2
FROM         dbo.func_related_Folder_L1_L2(@GUID_Type_Folder, @GUID_RelationType_isSubordinated) AS func_related_Folder_L1_L2_1
WHERE     (GUID_Token_Folder_Root = @GUID_Token_Folder)
END
'
END
GO
EXEC sp_addextendedproperty 
		@name = SchemaVersion, @value = '0.1.0.18';
GO
EXEC sp_addextendedproperty 
		@name = SemDB, @value = 'Yes';
GO
