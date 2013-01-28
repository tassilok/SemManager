execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''68ac4472-ee22-4229-96ec-9753a016900a'') = 0
	insert into semtbl_Attribute VALUES(''68ac4472-ee22-4229-96ec-9753a016900a'',''XML-Text'',''64530b52-d96c-4df1-86fe-183f44513450'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''3940fb8a-7ec9-4bd5-9719-aed313da116d'') = 0
	insert into semtbl_Attribute VALUES(''3940fb8a-7ec9-4bd5-9719-aed313da116d'',''Value'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''a1b49452-19dc-4eae-a000-ef3802de35a9'') = 0
	insert into semtbl_Attribute VALUES(''a1b49452-19dc-4eae-a000-ef3802de35a9'',''ProcessorID'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''30b76a62-1b22-4f17-b9a5-ff665e08f35a'') = 0
	insert into semtbl_Attribute VALUES(''30b76a62-1b22-4f17-b9a5-ff665e08f35a'',''BaseboardSerial'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''2b0a539c-42dc-4ca0-8c82-d08ba5decb3d'')=0
	insert into semtbl_RelationType VALUES(''2b0a539c-42dc-4ca0-8c82-d08ba5decb3d'',''belonging Report-Template'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''5f6238f7-bd62-40ad-94c0-c18f44c420a7'')=0
	insert into semtbl_RelationType VALUES(''5f6238f7-bd62-40ad-94c0-c18f44c420a7'',''belonging Field-Template'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	insert into semtbl_RelationType VALUES(''e9711603-47db-44d8-a476-fe88290639a4'',''contains'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''88763305-8e22-45ba-99f1-d642871bd8f4'')=0
	insert into semtbl_RelationType VALUES(''88763305-8e22-45ba-99f1-d642871bd8f4'',''belonging Row-Template'')'
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='665dd88b-792e-4256-a27a-68ee1e10ece6') = 0
	insert into semtbl_Type VALUES('665dd88b-792e-4256-a27a-68ee1e10ece6','System','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747') = 0
	insert into semtbl_Type VALUES('b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747','Module-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='aa616051-e521-4fac-abdb-cbba6f8c6e73') = 0
	insert into semtbl_Type VALUES('aa616051-e521-4fac-abdb-cbba6f8c6e73','Module','b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='3ec02be2-793a-45c7-ba6a-27fa2ef2c005') = 0
	insert into semtbl_Type VALUES('3ec02be2-793a-45c7-ba6a-27fa2ef2c005','Splunk-Connector-Module','aa616051-e521-4fac-abdb-cbba6f8c6e73')
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='2f05c250-be33-4b77-ba3c-b8a0228821b6') = 0
	insert into semtbl_Type VALUES('2f05c250-be33-4b77-ba3c-b8a0228821b6','Filesystem-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='d7a03a35-8751-42b4-8e05-19fc7a77ee91') = 0
	insert into semtbl_Type VALUES('d7a03a35-8751-42b4-8e05-19fc7a77ee91','Server','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='83317bac-b4b1-4db8-bf84-9fca0a93ddd5') = 0
	insert into semtbl_Type VALUES('83317bac-b4b1-4db8-bf84-9fca0a93ddd5','Information-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'') = 0
	insert into semtbl_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''Splunk-Connector-Module'',''c6c9bcb8-0ac9-4713-9417-eeec1453026c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''16cd3ca4-f19e-418b-9006-4b626d2f3049'') = 0
	insert into semtbl_Token VALUES(''16cd3ca4-f19e-418b-9006-4b626d2f3049'',''Splunk-Connector-Module'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'') = 0
	insert into semtbl_Token VALUES(''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''Type_Module'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f2dfdacd-ae69-4802-ace1-2baffcdea82f'') = 0
	insert into semtbl_Token VALUES(''f2dfdacd-ae69-4802-ace1-2baffcdea82f'',''Token_Variable_DATETIME_TZ'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''56803624-0182-4926-9da5-3bc4fe5e7b31'') = 0
	insert into semtbl_Token VALUES(''56803624-0182-4926-9da5-3bc4fe5e7b31'',''Type_Port'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'') = 0
	insert into semtbl_Token VALUES(''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'',''Attribute_XML_Text'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''474d70c7-a115-4a93-b285-4a2672c2d041'') = 0
	insert into semtbl_Token VALUES(''474d70c7-a115-4a93-b285-4a2672c2d041'',''Token_Variable_CELL_VALUE'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fa0be9dc-49d3-476f-97e1-4c59d4a2c390'') = 0
	insert into semtbl_Token VALUES(''fa0be9dc-49d3-476f-97e1-4c59d4a2c390'',''RelationType_belonging_Report_Template'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''157f88cc-310a-4275-a7c1-5216d8ac5bf2'') = 0
	insert into semtbl_Token VALUES(''157f88cc-310a-4275-a7c1-5216d8ac5bf2'',''RelationType_belonging_Field_Template'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''266c6bf8-8ab7-4ee1-aa53-6ade2e5841c6'') = 0
	insert into semtbl_Token VALUES(''266c6bf8-8ab7-4ee1-aa53-6ade2e5841c6'',''RelationType_belonging_Row_Template'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'') = 0
	insert into semtbl_Token VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''attribute_dbPostfix'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''368d4f73-a358-4fe5-abc0-78a9dd0db591'') = 0
	insert into semtbl_Token VALUES(''368d4f73-a358-4fe5-abc0-78a9dd0db591'',''Type_Splunk_Connector_Module'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f2cde058-614e-41cb-96eb-78bbcf285171'') = 0
	insert into semtbl_Token VALUES(''f2cde058-614e-41cb-96eb-78bbcf285171'',''RelationType_offered_by'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'') = 0
	insert into semtbl_Token VALUES(''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'',''RelationType_belonging_Source'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''407516df-78ae-4f0d-ae36-956c0621588b'') = 0
	insert into semtbl_Token VALUES(''407516df-78ae-4f0d-ae36-956c0621588b'',''Token_Variable_CELL_NAME'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''be75dfa9-a31e-47af-8b91-9b42153b6d39'') = 0
	insert into semtbl_Token VALUES(''be75dfa9-a31e-47af-8b91-9b42153b6d39'',''Token_Variable_REPORT'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3186cc5e-023b-4edc-b6c7-a89919320839'') = 0
	insert into semtbl_Token VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''RelationType_belongsTo'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cfba621b-5774-445b-8749-af12bb8bb472'') = 0
	insert into semtbl_Token VALUES(''cfba621b-5774-445b-8749-af12bb8bb472'',''Type_XML'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ebe3987c-7845-47ab-a1f6-c6d8e3a12658'') = 0
	insert into semtbl_Token VALUES(''ebe3987c-7845-47ab-a1f6-c6d8e3a12658'',''Type_Variable'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'') = 0
	insert into semtbl_Token VALUES(''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''Type_Server'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''99d858e8-2a38-458e-834c-daec118523e2'') = 0
	insert into semtbl_Token VALUES(''99d858e8-2a38-458e-834c-daec118523e2'',''Token_Variable_CELL_LIST'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8c9fa101-8e2b-4aa6-b84f-6af075bdde3b'') = 0
	insert into semtbl_Token VALUES(''8c9fa101-8e2b-4aa6-b84f-6af075bdde3b'',''DATETIME_TZ'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1bb34344-d41c-4610-927a-74200fc9f6c4'') = 0
	insert into semtbl_Token VALUES(''1bb34344-d41c-4610-927a-74200fc9f6c4'',''CELL_VALUE'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3aa1632a-771e-4cc6-95cf-2dd583a812ca'') = 0
	insert into semtbl_Token VALUES(''3aa1632a-771e-4cc6-95cf-2dd583a812ca'',''ROW_LIST'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6bddeb7f-f782-4962-888f-af7381e8bad6'') = 0
	insert into semtbl_Token VALUES(''6bddeb7f-f782-4962-888f-af7381e8bad6'',''CELL_NAME'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''461bfc6f-4ef5-4185-82f9-d449b0b0aecc'') = 0
	insert into semtbl_Token VALUES(''461bfc6f-4ef5-4185-82f9-d449b0b0aecc'',''REPORT'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c6438d35-df0d-4c63-9a54-ab853bdd475a'') = 0
	insert into semtbl_Token VALUES(''c6438d35-df0d-4c63-9a54-ab853bdd475a'',''CELL_LIST'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''06569546-ccfb-4b98-8e53-5cc09405d492'') = 0
	insert into semtbl_Token VALUES(''06569546-ccfb-4b98-8e53-5cc09405d492'',''Splunk-Connector-Module'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c9636de3-6356-46e5-aab9-9a78444ab7f5'') = 0
	insert into semtbl_Token VALUES(''c9636de3-6356-46e5-aab9-9a78444ab7f5'',''Baseconfig'',''3ec02be2-793a-45c7-ba6a-27fa2ef2c005'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''f2dfdacd-ae69-4802-ace1-2baffcdea82f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''f2dfdacd-ae69-4802-ace1-2baffcdea82f'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''56803624-0182-4926-9da5-3bc4fe5e7b31'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''56803624-0182-4926-9da5-3bc4fe5e7b31'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''474d70c7-a115-4a93-b285-4a2672c2d041'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''474d70c7-a115-4a93-b285-4a2672c2d041'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''fa0be9dc-49d3-476f-97e1-4c59d4a2c390'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''fa0be9dc-49d3-476f-97e1-4c59d4a2c390'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''157f88cc-310a-4275-a7c1-5216d8ac5bf2'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''157f88cc-310a-4275-a7c1-5216d8ac5bf2'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''33b131b4-810d-449c-a3f7-60d16cba5853'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''33b131b4-810d-449c-a3f7-60d16cba5853'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''224f7ece-8d8b-4754-8ef2-6771809a7ea7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''224f7ece-8d8b-4754-8ef2-6771809a7ea7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''6c966e3c-c737-4af1-9970-68c8323679bc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''6c966e3c-c737-4af1-9970-68c8323679bc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''266c6bf8-8ab7-4ee1-aa53-6ade2e5841c6'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''266c6bf8-8ab7-4ee1-aa53-6ade2e5841c6'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''368d4f73-a358-4fe5-abc0-78a9dd0db591'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''368d4f73-a358-4fe5-abc0-78a9dd0db591'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''f2cde058-614e-41cb-96eb-78bbcf285171'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''f2cde058-614e-41cb-96eb-78bbcf285171'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''407516df-78ae-4f0d-ae36-956c0621588b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''407516df-78ae-4f0d-ae36-956c0621588b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''be75dfa9-a31e-47af-8b91-9b42153b6d39'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''be75dfa9-a31e-47af-8b91-9b42153b6d39'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''3186cc5e-023b-4edc-b6c7-a89919320839'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''cfba621b-5774-445b-8749-af12bb8bb472'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''cfba621b-5774-445b-8749-af12bb8bb472'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''ebe3987c-7845-47ab-a1f6-c6d8e3a12658'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''ebe3987c-7845-47ab-a1f6-c6d8e3a12658'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_Token_Right=''99d858e8-2a38-458e-834c-daec118523e2'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''99d858e8-2a38-458e-834c-daec118523e2'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''16cd3ca4-f19e-418b-9006-4b626d2f3049'' AND GUID_Token_Right=''414957c9-32b6-41bd-8f3d-ebef9eb54e36'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Token_Token VALUES(''16cd3ca4-f19e-418b-9006-4b626d2f3049'',''414957c9-32b6-41bd-8f3d-ebef9eb54e36'',''fafc1464-815f-4596-9737-bcbc96bd744a'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''06569546-ccfb-4b98-8e53-5cc09405d492'' AND GUID_Token_Right=''16cd3ca4-f19e-418b-9006-4b626d2f3049'' AND GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	INSERT INTO semtbl_Token_Token VALUES(''06569546-ccfb-4b98-8e53-5cc09405d492'',''16cd3ca4-f19e-418b-9006-4b626d2f3049'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''c9636de3-6356-46e5-aab9-9a78444ab7f5'' AND GUID_Token_Right=''06569546-ccfb-4b98-8e53-5cc09405d492'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''c9636de3-6356-46e5-aab9-9a78444ab7f5'',''06569546-ccfb-4b98-8e53-5cc09405d492'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_Attribute=''68ac4472-ee22-4229-96ec-9753a016900a'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''327e9773-fca6-458c-a44d-338a556e0ad9'',''68ac4472-ee22-4229-96ec-9753a016900a'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''4158aad2-656a-4fb9-97bf-524c6f5fecaa'' AND GUID_Attribute=''3940fb8a-7ec9-4bd5-9719-aed313da116d'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''4158aad2-656a-4fb9-97bf-524c6f5fecaa'',''3940fb8a-7ec9-4bd5-9719-aed313da116d'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_Attribute=''a1b49452-19dc-4eae-a000-ef3802de35a9'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''a1b49452-19dc-4eae-a000-ef3802de35a9'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_Attribute=''30b76a62-1b22-4f17-b9a5-ff665e08f35a'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''30b76a62-1b22-4f17-b9a5-ff665e08f35a'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''3ec02be2-793a-45c7-ba6a-27fa2ef2c005'' AND GUID_Type_Right=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_RelationType=''5f6238f7-bd62-40ad-94c0-c18f44c420a7'')=0
	INSERT INTO semtbl_Type_Type VALUES(''3ec02be2-793a-45c7-ba6a-27fa2ef2c005'',''327e9773-fca6-458c-a44d-338a556e0ad9'',''5f6238f7-bd62-40ad-94c0-c18f44c420a7'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''3ec02be2-793a-45c7-ba6a-27fa2ef2c005'' AND GUID_Type_Right=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_RelationType=''2b0a539c-42dc-4ca0-8c82-d08ba5decb3d'')=0
	INSERT INTO semtbl_Type_Type VALUES(''3ec02be2-793a-45c7-ba6a-27fa2ef2c005'',''327e9773-fca6-458c-a44d-338a556e0ad9'',''2b0a539c-42dc-4ca0-8c82-d08ba5decb3d'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''3ec02be2-793a-45c7-ba6a-27fa2ef2c005'' AND GUID_Type_Right=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_RelationType=''88763305-8e22-45ba-99f1-d642871bd8f4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''3ec02be2-793a-45c7-ba6a-27fa2ef2c005'',''327e9773-fca6-458c-a44d-338a556e0ad9'',''88763305-8e22-45ba-99f1-d642871bd8f4'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''3ec02be2-793a-45c7-ba6a-27fa2ef2c005'' AND GUID_Type_Right=''9ba24283-a0ad-4717-be30-6f0f3818c36c'' AND GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	INSERT INTO semtbl_Type_Type VALUES(''3ec02be2-793a-45c7-ba6a-27fa2ef2c005'',''9ba24283-a0ad-4717-be30-6f0f3818c36c'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''3ec02be2-793a-45c7-ba6a-27fa2ef2c005'' AND GUID_Type_Right=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''3ec02be2-793a-45c7-ba6a-27fa2ef2c005'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_Type_Right=''4158aad2-656a-4fb9-97bf-524c6f5fecaa'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''327e9773-fca6-458c-a44d-338a556e0ad9'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9ba24283-a0ad-4717-be30-6f0f3818c36c'' AND GUID_Type_Right=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9ba24283-a0ad-4717-be30-6f0f3818c36c'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9ba24283-a0ad-4717-be30-6f0f3818c36c'' AND GUID_Type_Right=''ca4eff30-a40b-476d-9906-9f56a67c8cf9'' AND GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9ba24283-a0ad-4717-be30-6f0f3818c36c'',''ca4eff30-a40b-476d-9906-9f56a67c8cf9'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',1,1,-1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''9e5cd511-8d22-4e56-9d6e-9ed5918555f4'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''9e5cd511-8d22-4e56-9d6e-9ed5918555f4'',''16cd3ca4-f19e-418b-9006-4b626d2f3049'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Varchar255 WHERE GUID_TokenAttribute=''9e5cd511-8d22-4e56-9d6e-9ed5918555f4'' )=0
	INSERT INTO semtbl_Token_Attribute_Varchar255 VALUES(''9e5cd511-8d22-4e56-9d6e-9ed5918555f4'',''splunk_connector_module'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'')=0
	INSERT INTO semtbl_OR VALUES(''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''13befea3-d3e4-42cb-b8f3-aece20c453be'')=0
	INSERT INTO semtbl_OR VALUES(''13befea3-d3e4-42cb-b8f3-aece20c453be'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b706b7f9-40ae-431f-afdf-b44f25701fc1'')=0
	INSERT INTO semtbl_OR VALUES(''b706b7f9-40ae-431f-afdf-b44f25701fc1'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b5a71e14-f203-4da9-b8e4-bd526ab5feba'')=0
	INSERT INTO semtbl_OR VALUES(''b5a71e14-f203-4da9-b8e4-bd526ab5feba'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''5f0b1e66-7a5a-4e75-830c-26aa47cf310d'')=0
	INSERT INTO semtbl_OR VALUES(''5f0b1e66-7a5a-4e75-830c-26aa47cf310d'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''9a9756ef-486c-4304-a405-61343cb9003b'')=0
	INSERT INTO semtbl_OR VALUES(''9a9756ef-486c-4304-a405-61343cb9003b'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''a1275785-c2dd-4902-a551-8f52bdf1a4c1'')=0
	INSERT INTO semtbl_OR VALUES(''a1275785-c2dd-4902-a551-8f52bdf1a4c1'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''0840b81c-cd9a-4eda-a8b0-577c50bd4993'')=0
	INSERT INTO semtbl_OR VALUES(''0840b81c-cd9a-4eda-a8b0-577c50bd4993'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ad40c583-9822-4da3-8b10-2dfa9afe0595'')=0
	INSERT INTO semtbl_OR VALUES(''ad40c583-9822-4da3-8b10-2dfa9afe0595'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'')=0
	INSERT INTO semtbl_OR VALUES(''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''07d78334-08f5-458a-b84a-b586f60700b9'')=0
	INSERT INTO semtbl_OR VALUES(''07d78334-08f5-458a-b84a-b586f60700b9'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''94979ade-755f-4adf-808c-7cc4bf279e40'')=0
	INSERT INTO semtbl_OR VALUES(''94979ade-755f-4adf-808c-7cc4bf279e40'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''fb8b6f16-df09-4894-9b80-9db1ac70916b'')=0
	INSERT INTO semtbl_OR VALUES(''fb8b6f16-df09-4894-9b80-9db1ac70916b'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'')=0
	INSERT INTO semtbl_OR VALUES(''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''1b02ff93-e616-4922-bcbb-b33fd9e25566'')=0
	INSERT INTO semtbl_OR VALUES(''1b02ff93-e616-4922-bcbb-b33fd9e25566'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''89c4e35e-c8fd-4beb-a6a6-48990442efe6'')=0
	INSERT INTO semtbl_OR VALUES(''89c4e35e-c8fd-4beb-a6a6-48990442efe6'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'')=0
	INSERT INTO semtbl_OR VALUES(''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d251cf80-30d7-404c-8f68-4926d0efad3e'')=0
	INSERT INTO semtbl_OR VALUES(''d251cf80-30d7-404c-8f68-4926d0efad3e'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'')=0
	INSERT INTO semtbl_OR_Type VALUES(''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''b706b7f9-40ae-431f-afdf-b44f25701fc1'')=0
	INSERT INTO semtbl_OR_Type VALUES(''b706b7f9-40ae-431f-afdf-b44f25701fc1'',''ca4eff30-a40b-476d-9906-9f56a67c8cf9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''880400b2-6832-4368-baa9-a1d543c382e7'')=0
	INSERT INTO semtbl_OR_Type VALUES(''880400b2-6832-4368-baa9-a1d543c382e7'',''9ba24283-a0ad-4717-be30-6f0f3818c36c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''ad40c583-9822-4da3-8b10-2dfa9afe0595'')=0
	INSERT INTO semtbl_OR_Type VALUES(''ad40c583-9822-4da3-8b10-2dfa9afe0595'',''3ec02be2-793a-45c7-ba6a-27fa2ef2c005'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''1b02ff93-e616-4922-bcbb-b33fd9e25566'')=0
	INSERT INTO semtbl_OR_Type VALUES(''1b02ff93-e616-4922-bcbb-b33fd9e25566'',''327e9773-fca6-458c-a44d-338a556e0ad9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''89c4e35e-c8fd-4beb-a6a6-48990442efe6'')=0
	INSERT INTO semtbl_OR_Type VALUES(''89c4e35e-c8fd-4beb-a6a6-48990442efe6'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'')=0
	INSERT INTO semtbl_OR_Type VALUES(''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''b5a71e14-f203-4da9-b8e4-bd526ab5feba'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''b5a71e14-f203-4da9-b8e4-bd526ab5feba'',''68ac4472-ee22-4229-96ec-9753a016900a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''9a9756ef-486c-4304-a405-61343cb9003b'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''9a9756ef-486c-4304-a405-61343cb9003b'',''2b0a539c-42dc-4ca0-8c82-d08ba5decb3d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''a1275785-c2dd-4902-a551-8f52bdf1a4c1'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''a1275785-c2dd-4902-a551-8f52bdf1a4c1'',''5f6238f7-bd62-40ad-94c0-c18f44c420a7'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''e9711603-47db-44d8-a476-fe88290639a4'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''0840b81c-cd9a-4eda-a8b0-577c50bd4993'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''0840b81c-cd9a-4eda-a8b0-577c50bd4993'',''88763305-8e22-45ba-99f1-d642871bd8f4'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''13befea3-d3e4-42cb-b8f3-aece20c453be'')=0
	INSERT INTO semtbl_OR_Token VALUES(''13befea3-d3e4-42cb-b8f3-aece20c453be'',''8c9fa101-8e2b-4aa6-b84f-6af075bdde3b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''5f0b1e66-7a5a-4e75-830c-26aa47cf310d'')=0
	INSERT INTO semtbl_OR_Token VALUES(''5f0b1e66-7a5a-4e75-830c-26aa47cf310d'',''1bb34344-d41c-4610-927a-74200fc9f6c4'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''33e15532-5b6f-4812-97bb-2989e82bf7a7'')=0
	INSERT INTO semtbl_OR_Token VALUES(''33e15532-5b6f-4812-97bb-2989e82bf7a7'',''3aa1632a-771e-4cc6-95cf-2dd583a812ca'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''94979ade-755f-4adf-808c-7cc4bf279e40'')=0
	INSERT INTO semtbl_OR_Token VALUES(''94979ade-755f-4adf-808c-7cc4bf279e40'',''6bddeb7f-f782-4962-888f-af7381e8bad6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''fb8b6f16-df09-4894-9b80-9db1ac70916b'')=0
	INSERT INTO semtbl_OR_Token VALUES(''fb8b6f16-df09-4894-9b80-9db1ac70916b'',''461bfc6f-4ef5-4185-82f9-d449b0b0aecc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''d251cf80-30d7-404c-8f68-4926d0efad3e'')=0
	INSERT INTO semtbl_OR_Token VALUES(''d251cf80-30d7-404c-8f68-4926d0efad3e'',''c6438d35-df0d-4c63-9a54-ab853bdd475a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'' AND GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f2dfdacd-ae69-4802-ace1-2baffcdea82f'' AND GUID_ObjectReference=''13befea3-d3e4-42cb-b8f3-aece20c453be'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f2dfdacd-ae69-4802-ace1-2baffcdea82f'',''13befea3-d3e4-42cb-b8f3-aece20c453be'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''56803624-0182-4926-9da5-3bc4fe5e7b31'' AND GUID_ObjectReference=''b706b7f9-40ae-431f-afdf-b44f25701fc1'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''56803624-0182-4926-9da5-3bc4fe5e7b31'',''b706b7f9-40ae-431f-afdf-b44f25701fc1'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'' AND GUID_ObjectReference=''b5a71e14-f203-4da9-b8e4-bd526ab5feba'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'',''b5a71e14-f203-4da9-b8e4-bd526ab5feba'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''474d70c7-a115-4a93-b285-4a2672c2d041'' AND GUID_ObjectReference=''5f0b1e66-7a5a-4e75-830c-26aa47cf310d'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''474d70c7-a115-4a93-b285-4a2672c2d041'',''5f0b1e66-7a5a-4e75-830c-26aa47cf310d'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''fa0be9dc-49d3-476f-97e1-4c59d4a2c390'' AND GUID_ObjectReference=''9a9756ef-486c-4304-a405-61343cb9003b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''fa0be9dc-49d3-476f-97e1-4c59d4a2c390'',''9a9756ef-486c-4304-a405-61343cb9003b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''157f88cc-310a-4275-a7c1-5216d8ac5bf2'' AND GUID_ObjectReference=''a1275785-c2dd-4902-a551-8f52bdf1a4c1'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''157f88cc-310a-4275-a7c1-5216d8ac5bf2'',''a1275785-c2dd-4902-a551-8f52bdf1a4c1'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''266c6bf8-8ab7-4ee1-aa53-6ade2e5841c6'' AND GUID_ObjectReference=''0840b81c-cd9a-4eda-a8b0-577c50bd4993'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''266c6bf8-8ab7-4ee1-aa53-6ade2e5841c6'',''0840b81c-cd9a-4eda-a8b0-577c50bd4993'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''368d4f73-a358-4fe5-abc0-78a9dd0db591'' AND GUID_ObjectReference=''ad40c583-9822-4da3-8b10-2dfa9afe0595'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''368d4f73-a358-4fe5-abc0-78a9dd0db591'',''ad40c583-9822-4da3-8b10-2dfa9afe0595'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f2cde058-614e-41cb-96eb-78bbcf285171'' AND GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f2cde058-614e-41cb-96eb-78bbcf285171'',''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'' AND GUID_ObjectReference=''07d78334-08f5-458a-b84a-b586f60700b9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'',''07d78334-08f5-458a-b84a-b586f60700b9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''407516df-78ae-4f0d-ae36-956c0621588b'' AND GUID_ObjectReference=''94979ade-755f-4adf-808c-7cc4bf279e40'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''407516df-78ae-4f0d-ae36-956c0621588b'',''94979ade-755f-4adf-808c-7cc4bf279e40'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''be75dfa9-a31e-47af-8b91-9b42153b6d39'' AND GUID_ObjectReference=''fb8b6f16-df09-4894-9b80-9db1ac70916b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''be75dfa9-a31e-47af-8b91-9b42153b6d39'',''fb8b6f16-df09-4894-9b80-9db1ac70916b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''cfba621b-5774-445b-8749-af12bb8bb472'' AND GUID_ObjectReference=''1b02ff93-e616-4922-bcbb-b33fd9e25566'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''cfba621b-5774-445b-8749-af12bb8bb472'',''1b02ff93-e616-4922-bcbb-b33fd9e25566'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ebe3987c-7845-47ab-a1f6-c6d8e3a12658'' AND GUID_ObjectReference=''89c4e35e-c8fd-4beb-a6a6-48990442efe6'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ebe3987c-7845-47ab-a1f6-c6d8e3a12658'',''89c4e35e-c8fd-4beb-a6a6-48990442efe6'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'' AND GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''99d858e8-2a38-458e-834c-daec118523e2'' AND GUID_ObjectReference=''d251cf80-30d7-404c-8f68-4926d0efad3e'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''99d858e8-2a38-458e-834c-daec118523e2'',''d251cf80-30d7-404c-8f68-4926d0efad3e'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''13c09f11-175c-4eef-bc8a-0fd8e86d557f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''13c09f11-175c-4eef-bc8a-0fd8e86d557f'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1)'
GO
