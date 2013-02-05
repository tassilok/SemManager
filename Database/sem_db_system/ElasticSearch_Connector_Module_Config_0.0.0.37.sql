use [sem_db_system]
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''68ac4472-ee22-4229-96ec-9753a016900a'') = 0
	insert into semtbl_Attribute VALUES(''68ac4472-ee22-4229-96ec-9753a016900a'',''XML-Text'',''64530b52-d96c-4df1-86fe-183f44513450'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''5e0c66db-0992-4c92-9dbb-0568e58250f9'') = 0
	insert into semtbl_Attribute VALUES(''5e0c66db-0992-4c92-9dbb-0568e58250f9'',''Header'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''f1dd87f2-ac53-4e83-a76b-fee5bffc6909'') = 0
	insert into semtbl_Attribute VALUES(''f1dd87f2-ac53-4e83-a76b-fee5bffc6909'',''visible'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''d4ea61d7-ec98-484d-a1cd-cd02d41cd0d3'') = 0
	insert into semtbl_Attribute VALUES(''d4ea61d7-ec98-484d-a1cd-cd02d41cd0d3'',''invisible'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''4fcf775b-2e0b-4712-be8d-0e8e0c643040'') = 0
	insert into semtbl_Attribute VALUES(''4fcf775b-2e0b-4712-be8d-0e8e0c643040'',''Searchpath'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''166531b2-a224-4ce1-bd01-6e38fec36bb3'') = 0
	insert into semtbl_Attribute VALUES(''166531b2-a224-4ce1-bd01-6e38fec36bb3'',''Url-Path'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'') = 0
	insert into semtbl_Attribute VALUES(''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'',''Blob'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''b67c3f3c-da03-4693-9afc-d2014997e328'') = 0
	insert into semtbl_Attribute VALUES(''b67c3f3c-da03-4693-9afc-d2014997e328'',''Datetimestamp (Create)'',''905fda81-788f-4e3d-8329-3e55ae984b9e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''a1b49452-19dc-4eae-a000-ef3802de35a9'') = 0
	insert into semtbl_Attribute VALUES(''a1b49452-19dc-4eae-a000-ef3802de35a9'',''ProcessorID'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''30b76a62-1b22-4f17-b9a5-ff665e08f35a'') = 0
	insert into semtbl_Attribute VALUES(''30b76a62-1b22-4f17-b9a5-ff665e08f35a'',''BaseboardSerial'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''3940fb8a-7ec9-4bd5-9719-aed313da116d'') = 0
	insert into semtbl_Attribute VALUES(''3940fb8a-7ec9-4bd5-9719-aed313da116d'',''Value'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''66857dba-efd6-48c9-ad54-04103f56ab8a'')=0
	insert into semtbl_RelationType VALUES(''66857dba-efd6-48c9-ad54-04103f56ab8a'',''Row-Config'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''a80b1064-649b-4510-980e-c28be335956c'')=0
	insert into semtbl_RelationType VALUES(''a80b1064-649b-4510-980e-c28be335956c'',''belonging Resources'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''6b106ab9-7e68-44f1-8a75-4612e021d7ab'')=0
	insert into semtbl_RelationType VALUES(''6b106ab9-7e68-44f1-8a75-4612e021d7ab'',''Seperator'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e6fa577e-ad2f-4c34-b314-061f5fa6c894'')=0
	insert into semtbl_RelationType VALUES(''e6fa577e-ad2f-4c34-b314-061f5fa6c894'',''Col-Config'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	insert into semtbl_RelationType VALUES(''e9711603-47db-44d8-a476-fe88290639a4'',''contains'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''aaf3e012-a822-4ba6-9d9d-d5bb35821757'')=0
	insert into semtbl_RelationType VALUES(''aaf3e012-a822-4ba6-9d9d-d5bb35821757'',''export to'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	insert into semtbl_RelationType VALUES(''9996494a-ef6a-4357-a6ef-71a92b5ff596'',''is of Type'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	insert into semtbl_RelationType VALUES(''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',''offered by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	insert into semtbl_RelationType VALUES(''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',''belonging Source'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	insert into semtbl_RelationType VALUES(''e07469d9-766c-443e-8526-6d9c684f944f'',''belongs to'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''82047cba-f63a-429f-a61b-33b622a9826e'')=0
	insert into semtbl_RelationType VALUES(''82047cba-f63a-429f-a61b-33b622a9826e'',''Textqualifier'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''0fa056ea-474f-424f-ab68-0a10b57d3a95'')=0
	insert into semtbl_RelationType VALUES(''0fa056ea-474f-424f-ab68-0a10b57d3a95'',''leads'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''6edbb77c-18d1-4736-92bf-7bd5e5dde8b8'')=0
	insert into semtbl_RelationType VALUES(''6edbb77c-18d1-4736-92bf-7bd5e5dde8b8'',''Type-Field'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''4f8f29b4-49bb-4d85-a65f-205d2af4f509'')=0
	insert into semtbl_RelationType VALUES(''4f8f29b4-49bb-4d85-a65f-205d2af4f509'',''is checkout by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	insert into semtbl_RelationType VALUES(''fafc1464-815f-4596-9737-bcbc96bd744a'',''needs'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	insert into semtbl_RelationType VALUES(''408db9f1-ae42-4807-b656-729270646f0a'',''is subordinated'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type=''49fdcd27-e105-4770-941d-7485dcad08c1'') = 0
	insert into semtbl_Type (GUID_Type,Name_Type) VALUES(''49fdcd27-e105-4770-941d-7485dcad08c1'',''Root'')'
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='4546225b-ab04-4036-b218-2e95a25a0c2b') = 0
	insert into semtbl_Type VALUES('4546225b-ab04-4036-b218-2e95a25a0c2b','Application','73e32abf-e577-4d31-9a46-bc07e9e15de3')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='d79c764d-e946-454c-8e91-054ca1471cf2') = 0
	insert into semtbl_Type VALUES('d79c764d-e946-454c-8e91-054ca1471cf2','ElasticSearch','4546225b-ab04-4036-b218-2e95a25a0c2b')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='1233afbe-60bf-40e7-9228-64ca4013b75c') = 0
	insert into semtbl_Type VALUES('1233afbe-60bf-40e7-9228-64ca4013b75c','Indexes (Elastic-Search)','d79c764d-e946-454c-8e91-054ca1471cf2')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='d9775bda-1526-475b-8e16-723881828876') = 0
	insert into semtbl_Type VALUES('d9775bda-1526-475b-8e16-723881828876','Types (Elastic Search)','d79c764d-e946-454c-8e91-054ca1471cf2')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='83317bac-b4b1-4db8-bf84-9fca0a93ddd5') = 0
	insert into semtbl_Type VALUES('83317bac-b4b1-4db8-bf84-9fca0a93ddd5','Information-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='30cbc6e8-9c0f-47d6-920c-97fdc40ea1de') = 0
	insert into semtbl_Type VALUES('30cbc6e8-9c0f-47d6-920c-97fdc40ea1de','Report','83317bac-b4b1-4db8-bf84-9fca0a93ddd5')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='c790aa5b-14a4-46b0-bd8c-4317ef5716e2') = 0
	insert into semtbl_Type VALUES('c790aa5b-14a4-46b0-bd8c-4317ef5716e2','Report-Field','30cbc6e8-9c0f-47d6-920c-97fdc40ea1de')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='a534dc0a-e3c8-4e05-9f86-faaec798f9cc') = 0
	insert into semtbl_Type VALUES('a534dc0a-e3c8-4e05-9f86-faaec798f9cc','Field-Type','c790aa5b-14a4-46b0-bd8c-4317ef5716e2')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='e1be73cd-0deb-41a0-a222-b779e7862412') = 0
	insert into semtbl_Type VALUES('e1be73cd-0deb-41a0-a222-b779e7862412','Fields','30cbc6e8-9c0f-47d6-920c-97fdc40ea1de')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='176cb03d-11c5-4d59-8de0-44cf5d1832e2') = 0
	insert into semtbl_Type VALUES('176cb03d-11c5-4d59-8de0-44cf5d1832e2','Sprache','83317bac-b4b1-4db8-bf84-9fca0a93ddd5')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='c8e580ed-be06-49a2-8ee8-17e8e0160393') = 0
	insert into semtbl_Type VALUES('c8e580ed-be06-49a2-8ee8-17e8e0160393','Zeichen','176cb03d-11c5-4d59-8de0-44cf5d1832e2')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='de988c64-dd59-41f4-bf1f-4b54c56e8fe7') = 0
	insert into semtbl_Type VALUES('de988c64-dd59-41f4-bf1f-4b54c56e8fe7','Templates','83317bac-b4b1-4db8-bf84-9fca0a93ddd5')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='327e9773-fca6-458c-a44d-338a556e0ad9') = 0
	insert into semtbl_Type VALUES('327e9773-fca6-458c-a44d-338a556e0ad9','XML','de988c64-dd59-41f4-bf1f-4b54c56e8fe7')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='4158aad2-656a-4fb9-97bf-524c6f5fecaa') = 0
	insert into semtbl_Type VALUES('4158aad2-656a-4fb9-97bf-524c6f5fecaa','Variable','83317bac-b4b1-4db8-bf84-9fca0a93ddd5')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='665dd88b-792e-4256-a27a-68ee1e10ece6') = 0
	insert into semtbl_Type VALUES('665dd88b-792e-4256-a27a-68ee1e10ece6','System','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747') = 0
	insert into semtbl_Type VALUES('b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747','Module-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='aa616051-e521-4fac-abdb-cbba6f8c6e73') = 0
	insert into semtbl_Type VALUES('aa616051-e521-4fac-abdb-cbba6f8c6e73','Module','b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='74303821-1abf-4e60-b119-0e6c7fffbe2d') = 0
	insert into semtbl_Type VALUES('74303821-1abf-4e60-b119-0e6c7fffbe2d','ElasticSearch-Connector-Module','aa616051-e521-4fac-abdb-cbba6f8c6e73')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='2bf81077-b8c9-4e0e-99bf-b8329ed8bf25') = 0
	insert into semtbl_Type VALUES('2bf81077-b8c9-4e0e-99bf-b8329ed8bf25','CSV-Import','74303821-1abf-4e60-b119-0e6c7fffbe2d')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='52b61535-d619-4db8-a3ea-fb77b864dc55') = 0
	insert into semtbl_Type VALUES('52b61535-d619-4db8-a3ea-fb77b864dc55','XML-Import','aa616051-e521-4fac-abdb-cbba6f8c6e73')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='48d76692-2ee7-4b34-b3bf-4a8116a50d0d') = 0
	insert into semtbl_Type VALUES('48d76692-2ee7-4b34-b3bf-4a8116a50d0d','XML-Nodes','52b61535-d619-4db8-a3ea-fb77b864dc55')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='eb411e2f-f93d-4a5e-bbba-c0b5d7ec0197') = 0
	insert into semtbl_Type VALUES('eb411e2f-f93d-4a5e-bbba-c0b5d7ec0197','Ontologies','b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='bb98059c-f51f-496e-950b-3d2fc17a16f1') = 0
	insert into semtbl_Type VALUES('bb98059c-f51f-496e-950b-3d2fc17a16f1','KindOfOntology','eb411e2f-f93d-4a5e-bbba-c0b5d7ec0197')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='9b0eeaff-d392-4596-a266-ed29f177f7eb') = 0
	insert into semtbl_Type VALUES('9b0eeaff-d392-4596-a266-ed29f177f7eb','Infrastructure','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='ca4eff30-a40b-476d-9906-9f56a67c8cf9') = 0
	insert into semtbl_Type VALUES('ca4eff30-a40b-476d-9906-9f56a67c8cf9','Port','9b0eeaff-d392-4596-a266-ed29f177f7eb')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='9ba24283-a0ad-4717-be30-6f0f3818c36c') = 0
	insert into semtbl_Type VALUES('9ba24283-a0ad-4717-be30-6f0f3818c36c','Server:Port','9b0eeaff-d392-4596-a266-ed29f177f7eb')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='4b335d37-2087-42f6-a680-a1b03e35d73c') = 0
	insert into semtbl_Type VALUES('4b335d37-2087-42f6-a680-a1b03e35d73c','Web-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='094d728d-6efc-463c-85c7-2dcfed903c78') = 0
	insert into semtbl_Type VALUES('094d728d-6efc-463c-85c7-2dcfed903c78','Url','4b335d37-2087-42f6-a680-a1b03e35d73c')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='2f05c250-be33-4b77-ba3c-b8a0228821b6') = 0
	insert into semtbl_Type VALUES('2f05c250-be33-4b77-ba3c-b8a0228821b6','Filesystem-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='6eb4fdd3-2e25-4886-b288-e1bfc2857efb') = 0
	insert into semtbl_Type VALUES('6eb4fdd3-2e25-4886-b288-e1bfc2857efb','File','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='d7a03a35-8751-42b4-8e05-19fc7a77ee91') = 0
	insert into semtbl_Type VALUES('d7a03a35-8751-42b4-8e05-19fc7a77ee91','Server','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ea952101-d18b-4542-81bd-3ece8de0add5'') = 0
	insert into semtbl_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''ElasticSearch_Connector_Module'',''c6c9bcb8-0ac9-4713-9417-eeec1453026c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5afa8b15-09ae-487c-a02d-4ff3e9ac88c4'') = 0
	insert into semtbl_Token VALUES(''5afa8b15-09ae-487c-a02d-4ff3e9ac88c4'',''ElasticSearch_Connector_Module'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d29b56cd-cdad-4b46-af59-0464909864b6'') = 0
	insert into semtbl_Token VALUES(''d29b56cd-cdad-4b46-af59-0464909864b6'',''Type_Field_Type'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ea85785e-42a2-41f1-b6f7-08cc803a21f7'') = 0
	insert into semtbl_Token VALUES(''ea85785e-42a2-41f1-b6f7-08cc803a21f7'',''RelationType_Row_Config'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'') = 0
	insert into semtbl_Token VALUES(''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''Type_Module'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c6141978-25a0-4e22-a359-22768240efef'') = 0
	insert into semtbl_Token VALUES(''c6141978-25a0-4e22-a359-22768240efef'',''Token_KindOfOntology_DataType'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6481c476-0c6b-4554-897e-260b4637fdcf'') = 0
	insert into semtbl_Token VALUES(''6481c476-0c6b-4554-897e-260b4637fdcf'',''Token_KindOfOntology_Class_Attribute'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5ea2aade-a23a-46a1-b34f-275676ac8a42'') = 0
	insert into semtbl_Token VALUES(''5ea2aade-a23a-46a1-b34f-275676ac8a42'',''RelationType_belonging_Resources'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9df96820-e006-4e98-bed4-299af16eba64'') = 0
	insert into semtbl_Token VALUES(''9df96820-e006-4e98-bed4-299af16eba64'',''RelationType_Seperator'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''daa8f561-5545-447c-b5df-2eaaacc2aac7'') = 0
	insert into semtbl_Token VALUES(''daa8f561-5545-447c-b5df-2eaaacc2aac7'',''Type_ElasticSearch_Connector_Module'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2a7dbccc-75d5-437d-a284-315522f5e068'') = 0
	insert into semtbl_Token VALUES(''2a7dbccc-75d5-437d-a284-315522f5e068'',''Token_KindOfOntology_Class'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''134c4442-89bc-4907-a49b-3983c7afb9a6'') = 0
	insert into semtbl_Token VALUES(''134c4442-89bc-4907-a49b-3983c7afb9a6'',''RelationType_Col_Config'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''56803624-0182-4926-9da5-3bc4fe5e7b31'') = 0
	insert into semtbl_Token VALUES(''56803624-0182-4926-9da5-3bc4fe5e7b31'',''Type_Port'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''92cb3704-e7d7-4e90-8d06-3d52a7f79c17'') = 0
	insert into semtbl_Token VALUES(''92cb3704-e7d7-4e90-8d06-3d52a7f79c17'',''Token_XML_ES_Bulk_Document'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'') = 0
	insert into semtbl_Token VALUES(''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'',''Attribute_XML_Text'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ed372a04-810e-4d62-a819-41c8c94dc7b6'') = 0
	insert into semtbl_Token VALUES(''ed372a04-810e-4d62-a819-41c8c94dc7b6'',''Token_KindOfOntology_KindOfOntology'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cef07f53-d0a7-49de-8675-58fcea3594bc'') = 0
	insert into semtbl_Token VALUES(''cef07f53-d0a7-49de-8675-58fcea3594bc'',''Token_Variable_VALUE'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2f06b88c-090b-4217-bfd6-5a150a866db9'') = 0
	insert into semtbl_Token VALUES(''2f06b88c-090b-4217-bfd6-5a150a866db9'',''Token_Types__Elastic_Search__ontologydb'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0c093478-9c30-4dfb-8f8f-5ae624b898f4'') = 0
	insert into semtbl_Token VALUES(''0c093478-9c30-4dfb-8f8f-5ae624b898f4'',''Token_KindOfOntology_Object_Ontology'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''33b131b4-810d-449c-a3f7-60d16cba5853'') = 0
	insert into semtbl_Token VALUES(''33b131b4-810d-449c-a3f7-60d16cba5853'',''Type_Server_Port'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f5e9753e-c848-4e57-bf75-64005dda7ede'') = 0
	insert into semtbl_Token VALUES(''f5e9753e-c848-4e57-bf75-64005dda7ede'',''Token_Variable_TYPE'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6c966e3c-c737-4af1-9970-68c8323679bc'') = 0
	insert into semtbl_Token VALUES(''6c966e3c-c737-4af1-9970-68c8323679bc'',''RelationType_contains'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'') = 0
	insert into semtbl_Token VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''attribute_dbPostfix'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e3d4516d-4f74-44ff-8472-6c2f016d457e'') = 0
	insert into semtbl_Token VALUES(''e3d4516d-4f74-44ff-8472-6c2f016d457e'',''RelationType_export_to'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''30d56364-c7da-4fd4-878f-6c6c63481540'') = 0
	insert into semtbl_Token VALUES(''30d56364-c7da-4fd4-878f-6c6c63481540'',''Token_KindOfOntology_Class_Relation'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6e494944-f602-4dcb-906f-70e5efe8f1dd'') = 0
	insert into semtbl_Token VALUES(''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''RelationType_is_of_Type'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8a650a18-5ec5-4732-9656-784c6b24768e'') = 0
	insert into semtbl_Token VALUES(''8a650a18-5ec5-4732-9656-784c6b24768e'',''Token_KindOfOntology_Object'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f2cde058-614e-41cb-96eb-78bbcf285171'') = 0
	insert into semtbl_Token VALUES(''f2cde058-614e-41cb-96eb-78bbcf285171'',''RelationType_offered_by'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''77fe297f-10d5-48b6-9543-7af4ea5b4909'') = 0
	insert into semtbl_Token VALUES(''77fe297f-10d5-48b6-9543-7af4ea5b4909'',''Token_KindOfOntology_Attribute'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b557820e-0322-42c4-b651-7dee101f5817'') = 0
	insert into semtbl_Token VALUES(''b557820e-0322-42c4-b651-7dee101f5817'',''Token_KindOfOntology_AttributeInstance'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''31ff7c35-21e8-45b2-9b86-81de3b26a71b'') = 0
	insert into semtbl_Token VALUES(''31ff7c35-21e8-45b2-9b86-81de3b26a71b'',''Type_Indexes__Elastic_Search_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''95e3d334-8193-4e9b-89cb-8e2baa3a0573'') = 0
	insert into semtbl_Token VALUES(''95e3d334-8193-4e9b-89cb-8e2baa3a0573'',''Type_ElasticSearch'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'') = 0
	insert into semtbl_Token VALUES(''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'',''RelationType_belonging_Source'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''80133943-600f-4596-b55d-97a334e91417'') = 0
	insert into semtbl_Token VALUES(''80133943-600f-4596-b55d-97a334e91417'',''Attribute_Header'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b87bb206-c885-4dc1-ba21-9adbc0cd55d9'') = 0
	insert into semtbl_Token VALUES(''b87bb206-c885-4dc1-ba21-9adbc0cd55d9'',''Token_KindOfOntology_Class_Ontology'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3186cc5e-023b-4edc-b6c7-a89919320839'') = 0
	insert into semtbl_Token VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''RelationType_belongsTo'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6de11361-38e0-4337-a182-ab7fcf55c255'') = 0
	insert into semtbl_Token VALUES(''6de11361-38e0-4337-a182-ab7fcf55c255'',''Type_XML_Nodes'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f10253cf-f5c4-4777-8f4b-abc61217e28b'') = 0
	insert into semtbl_Token VALUES(''f10253cf-f5c4-4777-8f4b-abc61217e28b'',''Type_Url'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''44210c2e-190f-4095-b579-aeed7a807854'') = 0
	insert into semtbl_Token VALUES(''44210c2e-190f-4095-b579-aeed7a807854'',''Token_Variable_ID'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f1ba23ed-ab41-4d34-8e09-b4e485671478'') = 0
	insert into semtbl_Token VALUES(''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''Type_File'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''40443821-c238-4ac1-b9c3-bce0ae4cbdb8'') = 0
	insert into semtbl_Token VALUES(''40443821-c238-4ac1-b9c3-bce0ae4cbdb8'',''Type_Zeichen'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''05fe193e-f8a0-46d3-bbae-c2300b8f57fc'') = 0
	insert into semtbl_Token VALUES(''05fe193e-f8a0-46d3-bbae-c2300b8f57fc'',''Token_KindOfOntology_RelationType'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''23d54d1e-3a3c-442f-bb96-c7eba4daa856'') = 0
	insert into semtbl_Token VALUES(''23d54d1e-3a3c-442f-bb96-c7eba4daa856'',''Type_Fields'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fec7ae6f-9434-4fca-b929-cbd5e7def83d'') = 0
	insert into semtbl_Token VALUES(''fec7ae6f-9434-4fca-b929-cbd5e7def83d'',''Token_Variable_INDEX'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fd7f0cf5-5e08-4097-b3de-cbf42b0d17ae'') = 0
	insert into semtbl_Token VALUES(''fd7f0cf5-5e08-4097-b3de-cbf42b0d17ae'',''Token_Variable_FIELD'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'') = 0
	insert into semtbl_Token VALUES(''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''Type_Server'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b2107a10-fbcb-4cc0-822f-e3800c7c3beb'') = 0
	insert into semtbl_Token VALUES(''b2107a10-fbcb-4cc0-822f-e3800c7c3beb'',''Type_Types__Elastic_Search_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f08d5f7e-c262-4998-b0c2-e81cb83052aa'') = 0
	insert into semtbl_Token VALUES(''f08d5f7e-c262-4998-b0c2-e81cb83052aa'',''Type_CSV_Import'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''15fc84c5-3b78-4520-85dc-e8282756cc3a'') = 0
	insert into semtbl_Token VALUES(''15fc84c5-3b78-4520-85dc-e8282756cc3a'',''Token_XML_ES_Bulk_Attribute'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''aed3d356-0c79-476c-971e-e917ee909603'') = 0
	insert into semtbl_Token VALUES(''aed3d356-0c79-476c-971e-e917ee909603'',''Type_XML_Import'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5e4427ff-b65f-4f54-9c3c-f291f96c7749'') = 0
	insert into semtbl_Token VALUES(''5e4427ff-b65f-4f54-9c3c-f291f96c7749'',''RelationType_Textqualifier'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9285e6f5-4dd3-41a7-a20d-b8dd5b0c3eeb'') = 0
	insert into semtbl_Token VALUES(''9285e6f5-4dd3-41a7-a20d-b8dd5b0c3eeb'',''DataType'',''bb98059c-f51f-496e-950b-3d2fc17a16f1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2ad76ad0-14c2-47cc-abec-81397298c6c8'') = 0
	insert into semtbl_Token VALUES(''2ad76ad0-14c2-47cc-abec-81397298c6c8'',''Class-Attribute'',''bb98059c-f51f-496e-950b-3d2fc17a16f1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''dbbfc1a0-0c2e-4836-8434-0a7b7a8b4b52'') = 0
	insert into semtbl_Token VALUES(''dbbfc1a0-0c2e-4836-8434-0a7b7a8b4b52'',''Class'',''bb98059c-f51f-496e-950b-3d2fc17a16f1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ad6e710c-a9ab-4b05-85bd-9475f7eca7be'') = 0
	insert into semtbl_Token VALUES(''ad6e710c-a9ab-4b05-85bd-9475f7eca7be'',''ES_Bulk_Document'',''327e9773-fca6-458c-a44d-338a556e0ad9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''69d36f9c-c59a-4766-9d10-8a46bed99b54'') = 0
	insert into semtbl_Token VALUES(''69d36f9c-c59a-4766-9d10-8a46bed99b54'',''KindOfOntology'',''bb98059c-f51f-496e-950b-3d2fc17a16f1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''88382390-0d28-41f4-a5d7-0b76aabd3235'') = 0
	insert into semtbl_Token VALUES(''88382390-0d28-41f4-a5d7-0b76aabd3235'',''VALUE'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d91d58a8-3c0d-4845-ba12-a727583291c8'') = 0
	insert into semtbl_Token VALUES(''d91d58a8-3c0d-4845-ba12-a727583291c8'',''ontologydb'',''d9775bda-1526-475b-8e16-723881828876'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''407e2719-982a-4ef5-a893-d3dfc2c42764'') = 0
	insert into semtbl_Token VALUES(''407e2719-982a-4ef5-a893-d3dfc2c42764'',''Object-Ontology'',''bb98059c-f51f-496e-950b-3d2fc17a16f1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''04cd4762-a7a9-4108-88b2-c023cab40a8f'') = 0
	insert into semtbl_Token VALUES(''04cd4762-a7a9-4108-88b2-c023cab40a8f'',''TYPE'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''30039a60-0e36-4ec8-92ac-a2892e35e247'') = 0
	insert into semtbl_Token VALUES(''30039a60-0e36-4ec8-92ac-a2892e35e247'',''Class-Relation'',''bb98059c-f51f-496e-950b-3d2fc17a16f1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e9ae24bf-f89b-407c-b36d-51f8219df6c8'') = 0
	insert into semtbl_Token VALUES(''e9ae24bf-f89b-407c-b36d-51f8219df6c8'',''Object'',''bb98059c-f51f-496e-950b-3d2fc17a16f1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''eff5d646-9ef6-447b-8575-921462f3b9b8'') = 0
	insert into semtbl_Token VALUES(''eff5d646-9ef6-447b-8575-921462f3b9b8'',''Attribute'',''bb98059c-f51f-496e-950b-3d2fc17a16f1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e36a4286-f34d-485f-b435-bd1344033c74'') = 0
	insert into semtbl_Token VALUES(''e36a4286-f34d-485f-b435-bd1344033c74'',''AttributeInstance'',''bb98059c-f51f-496e-950b-3d2fc17a16f1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d597e2c2-3fd5-4010-bcc7-82a664dd0563'') = 0
	insert into semtbl_Token VALUES(''d597e2c2-3fd5-4010-bcc7-82a664dd0563'',''Class-Ontology'',''bb98059c-f51f-496e-950b-3d2fc17a16f1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''392f4e01-491c-4da1-9894-42e368c8339f'') = 0
	insert into semtbl_Token VALUES(''392f4e01-491c-4da1-9894-42e368c8339f'',''ID'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0d1d690b-d406-4fb6-bdf0-475c29a7a9fe'') = 0
	insert into semtbl_Token VALUES(''0d1d690b-d406-4fb6-bdf0-475c29a7a9fe'',''RelationType'',''bb98059c-f51f-496e-950b-3d2fc17a16f1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''79a019e3-7c8c-4a26-8ac8-8f918f3c0509'') = 0
	insert into semtbl_Token VALUES(''79a019e3-7c8c-4a26-8ac8-8f918f3c0509'',''INDEX'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f7645fbc-8ab5-4f8d-85b9-3f8543d5583b'') = 0
	insert into semtbl_Token VALUES(''f7645fbc-8ab5-4f8d-85b9-3f8543d5583b'',''FIELD'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9af284c0-e391-40ec-b8bb-a5c2b92d044f'') = 0
	insert into semtbl_Token VALUES(''9af284c0-e391-40ec-b8bb-a5c2b92d044f'',''ES_Bulk_Attribute'',''327e9773-fca6-458c-a44d-338a556e0ad9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bb640443-9cb4-499d-a5f2-7e345a9c92e9'') = 0
	insert into semtbl_Token VALUES(''bb640443-9cb4-499d-a5f2-7e345a9c92e9'',''Elasticsearch-Connector-Module'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''236b0653-6d4a-4d6f-bf2e-580f7ea780ca'') = 0
	insert into semtbl_Token VALUES(''236b0653-6d4a-4d6f-bf2e-580f7ea780ca'',''BaseConfig'',''74303821-1abf-4e60-b119-0e6c7fffbe2d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''d29b56cd-cdad-4b46-af59-0464909864b6'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''d29b56cd-cdad-4b46-af59-0464909864b6'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''ea85785e-42a2-41f1-b6f7-08cc803a21f7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''ea85785e-42a2-41f1-b6f7-08cc803a21f7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''c6141978-25a0-4e22-a359-22768240efef'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''c6141978-25a0-4e22-a359-22768240efef'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''6481c476-0c6b-4554-897e-260b4637fdcf'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''6481c476-0c6b-4554-897e-260b4637fdcf'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''5ea2aade-a23a-46a1-b34f-275676ac8a42'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''5ea2aade-a23a-46a1-b34f-275676ac8a42'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''9df96820-e006-4e98-bed4-299af16eba64'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''9df96820-e006-4e98-bed4-299af16eba64'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''daa8f561-5545-447c-b5df-2eaaacc2aac7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''daa8f561-5545-447c-b5df-2eaaacc2aac7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''2a7dbccc-75d5-437d-a284-315522f5e068'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''2a7dbccc-75d5-437d-a284-315522f5e068'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''134c4442-89bc-4907-a49b-3983c7afb9a6'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''134c4442-89bc-4907-a49b-3983c7afb9a6'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''56803624-0182-4926-9da5-3bc4fe5e7b31'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''56803624-0182-4926-9da5-3bc4fe5e7b31'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''92cb3704-e7d7-4e90-8d06-3d52a7f79c17'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''92cb3704-e7d7-4e90-8d06-3d52a7f79c17'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''ed372a04-810e-4d62-a819-41c8c94dc7b6'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''ed372a04-810e-4d62-a819-41c8c94dc7b6'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''cef07f53-d0a7-49de-8675-58fcea3594bc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''cef07f53-d0a7-49de-8675-58fcea3594bc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''2f06b88c-090b-4217-bfd6-5a150a866db9'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''2f06b88c-090b-4217-bfd6-5a150a866db9'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''0c093478-9c30-4dfb-8f8f-5ae624b898f4'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''0c093478-9c30-4dfb-8f8f-5ae624b898f4'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''33b131b4-810d-449c-a3f7-60d16cba5853'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''33b131b4-810d-449c-a3f7-60d16cba5853'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''f5e9753e-c848-4e57-bf75-64005dda7ede'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''f5e9753e-c848-4e57-bf75-64005dda7ede'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''6c966e3c-c737-4af1-9970-68c8323679bc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''6c966e3c-c737-4af1-9970-68c8323679bc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''e3d4516d-4f74-44ff-8472-6c2f016d457e'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''e3d4516d-4f74-44ff-8472-6c2f016d457e'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''30d56364-c7da-4fd4-878f-6c6c63481540'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''30d56364-c7da-4fd4-878f-6c6c63481540'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''6e494944-f602-4dcb-906f-70e5efe8f1dd'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''8a650a18-5ec5-4732-9656-784c6b24768e'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''8a650a18-5ec5-4732-9656-784c6b24768e'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''f2cde058-614e-41cb-96eb-78bbcf285171'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''f2cde058-614e-41cb-96eb-78bbcf285171'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''77fe297f-10d5-48b6-9543-7af4ea5b4909'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''77fe297f-10d5-48b6-9543-7af4ea5b4909'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''b557820e-0322-42c4-b651-7dee101f5817'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''b557820e-0322-42c4-b651-7dee101f5817'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''31ff7c35-21e8-45b2-9b86-81de3b26a71b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''31ff7c35-21e8-45b2-9b86-81de3b26a71b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''95e3d334-8193-4e9b-89cb-8e2baa3a0573'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''95e3d334-8193-4e9b-89cb-8e2baa3a0573'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''80133943-600f-4596-b55d-97a334e91417'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''80133943-600f-4596-b55d-97a334e91417'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''b87bb206-c885-4dc1-ba21-9adbc0cd55d9'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''b87bb206-c885-4dc1-ba21-9adbc0cd55d9'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''3186cc5e-023b-4edc-b6c7-a89919320839'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''6de11361-38e0-4337-a182-ab7fcf55c255'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''6de11361-38e0-4337-a182-ab7fcf55c255'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''f10253cf-f5c4-4777-8f4b-abc61217e28b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''f10253cf-f5c4-4777-8f4b-abc61217e28b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''44210c2e-190f-4095-b579-aeed7a807854'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''44210c2e-190f-4095-b579-aeed7a807854'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''f1ba23ed-ab41-4d34-8e09-b4e485671478'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''40443821-c238-4ac1-b9c3-bce0ae4cbdb8'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''40443821-c238-4ac1-b9c3-bce0ae4cbdb8'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''05fe193e-f8a0-46d3-bbae-c2300b8f57fc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''05fe193e-f8a0-46d3-bbae-c2300b8f57fc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''23d54d1e-3a3c-442f-bb96-c7eba4daa856'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''23d54d1e-3a3c-442f-bb96-c7eba4daa856'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''fec7ae6f-9434-4fca-b929-cbd5e7def83d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''fec7ae6f-9434-4fca-b929-cbd5e7def83d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''fd7f0cf5-5e08-4097-b3de-cbf42b0d17ae'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''fd7f0cf5-5e08-4097-b3de-cbf42b0d17ae'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''b2107a10-fbcb-4cc0-822f-e3800c7c3beb'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''b2107a10-fbcb-4cc0-822f-e3800c7c3beb'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''f08d5f7e-c262-4998-b0c2-e81cb83052aa'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''f08d5f7e-c262-4998-b0c2-e81cb83052aa'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''15fc84c5-3b78-4520-85dc-e8282756cc3a'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''15fc84c5-3b78-4520-85dc-e8282756cc3a'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''aed3d356-0c79-476c-971e-e917ee909603'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''aed3d356-0c79-476c-971e-e917ee909603'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_Token_Right=''5e4427ff-b65f-4f54-9c3c-f291f96c7749'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea952101-d18b-4542-81bd-3ece8de0add5'',''5e4427ff-b65f-4f54-9c3c-f291f96c7749'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5afa8b15-09ae-487c-a02d-4ff3e9ac88c4'' AND GUID_Token_Right=''ea952101-d18b-4542-81bd-3ece8de0add5'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5afa8b15-09ae-487c-a02d-4ff3e9ac88c4'',''ea952101-d18b-4542-81bd-3ece8de0add5'',''fafc1464-815f-4596-9737-bcbc96bd744a'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ad6e710c-a9ab-4b05-85bd-9475f7eca7be'' AND GUID_Token_Right=''392f4e01-491c-4da1-9894-42e368c8339f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ad6e710c-a9ab-4b05-85bd-9475f7eca7be'',''392f4e01-491c-4da1-9894-42e368c8339f'',''e9711603-47db-44d8-a476-fe88290639a4'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ad6e710c-a9ab-4b05-85bd-9475f7eca7be'' AND GUID_Token_Right=''79a019e3-7c8c-4a26-8ac8-8f918f3c0509'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ad6e710c-a9ab-4b05-85bd-9475f7eca7be'',''79a019e3-7c8c-4a26-8ac8-8f918f3c0509'',''e9711603-47db-44d8-a476-fe88290639a4'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ad6e710c-a9ab-4b05-85bd-9475f7eca7be'' AND GUID_Token_Right=''04cd4762-a7a9-4108-88b2-c023cab40a8f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ad6e710c-a9ab-4b05-85bd-9475f7eca7be'',''04cd4762-a7a9-4108-88b2-c023cab40a8f'',''e9711603-47db-44d8-a476-fe88290639a4'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''9af284c0-e391-40ec-b8bb-a5c2b92d044f'' AND GUID_Token_Right=''88382390-0d28-41f4-a5d7-0b76aabd3235'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''9af284c0-e391-40ec-b8bb-a5c2b92d044f'',''88382390-0d28-41f4-a5d7-0b76aabd3235'',''e9711603-47db-44d8-a476-fe88290639a4'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''9af284c0-e391-40ec-b8bb-a5c2b92d044f'' AND GUID_Token_Right=''f7645fbc-8ab5-4f8d-85b9-3f8543d5583b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''9af284c0-e391-40ec-b8bb-a5c2b92d044f'',''f7645fbc-8ab5-4f8d-85b9-3f8543d5583b'',''e9711603-47db-44d8-a476-fe88290639a4'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''bb640443-9cb4-499d-a5f2-7e345a9c92e9'' AND GUID_Token_Right=''5afa8b15-09ae-487c-a02d-4ff3e9ac88c4'' AND GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	INSERT INTO semtbl_Token_Token VALUES(''bb640443-9cb4-499d-a5f2-7e345a9c92e9'',''5afa8b15-09ae-487c-a02d-4ff3e9ac88c4'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''236b0653-6d4a-4d6f-bf2e-580f7ea780ca'' AND GUID_Token_Right=''bb640443-9cb4-499d-a5f2-7e345a9c92e9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''236b0653-6d4a-4d6f-bf2e-580f7ea780ca'',''bb640443-9cb4-499d-a5f2-7e345a9c92e9'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'' AND GUID_Attribute=''f1dd87f2-ac53-4e83-a76b-fee5bffc6909'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'',''f1dd87f2-ac53-4e83-a76b-fee5bffc6909'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_Attribute=''d4ea61d7-ec98-484d-a1cd-cd02d41cd0d3'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''d4ea61d7-ec98-484d-a1cd-cd02d41cd0d3'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''094d728d-6efc-463c-85c7-2dcfed903c78'' AND GUID_Attribute=''4fcf775b-2e0b-4712-be8d-0e8e0c643040'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''094d728d-6efc-463c-85c7-2dcfed903c78'',''4fcf775b-2e0b-4712-be8d-0e8e0c643040'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''094d728d-6efc-463c-85c7-2dcfed903c78'' AND GUID_Attribute=''166531b2-a224-4ce1-bd01-6e38fec36bb3'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''094d728d-6efc-463c-85c7-2dcfed903c78'',''166531b2-a224-4ce1-bd01-6e38fec36bb3'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Attribute=''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Attribute=''b67c3f3c-da03-4693-9afc-d2014997e328'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''b67c3f3c-da03-4693-9afc-d2014997e328'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_Attribute=''a1b49452-19dc-4eae-a000-ef3802de35a9'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''a1b49452-19dc-4eae-a000-ef3802de35a9'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_Attribute=''30b76a62-1b22-4f17-b9a5-ff665e08f35a'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''30b76a62-1b22-4f17-b9a5-ff665e08f35a'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''2bf81077-b8c9-4e0e-99bf-b8329ed8bf25'' AND GUID_Attribute=''5e0c66db-0992-4c92-9dbb-0568e58250f9'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''2bf81077-b8c9-4e0e-99bf-b8329ed8bf25'',''5e0c66db-0992-4c92-9dbb-0568e58250f9'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_Attribute=''68ac4472-ee22-4229-96ec-9753a016900a'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''327e9773-fca6-458c-a44d-338a556e0ad9'',''68ac4472-ee22-4229-96ec-9753a016900a'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''4158aad2-656a-4fb9-97bf-524c6f5fecaa'' AND GUID_Attribute=''3940fb8a-7ec9-4bd5-9719-aed313da116d'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''4158aad2-656a-4fb9-97bf-524c6f5fecaa'',''3940fb8a-7ec9-4bd5-9719-aed313da116d'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''74303821-1abf-4e60-b119-0e6c7fffbe2d'' AND GUID_Type_Right=''9ba24283-a0ad-4717-be30-6f0f3818c36c'' AND GUID_RelationType=''a80b1064-649b-4510-980e-c28be335956c'')=0
	INSERT INTO semtbl_Type_Type VALUES(''74303821-1abf-4e60-b119-0e6c7fffbe2d'',''9ba24283-a0ad-4717-be30-6f0f3818c36c'',''a80b1064-649b-4510-980e-c28be335956c'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''74303821-1abf-4e60-b119-0e6c7fffbe2d'' AND GUID_Type_Right=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''74303821-1abf-4e60-b119-0e6c7fffbe2d'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''094d728d-6efc-463c-85c7-2dcfed903c78'' AND GUID_Type_Right=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''094d728d-6efc-463c-85c7-2dcfed903c78'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''094d728d-6efc-463c-85c7-2dcfed903c78'' AND GUID_Type_Right=''ca4eff30-a40b-476d-9906-9f56a67c8cf9'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''094d728d-6efc-463c-85c7-2dcfed903c78'',''ca4eff30-a40b-476d-9906-9f56a67c8cf9'',''e9711603-47db-44d8-a476-fe88290639a4'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_Type_Right=''4158aad2-656a-4fb9-97bf-524c6f5fecaa'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''327e9773-fca6-458c-a44d-338a556e0ad9'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_Type_Right=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_RelationType=''0fa056ea-474f-424f-ab68-0a10b57d3a95'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''0fa056ea-474f-424f-ab68-0a10b57d3a95'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_Type_Right=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_RelationType=''6edbb77c-18d1-4736-92bf-7bd5e5dde8b8'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''6edbb77c-18d1-4736-92bf-7bd5e5dde8b8'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_Type_Right=''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_Type_Right=''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''1233afbe-60bf-40e7-9228-64ca4013b75c'' AND GUID_Type_Right=''9ba24283-a0ad-4717-be30-6f0f3818c36c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''1233afbe-60bf-40e7-9228-64ca4013b75c'',''9ba24283-a0ad-4717-be30-6f0f3818c36c'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9ba24283-a0ad-4717-be30-6f0f3818c36c'' AND GUID_Type_Right=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9ba24283-a0ad-4717-be30-6f0f3818c36c'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9ba24283-a0ad-4717-be30-6f0f3818c36c'' AND GUID_Type_Right=''ca4eff30-a40b-476d-9906-9f56a67c8cf9'' AND GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9ba24283-a0ad-4717-be30-6f0f3818c36c'',''ca4eff30-a40b-476d-9906-9f56a67c8cf9'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'' AND GUID_Type_Right=''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'',''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''eb411e2f-f93d-4a5e-bbba-c0b5d7ec0197'' AND GUID_Type_Right=''eb411e2f-f93d-4a5e-bbba-c0b5d7ec0197'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''eb411e2f-f93d-4a5e-bbba-c0b5d7ec0197'',''eb411e2f-f93d-4a5e-bbba-c0b5d7ec0197'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_RelationType=''4f8f29b4-49bb-4d85-a65f-205d2af4f509'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''4f8f29b4-49bb-4d85-a65f-205d2af4f509'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c6c9bcb8-0ac9-4713-9417-eeec1453026c'' AND GUID_Type_Right=''13c09f11-175c-4eef-bc8a-0fd8e86d557f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c6c9bcb8-0ac9-4713-9417-eeec1453026c'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''c6c9bcb8-0ac9-4713-9417-eeec1453026c'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''c6c9bcb8-0ac9-4713-9417-eeec1453026c'',''fafc1464-815f-4596-9737-bcbc96bd744a'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''408db9f1-ae42-4807-b656-729270646f0a'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''fafc1464-815f-4596-9737-bcbc96bd744a'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e72ac2b4-d7d0-421a-b0d5-ca025987d52f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e72ac2b4-d7d0-421a-b0d5-ca025987d52f'',''5afa8b15-09ae-487c-a02d-4ff3e9ac88c4'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''8e1663b0-8602-4f3f-aa00-ad60917fab2a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''8e1663b0-8602-4f3f-aa00-ad60917fab2a'',''ad6e710c-a9ab-4b05-85bd-9475f7eca7be'',''68ac4472-ee22-4229-96ec-9753a016900a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''2eca5778-fbb2-4b3e-93fd-742cc3901fb7'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''2eca5778-fbb2-4b3e-93fd-742cc3901fb7'',''9af284c0-e391-40ec-b8bb-a5c2b92d044f'',''68ac4472-ee22-4229-96ec-9753a016900a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Varchar255 WHERE GUID_TokenAttribute=''e72ac2b4-d7d0-421a-b0d5-ca025987d52f'' )=0
	INSERT INTO semtbl_Token_Attribute_Varchar255 VALUES(''e72ac2b4-d7d0-421a-b0d5-ca025987d52f'',''elasticsearch_connector_module'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_VarcharMax WHERE GUID_TokenAttribute=''8e1663b0-8602-4f3f-aa00-ad60917fab2a'' )=0
	INSERT INTO semtbl_Token_Attribute_VarcharMax VALUES(''8e1663b0-8602-4f3f-aa00-ad60917fab2a'',''<?xml version="1.0" encoding="utf-8"?>
<data>
<![CDATA[{ "index" : { "_index" : "@INDEX@", "_type" : "@TYPE@", "_id" : "@ID@" } }]]>
</data>'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_VarcharMax WHERE GUID_TokenAttribute=''2eca5778-fbb2-4b3e-93fd-742cc3901fb7'' )=0
	INSERT INTO semtbl_Token_Attribute_VarcharMax VALUES(''2eca5778-fbb2-4b3e-93fd-742cc3901fb7'',''<?xml version="1.0" encoding="utf-8"?>
<data>
<![CDATA[{ "@FIELD@" : @VALUE@ }]]>
</data>'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'')=0
	INSERT INTO semtbl_OR VALUES(''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''191b2368-a79a-467b-88de-effb85dedc6a'')=0
	INSERT INTO semtbl_OR VALUES(''191b2368-a79a-467b-88de-effb85dedc6a'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'')=0
	INSERT INTO semtbl_OR VALUES(''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d5edf818-62ee-456f-abda-5195646a8459'')=0
	INSERT INTO semtbl_OR VALUES(''d5edf818-62ee-456f-abda-5195646a8459'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''259ca012-d01d-443e-aa67-b8bbb2e141b3'')=0
	INSERT INTO semtbl_OR VALUES(''259ca012-d01d-443e-aa67-b8bbb2e141b3'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''7f7b4d7a-ccc0-4e43-91b7-dd019687708e'')=0
	INSERT INTO semtbl_OR VALUES(''7f7b4d7a-ccc0-4e43-91b7-dd019687708e'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''5be84ca4-f091-433f-8db9-dc8bfc32ad71'')=0
	INSERT INTO semtbl_OR VALUES(''5be84ca4-f091-433f-8db9-dc8bfc32ad71'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8596804a-b301-4b0f-a63f-c113f2ad47d0'')=0
	INSERT INTO semtbl_OR VALUES(''8596804a-b301-4b0f-a63f-c113f2ad47d0'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''1fc5febd-08f7-4f6e-852a-f61b1cc0c614'')=0
	INSERT INTO semtbl_OR VALUES(''1fc5febd-08f7-4f6e-852a-f61b1cc0c614'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''91ff4559-3a0f-4436-9ded-588f3027314b'')=0
	INSERT INTO semtbl_OR VALUES(''91ff4559-3a0f-4436-9ded-588f3027314b'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b706b7f9-40ae-431f-afdf-b44f25701fc1'')=0
	INSERT INTO semtbl_OR VALUES(''b706b7f9-40ae-431f-afdf-b44f25701fc1'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b657f515-006b-422b-a26f-8017c6463e78'')=0
	INSERT INTO semtbl_OR VALUES(''b657f515-006b-422b-a26f-8017c6463e78'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b5a71e14-f203-4da9-b8e4-bd526ab5feba'')=0
	INSERT INTO semtbl_OR VALUES(''b5a71e14-f203-4da9-b8e4-bd526ab5feba'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''754fc5e3-2d0f-473b-89bd-c5520706bbbf'')=0
	INSERT INTO semtbl_OR VALUES(''754fc5e3-2d0f-473b-89bd-c5520706bbbf'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''1669dcbb-9275-4051-b253-5b7c40ca12f4'')=0
	INSERT INTO semtbl_OR VALUES(''1669dcbb-9275-4051-b253-5b7c40ca12f4'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e0452671-3115-4239-ae55-be8fc47aa253'')=0
	INSERT INTO semtbl_OR VALUES(''e0452671-3115-4239-ae55-be8fc47aa253'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''1f60dbcf-cf1a-45de-8d61-87f77f42f118'')=0
	INSERT INTO semtbl_OR VALUES(''1f60dbcf-cf1a-45de-8d61-87f77f42f118'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''880400b2-6832-4368-baa9-a1d543c382e7'')=0
	INSERT INTO semtbl_OR VALUES(''880400b2-6832-4368-baa9-a1d543c382e7'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''9d321253-bc17-4a6b-8b11-3d04430e0623'')=0
	INSERT INTO semtbl_OR VALUES(''9d321253-bc17-4a6b-8b11-3d04430e0623'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'')=0
	INSERT INTO semtbl_OR VALUES(''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8d26bffc-ae48-4ce9-b594-c911fa60ffe3'')=0
	INSERT INTO semtbl_OR VALUES(''8d26bffc-ae48-4ce9-b594-c911fa60ffe3'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d4e550c2-8ffd-4cb6-8940-34786e975cbd'')=0
	INSERT INTO semtbl_OR VALUES(''d4e550c2-8ffd-4cb6-8940-34786e975cbd'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'')=0
	INSERT INTO semtbl_OR VALUES(''008817a6-14e7-4295-9a69-6835575ae53b'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6d7d8bf3-3363-4146-8c99-593b36f8833a'')=0
	INSERT INTO semtbl_OR VALUES(''6d7d8bf3-3363-4146-8c99-593b36f8833a'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'')=0
	INSERT INTO semtbl_OR VALUES(''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''06cddf4c-9b68-49c7-b583-9643c4c6048c'')=0
	INSERT INTO semtbl_OR VALUES(''06cddf4c-9b68-49c7-b583-9643c4c6048c'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''27afd387-267c-4f28-9e66-b0f41d0f963f'')=0
	INSERT INTO semtbl_OR VALUES(''27afd387-267c-4f28-9e66-b0f41d0f963f'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8c1a80aa-657c-42a5-946e-8a01a2790e42'')=0
	INSERT INTO semtbl_OR VALUES(''8c1a80aa-657c-42a5-946e-8a01a2790e42'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''869ac306-e85e-4696-81ac-252df0f9e29d'')=0
	INSERT INTO semtbl_OR VALUES(''869ac306-e85e-4696-81ac-252df0f9e29d'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''07d78334-08f5-458a-b84a-b586f60700b9'')=0
	INSERT INTO semtbl_OR VALUES(''07d78334-08f5-458a-b84a-b586f60700b9'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''900731bd-88fc-488d-9da2-36c7b50a3e6f'')=0
	INSERT INTO semtbl_OR VALUES(''900731bd-88fc-488d-9da2-36c7b50a3e6f'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''4eb9e003-fbf2-44bd-ae09-b58d95dc0247'')=0
	INSERT INTO semtbl_OR VALUES(''4eb9e003-fbf2-44bd-ae09-b58d95dc0247'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'')=0
	INSERT INTO semtbl_OR VALUES(''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8ebbf711-0631-4741-bf14-403ea0b2a2b4'')=0
	INSERT INTO semtbl_OR VALUES(''8ebbf711-0631-4741-bf14-403ea0b2a2b4'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''a3eefd82-7501-4d2a-b95b-0314be945223'')=0
	INSERT INTO semtbl_OR VALUES(''a3eefd82-7501-4d2a-b95b-0314be945223'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b4fe7a2e-3c57-4a5b-8668-5eb31e689b81'')=0
	INSERT INTO semtbl_OR VALUES(''b4fe7a2e-3c57-4a5b-8668-5eb31e689b81'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'')=0
	INSERT INTO semtbl_OR VALUES(''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''3c1c1069-7064-4e4d-802a-ce6feedb9de9'')=0
	INSERT INTO semtbl_OR VALUES(''3c1c1069-7064-4e4d-802a-ce6feedb9de9'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''2bad766e-2271-4ea5-9078-71892bf10244'')=0
	INSERT INTO semtbl_OR VALUES(''2bad766e-2271-4ea5-9078-71892bf10244'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8a860df3-fa45-4726-a62c-222c41c78bad'')=0
	INSERT INTO semtbl_OR VALUES(''8a860df3-fa45-4726-a62c-222c41c78bad'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d6c69cc0-3ab2-4f94-9c9f-82e05e3bd126'')=0
	INSERT INTO semtbl_OR VALUES(''d6c69cc0-3ab2-4f94-9c9f-82e05e3bd126'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''566bf7c3-23d5-43e6-92a6-627e93f92e30'')=0
	INSERT INTO semtbl_OR VALUES(''566bf7c3-23d5-43e6-92a6-627e93f92e30'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'')=0
	INSERT INTO semtbl_OR VALUES(''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''1cbffd76-39e6-46af-bf36-ef3173c2689a'')=0
	INSERT INTO semtbl_OR VALUES(''1cbffd76-39e6-46af-bf36-ef3173c2689a'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''adb5b37a-5f23-4900-b322-9c87601b3794'')=0
	INSERT INTO semtbl_OR VALUES(''adb5b37a-5f23-4900-b322-9c87601b3794'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''3884a57c-a7ea-43bb-bc33-552f1d8bb7c8'')=0
	INSERT INTO semtbl_OR VALUES(''3884a57c-a7ea-43bb-bc33-552f1d8bb7c8'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''38dc5700-e76e-4593-a88a-76cdb9c0f59b'')=0
	INSERT INTO semtbl_OR VALUES(''38dc5700-e76e-4593-a88a-76cdb9c0f59b'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''692044fc-4362-4793-8ce5-3ff97ea8587b'')=0
	INSERT INTO semtbl_OR VALUES(''692044fc-4362-4793-8ce5-3ff97ea8587b'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'')=0
	INSERT INTO semtbl_OR_Type VALUES(''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'')=0
	INSERT INTO semtbl_OR_Type VALUES(''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''8596804a-b301-4b0f-a63f-c113f2ad47d0'')=0
	INSERT INTO semtbl_OR_Type VALUES(''8596804a-b301-4b0f-a63f-c113f2ad47d0'',''74303821-1abf-4e60-b119-0e6c7fffbe2d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''b706b7f9-40ae-431f-afdf-b44f25701fc1'')=0
	INSERT INTO semtbl_OR_Type VALUES(''b706b7f9-40ae-431f-afdf-b44f25701fc1'',''ca4eff30-a40b-476d-9906-9f56a67c8cf9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''880400b2-6832-4368-baa9-a1d543c382e7'')=0
	INSERT INTO semtbl_OR_Type VALUES(''880400b2-6832-4368-baa9-a1d543c382e7'',''9ba24283-a0ad-4717-be30-6f0f3818c36c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''8c1a80aa-657c-42a5-946e-8a01a2790e42'')=0
	INSERT INTO semtbl_OR_Type VALUES(''8c1a80aa-657c-42a5-946e-8a01a2790e42'',''1233afbe-60bf-40e7-9228-64ca4013b75c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''869ac306-e85e-4696-81ac-252df0f9e29d'')=0
	INSERT INTO semtbl_OR_Type VALUES(''869ac306-e85e-4696-81ac-252df0f9e29d'',''d79c764d-e946-454c-8e91-054ca1471cf2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''8ebbf711-0631-4741-bf14-403ea0b2a2b4'')=0
	INSERT INTO semtbl_OR_Type VALUES(''8ebbf711-0631-4741-bf14-403ea0b2a2b4'',''48d76692-2ee7-4b34-b3bf-4a8116a50d0d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''a3eefd82-7501-4d2a-b95b-0314be945223'')=0
	INSERT INTO semtbl_OR_Type VALUES(''a3eefd82-7501-4d2a-b95b-0314be945223'',''094d728d-6efc-463c-85c7-2dcfed903c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'')=0
	INSERT INTO semtbl_OR_Type VALUES(''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''3c1c1069-7064-4e4d-802a-ce6feedb9de9'')=0
	INSERT INTO semtbl_OR_Type VALUES(''3c1c1069-7064-4e4d-802a-ce6feedb9de9'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''8a860df3-fa45-4726-a62c-222c41c78bad'')=0
	INSERT INTO semtbl_OR_Type VALUES(''8a860df3-fa45-4726-a62c-222c41c78bad'',''e1be73cd-0deb-41a0-a222-b779e7862412'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'')=0
	INSERT INTO semtbl_OR_Type VALUES(''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''1cbffd76-39e6-46af-bf36-ef3173c2689a'')=0
	INSERT INTO semtbl_OR_Type VALUES(''1cbffd76-39e6-46af-bf36-ef3173c2689a'',''d9775bda-1526-475b-8e16-723881828876'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''adb5b37a-5f23-4900-b322-9c87601b3794'')=0
	INSERT INTO semtbl_OR_Type VALUES(''adb5b37a-5f23-4900-b322-9c87601b3794'',''2bf81077-b8c9-4e0e-99bf-b8329ed8bf25'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''38dc5700-e76e-4593-a88a-76cdb9c0f59b'')=0
	INSERT INTO semtbl_OR_Type VALUES(''38dc5700-e76e-4593-a88a-76cdb9c0f59b'',''52b61535-d619-4db8-a3ea-fb77b864dc55'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''b5a71e14-f203-4da9-b8e4-bd526ab5feba'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''b5a71e14-f203-4da9-b8e4-bd526ab5feba'',''68ac4472-ee22-4229-96ec-9753a016900a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''900731bd-88fc-488d-9da2-36c7b50a3e6f'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''900731bd-88fc-488d-9da2-36c7b50a3e6f'',''5e0c66db-0992-4c92-9dbb-0568e58250f9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''191b2368-a79a-467b-88de-effb85dedc6a'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''191b2368-a79a-467b-88de-effb85dedc6a'',''66857dba-efd6-48c9-ad54-04103f56ab8a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''7f7b4d7a-ccc0-4e43-91b7-dd019687708e'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''7f7b4d7a-ccc0-4e43-91b7-dd019687708e'',''a80b1064-649b-4510-980e-c28be335956c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''5be84ca4-f091-433f-8db9-dc8bfc32ad71'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''5be84ca4-f091-433f-8db9-dc8bfc32ad71'',''6b106ab9-7e68-44f1-8a75-4612e021d7ab'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''91ff4559-3a0f-4436-9ded-588f3027314b'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''91ff4559-3a0f-4436-9ded-588f3027314b'',''e6fa577e-ad2f-4c34-b314-061f5fa6c894'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''e9711603-47db-44d8-a476-fe88290639a4'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''8d26bffc-ae48-4ce9-b594-c911fa60ffe3'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''8d26bffc-ae48-4ce9-b594-c911fa60ffe3'',''aaf3e012-a822-4ba6-9d9d-d5bb35821757'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''008817a6-14e7-4295-9a69-6835575ae53b'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''07d78334-08f5-458a-b84a-b586f60700b9'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''07d78334-08f5-458a-b84a-b586f60700b9'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''e07469d9-766c-443e-8526-6d9c684f944f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''692044fc-4362-4793-8ce5-3ff97ea8587b'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''692044fc-4362-4793-8ce5-3ff97ea8587b'',''82047cba-f63a-429f-a61b-33b622a9826e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''d5edf818-62ee-456f-abda-5195646a8459'')=0
	INSERT INTO semtbl_OR_Token VALUES(''d5edf818-62ee-456f-abda-5195646a8459'',''9285e6f5-4dd3-41a7-a20d-b8dd5b0c3eeb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''259ca012-d01d-443e-aa67-b8bbb2e141b3'')=0
	INSERT INTO semtbl_OR_Token VALUES(''259ca012-d01d-443e-aa67-b8bbb2e141b3'',''2ad76ad0-14c2-47cc-abec-81397298c6c8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''1fc5febd-08f7-4f6e-852a-f61b1cc0c614'')=0
	INSERT INTO semtbl_OR_Token VALUES(''1fc5febd-08f7-4f6e-852a-f61b1cc0c614'',''dbbfc1a0-0c2e-4836-8434-0a7b7a8b4b52'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''b657f515-006b-422b-a26f-8017c6463e78'')=0
	INSERT INTO semtbl_OR_Token VALUES(''b657f515-006b-422b-a26f-8017c6463e78'',''ad6e710c-a9ab-4b05-85bd-9475f7eca7be'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''754fc5e3-2d0f-473b-89bd-c5520706bbbf'')=0
	INSERT INTO semtbl_OR_Token VALUES(''754fc5e3-2d0f-473b-89bd-c5520706bbbf'',''69d36f9c-c59a-4766-9d10-8a46bed99b54'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''1669dcbb-9275-4051-b253-5b7c40ca12f4'')=0
	INSERT INTO semtbl_OR_Token VALUES(''1669dcbb-9275-4051-b253-5b7c40ca12f4'',''88382390-0d28-41f4-a5d7-0b76aabd3235'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''e0452671-3115-4239-ae55-be8fc47aa253'')=0
	INSERT INTO semtbl_OR_Token VALUES(''e0452671-3115-4239-ae55-be8fc47aa253'',''d91d58a8-3c0d-4845-ba12-a727583291c8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''1f60dbcf-cf1a-45de-8d61-87f77f42f118'')=0
	INSERT INTO semtbl_OR_Token VALUES(''1f60dbcf-cf1a-45de-8d61-87f77f42f118'',''407e2719-982a-4ef5-a893-d3dfc2c42764'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''9d321253-bc17-4a6b-8b11-3d04430e0623'')=0
	INSERT INTO semtbl_OR_Token VALUES(''9d321253-bc17-4a6b-8b11-3d04430e0623'',''04cd4762-a7a9-4108-88b2-c023cab40a8f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''d4e550c2-8ffd-4cb6-8940-34786e975cbd'')=0
	INSERT INTO semtbl_OR_Token VALUES(''d4e550c2-8ffd-4cb6-8940-34786e975cbd'',''30039a60-0e36-4ec8-92ac-a2892e35e247'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''6d7d8bf3-3363-4146-8c99-593b36f8833a'')=0
	INSERT INTO semtbl_OR_Token VALUES(''6d7d8bf3-3363-4146-8c99-593b36f8833a'',''e9ae24bf-f89b-407c-b36d-51f8219df6c8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''06cddf4c-9b68-49c7-b583-9643c4c6048c'')=0
	INSERT INTO semtbl_OR_Token VALUES(''06cddf4c-9b68-49c7-b583-9643c4c6048c'',''eff5d646-9ef6-447b-8575-921462f3b9b8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''27afd387-267c-4f28-9e66-b0f41d0f963f'')=0
	INSERT INTO semtbl_OR_Token VALUES(''27afd387-267c-4f28-9e66-b0f41d0f963f'',''e36a4286-f34d-485f-b435-bd1344033c74'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''4eb9e003-fbf2-44bd-ae09-b58d95dc0247'')=0
	INSERT INTO semtbl_OR_Token VALUES(''4eb9e003-fbf2-44bd-ae09-b58d95dc0247'',''d597e2c2-3fd5-4010-bcc7-82a664dd0563'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''b4fe7a2e-3c57-4a5b-8668-5eb31e689b81'')=0
	INSERT INTO semtbl_OR_Token VALUES(''b4fe7a2e-3c57-4a5b-8668-5eb31e689b81'',''392f4e01-491c-4da1-9894-42e368c8339f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''2bad766e-2271-4ea5-9078-71892bf10244'')=0
	INSERT INTO semtbl_OR_Token VALUES(''2bad766e-2271-4ea5-9078-71892bf10244'',''0d1d690b-d406-4fb6-bdf0-475c29a7a9fe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''d6c69cc0-3ab2-4f94-9c9f-82e05e3bd126'')=0
	INSERT INTO semtbl_OR_Token VALUES(''d6c69cc0-3ab2-4f94-9c9f-82e05e3bd126'',''79a019e3-7c8c-4a26-8ac8-8f918f3c0509'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''566bf7c3-23d5-43e6-92a6-627e93f92e30'')=0
	INSERT INTO semtbl_OR_Token VALUES(''566bf7c3-23d5-43e6-92a6-627e93f92e30'',''f7645fbc-8ab5-4f8d-85b9-3f8543d5583b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''3884a57c-a7ea-43bb-bc33-552f1d8bb7c8'')=0
	INSERT INTO semtbl_OR_Token VALUES(''3884a57c-a7ea-43bb-bc33-552f1d8bb7c8'',''9af284c0-e391-40ec-b8bb-a5c2b92d044f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d29b56cd-cdad-4b46-af59-0464909864b6'' AND GUID_ObjectReference=''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d29b56cd-cdad-4b46-af59-0464909864b6'',''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ea85785e-42a2-41f1-b6f7-08cc803a21f7'' AND GUID_ObjectReference=''191b2368-a79a-467b-88de-effb85dedc6a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ea85785e-42a2-41f1-b6f7-08cc803a21f7'',''191b2368-a79a-467b-88de-effb85dedc6a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'' AND GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''c6141978-25a0-4e22-a359-22768240efef'' AND GUID_ObjectReference=''d5edf818-62ee-456f-abda-5195646a8459'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''c6141978-25a0-4e22-a359-22768240efef'',''d5edf818-62ee-456f-abda-5195646a8459'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6481c476-0c6b-4554-897e-260b4637fdcf'' AND GUID_ObjectReference=''259ca012-d01d-443e-aa67-b8bbb2e141b3'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6481c476-0c6b-4554-897e-260b4637fdcf'',''259ca012-d01d-443e-aa67-b8bbb2e141b3'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''5ea2aade-a23a-46a1-b34f-275676ac8a42'' AND GUID_ObjectReference=''7f7b4d7a-ccc0-4e43-91b7-dd019687708e'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''5ea2aade-a23a-46a1-b34f-275676ac8a42'',''7f7b4d7a-ccc0-4e43-91b7-dd019687708e'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''9df96820-e006-4e98-bed4-299af16eba64'' AND GUID_ObjectReference=''5be84ca4-f091-433f-8db9-dc8bfc32ad71'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''9df96820-e006-4e98-bed4-299af16eba64'',''5be84ca4-f091-433f-8db9-dc8bfc32ad71'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''daa8f561-5545-447c-b5df-2eaaacc2aac7'' AND GUID_ObjectReference=''8596804a-b301-4b0f-a63f-c113f2ad47d0'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''daa8f561-5545-447c-b5df-2eaaacc2aac7'',''8596804a-b301-4b0f-a63f-c113f2ad47d0'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''2a7dbccc-75d5-437d-a284-315522f5e068'' AND GUID_ObjectReference=''1fc5febd-08f7-4f6e-852a-f61b1cc0c614'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''2a7dbccc-75d5-437d-a284-315522f5e068'',''1fc5febd-08f7-4f6e-852a-f61b1cc0c614'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''134c4442-89bc-4907-a49b-3983c7afb9a6'' AND GUID_ObjectReference=''91ff4559-3a0f-4436-9ded-588f3027314b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''134c4442-89bc-4907-a49b-3983c7afb9a6'',''91ff4559-3a0f-4436-9ded-588f3027314b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''56803624-0182-4926-9da5-3bc4fe5e7b31'' AND GUID_ObjectReference=''b706b7f9-40ae-431f-afdf-b44f25701fc1'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''56803624-0182-4926-9da5-3bc4fe5e7b31'',''b706b7f9-40ae-431f-afdf-b44f25701fc1'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''92cb3704-e7d7-4e90-8d06-3d52a7f79c17'' AND GUID_ObjectReference=''b657f515-006b-422b-a26f-8017c6463e78'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''92cb3704-e7d7-4e90-8d06-3d52a7f79c17'',''b657f515-006b-422b-a26f-8017c6463e78'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'' AND GUID_ObjectReference=''b5a71e14-f203-4da9-b8e4-bd526ab5feba'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'',''b5a71e14-f203-4da9-b8e4-bd526ab5feba'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ed372a04-810e-4d62-a819-41c8c94dc7b6'' AND GUID_ObjectReference=''754fc5e3-2d0f-473b-89bd-c5520706bbbf'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ed372a04-810e-4d62-a819-41c8c94dc7b6'',''754fc5e3-2d0f-473b-89bd-c5520706bbbf'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''cef07f53-d0a7-49de-8675-58fcea3594bc'' AND GUID_ObjectReference=''1669dcbb-9275-4051-b253-5b7c40ca12f4'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''cef07f53-d0a7-49de-8675-58fcea3594bc'',''1669dcbb-9275-4051-b253-5b7c40ca12f4'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''2f06b88c-090b-4217-bfd6-5a150a866db9'' AND GUID_ObjectReference=''e0452671-3115-4239-ae55-be8fc47aa253'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''2f06b88c-090b-4217-bfd6-5a150a866db9'',''e0452671-3115-4239-ae55-be8fc47aa253'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''0c093478-9c30-4dfb-8f8f-5ae624b898f4'' AND GUID_ObjectReference=''1f60dbcf-cf1a-45de-8d61-87f77f42f118'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''0c093478-9c30-4dfb-8f8f-5ae624b898f4'',''1f60dbcf-cf1a-45de-8d61-87f77f42f118'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''33b131b4-810d-449c-a3f7-60d16cba5853'' AND GUID_ObjectReference=''880400b2-6832-4368-baa9-a1d543c382e7'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''33b131b4-810d-449c-a3f7-60d16cba5853'',''880400b2-6832-4368-baa9-a1d543c382e7'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f5e9753e-c848-4e57-bf75-64005dda7ede'' AND GUID_ObjectReference=''9d321253-bc17-4a6b-8b11-3d04430e0623'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f5e9753e-c848-4e57-bf75-64005dda7ede'',''9d321253-bc17-4a6b-8b11-3d04430e0623'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6c966e3c-c737-4af1-9970-68c8323679bc'' AND GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6c966e3c-c737-4af1-9970-68c8323679bc'',''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e3d4516d-4f74-44ff-8472-6c2f016d457e'' AND GUID_ObjectReference=''8d26bffc-ae48-4ce9-b594-c911fa60ffe3'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e3d4516d-4f74-44ff-8472-6c2f016d457e'',''8d26bffc-ae48-4ce9-b594-c911fa60ffe3'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''30d56364-c7da-4fd4-878f-6c6c63481540'' AND GUID_ObjectReference=''d4e550c2-8ffd-4cb6-8940-34786e975cbd'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''30d56364-c7da-4fd4-878f-6c6c63481540'',''d4e550c2-8ffd-4cb6-8940-34786e975cbd'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6e494944-f602-4dcb-906f-70e5efe8f1dd'' AND GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''008817a6-14e7-4295-9a69-6835575ae53b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8a650a18-5ec5-4732-9656-784c6b24768e'' AND GUID_ObjectReference=''6d7d8bf3-3363-4146-8c99-593b36f8833a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8a650a18-5ec5-4732-9656-784c6b24768e'',''6d7d8bf3-3363-4146-8c99-593b36f8833a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f2cde058-614e-41cb-96eb-78bbcf285171'' AND GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f2cde058-614e-41cb-96eb-78bbcf285171'',''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''77fe297f-10d5-48b6-9543-7af4ea5b4909'' AND GUID_ObjectReference=''06cddf4c-9b68-49c7-b583-9643c4c6048c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''77fe297f-10d5-48b6-9543-7af4ea5b4909'',''06cddf4c-9b68-49c7-b583-9643c4c6048c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b557820e-0322-42c4-b651-7dee101f5817'' AND GUID_ObjectReference=''27afd387-267c-4f28-9e66-b0f41d0f963f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b557820e-0322-42c4-b651-7dee101f5817'',''27afd387-267c-4f28-9e66-b0f41d0f963f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''31ff7c35-21e8-45b2-9b86-81de3b26a71b'' AND GUID_ObjectReference=''8c1a80aa-657c-42a5-946e-8a01a2790e42'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''31ff7c35-21e8-45b2-9b86-81de3b26a71b'',''8c1a80aa-657c-42a5-946e-8a01a2790e42'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''95e3d334-8193-4e9b-89cb-8e2baa3a0573'' AND GUID_ObjectReference=''869ac306-e85e-4696-81ac-252df0f9e29d'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''95e3d334-8193-4e9b-89cb-8e2baa3a0573'',''869ac306-e85e-4696-81ac-252df0f9e29d'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'' AND GUID_ObjectReference=''07d78334-08f5-458a-b84a-b586f60700b9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'',''07d78334-08f5-458a-b84a-b586f60700b9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''80133943-600f-4596-b55d-97a334e91417'' AND GUID_ObjectReference=''900731bd-88fc-488d-9da2-36c7b50a3e6f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''80133943-600f-4596-b55d-97a334e91417'',''900731bd-88fc-488d-9da2-36c7b50a3e6f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b87bb206-c885-4dc1-ba21-9adbc0cd55d9'' AND GUID_ObjectReference=''4eb9e003-fbf2-44bd-ae09-b58d95dc0247'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b87bb206-c885-4dc1-ba21-9adbc0cd55d9'',''4eb9e003-fbf2-44bd-ae09-b58d95dc0247'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6de11361-38e0-4337-a182-ab7fcf55c255'' AND GUID_ObjectReference=''8ebbf711-0631-4741-bf14-403ea0b2a2b4'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6de11361-38e0-4337-a182-ab7fcf55c255'',''8ebbf711-0631-4741-bf14-403ea0b2a2b4'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f10253cf-f5c4-4777-8f4b-abc61217e28b'' AND GUID_ObjectReference=''a3eefd82-7501-4d2a-b95b-0314be945223'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f10253cf-f5c4-4777-8f4b-abc61217e28b'',''a3eefd82-7501-4d2a-b95b-0314be945223'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''44210c2e-190f-4095-b579-aeed7a807854'' AND GUID_ObjectReference=''b4fe7a2e-3c57-4a5b-8668-5eb31e689b81'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''44210c2e-190f-4095-b579-aeed7a807854'',''b4fe7a2e-3c57-4a5b-8668-5eb31e689b81'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f1ba23ed-ab41-4d34-8e09-b4e485671478'' AND GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''40443821-c238-4ac1-b9c3-bce0ae4cbdb8'' AND GUID_ObjectReference=''3c1c1069-7064-4e4d-802a-ce6feedb9de9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''40443821-c238-4ac1-b9c3-bce0ae4cbdb8'',''3c1c1069-7064-4e4d-802a-ce6feedb9de9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''05fe193e-f8a0-46d3-bbae-c2300b8f57fc'' AND GUID_ObjectReference=''2bad766e-2271-4ea5-9078-71892bf10244'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''05fe193e-f8a0-46d3-bbae-c2300b8f57fc'',''2bad766e-2271-4ea5-9078-71892bf10244'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''23d54d1e-3a3c-442f-bb96-c7eba4daa856'' AND GUID_ObjectReference=''8a860df3-fa45-4726-a62c-222c41c78bad'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''23d54d1e-3a3c-442f-bb96-c7eba4daa856'',''8a860df3-fa45-4726-a62c-222c41c78bad'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''fec7ae6f-9434-4fca-b929-cbd5e7def83d'' AND GUID_ObjectReference=''d6c69cc0-3ab2-4f94-9c9f-82e05e3bd126'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''fec7ae6f-9434-4fca-b929-cbd5e7def83d'',''d6c69cc0-3ab2-4f94-9c9f-82e05e3bd126'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''fd7f0cf5-5e08-4097-b3de-cbf42b0d17ae'' AND GUID_ObjectReference=''566bf7c3-23d5-43e6-92a6-627e93f92e30'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''fd7f0cf5-5e08-4097-b3de-cbf42b0d17ae'',''566bf7c3-23d5-43e6-92a6-627e93f92e30'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'' AND GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b2107a10-fbcb-4cc0-822f-e3800c7c3beb'' AND GUID_ObjectReference=''1cbffd76-39e6-46af-bf36-ef3173c2689a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b2107a10-fbcb-4cc0-822f-e3800c7c3beb'',''1cbffd76-39e6-46af-bf36-ef3173c2689a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f08d5f7e-c262-4998-b0c2-e81cb83052aa'' AND GUID_ObjectReference=''adb5b37a-5f23-4900-b322-9c87601b3794'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f08d5f7e-c262-4998-b0c2-e81cb83052aa'',''adb5b37a-5f23-4900-b322-9c87601b3794'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''15fc84c5-3b78-4520-85dc-e8282756cc3a'' AND GUID_ObjectReference=''3884a57c-a7ea-43bb-bc33-552f1d8bb7c8'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''15fc84c5-3b78-4520-85dc-e8282756cc3a'',''3884a57c-a7ea-43bb-bc33-552f1d8bb7c8'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''aed3d356-0c79-476c-971e-e917ee909603'' AND GUID_ObjectReference=''38dc5700-e76e-4593-a88a-76cdb9c0f59b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''aed3d356-0c79-476c-971e-e917ee909603'',''38dc5700-e76e-4593-a88a-76cdb9c0f59b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''5e4427ff-b65f-4f54-9c3c-f291f96c7749'' AND GUID_ObjectReference=''692044fc-4362-4793-8ce5-3ff97ea8587b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''5e4427ff-b65f-4f54-9c3c-f291f96c7749'',''692044fc-4362-4793-8ce5-3ff97ea8587b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''13c09f11-175c-4eef-bc8a-0fd8e86d557f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''13c09f11-175c-4eef-bc8a-0fd8e86d557f'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1)'
GO
