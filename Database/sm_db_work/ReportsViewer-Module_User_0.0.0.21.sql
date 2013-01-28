use [sem_db_work]
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''d4ea61d7-ec98-484d-a1cd-cd02d41cd0d3'') = 0
	insert into semtbl_Attribute VALUES(''d4ea61d7-ec98-484d-a1cd-cd02d41cd0d3'',''invisible'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''d777cd8b-b212-4f83-b67e-da8586f97eca'') = 0
	insert into semtbl_Attribute VALUES(''d777cd8b-b212-4f83-b67e-da8586f97eca'',''is Sem-DB'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''d5d5eb28-e26e-4845-846b-48701fb5ca26'') = 0
	insert into semtbl_Attribute VALUES(''d5d5eb28-e26e-4845-846b-48701fb5ca26'',''is exported'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	insert into semtbl_RelationType VALUES(''3e104b75-e01c-48a0-b041-12908fd446a0'',''is'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	insert into semtbl_RelationType VALUES(''e9711603-47db-44d8-a476-fe88290639a4'',''contains'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	insert into semtbl_RelationType VALUES(''9996494a-ef6a-4357-a6ef-71a92b5ff596'',''is of Type'')'
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='7fd09ae5-cfda-42dd-bbfb-ed5d1376e4b8') = 0
	insert into semtbl_Type VALUES('7fd09ae5-cfda-42dd-bbfb-ed5d1376e4b8','Report-Type','30cbc6e8-9c0f-47d6-920c-97fdc40ea1de')
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='2f05c250-be33-4b77-ba3c-b8a0228821b6') = 0
	insert into semtbl_Type VALUES('2f05c250-be33-4b77-ba3c-b8a0228821b6','Filesystem-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='6eb4fdd3-2e25-4886-b288-e1bfc2857efb') = 0
	insert into semtbl_Type VALUES('6eb4fdd3-2e25-4886-b288-e1bfc2857efb','File','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='d7a03a35-8751-42b4-8e05-19fc7a77ee91') = 0
	insert into semtbl_Type VALUES('d7a03a35-8751-42b4-8e05-19fc7a77ee91','Server','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''01881cf9-9f24-4092-9a53-fe13f67eb5ef'') = 0
	insert into semtbl_Token VALUES(''01881cf9-9f24-4092-9a53-fe13f67eb5ef'',''File'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d5474c74-f70e-4916-98f6-4e3d3831c1f9'') = 0
	insert into semtbl_Token VALUES(''d5474c74-f70e-4916-98f6-4e3d3831c1f9'',''Text'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''53e3a800-7eb7-424a-beac-bbd930916c26'') = 0
	insert into semtbl_Token VALUES(''53e3a800-7eb7-424a-beac-bbd930916c26'',''Password'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c7781ee8-d681-4d76-954a-58982327b57d'') = 0
	insert into semtbl_Token VALUES(''c7781ee8-d681-4d76-954a-58982327b57d'',''Token-Report'',''7fd09ae5-cfda-42dd-bbfb-ed5d1376e4b8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''eadc5618-e3ee-464f-9247-a22b270afd93'') = 0
	insert into semtbl_Token VALUES(''eadc5618-e3ee-464f-9247-a22b270afd93'',''Url'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c17230e2-d57a-4a11-bea3-14db50a656a6'') = 0
	insert into semtbl_Token VALUES(''c17230e2-d57a-4a11-bea3-14db50a656a6'',''GUID'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c4a54bf0-a674-4b91-806b-aa886d4bbc0d'') = 0
	insert into semtbl_Token VALUES(''c4a54bf0-a674-4b91-806b-aa886d4bbc0d'',''View'',''7fd09ae5-cfda-42dd-bbfb-ed5d1376e4b8'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''9403650d-2a28-4a0d-9a7f-f1d893960701'' AND GUID_Attribute=''d5d5eb28-e26e-4845-846b-48701fb5ca26'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''9403650d-2a28-4a0d-9a7f-f1d893960701'',''d5d5eb28-e26e-4845-846b-48701fb5ca26'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6c5cd901-b9a1-4775-a522-3f776fbe0c8a'' AND GUID_Attribute=''d5d5eb28-e26e-4845-846b-48701fb5ca26'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6c5cd901-b9a1-4775-a522-3f776fbe0c8a'',''d5d5eb28-e26e-4845-846b-48701fb5ca26'',0,1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9053d6ad-8ebb-4f68-bfb0-285d8b38a170'' AND GUID_Type_Right=''6c5cd901-b9a1-4775-a522-3f776fbe0c8a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9053d6ad-8ebb-4f68-bfb0-285d8b38a170'',''6c5cd901-b9a1-4775-a522-3f776fbe0c8a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9053d6ad-8ebb-4f68-bfb0-285d8b38a170'' AND GUID_Type_Right=''9403650d-2a28-4a0d-9a7f-f1d893960701'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9053d6ad-8ebb-4f68-bfb0-285d8b38a170'',''9403650d-2a28-4a0d-9a7f-f1d893960701'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_Type_Right=''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'' AND GUID_RelationType=''0fa056ea-474f-424f-ab68-0a10b57d3a95'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'',''0fa056ea-474f-424f-ab68-0a10b57d3a95'',0,1,-1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_RelationType=''4f8f29b4-49bb-4d85-a65f-205d2af4f509'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''4f8f29b4-49bb-4d85-a65f-205d2af4f509'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1)'
GO
