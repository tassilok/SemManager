execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''d4ea61d7-ec98-484d-a1cd-cd02d41cd0d3'') = 0
	insert into semtbl_Attribute VALUES(''d4ea61d7-ec98-484d-a1cd-cd02d41cd0d3'',''invisible'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e13a1b73-8c00-4677-922e-32b36188786f'') = 0
	insert into semtbl_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''ReportsViewer-Module'',''c6c9bcb8-0ac9-4713-9417-eeec1453026c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f40e5133-f876-42c7-ab40-c8c602f8884c'') = 0
	insert into semtbl_Token VALUES(''f40e5133-f876-42c7-ab40-c8c602f8884c'',''ReportsViewer-Module'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d29b56cd-cdad-4b46-af59-0464909864b6'') = 0
	insert into semtbl_Token VALUES(''d29b56cd-cdad-4b46-af59-0464909864b6'',''Type_Field_Type'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7c73559d-0a69-4ee3-8fd9-1a44b11a1089'') = 0
	insert into semtbl_Token VALUES(''7c73559d-0a69-4ee3-8fd9-1a44b11a1089'',''Type_Report_Type'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'') = 0
	insert into semtbl_Token VALUES(''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'',''Type_Database'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8fd7d742-9a60-4a9d-9d16-32c04632893d'') = 0
	insert into semtbl_Token VALUES(''8fd7d742-9a60-4a9d-9d16-32c04632893d'',''Type_DB_Procedure'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''747952da-2e66-49c1-8462-3a20addbc0ef'') = 0
	insert into semtbl_Token VALUES(''747952da-2e66-49c1-8462-3a20addbc0ef'',''RelationType_is'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7c57bd11-55b1-437b-98b5-3d9ac401ac78'') = 0
	insert into semtbl_Token VALUES(''7c57bd11-55b1-437b-98b5-3d9ac401ac78'',''Token_Field_Type_File'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3c2fb8fa-b8bf-4930-bc5c-4817f8b1ad40'') = 0
	insert into semtbl_Token VALUES(''3c2fb8fa-b8bf-4930-bc5c-4817f8b1ad40'',''Type_DB_Views'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''49716d39-9cc8-45c3-8b81-54ad7429881f'') = 0
	insert into semtbl_Token VALUES(''49716d39-9cc8-45c3-8b81-54ad7429881f'',''Token_Field_Type_Text'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''765108ea-65a4-41f5-a95a-54bf4fd3effc'') = 0
	insert into semtbl_Token VALUES(''765108ea-65a4-41f5-a95a-54bf4fd3effc'',''Token_Field_Type_Zahl'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7c76114a-6a68-42aa-b9ce-5fd0d8a02eff'') = 0
	insert into semtbl_Token VALUES(''7c76114a-6a68-42aa-b9ce-5fd0d8a02eff'',''Attribute_invisible'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6c966e3c-c737-4af1-9970-68c8323679bc'') = 0
	insert into semtbl_Token VALUES(''6c966e3c-c737-4af1-9970-68c8323679bc'',''RelationType_contains'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'') = 0
	insert into semtbl_Token VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''attribute_dbPostfix'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6e494944-f602-4dcb-906f-70e5efe8f1dd'') = 0
	insert into semtbl_Token VALUES(''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''RelationType_is_of_Type'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d5d571dd-b9b2-4249-ae1b-75456a1ac504'') = 0
	insert into semtbl_Token VALUES(''d5d571dd-b9b2-4249-ae1b-75456a1ac504'',''Token_Field_Type_Password'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c7619aac-483f-4cec-be37-8c6495fbc2b7'') = 0
	insert into semtbl_Token VALUES(''c7619aac-483f-4cec-be37-8c6495fbc2b7'',''Type_Report_Field'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cf0f52ac-1e00-45f4-ae02-8d6d3a920b59'') = 0
	insert into semtbl_Token VALUES(''cf0f52ac-1e00-45f4-ae02-8d6d3a920b59'',''Token_Report_Type_Token_Report'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d3101831-962d-4069-a96d-94fcfc234651'') = 0
	insert into semtbl_Token VALUES(''d3101831-962d-4069-a96d-94fcfc234651'',''Type_DB_Columns'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4dc737aa-1a62-459b-b724-a21ea29683b6'') = 0
	insert into semtbl_Token VALUES(''4dc737aa-1a62-459b-b724-a21ea29683b6'',''Token_Field_Type_Url'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3186cc5e-023b-4edc-b6c7-a89919320839'') = 0
	insert into semtbl_Token VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''RelationType_belongsTo'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5a778c64-4bcc-4faf-bdba-aaa01092f200'') = 0
	insert into semtbl_Token VALUES(''5a778c64-4bcc-4faf-bdba-aaa01092f200'',''RelationType_leads'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f1ba23ed-ab41-4d34-8e09-b4e485671478'') = 0
	insert into semtbl_Token VALUES(''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''Type_File'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''178d63d3-84de-414f-8abb-b9ed14965b74'') = 0
	insert into semtbl_Token VALUES(''178d63d3-84de-414f-8abb-b9ed14965b74'',''Type_Reports'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'') = 0
	insert into semtbl_Token VALUES(''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'',''Type_Database_on_Server'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8618f96e-8494-432a-99da-cc91e6c117d5'') = 0
	insert into semtbl_Token VALUES(''8618f96e-8494-432a-99da-cc91e6c117d5'',''RelationType_located_in'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'') = 0
	insert into semtbl_Token VALUES(''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''Type_Server'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a6faac99-d3db-4df8-8e45-f177b5bf915e'') = 0
	insert into semtbl_Token VALUES(''a6faac99-d3db-4df8-8e45-f177b5bf915e'',''Token_Field_Type_GUID'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ba16c8e8-a814-4f36-b33f-f5dd8a2f4e16'') = 0
	insert into semtbl_Token VALUES(''ba16c8e8-a814-4f36-b33f-f5dd8a2f4e16'',''Token_Report_Type_View'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''01881cf9-9f24-4092-9a53-fe13f67eb5ef'') = 0
	insert into semtbl_Token VALUES(''01881cf9-9f24-4092-9a53-fe13f67eb5ef'',''File'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d5474c74-f70e-4916-98f6-4e3d3831c1f9'') = 0
	insert into semtbl_Token VALUES(''d5474c74-f70e-4916-98f6-4e3d3831c1f9'',''Text'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'') = 0
	insert into semtbl_Token VALUES(''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'',''Zahl'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''d29b56cd-cdad-4b46-af59-0464909864b6'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''d29b56cd-cdad-4b46-af59-0464909864b6'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''7c73559d-0a69-4ee3-8fd9-1a44b11a1089'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''7c73559d-0a69-4ee3-8fd9-1a44b11a1089'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''8fd7d742-9a60-4a9d-9d16-32c04632893d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''8fd7d742-9a60-4a9d-9d16-32c04632893d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''747952da-2e66-49c1-8462-3a20addbc0ef'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''747952da-2e66-49c1-8462-3a20addbc0ef'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''7c57bd11-55b1-437b-98b5-3d9ac401ac78'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''7c57bd11-55b1-437b-98b5-3d9ac401ac78'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''3c2fb8fa-b8bf-4930-bc5c-4817f8b1ad40'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''3c2fb8fa-b8bf-4930-bc5c-4817f8b1ad40'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''49716d39-9cc8-45c3-8b81-54ad7429881f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''49716d39-9cc8-45c3-8b81-54ad7429881f'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''765108ea-65a4-41f5-a95a-54bf4fd3effc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''765108ea-65a4-41f5-a95a-54bf4fd3effc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''7c76114a-6a68-42aa-b9ce-5fd0d8a02eff'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''7c76114a-6a68-42aa-b9ce-5fd0d8a02eff'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''6c966e3c-c737-4af1-9970-68c8323679bc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''6c966e3c-c737-4af1-9970-68c8323679bc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''6e494944-f602-4dcb-906f-70e5efe8f1dd'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''d5d571dd-b9b2-4249-ae1b-75456a1ac504'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''d5d571dd-b9b2-4249-ae1b-75456a1ac504'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''c7619aac-483f-4cec-be37-8c6495fbc2b7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''c7619aac-483f-4cec-be37-8c6495fbc2b7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''cf0f52ac-1e00-45f4-ae02-8d6d3a920b59'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''cf0f52ac-1e00-45f4-ae02-8d6d3a920b59'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''d3101831-962d-4069-a96d-94fcfc234651'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''d3101831-962d-4069-a96d-94fcfc234651'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''4dc737aa-1a62-459b-b724-a21ea29683b6'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''4dc737aa-1a62-459b-b724-a21ea29683b6'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''3186cc5e-023b-4edc-b6c7-a89919320839'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''5a778c64-4bcc-4faf-bdba-aaa01092f200'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''5a778c64-4bcc-4faf-bdba-aaa01092f200'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''f1ba23ed-ab41-4d34-8e09-b4e485671478'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''178d63d3-84de-414f-8abb-b9ed14965b74'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''178d63d3-84de-414f-8abb-b9ed14965b74'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''8618f96e-8494-432a-99da-cc91e6c117d5'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''8618f96e-8494-432a-99da-cc91e6c117d5'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e13a1b73-8c00-4677-922e-32b36188786f'' AND GUID_Token_Right=''a6faac99-d3db-4df8-8e45-f177b5bf915e'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e13a1b73-8c00-4677-922e-32b36188786f'',''a6faac99-d3db-4df8-8e45-f177b5bf915e'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c6c9bcb8-0ac9-4713-9417-eeec1453026c'' AND GUID_Type_Right=''13c09f11-175c-4eef-bc8a-0fd8e86d557f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c6c9bcb8-0ac9-4713-9417-eeec1453026c'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''c6c9bcb8-0ac9-4713-9417-eeec1453026c'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''c6c9bcb8-0ac9-4713-9417-eeec1453026c'',''fafc1464-815f-4596-9737-bcbc96bd744a'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''408db9f1-ae42-4807-b656-729270646f0a'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e39f270d-faab-4556-a1dc-655f1443a7e4'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e39f270d-faab-4556-a1dc-655f1443a7e4'',''f40e5133-f876-42c7-ab40-c8c602f8884c'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Varchar255 WHERE GUID_TokenAttribute=''e39f270d-faab-4556-a1dc-655f1443a7e4'' )=0
	INSERT INTO semtbl_Token_Attribute_Varchar255 VALUES(''e39f270d-faab-4556-a1dc-655f1443a7e4'',''reportsviewer_module'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'')=0
	INSERT INTO semtbl_OR VALUES(''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''70749d99-5266-4379-8c11-62e3a3bd3360'')=0
	INSERT INTO semtbl_OR VALUES(''70749d99-5266-4379-8c11-62e3a3bd3360'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''93ab0ef5-fb55-41aa-862e-79e161c2052c'')=0
	INSERT INTO semtbl_OR VALUES(''93ab0ef5-fb55-41aa-862e-79e161c2052c'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''58948066-2997-4573-b267-554a734fd141'')=0
	INSERT INTO semtbl_OR VALUES(''58948066-2997-4573-b267-554a734fd141'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''98f5d1eb-3a56-4083-a51b-8fa68a184c09'')=0
	INSERT INTO semtbl_OR VALUES(''98f5d1eb-3a56-4083-a51b-8fa68a184c09'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''983b4404-e7f6-46bd-8f93-4829bef1b10c'')=0
	INSERT INTO semtbl_OR VALUES(''983b4404-e7f6-46bd-8f93-4829bef1b10c'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6492175f-d7f3-4bfc-b1a3-f59eca48d6be'')=0
	INSERT INTO semtbl_OR VALUES(''6492175f-d7f3-4bfc-b1a3-f59eca48d6be'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''50d23921-5da1-404a-9bf5-89dcf5c452cb'')=0
	INSERT INTO semtbl_OR VALUES(''50d23921-5da1-404a-9bf5-89dcf5c452cb'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e769da11-8b4d-4929-8aec-c387d9b94c19'')=0
	INSERT INTO semtbl_OR VALUES(''e769da11-8b4d-4929-8aec-c387d9b94c19'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''baee993b-0a3d-4a4f-a95c-0a074e9f073b'')=0
	INSERT INTO semtbl_OR VALUES(''baee993b-0a3d-4a4f-a95c-0a074e9f073b'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'')=0
	INSERT INTO semtbl_OR VALUES(''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'')=0
	INSERT INTO semtbl_OR VALUES(''008817a6-14e7-4295-9a69-6835575ae53b'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''1d2c70a3-57fe-4237-99a2-1503303715cf'')=0
	INSERT INTO semtbl_OR VALUES(''1d2c70a3-57fe-4237-99a2-1503303715cf'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8850a46d-8d2c-4500-ab68-def664bd1a3b'')=0
	INSERT INTO semtbl_OR VALUES(''8850a46d-8d2c-4500-ab68-def664bd1a3b'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''f4c859c5-7633-443b-b235-3b8eae694e59'')=0
	INSERT INTO semtbl_OR VALUES(''f4c859c5-7633-443b-b235-3b8eae694e59'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b0f72e18-4d2b-4990-b98a-e7eef4fe5b3a'')=0
	INSERT INTO semtbl_OR VALUES(''b0f72e18-4d2b-4990-b98a-e7eef4fe5b3a'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6b21fda2-2004-4c97-92e8-38c041af70f8'')=0
	INSERT INTO semtbl_OR VALUES(''6b21fda2-2004-4c97-92e8-38c041af70f8'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'')=0
	INSERT INTO semtbl_OR VALUES(''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''04499b6b-4d2c-4ba4-8ae8-a6b68fecdda1'')=0
	INSERT INTO semtbl_OR VALUES(''04499b6b-4d2c-4ba4-8ae8-a6b68fecdda1'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'')=0
	INSERT INTO semtbl_OR VALUES(''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ca0d8f42-71d5-432b-b047-9fef7bc8b101'')=0
	INSERT INTO semtbl_OR VALUES(''ca0d8f42-71d5-432b-b047-9fef7bc8b101'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'')=0
	INSERT INTO semtbl_OR VALUES(''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''c09ca6bf-b5fb-4121-b169-d389981a2ad4'')=0
	INSERT INTO semtbl_OR VALUES(''c09ca6bf-b5fb-4121-b169-d389981a2ad4'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'')=0
	INSERT INTO semtbl_OR VALUES(''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''15c98e13-ec0f-44fa-bc76-abc87189d04f'')=0
	INSERT INTO semtbl_OR VALUES(''15c98e13-ec0f-44fa-bc76-abc87189d04f'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''0db4a03a-2d87-4033-834a-50b9274b453e'')=0
	INSERT INTO semtbl_OR VALUES(''0db4a03a-2d87-4033-834a-50b9274b453e'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'')=0
	INSERT INTO semtbl_OR_Type VALUES(''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'',''a534dc0a-e3c8-4e05-9f86-faaec798f9cc'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''6492175f-d7f3-4bfc-b1a3-f59eca48d6be'')=0
	INSERT INTO semtbl_OR_Type VALUES(''6492175f-d7f3-4bfc-b1a3-f59eca48d6be'',''9403650d-2a28-4a0d-9a7f-f1d893960701'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''8850a46d-8d2c-4500-ab68-def664bd1a3b'')=0
	INSERT INTO semtbl_OR_Type VALUES(''8850a46d-8d2c-4500-ab68-def664bd1a3b'',''c790aa5b-14a4-46b0-bd8c-4317ef5716e2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''b0f72e18-4d2b-4990-b98a-e7eef4fe5b3a'')=0
	INSERT INTO semtbl_OR_Type VALUES(''b0f72e18-4d2b-4990-b98a-e7eef4fe5b3a'',''9053d6ad-8ebb-4f68-bfb0-285d8b38a170'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'')=0
	INSERT INTO semtbl_OR_Type VALUES(''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''ca0d8f42-71d5-432b-b047-9fef7bc8b101'')=0
	INSERT INTO semtbl_OR_Type VALUES(''ca0d8f42-71d5-432b-b047-9fef7bc8b101'',''30cbc6e8-9c0f-47d6-920c-97fdc40ea1de'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'')=0
	INSERT INTO semtbl_OR_Type VALUES(''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'',''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'')=0
	INSERT INTO semtbl_OR_Type VALUES(''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''baee993b-0a3d-4a4f-a95c-0a074e9f073b'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''baee993b-0a3d-4a4f-a95c-0a074e9f073b'',''d4ea61d7-ec98-484d-a1cd-cd02d41cd0d3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''98f5d1eb-3a56-4083-a51b-8fa68a184c09'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''98f5d1eb-3a56-4083-a51b-8fa68a184c09'',''3e104b75-e01c-48a0-b041-12908fd446a0'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''e9711603-47db-44d8-a476-fe88290639a4'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''008817a6-14e7-4295-9a69-6835575ae53b'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''983b4404-e7f6-46bd-8f93-4829bef1b10c'')=0
	INSERT INTO semtbl_OR_Token VALUES(''983b4404-e7f6-46bd-8f93-4829bef1b10c'',''01881cf9-9f24-4092-9a53-fe13f67eb5ef'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''50d23921-5da1-404a-9bf5-89dcf5c452cb'')=0
	INSERT INTO semtbl_OR_Token VALUES(''50d23921-5da1-404a-9bf5-89dcf5c452cb'',''d5474c74-f70e-4916-98f6-4e3d3831c1f9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''e769da11-8b4d-4929-8aec-c387d9b94c19'')=0
	INSERT INTO semtbl_OR_Token VALUES(''e769da11-8b4d-4929-8aec-c387d9b94c19'',''e1ccab17-b2c5-4ff7-8d67-1e8b0bd51a91'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''1d2c70a3-57fe-4237-99a2-1503303715cf'')=0
	INSERT INTO semtbl_OR_Token VALUES(''1d2c70a3-57fe-4237-99a2-1503303715cf'',''53e3a800-7eb7-424a-beac-bbd930916c26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''f4c859c5-7633-443b-b235-3b8eae694e59'')=0
	INSERT INTO semtbl_OR_Token VALUES(''f4c859c5-7633-443b-b235-3b8eae694e59'',''c7781ee8-d681-4d76-954a-58982327b57d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''6b21fda2-2004-4c97-92e8-38c041af70f8'')=0
	INSERT INTO semtbl_OR_Token VALUES(''6b21fda2-2004-4c97-92e8-38c041af70f8'',''eadc5618-e3ee-464f-9247-a22b270afd93'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''15c98e13-ec0f-44fa-bc76-abc87189d04f'')=0
	INSERT INTO semtbl_OR_Token VALUES(''15c98e13-ec0f-44fa-bc76-abc87189d04f'',''c17230e2-d57a-4a11-bea3-14db50a656a6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''0db4a03a-2d87-4033-834a-50b9274b453e'')=0
	INSERT INTO semtbl_OR_Token VALUES(''0db4a03a-2d87-4033-834a-50b9274b453e'',''c4a54bf0-a674-4b91-806b-aa886d4bbc0d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d29b56cd-cdad-4b46-af59-0464909864b6'' AND GUID_ObjectReference=''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d29b56cd-cdad-4b46-af59-0464909864b6'',''8025a36a-66d7-45d9-82ec-c1ca4fa86d32'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''7c73559d-0a69-4ee3-8fd9-1a44b11a1089'' AND GUID_ObjectReference=''70749d99-5266-4379-8c11-62e3a3bd3360'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''7c73559d-0a69-4ee3-8fd9-1a44b11a1089'',''70749d99-5266-4379-8c11-62e3a3bd3360'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'' AND GUID_ObjectReference=''93ab0ef5-fb55-41aa-862e-79e161c2052c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'',''93ab0ef5-fb55-41aa-862e-79e161c2052c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8fd7d742-9a60-4a9d-9d16-32c04632893d'' AND GUID_ObjectReference=''58948066-2997-4573-b267-554a734fd141'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8fd7d742-9a60-4a9d-9d16-32c04632893d'',''58948066-2997-4573-b267-554a734fd141'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''747952da-2e66-49c1-8462-3a20addbc0ef'' AND GUID_ObjectReference=''98f5d1eb-3a56-4083-a51b-8fa68a184c09'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''747952da-2e66-49c1-8462-3a20addbc0ef'',''98f5d1eb-3a56-4083-a51b-8fa68a184c09'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''7c57bd11-55b1-437b-98b5-3d9ac401ac78'' AND GUID_ObjectReference=''983b4404-e7f6-46bd-8f93-4829bef1b10c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''7c57bd11-55b1-437b-98b5-3d9ac401ac78'',''983b4404-e7f6-46bd-8f93-4829bef1b10c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3c2fb8fa-b8bf-4930-bc5c-4817f8b1ad40'' AND GUID_ObjectReference=''6492175f-d7f3-4bfc-b1a3-f59eca48d6be'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3c2fb8fa-b8bf-4930-bc5c-4817f8b1ad40'',''6492175f-d7f3-4bfc-b1a3-f59eca48d6be'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''49716d39-9cc8-45c3-8b81-54ad7429881f'' AND GUID_ObjectReference=''50d23921-5da1-404a-9bf5-89dcf5c452cb'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''49716d39-9cc8-45c3-8b81-54ad7429881f'',''50d23921-5da1-404a-9bf5-89dcf5c452cb'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''765108ea-65a4-41f5-a95a-54bf4fd3effc'' AND GUID_ObjectReference=''e769da11-8b4d-4929-8aec-c387d9b94c19'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''765108ea-65a4-41f5-a95a-54bf4fd3effc'',''e769da11-8b4d-4929-8aec-c387d9b94c19'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''7c76114a-6a68-42aa-b9ce-5fd0d8a02eff'' AND GUID_ObjectReference=''baee993b-0a3d-4a4f-a95c-0a074e9f073b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''7c76114a-6a68-42aa-b9ce-5fd0d8a02eff'',''baee993b-0a3d-4a4f-a95c-0a074e9f073b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6c966e3c-c737-4af1-9970-68c8323679bc'' AND GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6c966e3c-c737-4af1-9970-68c8323679bc'',''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6e494944-f602-4dcb-906f-70e5efe8f1dd'' AND GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''008817a6-14e7-4295-9a69-6835575ae53b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d5d571dd-b9b2-4249-ae1b-75456a1ac504'' AND GUID_ObjectReference=''1d2c70a3-57fe-4237-99a2-1503303715cf'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d5d571dd-b9b2-4249-ae1b-75456a1ac504'',''1d2c70a3-57fe-4237-99a2-1503303715cf'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''c7619aac-483f-4cec-be37-8c6495fbc2b7'' AND GUID_ObjectReference=''8850a46d-8d2c-4500-ab68-def664bd1a3b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''c7619aac-483f-4cec-be37-8c6495fbc2b7'',''8850a46d-8d2c-4500-ab68-def664bd1a3b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''cf0f52ac-1e00-45f4-ae02-8d6d3a920b59'' AND GUID_ObjectReference=''f4c859c5-7633-443b-b235-3b8eae694e59'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''cf0f52ac-1e00-45f4-ae02-8d6d3a920b59'',''f4c859c5-7633-443b-b235-3b8eae694e59'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d3101831-962d-4069-a96d-94fcfc234651'' AND GUID_ObjectReference=''b0f72e18-4d2b-4990-b98a-e7eef4fe5b3a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d3101831-962d-4069-a96d-94fcfc234651'',''b0f72e18-4d2b-4990-b98a-e7eef4fe5b3a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''4dc737aa-1a62-459b-b724-a21ea29683b6'' AND GUID_ObjectReference=''6b21fda2-2004-4c97-92e8-38c041af70f8'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''4dc737aa-1a62-459b-b724-a21ea29683b6'',''6b21fda2-2004-4c97-92e8-38c041af70f8'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''5a778c64-4bcc-4faf-bdba-aaa01092f200'' AND GUID_ObjectReference=''04499b6b-4d2c-4ba4-8ae8-a6b68fecdda1'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''5a778c64-4bcc-4faf-bdba-aaa01092f200'',''04499b6b-4d2c-4ba4-8ae8-a6b68fecdda1'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f1ba23ed-ab41-4d34-8e09-b4e485671478'' AND GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''178d63d3-84de-414f-8abb-b9ed14965b74'' AND GUID_ObjectReference=''ca0d8f42-71d5-432b-b047-9fef7bc8b101'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''178d63d3-84de-414f-8abb-b9ed14965b74'',''ca0d8f42-71d5-432b-b047-9fef7bc8b101'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'' AND GUID_ObjectReference=''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'',''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8618f96e-8494-432a-99da-cc91e6c117d5'' AND GUID_ObjectReference=''c09ca6bf-b5fb-4121-b169-d389981a2ad4'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8618f96e-8494-432a-99da-cc91e6c117d5'',''c09ca6bf-b5fb-4121-b169-d389981a2ad4'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'' AND GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''a6faac99-d3db-4df8-8e45-f177b5bf915e'' AND GUID_ObjectReference=''15c98e13-ec0f-44fa-bc76-abc87189d04f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''a6faac99-d3db-4df8-8e45-f177b5bf915e'',''15c98e13-ec0f-44fa-bc76-abc87189d04f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
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
