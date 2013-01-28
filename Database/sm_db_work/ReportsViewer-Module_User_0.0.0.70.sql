use [sem_db_work]
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='73e32abf-e577-4d31-9a46-bc07e9e15de3') = 0
	insert into semtbl_Type VALUES('73e32abf-e577-4d31-9a46-bc07e9e15de3','Software-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c4a54bf0-a674-4b91-806b-aa886d4bbc0d'') = 0
	insert into semtbl_Token VALUES(''c4a54bf0-a674-4b91-806b-aa886d4bbc0d'',''View'',''7fd09ae5-cfda-42dd-bbfb-ed5d1376e4b8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9254644c-bb1b-4cdb-b288-a7c5db19b5a5'') = 0
	insert into semtbl_Token VALUES(''9254644c-bb1b-4cdb-b288-a7c5db19b5a5'',''bigint'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b0c36c12-7c8f-4b6d-904e-0ca300d909c4'') = 0
	insert into semtbl_Token VALUES(''b0c36c12-7c8f-4b6d-904e-0ca300d909c4'',''binary'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e14946c4-c8fe-4775-ab93-2caac15bbb47'') = 0
	insert into semtbl_Token VALUES(''e14946c4-c8fe-4775-ab93-2caac15bbb47'',''bit'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''420f5f7d-353e-4640-8db8-c0672949a541'') = 0
	insert into semtbl_Token VALUES(''420f5f7d-353e-4640-8db8-c0672949a541'',''char'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0553c5f4-8f52-4ad5-93e9-008f4bf92352'') = 0
	insert into semtbl_Token VALUES(''0553c5f4-8f52-4ad5-93e9-008f4bf92352'',''date'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7f3b2329-f187-4727-a211-3c11d1ddb581'') = 0
	insert into semtbl_Token VALUES(''7f3b2329-f187-4727-a211-3c11d1ddb581'',''datetime'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fa898772-8b80-4f8d-a1aa-78532e16ede9'') = 0
	insert into semtbl_Token VALUES(''fa898772-8b80-4f8d-a1aa-78532e16ede9'',''datetime2'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''707d57cf-b720-4685-9f48-db5b0b6786f5'') = 0
	insert into semtbl_Token VALUES(''707d57cf-b720-4685-9f48-db5b0b6786f5'',''datetimeoffset'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a5a962bb-463a-4061-b2c4-ee6e4f58f092'') = 0
	insert into semtbl_Token VALUES(''a5a962bb-463a-4061-b2c4-ee6e4f58f092'',''decimal'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f17d382b-2075-463d-9ca3-3133eef967fe'') = 0
	insert into semtbl_Token VALUES(''f17d382b-2075-463d-9ca3-3133eef967fe'',''float'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''89d91b20-31b4-43ed-9d30-80cd62a5f110'') = 0
	insert into semtbl_Token VALUES(''89d91b20-31b4-43ed-9d30-80cd62a5f110'',''geography'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''daca71af-177f-4f6b-a91f-c5b670365661'') = 0
	insert into semtbl_Token VALUES(''daca71af-177f-4f6b-a91f-c5b670365661'',''geometry'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0d10e858-967f-4aeb-87df-73eb7dadd960'') = 0
	insert into semtbl_Token VALUES(''0d10e858-967f-4aeb-87df-73eb7dadd960'',''hierarchyid'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''05158d76-fdd4-4816-b6f7-86df975bca16'') = 0
	insert into semtbl_Token VALUES(''05158d76-fdd4-4816-b6f7-86df975bca16'',''image'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5e45dcd9-e013-4d56-8c17-a94906114f35'') = 0
	insert into semtbl_Token VALUES(''5e45dcd9-e013-4d56-8c17-a94906114f35'',''int'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9ef70b5b-a316-4f82-b701-ee656f64e8f6'') = 0
	insert into semtbl_Token VALUES(''9ef70b5b-a316-4f82-b701-ee656f64e8f6'',''money'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8937e508-573d-473a-993a-0ae0537c23cd'') = 0
	insert into semtbl_Token VALUES(''8937e508-573d-473a-993a-0ae0537c23cd'',''nchar'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c62a680a-b006-4193-a4eb-92dd3731f81a'') = 0
	insert into semtbl_Token VALUES(''c62a680a-b006-4193-a4eb-92dd3731f81a'',''ntext'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e2add4cb-7a1c-42ea-861f-812add86e87b'') = 0
	insert into semtbl_Token VALUES(''e2add4cb-7a1c-42ea-861f-812add86e87b'',''numeric'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a01d0f9c-b33f-4166-8a21-ec5b3ea36550'') = 0
	insert into semtbl_Token VALUES(''a01d0f9c-b33f-4166-8a21-ec5b3ea36550'',''nvarchar'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''74334c82-bcc5-4079-8806-942dac3292a8'') = 0
	insert into semtbl_Token VALUES(''74334c82-bcc5-4079-8806-942dac3292a8'',''real'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''beb1e9b8-6553-4f93-a677-2b6100ef98a2'') = 0
	insert into semtbl_Token VALUES(''beb1e9b8-6553-4f93-a677-2b6100ef98a2'',''smalldatetime'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7782c1b7-88e2-47c3-89c3-b57ec0e1029c'') = 0
	insert into semtbl_Token VALUES(''7782c1b7-88e2-47c3-89c3-b57ec0e1029c'',''smallint'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4b28a208-0de5-4e32-882a-b1b07445d7b0'') = 0
	insert into semtbl_Token VALUES(''4b28a208-0de5-4e32-882a-b1b07445d7b0'',''smallmoney'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3a30f660-3736-4ae8-9439-aacc9826e10d'') = 0
	insert into semtbl_Token VALUES(''3a30f660-3736-4ae8-9439-aacc9826e10d'',''sql_variant'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''044d6b04-9cdf-4859-87ad-4f18f57ee220'') = 0
	insert into semtbl_Token VALUES(''044d6b04-9cdf-4859-87ad-4f18f57ee220'',''sysname'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d88bc81e-d695-415c-a4d3-411333357b86'') = 0
	insert into semtbl_Token VALUES(''d88bc81e-d695-415c-a4d3-411333357b86'',''text'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''28f42e6b-d443-434c-bc52-a8fccd1e6af0'') = 0
	insert into semtbl_Token VALUES(''28f42e6b-d443-434c-bc52-a8fccd1e6af0'',''time'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''015d9b17-4e34-4c97-9685-06a53a37ebb1'') = 0
	insert into semtbl_Token VALUES(''015d9b17-4e34-4c97-9685-06a53a37ebb1'',''timestamp'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7b9d3db2-2ea8-4b4e-95a6-0d892892115d'') = 0
	insert into semtbl_Token VALUES(''7b9d3db2-2ea8-4b4e-95a6-0d892892115d'',''tinyint'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b4aaa076-ff82-4d5c-8dd8-efe52447a328'') = 0
	insert into semtbl_Token VALUES(''b4aaa076-ff82-4d5c-8dd8-efe52447a328'',''uniqueidentifier'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c39e1c4e-f4cb-41d2-822d-7dcedb06627f'') = 0
	insert into semtbl_Token VALUES(''c39e1c4e-f4cb-41d2-822d-7dcedb06627f'',''varbinary'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d50c2786-294b-4adb-b7e1-c0227446c11e'') = 0
	insert into semtbl_Token VALUES(''d50c2786-294b-4adb-b7e1-c0227446c11e'',''varchar'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''00d80104-6738-46bc-8254-38bfbd4c3161'') = 0
	insert into semtbl_Token VALUES(''00d80104-6738-46bc-8254-38bfbd4c3161'',''xml'',''9e4bbf04-0394-4041-94c0-9b07da7281db'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b5264acf-1f53-48e5-8845-36afcd3f386d'') = 0
	insert into semtbl_Token VALUES(''b5264acf-1f53-48e5-8845-36afcd3f386d'',''C2'',''c0ae3680-18a8-41d9-9238-91505eb2a0ce'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''79dad07f-a205-46fc-80b4-5666d47f56df'') = 0
	insert into semtbl_Token VALUES(''79dad07f-a205-46fc-80b4-5666d47f56df'',''!='',''74aef11b-e102-4cb4-8ca9-3d8ea0fa30a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ac0811d0-9e86-4591-a1f0-7fd7825497f6'') = 0
	insert into semtbl_Token VALUES(''ac0811d0-9e86-4591-a1f0-7fd7825497f6'',''<'',''74aef11b-e102-4cb4-8ca9-3d8ea0fa30a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''40e931e8-ce3e-4f8c-8bf9-22f4a7fb4380'') = 0
	insert into semtbl_Token VALUES(''40e931e8-ce3e-4f8c-8bf9-22f4a7fb4380'',''<='',''74aef11b-e102-4cb4-8ca9-3d8ea0fa30a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a63330e1-7c54-4204-8102-ad978ba485d5'') = 0
	insert into semtbl_Token VALUES(''a63330e1-7c54-4204-8102-ad978ba485d5'',''='',''74aef11b-e102-4cb4-8ca9-3d8ea0fa30a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''29cd70b7-3e97-4d86-81cb-50b66df6cd28'') = 0
	insert into semtbl_Token VALUES(''29cd70b7-3e97-4d86-81cb-50b66df6cd28'',''>'',''74aef11b-e102-4cb4-8ca9-3d8ea0fa30a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''34eaefa8-12b7-45c2-bc82-2691bfa48ef5'') = 0
	insert into semtbl_Token VALUES(''34eaefa8-12b7-45c2-bc82-2691bfa48ef5'',''>='',''74aef11b-e102-4cb4-8ca9-3d8ea0fa30a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5383e8fa-ee8f-4002-9cd5-21861d9c3d1f'') = 0
	insert into semtbl_Token VALUES(''5383e8fa-ee8f-4002-9cd5-21861d9c3d1f'',''And'',''278365e9-37a2-448b-b96f-b4cbc97f07b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e0d372e7-f4cd-45c2-87e9-576c968edf67'') = 0
	insert into semtbl_Token VALUES(''e0d372e7-f4cd-45c2-87e9-576c968edf67'',''Or'',''278365e9-37a2-448b-b96f-b4cbc97f07b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6e431702-1209-4199-bcb0-daa9a55f134f'') = 0
	insert into semtbl_Token VALUES(''6e431702-1209-4199-bcb0-daa9a55f134f'',''Xor'',''278365e9-37a2-448b-b96f-b4cbc97f07b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d5474c74-f70e-4916-98f6-4e3d3831c1f9'' AND GUID_Token_Right=''8937e508-573d-473a-993a-0ae0537c23cd'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d5474c74-f70e-4916-98f6-4e3d3831c1f9'',''8937e508-573d-473a-993a-0ae0537c23cd'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d5474c74-f70e-4916-98f6-4e3d3831c1f9'' AND GUID_Token_Right=''e14946c4-c8fe-4775-ab93-2caac15bbb47'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d5474c74-f70e-4916-98f6-4e3d3831c1f9'',''e14946c4-c8fe-4775-ab93-2caac15bbb47'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d5474c74-f70e-4916-98f6-4e3d3831c1f9'' AND GUID_Token_Right=''d88bc81e-d695-415c-a4d3-411333357b86'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d5474c74-f70e-4916-98f6-4e3d3831c1f9'',''d88bc81e-d695-415c-a4d3-411333357b86'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d5474c74-f70e-4916-98f6-4e3d3831c1f9'' AND GUID_Token_Right=''044d6b04-9cdf-4859-87ad-4f18f57ee220'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d5474c74-f70e-4916-98f6-4e3d3831c1f9'',''044d6b04-9cdf-4859-87ad-4f18f57ee220'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d5474c74-f70e-4916-98f6-4e3d3831c1f9'' AND GUID_Token_Right=''c62a680a-b006-4193-a4eb-92dd3731f81a'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d5474c74-f70e-4916-98f6-4e3d3831c1f9'',''c62a680a-b006-4193-a4eb-92dd3731f81a'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d5474c74-f70e-4916-98f6-4e3d3831c1f9'' AND GUID_Token_Right=''d50c2786-294b-4adb-b7e1-c0227446c11e'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d5474c74-f70e-4916-98f6-4e3d3831c1f9'',''d50c2786-294b-4adb-b7e1-c0227446c11e'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d5474c74-f70e-4916-98f6-4e3d3831c1f9'' AND GUID_Token_Right=''420f5f7d-353e-4640-8db8-c0672949a541'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d5474c74-f70e-4916-98f6-4e3d3831c1f9'',''420f5f7d-353e-4640-8db8-c0672949a541'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d5474c74-f70e-4916-98f6-4e3d3831c1f9'' AND GUID_Token_Right=''a01d0f9c-b33f-4166-8a21-ec5b3ea36550'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d5474c74-f70e-4916-98f6-4e3d3831c1f9'',''a01d0f9c-b33f-4166-8a21-ec5b3ea36550'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'' AND GUID_Token_Right=''7b9d3db2-2ea8-4b4e-95a6-0d892892115d'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'',''7b9d3db2-2ea8-4b4e-95a6-0d892892115d'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'' AND GUID_Token_Right=''beb1e9b8-6553-4f93-a677-2b6100ef98a2'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'',''beb1e9b8-6553-4f93-a677-2b6100ef98a2'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'' AND GUID_Token_Right=''f17d382b-2075-463d-9ca3-3133eef967fe'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'',''f17d382b-2075-463d-9ca3-3133eef967fe'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'' AND GUID_Token_Right=''e2add4cb-7a1c-42ea-861f-812add86e87b'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'',''e2add4cb-7a1c-42ea-861f-812add86e87b'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'' AND GUID_Token_Right=''74334c82-bcc5-4079-8806-942dac3292a8'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'',''74334c82-bcc5-4079-8806-942dac3292a8'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'' AND GUID_Token_Right=''9254644c-bb1b-4cdb-b288-a7c5db19b5a5'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'',''9254644c-bb1b-4cdb-b288-a7c5db19b5a5'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'' AND GUID_Token_Right=''5e45dcd9-e013-4d56-8c17-a94906114f35'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'',''5e45dcd9-e013-4d56-8c17-a94906114f35'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'' AND GUID_Token_Right=''4b28a208-0de5-4e32-882a-b1b07445d7b0'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'',''4b28a208-0de5-4e32-882a-b1b07445d7b0'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'' AND GUID_Token_Right=''7782c1b7-88e2-47c3-89c3-b57ec0e1029c'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'',''7782c1b7-88e2-47c3-89c3-b57ec0e1029c'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'' AND GUID_Token_Right=''9ef70b5b-a316-4f82-b701-ee656f64e8f6'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'',''9ef70b5b-a316-4f82-b701-ee656f64e8f6'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'' AND GUID_Token_Right=''a5a962bb-463a-4061-b2c4-ee6e4f58f092'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'',''a5a962bb-463a-4061-b2c4-ee6e4f58f092'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''38090631-b096-4c3f-be03-cf79d6a537ae'' AND GUID_Token_Right=''015d9b17-4e34-4c97-9685-06a53a37ebb1'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''38090631-b096-4c3f-be03-cf79d6a537ae'',''015d9b17-4e34-4c97-9685-06a53a37ebb1'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''38090631-b096-4c3f-be03-cf79d6a537ae'' AND GUID_Token_Right=''beb1e9b8-6553-4f93-a677-2b6100ef98a2'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''38090631-b096-4c3f-be03-cf79d6a537ae'',''beb1e9b8-6553-4f93-a677-2b6100ef98a2'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''38090631-b096-4c3f-be03-cf79d6a537ae'' AND GUID_Token_Right=''7f3b2329-f187-4727-a211-3c11d1ddb581'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''38090631-b096-4c3f-be03-cf79d6a537ae'',''7f3b2329-f187-4727-a211-3c11d1ddb581'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''38090631-b096-4c3f-be03-cf79d6a537ae'' AND GUID_Token_Right=''fa898772-8b80-4f8d-a1aa-78532e16ede9'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''38090631-b096-4c3f-be03-cf79d6a537ae'',''fa898772-8b80-4f8d-a1aa-78532e16ede9'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''38090631-b096-4c3f-be03-cf79d6a537ae'' AND GUID_Token_Right=''707d57cf-b720-4685-9f48-db5b0b6786f5'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''38090631-b096-4c3f-be03-cf79d6a537ae'',''707d57cf-b720-4685-9f48-db5b0b6786f5'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''c17230e2-d57a-4a11-bea3-14db50a656a6'' AND GUID_Token_Right=''b4aaa076-ff82-4d5c-8dd8-efe52447a328'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Token_Token VALUES(''c17230e2-d57a-4a11-bea3-14db50a656a6'',''b4aaa076-ff82-4d5c-8dd8-efe52447a328'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c441518d-bfe0-4d55-b538-df5c5555dd83'' AND GUID_Type_Right=''3e1587d8-3e35-46dd-9833-41903904254d'' AND GUID_RelationType=''a778c55c-8308-4033-bd33-30ebd7347485'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c441518d-bfe0-4d55-b538-df5c5555dd83'',''3e1587d8-3e35-46dd-9833-41903904254d'',''a778c55c-8308-4033-bd33-30ebd7347485'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_RelationType=''4f8f29b4-49bb-4d85-a65f-205d2af4f509'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''4f8f29b4-49bb-4d85-a65f-205d2af4f509'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''8a894710-e08c-42c5-b829-ef4809830d33'' AND GUID_RelationType=''be8c7e8f-9b0b-4adc-8f0b-8f8f1ae47f87'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''8a894710-e08c-42c5-b829-ef4809830d33'',''be8c7e8f-9b0b-4adc-8f0b-8f8f1ae47f87'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9403650d-2a28-4a0d-9a7f-f1d893960701'' AND GUID_Type_Right=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_RelationType=''18004521-0c12-4b85-80c3-4af08ef9d444'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9403650d-2a28-4a0d-9a7f-f1d893960701'',''327e9773-fca6-458c-a44d-338a556e0ad9'',''18004521-0c12-4b85-80c3-4af08ef9d444'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'' AND GUID_Type_Right=''9e4bbf04-0394-4041-94c0-9b07da7281db'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Type_Type VALUES(''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'',''9e4bbf04-0394-4041-94c0-9b07da7281db'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1,-1,-1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1)'
GO
