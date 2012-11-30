CREATE DATABASE sem_db_change
GO
use [sem_db_change]
use [sem_db_change]
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Transaction_Action]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Transaction_Action](
	[GUID_Action] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
 CONSTRAINT [PK_chngtbl_Transaction_Action] PRIMARY KEY CLUSTERED 
(
	[GUID_Action] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Transaction_Action] ADD  CONSTRAINT [DF_chngtbl_Transaction_Action_GUID_Action]  DEFAULT (newid()) FOR [GUID_Action];

INSERT INTO chngtbl_Transaction_Action VALUES (''A6DF6AB2-3590-45B1-B325-35334A2F574A'',''Insert'');
INSERT INTO chngtbl_Transaction_Action VALUES (''BB6A9555-3AF6-40FC-9FB0-489D2678DFF2'',''Delete'');
INSERT INTO chngtbl_Transaction_Action VALUES (''9AD67D25-455C-47B1-9C3B-4D80E9A844AF'',''Attribute Change'');
INSERT INTO chngtbl_Transaction_Action VALUES (''FB4CD678-B890-4538-9B22-93128E375C09'',''Relation Change'');
INSERT INTO chngtbl_Transaction_Action VALUES (''2BF7E9D6-FB9C-4092-9B16-ECC4FEF7C072'',''Update'');
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_DB]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_DB](
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Name_DB] [varchar](255) NOT NULL,
	[is_SystemDB] [bit] NOT NULL,
 CONSTRAINT [PK_chngtbl_DB] PRIMARY KEY CLUSTERED 
(
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_DB] ADD  CONSTRAINT [DF_chngtbl_DB_GUID_DB]  DEFAULT (newid()) FOR [GUID_DB];

ALTER TABLE [dbo].[chngtbl_DB] ADD  CONSTRAINT [DF_chngtbl_DB_is_SystemDB]  DEFAULT ((0)) FOR [is_SystemDB];
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Transaction]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Transaction](
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
	[GUID_Action] [uniqueidentifier] NOT NULL,
	[Transaction_Timestamp] [datetime] NOT NULL,
 CONSTRAINT [PK_chngtbl_Transaction] PRIMARY KEY CLUSTERED 
(
	[GUID_Transaction] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Transaction_chngtbl_Transaction_Action] FOREIGN KEY([GUID_Action])
REFERENCES [dbo].[chngtbl_Transaction_Action] ([GUID_Action]);

ALTER TABLE [dbo].[chngtbl_Transaction] CHECK CONSTRAINT [FK_chngtbl_Transaction_chngtbl_Transaction_Action];

ALTER TABLE [dbo].[chngtbl_Transaction] ADD  CONSTRAINT [DF_chngtbl_Transaction_GUID_Transaction]  DEFAULT (newid()) FOR [GUID_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Type_Rel]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Type_Rel](
	[Version] [int] NOT NULL,
	[GUID_Type_Left] [uniqueidentifier] NOT NULL,
	[GUID_Type_Right] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Min_Forw] [int] NOT NULL,
	[Max_Forw] [int] NOT NULL,
	[Max_Backw] [int] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_Type_Rel] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Type_Left] ASC,
	[GUID_Type_Right] ASC,
	[GUID_RelationType] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Type_Rel]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Type_Rel_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Type_Rel] CHECK CONSTRAINT [FK_chngtbl_Type_Rel_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_Token]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_OR_Token](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_Token] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_OR_Token] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_OR_Token]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_OR_Token_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_OR_Token] CHECK CONSTRAINT [FK_chngtbl_OR_Token_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_TypeAttribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_OR_TypeAttribute](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[GUID_Attribute] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_OR_TypeAttribute] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_OR_TypeAttribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_OR_TypeAttribute_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_OR_TypeAttribute] CHECK CONSTRAINT [FK_chngtbl_OR_TypeAttribute_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_TypeType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_OR_TypeType](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_Type_Left] [uniqueidentifier] NOT NULL,
	[GUID_Type_Right] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_OR_TypeType] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_OR_TypeType]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_OR_TypeType_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_OR_TypeType] CHECK CONSTRAINT [FK_chngtbl_OR_TypeType_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_Type]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_OR_Type](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_OR_Type] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_OR_Type]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_OR_Type_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_OR_Type] CHECK CONSTRAINT [FK_chngtbl_OR_Type_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Type_Attribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Type_Attribute](
	[Version] [int] NOT NULL,
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[GUID_Attribute] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Min] [int] NOT NULL,
	[Max] [int] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_Type_Attribute] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Type] ASC,
	[GUID_Attribute] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Type_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Type_Attribute_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Type_Attribute] CHECK CONSTRAINT [FK_chngtbl_Type_Attribute_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_Attribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_OR_Attribute](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_Attribute] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_OR_Attribute] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_OR_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_OR_Attribute_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_OR_Attribute] CHECK CONSTRAINT [FK_chngtbl_OR_Attribute_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Token]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Token](
	[Version] [int] NOT NULL,
	[GUID_Token] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_Token] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Token] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Token]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Token_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Token] CHECK CONSTRAINT [FK_chngtbl_Token_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_TokenToken]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_OR_TokenToken](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_Token_Left] [uniqueidentifier] NOT NULL,
	[GUID_Token_Right] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_OR_TokenToken] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_OR_TokenToken]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_OR_TokenToken_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_OR_TokenToken] CHECK CONSTRAINT [FK_chngtbl_OR_TokenToken_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_AttributeType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_AttributeType](
	[Version] [int] NOT NULL,
	[GUID_AttributeType] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_Attribute_Type] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_AttributeType] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_AttributeType]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Attribute_Type_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_AttributeType] CHECK CONSTRAINT [FK_chngtbl_Attribute_Type_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Type]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Type](
	[Version] [int] NOT NULL,
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[GUID_Type_Parent] [uniqueidentifier] NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_Type] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Type] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Type]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Type_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Type] CHECK CONSTRAINT [FK_chngtbl_Type_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Token_OR]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Token_OR](
	[Version] [int] NOT NULL,
	[GUID_Token_Left] [uniqueidentifier] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[OrderID] [int] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_Token_OR] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Token_Left] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_RelationType] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Token_OR]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Token_OR_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Token_OR] CHECK CONSTRAINT [FK_chngtbl_Token_OR_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Token_Token]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Token_Token](
	[Version] [int] NOT NULL,
	[GUID_Token_Left] [uniqueidentifier] NOT NULL,
	[GUID_Token_Right] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[OrderID] [int] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_Token_Token] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Token_Left] ASC,
	[GUID_Token_Right] ASC,
	[GUID_RelationType] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Token_Token]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Token_Token_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Token_Token] CHECK CONSTRAINT [FK_chngtbl_Token_Token_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_TokenAttribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_OR_TokenAttribute](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_TokenAttribute] [uniqueidentifier] NOT NULL,
	[GUID_Transation] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_OR_TokenAttribute] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_OR_TokenAttribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_OR_TokenAttribute_chngtbl_Transaction] FOREIGN KEY([GUID_Transation])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_OR_TokenAttribute] CHECK CONSTRAINT [FK_chngtbl_OR_TokenAttribute_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_RelationType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_RelationType](
	[Version] [int] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_RelationType] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_RelationType] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_RelationType]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_RelationType_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_RelationType] CHECK CONSTRAINT [FK_chngtbl_RelationType_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_RelationType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_OR_RelationType](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_OR_RelationType] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_OR_RelationType]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_OR_RelationType_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_OR_RelationType] CHECK CONSTRAINT [FK_chngtbl_OR_RelationType_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Attribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Attribute](
	[Version] [int] NOT NULL,
	[GUID_Attribute] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[GUID_AttributeType] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_Attribute] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Attribute] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Attribute_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Attribute] CHECK CONSTRAINT [FK_chngtbl_Attribute_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Token_Attribute]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Token_Attribute](
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
 CONSTRAINT [PK_chngtbl_Token_Attribute] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_TokenAttribute] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Token_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Token_Attribute_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Token_Attribute] CHECK CONSTRAINT [FK_chngtbl_Token_Attribute_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_OR_AttributeType]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_OR_AttributeType](
	[Version] [int] NOT NULL,
	[GUID_ObjectReference] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[GUID_AttributeType] [uniqueidentifier] NOT NULL,
	[GUID_Transaction] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_OR_AttributeType] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_ObjectReference] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_OR_AttributeType]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_OR_AttributeType_chngtbl_Transaction] FOREIGN KEY([GUID_Transaction])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_OR_AttributeType] CHECK CONSTRAINT [FK_chngtbl_OR_AttributeType_chngtbl_Transaction];
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[chngtbl_Type_OR]') AND type in (N'U'))

BEGIN
execute dbo.sp_executesql @statement = N'CREATE TABLE [dbo].[chngtbl_Type_OR](
	[Version] [int] NOT NULL,
	[GUID_Type] [uniqueidentifier] NOT NULL,
	[GUID_RelationType] [uniqueidentifier] NOT NULL,
	[GUID_DB] [uniqueidentifier] NOT NULL,
	[Min_forw] [int] NOT NULL,
	[Max_forw] [int] NOT NULL,
	[GUID_Transation] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_chngtbl_Type_OR] PRIMARY KEY CLUSTERED 
(
	[Version] ASC,
	[GUID_Type] ASC,
	[GUID_RelationType] ASC,
	[GUID_DB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[chngtbl_Type_OR]  WITH CHECK ADD  CONSTRAINT [FK_chngtbl_Type_OR_chngtbl_Transaction] FOREIGN KEY([GUID_Transation])
REFERENCES [dbo].[chngtbl_Transaction] ([GUID_Transaction])
ON DELETE CASCADE;

ALTER TABLE [dbo].[chngtbl_Type_OR] CHECK CONSTRAINT [FK_chngtbl_Type_OR_chngtbl_Transaction];
'
END
GO
EXEC sp_addextendedproperty 
		@name = SchemaVersion, @value = '0.1.0.2';
GO
EXEC sp_addextendedproperty 
		@name = SemDB, @value = 'Yes';
GO
