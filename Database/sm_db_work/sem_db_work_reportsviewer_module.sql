USE [master]
GO
/****** Object:  Database [sem_db_work_reportsviewer_module]    Script Date: 12/10/2012 17:39:10 ******/
CREATE DATABASE [sem_db_work_reportsviewer_module] ON  PRIMARY 
( NAME = N'sem_db_work_reportsviewer_module', FILENAME = N'C:\Program Files\Microsoft SQL Server.exp\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\sem_db_work_reportsviewer_module.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'sem_db_work_reportsviewer_module_log', FILENAME = N'C:\Program Files\Microsoft SQL Server.exp\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\sem_db_work_reportsviewer_module_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sem_db_work_reportsviewer_module].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET ANSI_NULLS OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET ANSI_PADDING OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET ARITHABORT OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET AUTO_CLOSE ON
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET  ENABLE_BROKER
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET  READ_WRITE
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET RECOVERY SIMPLE
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET  MULTI_USER
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [sem_db_work_reportsviewer_module] SET DB_CHAINING OFF
GO
USE [sem_db_work_reportsviewer_module]
GO
/****** Object:  ExtendedProperty [SemDB]    Script Date: 12/10/2012 17:39:10 ******/
EXEC sys.sp_addextendedproperty @name=N'SemDB', @value=N'Yes'
GO
/****** Object:  ExtendedProperty [SchemaVersion]    Script Date: 12/10/2012 17:39:10 ******/
EXEC sys.sp_addextendedproperty @name=N'SchemaVersion', @value=N'0.0.0.3'
GO
/****** Object:  Synonym [dbo].[semtbl_Type]    Script Date: 12/10/2012 17:39:11 ******/
CREATE SYNONYM [dbo].[semtbl_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type]
GO
/****** Object:  Synonym [dbo].[semtbl_Token_Token]    Script Date: 12/10/2012 17:39:11 ******/
CREATE SYNONYM [dbo].[semtbl_Token_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Token]
GO
/****** Object:  Synonym [dbo].[semtbl_Token_Attribute_Bit]    Script Date: 12/10/2012 17:39:11 ******/
CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Bit] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Bit]
GO
/****** Object:  Synonym [dbo].[semtbl_Token_Attribute]    Script Date: 12/10/2012 17:39:11 ******/
CREATE SYNONYM [dbo].[semtbl_Token_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute]
GO
/****** Object:  Synonym [dbo].[semtbl_Token]    Script Date: 12/10/2012 17:39:11 ******/
CREATE SYNONYM [dbo].[semtbl_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token]
GO
/****** Object:  Synonym [dbo].[semtbl_RelationType]    Script Date: 12/10/2012 17:39:11 ******/
CREATE SYNONYM [dbo].[semtbl_RelationType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_RelationType]
GO
/****** Object:  Synonym [dbo].[semtbl_Attribute]    Script Date: 12/10/2012 17:39:11 ******/
CREATE SYNONYM [dbo].[semtbl_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Attribute]
GO
/****** Object:  StoredProcedure [dbo].[proc_TSQL_Views]    Script Date: 12/10/2012 17:39:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================

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
GO
/****** Object:  StoredProcedure [dbo].[proc_TSQL_Triggers]    Script Date: 12/10/2012 17:39:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================

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
GO
/****** Object:  StoredProcedure [dbo].[proc_TSQL_Tables]    Script Date: 12/10/2012 17:39:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================

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
GO
/****** Object:  StoredProcedure [dbo].[proc_TSQL_Synonyms]    Script Date: 12/10/2012 17:39:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================

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
GO
/****** Object:  StoredProcedure [dbo].[proc_TSQL_Procedures]    Script Date: 12/10/2012 17:39:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================

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
GO
/****** Object:  StoredProcedure [dbo].[proc_TSQL_Parameters]    Script Date: 12/10/2012 17:39:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================

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
GO
/****** Object:  StoredProcedure [dbo].[proc_TSQL_ObjectDefinition]    Script Date: 12/10/2012 17:39:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================

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
GO
/****** Object:  StoredProcedure [dbo].[proc_TSQL_Functions]    Script Date: 12/10/2012 17:39:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================

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

	SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE Routine_Type='FUNCTION' ORDER By ROUTINE_NAME

END
GO
/****** Object:  UserDefinedFunction [dbo].[func_Token_Server]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_Token_Server] 

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

)
GO
/****** Object:  UserDefinedFunction [dbo].[func_Token_Report_Type]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_Token_Report_Type] 

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

)
GO
/****** Object:  UserDefinedFunction [dbo].[func_Token_Report]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_Token_Report] 

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

)
GO
/****** Object:  UserDefinedFunction [dbo].[func_Token_DB_Views]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_Token_DB_Views] 

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

)
GO
/****** Object:  UserDefinedFunction [dbo].[func_Token_DB_Procedure]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_Token_DB_Procedure] 

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

)
GO
/****** Object:  UserDefinedFunction [dbo].[func_Token_Database_on_Server]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_Token_Database_on_Server] 

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

)
GO
/****** Object:  UserDefinedFunction [dbo].[func_Token_Database]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_Token_Database] 

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

)
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_Type_Server]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_Type_Server]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = 'Server';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_Type_Report_Type]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_Type_Report_Type]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = 'Report-Type';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_Type_Report]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_Type_Report]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = 'Report';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_Type_DB_Views]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_Type_DB_Views]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = 'DB-Views';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_Type_DB_Procedure]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_Type_DB_Procedure]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = 'DB-Procedure';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_Type_Database_on_Server]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_Type_Database_on_Server]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = 'Database on Server';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_Type_Database]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_Type_Database]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = 'Database';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_RelationType_located_in]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_RelationType_located_in]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = 'located in';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_RelationType_is_of_Type]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_RelationType_is_of_Type]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = 'is of Type';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_RelationType_is]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_RelationType_is]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = 'is';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_RelationType_contains]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_RelationType_contains]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = 'contains';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_RelationType_belongs_to]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_RelationType_belongs_to]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = 'belongs to';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_AttributeType_ProcessorID]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_AttributeType_ProcessorID]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = 'ProcessorID';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_AttributeType_is_Sem_DB]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_AttributeType_is_Sem_DB]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = 'is Sem-DB';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_AttributeType_is_exported]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_AttributeType_is_exported]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = 'is exported';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_AttributeType_db_postfix]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_AttributeType_db_postfix]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = 'db_postfix';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END
GO
/****** Object:  UserDefinedFunction [dbo].[dbg_AttributeType_BaseboardSerial]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[dbg_AttributeType_BaseboardSerial]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = 'BaseboardSerial';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END
GO
/****** Object:  StoredProcedure [dbo].[proc_ReportFields]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_ReportFields] 
	-- Add the parameters for the stored procedure here
	@GUID_Report		uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @GUID_Type_ReportField				uniqueidentifier
	DECLARE @GUID_Type_Report					uniqueidentifier
	DECLARE @GUID_Type_DBColumn					uniqueidentifier
	DECLARE @GUID_Type_FieldType				uniqueidentifier

	DECLARE @GUID_RelationType_belongsTo		uniqueidentifier
	DECLARE @GUID_RelationType_is				uniqueidentifier
	DECLARE @GUID_RelationType_isOfType			uniqueidentifier
	DECLARE @GUID_RelationType_leads			uniqueidentifier
	
	SET @GUID_Type_ReportField			= 'c790aa5b-14a4-46b0-bd8c-4317ef5716e2'
	SET @GUID_Type_Report				= '30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'
	SET @GUID_Type_DBColumn				= '9053d6ad-8ebb-4f68-bfb0-285d8b38a170'
	SET @GUID_Type_FieldType			= 'a534dc0a-e3c8-4e05-9f86-faaec798f9cc'
	
	SET @GUID_RelationType_belongsTo	= 'e07469d9-766c-443e-8526-6d9c684f944f'
	SET @GUID_RelationType_is			= '3e104b75-e01c-48a0-b041-12908fd446a0'
	SET @GUID_RelationType_isOfType		= '9996494a-ef6a-4357-a6ef-71a92b5ff596'
	SET @GUID_RelationType_leads		= '0fa056ea-474f-424f-ab68-0a10b57d3a95'
	

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
	
END
GO
/****** Object:  StoredProcedure [dbo].[proc_Report]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_Report]

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
GO
/****** Object:  StoredProcedure [dbo].[proc_ReportTree]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

				,p.Path + '\' + c.Name_Report AS Path

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
GO
/****** Object:  StoredProcedure [dbo].[dbg_ReportTree]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================

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

				,p.Path + '\' + c.Name_Report AS Path

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
GO
/****** Object:  StoredProcedure [dbo].[dbg_Report]    Script Date: 12/10/2012 17:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[dbg_Report]

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
GO
/****** Object:  Synonym [dbo].[semtbl_AttributeType]    Script Date: 12/10/2012 17:39:13 ******/
CREATE SYNONYM [dbo].[semtbl_AttributeType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_AttributeType]
GO
/****** Object:  Synonym [dbo].[semtbl_OR]    Script Date: 12/10/2012 17:39:13 ******/
CREATE SYNONYM [dbo].[semtbl_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_Attribute]    Script Date: 12/10/2012 17:39:13 ******/
CREATE SYNONYM [dbo].[semtbl_OR_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Attribute]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_AttributeType]    Script Date: 12/10/2012 17:39:13 ******/
CREATE SYNONYM [dbo].[semtbl_OR_AttributeType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_AttributeType]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_RelationType]    Script Date: 12/10/2012 17:39:13 ******/
CREATE SYNONYM [dbo].[semtbl_OR_RelationType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_RelationType]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_Token]    Script Date: 12/10/2012 17:39:13 ******/
CREATE SYNONYM [dbo].[semtbl_OR_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_Token_Attribute_Bit]    Script Date: 12/10/2012 17:39:13 ******/
CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Bit] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Bit]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_Token_Attribute_Date]    Script Date: 12/10/2012 17:39:13 ******/
CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Date] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Date]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_Token_Attribute_Datetime]    Script Date: 12/10/2012 17:39:13 ******/
CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Datetime] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Datetime]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_Token_Attribute_Int]    Script Date: 12/10/2012 17:39:13 ******/
CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Int] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Int]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_Token_Attribute_Real]    Script Date: 12/10/2012 17:39:13 ******/
CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Real] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Real]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_Token_Attribute_Time]    Script Date: 12/10/2012 17:39:13 ******/
CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Time] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Time]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_Token_Attribute_Varchar255]    Script Date: 12/10/2012 17:39:13 ******/
CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Varchar255] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Varchar255]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]    Script Date: 12/10/2012 17:39:13 ******/
CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_VARCHARMAX] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_Token_Token]    Script Date: 12/10/2012 17:39:14 ******/
CREATE SYNONYM [dbo].[semtbl_OR_Token_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Token]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_Type]    Script Date: 12/10/2012 17:39:14 ******/
CREATE SYNONYM [dbo].[semtbl_OR_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Type]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_Type_Attribute]    Script Date: 12/10/2012 17:39:14 ******/
CREATE SYNONYM [dbo].[semtbl_OR_Type_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Type_Attribute]
GO
/****** Object:  Synonym [dbo].[semtbl_OR_Type_Type]    Script Date: 12/10/2012 17:39:14 ******/
CREATE SYNONYM [dbo].[semtbl_OR_Type_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Type_Type]
GO
/****** Object:  Synonym [dbo].[semtbl_ORType]    Script Date: 12/10/2012 17:39:14 ******/
CREATE SYNONYM [dbo].[semtbl_ORType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_ORType]
GO
/****** Object:  Synonym [dbo].[semtbl_Token_Attribute_Date]    Script Date: 12/10/2012 17:39:14 ******/
CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Date] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Date]
GO
/****** Object:  Synonym [dbo].[semtbl_Token_attribute_datetime]    Script Date: 12/10/2012 17:39:14 ******/
CREATE SYNONYM [dbo].[semtbl_Token_attribute_datetime] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_attribute_datetime]
GO
/****** Object:  Synonym [dbo].[semtbl_Token_Attribute_Int]    Script Date: 12/10/2012 17:39:14 ******/
CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Int] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Int]
GO
/****** Object:  Synonym [dbo].[semtbl_Token_Attribute_Real]    Script Date: 12/10/2012 17:39:14 ******/
CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Real] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Real]
GO
/****** Object:  Synonym [dbo].[semtbl_Token_attribute_time]    Script Date: 12/10/2012 17:39:14 ******/
CREATE SYNONYM [dbo].[semtbl_Token_attribute_time] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_attribute_time]
GO
/****** Object:  Synonym [dbo].[semtbl_Token_Attribute_varchar255]    Script Date: 12/10/2012 17:39:14 ******/
CREATE SYNONYM [dbo].[semtbl_Token_Attribute_varchar255] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_varchar255]
GO
/****** Object:  Synonym [dbo].[semtbl_Token_Attribute_varcharMAX]    Script Date: 12/10/2012 17:39:14 ******/
CREATE SYNONYM [dbo].[semtbl_Token_Attribute_varcharMAX] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_varcharMAX]
GO
/****** Object:  Synonym [dbo].[semtbl_Token_OR]    Script Date: 12/10/2012 17:39:14 ******/
CREATE SYNONYM [dbo].[semtbl_Token_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_OR]
GO
/****** Object:  Synonym [dbo].[semtbl_Type_Attribute]    Script Date: 12/10/2012 17:39:15 ******/
CREATE SYNONYM [dbo].[semtbl_Type_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type_Attribute]
GO
/****** Object:  Synonym [dbo].[semtbl_Type_OR]    Script Date: 12/10/2012 17:39:15 ******/
CREATE SYNONYM [dbo].[semtbl_Type_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type_OR]
GO
/****** Object:  Synonym [dbo].[semtbl_Type_Type]    Script Date: 12/10/2012 17:39:15 ******/
CREATE SYNONYM [dbo].[semtbl_Type_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type_Type]
GO
