use [sem_db_work]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Valutatag]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Valutatag]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''Valutatag'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);

	-- Return the result of the function
	RETURN @GUID_AttributeType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Menge]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Menge]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''Menge'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);

	-- Return the result of the function
	RETURN @GUID_AttributeType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Beg_nstigter_Zahlungspflichtiger]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Beg_nstigter_Zahlungspflichtiger]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''Begünstigter/Zahlungspflichtiger'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);

	-- Return the result of the function
	RETURN @GUID_AttributeType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_percent]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_percent]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''percent'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);

	-- Return the result of the function
	RETURN @GUID_AttributeType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Zahlungsausgang]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Zahlungsausgang]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''Zahlungsausgang'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);

	-- Return the result of the function
	RETURN @GUID_AttributeType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Gross__Standard_]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Gross__Standard_]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''Gross (Standard)'';
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Transaction_ID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Transaction_ID]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''Transaction-ID'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);

	-- Return the result of the function
	RETURN @GUID_AttributeType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Betrag]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Betrag]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''Betrag'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);

	-- Return the result of the function
	RETURN @GUID_AttributeType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Transaction_Date]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Transaction_Date]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''Transaction-Date'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);

	-- Return the result of the function
	RETURN @GUID_AttributeType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Amount]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Amount]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''Amount'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);

	-- Return the result of the function
	RETURN @GUID_AttributeType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_gross]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_gross]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''gross'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);

	-- Return the result of the function
	RETURN @GUID_AttributeType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_to_Pay]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_to_Pay]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''to Pay'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);

	-- Return the result of the function
	RETURN @GUID_AttributeType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_part____]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_part____]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''part / %'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);

	-- Return the result of the function
	RETURN @GUID_AttributeType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Info]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Info]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''Info'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);

	-- Return the result of the function
	RETURN @GUID_AttributeType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Buchungstext]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Buchungstext]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''Buchungstext'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);

	-- Return the result of the function
	RETURN @GUID_AttributeType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Verwendungszweck]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Verwendungszweck]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''Verwendungszweck'';
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_factor]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_factor]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_AttributeType			uniqueidentifier;
	DECLARE @Name_AttributeType			varchar(255);

	SET @Name_AttributeType = ''factor'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);

	-- Return the result of the function
	RETURN @GUID_AttributeType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_Payment]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_Payment]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''belonging Payment'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_Standard]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_Standard]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''Standard'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_Amount]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_Amount]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''belonging Amount'';
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_Currency]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_Currency]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''belonging Currency'';
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_zugeh_rige_Mandanten]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_zugeh_rige_Mandanten]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''zugehörige Mandanten'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_Tax_Rate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_Tax_Rate]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''belonging Tax-Rate'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_Contractor]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_Contractor]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''belonging Contractor'';
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_accountings]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_accountings]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''accountings'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_Contractee]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_Contractee]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''belonging Contractee'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_Gegenkonto]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_Gegenkonto]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''Gegenkonto'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_offers]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_offers]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''offers'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_Sem_Item]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_Sem_Item]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''belonging Sem-Item'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_Auftragskonto]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_Auftragskonto]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''Auftragskonto'';
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_is_partner_of]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_is_partner_of]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''is partner of'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_contact]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_contact]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''contact'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_Base]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_Base]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''Base'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_additional]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_additional]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	-- Declare the return variable here
	DECLARE @GUID_RelationType			uniqueidentifier;
	DECLARE @Name_RelationType			varchar(255);

	SET @Name_RelationType = ''additional'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);

	-- Return the result of the function
	RETURN @GUID_RelationType

END'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Bank_Transaktionen__Sparkasse_]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Bank_Transaktionen__Sparkasse_]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Bank-Transaktionen (Sparkasse)'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Bank_Transaktionen__Sparkasse_]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Bank_Transaktionen__Sparkasse_] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Bank_Transaktionen__Sparkasse_		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Bank_Transaktionen__Sparkasse_, Name_Token AS Name_Bank_Transaktionen__Sparkasse_, GUID_Type AS GUID_Type_Bank_Transaktionen__Sparkasse_
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Bank_Transaktionen__Sparkasse_)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Container__Physical_]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Container__Physical_]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Container (Physical)'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Container__Physical_]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Container__Physical_] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Container__Physical_		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Container__Physical_, Name_Token AS Name_Container__Physical_, GUID_Type AS GUID_Type_Container__Physical_
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Container__Physical_)
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Search_Template]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Search_Template]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Search-Template'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Search_Template]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Search_Template] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Search_Template		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Search_Template, Name_Token AS Name_Search_Template, GUID_Type AS GUID_Type_Search_Template
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Search_Template)
)'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Bank_Transaktionen__Sparkasse____Archiv]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Bank_Transaktionen__Sparkasse____Archiv]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Bank-Transaktionen (Sparkasse) - Archiv'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Bank_Transaktionen__Sparkasse____Archiv]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Bank_Transaktionen__Sparkasse____Archiv] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Bank_Transaktionen__Sparkasse____Archiv		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Bank_Transaktionen__Sparkasse____Archiv, Name_Token AS Name_Bank_Transaktionen__Sparkasse____Archiv, GUID_Type AS GUID_Type_Bank_Transaktionen__Sparkasse____Archiv
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Bank_Transaktionen__Sparkasse____Archiv)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Menge]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Menge]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Menge'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Menge]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Menge] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Menge		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Menge, Name_Token AS Name_Menge, GUID_Type AS GUID_Type_Menge
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Menge)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Direction]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Direction]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Direction'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Direction]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Direction] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Direction		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Direction, Name_Token AS Name_Direction, GUID_Type AS GUID_Type_Direction
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Direction)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Payment]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Payment]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Payment'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Payment]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Payment] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Payment		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Payment, Name_Token AS Name_Payment, GUID_Type AS GUID_Type_Payment
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Payment)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Financial_Transaction]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Financial_Transaction]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Financial-Transaction'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Financial_Transaction]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Financial_Transaction] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Financial_Transaction		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Financial_Transaction, Name_Token AS Name_Financial_Transaction, GUID_Type AS GUID_Type_Financial_Transaction
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Financial_Transaction)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Beleg]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Beleg]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Beleg'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Beleg]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Beleg] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Beleg		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Beleg, Name_Token AS Name_Beleg, GUID_Type AS GUID_Type_Beleg
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Beleg)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Bill_Module]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Bill_Module]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Bill-Module'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Bill_Module]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Bill_Module] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Bill_Module		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Bill_Module, Name_Token AS Name_Bill_Module, GUID_Type AS GUID_Type_Bill_Module
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Bill_Module)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Bankkonto]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Bankkonto]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Bankkonto'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Bankkonto]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Bankkonto] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Bankkonto		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Bankkonto, Name_Token AS Name_Bankkonto, GUID_Type AS GUID_Type_Bankkonto
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Bankkonto)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Currencies]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Currencies]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Currencies'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Currencies]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Currencies] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Currencies		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Currencies, Name_Token AS Name_Currencies, GUID_Type AS GUID_Type_Currencies
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Currencies)
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Belegsart]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Belegsart]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Belegsart'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Belegsart]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Belegsart] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Belegsart		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Belegsart, Name_Token AS Name_Belegsart, GUID_Type AS GUID_Type_Belegsart
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Belegsart)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Software_Development]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Software_Development]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Software-Development'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Software_Development]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Software_Development] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Software_Development		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Software_Development, Name_Token AS Name_Software_Development, GUID_Type AS GUID_Type_Software_Development
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Software_Development)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Software_Management]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Software_Management]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Software-Management'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Software_Management]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Software_Management] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Software_Management		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Software_Management, Name_Token AS Name_Software_Management, GUID_Type AS GUID_Type_Software_Management
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Software_Management)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Bankinstitut]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Bankinstitut]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Bankinstitut'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Bankinstitut]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Bankinstitut] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Bankinstitut		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Bankinstitut, Name_Token AS Name_Bankinstitut, GUID_Type AS GUID_Type_Bankinstitut
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Bankinstitut)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Einheit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Einheit]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Einheit'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Einheit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Einheit] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Einheit		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Einheit, Name_Token AS Name_Einheit, GUID_Type AS GUID_Type_Einheit
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Einheit)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Tax_Rates]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Tax_Rates]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Tax-Rates'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Tax_Rates]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Tax_Rates] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Tax_Rates		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Tax_Rates, Name_Token AS Name_Tax_Rates, GUID_Type AS GUID_Type_Tax_Rates
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Tax_Rates)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Offset]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Offset]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Offset'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Offset]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Offset] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Offset		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Offset, Name_Token AS Name_Offset, GUID_Type AS GUID_Type_Offset
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Offset)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Partner]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Partner]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Partner'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Partner]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Partner] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Partner		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Partner, Name_Token AS Name_Partner, GUID_Type AS GUID_Type_Partner
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Partner)
)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Financial_Transaction___Archive]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Financial_Transaction___Archive]
(
	-- Add the parameters for the function here
	
)
RETURNS uniqueidentifier
AS
BEGIN
	DECLARE @GUID_Type			uniqueidentifier;
	DECLARE @Name_Type			varchar(255);

	SET @Name_Type = ''Financial-Transaction - Archive'';
	-- Add the T-SQL statements to compute the return value here
	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);

	-- Return the result of the function
	RETURN @GUID_Type

END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Financial_Transaction___Archive]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Financial_Transaction___Archive] 
(	
	-- Add the parameters for the function here
	@GUID_Type_Financial_Transaction___Archive		uniqueidentifier
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     GUID_Token AS GUID_Financial_Transaction___Archive, Name_Token AS Name_Financial_Transaction___Archive, GUID_Type AS GUID_Type_Financial_Transaction___Archive
FROM         semtbl_Token
WHERE     (GUID_Type = @GUID_Type_Financial_Transaction___Archive)
)'
END
GO
