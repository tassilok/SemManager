use [sem_db_system_change_module]
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

END'
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

END'
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

END'
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

END'
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

END'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_Resource]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_Resource]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''belonging Resource'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
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

END'
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

END'
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
)'
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
)'
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
)'
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

END'
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
)'
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

END'
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

END'
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
)'
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
)'
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

END'
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
)'
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
)'
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
