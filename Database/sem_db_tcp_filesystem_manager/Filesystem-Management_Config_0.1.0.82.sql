execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'') = 0
	insert into semtbl_Attribute VALUES(''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'',''Blob'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''b67c3f3c-da03-4693-9afc-d2014997e328'') = 0
	insert into semtbl_Attribute VALUES(''b67c3f3c-da03-4693-9afc-d2014997e328'',''Datetimestamp (Create)'',''905fda81-788f-4e3d-8329-3e55ae984b9e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''bf4b121d-4cbc-4cb0-9062-9fcbdbf4032f'') = 0
	insert into semtbl_Attribute VALUES(''bf4b121d-4cbc-4cb0-9062-9fcbdbf4032f'',''Path'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''a1b49452-19dc-4eae-a000-ef3802de35a9'') = 0
	insert into semtbl_Attribute VALUES(''a1b49452-19dc-4eae-a000-ef3802de35a9'',''ProcessorID'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''30b76a62-1b22-4f17-b9a5-ff665e08f35a'') = 0
	insert into semtbl_Attribute VALUES(''30b76a62-1b22-4f17-b9a5-ff665e08f35a'',''BaseboardSerial'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''d777cd8b-b212-4f83-b67e-da8586f97eca'') = 0
	insert into semtbl_Attribute VALUES(''d777cd8b-b212-4f83-b67e-da8586f97eca'',''is Sem-DB'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''4f8f29b4-49bb-4d85-a65f-205d2af4f509'')=0
	insert into semtbl_RelationType VALUES(''4f8f29b4-49bb-4d85-a65f-205d2af4f509'',''is checkout by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''cf27679f-cbe7-4010-a3ae-472072762b33'')=0
	insert into semtbl_RelationType VALUES(''cf27679f-cbe7-4010-a3ae-472072762b33'',''is in State'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	insert into semtbl_RelationType VALUES(''9996494a-ef6a-4357-a6ef-71a92b5ff596'',''is of Type'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	insert into semtbl_RelationType VALUES(''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',''offered by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	insert into semtbl_RelationType VALUES(''e07469d9-766c-443e-8526-6d9c684f944f'',''belongs to'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	insert into semtbl_RelationType VALUES(''408db9f1-ae42-4807-b656-729270646f0a'',''is subordinated'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''5621cb25-972d-4166-9c77-c37ee764a0b7'')=0
	insert into semtbl_RelationType VALUES(''5621cb25-972d-4166-9c77-c37ee764a0b7'',''watch'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e1cc31b2-fdf0-4e52-bdcf-34ee60e5be75'')=0
	insert into semtbl_RelationType VALUES(''e1cc31b2-fdf0-4e52-bdcf-34ee60e5be75'',''Fileshare'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'')=0
	insert into semtbl_RelationType VALUES(''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'',''located in'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''2461e5ba-cd55-4a52-9c18-ebab166eba22'')=0
	insert into semtbl_RelationType VALUES(''2461e5ba-cd55-4a52-9c18-ebab166eba22'',''ends with'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''7e709649-5791-4116-af93-263864214ffe'')=0
	insert into semtbl_RelationType VALUES(''7e709649-5791-4116-af93-263864214ffe'',''Sources located in'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''be8c7e8f-9b0b-4adc-8f0b-8f8f1ae47f87'')=0
	insert into semtbl_RelationType VALUES(''be8c7e8f-9b0b-4adc-8f0b-8f8f1ae47f87'',''relative'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	insert into semtbl_RelationType VALUES(''e9711603-47db-44d8-a476-fe88290639a4'',''contains'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	insert into semtbl_RelationType VALUES(''fafc1464-815f-4596-9737-bcbc96bd744a'',''needs'')'
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='665dd88b-792e-4256-a27a-68ee1e10ece6') = 0
	insert into semtbl_Type VALUES('665dd88b-792e-4256-a27a-68ee1e10ece6','System','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='2f05c250-be33-4b77-ba3c-b8a0228821b6') = 0
	insert into semtbl_Type VALUES('2f05c250-be33-4b77-ba3c-b8a0228821b6','Filesystem-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='d7a03a35-8751-42b4-8e05-19fc7a77ee91') = 0
	insert into semtbl_Type VALUES('d7a03a35-8751-42b4-8e05-19fc7a77ee91','Server','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='7c2f4f6a-a1f3-4a61-b6eb-9a8eced06cc2') = 0
	insert into semtbl_Type VALUES('7c2f4f6a-a1f3-4a61-b6eb-9a8eced06cc2','Server-Type','d7a03a35-8751-42b4-8e05-19fc7a77ee91')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='cf8f059d-eb85-4749-bc45-5f415417216f') = 0
	insert into semtbl_Type VALUES('cf8f059d-eb85-4749-bc45-5f415417216f','Server-State','d7a03a35-8751-42b4-8e05-19fc7a77ee91')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='6eb4fdd3-2e25-4886-b288-e1bfc2857efb') = 0
	insert into semtbl_Type VALUES('6eb4fdd3-2e25-4886-b288-e1bfc2857efb','File','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='ba76b764-1343-41d6-9973-ca181c4fabc8') = 0
	insert into semtbl_Type VALUES('ba76b764-1343-41d6-9973-ca181c4fabc8','Filetypes','6eb4fdd3-2e25-4886-b288-e1bfc2857efb')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='6e31f905-20ce-4f8f-b401-6da5ba871ecb') = 0
	insert into semtbl_Type VALUES('6e31f905-20ce-4f8f-b401-6da5ba871ecb','Extensions','ba76b764-1343-41d6-9973-ca181c4fabc8')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='cd159d56-e3d4-4eb9-a8ee-f3eaba3b79d3') = 0
	insert into semtbl_Type VALUES('cd159d56-e3d4-4eb9-a8ee-f3eaba3b79d3','Drive','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='f47a3e1c-50b4-4666-a41d-e975597c9adb') = 0
	insert into semtbl_Type VALUES('f47a3e1c-50b4-4666-a41d-e975597c9adb','Folder','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='8a894710-e08c-42c5-b829-ef4809830d33') = 0
	insert into semtbl_Type VALUES('8a894710-e08c-42c5-b829-ef4809830d33','Path','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747') = 0
	insert into semtbl_Type VALUES('b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747','Module-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='aa616051-e521-4fac-abdb-cbba6f8c6e73') = 0
	insert into semtbl_Type VALUES('aa616051-e521-4fac-abdb-cbba6f8c6e73','Module','b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='c864bf98-78d2-461a-9e6c-1d2316f40575') = 0
	insert into semtbl_Type VALUES('c864bf98-78d2-461a-9e6c-1d2316f40575','BlobDirWatcher','aa616051-e521-4fac-abdb-cbba6f8c6e73')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='53136d10-b7e7-47fc-94ad-7887a354d6e1') = 0
	insert into semtbl_Type VALUES('53136d10-b7e7-47fc-94ad-7887a354d6e1','Log-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='1d9568af-b6da-4990-8f4d-907dfdd30749') = 0
	insert into semtbl_Type VALUES('1d9568af-b6da-4990-8f4d-907dfdd30749','Logstate','53136d10-b7e7-47fc-94ad-7887a354d6e1')
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''aae18585-4655-4f4d-b898-662be2082df5'') = 0
	insert into semtbl_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''Filesystem-Management'',''c6c9bcb8-0ac9-4713-9417-eeec1453026c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''488fe6a8-ac90-4871-8e3a-598667ba8828'') = 0
	insert into semtbl_Token VALUES(''488fe6a8-ac90-4871-8e3a-598667ba8828'',''Filesystem-Management'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a8c491fc-69b6-4039-bdb6-03ad1d217765'') = 0
	insert into semtbl_Token VALUES(''a8c491fc-69b6-4039-bdb6-03ad1d217765'',''Type_Server_Type'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'') = 0
	insert into semtbl_Token VALUES(''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''Type_Module'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'') = 0
	insert into semtbl_Token VALUES(''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'',''Type_Database'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3b443150-eb19-4393-80ce-1be64faaab8f'') = 0
	insert into semtbl_Token VALUES(''3b443150-eb19-4393-80ce-1be64faaab8f'',''Token_Fileserver_Server_Type'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''94e8dbd1-ac07-45a2-8a5c-5c032794e6b8'') = 0
	insert into semtbl_Token VALUES(''94e8dbd1-ac07-45a2-8a5c-5c032794e6b8'',''Type_Extensions'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e5c41e3c-b4ed-41c8-9eb5-5f17332cd15b'') = 0
	insert into semtbl_Token VALUES(''e5c41e3c-b4ed-41c8-9eb5-5f17332cd15b'',''Type_Server_State'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b6c8f6a5-9452-40fc-95e9-623712bd51bf'') = 0
	insert into semtbl_Token VALUES(''b6c8f6a5-9452-40fc-95e9-623712bd51bf'',''Attribute_Blob'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''093d019a-c9e8-4faa-b604-65ffa216d309'') = 0
	insert into semtbl_Token VALUES(''093d019a-c9e8-4faa-b604-65ffa216d309'',''RelationType_is_checkout_by'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8e96640d-b873-4a50-b272-6b1376b26852'') = 0
	insert into semtbl_Token VALUES(''8e96640d-b873-4a50-b272-6b1376b26852'',''RelationType_isInState'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'') = 0
	insert into semtbl_Token VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''attribute_dbPostfix'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6e494944-f602-4dcb-906f-70e5efe8f1dd'') = 0
	insert into semtbl_Token VALUES(''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''RelationType_is_of_Type'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6ef2b776-c536-4af8-8195-756a5170a10a'') = 0
	insert into semtbl_Token VALUES(''6ef2b776-c536-4af8-8195-756a5170a10a'',''Type_Drive'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f2cde058-614e-41cb-96eb-78bbcf285171'') = 0
	insert into semtbl_Token VALUES(''f2cde058-614e-41cb-96eb-78bbcf285171'',''RelationType_offered_by'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5c218446-83ed-4fd1-b110-9d06d4fd78ce'') = 0
	insert into semtbl_Token VALUES(''5c218446-83ed-4fd1-b110-9d06d4fd78ce'',''Token_Active_Server_State'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3186cc5e-023b-4edc-b6c7-a89919320839'') = 0
	insert into semtbl_Token VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''RelationType_belongsTo'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f5658dca-283f-43d8-b4cc-ac78f064d0f8'') = 0
	insert into semtbl_Token VALUES(''f5658dca-283f-43d8-b4cc-ac78f064d0f8'',''Type_Filesystem_Management'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''923108a1-c159-4d69-affe-ae048460dd24'') = 0
	insert into semtbl_Token VALUES(''923108a1-c159-4d69-affe-ae048460dd24'',''type_Folder'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8a6a3874-7e7b-4c41-b43a-b0349e39113b'') = 0
	insert into semtbl_Token VALUES(''8a6a3874-7e7b-4c41-b43a-b0349e39113b'',''Type_Path'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f1ba23ed-ab41-4d34-8e09-b4e485671478'') = 0
	insert into semtbl_Token VALUES(''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''Type_File'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''26d91bb9-0af4-491b-8d48-b53e08f7abe3'') = 0
	insert into semtbl_Token VALUES(''26d91bb9-0af4-491b-8d48-b53e08f7abe3'',''RelationType_isSubordinated'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f54e093f-554b-47ec-80b2-bc3be3f6d260'') = 0
	insert into semtbl_Token VALUES(''f54e093f-554b-47ec-80b2-bc3be3f6d260'',''RelationType_watch'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cd862075-aef5-478d-8b96-c0b2619bca7d'') = 0
	insert into semtbl_Token VALUES(''cd862075-aef5-478d-8b96-c0b2619bca7d'',''RelationType_Fileshare'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'') = 0
	insert into semtbl_Token VALUES(''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'',''Type_Database_on_Server'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''daf64676-3baa-44fe-8f19-c810776d4e29'') = 0
	insert into semtbl_Token VALUES(''daf64676-3baa-44fe-8f19-c810776d4e29'',''token_LogState_Active'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f8a8cd69-2c45-40b8-bf60-cad253a05014'') = 0
	insert into semtbl_Token VALUES(''f8a8cd69-2c45-40b8-bf60-cad253a05014'',''Token_Module_Filesystem_Management'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8618f96e-8494-432a-99da-cc91e6c117d5'') = 0
	insert into semtbl_Token VALUES(''8618f96e-8494-432a-99da-cc91e6c117d5'',''RelationType_located_in'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7356d8f9-3a09-4522-be25-d0c378732d65'') = 0
	insert into semtbl_Token VALUES(''7356d8f9-3a09-4522-be25-d0c378732d65'',''Attribute_Datetimestamp__Create_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'') = 0
	insert into semtbl_Token VALUES(''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''Type_Server'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3bc41b59-2d97-4b5d-8ba3-dec5d849d1df'') = 0
	insert into semtbl_Token VALUES(''3bc41b59-2d97-4b5d-8ba3-dec5d849d1df'',''RelationType_ends_with'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''218c3e22-6e53-49d3-8cdb-e91ecd9b6d0c'') = 0
	insert into semtbl_Token VALUES(''218c3e22-6e53-49d3-8cdb-e91ecd9b6d0c'',''Attribute_Path'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''88cf5098-5944-46bc-8030-f8c4b5348859'') = 0
	insert into semtbl_Token VALUES(''88cf5098-5944-46bc-8030-f8c4b5348859'',''Type_BlobDirWatcher'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''017234b8-7e15-475e-9154-25e45c74697f'') = 0
	insert into semtbl_Token VALUES(''017234b8-7e15-475e-9154-25e45c74697f'',''Fileserver'',''7c2f4f6a-a1f3-4a61-b6eb-9a8eced06cc2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4ee53bf6-be79-459e-86dd-d648d0519fe2'') = 0
	insert into semtbl_Token VALUES(''4ee53bf6-be79-459e-86dd-d648d0519fe2'',''Active'',''cf8f059d-eb85-4749-bc45-5f415417216f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''aabfd0bc-070f-43d0-9ea2-0f7ba13612ce'') = 0
	insert into semtbl_Token VALUES(''aabfd0bc-070f-43d0-9ea2-0f7ba13612ce'',''Active'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0c6ed922-5732-418d-97d8-e610ea9c7111'') = 0
	insert into semtbl_Token VALUES(''0c6ed922-5732-418d-97d8-e610ea9c7111'',''Filesystem-Management'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7bf1cb3e-e243-424c-a833-66f138b731d3'') = 0
	insert into semtbl_Token VALUES(''7bf1cb3e-e243-424c-a833-66f138b731d3'',''BaseConfig'',''c864bf98-78d2-461a-9e6c-1d2316f40575'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''a8c491fc-69b6-4039-bdb6-03ad1d217765'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''a8c491fc-69b6-4039-bdb6-03ad1d217765'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''3b443150-eb19-4393-80ce-1be64faaab8f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''3b443150-eb19-4393-80ce-1be64faaab8f'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''94e8dbd1-ac07-45a2-8a5c-5c032794e6b8'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''94e8dbd1-ac07-45a2-8a5c-5c032794e6b8'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''e5c41e3c-b4ed-41c8-9eb5-5f17332cd15b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''e5c41e3c-b4ed-41c8-9eb5-5f17332cd15b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''b6c8f6a5-9452-40fc-95e9-623712bd51bf'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''b6c8f6a5-9452-40fc-95e9-623712bd51bf'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''093d019a-c9e8-4faa-b604-65ffa216d309'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''093d019a-c9e8-4faa-b604-65ffa216d309'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''8e96640d-b873-4a50-b272-6b1376b26852'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''8e96640d-b873-4a50-b272-6b1376b26852'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''e9711603-47db-44d8-a476-fe88290639a4'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''6e494944-f602-4dcb-906f-70e5efe8f1dd'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''6ef2b776-c536-4af8-8195-756a5170a10a'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''6ef2b776-c536-4af8-8195-756a5170a10a'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''f2cde058-614e-41cb-96eb-78bbcf285171'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''f2cde058-614e-41cb-96eb-78bbcf285171'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''5c218446-83ed-4fd1-b110-9d06d4fd78ce'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''5c218446-83ed-4fd1-b110-9d06d4fd78ce'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''3186cc5e-023b-4edc-b6c7-a89919320839'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''f5658dca-283f-43d8-b4cc-ac78f064d0f8'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''f5658dca-283f-43d8-b4cc-ac78f064d0f8'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''923108a1-c159-4d69-affe-ae048460dd24'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''923108a1-c159-4d69-affe-ae048460dd24'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''8a6a3874-7e7b-4c41-b43a-b0349e39113b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''8a6a3874-7e7b-4c41-b43a-b0349e39113b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''f1ba23ed-ab41-4d34-8e09-b4e485671478'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''26d91bb9-0af4-491b-8d48-b53e08f7abe3'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''26d91bb9-0af4-491b-8d48-b53e08f7abe3'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''f54e093f-554b-47ec-80b2-bc3be3f6d260'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''f54e093f-554b-47ec-80b2-bc3be3f6d260'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''cd862075-aef5-478d-8b96-c0b2619bca7d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''cd862075-aef5-478d-8b96-c0b2619bca7d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''daf64676-3baa-44fe-8f19-c810776d4e29'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''daf64676-3baa-44fe-8f19-c810776d4e29'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''f8a8cd69-2c45-40b8-bf60-cad253a05014'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''f8a8cd69-2c45-40b8-bf60-cad253a05014'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''8618f96e-8494-432a-99da-cc91e6c117d5'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''8618f96e-8494-432a-99da-cc91e6c117d5'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''7356d8f9-3a09-4522-be25-d0c378732d65'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''7356d8f9-3a09-4522-be25-d0c378732d65'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''3bc41b59-2d97-4b5d-8ba3-dec5d849d1df'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''3bc41b59-2d97-4b5d-8ba3-dec5d849d1df'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''218c3e22-6e53-49d3-8cdb-e91ecd9b6d0c'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''218c3e22-6e53-49d3-8cdb-e91ecd9b6d0c'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_Token_Right=''88cf5098-5944-46bc-8030-f8c4b5348859'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aae18585-4655-4f4d-b898-662be2082df5'',''88cf5098-5944-46bc-8030-f8c4b5348859'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''488fe6a8-ac90-4871-8e3a-598667ba8828'' AND GUID_Token_Right=''aabfd0bc-070f-43d0-9ea2-0f7ba13612ce'' AND GUID_RelationType=''cf27679f-cbe7-4010-a3ae-472072762b33'')=0
	INSERT INTO semtbl_Token_Token VALUES(''488fe6a8-ac90-4871-8e3a-598667ba8828'',''aabfd0bc-070f-43d0-9ea2-0f7ba13612ce'',''cf27679f-cbe7-4010-a3ae-472072762b33'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''488fe6a8-ac90-4871-8e3a-598667ba8828'' AND GUID_Token_Right=''aae18585-4655-4f4d-b898-662be2082df5'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Token_Token VALUES(''488fe6a8-ac90-4871-8e3a-598667ba8828'',''aae18585-4655-4f4d-b898-662be2082df5'',''fafc1464-815f-4596-9737-bcbc96bd744a'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''0c6ed922-5732-418d-97d8-e610ea9c7111'' AND GUID_Token_Right=''488fe6a8-ac90-4871-8e3a-598667ba8828'' AND GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	INSERT INTO semtbl_Token_Token VALUES(''0c6ed922-5732-418d-97d8-e610ea9c7111'',''488fe6a8-ac90-4871-8e3a-598667ba8828'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''7bf1cb3e-e243-424c-a833-66f138b731d3'' AND GUID_Token_Right=''0c6ed922-5732-418d-97d8-e610ea9c7111'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''7bf1cb3e-e243-424c-a833-66f138b731d3'',''0c6ed922-5732-418d-97d8-e610ea9c7111'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_Attribute=''a1b49452-19dc-4eae-a000-ef3802de35a9'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''a1b49452-19dc-4eae-a000-ef3802de35a9'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_Attribute=''30b76a62-1b22-4f17-b9a5-ff665e08f35a'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''30b76a62-1b22-4f17-b9a5-ff665e08f35a'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''f8a525de-72bb-4904-941f-63a40ce34234'' AND GUID_Attribute=''d777cd8b-b212-4f83-b67e-da8586f97eca'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''f8a525de-72bb-4904-941f-63a40ce34234'',''d777cd8b-b212-4f83-b67e-da8586f97eca'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Attribute=''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Attribute=''b67c3f3c-da03-4693-9afc-d2014997e328'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''b67c3f3c-da03-4693-9afc-d2014997e328'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_Type_Right=''cf8f059d-eb85-4749-bc45-5f415417216f'' AND GUID_RelationType=''cf27679f-cbe7-4010-a3ae-472072762b33'')=0
	INSERT INTO semtbl_Type_Type VALUES(''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''cf8f059d-eb85-4749-bc45-5f415417216f'',''cf27679f-cbe7-4010-a3ae-472072762b33'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_Type_Right=''7c2f4f6a-a1f3-4a61-b6eb-9a8eced06cc2'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Type_Type VALUES(''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''7c2f4f6a-a1f3-4a61-b6eb-9a8eced06cc2'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_Type_Right=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_RelationType=''e1cc31b2-fdf0-4e52-bdcf-34ee60e5be75'')=0
	INSERT INTO semtbl_Type_Type VALUES(''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''e1cc31b2-fdf0-4e52-bdcf-34ee60e5be75'',0,-1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c864bf98-78d2-461a-9e6c-1d2316f40575'' AND GUID_Type_Right=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c864bf98-78d2-461a-9e6c-1d2316f40575'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c864bf98-78d2-461a-9e6c-1d2316f40575'' AND GUID_Type_Right=''8a894710-e08c-42c5-b829-ef4809830d33'' AND GUID_RelationType=''5621cb25-972d-4166-9c77-c37ee764a0b7'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c864bf98-78d2-461a-9e6c-1d2316f40575'',''8a894710-e08c-42c5-b829-ef4809830d33'',''5621cb25-972d-4166-9c77-c37ee764a0b7'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'' AND GUID_Type_Right=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_RelationType=''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'')=0
	INSERT INTO semtbl_Type_Type VALUES(''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'' AND GUID_Type_Right=''f8a525de-72bb-4904-941f-63a40ce34234'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'',''f8a525de-72bb-4904-941f-63a40ce34234'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''ba76b764-1343-41d6-9973-ca181c4fabc8'' AND GUID_Type_Right=''6e31f905-20ce-4f8f-b401-6da5ba871ecb'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Type_Type VALUES(''ba76b764-1343-41d6-9973-ca181c4fabc8'',''6e31f905-20ce-4f8f-b401-6da5ba871ecb'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_Type_Right=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_RelationType=''7e709649-5791-4116-af93-263864214ffe'')=0
	INSERT INTO semtbl_Type_Type VALUES(''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''7e709649-5791-4116-af93-263864214ffe'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_RelationType=''4f8f29b4-49bb-4d85-a65f-205d2af4f509'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''4f8f29b4-49bb-4d85-a65f-205d2af4f509'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''6e31f905-20ce-4f8f-b401-6da5ba871ecb'' AND GUID_RelationType=''2461e5ba-cd55-4a52-9c18-ebab166eba22'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''6e31f905-20ce-4f8f-b401-6da5ba871ecb'',''2461e5ba-cd55-4a52-9c18-ebab166eba22'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''ba76b764-1343-41d6-9973-ca181c4fabc8'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''ba76b764-1343-41d6-9973-ca181c4fabc8'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''408db9f1-ae42-4807-b656-729270646f0a'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''8a894710-e08c-42c5-b829-ef4809830d33'' AND GUID_RelationType=''be8c7e8f-9b0b-4adc-8f0b-8f8f1ae47f87'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''8a894710-e08c-42c5-b829-ef4809830d33'',''be8c7e8f-9b0b-4adc-8f0b-8f8f1ae47f87'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''cd159d56-e3d4-4eb9-a8ee-f3eaba3b79d3'' AND GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''cd159d56-e3d4-4eb9-a8ee-f3eaba3b79d3'',''408db9f1-ae42-4807-b656-729270646f0a'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_Type_Right=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''408db9f1-ae42-4807-b656-729270646f0a'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_Type_Right=''cd159d56-e3d4-4eb9-a8ee-f3eaba3b79d3'' AND GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''cd159d56-e3d4-4eb9-a8ee-f3eaba3b79d3'',''408db9f1-ae42-4807-b656-729270646f0a'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c6c9bcb8-0ac9-4713-9417-eeec1453026c'' AND GUID_Type_Right=''13c09f11-175c-4eef-bc8a-0fd8e86d557f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c6c9bcb8-0ac9-4713-9417-eeec1453026c'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''cd159d56-e3d4-4eb9-a8ee-f3eaba3b79d3'' AND GUID_Type_Right=''d7a03a35-8751-42b4-8e05-19fc7a77ee91'' AND GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''cd159d56-e3d4-4eb9-a8ee-f3eaba3b79d3'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'',''408db9f1-ae42-4807-b656-729270646f0a'',1,1,-1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''fafc1464-815f-4596-9737-bcbc96bd744a'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''7c269b91-4edd-4723-9ecb-7c4157dd188f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''7c269b91-4edd-4723-9ecb-7c4157dd188f'',''488fe6a8-ac90-4871-8e3a-598667ba8828'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Varchar255 WHERE GUID_TokenAttribute=''7c269b91-4edd-4723-9ecb-7c4157dd188f'' )=0
	INSERT INTO semtbl_Token_Attribute_Varchar255 VALUES(''7c269b91-4edd-4723-9ecb-7c4157dd188f'',''filesystem_manager'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''7a6efbcd-36f1-4914-bc22-4289cf9f380b'')=0
	INSERT INTO semtbl_OR VALUES(''7a6efbcd-36f1-4914-bc22-4289cf9f380b'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'')=0
	INSERT INTO semtbl_OR VALUES(''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''93ab0ef5-fb55-41aa-862e-79e161c2052c'')=0
	INSERT INTO semtbl_OR VALUES(''93ab0ef5-fb55-41aa-862e-79e161c2052c'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6d4eab95-a15d-4776-9ed5-d599e5d27c88'')=0
	INSERT INTO semtbl_OR VALUES(''6d4eab95-a15d-4776-9ed5-d599e5d27c88'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''56ecc811-8fe4-4b06-915b-6cf29696b317'')=0
	INSERT INTO semtbl_OR VALUES(''56ecc811-8fe4-4b06-915b-6cf29696b317'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d4eef40c-8a7c-413c-82bc-ffbe02692de6'')=0
	INSERT INTO semtbl_OR VALUES(''d4eef40c-8a7c-413c-82bc-ffbe02692de6'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e0fb98af-4998-4ed1-bd7d-20ab8741e0b0'')=0
	INSERT INTO semtbl_OR VALUES(''e0fb98af-4998-4ed1-bd7d-20ab8741e0b0'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''4fe80ea3-3335-48a2-a5cb-c6588a5950b8'')=0
	INSERT INTO semtbl_OR VALUES(''4fe80ea3-3335-48a2-a5cb-c6588a5950b8'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'')=0
	INSERT INTO semtbl_OR VALUES(''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'')=0
	INSERT INTO semtbl_OR VALUES(''008817a6-14e7-4295-9a69-6835575ae53b'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b10dc7f8-405d-4726-bab2-8cc006b55432'')=0
	INSERT INTO semtbl_OR VALUES(''b10dc7f8-405d-4726-bab2-8cc006b55432'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'')=0
	INSERT INTO semtbl_OR VALUES(''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''2e9bf25b-d400-4683-a017-9df9a02d80e5'')=0
	INSERT INTO semtbl_OR VALUES(''2e9bf25b-d400-4683-a017-9df9a02d80e5'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'')=0
	INSERT INTO semtbl_OR VALUES(''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''0cf0c0e6-bb80-4f3a-a294-ed3b889a573b'')=0
	INSERT INTO semtbl_OR VALUES(''0cf0c0e6-bb80-4f3a-a294-ed3b889a573b'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''949df552-05f6-450c-8cc9-775901d1c5df'')=0
	INSERT INTO semtbl_OR VALUES(''949df552-05f6-450c-8cc9-775901d1c5df'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'')=0
	INSERT INTO semtbl_OR VALUES(''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'')=0
	INSERT INTO semtbl_OR VALUES(''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8db9f2d4-0fa4-4a9d-a86e-29c9223a699f'')=0
	INSERT INTO semtbl_OR VALUES(''8db9f2d4-0fa4-4a9d-a86e-29c9223a699f'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e1125968-1990-45d0-be7a-5b08ea3bf827'')=0
	INSERT INTO semtbl_OR VALUES(''e1125968-1990-45d0-be7a-5b08ea3bf827'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''637af5dd-d913-4291-8962-f20bb192331c'')=0
	INSERT INTO semtbl_OR VALUES(''637af5dd-d913-4291-8962-f20bb192331c'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'')=0
	INSERT INTO semtbl_OR VALUES(''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''4048b50c-a672-4577-94fd-ec743fa548fd'')=0
	INSERT INTO semtbl_OR VALUES(''4048b50c-a672-4577-94fd-ec743fa548fd'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''bdf4645f-089d-4229-b914-da4025ee72ad'')=0
	INSERT INTO semtbl_OR VALUES(''bdf4645f-089d-4229-b914-da4025ee72ad'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''c09ca6bf-b5fb-4121-b169-d389981a2ad4'')=0
	INSERT INTO semtbl_OR VALUES(''c09ca6bf-b5fb-4121-b169-d389981a2ad4'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''f374bcf5-4dc5-4164-b3d8-9bdf029f4b2b'')=0
	INSERT INTO semtbl_OR VALUES(''f374bcf5-4dc5-4164-b3d8-9bdf029f4b2b'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'')=0
	INSERT INTO semtbl_OR VALUES(''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''9ba5638b-d2bc-4278-900b-7a06c178a80e'')=0
	INSERT INTO semtbl_OR VALUES(''9ba5638b-d2bc-4278-900b-7a06c178a80e'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''a5582423-de36-49c8-8495-8f6ab1d950cc'')=0
	INSERT INTO semtbl_OR VALUES(''a5582423-de36-49c8-8495-8f6ab1d950cc'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''eb731795-e71a-4213-8a09-5dabce38df35'')=0
	INSERT INTO semtbl_OR VALUES(''eb731795-e71a-4213-8a09-5dabce38df35'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''7a6efbcd-36f1-4914-bc22-4289cf9f380b'')=0
	INSERT INTO semtbl_OR_Type VALUES(''7a6efbcd-36f1-4914-bc22-4289cf9f380b'',''7c2f4f6a-a1f3-4a61-b6eb-9a8eced06cc2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'')=0
	INSERT INTO semtbl_OR_Type VALUES(''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''93ab0ef5-fb55-41aa-862e-79e161c2052c'')=0
	INSERT INTO semtbl_OR_Type VALUES(''93ab0ef5-fb55-41aa-862e-79e161c2052c'',''f8a525de-72bb-4904-941f-63a40ce34234'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''56ecc811-8fe4-4b06-915b-6cf29696b317'')=0
	INSERT INTO semtbl_OR_Type VALUES(''56ecc811-8fe4-4b06-915b-6cf29696b317'',''6e31f905-20ce-4f8f-b401-6da5ba871ecb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''d4eef40c-8a7c-413c-82bc-ffbe02692de6'')=0
	INSERT INTO semtbl_OR_Type VALUES(''d4eef40c-8a7c-413c-82bc-ffbe02692de6'',''cf8f059d-eb85-4749-bc45-5f415417216f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''b10dc7f8-405d-4726-bab2-8cc006b55432'')=0
	INSERT INTO semtbl_OR_Type VALUES(''b10dc7f8-405d-4726-bab2-8cc006b55432'',''cd159d56-e3d4-4eb9-a8ee-f3eaba3b79d3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''0cf0c0e6-bb80-4f3a-a294-ed3b889a573b'')=0
	INSERT INTO semtbl_OR_Type VALUES(''0cf0c0e6-bb80-4f3a-a294-ed3b889a573b'',''2f05c250-be33-4b77-ba3c-b8a0228821b6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''949df552-05f6-450c-8cc9-775901d1c5df'')=0
	INSERT INTO semtbl_OR_Type VALUES(''949df552-05f6-450c-8cc9-775901d1c5df'',''f47a3e1c-50b4-4666-a41d-e975597c9adb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'')=0
	INSERT INTO semtbl_OR_Type VALUES(''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'',''8a894710-e08c-42c5-b829-ef4809830d33'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'')=0
	INSERT INTO semtbl_OR_Type VALUES(''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'')=0
	INSERT INTO semtbl_OR_Type VALUES(''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'',''76d12ad6-cd51-4ee7-8b40-5e9e6e5a182c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'')=0
	INSERT INTO semtbl_OR_Type VALUES(''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''d7a03a35-8751-42b4-8e05-19fc7a77ee91'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''eb731795-e71a-4213-8a09-5dabce38df35'')=0
	INSERT INTO semtbl_OR_Type VALUES(''eb731795-e71a-4213-8a09-5dabce38df35'',''c864bf98-78d2-461a-9e6c-1d2316f40575'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''e0fb98af-4998-4ed1-bd7d-20ab8741e0b0'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''e0fb98af-4998-4ed1-bd7d-20ab8741e0b0'',''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''f374bcf5-4dc5-4164-b3d8-9bdf029f4b2b'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''f374bcf5-4dc5-4164-b3d8-9bdf029f4b2b'',''b67c3f3c-da03-4693-9afc-d2014997e328'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''a5582423-de36-49c8-8495-8f6ab1d950cc'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''a5582423-de36-49c8-8495-8f6ab1d950cc'',''bf4b121d-4cbc-4cb0-9062-9fcbdbf4032f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''4fe80ea3-3335-48a2-a5cb-c6588a5950b8'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''4fe80ea3-3335-48a2-a5cb-c6588a5950b8'',''4f8f29b4-49bb-4d85-a65f-205d2af4f509'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'',''cf27679f-cbe7-4010-a3ae-472072762b33'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''008817a6-14e7-4295-9a69-6835575ae53b'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''e07469d9-766c-443e-8526-6d9c684f944f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''8db9f2d4-0fa4-4a9d-a86e-29c9223a699f'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''8db9f2d4-0fa4-4a9d-a86e-29c9223a699f'',''408db9f1-ae42-4807-b656-729270646f0a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''e1125968-1990-45d0-be7a-5b08ea3bf827'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''e1125968-1990-45d0-be7a-5b08ea3bf827'',''5621cb25-972d-4166-9c77-c37ee764a0b7'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''637af5dd-d913-4291-8962-f20bb192331c'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''637af5dd-d913-4291-8962-f20bb192331c'',''e1cc31b2-fdf0-4e52-bdcf-34ee60e5be75'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''c09ca6bf-b5fb-4121-b169-d389981a2ad4'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''c09ca6bf-b5fb-4121-b169-d389981a2ad4'',''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''9ba5638b-d2bc-4278-900b-7a06c178a80e'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''9ba5638b-d2bc-4278-900b-7a06c178a80e'',''2461e5ba-cd55-4a52-9c18-ebab166eba22'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''6d4eab95-a15d-4776-9ed5-d599e5d27c88'')=0
	INSERT INTO semtbl_OR_Token VALUES(''6d4eab95-a15d-4776-9ed5-d599e5d27c88'',''017234b8-7e15-475e-9154-25e45c74697f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''2e9bf25b-d400-4683-a017-9df9a02d80e5'')=0
	INSERT INTO semtbl_OR_Token VALUES(''2e9bf25b-d400-4683-a017-9df9a02d80e5'',''4ee53bf6-be79-459e-86dd-d648d0519fe2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''4048b50c-a672-4577-94fd-ec743fa548fd'')=0
	INSERT INTO semtbl_OR_Token VALUES(''4048b50c-a672-4577-94fd-ec743fa548fd'',''aabfd0bc-070f-43d0-9ea2-0f7ba13612ce'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''bdf4645f-089d-4229-b914-da4025ee72ad'')=0
	INSERT INTO semtbl_OR_Token VALUES(''bdf4645f-089d-4229-b914-da4025ee72ad'',''0c6ed922-5732-418d-97d8-e610ea9c7111'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''a8c491fc-69b6-4039-bdb6-03ad1d217765'' AND GUID_ObjectReference=''7a6efbcd-36f1-4914-bc22-4289cf9f380b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''a8c491fc-69b6-4039-bdb6-03ad1d217765'',''7a6efbcd-36f1-4914-bc22-4289cf9f380b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'' AND GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'' AND GUID_ObjectReference=''93ab0ef5-fb55-41aa-862e-79e161c2052c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''1d80b9e8-8a44-43c4-aed3-1ab9d03d1600'',''93ab0ef5-fb55-41aa-862e-79e161c2052c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3b443150-eb19-4393-80ce-1be64faaab8f'' AND GUID_ObjectReference=''6d4eab95-a15d-4776-9ed5-d599e5d27c88'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3b443150-eb19-4393-80ce-1be64faaab8f'',''6d4eab95-a15d-4776-9ed5-d599e5d27c88'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''94e8dbd1-ac07-45a2-8a5c-5c032794e6b8'' AND GUID_ObjectReference=''56ecc811-8fe4-4b06-915b-6cf29696b317'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''94e8dbd1-ac07-45a2-8a5c-5c032794e6b8'',''56ecc811-8fe4-4b06-915b-6cf29696b317'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e5c41e3c-b4ed-41c8-9eb5-5f17332cd15b'' AND GUID_ObjectReference=''d4eef40c-8a7c-413c-82bc-ffbe02692de6'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e5c41e3c-b4ed-41c8-9eb5-5f17332cd15b'',''d4eef40c-8a7c-413c-82bc-ffbe02692de6'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b6c8f6a5-9452-40fc-95e9-623712bd51bf'' AND GUID_ObjectReference=''e0fb98af-4998-4ed1-bd7d-20ab8741e0b0'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b6c8f6a5-9452-40fc-95e9-623712bd51bf'',''e0fb98af-4998-4ed1-bd7d-20ab8741e0b0'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''093d019a-c9e8-4faa-b604-65ffa216d309'' AND GUID_ObjectReference=''4fe80ea3-3335-48a2-a5cb-c6588a5950b8'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''093d019a-c9e8-4faa-b604-65ffa216d309'',''4fe80ea3-3335-48a2-a5cb-c6588a5950b8'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8e96640d-b873-4a50-b272-6b1376b26852'' AND GUID_ObjectReference=''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8e96640d-b873-4a50-b272-6b1376b26852'',''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6e494944-f602-4dcb-906f-70e5efe8f1dd'' AND GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''008817a6-14e7-4295-9a69-6835575ae53b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6ef2b776-c536-4af8-8195-756a5170a10a'' AND GUID_ObjectReference=''b10dc7f8-405d-4726-bab2-8cc006b55432'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6ef2b776-c536-4af8-8195-756a5170a10a'',''b10dc7f8-405d-4726-bab2-8cc006b55432'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f2cde058-614e-41cb-96eb-78bbcf285171'' AND GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f2cde058-614e-41cb-96eb-78bbcf285171'',''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''5c218446-83ed-4fd1-b110-9d06d4fd78ce'' AND GUID_ObjectReference=''2e9bf25b-d400-4683-a017-9df9a02d80e5'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''5c218446-83ed-4fd1-b110-9d06d4fd78ce'',''2e9bf25b-d400-4683-a017-9df9a02d80e5'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f5658dca-283f-43d8-b4cc-ac78f064d0f8'' AND GUID_ObjectReference=''0cf0c0e6-bb80-4f3a-a294-ed3b889a573b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f5658dca-283f-43d8-b4cc-ac78f064d0f8'',''0cf0c0e6-bb80-4f3a-a294-ed3b889a573b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''923108a1-c159-4d69-affe-ae048460dd24'' AND GUID_ObjectReference=''949df552-05f6-450c-8cc9-775901d1c5df'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''923108a1-c159-4d69-affe-ae048460dd24'',''949df552-05f6-450c-8cc9-775901d1c5df'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8a6a3874-7e7b-4c41-b43a-b0349e39113b'' AND GUID_ObjectReference=''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8a6a3874-7e7b-4c41-b43a-b0349e39113b'',''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f1ba23ed-ab41-4d34-8e09-b4e485671478'' AND GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''26d91bb9-0af4-491b-8d48-b53e08f7abe3'' AND GUID_ObjectReference=''8db9f2d4-0fa4-4a9d-a86e-29c9223a699f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''26d91bb9-0af4-491b-8d48-b53e08f7abe3'',''8db9f2d4-0fa4-4a9d-a86e-29c9223a699f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f54e093f-554b-47ec-80b2-bc3be3f6d260'' AND GUID_ObjectReference=''e1125968-1990-45d0-be7a-5b08ea3bf827'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f54e093f-554b-47ec-80b2-bc3be3f6d260'',''e1125968-1990-45d0-be7a-5b08ea3bf827'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''cd862075-aef5-478d-8b96-c0b2619bca7d'' AND GUID_ObjectReference=''637af5dd-d913-4291-8962-f20bb192331c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''cd862075-aef5-478d-8b96-c0b2619bca7d'',''637af5dd-d913-4291-8962-f20bb192331c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'' AND GUID_ObjectReference=''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ee3a8cf7-1ffd-4910-9df0-c4369689a9dc'',''ed8b68b6-058d-4fb2-a7be-e5d43a3d0500'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''daf64676-3baa-44fe-8f19-c810776d4e29'' AND GUID_ObjectReference=''4048b50c-a672-4577-94fd-ec743fa548fd'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''daf64676-3baa-44fe-8f19-c810776d4e29'',''4048b50c-a672-4577-94fd-ec743fa548fd'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f8a8cd69-2c45-40b8-bf60-cad253a05014'' AND GUID_ObjectReference=''bdf4645f-089d-4229-b914-da4025ee72ad'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f8a8cd69-2c45-40b8-bf60-cad253a05014'',''bdf4645f-089d-4229-b914-da4025ee72ad'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8618f96e-8494-432a-99da-cc91e6c117d5'' AND GUID_ObjectReference=''c09ca6bf-b5fb-4121-b169-d389981a2ad4'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8618f96e-8494-432a-99da-cc91e6c117d5'',''c09ca6bf-b5fb-4121-b169-d389981a2ad4'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''7356d8f9-3a09-4522-be25-d0c378732d65'' AND GUID_ObjectReference=''f374bcf5-4dc5-4164-b3d8-9bdf029f4b2b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''7356d8f9-3a09-4522-be25-d0c378732d65'',''f374bcf5-4dc5-4164-b3d8-9bdf029f4b2b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e8abdc85-511b-4e0c-8036-d980caf9e1f7'' AND GUID_ObjectReference=''e101aad4-54a2-43ac-953d-9c6d0dc85261'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e8abdc85-511b-4e0c-8036-d980caf9e1f7'',''e101aad4-54a2-43ac-953d-9c6d0dc85261'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3bc41b59-2d97-4b5d-8ba3-dec5d849d1df'' AND GUID_ObjectReference=''9ba5638b-d2bc-4278-900b-7a06c178a80e'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3bc41b59-2d97-4b5d-8ba3-dec5d849d1df'',''9ba5638b-d2bc-4278-900b-7a06c178a80e'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''218c3e22-6e53-49d3-8cdb-e91ecd9b6d0c'' AND GUID_ObjectReference=''a5582423-de36-49c8-8495-8f6ab1d950cc'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''218c3e22-6e53-49d3-8cdb-e91ecd9b6d0c'',''a5582423-de36-49c8-8495-8f6ab1d950cc'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''88cf5098-5944-46bc-8030-f8c4b5348859'' AND GUID_ObjectReference=''eb731795-e71a-4213-8a09-5dabce38df35'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''88cf5098-5944-46bc-8030-f8c4b5348859'',''eb731795-e71a-4213-8a09-5dabce38df35'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''13c09f11-175c-4eef-bc8a-0fd8e86d557f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''13c09f11-175c-4eef-bc8a-0fd8e86d557f'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1)'
GO
