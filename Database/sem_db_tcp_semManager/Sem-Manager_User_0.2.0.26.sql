use [sem_db_tcp]
GO
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''4e173916-e8d7-4640-8ef1-965b74371124'') = 0
	insert into semtbl_Attribute VALUES(''4e173916-e8d7-4640-8ef1-965b74371124'',''Codepage'',''3a4f5b7b-da75-4980-933e-fbc33cc51439'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''581597d8-dde6-4779-9ef0-37d29d0a67a2'') = 0
	insert into semtbl_Attribute VALUES(''581597d8-dde6-4779-9ef0-37d29d0a67a2'',''LCID'',''3a4f5b7b-da75-4980-933e-fbc33cc51439'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''04048642-e81e-4026-841a-fb377a02dbc5'') = 0
	insert into semtbl_Attribute VALUES(''04048642-e81e-4026-841a-fb377a02dbc5'',''Short'',''065e644e-c7df-4007-8672-aa5414131c78'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''81bbd380-e356-48a1-a4b7-fdbaebe7273c'')=0
	insert into semtbl_RelationType VALUES(''81bbd380-e356-48a1-a4b7-fdbaebe7273c'',''belonging Attribute'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	insert into semtbl_RelationType VALUES(''e07469d9-766c-443e-8526-6d9c684f944f'',''belongs to'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''fcd7eb74-cc20-45e8-b37e-11e2b62c99a1'')=0
	insert into semtbl_RelationType VALUES(''fcd7eb74-cc20-45e8-b37e-11e2b62c99a1'',''offers for'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''8f86b4a8-32f1-495a-9853-a84e2d931345'')=0
	insert into semtbl_RelationType VALUES(''8f86b4a8-32f1-495a-9853-a84e2d931345'',''RelationType'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''f2b54f82-ada5-460e-afe5-551d55629f14'')=0
	insert into semtbl_RelationType VALUES(''f2b54f82-ada5-460e-afe5-551d55629f14'',''belonging Type'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''f68a9438-fb8b-418d-8e0b-d9aefc9ecdf3'')=0
	insert into semtbl_RelationType VALUES(''f68a9438-fb8b-418d-8e0b-d9aefc9ecdf3'',''belonging Token'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e1cc31b2-fdf0-4e52-bdcf-34ee60e5be75'')=0
	insert into semtbl_RelationType VALUES(''e1cc31b2-fdf0-4e52-bdcf-34ee60e5be75'',''Fileshare'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	insert into semtbl_RelationType VALUES(''408db9f1-ae42-4807-b656-729270646f0a'',''is subordinated'')'
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='9ba99dfe-2f15-4956-9cd0-ce20b575a4b3') = 0
	insert into semtbl_Type VALUES('9ba99dfe-2f15-4956-9cd0-ce20b575a4b3','Sem-Manager','aa616051-e521-4fac-abdb-cbba6f8c6e73')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='041ec955-ed78-4931-a491-2336b55d9bd7') = 0
	insert into semtbl_Type VALUES('041ec955-ed78-4931-a491-2336b55d9bd7','Module-Activator','b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='23ad9ceb-5c77-44f7-a5cd-eb61aa2f20f5') = 0
	insert into semtbl_Type VALUES('23ad9ceb-5c77-44f7-a5cd-eb61aa2f20f5','Integration-Level','b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747')
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='83317bac-b4b1-4db8-bf84-9fca0a93ddd5') = 0
	insert into semtbl_Type VALUES('83317bac-b4b1-4db8-bf84-9fca0a93ddd5','Information-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='3d1dc6cf-b964-4986-9808-f39b7c5c3907') = 0
	insert into semtbl_Type VALUES('3d1dc6cf-b964-4986-9808-f39b7c5c3907','Direction','83317bac-b4b1-4db8-bf84-9fca0a93ddd5')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='7d0178e2-9c04-4485-b81c-6d79253c6f64') = 0
	insert into semtbl_Type VALUES('7d0178e2-9c04-4485-b81c-6d79253c6f64','Localization-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='e79ff4de-2e39-4101-b5a1-0055c40f41cd') = 0
	insert into semtbl_Type VALUES('e79ff4de-2e39-4101-b5a1-0055c40f41cd','Language','7d0178e2-9c04-4485-b81c-6d79253c6f64')
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''52c468e3-fc34-4095-a4f0-fef640f93517'') = 0
	insert into semtbl_Token VALUES(''52c468e3-fc34-4095-a4f0-fef640f93517'',''Information'',''23ad9ceb-5c77-44f7-a5cd-eb61aa2f20f5'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''05ce853c-ce41-4eea-8a11-caa578c337de'') = 0
	insert into semtbl_Token VALUES(''05ce853c-ce41-4eea-8a11-caa578c337de'',''Filter'',''23ad9ceb-5c77-44f7-a5cd-eb61aa2f20f5'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e5569386-3cb7-46f2-8162-484a44e55916'') = 0
	insert into semtbl_Token VALUES(''e5569386-3cb7-46f2-8162-484a44e55916'',''DayEnd'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6be87f22-7906-433d-b6ce-767074dab592'') = 0
	insert into semtbl_Token VALUES(''6be87f22-7906-433d-b6ce-767074dab592'',''DayStart'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bb6a9555-3af6-40fc-9fb0-489d2678dff2'') = 0
	insert into semtbl_Token VALUES(''bb6a9555-3af6-40fc-9fb0-489d2678dff2'',''Delete'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''da431a4a-568c-4708-8fb7-583fd113a7b1'') = 0
	insert into semtbl_Token VALUES(''da431a4a-568c-4708-8fb7-583fd113a7b1'',''Download'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''70253592-e2ce-4340-a9e7-36a8a1f4230b'') = 0
	insert into semtbl_Token VALUES(''70253592-e2ce-4340-a9e7-36a8a1f4230b'',''Base-Config'',''9ba99dfe-2f15-4956-9cd0-ce20b575a4b3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8b1691d9-b296-4841-b01e-a7b6452eab2f'') = 0
	insert into semtbl_Token VALUES(''8b1691d9-b296-4841-b01e-a7b6452eab2f'',''German (Germany)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''e79ff4de-2e39-4101-b5a1-0055c40f41cd'' AND GUID_Attribute=''581597d8-dde6-4779-9ef0-37d29d0a67a2'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''e79ff4de-2e39-4101-b5a1-0055c40f41cd'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''e79ff4de-2e39-4101-b5a1-0055c40f41cd'' AND GUID_Attribute=''4e173916-e8d7-4640-8ef1-965b74371124'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''e79ff4de-2e39-4101-b5a1-0055c40f41cd'',''4e173916-e8d7-4640-8ef1-965b74371124'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''e79ff4de-2e39-4101-b5a1-0055c40f41cd'' AND GUID_Attribute=''04048642-e81e-4026-841a-fb377a02dbc5'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''e79ff4de-2e39-4101-b5a1-0055c40f41cd'',''04048642-e81e-4026-841a-fb377a02dbc5'',1,1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9ba99dfe-2f15-4956-9cd0-ce20b575a4b3'' AND GUID_Type_Right=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9ba99dfe-2f15-4956-9cd0-ce20b575a4b3'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_Type_Right=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''408db9f1-ae42-4807-b656-729270646f0a'',0,1,-1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''408db9f1-ae42-4807-b656-729270646f0a'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''fafc1464-815f-4596-9737-bcbc96bd744a'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''8e31154b-c54e-4350-81f6-0b113cdb302b'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''8e31154b-c54e-4350-81f6-0b113cdb302b'',''8b1691d9-b296-4841-b01e-a7b6452eab2f'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e9d487e9-d7cc-401b-b032-9f0d8a9121ab'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e9d487e9-d7cc-401b-b032-9f0d8a9121ab'',''8b1691d9-b296-4841-b01e-a7b6452eab2f'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''d264ff27-c287-43ce-b602-092b37018e40'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''d264ff27-c287-43ce-b602-092b37018e40'',''8b1691d9-b296-4841-b01e-a7b6452eab2f'',''04048642-e81e-4026-841a-fb377a02dbc5'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''8e31154b-c54e-4350-81f6-0b113cdb302b'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''8e31154b-c54e-4350-81f6-0b113cdb302b'',1031,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''e9d487e9-d7cc-401b-b032-9f0d8a9121ab'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''e9d487e9-d7cc-401b-b032-9f0d8a9121ab'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Varchar255 WHERE GUID_TokenAttribute=''d264ff27-c287-43ce-b602-092b37018e40'' )=0
	INSERT INTO semtbl_Token_Attribute_Varchar255 VALUES(''d264ff27-c287-43ce-b602-092b37018e40'',''DE'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''c9777425-cc57-48e3-aab4-8c9d61b052bf'')=0
	INSERT INTO semtbl_OR VALUES(''c9777425-cc57-48e3-aab4-8c9d61b052bf'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''69bdc7fa-c332-4186-a6ff-b76cfc155d6b'')=0
	INSERT INTO semtbl_OR VALUES(''69bdc7fa-c332-4186-a6ff-b76cfc155d6b'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''c9777425-cc57-48e3-aab4-8c9d61b052bf'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''c9777425-cc57-48e3-aab4-8c9d61b052bf'',''fafc1464-815f-4596-9737-bcbc96bd744a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''69bdc7fa-c332-4186-a6ff-b76cfc155d6b'')=0
	INSERT INTO semtbl_OR_Token VALUES(''69bdc7fa-c332-4186-a6ff-b76cfc155d6b'',''8b1691d9-b296-4841-b01e-a7b6452eab2f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''70253592-e2ce-4340-a9e7-36a8a1f4230b'' AND GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'' AND GUID_RelationType=''81bbd380-e356-48a1-a4b7-fdbaebe7273c'')=0
	INSERT INTO semtbl_Token_OR VALUES(''70253592-e2ce-4340-a9e7-36a8a1f4230b'',''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''81bbd380-e356-48a1-a4b7-fdbaebe7273c'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''70253592-e2ce-4340-a9e7-36a8a1f4230b'' AND GUID_ObjectReference=''c9777425-cc57-48e3-aab4-8c9d61b052bf'' AND GUID_RelationType=''8f86b4a8-32f1-495a-9853-a84e2d931345'')=0
	INSERT INTO semtbl_Token_OR VALUES(''70253592-e2ce-4340-a9e7-36a8a1f4230b'',''c9777425-cc57-48e3-aab4-8c9d61b052bf'',''8f86b4a8-32f1-495a-9853-a84e2d931345'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''70253592-e2ce-4340-a9e7-36a8a1f4230b'' AND GUID_ObjectReference=''69bdc7fa-c332-4186-a6ff-b76cfc155d6b'' AND GUID_RelationType=''f68a9438-fb8b-418d-8e0b-d9aefc9ecdf3'')=0
	INSERT INTO semtbl_Token_OR VALUES(''70253592-e2ce-4340-a9e7-36a8a1f4230b'',''69bdc7fa-c332-4186-a6ff-b76cfc155d6b'',''f68a9438-fb8b-418d-8e0b-d9aefc9ecdf3'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''041ec955-ed78-4931-a491-2336b55d9bd7'' AND GUID_RelationType=''fcd7eb74-cc20-45e8-b37e-11e2b62c99a1'')=0
	INSERT INTO semtbl_Type_OR VALUES(''041ec955-ed78-4931-a491-2336b55d9bd7'',''fcd7eb74-cc20-45e8-b37e-11e2b62c99a1'',0,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''9ba99dfe-2f15-4956-9cd0-ce20b575a4b3'' AND GUID_RelationType=''f2b54f82-ada5-460e-afe5-551d55629f14'')=0
	INSERT INTO semtbl_Type_OR VALUES(''9ba99dfe-2f15-4956-9cd0-ce20b575a4b3'',''f2b54f82-ada5-460e-afe5-551d55629f14'',0,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''9ba99dfe-2f15-4956-9cd0-ce20b575a4b3'' AND GUID_RelationType=''8f86b4a8-32f1-495a-9853-a84e2d931345'')=0
	INSERT INTO semtbl_Type_OR VALUES(''9ba99dfe-2f15-4956-9cd0-ce20b575a4b3'',''8f86b4a8-32f1-495a-9853-a84e2d931345'',0,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''9ba99dfe-2f15-4956-9cd0-ce20b575a4b3'' AND GUID_RelationType=''f68a9438-fb8b-418d-8e0b-d9aefc9ecdf3'')=0
	INSERT INTO semtbl_Type_OR VALUES(''9ba99dfe-2f15-4956-9cd0-ce20b575a4b3'',''f68a9438-fb8b-418d-8e0b-d9aefc9ecdf3'',0,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''9ba99dfe-2f15-4956-9cd0-ce20b575a4b3'' AND GUID_RelationType=''81bbd380-e356-48a1-a4b7-fdbaebe7273c'')=0
	INSERT INTO semtbl_Type_OR VALUES(''9ba99dfe-2f15-4956-9cd0-ce20b575a4b3'',''81bbd380-e356-48a1-a4b7-fdbaebe7273c'',0,-1)'
GO
