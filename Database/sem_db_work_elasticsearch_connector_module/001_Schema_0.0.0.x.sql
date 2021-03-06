USE [sem_db_work_elasticsearch_connector_module]
GO
/****** Object:  StoredProcedure [dbo].[proc_CSVImport_Fields]    Script Date: 02/05/2013 16:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_CSVImport_Fields]
	-- Add the parameters for the stored procedure here
	 @GUID_Type_Field				uniqueidentifier
	,@GUID_Type_FieldType			uniqueidentifier
	,@GUID_RelationType_Contains	uniqueidentifier
	,@GUID_RelationType_isOfType	uniqueidentifier
	,@GUID_CSVImport				uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	SELECT	 CSVImport_To_Field.GUID_Token_Left AS GUID_CSVImport
			,Field.GUID_Token AS GUID_Field
			,Field.Name_Token AS Name_Field
			,FieldType.GUID_Token AS GUID_FieldType
			,FieldType.Name_Token AS Name_FieldType
	FROM semtbl_Token_Token AS CSVImport_To_Field
	INNER JOIN semtbl_Token AS Field ON Field.GUID_Token = CSVImport_To_Field.GUID_Token_Right
	INNER JOIN semtbl_Token_Token Field_To_FieldType ON Field_To_FieldType.GUID_Token_Left = Field.GUID_Token
	INNER JOIN semtbl_Token FieldType ON FieldType.GUID_Token = Field_To_FieldType.GUID_Token_Right
	WHERE CSVImport_To_Field.GUID_Token_Left = @GUID_CSVImport
	AND Field.GUID_Type = @GUID_Type_Field
	AND Field_To_FieldType.GUID_RelationType = @GUID_RelationType_isOfType
	ORDER BY CSVImport_To_Field.OrderID
	
END
GO
/****** Object:  StoredProcedure [dbo].[proc_CSVImport]    Script Date: 02/05/2013 16:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[proc_CSVImport]
	-- Add the parameters for the stored procedure here
	 @GUID_Attribute_Header				uniqueidentifier
	,@GUID_Type_CSVImport				uniqueidentifier
	,@GUID_Type_Types_ElasticSearch		uniqueidentifier
	,@GUID_Type_Zeichen					uniqueidentifier
	,@GUID_Type_File					uniqueidentifier
	,@GUID_RelationType_isOfType		uniqueidentifier
	,@GUID_RelationType_belongsTo		uniqueidentifier
	,@GUID_RelationType_Textqualifier	uniqueidentifier
	,@GUID_RelationType_Seperator		uniqueidentifier
	,@GUID_RelationType_belongingSource	uniqueidentifier
	,@GUID_User							uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here


	SELECT	 CSVImport.GUID_Token AS GUID_CSVImport
			,CSVImport.Name_Token AS Name_CSVImport
			,CSVImport__Header_Bit.GUID_TokenAttribute AS GUID_TokenAttribute_Header
			,CSVImport__Header_Bit.Val AS Header
			,TypesElasticSearch.GUID_Token AS GUID_TypeElasticSearch
			,TypesElasticSearch.Name_Token AS Name_TypeElasticSearch
			,TextQualifier.GUID_Token AS GUID_Textqualifier
			,TextQualifier.Name_Token AS Name_Textqualifiert
			,Seperator.GUID_Token AS GUID_Seperator
			,Seperator.Name_Token AS Name_Seperator
			,Files.GUID_Token AS GUID_File
			,Files.Name_Token as Name_File
	FROM semtbl_Token AS CSVImport
	INNER JOIN semtbl_Token_Attribute AS CSVImport__Header ON CSVImport__Header.GUID_Token = CSVImport.GUID_Token
	INNER JOIN semtbl_Token_Attribute_Bit AS CSVImport__Header_Bit ON CSVImport__Header_Bit.GUID_TokenAttribute = CSVImport__Header.GUID_TokenAttribute
	INNER JOIN semtbl_Token_Token AS CSVImport_To_Types_ElasticSearch ON CSVImport_To_Types_ElasticSearch.GUID_Token_Left = CSVImport.GUID_Token
	INNER JOIN semtbl_Token AS TypesElasticSearch ON TypesElasticSearch.GUID_Token = CSVImport_To_Types_ElasticSearch.GUID_Token_Right
	INNER JOIN semtbl_Token_Token AS CSVImport_To_User ON CSVImport_To_User.GUID_Token_Left = CSVImport.GUID_Token
	LEFT OUTER JOIN semtbl_Token_Token AS CSVImport_To_TextQualifier ON CSVImport_To_TextQualifier.GUID_Token_Left = CSVImport.GUID_Token AND CSVImport_To_TextQualifier.GUID_RelationType = @GUID_RelationType_Textqualifier
	LEFT OUTER JOIN semtbl_Token TextQualifier ON TextQualifier.GUID_Token = CSVImport_To_TextQualifier.GUID_Token_Right AND TextQualifier.GUID_Type = @GUID_Type_Zeichen
	INNER JOIN semtbl_Token_Token AS CSVImport_To_Seperator ON CSVImport_To_Seperator.GUID_Token_Left = CSVImport.GUID_Token
	INNER JOIN semtbl_Token AS Seperator ON Seperator.GUID_Token = CSVImport_To_Seperator.GUID_Token_Right
	INNER JOIN semtbl_Token_Token AS CSVImport_To_File ON CSVImport_To_File.GUID_Token_Left = CSVImport.GUID_Token
	INNER JOIN semtbl_Token AS Files ON Files.GUID_Token = CSVImport_To_File.GUID_Token_Right 
	WHERE CSVImport.GUID_Type = @GUID_Type_CSVImport
	AND CSVImport__Header.GUID_Attribute = @GUID_Attribute_Header
	AND CSVImport_To_Types_ElasticSearch.GUID_RelationType = @GUID_RelationType_isOfType
	AND CSVImport_To_User.GUID_RelationType = @GUID_RelationType_belongsTo
	AND CSVImport_To_User.GUID_Token_Right = @GUID_User
	AND TypesElasticSearch.GUID_Type = @GUID_Type_Types_ElasticSearch
	AND CSVImport_To_Seperator.GUID_RelationType = @GUID_RelationType_Seperator
	AND Seperator.GUID_Type = @GUID_Type_Zeichen
	AND Files.GUID_Type = @GUID_Type_File
	AND CSVImport_To_File.GUID_RelationType = @GUID_RelationType_belongingSource
END
GO
/****** Object:  StoredProcedure [dbo].[dbg_CSVImport_Fields]    Script Date: 02/05/2013 16:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[dbg_CSVImport_Fields]
	-- Add the parameters for the stored procedure here
	@GUID_CSVImport						uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	DECLARE @GUID_Type_Field				uniqueidentifier
	DECLARE @GUID_Type_FieldType			uniqueidentifier
	DECLARE @GUID_RelationType_Contains		uniqueidentifier
	DECLARE @GUID_RelationType_isOfType		uniqueidentifier


	SET @GUID_Type_Field					= 'e1be73cd-0deb-41a0-a222-b779e7862412'
	SET @GUID_Type_FieldType				= 'a534dc0a-e3c8-4e05-9f86-faaec798f9cc'
	SET @GUID_RelationType_Contains			= 'e9711603-47db-44d8-a476-fe88290639a4'
	SET @GUID_RelationType_isOfType			= '9996494a-ef6a-4357-a6ef-71a92b5ff596'



	SELECT	 CSVImport_To_Field.GUID_Token_Left AS GUID_CSVImport
			,Field.GUID_Token AS GUID_Field
			,Field.Name_Token AS Name_Field
			,FieldType.GUID_Token AS GUID_FieldType
			,FieldType.Name_Token AS Name_FieldType
	FROM semtbl_Token_Token AS CSVImport_To_Field
	INNER JOIN semtbl_Token AS Field ON Field.GUID_Token = CSVImport_To_Field.GUID_Token_Right
	INNER JOIN semtbl_Token_Token Field_To_FieldType ON Field_To_FieldType.GUID_Token_Left = Field.GUID_Token
	INNER JOIN semtbl_Token FieldType ON FieldType.GUID_Token = Field_To_FieldType.GUID_Token_Right
	WHERE CSVImport_To_Field.GUID_Token_Left = @GUID_CSVImport
	AND Field.GUID_Type = @GUID_Type_Field
	AND Field_To_FieldType.GUID_RelationType = @GUID_RelationType_isOfType
	ORDER BY CSVImport_To_Field.OrderID
	
END
GO
/****** Object:  StoredProcedure [dbo].[dbg_CSVImport]    Script Date: 02/05/2013 16:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[dbg_CSVImport]
	-- Add the parameters for the stored procedure here
	@GUID_User		uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @GUID_Attribute_Header				uniqueidentifier
	DECLARE @GUID_Type_CSVImport				uniqueidentifier
	DECLARE @GUID_Type_Types_ElasticSearch		uniqueidentifier
	DECLARE @GUID_Type_Zeichen					uniqueidentifier
	DECLARE @GUID_Type_File						uniqueidentifier
	DECLARE @GUID_RelationType_isOfType			uniqueidentifier
	DECLARE @GUID_RelationType_belongsTo		uniqueidentifier
	DECLARE @GUID_RelationType_Textqualifier	uniqueidentifier
	DECLARE @GUID_RelationType_Seperator		uniqueidentifier
	DECLARE @GUID_RelationType_belongingSource	uniqueidentifier
	DECLARE @GUID_RelationType_contains			uniqueidentifier
	


	SET @GUID_Attribute_Header				= '5e0c66db-0992-4c92-9dbb-0568e58250f9'
	SET @GUID_Type_CSVImport				= '2bf81077-b8c9-4e0e-99bf-b8329ed8bf25'
	SET @GUID_Type_Types_ElasticSearch		= 'd9775bda-1526-475b-8e16-723881828876'
	SET @GUID_Type_Zeichen					= 'c8e580ed-be06-49a2-8ee8-17e8e0160393'
	SET @GUID_Type_File						= '6eb4fdd3-2e25-4886-b288-e1bfc2857efb'
	SET @GUID_RelationType_isOfType			= '9996494a-ef6a-4357-a6ef-71a92b5ff596'
	SET @GUID_RelationType_belongsTo		= 'e07469d9-766c-443e-8526-6d9c684f944f'
	SET @GUID_RelationType_Textqualifier	= '82047cba-f63a-429f-a61b-33b622a9826e'
	SET @GUID_RelationType_Seperator		= '6b106ab9-7e68-44f1-8a75-4612e021d7ab'
	SET @GUID_RelationType_belongingSource	= 'd34d545e-9ddf-46ce-bb6f-22db1b7bb025'
	SET @GUID_RelationType_contains			= 'e9711603-47db-44d8-a476-fe88290639a4'


	SELECT	 CSVImport.GUID_Token AS GUID_CSVImport
			,CSVImport.Name_Token AS Name_CSVImport
			,CSVImport__Header_Bit.GUID_TokenAttribute AS GUID_TokenAttribute_Header
			,CSVImport__Header_Bit.Val AS Header
			,TypesElasticSearch.GUID_Token AS GUID_TypeElasticSearch
			,TypesElasticSearch.Name_Token AS Name_TypeElasticSearch
			,TextQualifier.GUID_Token AS GUID_Textqualifier
			,TextQualifier.Name_Token AS Name_Textqualifiert
			,Seperator.GUID_Token AS GUID_Seperator
			,Seperator.Name_Token AS Name_Seperator
			,Files.GUID_Token AS GUID_File
			,Files.Name_Token as Name_File
	FROM semtbl_Token AS CSVImport
	INNER JOIN semtbl_Token_Attribute AS CSVImport__Header ON CSVImport__Header.GUID_Token = CSVImport.GUID_Token
	INNER JOIN semtbl_Token_Attribute_Bit AS CSVImport__Header_Bit ON CSVImport__Header_Bit.GUID_TokenAttribute = CSVImport__Header.GUID_TokenAttribute
	INNER JOIN semtbl_Token_Token AS CSVImport_To_Types_ElasticSearch ON CSVImport_To_Types_ElasticSearch.GUID_Token_Left = CSVImport.GUID_Token
	INNER JOIN semtbl_Token AS TypesElasticSearch ON TypesElasticSearch.GUID_Token = CSVImport_To_Types_ElasticSearch.GUID_Token_Right
	INNER JOIN semtbl_Token_Token AS CSVImport_To_User ON CSVImport_To_User.GUID_Token_Left = CSVImport.GUID_Token
	LEFT OUTER JOIN semtbl_Token_Token AS CSVImport_To_TextQualifier ON CSVImport_To_TextQualifier.GUID_Token_Left = CSVImport.GUID_Token AND CSVImport_To_TextQualifier.GUID_RelationType = @GUID_RelationType_Textqualifier
	LEFT OUTER JOIN semtbl_Token TextQualifier ON TextQualifier.GUID_Token = CSVImport_To_TextQualifier.GUID_Token_Right AND TextQualifier.GUID_Type = @GUID_Type_Zeichen
	INNER JOIN semtbl_Token_Token AS CSVImport_To_Seperator ON CSVImport_To_Seperator.GUID_Token_Left = CSVImport.GUID_Token
	INNER JOIN semtbl_Token AS Seperator ON Seperator.GUID_Token = CSVImport_To_Seperator.GUID_Token_Right
	INNER JOIN semtbl_Token_Token AS CSVImport_To_File ON CSVImport_To_File.GUID_Token_Left = CSVImport.GUID_Token
	INNER JOIN semtbl_Token AS Files ON Files.GUID_Token = CSVImport_To_File.GUID_Token_Right 
	WHERE CSVImport.GUID_Type = @GUID_Type_CSVImport
	AND CSVImport__Header.GUID_Attribute = @GUID_Attribute_Header
	AND CSVImport_To_Types_ElasticSearch.GUID_RelationType = @GUID_RelationType_isOfType
	AND CSVImport_To_User.GUID_RelationType = @GUID_RelationType_belongsTo
	AND CSVImport_To_User.GUID_Token_Right = @GUID_User
	AND TypesElasticSearch.GUID_Type = @GUID_Type_Types_ElasticSearch
	AND CSVImport_To_Seperator.GUID_RelationType = @GUID_RelationType_Seperator
	AND Seperator.GUID_Type = @GUID_Type_Zeichen
	AND Files.GUID_Type = @GUID_Type_File
	AND CSVImport_To_File.GUID_RelationType = @GUID_RelationType_belongingSource
END
GO
