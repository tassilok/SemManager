CREATE DATABASE sem_db_work_HTMLExport_Module
GO
use [sem_db_change]
use [sem_db_work_HTMLExport_Module]
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Varchar255]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Varchar255] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Varchar255]'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type_OR]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_VarcharMax]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_varcharMAX] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_varcharMAX]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_AttributeType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_AttributeType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_AttributeType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Date]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Date] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Date]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Datetime]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Datetime] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Datetime]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Time]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_attribute_time] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_attribute_time]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Type_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Type_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Type_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Real]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Real] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Real]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_AttributeType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_AttributeType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_AttributeType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_RelationType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_RelationType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_RelationType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Real]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Real] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Real]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_VARCHARMAX] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_VARCHARMAX]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Type] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Type]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Int]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Int] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Int]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_ORType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_ORType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_ORType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Token]'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_RelationType]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_RelationType] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_RelationType]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Bit]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_Bit] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_Bit]'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Type_Attribute]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Type_Attribute] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Type_Attribute]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Int]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Int] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Int]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Attribute_Varchar255]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Attribute_varchar255] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Attribute_varchar255]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_OR_Token_Attribute_Time]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_OR_Token_Attribute_Time] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_OR_Token_Attribute_Time]'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[semtbl_Token_Token]') AND type='SN')
BEGIN
execute dbo.sp_executesql @statement = N'CREATE SYNONYM [dbo].[semtbl_Token_Token] FOR [h3d-kolltass-01\SQLEXPRESS].[sem_db_work].[dbo].[semtbl_Token_Token]'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_relative]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_relative]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''relative'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_belonging_Token]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_belonging_Token]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''belonging Token'';

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

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Tag_Attributes]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Tag_Attributes]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Tag-Attributes'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_PDF_Documents]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_PDF_Documents]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''PDF-Documents'';

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_HTML_Document]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_HTML_Document]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''HTML-Document'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Major]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Major]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Major'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Attribute_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Attribute_Type] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Attribute_Type		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Attribute_Type, Name_Token AS Name_Attribute_Type, GUID_Type AS GUID_Type_Attribute_Type

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Attribute_Type)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Tag_Attributes]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Tag_Attributes] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Tag_Attributes		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Tag_Attributes, Name_Token AS Name_Tag_Attributes, GUID_Type AS GUID_Type_Tag_Attributes

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Tag_Attributes)

)'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Media_Item]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Media_Item] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Media_Item		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Media_Item, Name_Token AS Name_Media_Item, GUID_Type AS GUID_Type_Media_Item

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Media_Item)

)'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Document_Tag_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Document_Tag_Type]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Document-Tag-Type'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Build]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Build]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Build'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_taking]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_taking]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''taking'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_Tag_End]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_Tag_End]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''Tag-End'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Development_Version]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Development_Version]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Development-Version'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Images__Graphic_]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Images__Graphic_]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Images (Graphic)'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Media_Item]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Media_Item]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Media-Item'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_Tag_Start]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_Tag_Start]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''Tag-Start'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Level]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Level]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Level'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_Intro]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_Intro]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''Intro'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Development_Version]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Development_Version] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Development_Version		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Development_Version, Name_Token AS Name_Development_Version, GUID_Type AS GUID_Type_Development_Version

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Development_Version)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Revision]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Revision]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Revision'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_happened]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_happened]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''happened'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_RelationType = (SELECT GUID_RelationType FROM semtbl_RelationType WHERE Name_RelationType=@Name_RelationType);



	-- Return the result of the function

	RETURN @GUID_RelationType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Zeichen]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Zeichen] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Zeichen		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Zeichen, Name_Token AS Name_Zeichen, GUID_Type AS GUID_Type_Zeichen

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Zeichen)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Datetimestamp__Create_]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Datetimestamp__Create_]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Datetimestamp (Create)'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_relative]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_relative]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''relative'';

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_RelationType_Tag_End_Init]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_RelationType_Tag_End_Init]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_RelationType			uniqueidentifier;

	DECLARE @Name_RelationType			varchar(255);



	SET @Name_RelationType = ''Tag-End-Init'';

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_HTML_Document]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_HTML_Document] 

(	

	-- Add the parameters for the function here

	@GUID_Type_HTML_Document		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_HTML_Document, Name_Token AS Name_HTML_Document, GUID_Type AS GUID_Type_HTML_Document

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_HTML_Document)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_HTML_Tags]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_HTML_Tags] 

(	

	-- Add the parameters for the function here

	@GUID_Type_HTML_Tags		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_HTML_Tags, Name_Token AS Name_HTML_Tags, GUID_Type AS GUID_Type_HTML_Tags

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_HTML_Tags)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Images__Graphic_]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Images__Graphic_] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Images__Graphic_		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Images__Graphic_, Name_Token AS Name_Images__Graphic_, GUID_Type AS GUID_Type_Images__Graphic_

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Images__Graphic_)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_HTMLExport_Module]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_HTMLExport_Module] 

(	

	-- Add the parameters for the function here

	@GUID_Type_HTMLExport_Module		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_HTMLExport_Module, Name_Token AS Name_HTMLExport_Module, GUID_Type AS GUID_Type_HTMLExport_Module

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_HTMLExport_Module)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Document_Parts]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Document_Parts]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Document-Parts'';

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Minor]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Minor]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Minor'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_AttributeType = (SELECT GUID_Attribute FROM semtbl_Attribute WHERE Name_Attribute=@Name_AttributeType);



	-- Return the result of the function

	RETURN @GUID_AttributeType



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_HTML_Tags]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_HTML_Tags]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''HTML-Tags'';

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Document_Tag_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Document_Tag_Type] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Document_Tag_Type		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Document_Tag_Type, Name_Token AS Name_Document_Tag_Type, GUID_Type AS GUID_Type_Document_Tag_Type

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Document_Tag_Type)

)'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_Document_Parts]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_Document_Parts] 

(	

	-- Add the parameters for the function here

	@GUID_Type_Document_Parts		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_Document_Parts, Name_Token AS Name_Document_Parts, GUID_Type AS GUID_Type_Document_Parts

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_Document_Parts)

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



END'
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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Attribute_Type]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Attribute_Type]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Attribute-Type'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_HTMLExport_Module]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_HTMLExport_Module]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''HTMLExport-Module'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



END'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_AttributeType_Datetimestamp__Create_]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_AttributeType_Datetimestamp__Create_]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	-- Declare the return variable here

	DECLARE @GUID_AttributeType			uniqueidentifier;

	DECLARE @Name_AttributeType			varchar(255);



	SET @Name_AttributeType = ''Datetimestamp (Create)'';

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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_Type_Zeichen]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[dbg_Type_Zeichen]

(

	-- Add the parameters for the function here

	

)

RETURNS uniqueidentifier

AS

BEGIN

	DECLARE @GUID_Type			uniqueidentifier;

	DECLARE @Name_Type			varchar(255);



	SET @Name_Type = ''Zeichen'';

	-- Add the T-SQL statements to compute the return value here

	SET @GUID_Type = (SELECT GUID_Type FROM semtbl_Type WHERE Name_Type=@Name_Type);



	-- Return the result of the function

	RETURN @GUID_Type



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
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[func_Token_PDF_Documents]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE FUNCTION [dbo].[func_Token_PDF_Documents] 

(	

	-- Add the parameters for the function here

	@GUID_Type_PDF_Documents		uniqueidentifier

)

RETURNS TABLE 

AS

RETURN 

(

	-- Add the SELECT statement with parameter references here

	SELECT     GUID_Token AS GUID_PDF_Documents, Name_Token AS Name_PDF_Documents, GUID_Type AS GUID_Type_PDF_Documents

FROM         semtbl_Token

WHERE     (GUID_Type = @GUID_Type_PDF_Documents)

)'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_TagSigns]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE dbg_TagSigns 

	-- Add the parameters for the stored procedure here

	@GUID_BaseConfig			uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Type_Zeichen				uniqueidentifier

	DECLARE @GUID_RelationType_TagStart		uniqueidentifier

	DECLARE @GUID_RelationType_TagEnd		uniqueidentifier

	DECLARE @GUID_RelationType_TagEndInit	uniqueidentifier

	

	SET @GUID_Type_Zeichen					= dbo.dbg_Type_Zeichen()

	SET @GUID_RelationType_TagStart			= dbo.dbg_RelationType_Tag_Start()

	SET @GUID_RelationType_TagEnd			= dbo.dbg_RelationType_Tag_End()

	SET @GUID_RelationType_TagEndInit		= dbo.dbg_RelationType_Tag_End_Init()

	

	PRINT @GUID_Type_Zeichen				

	PRINT @GUID_RelationType_TagStart		

	PRINT @GUID_RelationType_TagEnd		

	PRINT @GUID_RelationType_TagEndInit	

	



    -- Insert statements for procedure here

	SELECT     func_Token_Zeichen_1.GUID_Zeichen, func_Token_Zeichen_1.Name_Zeichen, func_Token_Zeichen_1.GUID_Type_Zeichen, Baseconfig_To_Zeichen.GUID_RelationType

	FROM         semtbl_Token_Token AS Baseconfig_To_Zeichen INNER JOIN

						  dbo.func_Token_Zeichen(@GUID_Type_Zeichen) AS func_Token_Zeichen_1 ON 

						  Baseconfig_To_Zeichen.GUID_Token_Right = func_Token_Zeichen_1.GUID_Zeichen

	WHERE     (Baseconfig_To_Zeichen.GUID_RelationType = @GUID_RelationType_TagStart OR Baseconfig_To_Zeichen.GUID_RelationType = @GUID_RelationType_TagEnd OR Baseconfig_To_Zeichen.GUID_RelationType = @GUID_RelationType_TagEndInit) AND (Baseconfig_To_Zeichen
.GUID_Token_Left = @GUID_BaseConfig)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_HTMLDocuments]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_HTMLDocuments]

	-- Add the parameters for the stored procedure here

	 @GUID_Type_HTMLDoc				uniqueidentifier

	,@GUID_Type_DevelopmentVersion	uniqueidentifier

	,@GUID_RelationType_IsInState	uniqueidentifier

	,@GUID_HTMLDoc		uniqueidentifier = null

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;

    -- Insert statements for procedure here

	SELECT     func_Token_HTML_Document_1.GUID_HTML_Document, func_Token_HTML_Document_1.Name_HTML_Document, 

                      func_Token_HTML_Document_1.GUID_Type_HTML_Document, func_Token_Development_Version_1.GUID_Development_Version, 

                      func_Token_Development_Version_1.Name_Development_Version, func_Token_Development_Version_1.GUID_Type_Development_Version

FROM         dbo.func_Token_HTML_Document(@GUID_Type_HTMLDoc) AS func_Token_HTML_Document_1 INNER JOIN

                      semtbl_Token_Token AS HTMLDoc_To_DevelopmentVersion ON 

                      func_Token_HTML_Document_1.GUID_HTML_Document = HTMLDoc_To_DevelopmentVersion.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Development_Version(@GUID_Type_DevelopmentVersion) AS func_Token_Development_Version_1 ON 

                      HTMLDoc_To_DevelopmentVersion.GUID_Token_Right = func_Token_Development_Version_1.GUID_Development_Version

WHERE     (HTMLDoc_To_DevelopmentVersion.GUID_RelationType = @GUID_RelationType_IsInState)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[dbg_HTMLDocuments]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE dbg_HTMLDocuments

	-- Add the parameters for the stored procedure here

	@GUID_HTMLDoc		uniqueidentifier = null

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



	DECLARE @GUID_Type_HTMLDoc				uniqueidentifier

	DECLARE @GUID_Type_DevelopmentVersion	uniqueidentifier

	DECLARE @GUID_RelationType_IsInState	uniqueidentifier

	

	SET @GUID_Type_HTMLDoc				= dbo.dbg_Type_HTML_Document()

	SET @GUID_Type_DevelopmentVersion	= dbo.dbg_Type_Development_Version()

	SET @GUID_RelationType_IsInState	= dbo.dbg_RelationType_is_in_State()

	

	PRINT @GUID_Type_HTMLDoc				

	PRINT @GUID_Type_DevelopmentVersion	

	PRINT @GUID_RelationType_IsInState	



    -- Insert statements for procedure here

	SELECT     func_Token_HTML_Document_1.GUID_HTML_Document, func_Token_HTML_Document_1.Name_HTML_Document, 

                      func_Token_HTML_Document_1.GUID_Type_HTML_Document, func_Token_Development_Version_1.GUID_Development_Version, 

                      func_Token_Development_Version_1.Name_Development_Version, func_Token_Development_Version_1.GUID_Type_Development_Version

FROM         dbo.func_Token_HTML_Document(@GUID_Type_HTMLDoc) AS func_Token_HTML_Document_1 INNER JOIN

                      semtbl_Token_Token AS HTMLDoc_To_DevelopmentVersion ON 

                      func_Token_HTML_Document_1.GUID_HTML_Document = HTMLDoc_To_DevelopmentVersion.GUID_Token_Left INNER JOIN

                      dbo.func_Token_Development_Version(@GUID_Type_DevelopmentVersion) AS func_Token_Development_Version_1 ON 

                      HTMLDoc_To_DevelopmentVersion.GUID_Token_Right = func_Token_Development_Version_1.GUID_Development_Version

WHERE     (HTMLDoc_To_DevelopmentVersion.GUID_RelationType = @GUID_RelationType_IsInState)

END
'
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_TagSigns]') AND type in (N'P', N'PC'))
BEGIN
execute dbo.sp_executesql @statement = N'

-- =============================================

-- Author:		<Author,,Name>

-- Create date: <Create Date,,>

-- Description:	<Description,,>

-- =============================================

CREATE PROCEDURE [dbo].[proc_TagSigns] 

	-- Add the parameters for the stored procedure here

	 @GUID_Type_Zeichen				uniqueidentifier

	,@GUID_RelationType_TagStart		uniqueidentifier

	,@GUID_RelationType_TagEnd		uniqueidentifier

	,@GUID_RelationType_TagEndInit	uniqueidentifier

	,@GUID_BaseConfig			uniqueidentifier

AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from

	-- interfering with SELECT statements.

	SET NOCOUNT ON;



    -- Insert statements for procedure here

	SELECT     func_Token_Zeichen_1.GUID_Zeichen, func_Token_Zeichen_1.Name_Zeichen, func_Token_Zeichen_1.GUID_Type_Zeichen, Baseconfig_To_Zeichen.GUID_RelationType

	FROM         semtbl_Token_Token AS Baseconfig_To_Zeichen INNER JOIN

						  dbo.func_Token_Zeichen(@GUID_Type_Zeichen) AS func_Token_Zeichen_1 ON 

						  Baseconfig_To_Zeichen.GUID_Token_Right = func_Token_Zeichen_1.GUID_Zeichen

	WHERE     (Baseconfig_To_Zeichen.GUID_RelationType = @GUID_RelationType_TagStart OR Baseconfig_To_Zeichen.GUID_RelationType = @GUID_RelationType_TagEnd OR Baseconfig_To_Zeichen.GUID_RelationType = @GUID_RelationType_TagEndInit) AND (Baseconfig_To_Zeichen
.GUID_Token_Left = @GUID_BaseConfig)

END


'
END
GO
EXEC sp_addextendedproperty 
		@name = SchemaVersion, @value = '0.0.0.6';
GO
EXEC sp_addextendedproperty 
		@name = SemDB, @value = 'Yes';
GO
