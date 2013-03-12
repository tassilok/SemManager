use [sem_db_system]
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''3940fb8a-7ec9-4bd5-9719-aed313da116d'') = 0
	insert into semtbl_Attribute VALUES(''3940fb8a-7ec9-4bd5-9719-aed313da116d'',''Value'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''3316543a-c922-4bb8-afe8-b6f58db0adef'') = 0
	insert into semtbl_Attribute VALUES(''3316543a-c922-4bb8-afe8-b6f58db0adef'',''Standard'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''f1dd87f2-ac53-4e83-a76b-fee5bffc6909'') = 0
	insert into semtbl_Attribute VALUES(''f1dd87f2-ac53-4e83-a76b-fee5bffc6909'',''visible'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''68ac4472-ee22-4229-96ec-9753a016900a'') = 0
	insert into semtbl_Attribute VALUES(''68ac4472-ee22-4229-96ec-9753a016900a'',''XML-Text'',''64530b52-d96c-4df1-86fe-183f44513450'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''d4ea61d7-ec98-484d-a1cd-cd02d41cd0d3'') = 0
	insert into semtbl_Attribute VALUES(''d4ea61d7-ec98-484d-a1cd-cd02d41cd0d3'',''invisible'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''0705d441-2a3e-4ccf-bc35-140ae3d406bd'') = 0
	insert into semtbl_Attribute VALUES(''0705d441-2a3e-4ccf-bc35-140ae3d406bd'',''is Null'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''1d7d076b-bf2d-4274-88ee-a9a1f570e690'') = 0
	insert into semtbl_Attribute VALUES(''1d7d076b-bf2d-4274-88ee-a9a1f570e690'',''ASC'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''6c758923-0363-4259-bd18-8a44a9d7fad8'') = 0
	insert into semtbl_Attribute VALUES(''6c758923-0363-4259-bd18-8a44a9d7fad8'',''Row-Header'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''d777cd8b-b212-4f83-b67e-da8586f97eca'') = 0
	insert into semtbl_Attribute VALUES(''d777cd8b-b212-4f83-b67e-da8586f97eca'',''is Sem-DB'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''d5d5eb28-e26e-4845-846b-48701fb5ca26'') = 0
	insert into semtbl_Attribute VALUES(''d5d5eb28-e26e-4845-846b-48701fb5ca26'',''is exported'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''301374ab-7877-4dd9-9e5b-36db1e1125fa'') = 0
	insert into semtbl_Attribute VALUES(''301374ab-7877-4dd9-9e5b-36db1e1125fa'',''Master-Password'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''a1b49452-19dc-4eae-a000-ef3802de35a9'') = 0
	insert into semtbl_Attribute VALUES(''a1b49452-19dc-4eae-a000-ef3802de35a9'',''ProcessorID'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''30b76a62-1b22-4f17-b9a5-ff665e08f35a'') = 0
	insert into semtbl_Attribute VALUES(''30b76a62-1b22-4f17-b9a5-ff665e08f35a'',''BaseboardSerial'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''66857dba-efd6-48c9-ad54-04103f56ab8a'')=0
	insert into semtbl_RelationType VALUES(''66857dba-efd6-48c9-ad54-04103f56ab8a'',''Row-Config'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''a80b1064-649b-4510-980e-c28be335956c'')=0
	insert into semtbl_RelationType VALUES(''a80b1064-649b-4510-980e-c28be335956c'',''belonging Resources'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''2abef94e-34de-45ab-80c1-5d0ad5a006d0'')=0
	insert into semtbl_RelationType VALUES(''2abef94e-34de-45ab-80c1-5d0ad5a006d0'',''Table-Config'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''f7930edf-0e80-47f8-b1a5-84c4b15366a3'')=0
	insert into semtbl_RelationType VALUES(''f7930edf-0e80-47f8-b1a5-84c4b15366a3'',''Cell-Config'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	insert into semtbl_RelationType VALUES(''3e104b75-e01c-48a0-b041-12908fd446a0'',''is'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''801886c0-0938-47e2-945e-f3d34f7c68fe'')=0
	insert into semtbl_RelationType VALUES(''801886c0-0938-47e2-945e-f3d34f7c68fe'',''connected by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	insert into semtbl_RelationType VALUES(''e9711603-47db-44d8-a476-fe88290639a4'',''contains'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	insert into semtbl_RelationType VALUES(''9996494a-ef6a-4357-a6ef-71a92b5ff596'',''is of Type'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''6edbb77c-18d1-4736-92bf-7bd5e5dde8b8'')=0
	insert into semtbl_RelationType VALUES(''6edbb77c-18d1-4736-92bf-7bd5e5dde8b8'',''Type-Field'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	insert into semtbl_RelationType VALUES(''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',''belonging Source'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	insert into semtbl_RelationType VALUES(''e07469d9-766c-443e-8526-6d9c684f944f'',''belongs to'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''0fa056ea-474f-424f-ab68-0a10b57d3a95'')=0
	insert into semtbl_RelationType VALUES(''0fa056ea-474f-424f-ab68-0a10b57d3a95'',''leads'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'')=0
	insert into semtbl_RelationType VALUES(''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'',''located in'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''ace00f97-67b7-4177-bfe0-6ac7b3bfd8a5'')=0
	insert into semtbl_RelationType VALUES(''ace00f97-67b7-4177-bfe0-6ac7b3bfd8a5'',''Formatted by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	insert into semtbl_RelationType VALUES(''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',''offered by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''0ecc4f8c-c0de-49ad-834f-5194d568a16e'')=0
	insert into semtbl_RelationType VALUES(''0ecc4f8c-c0de-49ad-834f-5194d568a16e'',''encoded by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''d48c0e60-17bd-4f00-9323-644190285bd4'')=0
	insert into semtbl_RelationType VALUES(''d48c0e60-17bd-4f00-9323-644190285bd4'',''Config'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''536c136f-1f95-4e11-ab89-7c5e0d74445b'')=0
	insert into semtbl_RelationType VALUES(''536c136f-1f95-4e11-ab89-7c5e0d74445b'',''User'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''f0b70d32-d248-4020-992a-a8f7a920200c'')=0
	insert into semtbl_RelationType VALUES(''f0b70d32-d248-4020-992a-a8f7a920200c'',''Module'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''ed2f5120-2501-4a7c-a8be-ae1745fa8a5b'')=0
	insert into semtbl_RelationType VALUES(''ed2f5120-2501-4a7c-a8be-ae1745fa8a5b'',''Schema'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	insert into semtbl_RelationType VALUES(''fafc1464-815f-4596-9737-bcbc96bd744a'',''needs'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''a778c55c-8308-4033-bd33-30ebd7347485'')=0
	insert into semtbl_RelationType VALUES(''a778c55c-8308-4033-bd33-30ebd7347485'',''secured by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''4f8f29b4-49bb-4d85-a65f-205d2af4f509'')=0
	insert into semtbl_RelationType VALUES(''4f8f29b4-49bb-4d85-a65f-205d2af4f509'',''is checkout by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''be8c7e8f-9b0b-4adc-8f0b-8f8f1ae47f87'')=0
	insert into semtbl_RelationType VALUES(''be8c7e8f-9b0b-4adc-8f0b-8f8f1ae47f87'',''relative'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''18004521-0c12-4b85-80c3-4af08ef9d444'')=0
	insert into semtbl_RelationType VALUES(''18004521-0c12-4b85-80c3-4af08ef9d444'',''creation template'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''03da78f1-645b-4248-b249-6169f78401ac'')=0
	insert into semtbl_RelationType VALUES(''03da78f1-645b-4248-b249-6169f78401ac'',''was developed by'')'
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='132a845f-849f-4f6b-8684-7ab3fd068824') = 0
	insert into semtbl_Type VALUES('132a845f-849f-4f6b-8684-7ab3fd068824','Database-Management','73e32abf-e577-4d31-9a46-bc07e9e15de3')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='f8a525de-72bb-4904-941f-63a40ce34234') = 0
	insert into semtbl_Type VALUES('f8a525de-72bb-4904-941f-63a40ce34234','Database','132a845f-849f-4f6b-8684-7ab3fd068824')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='d9bc8152-e70b-46ce-b09a-95b98f0ba7ac') = 0
	insert into semtbl_Type VALUES('d9bc8152-e70b-46ce-b09a-95b98f0ba7ac','T-SQL','f8a525de-72bb-4904-941f-63a40ce34234')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='9e4bbf04-0394-4041-94c0-9b07da7281db') = 0
	insert into semtbl_Type VALUES('9e4bbf04-0394-4041-94c0-9b07da7281db','DataTypes (Ms-SQL)','d9bc8152-e70b-46ce-b09a-95b98f0ba7ac')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c') = 0
	insert into semtbl_Type VALUES('76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c','Database on Server','f8a525de-72bb-4904-941f-63a40ce34234')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='3dd1a15f-eef3-4943-8ce1-828e201a3c9d') = 0
	insert into semtbl_Type VALUES('3dd1a15f-eef3-4943-8ce1-828e201a3c9d','DB-Procedure','132a845f-849f-4f6b-8684-7ab3fd068824')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='9403650d-2a28-4a0d-9a7f-f1d893960701') = 0
	insert into semtbl_Type VALUES('9403650d-2a28-4a0d-9a7f-f1d893960701','DB-Views','132a845f-849f-4f6b-8684-7ab3fd068824')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='6c5cd901-b9a1-4775-a522-3f776fbe0c8a') = 0
	insert into semtbl_Type VALUES('6c5cd901-b9a1-4775-a522-3f776fbe0c8a','DB-Tables','132a845f-849f-4f6b-8684-7ab3fd068824')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='9053d6ad-8ebb-4f68-bfb0-285d8b38a170') = 0
	insert into semtbl_Type VALUES('9053d6ad-8ebb-4f68-bfb0-285d8b38a170','DB-Columns','6c5cd901-b9a1-4775-a522-3f776fbe0c8a')
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='c0ae3680-18a8-41d9-9238-91505eb2a0ce') = 0
	insert into semtbl_Type VALUES('c0ae3680-18a8-41d9-9238-91505eb2a0ce','Field-Format','c790aa5b-14a4-46b0-bd8c-4317ef5716e2')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='7fd09ae5-cfda-42dd-bbfb-ed5d1376e4b8') = 0
	insert into semtbl_Type VALUES('7fd09ae5-cfda-42dd-bbfb-ed5d1376e4b8','Report-Type','30cbc6e8-9c0f-47d6-920c-97fdc40ea1de')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='748a8642-f689-485f-a4a6-11bbb76f9523') = 0
	insert into semtbl_Type VALUES('748a8642-f689-485f-a4a6-11bbb76f9523','Report-Filter','30cbc6e8-9c0f-47d6-920c-97fdc40ea1de')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='e17005da-097f-46da-aa31-0cbc770f8495') = 0
	insert into semtbl_Type VALUES('e17005da-097f-46da-aa31-0cbc770f8495','Report-Sort','30cbc6e8-9c0f-47d6-920c-97fdc40ea1de')
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='31da8093-3149-4400-957f-a26027fb506e') = 0
	insert into semtbl_Type VALUES('31da8093-3149-4400-957f-a26027fb506e','Security-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='3e1587d8-3e35-46dd-9833-41903904254d') = 0
	insert into semtbl_Type VALUES('3e1587d8-3e35-46dd-9833-41903904254d','Password','31da8093-3149-4400-957f-a26027fb506e')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='c441518d-bfe0-4d55-b538-df5c5555dd83') = 0
	insert into semtbl_Type VALUES('c441518d-bfe0-4d55-b538-df5c5555dd83','user','31da8093-3149-4400-957f-a26027fb506e')
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='8a894710-e08c-42c5-b829-ef4809830d33') = 0
	insert into semtbl_Type VALUES('8a894710-e08c-42c5-b829-ef4809830d33','Path','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='6eb4fdd3-2e25-4886-b288-e1bfc2857efb') = 0
	insert into semtbl_Type VALUES('6eb4fdd3-2e25-4886-b288-e1bfc2857efb','File','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='d7a03a35-8751-42b4-8e05-19fc7a77ee91') = 0
	insert into semtbl_Type VALUES('d7a03a35-8751-42b4-8e05-19fc7a77ee91','Server','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747') = 0
	insert into semtbl_Type VALUES('b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747','Module-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='aa616051-e521-4fac-abdb-cbba6f8c6e73') = 0
	insert into semtbl_Type VALUES('aa616051-e521-4fac-abdb-cbba6f8c6e73','Module','b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='0781e3c6-05ad-4bd1-ab20-90e016493486') = 0
	insert into semtbl_Type VALUES('0781e3c6-05ad-4bd1-ab20-90e016493486','ReportViewer-Module','aa616051-e521-4fac-abdb-cbba6f8c6e73')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='2b30cab7-81b4-4d1b-b3cd-9fb89c9de6eb') = 0
	insert into semtbl_Type VALUES('2b30cab7-81b4-4d1b-b3cd-9fb89c9de6eb','XML-Config','0781e3c6-05ad-4bd1-ab20-90e016493486')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='7d0178e2-9c04-4485-b81c-6d79253c6f64') = 0
	insert into semtbl_Type VALUES('7d0178e2-9c04-4485-b81c-6d79253c6f64','Localization-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='8aa50712-fda9-4222-a350-6378f36e49f8') = 0
	insert into semtbl_Type VALUES('8aa50712-fda9-4222-a350-6378f36e49f8','Formats','7d0178e2-9c04-4485-b81c-6d79253c6f64')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='74aef11b-e102-4cb4-8ca9-3d8ea0fa30a2') = 0
	insert into semtbl_Type VALUES('74aef11b-e102-4cb4-8ca9-3d8ea0fa30a2','Comparison Operators','8aa50712-fda9-4222-a350-6378f36e49f8')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='278365e9-37a2-448b-b96f-b4cbc97f07b1') = 0
	insert into semtbl_Type VALUES('278365e9-37a2-448b-b96f-b4cbc97f07b1','Logical Operators','8aa50712-fda9-4222-a350-6378f36e49f8')
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e13a1b73-8c00-4677-922e-32b36188786f'') = 0
	insert into semtbl_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''ReportsViewer-Module'',''c6c9bcb8-0ac9-4713-9417-eeec1453026c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f40e5133-f876-42c7-ab40-c8c602f8884c'') = 0
	insert into semtbl_Token VALUES(''f40e5133-f876-42c7-ab40-c8c602f8884c'',''ReportsViewer-Module'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d29b56cd-cdad-4b46-af59-0464909864b6'') = 0
	insert into semtbl_Token VALUES(''d29b56cd-cdad-4b46-af59-0464909864b6'',''Type_Field_Type'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9d8f3864-12da-48a0-952c-0741d81d5ec9'') = 0
	insert into semtbl_Token VALUES(''9d8f3864-12da-48a0-952c-0741d81d5ec9'',''Token_Variable_COLCOUNT'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ea85785e-42a2-41f1-b6f7-08cc803a21f7'') = 0
	insert into semtbl_Token VALUES(''ea85785e-42a2-41f1-b6f7-08cc803a21f7'',''RelationType_Row_Config'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''aec9173b-37fb-4b0b-a2ef-108a939ad87b'') = 0
	insert into semtbl_Token VALUES(''aec9173b-37fb-4b0b-a2ef-108a939ad87b'',''Type_DataTypes__Ms_SQL_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c5d5cbf4-77dd-44a7-87a9-18d68ed0cded'') = 0
	insert into semtbl_Token VALUES(''c5d5cbf4-77dd-44a7-87a9-18d68ed0cded'',''Attribute_Value'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''26ff5a5b-f32b-4082-984a-191d7c2d6b38'') = 0
	insert into semtbl_Token VALUES(''26ff5a5b-f32b-4082-984a-191d7c2d6b38'',''Type_Password'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7c73559d-0a69-4ee3-8fd9-1a44b11a1089'') = 0
	insert into semtbl_Token VALUES(''7c73559d-0a69-4ee3-8fd9-1a44b11a1089'',''Type_Report_Type'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'') = 0
	insert into semtbl_Token VALUES(''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'',''Type_Database'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5ea2aade-a23a-46a1-b34f-275676ac8a42'') = 0
	insert into semtbl_Token VALUES(''5ea2aade-a23a-46a1-b34f-275676ac8a42'',''RelationType_belonging_Resources'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f2dfdacd-ae69-4802-ace1-2baffcdea82f'') = 0
	insert into semtbl_Token VALUES(''f2dfdacd-ae69-4802-ace1-2baffcdea82f'',''Token_Variable_DATETIME_TZ'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4fdbe676-6ab7-4209-ad91-306d10e56fbd'') = 0
	insert into semtbl_Token VALUES(''4fdbe676-6ab7-4209-ad91-306d10e56fbd'',''RelationType_Table_Config'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8fd7d742-9a60-4a9d-9d16-32c04632893d'') = 0
	insert into semtbl_Token VALUES(''8fd7d742-9a60-4a9d-9d16-32c04632893d'',''Type_DB_Procedure'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3b16d4dc-a07e-4579-b715-33bf363dd7d6'') = 0
	insert into semtbl_Token VALUES(''3b16d4dc-a07e-4579-b715-33bf363dd7d6'',''Attribute_Standard'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c1718c62-ea40-4023-bf35-33e3ce431734'') = 0
	insert into semtbl_Token VALUES(''c1718c62-ea40-4023-bf35-33e3ce431734'',''Type_Field_Format'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6b680dc6-1c99-4ee3-945e-364d50b2d5df'') = 0
	insert into semtbl_Token VALUES(''6b680dc6-1c99-4ee3-945e-364d50b2d5df'',''RelationType_Cell_Config'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2a4992d1-8dd1-45e6-a500-37052cb97586'') = 0
	insert into semtbl_Token VALUES(''2a4992d1-8dd1-45e6-a500-37052cb97586'',''Attribute_visible'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''747952da-2e66-49c1-8462-3a20addbc0ef'') = 0
	insert into semtbl_Token VALUES(''747952da-2e66-49c1-8462-3a20addbc0ef'',''RelationType_is'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''56803624-0182-4926-9da5-3bc4fe5e7b31'') = 0
	insert into semtbl_Token VALUES(''56803624-0182-4926-9da5-3bc4fe5e7b31'',''Type_Port'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'') = 0
	insert into semtbl_Token VALUES(''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'',''Attribute_XML_Text'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0f54c71f-1aea-4bf3-9958-44a68afd84ec'') = 0
	insert into semtbl_Token VALUES(''0f54c71f-1aea-4bf3-9958-44a68afd84ec'',''Token_Variable_id'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''091343df-f818-4db7-8dfa-45358e2133b1'') = 0
	insert into semtbl_Token VALUES(''091343df-f818-4db7-8dfa-45358e2133b1'',''Type_Report_Filter'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3c2fb8fa-b8bf-4930-bc5c-4817f8b1ad40'') = 0
	insert into semtbl_Token VALUES(''3c2fb8fa-b8bf-4930-bc5c-4817f8b1ad40'',''Type_DB_Views'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''474d70c7-a115-4a93-b285-4a2672c2d041'') = 0
	insert into semtbl_Token VALUES(''474d70c7-a115-4a93-b285-4a2672c2d041'',''Token_Variable_CELL_VALUE'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1f99c1f1-770a-4faf-98c8-50facf2a10f7'') = 0
	insert into semtbl_Token VALUES(''1f99c1f1-770a-4faf-98c8-50facf2a10f7'',''Token_Variable_ROWCOUNT'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''49716d39-9cc8-45c3-8b81-54ad7429881f'') = 0
	insert into semtbl_Token VALUES(''49716d39-9cc8-45c3-8b81-54ad7429881f'',''Token_Field_Type_Text'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''765108ea-65a4-41f5-a95a-54bf4fd3effc'') = 0
	insert into semtbl_Token VALUES(''765108ea-65a4-41f5-a95a-54bf4fd3effc'',''Token_Field_Type_Zahl'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e1215482-8954-493d-888d-5800e2e5e29d'') = 0
	insert into semtbl_Token VALUES(''e1215482-8954-493d-888d-5800e2e5e29d'',''RelationType_connected_by'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7c76114a-6a68-42aa-b9ce-5fd0d8a02eff'') = 0
	insert into semtbl_Token VALUES(''7c76114a-6a68-42aa-b9ce-5fd0d8a02eff'',''Attribute_invisible'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''33b131b4-810d-449c-a3f7-60d16cba5853'') = 0
	insert into semtbl_Token VALUES(''33b131b4-810d-449c-a3f7-60d16cba5853'',''Type_Server_Port'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''224f7ece-8d8b-4754-8ef2-6771809a7ea7'') = 0
	insert into semtbl_Token VALUES(''224f7ece-8d8b-4754-8ef2-6771809a7ea7'',''Token_Variable_ROW_LIST'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6c966e3c-c737-4af1-9970-68c8323679bc'') = 0
	insert into semtbl_Token VALUES(''6c966e3c-c737-4af1-9970-68c8323679bc'',''RelationType_contains'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'') = 0
	insert into semtbl_Token VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''attribute_dbPostfix'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''dc650c9f-6914-45ab-b7af-6ebe8a928bb5'') = 0
	insert into semtbl_Token VALUES(''dc650c9f-6914-45ab-b7af-6ebe8a928bb5'',''Token_Variable_ROW_NAME'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6e494944-f602-4dcb-906f-70e5efe8f1dd'') = 0
	insert into semtbl_Token VALUES(''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''RelationType_is_of_Type'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''600419f9-88da-4649-b3bf-78a4edecc9a6'') = 0
	insert into semtbl_Token VALUES(''600419f9-88da-4649-b3bf-78a4edecc9a6'',''Attribute_is_Null'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e85c65c5-2058-45f9-a66a-7d9a96987075'') = 0
	insert into semtbl_Token VALUES(''e85c65c5-2058-45f9-a66a-7d9a96987075'',''RelationType_Type_Field'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f952e7f1-438b-4ae9-b588-8142aaf280d3'') = 0
	insert into semtbl_Token VALUES(''f952e7f1-438b-4ae9-b588-8142aaf280d3'',''Attribute_ASC'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''31ff7c35-21e8-45b2-9b86-81de3b26a71b'') = 0
	insert into semtbl_Token VALUES(''31ff7c35-21e8-45b2-9b86-81de3b26a71b'',''Type_Indexes__Elastic_Search_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''aa297c67-08be-46bd-a98c-856aea6b8046'') = 0
	insert into semtbl_Token VALUES(''aa297c67-08be-46bd-a98c-856aea6b8046'',''Attribute_Row_Header'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c7619aac-483f-4cec-be37-8c6495fbc2b7'') = 0
	insert into semtbl_Token VALUES(''c7619aac-483f-4cec-be37-8c6495fbc2b7'',''Type_Report_Field'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cf0f52ac-1e00-45f4-ae02-8d6d3a920b59'') = 0
	insert into semtbl_Token VALUES(''cf0f52ac-1e00-45f4-ae02-8d6d3a920b59'',''Token_Report_Type_Token_Report'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'') = 0
	insert into semtbl_Token VALUES(''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'',''RelationType_belonging_Source'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d3101831-962d-4069-a96d-94fcfc234651'') = 0
	insert into semtbl_Token VALUES(''d3101831-962d-4069-a96d-94fcfc234651'',''Type_DB_Columns'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''407516df-78ae-4f0d-ae36-956c0621588b'') = 0
	insert into semtbl_Token VALUES(''407516df-78ae-4f0d-ae36-956c0621588b'',''Token_Variable_CELL_NAME'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''be75dfa9-a31e-47af-8b91-9b42153b6d39'') = 0
	insert into semtbl_Token VALUES(''be75dfa9-a31e-47af-8b91-9b42153b6d39'',''Token_Variable_REPORT'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d5556f74-b21f-4efe-a439-a28b53a4bf5f'') = 0
	insert into semtbl_Token VALUES(''d5556f74-b21f-4efe-a439-a28b53a4bf5f'',''Type_Report_Sort'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3186cc5e-023b-4edc-b6c7-a89919320839'') = 0
	insert into semtbl_Token VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''RelationType_belongsTo'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5a778c64-4bcc-4faf-bdba-aaa01092f200'') = 0
	insert into semtbl_Token VALUES(''5a778c64-4bcc-4faf-bdba-aaa01092f200'',''RelationType_leads'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f10253cf-f5c4-4777-8f4b-abc61217e28b'') = 0
	insert into semtbl_Token VALUES(''f10253cf-f5c4-4777-8f4b-abc61217e28b'',''Type_Url'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cfba621b-5774-445b-8749-af12bb8bb472'') = 0
	insert into semtbl_Token VALUES(''cfba621b-5774-445b-8749-af12bb8bb472'',''Type_XML'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8a6a3874-7e7b-4c41-b43a-b0349e39113b'') = 0
	insert into semtbl_Token VALUES(''8a6a3874-7e7b-4c41-b43a-b0349e39113b'',''Type_Path'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f1ba23ed-ab41-4d34-8e09-b4e485671478'') = 0
	insert into semtbl_Token VALUES(''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''Type_File'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''178d63d3-84de-414f-8abb-b9ed14965b74'') = 0
	insert into semtbl_Token VALUES(''178d63d3-84de-414f-8abb-b9ed14965b74'',''Type_Reports'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''47340256-8975-43ca-b89b-bb87cfeb662a'') = 0
	insert into semtbl_Token VALUES(''47340256-8975-43ca-b89b-bb87cfeb662a'',''Type_XML_Config'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'') = 0
	insert into semtbl_Token VALUES(''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'',''Type_Database_on_Server'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ebe3987c-7845-47ab-a1f6-c6d8e3a12658'') = 0
	insert into semtbl_Token VALUES(''ebe3987c-7845-47ab-a1f6-c6d8e3a12658'',''Type_Variable'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ea69a5ce-6242-42b7-80a2-c91ae1b59524'') = 0
	insert into semtbl_Token VALUES(''ea69a5ce-6242-42b7-80a2-c91ae1b59524'',''Token_Field_Type_DateTime'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8618f96e-8494-432a-99da-cc91e6c117d5'') = 0
	insert into semtbl_Token VALUES(''8618f96e-8494-432a-99da-cc91e6c117d5'',''RelationType_located_in'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''594ef5cd-f083-4a78-8a5d-d0aabee43967'') = 0
	insert into semtbl_Token VALUES(''594ef5cd-f083-4a78-8a5d-d0aabee43967'',''type_User'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''935bd858-2d0b-4b96-a581-d51fbb6e5e37'') = 0
	insert into semtbl_Token VALUES(''935bd858-2d0b-4b96-a581-d51fbb6e5e37'',''Token_Variable_REPORT_20'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'') = 0
	insert into semtbl_Token VALUES(''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''Type_Server'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''99d858e8-2a38-458e-834c-daec118523e2'') = 0
	insert into semtbl_Token VALUES(''99d858e8-2a38-458e-834c-daec118523e2'',''Token_Variable_CELL_LIST'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3e0274d6-ea91-488f-b8cb-e1212d74b7c9'') = 0
	insert into semtbl_Token VALUES(''3e0274d6-ea91-488f-b8cb-e1212d74b7c9'',''RelationType_Formatted_by'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2743e551-64bb-43d7-8c4f-e65f4ab849b9'') = 0
	insert into semtbl_Token VALUES(''2743e551-64bb-43d7-8c4f-e65f4ab849b9'',''Token_Variable_AUTHOR'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3489349e-4805-40ad-ac54-ed6348092fbb'') = 0
	insert into semtbl_Token VALUES(''3489349e-4805-40ad-ac54-ed6348092fbb'',''Type_Comparison_Operators'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a6faac99-d3db-4df8-8e45-f177b5bf915e'') = 0
	insert into semtbl_Token VALUES(''a6faac99-d3db-4df8-8e45-f177b5bf915e'',''Token_Field_Type_GUID'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''444bb9bc-5d80-4911-a6fb-f1c67fe34380'') = 0
	insert into semtbl_Token VALUES(''444bb9bc-5d80-4911-a6fb-f1c67fe34380'',''Token_Report_Type_ElasticView'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9af3ab0d-10bb-428a-8be6-f37e7f0da912'') = 0
	insert into semtbl_Token VALUES(''9af3ab0d-10bb-428a-8be6-f37e7f0da912'',''Type_Logical_Operators'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ba16c8e8-a814-4f36-b33f-f5dd8a2f4e16'') = 0
	insert into semtbl_Token VALUES(''ba16c8e8-a814-4f36-b33f-f5dd8a2f4e16'',''Token_Report_Type_View'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f6d51ec7-8ae7-47b4-b496-6b3db94779bb'') = 0
	insert into semtbl_Token VALUES(''f6d51ec7-8ae7-47b4-b496-6b3db94779bb'',''COLCOUNT'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8c9fa101-8e2b-4aa6-b84f-6af075bdde3b'') = 0
	insert into semtbl_Token VALUES(''8c9fa101-8e2b-4aa6-b84f-6af075bdde3b'',''DATETIME_TZ'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''23b585f2-79e2-4abd-a505-f2d6a9369eeb'') = 0
	insert into semtbl_Token VALUES(''23b585f2-79e2-4abd-a505-f2d6a9369eeb'',''id'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1bb34344-d41c-4610-927a-74200fc9f6c4'') = 0
	insert into semtbl_Token VALUES(''1bb34344-d41c-4610-927a-74200fc9f6c4'',''CELL_VALUE'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c7bc92dc-4f2e-45c1-87d7-ce4bb40719be'') = 0
	insert into semtbl_Token VALUES(''c7bc92dc-4f2e-45c1-87d7-ce4bb40719be'',''ROWCOUNT'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d5474c74-f70e-4916-98f6-4e3d3831c1f9'') = 0
	insert into semtbl_Token VALUES(''d5474c74-f70e-4916-98f6-4e3d3831c1f9'',''Text'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'') = 0
	insert into semtbl_Token VALUES(''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'',''Zahl'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3aa1632a-771e-4cc6-95cf-2dd583a812ca'') = 0
	insert into semtbl_Token VALUES(''3aa1632a-771e-4cc6-95cf-2dd583a812ca'',''ROW_LIST'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2d9d8f4e-918e-4339-9243-a602afd5280b'') = 0
	insert into semtbl_Token VALUES(''2d9d8f4e-918e-4339-9243-a602afd5280b'',''ROW_NAME'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c7781ee8-d681-4d76-954a-58982327b57d'') = 0
	insert into semtbl_Token VALUES(''c7781ee8-d681-4d76-954a-58982327b57d'',''Token-Report'',''7fd09ae5-cfda-42dd-bbfb-ed5d1376e4b8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6bddeb7f-f782-4962-888f-af7381e8bad6'') = 0
	insert into semtbl_Token VALUES(''6bddeb7f-f782-4962-888f-af7381e8bad6'',''CELL_NAME'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''461bfc6f-4ef5-4185-82f9-d449b0b0aecc'') = 0
	insert into semtbl_Token VALUES(''461bfc6f-4ef5-4185-82f9-d449b0b0aecc'',''REPORT'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''38090631-b096-4c3f-be03-cf79d6a537ae'') = 0
	insert into semtbl_Token VALUES(''38090631-b096-4c3f-be03-cf79d6a537ae'',''DateTime'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1ec005b7-20f3-4016-a404-c9d29b44470a'') = 0
	insert into semtbl_Token VALUES(''1ec005b7-20f3-4016-a404-c9d29b44470a'',''REPORT_20'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c6438d35-df0d-4c63-9a54-ab853bdd475a'') = 0
	insert into semtbl_Token VALUES(''c6438d35-df0d-4c63-9a54-ab853bdd475a'',''CELL_LIST'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0d2b3ce0-afd5-465e-affc-12abfac7762a'') = 0
	insert into semtbl_Token VALUES(''0d2b3ce0-afd5-465e-affc-12abfac7762a'',''AUTHOR'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c17230e2-d57a-4a11-bea3-14db50a656a6'') = 0
	insert into semtbl_Token VALUES(''c17230e2-d57a-4a11-bea3-14db50a656a6'',''GUID'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bc89df19-ad5e-4f2d-b821-af073f60c0a7'') = 0
	insert into semtbl_Token VALUES(''bc89df19-ad5e-4f2d-b821-af073f60c0a7'',''ElasticView'',''7fd09ae5-cfda-42dd-bbfb-ed5d1376e4b8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c4a54bf0-a674-4b91-806b-aa886d4bbc0d'') = 0
	insert into semtbl_Token VALUES(''c4a54bf0-a674-4b91-806b-aa886d4bbc0d'',''View'',''7fd09ae5-cfda-42dd-bbfb-ed5d1376e4b8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''d29b56cd-cdad-4b46-af59-0464909864b6'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''d29b56cd-cdad-4b46-af59-0464909864b6'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''9d8f3864-12da-48a0-952c-0741d81d5ec9'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''9d8f3864-12da-48a0-952c-0741d81d5ec9'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''ea85785e-42a2-41f1-b6f7-08cc803a21f7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''ea85785e-42a2-41f1-b6f7-08cc803a21f7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''aec9173b-37fb-4b0b-a2ef-108a939ad87b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''aec9173b-37fb-4b0b-a2ef-108a939ad87b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''c5d5cbf4-77dd-44a7-87a9-18d68ed0cded'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''c5d5cbf4-77dd-44a7-87a9-18d68ed0cded'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''26ff5a5b-f32b-4082-984a-191d7c2d6b38'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''26ff5a5b-f32b-4082-984a-191d7c2d6b38'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''7c73559d-0a69-4ee3-8fd9-1a44b11a1089'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''7c73559d-0a69-4ee3-8fd9-1a44b11a1089'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''5ea2aade-a23a-46a1-b34f-275676ac8a42'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''5ea2aade-a23a-46a1-b34f-275676ac8a42'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''f2dfdacd-ae69-4802-ace1-2baffcdea82f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''f2dfdacd-ae69-4802-ace1-2baffcdea82f'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''4fdbe676-6ab7-4209-ad91-306d10e56fbd'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''4fdbe676-6ab7-4209-ad91-306d10e56fbd'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''8fd7d742-9a60-4a9d-9d16-32c04632893d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''8fd7d742-9a60-4a9d-9d16-32c04632893d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''3b16d4dc-a07e-4579-b715-33bf363dd7d6'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''3b16d4dc-a07e-4579-b715-33bf363dd7d6'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''c1718c62-ea40-4023-bf35-33e3ce431734'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''c1718c62-ea40-4023-bf35-33e3ce431734'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''6b680dc6-1c99-4ee3-945e-364d50b2d5df'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''6b680dc6-1c99-4ee3-945e-364d50b2d5df'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''2a4992d1-8dd1-45e6-a500-37052cb97586'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''2a4992d1-8dd1-45e6-a500-37052cb97586'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''747952da-2e66-49c1-8462-3a20addbc0ef'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''747952da-2e66-49c1-8462-3a20addbc0ef'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''56803624-0182-4926-9da5-3bc4fe5e7b31'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''56803624-0182-4926-9da5-3bc4fe5e7b31'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''0f54c71f-1aea-4bf3-9958-44a68afd84ec'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''0f54c71f-1aea-4bf3-9958-44a68afd84ec'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''091343df-f818-4db7-8dfa-45358e2133b1'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''091343df-f818-4db7-8dfa-45358e2133b1'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''3c2fb8fa-b8bf-4930-bc5c-4817f8b1ad40'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''3c2fb8fa-b8bf-4930-bc5c-4817f8b1ad40'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''474d70c7-a115-4a93-b285-4a2672c2d041'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''474d70c7-a115-4a93-b285-4a2672c2d041'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''1f99c1f1-770a-4faf-98c8-50facf2a10f7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''1f99c1f1-770a-4faf-98c8-50facf2a10f7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''49716d39-9cc8-45c3-8b81-54ad7429881f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''49716d39-9cc8-45c3-8b81-54ad7429881f'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''765108ea-65a4-41f5-a95a-54bf4fd3effc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''765108ea-65a4-41f5-a95a-54bf4fd3effc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''e1215482-8954-493d-888d-5800e2e5e29d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''e1215482-8954-493d-888d-5800e2e5e29d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''7c76114a-6a68-42aa-b9ce-5fd0d8a02eff'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''7c76114a-6a68-42aa-b9ce-5fd0d8a02eff'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''33b131b4-810d-449c-a3f7-60d16cba5853'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''33b131b4-810d-449c-a3f7-60d16cba5853'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''224f7ece-8d8b-4754-8ef2-6771809a7ea7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''224f7ece-8d8b-4754-8ef2-6771809a7ea7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''6c966e3c-c737-4af1-9970-68c8323679bc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''6c966e3c-c737-4af1-9970-68c8323679bc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''dc650c9f-6914-45ab-b7af-6ebe8a928bb5'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''dc650c9f-6914-45ab-b7af-6ebe8a928bb5'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''6e494944-f602-4dcb-906f-70e5efe8f1dd'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''600419f9-88da-4649-b3bf-78a4edecc9a6'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''600419f9-88da-4649-b3bf-78a4edecc9a6'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''e85c65c5-2058-45f9-a66a-7d9a96987075'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''e85c65c5-2058-45f9-a66a-7d9a96987075'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''f952e7f1-438b-4ae9-b588-8142aaf280d3'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''f952e7f1-438b-4ae9-b588-8142aaf280d3'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''31ff7c35-21e8-45b2-9b86-81de3b26a71b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''31ff7c35-21e8-45b2-9b86-81de3b26a71b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''aa297c67-08be-46bd-a98c-856aea6b8046'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''aa297c67-08be-46bd-a98c-856aea6b8046'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''c7619aac-483f-4cec-be37-8c6495fbc2b7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''c7619aac-483f-4cec-be37-8c6495fbc2b7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''cf0f52ac-1e00-45f4-ae02-8d6d3a920b59'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''cf0f52ac-1e00-45f4-ae02-8d6d3a920b59'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''d3101831-962d-4069-a96d-94fcfc234651'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''d3101831-962d-4069-a96d-94fcfc234651'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''407516df-78ae-4f0d-ae36-956c0621588b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''407516df-78ae-4f0d-ae36-956c0621588b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''be75dfa9-a31e-47af-8b91-9b42153b6d39'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''be75dfa9-a31e-47af-8b91-9b42153b6d39'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''d5556f74-b21f-4efe-a439-a28b53a4bf5f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''d5556f74-b21f-4efe-a439-a28b53a4bf5f'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''3186cc5e-023b-4edc-b6c7-a89919320839'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''5a778c64-4bcc-4faf-bdba-aaa01092f200'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''5a778c64-4bcc-4faf-bdba-aaa01092f200'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''f10253cf-f5c4-4777-8f4b-abc61217e28b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''f10253cf-f5c4-4777-8f4b-abc61217e28b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''cfba621b-5774-445b-8749-af12bb8bb472'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''cfba621b-5774-445b-8749-af12bb8bb472'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''8a6a3874-7e7b-4c41-b43a-b0349e39113b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''8a6a3874-7e7b-4c41-b43a-b0349e39113b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''f1ba23ed-ab41-4d34-8e09-b4e485671478'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''178d63d3-84de-414f-8abb-b9ed14965b74'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''178d63d3-84de-414f-8abb-b9ed14965b74'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''47340256-8975-43ca-b89b-bb87cfeb662a'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''47340256-8975-43ca-b89b-bb87cfeb662a'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''ebe3987c-7845-47ab-a1f6-c6d8e3a12658'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''ebe3987c-7845-47ab-a1f6-c6d8e3a12658'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''ea69a5ce-6242-42b7-80a2-c91ae1b59524'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''ea69a5ce-6242-42b7-80a2-c91ae1b59524'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''8618f96e-8494-432a-99da-cc91e6c117d5'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''8618f96e-8494-432a-99da-cc91e6c117d5'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''594ef5cd-f083-4a78-8a5d-d0aabee43967'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''594ef5cd-f083-4a78-8a5d-d0aabee43967'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''935bd858-2d0b-4b96-a581-d51fbb6e5e37'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''935bd858-2d0b-4b96-a581-d51fbb6e5e37'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''99d858e8-2a38-458e-834c-daec118523e2'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''99d858e8-2a38-458e-834c-daec118523e2'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''3e0274d6-ea91-488f-b8cb-e1212d74b7c9'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''3e0274d6-ea91-488f-b8cb-e1212d74b7c9'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''2743e551-64bb-43d7-8c4f-e65f4ab849b9'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''2743e551-64bb-43d7-8c4f-e65f4ab849b9'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''3489349e-4805-40ad-ac54-ed6348092fbb'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''3489349e-4805-40ad-ac54-ed6348092fbb'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''a6faac99-d3db-4df8-8e45-f177b5bf915e'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''a6faac99-d3db-4df8-8e45-f177b5bf915e'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''444bb9bc-5d80-4911-a6fb-f1c67fe34380'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''444bb9bc-5d80-4911-a6fb-f1c67fe34380'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''9af3ab0d-10bb-428a-8be6-f37e7f0da912'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''9af3ab0d-10bb-428a-8be6-f37e7f0da912'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''ba16c8e8-a814-4f36-b33f-f5dd8a2f4e16'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''ba16c8e8-a814-4f36-b33f-f5dd8a2f4e16'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''f40e5133-f876-42c7-ab40-c8c602f8884c'' AND GUID_Token_Right=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Token_Token VALUES(''f40e5133-f876-42c7-ab40-c8c602f8884c'',''e13a1b73-8c00-4677-922e-32b36188786f'',''fafc1464-815f-4596-9737-bcbc96bd744a'',1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''f8a525de-72bb-4904-941f-63a40ce34234'' AND GUID_Attribute=''d777cd8b-b212-4f83-b67e-da8586f97eca'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''f8a525de-72bb-4904-941f-63a40ce34234'',''d777cd8b-b212-4f83-b67e-da8586f97eca'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''3dd1a15f-eef3-4943-8ce1-828e201a3c9d'' AND GUID_Attribute=''d5d5eb28-e26e-4845-846b-48701fb5ca26'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''3dd1a15f-eef3-4943-8ce1-828e201a3c9d'',''d5d5eb28-e26e-4845-846b-48701fb5ca26'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''748a8642-f689-485f-a4a6-11bbb76f9523'' AND GUID_Attribute=''0705d441-2a3e-4ccf-bc35-140ae3d406bd'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''748a8642-f689-485f-a4a6-11bbb76f9523'',''0705d441-2a3e-4ccf-bc35-140ae3d406bd'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''748a8642-f689-485f-a4a6-11bbb76f9523'' AND GUID_Attribute=''3940fb8a-7ec9-4bd5-9719-aed313da116d'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''748a8642-f689-485f-a4a6-11bbb76f9523'',''3940fb8a-7ec9-4bd5-9719-aed313da116d'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''748a8642-f689-485f-a4a6-11bbb76f9523'' AND GUID_Attribute=''3316543a-c922-4bb8-afe8-b6f58db0adef'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''748a8642-f689-485f-a4a6-11bbb76f9523'',''3316543a-c922-4bb8-afe8-b6f58db0adef'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''9403650d-2a28-4a0d-9a7f-f1d893960701'' AND GUID_Attribute=''d5d5eb28-e26e-4845-846b-48701fb5ca26'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''9403650d-2a28-4a0d-9a7f-f1d893960701'',''d5d5eb28-e26e-4845-846b-48701fb5ca26'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6c5cd901-b9a1-4775-a522-3f776fbe0c8a'' AND GUID_Attribute=''d5d5eb28-e26e-4845-846b-48701fb5ca26'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6c5cd901-b9a1-4775-a522-3f776fbe0c8a'',''d5d5eb28-e26e-4845-846b-48701fb5ca26'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''e17005da-097f-46da-aa31-0cbc770f8495'' AND GUID_Attribute=''1d7d076b-bf2d-4274-88ee-a9a1f570e690'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''e17005da-097f-46da-aa31-0cbc770f8495'',''1d7d076b-bf2d-4274-88ee-a9a1f570e690'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''e17005da-097f-46da-aa31-0cbc770f8495'' AND GUID_Attribute=''3316543a-c922-4bb8-afe8-b6f58db0adef'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''e17005da-097f-46da-aa31-0cbc770f8495'',''3316543a-c922-4bb8-afe8-b6f58db0adef'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''094d728d-6efc-463c-85c7-2dcfed903c78'' AND GUID_Attribute=''4fcf775b-2e0b-4712-be8d-0e8e0c643040'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''094d728d-6efc-463c-85c7-2dcfed903c78'',''4fcf775b-2e0b-4712-be8d-0e8e0c643040'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''094d728d-6efc-463c-85c7-2dcfed903c78'' AND GUID_Attribute=''166531b2-a224-4ce1-bd01-6e38fec36bb3'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''094d728d-6efc-463c-85c7-2dcfed903c78'',''166531b2-a224-4ce1-bd01-6e38fec36bb3'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_Attribute=''68ac4472-ee22-4229-96ec-9753a016900a'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''327e9773-fca6-458c-a44d-338a556e0ad9'',''68ac4472-ee22-4229-96ec-9753a016900a'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Attribute=''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Attribute=''b67c3f3c-da03-4693-9afc-d2014997e328'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''b67c3f3c-da03-4693-9afc-d2014997e328'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''2b30cab7-81b4-4d1b-b3cd-9fb89c9de6eb'' AND GUID_Attribute=''6c758923-0363-4259-bd18-8a44a9d7fad8'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''2b30cab7-81b4-4d1b-b3cd-9fb89c9de6eb'',''6c758923-0363-4259-bd18-8a44a9d7fad8'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''4158aad2-656a-4fb9-97bf-524c6f5fecaa'' AND GUID_Attribute=''3940fb8a-7ec9-4bd5-9719-aed313da116d'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''4158aad2-656a-4fb9-97bf-524c6f5fecaa'',''3940fb8a-7ec9-4bd5-9719-aed313da116d'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''c441518d-bfe0-4d55-b538-df5c5555dd83'' AND GUID_Attribute=''301374ab-7877-4dd9-9e5b-36db1e1125fa'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''c441518d-bfe0-4d55-b538-df5c5555dd83'',''301374ab-7877-4dd9-9e5b-36db1e1125fa'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_Attribute=''a1b49452-19dc-4eae-a000-ef3802de35a9'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''a1b49452-19dc-4eae-a000-ef3802de35a9'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_Attribute=''30b76a62-1b22-4f17-b9a5-ff665e08f35a'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''30b76a62-1b22-4f17-b9a5-ff665e08f35a'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''e17005da-097f-46da-aa31-0cbc770f8495'' AND GUID_Type_Right=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''e17005da-097f-46da-aa31-0cbc770f8495'',''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''e9711603-47db-44d8-a476-fe88290639a4'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''e17005da-097f-46da-aa31-0cbc770f8495'' AND GUID_Type_Right=''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''e17005da-097f-46da-aa31-0cbc770f8495'',''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''748a8642-f689-485f-a4a6-11bbb76f9523'' AND GUID_Type_Right=''748a8642-f689-485f-a4a6-11bbb76f9523'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''748a8642-f689-485f-a4a6-11bbb76f9523'',''748a8642-f689-485f-a4a6-11bbb76f9523'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''748a8642-f689-485f-a4a6-11bbb76f9523'' AND GUID_Type_Right=''74aef11b-e102-4cb4-8ca9-3d8ea0fa30a2'' AND GUID_RelationType=''801886c0-0938-47e2-945e-f3d34f7c68fe'')=0
	INSERT INTO semtbl_Type_Type VALUES(''748a8642-f689-485f-a4a6-11bbb76f9523'',''74aef11b-e102-4cb4-8ca9-3d8ea0fa30a2'',''801886c0-0938-47e2-945e-f3d34f7c68fe'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''748a8642-f689-485f-a4a6-11bbb76f9523'' AND GUID_Type_Right=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''748a8642-f689-485f-a4a6-11bbb76f9523'',''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''e9711603-47db-44d8-a476-fe88290639a4'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''748a8642-f689-485f-a4a6-11bbb76f9523'' AND GUID_Type_Right=''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''748a8642-f689-485f-a4a6-11bbb76f9523'',''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''748a8642-f689-485f-a4a6-11bbb76f9523'' AND GUID_Type_Right=''278365e9-37a2-448b-b96f-b4cbc97f07b1'' AND GUID_RelationType=''801886c0-0938-47e2-945e-f3d34f7c68fe'')=0
	INSERT INTO semtbl_Type_Type VALUES(''748a8642-f689-485f-a4a6-11bbb76f9523'',''278365e9-37a2-448b-b96f-b4cbc97f07b1'',''801886c0-0938-47e2-945e-f3d34f7c68fe'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9053d6ad-8ebb-4f68-bfb0-285d8b38a170'' AND GUID_Type_Right=''6c5cd901-b9a1-4775-a522-3f776fbe0c8a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9053d6ad-8ebb-4f68-bfb0-285d8b38a170'',''6c5cd901-b9a1-4775-a522-3f776fbe0c8a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9053d6ad-8ebb-4f68-bfb0-285d8b38a170'' AND GUID_Type_Right=''9403650d-2a28-4a0d-9a7f-f1d893960701'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9053d6ad-8ebb-4f68-bfb0-285d8b38a170'',''9403650d-2a28-4a0d-9a7f-f1d893960701'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,1,-1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''3e1587d8-3e35-46dd-9833-41903904254d'' AND GUID_Type_Right=''c441518d-bfe0-4d55-b538-df5c5555dd83'' AND GUID_RelationType=''0ecc4f8c-c0de-49ad-834f-5194d568a16e'')=0
	INSERT INTO semtbl_Type_Type VALUES(''3e1587d8-3e35-46dd-9833-41903904254d'',''c441518d-bfe0-4d55-b538-df5c5555dd83'',''0ecc4f8c-c0de-49ad-834f-5194d568a16e'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_Type_Right=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_RelationType=''0fa056ea-474f-424f-ab68-0a10b57d3a95'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''0fa056ea-474f-424f-ab68-0a10b57d3a95'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_Type_Right=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_RelationType=''6edbb77c-18d1-4736-92bf-7bd5e5dde8b8'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''6edbb77c-18d1-4736-92bf-7bd5e5dde8b8'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_Type_Right=''c0ae3680-18a8-41d9-9238-91505eb2a0ce'' AND GUID_RelationType=''ace00f97-67b7-4177-bfe0-6ac7b3bfd8a5'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''c0ae3680-18a8-41d9-9238-91505eb2a0ce'',''ace00f97-67b7-4177-bfe0-6ac7b3bfd8a5'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_Type_Right=''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_Type_Right=''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'' AND GUID_Type_Right=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_RelationType=''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'')=0
	INSERT INTO semtbl_Type_Type VALUES(''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'' AND GUID_Type_Right=''6c5cd901-b9a1-4775-a522-3f776fbe0c8a'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'',''6c5cd901-b9a1-4775-a522-3f776fbe0c8a'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'' AND GUID_Type_Right=''f8a525de-72bb-4904-941f-63a40ce34234'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'',''f8a525de-72bb-4904-941f-63a40ce34234'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'' AND GUID_Type_Right=''3dd1a15f-eef3-4943-8ce1-828e201a3c9d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'',''3dd1a15f-eef3-4943-8ce1-828e201a3c9d'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'' AND GUID_Type_Right=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''d48c0e60-17bd-4f00-9323-644190285bd4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'',''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''d48c0e60-17bd-4f00-9323-644190285bd4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'' AND GUID_Type_Right=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''536c136f-1f95-4e11-ab89-7c5e0d74445b'')=0
	INSERT INTO semtbl_Type_Type VALUES(''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'',''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''536c136f-1f95-4e11-ab89-7c5e0d74445b'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'' AND GUID_Type_Right=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''f0b70d32-d248-4020-992a-a8f7a920200c'')=0
	INSERT INTO semtbl_Type_Type VALUES(''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'',''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''f0b70d32-d248-4020-992a-a8f7a920200c'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'' AND GUID_Type_Right=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''ed2f5120-2501-4a7c-a8be-ae1745fa8a5b'')=0
	INSERT INTO semtbl_Type_Type VALUES(''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'',''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''ed2f5120-2501-4a7c-a8be-ae1745fa8a5b'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'' AND GUID_Type_Right=''9403650d-2a28-4a0d-9a7f-f1d893960701'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'',''9403650d-2a28-4a0d-9a7f-f1d893960701'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''3dd1a15f-eef3-4943-8ce1-828e201a3c9d'' AND GUID_Type_Right=''6c5cd901-b9a1-4775-a522-3f776fbe0c8a'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''3dd1a15f-eef3-4943-8ce1-828e201a3c9d'',''6c5cd901-b9a1-4775-a522-3f776fbe0c8a'',''fafc1464-815f-4596-9737-bcbc96bd744a'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'' AND GUID_Type_Right=''3dd1a15f-eef3-4943-8ce1-828e201a3c9d'' AND GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	INSERT INTO semtbl_Type_Type VALUES(''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'',''3dd1a15f-eef3-4943-8ce1-828e201a3c9d'',''3e104b75-e01c-48a0-b041-12908fd446a0'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'' AND GUID_Type_Right=''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'',''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'' AND GUID_Type_Right=''7fd09ae5-cfda-42dd-bbfb-ed5d1376e4b8'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Type_Type VALUES(''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'',''7fd09ae5-cfda-42dd-bbfb-ed5d1376e4b8'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'' AND GUID_Type_Right=''9403650d-2a28-4a0d-9a7f-f1d893960701'' AND GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	INSERT INTO semtbl_Type_Type VALUES(''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'',''9403650d-2a28-4a0d-9a7f-f1d893960701'',''3e104b75-e01c-48a0-b041-12908fd446a0'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''2b30cab7-81b4-4d1b-b3cd-9fb89c9de6eb'' AND GUID_Type_Right=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_RelationType=''66857dba-efd6-48c9-ad54-04103f56ab8a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''2b30cab7-81b4-4d1b-b3cd-9fb89c9de6eb'',''327e9773-fca6-458c-a44d-338a556e0ad9'',''66857dba-efd6-48c9-ad54-04103f56ab8a'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''2b30cab7-81b4-4d1b-b3cd-9fb89c9de6eb'' AND GUID_Type_Right=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_RelationType=''2abef94e-34de-45ab-80c1-5d0ad5a006d0'')=0
	INSERT INTO semtbl_Type_Type VALUES(''2b30cab7-81b4-4d1b-b3cd-9fb89c9de6eb'',''327e9773-fca6-458c-a44d-338a556e0ad9'',''2abef94e-34de-45ab-80c1-5d0ad5a006d0'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''2b30cab7-81b4-4d1b-b3cd-9fb89c9de6eb'' AND GUID_Type_Right=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_RelationType=''f7930edf-0e80-47f8-b1a5-84c4b15366a3'')=0
	INSERT INTO semtbl_Type_Type VALUES(''2b30cab7-81b4-4d1b-b3cd-9fb89c9de6eb'',''327e9773-fca6-458c-a44d-338a556e0ad9'',''f7930edf-0e80-47f8-b1a5-84c4b15366a3'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''2b30cab7-81b4-4d1b-b3cd-9fb89c9de6eb'' AND GUID_Type_Right=''c441518d-bfe0-4d55-b538-df5c5555dd83'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''2b30cab7-81b4-4d1b-b3cd-9fb89c9de6eb'',''c441518d-bfe0-4d55-b538-df5c5555dd83'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c441518d-bfe0-4d55-b538-df5c5555dd83'' AND GUID_Type_Right=''3e1587d8-3e35-46dd-9833-41903904254d'' AND GUID_RelationType=''a778c55c-8308-4033-bd33-30ebd7347485'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c441518d-bfe0-4d55-b538-df5c5555dd83'',''3e1587d8-3e35-46dd-9833-41903904254d'',''a778c55c-8308-4033-bd33-30ebd7347485'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_RelationType=''4f8f29b4-49bb-4d85-a65f-205d2af4f509'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''4f8f29b4-49bb-4d85-a65f-205d2af4f509'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''8a894710-e08c-42c5-b829-ef4809830d33'' AND GUID_RelationType=''be8c7e8f-9b0b-4adc-8f0b-8f8f1ae47f87'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''8a894710-e08c-42c5-b829-ef4809830d33'',''be8c7e8f-9b0b-4adc-8f0b-8f8f1ae47f87'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c6c9bcb8-0ac9-4713-9417-eeec1453026c'' AND GUID_Type_Right=''13c09f11-175c-4eef-bc8a-0fd8e86d557f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c6c9bcb8-0ac9-4713-9417-eeec1453026c'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9403650d-2a28-4a0d-9a7f-f1d893960701'' AND GUID_Type_Right=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_RelationType=''18004521-0c12-4b85-80c3-4af08ef9d444'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9403650d-2a28-4a0d-9a7f-f1d893960701'',''327e9773-fca6-458c-a44d-338a556e0ad9'',''18004521-0c12-4b85-80c3-4af08ef9d444'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''c441518d-bfe0-4d55-b538-df5c5555dd83'' AND GUID_RelationType=''03da78f1-645b-4248-b249-6169f78401ac'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''c441518d-bfe0-4d55-b538-df5c5555dd83'',''03da78f1-645b-4248-b249-6169f78401ac'',1,1,-1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'' AND GUID_Type_Right=''9e4bbf04-0394-4041-94c0-9b07da7281db'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Type_Type VALUES(''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'',''9e4bbf04-0394-4041-94c0-9b07da7281db'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e39f270d-faab-4556-a1dc-655f1443a7e4'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e39f270d-faab-4556-a1dc-655f1443a7e4'',''f40e5133-f876-42c7-ab40-c8c602f8884c'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''269a9b57-254e-4ef2-96a1-5ed53b1e7d8e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''269a9b57-254e-4ef2-96a1-5ed53b1e7d8e'',''d5474c74-f70e-4916-98f6-4e3d3831c1f9'',''f1dd87f2-ac53-4e83-a76b-fee5bffc6909'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''a77ffe0a-878b-40a9-86ce-b61ce14e77d9'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''a77ffe0a-878b-40a9-86ce-b61ce14e77d9'',''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'',''f1dd87f2-ac53-4e83-a76b-fee5bffc6909'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''faef14fe-8a88-4a35-9ffa-989c6c84e9fd'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''faef14fe-8a88-4a35-9ffa-989c6c84e9fd'',''38090631-b096-4c3f-be03-cf79d6a537ae'',''f1dd87f2-ac53-4e83-a76b-fee5bffc6909'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''7fbc1647-4976-4913-ab27-2e1ce6253430'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''7fbc1647-4976-4913-ab27-2e1ce6253430'',''c17230e2-d57a-4a11-bea3-14db50a656a6'',''f1dd87f2-ac53-4e83-a76b-fee5bffc6909'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Bit WHERE GUID_TokenAttribute=''269a9b57-254e-4ef2-96a1-5ed53b1e7d8e'' )=0
	INSERT INTO semtbl_Token_Attribute_Bit VALUES(''269a9b57-254e-4ef2-96a1-5ed53b1e7d8e'',-1,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Bit WHERE GUID_TokenAttribute=''a77ffe0a-878b-40a9-86ce-b61ce14e77d9'' )=0
	INSERT INTO semtbl_Token_Attribute_Bit VALUES(''a77ffe0a-878b-40a9-86ce-b61ce14e77d9'',-1,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Bit WHERE GUID_TokenAttribute=''faef14fe-8a88-4a35-9ffa-989c6c84e9fd'' )=0
	INSERT INTO semtbl_Token_Attribute_Bit VALUES(''faef14fe-8a88-4a35-9ffa-989c6c84e9fd'',-1,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Bit WHERE GUID_TokenAttribute=''7fbc1647-4976-4913-ab27-2e1ce6253430'' )=0
	INSERT INTO semtbl_Token_Attribute_Bit VALUES(''7fbc1647-4976-4913-ab27-2e1ce6253430'',0,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Varchar255 WHERE GUID_TokenAttribute=''e39f270d-faab-4556-a1dc-655f1443a7e4'' )=0
	INSERT INTO semtbl_Token_Attribute_Varchar255 VALUES(''e39f270d-faab-4556-a1dc-655f1443a7e4'',''reportsviewer_module'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'')=0
	INSERT INTO semtbl_OR VALUES(''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6a0bbdd5-6206-4454-b5c3-e186b4105690'')=0
	INSERT INTO semtbl_OR VALUES(''6a0bbdd5-6206-4454-b5c3-e186b4105690'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''191b2368-a79a-467b-88de-effb85dedc6a'')=0
	INSERT INTO semtbl_OR VALUES(''191b2368-a79a-467b-88de-effb85dedc6a'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''1df45128-8e9e-485c-a562-2cd66e20e5eb'')=0
	INSERT INTO semtbl_OR VALUES(''1df45128-8e9e-485c-a562-2cd66e20e5eb'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b4596189-1bfe-450e-a4cd-3b051035dbdc'')=0
	INSERT INTO semtbl_OR VALUES(''b4596189-1bfe-450e-a4cd-3b051035dbdc'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''477c0c59-e4b1-44b1-aa5d-2d9c93dc0910'')=0
	INSERT INTO semtbl_OR VALUES(''477c0c59-e4b1-44b1-aa5d-2d9c93dc0910'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''70749d99-5266-4379-8c11-62e3a3bd3360'')=0
	INSERT INTO semtbl_OR VALUES(''70749d99-5266-4379-8c11-62e3a3bd3360'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''93ab0ef5-fb55-41aa-862e-79e161c2052c'')=0
	INSERT INTO semtbl_OR VALUES(''93ab0ef5-fb55-41aa-862e-79e161c2052c'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''7f7b4d7a-ccc0-4e43-91b7-dd019687708e'')=0
	INSERT INTO semtbl_OR VALUES(''7f7b4d7a-ccc0-4e43-91b7-dd019687708e'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''13befea3-d3e4-42cb-b8f3-aece20c453be'')=0
	INSERT INTO semtbl_OR VALUES(''13befea3-d3e4-42cb-b8f3-aece20c453be'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b59a68f6-4a37-455a-94c4-210a96c3aa3e'')=0
	INSERT INTO semtbl_OR VALUES(''b59a68f6-4a37-455a-94c4-210a96c3aa3e'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''58948066-2997-4573-b267-554a734fd141'')=0
	INSERT INTO semtbl_OR VALUES(''58948066-2997-4573-b267-554a734fd141'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''774cd5c1-0531-437c-8963-0953933b7e66'')=0
	INSERT INTO semtbl_OR VALUES(''774cd5c1-0531-437c-8963-0953933b7e66'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''7ac5d7b3-7921-49fe-8d90-836b6acea41f'')=0
	INSERT INTO semtbl_OR VALUES(''7ac5d7b3-7921-49fe-8d90-836b6acea41f'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b9221168-243b-444f-9f95-b670e7354aba'')=0
	INSERT INTO semtbl_OR VALUES(''b9221168-243b-444f-9f95-b670e7354aba'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ae863148-c4e2-4473-81eb-19f4f95c436c'')=0
	INSERT INTO semtbl_OR VALUES(''ae863148-c4e2-4473-81eb-19f4f95c436c'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''98f5d1eb-3a56-4083-a51b-8fa68a184c09'')=0
	INSERT INTO semtbl_OR VALUES(''98f5d1eb-3a56-4083-a51b-8fa68a184c09'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b706b7f9-40ae-431f-afdf-b44f25701fc1'')=0
	INSERT INTO semtbl_OR VALUES(''b706b7f9-40ae-431f-afdf-b44f25701fc1'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b5a71e14-f203-4da9-b8e4-bd526ab5feba'')=0
	INSERT INTO semtbl_OR VALUES(''b5a71e14-f203-4da9-b8e4-bd526ab5feba'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b52f76ef-eb6c-4298-ac9f-8414afbd055a'')=0
	INSERT INTO semtbl_OR VALUES(''b52f76ef-eb6c-4298-ac9f-8414afbd055a'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''f6af7b5d-ebef-4136-ba08-5de26d11d147'')=0
	INSERT INTO semtbl_OR VALUES(''f6af7b5d-ebef-4136-ba08-5de26d11d147'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6492175f-d7f3-4bfc-b1a3-f59eca48d6be'')=0
	INSERT INTO semtbl_OR VALUES(''6492175f-d7f3-4bfc-b1a3-f59eca48d6be'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''5f0b1e66-7a5a-4e75-830c-26aa47cf310d'')=0
	INSERT INTO semtbl_OR VALUES(''5f0b1e66-7a5a-4e75-830c-26aa47cf310d'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''03dba0ac-70ba-4be2-afbb-955fdf0756bd'')=0
	INSERT INTO semtbl_OR VALUES(''03dba0ac-70ba-4be2-afbb-955fdf0756bd'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''50d23921-5da1-404a-9bf5-89dcf5c452cb'')=0
	INSERT INTO semtbl_OR VALUES(''50d23921-5da1-404a-9bf5-89dcf5c452cb'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e769da11-8b4d-4929-8aec-c387d9b94c19'')=0
	INSERT INTO semtbl_OR VALUES(''e769da11-8b4d-4929-8aec-c387d9b94c19'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''af56d52d-96d0-41f3-a39d-9b2ed6e1cd65'')=0
	INSERT INTO semtbl_OR VALUES(''af56d52d-96d0-41f3-a39d-9b2ed6e1cd65'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''baee993b-0a3d-4a4f-a95c-0a074e9f073b'')=0
	INSERT INTO semtbl_OR VALUES(''baee993b-0a3d-4a4f-a95c-0a074e9f073b'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''880400b2-6832-4368-baa9-a1d543c382e7'')=0
	INSERT INTO semtbl_OR VALUES(''880400b2-6832-4368-baa9-a1d543c382e7'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''33e15532-5b6f-4812-97bb-2989e82bf7a7'')=0
	INSERT INTO semtbl_OR VALUES(''33e15532-5b6f-4812-97bb-2989e82bf7a7'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'')=0
	INSERT INTO semtbl_OR VALUES(''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''279d8f97-6ef2-45cd-8020-8e9d9ac9fd78'')=0
	INSERT INTO semtbl_OR VALUES(''279d8f97-6ef2-45cd-8020-8e9d9ac9fd78'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'')=0
	INSERT INTO semtbl_OR VALUES(''008817a6-14e7-4295-9a69-6835575ae53b'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''863b025b-d7c3-4e1b-8764-8b60e555307f'')=0
	INSERT INTO semtbl_OR VALUES(''863b025b-d7c3-4e1b-8764-8b60e555307f'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''292ded0e-f1e2-4994-a00b-607decea248b'')=0
	INSERT INTO semtbl_OR VALUES(''292ded0e-f1e2-4994-a00b-607decea248b'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''14c142d9-7570-48db-8587-f5bdf241b95e'')=0
	INSERT INTO semtbl_OR VALUES(''14c142d9-7570-48db-8587-f5bdf241b95e'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8c1a80aa-657c-42a5-946e-8a01a2790e42'')=0
	INSERT INTO semtbl_OR VALUES(''8c1a80aa-657c-42a5-946e-8a01a2790e42'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''fa81f65a-8cdd-49c8-b790-24da61855839'')=0
	INSERT INTO semtbl_OR VALUES(''fa81f65a-8cdd-49c8-b790-24da61855839'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8850a46d-8d2c-4500-ab68-def664bd1a3b'')=0
	INSERT INTO semtbl_OR VALUES(''8850a46d-8d2c-4500-ab68-def664bd1a3b'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''f4c859c5-7633-443b-b235-3b8eae694e59'')=0
	INSERT INTO semtbl_OR VALUES(''f4c859c5-7633-443b-b235-3b8eae694e59'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''07d78334-08f5-458a-b84a-b586f60700b9'')=0
	INSERT INTO semtbl_OR VALUES(''07d78334-08f5-458a-b84a-b586f60700b9'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b0f72e18-4d2b-4990-b98a-e7eef4fe5b3a'')=0
	INSERT INTO semtbl_OR VALUES(''b0f72e18-4d2b-4990-b98a-e7eef4fe5b3a'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''94979ade-755f-4adf-808c-7cc4bf279e40'')=0
	INSERT INTO semtbl_OR VALUES(''94979ade-755f-4adf-808c-7cc4bf279e40'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''fb8b6f16-df09-4894-9b80-9db1ac70916b'')=0
	INSERT INTO semtbl_OR VALUES(''fb8b6f16-df09-4894-9b80-9db1ac70916b'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''93e02712-72b6-4233-94ad-490ebe740832'')=0
	INSERT INTO semtbl_OR VALUES(''93e02712-72b6-4233-94ad-490ebe740832'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'')=0
	INSERT INTO semtbl_OR VALUES(''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''04499b6b-4d2c-4ba4-8ae8-a6b68fecdda1'')=0
	INSERT INTO semtbl_OR VALUES(''04499b6b-4d2c-4ba4-8ae8-a6b68fecdda1'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''a3eefd82-7501-4d2a-b95b-0314be945223'')=0
	INSERT INTO semtbl_OR VALUES(''a3eefd82-7501-4d2a-b95b-0314be945223'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''1b02ff93-e616-4922-bcbb-b33fd9e25566'')=0
	INSERT INTO semtbl_OR VALUES(''1b02ff93-e616-4922-bcbb-b33fd9e25566'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'')=0
	INSERT INTO semtbl_OR VALUES(''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'')=0
	INSERT INTO semtbl_OR VALUES(''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ca0d8f42-71d5-432b-b047-9fef7bc8b101'')=0
	INSERT INTO semtbl_OR VALUES(''ca0d8f42-71d5-432b-b047-9fef7bc8b101'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''72271efb-49f0-40e6-8f6a-20bf0b1c0996'')=0
	INSERT INTO semtbl_OR VALUES(''72271efb-49f0-40e6-8f6a-20bf0b1c0996'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'')=0
	INSERT INTO semtbl_OR VALUES(''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''89c4e35e-c8fd-4beb-a6a6-48990442efe6'')=0
	INSERT INTO semtbl_OR VALUES(''89c4e35e-c8fd-4beb-a6a6-48990442efe6'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''7de4606d-dddd-431d-92c2-928f5eb851c4'')=0
	INSERT INTO semtbl_OR VALUES(''7de4606d-dddd-431d-92c2-928f5eb851c4'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''c09ca6bf-b5fb-4121-b169-d389981a2ad4'')=0
	INSERT INTO semtbl_OR VALUES(''c09ca6bf-b5fb-4121-b169-d389981a2ad4'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''4fdbc15a-7211-4dce-92af-40f3caf3916a'')=0
	INSERT INTO semtbl_OR VALUES(''4fdbc15a-7211-4dce-92af-40f3caf3916a'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''7babbe69-d349-4ef8-9e12-8bfbe6af815f'')=0
	INSERT INTO semtbl_OR VALUES(''7babbe69-d349-4ef8-9e12-8bfbe6af815f'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'')=0
	INSERT INTO semtbl_OR VALUES(''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d251cf80-30d7-404c-8f68-4926d0efad3e'')=0
	INSERT INTO semtbl_OR VALUES(''d251cf80-30d7-404c-8f68-4926d0efad3e'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''655bd8d3-cd88-4e10-bce4-b952205f8130'')=0
	INSERT INTO semtbl_OR VALUES(''655bd8d3-cd88-4e10-bce4-b952205f8130'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''18a75b98-b3c3-4ddc-847a-848176079e09'')=0
	INSERT INTO semtbl_OR VALUES(''18a75b98-b3c3-4ddc-847a-848176079e09'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''0685fe36-17ef-43ad-9c90-fe202ae20f4e'')=0
	INSERT INTO semtbl_OR VALUES(''0685fe36-17ef-43ad-9c90-fe202ae20f4e'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''15c98e13-ec0f-44fa-bc76-abc87189d04f'')=0
	INSERT INTO semtbl_OR VALUES(''15c98e13-ec0f-44fa-bc76-abc87189d04f'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''bf64e808-bb40-4587-9fc2-8ae2b4896558'')=0
	INSERT INTO semtbl_OR VALUES(''bf64e808-bb40-4587-9fc2-8ae2b4896558'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''840bcc61-eae8-4c9c-8cb3-ed38a95f6be5'')=0
	INSERT INTO semtbl_OR VALUES(''840bcc61-eae8-4c9c-8cb3-ed38a95f6be5'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''0db4a03a-2d87-4033-834a-50b9274b453e'')=0
	INSERT INTO semtbl_OR VALUES(''0db4a03a-2d87-4033-834a-50b9274b453e'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'')=0
	INSERT INTO semtbl_OR_Type VALUES(''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''1df45128-8e9e-485c-a562-2cd66e20e5eb'')=0
	INSERT INTO semtbl_OR_Type VALUES(''1df45128-8e9e-485c-a562-2cd66e20e5eb'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''477c0c59-e4b1-44b1-aa5d-2d9c93dc0910'')=0
	INSERT INTO semtbl_OR_Type VALUES(''477c0c59-e4b1-44b1-aa5d-2d9c93dc0910'',''3e1587d8-3e35-46dd-9833-41903904254d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''70749d99-5266-4379-8c11-62e3a3bd3360'')=0
	INSERT INTO semtbl_OR_Type VALUES(''70749d99-5266-4379-8c11-62e3a3bd3360'',''7fd09ae5-cfda-42dd-bbfb-ed5d1376e4b8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''93ab0ef5-fb55-41aa-862e-79e161c2052c'')=0
	INSERT INTO semtbl_OR_Type VALUES(''93ab0ef5-fb55-41aa-862e-79e161c2052c'',''f8a525de-72bb-4904-941f-63a40ce34234'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''58948066-2997-4573-b267-554a734fd141'')=0
	INSERT INTO semtbl_OR_Type VALUES(''58948066-2997-4573-b267-554a734fd141'',''3dd1a15f-eef3-4943-8ce1-828e201a3c9d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''7ac5d7b3-7921-49fe-8d90-836b6acea41f'')=0
	INSERT INTO semtbl_OR_Type VALUES(''7ac5d7b3-7921-49fe-8d90-836b6acea41f'',''c0ae3680-18a8-41d9-9238-91505eb2a0ce'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''b706b7f9-40ae-431f-afdf-b44f25701fc1'')=0
	INSERT INTO semtbl_OR_Type VALUES(''b706b7f9-40ae-431f-afdf-b44f25701fc1'',''ca4eff30-a40b-476d-9906-9f56a67c8cf9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''f6af7b5d-ebef-4136-ba08-5de26d11d147'')=0
	INSERT INTO semtbl_OR_Type VALUES(''f6af7b5d-ebef-4136-ba08-5de26d11d147'',''748a8642-f689-485f-a4a6-11bbb76f9523'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''6492175f-d7f3-4bfc-b1a3-f59eca48d6be'')=0
	INSERT INTO semtbl_OR_Type VALUES(''6492175f-d7f3-4bfc-b1a3-f59eca48d6be'',''9403650d-2a28-4a0d-9a7f-f1d893960701'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''880400b2-6832-4368-baa9-a1d543c382e7'')=0
	INSERT INTO semtbl_OR_Type VALUES(''880400b2-6832-4368-baa9-a1d543c382e7'',''9ba24283-a0ad-4717-be30-6f0f3818c36c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''8c1a80aa-657c-42a5-946e-8a01a2790e42'')=0
	INSERT INTO semtbl_OR_Type VALUES(''8c1a80aa-657c-42a5-946e-8a01a2790e42'',''1233afbe-60bf-40e7-9228-64ca4013b75c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''8850a46d-8d2c-4500-ab68-def664bd1a3b'')=0
	INSERT INTO semtbl_OR_Type VALUES(''8850a46d-8d2c-4500-ab68-def664bd1a3b'',''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''b0f72e18-4d2b-4990-b98a-e7eef4fe5b3a'')=0
	INSERT INTO semtbl_OR_Type VALUES(''b0f72e18-4d2b-4990-b98a-e7eef4fe5b3a'',''9053d6ad-8ebb-4f68-bfb0-285d8b38a170'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''93e02712-72b6-4233-94ad-490ebe740832'')=0
	INSERT INTO semtbl_OR_Type VALUES(''93e02712-72b6-4233-94ad-490ebe740832'',''e17005da-097f-46da-aa31-0cbc770f8495'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''a3eefd82-7501-4d2a-b95b-0314be945223'')=0
	INSERT INTO semtbl_OR_Type VALUES(''a3eefd82-7501-4d2a-b95b-0314be945223'',''094d728d-6efc-463c-85c7-2dcfed903c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''1b02ff93-e616-4922-bcbb-b33fd9e25566'')=0
	INSERT INTO semtbl_OR_Type VALUES(''1b02ff93-e616-4922-bcbb-b33fd9e25566'',''327e9773-fca6-458c-a44d-338a556e0ad9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'')=0
	INSERT INTO semtbl_OR_Type VALUES(''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'',''8a894710-e08c-42c5-b829-ef4809830d33'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'')=0
	INSERT INTO semtbl_OR_Type VALUES(''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''ca0d8f42-71d5-432b-b047-9fef7bc8b101'')=0
	INSERT INTO semtbl_OR_Type VALUES(''ca0d8f42-71d5-432b-b047-9fef7bc8b101'',''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''72271efb-49f0-40e6-8f6a-20bf0b1c0996'')=0
	INSERT INTO semtbl_OR_Type VALUES(''72271efb-49f0-40e6-8f6a-20bf0b1c0996'',''2b30cab7-81b4-4d1b-b3cd-9fb89c9de6eb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'')=0
	INSERT INTO semtbl_OR_Type VALUES(''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'',''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''89c4e35e-c8fd-4beb-a6a6-48990442efe6'')=0
	INSERT INTO semtbl_OR_Type VALUES(''89c4e35e-c8fd-4beb-a6a6-48990442efe6'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''4fdbc15a-7211-4dce-92af-40f3caf3916a'')=0
	INSERT INTO semtbl_OR_Type VALUES(''4fdbc15a-7211-4dce-92af-40f3caf3916a'',''c441518d-bfe0-4d55-b538-df5c5555dd83'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'')=0
	INSERT INTO semtbl_OR_Type VALUES(''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''0685fe36-17ef-43ad-9c90-fe202ae20f4e'')=0
	INSERT INTO semtbl_OR_Type VALUES(''0685fe36-17ef-43ad-9c90-fe202ae20f4e'',''74aef11b-e102-4cb4-8ca9-3d8ea0fa30a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''840bcc61-eae8-4c9c-8cb3-ed38a95f6be5'')=0
	INSERT INTO semtbl_OR_Type VALUES(''840bcc61-eae8-4c9c-8cb3-ed38a95f6be5'',''278365e9-37a2-448b-b96f-b4cbc97f07b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''b4596189-1bfe-450e-a4cd-3b051035dbdc'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''b4596189-1bfe-450e-a4cd-3b051035dbdc'',''3940fb8a-7ec9-4bd5-9719-aed313da116d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''774cd5c1-0531-437c-8963-0953933b7e66'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''774cd5c1-0531-437c-8963-0953933b7e66'',''3316543a-c922-4bb8-afe8-b6f58db0adef'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''ae863148-c4e2-4473-81eb-19f4f95c436c'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''ae863148-c4e2-4473-81eb-19f4f95c436c'',''f1dd87f2-ac53-4e83-a76b-fee5bffc6909'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''b5a71e14-f203-4da9-b8e4-bd526ab5feba'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''b5a71e14-f203-4da9-b8e4-bd526ab5feba'',''68ac4472-ee22-4229-96ec-9753a016900a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''baee993b-0a3d-4a4f-a95c-0a074e9f073b'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''baee993b-0a3d-4a4f-a95c-0a074e9f073b'',''d4ea61d7-ec98-484d-a1cd-cd02d41cd0d3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''863b025b-d7c3-4e1b-8764-8b60e555307f'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''863b025b-d7c3-4e1b-8764-8b60e555307f'',''0705d441-2a3e-4ccf-bc35-140ae3d406bd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''14c142d9-7570-48db-8587-f5bdf241b95e'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''14c142d9-7570-48db-8587-f5bdf241b95e'',''1d7d076b-bf2d-4274-88ee-a9a1f570e690'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''fa81f65a-8cdd-49c8-b790-24da61855839'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''fa81f65a-8cdd-49c8-b790-24da61855839'',''6c758923-0363-4259-bd18-8a44a9d7fad8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''191b2368-a79a-467b-88de-effb85dedc6a'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''191b2368-a79a-467b-88de-effb85dedc6a'',''66857dba-efd6-48c9-ad54-04103f56ab8a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''7f7b4d7a-ccc0-4e43-91b7-dd019687708e'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''7f7b4d7a-ccc0-4e43-91b7-dd019687708e'',''a80b1064-649b-4510-980e-c28be335956c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''b59a68f6-4a37-455a-94c4-210a96c3aa3e'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''b59a68f6-4a37-455a-94c4-210a96c3aa3e'',''2abef94e-34de-45ab-80c1-5d0ad5a006d0'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''b9221168-243b-444f-9f95-b670e7354aba'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''b9221168-243b-444f-9f95-b670e7354aba'',''f7930edf-0e80-47f8-b1a5-84c4b15366a3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''98f5d1eb-3a56-4083-a51b-8fa68a184c09'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''98f5d1eb-3a56-4083-a51b-8fa68a184c09'',''3e104b75-e01c-48a0-b041-12908fd446a0'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''af56d52d-96d0-41f3-a39d-9b2ed6e1cd65'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''af56d52d-96d0-41f3-a39d-9b2ed6e1cd65'',''801886c0-0938-47e2-945e-f3d34f7c68fe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''e9711603-47db-44d8-a476-fe88290639a4'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''008817a6-14e7-4295-9a69-6835575ae53b'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''292ded0e-f1e2-4994-a00b-607decea248b'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''292ded0e-f1e2-4994-a00b-607decea248b'',''6edbb77c-18d1-4736-92bf-7bd5e5dde8b8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''07d78334-08f5-458a-b84a-b586f60700b9'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''07d78334-08f5-458a-b84a-b586f60700b9'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''e07469d9-766c-443e-8526-6d9c684f944f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''04499b6b-4d2c-4ba4-8ae8-a6b68fecdda1'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''04499b6b-4d2c-4ba4-8ae8-a6b68fecdda1'',''0fa056ea-474f-424f-ab68-0a10b57d3a95'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''c09ca6bf-b5fb-4121-b169-d389981a2ad4'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''c09ca6bf-b5fb-4121-b169-d389981a2ad4'',''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''655bd8d3-cd88-4e10-bce4-b952205f8130'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''655bd8d3-cd88-4e10-bce4-b952205f8130'',''ace00f97-67b7-4177-bfe0-6ac7b3bfd8a5'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''6a0bbdd5-6206-4454-b5c3-e186b4105690'')=0
	INSERT INTO semtbl_OR_Token VALUES(''6a0bbdd5-6206-4454-b5c3-e186b4105690'',''f6d51ec7-8ae7-47b4-b496-6b3db94779bb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''13befea3-d3e4-42cb-b8f3-aece20c453be'')=0
	INSERT INTO semtbl_OR_Token VALUES(''13befea3-d3e4-42cb-b8f3-aece20c453be'',''8c9fa101-8e2b-4aa6-b84f-6af075bdde3b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''b52f76ef-eb6c-4298-ac9f-8414afbd055a'')=0
	INSERT INTO semtbl_OR_Token VALUES(''b52f76ef-eb6c-4298-ac9f-8414afbd055a'',''23b585f2-79e2-4abd-a505-f2d6a9369eeb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''5f0b1e66-7a5a-4e75-830c-26aa47cf310d'')=0
	INSERT INTO semtbl_OR_Token VALUES(''5f0b1e66-7a5a-4e75-830c-26aa47cf310d'',''1bb34344-d41c-4610-927a-74200fc9f6c4'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''03dba0ac-70ba-4be2-afbb-955fdf0756bd'')=0
	INSERT INTO semtbl_OR_Token VALUES(''03dba0ac-70ba-4be2-afbb-955fdf0756bd'',''c7bc92dc-4f2e-45c1-87d7-ce4bb40719be'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''50d23921-5da1-404a-9bf5-89dcf5c452cb'')=0
	INSERT INTO semtbl_OR_Token VALUES(''50d23921-5da1-404a-9bf5-89dcf5c452cb'',''d5474c74-f70e-4916-98f6-4e3d3831c1f9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''e769da11-8b4d-4929-8aec-c387d9b94c19'')=0
	INSERT INTO semtbl_OR_Token VALUES(''e769da11-8b4d-4929-8aec-c387d9b94c19'',''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''33e15532-5b6f-4812-97bb-2989e82bf7a7'')=0
	INSERT INTO semtbl_OR_Token VALUES(''33e15532-5b6f-4812-97bb-2989e82bf7a7'',''3aa1632a-771e-4cc6-95cf-2dd583a812ca'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''279d8f97-6ef2-45cd-8020-8e9d9ac9fd78'')=0
	INSERT INTO semtbl_OR_Token VALUES(''279d8f97-6ef2-45cd-8020-8e9d9ac9fd78'',''2d9d8f4e-918e-4339-9243-a602afd5280b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''f4c859c5-7633-443b-b235-3b8eae694e59'')=0
	INSERT INTO semtbl_OR_Token VALUES(''f4c859c5-7633-443b-b235-3b8eae694e59'',''c7781ee8-d681-4d76-954a-58982327b57d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''94979ade-755f-4adf-808c-7cc4bf279e40'')=0
	INSERT INTO semtbl_OR_Token VALUES(''94979ade-755f-4adf-808c-7cc4bf279e40'',''6bddeb7f-f782-4962-888f-af7381e8bad6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''fb8b6f16-df09-4894-9b80-9db1ac70916b'')=0
	INSERT INTO semtbl_OR_Token VALUES(''fb8b6f16-df09-4894-9b80-9db1ac70916b'',''461bfc6f-4ef5-4185-82f9-d449b0b0aecc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''7de4606d-dddd-431d-92c2-928f5eb851c4'')=0
	INSERT INTO semtbl_OR_Token VALUES(''7de4606d-dddd-431d-92c2-928f5eb851c4'',''38090631-b096-4c3f-be03-cf79d6a537ae'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''7babbe69-d349-4ef8-9e12-8bfbe6af815f'')=0
	INSERT INTO semtbl_OR_Token VALUES(''7babbe69-d349-4ef8-9e12-8bfbe6af815f'',''1ec005b7-20f3-4016-a404-c9d29b44470a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''d251cf80-30d7-404c-8f68-4926d0efad3e'')=0
	INSERT INTO semtbl_OR_Token VALUES(''d251cf80-30d7-404c-8f68-4926d0efad3e'',''c6438d35-df0d-4c63-9a54-ab853bdd475a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''18a75b98-b3c3-4ddc-847a-848176079e09'')=0
	INSERT INTO semtbl_OR_Token VALUES(''18a75b98-b3c3-4ddc-847a-848176079e09'',''0d2b3ce0-afd5-465e-affc-12abfac7762a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''15c98e13-ec0f-44fa-bc76-abc87189d04f'')=0
	INSERT INTO semtbl_OR_Token VALUES(''15c98e13-ec0f-44fa-bc76-abc87189d04f'',''c17230e2-d57a-4a11-bea3-14db50a656a6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''bf64e808-bb40-4587-9fc2-8ae2b4896558'')=0
	INSERT INTO semtbl_OR_Token VALUES(''bf64e808-bb40-4587-9fc2-8ae2b4896558'',''bc89df19-ad5e-4f2d-b821-af073f60c0a7'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''0db4a03a-2d87-4033-834a-50b9274b453e'')=0
	INSERT INTO semtbl_OR_Token VALUES(''0db4a03a-2d87-4033-834a-50b9274b453e'',''c4a54bf0-a674-4b91-806b-aa886d4bbc0d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d29b56cd-cdad-4b46-af59-0464909864b6'' AND GUID_ObjectReference=''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d29b56cd-cdad-4b46-af59-0464909864b6'',''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''9d8f3864-12da-48a0-952c-0741d81d5ec9'' AND GUID_ObjectReference=''6a0bbdd5-6206-4454-b5c3-e186b4105690'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''9d8f3864-12da-48a0-952c-0741d81d5ec9'',''6a0bbdd5-6206-4454-b5c3-e186b4105690'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ea85785e-42a2-41f1-b6f7-08cc803a21f7'' AND GUID_ObjectReference=''191b2368-a79a-467b-88de-effb85dedc6a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ea85785e-42a2-41f1-b6f7-08cc803a21f7'',''191b2368-a79a-467b-88de-effb85dedc6a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''aec9173b-37fb-4b0b-a2ef-108a939ad87b'' AND GUID_ObjectReference=''1df45128-8e9e-485c-a562-2cd66e20e5eb'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''aec9173b-37fb-4b0b-a2ef-108a939ad87b'',''1df45128-8e9e-485c-a562-2cd66e20e5eb'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''c5d5cbf4-77dd-44a7-87a9-18d68ed0cded'' AND GUID_ObjectReference=''b4596189-1bfe-450e-a4cd-3b051035dbdc'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''c5d5cbf4-77dd-44a7-87a9-18d68ed0cded'',''b4596189-1bfe-450e-a4cd-3b051035dbdc'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''26ff5a5b-f32b-4082-984a-191d7c2d6b38'' AND GUID_ObjectReference=''477c0c59-e4b1-44b1-aa5d-2d9c93dc0910'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''26ff5a5b-f32b-4082-984a-191d7c2d6b38'',''477c0c59-e4b1-44b1-aa5d-2d9c93dc0910'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''7c73559d-0a69-4ee3-8fd9-1a44b11a1089'' AND GUID_ObjectReference=''70749d99-5266-4379-8c11-62e3a3bd3360'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''7c73559d-0a69-4ee3-8fd9-1a44b11a1089'',''70749d99-5266-4379-8c11-62e3a3bd3360'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'' AND GUID_ObjectReference=''93ab0ef5-fb55-41aa-862e-79e161c2052c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'',''93ab0ef5-fb55-41aa-862e-79e161c2052c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''5ea2aade-a23a-46a1-b34f-275676ac8a42'' AND GUID_ObjectReference=''7f7b4d7a-ccc0-4e43-91b7-dd019687708e'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''5ea2aade-a23a-46a1-b34f-275676ac8a42'',''7f7b4d7a-ccc0-4e43-91b7-dd019687708e'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f2dfdacd-ae69-4802-ace1-2baffcdea82f'' AND GUID_ObjectReference=''13befea3-d3e4-42cb-b8f3-aece20c453be'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f2dfdacd-ae69-4802-ace1-2baffcdea82f'',''13befea3-d3e4-42cb-b8f3-aece20c453be'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''4fdbe676-6ab7-4209-ad91-306d10e56fbd'' AND GUID_ObjectReference=''b59a68f6-4a37-455a-94c4-210a96c3aa3e'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''4fdbe676-6ab7-4209-ad91-306d10e56fbd'',''b59a68f6-4a37-455a-94c4-210a96c3aa3e'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8fd7d742-9a60-4a9d-9d16-32c04632893d'' AND GUID_ObjectReference=''58948066-2997-4573-b267-554a734fd141'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8fd7d742-9a60-4a9d-9d16-32c04632893d'',''58948066-2997-4573-b267-554a734fd141'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3b16d4dc-a07e-4579-b715-33bf363dd7d6'' AND GUID_ObjectReference=''774cd5c1-0531-437c-8963-0953933b7e66'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3b16d4dc-a07e-4579-b715-33bf363dd7d6'',''774cd5c1-0531-437c-8963-0953933b7e66'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''c1718c62-ea40-4023-bf35-33e3ce431734'' AND GUID_ObjectReference=''7ac5d7b3-7921-49fe-8d90-836b6acea41f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''c1718c62-ea40-4023-bf35-33e3ce431734'',''7ac5d7b3-7921-49fe-8d90-836b6acea41f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6b680dc6-1c99-4ee3-945e-364d50b2d5df'' AND GUID_ObjectReference=''b9221168-243b-444f-9f95-b670e7354aba'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6b680dc6-1c99-4ee3-945e-364d50b2d5df'',''b9221168-243b-444f-9f95-b670e7354aba'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''2a4992d1-8dd1-45e6-a500-37052cb97586'' AND GUID_ObjectReference=''ae863148-c4e2-4473-81eb-19f4f95c436c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''2a4992d1-8dd1-45e6-a500-37052cb97586'',''ae863148-c4e2-4473-81eb-19f4f95c436c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''747952da-2e66-49c1-8462-3a20addbc0ef'' AND GUID_ObjectReference=''98f5d1eb-3a56-4083-a51b-8fa68a184c09'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''747952da-2e66-49c1-8462-3a20addbc0ef'',''98f5d1eb-3a56-4083-a51b-8fa68a184c09'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''56803624-0182-4926-9da5-3bc4fe5e7b31'' AND GUID_ObjectReference=''b706b7f9-40ae-431f-afdf-b44f25701fc1'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''56803624-0182-4926-9da5-3bc4fe5e7b31'',''b706b7f9-40ae-431f-afdf-b44f25701fc1'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'' AND GUID_ObjectReference=''b5a71e14-f203-4da9-b8e4-bd526ab5feba'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'',''b5a71e14-f203-4da9-b8e4-bd526ab5feba'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''0f54c71f-1aea-4bf3-9958-44a68afd84ec'' AND GUID_ObjectReference=''b52f76ef-eb6c-4298-ac9f-8414afbd055a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''0f54c71f-1aea-4bf3-9958-44a68afd84ec'',''b52f76ef-eb6c-4298-ac9f-8414afbd055a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''091343df-f818-4db7-8dfa-45358e2133b1'' AND GUID_ObjectReference=''f6af7b5d-ebef-4136-ba08-5de26d11d147'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''091343df-f818-4db7-8dfa-45358e2133b1'',''f6af7b5d-ebef-4136-ba08-5de26d11d147'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3c2fb8fa-b8bf-4930-bc5c-4817f8b1ad40'' AND GUID_ObjectReference=''6492175f-d7f3-4bfc-b1a3-f59eca48d6be'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3c2fb8fa-b8bf-4930-bc5c-4817f8b1ad40'',''6492175f-d7f3-4bfc-b1a3-f59eca48d6be'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''474d70c7-a115-4a93-b285-4a2672c2d041'' AND GUID_ObjectReference=''5f0b1e66-7a5a-4e75-830c-26aa47cf310d'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''474d70c7-a115-4a93-b285-4a2672c2d041'',''5f0b1e66-7a5a-4e75-830c-26aa47cf310d'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''1f99c1f1-770a-4faf-98c8-50facf2a10f7'' AND GUID_ObjectReference=''03dba0ac-70ba-4be2-afbb-955fdf0756bd'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''1f99c1f1-770a-4faf-98c8-50facf2a10f7'',''03dba0ac-70ba-4be2-afbb-955fdf0756bd'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''49716d39-9cc8-45c3-8b81-54ad7429881f'' AND GUID_ObjectReference=''50d23921-5da1-404a-9bf5-89dcf5c452cb'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''49716d39-9cc8-45c3-8b81-54ad7429881f'',''50d23921-5da1-404a-9bf5-89dcf5c452cb'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''765108ea-65a4-41f5-a95a-54bf4fd3effc'' AND GUID_ObjectReference=''e769da11-8b4d-4929-8aec-c387d9b94c19'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''765108ea-65a4-41f5-a95a-54bf4fd3effc'',''e769da11-8b4d-4929-8aec-c387d9b94c19'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e1215482-8954-493d-888d-5800e2e5e29d'' AND GUID_ObjectReference=''af56d52d-96d0-41f3-a39d-9b2ed6e1cd65'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e1215482-8954-493d-888d-5800e2e5e29d'',''af56d52d-96d0-41f3-a39d-9b2ed6e1cd65'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''7c76114a-6a68-42aa-b9ce-5fd0d8a02eff'' AND GUID_ObjectReference=''baee993b-0a3d-4a4f-a95c-0a074e9f073b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''7c76114a-6a68-42aa-b9ce-5fd0d8a02eff'',''baee993b-0a3d-4a4f-a95c-0a074e9f073b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''33b131b4-810d-449c-a3f7-60d16cba5853'' AND GUID_ObjectReference=''880400b2-6832-4368-baa9-a1d543c382e7'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''33b131b4-810d-449c-a3f7-60d16cba5853'',''880400b2-6832-4368-baa9-a1d543c382e7'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''224f7ece-8d8b-4754-8ef2-6771809a7ea7'' AND GUID_ObjectReference=''33e15532-5b6f-4812-97bb-2989e82bf7a7'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''224f7ece-8d8b-4754-8ef2-6771809a7ea7'',''33e15532-5b6f-4812-97bb-2989e82bf7a7'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6c966e3c-c737-4af1-9970-68c8323679bc'' AND GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6c966e3c-c737-4af1-9970-68c8323679bc'',''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''dc650c9f-6914-45ab-b7af-6ebe8a928bb5'' AND GUID_ObjectReference=''279d8f97-6ef2-45cd-8020-8e9d9ac9fd78'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''dc650c9f-6914-45ab-b7af-6ebe8a928bb5'',''279d8f97-6ef2-45cd-8020-8e9d9ac9fd78'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6e494944-f602-4dcb-906f-70e5efe8f1dd'' AND GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''008817a6-14e7-4295-9a69-6835575ae53b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''600419f9-88da-4649-b3bf-78a4edecc9a6'' AND GUID_ObjectReference=''863b025b-d7c3-4e1b-8764-8b60e555307f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''600419f9-88da-4649-b3bf-78a4edecc9a6'',''863b025b-d7c3-4e1b-8764-8b60e555307f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e85c65c5-2058-45f9-a66a-7d9a96987075'' AND GUID_ObjectReference=''292ded0e-f1e2-4994-a00b-607decea248b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e85c65c5-2058-45f9-a66a-7d9a96987075'',''292ded0e-f1e2-4994-a00b-607decea248b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f952e7f1-438b-4ae9-b588-8142aaf280d3'' AND GUID_ObjectReference=''14c142d9-7570-48db-8587-f5bdf241b95e'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f952e7f1-438b-4ae9-b588-8142aaf280d3'',''14c142d9-7570-48db-8587-f5bdf241b95e'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''31ff7c35-21e8-45b2-9b86-81de3b26a71b'' AND GUID_ObjectReference=''8c1a80aa-657c-42a5-946e-8a01a2790e42'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''31ff7c35-21e8-45b2-9b86-81de3b26a71b'',''8c1a80aa-657c-42a5-946e-8a01a2790e42'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''aa297c67-08be-46bd-a98c-856aea6b8046'' AND GUID_ObjectReference=''fa81f65a-8cdd-49c8-b790-24da61855839'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''aa297c67-08be-46bd-a98c-856aea6b8046'',''fa81f65a-8cdd-49c8-b790-24da61855839'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''c7619aac-483f-4cec-be37-8c6495fbc2b7'' AND GUID_ObjectReference=''8850a46d-8d2c-4500-ab68-def664bd1a3b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''c7619aac-483f-4cec-be37-8c6495fbc2b7'',''8850a46d-8d2c-4500-ab68-def664bd1a3b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''cf0f52ac-1e00-45f4-ae02-8d6d3a920b59'' AND GUID_ObjectReference=''f4c859c5-7633-443b-b235-3b8eae694e59'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''cf0f52ac-1e00-45f4-ae02-8d6d3a920b59'',''f4c859c5-7633-443b-b235-3b8eae694e59'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'' AND GUID_ObjectReference=''07d78334-08f5-458a-b84a-b586f60700b9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'',''07d78334-08f5-458a-b84a-b586f60700b9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d3101831-962d-4069-a96d-94fcfc234651'' AND GUID_ObjectReference=''b0f72e18-4d2b-4990-b98a-e7eef4fe5b3a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d3101831-962d-4069-a96d-94fcfc234651'',''b0f72e18-4d2b-4990-b98a-e7eef4fe5b3a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''407516df-78ae-4f0d-ae36-956c0621588b'' AND GUID_ObjectReference=''94979ade-755f-4adf-808c-7cc4bf279e40'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''407516df-78ae-4f0d-ae36-956c0621588b'',''94979ade-755f-4adf-808c-7cc4bf279e40'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''be75dfa9-a31e-47af-8b91-9b42153b6d39'' AND GUID_ObjectReference=''fb8b6f16-df09-4894-9b80-9db1ac70916b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''be75dfa9-a31e-47af-8b91-9b42153b6d39'',''fb8b6f16-df09-4894-9b80-9db1ac70916b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d5556f74-b21f-4efe-a439-a28b53a4bf5f'' AND GUID_ObjectReference=''93e02712-72b6-4233-94ad-490ebe740832'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d5556f74-b21f-4efe-a439-a28b53a4bf5f'',''93e02712-72b6-4233-94ad-490ebe740832'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''5a778c64-4bcc-4faf-bdba-aaa01092f200'' AND GUID_ObjectReference=''04499b6b-4d2c-4ba4-8ae8-a6b68fecdda1'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''5a778c64-4bcc-4faf-bdba-aaa01092f200'',''04499b6b-4d2c-4ba4-8ae8-a6b68fecdda1'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f10253cf-f5c4-4777-8f4b-abc61217e28b'' AND GUID_ObjectReference=''a3eefd82-7501-4d2a-b95b-0314be945223'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f10253cf-f5c4-4777-8f4b-abc61217e28b'',''a3eefd82-7501-4d2a-b95b-0314be945223'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''cfba621b-5774-445b-8749-af12bb8bb472'' AND GUID_ObjectReference=''1b02ff93-e616-4922-bcbb-b33fd9e25566'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''cfba621b-5774-445b-8749-af12bb8bb472'',''1b02ff93-e616-4922-bcbb-b33fd9e25566'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8a6a3874-7e7b-4c41-b43a-b0349e39113b'' AND GUID_ObjectReference=''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8a6a3874-7e7b-4c41-b43a-b0349e39113b'',''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f1ba23ed-ab41-4d34-8e09-b4e485671478'' AND GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''178d63d3-84de-414f-8abb-b9ed14965b74'' AND GUID_ObjectReference=''ca0d8f42-71d5-432b-b047-9fef7bc8b101'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''178d63d3-84de-414f-8abb-b9ed14965b74'',''ca0d8f42-71d5-432b-b047-9fef7bc8b101'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''47340256-8975-43ca-b89b-bb87cfeb662a'' AND GUID_ObjectReference=''72271efb-49f0-40e6-8f6a-20bf0b1c0996'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''47340256-8975-43ca-b89b-bb87cfeb662a'',''72271efb-49f0-40e6-8f6a-20bf0b1c0996'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'' AND GUID_ObjectReference=''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'',''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ebe3987c-7845-47ab-a1f6-c6d8e3a12658'' AND GUID_ObjectReference=''89c4e35e-c8fd-4beb-a6a6-48990442efe6'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ebe3987c-7845-47ab-a1f6-c6d8e3a12658'',''89c4e35e-c8fd-4beb-a6a6-48990442efe6'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ea69a5ce-6242-42b7-80a2-c91ae1b59524'' AND GUID_ObjectReference=''7de4606d-dddd-431d-92c2-928f5eb851c4'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ea69a5ce-6242-42b7-80a2-c91ae1b59524'',''7de4606d-dddd-431d-92c2-928f5eb851c4'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8618f96e-8494-432a-99da-cc91e6c117d5'' AND GUID_ObjectReference=''c09ca6bf-b5fb-4121-b169-d389981a2ad4'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8618f96e-8494-432a-99da-cc91e6c117d5'',''c09ca6bf-b5fb-4121-b169-d389981a2ad4'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''594ef5cd-f083-4a78-8a5d-d0aabee43967'' AND GUID_ObjectReference=''4fdbc15a-7211-4dce-92af-40f3caf3916a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''594ef5cd-f083-4a78-8a5d-d0aabee43967'',''4fdbc15a-7211-4dce-92af-40f3caf3916a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''935bd858-2d0b-4b96-a581-d51fbb6e5e37'' AND GUID_ObjectReference=''7babbe69-d349-4ef8-9e12-8bfbe6af815f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''935bd858-2d0b-4b96-a581-d51fbb6e5e37'',''7babbe69-d349-4ef8-9e12-8bfbe6af815f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'' AND GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''99d858e8-2a38-458e-834c-daec118523e2'' AND GUID_ObjectReference=''d251cf80-30d7-404c-8f68-4926d0efad3e'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''99d858e8-2a38-458e-834c-daec118523e2'',''d251cf80-30d7-404c-8f68-4926d0efad3e'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3e0274d6-ea91-488f-b8cb-e1212d74b7c9'' AND GUID_ObjectReference=''655bd8d3-cd88-4e10-bce4-b952205f8130'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3e0274d6-ea91-488f-b8cb-e1212d74b7c9'',''655bd8d3-cd88-4e10-bce4-b952205f8130'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''2743e551-64bb-43d7-8c4f-e65f4ab849b9'' AND GUID_ObjectReference=''18a75b98-b3c3-4ddc-847a-848176079e09'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''2743e551-64bb-43d7-8c4f-e65f4ab849b9'',''18a75b98-b3c3-4ddc-847a-848176079e09'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3489349e-4805-40ad-ac54-ed6348092fbb'' AND GUID_ObjectReference=''0685fe36-17ef-43ad-9c90-fe202ae20f4e'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3489349e-4805-40ad-ac54-ed6348092fbb'',''0685fe36-17ef-43ad-9c90-fe202ae20f4e'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''a6faac99-d3db-4df8-8e45-f177b5bf915e'' AND GUID_ObjectReference=''15c98e13-ec0f-44fa-bc76-abc87189d04f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''a6faac99-d3db-4df8-8e45-f177b5bf915e'',''15c98e13-ec0f-44fa-bc76-abc87189d04f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''444bb9bc-5d80-4911-a6fb-f1c67fe34380'' AND GUID_ObjectReference=''bf64e808-bb40-4587-9fc2-8ae2b4896558'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''444bb9bc-5d80-4911-a6fb-f1c67fe34380'',''bf64e808-bb40-4587-9fc2-8ae2b4896558'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''9af3ab0d-10bb-428a-8be6-f37e7f0da912'' AND GUID_ObjectReference=''840bcc61-eae8-4c9c-8cb3-ed38a95f6be5'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''9af3ab0d-10bb-428a-8be6-f37e7f0da912'',''840bcc61-eae8-4c9c-8cb3-ed38a95f6be5'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ba16c8e8-a814-4f36-b33f-f5dd8a2f4e16'' AND GUID_ObjectReference=''0db4a03a-2d87-4033-834a-50b9274b453e'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ba16c8e8-a814-4f36-b33f-f5dd8a2f4e16'',''0db4a03a-2d87-4033-834a-50b9274b453e'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''13c09f11-175c-4eef-bc8a-0fd8e86d557f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''13c09f11-175c-4eef-bc8a-0fd8e86d557f'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1)'
GO
