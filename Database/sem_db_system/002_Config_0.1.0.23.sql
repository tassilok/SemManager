execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''d9716e15-9624-4eed-89a8-d45bc0ceb2b1'') = 0
	insert into semtbl_Attribute VALUES(''d9716e15-9624-4eed-89a8-d45bc0ceb2b1'',''Type'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''30b76a62-1b22-4f17-b9a5-ff665e08f35a'') = 0
	insert into semtbl_Attribute VALUES(''30b76a62-1b22-4f17-b9a5-ff665e08f35a'',''BaseboardSerial'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''234a50e0-548d-46bf-8a04-82d68bf842e5'') = 0
	insert into semtbl_Attribute VALUES(''234a50e0-548d-46bf-8a04-82d68bf842e5'',''Token'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''a1b49452-19dc-4eae-a000-ef3802de35a9'') = 0
	insert into semtbl_Attribute VALUES(''a1b49452-19dc-4eae-a000-ef3802de35a9'',''ProcessorID'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''0f8ff423-e407-4082-ab28-ec6b6cfe31d7'') = 0
	insert into semtbl_Attribute VALUES(''0f8ff423-e407-4082-ab28-ec6b6cfe31d7'',''Attribute'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''b66ed485-e41a-4c1f-b003-451991967cc8'') = 0
	insert into semtbl_Attribute VALUES(''b66ed485-e41a-4c1f-b003-451991967cc8'',''RelationType'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''6c72b7e7-a182-4135-9c4e-63c8885b07b8'') = 0
	insert into semtbl_Attribute VALUES(''6c72b7e7-a182-4135-9c4e-63c8885b07b8'',''Minor'',''3a4f5b7b-da75-4980-933e-fbc33cc51439'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''d4c755c1-4ebe-4c1c-9be1-89244e1bf8d3'') = 0
	insert into semtbl_Attribute VALUES(''d4c755c1-4ebe-4c1c-9be1-89244e1bf8d3'',''Revision'',''3a4f5b7b-da75-4980-933e-fbc33cc51439'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''e57ea6f4-77d5-4cc7-9070-d0ea3308092f'') = 0
	insert into semtbl_Attribute VALUES(''e57ea6f4-77d5-4cc7-9070-d0ea3308092f'',''Major'',''3a4f5b7b-da75-4980-933e-fbc33cc51439'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''e364d837-b5d8-4c04-b951-e0bd1631334d'') = 0
	insert into semtbl_Attribute VALUES(''e364d837-b5d8-4c04-b951-e0bd1631334d'',''Build'',''3a4f5b7b-da75-4980-933e-fbc33cc51439'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''7e709649-5791-4116-af93-263864214ffe'')=0
	insert into semtbl_RelationType VALUES(''7e709649-5791-4116-af93-263864214ffe'',''Sources located in'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''050bf6fa-4754-48b0-952c-8bd11a442f2d'')=0
	insert into semtbl_RelationType VALUES(''050bf6fa-4754-48b0-952c-8bd11a442f2d'',''is on'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''cf27679f-cbe7-4010-a3ae-472072762b33'')=0
	insert into semtbl_RelationType VALUES(''cf27679f-cbe7-4010-a3ae-472072762b33'',''is in State'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	insert into semtbl_RelationType VALUES(''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',''offered by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''eb05244b-4e49-4808-b81b-995f3ee6065a'')=0
	insert into semtbl_RelationType VALUES(''eb05244b-4e49-4808-b81b-995f3ee6065a'',''superordinate'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''fcd7eb74-cc20-45e8-b37e-11e2b62c99a1'')=0
	insert into semtbl_RelationType VALUES(''fcd7eb74-cc20-45e8-b37e-11e2b62c99a1'',''offers for'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e1cc31b2-fdf0-4e52-bdcf-34ee60e5be75'')=0
	insert into semtbl_RelationType VALUES(''e1cc31b2-fdf0-4e52-bdcf-34ee60e5be75'',''Fileshare'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	insert into semtbl_RelationType VALUES(''408db9f1-ae42-4807-b656-729270646f0a'',''is subordinated'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	insert into semtbl_RelationType VALUES(''e9711603-47db-44d8-a476-fe88290639a4'',''contains'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	insert into semtbl_RelationType VALUES(''fafc1464-815f-4596-9737-bcbc96bd744a'',''needs'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	insert into semtbl_RelationType VALUES(''e07469d9-766c-443e-8526-6d9c684f944f'',''belongs to'')'
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='f30436d6-2ffc-4071-af5e-3ce708b8c2d9') = 0
	insert into semtbl_Type VALUES('f30436d6-2ffc-4071-af5e-3ce708b8c2d9','Development-Version','71415eeb-ce46-4b2c-b0a2-f72116b55438')
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='041ec955-ed78-4931-a491-2336b55d9bd7') = 0
	insert into semtbl_Type VALUES('041ec955-ed78-4931-a491-2336b55d9bd7','Module-Activator','b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='23ad9ceb-5c77-44f7-a5cd-eb61aa2f20f5') = 0
	insert into semtbl_Type VALUES('23ad9ceb-5c77-44f7-a5cd-eb61aa2f20f5','Integration-Level','b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='83317bac-b4b1-4db8-bf84-9fca0a93ddd5') = 0
	insert into semtbl_Type VALUES('83317bac-b4b1-4db8-bf84-9fca0a93ddd5','Information-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='3d1dc6cf-b964-4986-9808-f39b7c5c3907') = 0
	insert into semtbl_Type VALUES('3d1dc6cf-b964-4986-9808-f39b7c5c3907','Direction','83317bac-b4b1-4db8-bf84-9fca0a93ddd5')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='53136d10-b7e7-47fc-94ad-7887a354d6e1') = 0
	insert into semtbl_Type VALUES('53136d10-b7e7-47fc-94ad-7887a354d6e1','Log-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='1d9568af-b6da-4990-8f4d-907dfdd30749') = 0
	insert into semtbl_Type VALUES('1d9568af-b6da-4990-8f4d-907dfdd30749','Logstate','53136d10-b7e7-47fc-94ad-7887a354d6e1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='2f05c250-be33-4b77-ba3c-b8a0228821b6') = 0
	insert into semtbl_Type VALUES('2f05c250-be33-4b77-ba3c-b8a0228821b6','Filesystem-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='f47a3e1c-50b4-4666-a41d-e975597c9adb') = 0
	insert into semtbl_Type VALUES('f47a3e1c-50b4-4666-a41d-e975597c9adb','Folder','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='d7a03a35-8751-42b4-8e05-19fc7a77ee91') = 0
	insert into semtbl_Type VALUES('d7a03a35-8751-42b4-8e05-19fc7a77ee91','Server','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'') = 0
	insert into semtbl_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''Sem-Manager'',''c6c9bcb8-0ac9-4713-9417-eeec1453026c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bb96e526-e6d7-419f-adf8-fe4fbc12038d'') = 0
	insert into semtbl_Token VALUES(''bb96e526-e6d7-419f-adf8-fe4fbc12038d'',''Sem-Manager'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fc5609f3-fd7c-44aa-9744-0063b1c6f95e'') = 0
	insert into semtbl_Token VALUES(''fc5609f3-fd7c-44aa-9744-0063b1c6f95e'',''Token_Type_Integration_Level'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1b0b153a-f0a8-4218-b579-0472f00f6f43'') = 0
	insert into semtbl_Token VALUES(''1b0b153a-f0a8-4218-b579-0472f00f6f43'',''Token_Filter_Integration_Level'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1d7fefa9-2304-450d-9a4a-0a3c4be58ccc'') = 0
	insert into semtbl_Token VALUES(''1d7fefa9-2304-450d-9a4a-0a3c4be58ccc'',''type_SoftwareDevelopment'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'') = 0
	insert into semtbl_Token VALUES(''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''Type_Module'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''53f76bfa-93cd-4ceb-9afe-0cea9c338e68'') = 0
	insert into semtbl_Token VALUES(''53f76bfa-93cd-4ceb-9afe-0cea9c338e68'',''Type_Direction'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''77a54faf-aef7-47f0-8831-0ea2bae84aee'') = 0
	insert into semtbl_Token VALUES(''77a54faf-aef7-47f0-8831-0ea2bae84aee'',''Attribute_Type'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2fe835b6-edef-437c-b069-1216e4c77b46'') = 0
	insert into semtbl_Token VALUES(''2fe835b6-edef-437c-b069-1216e4c77b46'',''Token_Full_Integration_Level'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d47fc40f-323c-446b-8a96-17a3de704f93'') = 0
	insert into semtbl_Token VALUES(''d47fc40f-323c-446b-8a96-17a3de704f93'',''Type_Module_Activator'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5f04d3aa-694e-46a7-801e-19d44774342e'') = 0
	insert into semtbl_Token VALUES(''5f04d3aa-694e-46a7-801e-19d44774342e'',''Token_Integration_Level_Menu'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ca828f58-ede1-41f2-bf80-204e09646be4'') = 0
	insert into semtbl_Token VALUES(''ca828f58-ede1-41f2-bf80-204e09646be4'',''Attribute_BaseboardSerial'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fa3d85ef-eb88-4457-9a87-288193c81354'') = 0
	insert into semtbl_Token VALUES(''fa3d85ef-eb88-4457-9a87-288193c81354'',''Attribute_Token'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f8fe8cf8-e39a-4bed-b872-28b9fea65d9d'') = 0
	insert into semtbl_Token VALUES(''f8fe8cf8-e39a-4bed-b872-28b9fea65d9d'',''Type_System'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''54b79b2b-3068-493d-a1f3-2cf05dac6a85'') = 0
	insert into semtbl_Token VALUES(''54b79b2b-3068-493d-a1f3-2cf05dac6a85'',''Token_Information_Integration_Level'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''70c70898-53ed-4e40-bdf8-2ddb5b369c85'') = 0
	insert into semtbl_Token VALUES(''70c70898-53ed-4e40-bdf8-2ddb5b369c85'',''Type_Integration_Level'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''dd378ef1-7f29-4702-98ff-38efc318037f'') = 0
	insert into semtbl_Token VALUES(''dd378ef1-7f29-4702-98ff-38efc318037f'',''Type_Module_Management'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e407ccec-9732-497f-811b-40e05449d97d'') = 0
	insert into semtbl_Token VALUES(''e407ccec-9732-497f-811b-40e05449d97d'',''RelationType_SourcesLocatedIn'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''31f8be26-616c-49bf-a7d6-46957e65b859'') = 0
	insert into semtbl_Token VALUES(''31f8be26-616c-49bf-a7d6-46957e65b859'',''RelationType_is_on'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d09dabad-6d47-48a9-8ea7-64d011d76d4e'') = 0
	insert into semtbl_Token VALUES(''d09dabad-6d47-48a9-8ea7-64d011d76d4e'',''type_Logstate'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8e96640d-b873-4a50-b272-6b1376b26852'') = 0
	insert into semtbl_Token VALUES(''8e96640d-b873-4a50-b272-6b1376b26852'',''RelationType_isInState'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'') = 0
	insert into semtbl_Token VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''attribute_dbPostfix'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f2cde058-614e-41cb-96eb-78bbcf285171'') = 0
	insert into semtbl_Token VALUES(''f2cde058-614e-41cb-96eb-78bbcf285171'',''RelationType_offered_by'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f0750b76-7682-4f3d-861e-83d9e703916e'') = 0
	insert into semtbl_Token VALUES(''f0750b76-7682-4f3d-861e-83d9e703916e'',''RelationType_superordinate'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''28c896af-a0f2-465b-925a-9b26fbc84d1e'') = 0
	insert into semtbl_Token VALUES(''28c896af-a0f2-465b-925a-9b26fbc84d1e'',''Attribute_ProcessorID'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f5658dca-283f-43d8-b4cc-ac78f064d0f8'') = 0
	insert into semtbl_Token VALUES(''f5658dca-283f-43d8-b4cc-ac78f064d0f8'',''Type_Filesystem_Management'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''923108a1-c159-4d69-affe-ae048460dd24'') = 0
	insert into semtbl_Token VALUES(''923108a1-c159-4d69-affe-ae048460dd24'',''type_Folder'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4ce41b7a-2fb9-4df6-b67a-c5aca2e46da1'') = 0
	insert into semtbl_Token VALUES(''4ce41b7a-2fb9-4df6-b67a-c5aca2e46da1'',''type_DevelopmentVersion'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e515708f-6eda-483a-9ab3-cec2872f1720'') = 0
	insert into semtbl_Token VALUES(''e515708f-6eda-483a-9ab3-cec2872f1720'',''Attribute_Attribute'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''759851bb-e1ff-40a9-996c-cf6f2dbd3bcd'') = 0
	insert into semtbl_Token VALUES(''759851bb-e1ff-40a9-996c-cf6f2dbd3bcd'',''RelationType_offers_for'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'') = 0
	insert into semtbl_Token VALUES(''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''Type_Server'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f80322ed-326f-4145-b7a1-dd8a3fcfc247'') = 0
	insert into semtbl_Token VALUES(''f80322ed-326f-4145-b7a1-dd8a3fcfc247'',''Attribute_RelationType'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''52c468e3-fc34-4095-a4f0-fef640f93517'') = 0
	insert into semtbl_Token VALUES(''52c468e3-fc34-4095-a4f0-fef640f93517'',''Information'',''23ad9ceb-5c77-44f7-a5cd-eb61aa2f20f5'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''05ce853c-ce41-4eea-8a11-caa578c337de'') = 0
	insert into semtbl_Token VALUES(''05ce853c-ce41-4eea-8a11-caa578c337de'',''Filter'',''23ad9ceb-5c77-44f7-a5cd-eb61aa2f20f5'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ef419235-2d55-4ce7-a0f4-6702ab57fbb7'') = 0
	insert into semtbl_Token VALUES(''ef419235-2d55-4ce7-a0f4-6702ab57fbb7'',''Down'',''3d1dc6cf-b964-4986-9808-f39b7c5c3907'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cc99d536-5d56-4fd2-9d4f-45b48af33029'') = 0
	insert into semtbl_Token VALUES(''cc99d536-5d56-4fd2-9d4f-45b48af33029'',''Left-Right'',''3d1dc6cf-b964-4986-9808-f39b7c5c3907'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''061243fc-4c13-4bd5-800c-2c33b70e99b2'') = 0
	insert into semtbl_Token VALUES(''061243fc-4c13-4bd5-800c-2c33b70e99b2'',''Right-Left'',''3d1dc6cf-b964-4986-9808-f39b7c5c3907'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''14cc9088-fd98-45f9-957e-b4bf519bf6f5'') = 0
	insert into semtbl_Token VALUES(''14cc9088-fd98-45f9-957e-b4bf519bf6f5'',''Up'',''3d1dc6cf-b964-4986-9808-f39b7c5c3907'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''11f634d0-6673-4e6b-8164-7123e169c9de'') = 0
	insert into semtbl_Token VALUES(''11f634d0-6673-4e6b-8164-7123e169c9de'',''Full'',''23ad9ceb-5c77-44f7-a5cd-eb61aa2f20f5'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7647f6a9-1348-469e-8b43-7f4b8d195183'') = 0
	insert into semtbl_Token VALUES(''7647f6a9-1348-469e-8b43-7f4b8d195183'',''Menu'',''23ad9ceb-5c77-44f7-a5cd-eb61aa2f20f5'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cbf10cd8-e3d8-4e3f-82d9-a5547498b0c9'') = 0
	insert into semtbl_Token VALUES(''cbf10cd8-e3d8-4e3f-82d9-a5547498b0c9'',''Objecttype'',''23ad9ceb-5c77-44f7-a5cd-eb61aa2f20f5'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''aabfd0bc-070f-43d0-9ea2-0f7ba13612ce'') = 0
	insert into semtbl_Token VALUES(''aabfd0bc-070f-43d0-9ea2-0f7ba13612ce'',''Active'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9ad67d25-455c-47b1-9c3b-4d80e9a844af'') = 0
	insert into semtbl_Token VALUES(''9ad67d25-455c-47b1-9c3b-4d80e9a844af'',''Attribute Change'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d94eafea-c624-4230-bcf8-833ff364f865'') = 0
	insert into semtbl_Token VALUES(''d94eafea-c624-4230-bcf8-833ff364f865'',''Changed'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bdfa7784-a8cf-41de-84ab-960c54430c7a'') = 0
	insert into semtbl_Token VALUES(''bdfa7784-a8cf-41de-84ab-960c54430c7a'',''Config-Error'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''34b32bee-4afe-4c12-9774-4720b6a336a5'') = 0
	insert into semtbl_Token VALUES(''34b32bee-4afe-4c12-9774-4720b6a336a5'',''ConfigItem-Added'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4d2cc4c4-75f1-415b-b955-03709af32334'') = 0
	insert into semtbl_Token VALUES(''4d2cc4c4-75f1-415b-b955-03709af32334'',''Create'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''76a1996b-325d-40d1-b5e8-06c00575ef41'') = 0
	insert into semtbl_Token VALUES(''76a1996b-325d-40d1-b5e8-06c00575ef41'',''daily Work Done'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bb6a9555-3af6-40fc-9fb0-489d2678dff2'') = 0
	insert into semtbl_Token VALUES(''bb6a9555-3af6-40fc-9fb0-489d2678dff2'',''Delete'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cc714341-7631-4b78-b8f4-385db073635f'') = 0
	insert into semtbl_Token VALUES(''cc714341-7631-4b78-b8f4-385db073635f'',''Error'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0b285306-f64d-4444-bffe-627a21687eff'') = 0
	insert into semtbl_Token VALUES(''0b285306-f64d-4444-bffe-627a21687eff'',''Exists'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e482fe1f-7892-4fb7-8a1e-9430c28af262'') = 0
	insert into semtbl_Token VALUES(''e482fe1f-7892-4fb7-8a1e-9430c28af262'',''finished'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2b2e93ae-df66-499a-9eab-0a1f4122998a'') = 0
	insert into semtbl_Token VALUES(''2b2e93ae-df66-499a-9eab-0a1f4122998a'',''Inactive'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''80f0fdf1-373e-42c8-b07e-04e4aed313a3'') = 0
	insert into semtbl_Token VALUES(''80f0fdf1-373e-42c8-b07e-04e4aed313a3'',''Information'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a6df6ab2-3590-45b1-b325-35334a2f574a'') = 0
	insert into semtbl_Token VALUES(''a6df6ab2-3590-45b1-b325-35334a2f574a'',''Insert'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3dfc2a38-8ea7-4864-8d9c-3f811fb1f16a'') = 0
	insert into semtbl_Token VALUES(''3dfc2a38-8ea7-4864-8d9c-3f811fb1f16a'',''Last Position'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''95666887-fb2a-416e-9624-a48d48dc5446'') = 0
	insert into semtbl_Token VALUES(''95666887-fb2a-416e-9624-a48d48dc5446'',''Nothing'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9f2bc62d-caa6-4e37-bc1e-164044102ee9'') = 0
	insert into semtbl_Token VALUES(''9f2bc62d-caa6-4e37-bc1e-164044102ee9'',''Obsolete'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3273a7e0-7871-46c4-8cf4-3e09157d69a3'') = 0
	insert into semtbl_Token VALUES(''3273a7e0-7871-46c4-8cf4-3e09157d69a3'',''Open'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bdb17d4e-37d0-498e-b817-48937925c047'') = 0
	insert into semtbl_Token VALUES(''bdb17d4e-37d0-498e-b817-48937925c047'',''Pause'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a46b7472-3c8e-44a8-b785-3913b760db22'') = 0
	insert into semtbl_Token VALUES(''a46b7472-3c8e-44a8-b785-3913b760db22'',''Relation'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fb4cd678-b890-4538-9b22-93128e375c09'') = 0
	insert into semtbl_Token VALUES(''fb4cd678-b890-4538-9b22-93128e375c09'',''Relation Change'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c956e545-ea6f-44c6-85a8-2456bfa1c326'') = 0
	insert into semtbl_Token VALUES(''c956e545-ea6f-44c6-85a8-2456bfa1c326'',''Request'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''13a92675-6054-47eb-82e1-d4ed62c69e80'') = 0
	insert into semtbl_Token VALUES(''13a92675-6054-47eb-82e1-d4ed62c69e80'',''solved'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''eabea67d-a6c4-41e3-998d-3e79aa87c116'') = 0
	insert into semtbl_Token VALUES(''eabea67d-a6c4-41e3-998d-3e79aa87c116'',''Start'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5895fa84-0476-487c-b5df-c7a7485c63d2'') = 0
	insert into semtbl_Token VALUES(''5895fa84-0476-487c-b5df-c7a7485c63d2'',''Stop'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''84251164-265e-4e02-94b2-ed7c40a02e56'') = 0
	insert into semtbl_Token VALUES(''84251164-265e-4e02-94b2-ed7c40a02e56'',''Success'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''438e52d1-8501-4a3f-86c3-a626e197c76f'') = 0
	insert into semtbl_Token VALUES(''438e52d1-8501-4a3f-86c3-a626e197c76f'',''Unassigned'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2bf7e9d6-fb9c-4092-9b16-ecc4fef7c072'') = 0
	insert into semtbl_Token VALUES(''2bf7e9d6-fb9c-4092-9b16-ecc4fef7c072'',''Update'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4fa6bfbc-b99e-4586-8963-868d6fe48a27'') = 0
	insert into semtbl_Token VALUES(''4fa6bfbc-b99e-4586-8963-868d6fe48a27'',''User-Defined'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c4e87510-d6e2-4d4c-b475-7e171dea16c6'') = 0
	insert into semtbl_Token VALUES(''c4e87510-d6e2-4d4c-b475-7e171dea16c6'',''Version Changed'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''fc5609f3-fd7c-44aa-9744-0063b1c6f95e'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''fc5609f3-fd7c-44aa-9744-0063b1c6f95e'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''1b0b153a-f0a8-4218-b579-0472f00f6f43'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''1b0b153a-f0a8-4218-b579-0472f00f6f43'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''1d7fefa9-2304-450d-9a4a-0a3c4be58ccc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''1d7fefa9-2304-450d-9a4a-0a3c4be58ccc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''53f76bfa-93cd-4ceb-9afe-0cea9c338e68'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''53f76bfa-93cd-4ceb-9afe-0cea9c338e68'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''77a54faf-aef7-47f0-8831-0ea2bae84aee'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''77a54faf-aef7-47f0-8831-0ea2bae84aee'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''2fe835b6-edef-437c-b069-1216e4c77b46'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''2fe835b6-edef-437c-b069-1216e4c77b46'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''d47fc40f-323c-446b-8a96-17a3de704f93'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''d47fc40f-323c-446b-8a96-17a3de704f93'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''5f04d3aa-694e-46a7-801e-19d44774342e'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''5f04d3aa-694e-46a7-801e-19d44774342e'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''ca828f58-ede1-41f2-bf80-204e09646be4'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''ca828f58-ede1-41f2-bf80-204e09646be4'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''fa3d85ef-eb88-4457-9a87-288193c81354'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''fa3d85ef-eb88-4457-9a87-288193c81354'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''f8fe8cf8-e39a-4bed-b872-28b9fea65d9d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''f8fe8cf8-e39a-4bed-b872-28b9fea65d9d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''54b79b2b-3068-493d-a1f3-2cf05dac6a85'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''54b79b2b-3068-493d-a1f3-2cf05dac6a85'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''70c70898-53ed-4e40-bdf8-2ddb5b369c85'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''70c70898-53ed-4e40-bdf8-2ddb5b369c85'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''dd378ef1-7f29-4702-98ff-38efc318037f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''dd378ef1-7f29-4702-98ff-38efc318037f'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''e407ccec-9732-497f-811b-40e05449d97d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''e407ccec-9732-497f-811b-40e05449d97d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''31f8be26-616c-49bf-a7d6-46957e65b859'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''31f8be26-616c-49bf-a7d6-46957e65b859'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''d09dabad-6d47-48a9-8ea7-64d011d76d4e'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''d09dabad-6d47-48a9-8ea7-64d011d76d4e'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''8e96640d-b873-4a50-b272-6b1376b26852'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''8e96640d-b873-4a50-b272-6b1376b26852'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''f2cde058-614e-41cb-96eb-78bbcf285171'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''f2cde058-614e-41cb-96eb-78bbcf285171'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''f0750b76-7682-4f3d-861e-83d9e703916e'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''f0750b76-7682-4f3d-861e-83d9e703916e'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''28c896af-a0f2-465b-925a-9b26fbc84d1e'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''28c896af-a0f2-465b-925a-9b26fbc84d1e'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''f5658dca-283f-43d8-b4cc-ac78f064d0f8'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''f5658dca-283f-43d8-b4cc-ac78f064d0f8'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''923108a1-c159-4d69-affe-ae048460dd24'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''923108a1-c159-4d69-affe-ae048460dd24'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''4ce41b7a-2fb9-4df6-b67a-c5aca2e46da1'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''4ce41b7a-2fb9-4df6-b67a-c5aca2e46da1'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''e515708f-6eda-483a-9ab3-cec2872f1720'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''e515708f-6eda-483a-9ab3-cec2872f1720'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''759851bb-e1ff-40a9-996c-cf6f2dbd3bcd'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''759851bb-e1ff-40a9-996c-cf6f2dbd3bcd'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_Token_Right=''f80322ed-326f-4145-b7a1-dd8a3fcfc247'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''f80322ed-326f-4145-b7a1-dd8a3fcfc247'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''bb96e526-e6d7-419f-adf8-fe4fbc12038d'' AND GUID_Token_Right=''aabfd0bc-070f-43d0-9ea2-0f7ba13612ce'' AND GUID_RelationType=''cf27679f-cbe7-4010-a3ae-472072762b33'')=0
	INSERT INTO semtbl_Token_Token VALUES(''bb96e526-e6d7-419f-adf8-fe4fbc12038d'',''aabfd0bc-070f-43d0-9ea2-0f7ba13612ce'',''cf27679f-cbe7-4010-a3ae-472072762b33'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''bb96e526-e6d7-419f-adf8-fe4fbc12038d'' AND GUID_Token_Right=''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Token_Token VALUES(''bb96e526-e6d7-419f-adf8-fe4fbc12038d'',''5e22c144-1133-4a1b-8e95-b3787a2d5e5c'',''fafc1464-815f-4596-9737-bcbc96bd744a'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''041ec955-ed78-4931-a491-2336b55d9bd7'' AND GUID_Attribute=''b66ed485-e41a-4c1f-b003-451991967cc8'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''041ec955-ed78-4931-a491-2336b55d9bd7'',''b66ed485-e41a-4c1f-b003-451991967cc8'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''041ec955-ed78-4931-a491-2336b55d9bd7'' AND GUID_Attribute=''234a50e0-548d-46bf-8a04-82d68bf842e5'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''041ec955-ed78-4931-a491-2336b55d9bd7'',''234a50e0-548d-46bf-8a04-82d68bf842e5'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''041ec955-ed78-4931-a491-2336b55d9bd7'' AND GUID_Attribute=''d9716e15-9624-4eed-89a8-d45bc0ceb2b1'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''041ec955-ed78-4931-a491-2336b55d9bd7'',''d9716e15-9624-4eed-89a8-d45bc0ceb2b1'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''041ec955-ed78-4931-a491-2336b55d9bd7'' AND GUID_Attribute=''0f8ff423-e407-4082-ab28-ec6b6cfe31d7'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''041ec955-ed78-4931-a491-2336b55d9bd7'',''0f8ff423-e407-4082-ab28-ec6b6cfe31d7'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'' AND GUID_Attribute=''6c72b7e7-a182-4135-9c4e-63c8885b07b8'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'',''6c72b7e7-a182-4135-9c4e-63c8885b07b8'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'' AND GUID_Attribute=''d4c755c1-4ebe-4c1c-9be1-89244e1bf8d3'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'',''d4c755c1-4ebe-4c1c-9be1-89244e1bf8d3'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'' AND GUID_Attribute=''e57ea6f4-77d5-4cc7-9070-d0ea3308092f'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'',''e57ea6f4-77d5-4cc7-9070-d0ea3308092f'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'' AND GUID_Attribute=''e364d837-b5d8-4c04-b951-e0bd1631334d'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'',''e364d837-b5d8-4c04-b951-e0bd1631334d'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_Attribute=''a1b49452-19dc-4eae-a000-ef3802de35a9'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''a1b49452-19dc-4eae-a000-ef3802de35a9'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_Attribute=''30b76a62-1b22-4f17-b9a5-ff665e08f35a'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''30b76a62-1b22-4f17-b9a5-ff665e08f35a'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_Type_Right=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_RelationType=''e1cc31b2-fdf0-4e52-bdcf-34ee60e5be75'')=0
	INSERT INTO semtbl_Type_Type VALUES(''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''e1cc31b2-fdf0-4e52-bdcf-34ee60e5be75'',0,-1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_Type_Right=''041ec955-ed78-4931-a491-2336b55d9bd7'' AND GUID_RelationType=''fcd7eb74-cc20-45e8-b37e-11e2b62c99a1'')=0
	INSERT INTO semtbl_Type_Type VALUES(''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''041ec955-ed78-4931-a491-2336b55d9bd7'',''fcd7eb74-cc20-45e8-b37e-11e2b62c99a1'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_Type_Right=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_RelationType=''7e709649-5791-4116-af93-263864214ffe'')=0
	INSERT INTO semtbl_Type_Type VALUES(''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''7e709649-5791-4116-af93-263864214ffe'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_Type_Right=''23ad9ceb-5c77-44f7-a5cd-eb61aa2f20f5'' AND GUID_RelationType=''050bf6fa-4754-48b0-952c-8bd11a442f2d'')=0
	INSERT INTO semtbl_Type_Type VALUES(''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''23ad9ceb-5c77-44f7-a5cd-eb61aa2f20f5'',''050bf6fa-4754-48b0-952c-8bd11a442f2d'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_Type_Right=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''408db9f1-ae42-4807-b656-729270646f0a'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c6c9bcb8-0ac9-4713-9417-eeec1453026c'' AND GUID_Type_Right=''13c09f11-175c-4eef-bc8a-0fd8e86d557f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c6c9bcb8-0ac9-4713-9417-eeec1453026c'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'' AND GUID_RelationType=''cf27679f-cbe7-4010-a3ae-472072762b33'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'',''cf27679f-cbe7-4010-a3ae-472072762b33'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''1d9568af-b6da-4990-8f4d-907dfdd30749'' AND GUID_RelationType=''cf27679f-cbe7-4010-a3ae-472072762b33'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''1d9568af-b6da-4990-8f4d-907dfdd30749'',''cf27679f-cbe7-4010-a3ae-472072762b33'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_RelationType=''7e709649-5791-4116-af93-263864214ffe'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''7e709649-5791-4116-af93-263864214ffe'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''c6c9bcb8-0ac9-4713-9417-eeec1453026c'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''c6c9bcb8-0ac9-4713-9417-eeec1453026c'',''fafc1464-815f-4596-9737-bcbc96bd744a'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''408db9f1-ae42-4807-b656-729270646f0a'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6489f44e-9d69-4ae9-871b-dfd7b8d312f3'')=0
	INSERT INTO semtbl_OR VALUES(''6489f44e-9d69-4ae9-871b-dfd7b8d312f3'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''3abba48d-996e-46c4-beeb-f8daad98c908'')=0
	INSERT INTO semtbl_OR VALUES(''3abba48d-996e-46c4-beeb-f8daad98c908'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''07024367-2073-47f5-a4c2-dee8b726cc2e'')=0
	INSERT INTO semtbl_OR VALUES(''07024367-2073-47f5-a4c2-dee8b726cc2e'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'')=0
	INSERT INTO semtbl_OR VALUES(''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8bfe19d4-c06b-48bd-8b91-1fb5cb480806'')=0
	INSERT INTO semtbl_OR VALUES(''8bfe19d4-c06b-48bd-8b91-1fb5cb480806'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''af1be1d2-cda1-4cbd-9d9d-5697bd3d7195'')=0
	INSERT INTO semtbl_OR VALUES(''af1be1d2-cda1-4cbd-9d9d-5697bd3d7195'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''22cff965-3c6a-431f-bb20-51c592e5e9f1'')=0
	INSERT INTO semtbl_OR VALUES(''22cff965-3c6a-431f-bb20-51c592e5e9f1'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''dab64e34-d13b-4cf4-81b2-f2cf06c25964'')=0
	INSERT INTO semtbl_OR VALUES(''dab64e34-d13b-4cf4-81b2-f2cf06c25964'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''c5e607dd-24fc-40c2-a1b8-60fc9e961175'')=0
	INSERT INTO semtbl_OR VALUES(''c5e607dd-24fc-40c2-a1b8-60fc9e961175'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e7441eb7-3a71-4726-b689-724cda546e0e'')=0
	INSERT INTO semtbl_OR VALUES(''e7441eb7-3a71-4726-b689-724cda546e0e'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''c838e185-7ddb-4fcb-b600-afaacd973d48'')=0
	INSERT INTO semtbl_OR VALUES(''c838e185-7ddb-4fcb-b600-afaacd973d48'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''1c3a6f24-4e86-42da-ab8e-987d41b3e125'')=0
	INSERT INTO semtbl_OR VALUES(''1c3a6f24-4e86-42da-ab8e-987d41b3e125'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''c579cf43-5c8e-4f2b-a74e-77ba85848aa4'')=0
	INSERT INTO semtbl_OR VALUES(''c579cf43-5c8e-4f2b-a74e-77ba85848aa4'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d54189bb-b402-4206-b626-94a63c42bb17'')=0
	INSERT INTO semtbl_OR VALUES(''d54189bb-b402-4206-b626-94a63c42bb17'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''da2fe369-a189-4196-9635-db1f2171ed24'')=0
	INSERT INTO semtbl_OR VALUES(''da2fe369-a189-4196-9635-db1f2171ed24'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ee8a6495-f003-41a9-8af5-90c7ce23349f'')=0
	INSERT INTO semtbl_OR VALUES(''ee8a6495-f003-41a9-8af5-90c7ce23349f'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''99fcdaf2-6789-4333-8295-12e61023011c'')=0
	INSERT INTO semtbl_OR VALUES(''99fcdaf2-6789-4333-8295-12e61023011c'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6e66ee0b-8b9a-4985-b4d2-f5989cd75364'')=0
	INSERT INTO semtbl_OR VALUES(''6e66ee0b-8b9a-4985-b4d2-f5989cd75364'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'')=0
	INSERT INTO semtbl_OR VALUES(''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'')=0
	INSERT INTO semtbl_OR VALUES(''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''a2c4a33b-c43e-4f05-b1b0-e5bd6851976d'')=0
	INSERT INTO semtbl_OR VALUES(''a2c4a33b-c43e-4f05-b1b0-e5bd6851976d'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6b3c89bb-e035-4e7b-804d-873614aa31fe'')=0
	INSERT INTO semtbl_OR VALUES(''6b3c89bb-e035-4e7b-804d-873614aa31fe'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''0cf0c0e6-bb80-4f3a-a294-ed3b889a573b'')=0
	INSERT INTO semtbl_OR VALUES(''0cf0c0e6-bb80-4f3a-a294-ed3b889a573b'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''949df552-05f6-450c-8cc9-775901d1c5df'')=0
	INSERT INTO semtbl_OR VALUES(''949df552-05f6-450c-8cc9-775901d1c5df'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''71aabfc8-0fc1-40b0-b3a3-ba3d854ab7c7'')=0
	INSERT INTO semtbl_OR VALUES(''71aabfc8-0fc1-40b0-b3a3-ba3d854ab7c7'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e60d2cf3-590a-4845-812a-636b32e46d73'')=0
	INSERT INTO semtbl_OR VALUES(''e60d2cf3-590a-4845-812a-636b32e46d73'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''97415200-78a2-485e-90f1-6555cf0a5c91'')=0
	INSERT INTO semtbl_OR VALUES(''97415200-78a2-485e-90f1-6555cf0a5c91'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'')=0
	INSERT INTO semtbl_OR VALUES(''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6b58904e-62b5-4fd9-a90b-18ab46c1957b'')=0
	INSERT INTO semtbl_OR VALUES(''6b58904e-62b5-4fd9-a90b-18ab46c1957b'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''07024367-2073-47f5-a4c2-dee8b726cc2e'')=0
	INSERT INTO semtbl_OR_Type VALUES(''07024367-2073-47f5-a4c2-dee8b726cc2e'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'')=0
	INSERT INTO semtbl_OR_Type VALUES(''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''8bfe19d4-c06b-48bd-8b91-1fb5cb480806'')=0
	INSERT INTO semtbl_OR_Type VALUES(''8bfe19d4-c06b-48bd-8b91-1fb5cb480806'',''3d1dc6cf-b964-4986-9808-f39b7c5c3907'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''dab64e34-d13b-4cf4-81b2-f2cf06c25964'')=0
	INSERT INTO semtbl_OR_Type VALUES(''dab64e34-d13b-4cf4-81b2-f2cf06c25964'',''041ec955-ed78-4931-a491-2336b55d9bd7'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''1c3a6f24-4e86-42da-ab8e-987d41b3e125'')=0
	INSERT INTO semtbl_OR_Type VALUES(''1c3a6f24-4e86-42da-ab8e-987d41b3e125'',''665dd88b-792e-4256-a27a-68ee1e10ece6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''d54189bb-b402-4206-b626-94a63c42bb17'')=0
	INSERT INTO semtbl_OR_Type VALUES(''d54189bb-b402-4206-b626-94a63c42bb17'',''23ad9ceb-5c77-44f7-a5cd-eb61aa2f20f5'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''da2fe369-a189-4196-9635-db1f2171ed24'')=0
	INSERT INTO semtbl_OR_Type VALUES(''da2fe369-a189-4196-9635-db1f2171ed24'',''b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''6e66ee0b-8b9a-4985-b4d2-f5989cd75364'')=0
	INSERT INTO semtbl_OR_Type VALUES(''6e66ee0b-8b9a-4985-b4d2-f5989cd75364'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''0cf0c0e6-bb80-4f3a-a294-ed3b889a573b'')=0
	INSERT INTO semtbl_OR_Type VALUES(''0cf0c0e6-bb80-4f3a-a294-ed3b889a573b'',''2f05c250-be33-4b77-ba3c-b8a0228821b6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''949df552-05f6-450c-8cc9-775901d1c5df'')=0
	INSERT INTO semtbl_OR_Type VALUES(''949df552-05f6-450c-8cc9-775901d1c5df'',''f47a3e1c-50b4-4666-a41d-e975597c9adb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''71aabfc8-0fc1-40b0-b3a3-ba3d854ab7c7'')=0
	INSERT INTO semtbl_OR_Type VALUES(''71aabfc8-0fc1-40b0-b3a3-ba3d854ab7c7'',''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'')=0
	INSERT INTO semtbl_OR_Type VALUES(''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''af1be1d2-cda1-4cbd-9d9d-5697bd3d7195'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''af1be1d2-cda1-4cbd-9d9d-5697bd3d7195'',''d9716e15-9624-4eed-89a8-d45bc0ceb2b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''e7441eb7-3a71-4726-b689-724cda546e0e'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''e7441eb7-3a71-4726-b689-724cda546e0e'',''30b76a62-1b22-4f17-b9a5-ff665e08f35a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''c838e185-7ddb-4fcb-b600-afaacd973d48'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''c838e185-7ddb-4fcb-b600-afaacd973d48'',''234a50e0-548d-46bf-8a04-82d68bf842e5'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''6b3c89bb-e035-4e7b-804d-873614aa31fe'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''6b3c89bb-e035-4e7b-804d-873614aa31fe'',''a1b49452-19dc-4eae-a000-ef3802de35a9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''e60d2cf3-590a-4845-812a-636b32e46d73'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''e60d2cf3-590a-4845-812a-636b32e46d73'',''0f8ff423-e407-4082-ab28-ec6b6cfe31d7'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''6b58904e-62b5-4fd9-a90b-18ab46c1957b'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''6b58904e-62b5-4fd9-a90b-18ab46c1957b'',''b66ed485-e41a-4c1f-b003-451991967cc8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''ee8a6495-f003-41a9-8af5-90c7ce23349f'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''ee8a6495-f003-41a9-8af5-90c7ce23349f'',''7e709649-5791-4116-af93-263864214ffe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''99fcdaf2-6789-4333-8295-12e61023011c'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''99fcdaf2-6789-4333-8295-12e61023011c'',''050bf6fa-4754-48b0-952c-8bd11a442f2d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'',''cf27679f-cbe7-4010-a3ae-472072762b33'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''a2c4a33b-c43e-4f05-b1b0-e5bd6851976d'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''a2c4a33b-c43e-4f05-b1b0-e5bd6851976d'',''eb05244b-4e49-4808-b81b-995f3ee6065a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''97415200-78a2-485e-90f1-6555cf0a5c91'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''97415200-78a2-485e-90f1-6555cf0a5c91'',''fcd7eb74-cc20-45e8-b37e-11e2b62c99a1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''6489f44e-9d69-4ae9-871b-dfd7b8d312f3'')=0
	INSERT INTO semtbl_OR_Token VALUES(''6489f44e-9d69-4ae9-871b-dfd7b8d312f3'',''52c468e3-fc34-4095-a4f0-fef640f93517'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''3abba48d-996e-46c4-beeb-f8daad98c908'')=0
	INSERT INTO semtbl_OR_Token VALUES(''3abba48d-996e-46c4-beeb-f8daad98c908'',''05ce853c-ce41-4eea-8a11-caa578c337de'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''22cff965-3c6a-431f-bb20-51c592e5e9f1'')=0
	INSERT INTO semtbl_OR_Token VALUES(''22cff965-3c6a-431f-bb20-51c592e5e9f1'',''11f634d0-6673-4e6b-8164-7123e169c9de'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''c5e607dd-24fc-40c2-a1b8-60fc9e961175'')=0
	INSERT INTO semtbl_OR_Token VALUES(''c5e607dd-24fc-40c2-a1b8-60fc9e961175'',''7647f6a9-1348-469e-8b43-7f4b8d195183'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''c579cf43-5c8e-4f2b-a74e-77ba85848aa4'')=0
	INSERT INTO semtbl_OR_Token VALUES(''c579cf43-5c8e-4f2b-a74e-77ba85848aa4'',''cbf10cd8-e3d8-4e3f-82d9-a5547498b0c9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''fc5609f3-fd7c-44aa-9744-0063b1c6f95e'' AND GUID_ObjectReference=''6489f44e-9d69-4ae9-871b-dfd7b8d312f3'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''fc5609f3-fd7c-44aa-9744-0063b1c6f95e'',''6489f44e-9d69-4ae9-871b-dfd7b8d312f3'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''1b0b153a-f0a8-4218-b579-0472f00f6f43'' AND GUID_ObjectReference=''3abba48d-996e-46c4-beeb-f8daad98c908'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''1b0b153a-f0a8-4218-b579-0472f00f6f43'',''3abba48d-996e-46c4-beeb-f8daad98c908'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''1d7fefa9-2304-450d-9a4a-0a3c4be58ccc'' AND GUID_ObjectReference=''07024367-2073-47f5-a4c2-dee8b726cc2e'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''1d7fefa9-2304-450d-9a4a-0a3c4be58ccc'',''07024367-2073-47f5-a4c2-dee8b726cc2e'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'' AND GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''53f76bfa-93cd-4ceb-9afe-0cea9c338e68'' AND GUID_ObjectReference=''8bfe19d4-c06b-48bd-8b91-1fb5cb480806'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''53f76bfa-93cd-4ceb-9afe-0cea9c338e68'',''8bfe19d4-c06b-48bd-8b91-1fb5cb480806'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''77a54faf-aef7-47f0-8831-0ea2bae84aee'' AND GUID_ObjectReference=''af1be1d2-cda1-4cbd-9d9d-5697bd3d7195'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''77a54faf-aef7-47f0-8831-0ea2bae84aee'',''af1be1d2-cda1-4cbd-9d9d-5697bd3d7195'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''2fe835b6-edef-437c-b069-1216e4c77b46'' AND GUID_ObjectReference=''22cff965-3c6a-431f-bb20-51c592e5e9f1'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''2fe835b6-edef-437c-b069-1216e4c77b46'',''22cff965-3c6a-431f-bb20-51c592e5e9f1'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d47fc40f-323c-446b-8a96-17a3de704f93'' AND GUID_ObjectReference=''dab64e34-d13b-4cf4-81b2-f2cf06c25964'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d47fc40f-323c-446b-8a96-17a3de704f93'',''dab64e34-d13b-4cf4-81b2-f2cf06c25964'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''5f04d3aa-694e-46a7-801e-19d44774342e'' AND GUID_ObjectReference=''c5e607dd-24fc-40c2-a1b8-60fc9e961175'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''5f04d3aa-694e-46a7-801e-19d44774342e'',''c5e607dd-24fc-40c2-a1b8-60fc9e961175'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ca828f58-ede1-41f2-bf80-204e09646be4'' AND GUID_ObjectReference=''e7441eb7-3a71-4726-b689-724cda546e0e'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ca828f58-ede1-41f2-bf80-204e09646be4'',''e7441eb7-3a71-4726-b689-724cda546e0e'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''fa3d85ef-eb88-4457-9a87-288193c81354'' AND GUID_ObjectReference=''c838e185-7ddb-4fcb-b600-afaacd973d48'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''fa3d85ef-eb88-4457-9a87-288193c81354'',''c838e185-7ddb-4fcb-b600-afaacd973d48'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f8fe8cf8-e39a-4bed-b872-28b9fea65d9d'' AND GUID_ObjectReference=''1c3a6f24-4e86-42da-ab8e-987d41b3e125'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f8fe8cf8-e39a-4bed-b872-28b9fea65d9d'',''1c3a6f24-4e86-42da-ab8e-987d41b3e125'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''54b79b2b-3068-493d-a1f3-2cf05dac6a85'' AND GUID_ObjectReference=''c579cf43-5c8e-4f2b-a74e-77ba85848aa4'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''54b79b2b-3068-493d-a1f3-2cf05dac6a85'',''c579cf43-5c8e-4f2b-a74e-77ba85848aa4'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''70c70898-53ed-4e40-bdf8-2ddb5b369c85'' AND GUID_ObjectReference=''d54189bb-b402-4206-b626-94a63c42bb17'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''70c70898-53ed-4e40-bdf8-2ddb5b369c85'',''d54189bb-b402-4206-b626-94a63c42bb17'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''dd378ef1-7f29-4702-98ff-38efc318037f'' AND GUID_ObjectReference=''da2fe369-a189-4196-9635-db1f2171ed24'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''dd378ef1-7f29-4702-98ff-38efc318037f'',''da2fe369-a189-4196-9635-db1f2171ed24'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e407ccec-9732-497f-811b-40e05449d97d'' AND GUID_ObjectReference=''ee8a6495-f003-41a9-8af5-90c7ce23349f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e407ccec-9732-497f-811b-40e05449d97d'',''ee8a6495-f003-41a9-8af5-90c7ce23349f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''31f8be26-616c-49bf-a7d6-46957e65b859'' AND GUID_ObjectReference=''99fcdaf2-6789-4333-8295-12e61023011c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''31f8be26-616c-49bf-a7d6-46957e65b859'',''99fcdaf2-6789-4333-8295-12e61023011c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d09dabad-6d47-48a9-8ea7-64d011d76d4e'' AND GUID_ObjectReference=''6e66ee0b-8b9a-4985-b4d2-f5989cd75364'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d09dabad-6d47-48a9-8ea7-64d011d76d4e'',''6e66ee0b-8b9a-4985-b4d2-f5989cd75364'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8e96640d-b873-4a50-b272-6b1376b26852'' AND GUID_ObjectReference=''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8e96640d-b873-4a50-b272-6b1376b26852'',''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f2cde058-614e-41cb-96eb-78bbcf285171'' AND GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f2cde058-614e-41cb-96eb-78bbcf285171'',''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f0750b76-7682-4f3d-861e-83d9e703916e'' AND GUID_ObjectReference=''a2c4a33b-c43e-4f05-b1b0-e5bd6851976d'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f0750b76-7682-4f3d-861e-83d9e703916e'',''a2c4a33b-c43e-4f05-b1b0-e5bd6851976d'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''28c896af-a0f2-465b-925a-9b26fbc84d1e'' AND GUID_ObjectReference=''6b3c89bb-e035-4e7b-804d-873614aa31fe'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''28c896af-a0f2-465b-925a-9b26fbc84d1e'',''6b3c89bb-e035-4e7b-804d-873614aa31fe'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f5658dca-283f-43d8-b4cc-ac78f064d0f8'' AND GUID_ObjectReference=''0cf0c0e6-bb80-4f3a-a294-ed3b889a573b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f5658dca-283f-43d8-b4cc-ac78f064d0f8'',''0cf0c0e6-bb80-4f3a-a294-ed3b889a573b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''923108a1-c159-4d69-affe-ae048460dd24'' AND GUID_ObjectReference=''949df552-05f6-450c-8cc9-775901d1c5df'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''923108a1-c159-4d69-affe-ae048460dd24'',''949df552-05f6-450c-8cc9-775901d1c5df'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''4ce41b7a-2fb9-4df6-b67a-c5aca2e46da1'' AND GUID_ObjectReference=''71aabfc8-0fc1-40b0-b3a3-ba3d854ab7c7'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''4ce41b7a-2fb9-4df6-b67a-c5aca2e46da1'',''71aabfc8-0fc1-40b0-b3a3-ba3d854ab7c7'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e515708f-6eda-483a-9ab3-cec2872f1720'' AND GUID_ObjectReference=''e60d2cf3-590a-4845-812a-636b32e46d73'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e515708f-6eda-483a-9ab3-cec2872f1720'',''e60d2cf3-590a-4845-812a-636b32e46d73'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''759851bb-e1ff-40a9-996c-cf6f2dbd3bcd'' AND GUID_ObjectReference=''97415200-78a2-485e-90f1-6555cf0a5c91'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''759851bb-e1ff-40a9-996c-cf6f2dbd3bcd'',''97415200-78a2-485e-90f1-6555cf0a5c91'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'' AND GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f80322ed-326f-4145-b7a1-dd8a3fcfc247'' AND GUID_ObjectReference=''6b58904e-62b5-4fd9-a90b-18ab46c1957b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f80322ed-326f-4145-b7a1-dd8a3fcfc247'',''6b58904e-62b5-4fd9-a90b-18ab46c1957b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''13c09f11-175c-4eef-bc8a-0fd8e86d557f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''13c09f11-175c-4eef-bc8a-0fd8e86d557f'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''041ec955-ed78-4931-a491-2336b55d9bd7'' AND GUID_RelationType=''fcd7eb74-cc20-45e8-b37e-11e2b62c99a1'')=0
	INSERT INTO semtbl_Type_OR VALUES(''041ec955-ed78-4931-a491-2336b55d9bd7'',''fcd7eb74-cc20-45e8-b37e-11e2b62c99a1'',0,-1)'
GO