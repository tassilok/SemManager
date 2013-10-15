use [sem_db_work_timemanagement_module]
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_DateTimestamp]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
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

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''belonging'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
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

END'
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

END'
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
)'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Timemanagement]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Timemanagement]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Timemanagement'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Timemanagement]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Timemanagement] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Timemanagement		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Timemanagement, Name_Token AS Name_Timemanagement, GUID_Type AS GUID_Type_Timemanagement
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Timemanagement)
)'
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
