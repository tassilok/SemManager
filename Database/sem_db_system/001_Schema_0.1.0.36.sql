CREATE DATABASE sem_db_system
GO
use [sem_db_change]
INSERT INTO chngtbl_db VALUES('29114adb-d74e-4b94-80ce-0f7c8941c500','sem_db_system',0)
GO
use [sem_db_system]
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_Transaction_Action]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_Transaction_Action](
	[GUID_Action] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
 CONSTRAINT [PK_chngtbl_Transaction_Action_loc] PRIMARY KEY CLUSTERED 
(
	[GUID_Action] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_Transaction_Action] ADD  CONSTRAINT [DF_chngtbl_Transaction_Action_loc_GUID_Action]  DEFAULT (newid()) FOR [GUID_Action];

INSERT [dbo].[chngtbll_Transaction_Action] ([GUID_Action], [Name]) VALUES (N''a6df6ab2-3590-45b1-b325-35334a2f574a'', N''Insert'');
INSERT [dbo].[chngtbll_Transaction_Action] ([GUID_Action], [Name]) VALUES (N''bb6a9555-3af6-40fc-9fb0-489d2678dff2'', N''Delete'');
INSERT [dbo].[chngtbll_Transaction_Action] ([GUID_Action], [Name]) VALUES (N''9ad67d25-455c-47b1-9c3b-4d80e9a844af'', N''Attribute Change'');
INSERT [dbo].[chngtbll_Transaction_Action] ([GUID_Action], [Name]) VALUES (N''fb4cd678-b890-4538-9b22-93128e375c09'', N''Relation Change'');
INSERT [dbo].[chngtbll_Transaction_Action] ([GUID_Action], [Name]) VALUES (N''2bf7e9d6-fb9c-4092-9b16-ecc4fef7c072'', N''Update'');

'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_UpdateExtendedProperty]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_UpdateExtendedProperty

	-- Add the parameters for the stored procedure here

	@Name_Property		varchar(255),

	@Value_Property		varchar(255)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	EXEC sys.sp_updateextendedproperty

		@name = @Name_Property, 

		@value = @Value_Property;

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_AttributeType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_AttributeType](
	[GUID_AttributeType] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_AttributeType_GUID_AttributeType]  DEFAULT (newid()),
	[Name_AttributeType] [varchar](255) NOT NULL,
 CONSTRAINT [PK_semtbl_attribute_type] PRIMARY KEY CLUSTERED 
(
	[GUID_AttributeType] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_ORType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_ORType](
	[GUID_ObjectReferenceType] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_ORType_GUID_ObjectReferenceType]  DEFAULT (newid()),
	[Name_ObjectReferenceType] [varchar](255) NOT NULL,
 CONSTRAINT [PK_semtbl_OR_OrType] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReferenceType] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_OR_Token] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_OR_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_Token] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_Attribute] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_DB]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_DB] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_DB]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_OR_Type] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_OR_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_RelationType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_RelationType] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_RelationType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Token_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_Token_OR] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_Token_OR]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_AttributeType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_AttributeType] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_AttributeType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_OR_Attribute] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_OR_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_TypeType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_OR_TypeType] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_OR_TypeType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Type_Rel]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_Type_Rel] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_Type_Rel]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Token_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_Token_Attribute] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_Token_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_Type] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_RelationType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_OR_RelationType] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_OR_RelationType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Type_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_Type_Attribute] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_Type_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Transaction_Action]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_Transaction_Action] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_Transaction_Action]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Transaction]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_Transaction] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_Transaction]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Token_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_Token_Token] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_Token_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_TokenToken]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_OR_TokenToken] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_OR_TokenToken]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_AttributeType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_OR_AttributeType] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_OR_AttributeType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_TypeAttribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_OR_TypeAttribute] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_OR_TypeAttribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_TokenAttribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_OR_TokenAttribute] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_OR_TokenAttribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Type_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[chngtbl_Type_OR] FOR [SEMSERVER\SQLEXPRESS].[sem_db_change].[dbo].[chngtbl_Type_OR]'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_DB]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_DB](
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Name_DB] [varchar](255) NOT NULL,
 CONSTRAINT [PK_chngtbll_DB] PRIMARY KEY CLUSTERED 
(
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_RelationType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_RelationType](
	[GUID_RelationType] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_RelationType_GUID_RelationType]  DEFAULT (newid()),
	[Name_RelationType] [varchar](255) NOT NULL,
 CONSTRAINT [PK_semtbl_RelationType] PRIMARY KEY CLUSTERED 
(
	[GUID_RelationType] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_listExtendedProperties]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE FUNCTION func_listExtendedProperties

(	

	-- Add the parameters for the function here

	

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT *

FROM fn_listextendedproperty(default, default, default, default, default, default, default)

)
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_AddExtendedProperty]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_AddExtendedProperty

	-- Add the parameters for the stored procedure here

	@Name_Property			varchar(255),

	@Value_Property			varchar(255)

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	EXEC sp_addextendedproperty 

		@name = @Name_Property, @value = @Value_Property

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Type](
	[GUID_Type] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_Type_GUID_Type]  DEFAULT (newid()),
	[Name_Type] [varchar](255) NOT NULL,
	[GUID_Type_Parent] [uniqueidentifier] NULL,
 CONSTRAINT [PK_semtbl_Type] PRIMARY KEY CLUSTERED 
(
	[GUID_Type] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Type]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Type_semtbl_Type] FOREIGN KEY([GUID_Type_Parent])
REFERENCES [dbo].[semtbl_Type] ([GUID_Type]);
ALTER TABLE [dbo].[semtbl_Type] CHECK CONSTRAINT [FK_semtbl_Type_semtbl_Type];'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_TypeGUID_ObjectReference]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE  FUNCTION [dbo].[func_TypeGUID_ObjectReference]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_Type uniqueidentifier;

	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=''Object-Reference'');

	-- Return the result of the function
	RETURN @GUID_Type

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AttributeType_Bool]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AttributeType_Bool]

AS

	SET NOCOUNT ON;

SELECT        GUID_AttributeType, Name_AttributeType

FROM            semtbl_AttributeType

WHERE        (Name_AttributeType = ''BOOL'')'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_Transaction]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_Transaction](
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
	[TransactionDate_Start] [datetime] NOT NULL,
	[TransactionDate_End] [datetime] NULL,
	[GUID_Action] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_Transaction_loc] PRIMARY KEY CLUSTERED 
(
	[GUID_Transaction] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Transaction_loc_chngtbl_Transaction_Action_loc] FOREIGN KEY([GUID_Action])
REFERENCES [dbo].[chngtbll_Transaction_Action] ([GUID_Action]);

ALTER TABLE [dbo].[chngtbll_Transaction] CHECK CONSTRAINT [FK_chngtbl_Transaction_loc_chngtbl_Transaction_Action_loc];

ALTER TABLE [dbo].[chngtbll_Transaction] ADD  CONSTRAINT [DF_chngtbl_Transaction_loc_TransactionDate]  DEFAULT (getdate()) FOR [TransactionDate_Start];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_Token_Attribute_Bit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_Token_Attribute_Bit]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_Token_Attribute_Bit''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[typeproc_Type_By_Name]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.typeproc_Type_By_Name

(

	@Name_Type varchar(255)

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Type, Name_Type, GUID_Type_Parent

FROM            semtbl_Type

WHERE        (Name_Type = @Name_Type)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_Token]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUID_ORType_Token]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AttributeType_Date]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.AttributeType_Date

AS

	SET NOCOUNT ON;

SELECT        GUID_AttributeType, Name_AttributeType

FROM            semtbl_AttributeType

WHERE        (Name_AttributeType = ''DATE'')'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_TypeAttribute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_TypeAttribute]

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

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT     GUID_ObjectReferenceType

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Type-Attribute''));



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Attribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Attribute](
	[GUID_Attribute] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_Attribute_GUID_Attribute]  DEFAULT (newid()),
	[Name_Attribute] [varchar](255) NOT NULL,
	[GUID_AttributeType] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_attribute] PRIMARY KEY CLUSTERED 
(
	[GUID_Attribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_attribute_semtbl_attribute_type] FOREIGN KEY([GUID_AttributeType])
REFERENCES [dbo].[semtbl_AttributeType] ([GUID_AttributeType]);
ALTER TABLE [dbo].[semtbl_Attribute] CHECK CONSTRAINT [FK_semtbl_attribute_semtbl_attribute_type];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_GUID_Root]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_GUID_Root

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     GUID_Type

		FROM         semtbl_Type

		WHERE     (Name_Type = ''Root'')

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Type_Like_Name]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Type_Like_Name]

	-- Add the parameters for the stored procedure here

	@Search		VARCHAR(255)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	SET @Search=REPLACE(@Search,'''','''''''')

    -- Insert statements for procedure here

	SELECT GUID_Type, Name_Type, GUID_Type_Parent

	FROM semtbl_Type

	WHERE Name_Type LIKE ''%'' + @Search + ''%''

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RelationTypeProc_By_Name]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.RelationTypeProc_By_Name

(

	@Name_RelationType varchar(255)

)

AS

	SET NOCOUNT ON;

SELECT        GUID_RelationType, Name_RelationType

FROM            semtbl_RelationType

WHERE        (Name_RelationType = @Name_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_AttributeType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUID_ORType_AttributeType]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''AttributeType''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_Token_OR]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_Token_OR]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_RelationType_By_GUID]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.proc_RelationType_By_GUID

(

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_RelationType, Name_RelationType

FROM            semtbl_RelationType

WHERE        (GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_TypeGUID_DevelopmentConfigItem]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE  FUNCTION [dbo].[func_TypeGUID_DevelopmentConfigItem]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_Type uniqueidentifier;

	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=''Development-ConfigItem'');

	-- Return the result of the function
	RETURN @GUID_Type

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AttributeType_Time]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.AttributeType_Time

AS

	SET NOCOUNT ON;

SELECT        GUID_AttributeType, Name_AttributeType

FROM            semtbl_AttributeType

WHERE        (Name_AttributeType = ''TIME'')'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Type_OR''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_AttributeType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_AttributeType]

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

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT     GUID_ObjectReferenceType

FROM         semtbl_ORType

WHERE     (Name_ObjectReferenceType = ''AttributeType''));



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AttributeType_Int]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.AttributeType_Int

AS

	SET NOCOUNT ON;

SELECT        GUID_AttributeType, Name_AttributeType

FROM            semtbl_AttributeType

WHERE        (Name_AttributeType = ''INT'')'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_Token_Attribute_Real]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_Token_Attribute_Real]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_Token_Attribute_Real''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Type_Root]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Type_Root] 
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_Type	uniqueidentifier;

	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE GUID_Type_Parent IS NULL);

	-- Return the result of the function
	RETURN @GUID_Type;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_TokenAttributeVarchar255]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUID_ORType_TokenAttributeVarchar255]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token-Attribute-Varchar255''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_Token_Attribute_Time]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_Token_Attribute_Time]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_Token_Attribute_Time''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Types_of_Parent]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[func_Types_of_Parent] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Parent	uniqueidentifier,
	@intLevel			int
)
RETURNS @tmptbl_Types TABLE 
(
	GUID_Type			uniqueidentifier,
	Name_Type			varchar(255),
	GUID_Type_Parent	uniqueidentifier,
	intLevel			int
)
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);
	DECLARE @intLevel_Child		int;
	
	SET @intLevel = @intLevel + 1;

	DECLARE cur_Types CURSOR FOR
		SELECT     GUID_Type, Name_Type, GUID_Type_Parent
			FROM         semtbl_Type
			WHERE     (GUID_Type_Parent = @GUID_Type_Parent)
			ORDER BY Name_Type;

	
	OPEN cur_Types;
	FETCH NEXT FROM cur_Types INTO
		@GUID_Type,
		@Name_Type,
		@GUID_Type_Parent;

	WHILE @@FETCH_STATUS=0
	BEGIN
		INSERT INTO @tmptbl_Types VALUES (
			@GUID_Type,
			@Name_Type,
			@GUID_Type_Parent,
			@intLevel);
		DECLARE cur_Types_Child CURSOR FOR
			SELECT * FROM dbo.func_Types_of_Parent(@GUID_Type,@intLevel);
		OPEN cur_Types_Child;
		FETCH NEXT FROM cur_Types_Child INTO
			@GUID_Type,
			@Name_Type,
			@GUID_Type_Parent,
			@intLevel_Child;
		WHILE @@FETCH_STATUS=0
		BEGIN
			INSERT INTO @tmptbl_Types VALUES (
				@GUID_Type,
				@Name_Type,
				@GUID_Type_Parent,
				@intLevel_Child);
			FETCH NEXT FROM cur_Types_Child INTO
				@GUID_Type,
				@Name_Type,
				@GUID_Type_Parent,
				@intLevel_Child;
		END
		CLOSE cur_Types_Child;
		DEALLOCATE cur_Types_Child;
		FETCH NEXT FROM cur_Types INTO
			@GUID_Type,
			@Name_Type,
			@GUID_Type_Parent;
	END
	CLOSE cur_Types;
	DEALLOCATE cur_Types;
	RETURN
END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_RelationTypeGUID_isOfType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_RelationTypeGUID_isOfType]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=''is of Type'');



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_TokenAttributeInt]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUID_ORType_TokenAttributeInt]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token-Attribute-Int''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_TokenAttributeVarcharMAX]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUID_ORType_TokenAttributeVarcharMAX]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token-Attribute-VarcharMAX''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_Token_Attribute_Date]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_Token_Attribute_Date]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_Token_Attribute_Date''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_OR]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Type_OR](
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[Min_forw] [int] NOT NULL CONSTRAINT [DF_semtbl_Type_OR_Min_forw]  DEFAULT ((1)),
	[Max_forw] [int] NOT NULL CONSTRAINT [DF_semtbl_Type_OR_Min_backw]  DEFAULT ((1)),
 CONSTRAINT [PK_semtbl_Type_OR_1] PRIMARY KEY CLUSTERED 
(
	[GUID_Type] ASC,
	[GUID_RelationType] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Type_OR]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Type_OR_semtbl_RelationType] FOREIGN KEY([GUID_RelationType])
REFERENCES [dbo].[semtbl_RelationType] ([GUID_RelationType]);
ALTER TABLE [dbo].[semtbl_Type_OR] CHECK CONSTRAINT [FK_semtbl_Type_OR_semtbl_RelationType];
ALTER TABLE [dbo].[semtbl_Type_OR]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Type_OR_semtbl_Type] FOREIGN KEY([GUID_Type])
REFERENCES [dbo].[semtbl_Type] ([GUID_Type])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_Type_OR] CHECK CONSTRAINT [FK_semtbl_Type_OR_semtbl_Type];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_TypeGUID_Direction]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE  FUNCTION [dbo].[func_TypeGUID_Direction]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_Type uniqueidentifier;

	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=''Direction'');

	-- Return the result of the function
	RETURN @GUID_Type

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_RelationType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_RelationType]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_RelationType''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_RelationTypeGUID_needs]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[func_RelationTypeGUID_needs]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType uniqueidentifier;

	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=''needs'');

	-- Return the result of the function
	RETURN @GUID_RelationType

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_TokenAttributeTime]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUID_ORType_TokenAttributeTime]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token-Attribute-Time''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Token](
	[GUID_Token] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_Token_GUID_Token]  DEFAULT (newid()),
	[Name_Token] [varchar](255) NOT NULL,
	[GUID_Type] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_Token] PRIMARY KEY CLUSTERED 
(
	[GUID_Token] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Token]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_semtbl_Type] FOREIGN KEY([GUID_Type])
REFERENCES [dbo].[semtbl_Type] ([GUID_Type]);
ALTER TABLE [dbo].[semtbl_Token] CHECK CONSTRAINT [FK_semtbl_Token_semtbl_Type];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AttributeType_Real]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.AttributeType_Real

AS

	SET NOCOUNT ON;

SELECT        GUID_AttributeType, Name_AttributeType

FROM            semtbl_AttributeType

WHERE        (Name_AttributeType = ''REAL'')'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_Token_Attribute_Varchar255]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_Token_Attribute_Varchar255]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_Token_Attribute_Varchar255''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_TypeGUID_SoftwareDevelopment]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE  FUNCTION [dbo].[func_TypeGUID_SoftwareDevelopment]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_Type uniqueidentifier;

	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=''Software-Development'');

	-- Return the result of the function
	RETURN @GUID_Type

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_Token_Attribute_Datetime]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_Token_Attribute_Datetime]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_Token_Attribute_Datetime''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUID_ORType_Type]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Type''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_Type_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_Type_Type]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_Type_Type''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_RelationTypeGUID_belongsTo]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_RelationTypeGUID_belongsTo]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=''belongs to'');



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_TypeGUID_Server]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE  FUNCTION [dbo].[func_TypeGUID_Server]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_Type uniqueidentifier;

	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=''Server'');

	-- Return the result of the function
	RETURN @GUID_Type

END

'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RelationTypeGUID_isOfType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION RelationTypeGUID_isOfType

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=''is of Type'');



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_TokenAttributeBit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUID_ORType_TokenAttributeBit]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token-Attribute-Bit''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_RelationTypeGUID_contains]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_RelationTypeGUID_contains]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=''contains'');



	-- Return the result of the function

	RETURN @GUID_RelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_AttributeType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_AttributeType]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_AttributeType''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_TypeAttribute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUID_ORType_TypeAttribute]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Type-Attribute''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_ORType] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_ObjectReference] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_semtbl_ORType] FOREIGN KEY([GUID_ORType])
REFERENCES [dbo].[semtbl_ORType] ([GUID_ObjectReferenceType]);
ALTER TABLE [dbo].[semtbl_OR] CHECK CONSTRAINT [FK_semtbl_OR_semtbl_ORType];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_GUID_Action]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_GUID_Action]

(

	-- Add the parameters for the function here

	@Name_Action	varchar(255)

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_Action	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Action = (SELECT     GUID_Action

		FROM         chngtbll_Transaction_Action

		WHERE     ([Name] = @Name_Action));



	-- Return the result of the function

	RETURN @GUID_Action;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AttributeType_String]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.AttributeType_String

AS

	SET NOCOUNT ON;

SELECT        GUID_AttributeType, Name_AttributeType

FROM            semtbl_AttributeType

WHERE        (Name_AttributeType = ''STRING'')'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_TypeType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_TypeType]

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

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT     GUID_ObjectReferenceType

		FROM         semtbl_ORType

		WHERE     (Name_ObjectReferenceType = ''Type-Type''));



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AttributeType_VARCHAR255]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.AttributeType_VARCHAR255

AS

	SET NOCOUNT ON;

SELECT        GUID_AttributeType, Name_AttributeType

FROM            semtbl_AttributeType

WHERE        (Name_AttributeType = ''VARCHAR255'')'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_TypeGUID_DevelopmentConfig]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE  FUNCTION [dbo].[func_TypeGUID_DevelopmentConfig]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_Type uniqueidentifier;

	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=''Development-Config'');

	-- Return the result of the function
	RETURN @GUID_Type

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_Token]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_Token]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_Token''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngqry_DB_System]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.chngqry_DB_System

AS

	SET NOCOUNT ON;

SELECT        GUID_DB, Name_DB, is_SystemDB

FROM            chngtbl_DB

WHERE        (is_SystemDB = 1)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_TokenAttributeDatetime]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUID_ORType_TokenAttributeDatetime]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token-Attribute-Datetime''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_Type]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_Type''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Type_Like_Name]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Type_Like_Name]

	-- Add the parameters for the stored procedure here

	@Search		VARCHAR(255)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	SET @Search=REPLACE(@Search,'''','''''''')

    -- Insert statements for procedure here

	SELECT GUID_Type, Name_Type, GUID_Type_Parent

	FROM semtbl_Type

	WHERE Name_Type LIKE ''%'' + @Search + ''%''

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AttributeType_Datetime]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AttributeType_Datetime]

AS

	SET NOCOUNT ON;

SELECT        GUID_AttributeType, Name_AttributeType

FROM            semtbl_AttributeType

WHERE        (Name_AttributeType = ''DATETIME'')'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_TypeType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUID_ORType_TypeType]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Type-Type''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_Attribute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_Attribute]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_Attribute''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_RelationType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_RelationType]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''RelationType''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_RelationType_Like_Name]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_RelationType_Like_Name

	-- Add the parameters for the stored procedure here

	@Search		varchar(255)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	SET @Search = REPLACE(@Search,'''','''''''')

	

    -- Insert statements for procedure here

	SELECT GUID_RelationType, Name_RelationType

	FROM semtbl_RelationType

	WHERE Name_RelationType LIKE ''%''+@Search+''%''

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Insert_New_SemDB]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_Insert_New_SemDB

	-- Add the parameters for the stored procedure here

	@GUID_DB		uniqueidentifier,

	@Name_DB		varchar(255),

	@is_SystemDB	bit

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	INSERT INTO chngtbl_DB VALUES(@GUID_DB,@Name_DB,@is_SystemDB)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_Attribute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUID_ORType_Attribute]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Attribute''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[typeproc_Type_By_GUID]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.typeproc_Type_By_GUID

(

	@GUID_Type uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Type, Name_Type, GUID_Type_Parent

FROM            semtbl_Type

WHERE        (GUID_Type = @GUID_Type)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_RelationType_Like_Name]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_RelationType_Like_Name

	-- Add the parameters for the stored procedure here

	@Search		varchar(255)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	SET @Search = REPLACE(@Search,'''','''''''')

	

    -- Insert statements for procedure here

	SELECT GUID_RelationType, Name_RelationType

	FROM semtbl_RelationType

	WHERE Name_RelationType LIKE ''%''+@Search+''%''

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_TokenAttributeDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUID_ORType_TokenAttributeDate]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token-Attribute-Date''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Type_Parent_By_GUIDTypeParent]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.proc_Type_Parent_By_GUIDTypeParent

(

	@GUID_Type_Parent uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Type, Name_Type, GUID_Type_Parent

FROM            semtbl_Type

WHERE        (GUID_Type_Parent = @GUID_Type_Parent)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_Token_Attribute_Int]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_Token_Attribute_Int]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_Token_Attribute_Int''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semfunc_Type_Path]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[semfunc_Type_Path] 
(	
	-- Add the parameters for the function here
	
)
RETURNS @tmptbl_Path TABLE 
(
	GUID_Type	uniqueidentifier,
	Name_Type	varchar(255),
	GUID_Type_Parent	uniqueidentifier,
	Path_Type	varchar(max)
)
AS
BEGIN
	-- Add the SELECT statement with parameter references here
	DECLARE @GUID_Type	uniqueidentifier;
	DECLARE	@GUID_Type1	uniqueidentifier;
	DECLARE @Name_Type	varchar(255);
	DECLARE @strName_Type	varchar(255);
	DECLARE @GUID_Type_Parent	uniqueidentifier;
	DECLARE @GUID_Type_Parent1	uniqueidentifier;
	DECLARE @Path_Type		varchar(max);

	DECLARE cur_Type CURSOR FOR
		SELECT     GUID_Type, Name_Type, GUID_Type_Parent
			FROM         semtbl_Type;
	OPEN cur_Type;
	FETCH NEXT FROM cur_Type INTO
		@GUID_Type,
		@Name_Type,
		@GUID_Type_Parent;
	
	WHILE @@FETCH_STATUS=0
	BEGIN
		SET @Path_Type=@Name_Type;
		SET @GUID_Type_Parent1 = @GUID_Type_Parent;
		WHILE  NOT @GUID_Type_Parent1 IS NULL 
		BEGIN
			
			DECLARE cur_Type_Parent2 CURSOR FOR
				SELECT     GUID_Type, Name_Type, GUID_Type_Parent
					FROM         semtbl_Type
					WHERE     (GUID_Type = @GUID_Type_Parent1);
			OPEN cur_Type_Parent2;
			FETCH NEXT FROM cur_Type_Parent2 INTO
				@GUID_Type1,
				@strName_Type,
				@GUID_Type_Parent1;
			If @@FETCH_STATUS=0
				SET @Path_Type = @strName_Type+''\''+@Path_Type;
			CLOSE cur_Type_Parent2;
			DEALLOCATE cur_Type_Parent2;
		END
		
		
		INSERT INTO @tmptbl_Path VALUES(
			@GUID_Type,
			@Name_Type,
			@GUID_Type_Parent,
			@Path_Type);
		FETCH NEXT FROM cur_Type INTO
				@GUID_Type,
				@Name_Type,
				@GUID_Type_Parent;
	END
	CLOSE cur_Type;
	DEALLOCATE cur_Type;
	-- Return the result of the function

	RETURN
END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_TokenAttributeReal]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUID_ORType_TokenAttributeReal]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token-Attribute-Real''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_TokenToken]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUID_ORType_TokenToken]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token-Token''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_Type]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Type_Type](
	[GUID_Type_Left] [uniqueidentifier] NOT NULL,
	[GUID_Type_Right] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[Min_forw] [int] NOT NULL CONSTRAINT [DF_semtbl_Type_RelationType_Min]  DEFAULT ((1)),
	[Max_forw] [int] NOT NULL CONSTRAINT [DF_semtbl_Type_RelationType_Max]  DEFAULT ((1)),
	[Max_backw] [int] NOT NULL CONSTRAINT [DF_semtbl_Type_Type_Max_backw]  DEFAULT ((1)),
 CONSTRAINT [PK_semtbl_Type_Type] PRIMARY KEY CLUSTERED 
(
	[GUID_Type_Left] ASC,
	[GUID_Type_Right] ASC,
	[GUID_RelationType] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Type_Type]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Type_Type_semtbl_RelationType] FOREIGN KEY([GUID_RelationType])
REFERENCES [dbo].[semtbl_RelationType] ([GUID_RelationType]);
ALTER TABLE [dbo].[semtbl_Type_Type] CHECK CONSTRAINT [FK_semtbl_Type_Type_semtbl_RelationType];
ALTER TABLE [dbo].[semtbl_Type_Type]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Type_Type_semtbl_Type] FOREIGN KEY([GUID_Type_Left])
REFERENCES [dbo].[semtbl_Type] ([GUID_Type]);
ALTER TABLE [dbo].[semtbl_Type_Type] CHECK CONSTRAINT [FK_semtbl_Type_Type_semtbl_Type];
ALTER TABLE [dbo].[semtbl_Type_Type]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Type_Type_semtbl_Type1] FOREIGN KEY([GUID_Type_Right])
REFERENCES [dbo].[semtbl_Type] ([GUID_Type]);
ALTER TABLE [dbo].[semtbl_Type_Type] CHECK CONSTRAINT [FK_semtbl_Type_Type_semtbl_Type1];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_Token_Token]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_Token_Token]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_Token_Token''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_Type_Attribute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_Type_Attribute]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_Type_Attribute''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUID_ORType_OR_Token_Attribute_VARCHARMAX]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[func_GUID_ORType_OR_Token_Attribute_VARCHARMAX]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_ObjectReferenceType	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_ObjectReferenceType = (SELECT        GUID_ObjectReferenceType

		FROM            semtbl_ORType

		WHERE        (Name_ObjectReferenceType = ''Token_OR_Token_Attribute_VARCHARMAX''));



	-- Return the result of the function

	RETURN @GUID_ObjectReferenceType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_Token_TypeChilds]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[semproc_Token_TypeChilds]

(

	@strGUID_Type uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     GUID_Token, Name_Token, GUID_Type

FROM         semtbl_Token

WHERE     (GUID_Type = @strGUID_Type)

ORDER BY Name_Token'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_Type]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_Type]

AS

	SET NOCOUNT ON;

SELECT  dbo.func_GUID_ORType_Type() AS      GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_TokenAttributeReal]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_TokenAttributeReal]

AS

	SET NOCOUNT ON;

SELECT  dbo.func_GUID_ORType_TokenAttributeReal() AS       GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_Type_with_Path_By_GUID]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE semproc_Type_with_Path_By_GUID 

	-- Add the parameters for the stored procedure here

	@GUID_Type		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     GUID_Type, Name_Type, GUID_Type_Parent, Path_Type

		FROM         dbo.semfunc_Type_Path() AS semfunc_Type_Path_1

		WHERE     (GUID_Type = @GUID_Type)

		

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_TokenAttributeDate]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_TokenAttributeDate]

AS

	SET NOCOUNT ON;

SELECT dbo.func_GUID_ORType_TokenAttributeDate() AS       GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_Attribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_Attribute](
	[Version] [int] NOT NULL,
	[GUID_Attribute] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[GUID_AttributeType] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_Attribute] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Attribute] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[chngtbll_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Attribute_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;
ALTER TABLE [dbo].[chngtbll_Attribute] CHECK CONSTRAINT [FK_chngtbll_Attribute_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Attribute_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;


ALTER TABLE [dbo].[chngtbll_Attribute] CHECK CONSTRAINT [FK_chngtbll_Attribute_chngtbll_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_RelationType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_RelationType](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_RelationType_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_RelationType] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_semtbl_OR_RelationType] UNIQUE NONCLUSTERED 
(
	[GUID_RelationType] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_RelationType]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_RelationType_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_RelationType] CHECK CONSTRAINT [FK_semtbl_OR_RelationType_semtbl_OR];
ALTER TABLE [dbo].[semtbl_OR_RelationType]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_RelationType_semtbl_RelationType] FOREIGN KEY([GUID_RelationType])
REFERENCES [dbo].[semtbl_RelationType] ([GUID_RelationType])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_RelationType] CHECK CONSTRAINT [FK_semtbl_OR_RelationType_semtbl_RelationType];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Attribute_Like_Name]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Attribute_Like_Name]

	-- Add the parameters for the stored procedure here

	@Search		VARCHAR(255)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	SET @Search=REPLACE(@Search,'''','''''''')

    -- Insert statements for procedure here

	SELECT GUID_Attribute, Name_Attribute, GUID_AttributeType

	FROM semtbl_Attribute

	WHERE Name_Attribute LIKE ''%'' + @Search + ''%''

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUIDToken_Direction_LeftRight]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUIDToken_Direction_LeftRight]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_Direction		uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Direction = (SELECT GUID_Token FROM semtbl_Token WHERE GUID_Type=dbo.func_TypeGUID_Direction() AND Name_Token=''Left-Right'');



	-- Return the result of the function

	RETURN @GUID_Direction



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Attribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_Attribute](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_Attribute_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_Attribute] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_Attribute] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_semtbl_OR_Attribute] UNIQUE NONCLUSTERED 
(
	[GUID_Attribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Attribute_semtbl_Attribute] FOREIGN KEY([GUID_Attribute])
REFERENCES [dbo].[semtbl_Attribute] ([GUID_Attribute])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Attribute] CHECK CONSTRAINT [FK_semtbl_OR_Attribute_semtbl_Attribute];
ALTER TABLE [dbo].[semtbl_OR_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Attribute_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Attribute] CHECK CONSTRAINT [FK_semtbl_OR_Attribute_semtbl_OR];'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_TokenAttributeVarchar255]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_TokenAttributeVarchar255]

AS

	SET NOCOUNT ON;

SELECT  dbo.func_GUID_ORType_TokenAttributeVarchar255() AS      GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_TokenAttributeTime]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_TokenAttributeTime]

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

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT GUID_Token FROM semtbl_Token WHERE GUID_Type=dbo.func_TypeGUID_ObjectReferenceType() AND Name_Token=''Token-Attribute-Time'');



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_TypeAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_TypeAttribute]

AS

	SET NOCOUNT ON;

SELECT   dbo.func_GUID_ORType_TypeAttribute() AS     GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_Token_Token]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_Token_Token]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_Token_Token() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_TokenToken]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_TokenToken]

AS

	SET NOCOUNT ON;

SELECT dbo.func_GUID_ORType_TokenToken() AS       GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Attribute_By_Name]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.Attribute_By_Name

(

	@Name_Attribute varchar(255)

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Attribute, Name_Attribute, GUID_AttributeType

FROM            semtbl_Attribute

WHERE        (Name_Attribute = @Name_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_TokenAttributeReal]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_TokenAttributeReal]

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

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT GUID_Token FROM semtbl_Token WHERE GUID_Type=dbo.func_TypeGUID_ObjectReferenceType() AND Name_Token=''Token-Attribute-Real'');



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_Type_Attribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_Type_Attribute](
	[Version] [int] NOT NULL,
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[GUID_Attribute] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Min] [int] NOT NULL,
	[Max] [int] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_Type_Attribute] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Type] ASC,
	[GUID_Attribute] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_Type_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Type_Attribute_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Type_Attribute] CHECK CONSTRAINT [FK_chngtbll_Type_Attribute_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_Type_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Type_Attribute_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Type_Attribute] CHECK CONSTRAINT [FK_chngtbll_Type_Attribute_chngtbll_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_GUIDToken_Direction_RightLeft]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_GUIDToken_Direction_RightLeft]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_Direction		uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Direction = (SELECT GUID_Token FROM semtbl_Token WHERE GUID_Type=dbo.func_TypeGUID_Direction() AND Name_Token=''Right-Left'');



	-- Return the result of the function

	RETURN @GUID_Direction



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_WMI_BaseBoardSerial]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION func_WMI_BaseBoardSerial
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_BaseBoardSerial	uniqueidentifier;

	-- Add the T-SQL statements to compute the return value here
	SET @GUID_BaseBoardSerial = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=''BaseboardSerial'');

	-- Return the result of the function
	RETURN @GUID_BaseBoardSerial;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_OR_Attribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_OR_Attribute](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_Attribute] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_OR_Attribute] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_OR_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Attribute_OR_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_Attribute] CHECK CONSTRAINT [FK_chngtbll_Attribute_OR_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_OR_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_Attribute_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_Attribute] CHECK CONSTRAINT [FK_chngtbll_OR_Attribute_chngtbll_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_Token_Attribute_Time]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_Token_Attribute_Time]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_Token_Attribute_Time() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_Token_Attribute_VARCHARMAX]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_Token_Attribute_VARCHARMAX]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_Token_Attribute_VARCHARMAX() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_OR_TypeAttribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_OR_TypeAttribute](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[GUID_Attribute] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_OR_TypeAttribute] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_OR_TypeAttribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_TypeAttribute_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_TypeAttribute] CHECK CONSTRAINT [FK_chngtbll_OR_TypeAttribute_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_OR_TypeAttribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_TypeAttribute_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_TypeAttribute] CHECK CONSTRAINT [FK_chngtbll_OR_TypeAttribute_chngtbll_Transaction];

'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_TokenAttributeTime]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_TokenAttributeTime]

AS

	SET NOCOUNT ON;

SELECT  dbo.func_GUID_ORType_TokenAttributeTime() AS      GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_TokenAttributeVarcharMAX]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_TokenAttributeVarcharMAX]

AS

	SET NOCOUNT ON;

SELECT  dbo.func_GUID_ORType_TokenAttributeVarcharMAX() AS      GUID_ObjectReferenceType


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_TokenAttributeInt]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_TokenAttributeInt]

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

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT GUID_Token FROM semtbl_Token WHERE GUID_Type=dbo.func_TypeGUID_ObjectReferenceType() AND Name_Token=''Token-Attribute-Int'');



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_AttributeType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_AttributeType]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_AttributeType() AS GUID_ObjectReferenceType;
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_OR_TypeType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_OR_TypeType](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_Type_Left] [uniqueidentifier] NOT NULL,
	[GUID_Type_Right] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_OR_TypeType] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_OR_TypeType]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_TypeType_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_TypeType] CHECK CONSTRAINT [FK_chngtbll_OR_TypeType_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_OR_TypeType]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_TypeType_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_TypeType] CHECK CONSTRAINT [FK_chngtbll_OR_TypeType_chngtbll_Transaction];

'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_Type]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_Type]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_Type() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_Token_Attribute_Bit]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_Token_Attribute_Bit]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_Token_Attribute_Bit() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Path]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE dbg_Type_Path 

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT * FROM dbo.semfunc_Type_Path();

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_TokenAttributeDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_TokenAttributeDate]

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

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT GUID_Token FROM semtbl_Token WHERE GUID_Type=dbo.func_TypeGUID_ObjectReferenceType() AND Name_Token=''Token-Attribute-Date'');



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_Type_Type]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_Type_Type]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_Type_Type() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_TokenAttributeDatetime]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_TokenAttributeDatetime]

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

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT GUID_Token FROM semtbl_Token WHERE GUID_Type=dbo.func_TypeGUID_ObjectReferenceType() AND Name_Token=''Token-Attribute-Datetime'');



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semfunc_Token_Path]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION semfunc_Token_Path 
(
	-- Add the parameters for the function here
)
RETURNS @tmptbl_Path TABLE
(
	GUID_Token		uniqueidentifier,
	Name_Token		varchar(255),
	GUID_Type		uniqueidentifier,
	Path_Token		varchar(max)
)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_Token		uniqueidentifier;
	DECLARE @strPath_Token	varchar(max);
	DECLARE @strName_Token	varchar(255);
	DECLARE @strName_Type	varchar(255);
	DECLARE @GUID_Type_Token	uniqueidentifier;
	DECLARE @GUID_Type		uniqueidentifier;
	DECLARE @GUID_Type_Parent uniqueidentifier;

	-- Add the T-SQL statements to compute the return value here
	DECLARE cur_Token CURSOR FOR
		SELECT     GUID_Token, Name_Token, GUID_Type
			FROM         semtbl_Token;
	OPEN cur_Token;
	FETCH NEXT FROM cur_Token INTO
		@GUID_Token,
		@strName_Token,
		@GUID_Type_Token;
	WHILE @@FETCH_STATUS=0
	BEGIN
		SET @strPath_Token = @strName_Token;
		DECLARE cur_Type CURSOR FOR
			SELECT     GUID_Type, Name_Type, GUID_Type_Parent
				FROM         semtbl_Type
				WHERE     (GUID_Type = @GUID_Type_Token)
		OPEN cur_Type;
		FETCH NEXT FROM cur_Type INTO
			@GUID_Type,
			@strName_Type,
			@GUID_Type_Parent;
		If @@FETCH_STATUS=0
		BEGIN
			SET @strPath_Token = @strPath_Token+''\\''+@strName_Type;
			DECLARE cur_Type_Parent CURSOR FOR
				SELECT     GUID_Type, Name_Type, GUID_Type_Parent
					FROM         semtbl_Type
					WHERE     (GUID_Type = @GUID_Type_Parent);
			OPEN cur_Type_Parent;
			FETCH NEXT FROM cur_Type_Parent INTO
				@GUID_Type,
				@strName_Type,
				@GUID_Type_Parent;
			CLOSE cur_Type_Parent;
			DEALLOCATE cur_Type_Parent;
			WHILE  NOT @GUID_Type_Parent IS NULL 
			BEGIN
				SET @strPath_Token = @strPath_Token+''\''+@strName_Type;
				DECLARE cur_Type_Parent CURSOR FOR
					SELECT     GUID_Type, Name_Type, GUID_Type_Parent
						FROM         semtbl_Type
						WHERE     (GUID_Type = @GUID_Type_Parent);
				OPEN cur_Type_Parent;
				FETCH NEXT FROM cur_Type_Parent INTO
					@GUID_Type,
					@strName_Type,
					@GUID_Type_Parent;
				CLOSE cur_Type_Parent;
				DEALLOCATE cur_Type_Parent;
			END
			
		END
		CLOSE cur_Type;
		DEALLOCATE cur_Type;
		INSERT INTO @tmptbl_Path VALUES(
			@GUID_Token,
			@strName_Token,
			@GUID_Type_Token,
			@strPath_Token);
		FETCH NEXT FROM cur_Token INTO
				@GUID_Token,
				@strName_Token,
				@GUID_Type;
	END
	CLOSE cur_Token;
	DEALLOCATE cur_Token;
	-- Return the result of the function
	RETURN

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_Token_Attribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_Token_Attribute](
	[Version] [int] NOT NULL,
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_Token] [uniqueidentifier] NOT NULL,
	[GUID_Attribute] [uniqueidentifier] NOT NULL,
	[OrderID] [int] NOT NULL,
	[val_Bit] [bit] NULL,
	[val_Date] [datetime] NULL,
	[val_time] [datetime] NULL,
	[val_datetime] [datetime] NULL,
	[val_Real] [real] NULL,
	[val_Int] [int] NULL,
	[val_VarcharMax] [varchar](max) NULL,
	[val_Varchar255] [varchar](255) NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_Token_Attribute] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_TokenAttribute] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_Token_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Token_Attribute_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Token_Attribute] CHECK CONSTRAINT [FK_chngtbll_Token_Attribute_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_Token_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Token_Attribute_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Token_Attribute] CHECK CONSTRAINT [FK_chngtbll_Token_Attribute_chngtbll_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_TokenAttributeVarchar255]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_TokenAttributeVarchar255]

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

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT GUID_Token FROM semtbl_Token WHERE GUID_Type=dbo.func_TypeGUID_ObjectReferenceType() AND Name_Token=''Token-Attribute-Varchar255'');



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Token]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_Token_Token](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_Token_Token_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_Token_Left] [uniqueidentifier] NOT NULL,
	[GUID_Token_Right] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_Token_Token] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_Token_Token]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Token_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Token] CHECK CONSTRAINT [FK_semtbl_OR_Token_Token_semtbl_OR];
ALTER TABLE [dbo].[semtbl_OR_Token_Token]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Token_semtbl_RelationType] FOREIGN KEY([GUID_RelationType])
REFERENCES [dbo].[semtbl_RelationType] ([GUID_RelationType])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Token] CHECK CONSTRAINT [FK_semtbl_OR_Token_Token_semtbl_RelationType];
ALTER TABLE [dbo].[semtbl_OR_Token_Token]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Token_semtbl_Token] FOREIGN KEY([GUID_Token_Left])
REFERENCES [dbo].[semtbl_Token] ([GUID_Token]);
ALTER TABLE [dbo].[semtbl_OR_Token_Token] CHECK CONSTRAINT [FK_semtbl_OR_Token_Token_semtbl_Token];
ALTER TABLE [dbo].[semtbl_OR_Token_Token]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Token_semtbl_Token1] FOREIGN KEY([GUID_Token_Right])
REFERENCES [dbo].[semtbl_Token] ([GUID_Token])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Token] CHECK CONSTRAINT [FK_semtbl_OR_Token_Token_semtbl_Token1];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_AttributeType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_AttributeType]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_AttributeType() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_Type_OR]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_Type_OR]

AS

	SET NOCOUNT ON;

SELECT  dbo.func_GUID_ORType_OR() AS      GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Attribute_By_GUID]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.Attribute_By_GUID

(

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Attribute, Name_Attribute, GUID_AttributeType

FROM            semtbl_Attribute

WHERE        (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_TokenToken]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_TokenToken]

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

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT GUID_Token FROM semtbl_Token WHERE GUID_Type=dbo.func_TypeGUID_ObjectReferenceType() AND Name_Token=''Token-Token'');



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_TokenAttributeVarcharMAX]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_TokenAttributeVarcharMAX]

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

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT GUID_Token FROM semtbl_Token WHERE GUID_Type=dbo.func_TypeGUID_ObjectReferenceType() AND Name_Token=''Token-Attribute-VarcharMAX'');



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_Token]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_Token](
	[Version] [int] NOT NULL,
	[GUID_Token] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_Token] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Token] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_Token]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Token_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Token] CHECK CONSTRAINT [FK_chngtbll_Token_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_Token]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Token_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Token] CHECK CONSTRAINT [FK_chngtbll_Token_chngtbll_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type_Attribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_Type_Attribute](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_Type_Attribute_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[GUID_Attribute] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_Type_Attribute] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_Type_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Type_Attribute_semtbl_Attribute] FOREIGN KEY([GUID_Attribute])
REFERENCES [dbo].[semtbl_Attribute] ([GUID_Attribute])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Type_Attribute] CHECK CONSTRAINT [FK_semtbl_OR_Type_Attribute_semtbl_Attribute];
ALTER TABLE [dbo].[semtbl_OR_Type_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Type_Attribute_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Type_Attribute] CHECK CONSTRAINT [FK_semtbl_OR_Type_Attribute_semtbl_OR];
ALTER TABLE [dbo].[semtbl_OR_Type_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Type_Attribute_semtbl_Type] FOREIGN KEY([GUID_Type])
REFERENCES [dbo].[semtbl_Type] ([GUID_Type])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Type_Attribute] CHECK CONSTRAINT [FK_semtbl_OR_Type_Attribute_semtbl_Type];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Attribute_List_With_TypeName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE FUNCTION Attribute_List_With_TypeName

(	

	-- Add the parameters for the function here

	

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     semtbl_Attribute.GUID_Attribute, semtbl_Attribute.Name_Attribute, semtbl_Attribute.GUID_AttributeType, semtbl_AttributeType.Name_AttributeType

		FROM         semtbl_Attribute INNER JOIN

                      semtbl_AttributeType ON semtbl_Attribute.GUID_AttributeType = semtbl_AttributeType.GUID_AttributeType

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR]

AS

	SET NOCOUNT ON;

SELECT  dbo.func_GUID_ORType_OR() AS      GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_Token_Attribute_Varchar255]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_Token_Attribute_Varchar255]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_Token_Attribute_Varchar255() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_RelationType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_RelationType]

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

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT GUID_Token FROM semtbl_Token WHERE GUID_Type=dbo.func_TypeGUID_ObjectReferenceType() AND Name_Token=''RelationType'');



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type_Type]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_Type_Type](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_Type_Type_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_Type_Left] [uniqueidentifier] NOT NULL,
	[GUID_Type_Right] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_Type_Type] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_Type_Type]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Type_Type_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Type_Type] CHECK CONSTRAINT [FK_semtbl_OR_Type_Type_semtbl_OR];
ALTER TABLE [dbo].[semtbl_OR_Type_Type]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Type_Type_semtbl_RelationType] FOREIGN KEY([GUID_RelationType])
REFERENCES [dbo].[semtbl_RelationType] ([GUID_RelationType])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Type_Type] CHECK CONSTRAINT [FK_semtbl_OR_Type_Type_semtbl_RelationType];
ALTER TABLE [dbo].[semtbl_OR_Type_Type]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Type_Type_semtbl_Type] FOREIGN KEY([GUID_Type_Left])
REFERENCES [dbo].[semtbl_Type] ([GUID_Type])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Type_Type] CHECK CONSTRAINT [FK_semtbl_OR_Type_Type_semtbl_Type];
ALTER TABLE [dbo].[semtbl_OR_Type_Type]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Type_Type_semtbl_Type1] FOREIGN KEY([GUID_Type_Right])
REFERENCES [dbo].[semtbl_Type] ([GUID_Type]);
ALTER TABLE [dbo].[semtbl_OR_Type_Type] CHECK CONSTRAINT [FK_semtbl_OR_Type_Type_semtbl_Type1];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_Type]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_Type](
	[Version] [int] NOT NULL,
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[GUID_Type_Parent] [uniqueidentifier] NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_Type] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Type] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_Type]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Type_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Type] CHECK CONSTRAINT [FK_chngtbll_Type_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_Type]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Type_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Type] CHECK CONSTRAINT [FK_chngtbll_Type_chngtbll_Transaction];

'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_Token]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_Token]

AS

	SET NOCOUNT ON;

SELECT  dbo.func_GUID_ORType_Token() AS      GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Token_Attribute](
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_Token_Attribute_GUID_TokenAttribute]  DEFAULT (newid()),
	[GUID_Token] [uniqueidentifier] NOT NULL,
	[GUID_Attribute] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_Token_Attribute] PRIMARY KEY CLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Token_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_Attribute_semtbl_attribute] FOREIGN KEY([GUID_Attribute])
REFERENCES [dbo].[semtbl_Attribute] ([GUID_Attribute]);
ALTER TABLE [dbo].[semtbl_Token_Attribute] CHECK CONSTRAINT [FK_semtbl_Token_Attribute_semtbl_attribute];
ALTER TABLE [dbo].[semtbl_Token_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_Attribute_semtbl_Token] FOREIGN KEY([GUID_Token])
REFERENCES [dbo].[semtbl_Token] ([GUID_Token]);
ALTER TABLE [dbo].[semtbl_Token_Attribute] CHECK CONSTRAINT [FK_semtbl_Token_Attribute_semtbl_Token];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Token_Like_Name]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Token_Like_Name]

	-- Add the parameters for the stored procedure here

	@Search		VARCHAR(255)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	SET @Search=REPLACE(@Search,'''','''''''')

    -- Insert statements for procedure here

	SELECT GUID_Token, Name_Token, GUID_Type

	FROM semtbl_Token

	WHERE Name_Token LIKE ''%'' + @Search + ''%''

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semfunc_LogStates]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[semfunc_LogStates] 
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token.GUID_Token, semtbl_Token.Name_Token, semtbl_Token.GUID_Type
FROM         semtbl_Token INNER JOIN
                      semtbl_Type ON semtbl_Token.GUID_Type = semtbl_Type.GUID_Type
WHERE     (semtbl_Type.Name_Type = ''LogState'')
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_Token]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_Token]

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

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT GUID_Token FROM semtbl_Token WHERE GUID_Type=dbo.func_TypeGUID_ObjectReferenceType() AND Name_Token=''Token'');



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Type_OR_Simpl_By_GUIDType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.proc_Type_OR_Simpl_By_GUIDType

(

	@GUID_Type uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Type, GUID_RelationType, Min_forw, Max_forw

FROM            semtbl_Type_OR

WHERE        (GUID_Type = @GUID_Type)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_Token_Token]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_Token_Token](
	[Version] [int] NOT NULL,
	[GUID_Token_Left] [uniqueidentifier] NOT NULL,
	[GUID_Token_Right] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[OrderID] [int] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_Token_Token] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Token_Left] ASC,
	[GUID_Token_Right] ASC,
	[GUID_RelationType] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_Token_Token]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Token_Token_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Token_Token] CHECK CONSTRAINT [FK_chngtbll_Token_Token_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_Token_Token]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Token_Token_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Token_Token] CHECK CONSTRAINT [FK_chngtbll_Token_Token_chngtbll_Transaction];

'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TypeRelProc_MinMaxFMaxB_ByGUIDs]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.TypeRelProc_MinMaxFMaxB_ByGUIDs

(

	@GUID_Type_Left uniqueidentifier,

	@GUID_Type_Right uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Type_Left, GUID_Type_Right, GUID_RelationType, Min_forw, Max_forw, Max_backw

FROM            semtbl_Type_Type

WHERE        (GUID_Type_Left = @GUID_Type_Left) AND (GUID_Type_Right = @GUID_Type_Right) AND (GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_Token_Attribute_Int]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_Token_Attribute_Int]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_Token_Attribute_Int() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_TokenAttributeBit]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_TokenAttributeBit]

AS

	SET NOCOUNT ON;

SELECT dbo.func_GUID_ORType_TokenAttributeBit

() AS       GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_Attribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_Attribute]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_Attribute() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_OR_Type]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_OR_Type](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_OR_Type] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_OR_Type]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_Type_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_Type] CHECK CONSTRAINT [FK_chngtbll_OR_Type_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_OR_Type]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_Type_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_Type] CHECK CONSTRAINT [FK_chngtbll_OR_Type_chngtbll_Transaction];

'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_ObjectReference]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE dbg_ObjectReference

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     semfunc_ObjectReference_1.*

FROM         dbo.semfunc_ObjectReference() AS semfunc_ObjectReference_1

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_OR_AttributeType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_OR_AttributeType](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_AttributeType] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_OR_AttributeType] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_OR_AttributeType]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_AttributeType_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_AttributeType] CHECK CONSTRAINT [FK_chngtbll_OR_AttributeType_chngtbll_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_Token_OR]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_Token_OR](
	[Version] [int] NOT NULL,
	[GUID_Token_Left] [uniqueidentifier] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[OrderID] [int] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_Token_OR] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Token_Left] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_RelationType] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_Token_OR]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Token_OR_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Token_OR] CHECK CONSTRAINT [FK_chngtbll_Token_OR_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_Token_OR]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Token_OR_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Token_OR] CHECK CONSTRAINT [FK_chngtbll_Token_OR_chngtbll_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_WMI_ProcessorID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION func_WMI_ProcessorID
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_ProcessorID	uniqueidentifier;

	-- Add the T-SQL statements to compute the return value here
	SET @GUID_ProcessorID = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=''ProcessorID'');

	-- Return the result of the function
	RETURN @GUID_ProcessorID;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Type_OR_By_GUIDType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_Type_OR_By_GUIDType]

(

	@GUID_Type uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     semtbl_Type_OR.GUID_Type, semtbl_Type.Name_Type, semtbl_Type_OR.GUID_RelationType, semtbl_RelationType.Name_RelationType, 

                      semtbl_Type_OR.Min_forw, semtbl_Type_OR.Max_forw

FROM         semtbl_Type_OR INNER JOIN

                      semtbl_Type ON semtbl_Type_OR.GUID_Type = semtbl_Type.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Type_OR.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE     (semtbl_Type_OR.GUID_Type = @GUID_Type)

ORDER BY semtbl_RelationType.Name_RelationType'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_AttributeType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_AttributeType](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_AttributeType_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_AttributeType] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_AttributeType] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_semtbl_OR_AttributeType] UNIQUE NONCLUSTERED 
(
	[GUID_AttributeType] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_AttributeType]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_AttributeType_semtbl_AttributeType] FOREIGN KEY([GUID_AttributeType])
REFERENCES [dbo].[semtbl_AttributeType] ([GUID_AttributeType])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_AttributeType] CHECK CONSTRAINT [FK_semtbl_OR_AttributeType_semtbl_AttributeType];
ALTER TABLE [dbo].[semtbl_OR_AttributeType]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_AttributeType_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_AttributeType] CHECK CONSTRAINT [FK_semtbl_OR_AttributeType_semtbl_OR];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_Type_OR]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_Type_OR](
	[Version] [int] NOT NULL,
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Min_forw] [int] NOT NULL,
	[Max_forw] [int] NOT NULL,
	[GUID_Transation] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_Type_OR] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Type] ASC,
	[GUID_RelationType] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_Type_OR]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Type_OR_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Type_OR] CHECK CONSTRAINT [FK_chngtbll_Type_OR_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_Type_OR]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Type_OR_chngtbll_Transaction] FOREIGN KEY([GUID_Transation])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Type_OR] CHECK CONSTRAINT [FK_chngtbll_Type_OR_chngtbll_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_Token_Attribute_Datetime]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_Token_Attribute_Datetime]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_Token_Attribute_Datetime() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_TokenAttributeInt]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_TokenAttributeInt]

AS

	SET NOCOUNT ON;

SELECT  dbo.func_GUID_ORType_TokenAttributeInt() AS      GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_OR_TokenAttribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_OR_TokenAttribute](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
	[GUID_Transation] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_OR_TokenAttribute] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_OR_TokenAttribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_TokenAttribute_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_TokenAttribute] CHECK CONSTRAINT [FK_chngtbll_OR_TokenAttribute_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_OR_TokenAttribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_TokenAttribute_chngtbll_Transaction] FOREIGN KEY([GUID_Transation])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_TokenAttribute] CHECK CONSTRAINT [FK_chngtbll_OR_TokenAttribute_chngtbll_Transaction];



'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_Type](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_Type_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_Type] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_Type] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_semtbl_OR_Type] UNIQUE NONCLUSTERED 
(
	[GUID_Type] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_Type]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Type_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Type] CHECK CONSTRAINT [FK_semtbl_OR_Type_semtbl_OR];
ALTER TABLE [dbo].[semtbl_OR_Type]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Type_semtbl_Type] FOREIGN KEY([GUID_Type])
REFERENCES [dbo].[semtbl_Type] ([GUID_Type])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Type] CHECK CONSTRAINT [FK_semtbl_OR_Type_semtbl_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_Type_Rel]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_Type_Rel](
	[Version] [int] NOT NULL,
	[GUID_Type_Left] [uniqueidentifier] NOT NULL,
	[GUID_Type_Right] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Min_Forw] [int] NOT NULL,
	[Max_Forw] [int] NOT NULL,
	[Max_Backw] [int] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_Type_Rel] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Type_Left] ASC,
	[GUID_Type_Right] ASC,
	[GUID_RelationType] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_Type_Rel]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Type_Rel_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Type_Rel] CHECK CONSTRAINT [FK_chngtbll_Type_Rel_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_Type_Rel]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Type_Rel_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_Type_Rel] CHECK CONSTRAINT [FK_chngtbll_Type_Rel_chngtbll_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Token_By_GUID]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Token_By_GUID]

(

	@strGUID_Token uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Token, Name_Token, GUID_Type

FROM            semtbl_Token

WHERE        (GUID_Token = @strGUID_Token)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Token_Like_Name]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Token_Like_Name]

	-- Add the parameters for the stored procedure here

	@Search		VARCHAR(255)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	SET @Search=REPLACE(@Search,'''','''''''')

    -- Insert statements for procedure here

	SELECT GUID_Token, Name_Token, GUID_Type

	FROM semtbl_Token

	WHERE Name_Token LIKE ''%'' + @Search + ''%''

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_AttributeType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_AttributeType](
	[Version] [int] NOT NULL,
	[GUID_AttributeType] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_Attribute_Type] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_AttributeType] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_AttributeType]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_Attribute_Type_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_AttributeType] CHECK CONSTRAINT [FK_chngtbll_Attribute_Type_chngtbll_Transaction];

ALTER TABLE [dbo].[chngtbll_AttributeType]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_AttributeType_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_AttributeType] CHECK CONSTRAINT [FK_chngtbll_AttributeType_chngtbll_DB];

'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_Type]

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

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT GUID_Token FROM semtbl_Token WHERE GUID_Type=dbo.func_TypeGUID_ObjectReferenceType() AND Name_Token=''Type'');



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_Attribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Type_Attribute](
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[GUID_Attribute] [uniqueidentifier] NOT NULL,
	[Min] [int] NOT NULL CONSTRAINT [DF_semtbl_Type_Attribute_Min]  DEFAULT ((1)),
	[Max] [int] NOT NULL CONSTRAINT [DF_semtbl_Type_Attribute_Max]  DEFAULT ((1)),
 CONSTRAINT [PK_semtbl_Type_Attribute] PRIMARY KEY CLUSTERED 
(
	[GUID_Type] ASC,
	[GUID_Attribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Type_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Type_Attribute_semtbl_attribute] FOREIGN KEY([GUID_Attribute])
REFERENCES [dbo].[semtbl_Attribute] ([GUID_Attribute]);
ALTER TABLE [dbo].[semtbl_Type_Attribute] CHECK CONSTRAINT [FK_semtbl_Type_Attribute_semtbl_attribute];
ALTER TABLE [dbo].[semtbl_Type_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Type_Attribute_semtbl_Type_Attribute] FOREIGN KEY([GUID_Type])
REFERENCES [dbo].[semtbl_Type] ([GUID_Type]);
ALTER TABLE [dbo].[semtbl_Type_Attribute] CHECK CONSTRAINT [FK_semtbl_Type_Attribute_semtbl_Type_Attribute];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_RelationType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_RelationType](
	[Version] [int] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_RelationType] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_RelationType] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_RelationType]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_RelationType_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_RelationType] CHECK CONSTRAINT [FK_chngtbll_RelationType_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_RelationType]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_RelationType_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_RelationType] CHECK CONSTRAINT [FK_chngtbll_RelationType_chngtbll_Transaction];

'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_Token_OR]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_Token_OR]

AS

	SET NOCOUNT ON;

SELECT  dbo.func_GUID_ORType_Token_OR() AS      GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Attribute_Like_Name]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Attribute_Like_Name]

	-- Add the parameters for the stored procedure here

	@Search		VARCHAR(255)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	SET @Search=REPLACE(@Search,'''','''''''')

    -- Insert statements for procedure here

	SELECT GUID_Attribute, Name_Attribute, GUID_AttributeType

	FROM semtbl_Attribute

	WHERE Name_Attribute LIKE ''%'' + @Search + ''%''

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Token_By_LikeName_And_GUIDType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'

CREATE PROCEDURE [dbo].[Token_By_LikeName_And_GUIDType]

(

	@strGUID_Type uniqueidentifier,

	@strName_Token varchar(255)

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Token, Name_Token, GUID_Type

FROM            semtbl_Token

WHERE        (GUID_Type = @strGUID_Type) AND (Name_Token LIKE ''%''+ @strName_Token + ''%'')

ORDER BY Name_Token
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_Token_Attribute_Date]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_Token_Attribute_Date]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_Token_Attribute_Date() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[typefunc_Types_Rel]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[typefunc_Types_Rel] 
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Type.GUID_Type AS GUID_Type_Left, semtbl_Type.Name_Type AS Name_Type_Left, semtbl_Type.GUID_Type_Parent AS GUID_Type_Parent_Left, 
                      semtbl_RelationType.GUID_RelationType, semtbl_RelationType.Name_RelationType, semtbl_Type_1.GUID_Type AS GUID_Type_Right, 
                      semtbl_Type_1.Name_Type AS Name_Type_Right, semtbl_Type_1.GUID_Type_Parent AS GUID_Type_Parent_Right, semtbl_Type_Type.Min_forw, 
                      semtbl_Type_Type.Max_forw, semtbl_Type_Type.Max_backw
FROM         semtbl_RelationType INNER JOIN
                      semtbl_Type_Type ON semtbl_RelationType.GUID_RelationType = semtbl_Type_Type.GUID_RelationType INNER JOIN
                      semtbl_Type ON semtbl_Type_Type.GUID_Type_Left = semtbl_Type.GUID_Type INNER JOIN
                      semtbl_Type AS semtbl_Type_1 ON semtbl_Type_Type.GUID_Type_Right = semtbl_Type_1.GUID_Type
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ObjectReference_By_GUID_Ref]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.proc_ObjectReference_By_GUID_Ref

(

	@GUID_ReferencedObject uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_ObjectReference, Name_Token, GUID_Ref, GUID_ItemType

FROM            dbo.semfunc_ObjectReference() AS semfunc_ObjectReference_1

WHERE        (GUID_Ref = @GUID_ReferencedObject)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_TypeType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_TypeType]

AS

	SET NOCOUNT ON;

SELECT  dbo.func_GUID_ORType_TypeType() AS      GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_Token](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_Token_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_Token] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_Token] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_semtbl_OR_Token] UNIQUE NONCLUSTERED 
(
	[GUID_Token] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_Token]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token] CHECK CONSTRAINT [FK_semtbl_OR_Token_semtbl_OR];
ALTER TABLE [dbo].[semtbl_OR_Token]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_semtbl_Token] FOREIGN KEY([GUID_Token])
REFERENCES [dbo].[semtbl_Token] ([GUID_Token])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token] CHECK CONSTRAINT [FK_semtbl_OR_Token_semtbl_Token];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_OR_TokenToken]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_OR_TokenToken](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_Token_Left] [uniqueidentifier] NOT NULL,
	[GUID_Token_Right] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_OR_TokenToken] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_OR_TokenToken]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_TokenToken_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_TokenToken] CHECK CONSTRAINT [FK_chngtbll_OR_TokenToken_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_OR_TokenToken]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_TokenToken_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_TokenToken] CHECK CONSTRAINT [FK_chngtbll_OR_TokenToken_chngtbll_Transaction];


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_OR]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Token_OR](
	[GUID_Token_Left] [uniqueidentifier] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[OrderID] [int] NOT NULL CONSTRAINT [DF_semtbl_Token_OR_OrderID]  DEFAULT ((0)),
 CONSTRAINT [PK_semtbl_Token_OR] PRIMARY KEY CLUSTERED 
(
	[GUID_Token_Left] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_RelationType] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Token_OR]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_OR_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference]);
ALTER TABLE [dbo].[semtbl_Token_OR] CHECK CONSTRAINT [FK_semtbl_Token_OR_semtbl_OR];
ALTER TABLE [dbo].[semtbl_Token_OR]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_OR_semtbl_RelationType] FOREIGN KEY([GUID_RelationType])
REFERENCES [dbo].[semtbl_RelationType] ([GUID_RelationType]);
ALTER TABLE [dbo].[semtbl_Token_OR] CHECK CONSTRAINT [FK_semtbl_Token_OR_semtbl_RelationType];
ALTER TABLE [dbo].[semtbl_Token_OR]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_OR_semtbl_Token] FOREIGN KEY([GUID_Token_Left])
REFERENCES [dbo].[semtbl_Token] ([GUID_Token])
ON UPDATE CASCADE;
ALTER TABLE [dbo].[semtbl_Token_OR] CHECK CONSTRAINT [FK_semtbl_Token_OR_semtbl_Token];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_RelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_RelationType]

AS

	SET NOCOUNT ON;

SELECT  dbo.func_GUID_ORType_RelationType() AS  GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_Attribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_Attribute]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_Attribute() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_TokenAttributeDatetime]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_TokenAttributeDatetime]

AS

	SET NOCOUNT ON;

SELECT  dbo.func_GUID_ORType_TokenAttributeDatetime() AS      GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_Token]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_Token]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_Token() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_TypesTree]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[func_TypesTree]
(
)
RETURNS @tmptbl_Types_TABLE TABLE
(
	GUID_Type			uniqueidentifier,
	Name_Type			varchar(255),
	GUID_Type_Parent	uniqueidentifier,
	LevelID				int
) 
AS
BEGIN
	DECLARE @GUID_Type_Root		uniqueidentifier;
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);
	DECLARE @GUID_Type_Parent	uniqueidentifier;
	DECLARE @intLevel			int;

	SET @GUID_Type_Root = dbo.func_Type_Root();
	SET @intLevel=1;
	
	INSERT INTO @tmptbl_Types_TABLE (GUID_Type, Name_Type, LevelID) VALUES(@GUID_Type_Root,''Root'',0);

	DECLARE cur_Types CURSOR FOR
		SELECT * FROM dbo.func_Types_of_Parent(@GUID_Type_Root,@intLevel);	
	OPEN cur_Types;
	FETCH NEXT FROM cur_Types INTO
		@GUID_Type,
		@Name_Type,
		@GUID_Type_Parent,
		@intLevel;
	WHILE @@FETCH_STATUS=0
	BEGIN
		INSERT INTO @tmptbl_Types_TABLE VALUES (
			@GUID_Type,
			@Name_Type,
			@GUID_Type_Parent,
			@intLevel);

		FETCH NEXT FROM cur_Types  INTO
			@GUID_Type,
			@Name_Type,
			@GUID_Type_Parent,
			@intLevel;
	END
	CLOSE cur_Types;
	DEALLOCATE cur_Types;
	RETURN
END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TypeRel_By_GUIDTypeLeft]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.proc_TypeRel_By_GUIDTypeLeft

(

	@GUID_Type_Left uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Type_Left, GUID_Type_Right, GUID_RelationType, Min_forw, Max_forw, Max_backw

FROM            semtbl_Type_Type

WHERE        (GUID_Type_Left = @GUID_Type_Left)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Token_By_Name_And_GUIDType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Token_By_Name_And_GUIDType]

(

	@strGUID_Type uniqueidentifier,

	@strName_Token varchar(255)

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Token, Name_Token, GUID_Type

FROM            semtbl_Token

WHERE        (GUID_Type = @strGUID_Type) AND (Name_Token = @strName_Token)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR]

AS

	SET NOCOUNT ON;

SELECT  dbo.func_GUID_ORType_OR() AS      GUID_ObjectReferenceType
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_Token_Attribute_Real]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_Token_Attribute_Real]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_Token_Attribute_Real() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_OR_RelationType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_OR_RelationType](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_OR_RelationType] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_OR_RelationType]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_RelationType_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_RelationType] CHECK CONSTRAINT [FK_chngtbll_OR_RelationType_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_OR_RelationType]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_RelationType_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_RelationType] CHECK CONSTRAINT [FK_chngtbll_OR_RelationType_chngtbll_Transaction];

'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Token]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Token_Token](
	[GUID_Token_Left] [uniqueidentifier] NOT NULL,
	[GUID_Token_Right] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[OrderID] [int] NOT NULL CONSTRAINT [DF_semtbl_Token_Token_OrderID]  DEFAULT ((0)),
 CONSTRAINT [PK_semtbl_Token_Token] PRIMARY KEY CLUSTERED 
(
	[GUID_Token_Left] ASC,
	[GUID_Token_Right] ASC,
	[GUID_RelationType] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Token_Token]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_Token_semtbl_RelationType] FOREIGN KEY([GUID_RelationType])
REFERENCES [dbo].[semtbl_RelationType] ([GUID_RelationType]);
ALTER TABLE [dbo].[semtbl_Token_Token] CHECK CONSTRAINT [FK_semtbl_Token_Token_semtbl_RelationType];
ALTER TABLE [dbo].[semtbl_Token_Token]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_Token_semtbl_Token] FOREIGN KEY([GUID_Token_Left])
REFERENCES [dbo].[semtbl_Token] ([GUID_Token]);
ALTER TABLE [dbo].[semtbl_Token_Token] CHECK CONSTRAINT [FK_semtbl_Token_Token_semtbl_Token];
ALTER TABLE [dbo].[semtbl_Token_Token]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_Token_semtbl_Token1] FOREIGN KEY([GUID_Token_Right])
REFERENCES [dbo].[semtbl_Token] ([GUID_Token]);
ALTER TABLE [dbo].[semtbl_Token_Token] CHECK CONSTRAINT [FK_semtbl_Token_Token_semtbl_Token1];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_Type_Attribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_Type_Attribute]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_Type_Attribute() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[is_ObjectReferenceType_TokenAttributeBit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[is_ObjectReferenceType_TokenAttributeBit]

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

	

	SET @strGUID_Token_ObjectReferenceType=(SELECT GUID_Token FROM semtbl_Token WHERE GUID_Type=dbo.func_TypeGUID_ObjectReferenceType() AND Name_Token=''Token-Attribute-Bit'');



	If @strGUID_Token_ObjectReferenceType=@strGUID_ObjectReferenceType

		SET @bitResult = 1;

	-- Return the result of the function

	RETURN @bitResult;



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ORType_OR_RelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_ORType_OR_RelationType]

AS

	SET NOCOUNT ON;

	SELECT dbo.func_GUID_ORType_OR_RelationType() AS GUID_ObjectReferenceType;'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbll_OR_Token]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[chngtbll_OR_Token](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_Token] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbll_OR_Token] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbll_OR_Token]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_Token_chngtbll_DB] FOREIGN KEY([GUID_DB])
REFERENCES [dbo].[chngtbll_DB] ([GUID_DB])
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_Token] CHECK CONSTRAINT [FK_chngtbll_OR_Token_chngtbll_DB];

ALTER TABLE [dbo].[chngtbll_OR_Token]  WITH CHECK ADD  CONSTRAINT [FK_chngtbll_OR_Token_chngtbll_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbll_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbll_OR_Token] CHECK CONSTRAINT [FK_chngtbll_OR_Token_chngtbll_Transaction];

'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_Attribute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_Attribute]

(

	-- Add the parameters for the function here

	@GUID_Attribute	uniqueidentifier,

	@GUID_DB		uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxAttribute int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxAttribute = (SELECT  TOP 1 [Version] AS MaxVersion

FROM         chngtbll_Attribute

WHERE     (GUID_Attribute = @GUID_Attribute) AND (GUID_DB = @GUID_DB)

ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxAttribute



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_TokenAttribute_Int]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_TokenAttribute_Int]

	-- Add the parameters for the stored procedure here

	@GUID_Token		uniqueidentifier,

	@GUID_Attribute uniqueidentifier,

	@GUID_TokenAttribute uniqueidentifier,

	@val_Int				int,

	@intOrderID				int

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Token_DB			uniqueidentifier;

	DECLARE @GUID_Attribute_DB		uniqueidentifier;

	DECLARE @GUID_TokenAttribute_DB	uniqueidentifier;

	DECLARE @val_Int_DB				int;

	DECLARe @intOrderID_DB			int;



    -- Insert statements for procedure here

	If @GUID_TokenAttribute IS NULL

	BEGIN

		SET @GUID_Token_DB = (SELECT GUID_Token FROM semtbl_Token WHERE GUID_Token=@GUID_Token);

		SET @GUID_Attribute_DB = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE GUID_Attribute=@GUID_Attribute);

		

		If @GUID_Token IS NULL OR @GUID_Attribute IS NULL

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		ELSE

		BEGIN

			SET @GUID_TokenAttribute = newid()

			INSERT INTO semtbl_Token_Attribute VALUES (@GUID_TokenAttribute,@GUID_Token,@GUID_Attribute);

			INSERT INTO semtbl_Token_Attribute_Int VALUES (@GUID_TokenAttribute,@val_Int,@intOrderID);

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

	END

	ELSE

	BEGIN

		DECLARE cur_TokenAttribute_INT CURSOR FOR 

			SELECT     semtbl_Token_Attribute.GUID_TokenAttribute, semtbl_Token_Attribute_Int.val, semtbl_Token_Attribute_Int.OrderID

FROM         semtbl_Token_Attribute INNER JOIN

                      semtbl_Token_Attribute_Int ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Int.GUID_TokenAttribute

WHERE     (semtbl_Token_Attribute.GUID_TokenAttribute = @GUID_TokenAttribute)

		OPEN cur_TokenAttribute_INT;

		FETCH NEXT FROM cur_TokenAttribute_INT INTO

			@GUID_TokenAttribute_DB,

			@val_Int_DB,

			@intOrderID_DB;

		IF @@FETCH_STATUS=0

		BEGIN

			If NOT @val_Int_DB=@val_Int

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_Int SET Val=@val_Int, OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					UPDATE semtbl_Token_Attribute_Int SET Val=@val_Int WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

			END

			ELSE

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_Int SET OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

				END

			END

		END

		ELSE

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		CLOSE cur_TokenAttribute_INT;

		DEALLOCATE cur_TokenAttribute_INT;

		

	END

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Token_Path]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE dbg_Token_Path

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT * FROM dbo.semfunc_Token_Path()

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_OR_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_OR_Type]

(

	-- Add the parameters for the function here

	@GUID_ObjectReference	uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxObjectReference int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxObjectReference = (SELECT  TOP 1 [Version] AS MaxVersion

		FROM         chngtbll_OR_Type

		WHERE     (GUID_DB = @GUID_DB) AND (GUID_ObjectReference = @GUID_ObjectReference)

		ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxObjectReference



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_Attribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_Attribute] 

	-- Add the parameters for the stored procedure here

	@GUID_Attribute			uniqueidentifier,

	@Name_Attribute			varchar(255),

	@GUID_AttributeType		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Attribute_DB		uniqueidentifier;

	DECLARE @Name_Attribute_DB		varchar(255);

	DECLARE @GUID_AttributeType_DB	uniqueidentifier;

	DECLARE @intCount_Tokens		int;

	DECLARE @bit_Change				bit;

	DECLARE @bit_Relation			bit;



    -- Insert statements for procedure here

	DECLARE cur_Attribute CURSOR FOR

		SELECT     GUID_Attribute, Name_Attribute, GUID_AttributeType

			FROM         semtbl_Attribute WHERE GUID_Attribute=@GUID_Attribute;



	OPEN cur_Attribute;

	FETCH NEXT FROM cur_Attribute INTO

		@GUID_Attribute_DB,

		@Name_Attribute_DB,

		@GUID_AttributeType_DB;

	IF @@FETCH_STATUS=0 

	BEGIN

		SET @bit_Change = 0;

		SET @bit_Relation = 0;

		IF NOT @Name_Attribute_DB=@Name_Attribute

		BEGIN

			UPDATE semtbl_Attribute SET Name_Attribute = @Name_attribute WHERE GUID_Attribute=@GUID_Attribute;

			SET @bit_Change = 1;

		END

		IF NOT @GUID_AttributeType = @GUID_Attribute_DB

		BEGIN

			SET @intCount_Tokens = (SELECT     COUNT(*) AS Count_Token

				FROM         semtbl_Token_Attribute

				WHERE     (GUID_Attribute = @GUID_Attribute));

			IF @intCount_Tokens = 0

			BEGIN

				UPDATE semtbl_Attribute SET GUID_AttributeType = @GUID_AttributeType WHERE GUID_Attribute=@GUID_Attribute;

				SET @bit_Change = 1;

			END

			ELSE

			BEGIN

				SET @bit_Relation=1;

			END

			

		END 

		If @bit_Change=1

		BEGIN

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

		END

		ELSE

		BEGIN

			IF @bit_Relation = 0

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

			ELSE

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

		END

	END

	ELSE

	BEGIN

		INSERT INTO semtbl_Attribute VALUES (@GUID_Attribute,@Name_Attribute,@GUID_AttributeType);

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

	END

	CLOSE cur_Attribute;

	DEALLOCATE cur_Attribute;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_DBWork_Save_OR_RelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_DBWork_Save_OR_RelationType]

	-- Add the parameters for the stored procedure here

		@GUID_Ref			uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	

	DECLARE @GUID_ObjectReference	uniqueidentifier;

	DECLARE @Name_Token				varchar(255);

	DECLARE @GUID_ItemType			uniqueidentifier;

	DECLARE @intCount				int;



	-- Typ-Abhängig (RelationType

	SET @GUID_ItemType = dbo.func_GUID_ORType_RelationType()

	SET @intCount = (SELECT     COUNT(*) AS Count_RelationTypes

		FROM         semtbl_RelationType

		WHERE    (GUID_RelationType = @GUID_Ref));

	-- Typ-Abhängig (RelationType



	IF @intCount > 0

	BEGIN

		-- Typ-Abhängig (RelationType

		SET @GUID_ObjectReference = (SELECT     GUID_ObjectReference

			FROM         semtbl_OR_RelationType

			WHERE     (GUID_RelationType = @GUID_Ref));

		-- Typ-Abhängig (RelationType



		IF @GUID_ObjectReference is null

		BEGIN

			SET @GUID_ObjectReference=newid();

			INSERT INTO semtbl_OR VALUES (@GUID_ObjectReference,@GUID_ItemType);



			-- Typ-Abhängig (Attribute

			INSERT INTO semtbl_OR_RelationType VALUES(@GUID_ObjectReference,@GUID_Ref);

			-- Typ-Abhängig (Attribute



			SELECT *,@GUID_ObjectReference AS GUID_ObjectReference FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

		ELSE

		BEGIN

			SELECT *,@GUID_ObjectReference AS GUID_ObjectReference FROM dbo.semfunc_LogStates() WHERE Name_Token=''Exists'';

		END

		

	END

	ELSE

	BEGIN

		SELECT *,null AS GUID_ObjectReference FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

	END

	

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenToken_RightLeft]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenToken_RightLeft]

(

	@strGUID_Token_Right uniqueidentifier,

	@strRelationTypeGUID uniqueidentifier,

	@strGUID_Type_Left uniqueidentifier

	

)

AS

	SET NOCOUNT ON;

SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE     (semtbl_Token_Right.GUID_Token = @strGUID_Token_Right) AND (semtbl_Token_Left.GUID_Type = @strGUID_Type_Left) AND (semtbl_RelationType.GUID_RelationType = @strRelationTypeGUID)

ORDER BY semtbl_Token_Left.Name_Token'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_Type_Attribute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_Type_Attribute]

(

	-- Add the parameters for the function here

	@GUID_Type			uniqueidentifier,

	@GUID_Attribute		uniqueidentifier,

	@GUID_DB			uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxTypeAttrib int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxTypeAttrib = (SELECT  TOP 1  [Version] AS MaxVersion

FROM         chngtbll_Type_Attribute

WHERE     (GUID_Type = @GUID_Type) AND (GUID_Type = @GUID_Type) AND (GUID_DB = @GUID_DB)

ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxTypeAttrib



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_Token_Token]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_Token_Token]

(

	-- Add the parameters for the function here

	@GUID_Token_Left		uniqueidentifier,

	@GUID_Token_Right		uniqueidentifier,

	@GUID_RelationType		uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxTokenRel int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxTokenRel = (SELECT  TOP 1   [Version] AS MaxVersion

FROM         chngtbll_Token_Token

WHERE     (GUID_Token_Left = @GUID_Token_Left) AND (GUID_Token_Right = @GUID_Token_Right) AND (GUID_RelationType = @GUID_RelationType) AND (GUID_DB = @GUID_DB)

ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxTokenRel



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_TypeRel]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_TypeRel] 

	-- Add the parameters for the stored procedure here

	@GUID_Type_Left		uniqueidentifier,

	@GUID_Type_Right	uniqueidentifier,

	@GUID_RelationType	uniqueidentifier,

	@intMin_forw		int,

	@intMax_forw		int,

	@intMax_backw		int

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Type_Left_DB		uniqueidentifier;

	DECLARE @GUID_Type_Right_DB		uniqueidentifier;

	DECLARE @GUID_RelationType_DB	uniqueidentifier;

	DECLARE @intMin_forw_db			int;

	DECLARE @intMax_forw_db			int;

	DECLARE @intMax_backw_db		int;

	DECLARE	@bitMin_forw			bit;

	DECLARE @bitMax_forw			bit;

	DECLARE @bitMax_backw			bit;

	DECLARE @bitChange				bit;



    -- Insert statements for procedure here

	DECLARE cur_Type_Rel CURSOR FOR

		SELECT     GUID_Type_Left, GUID_Type_Right, GUID_RelationType, Min_forw, Max_forw, Max_backw

			FROM         semtbl_Type_Type

			WHERE     (GUID_Type_Left = @GUID_Type_Left) AND (GUID_Type_Right = @GUID_Type_Right) AND (GUID_RelationType = @GUID_RelationType);



	OPEN cur_Type_Rel;

	FETCH NEXT FROM cur_Type_Rel INTO

		@GUID_Type_Left_DB,

		@GUID_Type_Right_DB,

		@GUID_RelationType,

		@intMin_forw_db,

		@intMax_forw_db,

		@intMax_backw_db;



	SET @bitChange = 0;

	IF @@FETCH_STATUS=0 

	BEGIN

		If @intMin_forw <> @intMin_forw_db

		BEGIN

			SET @bitMin_forw = 1;

			SET @bitChange=1;	

		END

		ELSE

		BEGIN

			SET @bitMin_forw = 0;

		END

		If @intMax_forw <> @intMax_forw_db

		BEGIN

			SET @bitMax_forw = 1;	

			SET @bitChange=1;

		END

		ELSE

		BEGIN

			SET @bitMax_forw = 0;

		END

		If @intMax_backw <> @intMax_backw_db

		BEGIN

			SET @bitMax_backw = 1;	

			SET @bitChange=1;

		END

		ELSE

		BEGIN

			SET @bitMax_backw = 0;

		END



		If @bitMin_forw = 1 AND @bitMax_forw = 1 AND @bitMax_backw = 1

			UPDATE semtbl_Type_type SET Min_forw=@intMin_forw,Max_forw=@intMax_forw,Max_backw=@intMax_backw

				WHERE     (GUID_Type_Left = @GUID_Type_Left) AND (GUID_Type_Right = @GUID_Type_Right) AND (GUID_RelationType = @GUID_RelationType);

		IF @bitMin_forw = 1 AND @bitMax_forw = 1 AND @bitMax_backw = 0

			UPDATE semtbl_Type_type SET Min_forw=@intMin_forw,Max_forw=@intMax_forw

				WHERE     (GUID_Type_Left = @GUID_Type_Left) AND (GUID_Type_Right = @GUID_Type_Right) AND (GUID_RelationType = @GUID_RelationType);

		IF @bitMin_forw = 1 AND @bitMax_forw = 0 AND @bitMax_backw = 1

			UPDATE semtbl_Type_type SET Min_forw=@intMin_forw,Max_backw=@intMax_backw

				WHERE     (GUID_Type_Left = @GUID_Type_Left) AND (GUID_Type_Right = @GUID_Type_Right) AND (GUID_RelationType = @GUID_RelationType);

		IF @bitMin_forw = 1 AND @bitMax_forw = 0 AND @bitMax_backw = 0

			UPDATE semtbl_Type_type SET Min_forw=@intMin_forw

				WHERE     (GUID_Type_Left = @GUID_Type_Left) AND (GUID_Type_Right = @GUID_Type_Right) AND (GUID_RelationType = @GUID_RelationType);

		IF @bitMin_forw = 0 AND @bitMax_forw = 1 AND @bitMax_backw = 1

			UPDATE semtbl_Type_type SET Max_forw=@intMax_forw,Max_backw=@intMax_backw

				WHERE     (GUID_Type_Left = @GUID_Type_Left) AND (GUID_Type_Right = @GUID_Type_Right) AND (GUID_RelationType = @GUID_RelationType);

		IF @bitMin_forw = 0 AND @bitMax_forw = 1 AND @bitMax_backw = 0

			UPDATE semtbl_Type_type SET Max_forw=@intMax_forw

				WHERE     (GUID_Type_Left = @GUID_Type_Left) AND (GUID_Type_Right = @GUID_Type_Right) AND (GUID_RelationType = @GUID_RelationType);

		IF @bitMin_forw = 0 AND @bitMax_forw = 0 AND @bitMax_backw = 1

			UPDATE semtbl_Type_type SET Max_backw=@intMax_backw

				WHERE     (GUID_Type_Left = @GUID_Type_Left) AND (GUID_Type_Right = @GUID_Type_Right) AND (GUID_RelationType = @GUID_RelationType);

		

		If @bitChange=1

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

		ELSE

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

	END

	ELSE

	BEGIN

		INSERT INTO semtbl_Type_Type VALUES (@GUID_Type_Left,@GUID_Type_Right,@GUID_RelationType,@intMin_forw,@intMax_forw,@intMax_backw);

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

	END

	CLOSE cur_Type_Rel;

	DEALLOCATE cur_Type_Rel;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_OR_TypeAttribute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_OR_TypeAttribute]

(

	-- Add the parameters for the function here

	@GUID_ObjectReference	uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxObjectReference int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxObjectReference = (SELECT TOP 1    [Version] AS MaxVersion

		FROM         chngtbll_OR_TypeAttribute

		WHERE     (GUID_DB = @GUID_DB) AND (GUID_ObjectReference = @GUID_ObjectReference)

		ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxObjectReference



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_TokenAttribute_Bit]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_TokenAttribute_Bit]

	-- Add the parameters for the stored procedure here

	@GUID_Token		uniqueidentifier,

	@GUID_Attribute uniqueidentifier,

	@GUID_TokenAttribute uniqueidentifier,

	@val_Bit				bit,

	@intOrderID				int

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Token_DB			uniqueidentifier;

	DECLARE @GUID_Attribute_DB		uniqueidentifier;

	DECLARE @GUID_TokenAttribute_DB	uniqueidentifier;

	DECLARE @val_Bit_DB				bit;

	DECLARe @intOrderID_DB			int;



    -- Insert statements for procedure here

	If @GUID_TokenAttribute IS NULL

	BEGIN

		SET @GUID_Token_DB = (SELECT GUID_Token FROM semtbl_Token WHERE GUID_Token=@GUID_Token);

		SET @GUID_Attribute_DB = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE GUID_Attribute=@GUID_Attribute);

		

		If @GUID_Token IS NULL OR @GUID_Attribute IS NULL

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		ELSE

		BEGIN

			SET @GUID_TokenAttribute = newid()

			INSERT INTO semtbl_Token_Attribute VALUES (@GUID_TokenAttribute,@GUID_Token,@GUID_Attribute);

			INSERT INTO semtbl_Token_Attribute_Bit VALUES (@GUID_TokenAttribute,@val_Bit,@intOrderID);

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

	END

	ELSE

	BEGIN

		DECLARE cur_TokenAttribute_BIT CURSOR FOR 

			SELECT     semtbl_Token_Attribute.GUID_TokenAttribute, semtbl_Token_Attribute_Bit.val, semtbl_Token_Attribute_Bit.OrderID

				FROM         semtbl_Token_Attribute INNER JOIN

									  semtbl_Token_Attribute_Bit ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Bit.GUID_TokenAttribute

				WHERE     (semtbl_Token_Attribute.GUID_TokenAttribute = @GUID_TokenAttribute)

		OPEN cur_TokenAttribute_BIT;

		FETCH NEXT FROM cur_TokenAttribute_BIT INTO

			@GUID_TokenAttribute_DB,

			@val_Bit_DB,

			@intOrderID_DB;

		IF @@FETCH_STATUS=0

		BEGIN

			If NOT @val_Bit_DB=@val_Bit

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_Bit SET Val=@val_Bit, OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					UPDATE semtbl_Token_Attribute_Bit SET Val=@val_Bit WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

			END

			ELSE

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_Bit SET OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

				END

			END

		END

		ELSE

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		CLOSE cur_TokenAttribute_BIT;

		DEALLOCATE cur_TokenAttribute_BIT;

		

	END

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_Token]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_Token] 

	-- Add the parameters for the stored procedure here

	@GUID_Token		uniqueidentifier,

	@Name_Token		varchar(255),

	@GUID_Type		uniqueidentifier,

	@bitCreate		bit

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Token_DB		uniqueidentifier;

	DECLARE @Name_Token_DB		varchar(255);

	DECLARE @GUID_Type_DB		uniqueidentifier;

	DECLARE @intCount			int;



    -- Insert statements for procedure here

	DECLARE cur_Token CURSOR FOR

		SELECT     GUID_Token, Name_Token, GUID_Type

		FROM         semtbl_Token

		WHERE     (GUID_Token = @GUID_Token);



	OPEN cur_Token;

	

	

	FETCH NEXT FROM cur_Token INTO

		@GUID_Token_DB,

		@Name_Token_DB,

		@GUID_Type_DB;



	CLOSE cur_Token;

	DEALLOCATE cur_Token;

	IF @@FETCH_STATUS=0 

	BEGIN

		IF NOT @Name_Token_DB = @Name_Token

		BEGIN

			UPDATE semtbl_Token SET Name_Token=@Name_Token WHERE GUID_Token=@GUID_Token;

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

		END

		ELSE

		BEGIN

			IF NOT @GUID_Type=@GUID_Type_DB

			BEGIN

				UPDATE semtbl_Token SET GUID_Type=@GUID_Type WHERE GUID_Token=@GUID_Token

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

			END

			ELSE

			BEGIN

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

			END

			

		END

	END

	ELSE

	BEGIN

		SET @intCount = (SELECT     COUNT(*) AS Count_Token

			FROM         semtbl_Token

			WHERE     (Name_Token = @Name_Token));

		IF @bitCreate=0

		BEGIN

			IF @intCount=0

			BEGIN

				INSERT INTO semtbl_Token VALUES (@GUID_Token,@Name_Token,@GUID_Type);

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

			END

			ELSE

			BEGIN

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Exists'';

			END

		END

		ELSE

		BEGIN

			INSERT INTO semtbl_Token VALUES (@GUID_Token,@Name_Token,@GUID_Type);

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

		

		

		

	END

	

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenToken_LeftRight]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenToken_LeftRight]

(

	@strGUID_Token_Left uniqueidentifier,

	@strRelationTypeGUID uniqueidentifier,

	@strGUID_Type_Right uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE     (semtbl_Token_Left.GUID_Token = @strGUID_Token_Left) AND (semtbl_RelationType.GUID_RelationType = @strRelationTypeGUID) AND (semtbl_Type_Right.GUID_Type = @strGUID_Type_Right)

ORDER BY semtbl_Token_Right.Name_Token'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Date]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Token_Attribute_Date](
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
	[val] [datetime] NOT NULL,
	[OrderID] [int] NOT NULL CONSTRAINT [DF_semtbl_Token_Attribute_Date_OrderID]  DEFAULT ((0)),
 CONSTRAINT [PK_semtbl_Token_Attribute_Datetime1] PRIMARY KEY CLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Token_Attribute_Date]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_Attribute_Date_semtbl_Token_Attribute] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_Attribute] ([GUID_TokenAttribute]);
ALTER TABLE [dbo].[semtbl_Token_Attribute_Date] CHECK CONSTRAINT [FK_semtbl_Token_Attribute_Date_semtbl_Token_Attribute];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_Type_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_Type_Type]

(

	-- Add the parameters for the function here

	@GUID_Type_Left			uniqueidentifier,

	@GUID_Type_Right		uniqueidentifier,

	@GUID_RelationType		uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxTypeRel int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxTypeRel = (SELECT TOP 1 [Version] AS MaxVersion

FROM         chngtbll_Type_Rel

WHERE     (GUID_DB = @GUID_DB) AND (GUID_Type_left = @GUID_Type_Left) AND (GUID_Type_Right = @GUID_Type_Right) AND (GUID_RelationType = @GUID_RelationType)

ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxTypeRel



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_rel_CONCAT_GROUP]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION func_rel_CONCAT_GROUP

(

	-- Add the parameters for the function here

	 @GUID_Token				uniqueidentifier

	,@GUID_RelationType			uniqueidentifier

	,@GUID_Type					uniqueidentifier

	,@GUID_Direction			uniqueidentifier

)

RETURNS varchar(max)

AS

BEGIN

	-- Declare the return variable here

	DECLARE @Result		varchar(max)



	SET @Result = ''''

	-- Add the T-SQL statements to compute the return value here

	IF @GUID_Direction = dbo.func_GUIDToken_Direction_LeftRight()

	BEGIN

		SELECT @Result = CASE WHEN NOT @Result = '''' THEN @Result + '', '' ELSE @Result END + ISNULL(Name_Token,'''')

		FROM semtbl_Token_Token

		INNER JOIN semtbl_Token ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token.GUID_Token

		WHERE semtbl_Token_Token.GUID_Token_Left = @GUID_Token

		AND semtbl_Token_Token.GUID_RelationType = @GUID_RelationType

		AND semtbl_Token.GUID_Type = @GUID_Type

		ORDER BY orderid, Name_Token



	END

	ELSE

	BEGIN

		SELECT @Result = CASE WHEN NOT @Result = '''' THEN @Result + '', '' ELSE @Result END + ISNULL(Name_Token,'''')

		FROM semtbl_Token_Token

		INNER JOIN semtbl_Token ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token.GUID_Token

		WHERE semtbl_Token_Token.GUID_Token_Right = @GUID_Token 

		AND semtbl_Token_Token.GUID_RelationType = @GUID_RelationType

		AND semtbl_Token.GUID_Type = @GUID_Type

		ORDER BY orderid, Name_Token

	END



	-- Return the result of the function

	RETURN @Result



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TypeAttributeProc_MinMax_ByGUIDs]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.TypeAttributeProc_MinMax_ByGUIDs

(

	@GUID_Type uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Type, GUID_Attribute, Min, Max

FROM            semtbl_Type_Attribute

WHERE        (GUID_Type = @GUID_Type) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Del_Token]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Del_Token]

	-- Add the parameters for the stored procedure here

	@GUID_Token		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	

    -- Insert statements for procedure here

	DECLARE @GUID_Token_DB				uniqueidentifier;

	DECLARE @Name_Token_DB				varchar(255);

	DECLARE @GUID_Type_DB				uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Type_ObjectReference	uniqueidentifier;

	DECLARE @GUID_LogState				uniqueidentifier;

	DECLARE @GUID_LogState_Delete		uniqueidentifier;

	DECLARE @intCount					int;



	DECLARE cur_Token CURSOR FOR

		SELECT * FROM semtbl_Token WHERE

			GUID_Token=@GUID_Token;

	

	OPEN cur_Token;

	FETCH NEXT FROM cur_Token INTO

		@GUID_Token_DB,

		@Name_Token_DB,

		@GUID_Type_DB;

	CLOSE cur_Token;

	DEALLOCATE cur_Token;	

	

	IF @@FETCH_STATUS=0

	BEGIN

		

		SET @intCount = (SELECT     COUNT(*) AS Count_Token_LeftRight

			FROM         semtbl_Token_Token

			WHERE     (GUID_Token_Left = @GUID_Token));

		If @intCount=0

		BEGIN

			SET @intCount = (SELECT     COUNT(*) AS Count_Token_LeftRight

				FROM         semtbl_Token_Token

				WHERE     (GUID_Token_Right = @GUID_Token));

			If @intCount=0

			BEGIN

				SET @GUID_ObjectReference = (SELECT     GUID_ObjectReference

					FROM         semtbl_OR_Token

					WHERE	(GUID_Token=@GUID_Token));

				IF NOT @GUID_ObjectReference IS NULL

				BEGIN

					SET @intCount = (SELECT     COUNT(*) AS Count_Rel_RightLeft

						FROM         semtbl_Token_OR

						WHERE     (GUID_ObjectReference = @GUID_ObjectReference));

					-- weiter

					IF @intCount=0

					BEGIN

						DELETE FROM semtbl_OR_Token WHERE

							GUID_Token=@GUID_ObjectReference;

						DELETE FROM semtbl_Token WHERE

							GUID_Token=@GUID_Token;

						SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

					END

					ELSE

					BEGIN

						SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

					END

				

					

				END

				ELSE

				BEGIN

					DELETE FROM semtbl_Token WHERE GUID_Token=@GUID_Token;

					SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

				END

			END

			ELSE

			BEGIN

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

			END

		END

		ELSE

		BEGIN

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

		END



	END

	ELSE

	BEGIN

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

	END



	

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_OR_Token_By_GUIDToken]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_OR_Token_By_GUIDToken]

(

	@GUID_Token uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_ObjectReference, GUID_Token

FROM            semtbl_OR_Token

WHERE        (GUID_Token = @GUID_Token)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_TokenAttribute_Date]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_TokenAttribute_Date]

	-- Add the parameters for the stored procedure here

	@GUID_Token		uniqueidentifier,

	@GUID_Attribute uniqueidentifier,

	@GUID_TokenAttribute uniqueidentifier,

	@val_Date				datetime,

	@intOrderID				int

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Token_DB			uniqueidentifier;

	DECLARE @GUID_Attribute_DB		uniqueidentifier;

	DECLARE @GUID_TokenAttribute_DB	uniqueidentifier;

	DECLARE @val_Date_DB			datetime;

	DECLARe @intOrderID_DB			int;



    -- Insert statements for procedure here

	If @GUID_TokenAttribute IS NULL

	BEGIN

		SET @GUID_Token_DB = (SELECT GUID_Token FROM semtbl_Token WHERE GUID_Token=@GUID_Token);

		SET @GUID_Attribute_DB = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE GUID_Attribute=@GUID_Attribute);

		

		If @GUID_Token IS NULL OR @GUID_Attribute IS NULL

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		ELSE

		BEGIN

			SET @GUID_TokenAttribute = newid()

			INSERT INTO semtbl_Token_Attribute VALUES (@GUID_TokenAttribute,@GUID_Token,@GUID_Attribute);

			INSERT INTO semtbl_Token_Attribute_Date VALUES (@GUID_TokenAttribute,@val_Date,@intOrderID);

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

	END

	ELSE

	BEGIN

		DECLARE cur_TokenAttribute_DATE CURSOR FOR 

			SELECT     semtbl_Token_Attribute.GUID_TokenAttribute, semtbl_Token_Attribute_Date.val, semtbl_Token_Attribute_Date.OrderID

FROM         semtbl_Token_Attribute INNER JOIN

                      semtbl_Token_Attribute_Date ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Date.GUID_TokenAttribute

WHERE     (semtbl_Token_Attribute.GUID_TokenAttribute = @GUID_TokenAttribute)

		OPEN cur_TokenAttribute_DATE;

		FETCH NEXT FROM cur_TokenAttribute_DATE INTO

			@GUID_TokenAttribute_DB,

			@val_Date_DB,

			@intOrderID_DB;

		IF @@FETCH_STATUS=0

		BEGIN

			If NOT @val_Date_DB=@val_Date

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_Date SET Val=@val_Date, OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					UPDATE semtbl_Token_Attribute_Date SET Val=@val_Date WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

			END

			ELSE

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_Date SET OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

				END

			END

		END

		ELSE

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		CLOSE cur_TokenAttribute_DATE;

		DEALLOCATE cur_TokenAttribute_DATE;

		

	END

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenToken_LeftRight_By_GUIDType_Left_And_RelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenToken_LeftRight_By_GUIDType_Left_And_RelationType]

(

	@GUID_Type_Left uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE     (semtbl_Token_Left.GUID_Type = @GUID_Type_Left) AND (semtbl_RelationType.GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Bit]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Token_Attribute_Bit](
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
	[val] [bit] NOT NULL,
	[OrderID] [int] NOT NULL CONSTRAINT [DF_semtbl_Token_Attribute_Bit_OrderID]  DEFAULT ((0)),
 CONSTRAINT [PK_semtbl_Token_Attribute_Bit] PRIMARY KEY CLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Token_Attribute_Bit]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_Attribute_Bit_semtbl_Token_Attribute] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_Attribute] ([GUID_TokenAttribute]);
ALTER TABLE [dbo].[semtbl_Token_Attribute_Bit] CHECK CONSTRAINT [FK_semtbl_Token_Attribute_Bit_semtbl_Token_Attribute];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Real]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Token_Attribute_Real](
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
	[val] [real] NOT NULL,
	[OrderID] [int] NOT NULL CONSTRAINT [DF_semtbl_Token_Attribute_Real_OrderID]  DEFAULT ((0)),
 CONSTRAINT [PK_semtbl_Token_Attribute_Real] PRIMARY KEY CLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Token_Attribute_Real]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_Attribute_Real_semtbl_Token_Attribute] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_Attribute] ([GUID_TokenAttribute]);
ALTER TABLE [dbo].[semtbl_Token_Attribute_Real] CHECK CONSTRAINT [FK_semtbl_Token_Attribute_Real_semtbl_Token_Attribute];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_LogState_Update]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_LogState_Update] 

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     semfunc_LogStates_1.*

FROM         dbo.semfunc_LogStates() AS semfunc_LogStates_1

WHERE     (Name_Token = ''Update'')

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Attribute_With_Type_By_GUIDAttribute_LikeName]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'

-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[Attribute_With_Type_By_GUIDAttribute_LikeName]

	-- Add the parameters for the stored procedure here

	@Name_Attribute		varchar(255)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     Attribute_List_With_TypeName_1.*

		FROM         dbo.Attribute_List_With_TypeName() AS Attribute_List_With_TypeName_1

		WHERE     (Name_Attribute LIKE ''%'' + @Name_Attribute + ''%'')

		ORDER BY Name_Attribute

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Del_Type]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'

-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Del_Type] 

	-- Add the parameters for the stored procedure here

	@GUID_Type			uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Type_DB			uniqueidentifier;

	DECLARE @intCount				int;



    -- Insert statements for procedure here

    SET @intCount = (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type=@GUID_Type)

	

	IF @intCount=0

	BEGIN

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

	END

	ELSE

	BEGIN

		SET @intCount = (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=@GUID_Type)

		IF @intCount = 0

		BEGIN

			SET @intCount = (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=@GUID_Type OR GUID_Type_Right=@GUID_Type)

			IF @intCount = 0

			BEGIN

				SET @intCount = (SELECT COUNT(*) 

								FROM semtbl_OR_Type

								JOIN semtbl_Token_OR ON semtbl_OR_Type.GUID_ObjectReference = semtbl_Token_OR.GUID_ObjectReference

								WHERE semtbl_OR_Type.GUID_Type = @GUID_Type)

				IF @intCount = 0

				BEGIN

					DELETE FROM semtbl_Type WHERE GUID_Type=@GUID_Type

					SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete''

				END

				ELSE

				BEGIN

					SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

				END

			END

			ELSE

			BEGIN

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

			END

		END

		ELSE

		BEGIN

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

		END	

	END



	

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_OR_Token]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_OR_Token]

(

	-- Add the parameters for the function here

	@GUID_ObjectReference	uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxObjectReference int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxObjectReference = (SELECT   TOP 1  [Version] AS MaxVersion

		FROM         chngtbll_OR_Token

		WHERE     (GUID_DB = @GUID_DB) AND (GUID_ObjectReference = @GUID_ObjectReference)

		ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxObjectReference



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_LogState_Relation]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_LogState_Relation] 

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     semfunc_LogStates_1.*

FROM         dbo.semfunc_LogStates() AS semfunc_LogStates_1

WHERE     (Name_Token = ''Relation'')

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenFunc_TokenToken_By_GUIDRelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenFunc_TokenToken_By_GUIDRelationType]

(

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE        (semtbl_RelationType.GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenToken_LeftRight_NoLeft]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_TokenToken_LeftRight_NoLeft]

	-- Add the parameters for the stored procedure here

	@GUID_Type_Left				uniqueidentifier,

	@GUID_Type_Right			uniqueidentifier,

	@GUID_RelationType			uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	

	CREATE TABLE #tmptbl_Relation

	(

		GUID_Token_left		uniqueidentifier,

		GUID_Token_Right	uniqueidentifier,

		GUID_RelationType	uniqueidentifier,

		OrderID				int

	)



	CREATE TABLE #tmptbl_Token_Left

	(

		GUID_Token			uniqueidentifier,

		Name_Token			varchar(255),

		GUID_Type			uniqueidentifier

	)



	CREATE TABLE #tmptbl_Token_Right

	(

		GUID_Token			uniqueidentifier,

		Name_Token			varchar(255),

		GUID_Type			uniqueidentifier

	)



    -- Insert statements for procedure here

	INSERT INTO #tmptbl_Relation

		SELECT        semtbl_Token_Token.GUID_Token_Left, semtbl_Token_Token.GUID_Token_Right, semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID

		FROM            semtbl_Token_Token INNER JOIN

		                         semtbl_Token ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token.GUID_Token INNER JOIN

		                         semtbl_Token AS semtbl_Token_1 ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_1.GUID_Token

		WHERE        (semtbl_Token_Token.GUID_RelationType = @GUID_RelationType) AND (semtbl_Token.GUID_Type = @GUID_Type_Left) AND 

		                         (semtbl_Token_1.GUID_Type = @GUID_Type_Right)



	

	INSERT INTO #tmptbl_Token_Left

		SELECT     GUID_Token, Name_Token, GUID_Type

			FROM         semtbl_Token

			WHERE     (GUID_Type = @GUID_Type_Left);



	INSERT INTO #tmptbl_Token_Right

		SELECT     GUID_Token, Name_Token, GUID_Type

			FROM         semtbl_Token

			WHERE     (GUID_Type = @GUID_Type_Right);



	

	

		SELECT     #tmptbl_Token_Right.GUID_Token, #tmptbl_Token_Right.Name_Token, #tmptbl_Token_Right.GUID_Type

			FROM         #tmptbl_Token_Right LEFT OUTER JOIN

								  #tmptbl_Relation ON #tmptbl_Token_Right.GUID_Token = #tmptbl_Relation.GUID_Token_Right

			WHERE     (#tmptbl_Relation.GUID_Token_Right IS NULL);

	



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_TokenAttribute_Real]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_TokenAttribute_Real]

	-- Add the parameters for the stored procedure here

	@GUID_Token		uniqueidentifier,

	@GUID_Attribute uniqueidentifier,

	@GUID_TokenAttribute uniqueidentifier,

	@val_Real				real,

	@intOrderID				int

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Token_DB			uniqueidentifier;

	DECLARE @GUID_Attribute_DB		uniqueidentifier;

	DECLARE @GUID_TokenAttribute_DB	uniqueidentifier;

	DECLARE @val_Real_DB			real;

	DECLARe @intOrderID_DB			int;



    -- Insert statements for procedure here

	If @GUID_TokenAttribute IS NULL

	BEGIN

		SET @GUID_Token_DB = (SELECT GUID_Token FROM semtbl_Token WHERE GUID_Token=@GUID_Token);

		SET @GUID_Attribute_DB = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE GUID_Attribute=@GUID_Attribute);

		

		If @GUID_Token IS NULL OR @GUID_Attribute IS NULL

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		ELSE

		BEGIN

			SET @GUID_TokenAttribute = newid()

			INSERT INTO semtbl_Token_Attribute VALUES (@GUID_TokenAttribute,@GUID_Token,@GUID_Attribute);

			INSERT INTO semtbl_Token_Attribute_Real VALUES (@GUID_TokenAttribute,@val_Real,@intOrderID);

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

	END

	ELSE

	BEGIN

		DECLARE cur_TokenAttribute_REAL CURSOR FOR 

			SELECT     semtbl_Token_Attribute.GUID_TokenAttribute, semtbl_Token_Attribute_Real.val, semtbl_Token_Attribute_Real.OrderID

FROM         semtbl_Token_Attribute INNER JOIN

                      semtbl_Token_Attribute_Real ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Real.GUID_TokenAttribute

WHERE     (semtbl_Token_Attribute.GUID_TokenAttribute = @GUID_TokenAttribute)

		OPEN cur_TokenAttribute_REAL;

		FETCH NEXT FROM cur_TokenAttribute_REAL INTO

			@GUID_TokenAttribute_DB,

			@val_Real_DB,

			@intOrderID_DB;

		IF @@FETCH_STATUS=0

		BEGIN

			If NOT @val_Real_DB=@val_Real

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_Real SET Val=@val_Real, OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					UPDATE semtbl_Token_Attribute_Real SET Val=@val_Real WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

			END

			ELSE

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_Real SET OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

				END

			END

		END

		ELSE

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		CLOSE cur_TokenAttribute_REAL;

		DEALLOCATE cur_TokenAttribute_REAL;

		

	END

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_OR_Attribute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_OR_Attribute]

(

	-- Add the parameters for the function here

	@GUID_ObjectReference	uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxObjectReference int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxObjectReference = (SELECT  TOP 1   [Version] AS Expr1

		FROM         chngtbll_OR_Attribute

		WHERE     (GUID_DB = @GUID_DB) AND (GUID_ObjectReference = @GUID_ObjectReference)

		ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxObjectReference



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenToken_By_GUIDs]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenToken_By_GUIDs]

(

	@GUID_Type_Left uniqueidentifier,

	@GUID_Type_Right uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE     (semtbl_Type_Left.GUID_Type = @GUID_Type_Left) AND (semtbl_Type_Right.GUID_Type = @GUID_Type_Right) AND (semtbl_RelationType.GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_Type]

(

	-- Add the parameters for the function here

	@GUID_Type			uniqueidentifier,

	@GUID_DB			uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxType int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxType = (SELECT  TOP 1 [Version] AS MaxVersion

FROM         chngtbll_Type

WHERE     (GUID_Type = @GUID_Type) AND (GUID_DB = @GUID_DB)

ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Del_TokenAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Del_TokenAttribute]

	-- Add the parameters for the stored procedure here

	@GUID_TokenAttribute uniqueidentifier

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_AttributeType				uniqueidentifier;

	DECLARE @GUID_AttributeType_Bool		uniqueidentifier;

	DECLARE @GUID_AttributeType_Date		uniqueidentifier;

	DECLARe @GUID_AttributeType_Datetime	uniqueidentifier;

	DECLARE @GUID_AttributeType_Int			uniqueidentifier;

	DECLARE @GUID_AttributeType_Real		uniqueidentifier;

	DECLARE @GUID_AttributeType_String		uniqueidentifier;

	DECLARE @GUID_AttributeType_Time		uniqueidentifier;

	DECLARE @GUID_AttributeType_VARCHAR255	uniqueidentifier;



    -- Insert statements for procedure here

	SET @GUID_AttributeType_Bool = (SELECT        GUID_AttributeType

		FROM            semtbl_AttributeType

		WHERE        (Name_AttributeType = ''BOOL''));



	SET @GUID_AttributeType_Date = (SELECT        GUID_AttributeType

		FROM            semtbl_AttributeType

		WHERE        (Name_AttributeType = ''Date''));



	SET @GUID_AttributeType_Datetime = (SELECT        GUID_AttributeType

		FROM            semtbl_AttributeType

		WHERE        (Name_AttributeType = ''Datetime''));



	SET @GUID_AttributeType_Int = (SELECT        GUID_AttributeType

		FROM            semtbl_AttributeType

		WHERE        (Name_AttributeType = ''INT''));



	SET @GUID_AttributeType_Real = (SELECT        GUID_AttributeType

		FROM            semtbl_AttributeType

		WHERE        (Name_AttributeType = ''Real''));



	SET @GUID_AttributeType_String = (SELECT        GUID_AttributeType

		FROM            semtbl_AttributeType

		WHERE        (Name_AttributeType = ''String''));



	SET @GUID_AttributeType_Time = (SELECT        GUID_AttributeType

		FROM            semtbl_AttributeType

		WHERE        (Name_AttributeType = ''Time''));



	SET @GUID_AttributeType_String = (SELECT        GUID_AttributeType

		FROM            semtbl_AttributeType

		WHERE        (Name_AttributeType = ''String''));



	SET @GUID_AttributeType_VARCHAR255 = (SELECT        GUID_AttributeType

		FROM            semtbl_AttributeType

		WHERE        (Name_AttributeType = ''VARCHAR255''));



	SET @GUID_AttributeType = 	(SELECT     semtbl_AttributeType.GUID_AttributeType

		FROM         semtbl_Token_Attribute INNER JOIN

							  semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN

							  semtbl_AttributeType ON semtbl_Attribute.GUID_AttributeType = semtbl_AttributeType.GUID_AttributeType

		WHERE     (semtbl_Token_Attribute.GUID_TokenAttribute = @GUID_TokenAttribute));

	

	If @GUID_AttributeType= @GUID_AttributeType_Bool	

	BEGIN

		DELETE FROM semtbl_Token_Attribute_Bit WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

	END

	ELSE

	BEGIN

		If @GUID_AttributeType= @GUID_AttributeType_Date

		BEGIN

			DELETE FROM semtbl_Token_Attribute_Date WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

		END

		ELSE

		BEGIN

			If @GUID_AttributeType= @GUID_AttributeType_Datetime

			BEGIN

				DELETE FROM semtbl_Token_Attribute_Datetime WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

			END

			ELSE

			BEGIN

				If @GUID_AttributeType= @GUID_AttributeType_Int

				BEGIN

					DELETE FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

				END

				ELSE

				BEGIN

					If @GUID_AttributeType= @GUID_AttributeType_Real

					BEGIN

						DELETE FROM semtbl_Token_Attribute_Real WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

						SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

					END

					ELSE

					BEGIN

						If @GUID_AttributeType= @GUID_AttributeType_String

						BEGIN

							DELETE FROM semtbl_Token_Attribute_VarcharMAX WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

							SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

						END

						ELSE

						BEGIN

							If @GUID_AttributeType= @GUID_AttributeType_Time

							BEGIN

								DELETE FROM semtbl_Token_Attribute_Time WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

								SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

							END

							ELSE

							BEGIN

								If @GUID_AttributeType= @GUID_AttributeType_VARCHAR255

								BEGIN

									DELETE FROM semtbl_Token_Attribute_Varchar255 WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

									SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

								END

								ELSE

								BEGIN

									SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

								END

							END

							

						END

						

					END

				END

			END

		END

	END

		



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_ModuleActivator_With_RelatedObjectReferences]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE FUNCTION [dbo].[func_ModuleActivator_With_RelatedObjectReferences]

(	

	-- Add the parameters for the function here

	@GUID_Type_ModuleActivator		uniqueidentifier,

	@GUID_RelationType_offersFor	uniqueidentifier	

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     semtbl_Token.GUID_Token AS GUID_ModuleActivator, semtbl_Token.Name_Token AS Name_ModuleActivator, 

                      semtbl_Token.GUID_Type AS GUID_Type_ModuleActivator, semfunc_ObjectReference_1.Name_Token, semfunc_ObjectReference_1.GUID_Ref, 

                      semfunc_ObjectReference_1.GUID_ItemType

FROM         semtbl_Token INNER JOIN

                      semtbl_Token_OR ON semtbl_Token.GUID_Token = semtbl_Token_OR.GUID_Token_Left INNER JOIN

                      dbo.semfunc_ObjectReference() AS semfunc_ObjectReference_1 ON 

                      semtbl_Token_OR.GUID_ObjectReference = semfunc_ObjectReference_1.GUID_ObjectReference

WHERE     (semtbl_Token.GUID_Type = @GUID_Type_ModuleActivator) AND (semtbl_Token_OR.GUID_RelationType = @GUID_RelationType_offersFor)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_OR_TypeType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_OR_TypeType]

(

	-- Add the parameters for the function here

	@GUID_ObjectReference	uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxObjectReference int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxObjectReference = (SELECT  TOP 1   [Version] AS MaxVersion

		FROM         chngtbll_OR_TypeType

		WHERE     (GUID_DB = @GUID_DB) AND (GUID_ObjectReference = @GUID_ObjectReference)

		ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxObjectReference



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_TokenToken]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE FUNCTION [dbo].[func_TokenToken]

(	

	-- Add the parameters for the function here

	

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     semtbl_Token.GUID_Token AS GUID_Token_Left, semtbl_Token.Name_Token AS Name_Token_Left, semtbl_Token.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_1.GUID_Token AS GUID_Token_Right, semtbl_Token_1.Name_Token AS Name_Token_Right, semtbl_Token_1.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type.Name_Type AS Name_Type_Left, 

                      semtbl_Type_1.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_1 ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_1.GUID_Token INNER JOIN

                      semtbl_Type ON semtbl_Token.GUID_Type = semtbl_Type.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_1 ON semtbl_Token_1.GUID_Type = semtbl_Type_1.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_TokenToken_OR]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[func_TokenToken_OR]
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token.GUID_Token AS GUID_Token_Right, semtbl_Token.Name_Token AS Name_Token_Right, semtbl_Token.GUID_Type AS GUID_Type_Right, 
                      semtbl_Token_1.GUID_Token AS GUID_Token_Left, semtbl_Token_1.Name_Token AS Name_Token_Left, semtbl_Token_1.GUID_Type AS GUID_Type_Left
FROM         dbo.semfunc_ObjectReference() AS semfunc_ObjectReference_1 INNER JOIN
                      semtbl_Token_OR ON semfunc_ObjectReference_1.GUID_ObjectReference = semtbl_Token_OR.GUID_ObjectReference INNER JOIN
                      semtbl_Token ON semfunc_ObjectReference_1.GUID_Ref = semtbl_Token.GUID_Token INNER JOIN
                      semtbl_Token AS semtbl_Token_1 ON semtbl_Token_OR.GUID_Token_Left = semtbl_Token_1.GUID_Token
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenToken_RightLeft_Ordered_By_GUIDs]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_TokenToken_RightLeft_Ordered_By_GUIDs] 

	-- Add the parameters for the stored procedure here

	@GUID_Token_Right	uniqueidentifier,

	@GUID_Type_Left		uniqueidentifier,

	@GUID_RelationType	uniqueidentifier,

	@bitASC				bit

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	IF @bitASC=1

	BEGIN

		SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE     (semtbl_RelationType.GUID_RelationType = @GUID_RelationType) AND (semtbl_Type_Left.GUID_Type = @GUID_Type_Left) AND (semtbl_Token_Token.GUID_Token_Right = @GUID_Token_Right)

		ORDER BY OrderID;

	END

	ELSE

	BEGIN

		SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE     (semtbl_RelationType.GUID_RelationType = @GUID_RelationType) AND (semtbl_Type_Left.GUID_Type = @GUID_Type_Left) AND (semtbl_Token_Token.GUID_Token_Right = @GUID_Token_Right)

		ORDER BY OrderID DESC;

	END

	

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_OR_Type_By_GUIDType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_OR_Type_By_GUIDType]

(

	@GUID_Type uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_ObjectReference, GUID_Type

FROM            semtbl_OR_Type

WHERE        (GUID_Type = @GUID_Type)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Del_Type_Rel]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Del_Type_Rel] 

	-- Add the parameters for the stored procedure here

	@GUID_Type_Left			uniqueidentifier,

	@GUID_Type_Right		uniqueidentifier,

	@GUID_RelationType		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	DECLARE @intCount		int;



	SET @intCount = (SELECT COUNT(*) FROM semtbl_Type_Type WHERE

							GUID_Type_Left		= @GUID_Type_Left

						AND GUID_Type_Right		= @GUID_Type_Right

						AND GUID_RelationType	= @GUID_RelationType);



	If @intCount=1

	BEGIN

		DELETE FROM semtbl_Type_Type WHERE

				GUID_Type_Left		= @GUID_Type_Left

			AND GUID_Type_Right		= @GUID_Type_Right

			AND GUID_RelationType	= @GUID_RelationType;

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

	END

	ELSE

	BEGIN

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

	END

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_DBWork_Save_OR_Attribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_DBWork_Save_OR_Attribute]

	-- Add the parameters for the stored procedure here

		@GUID_Ref			uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	

	DECLARE @GUID_ObjectReference	uniqueidentifier;

	DECLARE @Name_Token				varchar(255);

	DECLARE @GUID_ItemType			uniqueidentifier;

	DECLARE @intCount				int;



	-- Typ-Abhängig (Attribute

	SET @GUID_ItemType = dbo.func_GUID_ORType_Attribute()

	SET @intCount = (SELECT     COUNT(*) AS Count_Attributes

		FROM         semtbl_Attribute

		WHERE    (GUID_Attribute = @GUID_Ref));

	-- Typ-Abhängig (Attribute



	IF @intCount > 0

	BEGIN

		-- Typ-Abhängig (Attribute

		SET @GUID_ObjectReference = (SELECT     GUID_ObjectReference

			FROM         semtbl_OR_Attribute

			WHERE     (GUID_Attribute = @GUID_Ref));

		-- Typ-Abhängig (Attribute



		IF @GUID_ObjectReference is null

		BEGIN

			SET @GUID_ObjectReference=newid();

			INSERT INTO semtbl_OR VALUES (@GUID_ObjectReference,@GUID_ItemType);



			-- Typ-Abhängig (Attribute

			INSERT INTO semtbl_OR_Attribute VALUES(@GUID_ObjectReference,@GUID_Ref);

			-- Typ-Abhängig (Attribute



			SELECT *,@GUID_ObjectReference AS GUID_ObjectReference FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

		ELSE

		BEGIN

			SELECT *,@GUID_ObjectReference AS GUID_ObjectReference FROM dbo.semfunc_LogStates() WHERE Name_Token=''Exists'';

		END

		

	END

	ELSE

	BEGIN

		SELECT *,null AS GUID_ObjectReference FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

	END

	

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_Token_Attribute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_Token_Attribute]

(

	-- Add the parameters for the function here

	@GUID_TokenAttribute	uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxTokenAttribute int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxTokenAttribute = (SELECT TOP 1 [Version] AS MaxVersion

FROM         chngtbll_Token_Attribute

WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute) AND (GUID_DB = @GUID_DB)

ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxTokenAttribute



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_DBWork_Save_OR_Token]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_DBWork_Save_OR_Token]

	-- Add the parameters for the stored procedure here

		@GUID_Ref			uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	

	DECLARE @GUID_ObjectReference	uniqueidentifier;

	DECLARE @Name_Token				varchar(255);

	DECLARE @GUID_ItemType			uniqueidentifier;

	DECLARE @intCount				int;



	-- Typ-Abhängig (Token

	SET @GUID_ItemType = dbo.func_GUID_ORType_Token()

	SET @intCount = (SELECT     COUNT(*) AS Count_Token

		FROM         semtbl_Token

		WHERE    (GUID_Token = @GUID_Ref));

	-- Typ-Abhängig (Token



	IF @intCount > 0

	BEGIN

		-- Typ-Abhängig (Token

		SET @GUID_ObjectReference = (SELECT     GUID_ObjectReference

			FROM         semtbl_OR_Token

			WHERE     (GUID_Token = @GUID_Ref));

		-- Typ-Abhängig (Token



		IF @GUID_ObjectReference is null

		BEGIN

			SET @GUID_ObjectReference=newid();

			INSERT INTO semtbl_OR VALUES (@GUID_ObjectReference,@GUID_ItemType);



			-- Typ-Abhängig (Token

			INSERT INTO semtbl_OR_Token VALUES(@GUID_ObjectReference,@GUID_Ref);

			-- Typ-Abhängig (Token



			SELECT *,@GUID_ObjectReference AS GUID_ObjectReference FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

		ELSE

		BEGIN

			SELECT *,@GUID_ObjectReference AS GUID_ObjectReference FROM dbo.semfunc_LogStates() WHERE Name_Token=''Exists'';

		END

		

	END

	ELSE

	BEGIN

		SELECT *,null AS GUID_ObjectReference FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

	END

	

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_TokenAttribute_VarcharMax]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_TokenAttribute_VarcharMax]

	-- Add the parameters for the stored procedure here

	@GUID_Token		uniqueidentifier,

	@GUID_Attribute uniqueidentifier,

	@GUID_TokenAttribute uniqueidentifier,

	@val_Varchar255				varchar(Max),

	@intOrderID				int

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Token_DB			uniqueidentifier;

	DECLARE @GUID_Attribute_DB		uniqueidentifier;

	DECLARE @GUID_TokenAttribute_DB	uniqueidentifier;

	DECLARE @val_VarcharMax_DB			varchar(Max);

	DECLARe @intOrderID_DB			int;



    -- Insert statements for procedure here

	If @GUID_TokenAttribute IS NULL

	BEGIN

		SET @GUID_Token_DB = (SELECT GUID_Token FROM semtbl_Token WHERE GUID_Token=@GUID_Token);

		SET @GUID_Attribute_DB = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE GUID_Attribute=@GUID_Attribute);

		

		If @GUID_Token IS NULL OR @GUID_Attribute IS NULL

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		ELSE

		BEGIN

			SET @GUID_TokenAttribute = newid()

			INSERT INTO semtbl_Token_Attribute VALUES (@GUID_TokenAttribute,@GUID_Token,@GUID_Attribute);

			INSERT INTO semtbl_Token_Attribute_VarcharMax VALUES (@GUID_TokenAttribute,@val_Varchar255,@intOrderID);

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

	END

	ELSE

	BEGIN

		DECLARE cur_TokenAttribute_VARCHARMAX CURSOR FOR 

			SELECT     semtbl_Token_Attribute.GUID_TokenAttribute, semtbl_Token_Attribute_VarcharMax.val, semtbl_Token_Attribute_VarcharMax.OrderID

FROM         semtbl_Token_Attribute INNER JOIN

                      semtbl_Token_Attribute_VarcharMax ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_VarcharMax.GUID_TokenAttribute

WHERE     (semtbl_Token_Attribute.GUID_TokenAttribute = @GUID_TokenAttribute)

		OPEN cur_TokenAttribute_VARCHARMAX;

		FETCH NEXT FROM cur_TokenAttribute_VARCHARMAX INTO

			@GUID_TokenAttribute_DB,

			@val_VarcharMax_DB,

			@intOrderID_DB;

		IF @@FETCH_STATUS=0

		BEGIN

			If NOT @val_VarcharMax_DB=@val_Varchar255

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_VarcharMax SET Val=@val_Varchar255, OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					UPDATE semtbl_Token_Attribute_VarcharMax SET Val=@val_Varchar255 WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

			END

			ELSE

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_VarcharMax SET OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

				END

			END

		END

		ELSE

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		CLOSE cur_TokenAttribute_VARCHARMAX;

		DEALLOCATE cur_TokenAttribute_VARCHARMAX;

		

	END

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Token_OR_Count_Rels_By_GUIDs]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.proc_Token_OR_Count_Rels_By_GUIDs

(

	@GUID_Token_Left uniqueidentifier,

	@GUID_ObjectReference uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        COUNT(*) AS Count_items

FROM            semtbl_Token_OR

WHERE        (GUID_Token_Left = @GUID_Token_Left) AND (GUID_ObjectReference = @GUID_ObjectReference) AND (GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Del_Attribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Del_Attribute]

	-- Add the parameters for the stored procedure here

	@GUID_Attribute	uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	DECLARE @GUID_Token		uniqueidentifier;

	DECLARE @intCount		int;

	

	SET @intCount = (SELECT     COUNT(*) AS Count_Token

		FROM         semtbl_Token_Attribute

		WHERE     (GUID_Attribute = @GUID_Attribute));



	If @intCount > 0

	BEGIN

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

		

	END

	ELSE

	BEGIN

		SET @intCount = (SELECT     COUNT(*) AS Count_Types

			FROM         semtbl_Type_Attribute

			WHERE     (GUID_Attribute = @GUID_Attribute));

		If @intCount=0

		BEGIN

			DECLARE cur_ObjectReference CURSOR FOR

			SELECT     GUID_Token

				FROM         semtbl_Token

				WHERE     (GUID_Type = dbo.func_TypeGUID_ObjectReference()) AND (Name_Token = CAST(@GUID_Attribute AS varchar(255)));

			OPEN cur_ObjectReference;

			FETCH NEXT FROM cur_ObjectReference INTO

				@GUID_Token;

			CLOSE cur_ObjectReference;

			DEALLOCATE cur_ObjectReference;

			If @@FETCH_STATUS=0

			BEGIN

				SET @intCount = (SELECT     COUNT(*) AS Count_Relations

					FROM         semtbl_Token_Token

					GROUP BY GUID_Token_Right

					HAVING      (GUID_Token_Right = @GUID_Token));

				If @intCount=0

				BEGIN

					

					DELETE FROM semtbl_Token WHERE GUID_Token=@GUID_Token;

					DELETE FROM semtbl_Attribute WHERE GUID_Attribute=@GUID_Attribute;

					SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

				END

				ELSE

				BEGIN

					SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

				END

			END

			ELSE

			BEGIN

				DELETE FROM semtbl_Attribute WHERE GUID_Attribute=@GUID_Attribute;

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

			END

		END

		ELSE

		BEGIN

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

		END



		

		

	END

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Token_Path_By_GUID]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_Token_Path_By_GUID 

	-- Add the parameters for the stored procedure here

	@GUID_Token		uniqueidentifier,

	@Name_Token		varchar(255),

	@GUID_Type		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	DECLARE @strPath_Token		varchar(255);



	DECLARE @GUID_Type_DB		uniqueidentifier;

	DECLARE @Name_Type_DB		varchar(255);

	DECLARE @GUID_Type_Parent	uniqueidentifier;



	-- Add the T-SQL statements to compute the return value here

--		SET @strPath_Token = (SELECT     Path_Token

--			FROM         dbo.semfunc_Token_Path() AS semfunc_Token_Path_1

	

	SET @strPath_Token = @Name_Token;



	DECLARE cur_Type CURSOR FOR

		SELECT * FROM semtbl_Type WHERE GUID_Type=@GUID_Type;

	OPEN cur_Type;

	FETCH NEXT FROM cur_Type INTO

		@GUID_Type_DB,

		@Name_Type_DB,

		@GUID_Type_Parent;

	CLOSE cur_Type;

	DEALLOCATE cur_Type;

	SET @strPath_Token=@strPath_Token + ''\'' + @Name_Type_DB;

	WHILE @GUID_Type_Parent IS NOT NULL

	BEGIN

		

		DECLARE cur_Type CURSOR FOR

			SELECT * FROM semtbl_Type WHERE GUID_Type = @GUID_Type_Parent;

		OPEN cur_Type;

		FETCH NEXT FROM cur_Type INTO

			@GUID_Type_DB,

			@Name_Type_DB,

			@GUID_Type_Parent;

		CLOSE cur_Type;

		DEALLOCATE cur_Type;

		SET @strPath_Token=@strPath_Token + ''\'' + @Name_Type_DB;

	END

	

	-- Return the result of the function

	SELECT @strPath_Token AS Path_Token

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[typeproc_Type_Rel_By_GUIDs]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.typeproc_Type_Rel_By_GUIDs

(

	@GUID_Type_Left uniqueidentifier,

	@GUID_Type_Right uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Type_Left, Name_Type_Left, GUID_Type_Parent_Left, GUID_RelationType, Name_RelationType, GUID_Type_Right, Name_Type_Right, 

                         GUID_Type_Parent_Right, Min_forw, Max_forw, Max_backw

FROM            dbo.typefunc_Types_Rel() AS typefunc_Types_Rel_1

WHERE        (GUID_Type_Left = @GUID_Type_Left) AND (GUID_Type_Right = @GUID_Type_Right) AND (GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_SoftwareDevelopment_Config]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[func_SoftwareDevelopment_Config]
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token.GUID_Token AS GUID_Token_Development, semtbl_Token.Name_Token AS Name_Token_Development, 
                      semtbl_Token.GUID_Type AS GUID_Type_Development, semtbl_Token_1.GUID_Token AS GUID_Token_DevelopmentConfig, 
                      semtbl_Token_1.Name_Token AS Name_Token_DevelopmentConfig, semtbl_Token_1.GUID_Type AS GUID_Type_DevelopmentConfig, 
                      semtbl_Token_2.GUID_Token AS GUID_Token_ConfigItem, semtbl_Token_2.Name_Token AS Name_Token_ConfigItem, 
                      semtbl_Token_2.GUID_Type AS GUID_Type_ConfigItem, semtbl_OR.GUID_ORType, semtbl_OR.GUID_ObjectReference
FROM         semtbl_Token INNER JOIN
                      semtbl_Token_Token ON semtbl_Token.GUID_Token = semtbl_Token_Token.GUID_Token_Left INNER JOIN
                      semtbl_Token AS semtbl_Token_1 ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_1.GUID_Token INNER JOIN
                      semtbl_Token_Token AS semtbl_Token_Token_1 ON semtbl_Token_1.GUID_Token = semtbl_Token_Token_1.GUID_Token_Left INNER JOIN
                      semtbl_Token AS semtbl_Token_2 ON semtbl_Token_Token_1.GUID_Token_Right = semtbl_Token_2.GUID_Token INNER JOIN
                      semtbl_Token_OR ON semtbl_Token_2.GUID_Token = semtbl_Token_OR.GUID_Token_Left INNER JOIN
                      semtbl_OR ON semtbl_Token_OR.GUID_ObjectReference = semtbl_OR.GUID_ObjectReference
WHERE     (semtbl_Token.GUID_Type = dbo.func_TypeGUID_SoftwareDevelopment()) AND (semtbl_Token_Token.GUID_RelationType = dbo.func_RelationTypeGUID_needs()) AND
                       (semtbl_Token_1.GUID_Type = dbo.func_TypeGUID_DevelopmentConfig()) AND (semtbl_Token_Token_1.GUID_RelationType = dbo.func_RelationTypeGUID_contains())
                       AND (semtbl_Token_2.GUID_Type = dbo.func_TypeGUID_DevelopmentConfigItem())
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_Type]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_Type] 

	-- Add the parameters for the stored procedure here

	@GUID_Type			uniqueidentifier,

	@Name_Type			varchar(255),

	@GUID_Type_Parent	uniqueidentifier =null

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Type_DB			uniqueidentifier;

	DECLARE @Name_Type_DB			varchar(255);

	DECLARE @GUID_Type_Parent_DB	uniqueidentifier;

	DECLARE @intCount				int;

	DECLARE @bitChange				bit;



    -- Insert statements for procedure here

	DECLARE cur_Type CURSOR FOR

		SELECT     GUID_Type, Name_Type, GUID_Type_Parent

			FROM         semtbl_Type

			WHERE		(GUID_Type = @GUID_Type);



	OPEN cur_Type;

	FETCH NEXT FROM cur_Type INTO

		@GUID_Type_DB,

		@Name_Type_DB,

		@GUID_Type_Parent_DB;



	CLOSE cur_Type;

	DEALLOCATE cur_Type;

	SET @bitChange = 0;

	IF @@FETCH_STATUS=0 

	BEGIN

		IF NOT @Name_Type_DB=@Name_Type

		BEGIN

			UPDATE semtbl_Type SET Name_Type=@Name_Type WHERE GUID_Type=@GUID_Type;

			SET @bitChange=1;

		END

		IF NOT @GUID_Type_Parent_DB=@GUID_Type_Parent

		BEGIN

			UPDATE semtbl_Type SET GUID_Type_Parent=@GUID_Type_Parent WHERE GUID_Type=@GUID_Type;

			SET @bitChange=1;

		END

		

		If @bitChange=1

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

		ELSE

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

	END

	ELSE

	BEGIN

		IF @GUID_Type_Parent IS NULL

		BEGIN

			INSERT INTO semtbl_Type (GUID_Type,Name_Type) VALUES (@GUID_Type,@Name_Type);

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

		ELSE

		BEGIN

			SET @intCount = (SELECT     COUNT(*) AS Count_Types

				FROM         semtbl_Type

				WHERE     (Name_Type = @Name_Type));

			IF @intCount = 0

			BEGIN

				INSERT INTO semtbl_Type (GUID_Type,Name_Type,GUID_Type_Parent) VALUES (@GUID_Type,@Name_Type,@GUID_Type_Parent);

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

			END

			ELSE

			BEGIN

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Exists'';

			END

		END

		

	END

	

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Token_By_Rel]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'

-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Token_By_Rel]

	-- Add the parameters for the stored procedure here

	 @Direction					int

	,@Null_Other                bit

    ,@GUID_Token_Left			uniqueidentifier = null

    ,@Name_Token_Left			varchar(255) = null

    ,@GUID_Type_Left			uniqueidentifier = null

    ,@GUID_Token_Right          uniqueidentifier = null

    ,@Name_Token_Right          varchar(255) = null

    ,@GUID_Type_Right			uniqueidentifier = null

    ,@GUID_RelationType         uniqueidentifier = null



AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	DECLARE @SQL_Token           varchar(400)

      DECLARE @SQL_Rel_Left   varchar(800)

      DECLARE @SQL_Rel_Right  varchar(800)

      DECLARE @WHERE_Left          varchar(500)

      DECLARE @WHERE_Right    varchar(500)

      DECLARE @SQL                 varchar(4000)



      SET @SQL_Token = ''SELECT  GUID_Token

                                         ,Name_Token

                                         ,GUID_Type

                                   FROM semtbl_Token''

      SET @SQL_Rel_Left =     ''

      SELECT   semtbl_Token_Token.GUID_Token_Right

                  ,semtbl_Token_Token.GUID_RelationType

                  ,semtbl_Token.GUID_Token

                  ,semtbl_Token.Name_Token

            ,semtbl_Token.GUID_Type

            FROM         semtbl_Token 

            INNER JOIN semtbl_Token_Token ON semtbl_Token.GUID_Token = semtbl_Token_Token.GUID_Token_Left

      ''

      

      SET @SQL_Rel_Right =    ''

      SELECT   semtbl_Token_Token.GUID_Token_Left

                  ,semtbl_Token_Token.GUID_RelationType

                  ,semtbl_Token.GUID_Token

            ,semtbl_Token.Name_Token

                  ,semtbl_Token.GUID_Type

            FROM         semtbl_Token 

            INNER JOIN semtbl_Token_Token ON semtbl_Token.GUID_Token = semtbl_Token_Token.GUID_Token_Right

      ''

      

      SET @WHERE_Left = ''''

      SET @WHERE_Right = ''''



      IF @GUID_Token_Left IS NOT NULL AND NOT @GUID_Token_Left = ''00000000-0000-0000-0000-000000000000''

      BEGIN

            IF NOT @WHERE_Left=''''

                  SET @WHERE_Left = @WHERE_Left + '' AND ''

            

            SET @WHERE_Left = @WHERE_Left + ''GUID_Token = '''''' + CAST(@GUID_Token_Left AS VARCHAR(36)) + ''''''''

      END



      IF @Name_Token_Left IS NOT NULL

      BEGIN

            IF NOT @WHERE_Left=''''

                  SET @WHERE_Left = @WHERE_Left + '' AND ''

            

            SET @WHERE_Left = @WHERE_Left + ''Name_Token Like ''''%'' + @Name_Token_Left + ''%''''''



      END



      IF @GUID_Type_Left IS NOT NULL AND NOT @GUID_Type_Left = ''00000000-0000-0000-0000-000000000000''

      BEGIN

            IF NOT @WHERE_Left=''''

                  SET @WHERE_Left = @WHERE_Left + '' AND ''

            

            SET @WHERE_Left = @WHERE_Left + ''GUID_Type = '''''' + CAST(@GUID_Type_Left AS VARCHAR(36)) + ''''''''



      END



      IF @GUID_Token_Right IS NOT NULL AND NOT @GUID_Token_Right = ''00000000-0000-0000-0000-000000000000''

      BEGIN

            IF NOT @WHERE_Right=''''

                  SET @WHERE_Right = @WHERE_Right + '' AND ''

            

            SET @WHERE_Right = @WHERE_Right + ''GUID_Token = '''''' + CAST(@GUID_Token_Right AS VARCHAR(36)) + ''''''''



      END



      IF @Name_Token_Right IS NOT NULL 

      BEGIN

            IF NOT @WHERE_Right=''''

                  SET @WHERE_Right = @WHERE_Right + '' AND ''

            

            SET @WHERE_Right = @WHERE_Right + ''Name_Token Like ''''%'' + @Name_Token_Right + ''%''''''



      END



      



      IF @GUID_Type_Right IS NOT NULL AND NOT @GUID_Type_Right = ''00000000-0000-0000-0000-000000000000''

      BEGIN

            IF NOT @WHERE_Right=''''

                  SET @WHERE_Right = @WHERE_Right + '' AND ''

            

            SET @WHERE_Right = @WHERE_Right + ''GUID_Type = '''''' + CAST(@GUID_Type_Right AS VARCHAR(36)) + ''''''''



      END



	  IF @Direction=1

      BEGIN

            IF NOT @WHERE_Left = ''''

                  SET @SQL_Token = @SQL_Token + '' WHERE '' + @WHERE_Left



      END

      ELSE

      BEGIN

            IF NOT @WHERE_Right = ''''

                  SET @SQL_Token = @SQL_Token + '' WHERE '' + @WHERE_Right

      END	

      

      IF @GUID_RelationType IS NOT NULL AND NOT @GUID_RelationType = ''00000000-0000-0000-0000-000000000000''

      BEGIN



            IF NOT @WHERE_Left=''''

                  SET @WHERE_Left = @WHERE_Left + '' AND ''

            

            SET @WHERE_Left = @WHERE_Left + ''GUID_RelationType = '''''' + CAST(@GUID_RelationType AS VARCHAR(36)) + ''''''''



            IF NOT @WHERE_Right=''''

                  SET @WHERE_Right = @WHERE_Right + '' AND ''

            

            SET @WHERE_Right = @WHERE_Right + ''GUID_RelationType = '''''' + CAST(@GUID_RelationType AS VARCHAR(36)) + ''''''''

      END



      IF NOT @WHERE_Left = ''''

      BEGIN

            SET @SQL_Rel_Left = @SQL_Rel_Left + '' WHERE '' + @WHERE_Left

      END



      IF NOT @WHERE_Right = ''''

      BEGIN

            SET @SQL_Rel_Right = @SQL_Rel_Right + '' WHERE '' + @WHERE_Right

      END

      

      IF @Direction = 1

      BEGIN

            SET @SQL = ''SELECT DISTINCT  Token_Left.GUID_Token

                                         ,Token_Left.Name_Token

                                         ,Token_Left.GUID_Type FROM ''

            SET @SQL = @SQL + ''('' + @SQL_Token + '') AS Token_Left ''

            IF @Null_Other=1

                  SET @SQL = @SQL + ''LEFT OUTER ''

            SET @SQL = @SQL + ''JOIN ('' + @SQL_Rel_Right + '') AS Token_Right ON Token_Left.GUID_Token = Token_Right.GUID_Token_Left ''

            IF @Null_Other=1

                  SET @SQL = @SQL + ''WHERE Token_Right.GUID_Token IS NULL''

      END

      ELSE

      BEGIN

            SET @SQL = ''SELECT  DISTINCT Token_Right.GUID_Token

                                         ,Token_Right.Name_Token

                                         ,Token_Right.GUID_Type FROM ''

            SET @SQL = @SQL + ''('' + @SQL_Token + '') AS Token_Right ''

            IF @Null_Other=1

                  SET @SQL = @SQL + ''LEFT OUTER ''

            SET @SQL = @SQL + ''JOIN ('' + @SQL_Rel_Left + '') AS Token_Left ON Token_Left.GUID_Token_Right = Token_Right.GUID_Token ''

            IF @Null_Other=1

                  SET @SQL = @SQL + ''WHERE Token_Left.GUID_Token IS NULL''

      END

		PRINT @SQL

      exec(@SQL)  



END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_OR_RelationType_By_GUIDRelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_OR_RelationType_By_GUIDRelationType]

(

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_ObjectReference, GUID_RelationType

FROM            semtbl_OR_RelationType

WHERE        (GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Del_Type_OR]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Del_Type_OR] 

	-- Add the parameters for the stored procedure here

	@GUID_Type				uniqueidentifier,

	@GUID_RelationType		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	DECLARE @intCount		int;



	SET @intCount = (SELECT COUNT(*) FROM semtbl_Type_OR WHERE

							GUID_Type		= @GUID_Type

						AND GUID_RelationType	= @GUID_RelationType);



	If @intCount=1

	BEGIN

		DELETE FROM semtbl_Type_OR WHERE

				GUID_Type		=	@GUID_Type

			AND GUID_RelationType	= @GUID_RelationType;

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

	END

	ELSE

	BEGIN

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

	END

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_OR]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[func_Token_OR]
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token.GUID_Token AS GUID_Token_Left, semtbl_Token.Name_Token AS Name_Token_Left, semtbl_Type.Name_Type AS Name_Type_Left, 
                      semtbl_Token.GUID_Type AS GUID_Type_Left, semtbl_Token_OR.GUID_ObjectReference, semtbl_Token_OR.GUID_RelationType, 
                      semtbl_RelationType.Name_RelationType, semtbl_ORType.GUID_ObjectReferenceType, semtbl_ORType.Name_ObjectReferenceType, 
                      semfunc_ObjectReference_1.GUID_Ref, semfunc_ObjectReference_1.Name_Token AS Name_Ref, semtbl_Token_OR.OrderID, semfunc_ObjectReference_1.GUID_ItemType
FROM         semtbl_Token_OR INNER JOIN
                      semtbl_OR ON semtbl_Token_OR.GUID_ObjectReference = semtbl_OR.GUID_ObjectReference INNER JOIN
                      semtbl_ORType ON semtbl_OR.GUID_ORType = semtbl_ORType.GUID_ObjectReferenceType INNER JOIN
                      semtbl_Token ON semtbl_Token_OR.GUID_Token_Left = semtbl_Token.GUID_Token INNER JOIN
                      semtbl_Type ON semtbl_Token.GUID_Type = semtbl_Type.GUID_Type INNER JOIN
                      semtbl_RelationType ON semtbl_Token_OR.GUID_RelationType = semtbl_RelationType.GUID_RelationType INNER JOIN
                      dbo.semfunc_ObjectReference() AS semfunc_ObjectReference_1 ON semtbl_OR.GUID_ObjectReference = semfunc_ObjectReference_1.GUID_ObjectReference
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenToken_LeftRight_By_GUIDTypeLeft_GUIDRelationType_GUIDTypeRight]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenToken_LeftRight_By_GUIDTypeLeft_GUIDRelationType_GUIDTypeRight]

(

	@GUID_Type_Left uniqueidentifier,

	@GUID_Type_Right uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE        (semtbl_Type_Left.GUID_Type = @GUID_Type_Left) AND (semtbl_Type_Right.GUID_Type = @GUID_Type_Right) AND (semtbl_RelationType.GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Del_Type]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'

-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Del_Type] 

	-- Add the parameters for the stored procedure here

	@GUID_Type			uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Type_DB			uniqueidentifier;

	DECLARE @intCount				int;



    -- Insert statements for procedure here

    SET @intCount = (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type=@GUID_Type)

	

	IF @intCount=0

	BEGIN

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

	END

	ELSE

	BEGIN

		SET @intCount = (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=@GUID_Type)

		IF @intCount = 0

		BEGIN

			SET @intCount = (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=@GUID_Type OR GUID_Type_Right=@GUID_Type)

			IF @intCount = 0

			BEGIN

				SET @intCount = (SELECT COUNT(*) 

								FROM semtbl_OR_Type

								JOIN semtbl_Token_OR ON semtbl_OR_Type.GUID_ObjectReference = semtbl_Token_OR.GUID_ObjectReference

								WHERE semtbl_OR_Type.GUID_Type = @GUID_Type)

				IF @intCount = 0

				BEGIN

					DELETE FROM semtbl_Type WHERE GUID_Type=@GUID_Type

					SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete''

				END

				ELSE

				BEGIN

					SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

				END

			END

			ELSE

			BEGIN

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

			END

		END

		ELSE

		BEGIN

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

		END	

	END



	

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Del_TypeAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Del_TypeAttribute]

	-- Add the parameters for the stored procedure here

	@GUID_Type		uniqueidentifier,

	@GUID_Attribute	uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	DECLARE @intCount		int;

	

	SET @intCount = (SELECT     COUNT(*) AS Count_Rels

		FROM         semtbl_Type_Attribute

		WHERE     (GUID_Type = @GUID_Type) AND (GUID_Attribute = @GUID_Attribute));



	If @intCount > 0

	BEGIN

		DELETE FROM semtbl_Type_Attribute WHERE GUID_Type=@GUID_Type AND GUID_Attribute=@GUID_Attribute;

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

	END

	ELSE

	BEGIN

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

	END

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TypeAttribute_By_GUIDType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.proc_TypeAttribute_By_GUIDType

(

	@GUID_Type uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Type, GUID_Attribute, Min, Max

FROM            semtbl_Type_Attribute

WHERE        (GUID_Type = @GUID_Type)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_LogState_Success]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[semproc_LogState_Success] 

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     semfunc_LogStates_1.*

FROM         dbo.semfunc_LogStates() AS semfunc_LogStates_1

WHERE     (Name_Token = ''Success'')

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenToken_LeftRight_NoRight]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_TokenToken_LeftRight_NoRight]

	-- Add the parameters for the stored procedure here

	@GUID_Type_Left				uniqueidentifier,

	@GUID_Type_Right			uniqueidentifier,

	@GUID_RelationType			uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	

	CREATE TABLE #tmptbl_Relation

	(

		GUID_Token_left		uniqueidentifier,

		GUID_Token_Right	uniqueidentifier,

		GUID_RelationType	uniqueidentifier,

		OrderID				int

	)



	CREATE TABLE #tmptbl_Token_Left

	(

		GUID_Token			uniqueidentifier,

		Name_Token			varchar(255),

		GUID_Type			uniqueidentifier

	)



	CREATE TABLE #tmptbl_Token_Right

	(

		GUID_Token			uniqueidentifier,

		Name_Token			varchar(255),

		GUID_Type			uniqueidentifier

	)



    -- Insert statements for procedure here

	INSERT INTO #tmptbl_Relation

		SELECT        semtbl_Token_Token.GUID_Token_Left, semtbl_Token_Token.GUID_Token_Right, semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID

		FROM            semtbl_Token_Token INNER JOIN

		                         semtbl_Token ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token.GUID_Token INNER JOIN

		                         semtbl_Token AS semtbl_Token_1 ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_1.GUID_Token

		WHERE        (semtbl_Token_Token.GUID_RelationType = @GUID_RelationType) AND (semtbl_Token.GUID_Type = @GUID_Type_Left) AND 

		                         (semtbl_Token_1.GUID_Type = @GUID_Type_Right)



	

	INSERT INTO #tmptbl_Token_Left

		SELECT     GUID_Token, Name_Token, GUID_Type

			FROM         semtbl_Token

			WHERE     (GUID_Type = @GUID_Type_Left);



	INSERT INTO #tmptbl_Token_Right

		SELECT     GUID_Token, Name_Token, GUID_Type

			FROM         semtbl_Token

			WHERE     (GUID_Type = @GUID_Type_Right);



	

	SELECT     #tmptbl_Token_Left.GUID_Token, #tmptbl_Token_Left.Name_Token, #tmptbl_Token_Left.GUID_Type

		FROM         #tmptbl_Token_Left LEFT OUTER JOIN

							  #tmptbl_Relation ON #tmptbl_Token_Left.GUID_Token = #tmptbl_Relation.GUID_Token_Left

		WHERE     (#tmptbl_Relation.GUID_Token_Left IS NULL);

	

	



END




'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_TokenToken_OR_LeftRight]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[func_TokenToken_OR_LeftRight]
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semfunc_ObjectReference_1.Name_Token, semfunc_ObjectReference_1.GUID_Ref, semfunc_ObjectReference_1.GUID_ItemType, 
                      semtbl_Token_OR.GUID_Token_Left, semtbl_Token_OR.GUID_RelationType, semtbl_Token_OR.OrderID
FROM         dbo.semfunc_ObjectReference() AS semfunc_ObjectReference_1 INNER JOIN
                      semtbl_Token_OR ON semfunc_ObjectReference_1.GUID_ObjectReference = semtbl_Token_OR.GUID_ObjectReference
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_OR_Type_By_GUIDObjectReference]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_OR_Type_By_GUIDObjectReference

	-- Add the parameters for the stored procedure here

	@GUID_ObjectReference		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     semtbl_OR_Type.GUID_ObjectReference, semtbl_Type.GUID_Type, semtbl_Type.Name_Type, semtbl_Type.GUID_Type_Parent

FROM         semtbl_OR_Type INNER JOIN

                      semtbl_Type ON semtbl_OR_Type.GUID_Type = semtbl_Type.GUID_Type

WHERE     (semtbl_OR_Type.GUID_ObjectReference = @GUID_ObjectReference)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Attribute_With_Type_By_GUIDAttribute_LikeName]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'

-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[Attribute_With_Type_By_GUIDAttribute_LikeName]

	-- Add the parameters for the stored procedure here

	@Name_Attribute		varchar(255)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     Attribute_List_With_TypeName_1.*

		FROM         dbo.Attribute_List_With_TypeName() AS Attribute_List_With_TypeName_1

		WHERE     (Name_Attribute LIKE ''%'' + @Name_Attribute + ''%'')

		ORDER BY Name_Attribute

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Del_Token_OR]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Del_Token_OR]

	-- Add the parameters for the stored procedure here

	@GUID_Token_Left		uniqueidentifier,

	@GUID_ObjectReference	uniqueidentifier,

	@GUID_RelationType		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	

    -- Insert statements for procedure here

	

	DECLARE @intCount					int;



	SET @intCount = (SELECT     COUNT(*) AS Count_Rel

FROM         semtbl_Token_OR

WHERE     (GUID_Token_Left = @GUID_Token_Left) AND (GUID_ObjectReference = @GUID_ObjectReference) AND (GUID_RelationType = @GUID_RelationType));



	IF @intCount = 0

	BEGIN

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

	END

	ELSE

	BEGIN

		DELETE FROM semtbl_Token_OR

			WHERE     (GUID_Token_Left = @GUID_Token_Left) AND (GUID_ObjectReference = @GUID_ObjectReference) AND (GUID_RelationType = @GUID_RelationType);

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

	END

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenToken_LeftRight_Tokens_By_GUIDTokenLeft_Only]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenToken_LeftRight_Tokens_By_GUIDTokenLeft_Only]

(

	@GUID_Token_Left uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE        (semtbl_Token_Left.GUID_Token = @GUID_Token_Left)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_LogState_Error]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[semproc_LogState_Error] 

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     semfunc_LogStates_1.*

FROM         dbo.semfunc_LogStates() AS semfunc_LogStates_1

WHERE     (Name_Token = ''Error'')

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_AttributeType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_AttributeType]

(

	-- Add the parameters for the function here

	@GUID_AttributeType	uniqueidentifier,

	@GUID_DB			uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxAttributeType int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxAttributeType = (SELECT  TOP 1 [Version] AS MaxVersion

FROM         chngtbll_AttributeType

WHERE     (GUID_AttributeType = @GUID_AttributeType) AND (GUID_DB = @GUID_DB)

ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxAttributeType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenToken_RightLeft_By_GUIDToken_Right_GUIDType_Left_TokenName_Left_GUIDRel]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenToken_RightLeft_By_GUIDToken_Right_GUIDType_Left_TokenName_Left_GUIDRel]

(

	@GUID_Token_Right uniqueidentifier,

	@Name_Token_Left varchar(255),

	@GUID_Type_Left uniqueidentifier,

	@GUID_RelationType	uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE     (semtbl_Token_Right.GUID_Token = @GUID_Token_Right) AND (semtbl_Token_Left.Name_Token = @Name_Token_Left) AND (semtbl_Type_Left.GUID_Type = @GUID_Type_Left) AND 

                      (semtbl_RelationType.GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenToken_RightLeft_By_GUIDToken_Right_And_RelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenToken_RightLeft_By_GUIDToken_Right_And_RelationType]

(

	@GUID_Token_Right uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE        (semtbl_Token_Right.GUID_Token = @GUID_Token_Right) AND (semtbl_RelationType.GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_OR_TokenAttribute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_OR_TokenAttribute]

(

	-- Add the parameters for the function here

	@GUID_ObjectReference	uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxObjectReference int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxObjectReference = (SELECT  TOP  1  [Version] AS MaxVersion

		FROM         chngtbll_OR_TokenAttribute

		WHERE     (GUID_DB = @GUID_DB) AND (GUID_ObjectReference = @GUID_ObjectReference)

		ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxObjectReference



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_Type_OR]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_Type_OR]

(

	-- Add the parameters for the function here

	@GUID_Type_Left		uniqueidentifier,

	@GUID_RelationType		uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxObjectReference int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxObjectReference = (SELECT  TOP 1   [Version] AS MaxVersion

FROM         chngtbll_Type_OR

WHERE     (GUID_DB = @GUID_DB) AND (GUID_RelationType = @GUID_RelationType) AND (GUID_Type = @GUID_Type_Left)

ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxObjectReference



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_LogState_Exists]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_LogState_Exists] 

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     semfunc_LogStates_1.*

FROM         dbo.semfunc_LogStates() AS semfunc_LogStates_1

WHERE     (Name_Token = ''Exists'')

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Int]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Token_Attribute_Int](
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
	[val] [int] NOT NULL,
	[OrderID] [int] NOT NULL CONSTRAINT [DF_semtbl_Token_Attribute_Int_OrderID]  DEFAULT ((0)),
 CONSTRAINT [PK_semtbl_Token_Attribute_Int] PRIMARY KEY CLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Token_Attribute_Int]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_Attribute_Int_semtbl_Token_Attribute] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_Attribute] ([GUID_TokenAttribute]);
ALTER TABLE [dbo].[semtbl_Token_Attribute_Int] CHECK CONSTRAINT [FK_semtbl_Token_Attribute_Int_semtbl_Token_Attribute];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Modules_With_Rels]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE FUNCTION [dbo].[func_Modules_With_Rels] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Module					uniqueidentifier,

	@GUID_Type_IntegrationLevel			uniqueidentifier,

	@GUID_Type_Folder					uniqueidentifier,

	@GUID_Type_SoftwareDevelopment		uniqueidentifier,

	@GUID_RelationType_isOn				uniqueidentifier,

	@GUID_RelationType_SourcesLocatedIn	uniqueidentifier,

	@GUID_RelationType_offeredBy		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     semtbl_Token.GUID_Token AS GUID_Module, semtbl_Token.Name_Token AS Name_Module, semtbl_Token.GUID_Type AS GUID_Type_Module, 

                      semtbl_Token_1.GUID_Token AS GUID_IntegrationLevel, semtbl_Token_1.Name_Token AS Name_IntegrationLevel, 

                      semtbl_Token_1.GUID_Type AS GUID_Type_IntegrationLevel, semtbl_Token_2.GUID_Token AS GUID_Folder, semtbl_Token_2.Name_Token AS Name_Folder, 

                      semtbl_Token_2.GUID_Type AS GUID_Type_Folder, semtbl_Token_3.GUID_Token AS GUID_SoftwareDevelopment, 

                      semtbl_Token_3.Name_Token AS Name_SoftwareDevelopment, semtbl_Token_3.GUID_Type AS GUID_Type_SoftwareDevelopment

FROM         semtbl_Token INNER JOIN

                      semtbl_Token_Token ON semtbl_Token.GUID_Token = semtbl_Token_Token.GUID_Token_Left INNER JOIN

                      semtbl_Token AS semtbl_Token_1 ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_1.GUID_Token INNER JOIN

                      semtbl_Token_Token AS semtbl_Token_Token_1 ON semtbl_Token.GUID_Token = semtbl_Token_Token_1.GUID_Token_Left INNER JOIN

                      semtbl_Token AS semtbl_Token_2 ON semtbl_Token_Token_1.GUID_Token_Right = semtbl_Token_2.GUID_Token INNER JOIN

                      semtbl_Token_Token AS semtbl_Token_Token_2 ON semtbl_Token.GUID_Token = semtbl_Token_Token_2.GUID_Token_Left INNER JOIN

                      semtbl_Token AS semtbl_Token_3 ON semtbl_Token_Token_2.GUID_Token_Right = semtbl_Token_3.GUID_Token

WHERE     (semtbl_Token.GUID_Type = @GUID_Type_Module) AND (semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_isOn) AND 

                      (semtbl_Token_1.GUID_Type = @GUID_Type_IntegrationLevel) AND (semtbl_Token_Token_1.GUID_RelationType = @GUID_RelationType_SourcesLocatedIn) AND 

                      (semtbl_Token_2.GUID_Type = @GUID_Type_Folder) AND (semtbl_Token_Token_2.GUID_RelationType = @GUID_RelationType_offeredBy) AND 

                      (semtbl_Token_3.GUID_Type = @GUID_Type_SoftwareDevelopment)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_TokenToken_LeftRigth_By_GUIDs]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[func_TokenToken_LeftRigth_By_GUIDs]
(	
	-- Add the parameters for the function here
	@GUID_Token_Left		uniqueidentifier,
	@GUID_RelationType		uniqueidentifier,
	@GUID_Type_Right		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 
                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, 
                      semtbl_Token_Right.GUID_Type AS GUID_Type_Right, semtbl_Type_Left.Name_Type AS Name_Type_Left, semtbl_Type_Right.Name_Type AS Name_Type_Right, 
                      semtbl_Token_Token.OrderID
FROM         semtbl_Token_Token INNER JOIN
                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN
                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN
                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN
                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type
WHERE     (semtbl_Token_Token.GUID_RelationType = @GUID_RelationType) AND (semtbl_Token_Token.GUID_Token_Left = @GUID_Token_Left) AND 
                      (semtbl_Token_Right.GUID_Type = @GUID_Type_Right)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_RelationType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_RelationType]

(

	-- Add the parameters for the function here



	@GUID_RelationType		uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxRelationType int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxRelationType = (SELECT TOP 1 [Version] AS MaxVersion

FROM         chngtbll_RelationType

WHERE     (GUID_DB = @GUID_DB) AND (GUID_RelationType = @GUID_RelationType)

ORDER BY [VErsion] DESC);



	-- Return the result of the function

	RETURN @intMaxRelationType



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenToken_LeftRight_Ordered_By_GUIDs]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_TokenToken_LeftRight_Ordered_By_GUIDs] 

	-- Add the parameters for the stored procedure here

	@GUID_Token_Left	uniqueidentifier,

	@GUID_Type_Right	uniqueidentifier,

	@GUID_RelationType	uniqueidentifier,

	@bitASC				bit

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	IF @bitASC=1

	BEGIN

		SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE     (semtbl_Token_Left.GUID_Token = @GUID_Token_Left) AND (semtbl_Type_Right.GUID_Type = @GUID_Type_Right) AND (semtbl_RelationType.GUID_RelationType = @GUID_RelationType)

		ORDER BY OrderID;

	END

	ELSE

	BEGIN

		SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE     (semtbl_Token_Left.GUID_Token = @GUID_Token_Left) AND (semtbl_Type_Right.GUID_Type = @GUID_Type_Right) AND (semtbl_RelationType.GUID_RelationType = @GUID_RelationType)

		ORDER BY OrderID DESC;

	END

	

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_TokenAttribute_Time]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_TokenAttribute_Time]

	-- Add the parameters for the stored procedure here

	@GUID_Token		uniqueidentifier,

	@GUID_Attribute uniqueidentifier,

	@GUID_TokenAttribute uniqueidentifier,

	@val_Time				datetime,

	@intOrderID				int

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Token_DB			uniqueidentifier;

	DECLARE @GUID_Attribute_DB		uniqueidentifier;

	DECLARE @GUID_TokenAttribute_DB	uniqueidentifier;

	DECLARE @val_Time_DB			datetime;

	DECLARe @intOrderID_DB			int;



    -- Insert statements for procedure here

	If @GUID_TokenAttribute IS NULL

	BEGIN

		SET @GUID_Token_DB = (SELECT GUID_Token FROM semtbl_Token WHERE GUID_Token=@GUID_Token);

		SET @GUID_Attribute_DB = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE GUID_Attribute=@GUID_Attribute);

		

		If @GUID_Token IS NULL OR @GUID_Attribute IS NULL

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		ELSE

		BEGIN

			SET @GUID_TokenAttribute = newid()

			INSERT INTO semtbl_Token_Attribute VALUES (@GUID_TokenAttribute,@GUID_Token,@GUID_Attribute);

			INSERT INTO semtbl_Token_Attribute_Time VALUES (@GUID_TokenAttribute,@val_Time,@intOrderID);

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

	END

	ELSE

	BEGIN

		DECLARE cur_TokenAttribute_TIME CURSOR FOR 

			SELECT     semtbl_Token_Attribute.GUID_TokenAttribute, semtbl_Token_Attribute_Time.val, semtbl_Token_Attribute_Time.OrderID

FROM         semtbl_Token_Attribute INNER JOIN

                      semtbl_Token_Attribute_Time ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Time.GUID_TokenAttribute

WHERE     (semtbl_Token_Attribute.GUID_TokenAttribute = @GUID_TokenAttribute)

		OPEN cur_TokenAttribute_TIME;

		FETCH NEXT FROM cur_TokenAttribute_TIME INTO

			@GUID_TokenAttribute_DB,

			@val_Time_DB,

			@intOrderID_DB;

		IF @@FETCH_STATUS=0

		BEGIN

			If NOT @val_Time_DB=@val_Time

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_Time SET Val=@val_Time, OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					UPDATE semtbl_Token_Attribute_Time SET Val=@val_Time WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

			END

			ELSE

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_Time SET OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

				END

			END

		END

		ELSE

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		CLOSE cur_TokenAttribute_TIME;

		DEALLOCATE cur_TokenAttribute_TIME;

		

	END

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_Type_Attribute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_Type_Attribute]

(

	-- Add the parameters for the function here

	@GUID_Type			uniqueidentifier,

	@GUID_Attribute		uniqueidentifier,

	@GUID_DB			uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxTypeAttrib int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxTypeAttrib = (SELECT  TOP 1  [Version] AS MaxVersion

FROM         chngtbll_Type_Attribute

WHERE     (GUID_Type = @GUID_Type) AND (GUID_Type = @GUID_Type) AND (GUID_DB = @GUID_DB)

ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxTypeAttrib



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TypeProc_Type_Type_By_GUIDRelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.TypeProc_Type_Type_By_GUIDRelationType

(

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Type_Left, Name_Type_Left, GUID_Type_Parent_Left, GUID_RelationType, Name_RelationType, GUID_Type_Right, Name_Type_Right, 

                         GUID_Type_Parent_Right, Min_forw, Max_forw, Max_backw

FROM            dbo.typefunc_Types_Rel() AS typefunc_Types_Rel_1

WHERE        (GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_TokenAttribute_Varchar255]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_TokenAttribute_Varchar255]

	-- Add the parameters for the stored procedure here

	@GUID_Token		uniqueidentifier,

	@GUID_Attribute uniqueidentifier,

	@GUID_TokenAttribute uniqueidentifier,

	@val_Varchar255				varchar(255),

	@intOrderID				int

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Token_DB			uniqueidentifier;

	DECLARE @GUID_Attribute_DB		uniqueidentifier;

	DECLARE @GUID_TokenAttribute_DB	uniqueidentifier;

	DECLARE @val_Varchar255_DB			varchar(255);

	DECLARe @intOrderID_DB			int;



    -- Insert statements for procedure here

	If @GUID_TokenAttribute IS NULL

	BEGIN

		SET @GUID_Token_DB = (SELECT GUID_Token FROM semtbl_Token WHERE GUID_Token=@GUID_Token);

		SET @GUID_Attribute_DB = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE GUID_Attribute=@GUID_Attribute);

		

		If @GUID_Token IS NULL OR @GUID_Attribute IS NULL

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		ELSE

		BEGIN

			SET @GUID_TokenAttribute = newid()

			INSERT INTO semtbl_Token_Attribute VALUES (@GUID_TokenAttribute,@GUID_Token,@GUID_Attribute);

			INSERT INTO semtbl_Token_Attribute_Varchar255 VALUES (@GUID_TokenAttribute,@val_Varchar255,@intOrderID);

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

	END

	ELSE

	BEGIN

		DECLARE cur_TokenAttribute_VARCHAR255 CURSOR FOR 

			SELECT     semtbl_Token_Attribute.GUID_TokenAttribute, semtbl_Token_Attribute_Varchar255.val, semtbl_Token_Attribute_Varchar255.OrderID

FROM         semtbl_Token_Attribute INNER JOIN

                      semtbl_Token_Attribute_Varchar255 ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Varchar255.GUID_TokenAttribute

WHERE     (semtbl_Token_Attribute.GUID_TokenAttribute = @GUID_TokenAttribute)

		OPEN cur_TokenAttribute_VARCHAR255;

		FETCH NEXT FROM cur_TokenAttribute_VARCHAR255 INTO

			@GUID_TokenAttribute_DB,

			@val_Varchar255_DB,

			@intOrderID_DB;

		IF @@FETCH_STATUS=0

		BEGIN

			If NOT @val_Varchar255_DB=@val_Varchar255

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_Varchar255 SET Val=@val_Varchar255, OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					UPDATE semtbl_Token_Attribute_Varchar255 SET Val=@val_Varchar255 WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

			END

			ELSE

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_Varchar255 SET OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

				END

			END

		END

		ELSE

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		CLOSE cur_TokenAttribute_VARCHAR255;

		DEALLOCATE cur_TokenAttribute_VARCHAR255;

		

	END

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Del_TokenRel]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Del_TokenRel]

	-- Add the parameters for the stored procedure here

	@GUID_Token_Left		uniqueidentifier,

	@GUID_Token_Right		uniqueidentifier,

	@GUID_RelationType		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	

    -- Insert statements for procedure here

	

	DECLARE @intCount					int;



	SET @intCount = (SELECT     COUNT(*) AS Count_Rel

		FROM         semtbl_Token_Token

		WHERE     (GUID_Token_Left = @GUID_Token_Left) AND (GUID_Token_Right = @GUID_Token_Right) AND (GUID_RelationType = @GUID_RelationType));



	IF @intCount = 0

	BEGIN

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

	END

	ELSE

	BEGIN

		DELETE FROM semtbl_Token_Token

			WHERE     (GUID_Token_Left = @GUID_Token_Left) AND (GUID_Token_Right = @GUID_Token_Right) AND (GUID_RelationType = @GUID_RelationType);

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

	END

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_Token]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_Token]

(

	-- Add the parameters for the function here

	@GUID_Token		uniqueidentifier,

	@GUID_DB		uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxToken int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxToken = (SELECT  TOP 1 [Version] AS MaxVersion

FROM         chngtbll_Token

WHERE     (GUID_Token = @GUID_Token) AND (GUID_DB = @GUID_DB)

ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxToken



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_attribute_time]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Token_attribute_time](
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
	[val] [datetime] NOT NULL,
	[OrderID] [int] NOT NULL CONSTRAINT [DF_semtbl_Token_attribute_time_OrderID]  DEFAULT ((0)),
 CONSTRAINT [PK_semtbl_Token_attribute_timetime1] PRIMARY KEY CLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Token_attribute_time]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_attribute_time_semtbl_Token_Attribute] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_Attribute] ([GUID_TokenAttribute]);
ALTER TABLE [dbo].[semtbl_Token_attribute_time] CHECK CONSTRAINT [FK_semtbl_Token_attribute_time_semtbl_Token_Attribute];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_varcharMAX]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Token_Attribute_varcharMAX](
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
	[val] [varchar](max) NOT NULL,
	[OrderID] [int] NOT NULL CONSTRAINT [DF_semtbl_Token_Attribute_varcharMAX_OrderID]  DEFAULT ((0)),
 CONSTRAINT [PK_semtbl_Token_Attribute_varcharMAX] PRIMARY KEY CLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Token_Attribute_varcharMAX]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_Attribute_varcharMAX_semtbl_Token_Attribute] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_Attribute] ([GUID_TokenAttribute]);
ALTER TABLE [dbo].[semtbl_Token_Attribute_varcharMAX] CHECK CONSTRAINT [FK_semtbl_Token_Attribute_varcharMAX_semtbl_Token_Attribute];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_TokenAttribute_Datetime]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_TokenAttribute_Datetime]

	-- Add the parameters for the stored procedure here

	@GUID_Token		uniqueidentifier,

	@GUID_Attribute uniqueidentifier,

	@GUID_TokenAttribute uniqueidentifier,

	@val_Date				datetime,

	@intOrderID				int

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Token_DB			uniqueidentifier;

	DECLARE @GUID_Attribute_DB		uniqueidentifier;

	DECLARE @GUID_TokenAttribute_DB	uniqueidentifier;

	DECLARE @val_Date_DB			datetime;

	DECLARe @intOrderID_DB			int;



    -- Insert statements for procedure here

	If @GUID_TokenAttribute IS NULL

	BEGIN

		SET @GUID_Token_DB = (SELECT GUID_Token FROM semtbl_Token WHERE GUID_Token=@GUID_Token);

		SET @GUID_Attribute_DB = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE GUID_Attribute=@GUID_Attribute);

		

		If @GUID_Token IS NULL OR @GUID_Attribute IS NULL

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		ELSE

		BEGIN

			SET @GUID_TokenAttribute = newid()

			INSERT INTO semtbl_Token_Attribute VALUES (@GUID_TokenAttribute,@GUID_Token,@GUID_Attribute);

			INSERT INTO semtbl_Token_Attribute_Datetime VALUES (@GUID_TokenAttribute,@val_Date,@intOrderID);

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

	END

	ELSE

	BEGIN

		DECLARE cur_TokenAttribute_DATETIME CURSOR FOR 

			SELECT     semtbl_Token_Attribute.GUID_TokenAttribute, semtbl_Token_attribute_datetime.val, semtbl_Token_attribute_datetime.OrderID

FROM         semtbl_Token_Attribute INNER JOIN

                      semtbl_Token_attribute_datetime ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_attribute_datetime.GUID_TokenAttribute

WHERE     (semtbl_Token_Attribute.GUID_TokenAttribute = @GUID_TokenAttribute)

		OPEN cur_TokenAttribute_DATETIME;

		FETCH NEXT FROM cur_TokenAttribute_DATETIME INTO

			@GUID_TokenAttribute_DB,

			@val_Date_DB,

			@intOrderID_DB;

		IF @@FETCH_STATUS=0

		BEGIN

			If NOT @val_Date_DB=@val_Date

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_Datetime SET Val=@val_Date, OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					UPDATE semtbl_Token_Attribute_Datetime SET Val=@val_Date WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

			END

			ELSE

			BEGIN

				IF NOT @intOrderID=@intOrderID_DB

				BEGIN

					UPDATE semtbl_Token_Attribute_Datetime SET OrderID=@intOrderID WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

				END

				ELSE

				BEGIN

					SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

				END

			END

		END

		ELSE

		BEGIN

			SELECT *,@GUID_TokenAttribute AS GUID_TokenAttribute FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		CLOSE cur_TokenAttribute_DATETIME;

		DEALLOCATE cur_TokenAttribute_DATETIME;

		

	END

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_OR_AttributeType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_OR_AttributeType]

(

	-- Add the parameters for the function here

	@GUID_ObjectReference	uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxObjectReference int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxObjectReference = (SELECT TOP 1 [Version] AS MaxVersion

		FROM         chngtbll_OR_AttributeType

		WHERE     (GUID_DB = @GUID_DB) AND (GUID_ObjectReference = @GUID_ObjectReference)

		ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxObjectReference



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_Token_OR]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_Token_OR] 

	-- Add the parameters for the stored procedure here

	@GUID_Token_Left		uniqueidentifier,

	@GUID_ObjectReference	uniqueidentifier,

	@GUID_RelationType		uniqueidentifier,

	@intOrderID				int

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Token_Left_DB		uniqueidentifier;

	DECLARE @GUID_ObjectReference_DB	uniqueidentifier;

	DECLARE @GUID_RelationType_DB	uniqueidentifier;

	DECLARE @intOrderID_DB			int



    -- Insert statements for procedure here

	DECLARE cur_Token_Rel CURSOR FOR

		SELECT     GUID_Token_Left, GUID_ObjectReference, GUID_RelationType, OrderID

FROM         semtbl_Token_OR

WHERE     (GUID_Token_Left = @GUID_Token_Left) AND (GUID_ObjectReference = @GUID_ObjectReference) AND (GUID_RelationType = @GUID_RelationType);



	OPEN cur_Token_Rel;

	FETCH NEXT FROM cur_Token_Rel INTO

		@GUID_Token_Left_DB,

		@GUID_ObjectReference_DB,

		@GUID_RelationType_DB,

		@intOrderID_DB;



	IF @@FETCH_STATUS=0 

	BEGIN

		



		IF NOT @intOrderID_DB = @intOrderID

		BEGIN

			UPDATE semtbl_Token_OR SET OrderID=@intOrderID 

				WHERE GUID_Token_Left=@GUID_Token_Left

				AND GUID_ObjectReference=@GUID_ObjectReference

				AND GUID_RelationType=@GUID_RelationType;

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

		END

		ELSE

		BEGIN

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

		END

	END

	ELSE

	BEGIN

		INSERT INTO semtbl_Token_OR VALUES (@GUID_Token_Left,@GUID_ObjectReference,@GUID_RelationType,@intOrderID);

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

	END

	CLOSE cur_Token_Rel;

	DEALLOCATE cur_Token_Rel;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenToken_LeftRight_By_GUIDToken_Left_And_RelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenToken_LeftRight_By_GUIDToken_Left_And_RelationType]

(

	@GUID_Token_Left uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE     (semtbl_Token_Left.GUID_Token = @GUID_Token_Left) AND (semtbl_RelationType.GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenRel_With_Or]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_TokenRel_With_Or]

	-- Add the parameters for the stored procedure here

	 @GUID_Token				uniqueidentifier

	,@GUID_Direction_LeftRight	uniqueidentifier

	,@Name_Direction_LeftRight	varchar(255)

	,@GUID_Direction_RightLeft	uniqueidentifier

	,@Name_Direction_RightLeft	varchar(255)

	,@GUID_Type_Direction		uniqueidentifier

	,@GUID_ItemType_Token		uniqueidentifier

	,@Name_ItemType_Token		varchar(255)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

    DECLARE @tmp_Token_Rel TABLE

    (

		 GUID_Direction			uniqueidentifier

		,Name_Direction			varchar(255)

		,GUID_Type_Direction	uniqueidentifier

		,GUID_RelationType		uniqueidentifier

		,Name_RelationType		varchar(255)

		,OrderID				int

		,GUID_Other				uniqueidentifier

		,Name_Other				varchar(255)

		,GUID_ObjectReference	uniqueidentifier

		,GUID_Parent_Other		uniqueidentifier

		,Name_Parent_Other		varchar(255)

		,GUID_ItemType			uniqueidentifier

		,Name_ItemType			varchar(255)

    )

	

	INSERT INTO @tmp_Token_Rel

	SELECT   @GUID_Direction_LeftRight AS GUID_Direction

			,@Name_Direction_LeftRight AS Name_Direction

			,@GUID_Type_Direction AS GUID_Type_Direction

			,semtbl_Token_OR.GUID_RelationType

			,semtbl_RelationType.Name_RelationType

			,semtbl_Token_OR.OrderID

			,CAST(NULL AS uniqueidentifier) AS GUID_Other

			,CAST(NULL AS varchar(255)) AS Name_Other

			,semtbl_Token_OR.GUID_ObjectReference AS GUID_ObjectReference

			,CAST(NULL AS uniqueidentifier) AS GUID_Parent_Other

			,CAST(NULL AS varchar(255)) AS Name_Parent_Other

			,semtbl_ORType.GUID_ObjectReferenceType AS GUID_ItemType

			,semtbl_ORType.Name_ObjectReferenceType AS Name_ItemType

	FROM        semtbl_Token_OR

	INNER JOIN	semtbl_RelationType ON semtbl_Token_OR.GUID_RelationType = semtbl_RelationType.GUID_RelationType

	INNER JOIN semtbl_OR ON semtbl_Token_OR.GUID_ObjectReference = semtbl_OR.GUID_ObjectReference 

	INNER JOIN semtbl_ORType ON semtbl_OR.GUID_ORType = semtbl_ORType.GUID_ObjectReferenceType

	WHERE     (semtbl_Token_OR.GUID_Token_Left = @GUID_Token)

	

	UPDATE @tmp_Token_Rel

		 SET GUID_Other = semtbl_Attribute.GUID_Attribute

			,Name_Other = semtbl_Attribute.Name_Attribute

			,GUID_Parent_Other = semtbl_AttributeType.GUID_AttributeType

			,Name_Parent_Other = semtbl_AttributeType.Name_AttributeType

	FROM         @tmp_Token_Rel t INNER JOIN

						  semtbl_OR_Attribute ON t.GUID_ObjectReference = semtbl_OR_Attribute.GUID_ObjectReference INNER JOIN

						  semtbl_Attribute ON semtbl_OR_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN

						  semtbl_AttributeType ON semtbl_Attribute.GUID_AttributeType = semtbl_AttributeType.GUID_AttributeType

						  

	

	

	UPDATE @tmp_Token_Rel

		 SET GUID_Other = ItemRef.GUID_RelationType

			,Name_Other = ItemRef.Name_RelationType

	FROM         @tmp_Token_Rel t INNER JOIN

						  semtbl_OR_RelationType ON t.GUID_ObjectReference = semtbl_OR_RelationType.GUID_ObjectReference INNER JOIN

						  semtbl_RelationType AS ItemRef ON semtbl_OR_RelationType.GUID_RelationType = ItemRef.GUID_RelationType

	

	

	UPDATE @tmp_Token_Rel

		 SET GUID_Other = ItemRef.GUID_Type

			,Name_Other = ItemRef.Name_Type

			,GUID_Parent_Other = ItemRef.GUID_Type_Parent

	FROM         @tmp_Token_Rel t INNER JOIN

						  semtbl_OR_Type ON t.GUID_ObjectReference = semtbl_OR_Type.GUID_ObjectReference INNER JOIN

						  semtbl_Type AS ItemRef ON semtbl_OR_Type.GUID_Type = ItemRef.GUID_Type

	

	UPDATE @tmp_Token_Rel

		 SET GUID_Other = ItemRef.GUID_Token

			,Name_Other = ItemRef.Name_Token

			,GUID_Parent_Other = ItemRef_Parent.GUID_Type

			,Name_Parent_Other = ItemRef_Parent.Name_Type

	FROM         @tmp_Token_Rel t INNER JOIN

						  semtbl_OR_Token ON t.GUID_ObjectReference = semtbl_OR_Token.GUID_ObjectReference INNER JOIN

						  semtbl_Token AS ItemRef ON semtbl_OR_Token.GUID_Token = ItemRef.GUID_Token INNER JOIN

						  semtbl_Type AS ItemRef_Parent ON ItemRef.GUID_Type = ItemRef_Parent.GUID_Type

	

	INSERT INTO @tmp_Token_Rel

	SELECT   @GUID_Direction_LeftRight AS GUID_Direction

			,@Name_Direction_LeftRight AS Name_Direction

			,@GUID_Type_Direction AS GUID_Type_Direction

			,semtbl_Token_Token.GUID_RelationType

			,semtbl_RelationType.Name_RelationType

			,semtbl_Token_Token.OrderID

			,Token_Right.GUID_Token AS GUID_Other

			,Token_Right.Name_Token AS Name_Other

			,CAST(NULL AS uniqueidentifier) AS GUID_ObjectReference	

			,Token_Right.GUID_Type AS GUID_Parent_Other

			,semtbl_Type.Name_Type AS Name_Parent_Other

			,@GUID_ItemType_Token AS GUID_ItemType

			,@Name_ItemType_Token AS Name_ItemType

	FROM         semtbl_Token_Token INNER JOIN

						  semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType INNER JOIN

						  semtbl_Token AS Token_Right ON semtbl_Token_Token.GUID_Token_Right = Token_Right.GUID_Token INNER JOIN

						  semtbl_Type ON Token_Right.GUID_Type = semtbl_Type.GUID_Type

	WHERE     (semtbl_Token_Token.GUID_Token_Left = @GUID_Token)	

	

	INSERT INTO @tmp_Token_Rel

	  SELECT @GUID_Direction_RightLeft AS GUID_Direction

			,@Name_Direction_RightLeft AS Name_Direction

			,@GUID_Type_Direction AS GUID_Type_Direction

			,semtbl_Token_Token.GUID_RelationType

			,semtbl_RelationType.Name_RelationType

			,semtbl_Token_Token.OrderID

			,Token_Left.GUID_Token AS GUID_Other

			,Token_Left.Name_Token AS Name_Other

			,CAST(NULL AS uniqueidentifier) AS GUID_ObjectReference	

			,Token_Left.GUID_Type AS GUID_Parent_Other

			,semtbl_Type.Name_Type AS Name_Parent_Other

			,@GUID_ItemType_Token AS GUID_ItemType

			,@Name_ItemType_Token AS Name_ItemType

	FROM         semtbl_Token_Token INNER JOIN

						  semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType INNER JOIN

						  semtbl_Token AS Token_Left ON semtbl_Token_Token.GUID_Token_Left = Token_Left.GUID_Token INNER JOIN

						  semtbl_Type ON Token_Left.GUID_Type = semtbl_Type.GUID_Type

	WHERE     (semtbl_Token_Token.GUID_Token_Right = @GUID_Token)	



	SELECT * FROM @tmp_Token_Rel	

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_LogState_Nothing]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE semproc_LogState_Nothing

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     semfunc_LogStates_1.*

FROM         dbo.semfunc_LogStates() AS semfunc_LogStates_1

WHERE     (Name_Token = ''Nothing'')

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_TokenRel]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_TokenRel] 

	-- Add the parameters for the stored procedure here

	@GUID_Token_Left		uniqueidentifier,

	@GUID_Token_Right		uniqueidentifier,

	@GUID_RelationType		uniqueidentifier,

	@intOrderID				int

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Token_Left_DB		uniqueidentifier;

	DECLARE @GUID_Token_Right_DB	uniqueidentifier;

	DECLARE @GUID_RelationType_DB	uniqueidentifier;

	DECLARE @intOrderID_DB			int



    -- Insert statements for procedure here

	DECLARE cur_Token_Rel CURSOR FOR

		SELECT     GUID_Token_Left, GUID_Token_Right, GUID_RelationType, OrderID

			FROM         semtbl_Token_Token

			WHERE     (GUID_Token_Left = @GUID_Token_Left) AND (GUID_Token_Right = @GUID_Token_Right) AND (GUID_RelationType = @GUID_RelationType);



	OPEN cur_Token_Rel;

	FETCH NEXT FROM cur_Token_Rel INTO

		@GUID_Token_Left_DB,

		@GUID_Token_Right_DB,

		@GUID_RelationType_DB,

		@intOrderID_DB;



	IF @@FETCH_STATUS=0 

	BEGIN

		



		IF NOT @intOrderID_DB = @intOrderID

		BEGIN

			UPDATE semtbl_Token_Token SET OrderID=@intOrderID WHERE

				GUID_Token_Left=@GUID_Token_Left AND GUID_Token_Right=@GUID_Token_Right AND GUID_RelationType=@GUID_RelationType;

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

		END

		ELSE

		BEGIN

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

		END

	END

	ELSE

	BEGIN

		INSERT INTO semtbl_Token_Token VALUES (@GUID_Token_Left,@GUID_Token_Right,@GUID_RelationType,@intOrderID);

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

	END

	CLOSE cur_Token_Rel;

	DEALLOCATE cur_Token_Rel;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_OR_TokenAttibute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_OR_TokenAttibute]

(

	-- Add the parameters for the function here

	@GUID_ObjectReference	uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxObjectReference int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxObjectReference = (SELECT TOP 1 [Version] AS MaxVersion

		FROM         chngtbll_OR_TokenAttribute

		WHERE     (GUID_DB = @GUID_DB) AND (GUID_ObjectReference = @GUID_ObjectReference)

		ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxObjectReference



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_OR_TokenToken]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_OR_TokenToken]

(

	-- Add the parameters for the function here

	@GUID_ObjectReference	uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxObjectReference int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxObjectReference = (SELECT  TOP 1   [Version] AS MaxVersion

		FROM         chngtbll_OR_TokenToken

		WHERE     (GUID_DB = @GUID_DB) AND (GUID_ObjectReference = @GUID_ObjectReference)

		ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxObjectReference



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[typefunc_Types_With_Attributes_And_Types]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION typefunc_Types_With_Attributes_And_Types
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Type.GUID_Type, semtbl_Type.Name_Type, semtbl_Attribute.GUID_Attribute, semtbl_Attribute.Name_Attribute, semtbl_AttributeType.GUID_AttributeType, 
                      semtbl_AttributeType.Name_AttributeType, semtbl_Type_Attribute.Min, semtbl_Type_Attribute.Max
FROM         semtbl_Type INNER JOIN
                      semtbl_Type_Attribute ON semtbl_Type.GUID_Type = semtbl_Type_Attribute.GUID_Type INNER JOIN
                      semtbl_Attribute ON semtbl_Type_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
                      semtbl_AttributeType ON semtbl_Attribute.GUID_AttributeType = semtbl_AttributeType.GUID_AttributeType
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenToken_RightLeft_Tokens_By_GUIDTokenRight_Only]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenToken_RightLeft_Tokens_By_GUIDTokenRight_Only]

(

	@GUID_Token_Right uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE        (semtbl_Token_Right.GUID_Token = @GUID_Token_Right)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_varchar255]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Token_Attribute_varchar255](
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
	[val] [varchar](255) NOT NULL,
	[OrderID] [int] NOT NULL CONSTRAINT [DF_semtbl_Token_Attribute_varchar255_OrderID]  DEFAULT ((0)),
 CONSTRAINT [PK_semtbl_Token_Attribute_varchar255] PRIMARY KEY CLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Token_Attribute_varchar255]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_Attribute_varchar255_semtbl_Token_Attribute] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_Attribute] ([GUID_TokenAttribute]);
ALTER TABLE [dbo].[semtbl_Token_Attribute_varchar255] CHECK CONSTRAINT [FK_semtbl_Token_Attribute_varchar255_semtbl_Token_Attribute];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_attribute_datetime]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_Token_attribute_datetime](
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
	[val] [datetime] NOT NULL,
	[OrderID] [int] NOT NULL CONSTRAINT [DF_semtbl_Token_attribute_datetime_OrderID]  DEFAULT ((0)),
 CONSTRAINT [PK_semtbl_Token_attribute_datetimetime1] PRIMARY KEY CLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_Token_attribute_datetime]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_Token_attribute_datetime_semtbl_Token_Attribute] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_Attribute] ([GUID_TokenAttribute]);
ALTER TABLE [dbo].[semtbl_Token_attribute_datetime] CHECK CONSTRAINT [FK_semtbl_Token_attribute_datetime_semtbl_Token_Attribute];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_OR_AttributeType_By_GUIDObjectReference]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_OR_AttributeType_By_GUIDObjectReference

	-- Add the parameters for the stored procedure here

	@GUID_ObjectReference		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     semtbl_OR_AttributeType.GUID_ObjectReference, semtbl_AttributeType.GUID_AttributeType, semtbl_AttributeType.Name_AttributeType

FROM         semtbl_OR_AttributeType INNER JOIN

                      semtbl_AttributeType ON semtbl_OR_AttributeType.GUID_ObjectReference = semtbl_AttributeType.GUID_AttributeType

WHERE     (semtbl_OR_AttributeType.GUID_ObjectReference = @GUID_ObjectReference)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Token_By_Rel]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'

-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Token_By_Rel]

	-- Add the parameters for the stored procedure here

	 @Direction					int

	,@Null_Other                bit

    ,@GUID_Token_Left			uniqueidentifier = null

    ,@Name_Token_Left			varchar(255) = null

    ,@GUID_Type_Left			uniqueidentifier = null

    ,@GUID_Token_Right          uniqueidentifier = null

    ,@Name_Token_Right          varchar(255) = null

    ,@GUID_Type_Right			uniqueidentifier = null

    ,@GUID_RelationType         uniqueidentifier = null



AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	DECLARE @SQL_Token           varchar(400)

      DECLARE @SQL_Rel_Left   varchar(800)

      DECLARE @SQL_Rel_Right  varchar(800)

      DECLARE @WHERE_Left          varchar(500)

      DECLARE @WHERE_Right    varchar(500)

      DECLARE @SQL                 varchar(4000)



      SET @SQL_Token = ''SELECT  GUID_Token

                                         ,Name_Token

                                         ,GUID_Type

                                   FROM semtbl_Token''

      SET @SQL_Rel_Left =     ''

      SELECT   semtbl_Token_Token.GUID_Token_Right

                  ,semtbl_Token_Token.GUID_RelationType

                  ,semtbl_Token.GUID_Token

                  ,semtbl_Token.Name_Token

            ,semtbl_Token.GUID_Type

            FROM         semtbl_Token 

            INNER JOIN semtbl_Token_Token ON semtbl_Token.GUID_Token = semtbl_Token_Token.GUID_Token_Left

      ''

      

      SET @SQL_Rel_Right =    ''

      SELECT   semtbl_Token_Token.GUID_Token_Left

                  ,semtbl_Token_Token.GUID_RelationType

                  ,semtbl_Token.GUID_Token

            ,semtbl_Token.Name_Token

                  ,semtbl_Token.GUID_Type

            FROM         semtbl_Token 

            INNER JOIN semtbl_Token_Token ON semtbl_Token.GUID_Token = semtbl_Token_Token.GUID_Token_Right

      ''

      

      SET @WHERE_Left = ''''

      SET @WHERE_Right = ''''



      IF @GUID_Token_Left IS NOT NULL AND NOT @GUID_Token_Left = ''00000000-0000-0000-0000-000000000000''

      BEGIN

            IF NOT @WHERE_Left=''''

                  SET @WHERE_Left = @WHERE_Left + '' AND ''

            

            SET @WHERE_Left = @WHERE_Left + ''GUID_Token = '''''' + CAST(@GUID_Token_Left AS VARCHAR(36)) + ''''''''

      END



      IF @Name_Token_Left IS NOT NULL

      BEGIN

            IF NOT @WHERE_Left=''''

                  SET @WHERE_Left = @WHERE_Left + '' AND ''

            

            SET @WHERE_Left = @WHERE_Left + ''Name_Token Like ''''%'' + @Name_Token_Left + ''%''''''



      END



      IF @GUID_Type_Left IS NOT NULL AND NOT @GUID_Type_Left = ''00000000-0000-0000-0000-000000000000''

      BEGIN

            IF NOT @WHERE_Left=''''

                  SET @WHERE_Left = @WHERE_Left + '' AND ''

            

            SET @WHERE_Left = @WHERE_Left + ''GUID_Type = '''''' + CAST(@GUID_Type_Left AS VARCHAR(36)) + ''''''''



      END



      IF @GUID_Token_Right IS NOT NULL AND NOT @GUID_Token_Right = ''00000000-0000-0000-0000-000000000000''

      BEGIN

            IF NOT @WHERE_Right=''''

                  SET @WHERE_Right = @WHERE_Right + '' AND ''

            

            SET @WHERE_Right = @WHERE_Right + ''GUID_Token = '''''' + CAST(@GUID_Token_Right AS VARCHAR(36)) + ''''''''



      END



      IF @Name_Token_Right IS NOT NULL 

      BEGIN

            IF NOT @WHERE_Right=''''

                  SET @WHERE_Right = @WHERE_Right + '' AND ''

            

            SET @WHERE_Right = @WHERE_Right + ''Name_Token Like ''''%'' + @Name_Token_Right + ''%''''''



      END



      



      IF @GUID_Type_Right IS NOT NULL AND NOT @GUID_Type_Right = ''00000000-0000-0000-0000-000000000000''

      BEGIN

            IF NOT @WHERE_Right=''''

                  SET @WHERE_Right = @WHERE_Right + '' AND ''

            

            SET @WHERE_Right = @WHERE_Right + ''GUID_Type = '''''' + CAST(@GUID_Type_Right AS VARCHAR(36)) + ''''''''



      END



	  IF @Direction=1

      BEGIN

            IF NOT @WHERE_Left = ''''

                  SET @SQL_Token = @SQL_Token + '' WHERE '' + @WHERE_Left



      END

      ELSE

      BEGIN

            IF NOT @WHERE_Right = ''''

                  SET @SQL_Token = @SQL_Token + '' WHERE '' + @WHERE_Right

      END	

      

      IF @GUID_RelationType IS NOT NULL AND NOT @GUID_RelationType = ''00000000-0000-0000-0000-000000000000''

      BEGIN



            IF NOT @WHERE_Left=''''

                  SET @WHERE_Left = @WHERE_Left + '' AND ''

            

            SET @WHERE_Left = @WHERE_Left + ''GUID_RelationType = '''''' + CAST(@GUID_RelationType AS VARCHAR(36)) + ''''''''



            IF NOT @WHERE_Right=''''

                  SET @WHERE_Right = @WHERE_Right + '' AND ''

            

            SET @WHERE_Right = @WHERE_Right + ''GUID_RelationType = '''''' + CAST(@GUID_RelationType AS VARCHAR(36)) + ''''''''

      END



      IF NOT @WHERE_Left = ''''

      BEGIN

            SET @SQL_Rel_Left = @SQL_Rel_Left + '' WHERE '' + @WHERE_Left

      END



      IF NOT @WHERE_Right = ''''

      BEGIN

            SET @SQL_Rel_Right = @SQL_Rel_Right + '' WHERE '' + @WHERE_Right

      END

      

      IF @Direction = 1

      BEGIN

            SET @SQL = ''SELECT DISTINCT  Token_Left.GUID_Token

                                         ,Token_Left.Name_Token

                                         ,Token_Left.GUID_Type FROM ''

            SET @SQL = @SQL + ''('' + @SQL_Token + '') AS Token_Left ''

            IF @Null_Other=1

                  SET @SQL = @SQL + ''LEFT OUTER ''

            SET @SQL = @SQL + ''JOIN ('' + @SQL_Rel_Right + '') AS Token_Right ON Token_Left.GUID_Token = Token_Right.GUID_Token_Left ''

            IF @Null_Other=1

                  SET @SQL = @SQL + ''WHERE Token_Right.GUID_Token IS NULL''

      END

      ELSE

      BEGIN

            SET @SQL = ''SELECT  DISTINCT Token_Right.GUID_Token

                                         ,Token_Right.Name_Token

                                         ,Token_Right.GUID_Type FROM ''

            SET @SQL = @SQL + ''('' + @SQL_Token + '') AS Token_Right ''

            IF @Null_Other=1

                  SET @SQL = @SQL + ''LEFT OUTER ''

            SET @SQL = @SQL + ''JOIN ('' + @SQL_Rel_Left + '') AS Token_Left ON Token_Left.GUID_Token_Right = Token_Right.GUID_Token ''

            IF @Null_Other=1

                  SET @SQL = @SQL + ''WHERE Token_Left.GUID_Token IS NULL''

      END

		PRINT @SQL

      exec(@SQL)  



END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_OR_Attribute_By_GUIDAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_OR_Attribute_By_GUIDAttribute]

(

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_ObjectReference, GUID_Attribute

FROM            semtbl_OR_Attribute

WHERE        (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_OR_RelationType_By_GUIDObjectReference]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_OR_RelationType_By_GUIDObjectReference

	-- Add the parameters for the stored procedure here

	@GUID_ObjectReference		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     semtbl_OR_RelationType.GUID_ObjectReference, semtbl_RelationType.GUID_RelationType, semtbl_RelationType.Name_RelationType

FROM         semtbl_OR_RelationType INNER JOIN

                      semtbl_RelationType ON semtbl_OR_RelationType.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE     (semtbl_OR_RelationType.GUID_ObjectReference = @GUID_ObjectReference)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_LogState_Insert]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_LogState_Insert] 

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     semfunc_LogStates_1.*

FROM         dbo.semfunc_LogStates() AS semfunc_LogStates_1

WHERE     (Name_Token = ''Insert'')

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_OR_Attribute_By_GUIDObjectReference]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_OR_Attribute_By_GUIDObjectReference

	-- Add the parameters for the stored procedure here

	@GUID_ObjectReference		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     semtbl_OR_Attribute.GUID_ObjectReference, semtbl_Attribute.GUID_Attribute, semtbl_Attribute.Name_Attribute, semtbl_Attribute.GUID_AttributeType

FROM         semtbl_OR_Attribute INNER JOIN

                      semtbl_Attribute ON semtbl_OR_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute

WHERE     (semtbl_OR_Attribute.GUID_ObjectReference = @GUID_ObjectReference)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_RelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_RelationType] 

	-- Add the parameters for the stored procedure here

	@GUID_RelationType			uniqueidentifier,

	@Name_RelationType			varchar(255)

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_RelationType_DB			uniqueidentifier;

	DECLARE @Name_RelationType_DB			varchar(255);

	DECLARE @intCount						int;

	DECLARE @bitChange						bit;



    -- Insert statements for procedure here

	DECLARE cur_RelationType CURSOR FOR

		SELECT     GUID_RelationType, Name_RelationType

			FROM         semtbl_RelationType

			WHERE     (GUID_RelationType = @GUID_RelationType);



	OPEN cur_RelationType;

	FETCH NEXT FROM cur_RelationType INTO

		@GUID_RelationType_DB,

		@Name_RelationType_DB;



	CLOSE cur_RelationType;

	DEALLOCATE cur_RelationType;

	SET @bitChange = 0;

	IF @@FETCH_STATUS=0 

	BEGIN

		IF NOT @Name_RelationType=@Name_RelationType_DB

		BEGIN

			UPDATE semtbl_RelationType SET Name_RelationType=@Name_RelationType WHERE GUID_RelationType=@GUID_RelationType;

			SET @bitChange=1;

		END

		

		If @bitChange=1

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

		ELSE

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

	END

	ELSE

	BEGIN

		

		SET @intCount = (SELECT     COUNT(*) AS Count_RelationTypes

			FROM         semtbl_RelationType

			WHERE     (Name_RelationType = @Name_RelationType));

		IF @intCount = 0

		BEGIN

			INSERT INTO semtbl_RelationType VALUES (@GUID_RelationType,@Name_RelationType);

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

		ELSE

		BEGIN

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Exists'';

		END

	

		

	END

	

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenToken_LeftRight_By_GUIDToken_Left_GUIDType_Right_TokenName_Right_GUIDRel]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenToken_LeftRight_By_GUIDToken_Left_GUIDType_Right_TokenName_Right_GUIDRel]

(

	@GUID_Token_Left uniqueidentifier,

	@Name_Token_Right varchar(255),

	@GUID_Type_Right uniqueidentifier,

	@GUID_RelationType	uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE     (semtbl_Token_Left.GUID_Token = @GUID_Token_Left) AND (semtbl_Token_Right.GUID_Type = @GUID_Type_Right) AND (semtbl_Token_Right.Name_Token = @Name_Token_Right) AND 

                      (semtbl_RelationType.GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenTree_TopDown]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_TokenTree_TopDown]

	-- Add the parameters for the stored procedure here

	 @GUID_Type                  uniqueidentifier

    ,@GUID_RelationType          uniqueidentifier

    ,@GUID_Token_Filter          uniqueidentifier=null



AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	  IF @GUID_Token_Filter IS NULL

      BEGIN

            ;WITH hierarchy AS (

                  SELECT c.GUID_Token, c.Name_Token, c.GUID_Type, c_t.Name_Type, CAST(NULL AS uniqueidentifier) AS GUID_Token_Parent, 0 AS OrderID, 0 AS [level]

                  FROM semtbl_Token AS c

                  INNER JOIN semtbl_Type AS c_t ON c.GUID_Type = c_t.GUID_Type

                  LEFT OUTER JOIN (SELECT     semtbl_Token_Token.GUID_Token_Right

                  FROM         semtbl_Token INNER JOIN

                                                 semtbl_Token_Token ON semtbl_Token.GUID_Token = semtbl_Token_Token.GUID_Token_Left

                  WHERE     (semtbl_Token.GUID_Type = @GUID_Type) AND 

                                                 (semtbl_Token_Token.GUID_RelationType = @GUID_RelationType)) AS p ON c.GUID_Token = p.GUID_Token_Right

                  WHERE p.GUID_Token_Right IS NULL

                  AND c.GUID_Type=@GUID_Type



            UNION ALL



            SELECT c.GUID_Token, c.Name_Token, c.GUID_Type, c_t.Name_Type, p.GUID_Token AS GUID_Token_Parent, p_c.OrderID, p.[level]+1 AS [level]

            FROM hierarchy p

            INNER JOIN semtbl_Token_Token p_c on p.GUID_Token = p_c.GUID_Token_Left

            INNER JOIN semtbl_Token c ON p_c.GUID_Token_Right = c.GUID_Token

            INNER JOIN semtbl_Type AS c_t ON c.GUID_Type = c_t.GUID_Type

            WHERE p_c.GUID_RelationType = @GUID_RelationType

            AND c.GUID_Type = @GUID_Type)



            

            SELECT * 

            FROM Hierarchy

            ORDER BY OrderID, Name_Token

      END

      ELSE

      BEGIN

            ;WITH hierarchy AS (

                  SELECT p.GUID_Token, p.Name_Token, p.GUID_Type, c_t.Name_Type, CAST(NULL AS uniqueidentifier) AS GUID_Token_Parent, 0 AS OrderID, 0 AS [level]

                  FROM semtbl_Token p

                  INNER JOIN semtbl_Type AS c_t ON p.GUID_Type = c_t.GUID_Type

                  WHERE p.GUID_Token = @GUID_Token_Filter

            UNION ALL



            SELECT c.GUID_Token, c.Name_Token, c.GUID_Type, c_t.Name_Type, p.GUID_Token AS GUID_Token_Parent, p_c.OrderID, p.[level]+1 AS [level]

            FROM hierarchy p

            INNER JOIN semtbl_Token_Token p_c on p.GUID_Token = p_c.GUID_Token_Left

            INNER JOIN semtbl_Token c ON p_c.GUID_Token_Right = c.GUID_Token

            INNER JOIN semtbl_Type AS c_t ON c.GUID_Type = c_t.GUID_Type

            WHERE p_c.GUID_RelationType = @GUID_RelationType

            AND c.GUID_Type = @GUID_Type)

            

            SELECT * 

            FROM Hierarchy

            ORDER BY orderID, Name_Token

      END



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semfunc_Token_Attribute]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION semfunc_Token_Attribute 
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token_Attribute.GUID_TokenAttribute, semtbl_Attribute.GUID_Attribute, semtbl_Attribute.Name_Attribute, semtbl_Attribute.GUID_AttributeType, 
                      semtbl_Token.GUID_Token, semtbl_Token.Name_Token, semtbl_Token.GUID_Type
FROM         semtbl_Token_Attribute INNER JOIN
                      semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
                      semtbl_Token ON semtbl_Token_Attribute.GUID_Token = semtbl_Token.GUID_Token
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_OR_RelationType]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_OR_RelationType]

(

	-- Add the parameters for the function here

	@GUID_ObjectReference	uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxObjectReference int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxObjectReference = (SELECT  TOP 1   [Version] AS MaxVersion

		FROM         chngtbll_OR_RelationType

		WHERE     (GUID_DB = @GUID_DB) AND (GUID_ObjectReference = @GUID_ObjectReference)

		ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxObjectReference



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenToken_Right_Tokens_By_GUID_Token_Left]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenToken_Right_Tokens_By_GUID_Token_Left]

(

	@GIUD_Token_Left uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Token_Left, GUID_Token_Right, GUID_RelationType, OrderID

FROM            semtbl_Token_Token

WHERE        (GUID_Token_Left = @GIUD_Token_Left)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[typeproc_Type_Rel_By_TypeGUIDRight]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[typeproc_Type_Rel_By_TypeGUIDRight]

(

	@GUID_Type_Right uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     GUID_Type_Left, Name_Type_Left, GUID_Type_Parent_Left, GUID_RelationType, Name_RelationType, GUID_Type_Right, Name_Type_Right, 

                      GUID_Type_Parent_Right, Min_forw, Max_forw, Max_backw

FROM         dbo.typefunc_Types_Rel() AS typefunc_Types_Rel_1

WHERE     (GUID_Type_Right = @GUID_Type_Right)

ORDER BY Name_Type_Left'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_OR_Token_By_GUIDObjectReference]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_OR_Token_By_GUIDObjectReference

	-- Add the parameters for the stored procedure here

	@GUID_ObjectReference		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     semtbl_OR_Token.GUID_ObjectReference, semtbl_Token.GUID_Token, semtbl_Token.Name_Token, semtbl_Token.GUID_Type

FROM         semtbl_OR_Token INNER JOIN

                      semtbl_Token ON semtbl_OR_Token.GUID_Token = semtbl_Token.GUID_Token

WHERE     (semtbl_OR_Token.GUID_ObjectReference = @GUID_ObjectReference)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_Type_OR]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_Type_OR]

(

	-- Add the parameters for the function here

	@GUID_Type_Left		uniqueidentifier,

	@GUID_RelationType		uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxObjectReference int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxObjectReference = (SELECT  TOP 1   [Version] AS MaxVersion

FROM         chngtbll_Type_OR

WHERE     (GUID_DB = @GUID_DB) AND (GUID_RelationType = @GUID_RelationType) AND (GUID_Type = @GUID_Type_Left)

ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxObjectReference



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_Token_OR]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_Token_OR]

(

	-- Add the parameters for the function here

	@GUID_Token_Left		uniqueidentifier,

	@GUID_ObjectReference	uniqueidentifier,

	@GUID_RelationType		uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxObjectReference int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxObjectReference = (SELECT  TOP 1   [Version] AS MaxVersion

FROM         chngtbll_Token_OR

WHERE     (GUID_DB = @GUID_DB) AND (GUID_ObjectReference = @GUID_ObjectReference) AND (GUID_Token_Left = @GUID_Token_Left) AND 

                      (GUID_RelationType = @GUID_RelationType)

ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxObjectReference



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_DBWork_Save_OR_Type]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_DBWork_Save_OR_Type]

	-- Add the parameters for the stored procedure here

		@GUID_Ref			uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	

	DECLARE @GUID_ObjectReference	uniqueidentifier;

	DECLARE @Name_Token				varchar(255);

	DECLARE @GUID_ItemType			uniqueidentifier;

	DECLARE @intCount				int;



	-- Typ-Abhängig (Type

	SET @GUID_ItemType = dbo.func_GUID_ORType_Type()

	SET @intCount = (SELECT     COUNT(*) AS Count_Type

		FROM         semtbl_Type

		WHERE    (GUID_Type = @GUID_Ref));

	-- Typ-Abhängig (Type



	IF @intCount > 0

	BEGIN

		-- Typ-Abhängig (Token

		SET @GUID_ObjectReference = (SELECT     GUID_ObjectReference

			FROM         semtbl_OR_Type

			WHERE     (GUID_Type = @GUID_Ref));

		-- Typ-Abhängig (Token



		IF @GUID_ObjectReference is null

		BEGIN

			SET @GUID_ObjectReference=newid();

			INSERT INTO semtbl_OR VALUES (@GUID_ObjectReference,@GUID_ItemType);



			-- Typ-Abhängig (Type

			INSERT INTO semtbl_OR_Type VALUES(@GUID_ObjectReference,@GUID_Ref);

			-- Typ-Abhängig (Type



			SELECT *,@GUID_ObjectReference AS GUID_ObjectReference FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

		ELSE

		BEGIN

			SELECT *,@GUID_ObjectReference AS GUID_ObjectReference FROM dbo.semfunc_LogStates() WHERE Name_Token=''Exists'';

		END

		

	END

	ELSE

	BEGIN

		SELECT *,null AS GUID_ObjectReference FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

	END

	

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenToken_By_GUIDs]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_TokenToken_By_GUIDs 

	-- Add the parameters for the stored procedure here

	@GUID_Token_Left	uniqueidentifier,

	@GUID_Token_Right	uniqueidentifier,

	@GUID_RelationType	uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     GUID_Token_Left, GUID_Token_Right, GUID_RelationType, OrderID

FROM         semtbl_Token_Token

WHERE     (GUID_Token_Left = @GUID_Token_Left) AND (GUID_Token_Right = @GUID_Token_Right) AND (GUID_RelationType = @GUID_RelationType)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenToken_Count_By_GUIDs]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.proc_TokenToken_Count_By_GUIDs

(

	@GUID_Token_Left uniqueidentifier,

	@GUID_Token_Right uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        COUNT(*) AS Count_Items

FROM            semtbl_Token_Token

WHERE        (GUID_Token_Left = @GUID_Token_Left) AND (GUID_Token_Right = @GUID_Token_Right) AND (GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_By_GUIDType_And_GUIDAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_TokenAttribute_By_GUIDType_And_GUIDAttribute

	-- Add the parameters for the stored procedure here

	@GUID_Attribute		uniqueidentifier,

	@GUID_Type			uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     semtbl_Token.GUID_Token, semtbl_Token.Name_Token, semtbl_Token.GUID_Type, semtbl_Token_Attribute.GUID_TokenAttribute

FROM         semtbl_Token INNER JOIN

                      semtbl_Token_Attribute ON semtbl_Token.GUID_Token = semtbl_Token_Attribute.GUID_Token

WHERE     (semtbl_Token.GUID_Type = @GUID_Type) AND (semtbl_Token_Attribute.GUID_Attribute = @GUID_Attribute)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_LogState_Delete]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_LogState_Delete] 

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     semfunc_LogStates_1.*

FROM         dbo.semfunc_LogStates() AS semfunc_LogStates_1

WHERE     (Name_Token = ''Delete'')

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Attribute_With_Type_By_GUIDAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE Attribute_With_Type_By_GUIDAttribute

	-- Add the parameters for the stored procedure here

	@GUID_Attribute			uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     Attribute_List_With_TypeName_1.*

		FROM         dbo.Attribute_List_With_TypeName() AS Attribute_List_With_TypeName_1

		WHERE     (GUID_Attribute = @GUID_Attribute)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenToken_RightLeft_By_GUIDType_Left_And_RelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenToken_RightLeft_By_GUIDType_Left_And_RelationType]

(

	@GUID_Type_Right uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     semtbl_Token_Left.GUID_Token AS GUID_Token_Left, semtbl_Token_Left.Name_Token AS Name_Token_Left, semtbl_Token_Left.GUID_Type AS GUID_Type_Left, 

                      semtbl_Token_Right.GUID_Token AS GUID_Token_Right, semtbl_Token_Right.Name_Token AS Name_Token_Right, semtbl_Token_Right.GUID_Type AS GUID_Type_Right, 

                      semtbl_Token_Token.GUID_RelationType, semtbl_Token_Token.OrderID, semtbl_Type_Left.Name_Type AS Name_Type_Left, 

                      semtbl_Type_Right.Name_Type AS Name_Type_Right, Name_RelationType

FROM         semtbl_Token_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Left ON semtbl_Token_Token.GUID_Token_Left = semtbl_Token_Left.GUID_Token INNER JOIN

                      semtbl_Token AS semtbl_Token_Right ON semtbl_Token_Token.GUID_Token_Right = semtbl_Token_Right.GUID_Token INNER JOIN

                      semtbl_Type AS semtbl_Type_Left ON semtbl_Token_Left.GUID_Type = semtbl_Type_Left.GUID_Type INNER JOIN

                      semtbl_Type AS semtbl_Type_Right ON semtbl_Token_Right.GUID_Type = semtbl_Type_Right.GUID_Type INNER JOIN

                      semtbl_RelationType ON semtbl_Token_Token.GUID_RelationType = semtbl_RelationType.GUID_RelationType

WHERE        (semtbl_Type_Right.GUID_Type = @GUID_Type_Right) AND (semtbl_RelationType.GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_Type_OR]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_Type_OR] 

	-- Add the parameters for the stored procedure here

	@GUID_Type				uniqueidentifier,

	@GUID_RelationType		uniqueidentifier,

	@intMin_forw			int,

	@intMax_forw			int

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Type_DB		uniqueidentifier;

	DECLARE @GUID_RelationType_DB	uniqueidentifier;

	DECLARE @intMin_forw_DB			int;

	DECLARE @intMax_forw_DB			int;

	DECLARE	@bitMin_forw			bit;

	DECLARE @bitMax_forw			bit;

	DECLARE @bitChange				bit;



    -- Insert statements for procedure here

	DECLARE cur_Token_Rel CURSOR FOR

		SELECT     GUID_Type, GUID_RelationType, Min_forw, Max_forw

FROM         semtbl_Type_OR

WHERE     (GUID_Type = @GUID_Type) AND (GUID_RelationType = @GUID_RelationType)



	OPEN cur_Token_Rel;

	FETCH NEXT FROM cur_Token_Rel INTO

		@GUID_Type_DB,

		@GUID_RelationType_DB,

		@intMin_forw_DB,

		@intMax_forw_DB;



	IF @@FETCH_STATUS=0 

	BEGIN

		

		If @intMin_forw <> @intMin_forw_db

		BEGIN

			SET @bitMin_forw = 1;	

		END

		ELSE

		BEGIN

			SET @bitMin_forw = 0;

		END

		If @intMax_forw <> @intMax_forw_db

		BEGIN

			SET @bitMax_forw = 1;	

		END

		ELSE

		BEGIN

			SET @bitMax_forw = 0;

		END

		

		IF @bitMin_forw=1 And @bitMax_forw=1

			UPDATE semtbl_Type_OR SET Min_forw=@intMin_forw,Max_forw=@intMax_forw

				WHERE     (GUID_Type = @GUID_Type) AND (GUID_RelationType = @GUID_RelationType);

		IF @bitMin_forw=1 And @bitMax_forw=0

			UPDATE semtbl_Type_OR SET Min_forw=@intMin_forw

				WHERE     (GUID_Type = @GUID_Type) AND (GUID_RelationType = @GUID_RelationType);

		IF @bitMin_forw=0 And @bitMax_forw=1

			UPDATE semtbl_Type_OR SET Max_forw=@intMax_forw

				WHERE     (GUID_Type = @GUID_Type) AND (GUID_RelationType = @GUID_RelationType);

		If @bitChange=1

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

		ELSE

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

	END

	ELSE

	BEGIN

		INSERT INTO semtbl_Type_OR VALUES (@GUID_Type,@GUID_RelationType,@intMin_forw,@intMax_forw);

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

	END

	CLOSE cur_Token_Rel;

	DEALLOCATE cur_Token_Rel;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[typeproc_Type_Rel_By_TypeGUIDLeft]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.typeproc_Type_Rel_By_TypeGUIDLeft

(

	@GUID_Type_Left uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     GUID_Type_Left, Name_Type_Left, GUID_Type_Parent_Left, GUID_RelationType, Name_RelationType, GUID_Type_Right, Name_Type_Right, 

                      GUID_Type_Parent_Right, Min_forw, Max_forw, Max_backw

FROM         dbo.typefunc_Types_Rel() AS typefunc_Types_Rel_1

WHERE     (GUID_Type_Left = @GUID_Type_Left)

ORDER BY Name_Type_Right'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Del_RelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Del_RelationType]

	-- Add the parameters for the stored procedure here

	@GUID_RelationType	uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	DECLARE	@GUID_ObjectReference	uniqueidentifier;

	DECLARE @intCount				int;

	

	SET @intCount = (SELECT     COUNT(*) AS Count_RelationType

		FROM         semtbl_Type_Type

		WHERE     (GUID_RelationType = @GUID_RelationType));	

	IF @intCount=0

	BEGIN

		SET @intCount = (SELECT     COUNT(*) AS Count_TokenRel

			FROM         semtbl_Token_Token

			WHERE     (GUID_RelationType = @GUID_RelationType));

		IF @intCount = 0

		BEGIN

			SET @GUID_ObjectReference = (SELECT     GUID_Token

				FROM         semtbl_Token

				WHERE	(Name_Token = CAST(@GUID_RelationType AS VARCHAR(255))) 

					AND (GUID_Type = dbo.func_TypeGUID_ObjectReference()));

			IF NOT @GUID_ObjectReference IS NULL

			BEGIN

				SET @intCount = (SELECT     COUNT(*) AS Count_Rel_RightLeft

					FROM         semtbl_Token_Token

					WHERE     (GUID_Token_Right = @GUID_ObjectReference));

				-- weiter

				IF @intCount=0

				BEGIN

					DELETE FROM semtbl_Token_Token WHERE 

						GUID_Token_Left=@GUID_ObjectReference;

					DELETE FROM semtbl_Token WHERE

						GUID_Token=@GUID_ObjectReference;

					DELETE FROM semtbl_RelationType WHERE

						GUID_RelationType=@GUID_RelationType;

					SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

				END

				ELSE

				BEGIN

					SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

				END

			END

			ELSE

			BEGIN

				DELETE FROM semtbl_RelationType WHERE GUID_RelationType=@GUID_RelationType;

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Delete'';

			END

		END

		ELSE

		BEGIN

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

		END

	END

	ELSE

	BEGIN

		SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Relation'';

	END



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_DBWork_Save_TypeAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[semproc_DBWork_Save_TypeAttribute]

	-- Add the parameters for the stored procedure here

	@GUID_Type		uniqueidentifier,

	@GUID_Attribute	uniqueidentifier,

	@intMin			int,

	@intMax			int

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Type_DB		uniqueidentifier;

	DECLARE @GUID_Attribute_DB	uniqueidentifier;

	DECLARE @intMin_DB			int;

	DECLARE @intMax_DB			int;

	



    -- Insert statements for procedure here

	DECLARE cur_TypeAttribute CURSOR FOR

		SELECT     *

			FROM         semtbl_Type_Attribute

			WHERE     (GUID_Type = @GUID_Type) AND (GUID_Attribute = @GUID_Attribute);



	OPEN cur_TypeAttribute;

	FETCH NEXT FROM cur_TypeAttribute INTO

		@GUID_Type_DB,

		@GUID_Attribute_DB,

		@intMin_DB,

		@intMax_DB

	IF @@FETCH_STATUS=0

	BEGIN

		If NOT @intMin=@intMin_DB

		BEGIN

			IF NOT @intMax=@intMax_DB

			BEGIN

				UPDATE semtbl_Type_Attribute 

					SET [Min]=@intMin,[Max]=@intMax

					WHERE	GUID_Type		=@GUID_Type 

						AND GUID_Attribute	=@GUID_Attribute;

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

			END

			ELSE

			BEGIN

				UPDATE semtbl_Type_Attribute 

					SET [Min]=@intMin

					WHERE	GUID_Type		=@GUID_Type 

						AND GUID_Attribute	=@GUID_Attribute;

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

			END

		END

		ELSE

		BEGIN

			IF NOT @intMax=@intMax_DB

			BEGIN

				UPDATE semtbl_Type_Attribute 

					SET [Max]=@intMax

					WHERE	GUID_Type		=@GUID_Type 

						AND GUID_Attribute	=@GUID_Attribute;

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Update'';

			END	

			ELSE

			BEGIN

				SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Nothing'';

			END

		END

	END

	ELSE

	BEGIN

		SET @GUID_Type_DB = (SELECT GUID_Type FROM semtbl_Type WHERE GUID_Type=@GUID_Type);

		SET @GUID_Attribute_DB = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE GUID_Attribute=@GUID_Attribute);

		If @GUID_Type_DB IS NULL OR @GUID_Attribute_DB IS NULL

		BEGIN

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Error'';

		END

		ELSE

		BEGIN

			INSERT INTO semtbl_Type_Attribute VALUES (@GUID_Type,@GUID_Attribute,@intMin, @intMax);

			SELECT * FROM dbo.semfunc_LogStates() WHERE Name_Token=''Insert'';

		END

		

	END

	CLOSE cur_TypeAttribute;

	DEALLOCATE cur_TypeAttribute;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[get_MaxVersion_Type_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date, ,>

-- Description:	<Description, ,>

-- =============================================

CREATE FUNCTION [dbo].[get_MaxVersion_Type_Type]

(

	-- Add the parameters for the function here

	@GUID_Type_Left			uniqueidentifier,

	@GUID_Type_Right		uniqueidentifier,

	@GUID_RelationType		uniqueidentifier,

	@GUID_DB				uniqueidentifier

)

RETURNS int

AS

BEGIN

	-- Declare the return variable here

	DECLARE @intMaxTypeRel int;



	-- Add the T-SQL statements to compute the return value here

	SET @intMaxTypeRel = (SELECT TOP 1 [Version] AS MaxVersion

FROM         chngtbll_Type_Rel

WHERE     (GUID_DB = @GUID_DB) AND (GUID_Type_left = @GUID_Type_Left) AND (GUID_Type_Right = @GUID_Type_Right) AND (GUID_RelationType = @GUID_RelationType)

ORDER BY [Version] DESC);



	-- Return the result of the function

	RETURN @intMaxTypeRel



END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_Token_Attribute_VARCHARMAX](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_Token_Attribute_VARCHARMAX_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_Token_Attribute_VARCHARMAX] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_semtbl_OR_Token_Attribute_VARCHARMAX] UNIQUE NONCLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_VARCHARMAX_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_VARCHARMAX] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_VARCHARMAX_semtbl_OR];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_VARCHARMAX_semtbl_Token_Attribute_varcharMAX] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_Attribute_varcharMAX] ([GUID_TokenAttribute])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_VARCHARMAX] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_VARCHARMAX_semtbl_Token_Attribute_varcharMAX];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_TokenToken_LeftRight_Hierarchical]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION func_TokenToken_LeftRight_Hierarchical
(	
	-- Add the parameters for the function here
	@GUID_Token_Left uniqueidentifier,
	@GUID_RelationType uniqueidentifier,
	@GUID_Type_Right uniqueidentifier,
	@TreeLevel int,
	@MaxDeep int,
	@OrderID int
	
)
RETURNS @treetbl_TokenToken_LeftRight TABLE
(
	GUID_Token uniqueidentifier,
	Name_Token varchar(255),
	GUID_Type uniqueidentifier,
	GUID_Token_Parent uniqueidentifier,
	TreeLevel int,
	OrderID int
)
AS
BEGIN
	DECLARE @treetbl_TokenToken_LeftRight_Child TABLE
	(
		GUID_Token uniqueidentifier,
		Name_Token varchar(255),
		GUID_Type uniqueidentifier,
		GUID_Token_Parent uniqueidentifier,
		TreeLevel int,
		OrderID int
	)
	DECLARE @GUID_Token uniqueidentifier, @Name_Token varchar(255), @GUID_Type uniqueidentifier, @GUID_Token_Parent uniqueidentifier;
	DECLARE @TreeLevel_tmp int, @OrderID_tmp int;
	DECLARE child_Token_cursor CURSOR  FOR
			SELECT * FROM @treetbl_TokenToken_LeftRight_Child;
	DECLARE root_Token_cursor CURSOR  FOR
		SELECT GUID_Token_Right, Name_Token_Right, GUID_Type_Right
			FROM dbo.func_TokenToken_LeftRigth_By_GUIDs(
					@GUID_Token_Left, 
					@GUID_RelationType, 
					@GUID_Type_Right) 
                      AS func_TokenToken_LeftRigth_By_GUIDs_1
			ORDER BY OrderID
	
	SET @TreeLevel = @TreeLevel + 1;
	
	OPEN root_Token_cursor;
	
	FETCH NEXT FROM root_Token_cursor INTO
		@GUID_Token,
		@Name_Token,
		@GUID_Type;
	
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @OrderID = @OrderID + 1;
		INSERT INTO @treetbl_TokenToken_LeftRight 
			VALUES (
				@GUID_Token,
				@Name_Token,
				@GUID_Type,
				@GUID_Token_Left,
				@TreeLevel,
				@OrderID);
		
		IF @MaxDeep = -1 OR @MaxDeep < @TreeLevel
		BEGIN
			DELETE FROM @treetbl_TokenToken_LeftRight_Child;
			INSERT INTO @treetbl_TokenToken_LeftRight_Child 
				SELECT *
				FROM dbo.func_TokenToken_LeftRight_Hierarchical
					(@GUID_Token,
					 @GUID_RelationType,
					 @GUID_Type_Right,
					 @TreeLevel,
					 @MaxDeep,
					 @OrderID);

			OPEN child_Token_cursor;

			
			FETCH NEXT FROM child_Token_cursor INTO
				@GUID_Token,
				@Name_Token,
				@GUID_Type,
				@GUID_Token_Parent,
				@TreeLevel_tmp,
				@OrderID_tmp;
			WHILE @@FETCH_STATUS = 0
			BEGIN
				INSERT INTO @treetbl_TokenToken_LeftRight 
					VALUES (
						@GUID_Token,
						@Name_Token,
						@GUID_Type,
						@GUID_Token_Parent,
						@TreeLevel_tmp,
						@OrderID_tmp);
				FETCH NEXT FROM child_Token_cursor INTO
					@GUID_Token,
					@Name_Token,
					@GUID_Type,
					@GUID_Token_Parent,
					@TreeLevel_tmp,
					@OrderID_tmp;
				SET @OrderID = @OrderID_tmp;
			END
			
			CLOSE child_Token_cursor;
		END
		
		
		
		FETCH NEXT FROM root_Token_cursor INTO
			@GUID_Token,
			@Name_Token,
			@GUID_Type;
		
	END
	CLOSE root_Token_cursor;
	DEALLOCATE root_Token_cursor;
	DEALLOCATE child_Token_cursor;
	RETURN
END



'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_Token_attribute_time]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_Token_attribute_time] 

   ON  [dbo].[semtbl_Token_attribute_time]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @dateVal				datetime;

	DECLARE @intVersion			int;

	DECLARe @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Delete'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_TokenAttribute,

		@dateVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_Time,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@dateVal,@GUID_Transaction);


			if @@ERROR=0

			BEGIN

				DELETE FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

			END	



			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_TokenAttribute,

			@dateVal,

			@intOrderID;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Bit]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_Token_Attribute_Bit](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_Token_Attribute_Bit_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_Token_Attribute] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_semtbl_OR_Token_Attribute_Bit] UNIQUE NONCLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Bit]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Bit] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_semtbl_OR];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Bit]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_semtbl_Token_Attribute] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_Attribute_Bit] ([GUID_TokenAttribute])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Bit] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_semtbl_Token_Attribute];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Datetime]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_Token_Attribute_Datetime](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_Token_Attribute_Datetime_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_Token_Attribute_Datetime] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_semtbl_OR_Token_Attribute_Datetime] UNIQUE NONCLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Datetime]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_Datetime_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Datetime] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_Datetime_semtbl_OR];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Datetime]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_Datetime_semtbl_Token_attribute_datetime] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_attribute_datetime] ([GUID_TokenAttribute])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Datetime] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_Datetime_semtbl_Token_attribute_datetime];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Token_OR_Count_By_GUIDToken_And_GUIDRelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_Token_OR_Count_By_GUIDToken_And_GUIDRelationType]

(

	@GUID_Token uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        COUNT(*) AS Count_ObjectReferences

FROM            dbo.func_Token_OR() AS func_Token_OR_1

WHERE        (GUID_Token_Left = @GUID_Token) AND (GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_Token_attribute_real]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_Token_attribute_real] 

   ON  [dbo].[semtbl_Token_Attribute_Real]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @realVal				real;

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@realVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_REAL,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@realVal,@GUID_Transaction);


			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@realVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_Token_attribute_varchar255]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_Token_attribute_varchar255] 

   ON  [dbo].[semtbl_Token_Attribute_varchar255]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @strVal				varchar(255);

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@strVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_VARCHAR255,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@strVal,@GUID_Transaction);

			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@strVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_attribute]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_attribute] 

   ON  [dbo].[semtbl_Attribute]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB			varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @Name_Attribute		varchar(255);

	DECLARE @GUID_AttributeType	uniqueidentifier;

	DECLARE @intVersion			int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Attribute,

		@Name_Attribute,

		@GUID_AttributeType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Attribute(@GUID_Attribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Attribute VALUES(@intVersion,@GUID_Attribute,@GUID_DB,@Name_Attribute,@GUID_AttributeType,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Attribute,

			@Name_Attribute,

			@GUID_AttributeType;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_Token_attribute_time]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_Token_attribute_time] 

   ON  [dbo].[semtbl_Token_attribute_time]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @dateVal				datetime;

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@dateVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_Time,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@dateVal,@GUID_Transaction);


			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@dateVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_Token_attribute_bit]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_Token_attribute_bit] 

   ON  [dbo].[semtbl_Token_Attribute_Bit]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @bitVal				bit;

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@bitVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_Attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute)

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_bit,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@bitVal,@GUID_Transaction);

			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@bitVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_Token_attribute_datetime]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_Token_attribute_datetime] 

   ON  [dbo].[semtbl_Token_attribute_datetime]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @dateVal				datetime;

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@dateVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_Datetime,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@dateVal,@GUID_Transaction);

			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@dateVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Time]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[TokenAttribute_Time]
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token.GUID_Token, semtbl_Token.Name_Token, semtbl_Token.GUID_Type, semtbl_Attribute.GUID_Attribute, semtbl_Attribute.Name_Attribute, 
                      semtbl_Attribute.GUID_AttributeType, semtbl_Token_attribute_time.val, semtbl_Token_attribute_time.OrderID, semtbl_Token_attribute_time.GUID_TokenAttribute
FROM         semtbl_Token_Attribute INNER JOIN
                      semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
                      semtbl_Token ON semtbl_Token_Attribute.GUID_Token = semtbl_Token.GUID_Token INNER JOIN
                      semtbl_Token_attribute_time ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_attribute_time.GUID_TokenAttribute
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_type]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_type] 

   ON  [dbo].[semtbl_Type]

   AFTER UPDATe

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_Type				uniqueidentifier;

	DECLARE @Name_Type				varchar(255);

	DECLARE @GUID_Type_Parent		uniqueidentifier;

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Type,

		@Name_Type,

		@GUID_Type_Parent;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Type(@GUID_Type,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			If NOT @GUID_Type_Parent IS NULL

				INSERT INTO chngtbll_Type VALUES(@intVersion,@GUID_Type,@GUID_DB,@Name_Type,@GUID_Type_Parent,@GUID_Transaction);

			ELSE

				INSERT INTO chngtbll_Type (Version,GUID_Type,GUID_DB,[Name],GUID_Transaction) VALUES(@intVersion,@GUID_Type,@GUID_DB,@Name_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Type,

			@Name_Type,

			@GUID_Type_Parent;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_RelationType]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_RelationType]

   ON  [dbo].[semtbl_OR_RelationType]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM Deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_RelationType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_RelationType(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_RelationType VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_RelationType,@GUID_Transaction);	

			DELETE FROM semtbl_OR WHERE GUID_ObjectReference=@GUID_ObjectReference;

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_RelationType;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_Token_attribute_int]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_Token_attribute_int] 

   ON  [dbo].[semtbl_Token_Attribute_Int]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @intVal				int;

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Delete'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_TokenAttribute,

		@intVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_INT,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@intVal,@GUID_Transaction);

			if @@ERROR=0

			BEGIN

				DELETE FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

			END	



			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_TokenAttribute,

			@intVal,

			@intOrderID;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Date]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_Token_Attribute_Date](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_Token_Attribute_Date_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_Token_Attribute_Date] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_semtbl_OR_Token_Attribute_Date] UNIQUE NONCLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Date]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_Date_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Date] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_Date_semtbl_OR];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Date]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_Date_semtbl_Token_Attribute_Date] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_Attribute_Date] ([GUID_TokenAttribute])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Date] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_Date_semtbl_Token_Attribute_Date];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_attributeType]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_attributeType] 

   ON  [dbo].[semtbl_AttributeType]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	

	DECLARE @GUID_AttributeType		uniqueidentifier;

	DECLARE @Name_AttributeType		varchar(255);

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_AttributeType,

		@Name_AttributeType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_AttributeType(@GUID_AttributeType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_AttributeType VALUES(@intVersion,@GUID_AttributeType,@GUID_DB,@Name_AttributeType,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_AttributeType,

		@Name_AttributeType;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Token_OR_By_GUIDToken_and_GUIDRelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Token_OR_By_GUIDToken_and_GUIDRelationType]

	-- Add the parameters for the stored procedure here

	@GUID_Token			uniqueidentifier,

	@GUID_RelationType	uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     *

FROM         dbo.func_Token_OR() AS func_Token_OR_1

WHERE     (GUID_Token_Left = @GUID_Token) AND (GUID_RelationType = @GUID_RelationType)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Real_Val_By_GUIDTokenAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Real_Val_By_GUIDTokenAttribute]

(

	@GUID_TokenAttribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_TokenAttribute, val, OrderID

FROM            semtbl_Token_Attribute_Real

WHERE        (GUID_TokenAttribute = @GUID_TokenAttribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_Type_OR]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_Type_OR]

   ON  [dbo].[semtbl_Type_OR]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Type					uniqueidentifier;

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @intMin_forw				int;

	DECLARE @intMax_forw				int;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Type,

		@GUID_RelationType,

		@intMin_forw,

		@intMax_forw;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Type_OR(@GUID_Type,@GUID_RelationType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Type_OR VALUES(@intVersion,@GUID_Type,@GUID_RelationType,@GUID_DB,@intMin_forw,@intMax_forw,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Type,

			@GUID_RelationType,

			@intMin_forw,

			@intMax_forw;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_token]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_token] 

   ON  [dbo].[semtbl_Token]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_Token				uniqueidentifier;

	DECLARE @Name_Token				varchar(255);

	DECLARE @GUID_Type				uniqueidentifier;

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Delete'');

	

	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_Token,

		@Name_Token,

		@GUID_Type;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_Token,

			@Name_Token,

			@GUID_Type;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_attribute]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_attribute] 

   ON  [dbo].[semtbl_Attribute]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB			varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @Name_Attribute		varchar(255);

	DECLARE @GUID_AttributeType	uniqueidentifier;

	DECLARE @intVersion			int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Delete'');

	

	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_Attribute,

		@Name_Attribute,

		@GUID_AttributeType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Attribute(@GUID_Attribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Attribute VALUES(@intVersion,@GUID_Attribute,@GUID_DB,@Name_Attribute,@GUID_AttributeType,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_Attribute,

			@Name_Attribute,

			@GUID_AttributeType;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_Token_attribute_varchar255]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_Token_attribute_varchar255] 

   ON  [dbo].[semtbl_Token_Attribute_varchar255]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @strVal				varchar(255);

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@strVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_VARCHAR255,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@strVal,@GUID_Transaction);

			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@strVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_type_attribute]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_type_attribute] 

   ON  [dbo].[semtbl_Type_Attribute]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_Type				uniqueidentifier;

	DECLARE @GUID_Attribute			uniqueidentifier;

	DECLARE @Name_Type				varchar(255);

	DECLARE @GUID_Type_Parent		uniqueidentifier;

	DECLARE @intMin					int;

	DECLARE @intMax					int;

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Type	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	SET @GUID_Transaction_Action_Type = dbo.get_GUID_Action(''Attribute Change'');	

	

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Type,

		@GUID_Attribute,

		@intMin,

		@intMax;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Type_Attribute(@GUID_Type,@GUID_Attribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Type_Attribute VALUES(@intVersion,@GUID_Type,@GUID_Attribute,@GUID_DB,@intMin,@intMax,@GUID_Transaction);

			

			DECLARE cur_Type CURSOR FOR

				SELECT Name_Type,GUID_Type_Parent

					FROM semtbl_Type

					WHERE (GUID_Type=@GUID_Type);

			OPEN cur_Type;

			FETCH NEXT FROM cur_Type INTO

				@Name_Type,

				@GUID_Type_Parent;

			CLOSE cur_Type;

			DEALLOCATE cur_Type;



			SET @intVersion = dbo.get_MaxVersion_Type(@GUID_Type,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Type,getdate());

			If NOT @GUID_Type_Parent IS NULL

				INSERT INTO chngtbll_Type VALUES(@intVersion,@GUID_Type,@GUID_DB,@Name_Type,@GUID_Type_Parent,@GUID_Transaction);

			ELSE

				INSERT INTO chngtbll_Type (Version,GUID_Type,GUID_DB,[Name],GUID_Transaction) VALUES(@intVersion,@GUID_Type,@GUID_DB,@Name_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Type,

			@GUID_Attribute,

			@intMin,

			@intMax;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_Type]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_Type]

   ON  [dbo].[semtbl_OR_Type]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_Type;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_Type(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_Type VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_Type,@GUID_Transaction);	

			DELETE FROM semtbl_OR WHERE GUID_ObjectReference=@GUID_ObjectReference;

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_Type;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Real]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[TokenAttribute_Real]
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token.GUID_Token, semtbl_Token.Name_Token, semtbl_Token.GUID_Type, semtbl_Attribute.GUID_Attribute, semtbl_Attribute.Name_Attribute, 
                      semtbl_Attribute.GUID_AttributeType, semtbl_Token_Attribute_Real.val, semtbl_Token_Attribute_Real.OrderID, 
                      semtbl_Token_Attribute_Real.GUID_TokenAttribute
FROM         semtbl_Token_Attribute INNER JOIN
                      semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
                      semtbl_Token ON semtbl_Token_Attribute.GUID_Token = semtbl_Token.GUID_Token INNER JOIN
                      semtbl_Token_Attribute_Real ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Real.GUID_TokenAttribute
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Varchar255]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[TokenAttribute_Varchar255]
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token.GUID_Token, semtbl_Token.Name_Token, semtbl_Token.GUID_Type, semtbl_Attribute.GUID_Attribute, semtbl_Attribute.Name_Attribute, 
                      semtbl_Attribute.GUID_AttributeType, semtbl_Token_Attribute_varchar255.val, semtbl_Token_Attribute_varchar255.OrderID, 
                      semtbl_Token_Attribute_varchar255.GUID_TokenAttribute
FROM         semtbl_Token_Attribute INNER JOIN
                      semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
                      semtbl_Token ON semtbl_Token_Attribute.GUID_Token = semtbl_Token.GUID_Token INNER JOIN
                      semtbl_Token_Attribute_varchar255 ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_varchar255.GUID_TokenAttribute
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[typeproc_Types_with_Attributs_and_Types_By_TypeGUID]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[typeproc_Types_with_Attributs_and_Types_By_TypeGUID]

(

	@GUID_Type uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     GUID_Type, Name_Type, GUID_Attribute, Name_Attribute, GUID_AttributeType, Name_AttributeType, Min, Max

FROM         dbo.typefunc_Types_With_Attributes_And_Types() AS typefunc_Types_With_Attributes_And_Types_1

WHERE     (GUID_Type = @GUID_Type)

ORDER BY Name_Attribute'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_Token_attribute_date]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_Token_attribute_date] 

   ON  [dbo].[semtbl_Token_Attribute_Date]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @dateVal				datetime;

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@dateVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_Date,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@dateVal,@GUID_Transaction);


			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@dateVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_Attribute]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_Attribute]

   ON  [dbo].[semtbl_OR_Attribute]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Attribute				uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_Attribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_Attribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_Attribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_Attribute,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_Attribute;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_Token_attribute_time]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_Token_attribute_time] 

   ON  [dbo].[semtbl_Token_attribute_time]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @dateVal				datetime;

	DECLARE @intVersion			int;

	DECLARe @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@dateVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_Time,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@dateVal,@GUID_Transaction);


			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@dateVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_Type_OR]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_Type_OR]

   ON  [dbo].[semtbl_Type_OR]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Type					uniqueidentifier;

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @intMin_forw				int;

	DECLARE @intMax_forw				int;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_Type,

		@GUID_RelationType,

		@intMin_forw,

		@intMax_forw;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Type_OR(@GUID_Type,@GUID_RelationType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Type_OR VALUES(@intVersion,@GUID_Type,@GUID_RelationType,@GUID_DB,@intMin_forw,@intMax_forw,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_Type,

			@GUID_RelationType,

			@intMin_forw,

			@intMax_forw;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_Token_attribute_date]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_Token_attribute_date] 

   ON  [dbo].[semtbl_Token_Attribute_Date]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @dateVal				datetime;

	DECLARE @intVersion			int;

	DECLARe @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Delete'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_TokenAttribute,

		@dateVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_Date,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@dateVal,@GUID_Transaction);


			if @@ERROR=0

			BEGIN

				DELETE FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

			END	



			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_TokenAttribute,

			@dateVal,

			@intOrderID;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Dateteime_Val_By_GUIDTokenAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Dateteime_Val_By_GUIDTokenAttribute]

(

	@GUID_TokenAttribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_TokenAttribute, val, OrderID

FROM            semtbl_Token_Attribute_Datetime

WHERE        (GUID_TokenAttribute = @GUID_TokenAttribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenToken_LeftRight_Max_OrderID_By_GUIDs]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.proc_TokenToken_LeftRight_Max_OrderID_By_GUIDs

(

	@GUID_Token_Left uniqueidentifier,

	@GUID_Type_Right uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        MAX(OrderID) AS Expr1

FROM            dbo.func_TokenToken() AS func_TokenToken_1

WHERE        (GUID_Token_Left = @GUID_Token_Left) AND (GUID_Type_Right = @GUID_Type_Right) AND (GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Varchar255]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_Token_Attribute_Varchar255](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_Token_Attribute_Varchar255_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_Token_Attribute_Varchar255] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_semtbl_OR_Token_Attribute_Varchar255] UNIQUE NONCLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Varchar255]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_Varchar255_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Varchar255] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_Varchar255_semtbl_OR];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Varchar255]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_Varchar255_semtbl_Token_Attribute_varchar255] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_Attribute_varchar255] ([GUID_TokenAttribute])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Varchar255] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_Varchar255_semtbl_Token_Attribute_varchar255];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_AttributeType]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_AttributeType]

   ON  [dbo].[semtbl_OR_AttributeType]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_AttributeType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_AttributeType(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_AttributeType VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_AttributeType,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_AttributeType;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_type_attribute]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_type_attribute] 

   ON  [dbo].[semtbl_Type_Attribute]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_Type				uniqueidentifier;

	DECLARE @GUID_Attribute			uniqueidentifier;

	DECLARE @Name_Type				varchar(255);

	DECLARE @GUID_Type_Parent		uniqueidentifier;

	DECLARE @intMin					int;

	DECLARE @intMax					int;

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Type	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Delete'');

	SET @GUID_Transaction_Action_Type = dbo.get_GUID_Action(''Attribute Change'');	



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_Type,

		@GUID_Attribute,

		@intMin,

		@intMax;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Type_Attribute(@GUID_Type,@GUID_Attribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Type_Attribute VALUES(@intVersion,@GUID_Type,@GUID_Attribute,@GUID_DB,@intMin,@intMax,@GUID_Transaction);

			

			DECLARE cur_Type CURSOR FOR

				SELECT Name_Type,GUID_Type_Parent

					FROM semtbl_Type

					WHERE (GUID_Type=@GUID_Type);

			OPEN cur_Type;

			FETCH NEXT FROM cur_Type INTO

				@Name_Type,

				@GUID_Type_Parent;

			CLOSE cur_Type;

			DEALLOCATE cur_Type;



			SET @intVersion = dbo.get_MaxVersion_Type(@GUID_Type,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Type,getdate());

			If NOT @GUID_Type_Parent IS NULL

				INSERT INTO chngtbll_Type VALUES(@intVersion,@GUID_Type,@GUID_DB,@Name_Type,@GUID_Type_Parent,@GUID_Transaction);

			ELSE

				INSERT INTO chngtbll_Type (Version,GUID_Type,GUID_DB,[Name],GUID_Transaction) VALUES(@intVersion,@GUID_Type,@GUID_DB,@Name_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_Type,

			@GUID_Attribute,

			@intMin,

			@intMax;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Int]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[TokenAttribute_Int]
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token.GUID_Token, semtbl_Token.Name_Token, semtbl_Token.GUID_Type, semtbl_Attribute.GUID_Attribute, semtbl_Attribute.Name_Attribute, 
                      semtbl_Attribute.GUID_AttributeType, semtbl_Token_Attribute_Int.val, semtbl_Token_Attribute_Int.OrderID, semtbl_Token_Attribute_Int.GUID_TokenAttribute
FROM         semtbl_Token_Attribute INNER JOIN
                      semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
                      semtbl_Token ON semtbl_Token_Attribute.GUID_Token = semtbl_Token.GUID_Token INNER JOIN
                      semtbl_Token_Attribute_Int ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Int.GUID_TokenAttribute
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[typeproc_Type_Attribute_By_GUIDs]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.typeproc_Type_Attribute_By_GUIDs

(

	@GUID_Type uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Type, Name_Type, GUID_Attribute, Name_Attribute, GUID_AttributeType, Name_AttributeType, Min, Max

FROM            dbo.typefunc_Types_With_Attributes_And_Types() AS typefunc_Types_With_Attributes_And_Types_1

WHERE        (GUID_Type = @GUID_Type) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Int]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_Token_Attribute_Int](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_Token_Attribute_Int_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_Token_Attribute_Int] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_semtbl_OR_Token_Attribute_Int] UNIQUE NONCLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Int]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_Int_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Int] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_Int_semtbl_OR];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Int]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_Int_semtbl_Token_Attribute_Int] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_Attribute_Int] ([GUID_TokenAttribute])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Int] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_Int_semtbl_Token_Attribute_Int]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_Token]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_Token]

   ON  [dbo].[semtbl_OR_Token]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM Deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_Token(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_Token VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_Token,@GUID_Transaction);	

			DELETE FROM semtbl_OR WHERE GUID_ObjectReference=@GUID_ObjectReference;

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_Token;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Int_Val_By_GUIDTokenAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Int_Val_By_GUIDTokenAttribute]

(

	@GUID_TokenAttribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_TokenAttribute, val, OrderID

FROM            semtbl_Token_Attribute_Int

WHERE        (GUID_TokenAttribute = @GUID_TokenAttribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Datetime]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[TokenAttribute_Datetime]
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token.GUID_Token, semtbl_Token.Name_Token, semtbl_Token.GUID_Type, semtbl_Attribute.GUID_Attribute, semtbl_Attribute.Name_Attribute, 
                      semtbl_Attribute.GUID_AttributeType, semtbl_Token_attribute_datetime.val, semtbl_Token_attribute_datetime.OrderID, 
                      semtbl_Token_attribute_datetime.GUID_TokenAttribute
FROM         semtbl_Token_Attribute INNER JOIN
                      semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
                      semtbl_Token ON semtbl_Token_Attribute.GUID_Token = semtbl_Token.GUID_Token INNER JOIN
                      semtbl_Token_attribute_datetime ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_attribute_datetime.GUID_TokenAttribute
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Token_OR_By_GUIDObjectReference_And_GUIDRelationType_And_GUID_Type]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_Token_OR_By_GUIDObjectReference_And_GUIDRelationType_And_GUID_Type

	-- Add the parameters for the stored procedure here

	@GUID_Type				uniqueidentifier,

	@GUID_RelationType		uniqueidentifier,

	@GUID_ObjectReference	uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     GUID_Token_Left, Name_Token_Left, Name_Type_Left, GUID_Type_Left, GUID_ObjectReference, GUID_RelationType, Name_RelationType, 

                      GUID_ObjectReferenceType, Name_ObjectReferenceType, GUID_Ref, Name_Ref, OrderID, GUID_ItemType

FROM         dbo.func_Token_OR() AS func_Token_OR_1

WHERE     (GUID_ObjectReference = @GUID_ObjectReference) AND (GUID_RelationType = @GUID_RelationType) AND (GUID_Type_Left = @GUID_Type)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_Token_OR]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_Token_OR]

   ON  [dbo].[semtbl_Token_OR]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Token_Left			uniqueidentifier;

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @intOrderID					int;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Token_Left,

		@GUID_ObjectReference,

		@GUID_RelationType,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Token_OR(@GUID_Token_Left,@GUID_ObjectReference,@GUID_RelationType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_OR VALUES(@intVersion,@GUID_Token_Left,@GUID_ObjectReference,@GUID_RelationType,@GUID_DB,@intOrderID,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Token_Left,

			@GUID_ObjectReference,

			@GUID_RelationType,

			@intOrderID;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_relationtype]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_relationtype] 

   ON  [dbo].[semtbl_RelationType]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_RelationType		uniqueidentifier;

	DECLARE @Name_RelationType				varchar(255);

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Delete'');

	

	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_RelationType,

		@Name_RelationType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_RelationType(@GUID_RelationType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_RelationType VALUES(@intVersion,@GUID_RelationType,@GUID_DB,@Name_RelationType,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_RelationType,

			@Name_RelationType;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Date_Val_By_GUIDTokenAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.proc_TokenAttribute_Date_Val_By_GUIDTokenAttribute

(

	@GUID_TokenAttribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_TokenAttribute, val, OrderID

FROM            semtbl_Token_Attribute_Date

WHERE        (GUID_TokenAttribute = @GUID_TokenAttribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_Token_attribute_varcharmax]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_Token_attribute_varcharmax] 

   ON  [dbo].[semtbl_Token_Attribute_varcharMAX]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @strVal				varchar(MAX);

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@strVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT        GUID_Token, GUID_Attribute

				FROM            semtbl_Token_Attribute

				WHERE        (GUID_TokenAttribute = @GUID_TokenAttribute)

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_VARCHARMAX,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@strVal,@GUID_Transaction);

			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@strVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_ModuleActivator_With_RelatedObjectReferences]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_ModuleActivator_With_RelatedObjectReferences]

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	

	DECLARE @GUID_Type_ModuleActivator		uniqueidentifier;

	DECLARE @GUID_RelationType_offersFor	uniqueidentifier;	



	SET @GUID_Type_ModuleActivator		= dbo.func_Named_GUIDType(''Module-Activator'');

	SET @GUID_RelationType_offersFor	= dbo.func_Named_GUIDRelationType(''offers for'');



	PRINT @GUID_Type_ModuleActivator;

	PRINT @GUID_RelationType_offersFor;



    -- Insert statements for procedure here

	SELECT * FROM func_ModuleActivator_With_RelatedObjectReferences(

		@GUID_Type_ModuleActivator,

		@GUID_RelationType_offersFor)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Date]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[TokenAttribute_Date]
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token.GUID_Token, semtbl_Token.Name_Token, semtbl_Token.GUID_Type, semtbl_Attribute.GUID_Attribute, semtbl_Attribute.Name_Attribute, 
                      semtbl_Attribute.GUID_AttributeType, semtbl_Token_Attribute_Date.val, semtbl_Token_Attribute_Date.OrderID, 
                      semtbl_Token_Attribute_Date.GUID_TokenAttribute
FROM         semtbl_Token_Attribute INNER JOIN
                      semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
                      semtbl_Token ON semtbl_Token_Attribute.GUID_Token = semtbl_Token.GUID_Token INNER JOIN
                      semtbl_Token_Attribute_Date ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Date.GUID_TokenAttribute
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenToken_RightLeft_Max_OrderID_By_GUIDs]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.proc_TokenToken_RightLeft_Max_OrderID_By_GUIDs

(

	@GUID_Token_Right uniqueidentifier,

	@GUID_Type_Left uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        MAX(OrderID) AS Expr1

FROM            dbo.func_TokenToken() AS func_TokenToken_1

WHERE        (GUID_Token_Right = @GUID_Token_Right) AND (GUID_Type_Left = @GUID_Type_Left) AND (GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_Token_attribute_varcharmax]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_Token_attribute_varcharmax] 

   ON  [dbo].[semtbl_Token_Attribute_varcharMAX]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @strVal				varchar(MAX);

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@strVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT        GUID_Token, GUID_Attribute

				FROM            semtbl_Token_Attribute

				WHERE        (GUID_TokenAttribute = @GUID_TokenAttribute)

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_VARCHARMAX,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@strVal,@GUID_Transaction);

			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@strVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_Token_attribute_bit]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_Token_attribute_bit] 

   ON  [dbo].[semtbl_Token_Attribute_Bit]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @bitVal				bit;

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@bitVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_Attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute)

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_Bit,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@bitVal,@GUID_Transaction);

			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@bitVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Token_OR_By_GUIDTypeLeft_and_GUIDRelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Token_OR_By_GUIDTypeLeft_and_GUIDRelationType]

	-- Add the parameters for the stored procedure here

	@GUID_Type_Left		uniqueidentifier,

	@GUID_RelationType	uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     *

FROM         dbo.func_Token_OR() AS func_Token_OR_1

WHERE     (GUID_Type_Left = @GUID_Type_Left) AND (GUID_RelationType = @GUID_RelationType)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_VarcharMax_Val_By_GUIDTokenAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_VarcharMax_Val_By_GUIDTokenAttribute]

(

	@GUID_TokenAttribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_TokenAttribute, val, OrderID

FROM            semtbl_Token_Attribute_VarcharMax

WHERE        (GUID_TokenAttribute = @GUID_TokenAttribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_TokenAttribute_Named_By_GUIDToken]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_TokenAttribute_Named_By_GUIDToken]
(	
	-- Add the parameters for the function here
	@GUID_Token		uniqueidentifier
)
RETURNS @tmptbl_TokenAttribute TABLE 
(
	GUID_Token			uniqueidentifier,
	GUID_Attribute		uniqueidentifier,
	Name_Attribute		varchar(255),
	GUID_AttributeType	uniqueidentifier,
	GUID_TokenAttribute	uniqueidentifier,
	VAL_Named			varchar(255),
	VAL_BOOL			bit,
	VAL_DATE			datetime,
	VAL_DATETIME		datetime,
	VAL_INT				int,
	VAL_REAL			real,
	VAL_TIME			datetime,
	VAL_VARCHAR255		varchar(255),
	VAL_VARCHARMAX		varchar(max),
	OrderID				int
)
AS
BEGIN
	
	INSERT INTO @tmptbl_TokenAttribute 
	SELECT  @GUID_Token AS GUID_Token,
			semtbl_Token_Attribute.GUID_Attribute, 
			semtbl_Attribute.Name_Attribute,
			semtbl_Attribute.GUID_AttributeType, 
			semtbl_Token_Attribute.GUID_TokenAttribute, 
			CASE WHEN semtbl_Token_Attribute_Bit.val=1 THEN ''True'' ELSE ''False'' END AS VAL_Named,
			semtbl_Token_Attribute_Bit.val AS VAL_BOOL,
			CAST (NULL AS DATETIME) AS VAL_Date,
			CAST (NULL AS DATETIME) AS VAL_Datetime,
			CAST (NULL AS INT) AS VAL_Int,
			CAST (NULL AS REAL) AS VAL_Real,
			CAST (NULL AS DATETIME) AS VAL_Time,
			CAST (NULL AS VARCHAR(255)) AS VAL_VARCHAR255,
			CAST (NULL AS VARCHAR(MAX)) AS VAL_VARCHARMAX,
			semtbl_Token_Attribute_Bit.OrderID
		FROM         semtbl_Token_Attribute INNER JOIN
							  semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
							  semtbl_Token_Attribute_Bit ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Bit.GUID_TokenAttribute
		WHERE     (semtbl_Token_Attribute.GUID_Token = @GUID_Token);

	INSERT INTO @tmptbl_TokenAttribute
	SELECT  @GUID_Token AS GUID_Token,
			semtbl_Token_Attribute.GUID_Attribute, 
			semtbl_Attribute.Name_Attribute,
			semtbl_Attribute.GUID_AttributeType, 
			semtbl_Token_Attribute.GUID_TokenAttribute, 
			CONVERT(varchar(255), semtbl_Token_Attribute_Date.val, 104) AS VAL_Named,
			CAST (NULL AS BIT) AS VAL_BOOL,
			semtbl_Token_Attribute_Date.val AS VAL_DATE,
			CAST (NULL AS DATETIME) AS VAL_Datetime,
			CAST (NULL AS INT) AS VAL_Int,
			CAST (NULL AS REAL) AS VAL_Real,
			CAST (NULL AS DATETIME) AS VAL_Time,
			CAST (NULL AS VARCHAR(255)) AS VAL_VARCHAR255,
			CAST (NULL AS VARCHAR(MAX)) AS VAL_VARCHARMAX,
			semtbl_Token_Attribute_Date.OrderID
		FROM         semtbl_Token_Attribute INNER JOIN
							  semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
							  semtbl_Token_Attribute_Date ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Date.GUID_TokenAttribute
		WHERE     (semtbl_Token_Attribute.GUID_Token = @GUID_Token);
	
	INSERT INTO @tmptbl_TokenAttribute
	SELECT  @GUID_Token AS GUID_Token,
			semtbl_Token_Attribute.GUID_Attribute, 
			semtbl_Attribute.Name_Attribute,
			semtbl_Attribute.GUID_AttributeType, 
			semtbl_Token_Attribute.GUID_TokenAttribute, 
			CONVERT(varchar(255), semtbl_Token_Attribute_Datetime.val, 113) AS VAL_NAMED, 
			CAST (NULL AS BIT) AS VAL_BOOL,
			CAST (NULL AS DATETIME) AS VAL_Date,
			semtbl_Token_Attribute_Datetime.val AS VAL_Datetime,
			CAST (NULL AS INT) AS VAL_Int,
			CAST (NULL AS REAL) AS VAL_Real,
			CAST (NULL AS DATETIME) AS VAL_Time,
			CAST (NULL AS VARCHAR(255)) AS VAL_VARCHAR255,
			CAST (NULL AS VARCHAR(MAX)) AS VAL_VARCHARMAX, 
			semtbl_Token_Attribute_Datetime.OrderID
		FROM         semtbl_Token_Attribute INNER JOIN
							  semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
							  semtbl_Token_Attribute_Datetime ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Datetime.GUID_TokenAttribute
		WHERE     (semtbl_Token_Attribute.GUID_Token = @GUID_Token);

	INSERT INTO @tmptbl_TokenAttribute
	SELECT  @GUID_Token AS GUID_Token,
			semtbl_Token_Attribute.GUID_Attribute, 
			semtbl_Attribute.Name_Attribute,
			semtbl_Attribute.GUID_AttributeType, 
			semtbl_Token_Attribute.GUID_TokenAttribute, 
			CONVERT(varchar(255), semtbl_Token_Attribute_Int.val) AS VAL_Named,
			CAST (NULL AS BIT) AS VAL_BOOL,
			CAST (NULL AS DATETIME) AS VAL_Date,
			CAST (NULL AS DATETIME) AS VAL_Datetime,
			semtbl_Token_Attribute_Int.val AS VAL_Int, 
			CAST (NULL AS REAL) AS VAL_Real,
			CAST (NULL AS DATETIME) AS VAL_Time,
			CAST (NULL AS VARCHAR(255)) AS VAL_VARCHAR255,
			CAST (NULL AS VARCHAR(MAX)) AS VAL_VARCHARMAX, 
			semtbl_Token_Attribute_Int.OrderID
		FROM         semtbl_Token_Attribute INNER JOIN
							  semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
							  semtbl_Token_Attribute_Int ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Int.GUID_TokenAttribute
		WHERE     (semtbl_Token_Attribute.GUID_Token = @GUID_Token);
		
	INSERT INTO @tmptbl_TokenAttribute
	SELECT  @GUID_Token AS GUID_Token,
			semtbl_Token_Attribute.GUID_Attribute, 
			semtbl_Attribute.Name_Attribute,
			semtbl_Attribute.GUID_AttributeType, 
			semtbl_Token_Attribute.GUID_TokenAttribute, 
			CONVERT(varchar(255), semtbl_Token_Attribute_Real.val) AS VAL_Named,
			CAST (NULL AS BIT) AS VAL_BOOL,
			CAST (NULL AS DATETIME) AS VAL_Date,
			CAST (NULL AS DATETIME) AS VAL_Datetime,
			CAST (NULL AS INT) AS VAL_Int,
			semtbl_Token_Attribute_Real.val AS VAL_Real,
			CAST (NULL AS DATETIME) AS VAL_Time,
			CAST (NULL AS VARCHAR(255)) AS VAL_VARCHAR255,
			CAST (NULL AS VARCHAR(MAX)) AS VAL_VARCHARMAX, 
			semtbl_Token_Attribute_Real.OrderID
		FROM         semtbl_Token_Attribute INNER JOIN
							  semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
							  semtbl_Token_Attribute_Real ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Real.GUID_TokenAttribute
		WHERE     (semtbl_Token_Attribute.GUID_Token = @GUID_Token)

	INSERT INTO @tmptbl_TokenAttribute
	SELECT  @GUID_Token AS GUID_Token,
			semtbl_Token_Attribute.GUID_Attribute, 
			semtbl_Attribute.Name_Attribute,
			semtbl_Attribute.GUID_AttributeType, 
			semtbl_Token_Attribute.GUID_TokenAttribute, 
			CONVERT(varchar(252),semtbl_Token_Attribute_varcharMAX.val) AS VAL_Named,
			CAST (NULL AS BIT) AS VAL_BOOL,
			CAST (NULL AS DATETIME) AS VAL_Date,
			CAST (NULL AS DATETIME) AS VAL_Datetime,
			CAST (NULL AS INT) AS VAL_Int,
			CAST (NULL AS REAL) AS VAL_Real,
			CAST (NULL AS DATETIME) AS VAL_Time,
			CAST (NULL AS VARCHAR(255)) AS VAL_VARCHAR255,
			semtbl_Token_Attribute_varcharMAX.val AS VAL_VARCHARMAX, 
			semtbl_Token_Attribute_varcharMAX.OrderID
		FROM         semtbl_Token_Attribute INNER JOIN
							  semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
							  semtbl_Token_Attribute_varcharMAX ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_varcharMAX.GUID_TokenAttribute
		WHERE     (semtbl_Token_Attribute.GUID_Token = @GUID_Token)

	INSERT INTO @tmptbl_TokenAttribute
	SELECT  @GUID_Token AS GUID_Token,
			semtbl_Token_Attribute.GUID_Attribute, 
			semtbl_Attribute.Name_Attribute,
			semtbl_Attribute.GUID_AttributeType, 
			semtbl_Token_Attribute.GUID_TokenAttribute, 
			CONVERT(varchar(255), semtbl_Token_Attribute_Time.val, 8) AS VAL_Named,
			CAST (NULL AS BIT) AS VAL_BOOL,
			CAST (NULL AS DATETIME) AS VAL_Date,
			CAST (NULL AS DATETIME) AS VAL_Datetime,
			CAST (NULL AS INT) AS VAL_Int,
			CAST (NULL AS REAL) AS VAL_Real,
			semtbl_Token_Attribute_Time.val AS VAL_Time,
			CAST (NULL AS VARCHAR(255)) AS VAL_VARCHAR255,
			CAST (NULL AS VARCHAR(MAX)) AS VAL_VARCHARMAX, 
			semtbl_Token_Attribute_Time.OrderID
		FROM         semtbl_Token_Attribute INNER JOIN
							  semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
							  semtbl_Token_Attribute_Time ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Time.GUID_TokenAttribute
		WHERE     (semtbl_Token_Attribute.GUID_Token = @GUID_Token)

	INSERT INTO @tmptbl_TokenAttribute
	SELECT  @GUID_Token AS GUID_Token,
			semtbl_Token_Attribute.GUID_Attribute, 
			semtbl_Attribute.Name_Attribute,
			semtbl_Attribute.GUID_AttributeType, 
			semtbl_Token_Attribute.GUID_TokenAttribute, 
			semtbl_Token_Attribute_varchar255.val AS VAL_Named,
			CAST (NULL AS BIT) AS VAL_BOOL,
			CAST (NULL AS DATETIME) AS VAL_Date,
			CAST (NULL AS DATETIME) AS VAL_Datetime,
			CAST (NULL AS INT) AS VAL_Int,
			CAST (NULL AS REAL) AS VAL_Real,
			CAST (NULL AS DATETIME) AS VAL_Time,
			semtbl_Token_Attribute_varchar255.val AS VAL_VARCHAR255,
			CAST (NULL AS VARCHAR(MAX)) AS VAL_VARCHARMAX, 
			semtbl_Token_Attribute_varchar255.OrderID
		FROM         semtbl_Token_Attribute INNER JOIN
							  semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
							  semtbl_Token_Attribute_varchar255 ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_varchar255.GUID_TokenAttribute
		WHERE     (semtbl_Token_Attribute.GUID_Token = @GUID_Token)
	

	RETURN
END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_Token_attribute_datetime]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_Token_attribute_datetime] 

   ON  [dbo].[semtbl_Token_attribute_datetime]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @dateVal				datetime;

	DECLARE @intVersion			int;

	DECLARe @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@dateVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_Datetime,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@dateVal,@GUID_Transaction);

			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@dateVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_Token_attribute_datetime]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_Token_attribute_datetime] 

   ON  [dbo].[semtbl_Token_attribute_datetime]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @dateVal				datetime;

	DECLARE @intVersion			int;

	DECLARe @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Delete'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_TokenAttribute,

		@dateVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_Datetime,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@dateVal,@GUID_Transaction);

			if @@ERROR=0

			BEGIN

				DELETE FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

			END	



			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_TokenAttribute,

			@dateVal,

			@intOrderID;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semproc_TokenAttribute_By_GUID_Attribute_And_GUID_Type]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.semproc_TokenAttribute_By_GUID_Attribute_And_GUID_Type

(

	@GUID_Attribute uniqueidentifier,

	@GUID_Type uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_TokenAttribute, GUID_Attribute, Name_Attribute, GUID_AttributeType, GUID_Token, Name_Token, GUID_Type

FROM            dbo.semfunc_Token_Attribute() AS semfunc_Token_Attribute_1

WHERE        (GUID_Attribute = @GUID_Attribute) AND (GUID_Type = @GUID_Type)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenToken_RightLeft_Max_OrderID]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.proc_TokenToken_RightLeft_Max_OrderID

(

	@GUID_Token_Right uniqueidentifier,

	@GUID_Type_Left uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        MAX(OrderID) AS Expr1

FROM            dbo.func_TokenToken() AS func_TokenToken_1

WHERE        (GUID_Token_Right = @GUID_Token_Right) AND (GUID_Type_Left = @GUID_Type_Left)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_related_TokenAttribute_BOOL]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE FUNCTION func_related_TokenAttribute_BOOL 

(	

	-- Add the parameters for the function here

	@GUID_Attribute		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     semtbl_Token_Attribute.GUID_Token, semtbl_Token_Attribute.GUID_Attribute, semtbl_Token_Attribute_Bit.GUID_TokenAttribute, semtbl_Token_Attribute_Bit.val

FROM         semtbl_Token_Attribute INNER JOIN

                      semtbl_Token_Attribute_Bit ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Bit.GUID_TokenAttribute

WHERE     (semtbl_Token_Attribute.GUID_Attribute = @GUID_Attribute)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_TokenToken]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_TokenToken]

   ON  [dbo].[semtbl_OR_Token_Token]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Token_Left			uniqueidentifier;

	DECLARE @GUID_Token_Right			uniqueidentifier;

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_Token_Left,

		@GUID_Token_Right,

		@GUID_RelationType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenToken(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenToken VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_Token_Left,@GUID_Token_Right,@GUID_RelationType,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_Token_Left,

			@GUID_Token_Right,

			@GUID_RelationType;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_Token_attribute_varchar255]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_Token_attribute_varchar255] 

   ON  [dbo].[semtbl_Token_Attribute_varchar255]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @strVal				varchar(255);

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Delete'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_TokenAttribute,

		@strVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_VARCHAR255,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@strVal,@GUID_Transaction);

			if @@ERROR=0

			BEGIN

				DELETE FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

			END	



			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_TokenAttribute,

			@strVal,

			@intOrderID;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngproc_Max_Version_Type]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE chngproc_Max_Version_Type 

	-- Add the parameters for the stored procedure here

	@GUID_Type	uniqueidentifier,

	@GUID_DB	uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT dbo.get_MaxVersion_Type(@GUID_Type,@GUID_DB) AS Version_Type

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Token_OR_By_GUIDObjectReference]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_Token_OR_By_GUIDObjectReference

	-- Add the parameters for the stored procedure here

	@GUID_ObjectReference	uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     GUID_Token_Left, Name_Token_Left, Name_Type_Left, GUID_Type_Left, GUID_ObjectReference, GUID_RelationType, Name_RelationType, 

                      GUID_ObjectReferenceType, Name_ObjectReferenceType, GUID_Ref, Name_Ref, OrderID, GUID_ItemType

FROM         dbo.func_Token_OR() AS func_Token_OR_1

WHERE     (GUID_ObjectReference = @GUID_ObjectReference)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_relationtype]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_relationtype] 

   ON  [dbo].[semtbl_RelationType]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_RelationType		uniqueidentifier;

	DECLARE @Name_RelationType				varchar(255);

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_RelationType,

		@Name_RelationType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_RelationType(@GUID_RelationType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_RelationType VALUES(@intVersion,@GUID_RelationType,@GUID_DB,@Name_RelationType,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_RelationType,

			@Name_RelationType;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_Attribute]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_Attribute]

   ON  [dbo].[semtbl_OR_Attribute]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Attribute				uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_Attribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_Attribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_Attribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_Attribute,@GUID_Transaction);	

			DELETE FROM semtbl_OR WHERE GUID_ObjectReference=@GUID_ObjectReference;

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_Attribute;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_Token_attribute_bit]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_Token_attribute_bit] 

   ON  [dbo].[semtbl_Token_Attribute_Bit]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @bitVal				bit;

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Delete'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_TokenAttribute,

		@bitVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_Attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute)

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_Bit,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@bitVal,@GUID_Transaction);

			if @@ERROR=0

			BEGIN

				DELETE FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

			END			



			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_TokenAttribute,

			@bitVal,

			@intOrderID;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Modules_With_Rels]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_Modules_With_Rels] 

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Type_Module					uniqueidentifier;

	DECLARE @GUID_Type_IntegrationLevel			uniqueidentifier;

	DECLARE @GUID_Type_Folder					uniqueidentifier;

	DECLARE @GUID_Type_SoftwareDevelopment		uniqueidentifier;

	DECLARE @GUID_RelationType_isOn				uniqueidentifier;

	DECLARE @GUID_RelationType_SourcesLocatedIn	uniqueidentifier;

	DECLARE @GUID_RelationType_offeredBy		uniqueidentifier;



	SET @GUID_Type_Module					= dbo.func_Named_GUIDType(''Module'');

	SET @GUID_Type_IntegrationLevel			= dbo.func_Named_GUIDType(''Integration-Level'');

	SET @GUID_Type_Folder					= dbo.func_Named_GUIDType(''Folder'');

	SET @GUID_Type_SoftwareDevelopment		= dbo.func_Named_GUIDType(''Software-Development'');

	SET @GUID_RelationType_isOn				= dbo.func_Named_GUIDRelationType(''is on''); 

	SET @GUID_RelationType_SourcesLocatedIn	= dbo.func_Named_GUIDRelationType(''sources located in'');

	SET @GUID_RelationType_offeredBy		= dbo.func_Named_GUIDRelationType(''offered by'');



	PRINT @GUID_Type_Module;

	PRINT @GUID_Type_IntegrationLevel;

	PRINT @GUID_Type_Folder;

	PRINT @GUID_Type_SoftwareDevelopment;

	PRINT @GUID_RelationType_isOn;

	PRINT @GUID_RelationType_SourcesLocatedIn;

	PRINT @GUID_RelationType_offeredBy;



    -- Insert statements for procedure here

	SELECT * FROM func_Modules_With_Rels(

		@GUID_Type_Module,

		@GUID_Type_IntegrationLevel,

		@GUID_Type_Folder,

		@GUID_Type_SoftwareDevelopment,

		@GUID_RelationType_isOn,

		@GUID_RelationType_SourcesLocatedIn,

		@GUID_RelationType_offeredBy)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[typeproc_Types_with_Attributs_and_Types_By_AttributeGUID]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.typeproc_Types_with_Attributs_and_Types_By_AttributeGUID

(

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Type, Name_Type, GUID_Attribute, Name_Attribute, GUID_AttributeType, Name_AttributeType, Min, Max

FROM            dbo.typefunc_Types_With_Attributes_And_Types() AS typefunc_Types_With_Attributes_And_Types_1

WHERE        (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_SoftwareDevelopment_Config_By_GUIDDevelopment]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_SoftwareDevelopment_Config_By_GUIDDevelopment]

(

	@GUID_Development uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        *

FROM            dbo.func_SoftwareDevelopment_Config() AS func_SoftwareDevelopment_Config_1

WHERE        (GUID_Token_Development = @GUID_Development)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenToken_LeftRight_OR_By_GUIDToken_and_GUIDRelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenToken_LeftRight_OR_By_GUIDToken_and_GUIDRelationType]

(

	@GUID_Token_Left uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        *

FROM            dbo.func_TokenToken_OR_LeftRight() AS func_TokenToken_OR_LeftRight_1

WHERE        (GUID_Token_Left = @GUID_Token_Left) AND (GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TypeAttribute_Attributes_By_GUIDType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.TypeAttribute_Attributes_By_GUIDType

(

	@GUID_Type uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Type, Name_Type, GUID_Attribute, Name_Attribute, GUID_AttributeType, Name_AttributeType, Min, Max

FROM            dbo.typefunc_Types_With_Attributes_And_Types() AS typefunc_Types_With_Attributes_And_Types_1

WHERE        (GUID_Type = @GUID_Type)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Modules_With_Rels_By_GUIDModule]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_Modules_With_Rels_By_GUIDModule]

(

	@GUID_Type_Module uniqueidentifier,

	@GUID_Type_IntegrationLevel uniqueidentifier,

	@GUID_Type_Folder uniqueidentifier,

	@GUID_Type_SoftwareDevelopment uniqueidentifier,

	@GUID_RelationType_isOn uniqueidentifier,

	@GUID_RelationType_SourcesLocatedIn uniqueidentifier,

	@GUID_RelationType_offeredBy uniqueidentifier,

	@GUID_Module uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Module, Name_Module, GUID_Type_Module, GUID_IntegrationLevel, Name_IntegrationLevel, GUID_Type_IntegrationLevel, GUID_Folder, Name_Folder, 

                         GUID_Type_Folder, GUID_SoftwareDevelopment, Name_SoftwareDevelopment, GUID_Type_SoftwareDevelopment

FROM            dbo.func_Modules_With_Rels(@GUID_Type_Module, @GUID_Type_IntegrationLevel, @GUID_Type_Folder, @GUID_Type_SoftwareDevelopment, 

                         @GUID_RelationType_isOn, @GUID_RelationType_SourcesLocatedIn, @GUID_RelationType_offeredBy) AS func_Modules_With_Rels_1

WHERE        (GUID_Module = @GUID_Module)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_type_type]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_type_type] 

   ON  [dbo].[semtbl_Type_Type]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_Type_Left			uniqueidentifier;

	DECLARE @GUID_Type_Right		uniqueidentifier;

	DECLARE @GUID_RelationType		varchar(255);

	DECLARE @Name_Type				varchar(255);

	DECLARE @GUID_Type_Parent		uniqueidentifier;

	DECLARE @intMinForw				int;

	DECLARE @intMaxForw				int;

	DECLARE @intMaxBackw			int;

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction				uniqueidentifier;

	DECLARE @GUID_Transaction_Action		uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Type	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Delete'');

	SET @GUID_Transaction_Action_Type = dbo.get_GUID_Action(''Relation Change'');

	

	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_Type_Left,

		@GUID_Type_Right,

		@GUID_RelationType,

		@intMinForw,

		@intMaxForw,

		@intMaxBackw;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Type_Type(@GUID_Type_Left,@GUID_Type_Right,@GUID_RelationType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Type_Rel VALUES(@intVersion,@GUID_Type_Left,@GUID_Type_Right,@GUID_RelationType,@GUID_DB,@intMinForw,@intMaxForw,@intMaxBackw,@GUID_Transaction);

			

			DECLARE cur_Type CURSOR FOR

				SELECT Name_Type,GUID_Type_Parent

					FROM semtbl_Type

					WHERE (GUID_Type=@GUID_Type_Left);

			OPEN cur_Type;

			FETCH NEXT FROM cur_Type INTO

				@Name_Type,

				@GUID_Type_Parent;

			CLOSE cur_Type;

			DEALLOCATE cur_Type;



			SET @intVersion = dbo.get_MaxVersion_Type(@GUID_Type_Left,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Type,getdate());

			If NOT @GUID_Type_Parent IS NULL

				INSERT INTO chngtbll_Type VALUES(@intVersion,@GUID_Type_Left,@GUID_DB,@Name_Type,@GUID_Type_Parent,@GUID_Transaction);

			ELSE

				INSERT INTO chngtbll_Type (Version,GUID_Type,GUID_DB,[Name],GUID_Transaction) VALUES(@intVersion,@GUID_Type_Left,@GUID_DB,@Name_Type,@GUID_Transaction);



			DECLARE cur_Type CURSOR FOR

				SELECT Name_Type,GUID_Type_Parent

					FROM semtbl_Type 

					WHERE (GUID_Type=@GUID_Type_Right);

			OPEN cur_Type;

			FETCH NEXT FROM cur_Type INTO

				@Name_Type,

				@GUID_Type_Parent;

			CLOSE cur_Type;

			DEALLOCATE cur_Type;



			SET @intVersion = dbo.get_MaxVersion_Type(@GUID_Type_Right,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Type,getdate());

			If NOT @GUID_Type_Parent IS NULL

				INSERT INTO chngtbll_Type VALUES(@intVersion,@GUID_Type_Right,@GUID_DB,@Name_Type,@GUID_Type_Parent,@GUID_Transaction);

			ELSE

				INSERT INTO chngtbll_Type (Version,GUID_Type,GUID_DB,[Name],GUID_Transaction) VALUES(@intVersion,@GUID_Type_Right,@GUID_DB,@Name_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_Type_Left,

			@GUID_Type_Right,

			@GUID_RelationType,

			@intMinForw,

			@intMaxForw,

			@intMaxBackw;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Token_OR_By_GUIDTokenLeft]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.proc_Token_OR_By_GUIDTokenLeft

(

	@GUID_Token_Left uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_Token_Left, Name_Token_Left, Name_Type_Left, GUID_Type_Left, GUID_ObjectReference, GUID_RelationType, Name_RelationType, 

                         GUID_ObjectReferenceType, Name_ObjectReferenceType, GUID_Ref, Name_Ref, OrderID, GUID_ItemType

FROM            dbo.func_Token_OR() AS func_Token_OR_1

WHERE        (GUID_Token_Left = @GUID_Token_Left)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Time_Val_By_GUIDTokenAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Time_Val_By_GUIDTokenAttribute]

(

	@GUID_TokenAttribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_TokenAttribute, val, OrderID

FROM            semtbl_Token_Attribute_Time

WHERE        (GUID_TokenAttribute = @GUID_TokenAttribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_Token_attribute_real]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_Token_attribute_real] 

   ON  [dbo].[semtbl_Token_Attribute_Real]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @realVal				real;

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Delete'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_TokenAttribute,

		@realVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_REAL,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@realVal,@GUID_Transaction);


			if @@ERROR=0

			BEGIN

				DELETE FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

			END				



			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_TokenAttribute,

			@realVal,

			@intOrderID;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_Token_OR]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_Token_OR]

   ON  [dbo].[semtbl_Token_OR]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Token_Left			uniqueidentifier;

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @intOrderID					int;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Token_Left,

		@GUID_ObjectReference,

		@GUID_RelationType,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Token_OR(@GUID_Token_Left,@GUID_ObjectReference,@GUID_RelationType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_OR VALUES(@intVersion,@GUID_Token_Left,@GUID_ObjectReference,@GUID_RelationType,@GUID_DB,@intOrderID,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Token_Left,

			@GUID_ObjectReference,

			@GUID_RelationType,

			@intOrderID;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_TypeAttribute]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_TypeAttribute]

   ON  [dbo].[semtbl_OR_Type_Attribute]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_Type,

		@GUID_Attribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TypeAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TypeAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_Type,@GUID_Attribute,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_Type,

			@GUID_Attribute;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Time]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_Token_Attribute_Time](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_Token_Attribute_Time_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_Token_Attribute_Time] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_semtbl_OR_Token_Attribute_Time] UNIQUE NONCLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Time]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_Time_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Time] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_Time_semtbl_OR];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Time]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_Time_semtbl_Token_attribute_time] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_attribute_time] ([GUID_TokenAttribute])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Time] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_Time_semtbl_Token_attribute_time];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_Token_attribute_int]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_Token_attribute_int] 

   ON  [dbo].[semtbl_Token_Attribute_Int]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @intVal				int;

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@intVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_INT,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@intVal,@GUID_Transaction);

			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@intVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_attributeType]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_attributeType] 

   ON  [dbo].[semtbl_AttributeType]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	

	DECLARE @GUID_AttributeType		uniqueidentifier;

	DECLARE @Name_AttributeType		varchar(255);

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_AttributeType,

		@Name_AttributeType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_AttributeType(@GUID_AttributeType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_AttributeType VALUES(@intVersion,@GUID_AttributeType,@GUID_DB,@Name_AttributeType,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_AttributeType,

		@Name_AttributeType;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_related_ModuleActivator_With_RelatedObjectReferences]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE FUNCTION [dbo].[func_related_ModuleActivator_With_RelatedObjectReferences]

(	

	-- Add the parameters for the function here

	@GUID_Type_ModuleActivator		uniqueidentifier,

	@GUID_RelationType_offersFor	uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     func_ModuleActivator_With_RelatedObjectReferences_1.GUID_ModuleActivator, func_ModuleActivator_With_RelatedObjectReferences_1.Name_ModuleActivator, 

                      func_ModuleActivator_With_RelatedObjectReferences_1.GUID_Type_ModuleActivator, func_ModuleActivator_With_RelatedObjectReferences_1.Name_Token, 

                      func_ModuleActivator_With_RelatedObjectReferences_1.GUID_Ref, func_ModuleActivator_With_RelatedObjectReferences_1.GUID_ItemType, 

                      semtbl_Token_Token.GUID_Token_Left AS GUID_Module

FROM         dbo.func_ModuleActivator_With_RelatedObjectReferences(@GUID_Type_ModuleActivator, @GUID_RelationType_offersFor) 

                      AS func_ModuleActivator_With_RelatedObjectReferences_1 INNER JOIN

                      semtbl_Token_Token ON func_ModuleActivator_With_RelatedObjectReferences_1.GUID_ModuleActivator = semtbl_Token_Token.GUID_Token_Right

WHERE     (semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_offersFor)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Varchar255_Val_By_GUIDTokenAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Varchar255_Val_By_GUIDTokenAttribute]

(

	@GUID_TokenAttribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_TokenAttribute, val, OrderID

FROM            semtbl_Token_Attribute_Varchar255

WHERE        (GUID_TokenAttribute = @GUID_TokenAttribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_attributeType]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_attributeType] 

   ON  [dbo].[semtbl_AttributeType]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	

	DECLARE @GUID_AttributeType		uniqueidentifier;

	DECLARE @Name_AttributeType		varchar(255);

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Delete'');

	

	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_AttributeType,

		@Name_AttributeType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_AttributeType(@GUID_AttributeType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_AttributeType VALUES(@intVersion,@GUID_AttributeType,@GUID_DB,@Name_AttributeType,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_AttributeType,

		@Name_AttributeType;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_OR_Count_By_Types]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[func_Token_OR_Count_By_Types] 
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token_Left, Name_ObjectReferenceType, GUID_RelationType, Name_RelationType, GUID_ObjectReferenceType, COUNT(*) AS Count_ORs
FROM         dbo.func_Token_OR() AS func_Token_OR_1
GROUP BY GUID_Token_Left, Name_ObjectReferenceType, Name_RelationType, GUID_ObjectReferenceType, GUID_RelationType
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_By_GUID_Attribute_And_GUID_Token]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenAttribute_By_GUID_Attribute_And_GUID_Token]

	-- Add the parameters for the stored procedure here

	@GUID_Attribute		uniqueidentifier,

	@GUID_Token			uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     *

FROM         dbo.semfunc_Token_Attribute() AS semfunc_Token_Attribute_1

WHERE     (GUID_Attribute = @GUID_Attribute) AND (GUID_Token = @GUID_Token)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_AttributeType]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_AttributeType]

   ON  [dbo].[semtbl_OR_AttributeType]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_AttributeType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_AttributeType(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_AttributeType VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_AttributeType,@GUID_Transaction);	

			DELETE FROM semtbl_OR WHERE GUID_ObjectReference=@GUID_ObjectReference;

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_AttributeType;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_TypeAttribute]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_TypeAttribute]

   ON  [dbo].[semtbl_OR_Type_Attribute]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_Type,

		@GUID_Attribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TypeAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TypeAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_Type,@GUID_Attribute,@GUID_Transaction);	

			DELETE FROM semtbl_OR WHERE GUID_ObjectReference=@GUID_ObjectReference;

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_Type,

			@GUID_Attribute;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_type]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_type] 

   ON  [dbo].[semtbl_Type]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_Type				uniqueidentifier;

	DECLARE @Name_Type				varchar(255);

	DECLARE @GUID_Type_Parent		uniqueidentifier;

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Type,

		@Name_Type,

		@GUID_Type_Parent;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Type(@GUID_Type,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			If NOT @GUID_Type_Parent IS NULL

				INSERT INTO chngtbll_Type VALUES(@intVersion,@GUID_Type,@GUID_DB,@Name_Type,@GUID_Type_Parent,@GUID_Transaction);

			ELSE

				INSERT INTO chngtbll_Type (Version,GUID_Type,GUID_DB,[Name],GUID_Transaction) VALUES(@intVersion,@GUID_Type,@GUID_DB,@Name_Type,@GUID_Transaction);

			

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Type,

			@Name_Type,

			@GUID_Type_Parent;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_Token_attribute_date]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_Token_attribute_date] 

   ON  [dbo].[semtbl_Token_Attribute_Date]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @dateVal				datetime;

	DECLARE @intVersion			int;

	DECLARe @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@dateVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_Date,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@dateVal,@GUID_Transaction);


			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@dateVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenToken_RightLeft_By_GUIDToken_Left_And_RelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenToken_RightLeft_By_GUIDToken_Left_And_RelationType]

(

	@GUID_Token_Right uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        *

FROM            dbo.func_TokenToken() AS func_TokenToken_1

WHERE        (GUID_Token_Right = @GUID_Token_Right) AND (GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_TypeType]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_TypeType]

   ON  [dbo].[semtbl_OR_Type_Type]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Type_Left			uniqueidentifier;

	DECLARE @GUID_Type_Right		uniqueidentifier;

	DECLARE @GUID_RelationType		uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_Type_Left,

		@GUID_Type_Right,

		@GUID_RelationType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TypeType(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TypeType VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_Type_Left,@GUID_Type_Right,@GUID_RelationType,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_Type_Left,

			@GUID_Type_Right,

			@GUID_RelationType;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_Token_attribute_varcharmax]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_Token_attribute_varcharmax] 

   ON  [dbo].[semtbl_Token_Attribute_varcharMAX]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @strVal				varchar(MAX);

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_TokenAttribute,

		@strVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_Attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute)

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_VARCHARMAX,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@strVal,@GUID_Transaction);

			if @@ERROR=0

			BEGIN

				DELETE FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=@GUID_TokenAttribute;

			END	



			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_TokenAttribute,

			@strVal,

			@intOrderID;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_VarcharMAX]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[TokenAttribute_VarcharMAX]
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token.GUID_Token, semtbl_Token.Name_Token, semtbl_Token.GUID_Type, semtbl_Attribute.GUID_Attribute, semtbl_Attribute.Name_Attribute, 
                      semtbl_Attribute.GUID_AttributeType, semtbl_Token_Attribute_varcharMAX.val, semtbl_Token_Attribute_varcharMAX.OrderID, 
                      semtbl_Token_Attribute_varcharMAX.GUID_TokenAttribute
FROM         semtbl_Token_Attribute INNER JOIN
                      semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
                      semtbl_Token ON semtbl_Token_Attribute.GUID_Token = semtbl_Token.GUID_Token INNER JOIN
                      semtbl_Token_Attribute_varcharMAX ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_varcharMAX.GUID_TokenAttribute
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_TypeType]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_TypeType]

   ON  [dbo].[semtbl_OR_Type_Type]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Type_Left			uniqueidentifier;

	DECLARE @GUID_Type_Right		uniqueidentifier;

	DECLARE @GUID_RelationType		uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_Type_Left,

		@GUID_Type_Right,

		@GUID_RelationType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TypeType(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TypeType VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_Type_Left,@GUID_Type_Right,@GUID_RelationType,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_Type_Left,

			@GUID_Type_Right,

			@GUID_RelationType;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_type_type]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_type_type] 

   ON  [dbo].[semtbl_Type_Type]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_Type_Left			uniqueidentifier;

	DECLARE @GUID_Type_Right		uniqueidentifier;

	DECLARE @GUID_RelationType		varchar(255);

	DECLARE @Name_Type				varchar(255);

	DECLARE @GUID_Type_Parent		uniqueidentifier;

	DECLARE @intMinForw				int;

	DECLARE @intMaxForw				int;

	DECLARE @intMaxBackw			int;

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction				uniqueidentifier;

	DECLARE @GUID_Transaction_Action		uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Type	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	SET @GUID_Transaction_Action_Type = dbo.get_GUID_Action(''Relation Change'');

	

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Type_Left,

		@GUID_Type_Right,

		@GUID_RelationType,

		@intMinForw,

		@intMaxForw,

		@intMaxBackw;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Type_Type(@GUID_Type_Left,@GUID_Type_Right,@GUID_RelationType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Type_Rel VALUES(@intVersion,@GUID_Type_Left,@GUID_Type_Right,@GUID_RelationType,@GUID_DB,@intMinForw,@intMaxForw,@intMaxBackw,@GUID_Transaction);

			

			DECLARE cur_Type CURSOR FOR

				SELECT Name_Type,GUID_Type_Parent

					FROM semtbl_Type

					WHERE (GUID_Type=@GUID_Type_Left);

			OPEN cur_Type;

			FETCH NEXT FROM cur_Type INTO

				@Name_Type,

				@GUID_Type_Parent;

			CLOSE cur_Type;

			DEALLOCATE cur_Type;



			SET @intVersion = dbo.get_MaxVersion_Type(@GUID_Type_Left,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Type,getdate());

			If NOT @GUID_Type_Parent IS NULL

				INSERT INTO chngtbll_Type VALUES(@intVersion,@GUID_Type_Left,@GUID_DB,@Name_Type,@GUID_Type_Parent,@GUID_Transaction);

			ELSE

				INSERT INTO chngtbll_Type (Version,GUID_Type,GUID_DB,[Name],GUID_Transaction) VALUES(@intVersion,@GUID_Type_Left,@GUID_DB,@Name_Type,@GUID_Transaction);



			DECLARE cur_Type CURSOR FOR

				SELECT Name_Type,GUID_Type_Parent

					FROM semtbl_Type 

					WHERE (GUID_Type=@GUID_Type_Right);

			OPEN cur_Type;

			FETCH NEXT FROM cur_Type INTO

				@Name_Type,

				@GUID_Type_Parent;

			CLOSE cur_Type;

			DEALLOCATE cur_Type;



			SET @intVersion = dbo.get_MaxVersion_Type(@GUID_Type_Right,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Type,getdate());

			If NOT @GUID_Type_Parent IS NULL

				INSERT INTO chngtbll_Type VALUES(@intVersion,@GUID_Type_Right,@GUID_DB,@Name_Type,@GUID_Type_Parent,@GUID_Transaction);

			ELSE

				INSERT INTO chngtbll_Type (Version,GUID_Type,GUID_DB,[Name],GUID_Transaction) VALUES(@intVersion,@GUID_Type_Right,@GUID_DB,@Name_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Type_Left,

			@GUID_Type_Right,

			@GUID_RelationType,

			@intMinForw,

			@intMaxForw,

			@intMaxBackw;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenToken_RightLeft_By_GUIDToken_Left_And_RelationType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenToken_RightLeft_By_GUIDToken_Left_And_RelationType]

(

	@GUID_Token_Right uniqueidentifier,

	@GUID_RelationType uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        *

FROM            dbo.func_TokenToken() AS func_TokenToken_1

WHERE        (GUID_Token_Right = @GUID_Token_Right) AND (GUID_RelationType = @GUID_RelationType)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_Token_attribute_real]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_Token_attribute_real] 

   ON  [dbo].[semtbl_Token_Attribute_Real]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @realVal				real;

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@realVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_REAL,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@realVal,@GUID_Transaction);


			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@realVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_type]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_type] 

   ON  [dbo].[semtbl_Type]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_Type				uniqueidentifier;

	DECLARE @Name_Type				varchar(255);

	DECLARE @GUID_Type_Parent		uniqueidentifier;

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Delete'');

	

	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_Type,

		@Name_Type,

		@GUID_Type_Parent;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Type(@GUID_Type,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			If NOT @GUID_Type_Parent IS NULL

				INSERT INTO chngtbll_Type VALUES(@intVersion,@GUID_Type,@GUID_DB,@Name_Type,@GUID_Type_Parent,@GUID_Transaction);

			ELSE

				INSERT INTO chngtbll_Type (Version,GUID_Type,GUID_DB,[Name],GUID_Transaction) VALUES(@intVersion,@GUID_Type,@GUID_DB,@Name_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_Type,

			@Name_Type,

			@GUID_Type_Parent;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_TokenToken]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_TokenToken]

   ON  [dbo].[semtbl_OR_Token_Token]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Token_Left			uniqueidentifier;

	DECLARE @GUID_Token_Right			uniqueidentifier;

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_Token_Left,

		@GUID_Token_Right,

		@GUID_RelationType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenToken(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenToken VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_Token_Left,@GUID_Token_Right,@GUID_RelationType,@GUID_Transaction);	

			DELETE FROM semtbl_OR WHERE GUID_ObjectReference=@GUID_ObjectReference;

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_Token_Left,

			@GUID_Token_Right,

			@GUID_RelationType;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Token_OR_By_GUIDToken]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Token_OR_By_GUIDToken]

	-- Add the parameters for the stored procedure here

	@GUID_Token			uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     GUID_Token_Left, Name_Token_Left, Name_Type_Left, GUID_Type_Left, GUID_ObjectReference, GUID_RelationType, Name_RelationType, 

                      GUID_ObjectReferenceType, Name_ObjectReferenceType, GUID_Ref, Name_Ref, OrderID, GUID_ItemType

FROM         dbo.func_Token_OR() AS func_Token_OR_1

WHERE     (GUID_Token_Left = @GUID_Token)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_token]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_token] 

   ON  [dbo].[semtbl_Token]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_Token				uniqueidentifier;

	DECLARE @Name_Token				varchar(255);

	DECLARE @GUID_Type				uniqueidentifier;

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Token,

		@Name_Token,

		@GUID_Type;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Token,

			@Name_Token,

			@GUID_Type;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[func_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level]
(	
	-- Add the parameters for the function here
	@GUID_Token_Base		uniqueidentifier,
	@GUID_Type_Rel			uniqueidentifier,
	@GUID_RelationType		uniqueidentifier,
	@GUID_Direction			uniqueidentifier,
	@intLevel				int,
	@orderByID				bit
)
RETURNS @tbl_Tree TABLE 
(
	GUID_Token_Base			uniqueidentifier,
	Name_Token_Base			varchar(255),
	GIUD_Token_Rel			uniqueidentifier,
	Name_Token_Rel			varchar(255),
	GUID_Type				uniqueidentifier,
	GUID_RelationType		uniqueidentifier,
	GUID_Direction			uniqueidentifier,
	intLevel				int,
	intOrderID				int
)
BEGIN
	DECLARE @GUID_Token_Rel		uniqueidentifier;
	DECLARE @Name_Token_Base	varchar(255);
	DECLARE @Name_Token_Rel		varchar(255);
	DECLARE @intLevel_Sub		int;
	DECLARE @intOrderID			int;
	
	SET @intOrderID = 1;
	-- Add the SELECT statement with parameter references here
	IF @GUID_Direction = dbo.func_GUIDToken_Direction_LeftRight()
	BEGIN
		IF @orderByID=1
			DECLARE cur_TokenRel CURSOR FOR
				SELECT  GUID_Token_Right, 
						Name_Token_Right, 
						GUID_Token_Left, 
						Name_Token_Left
					FROM         dbo.func_TokenToken() AS func_TokenToken_1
					WHERE     (GUID_Token_Left = @GUID_Token_Base) AND (GUID_Type_Right = @GUID_Type_Rel) AND (GUID_RelationType = @GUID_RelationType)
					ORDER By OrderID;
		ELSE
			DECLARE cur_TokenRel CURSOR FOR
				SELECT  GUID_Token_Right, 
						Name_Token_Right, 
						GUID_Token_Left, 
						Name_Token_Left
					FROM         dbo.func_TokenToken() AS func_TokenToken_1
					WHERE     (GUID_Token_Left = @GUID_Token_Base) AND (GUID_Type_Right = @GUID_Type_Rel) AND (GUID_RelationType = @GUID_RelationType);
	END
	ELSE
	BEGIN
		IF @orderByID=1
			DECLARE cur_TokenRel CURSOR FOR
				SELECT  GUID_Token_Left, 
						Name_Token_Left, 
						GUID_Token_Right, 
						Name_Token_Right
					FROM         dbo.func_TokenToken() AS func_TokenToken_1
					WHERE     (GUID_Token_Right = @GUID_Token_Base) AND (GUID_Type_Left = @GUID_Type_Rel) AND (GUID_RelationType = @GUID_RelationType)
					ORDER By OrderID;
		ELSE
			DECLARE cur_TokenRel CURSOR FOR
				SELECT  GUID_Token_Left, 
						Name_Token_Left, 
						GUID_Token_Right, 
						Name_Token_Right
					FROM         dbo.func_TokenToken() AS func_TokenToken_1
					WHERE     (GUID_Token_Right = @GUID_Token_Base) AND (GUID_Type_Left = @GUID_Type_Rel) AND (GUID_RelationType = @GUID_RelationType);
	END
	

	OPEN cur_TokenRel;
	FETCH NEXT FROM cur_TokenRel INTO
		@GUID_Token_Rel,
		@Name_Token_Rel,
		@GUID_Token_Base,
		@Name_Token_Base;
	
	WHILE @@FETCH_STATUS=0
	BEGIN
		INSERT INTO @tbl_Tree VALUES (
			@GUID_Token_Base,
			@Name_Token_Base,
			@GUID_Token_Rel,
			@Name_Token_Rel,
			@GUID_Type_Rel,
			@GUID_RelationType,
			@GUID_Direction,
			@intLevel,
			@intOrderID);
		SET @intOrderID = @intOrderID+1;
		DECLARE cur_TokenRel_Sub CURSOR FOR
			SELECT * FROM func_TokenTree_By_GUIDTokenBase_GUIDTokenRel_GUIDRelationType_Level(
				@GUID_Token_Rel,
				@GUID_Type_Rel,
				@GUID_RelationType,
				@GUID_Direction,
				@intLevel+1,
				@orderByID);
		OPEN cur_TokenRel_Sub;
		FETCH NEXT FROM cur_TokenRel_Sub INTO
			@GUID_Token_Base,
			@Name_Token_Base,
			@GUID_Token_Rel,
			@Name_Token_Rel,
			@GUID_Type_Rel,
			@GUID_RelationType,
			@GUID_Direction,
			@intLevel_Sub,
			@intOrderID;
		WHILE @@FETCH_STATUS=0
		BEGIN
			INSERT INTO @tbl_Tree VALUES (
				@GUID_Token_Base,
				@Name_Token_Base,
				@GUID_Token_Rel,
				@Name_Token_Rel,
				@GUID_Type_Rel,
				@GUID_RelationType,
				@GUID_Direction,
				@intLevel_Sub,
				@intOrderID);
			SET @intOrderID = @intOrderID+1;
			FETCH NEXT FROM cur_TokenRel_Sub INTO
				@GUID_Token_Base,
				@Name_Token_Base,
				@GUID_Token_Rel,
				@Name_Token_Rel,
				@GUID_Type_Rel,
				@GUID_RelationType,
				@GUID_Direction,
				@intLevel,
				@intOrderID;
		END
		CLOSE cur_TokenRel_Sub;
		DEALLOCATE cur_TokenRel_Sub;
		FETCH NEXT FROM cur_TokenRel INTO
			@GUID_Token_Rel,
			@Name_Token_Rel,
			@GUID_Token_Base,
			@Name_Token_Base;
	END
	CLOSE cur_TokenRel;
	DEALLOCATE cur_TokenRel;
	RETURN
END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_type_type]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_type_type] 

   ON  [dbo].[semtbl_Type_Type]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_Type_Left			uniqueidentifier;

	DECLARE @GUID_Type_Right		uniqueidentifier;

	DECLARE @GUID_RelationType		varchar(255);

	DECLARE @Name_Type				varchar(255);

	DECLARE @GUID_Type_Parent		uniqueidentifier;

	DECLARE @intMinForw				int;

	DECLARE @intMaxForw				int;

	DECLARE @intMaxBackw			int;

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction				uniqueidentifier;

	DECLARE @GUID_Transaction_Action		uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Type	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	SET @GUID_Transaction_Action_Type = dbo.get_GUID_Action(''Relation Change'');

	

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Type_Left,

		@GUID_Type_Right,

		@GUID_RelationType,

		@intMinForw,

		@intMaxForw,

		@intMaxBackw;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Type_Type(@GUID_Type_Left,@GUID_Type_Right,@GUID_RelationType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			INSERT INTO chngtbll_Type_Rel VALUES(@intVersion,@GUID_Type_Left,@GUID_Type_Right,@GUID_RelationType,@GUID_DB,@intMinForw,@intMaxForw,@intMaxBackw,@GUID_Transaction);

			

			

			DECLARE cur_Type CURSOR FOR

				SELECT Name_Type,GUID_Type_Parent

					FROM semtbl_Type

					WHERE (GUID_Type=@GUID_Type_Left);

			OPEN cur_Type;

			FETCH NEXT FROM cur_Type INTO

				@Name_Type,

				@GUID_Type_Parent;

			CLOSE cur_Type;

			DEALLOCATE cur_Type;



			SET @intVersion = dbo.get_MaxVersion_Type(@GUID_Type_Left,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Type,getdate());

			If NOT @GUID_Type_Parent IS NULL

				INSERT INTO chngtbll_Type VALUES(@intVersion,@GUID_Type_Left,@GUID_DB,@Name_Type,@GUID_Type_Parent,@GUID_Transaction);

			ELSE

				INSERT INTO chngtbll_Type (Version,GUID_Type,GUID_DB,[Name],GUID_Transaction) VALUES(@intVersion,@GUID_Type_Left,@GUID_DB,@Name_Type,@GUID_Transaction);



			DECLARE cur_Type CURSOR FOR

				SELECT Name_Type,GUID_Type_Parent

					FROM semtbl_Type 

					WHERE (GUID_Type=@GUID_Type_Right);

			OPEN cur_Type;

			FETCH NEXT FROM cur_Type INTO

				@Name_Type,

				@GUID_Type_Parent;

			CLOSE cur_Type;

			DEALLOCATE cur_Type;



			SET @intVersion = dbo.get_MaxVersion_Type(@GUID_Type_Right,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Type,getdate());

			If NOT @GUID_Type_Parent IS NULL

				INSERT INTO chngtbll_Type VALUES(@intVersion,@GUID_Type_Right,@GUID_DB,@Name_Type,@GUID_Type_Parent,@GUID_Transaction);

			ELSE

				INSERT INTO chngtbll_Type (Version,GUID_Type,GUID_DB,[Name],GUID_Transaction) VALUES(@intVersion,@GUID_Type_Right,@GUID_DB,@Name_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Type_Left,

			@GUID_Type_Right,

			@GUID_RelationType,

			@intMinForw,

			@intMaxForw,

			@intMaxBackw;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_token]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_token] 

   ON  [dbo].[semtbl_Token]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_Token				uniqueidentifier;

	DECLARE @Name_Token				varchar(255);

	DECLARE @GUID_Type				uniqueidentifier;

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Token,

		@Name_Token,

		@GUID_Type;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Token,

			@Name_Token,

			@GUID_Type;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_attribute]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_attribute] 

   ON  [dbo].[semtbl_Attribute]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB			varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @Name_Attribute		varchar(255);

	DECLARE @GUID_AttributeType	uniqueidentifier;

	DECLARE @intVersion			int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Attribute,

		@Name_Attribute,

		@GUID_AttributeType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Attribute(@GUID_Attribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Attribute VALUES(@intVersion,@GUID_Attribute,@GUID_DB,@Name_Attribute,@GUID_AttributeType,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Attribute,

			@Name_Attribute,

			@GUID_AttributeType;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Real]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[semtbl_OR_Token_Attribute_Real](
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL CONSTRAINT [DF_semtbl_OR_Token_Attribute_Real_GUID_ObjectReference]  DEFAULT (newid()),
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_semtbl_OR_Token_Attribute_Real] PRIMARY KEY CLUSTERED 
(
	[GUID_ObjectReference] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_semtbl_OR_Token_Attribute_Real] UNIQUE NONCLUSTERED 
(
	[GUID_TokenAttribute] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Real]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_Real_semtbl_OR] FOREIGN KEY([GUID_ObjectReference])
REFERENCES [dbo].[semtbl_OR] ([GUID_ObjectReference])
ON DELETE CASCADE;
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Real] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_Real_semtbl_OR];
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Real]  WITH CHECK ADD  CONSTRAINT [FK_semtbl_OR_Token_Attribute_Real_semtbl_Token_Attribute_Real] FOREIGN KEY([GUID_TokenAttribute])
REFERENCES [dbo].[semtbl_Token_Attribute_Real] ([GUID_TokenAttribute]);
ALTER TABLE [dbo].[semtbl_OR_Token_Attribute_Real] CHECK CONSTRAINT [FK_semtbl_OR_Token_Attribute_Real_semtbl_Token_Attribute_Real];'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_token_token]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_token_token] 

   ON  [dbo].[semtbl_Token_Token]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_Token_Left		uniqueidentifier;

	DECLARE @GUID_Token_Right		uniqueidentifier;

	DECLARE @GUID_RelationType				varchar(255);

	DECLARE @Name_Token				varchar(255);

	DECLARE @GUID_Type				uniqueidentifier;

	DECLARE @OrderID				int;

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction				uniqueidentifier;

	DECLARE @GUID_Transaction_Action		uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Relation Change'');

	

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Token_Left,

		@GUID_Token_Right,

		@GUID_RelationType,

		@OrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Token_Token(@GUID_Token_Left,@GUID_Token_Right,@GUID_RelationType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Token VALUES(@intVersion,@GUID_Token_Left,@GUID_Token_Right,@GUID_RelationType,@GUID_DB,@OrderID,@GUID_Transaction);

			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token 

					WHERE (GUID_Token=@GUID_Token_Left);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token_Left,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token_Left,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);



			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token 

					WHERE (GUID_Token=@GUID_Token_Right);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token_Right,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token_Right,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Token_Left,

			@GUID_Token_Right,

			@GUID_RelationType,

			@OrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_Token]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_Token]

   ON  [dbo].[semtbl_OR_Token]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_Token;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_Token(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_Token VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_Token,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_Token;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_RelationType]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_RelationType]

   ON  [dbo].[semtbl_OR_RelationType]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_RelationType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_RelationType(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_RelationType VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_RelationType,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_RelationType;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_relationtype]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_relationtype] 

   ON  [dbo].[semtbl_RelationType]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_RelationType		uniqueidentifier;

	DECLARE @Name_RelationType				varchar(255);

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_RelationType,

		@Name_RelationType;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_RelationType(@GUID_RelationType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_RelationType VALUES(@intVersion,@GUID_RelationType,@GUID_DB,@Name_RelationType,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_RelationType,

			@Name_RelationType;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_Token_OR]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_Token_OR]

   ON  [dbo].[semtbl_Token_OR]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Token_Left			uniqueidentifier;

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @intOrderID					int;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_Token_Left,

		@GUID_ObjectReference,

		@GUID_RelationType,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Token_OR(@GUID_Token_Left,@GUID_ObjectReference,@GUID_RelationType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_OR VALUES(@intVersion,@GUID_Token_Left,@GUID_ObjectReference,@GUID_RelationType,@GUID_DB,@intOrderID,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_Token_Left,

			@GUID_ObjectReference,

			@GUID_RelationType,

			@intOrderID;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Bit_Val_By_GUIDTokenAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.proc_TokenAttribute_Bit_Val_By_GUIDTokenAttribute

(

	@GUID_TokenAttribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_TokenAttribute, val, OrderID

FROM            semtbl_Token_Attribute_Bit

WHERE        (GUID_TokenAttribute = @GUID_TokenAttribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_token_token]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_token_token] 

   ON  [dbo].[semtbl_Token_Token]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_Token_Left		uniqueidentifier;

	DECLARE @GUID_Token_Right		uniqueidentifier;

	DECLARE @GUID_RelationType				varchar(255);

	DECLARE @Name_Token				varchar(255);

	DECLARE @GUID_Type				uniqueidentifier;

	DECLARE @OrderID				int;

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction				uniqueidentifier;

	DECLARE @GUID_Transaction_Action		uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Relation Change'');

	

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Token_Left,

		@GUID_Token_Right,

		@GUID_RelationType,

		@OrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Token_Token(@GUID_Token_Left,@GUID_Token_Right,@GUID_RelationType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Token VALUES(@intVersion,@GUID_Token_Left,@GUID_Token_Right,@GUID_RelationType,@GUID_DB,@OrderID,@GUID_Transaction);

			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token 

					WHERE (GUID_Token=@GUID_Token_Left);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token_Left,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token_Left,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);



			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token 

					WHERE (GUID_Token=@GUID_Token_Right);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token_Right,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token_Right,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Token_Left,

			@GUID_Token_Right,

			@GUID_RelationType,

			@OrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_type_attribute]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_type_attribute] 

   ON  [dbo].[semtbl_Type_Attribute]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_Type				uniqueidentifier;

	DECLARE @GUID_Attribute			uniqueidentifier;

	DECLARE @Name_Type				varchar(255);

	DECLARE @GUID_Type_Parent		uniqueidentifier;

	DECLARE @intMin					int;

	DECLARE @intMax					int;

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Type	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	SET @GUID_Transaction_Action_Type = dbo.get_GUID_Action(''Attribute Change'');		



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Type,

		@GUID_Attribute,

		@intMin,

		@intMax;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Type_Attribute(@GUID_Type,@GUID_Attribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Type_Attribute VALUES(@intVersion,@GUID_Type,@GUID_Attribute,@GUID_DB,@intMin,@intMax,@GUID_Transaction);

		

			DECLARE cur_Type CURSOR FOR

				SELECT Name_Type,GUID_Type_Parent

					FROM semtbl_Type

					WHERE (GUID_Type=@GUID_Type);

			OPEN cur_Type;

			FETCH NEXT FROM cur_Type INTO

				@Name_Type,

				@GUID_Type_Parent;

			CLOSE cur_Type;

			DEALLOCATE cur_Type;



			SET @intVersion = dbo.get_MaxVersion_Type(@GUID_Type,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Type,getdate());

			If NOT @GUID_Type_Parent IS NULL

				INSERT INTO chngtbll_Type VALUES(@intVersion,@GUID_Type,@GUID_DB,@Name_Type,@GUID_Type_Parent,@GUID_Transaction);

			ELSE

				INSERT INTO chngtbll_Type (Version,GUID_Type,GUID_DB,[Name],GUID_Transaction) VALUES(@intVersion,@GUID_Type,@GUID_DB,@Name_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Type,

			@GUID_Attribute,

			@intMin,

			@intMax;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Bit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[TokenAttribute_Bit]
(	
	-- Add the parameters for the function here
	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     semtbl_Token.GUID_Token, semtbl_Token.Name_Token, semtbl_Token.GUID_Type, semtbl_Attribute.GUID_Attribute, semtbl_Attribute.Name_Attribute, 
                      semtbl_Attribute.GUID_AttributeType, semtbl_Token_Attribute_Bit.val, semtbl_Token_Attribute_Bit.OrderID, semtbl_Token_Attribute_Bit.GUID_TokenAttribute
FROM         semtbl_Token_Attribute INNER JOIN
                      semtbl_Attribute ON semtbl_Token_Attribute.GUID_Attribute = semtbl_Attribute.GUID_Attribute INNER JOIN
                      semtbl_Token ON semtbl_Token_Attribute.GUID_Token = semtbl_Token.GUID_Token INNER JOIN
                      semtbl_Token_Attribute_Bit ON semtbl_Token_Attribute.GUID_TokenAttribute = semtbl_Token_Attribute_Bit.GUID_TokenAttribute
)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_token_token]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_token_token] 

   ON  [dbo].[semtbl_Token_Token]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB				uniqueidentifier;

	DECLARE @GUID_Token_Left		uniqueidentifier;

	DECLARE @GUID_Token_Right		uniqueidentifier;

	DECLARE @GUID_RelationType				varchar(255);

	DECLARE @Name_Token				varchar(255);

	DECLARE @GUID_Type				uniqueidentifier;

	DECLARE @OrderID				int;

	DECLARE @intVersion				int;



	DECLARE @GUID_Transaction				uniqueidentifier;

	DECLARE @GUID_Transaction_Action		uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Delete'');

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Relation Change'');

	

	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_Token_Left,

		@GUID_Token_Right,

		@GUID_RelationType,

		@OrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Token_Token(@GUID_Token_Left,@GUID_Token_Right,@GUID_RelationType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Token VALUES(@intVersion,@GUID_Token_Left,@GUID_Token_Right,@GUID_RelationType,@GUID_DB,@OrderID,@GUID_Transaction);

			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token 

					WHERE (GUID_Token=@GUID_Token_Left);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token_Left,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token_Left,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);



			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token 

					WHERE (GUID_Token=@GUID_Token_Right);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token_Right,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token_Right,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_Token_Left,

			@GUID_Token_Right,

			@GUID_RelationType,

			@OrderID;

	END

		

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END


'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_Token_attribute_int]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_Token_attribute_int] 

   ON  [dbo].[semtbl_Token_Attribute_Int]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for trigger here

	DECLARE @Name_DB				varchar(255);

	DECLARE @GUID_DB			uniqueidentifier;

	DECLARE @GUID_Server		uniqueidentifier;

	DECLARE @GUID_Token			uniqueidentifier;

	DECLARE @GUID_TokenAttribute	uniqueidentifier;

	DECLARE @GUID_Attribute		uniqueidentifier;

	DECLARE @intVal				int;

	DECLARE @intVersion			int;

	DECLARE @intOrderID			int;

	

	DECLARE @Name_Token			varchar(255);

	DECLARE @GUID_Type			uniqueidentifier;



	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction_Action_Token	uniqueidentifier;



	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');

	

	SET @GUID_Transaction_Action_Token = dbo.get_GUID_Action(''Attribute Change'');

	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_TokenAttribute,

		@intVal,

		@intOrderID;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			DECLARE cur_TokenAttribute CURSOR FOR 

				SELECT     GUID_Token, GUID_Attribute

					FROM         semtbl_Token_attribute

					WHERE     (GUID_TokenAttribute = @GUID_TokenAttribute);

			OPEN cur_TokenAttribute;

			FETCH NEXT FROM cur_TokenAttribute INTO

				@GUID_Token,

				@GUID_Attribute;

			CLOSE cur_TokenAttribute;

			DEALLOCATE cur_TokenAttribute;

			SET @intVersion = dbo.get_MaxVersion_Token_Attribute(@GUID_TokenAttribute,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Token_Attribute (Version,GUID_TokenAttribute,GUID_DB,GUID_Token,GUID_Attribute,OrderID,VAL_INT,GUID_Transaction) VALUES(@intVersion,@GUID_TokenAttribute,@GUID_DB,@GUID_Token,@GUID_Attribute,@intOrderID,@intVal,@GUID_Transaction);

			

			DECLARE cur_Token CURSOR FOR

				SELECT Name_Token,GUID_Type

					FROM semtbl_Token

					WHERE (GUID_Token=@GUID_Token);

			OPEN cur_Token;

			FETCH NEXT FROM cur_Token INTO

				@Name_Token,

				@GUID_Type;

			CLOSE cur_Token;

			DEALLOCATE cur_Token;



			SET @intVersion = dbo.get_MaxVersion_Token(@GUID_Token,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			

			SET @GUID_Transaction = newid();

			INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action_Token,getdate());

			INSERT INTO chngtbll_Token VALUES(@intVersion,@GUID_Token,@GUID_DB,@Name_Token,@GUID_Type,@GUID_Transaction);

		END

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_TokenAttribute,

			@intVal,

			@intOrderID;

	END

		

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END








'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_Type]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_Type]

   ON  [dbo].[semtbl_OR_Type]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_Type;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_Type(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_Type VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_Type,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_Type;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tokenattributeproc_TokenAttribute_By_GUID_Attribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.tokenattributeproc_TokenAttribute_By_GUID_Attribute

(

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        GUID_TokenAttribute, GUID_Attribute, Name_Attribute, GUID_AttributeType, GUID_Token, Name_Token, GUID_Type

FROM            dbo.semfunc_Token_Attribute() AS semfunc_Token_Attribute_1

WHERE        (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[update_semtbl_Type_OR]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[update_semtbl_Type_OR]

   ON  [dbo].[semtbl_Type_OR]

   AFTER UPDATE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_Type					uniqueidentifier;

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @intMin_forw				int;

	DECLARE @intMax_forw				int;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Update'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_Type,

		@GUID_RelationType,

		@intMin_forw,

		@intMax_forw;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_Type_OR(@GUID_Type,@GUID_RelationType,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_Type_OR VALUES(@intVersion,@GUID_Type,@GUID_RelationType,@GUID_DB,@intMin_forw,@intMax_forw,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_Type,

			@GUID_RelationType,

			@intMin_forw,

			@intMax_forw;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenToken_LeftRight_Max_OrderID]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE dbo.proc_TokenToken_LeftRight_Max_OrderID

(

	@GUID_Token_Left uniqueidentifier,

	@GUID_Type_Right uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        MAX(OrderID) AS Expr1

FROM            dbo.func_TokenToken() AS func_TokenToken_1

WHERE        (GUID_Token_Left = @GUID_Token_Left) AND (GUID_Type_Right = @GUID_Type_Right)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Count_Token_Of_Attribute_And_Token]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenAttribute_Count_Token_Of_Attribute_And_Token]

(

	@GUID_Attribute uniqueidentifier,

	@GUID_Token uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     COUNT(*) AS Count_Token

FROM         dbo.semfunc_Token_Attribute() AS semfunc_Token_Attribute_1

WHERE     (GUID_Attribute = @GUID_Attribute) AND (GUID_Token = @GUID_Token)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Time_Max]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Time_Max]

(

	@GUID_Type uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        MAX(val) AS Max_Val

FROM            dbo.TokenAttribute_Time() AS TokenAttribute_Time_1

WHERE        (GUID_Type = @GUID_Type) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Time_Min]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Time_Min]

(

	@GUID_Type uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        MIN(val) AS Min_Val

FROM            dbo.TokenAttribute_Time() AS TokenAttribute_Time_1

WHERE        (GUID_Type = @GUID_Type) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_TokenToken_LeftRight_Hierarchical]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE dbg_TokenToken_LeftRight_Hierarchical 

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Token_Left uniqueidentifier;

	DECLARE @GUID_RelationType uniqueidentifier;

	DECLARE @GUID_Type_Right uniqueidentifier;

	DECLARE @TreeLevel int;

	DECLARE @MaxDeep int;

	DECLARE @OrderID int;

	

	SET @GUID_Token_Left = ''7841700f-085e-48e6-a9a9-c9c6b5b8b6b8'';

	SET @GUID_RelationType = ''eb05244b-4e49-4808-b81b-995f3ee6065a'';

	SET @GUID_Type_Right  = ''2c1f5b97-21e5-44ca-95d2-43008011c14d''

	SET @TreeLevel = 0;

	SET @MaxDeep = -1;

	SET @OrderID = 1;

	

	PRINT @GUID_Token_Left;

	PRINT @GUID_RelationType;

	PRINT @GUID_Type_Right;

	PRINT @TreeLevel;

	PRINT @MaxDeep;

	PRINT @OrderID;

	

    -- Insert statements for procedure here

	SELECT * FROM func_TokenToken_LeftRight_Hierarchical(	

		@GUID_Token_Left,

		@GUID_RelationType,

		@GUID_Type_Right,

		@TreeLevel,

		@MaxDeep,

		@OrderID)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Attributes_By_GUIDToken_And_GUIDAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Attributes_By_GUIDToken_And_GUIDAttribute]

(

	@GUID_Token uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     func_TokenAttribute_Named_By_GUIDToken_1.*

FROM         dbo.func_TokenAttribute_Named_By_GUIDToken(@GUID_Token) AS func_TokenAttribute_Named_By_GUIDToken_1

WHERE     (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Date_By_GUIDAttribute_And_GUIDToken]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenAttribute_Date_By_GUIDAttribute_And_GUIDToken]

(

	@GUID_Token uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     GUID_Token, Name_Token, GUID_Type, GUID_Attribute, Name_Attribute, GUID_AttributeType, val, OrderID, GUID_TokenAttribute

FROM         dbo.TokenAttribute_Date() AS TokenAttribute_Date_1

WHERE     (GUID_Token = @GUID_Token) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Datetime_Max]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Datetime_Max]

(

	@GUID_Type uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        MAX(val) AS Max_Val

FROM            dbo.TokenAttribute_Datetime() AS TokenAttribute_Datetime_1

WHERE        (GUID_Type = @GUID_Type) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_ModuleActivator_With_RelatedObjectReferenceTypes]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE FUNCTION [dbo].[func_ModuleActivator_With_RelatedObjectReferenceTypes] 

(	

	-- Add the parameters for the function here

	@GUID_Type_ModuleActivator			uniqueidentifier,

	@GUID_Attribute_Type				uniqueidentifier,

	@GUID_Attribute_Token				uniqueidentifier,

	@GUID_Attribute_RelationType		uniqueidentifier,

	@GUID_Attribute_Attribute			uniqueidentifier

	

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     semtbl_Token.GUID_Token AS GUID_ModuleActivator, semtbl_Token.Name_Token AS Name_ModuleActivator, 

                      semtbl_Token.GUID_Type AS GUID_Type_ModuleActivator, func_related_TokenAttribute_BOOL_1.GUID_TokenAttribute AS GUID_TokenAttribute_Attribute, 

                      func_related_TokenAttribute_BOOL_1.val AS Attribute, func_related_TokenAttribute_BOOL_2.GUID_TokenAttribute AS GUID_TokenAttribute_RelationType, 

                      func_related_TokenAttribute_BOOL_2.val AS RelationType, func_related_TokenAttribute_BOOL_3.GUID_TokenAttribute AS GUID_TokenAttribute_Token, 

                      func_related_TokenAttribute_BOOL_3.val AS Token, func_related_TokenAttribute_BOOL_4.GUID_TokenAttribute AS GUID_TokenAttribute_Type, 

                      func_related_TokenAttribute_BOOL_4.val AS Type

FROM         semtbl_Token LEFT OUTER JOIN

                      dbo.func_related_TokenAttribute_BOOL(@GUID_Attribute_Type) AS func_related_TokenAttribute_BOOL_4 ON 

                      semtbl_Token.GUID_Token = func_related_TokenAttribute_BOOL_4.GUID_Token LEFT OUTER JOIN

                      dbo.func_related_TokenAttribute_BOOL(@GUID_Attribute_Token) AS func_related_TokenAttribute_BOOL_3 ON 

                      semtbl_Token.GUID_Token = func_related_TokenAttribute_BOOL_3.GUID_Token LEFT OUTER JOIN

                      dbo.func_related_TokenAttribute_BOOL(@GUID_Attribute_RelationType) AS func_related_TokenAttribute_BOOL_2 ON 

                      semtbl_Token.GUID_Token = func_related_TokenAttribute_BOOL_2.GUID_Token LEFT OUTER JOIN

                      dbo.func_related_TokenAttribute_BOOL(@GUID_Attribute_Attribute) AS func_related_TokenAttribute_BOOL_1 ON 

                      semtbl_Token.GUID_Token = func_related_TokenAttribute_BOOL_1.GUID_Token

WHERE     (semtbl_Token.GUID_Type = @GUID_Type_ModuleActivator)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Varchar255_By_GUIDAttribute_And_GUIDToken]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenAttribute_Varchar255_By_GUIDAttribute_And_GUIDToken]

(

	@GUID_Token uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     GUID_Token, Name_Token, GUID_Type, GUID_Attribute, Name_Attribute, GUID_AttributeType, val, OrderID, GUID_TokenAttribute

FROM         dbo.TokenAttribute_Varchar255() AS TokenAttribute_Varchar255_1

WHERE     (GUID_Token = @GUID_Token) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_Token_Attribute_Real]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_Token_Attribute_Real]

   ON  [dbo].[semtbl_OR_Token_Attribute_Real]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM Deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

			DELETE FROM semtbl_OR WHERE GUID_ObjectReference=@GUID_ObjectReference;

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_Token_Attribute_DateTime]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_Token_Attribute_DateTime]

   ON  [dbo].[semtbl_OR_Token_Attribute_Datetime]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM Deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

			DELETE FROM semtbl_OR WHERE GUID_ObjectReference=@GUID_ObjectReference;

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Named_By_GUIDToken_And_GUIDAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE proc_TokenAttribute_Named_By_GUIDToken_And_GUIDAttribute

	-- Add the parameters for the stored procedure here

	@GUID_Token			uniqueidentifier,

	@GUID_Attribute		uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     func_TokenAttribute_Named_By_GUIDToken_1.*

FROM         dbo.func_TokenAttribute_Named_By_GUIDToken(@GUID_Token) AS func_TokenAttribute_Named_By_GUIDToken_1

WHERE     (GUID_Attribute = @GUID_Attribute)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Named_By_GUIDToken_And_GUIDAttribute_OrderIDDESC]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Named_By_GUIDToken_And_GUIDAttribute_OrderIDDESC]

(

	@GUID_Token uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        *

FROM            dbo.func_TokenAttribute_Named_By_GUIDToken(@GUID_Token) AS func_TokenAttribute_Named_By_GUIDToken_1

WHERE        (GUID_Attribute = @GUID_Attribute)

ORDER BY OrderID DESC'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Date_Min]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Date_Min]

(

	@GUID_Type uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        MIN(val) AS Min_Val

FROM            dbo.TokenAttribute_Date() AS TokenAttribute_Date_1

WHERE        (GUID_Type = @GUID_Type) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_VarcharMax_By_GUIDAttribute_And_GUIDToken]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenAttribute_VarcharMax_By_GUIDAttribute_And_GUIDToken]

(

	@GUID_Token uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     GUID_Token, Name_Token, GUID_Type, GUID_Attribute, Name_Attribute, GUID_AttributeType, val, OrderID, GUID_TokenAttribute

FROM         dbo.TokenAttribute_VarcharMAX() AS TokenAttribute_VarcharMAX_1

WHERE     (GUID_Token = @GUID_Token) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_Token_Attribute_Bit]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_Token_Attribute_Bit]

   ON  [dbo].[semtbl_OR_Token_Attribute_Bit]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM Deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

			DELETE FROM semtbl_OR WHERE GUID_ObjectReference=@GUID_ObjectReference;

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_Token_Attribute_Int]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_Token_Attribute_Int]

   ON  [dbo].[semtbl_OR_Token_Attribute_Int]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_Token_Attribute_Date]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_Token_Attribute_Date]

   ON  [dbo].[semtbl_OR_Token_Attribute_Date]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_Token_Attribute_Bit]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_Token_Attribute_Bit]

   ON  [dbo].[semtbl_OR_Token_Attribute_Bit]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_Token_OR_Count_By_Types_and_GUIDToken]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_Token_OR_Count_By_Types_and_GUIDToken]

(

	@GUID_Token uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     GUID_Token_Left, Name_ObjectReferenceType, GUID_RelationType, Name_RelationType, GUID_ObjectReferenceType, Count_ORs

FROM         dbo.func_Token_OR_Count_By_Types() AS func_Token_OR_Count_By_Types_1

WHERE     (GUID_Token_Left = @GUID_Token)

ORDER BY Name_ObjectReferenceType, Name_RelationType'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Attributes_By_GUIDToken_And_GUIDAttribute]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenAttribute_Attributes_By_GUIDToken_And_GUIDAttribute]

(

	@GUID_Token uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     func_TokenAttribute_Named_By_GUIDToken_1.*

FROM         dbo.func_TokenAttribute_Named_By_GUIDToken(@GUID_Token) AS func_TokenAttribute_Named_By_GUIDToken_1

WHERE     (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_Token_Attribute_Int]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_Token_Attribute_Int]

   ON  [dbo].[semtbl_OR_Token_Attribute_Int]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM Deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

			DELETE FROM semtbl_OR WHERE GUID_ObjectReference=@GUID_ObjectReference;

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenToken_LeftRight_Tree]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_TokenToken_LeftRight_Tree]

	-- Add the parameters for the stored procedure here

	@GUID_Token_Left uniqueidentifier,

	@GUID_RelationType uniqueidentifier,

	@GUID_Type_Right uniqueidentifier,

	@TreeLevel int,

	@MaxDeep int,

	@OrderID int

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT * FROM func_TokenToken_LeftRight_Hierarchical(	

		@GUID_Token_Left,

		@GUID_RelationType,

		@GUID_Type_Right,

		@TreeLevel,

		@MaxDeep,

		@OrderID)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_related_ModuleActivator_With_ObjectReference_By_GUIDModule]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_related_ModuleActivator_With_ObjectReference_By_GUIDModule]

(

	@GUID_Type_ModuleActivator uniqueidentifier,

	@GUID_RelationType_offersFor uniqueidentifier,

	@GUID_Module uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     GUID_ModuleActivator, Name_ModuleActivator, GUID_Type_ModuleActivator, Name_Token, GUID_Ref, GUID_ItemType

FROM         dbo.func_related_ModuleActivator_With_RelatedObjectReferences(@GUID_Type_ModuleActivator, @GUID_RelationType_offersFor) 

                      AS func_related_ModuleActivator_With_RelatedObjectReferences_1

WHERE     (GUID_Module = @GUID_Module)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_Token_Attribute_VarcharMax]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_Token_Attribute_VarcharMax]

   ON  [dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_Token_Attribute_Varchar255]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_Token_Attribute_Varchar255]

   ON  [dbo].[semtbl_OR_Token_Attribute_Varchar255]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_Token_Attribute_Varchar255]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_Token_Attribute_Varchar255]

   ON  [dbo].[semtbl_OR_Token_Attribute_Varchar255]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM Deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

			DELETE FROM semtbl_OR WHERE GUID_ObjectReference=@GUID_ObjectReference;

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Named_By_GUIDToken_And_GUIDAttribute_OrderIDASC]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Named_By_GUIDToken_And_GUIDAttribute_OrderIDASC]

(

	@GUID_Token uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        *

FROM            dbo.func_TokenAttribute_Named_By_GUIDToken(@GUID_Token) AS func_TokenAttribute_Named_By_GUIDToken_1

WHERE        (GUID_Attribute = @GUID_Attribute)

ORDER BY OrderID'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Real_By_GUIDAttribute_And_GUIDToken]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenAttribute_Real_By_GUIDAttribute_And_GUIDToken]

(

	@GUID_Token uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     GUID_Token, Name_Token, GUID_Type, GUID_Attribute, Name_Attribute, GUID_AttributeType, val, OrderID, GUID_TokenAttribute

FROM         dbo.TokenAttribute_Real() AS TokenAttribute_Real_1

WHERE     (GUID_Token = @GUID_Token) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Int_Max]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Int_Max]

(

	@GUID_Type uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        MAX(val) AS Max_Val

FROM            dbo.TokenAttribute_Int() AS TokenAttribute_Int_1

WHERE        (GUID_Type = @GUID_Type) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Time_By_GUIDAttribute_And_GUIDToken]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenAttribute_Time_By_GUIDAttribute_And_GUIDToken]

(

	@GUID_Token uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     GUID_Token, Name_Token, GUID_Type, GUID_Attribute, Name_Attribute, GUID_AttributeType, val, OrderID, GUID_TokenAttribute

FROM         dbo.TokenAttribute_Time() AS TokenAttribute_Time_1

WHERE     (GUID_Token = @GUID_Token) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Datetime_Min]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Datetime_Min]

(

	@GUID_Type uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        MIN(val) AS Min_Val

FROM            dbo.TokenAttribute_Datetime() AS TokenAttribute_Datetime_1

WHERE        (GUID_Type = @GUID_Type) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_Token_Attribute_Real]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_Token_Attribute_Real]

   ON  [dbo].[semtbl_OR_Token_Attribute_Real]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Int_Min]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Int_Min]

(

	@GUID_Type uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        MIN(val) AS Min_Val

FROM            dbo.TokenAttribute_Int() AS TokenAttribute_Int_1

WHERE        (GUID_Type = @GUID_Type) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_Token_Attribute_DateTime]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_Token_Attribute_DateTime]

   ON  [dbo].[semtbl_OR_Token_Attribute_Datetime]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_VarcharMax_By_GUIDAttribute_And_GUIDToken_And_Val]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenAttribute_VarcharMax_By_GUIDAttribute_And_GUIDToken_And_Val]

(

	@GUID_Token uniqueidentifier,

	@GUID_Attribute uniqueidentifier,

	@strVal varchar(MAX)

)

AS

	SET NOCOUNT ON;

SELECT     GUID_Token, Name_Token, GUID_Type, GUID_Attribute, Name_Attribute, GUID_AttributeType, val, OrderID, GUID_TokenAttribute

FROM         dbo.TokenAttribute_VarcharMAX() AS TokenAttribute_VarcharMAX_1

WHERE     (GUID_Token = @GUID_Token) AND (GUID_Attribute = @GUID_Attribute) AND (val = @strVal)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TokenAttribute_Date_Max]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_TokenAttribute_Date_Max]

(

	@GUID_Type uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT        MAX(val) AS Max_Val

FROM            dbo.TokenAttribute_Date() AS TokenAttribute_Date_1

WHERE        (GUID_Type = @GUID_Type) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_Token_Attribute_Time]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_Token_Attribute_Time]

   ON  [dbo].[semtbl_OR_Token_Attribute_Time]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM Deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

			DELETE FROM semtbl_OR WHERE GUID_ObjectReference=@GUID_ObjectReference;

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_Token_Attribute_VarcharMax]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_Token_Attribute_VarcharMax]

   ON  [dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM Deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

			DELETE FROM semtbl_OR WHERE GUID_ObjectReference=@GUID_ObjectReference;

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insert_semtbl_OR_Token_Attribute_Time]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[insert_semtbl_OR_Token_Attribute_Time]

   ON  [dbo].[semtbl_OR_Token_Attribute_Time]

   AFTER INSERT

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''Insert'');



	DECLARE cur_Inserted CURSOR FOR

		SELECT * FROM inserted;

	OPEN cur_Inserted;



	FETCH NEXT FROM cur_Inserted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

		END

		

		FETCH NEXT FROM cur_Inserted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Inserted;

	DEALLOCATE cur_Inserted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Int_By_GUIDAttribute_And_GUIDToken]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenAttribute_Int_By_GUIDAttribute_And_GUIDToken]

(

	@GUID_Token uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     GUID_Token, Name_Token, GUID_Type, GUID_Attribute, Name_Attribute, GUID_AttributeType, val, OrderID, GUID_TokenAttribute

FROM         dbo.TokenAttribute_Int() AS TokenAttribute_Int_1

WHERE     (GUID_Token = @GUID_Token) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Bit_By_GUIDAttribute_And_GUIDToken]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenAttribute_Bit_By_GUIDAttribute_And_GUIDToken]

(

	@GUID_Token uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     GUID_Token, Name_Token, GUID_Type, GUID_Attribute, Name_Attribute, GUID_AttributeType, val, OrderID, GUID_TokenAttribute

FROM         dbo.TokenAttribute_Bit() AS TokenAttribute_Bit_1

WHERE     (GUID_Token = @GUID_Token) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[delete_semtbl_OR_Token_Attribute_Date]') AND type='TR')
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE TRIGGER [dbo].[delete_semtbl_OR_Token_Attribute_Date]

   ON  [dbo].[semtbl_OR_Token_Attribute_Date]

   AFTER DELETE

AS 

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

	DECLARE @Name_DB					varchar(255);

	DECLARE @GUID_DB					uniqueidentifier;

	DECLARE @GUID_ObjectReference		uniqueidentifier;

	DECLARE @GUID_Transaction_Action	uniqueidentifier;

	DECLARE @GUID_Transaction			uniqueidentifier;

	DECLARE @GUID_TokenAttribute			uniqueidentifier;

	DECLARE @intVersion					int;



    -- Insert statements for trigger here

	SET @Name_DB = db_name();

	SET @GUID_DB = (SELECT     GUID_DB

		FROM         chngtbll_DB

		WHERE     (Name_DB = @Name_DB));

	SET @GUID_Transaction_Action = dbo.get_GUID_Action(''delete'');



	DECLARE cur_Deleted CURSOR FOR

		SELECT * FROM Deleted;

	OPEN cur_Deleted;



	FETCH NEXT FROM cur_Deleted INTO

		@GUID_ObjectReference,

		@GUID_TokenAttribute;

	WHILE @@FETCH_STATUS=0

	BEGIN

		SET @GUID_Transaction = newid();

		INSERT INTO chngtbll_Transaction (GUID_Transaction, GUID_Action, TransactionDate_Start) VALUES(@GUID_Transaction,@GUID_Transaction_Action,getdate());

		if @@ERROR=0

		BEGIN

			SET @intVersion = dbo.get_MaxVersion_OR_TokenAttribute(@GUID_ObjectReference,@GUID_DB);

			SET @intVersion = isnull(@intVersion,0);

			SET @intVersion = @intVersion + 1;

			INSERT INTO chngtbll_OR_TokenAttribute VALUES(@intVersion,@GUID_ObjectReference,@GUID_DB,@GUID_TokenAttribute,@GUID_Transaction);	

			DELETE FROM semtbl_OR WHERE GUID_ObjectReference=@GUID_ObjectReference;

		END

		

		FETCH NEXT FROM cur_Deleted INTO

			@GUID_ObjectReference,

			@GUID_TokenAttribute;

	END

	CLOSE cur_Deleted;

	DEALLOCATE cur_Deleted;

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TokenAttribute_Datetime_By_GUIDAttribute_And_GUIDToken]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[TokenAttribute_Datetime_By_GUIDAttribute_And_GUIDToken]

(

	@GUID_Token uniqueidentifier,

	@GUID_Attribute uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     GUID_Token, Name_Token, GUID_Type, GUID_Attribute, Name_Attribute, GUID_AttributeType, val, OrderID, GUID_TokenAttribute

FROM         dbo.TokenAttribute_Datetime() AS TokenAttribute_Datetime_1

WHERE     (GUID_Token = @GUID_Token) AND (GUID_Attribute = @GUID_Attribute)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_related_ModuleActivators_With_RelatedObjectReferenceTypes]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE FUNCTION [dbo].[func_related_ModuleActivators_With_RelatedObjectReferenceTypes] 

(	

	-- Add the parameters for the function here

	@GUID_Type_ModuleActivator			uniqueidentifier,

	@GUID_RelationType_offersFor		uniqueidentifier,

	@GUID_Attribute_Type				uniqueidentifier,

	@GUID_Attribute_Token				uniqueidentifier,

	@GUID_Attribute_RelationType		uniqueidentifier,

	@GUID_Attribute_Attribute			uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     func_ModuleActivator_With_RelatedObjectReferenceType_1.GUID_ModuleActivator, 

                      func_ModuleActivator_With_RelatedObjectReferenceType_1.Name_ModuleActivator, 

                      func_ModuleActivator_With_RelatedObjectReferenceType_1.GUID_Type_ModuleActivator, semtbl_Token_Token.GUID_Token_Left AS GUID_Module, 

                      func_ModuleActivator_With_RelatedObjectReferenceType_1.GUID_TokenAttribute_Attribute, func_ModuleActivator_With_RelatedObjectReferenceType_1.Attribute, 

                      func_ModuleActivator_With_RelatedObjectReferenceType_1.GUID_TokenAttribute_RelationType, 

                      func_ModuleActivator_With_RelatedObjectReferenceType_1.RelationType, func_ModuleActivator_With_RelatedObjectReferenceType_1.GUID_TokenAttribute_Token, 

                      func_ModuleActivator_With_RelatedObjectReferenceType_1.Token, func_ModuleActivator_With_RelatedObjectReferenceType_1.GUID_TokenAttribute_Type, 

                      func_ModuleActivator_With_RelatedObjectReferenceType_1.Type

FROM         dbo.func_ModuleActivator_With_RelatedObjectReferenceTypes(@GUID_Type_ModuleActivator, @GUID_Attribute_Type,@GUID_Attribute_Token,@GUID_Attribute_RelationType,@GUID_Attribute_Attribute) 

                      AS func_ModuleActivator_With_RelatedObjectReferenceType_1 INNER JOIN

                      semtbl_Token_Token ON func_ModuleActivator_With_RelatedObjectReferenceType_1.GUID_ModuleActivator = semtbl_Token_Token.GUID_Token_Right

WHERE     (semtbl_Token_Token.GUID_RelationType = @GUID_RelationType_offersFor)

)
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_ModuleActivator_With_RelatedObjectReferenceType]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_ModuleActivator_With_RelatedObjectReferenceType]

	-- Add the parameters for the stored procedure here

	

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Type_ModuleActivator			uniqueidentifier;

	DECLARE @GUID_Attribute_Type				uniqueidentifier;

	DECLARE @GUID_Attribute_Token				uniqueidentifier;

	DECLARE @GUID_Attribute_RelationType		uniqueidentifier;

	DECLARE @GUID_Attribute_Attribute			uniqueidentifier;

	



	SET @GUID_Type_ModuleActivator			= dbo.func_Named_GUIDType(''Module-Activator'');

	SET @GUID_Attribute_Type				= dbo.func_Named_GUIDAttribute(''Type'');

	SET @GUID_Attribute_Token				= dbo.func_Named_GUIDAttribute(''Token'');

	SET @GUID_Attribute_RelationType		= dbo.func_Named_GUIDAttribute(''RelationType'');

	SET @GUID_Attribute_Attribute			= dbo.func_Named_GUIDAttribute(''Attribute'');



	PRINT @GUID_Type_ModuleActivator;

	



    -- Insert statements for procedure here

	SELECT * FROM func_ModuleActivator_With_RelatedObjectReferenceTypes(

		@GUID_Type_ModuleActivator,

		@GUID_Attribute_Type,

		@GUID_Attribute_Token,

		@GUID_Attribute_RelationType,

		@GUID_Attribute_Attribute)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_related_ModuleActivator_With_RelatedObjectReferenceType_By_GUIDModule]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[proc_related_ModuleActivator_With_RelatedObjectReferenceType_By_GUIDModule]

(

	@GUID_Type_ModuleActivator uniqueidentifier,

	@GUID_RelationType_offersFor uniqueidentifier,

	@GUID_Attribute_Type				uniqueidentifier,

	@GUID_Attribute_Token				uniqueidentifier,

	@GUID_Attribute_RelationType		uniqueidentifier,

	@GUID_Attribute_Attribute			uniqueidentifier,

	@GUID_Module uniqueidentifier

)

AS

	SET NOCOUNT ON;

SELECT     GUID_ModuleActivator, Name_ModuleActivator, GUID_TokenAttribute_Attribute, Attribute, GUID_TokenAttribute_RelationType, RelationType, 

                      GUID_TokenAttribute_Token, Token, GUID_TokenAttribute_Type, Type, GUID_Type_ModuleActivator

FROM         dbo.func_related_ModuleActivators_With_RelatedObjectReferenceTypes(@GUID_Type_ModuleActivator, @GUID_RelationType_offersFor, @GUID_Attribute_Type, 

                      @GUID_Attribute_Token, @GUID_Attribute_RelationType, @GUID_Attribute_Attribute) AS func_related_ModuleActivators_With_RelatedObjectReferenceType_1

WHERE     (GUID_Module = @GUID_Module)
'
END
GO
INSERT INTO chngtbll_db VALUES('29114adb-d74e-4b94-80ce-0f7c8941c500','sem_db_system')
GO
IF (SELECT COUNT(*) FROM semtbl_AttributeType WHERE GUID_AttributeType='64530b52-d96c-4df1-86fe-183f44513450')=0
	INSERT INTO semtbl_AttributeType VALUES('64530b52-d96c-4df1-86fe-183f44513450','STRING')
GO
IF (SELECT COUNT(*) FROM semtbl_AttributeType WHERE GUID_AttributeType='a1244d0e-187f-46ee-8574-2fc334077b7d')=0
	INSERT INTO semtbl_AttributeType VALUES('a1244d0e-187f-46ee-8574-2fc334077b7d','REAL')
GO
IF (SELECT COUNT(*) FROM semtbl_AttributeType WHERE GUID_AttributeType='905fda81-788f-4e3d-8329-3e55ae984b9e')=0
	INSERT INTO semtbl_AttributeType VALUES('905fda81-788f-4e3d-8329-3e55ae984b9e','DATETIME')
GO
IF (SELECT COUNT(*) FROM semtbl_AttributeType WHERE GUID_AttributeType='dd858f27-d5e1-4363-a5c3-3e561e432333')=0
	INSERT INTO semtbl_AttributeType VALUES('dd858f27-d5e1-4363-a5c3-3e561e432333','BOOL')
GO
IF (SELECT COUNT(*) FROM semtbl_AttributeType WHERE GUID_AttributeType='065e644e-c7df-4007-8672-aa5414131c78')=0
	INSERT INTO semtbl_AttributeType VALUES('065e644e-c7df-4007-8672-aa5414131c78','VARCHAR255')
GO
IF (SELECT COUNT(*) FROM semtbl_AttributeType WHERE GUID_AttributeType='d46f62a9-1744-4fc7-8262-bce6907d1598')=0
	INSERT INTO semtbl_AttributeType VALUES('d46f62a9-1744-4fc7-8262-bce6907d1598','DATE')
GO
IF (SELECT COUNT(*) FROM semtbl_AttributeType WHERE GUID_AttributeType='54335ea6-8139-4624-8f0d-c593d9f9b05a')=0
	INSERT INTO semtbl_AttributeType VALUES('54335ea6-8139-4624-8f0d-c593d9f9b05a','TIME')
GO
IF (SELECT COUNT(*) FROM semtbl_AttributeType WHERE GUID_AttributeType='3a4f5b7b-da75-4980-933e-fbc33cc51439')=0
	INSERT INTO semtbl_AttributeType VALUES('3a4f5b7b-da75-4980-933e-fbc33cc51439','INT')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='3a7f5573-bfac-4260-a8b7-0642b03496d8')=0
	INSERT INTO semtbl_ORType VALUES('3a7f5573-bfac-4260-a8b7-0642b03496d8','Token-Attribute-Int')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='5c78451d-fe48-48cc-bd49-0a47f947dfc6')=0
	INSERT INTO semtbl_ORType VALUES('5c78451d-fe48-48cc-bd49-0a47f947dfc6','Type')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='4455e61e-7979-43c5-8d99-0ac1543dca9e')=0
	INSERT INTO semtbl_ORType VALUES('4455e61e-7979-43c5-8d99-0ac1543dca9e','Token-Attribute-Date')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='fb3e6984-8f8a-4ab1-b12f-13960b5e2fd6')=0
	INSERT INTO semtbl_ORType VALUES('fb3e6984-8f8a-4ab1-b12f-13960b5e2fd6','Token_OR_Type')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='66a7f5c9-bff6-40dc-a893-15bdb65dbf26')=0
	INSERT INTO semtbl_ORType VALUES('66a7f5c9-bff6-40dc-a893-15bdb65dbf26','Attribute')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='1d0aad57-7792-4a55-8d6f-1e71c8860d8a')=0
	INSERT INTO semtbl_ORType VALUES('1d0aad57-7792-4a55-8d6f-1e71c8860d8a','Token_OR_Attribute')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='9badedeb-a8ac-4656-864e-1f62e0eb6253')=0
	INSERT INTO semtbl_ORType VALUES('9badedeb-a8ac-4656-864e-1f62e0eb6253','Token_OR_Token_Attribute_Int')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='970347d0-5efe-445f-9195-3fe0d339e70e')=0
	INSERT INTO semtbl_ORType VALUES('970347d0-5efe-445f-9195-3fe0d339e70e','Token_OR_Type_Type')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='47a44c65-9586-4f87-b7fc-4157991020f1')=0
	INSERT INTO semtbl_ORType VALUES('47a44c65-9586-4f87-b7fc-4157991020f1','Token_OR')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='446f0208-079b-4352-b50e-41e95813a8ba')=0
	INSERT INTO semtbl_ORType VALUES('446f0208-079b-4352-b50e-41e95813a8ba','Token_OR_Token_Token')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='0f2e3328-aeab-4aec-818d-453500abc23a')=0
	INSERT INTO semtbl_ORType VALUES('0f2e3328-aeab-4aec-818d-453500abc23a','Token_OR_RelationType')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='27665665-4733-4694-8fd1-4a0e30a45d53')=0
	INSERT INTO semtbl_ORType VALUES('27665665-4733-4694-8fd1-4a0e30a45d53','Token_OR_Token_Attribute_Bit')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='473c7cc8-44e9-43f8-b085-5a102df01923')=0
	INSERT INTO semtbl_ORType VALUES('473c7cc8-44e9-43f8-b085-5a102df01923','Token_OR_Token_Attribute_Varchar255')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='f58f33d3-2f14-448e-950c-5e0aca7f984e')=0
	INSERT INTO semtbl_ORType VALUES('f58f33d3-2f14-448e-950c-5e0aca7f984e','Type-Type')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='270e8f89-c1f1-49bf-8ca3-76f3e870c4cd')=0
	INSERT INTO semtbl_ORType VALUES('270e8f89-c1f1-49bf-8ca3-76f3e870c4cd','Token-Attribute-VarcharMAX')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='d35d5196-2d47-4cfa-bcb7-864ecbc93105')=0
	INSERT INTO semtbl_ORType VALUES('d35d5196-2d47-4cfa-bcb7-864ecbc93105','Token_OR_Token_Attribute_VARCHARMAX')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='761b8a7e-e65c-428a-804b-8e1d3def7c4b')=0
	INSERT INTO semtbl_ORType VALUES('761b8a7e-e65c-428a-804b-8e1d3def7c4b','RelationType')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='92293b0c-17dd-4388-9a5e-94eaf6ea3980')=0
	INSERT INTO semtbl_ORType VALUES('92293b0c-17dd-4388-9a5e-94eaf6ea3980','Token-Attribute-Time')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='950ec1c7-0487-4b0f-89fc-96d825c2932c')=0
	INSERT INTO semtbl_ORType VALUES('950ec1c7-0487-4b0f-89fc-96d825c2932c','Token-Attribute-Real')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='cf26bd95-6346-4d0a-a677-9a42b65147af')=0
	INSERT INTO semtbl_ORType VALUES('cf26bd95-6346-4d0a-a677-9a42b65147af','Token-Attribute-Datetime')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='c4ac78ca-3d79-449f-90ed-9c28085afb4b')=0
	INSERT INTO semtbl_ORType VALUES('c4ac78ca-3d79-449f-90ed-9c28085afb4b','Token_OR_Token_Attribute_Real')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='5bce0cee-f45b-4c88-a033-a186a87c7717')=0
	INSERT INTO semtbl_ORType VALUES('5bce0cee-f45b-4c88-a033-a186a87c7717','Type_OR')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='08d1b667-6e6a-4ed6-a95f-abe7fc804438')=0
	INSERT INTO semtbl_ORType VALUES('08d1b667-6e6a-4ed6-a95f-abe7fc804438','Type-Attribute')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='d1ad6985-74bf-48c8-9af5-ac98defab2a5')=0
	INSERT INTO semtbl_ORType VALUES('d1ad6985-74bf-48c8-9af5-ac98defab2a5','Token_OR_Token_Attribute_Time')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='96a49593-49f6-4293-9b2f-b34d79eaf5cc')=0
	INSERT INTO semtbl_ORType VALUES('96a49593-49f6-4293-9b2f-b34d79eaf5cc','Token_OR_Token_Attribute_Datetime')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='9d823a2a-811f-4d40-9cbe-b5f474faf1f2')=0
	INSERT INTO semtbl_ORType VALUES('9d823a2a-811f-4d40-9cbe-b5f474faf1f2','Token_OR_Type_Attribute')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='ec94120d-cd9a-47ba-854e-b6641fbcbfa1')=0
	INSERT INTO semtbl_ORType VALUES('ec94120d-cd9a-47ba-854e-b6641fbcbfa1','Token_OR_AttributeType')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='4cef5745-b03c-4d34-9165-b865a7d384b1')=0
	INSERT INTO semtbl_ORType VALUES('4cef5745-b03c-4d34-9165-b865a7d384b1','Token')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='cab70b63-6047-4433-98c1-be3afbf0aeed')=0
	INSERT INTO semtbl_ORType VALUES('cab70b63-6047-4433-98c1-be3afbf0aeed','Token_OR_Token_Attribute_Date')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='e335ffdb-33db-429a-b66e-c78124192939')=0
	INSERT INTO semtbl_ORType VALUES('e335ffdb-33db-429a-b66e-c78124192939','AttributeType')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='3d57c8bf-ff04-4e27-b68c-ce04e03c98f9')=0
	INSERT INTO semtbl_ORType VALUES('3d57c8bf-ff04-4e27-b68c-ce04e03c98f9','Token-Attribute-Varchar255')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='6424d126-38ca-44d7-b005-db733cbba390')=0
	INSERT INTO semtbl_ORType VALUES('6424d126-38ca-44d7-b005-db733cbba390','Token-Attribute-Bit')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='7a66b60a-f914-4c09-affd-df60231cdd9a')=0
	INSERT INTO semtbl_ORType VALUES('7a66b60a-f914-4c09-affd-df60231cdd9a','Token_OR_Token')
GO
IF (SELECT COUNT(*) FROM semtbl_ORType WHERE GUID_ObjectReferenceType='56525b02-c295-404c-8987-eb40e8dc9e04')=0
	INSERT INTO semtbl_ORType VALUES('56525b02-c295-404c-8987-eb40e8dc9e04','Token-Token')
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	insert into semtbl_RelationType VALUES(''9996494a-ef6a-4357-a6ef-71a92b5ff596'',''is of Type'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	insert into semtbl_RelationType VALUES(''e9711603-47db-44d8-a476-fe88290639a4'',''contains'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	insert into semtbl_RelationType VALUES(''e07469d9-766c-443e-8526-6d9c684f944f'',''belongs to'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	insert into semtbl_RelationType VALUES(''fafc1464-815f-4596-9737-bcbc96bd744a'',''needs'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type=''49fdcd27-e105-4770-941d-7485dcad08c1'') = 0
	insert into semtbl_Type (GUID_Type,Name_Type) VALUES(''49fdcd27-e105-4770-941d-7485dcad08c1'',''Root'')'
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='83317bac-b4b1-4db8-bf84-9fca0a93ddd5') = 0
	insert into semtbl_Type VALUES('83317bac-b4b1-4db8-bf84-9fca0a93ddd5','Information-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='3d1dc6cf-b964-4986-9808-f39b7c5c3907') = 0
	insert into semtbl_Type VALUES('3d1dc6cf-b964-4986-9808-f39b7c5c3907','Direction','83317bac-b4b1-4db8-bf84-9fca0a93ddd5')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='665dd88b-792e-4256-a27a-68ee1e10ece6') = 0
	insert into semtbl_Type VALUES('665dd88b-792e-4256-a27a-68ee1e10ece6','System','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='53136d10-b7e7-47fc-94ad-7887a354d6e1') = 0
	insert into semtbl_Type VALUES('53136d10-b7e7-47fc-94ad-7887a354d6e1','Log-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='1d9568af-b6da-4990-8f4d-907dfdd30749') = 0
	insert into semtbl_Type VALUES('1d9568af-b6da-4990-8f4d-907dfdd30749','Logstate','53136d10-b7e7-47fc-94ad-7887a354d6e1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='73e32abf-e577-4d31-9a46-bc07e9e15de3') = 0
	insert into semtbl_Type VALUES('73e32abf-e577-4d31-9a46-bc07e9e15de3','Software-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='71415eeb-ce46-4b2c-b0a2-f72116b55438') = 0
	insert into semtbl_Type VALUES('71415eeb-ce46-4b2c-b0a2-f72116b55438','Software-Development','73e32abf-e577-4d31-9a46-bc07e9e15de3')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='c6c9bcb8-0ac9-4713-9417-eeec1453026c') = 0
	insert into semtbl_Type VALUES('c6c9bcb8-0ac9-4713-9417-eeec1453026c','Development-Config','71415eeb-ce46-4b2c-b0a2-f72116b55438')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='13c09f11-175c-4eef-bc8a-0fd8e86d557f') = 0
	insert into semtbl_Type VALUES('13c09f11-175c-4eef-bc8a-0fd8e86d557f','Development-ConfigItem','c6c9bcb8-0ac9-4713-9417-eeec1453026c')
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cc99d536-5d56-4fd2-9d4f-45b48af33029'') = 0
	insert into semtbl_Token VALUES(''cc99d536-5d56-4fd2-9d4f-45b48af33029'',''Left-Right'',''3d1dc6cf-b964-4986-9808-f39b7c5c3907'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bb6a9555-3af6-40fc-9fb0-489d2678dff2'') = 0
	insert into semtbl_Token VALUES(''bb6a9555-3af6-40fc-9fb0-489d2678dff2'',''Delete'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fb4cd678-b890-4538-9b22-93128e375c09'') = 0
	insert into semtbl_Token VALUES(''fb4cd678-b890-4538-9b22-93128e375c09'',''Relation Change'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cc714341-7631-4b78-b8f4-385db073635f'') = 0
	insert into semtbl_Token VALUES(''cc714341-7631-4b78-b8f4-385db073635f'',''Error'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''84251164-265e-4e02-94b2-ed7c40a02e56'') = 0
	insert into semtbl_Token VALUES(''84251164-265e-4e02-94b2-ed7c40a02e56'',''Success'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a6df6ab2-3590-45b1-b325-35334a2f574a'') = 0
	insert into semtbl_Token VALUES(''a6df6ab2-3590-45b1-b325-35334a2f574a'',''Insert'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''061243fc-4c13-4bd5-800c-2c33b70e99b2'') = 0
	insert into semtbl_Token VALUES(''061243fc-4c13-4bd5-800c-2c33b70e99b2'',''Right-Left'',''3d1dc6cf-b964-4986-9808-f39b7c5c3907'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''95666887-fb2a-416e-9624-a48d48dc5446'') = 0
	insert into semtbl_Token VALUES(''95666887-fb2a-416e-9624-a48d48dc5446'',''Nothing'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a46b7472-3c8e-44a8-b785-3913b760db22'') = 0
	insert into semtbl_Token VALUES(''a46b7472-3c8e-44a8-b785-3913b760db22'',''Relation'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2bf7e9d6-fb9c-4092-9b16-ecc4fef7c072'') = 0
	insert into semtbl_Token VALUES(''2bf7e9d6-fb9c-4092-9b16-ecc4fef7c072'',''Update'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0b285306-f64d-4444-bffe-627a21687eff'') = 0
	insert into semtbl_Token VALUES(''0b285306-f64d-4444-bffe-627a21687eff'',''Exists'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9ad67d25-455c-47b1-9c3b-4d80e9a844af'') = 0
	insert into semtbl_Token VALUES(''9ad67d25-455c-47b1-9c3b-4d80e9a844af'',''Attribute Change'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
EXEC sp_addextendedproperty 
		@name = SchemaVersion, @value = '0.1.0.36';
GO
EXEC sp_addextendedproperty 
		@name = SemDB, @value = 'Yes';
GO
