use [sem_db_work]
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''68ac4472-ee22-4229-96ec-9753a016900a'') = 0
	insert into semtbl_Attribute VALUES(''68ac4472-ee22-4229-96ec-9753a016900a'',''XML-Text'',''64530b52-d96c-4df1-86fe-183f44513450'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type=''49fdcd27-e105-4770-941d-7485dcad08c1'') = 0
	insert into semtbl_Type (GUID_Type,Name_Type) VALUES(''49fdcd27-e105-4770-941d-7485dcad08c1'',''Root'')'
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='73e32abf-e577-4d31-9a46-bc07e9e15de3') = 0
	insert into semtbl_Type VALUES('73e32abf-e577-4d31-9a46-bc07e9e15de3','Software-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''236b0653-6d4a-4d6f-bf2e-580f7ea780ca'') = 0
	insert into semtbl_Token VALUES(''236b0653-6d4a-4d6f-bf2e-580f7ea780ca'',''BaseConfig'',''74303821-1abf-4e60-b119-0e6c7fffbe2d'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_RelationType=''4f8f29b4-49bb-4d85-a65f-205d2af4f509'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''4f8f29b4-49bb-4d85-a65f-205d2af4f509'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''8e1663b0-8602-4f3f-aa00-ad60917fab2a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''8e1663b0-8602-4f3f-aa00-ad60917fab2a'',''ad6e710c-a9ab-4b05-85bd-9475f7eca7be'',''68ac4472-ee22-4229-96ec-9753a016900a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''2eca5778-fbb2-4b3e-93fd-742cc3901fb7'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''2eca5778-fbb2-4b3e-93fd-742cc3901fb7'',''9af284c0-e391-40ec-b8bb-a5c2b92d044f'',''68ac4472-ee22-4229-96ec-9753a016900a'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1)'
GO
