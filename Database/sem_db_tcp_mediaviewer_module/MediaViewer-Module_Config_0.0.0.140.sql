execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''006b6f41-26a0-4d7b-b0d6-d2cf4dba3ff8'') = 0
	insert into semtbl_Attribute VALUES(''006b6f41-26a0-4d7b-b0d6-d2cf4dba3ff8'',''Länge (Minuten)'',''a1244d0e-187f-46ee-8574-2fc334077b7d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''68ac4472-ee22-4229-96ec-9753a016900a'') = 0
	insert into semtbl_Attribute VALUES(''68ac4472-ee22-4229-96ec-9753a016900a'',''XML-Text'',''64530b52-d96c-4df1-86fe-183f44513450'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''0b183be9-c13d-4157-989b-63b0362aeee6'') = 0
	insert into semtbl_Attribute VALUES(''0b183be9-c13d-4157-989b-63b0362aeee6'',''ID'',''3a4f5b7b-da75-4980-933e-fbc33cc51439'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''e93b6ef9-7e8c-4215-affa-2bb239d0ea45'') = 0
	insert into semtbl_Attribute VALUES(''e93b6ef9-7e8c-4215-affa-2bb239d0ea45'',''Titel'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''6092162a-d4cb-4655-8753-e18a662fb28f'') = 0
	insert into semtbl_Attribute VALUES(''6092162a-d4cb-4655-8753-e18a662fb28f'',''taking'',''905fda81-788f-4e3d-8329-3e55ae984b9e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''37347dbd-5b2c-45a4-b091-610d022566aa'') = 0
	insert into semtbl_Attribute VALUES(''37347dbd-5b2c-45a4-b091-610d022566aa'',''Media-Position'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''30a83dbb-ceef-416e-8060-9a58d93d6636'') = 0
	insert into semtbl_Attribute VALUES(''30a83dbb-ceef-416e-8060-9a58d93d6636'',''comment'',''64530b52-d96c-4df1-86fe-183f44513450'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''2e5fd016-c574-4924-b724-d1b30640243a'') = 0
	insert into semtbl_Attribute VALUES(''2e5fd016-c574-4924-b724-d1b30640243a'',''DateTimestamp'',''905fda81-788f-4e3d-8329-3e55ae984b9e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'') = 0
	insert into semtbl_Attribute VALUES(''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'',''Blob'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''b67c3f3c-da03-4693-9afc-d2014997e328'') = 0
	insert into semtbl_Attribute VALUES(''b67c3f3c-da03-4693-9afc-d2014997e328'',''Datetimestamp (Create)'',''905fda81-788f-4e3d-8329-3e55ae984b9e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''581597d8-dde6-4779-9ef0-37d29d0a67a2'') = 0
	insert into semtbl_Attribute VALUES(''581597d8-dde6-4779-9ef0-37d29d0a67a2'',''LCID'',''3a4f5b7b-da75-4980-933e-fbc33cc51439'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''4e173916-e8d7-4640-8ef1-965b74371124'') = 0
	insert into semtbl_Attribute VALUES(''4e173916-e8d7-4640-8ef1-965b74371124'',''Codepage'',''3a4f5b7b-da75-4980-933e-fbc33cc51439'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''04048642-e81e-4026-841a-fb377a02dbc5'') = 0
	insert into semtbl_Attribute VALUES(''04048642-e81e-4026-841a-fb377a02dbc5'',''Short'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''4fcf775b-2e0b-4712-be8d-0e8e0c643040'') = 0
	insert into semtbl_Attribute VALUES(''4fcf775b-2e0b-4712-be8d-0e8e0c643040'',''Searchpath'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''166531b2-a224-4ce1-bd01-6e38fec36bb3'') = 0
	insert into semtbl_Attribute VALUES(''166531b2-a224-4ce1-bd01-6e38fec36bb3'',''Url-Path'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''301374ab-7877-4dd9-9e5b-36db1e1125fa'') = 0
	insert into semtbl_Attribute VALUES(''301374ab-7877-4dd9-9e5b-36db1e1125fa'',''Master-Password'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''0d2c794d-281d-44ff-9767-eb8549d4ad16'') = 0
	insert into semtbl_Attribute VALUES(''0d2c794d-281d-44ff-9767-eb8549d4ad16'',''Message'',''64530b52-d96c-4df1-86fe-183f44513450'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''3940fb8a-7ec9-4bd5-9719-aed313da116d'') = 0
	insert into semtbl_Attribute VALUES(''3940fb8a-7ec9-4bd5-9719-aed313da116d'',''Value'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''faf118eb-6aab-4e47-89ae-320b7186b337'')=0
	insert into semtbl_RelationType VALUES(''faf118eb-6aab-4e47-89ae-320b7186b337'',''Media-Webservice-Url'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''3ffa80d4-7d6e-4025-be19-31abf3ba7c12'')=0
	insert into semtbl_RelationType VALUES(''3ffa80d4-7d6e-4025-be19-31abf3ba7c12'',''taking at'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''03d96017-6535-4cad-9327-e00a7d11761d'')=0
	insert into semtbl_RelationType VALUES(''03d96017-6535-4cad-9327-e00a7d11761d'',''belonging Done'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	insert into semtbl_RelationType VALUES(''3e104b75-e01c-48a0-b041-12908fd446a0'',''is'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''1f063a79-ddde-44c5-95ba-50391fe6f0e3'')=0
	insert into semtbl_RelationType VALUES(''1f063a79-ddde-44c5-95ba-50391fe6f0e3'',''is used by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''3371228a-5d2b-4357-8050-0159d1262007'')=0
	insert into semtbl_RelationType VALUES(''3371228a-5d2b-4357-8050-0159d1262007'',''Artist'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	insert into semtbl_RelationType VALUES(''e9711603-47db-44d8-a476-fe88290639a4'',''contains'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''1700a8b9-5f32-44ec-8687-1c5ddb84e109'')=0
	insert into semtbl_RelationType VALUES(''1700a8b9-5f32-44ec-8687-1c5ddb84e109'',''is described by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	insert into semtbl_RelationType VALUES(''9996494a-ef6a-4357-a6ef-71a92b5ff596'',''is of Type'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	insert into semtbl_RelationType VALUES(''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',''offered by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''62fc3781-8c1f-47fd-af1e-f0ebf96beefb'')=0
	insert into semtbl_RelationType VALUES(''62fc3781-8c1f-47fd-af1e-f0ebf96beefb'',''has'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''ec06ec43-f52c-463b-8ca4-67ca12124da9'')=0
	insert into semtbl_RelationType VALUES(''ec06ec43-f52c-463b-8ca4-67ca12124da9'',''from'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	insert into semtbl_RelationType VALUES(''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',''belonging Source'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	insert into semtbl_RelationType VALUES(''e07469d9-766c-443e-8526-6d9c684f944f'',''belongs to'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''25ed2608-4b28-464e-8ae8-05f708e3986f'')=0
	insert into semtbl_RelationType VALUES(''25ed2608-4b28-464e-8ae8-05f708e3986f'',''Disc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'')=0
	insert into semtbl_RelationType VALUES(''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'',''located in'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'')=0
	insert into semtbl_RelationType VALUES(''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'',''offers'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''86be124e-55b0-463e-9ecc-7d1043a09c41'')=0
	insert into semtbl_RelationType VALUES(''86be124e-55b0-463e-9ecc-7d1043a09c41'',''was created by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''9577533e-317f-4f6a-ae2d-d1a545092c68'')=0
	insert into semtbl_RelationType VALUES(''9577533e-317f-4f6a-ae2d-d1a545092c68'',''Composer'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e3628af3-0aca-478b-a541-f77583c48f58'')=0
	insert into semtbl_RelationType VALUES(''e3628af3-0aca-478b-a541-f77583c48f58'',''started with'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''1f30738c-746b-4806-be66-12fd45fb7be5'')=0
	insert into semtbl_RelationType VALUES(''1f30738c-746b-4806-be66-12fd45fb7be5'',''finished with'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''f77ee633-19d8-4ea6-947f-9fb6efad3547'')=0
	insert into semtbl_RelationType VALUES(''f77ee633-19d8-4ea6-947f-9fb6efad3547'',''is partner of'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''c9670b90-e5f0-4e30-a26d-ad3d6576ceac'')=0
	insert into semtbl_RelationType VALUES(''c9670b90-e5f0-4e30-a26d-ad3d6576ceac'',''contact'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''d513be0d-5832-445a-b9e4-0c5e85818a12'')=0
	insert into semtbl_RelationType VALUES(''d513be0d-5832-445a-b9e4-0c5e85818a12'',''provides'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''d91da85b-793c-431c-9724-8ddc1ace170e'')=0
	insert into semtbl_RelationType VALUES(''d91da85b-793c-431c-9724-8ddc1ace170e'',''Standard'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''2461e5ba-cd55-4a52-9c18-ebab166eba22'')=0
	insert into semtbl_RelationType VALUES(''2461e5ba-cd55-4a52-9c18-ebab166eba22'',''ends with'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''dd5a24ec-e2bd-47c2-9761-d4a7db114aed'')=0
	insert into semtbl_RelationType VALUES(''dd5a24ec-e2bd-47c2-9761-d4a7db114aed'',''additional'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''cf27679f-cbe7-4010-a3ae-472072762b33'')=0
	insert into semtbl_RelationType VALUES(''cf27679f-cbe7-4010-a3ae-472072762b33'',''is in State'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''fb8a3635-9532-42ac-9889-9f116abe6c53'')=0
	insert into semtbl_RelationType VALUES(''fb8a3635-9532-42ac-9889-9f116abe6c53'',''happened'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''fb90fea9-586d-4e7b-afd6-e5ccb009268a'')=0
	insert into semtbl_RelationType VALUES(''fb90fea9-586d-4e7b-afd6-e5ccb009268a'',''Request'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''03da78f1-645b-4248-b249-6169f78401ac'')=0
	insert into semtbl_RelationType VALUES(''03da78f1-645b-4248-b249-6169f78401ac'',''was developed by'')'
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='7d0178e2-9c04-4485-b81c-6d79253c6f64') = 0
	insert into semtbl_Type VALUES('7d0178e2-9c04-4485-b81c-6d79253c6f64','Localization-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='8aa50712-fda9-4222-a350-6378f36e49f8') = 0
	insert into semtbl_Type VALUES('8aa50712-fda9-4222-a350-6378f36e49f8','Formats','7d0178e2-9c04-4485-b81c-6d79253c6f64')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='c9a01318-6258-46eb-8efd-ddddd9f8ab08') = 0
	insert into semtbl_Type VALUES('c9a01318-6258-46eb-8efd-ddddd9f8ab08','Datetime','8aa50712-fda9-4222-a350-6378f36e49f8')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='83f136c4-cb76-4029-88ab-5ab8f10c1532') = 0
	insert into semtbl_Type VALUES('83f136c4-cb76-4029-88ab-5ab8f10c1532','Year','c9a01318-6258-46eb-8efd-ddddd9f8ab08')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='759bb22d-20b5-42ff-8079-813c2496946d') = 0
	insert into semtbl_Type VALUES('759bb22d-20b5-42ff-8079-813c2496946d','Month','c9a01318-6258-46eb-8efd-ddddd9f8ab08')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='3f7f258e-76b2-49ae-b5cc-25184f39899f') = 0
	insert into semtbl_Type VALUES('3f7f258e-76b2-49ae-b5cc-25184f39899f','Day','c9a01318-6258-46eb-8efd-ddddd9f8ab08')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='9428c7d3-7065-443e-ab0c-5086353f2e9a') = 0
	insert into semtbl_Type VALUES('9428c7d3-7065-443e-ab0c-5086353f2e9a','Wetterlage','7d0178e2-9c04-4485-b81c-6d79253c6f64')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='f1ae4aa2-1a92-4df1-ad63-cd4663dd26f1') = 0
	insert into semtbl_Type VALUES('f1ae4aa2-1a92-4df1-ad63-cd4663dd26f1','landscape','7d0178e2-9c04-4485-b81c-6d79253c6f64')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='e79ff4de-2e39-4101-b5a1-0055c40f41cd') = 0
	insert into semtbl_Type VALUES('e79ff4de-2e39-4101-b5a1-0055c40f41cd','Language','7d0178e2-9c04-4485-b81c-6d79253c6f64')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='402a7ca0-215e-47c8-9dfe-8cf1283dccc0') = 0
	insert into semtbl_Type VALUES('402a7ca0-215e-47c8-9dfe-8cf1283dccc0','Tierarten','7d0178e2-9c04-4485-b81c-6d79253c6f64')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='c0bb945e-d91e-42a9-ba59-50fe054b2fa0') = 0
	insert into semtbl_Type VALUES('c0bb945e-d91e-42a9-ba59-50fe054b2fa0','Pflanzenarten','7d0178e2-9c04-4485-b81c-6d79253c6f64')
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='460cb016-8fbb-47ae-91c8-cd9d8db5d8f4') = 0
	insert into semtbl_Type VALUES('460cb016-8fbb-47ae-91c8-cd9d8db5d8f4','MediaViewer-Module','aa616051-e521-4fac-abdb-cbba6f8c6e73')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='2f05c250-be33-4b77-ba3c-b8a0228821b6') = 0
	insert into semtbl_Type VALUES('2f05c250-be33-4b77-ba3c-b8a0228821b6','Filesystem-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='4b335d37-2087-42f6-a680-a1b03e35d73c') = 0
	insert into semtbl_Type VALUES('4b335d37-2087-42f6-a680-a1b03e35d73c','Web-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='094d728d-6efc-463c-85c7-2dcfed903c78') = 0
	insert into semtbl_Type VALUES('094d728d-6efc-463c-85c7-2dcfed903c78','Url','4b335d37-2087-42f6-a680-a1b03e35d73c')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='31da8093-3149-4400-957f-a26027fb506e') = 0
	insert into semtbl_Type VALUES('31da8093-3149-4400-957f-a26027fb506e','Security-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='c441518d-bfe0-4d55-b538-df5c5555dd83') = 0
	insert into semtbl_Type VALUES('c441518d-bfe0-4d55-b538-df5c5555dd83','user','31da8093-3149-4400-957f-a26027fb506e')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='53136d10-b7e7-47fc-94ad-7887a354d6e1') = 0
	insert into semtbl_Type VALUES('53136d10-b7e7-47fc-94ad-7887a354d6e1','Log-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='351d4591-2495-4501-82ab-a425f5235db9') = 0
	insert into semtbl_Type VALUES('351d4591-2495-4501-82ab-a425f5235db9','Logentry','53136d10-b7e7-47fc-94ad-7887a354d6e1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='1d9568af-b6da-4990-8f4d-907dfdd30749') = 0
	insert into semtbl_Type VALUES('1d9568af-b6da-4990-8f4d-907dfdd30749','Logstate','53136d10-b7e7-47fc-94ad-7887a354d6e1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='7415f32e-fb56-4aeb-a413-42e37457fdb7') = 0
	insert into semtbl_Type VALUES('7415f32e-fb56-4aeb-a413-42e37457fdb7','Media-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='d84fa125-dbce-44b0-9153-9abeb66ad27f') = 0
	insert into semtbl_Type VALUES('d84fa125-dbce-44b0-9153-9abeb66ad27f','Media-Item','7415f32e-fb56-4aeb-a413-42e37457fdb7')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='60a12cc0-20b2-4c8a-b03b-a4b7c71864de') = 0
	insert into semtbl_Type VALUES('60a12cc0-20b2-4c8a-b03b-a4b7c71864de','Media-Item Range','d84fa125-dbce-44b0-9153-9abeb66ad27f')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='0e228554-4c7e-48e0-ba03-2de51394be4a') = 0
	insert into semtbl_Type VALUES('0e228554-4c7e-48e0-ba03-2de51394be4a','mp3-File','d84fa125-dbce-44b0-9153-9abeb66ad27f')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='e51633ca-e76f-4a3b-b4eb-95aace386755') = 0
	insert into semtbl_Type VALUES('e51633ca-e76f-4a3b-b4eb-95aace386755','Media-Item Bookmark','d84fa125-dbce-44b0-9153-9abeb66ad27f')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='055c60b0-b807-46c1-a2cc-7b9dcf2c568a') = 0
	insert into semtbl_Type VALUES('055c60b0-b807-46c1-a2cc-7b9dcf2c568a','Media','7415f32e-fb56-4aeb-a413-42e37457fdb7')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='95029348-dd27-47cd-bf36-cd68739673b8') = 0
	insert into semtbl_Type VALUES('95029348-dd27-47cd-bf36-cd68739673b8','Genre','055c60b0-b807-46c1-a2cc-7b9dcf2c568a')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='7cf91a43-acdf-4624-8d1e-e6f9cdf10f89') = 0
	insert into semtbl_Type VALUES('7cf91a43-acdf-4624-8d1e-e6f9cdf10f89','Band','055c60b0-b807-46c1-a2cc-7b9dcf2c568a')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='7886d705-2b02-4ddc-bf6e-f35f3e58e19f') = 0
	insert into semtbl_Type VALUES('7886d705-2b02-4ddc-bf6e-f35f3e58e19f','Album','055c60b0-b807-46c1-a2cc-7b9dcf2c568a')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='f62cf1cc-ee51-475f-9c00-7094f1809b56') = 0
	insert into semtbl_Type VALUES('f62cf1cc-ee51-475f-9c00-7094f1809b56','Images (Graphic)','7415f32e-fb56-4aeb-a413-42e37457fdb7')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='04d7e938-a51d-4a49-b14b-03b0f8a6eeb1') = 0
	insert into semtbl_Type VALUES('04d7e938-a51d-4a49-b14b-03b0f8a6eeb1','Image-Objects','f62cf1cc-ee51-475f-9c00-7094f1809b56')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='5325e946-86c1-4254-b463-c7538d39caa3') = 0
	insert into semtbl_Type VALUES('5325e946-86c1-4254-b463-c7538d39caa3','Image-Objects (No Objects)','04d7e938-a51d-4a49-b14b-03b0f8a6eeb1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='d0f58213-7db4-4882-bd15-962163015d13') = 0
	insert into semtbl_Type VALUES('d0f58213-7db4-4882-bd15-962163015d13','PDF-Documents','7415f32e-fb56-4aeb-a413-42e37457fdb7')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='163b1710-3d39-4928-84e8-ed9bb505b64f') = 0
	insert into semtbl_Type VALUES('163b1710-3d39-4928-84e8-ed9bb505b64f','Geschichts-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='c1e3cfc9-8a22-4e83-bc8c-869319e408a2') = 0
	insert into semtbl_Type VALUES('c1e3cfc9-8a22-4e83-bc8c-869319e408a2','Kunst','163b1710-3d39-4928-84e8-ed9bb505b64f')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='86e299d3-f569-4810-9f58-b7172ae6fd0c') = 0
	insert into semtbl_Type VALUES('86e299d3-f569-4810-9f58-b7172ae6fd0c','Freizeit-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='c466c537-2c35-4379-b711-cc6b6b183b3f') = 0
	insert into semtbl_Type VALUES('c466c537-2c35-4379-b711-cc6b6b183b3f','Wichtige Ereignisse','86e299d3-f569-4810-9f58-b7172ae6fd0c')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='2a127013-81ca-42a4-bcf3-c3f28d62bf1c') = 0
	insert into semtbl_Type VALUES('2a127013-81ca-42a4-bcf3-c3f28d62bf1c','Adress-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='33cb21b4-58a7-4f56-b036-5d89bbc20993') = 0
	insert into semtbl_Type VALUES('33cb21b4-58a7-4f56-b036-5d89bbc20993','Bauwerke','2a127013-81ca-42a4-bcf3-c3f28d62bf1c')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='a751ce27-5609-4c3a-9b6a-b685ea646d10') = 0
	insert into semtbl_Type VALUES('a751ce27-5609-4c3a-9b6a-b685ea646d10','Ort','2a127013-81ca-42a4-bcf3-c3f28d62bf1c')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='a2d7d0fe-0495-4afe-85e1-1dcb88a27546') = 0
	insert into semtbl_Type VALUES('a2d7d0fe-0495-4afe-85e1-1dcb88a27546','Partner','2a127013-81ca-42a4-bcf3-c3f28d62bf1c')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='83317bac-b4b1-4db8-bf84-9fca0a93ddd5') = 0
	insert into semtbl_Type VALUES('83317bac-b4b1-4db8-bf84-9fca0a93ddd5','Information-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='499ec20d-af6f-4e72-bf55-ffb6eac101bf') = 0
	insert into semtbl_Type VALUES('499ec20d-af6f-4e72-bf55-ffb6eac101bf','Search-Template','83317bac-b4b1-4db8-bf84-9fca0a93ddd5')
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='dc4de8c5-6702-41a9-aa3f-8155f433a471') = 0
	insert into semtbl_Type VALUES('dc4de8c5-6702-41a9-aa3f-8155f433a471','Haushalts-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='aa000e0c-5415-4be9-bf6a-0bb43fc53bcf') = 0
	insert into semtbl_Type VALUES('aa000e0c-5415-4be9-bf6a-0bb43fc53bcf','Haustier','dc4de8c5-6702-41a9-aa3f-8155f433a471')
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'') = 0
	insert into semtbl_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''MediaViewer-Module'',''c6c9bcb8-0ac9-4713-9417-eeec1453026c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b8e5b73f-c84a-48f7-ad9e-48d1ad6c7d66'') = 0
	insert into semtbl_Token VALUES(''b8e5b73f-c84a-48f7-ad9e-48d1ad6c7d66'',''MediaViewer-Module'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f0becf55-4a6e-431c-b655-006503f59b47'') = 0
	insert into semtbl_Token VALUES(''f0becf55-4a6e-431c-b655-006503f59b47'',''Token_Image_Objects__No_Objects__no_landscape'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fb9503c0-b884-434e-af8a-0066c7a6c40f'') = 0
	insert into semtbl_Token VALUES(''fb9503c0-b884-434e-af8a-0066c7a6c40f'',''Type_Year'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bd160ac5-040a-410f-88f6-04d3659370e8'') = 0
	insert into semtbl_Token VALUES(''bd160ac5-040a-410f-88f6-04d3659370e8'',''Token_Extensions_Image'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'') = 0
	insert into semtbl_Token VALUES(''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''Type_Module'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ab95f5bb-5de1-42b0-9d4c-13d076ca3554'') = 0
	insert into semtbl_Token VALUES(''ab95f5bb-5de1-42b0-9d4c-13d076ca3554'',''RelationType_Media_Webservice_Url'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''89a8ce8f-d745-4d78-b82a-14306084cfc1'') = 0
	insert into semtbl_Token VALUES(''89a8ce8f-d745-4d78-b82a-14306084cfc1'',''RelationType_taking_at'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e311bbb5-4f2f-4757-b6f2-17b0849ce722'') = 0
	insert into semtbl_Token VALUES(''e311bbb5-4f2f-4757-b6f2-17b0849ce722'',''Token_Image_Objects__No_Objects__no_Buildings'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b53826c1-bddc-4fc2-a922-180c32ea7207'') = 0
	insert into semtbl_Token VALUES(''b53826c1-bddc-4fc2-a922-180c32ea7207'',''Type_Media_Item'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''73c0acf6-36ff-4c63-a190-191fa3a8644b'') = 0
	insert into semtbl_Token VALUES(''73c0acf6-36ff-4c63-a190-191fa3a8644b'',''Token_XML_Windows_Playlist_1_0_mediasrc'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c1df5546-3c90-4160-9924-1b6e5cee7920'') = 0
	insert into semtbl_Token VALUES(''c1df5546-3c90-4160-9924-1b6e5cee7920'',''Type_Wetterlage'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''98fbd3cc-40ac-4a19-b0f8-1f9e8efaff91'') = 0
	insert into semtbl_Token VALUES(''98fbd3cc-40ac-4a19-b0f8-1f9e8efaff91'',''Attribute_L_nge__Minuten_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''14f006b5-b225-4899-a0ac-2075f3ed3280'') = 0
	insert into semtbl_Token VALUES(''14f006b5-b225-4899-a0ac-2075f3ed3280'',''RelationType_belonging_Done'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''dc9ebe84-dd16-4f9c-bd77-294920c9387d'') = 0
	insert into semtbl_Token VALUES(''dc9ebe84-dd16-4f9c-bd77-294920c9387d'',''Type_Media'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''375c73ad-9a93-4775-a2ba-2fb097efb6ba'') = 0
	insert into semtbl_Token VALUES(''375c73ad-9a93-4775-a2ba-2fb097efb6ba'',''Type_Month'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''708a17aa-c475-4f08-a8d7-32a20269ca8a'') = 0
	insert into semtbl_Token VALUES(''708a17aa-c475-4f08-a8d7-32a20269ca8a'',''Token_Image_Objects__No_Objects__no_Persons'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cd5df308-8f49-4bb1-8d5d-33ed4279b850'') = 0
	insert into semtbl_Token VALUES(''cd5df308-8f49-4bb1-8d5d-33ed4279b850'',''Type_Media_Item_Range'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''26c6954f-c062-423b-b598-34147b3013fd'') = 0
	insert into semtbl_Token VALUES(''26c6954f-c062-423b-b598-34147b3013fd'',''Type_Filetypes'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''747952da-2e66-49c1-8462-3a20addbc0ef'') = 0
	insert into semtbl_Token VALUES(''747952da-2e66-49c1-8462-3a20addbc0ef'',''RelationType_is'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'') = 0
	insert into semtbl_Token VALUES(''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'',''Attribute_XML_Text'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''25c4a23b-baa0-4a4d-9b4f-40b354d3fac4'') = 0
	insert into semtbl_Token VALUES(''25c4a23b-baa0-4a4d-9b4f-40b354d3fac4'',''RelationType_is_used_by'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d0891239-7599-4e1b-9987-4830333ab06c'') = 0
	insert into semtbl_Token VALUES(''d0891239-7599-4e1b-9987-4830333ab06c'',''Token_Image_Objects__No_Objects__no_Address'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''60dac2f0-947c-47cd-9933-4a4e69681176'') = 0
	insert into semtbl_Token VALUES(''60dac2f0-947c-47cd-9933-4a4e69681176'',''Attribute_ID'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''00a54315-adbd-4073-a92e-4dc7cd9149d0'') = 0
	insert into semtbl_Token VALUES(''00a54315-adbd-4073-a92e-4dc7cd9149d0'',''Type_Image_Objects'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7de69c8a-375c-43d9-b8db-4f5746c949e1'') = 0
	insert into semtbl_Token VALUES(''7de69c8a-375c-43d9-b8db-4f5746c949e1'',''Attribute_Titel'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3749880b-154c-4197-ab8d-533a8b36f690'') = 0
	insert into semtbl_Token VALUES(''3749880b-154c-4197-ab8d-533a8b36f690'',''Token_XML_Windows_Playlist_1_0'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d72ffddd-bd17-4fa3-b856-549af23b2273'') = 0
	insert into semtbl_Token VALUES(''d72ffddd-bd17-4fa3-b856-549af23b2273'',''Attribute_taking'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''022a6b7a-02c8-4433-8764-5c21c5205ac1'') = 0
	insert into semtbl_Token VALUES(''022a6b7a-02c8-4433-8764-5c21c5205ac1'',''Token_Logstate_Pause'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''890a4d05-9c9f-47a0-b809-60c0676064be'') = 0
	insert into semtbl_Token VALUES(''890a4d05-9c9f-47a0-b809-60c0676064be'',''RelationType_Artist'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6c966e3c-c737-4af1-9970-68c8323679bc'') = 0
	insert into semtbl_Token VALUES(''6c966e3c-c737-4af1-9970-68c8323679bc'',''RelationType_contains'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''45206556-4bf3-4d9c-9b1a-6a123f970878'') = 0
	insert into semtbl_Token VALUES(''45206556-4bf3-4d9c-9b1a-6a123f970878'',''Type_Image_Objects__No_Objects_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''565ccbae-718f-4b3d-bd06-6a1906653220'') = 0
	insert into semtbl_Token VALUES(''565ccbae-718f-4b3d-bd06-6a1906653220'',''Type_Images__Graphic_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1f5c49ef-bee4-4fbc-a009-6aa4ac85cd40'') = 0
	insert into semtbl_Token VALUES(''1f5c49ef-bee4-4fbc-a009-6aa4ac85cd40'',''Token_Logstate_User_Defined'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'') = 0
	insert into semtbl_Token VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''attribute_dbPostfix'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3111af84-bd07-4635-80de-6c666b8c95eb'') = 0
	insert into semtbl_Token VALUES(''3111af84-bd07-4635-80de-6c666b8c95eb'',''Token_Image_Objects__No_Objects__no_Location'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''00029a7e-0e7f-4f0a-b818-6ce8c9a517d3'') = 0
	insert into semtbl_Token VALUES(''00029a7e-0e7f-4f0a-b818-6ce8c9a517d3'',''Token_Extensions_mod'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''15820ab1-0945-4e72-9792-6dd480e73954'') = 0
	insert into semtbl_Token VALUES(''15820ab1-0945-4e72-9792-6dd480e73954'',''RelationType_isDescribedBy'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0fb34fbc-3ec1-4d3d-865d-6e7844223bd7'') = 0
	insert into semtbl_Token VALUES(''0fb34fbc-3ec1-4d3d-865d-6e7844223bd7'',''Type_Kunst'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6e494944-f602-4dcb-906f-70e5efe8f1dd'') = 0
	insert into semtbl_Token VALUES(''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''RelationType_is_of_Type'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f2cde058-614e-41cb-96eb-78bbcf285171'') = 0
	insert into semtbl_Token VALUES(''f2cde058-614e-41cb-96eb-78bbcf285171'',''RelationType_offered_by'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''54ee77fa-3d84-4564-a2d8-7a484c66c0e8'') = 0
	insert into semtbl_Token VALUES(''54ee77fa-3d84-4564-a2d8-7a484c66c0e8'',''Type_Day'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''55635d10-7db1-4aed-a4f5-7b3ce3649879'') = 0
	insert into semtbl_Token VALUES(''55635d10-7db1-4aed-a4f5-7b3ce3649879'',''Type_Wichtige_Ereignisse'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''36ee074b-a672-4bf0-b744-7b880ba58207'') = 0
	insert into semtbl_Token VALUES(''36ee074b-a672-4bf0-b744-7b880ba58207'',''RelationType_has'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3965c342-890d-4227-84fe-7bf195c36325'') = 0
	insert into semtbl_Token VALUES(''3965c342-890d-4227-84fe-7bf195c36325'',''Type_Genre'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7375ee4b-b6ba-4df4-9433-7f88f4b1d1b9'') = 0
	insert into semtbl_Token VALUES(''7375ee4b-b6ba-4df4-9433-7f88f4b1d1b9'',''Attribute_Media_Position'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''11c42673-8aee-4dec-ae12-87e0bcd4b551'') = 0
	insert into semtbl_Token VALUES(''11c42673-8aee-4dec-ae12-87e0bcd4b551'',''Token_Variable_ITEMCOUNT'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3c61b8a2-0550-47ba-a38e-8934144332e4'') = 0
	insert into semtbl_Token VALUES(''3c61b8a2-0550-47ba-a38e-8934144332e4'',''Token_Image_Objects__No_Objects__no_species'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ffaf3ed4-1024-4842-a776-8c6e1ba13d98'') = 0
	insert into semtbl_Token VALUES(''ffaf3ed4-1024-4842-a776-8c6e1ba13d98'',''RelationType_from'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'') = 0
	insert into semtbl_Token VALUES(''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'',''RelationType_belonging_Source'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''afd32643-ddbc-4240-a009-8f8a741bbe45'') = 0
	insert into semtbl_Token VALUES(''afd32643-ddbc-4240-a009-8f8a741bbe45'',''Token_Variable_MEDIASRC'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''abce8221-44de-4962-9a28-8fa598144a88'') = 0
	insert into semtbl_Token VALUES(''abce8221-44de-4962-9a28-8fa598144a88'',''Attribute_comment'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c6eddf29-f402-4ee7-9b21-9148cbbe67f1'') = 0
	insert into semtbl_Token VALUES(''c6eddf29-f402-4ee7-9b21-9148cbbe67f1'',''Attribute_DateTimeStamp'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b07f9081-e969-439d-9616-91c9783915c0'') = 0
	insert into semtbl_Token VALUES(''b07f9081-e969-439d-9616-91c9783915c0'',''Token_Logstate_Unassigned'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''82553dbf-ce61-4b65-a633-96bd1c759f4c'') = 0
	insert into semtbl_Token VALUES(''82553dbf-ce61-4b65-a633-96bd1c759f4c'',''Type_landscape'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fb743b00-102e-4797-ab99-9bcfaa72041f'') = 0
	insert into semtbl_Token VALUES(''fb743b00-102e-4797-ab99-9bcfaa72041f'',''Token_Image_Objects__No_Objects__no_Pets'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b426d245-2c31-4558-9893-9f7e12578722'') = 0
	insert into semtbl_Token VALUES(''b426d245-2c31-4558-9893-9f7e12578722'',''Token_Extensions_pdf'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f936827c-e5b9-41aa-a897-a462d0bc2d72'') = 0
	insert into semtbl_Token VALUES(''f936827c-e5b9-41aa-a897-a462d0bc2d72'',''Type_PDF_Documents'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d8d3aabf-8d77-4108-8a26-a58a052ac265'') = 0
	insert into semtbl_Token VALUES(''d8d3aabf-8d77-4108-8a26-a58a052ac265'',''Type_mp3_File'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''94de9f11-b875-46ab-a6f3-a684a5c78e05'') = 0
	insert into semtbl_Token VALUES(''94de9f11-b875-46ab-a6f3-a684a5c78e05'',''Token_Variable_URL_MEDIASRC'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''87eb4dc0-bdae-4c49-bf3c-a70ea7a6a4d6'') = 0
	insert into semtbl_Token VALUES(''87eb4dc0-bdae-4c49-bf3c-a70ea7a6a4d6'',''Type_Language'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3d478c67-2bd0-4141-9459-a7cdc8d21fb8'') = 0
	insert into semtbl_Token VALUES(''3d478c67-2bd0-4141-9459-a7cdc8d21fb8'',''Type_Band'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3186cc5e-023b-4edc-b6c7-a89919320839'') = 0
	insert into semtbl_Token VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''RelationType_belongsTo'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''32795bc3-e71b-488d-91a7-a8fe44d87988'') = 0
	insert into semtbl_Token VALUES(''32795bc3-e71b-488d-91a7-a8fe44d87988'',''RelationType_Disc'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f10253cf-f5c4-4777-8f4b-abc61217e28b'') = 0
	insert into semtbl_Token VALUES(''f10253cf-f5c4-4777-8f4b-abc61217e28b'',''Type_Url'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9a1564a4-a5e8-464d-b901-b3b716aaa24f'') = 0
	insert into semtbl_Token VALUES(''9a1564a4-a5e8-464d-b901-b3b716aaa24f'',''Token_Logstate_Last_Position'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f1ba23ed-ab41-4d34-8e09-b4e485671478'') = 0
	insert into semtbl_Token VALUES(''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''Type_File'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b63ef338-285a-4358-94fc-bb31b8bfebd0'') = 0
	insert into semtbl_Token VALUES(''b63ef338-285a-4358-94fc-bb31b8bfebd0'',''Type_Bauwerke'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''59df733f-6853-4af3-87d6-bd769bc34684'') = 0
	insert into semtbl_Token VALUES(''59df733f-6853-4af3-87d6-bd769bc34684'',''Type_Search_Template'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5a9ea127-d417-47bb-84f8-c0655a84815b'') = 0
	insert into semtbl_Token VALUES(''5a9ea127-d417-47bb-84f8-c0655a84815b'',''Type_Tierarten'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6b4eb5ee-7009-49eb-a355-c5144275e004'') = 0
	insert into semtbl_Token VALUES(''6b4eb5ee-7009-49eb-a355-c5144275e004'',''Type_Image_Module'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a144f6f2-756d-4a12-ab01-c579174a64f0'') = 0
	insert into semtbl_Token VALUES(''a144f6f2-756d-4a12-ab01-c579174a64f0'',''Token_Image_Objects__No_Objects__no_Artwork'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a1339a65-c133-42e9-8e2c-c5b0b98c2e02'') = 0
	insert into semtbl_Token VALUES(''a1339a65-c133-42e9-8e2c-c5b0b98c2e02'',''Token_Image_Objects__No_Objects__no_plant_Species'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bf1af2ef-5cc5-4219-ad93-c846d18b02f4'') = 0
	insert into semtbl_Token VALUES(''bf1af2ef-5cc5-4219-ad93-c846d18b02f4'',''Token_Image_Objects__No_Objects__weather_condition'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3ed4e4e7-1acf-4724-9d57-ca0b5366d49d'') = 0
	insert into semtbl_Token VALUES(''3ed4e4e7-1acf-4724-9d57-ca0b5366d49d'',''Token_Logstate_Stop'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8618f96e-8494-432a-99da-cc91e6c117d5'') = 0
	insert into semtbl_Token VALUES(''8618f96e-8494-432a-99da-cc91e6c117d5'',''RelationType_located_in'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2c8b2594-908b-4e85-bd14-ce0727e2456a'') = 0
	insert into semtbl_Token VALUES(''2c8b2594-908b-4e85-bd14-ce0727e2456a'',''Type_Ort'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''594ef5cd-f083-4a78-8a5d-d0aabee43967'') = 0
	insert into semtbl_Token VALUES(''594ef5cd-f083-4a78-8a5d-d0aabee43967'',''type_User'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''22faaa6d-8fbe-4b5a-8856-dec1fbcb5959'') = 0
	insert into semtbl_Token VALUES(''22faaa6d-8fbe-4b5a-8856-dec1fbcb5959'',''RelationType_offers'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ab57193e-56cc-4f75-81a1-e2529fa99196'') = 0
	insert into semtbl_Token VALUES(''ab57193e-56cc-4f75-81a1-e2529fa99196'',''Type_Pflanzenarten'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''82be9300-79bd-407f-8c77-e429a2dafc58'') = 0
	insert into semtbl_Token VALUES(''82be9300-79bd-407f-8c77-e429a2dafc58'',''Token_Search_Template_Name_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''97ce5aad-fd31-479c-9164-e6e26f35a650'') = 0
	insert into semtbl_Token VALUES(''97ce5aad-fd31-479c-9164-e6e26f35a650'',''Token_Variable_title'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''470abd26-c317-4625-91a7-e9828b751893'') = 0
	insert into semtbl_Token VALUES(''470abd26-c317-4625-91a7-e9828b751893'',''Type_LogEntry'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''92121dac-d796-4dac-acc8-ea779f9cb1cd'') = 0
	insert into semtbl_Token VALUES(''92121dac-d796-4dac-acc8-ea779f9cb1cd'',''Type_Partner'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3faebef6-8e7d-4e06-8085-eba30e529f72'') = 0
	insert into semtbl_Token VALUES(''3faebef6-8e7d-4e06-8085-eba30e529f72'',''RelationType_wasCreatedBy'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e1627ced-e28d-4864-bcad-ee1af3f783ca'') = 0
	insert into semtbl_Token VALUES(''e1627ced-e28d-4864-bcad-ee1af3f783ca'',''Token_Image_Objects__No_Objects__no_Symbol'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7e3ffe0b-3974-4db7-8ffe-ee37609d7ec8'') = 0
	insert into semtbl_Token VALUES(''7e3ffe0b-3974-4db7-8ffe-ee37609d7ec8'',''Type_Media_Item_Bookmark'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ea755e36-262f-4c2e-956c-f120cbf638ce'') = 0
	insert into semtbl_Token VALUES(''ea755e36-262f-4c2e-956c-f120cbf638ce'',''Type_Album'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4fbada37-ac86-49f2-b06e-f6c5d7db8d2d'') = 0
	insert into semtbl_Token VALUES(''4fbada37-ac86-49f2-b06e-f6c5d7db8d2d'',''Type_Haustier'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b4d86c89-dbd6-432f-a048-f71d29dd39b1'') = 0
	insert into semtbl_Token VALUES(''b4d86c89-dbd6-432f-a048-f71d29dd39b1'',''RelationType_Composer'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''eb37c6a5-1ea2-4bf6-9951-fa2310fd38c9'') = 0
	insert into semtbl_Token VALUES(''eb37c6a5-1ea2-4bf6-9951-fa2310fd38c9'',''Token_Logstate_Start'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7dbbd3e8-635a-4dc5-a30b-fc3814271b8d'') = 0
	insert into semtbl_Token VALUES(''7dbbd3e8-635a-4dc5-a30b-fc3814271b8d'',''RelationType_started_with'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8f978e33-6565-4144-b2e3-ff28e652310a'') = 0
	insert into semtbl_Token VALUES(''8f978e33-6565-4144-b2e3-ff28e652310a'',''RelationType_finished_with'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''414061f9-bd6d-476f-b513-5762c0000c8c'') = 0
	insert into semtbl_Token VALUES(''414061f9-bd6d-476f-b513-5762c0000c8c'',''no landscape'',''5325e946-86c1-4254-b463-c7538d39caa3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''02d6213b-bc26-4afa-af20-9711a3872c33'') = 0
	insert into semtbl_Token VALUES(''02d6213b-bc26-4afa-af20-9711a3872c33'',''jpg'',''6e31f905-20ce-4f8f-b401-6da5ba871ecb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a741817e-054b-47f1-a2b5-4324e261c8be'') = 0
	insert into semtbl_Token VALUES(''a741817e-054b-47f1-a2b5-4324e261c8be'',''no Buildings'',''5325e946-86c1-4254-b463-c7538d39caa3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ea90b682-91fe-468d-8787-82dd86a2d7a8'') = 0
	insert into semtbl_Token VALUES(''ea90b682-91fe-468d-8787-82dd86a2d7a8'',''Windows Playlist 1.0 mediasrc'',''327e9773-fca6-458c-a44d-338a556e0ad9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8b25dedf-eb59-4b0c-a033-8cb006af7ee2'') = 0
	insert into semtbl_Token VALUES(''8b25dedf-eb59-4b0c-a033-8cb006af7ee2'',''no Persons'',''5325e946-86c1-4254-b463-c7538d39caa3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bd8030e7-038e-4ce8-8ae8-38e034bf960d'') = 0
	insert into semtbl_Token VALUES(''bd8030e7-038e-4ce8-8ae8-38e034bf960d'',''no Address'',''5325e946-86c1-4254-b463-c7538d39caa3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''db1a6d4e-bb72-4f80-8c16-67d9081cbdc9'') = 0
	insert into semtbl_Token VALUES(''db1a6d4e-bb72-4f80-8c16-67d9081cbdc9'',''Windows Playlist 1.0'',''327e9773-fca6-458c-a44d-338a556e0ad9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bdb17d4e-37d0-498e-b817-48937925c047'') = 0
	insert into semtbl_Token VALUES(''bdb17d4e-37d0-498e-b817-48937925c047'',''Pause'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4fa6bfbc-b99e-4586-8963-868d6fe48a27'') = 0
	insert into semtbl_Token VALUES(''4fa6bfbc-b99e-4586-8963-868d6fe48a27'',''User-Defined'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f3a48068-25c9-48d6-8fe2-3ffcca4ab67d'') = 0
	insert into semtbl_Token VALUES(''f3a48068-25c9-48d6-8fe2-3ffcca4ab67d'',''no Location'',''5325e946-86c1-4254-b463-c7538d39caa3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''448e90c7-19e8-40a2-a834-8a13d918880c'') = 0
	insert into semtbl_Token VALUES(''448e90c7-19e8-40a2-a834-8a13d918880c'',''mod'',''6e31f905-20ce-4f8f-b401-6da5ba871ecb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9c127bc9-640a-4159-b88b-cb04ae9eb8ba'') = 0
	insert into semtbl_Token VALUES(''9c127bc9-640a-4159-b88b-cb04ae9eb8ba'',''ITEMCOUNT'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8eb37136-7997-48e2-9b39-841cb827b29e'') = 0
	insert into semtbl_Token VALUES(''8eb37136-7997-48e2-9b39-841cb827b29e'',''no species'',''5325e946-86c1-4254-b463-c7538d39caa3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''09ad9ee2-6845-42cc-9b02-d74e1aef0ac5'') = 0
	insert into semtbl_Token VALUES(''09ad9ee2-6845-42cc-9b02-d74e1aef0ac5'',''MEDIASRC'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''438e52d1-8501-4a3f-86c3-a626e197c76f'') = 0
	insert into semtbl_Token VALUES(''438e52d1-8501-4a3f-86c3-a626e197c76f'',''Unassigned'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a3cc47e1-9624-4d62-b7d3-9d732c1d27a2'') = 0
	insert into semtbl_Token VALUES(''a3cc47e1-9624-4d62-b7d3-9d732c1d27a2'',''no Pets'',''5325e946-86c1-4254-b463-c7538d39caa3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ee821a89-db55-47ba-85b8-3c4049ba8143'') = 0
	insert into semtbl_Token VALUES(''ee821a89-db55-47ba-85b8-3c4049ba8143'',''pdf'',''6e31f905-20ce-4f8f-b401-6da5ba871ecb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''00bb92bb-ea89-4838-8964-6a1a4c34d902'') = 0
	insert into semtbl_Token VALUES(''00bb92bb-ea89-4838-8964-6a1a4c34d902'',''URL_MEDIASRC'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3dfc2a38-8ea7-4864-8d9c-3f811fb1f16a'') = 0
	insert into semtbl_Token VALUES(''3dfc2a38-8ea7-4864-8d9c-3f811fb1f16a'',''Last Position'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f134e9d2-db45-4523-b270-26184f36a1de'') = 0
	insert into semtbl_Token VALUES(''f134e9d2-db45-4523-b270-26184f36a1de'',''no Artwork'',''5325e946-86c1-4254-b463-c7538d39caa3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a9a13d03-2070-44a0-b1d3-32cae06460c3'') = 0
	insert into semtbl_Token VALUES(''a9a13d03-2070-44a0-b1d3-32cae06460c3'',''no plant Species'',''5325e946-86c1-4254-b463-c7538d39caa3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''af4e1fac-fd8c-49d5-ab6c-d4c8537dbcc1'') = 0
	insert into semtbl_Token VALUES(''af4e1fac-fd8c-49d5-ab6c-d4c8537dbcc1'',''no weather condition'',''5325e946-86c1-4254-b463-c7538d39caa3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5895fa84-0476-487c-b5df-c7a7485c63d2'') = 0
	insert into semtbl_Token VALUES(''5895fa84-0476-487c-b5df-c7a7485c63d2'',''Stop'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a030d27f-d920-4a87-a513-faaf4ccd2af7'') = 0
	insert into semtbl_Token VALUES(''a030d27f-d920-4a87-a513-faaf4ccd2af7'',''Name/GUID:'',''499ec20d-af6f-4e72-bf55-ffb6eac101bf'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8bfa64a0-7bfe-4ecc-ab35-3c2592664157'') = 0
	insert into semtbl_Token VALUES(''8bfa64a0-7bfe-4ecc-ab35-3c2592664157'',''title'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9775ef77-f511-41fa-93e4-5ede1ea379ba'') = 0
	insert into semtbl_Token VALUES(''9775ef77-f511-41fa-93e4-5ede1ea379ba'',''no Symbol'',''5325e946-86c1-4254-b463-c7538d39caa3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''eabea67d-a6c4-41e3-998d-3e79aa87c116'') = 0
	insert into semtbl_Token VALUES(''eabea67d-a6c4-41e3-998d-3e79aa87c116'',''Start'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6f3fc129-61c4-4c2b-b6bd-a189b13b2c3e'') = 0
	insert into semtbl_Token VALUES(''6f3fc129-61c4-4c2b-b6bd-a189b13b2c3e'',''MediaViewer-Module'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''49c6293d-838e-4b9c-b0de-d4ae569e605b'') = 0
	insert into semtbl_Token VALUES(''49c6293d-838e-4b9c-b0de-d4ae569e605b'',''Base-Config'',''460cb016-8fbb-47ae-91c8-cd9d8db5d8f4'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''f0becf55-4a6e-431c-b655-006503f59b47'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''f0becf55-4a6e-431c-b655-006503f59b47'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''fb9503c0-b884-434e-af8a-0066c7a6c40f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''fb9503c0-b884-434e-af8a-0066c7a6c40f'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''bd160ac5-040a-410f-88f6-04d3659370e8'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''bd160ac5-040a-410f-88f6-04d3659370e8'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''ab95f5bb-5de1-42b0-9d4c-13d076ca3554'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''ab95f5bb-5de1-42b0-9d4c-13d076ca3554'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''89a8ce8f-d745-4d78-b82a-14306084cfc1'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''89a8ce8f-d745-4d78-b82a-14306084cfc1'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''e311bbb5-4f2f-4757-b6f2-17b0849ce722'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''e311bbb5-4f2f-4757-b6f2-17b0849ce722'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''b53826c1-bddc-4fc2-a922-180c32ea7207'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''b53826c1-bddc-4fc2-a922-180c32ea7207'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''73c0acf6-36ff-4c63-a190-191fa3a8644b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''73c0acf6-36ff-4c63-a190-191fa3a8644b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''c1df5546-3c90-4160-9924-1b6e5cee7920'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''c1df5546-3c90-4160-9924-1b6e5cee7920'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''98fbd3cc-40ac-4a19-b0f8-1f9e8efaff91'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''98fbd3cc-40ac-4a19-b0f8-1f9e8efaff91'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''14f006b5-b225-4899-a0ac-2075f3ed3280'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''14f006b5-b225-4899-a0ac-2075f3ed3280'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''dc9ebe84-dd16-4f9c-bd77-294920c9387d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''dc9ebe84-dd16-4f9c-bd77-294920c9387d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''375c73ad-9a93-4775-a2ba-2fb097efb6ba'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''375c73ad-9a93-4775-a2ba-2fb097efb6ba'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''708a17aa-c475-4f08-a8d7-32a20269ca8a'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''708a17aa-c475-4f08-a8d7-32a20269ca8a'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''cd5df308-8f49-4bb1-8d5d-33ed4279b850'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''cd5df308-8f49-4bb1-8d5d-33ed4279b850'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''26c6954f-c062-423b-b598-34147b3013fd'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''26c6954f-c062-423b-b598-34147b3013fd'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''747952da-2e66-49c1-8462-3a20addbc0ef'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''747952da-2e66-49c1-8462-3a20addbc0ef'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''25c4a23b-baa0-4a4d-9b4f-40b354d3fac4'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''25c4a23b-baa0-4a4d-9b4f-40b354d3fac4'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''d0891239-7599-4e1b-9987-4830333ab06c'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''d0891239-7599-4e1b-9987-4830333ab06c'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''60dac2f0-947c-47cd-9933-4a4e69681176'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''60dac2f0-947c-47cd-9933-4a4e69681176'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''00a54315-adbd-4073-a92e-4dc7cd9149d0'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''00a54315-adbd-4073-a92e-4dc7cd9149d0'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''7de69c8a-375c-43d9-b8db-4f5746c949e1'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''7de69c8a-375c-43d9-b8db-4f5746c949e1'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''3749880b-154c-4197-ab8d-533a8b36f690'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''3749880b-154c-4197-ab8d-533a8b36f690'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''d72ffddd-bd17-4fa3-b856-549af23b2273'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''d72ffddd-bd17-4fa3-b856-549af23b2273'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''022a6b7a-02c8-4433-8764-5c21c5205ac1'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''022a6b7a-02c8-4433-8764-5c21c5205ac1'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''890a4d05-9c9f-47a0-b809-60c0676064be'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''890a4d05-9c9f-47a0-b809-60c0676064be'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''6c966e3c-c737-4af1-9970-68c8323679bc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''6c966e3c-c737-4af1-9970-68c8323679bc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''45206556-4bf3-4d9c-9b1a-6a123f970878'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''45206556-4bf3-4d9c-9b1a-6a123f970878'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''565ccbae-718f-4b3d-bd06-6a1906653220'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''565ccbae-718f-4b3d-bd06-6a1906653220'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''1f5c49ef-bee4-4fbc-a009-6aa4ac85cd40'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''1f5c49ef-bee4-4fbc-a009-6aa4ac85cd40'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''3111af84-bd07-4635-80de-6c666b8c95eb'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''3111af84-bd07-4635-80de-6c666b8c95eb'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''00029a7e-0e7f-4f0a-b818-6ce8c9a517d3'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''00029a7e-0e7f-4f0a-b818-6ce8c9a517d3'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''15820ab1-0945-4e72-9792-6dd480e73954'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''15820ab1-0945-4e72-9792-6dd480e73954'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''0fb34fbc-3ec1-4d3d-865d-6e7844223bd7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''0fb34fbc-3ec1-4d3d-865d-6e7844223bd7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''6e494944-f602-4dcb-906f-70e5efe8f1dd'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''f2cde058-614e-41cb-96eb-78bbcf285171'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''f2cde058-614e-41cb-96eb-78bbcf285171'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''54ee77fa-3d84-4564-a2d8-7a484c66c0e8'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''54ee77fa-3d84-4564-a2d8-7a484c66c0e8'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''55635d10-7db1-4aed-a4f5-7b3ce3649879'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''55635d10-7db1-4aed-a4f5-7b3ce3649879'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''36ee074b-a672-4bf0-b744-7b880ba58207'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''36ee074b-a672-4bf0-b744-7b880ba58207'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''3965c342-890d-4227-84fe-7bf195c36325'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''3965c342-890d-4227-84fe-7bf195c36325'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''7375ee4b-b6ba-4df4-9433-7f88f4b1d1b9'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''7375ee4b-b6ba-4df4-9433-7f88f4b1d1b9'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''11c42673-8aee-4dec-ae12-87e0bcd4b551'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''11c42673-8aee-4dec-ae12-87e0bcd4b551'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''3c61b8a2-0550-47ba-a38e-8934144332e4'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''3c61b8a2-0550-47ba-a38e-8934144332e4'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''ffaf3ed4-1024-4842-a776-8c6e1ba13d98'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''ffaf3ed4-1024-4842-a776-8c6e1ba13d98'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''afd32643-ddbc-4240-a009-8f8a741bbe45'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''afd32643-ddbc-4240-a009-8f8a741bbe45'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''abce8221-44de-4962-9a28-8fa598144a88'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''abce8221-44de-4962-9a28-8fa598144a88'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''c6eddf29-f402-4ee7-9b21-9148cbbe67f1'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''c6eddf29-f402-4ee7-9b21-9148cbbe67f1'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''b07f9081-e969-439d-9616-91c9783915c0'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''b07f9081-e969-439d-9616-91c9783915c0'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''82553dbf-ce61-4b65-a633-96bd1c759f4c'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''82553dbf-ce61-4b65-a633-96bd1c759f4c'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''fb743b00-102e-4797-ab99-9bcfaa72041f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''fb743b00-102e-4797-ab99-9bcfaa72041f'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''b426d245-2c31-4558-9893-9f7e12578722'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''b426d245-2c31-4558-9893-9f7e12578722'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''f936827c-e5b9-41aa-a897-a462d0bc2d72'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''f936827c-e5b9-41aa-a897-a462d0bc2d72'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''d8d3aabf-8d77-4108-8a26-a58a052ac265'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''d8d3aabf-8d77-4108-8a26-a58a052ac265'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''94de9f11-b875-46ab-a6f3-a684a5c78e05'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''94de9f11-b875-46ab-a6f3-a684a5c78e05'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''87eb4dc0-bdae-4c49-bf3c-a70ea7a6a4d6'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''87eb4dc0-bdae-4c49-bf3c-a70ea7a6a4d6'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''3d478c67-2bd0-4141-9459-a7cdc8d21fb8'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''3d478c67-2bd0-4141-9459-a7cdc8d21fb8'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''3186cc5e-023b-4edc-b6c7-a89919320839'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''32795bc3-e71b-488d-91a7-a8fe44d87988'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''32795bc3-e71b-488d-91a7-a8fe44d87988'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''f10253cf-f5c4-4777-8f4b-abc61217e28b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''f10253cf-f5c4-4777-8f4b-abc61217e28b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''9a1564a4-a5e8-464d-b901-b3b716aaa24f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''9a1564a4-a5e8-464d-b901-b3b716aaa24f'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''f1ba23ed-ab41-4d34-8e09-b4e485671478'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''b63ef338-285a-4358-94fc-bb31b8bfebd0'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''b63ef338-285a-4358-94fc-bb31b8bfebd0'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''59df733f-6853-4af3-87d6-bd769bc34684'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''59df733f-6853-4af3-87d6-bd769bc34684'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''5a9ea127-d417-47bb-84f8-c0655a84815b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''5a9ea127-d417-47bb-84f8-c0655a84815b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''6b4eb5ee-7009-49eb-a355-c5144275e004'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''6b4eb5ee-7009-49eb-a355-c5144275e004'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''a144f6f2-756d-4a12-ab01-c579174a64f0'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''a144f6f2-756d-4a12-ab01-c579174a64f0'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''a1339a65-c133-42e9-8e2c-c5b0b98c2e02'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''a1339a65-c133-42e9-8e2c-c5b0b98c2e02'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''bf1af2ef-5cc5-4219-ad93-c846d18b02f4'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''bf1af2ef-5cc5-4219-ad93-c846d18b02f4'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''3ed4e4e7-1acf-4724-9d57-ca0b5366d49d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''3ed4e4e7-1acf-4724-9d57-ca0b5366d49d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''8618f96e-8494-432a-99da-cc91e6c117d5'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''8618f96e-8494-432a-99da-cc91e6c117d5'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''2c8b2594-908b-4e85-bd14-ce0727e2456a'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''2c8b2594-908b-4e85-bd14-ce0727e2456a'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''594ef5cd-f083-4a78-8a5d-d0aabee43967'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''594ef5cd-f083-4a78-8a5d-d0aabee43967'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''22faaa6d-8fbe-4b5a-8856-dec1fbcb5959'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''22faaa6d-8fbe-4b5a-8856-dec1fbcb5959'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''ab57193e-56cc-4f75-81a1-e2529fa99196'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''ab57193e-56cc-4f75-81a1-e2529fa99196'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''82be9300-79bd-407f-8c77-e429a2dafc58'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''82be9300-79bd-407f-8c77-e429a2dafc58'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''97ce5aad-fd31-479c-9164-e6e26f35a650'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''97ce5aad-fd31-479c-9164-e6e26f35a650'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''470abd26-c317-4625-91a7-e9828b751893'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''470abd26-c317-4625-91a7-e9828b751893'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''92121dac-d796-4dac-acc8-ea779f9cb1cd'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''92121dac-d796-4dac-acc8-ea779f9cb1cd'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''3faebef6-8e7d-4e06-8085-eba30e529f72'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''3faebef6-8e7d-4e06-8085-eba30e529f72'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''e1627ced-e28d-4864-bcad-ee1af3f783ca'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''e1627ced-e28d-4864-bcad-ee1af3f783ca'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''7e3ffe0b-3974-4db7-8ffe-ee37609d7ec8'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''7e3ffe0b-3974-4db7-8ffe-ee37609d7ec8'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''ea755e36-262f-4c2e-956c-f120cbf638ce'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''ea755e36-262f-4c2e-956c-f120cbf638ce'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''4fbada37-ac86-49f2-b06e-f6c5d7db8d2d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''4fbada37-ac86-49f2-b06e-f6c5d7db8d2d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''b4d86c89-dbd6-432f-a048-f71d29dd39b1'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''b4d86c89-dbd6-432f-a048-f71d29dd39b1'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''eb37c6a5-1ea2-4bf6-9951-fa2310fd38c9'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''eb37c6a5-1ea2-4bf6-9951-fa2310fd38c9'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''7dbbd3e8-635a-4dc5-a30b-fc3814271b8d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''7dbbd3e8-635a-4dc5-a30b-fc3814271b8d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_Token_Right=''8f978e33-6565-4144-b2e3-ff28e652310a'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''8f978e33-6565-4144-b2e3-ff28e652310a'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b8e5b73f-c84a-48f7-ad9e-48d1ad6c7d66'' AND GUID_Token_Right=''d1edff2c-081b-4df5-9f60-4d091d7eafc5'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b8e5b73f-c84a-48f7-ad9e-48d1ad6c7d66'',''d1edff2c-081b-4df5-9f60-4d091d7eafc5'',''fafc1464-815f-4596-9737-bcbc96bd744a'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ea90b682-91fe-468d-8787-82dd86a2d7a8'' AND GUID_Token_Right=''00bb92bb-ea89-4838-8964-6a1a4c34d902'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ea90b682-91fe-468d-8787-82dd86a2d7a8'',''00bb92bb-ea89-4838-8964-6a1a4c34d902'',''e9711603-47db-44d8-a476-fe88290639a4'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''db1a6d4e-bb72-4f80-8c16-67d9081cbdc9'' AND GUID_Token_Right=''8bfa64a0-7bfe-4ecc-ab35-3c2592664157'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''db1a6d4e-bb72-4f80-8c16-67d9081cbdc9'',''8bfa64a0-7bfe-4ecc-ab35-3c2592664157'',''e9711603-47db-44d8-a476-fe88290639a4'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''db1a6d4e-bb72-4f80-8c16-67d9081cbdc9'' AND GUID_Token_Right=''9c127bc9-640a-4159-b88b-cb04ae9eb8ba'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''db1a6d4e-bb72-4f80-8c16-67d9081cbdc9'',''9c127bc9-640a-4159-b88b-cb04ae9eb8ba'',''e9711603-47db-44d8-a476-fe88290639a4'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''db1a6d4e-bb72-4f80-8c16-67d9081cbdc9'' AND GUID_Token_Right=''09ad9ee2-6845-42cc-9b02-d74e1aef0ac5'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''db1a6d4e-bb72-4f80-8c16-67d9081cbdc9'',''09ad9ee2-6845-42cc-9b02-d74e1aef0ac5'',''e9711603-47db-44d8-a476-fe88290639a4'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''6f3fc129-61c4-4c2b-b6bd-a189b13b2c3e'' AND GUID_Token_Right=''b8e5b73f-c84a-48f7-ad9e-48d1ad6c7d66'' AND GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	INSERT INTO semtbl_Token_Token VALUES(''6f3fc129-61c4-4c2b-b6bd-a189b13b2c3e'',''b8e5b73f-c84a-48f7-ad9e-48d1ad6c7d66'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''6f3fc129-61c4-4c2b-b6bd-a189b13b2c3e'' AND GUID_Token_Right=''a030d27f-d920-4a87-a513-faaf4ccd2af7'' AND GUID_RelationType=''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'')=0
	INSERT INTO semtbl_Token_Token VALUES(''6f3fc129-61c4-4c2b-b6bd-a189b13b2c3e'',''a030d27f-d920-4a87-a513-faaf4ccd2af7'',''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''49c6293d-838e-4b9c-b0de-d4ae569e605b'' AND GUID_Token_Right=''6f3fc129-61c4-4c2b-b6bd-a189b13b2c3e'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''49c6293d-838e-4b9c-b0de-d4ae569e605b'',''6f3fc129-61c4-4c2b-b6bd-a189b13b2c3e'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''83f136c4-cb76-4029-88ab-5ab8f10c1532'' AND GUID_Attribute=''0b183be9-c13d-4157-989b-63b0362aeee6'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''83f136c4-cb76-4029-88ab-5ab8f10c1532'',''0b183be9-c13d-4157-989b-63b0362aeee6'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''d84fa125-dbce-44b0-9153-9abeb66ad27f'' AND GUID_Attribute=''0b183be9-c13d-4157-989b-63b0362aeee6'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''d84fa125-dbce-44b0-9153-9abeb66ad27f'',''0b183be9-c13d-4157-989b-63b0362aeee6'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''759bb22d-20b5-42ff-8079-813c2496946d'' AND GUID_Attribute=''0b183be9-c13d-4157-989b-63b0362aeee6'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''759bb22d-20b5-42ff-8079-813c2496946d'',''0b183be9-c13d-4157-989b-63b0362aeee6'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Attribute=''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Attribute=''b67c3f3c-da03-4693-9afc-d2014997e328'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''b67c3f3c-da03-4693-9afc-d2014997e328'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''f62cf1cc-ee51-475f-9c00-7094f1809b56'' AND GUID_Attribute=''0b183be9-c13d-4157-989b-63b0362aeee6'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''f62cf1cc-ee51-475f-9c00-7094f1809b56'',''0b183be9-c13d-4157-989b-63b0362aeee6'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''f62cf1cc-ee51-475f-9c00-7094f1809b56'' AND GUID_Attribute=''6092162a-d4cb-4655-8753-e18a662fb28f'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''f62cf1cc-ee51-475f-9c00-7094f1809b56'',''6092162a-d4cb-4655-8753-e18a662fb28f'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''3f7f258e-76b2-49ae-b5cc-25184f39899f'' AND GUID_Attribute=''0b183be9-c13d-4157-989b-63b0362aeee6'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''3f7f258e-76b2-49ae-b5cc-25184f39899f'',''0b183be9-c13d-4157-989b-63b0362aeee6'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''95029348-dd27-47cd-bf36-cd68739673b8'' AND GUID_Attribute=''0b183be9-c13d-4157-989b-63b0362aeee6'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''95029348-dd27-47cd-bf36-cd68739673b8'',''0b183be9-c13d-4157-989b-63b0362aeee6'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''d0f58213-7db4-4882-bd15-962163015d13'' AND GUID_Attribute=''0b183be9-c13d-4157-989b-63b0362aeee6'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''d0f58213-7db4-4882-bd15-962163015d13'',''0b183be9-c13d-4157-989b-63b0362aeee6'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''0e228554-4c7e-48e0-ba03-2de51394be4a'' AND GUID_Attribute=''e93b6ef9-7e8c-4215-affa-2bb239d0ea45'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''0e228554-4c7e-48e0-ba03-2de51394be4a'',''e93b6ef9-7e8c-4215-affa-2bb239d0ea45'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''0e228554-4c7e-48e0-ba03-2de51394be4a'' AND GUID_Attribute=''30a83dbb-ceef-416e-8060-9a58d93d6636'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''0e228554-4c7e-48e0-ba03-2de51394be4a'',''30a83dbb-ceef-416e-8060-9a58d93d6636'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''0e228554-4c7e-48e0-ba03-2de51394be4a'' AND GUID_Attribute=''006b6f41-26a0-4d7b-b0d6-d2cf4dba3ff8'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''0e228554-4c7e-48e0-ba03-2de51394be4a'',''006b6f41-26a0-4d7b-b0d6-d2cf4dba3ff8'',1,1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''094d728d-6efc-463c-85c7-2dcfed903c78'' AND GUID_Attribute=''4fcf775b-2e0b-4712-be8d-0e8e0c643040'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''094d728d-6efc-463c-85c7-2dcfed903c78'',''4fcf775b-2e0b-4712-be8d-0e8e0c643040'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''094d728d-6efc-463c-85c7-2dcfed903c78'' AND GUID_Attribute=''166531b2-a224-4ce1-bd01-6e38fec36bb3'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''094d728d-6efc-463c-85c7-2dcfed903c78'',''166531b2-a224-4ce1-bd01-6e38fec36bb3'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''c441518d-bfe0-4d55-b538-df5c5555dd83'' AND GUID_Attribute=''301374ab-7877-4dd9-9e5b-36db1e1125fa'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''c441518d-bfe0-4d55-b538-df5c5555dd83'',''301374ab-7877-4dd9-9e5b-36db1e1125fa'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_Attribute=''2e5fd016-c574-4924-b724-d1b30640243a'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''351d4591-2495-4501-82ab-a425f5235db9'',''2e5fd016-c574-4924-b724-d1b30640243a'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_Attribute=''0d2c794d-281d-44ff-9767-eb8549d4ad16'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''351d4591-2495-4501-82ab-a425f5235db9'',''0d2c794d-281d-44ff-9767-eb8549d4ad16'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''e51633ca-e76f-4a3b-b4eb-95aace386755'' AND GUID_Attribute=''37347dbd-5b2c-45a4-b091-610d022566aa'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''e51633ca-e76f-4a3b-b4eb-95aace386755'',''37347dbd-5b2c-45a4-b091-610d022566aa'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_Attribute=''68ac4472-ee22-4229-96ec-9753a016900a'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''327e9773-fca6-458c-a44d-338a556e0ad9'',''68ac4472-ee22-4229-96ec-9753a016900a'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''4158aad2-656a-4fb9-97bf-524c6f5fecaa'' AND GUID_Attribute=''3940fb8a-7ec9-4bd5-9719-aed313da116d'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''4158aad2-656a-4fb9-97bf-524c6f5fecaa'',''3940fb8a-7ec9-4bd5-9719-aed313da116d'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'' AND GUID_Type_Right=''aa000e0c-5415-4be9-bf6a-0bb43fc53bcf'' AND GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	INSERT INTO semtbl_Type_Type VALUES(''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'',''aa000e0c-5415-4be9-bf6a-0bb43fc53bcf'',''3e104b75-e01c-48a0-b041-12908fd446a0'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'' AND GUID_Type_Right=''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'' AND GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	INSERT INTO semtbl_Type_Type VALUES(''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'',''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'',''3e104b75-e01c-48a0-b041-12908fd446a0'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'' AND GUID_Type_Right=''9428c7d3-7065-443e-ab0c-5086353f2e9a'' AND GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	INSERT INTO semtbl_Type_Type VALUES(''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'',''9428c7d3-7065-443e-ab0c-5086353f2e9a'',''3e104b75-e01c-48a0-b041-12908fd446a0'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'' AND GUID_Type_Right=''c0bb945e-d91e-42a9-ba59-50fe054b2fa0'' AND GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	INSERT INTO semtbl_Type_Type VALUES(''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'',''c0bb945e-d91e-42a9-ba59-50fe054b2fa0'',''3e104b75-e01c-48a0-b041-12908fd446a0'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'' AND GUID_Type_Right=''33cb21b4-58a7-4f56-b036-5d89bbc20993'' AND GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	INSERT INTO semtbl_Type_Type VALUES(''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'',''33cb21b4-58a7-4f56-b036-5d89bbc20993'',''3e104b75-e01c-48a0-b041-12908fd446a0'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'' AND GUID_Type_Right=''f62cf1cc-ee51-475f-9c00-7094f1809b56'' AND GUID_RelationType=''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'')=0
	INSERT INTO semtbl_Type_Type VALUES(''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'',''f62cf1cc-ee51-475f-9c00-7094f1809b56'',''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'' AND GUID_Type_Right=''402a7ca0-215e-47c8-9dfe-8cf1283dccc0'' AND GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	INSERT INTO semtbl_Type_Type VALUES(''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'',''402a7ca0-215e-47c8-9dfe-8cf1283dccc0'',''3e104b75-e01c-48a0-b041-12908fd446a0'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'' AND GUID_Type_Right=''a751ce27-5609-4c3a-9b6a-b685ea646d10'' AND GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	INSERT INTO semtbl_Type_Type VALUES(''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'',''a751ce27-5609-4c3a-9b6a-b685ea646d10'',''3e104b75-e01c-48a0-b041-12908fd446a0'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'' AND GUID_Type_Right=''5325e946-86c1-4254-b463-c7538d39caa3'' AND GUID_RelationType=''62fc3781-8c1f-47fd-af1e-f0ebf96beefb'')=0
	INSERT INTO semtbl_Type_Type VALUES(''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'',''5325e946-86c1-4254-b463-c7538d39caa3'',''62fc3781-8c1f-47fd-af1e-f0ebf96beefb'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'' AND GUID_Type_Right=''f1ae4aa2-1a92-4df1-ad63-cd4663dd26f1'' AND GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	INSERT INTO semtbl_Type_Type VALUES(''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'',''f1ae4aa2-1a92-4df1-ad63-cd4663dd26f1'',''3e104b75-e01c-48a0-b041-12908fd446a0'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'' AND GUID_Type_Right=''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'' AND GUID_RelationType=''f77ee633-19d8-4ea6-947f-9fb6efad3547'')=0
	INSERT INTO semtbl_Type_Type VALUES(''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'',''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'',''f77ee633-19d8-4ea6-947f-9fb6efad3547'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'' AND GUID_Type_Right=''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'' AND GUID_RelationType=''c9670b90-e5f0-4e30-a26d-ad3d6576ceac'')=0
	INSERT INTO semtbl_Type_Type VALUES(''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'',''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'',''c9670b90-e5f0-4e30-a26d-ad3d6576ceac'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''0e228554-4c7e-48e0-ba03-2de51394be4a'' AND GUID_Type_Right=''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'' AND GUID_RelationType=''9577533e-317f-4f6a-ae2d-d1a545092c68'')=0
	INSERT INTO semtbl_Type_Type VALUES(''0e228554-4c7e-48e0-ba03-2de51394be4a'',''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'',''9577533e-317f-4f6a-ae2d-d1a545092c68'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''0e228554-4c7e-48e0-ba03-2de51394be4a'' AND GUID_Type_Right=''83f136c4-cb76-4029-88ab-5ab8f10c1532'' AND GUID_RelationType=''ec06ec43-f52c-463b-8ca4-67ca12124da9'')=0
	INSERT INTO semtbl_Type_Type VALUES(''0e228554-4c7e-48e0-ba03-2de51394be4a'',''83f136c4-cb76-4029-88ab-5ab8f10c1532'',''ec06ec43-f52c-463b-8ca4-67ca12124da9'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''0e228554-4c7e-48e0-ba03-2de51394be4a'' AND GUID_Type_Right=''055c60b0-b807-46c1-a2cc-7b9dcf2c568a'' AND GUID_RelationType=''25ed2608-4b28-464e-8ae8-05f708e3986f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''0e228554-4c7e-48e0-ba03-2de51394be4a'',''055c60b0-b807-46c1-a2cc-7b9dcf2c568a'',''25ed2608-4b28-464e-8ae8-05f708e3986f'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''0e228554-4c7e-48e0-ba03-2de51394be4a'' AND GUID_Type_Right=''d84fa125-dbce-44b0-9153-9abeb66ad27f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''0e228554-4c7e-48e0-ba03-2de51394be4a'',''d84fa125-dbce-44b0-9153-9abeb66ad27f'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''0e228554-4c7e-48e0-ba03-2de51394be4a'' AND GUID_Type_Right=''95029348-dd27-47cd-bf36-cd68739673b8'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''0e228554-4c7e-48e0-ba03-2de51394be4a'',''95029348-dd27-47cd-bf36-cd68739673b8'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''0e228554-4c7e-48e0-ba03-2de51394be4a'' AND GUID_Type_Right=''7cf91a43-acdf-4624-8d1e-e6f9cdf10f89'' AND GUID_RelationType=''3371228a-5d2b-4357-8050-0159d1262007'')=0
	INSERT INTO semtbl_Type_Type VALUES(''0e228554-4c7e-48e0-ba03-2de51394be4a'',''7cf91a43-acdf-4624-8d1e-e6f9cdf10f89'',''3371228a-5d2b-4357-8050-0159d1262007'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''0e228554-4c7e-48e0-ba03-2de51394be4a'' AND GUID_Type_Right=''7886d705-2b02-4ddc-bf6e-f35f3e58e19f'' AND GUID_RelationType=''ec06ec43-f52c-463b-8ca4-67ca12124da9'')=0
	INSERT INTO semtbl_Type_Type VALUES(''0e228554-4c7e-48e0-ba03-2de51394be4a'',''7886d705-2b02-4ddc-bf6e-f35f3e58e19f'',''ec06ec43-f52c-463b-8ca4-67ca12124da9'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_Type_Right=''4158aad2-656a-4fb9-97bf-524c6f5fecaa'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''327e9773-fca6-458c-a44d-338a556e0ad9'',''4158aad2-656a-4fb9-97bf-524c6f5fecaa'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''f62cf1cc-ee51-475f-9c00-7094f1809b56'' AND GUID_Type_Right=''3f7f258e-76b2-49ae-b5cc-25184f39899f'' AND GUID_RelationType=''3ffa80d4-7d6e-4025-be19-31abf3ba7c12'')=0
	INSERT INTO semtbl_Type_Type VALUES(''f62cf1cc-ee51-475f-9c00-7094f1809b56'',''3f7f258e-76b2-49ae-b5cc-25184f39899f'',''3ffa80d4-7d6e-4025-be19-31abf3ba7c12'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''f62cf1cc-ee51-475f-9c00-7094f1809b56'' AND GUID_Type_Right=''83f136c4-cb76-4029-88ab-5ab8f10c1532'' AND GUID_RelationType=''3ffa80d4-7d6e-4025-be19-31abf3ba7c12'')=0
	INSERT INTO semtbl_Type_Type VALUES(''f62cf1cc-ee51-475f-9c00-7094f1809b56'',''83f136c4-cb76-4029-88ab-5ab8f10c1532'',''3ffa80d4-7d6e-4025-be19-31abf3ba7c12'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''f62cf1cc-ee51-475f-9c00-7094f1809b56'' AND GUID_Type_Right=''759bb22d-20b5-42ff-8079-813c2496946d'' AND GUID_RelationType=''3ffa80d4-7d6e-4025-be19-31abf3ba7c12'')=0
	INSERT INTO semtbl_Type_Type VALUES(''f62cf1cc-ee51-475f-9c00-7094f1809b56'',''759bb22d-20b5-42ff-8079-813c2496946d'',''3ffa80d4-7d6e-4025-be19-31abf3ba7c12'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''f62cf1cc-ee51-475f-9c00-7094f1809b56'' AND GUID_Type_Right=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	INSERT INTO semtbl_Type_Type VALUES(''f62cf1cc-ee51-475f-9c00-7094f1809b56'',''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''e51633ca-e76f-4a3b-b4eb-95aace386755'' AND GUID_Type_Right=''d84fa125-dbce-44b0-9153-9abeb66ad27f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''e51633ca-e76f-4a3b-b4eb-95aace386755'',''d84fa125-dbce-44b0-9153-9abeb66ad27f'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''e51633ca-e76f-4a3b-b4eb-95aace386755'' AND GUID_Type_Right=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_RelationType=''03d96017-6535-4cad-9327-e00a7d11761d'')=0
	INSERT INTO semtbl_Type_Type VALUES(''e51633ca-e76f-4a3b-b4eb-95aace386755'',''351d4591-2495-4501-82ab-a425f5235db9'',''03d96017-6535-4cad-9327-e00a7d11761d'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''d0f58213-7db4-4882-bd15-962163015d13'' AND GUID_Type_Right=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	INSERT INTO semtbl_Type_Type VALUES(''d0f58213-7db4-4882-bd15-962163015d13'',''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''d84fa125-dbce-44b0-9153-9abeb66ad27f'' AND GUID_Type_Right=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	INSERT INTO semtbl_Type_Type VALUES(''d84fa125-dbce-44b0-9153-9abeb66ad27f'',''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_Type_Right=''1d9568af-b6da-4990-8f4d-907dfdd30749'' AND GUID_RelationType=''d513be0d-5832-445a-b9e4-0c5e85818a12'')=0
	INSERT INTO semtbl_Type_Type VALUES(''351d4591-2495-4501-82ab-a425f5235db9'',''1d9568af-b6da-4990-8f4d-907dfdd30749'',''d513be0d-5832-445a-b9e4-0c5e85818a12'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_Type_Right=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''351d4591-2495-4501-82ab-a425f5235db9'',''351d4591-2495-4501-82ab-a425f5235db9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_Type_Right=''c441518d-bfe0-4d55-b538-df5c5555dd83'' AND GUID_RelationType=''86be124e-55b0-463e-9ecc-7d1043a09c41'')=0
	INSERT INTO semtbl_Type_Type VALUES(''351d4591-2495-4501-82ab-a425f5235db9'',''c441518d-bfe0-4d55-b538-df5c5555dd83'',''86be124e-55b0-463e-9ecc-7d1043a09c41'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''60a12cc0-20b2-4c8a-b03b-a4b7c71864de'' AND GUID_Type_Right=''e51633ca-e76f-4a3b-b4eb-95aace386755'' AND GUID_RelationType=''1f30738c-746b-4806-be66-12fd45fb7be5'')=0
	INSERT INTO semtbl_Type_Type VALUES(''60a12cc0-20b2-4c8a-b03b-a4b7c71864de'',''e51633ca-e76f-4a3b-b4eb-95aace386755'',''1f30738c-746b-4806-be66-12fd45fb7be5'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''60a12cc0-20b2-4c8a-b03b-a4b7c71864de'' AND GUID_Type_Right=''e51633ca-e76f-4a3b-b4eb-95aace386755'' AND GUID_RelationType=''e3628af3-0aca-478b-a541-f77583c48f58'')=0
	INSERT INTO semtbl_Type_Type VALUES(''60a12cc0-20b2-4c8a-b03b-a4b7c71864de'',''e51633ca-e76f-4a3b-b4eb-95aace386755'',''e3628af3-0aca-478b-a541-f77583c48f58'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''ba76b764-1343-41d6-9973-ca181c4fabc8'' AND GUID_Type_Right=''6e31f905-20ce-4f8f-b401-6da5ba871ecb'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Type_Type VALUES(''ba76b764-1343-41d6-9973-ca181c4fabc8'',''6e31f905-20ce-4f8f-b401-6da5ba871ecb'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_Type_Right=''499ec20d-af6f-4e72-bf55-ffb6eac101bf'' AND GUID_RelationType=''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'')=0
	INSERT INTO semtbl_Type_Type VALUES(''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''499ec20d-af6f-4e72-bf55-ffb6eac101bf'',''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_Type_Right=''499ec20d-af6f-4e72-bf55-ffb6eac101bf'' AND GUID_RelationType=''d91da85b-793c-431c-9724-8ddc1ace170e'')=0
	INSERT INTO semtbl_Type_Type VALUES(''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''499ec20d-af6f-4e72-bf55-ffb6eac101bf'',''d91da85b-793c-431c-9724-8ddc1ace170e'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''460cb016-8fbb-47ae-91c8-cd9d8db5d8f4'' AND GUID_Type_Right=''e79ff4de-2e39-4101-b5a1-0055c40f41cd'' AND GUID_RelationType=''1700a8b9-5f32-44ec-8687-1c5ddb84e109'')=0
	INSERT INTO semtbl_Type_Type VALUES(''460cb016-8fbb-47ae-91c8-cd9d8db5d8f4'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'',''1700a8b9-5f32-44ec-8687-1c5ddb84e109'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''460cb016-8fbb-47ae-91c8-cd9d8db5d8f4'' AND GUID_Type_Right=''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'' AND GUID_RelationType=''9577533e-317f-4f6a-ae2d-d1a545092c68'')=0
	INSERT INTO semtbl_Type_Type VALUES(''460cb016-8fbb-47ae-91c8-cd9d8db5d8f4'',''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'',''9577533e-317f-4f6a-ae2d-d1a545092c68'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''460cb016-8fbb-47ae-91c8-cd9d8db5d8f4'' AND GUID_Type_Right=''094d728d-6efc-463c-85c7-2dcfed903c78'' AND GUID_RelationType=''faf118eb-6aab-4e47-89ae-320b7186b337'')=0
	INSERT INTO semtbl_Type_Type VALUES(''460cb016-8fbb-47ae-91c8-cd9d8db5d8f4'',''094d728d-6efc-463c-85c7-2dcfed903c78'',''faf118eb-6aab-4e47-89ae-320b7186b337'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''460cb016-8fbb-47ae-91c8-cd9d8db5d8f4'' AND GUID_Type_Right=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''460cb016-8fbb-47ae-91c8-cd9d8db5d8f4'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''6e31f905-20ce-4f8f-b401-6da5ba871ecb'' AND GUID_RelationType=''2461e5ba-cd55-4a52-9c18-ebab166eba22'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''6e31f905-20ce-4f8f-b401-6da5ba871ecb'',''2461e5ba-cd55-4a52-9c18-ebab166eba22'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''ba76b764-1343-41d6-9973-ca181c4fabc8'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''ba76b764-1343-41d6-9973-ca181c4fabc8'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c6c9bcb8-0ac9-4713-9417-eeec1453026c'' AND GUID_Type_Right=''13c09f11-175c-4eef-bc8a-0fd8e86d557f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c6c9bcb8-0ac9-4713-9417-eeec1453026c'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''e79ff4de-2e39-4101-b5a1-0055c40f41cd'' AND GUID_RelationType=''d91da85b-793c-431c-9724-8ddc1ace170e'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'',''d91da85b-793c-431c-9724-8ddc1ace170e'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''e79ff4de-2e39-4101-b5a1-0055c40f41cd'' AND GUID_RelationType=''dd5a24ec-e2bd-47c2-9761-d4a7db114aed'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'',''dd5a24ec-e2bd-47c2-9761-d4a7db114aed'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''1d9568af-b6da-4990-8f4d-907dfdd30749'' AND GUID_RelationType=''cf27679f-cbe7-4010-a3ae-472072762b33'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''1d9568af-b6da-4990-8f4d-907dfdd30749'',''cf27679f-cbe7-4010-a3ae-472072762b33'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_RelationType=''fb8a3635-9532-42ac-9889-9f116abe6c53'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''351d4591-2495-4501-82ab-a425f5235db9'',''fb8a3635-9532-42ac-9889-9f116abe6c53'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_RelationType=''fb90fea9-586d-4e7b-afd6-e5ccb009268a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''351d4591-2495-4501-82ab-a425f5235db9'',''fb90fea9-586d-4e7b-afd6-e5ccb009268a'',0,-1,-1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e62c2aa7-b5a5-4927-bd33-bf534bd57c8f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e62c2aa7-b5a5-4927-bd33-bf534bd57c8f'',''b8e5b73f-c84a-48f7-ad9e-48d1ad6c7d66'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''1cff98ca-b773-4bec-a511-59c704558965'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''1cff98ca-b773-4bec-a511-59c704558965'',''ea90b682-91fe-468d-8787-82dd86a2d7a8'',''68ac4472-ee22-4229-96ec-9753a016900a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''16c1b959-0a3f-43f1-9168-a33715c26737'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''16c1b959-0a3f-43f1-9168-a33715c26737'',''db1a6d4e-bb72-4f80-8c16-67d9081cbdc9'',''68ac4472-ee22-4229-96ec-9753a016900a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Varchar255 WHERE GUID_TokenAttribute=''e62c2aa7-b5a5-4927-bd33-bf534bd57c8f'' )=0
	INSERT INTO semtbl_Token_Attribute_Varchar255 VALUES(''e62c2aa7-b5a5-4927-bd33-bf534bd57c8f'',''mediaviewer_module'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_VarcharMax WHERE GUID_TokenAttribute=''1cff98ca-b773-4bec-a511-59c704558965'' )=0
	INSERT INTO semtbl_Token_Attribute_VarcharMax VALUES(''1cff98ca-b773-4bec-a511-59c704558965'',''<media src="@URL_MEDIASRC@"/>'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_VarcharMax WHERE GUID_TokenAttribute=''16c1b959-0a3f-43f1-9168-a33715c26737'' )=0
	INSERT INTO semtbl_Token_Attribute_VarcharMax VALUES(''16c1b959-0a3f-43f1-9168-a33715c26737'',''<?wpl version="1.0"?>
<smil>
    <head>
        <meta name="Generator" content="MediaViewer-Moduel"/>
        <meta name="ItemCount" content="@ITEMCOUNT@"/>
        <meta name="IsFavorite"/>
        <meta name="ContentPartnerListID"/>
        <meta name="ContentPartnerNameType"/>
        <meta name="ContentPartnerName"/>
        <meta name="Subtitle"/>
        <author/>
        <title>@title@</title>
    </head>
    <body>
        <seq>
	@MEDIASRC@
        </seq>
    </body>
</smil>
'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''daef0e76-a883-4ed1-8359-d54eee20d039'')=0
	INSERT INTO semtbl_OR VALUES(''daef0e76-a883-4ed1-8359-d54eee20d039'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6d57eeab-0eab-4a49-affd-c80a89322a43'')=0
	INSERT INTO semtbl_OR VALUES(''6d57eeab-0eab-4a49-affd-c80a89322a43'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''7cf6ec72-c50a-48cf-8986-bceb63c54661'')=0
	INSERT INTO semtbl_OR VALUES(''7cf6ec72-c50a-48cf-8986-bceb63c54661'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'')=0
	INSERT INTO semtbl_OR VALUES(''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''68918e5e-0236-46b6-9d38-5217d35e2767'')=0
	INSERT INTO semtbl_OR VALUES(''68918e5e-0236-46b6-9d38-5217d35e2767'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''87f18e5d-fa3f-4fcd-8c29-c08b4b707453'')=0
	INSERT INTO semtbl_OR VALUES(''87f18e5d-fa3f-4fcd-8c29-c08b4b707453'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''4aa13d1d-6564-4c06-8adc-8ab74f2dc3f2'')=0
	INSERT INTO semtbl_OR VALUES(''4aa13d1d-6564-4c06-8adc-8ab74f2dc3f2'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6d8ef372-f34b-4519-a146-56beb208f6eb'')=0
	INSERT INTO semtbl_OR VALUES(''6d8ef372-f34b-4519-a146-56beb208f6eb'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''bd385897-588d-44a2-8c57-cdd03fc25b5b'')=0
	INSERT INTO semtbl_OR VALUES(''bd385897-588d-44a2-8c57-cdd03fc25b5b'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''09d618b7-1eb9-4c8f-8e79-5421f3a1dc53'')=0
	INSERT INTO semtbl_OR VALUES(''09d618b7-1eb9-4c8f-8e79-5421f3a1dc53'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''447e55fc-491c-4550-8783-586ec943d47f'')=0
	INSERT INTO semtbl_OR VALUES(''447e55fc-491c-4550-8783-586ec943d47f'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''4b006fde-58bf-4e1c-a470-3392c157e48b'')=0
	INSERT INTO semtbl_OR VALUES(''4b006fde-58bf-4e1c-a470-3392c157e48b'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ac9879cd-5d7c-47c9-97d2-92e602c19c1f'')=0
	INSERT INTO semtbl_OR VALUES(''ac9879cd-5d7c-47c9-97d2-92e602c19c1f'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''71589523-ca58-4004-a5d8-fc1ef2518b6a'')=0
	INSERT INTO semtbl_OR VALUES(''71589523-ca58-4004-a5d8-fc1ef2518b6a'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''37c23725-5fde-4749-a7a5-9a885c0ab111'')=0
	INSERT INTO semtbl_OR VALUES(''37c23725-5fde-4749-a7a5-9a885c0ab111'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''06dd55ee-d40b-4b9f-a10a-6e11df80f63d'')=0
	INSERT INTO semtbl_OR VALUES(''06dd55ee-d40b-4b9f-a10a-6e11df80f63d'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''f93057d2-2303-401a-be15-f315944617b1'')=0
	INSERT INTO semtbl_OR VALUES(''f93057d2-2303-401a-be15-f315944617b1'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''98f5d1eb-3a56-4083-a51b-8fa68a184c09'')=0
	INSERT INTO semtbl_OR VALUES(''98f5d1eb-3a56-4083-a51b-8fa68a184c09'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b5a71e14-f203-4da9-b8e4-bd526ab5feba'')=0
	INSERT INTO semtbl_OR VALUES(''b5a71e14-f203-4da9-b8e4-bd526ab5feba'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6c93cbbb-1441-42d4-9a4e-e2e298495fab'')=0
	INSERT INTO semtbl_OR VALUES(''6c93cbbb-1441-42d4-9a4e-e2e298495fab'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e99915c7-bca5-4ed1-bf64-95fe71a4d003'')=0
	INSERT INTO semtbl_OR VALUES(''e99915c7-bca5-4ed1-bf64-95fe71a4d003'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6c3f2ea4-031d-4529-8086-d582b82ee951'')=0
	INSERT INTO semtbl_OR VALUES(''6c3f2ea4-031d-4529-8086-d582b82ee951'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''37e88b54-15a5-4d9a-94ea-fe1d3dc9cf57'')=0
	INSERT INTO semtbl_OR VALUES(''37e88b54-15a5-4d9a-94ea-fe1d3dc9cf57'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''0940f0f4-e730-44dc-903b-24bfc9c8e96e'')=0
	INSERT INTO semtbl_OR VALUES(''0940f0f4-e730-44dc-903b-24bfc9c8e96e'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''a50946ae-afc8-4f92-8fa5-5f6cbf41d324'')=0
	INSERT INTO semtbl_OR VALUES(''a50946ae-afc8-4f92-8fa5-5f6cbf41d324'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6ce516f2-c266-4057-8343-02a9e4c70694'')=0
	INSERT INTO semtbl_OR VALUES(''6ce516f2-c266-4057-8343-02a9e4c70694'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''62622351-d47d-48f8-bebf-e37519a157c7'')=0
	INSERT INTO semtbl_OR VALUES(''62622351-d47d-48f8-bebf-e37519a157c7'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''78a30307-835e-4178-8447-3a6d55399c3a'')=0
	INSERT INTO semtbl_OR VALUES(''78a30307-835e-4178-8447-3a6d55399c3a'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'')=0
	INSERT INTO semtbl_OR VALUES(''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''801e68e7-0ac7-41f8-bf09-4a816e900c83'')=0
	INSERT INTO semtbl_OR VALUES(''801e68e7-0ac7-41f8-bf09-4a816e900c83'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''797de54b-28a5-4bd7-bb9d-cd212f5cce66'')=0
	INSERT INTO semtbl_OR VALUES(''797de54b-28a5-4bd7-bb9d-cd212f5cce66'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''10d91761-4c3f-4172-b364-c66efe45941b'')=0
	INSERT INTO semtbl_OR VALUES(''10d91761-4c3f-4172-b364-c66efe45941b'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''920015c1-1cc6-4635-90eb-4d3239a1ee8d'')=0
	INSERT INTO semtbl_OR VALUES(''920015c1-1cc6-4635-90eb-4d3239a1ee8d'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''09117035-27ed-4626-a163-aceab1be2a0a'')=0
	INSERT INTO semtbl_OR VALUES(''09117035-27ed-4626-a163-aceab1be2a0a'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''47121a8b-e65a-4683-b101-9dc5cd1966ac'')=0
	INSERT INTO semtbl_OR VALUES(''47121a8b-e65a-4683-b101-9dc5cd1966ac'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''87cbbf56-b83b-471d-8813-f47b6e881174'')=0
	INSERT INTO semtbl_OR VALUES(''87cbbf56-b83b-471d-8813-f47b6e881174'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'')=0
	INSERT INTO semtbl_OR VALUES(''008817a6-14e7-4295-9a69-6835575ae53b'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'')=0
	INSERT INTO semtbl_OR VALUES(''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8765f75d-d6eb-420a-bcc0-f19e7f9f0ef9'')=0
	INSERT INTO semtbl_OR VALUES(''8765f75d-d6eb-420a-bcc0-f19e7f9f0ef9'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''f46a97cf-657c-4580-9f9a-7058783f469f'')=0
	INSERT INTO semtbl_OR VALUES(''f46a97cf-657c-4580-9f9a-7058783f469f'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''c1c4c936-b556-4114-b276-b3207c5a795e'')=0
	INSERT INTO semtbl_OR VALUES(''c1c4c936-b556-4114-b276-b3207c5a795e'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''781dc2dc-bace-47d8-8c51-46e506ddb85b'')=0
	INSERT INTO semtbl_OR VALUES(''781dc2dc-bace-47d8-8c51-46e506ddb85b'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ffcb7add-5fac-4df5-8da3-3b816562706d'')=0
	INSERT INTO semtbl_OR VALUES(''ffcb7add-5fac-4df5-8da3-3b816562706d'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''f635dcfe-4340-4e12-94db-29c66a6312fb'')=0
	INSERT INTO semtbl_OR VALUES(''f635dcfe-4340-4e12-94db-29c66a6312fb'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''f6c7c9bf-a3ef-409d-bb95-bd986efd35d9'')=0
	INSERT INTO semtbl_OR VALUES(''f6c7c9bf-a3ef-409d-bb95-bd986efd35d9'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''719a3287-3d80-4ecf-a844-f404f57c53c4'')=0
	INSERT INTO semtbl_OR VALUES(''719a3287-3d80-4ecf-a844-f404f57c53c4'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''07d78334-08f5-458a-b84a-b586f60700b9'')=0
	INSERT INTO semtbl_OR VALUES(''07d78334-08f5-458a-b84a-b586f60700b9'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''15f6c2a7-787c-4277-9730-17dea6d6f7c6'')=0
	INSERT INTO semtbl_OR VALUES(''15f6c2a7-787c-4277-9730-17dea6d6f7c6'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''47fb2885-07fe-43e9-b82f-38f387dd8a90'')=0
	INSERT INTO semtbl_OR VALUES(''47fb2885-07fe-43e9-b82f-38f387dd8a90'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d7bb7c7d-2536-40c6-b8bb-a87222ba9d9d'')=0
	INSERT INTO semtbl_OR VALUES(''d7bb7c7d-2536-40c6-b8bb-a87222ba9d9d'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''9e3ae462-2e41-4988-a188-955aa4a4fe16'')=0
	INSERT INTO semtbl_OR VALUES(''9e3ae462-2e41-4988-a188-955aa4a4fe16'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6348f4f1-5cf5-43f6-819e-fac1b94d3edc'')=0
	INSERT INTO semtbl_OR VALUES(''6348f4f1-5cf5-43f6-819e-fac1b94d3edc'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6d8fe254-868a-4cff-9cf2-8eedc4daedb3'')=0
	INSERT INTO semtbl_OR VALUES(''6d8fe254-868a-4cff-9cf2-8eedc4daedb3'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''70a596b6-9311-4cae-8a08-aad3398feef1'')=0
	INSERT INTO semtbl_OR VALUES(''70a596b6-9311-4cae-8a08-aad3398feef1'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''3d6866ea-1cbf-4874-b0c7-f0df274a399f'')=0
	INSERT INTO semtbl_OR VALUES(''3d6866ea-1cbf-4874-b0c7-f0df274a399f'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''3c456175-07c7-462a-bc1d-73c00c6e2661'')=0
	INSERT INTO semtbl_OR VALUES(''3c456175-07c7-462a-bc1d-73c00c6e2661'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''09a2ba9b-fa73-48ab-8fe4-f694d3365ef2'')=0
	INSERT INTO semtbl_OR VALUES(''09a2ba9b-fa73-48ab-8fe4-f694d3365ef2'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''5b7370d1-c850-4203-9265-eabc2bcd2021'')=0
	INSERT INTO semtbl_OR VALUES(''5b7370d1-c850-4203-9265-eabc2bcd2021'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e0e3b99f-59ed-4d81-8b53-83b925a18d31'')=0
	INSERT INTO semtbl_OR VALUES(''e0e3b99f-59ed-4d81-8b53-83b925a18d31'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'')=0
	INSERT INTO semtbl_OR VALUES(''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''f2f3ae8e-d891-47a9-a14a-56afeeee6e20'')=0
	INSERT INTO semtbl_OR VALUES(''f2f3ae8e-d891-47a9-a14a-56afeeee6e20'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''a3eefd82-7501-4d2a-b95b-0314be945223'')=0
	INSERT INTO semtbl_OR VALUES(''a3eefd82-7501-4d2a-b95b-0314be945223'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''c114a19f-3fed-41e4-a18b-e3705c2a42bc'')=0
	INSERT INTO semtbl_OR VALUES(''c114a19f-3fed-41e4-a18b-e3705c2a42bc'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'')=0
	INSERT INTO semtbl_OR VALUES(''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''87649bbb-7f48-4204-9b92-887d795f12d7'')=0
	INSERT INTO semtbl_OR VALUES(''87649bbb-7f48-4204-9b92-887d795f12d7'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''dc545b73-2319-4914-a798-126b9e4c6d4c'')=0
	INSERT INTO semtbl_OR VALUES(''dc545b73-2319-4914-a798-126b9e4c6d4c'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8429b97a-f6f1-4785-923e-cbf78d60b3cd'')=0
	INSERT INTO semtbl_OR VALUES(''8429b97a-f6f1-4785-923e-cbf78d60b3cd'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''f5255a9e-34a9-4982-bbf5-cb77d7f6937c'')=0
	INSERT INTO semtbl_OR VALUES(''f5255a9e-34a9-4982-bbf5-cb77d7f6937c'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''4251fed1-6f44-490a-9393-941af0af7fba'')=0
	INSERT INTO semtbl_OR VALUES(''4251fed1-6f44-490a-9393-941af0af7fba'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''3340f1ca-b31c-45ef-9263-8d6e1ebe4c2a'')=0
	INSERT INTO semtbl_OR VALUES(''3340f1ca-b31c-45ef-9263-8d6e1ebe4c2a'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b4032ce4-d3f5-4153-9f40-6222dc414bc5'')=0
	INSERT INTO semtbl_OR VALUES(''b4032ce4-d3f5-4153-9f40-6222dc414bc5'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''a2172ef6-37ac-4493-9ea5-d902bd03d623'')=0
	INSERT INTO semtbl_OR VALUES(''a2172ef6-37ac-4493-9ea5-d902bd03d623'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''c09ca6bf-b5fb-4121-b169-d389981a2ad4'')=0
	INSERT INTO semtbl_OR VALUES(''c09ca6bf-b5fb-4121-b169-d389981a2ad4'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''71669480-1af5-4bce-b5b8-6cf2541dd18c'')=0
	INSERT INTO semtbl_OR VALUES(''71669480-1af5-4bce-b5b8-6cf2541dd18c'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''4fdbc15a-7211-4dce-92af-40f3caf3916a'')=0
	INSERT INTO semtbl_OR VALUES(''4fdbc15a-7211-4dce-92af-40f3caf3916a'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''3e2f1b1a-b99a-4269-bcf2-47de2f20084b'')=0
	INSERT INTO semtbl_OR VALUES(''3e2f1b1a-b99a-4269-bcf2-47de2f20084b'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''c2d7ef23-f69c-4905-bf07-733a1d08cac1'')=0
	INSERT INTO semtbl_OR VALUES(''c2d7ef23-f69c-4905-bf07-733a1d08cac1'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''93b946ef-dce6-4de0-8ae1-9d45ed6f5457'')=0
	INSERT INTO semtbl_OR VALUES(''93b946ef-dce6-4de0-8ae1-9d45ed6f5457'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b49a69ce-7d5f-4c25-90f6-1db7e4402be9'')=0
	INSERT INTO semtbl_OR VALUES(''b49a69ce-7d5f-4c25-90f6-1db7e4402be9'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ecbf4898-09f4-4d14-ab48-c15966e92ff1'')=0
	INSERT INTO semtbl_OR VALUES(''ecbf4898-09f4-4d14-ab48-c15966e92ff1'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''a8abe90f-6ac3-42e4-a3a7-4144e836f8a6'')=0
	INSERT INTO semtbl_OR VALUES(''a8abe90f-6ac3-42e4-a3a7-4144e836f8a6'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e350da57-ca79-4c4c-8764-06ab442cb3a0'')=0
	INSERT INTO semtbl_OR VALUES(''e350da57-ca79-4c4c-8764-06ab442cb3a0'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''c0cdddc5-3a1d-48a2-881a-967a8e44f6a6'')=0
	INSERT INTO semtbl_OR VALUES(''c0cdddc5-3a1d-48a2-881a-967a8e44f6a6'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''19fda1b9-1a35-4bd7-8f9d-166d44a1334b'')=0
	INSERT INTO semtbl_OR VALUES(''19fda1b9-1a35-4bd7-8f9d-166d44a1334b'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''9e93042e-fd3f-4fa5-bf5f-d14e659be359'')=0
	INSERT INTO semtbl_OR VALUES(''9e93042e-fd3f-4fa5-bf5f-d14e659be359'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''fc30c0af-0d33-4cce-9624-7ee679945959'')=0
	INSERT INTO semtbl_OR VALUES(''fc30c0af-0d33-4cce-9624-7ee679945959'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e35ae637-4933-4aa7-9e92-f377a4b5c0ef'')=0
	INSERT INTO semtbl_OR VALUES(''e35ae637-4933-4aa7-9e92-f377a4b5c0ef'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''fedeccdf-0a8e-433e-a972-344dfb44e57f'')=0
	INSERT INTO semtbl_OR VALUES(''fedeccdf-0a8e-433e-a972-344dfb44e57f'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''7d1dac48-aecd-44d7-bbad-e0f964050a98'')=0
	INSERT INTO semtbl_OR VALUES(''7d1dac48-aecd-44d7-bbad-e0f964050a98'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''17266d34-3ac7-4acb-9426-72d65e299b12'')=0
	INSERT INTO semtbl_OR VALUES(''17266d34-3ac7-4acb-9426-72d65e299b12'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''6d57eeab-0eab-4a49-affd-c80a89322a43'')=0
	INSERT INTO semtbl_OR_Type VALUES(''6d57eeab-0eab-4a49-affd-c80a89322a43'',''83f136c4-cb76-4029-88ab-5ab8f10c1532'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'')=0
	INSERT INTO semtbl_OR_Type VALUES(''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''6d8ef372-f34b-4519-a146-56beb208f6eb'')=0
	INSERT INTO semtbl_OR_Type VALUES(''6d8ef372-f34b-4519-a146-56beb208f6eb'',''d84fa125-dbce-44b0-9153-9abeb66ad27f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''09d618b7-1eb9-4c8f-8e79-5421f3a1dc53'')=0
	INSERT INTO semtbl_OR_Type VALUES(''09d618b7-1eb9-4c8f-8e79-5421f3a1dc53'',''9428c7d3-7065-443e-ab0c-5086353f2e9a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''ac9879cd-5d7c-47c9-97d2-92e602c19c1f'')=0
	INSERT INTO semtbl_OR_Type VALUES(''ac9879cd-5d7c-47c9-97d2-92e602c19c1f'',''055c60b0-b807-46c1-a2cc-7b9dcf2c568a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''71589523-ca58-4004-a5d8-fc1ef2518b6a'')=0
	INSERT INTO semtbl_OR_Type VALUES(''71589523-ca58-4004-a5d8-fc1ef2518b6a'',''759bb22d-20b5-42ff-8079-813c2496946d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''06dd55ee-d40b-4b9f-a10a-6e11df80f63d'')=0
	INSERT INTO semtbl_OR_Type VALUES(''06dd55ee-d40b-4b9f-a10a-6e11df80f63d'',''60a12cc0-20b2-4c8a-b03b-a4b7c71864de'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''f93057d2-2303-401a-be15-f315944617b1'')=0
	INSERT INTO semtbl_OR_Type VALUES(''f93057d2-2303-401a-be15-f315944617b1'',''ba76b764-1343-41d6-9973-ca181c4fabc8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''37e88b54-15a5-4d9a-94ea-fe1d3dc9cf57'')=0
	INSERT INTO semtbl_OR_Type VALUES(''37e88b54-15a5-4d9a-94ea-fe1d3dc9cf57'',''04d7e938-a51d-4a49-b14b-03b0f8a6eeb1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''801e68e7-0ac7-41f8-bf09-4a816e900c83'')=0
	INSERT INTO semtbl_OR_Type VALUES(''801e68e7-0ac7-41f8-bf09-4a816e900c83'',''5325e946-86c1-4254-b463-c7538d39caa3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''797de54b-28a5-4bd7-bb9d-cd212f5cce66'')=0
	INSERT INTO semtbl_OR_Type VALUES(''797de54b-28a5-4bd7-bb9d-cd212f5cce66'',''f62cf1cc-ee51-475f-9c00-7094f1809b56'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''87cbbf56-b83b-471d-8813-f47b6e881174'')=0
	INSERT INTO semtbl_OR_Type VALUES(''87cbbf56-b83b-471d-8813-f47b6e881174'',''c1e3cfc9-8a22-4e83-bc8c-869319e408a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''8765f75d-d6eb-420a-bcc0-f19e7f9f0ef9'')=0
	INSERT INTO semtbl_OR_Type VALUES(''8765f75d-d6eb-420a-bcc0-f19e7f9f0ef9'',''3f7f258e-76b2-49ae-b5cc-25184f39899f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''f46a97cf-657c-4580-9f9a-7058783f469f'')=0
	INSERT INTO semtbl_OR_Type VALUES(''f46a97cf-657c-4580-9f9a-7058783f469f'',''c466c537-2c35-4379-b711-cc6b6b183b3f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''781dc2dc-bace-47d8-8c51-46e506ddb85b'')=0
	INSERT INTO semtbl_OR_Type VALUES(''781dc2dc-bace-47d8-8c51-46e506ddb85b'',''95029348-dd27-47cd-bf36-cd68739673b8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''6348f4f1-5cf5-43f6-819e-fac1b94d3edc'')=0
	INSERT INTO semtbl_OR_Type VALUES(''6348f4f1-5cf5-43f6-819e-fac1b94d3edc'',''f1ae4aa2-1a92-4df1-ad63-cd4663dd26f1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''3d6866ea-1cbf-4874-b0c7-f0df274a399f'')=0
	INSERT INTO semtbl_OR_Type VALUES(''3d6866ea-1cbf-4874-b0c7-f0df274a399f'',''d0f58213-7db4-4882-bd15-962163015d13'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''3c456175-07c7-462a-bc1d-73c00c6e2661'')=0
	INSERT INTO semtbl_OR_Type VALUES(''3c456175-07c7-462a-bc1d-73c00c6e2661'',''0e228554-4c7e-48e0-ba03-2de51394be4a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''5b7370d1-c850-4203-9265-eabc2bcd2021'')=0
	INSERT INTO semtbl_OR_Type VALUES(''5b7370d1-c850-4203-9265-eabc2bcd2021'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''e0e3b99f-59ed-4d81-8b53-83b925a18d31'')=0
	INSERT INTO semtbl_OR_Type VALUES(''e0e3b99f-59ed-4d81-8b53-83b925a18d31'',''7cf91a43-acdf-4624-8d1e-e6f9cdf10f89'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''a3eefd82-7501-4d2a-b95b-0314be945223'')=0
	INSERT INTO semtbl_OR_Type VALUES(''a3eefd82-7501-4d2a-b95b-0314be945223'',''094d728d-6efc-463c-85c7-2dcfed903c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'')=0
	INSERT INTO semtbl_OR_Type VALUES(''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''87649bbb-7f48-4204-9b92-887d795f12d7'')=0
	INSERT INTO semtbl_OR_Type VALUES(''87649bbb-7f48-4204-9b92-887d795f12d7'',''33cb21b4-58a7-4f56-b036-5d89bbc20993'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''dc545b73-2319-4914-a798-126b9e4c6d4c'')=0
	INSERT INTO semtbl_OR_Type VALUES(''dc545b73-2319-4914-a798-126b9e4c6d4c'',''499ec20d-af6f-4e72-bf55-ffb6eac101bf'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''8429b97a-f6f1-4785-923e-cbf78d60b3cd'')=0
	INSERT INTO semtbl_OR_Type VALUES(''8429b97a-f6f1-4785-923e-cbf78d60b3cd'',''402a7ca0-215e-47c8-9dfe-8cf1283dccc0'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''f5255a9e-34a9-4982-bbf5-cb77d7f6937c'')=0
	INSERT INTO semtbl_OR_Type VALUES(''f5255a9e-34a9-4982-bbf5-cb77d7f6937c'',''460cb016-8fbb-47ae-91c8-cd9d8db5d8f4'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''71669480-1af5-4bce-b5b8-6cf2541dd18c'')=0
	INSERT INTO semtbl_OR_Type VALUES(''71669480-1af5-4bce-b5b8-6cf2541dd18c'',''a751ce27-5609-4c3a-9b6a-b685ea646d10'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''4fdbc15a-7211-4dce-92af-40f3caf3916a'')=0
	INSERT INTO semtbl_OR_Type VALUES(''4fdbc15a-7211-4dce-92af-40f3caf3916a'',''c441518d-bfe0-4d55-b538-df5c5555dd83'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''c2d7ef23-f69c-4905-bf07-733a1d08cac1'')=0
	INSERT INTO semtbl_OR_Type VALUES(''c2d7ef23-f69c-4905-bf07-733a1d08cac1'',''c0bb945e-d91e-42a9-ba59-50fe054b2fa0'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''ecbf4898-09f4-4d14-ab48-c15966e92ff1'')=0
	INSERT INTO semtbl_OR_Type VALUES(''ecbf4898-09f4-4d14-ab48-c15966e92ff1'',''351d4591-2495-4501-82ab-a425f5235db9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''a8abe90f-6ac3-42e4-a3a7-4144e836f8a6'')=0
	INSERT INTO semtbl_OR_Type VALUES(''a8abe90f-6ac3-42e4-a3a7-4144e836f8a6'',''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''19fda1b9-1a35-4bd7-8f9d-166d44a1334b'')=0
	INSERT INTO semtbl_OR_Type VALUES(''19fda1b9-1a35-4bd7-8f9d-166d44a1334b'',''e51633ca-e76f-4a3b-b4eb-95aace386755'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''9e93042e-fd3f-4fa5-bf5f-d14e659be359'')=0
	INSERT INTO semtbl_OR_Type VALUES(''9e93042e-fd3f-4fa5-bf5f-d14e659be359'',''7886d705-2b02-4ddc-bf6e-f35f3e58e19f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''fc30c0af-0d33-4cce-9624-7ee679945959'')=0
	INSERT INTO semtbl_OR_Type VALUES(''fc30c0af-0d33-4cce-9624-7ee679945959'',''aa000e0c-5415-4be9-bf6a-0bb43fc53bcf'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''447e55fc-491c-4550-8783-586ec943d47f'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''447e55fc-491c-4550-8783-586ec943d47f'',''006b6f41-26a0-4d7b-b0d6-d2cf4dba3ff8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''b5a71e14-f203-4da9-b8e4-bd526ab5feba'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''b5a71e14-f203-4da9-b8e4-bd526ab5feba'',''68ac4472-ee22-4229-96ec-9753a016900a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''6c3f2ea4-031d-4529-8086-d582b82ee951'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''6c3f2ea4-031d-4529-8086-d582b82ee951'',''0b183be9-c13d-4157-989b-63b0362aeee6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''0940f0f4-e730-44dc-903b-24bfc9c8e96e'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''0940f0f4-e730-44dc-903b-24bfc9c8e96e'',''e93b6ef9-7e8c-4215-affa-2bb239d0ea45'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''6ce516f2-c266-4057-8343-02a9e4c70694'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''6ce516f2-c266-4057-8343-02a9e4c70694'',''6092162a-d4cb-4655-8753-e18a662fb28f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''ffcb7add-5fac-4df5-8da3-3b816562706d'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''ffcb7add-5fac-4df5-8da3-3b816562706d'',''37347dbd-5b2c-45a4-b091-610d022566aa'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''47fb2885-07fe-43e9-b82f-38f387dd8a90'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''47fb2885-07fe-43e9-b82f-38f387dd8a90'',''30a83dbb-ceef-416e-8060-9a58d93d6636'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''d7bb7c7d-2536-40c6-b8bb-a87222ba9d9d'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''d7bb7c7d-2536-40c6-b8bb-a87222ba9d9d'',''2e5fd016-c574-4924-b724-d1b30640243a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''68918e5e-0236-46b6-9d38-5217d35e2767'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''68918e5e-0236-46b6-9d38-5217d35e2767'',''faf118eb-6aab-4e47-89ae-320b7186b337'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''87f18e5d-fa3f-4fcd-8c29-c08b4b707453'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''87f18e5d-fa3f-4fcd-8c29-c08b4b707453'',''3ffa80d4-7d6e-4025-be19-31abf3ba7c12'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''4b006fde-58bf-4e1c-a470-3392c157e48b'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''4b006fde-58bf-4e1c-a470-3392c157e48b'',''03d96017-6535-4cad-9327-e00a7d11761d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''98f5d1eb-3a56-4083-a51b-8fa68a184c09'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''98f5d1eb-3a56-4083-a51b-8fa68a184c09'',''3e104b75-e01c-48a0-b041-12908fd446a0'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''6c93cbbb-1441-42d4-9a4e-e2e298495fab'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''6c93cbbb-1441-42d4-9a4e-e2e298495fab'',''1f063a79-ddde-44c5-95ba-50391fe6f0e3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''78a30307-835e-4178-8447-3a6d55399c3a'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''78a30307-835e-4178-8447-3a6d55399c3a'',''3371228a-5d2b-4357-8050-0159d1262007'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''e9711603-47db-44d8-a476-fe88290639a4'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''47121a8b-e65a-4683-b101-9dc5cd1966ac'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''47121a8b-e65a-4683-b101-9dc5cd1966ac'',''1700a8b9-5f32-44ec-8687-1c5ddb84e109'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''008817a6-14e7-4295-9a69-6835575ae53b'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''c1c4c936-b556-4114-b276-b3207c5a795e'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''c1c4c936-b556-4114-b276-b3207c5a795e'',''62fc3781-8c1f-47fd-af1e-f0ebf96beefb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''719a3287-3d80-4ecf-a844-f404f57c53c4'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''719a3287-3d80-4ecf-a844-f404f57c53c4'',''ec06ec43-f52c-463b-8ca4-67ca12124da9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''07d78334-08f5-458a-b84a-b586f60700b9'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''07d78334-08f5-458a-b84a-b586f60700b9'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''e07469d9-766c-443e-8526-6d9c684f944f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''f2f3ae8e-d891-47a9-a14a-56afeeee6e20'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''f2f3ae8e-d891-47a9-a14a-56afeeee6e20'',''25ed2608-4b28-464e-8ae8-05f708e3986f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''c09ca6bf-b5fb-4121-b169-d389981a2ad4'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''c09ca6bf-b5fb-4121-b169-d389981a2ad4'',''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''3e2f1b1a-b99a-4269-bcf2-47de2f20084b'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''3e2f1b1a-b99a-4269-bcf2-47de2f20084b'',''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''e350da57-ca79-4c4c-8764-06ab442cb3a0'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''e350da57-ca79-4c4c-8764-06ab442cb3a0'',''86be124e-55b0-463e-9ecc-7d1043a09c41'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''e35ae637-4933-4aa7-9e92-f377a4b5c0ef'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''e35ae637-4933-4aa7-9e92-f377a4b5c0ef'',''9577533e-317f-4f6a-ae2d-d1a545092c68'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''7d1dac48-aecd-44d7-bbad-e0f964050a98'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''7d1dac48-aecd-44d7-bbad-e0f964050a98'',''e3628af3-0aca-478b-a541-f77583c48f58'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''17266d34-3ac7-4acb-9426-72d65e299b12'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''17266d34-3ac7-4acb-9426-72d65e299b12'',''1f30738c-746b-4806-be66-12fd45fb7be5'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''daef0e76-a883-4ed1-8359-d54eee20d039'')=0
	INSERT INTO semtbl_OR_Token VALUES(''daef0e76-a883-4ed1-8359-d54eee20d039'',''414061f9-bd6d-476f-b513-5762c0000c8c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''7cf6ec72-c50a-48cf-8986-bceb63c54661'')=0
	INSERT INTO semtbl_OR_Token VALUES(''7cf6ec72-c50a-48cf-8986-bceb63c54661'',''02d6213b-bc26-4afa-af20-9711a3872c33'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''4aa13d1d-6564-4c06-8adc-8ab74f2dc3f2'')=0
	INSERT INTO semtbl_OR_Token VALUES(''4aa13d1d-6564-4c06-8adc-8ab74f2dc3f2'',''a741817e-054b-47f1-a2b5-4324e261c8be'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''bd385897-588d-44a2-8c57-cdd03fc25b5b'')=0
	INSERT INTO semtbl_OR_Token VALUES(''bd385897-588d-44a2-8c57-cdd03fc25b5b'',''ea90b682-91fe-468d-8787-82dd86a2d7a8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''37c23725-5fde-4749-a7a5-9a885c0ab111'')=0
	INSERT INTO semtbl_OR_Token VALUES(''37c23725-5fde-4749-a7a5-9a885c0ab111'',''8b25dedf-eb59-4b0c-a033-8cb006af7ee2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''e99915c7-bca5-4ed1-bf64-95fe71a4d003'')=0
	INSERT INTO semtbl_OR_Token VALUES(''e99915c7-bca5-4ed1-bf64-95fe71a4d003'',''bd8030e7-038e-4ce8-8ae8-38e034bf960d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''a50946ae-afc8-4f92-8fa5-5f6cbf41d324'')=0
	INSERT INTO semtbl_OR_Token VALUES(''a50946ae-afc8-4f92-8fa5-5f6cbf41d324'',''db1a6d4e-bb72-4f80-8c16-67d9081cbdc9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''62622351-d47d-48f8-bebf-e37519a157c7'')=0
	INSERT INTO semtbl_OR_Token VALUES(''62622351-d47d-48f8-bebf-e37519a157c7'',''bdb17d4e-37d0-498e-b817-48937925c047'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''10d91761-4c3f-4172-b364-c66efe45941b'')=0
	INSERT INTO semtbl_OR_Token VALUES(''10d91761-4c3f-4172-b364-c66efe45941b'',''4fa6bfbc-b99e-4586-8963-868d6fe48a27'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''920015c1-1cc6-4635-90eb-4d3239a1ee8d'')=0
	INSERT INTO semtbl_OR_Token VALUES(''920015c1-1cc6-4635-90eb-4d3239a1ee8d'',''f3a48068-25c9-48d6-8fe2-3ffcca4ab67d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''09117035-27ed-4626-a163-aceab1be2a0a'')=0
	INSERT INTO semtbl_OR_Token VALUES(''09117035-27ed-4626-a163-aceab1be2a0a'',''448e90c7-19e8-40a2-a834-8a13d918880c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''f635dcfe-4340-4e12-94db-29c66a6312fb'')=0
	INSERT INTO semtbl_OR_Token VALUES(''f635dcfe-4340-4e12-94db-29c66a6312fb'',''9c127bc9-640a-4159-b88b-cb04ae9eb8ba'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''f6c7c9bf-a3ef-409d-bb95-bd986efd35d9'')=0
	INSERT INTO semtbl_OR_Token VALUES(''f6c7c9bf-a3ef-409d-bb95-bd986efd35d9'',''8eb37136-7997-48e2-9b39-841cb827b29e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''15f6c2a7-787c-4277-9730-17dea6d6f7c6'')=0
	INSERT INTO semtbl_OR_Token VALUES(''15f6c2a7-787c-4277-9730-17dea6d6f7c6'',''09ad9ee2-6845-42cc-9b02-d74e1aef0ac5'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''9e3ae462-2e41-4988-a188-955aa4a4fe16'')=0
	INSERT INTO semtbl_OR_Token VALUES(''9e3ae462-2e41-4988-a188-955aa4a4fe16'',''438e52d1-8501-4a3f-86c3-a626e197c76f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''6d8fe254-868a-4cff-9cf2-8eedc4daedb3'')=0
	INSERT INTO semtbl_OR_Token VALUES(''6d8fe254-868a-4cff-9cf2-8eedc4daedb3'',''a3cc47e1-9624-4d62-b7d3-9d732c1d27a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''70a596b6-9311-4cae-8a08-aad3398feef1'')=0
	INSERT INTO semtbl_OR_Token VALUES(''70a596b6-9311-4cae-8a08-aad3398feef1'',''ee821a89-db55-47ba-85b8-3c4049ba8143'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''09a2ba9b-fa73-48ab-8fe4-f694d3365ef2'')=0
	INSERT INTO semtbl_OR_Token VALUES(''09a2ba9b-fa73-48ab-8fe4-f694d3365ef2'',''00bb92bb-ea89-4838-8964-6a1a4c34d902'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''c114a19f-3fed-41e4-a18b-e3705c2a42bc'')=0
	INSERT INTO semtbl_OR_Token VALUES(''c114a19f-3fed-41e4-a18b-e3705c2a42bc'',''3dfc2a38-8ea7-4864-8d9c-3f811fb1f16a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''4251fed1-6f44-490a-9393-941af0af7fba'')=0
	INSERT INTO semtbl_OR_Token VALUES(''4251fed1-6f44-490a-9393-941af0af7fba'',''f134e9d2-db45-4523-b270-26184f36a1de'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''3340f1ca-b31c-45ef-9263-8d6e1ebe4c2a'')=0
	INSERT INTO semtbl_OR_Token VALUES(''3340f1ca-b31c-45ef-9263-8d6e1ebe4c2a'',''a9a13d03-2070-44a0-b1d3-32cae06460c3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''b4032ce4-d3f5-4153-9f40-6222dc414bc5'')=0
	INSERT INTO semtbl_OR_Token VALUES(''b4032ce4-d3f5-4153-9f40-6222dc414bc5'',''af4e1fac-fd8c-49d5-ab6c-d4c8537dbcc1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''a2172ef6-37ac-4493-9ea5-d902bd03d623'')=0
	INSERT INTO semtbl_OR_Token VALUES(''a2172ef6-37ac-4493-9ea5-d902bd03d623'',''5895fa84-0476-487c-b5df-c7a7485c63d2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''93b946ef-dce6-4de0-8ae1-9d45ed6f5457'')=0
	INSERT INTO semtbl_OR_Token VALUES(''93b946ef-dce6-4de0-8ae1-9d45ed6f5457'',''a030d27f-d920-4a87-a513-faaf4ccd2af7'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''b49a69ce-7d5f-4c25-90f6-1db7e4402be9'')=0
	INSERT INTO semtbl_OR_Token VALUES(''b49a69ce-7d5f-4c25-90f6-1db7e4402be9'',''8bfa64a0-7bfe-4ecc-ab35-3c2592664157'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''c0cdddc5-3a1d-48a2-881a-967a8e44f6a6'')=0
	INSERT INTO semtbl_OR_Token VALUES(''c0cdddc5-3a1d-48a2-881a-967a8e44f6a6'',''9775ef77-f511-41fa-93e4-5ede1ea379ba'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''fedeccdf-0a8e-433e-a972-344dfb44e57f'')=0
	INSERT INTO semtbl_OR_Token VALUES(''fedeccdf-0a8e-433e-a972-344dfb44e57f'',''eabea67d-a6c4-41e3-998d-3e79aa87c116'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f0becf55-4a6e-431c-b655-006503f59b47'' AND GUID_ObjectReference=''daef0e76-a883-4ed1-8359-d54eee20d039'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f0becf55-4a6e-431c-b655-006503f59b47'',''daef0e76-a883-4ed1-8359-d54eee20d039'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''fb9503c0-b884-434e-af8a-0066c7a6c40f'' AND GUID_ObjectReference=''6d57eeab-0eab-4a49-affd-c80a89322a43'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''fb9503c0-b884-434e-af8a-0066c7a6c40f'',''6d57eeab-0eab-4a49-affd-c80a89322a43'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''bd160ac5-040a-410f-88f6-04d3659370e8'' AND GUID_ObjectReference=''7cf6ec72-c50a-48cf-8986-bceb63c54661'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''bd160ac5-040a-410f-88f6-04d3659370e8'',''7cf6ec72-c50a-48cf-8986-bceb63c54661'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'' AND GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ab95f5bb-5de1-42b0-9d4c-13d076ca3554'' AND GUID_ObjectReference=''68918e5e-0236-46b6-9d38-5217d35e2767'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ab95f5bb-5de1-42b0-9d4c-13d076ca3554'',''68918e5e-0236-46b6-9d38-5217d35e2767'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''89a8ce8f-d745-4d78-b82a-14306084cfc1'' AND GUID_ObjectReference=''87f18e5d-fa3f-4fcd-8c29-c08b4b707453'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''89a8ce8f-d745-4d78-b82a-14306084cfc1'',''87f18e5d-fa3f-4fcd-8c29-c08b4b707453'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e311bbb5-4f2f-4757-b6f2-17b0849ce722'' AND GUID_ObjectReference=''4aa13d1d-6564-4c06-8adc-8ab74f2dc3f2'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e311bbb5-4f2f-4757-b6f2-17b0849ce722'',''4aa13d1d-6564-4c06-8adc-8ab74f2dc3f2'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b53826c1-bddc-4fc2-a922-180c32ea7207'' AND GUID_ObjectReference=''6d8ef372-f34b-4519-a146-56beb208f6eb'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b53826c1-bddc-4fc2-a922-180c32ea7207'',''6d8ef372-f34b-4519-a146-56beb208f6eb'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''73c0acf6-36ff-4c63-a190-191fa3a8644b'' AND GUID_ObjectReference=''bd385897-588d-44a2-8c57-cdd03fc25b5b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''73c0acf6-36ff-4c63-a190-191fa3a8644b'',''bd385897-588d-44a2-8c57-cdd03fc25b5b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''c1df5546-3c90-4160-9924-1b6e5cee7920'' AND GUID_ObjectReference=''09d618b7-1eb9-4c8f-8e79-5421f3a1dc53'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''c1df5546-3c90-4160-9924-1b6e5cee7920'',''09d618b7-1eb9-4c8f-8e79-5421f3a1dc53'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''98fbd3cc-40ac-4a19-b0f8-1f9e8efaff91'' AND GUID_ObjectReference=''447e55fc-491c-4550-8783-586ec943d47f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''98fbd3cc-40ac-4a19-b0f8-1f9e8efaff91'',''447e55fc-491c-4550-8783-586ec943d47f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''14f006b5-b225-4899-a0ac-2075f3ed3280'' AND GUID_ObjectReference=''4b006fde-58bf-4e1c-a470-3392c157e48b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''14f006b5-b225-4899-a0ac-2075f3ed3280'',''4b006fde-58bf-4e1c-a470-3392c157e48b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''dc9ebe84-dd16-4f9c-bd77-294920c9387d'' AND GUID_ObjectReference=''ac9879cd-5d7c-47c9-97d2-92e602c19c1f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''dc9ebe84-dd16-4f9c-bd77-294920c9387d'',''ac9879cd-5d7c-47c9-97d2-92e602c19c1f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''375c73ad-9a93-4775-a2ba-2fb097efb6ba'' AND GUID_ObjectReference=''71589523-ca58-4004-a5d8-fc1ef2518b6a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''375c73ad-9a93-4775-a2ba-2fb097efb6ba'',''71589523-ca58-4004-a5d8-fc1ef2518b6a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''708a17aa-c475-4f08-a8d7-32a20269ca8a'' AND GUID_ObjectReference=''37c23725-5fde-4749-a7a5-9a885c0ab111'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''708a17aa-c475-4f08-a8d7-32a20269ca8a'',''37c23725-5fde-4749-a7a5-9a885c0ab111'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''cd5df308-8f49-4bb1-8d5d-33ed4279b850'' AND GUID_ObjectReference=''06dd55ee-d40b-4b9f-a10a-6e11df80f63d'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''cd5df308-8f49-4bb1-8d5d-33ed4279b850'',''06dd55ee-d40b-4b9f-a10a-6e11df80f63d'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''26c6954f-c062-423b-b598-34147b3013fd'' AND GUID_ObjectReference=''f93057d2-2303-401a-be15-f315944617b1'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''26c6954f-c062-423b-b598-34147b3013fd'',''f93057d2-2303-401a-be15-f315944617b1'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''747952da-2e66-49c1-8462-3a20addbc0ef'' AND GUID_ObjectReference=''98f5d1eb-3a56-4083-a51b-8fa68a184c09'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''747952da-2e66-49c1-8462-3a20addbc0ef'',''98f5d1eb-3a56-4083-a51b-8fa68a184c09'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'' AND GUID_ObjectReference=''b5a71e14-f203-4da9-b8e4-bd526ab5feba'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'',''b5a71e14-f203-4da9-b8e4-bd526ab5feba'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''25c4a23b-baa0-4a4d-9b4f-40b354d3fac4'' AND GUID_ObjectReference=''6c93cbbb-1441-42d4-9a4e-e2e298495fab'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''25c4a23b-baa0-4a4d-9b4f-40b354d3fac4'',''6c93cbbb-1441-42d4-9a4e-e2e298495fab'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d0891239-7599-4e1b-9987-4830333ab06c'' AND GUID_ObjectReference=''e99915c7-bca5-4ed1-bf64-95fe71a4d003'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d0891239-7599-4e1b-9987-4830333ab06c'',''e99915c7-bca5-4ed1-bf64-95fe71a4d003'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''60dac2f0-947c-47cd-9933-4a4e69681176'' AND GUID_ObjectReference=''6c3f2ea4-031d-4529-8086-d582b82ee951'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''60dac2f0-947c-47cd-9933-4a4e69681176'',''6c3f2ea4-031d-4529-8086-d582b82ee951'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''00a54315-adbd-4073-a92e-4dc7cd9149d0'' AND GUID_ObjectReference=''37e88b54-15a5-4d9a-94ea-fe1d3dc9cf57'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''00a54315-adbd-4073-a92e-4dc7cd9149d0'',''37e88b54-15a5-4d9a-94ea-fe1d3dc9cf57'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''7de69c8a-375c-43d9-b8db-4f5746c949e1'' AND GUID_ObjectReference=''0940f0f4-e730-44dc-903b-24bfc9c8e96e'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''7de69c8a-375c-43d9-b8db-4f5746c949e1'',''0940f0f4-e730-44dc-903b-24bfc9c8e96e'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3749880b-154c-4197-ab8d-533a8b36f690'' AND GUID_ObjectReference=''a50946ae-afc8-4f92-8fa5-5f6cbf41d324'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3749880b-154c-4197-ab8d-533a8b36f690'',''a50946ae-afc8-4f92-8fa5-5f6cbf41d324'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d72ffddd-bd17-4fa3-b856-549af23b2273'' AND GUID_ObjectReference=''6ce516f2-c266-4057-8343-02a9e4c70694'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d72ffddd-bd17-4fa3-b856-549af23b2273'',''6ce516f2-c266-4057-8343-02a9e4c70694'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''022a6b7a-02c8-4433-8764-5c21c5205ac1'' AND GUID_ObjectReference=''62622351-d47d-48f8-bebf-e37519a157c7'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''022a6b7a-02c8-4433-8764-5c21c5205ac1'',''62622351-d47d-48f8-bebf-e37519a157c7'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''890a4d05-9c9f-47a0-b809-60c0676064be'' AND GUID_ObjectReference=''78a30307-835e-4178-8447-3a6d55399c3a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''890a4d05-9c9f-47a0-b809-60c0676064be'',''78a30307-835e-4178-8447-3a6d55399c3a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6c966e3c-c737-4af1-9970-68c8323679bc'' AND GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6c966e3c-c737-4af1-9970-68c8323679bc'',''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''45206556-4bf3-4d9c-9b1a-6a123f970878'' AND GUID_ObjectReference=''801e68e7-0ac7-41f8-bf09-4a816e900c83'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''45206556-4bf3-4d9c-9b1a-6a123f970878'',''801e68e7-0ac7-41f8-bf09-4a816e900c83'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''565ccbae-718f-4b3d-bd06-6a1906653220'' AND GUID_ObjectReference=''797de54b-28a5-4bd7-bb9d-cd212f5cce66'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''565ccbae-718f-4b3d-bd06-6a1906653220'',''797de54b-28a5-4bd7-bb9d-cd212f5cce66'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''1f5c49ef-bee4-4fbc-a009-6aa4ac85cd40'' AND GUID_ObjectReference=''10d91761-4c3f-4172-b364-c66efe45941b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''1f5c49ef-bee4-4fbc-a009-6aa4ac85cd40'',''10d91761-4c3f-4172-b364-c66efe45941b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3111af84-bd07-4635-80de-6c666b8c95eb'' AND GUID_ObjectReference=''920015c1-1cc6-4635-90eb-4d3239a1ee8d'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3111af84-bd07-4635-80de-6c666b8c95eb'',''920015c1-1cc6-4635-90eb-4d3239a1ee8d'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''00029a7e-0e7f-4f0a-b818-6ce8c9a517d3'' AND GUID_ObjectReference=''09117035-27ed-4626-a163-aceab1be2a0a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''00029a7e-0e7f-4f0a-b818-6ce8c9a517d3'',''09117035-27ed-4626-a163-aceab1be2a0a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''15820ab1-0945-4e72-9792-6dd480e73954'' AND GUID_ObjectReference=''47121a8b-e65a-4683-b101-9dc5cd1966ac'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''15820ab1-0945-4e72-9792-6dd480e73954'',''47121a8b-e65a-4683-b101-9dc5cd1966ac'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''0fb34fbc-3ec1-4d3d-865d-6e7844223bd7'' AND GUID_ObjectReference=''87cbbf56-b83b-471d-8813-f47b6e881174'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''0fb34fbc-3ec1-4d3d-865d-6e7844223bd7'',''87cbbf56-b83b-471d-8813-f47b6e881174'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6e494944-f602-4dcb-906f-70e5efe8f1dd'' AND GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''008817a6-14e7-4295-9a69-6835575ae53b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f2cde058-614e-41cb-96eb-78bbcf285171'' AND GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f2cde058-614e-41cb-96eb-78bbcf285171'',''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''54ee77fa-3d84-4564-a2d8-7a484c66c0e8'' AND GUID_ObjectReference=''8765f75d-d6eb-420a-bcc0-f19e7f9f0ef9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''54ee77fa-3d84-4564-a2d8-7a484c66c0e8'',''8765f75d-d6eb-420a-bcc0-f19e7f9f0ef9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''55635d10-7db1-4aed-a4f5-7b3ce3649879'' AND GUID_ObjectReference=''f46a97cf-657c-4580-9f9a-7058783f469f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''55635d10-7db1-4aed-a4f5-7b3ce3649879'',''f46a97cf-657c-4580-9f9a-7058783f469f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''36ee074b-a672-4bf0-b744-7b880ba58207'' AND GUID_ObjectReference=''c1c4c936-b556-4114-b276-b3207c5a795e'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''36ee074b-a672-4bf0-b744-7b880ba58207'',''c1c4c936-b556-4114-b276-b3207c5a795e'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3965c342-890d-4227-84fe-7bf195c36325'' AND GUID_ObjectReference=''781dc2dc-bace-47d8-8c51-46e506ddb85b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3965c342-890d-4227-84fe-7bf195c36325'',''781dc2dc-bace-47d8-8c51-46e506ddb85b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''7375ee4b-b6ba-4df4-9433-7f88f4b1d1b9'' AND GUID_ObjectReference=''ffcb7add-5fac-4df5-8da3-3b816562706d'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''7375ee4b-b6ba-4df4-9433-7f88f4b1d1b9'',''ffcb7add-5fac-4df5-8da3-3b816562706d'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''11c42673-8aee-4dec-ae12-87e0bcd4b551'' AND GUID_ObjectReference=''f635dcfe-4340-4e12-94db-29c66a6312fb'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''11c42673-8aee-4dec-ae12-87e0bcd4b551'',''f635dcfe-4340-4e12-94db-29c66a6312fb'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3c61b8a2-0550-47ba-a38e-8934144332e4'' AND GUID_ObjectReference=''f6c7c9bf-a3ef-409d-bb95-bd986efd35d9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3c61b8a2-0550-47ba-a38e-8934144332e4'',''f6c7c9bf-a3ef-409d-bb95-bd986efd35d9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ffaf3ed4-1024-4842-a776-8c6e1ba13d98'' AND GUID_ObjectReference=''719a3287-3d80-4ecf-a844-f404f57c53c4'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ffaf3ed4-1024-4842-a776-8c6e1ba13d98'',''719a3287-3d80-4ecf-a844-f404f57c53c4'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'' AND GUID_ObjectReference=''07d78334-08f5-458a-b84a-b586f60700b9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''7889dd1c-c617-4bfa-9a64-8ee38fb26a59'',''07d78334-08f5-458a-b84a-b586f60700b9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''afd32643-ddbc-4240-a009-8f8a741bbe45'' AND GUID_ObjectReference=''15f6c2a7-787c-4277-9730-17dea6d6f7c6'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''afd32643-ddbc-4240-a009-8f8a741bbe45'',''15f6c2a7-787c-4277-9730-17dea6d6f7c6'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''abce8221-44de-4962-9a28-8fa598144a88'' AND GUID_ObjectReference=''47fb2885-07fe-43e9-b82f-38f387dd8a90'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''abce8221-44de-4962-9a28-8fa598144a88'',''47fb2885-07fe-43e9-b82f-38f387dd8a90'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''c6eddf29-f402-4ee7-9b21-9148cbbe67f1'' AND GUID_ObjectReference=''d7bb7c7d-2536-40c6-b8bb-a87222ba9d9d'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''c6eddf29-f402-4ee7-9b21-9148cbbe67f1'',''d7bb7c7d-2536-40c6-b8bb-a87222ba9d9d'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b07f9081-e969-439d-9616-91c9783915c0'' AND GUID_ObjectReference=''9e3ae462-2e41-4988-a188-955aa4a4fe16'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b07f9081-e969-439d-9616-91c9783915c0'',''9e3ae462-2e41-4988-a188-955aa4a4fe16'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''82553dbf-ce61-4b65-a633-96bd1c759f4c'' AND GUID_ObjectReference=''6348f4f1-5cf5-43f6-819e-fac1b94d3edc'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''82553dbf-ce61-4b65-a633-96bd1c759f4c'',''6348f4f1-5cf5-43f6-819e-fac1b94d3edc'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''fb743b00-102e-4797-ab99-9bcfaa72041f'' AND GUID_ObjectReference=''6d8fe254-868a-4cff-9cf2-8eedc4daedb3'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''fb743b00-102e-4797-ab99-9bcfaa72041f'',''6d8fe254-868a-4cff-9cf2-8eedc4daedb3'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b426d245-2c31-4558-9893-9f7e12578722'' AND GUID_ObjectReference=''70a596b6-9311-4cae-8a08-aad3398feef1'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b426d245-2c31-4558-9893-9f7e12578722'',''70a596b6-9311-4cae-8a08-aad3398feef1'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f936827c-e5b9-41aa-a897-a462d0bc2d72'' AND GUID_ObjectReference=''3d6866ea-1cbf-4874-b0c7-f0df274a399f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f936827c-e5b9-41aa-a897-a462d0bc2d72'',''3d6866ea-1cbf-4874-b0c7-f0df274a399f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d8d3aabf-8d77-4108-8a26-a58a052ac265'' AND GUID_ObjectReference=''3c456175-07c7-462a-bc1d-73c00c6e2661'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d8d3aabf-8d77-4108-8a26-a58a052ac265'',''3c456175-07c7-462a-bc1d-73c00c6e2661'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''94de9f11-b875-46ab-a6f3-a684a5c78e05'' AND GUID_ObjectReference=''09a2ba9b-fa73-48ab-8fe4-f694d3365ef2'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''94de9f11-b875-46ab-a6f3-a684a5c78e05'',''09a2ba9b-fa73-48ab-8fe4-f694d3365ef2'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''87eb4dc0-bdae-4c49-bf3c-a70ea7a6a4d6'' AND GUID_ObjectReference=''5b7370d1-c850-4203-9265-eabc2bcd2021'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''87eb4dc0-bdae-4c49-bf3c-a70ea7a6a4d6'',''5b7370d1-c850-4203-9265-eabc2bcd2021'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3d478c67-2bd0-4141-9459-a7cdc8d21fb8'' AND GUID_ObjectReference=''e0e3b99f-59ed-4d81-8b53-83b925a18d31'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3d478c67-2bd0-4141-9459-a7cdc8d21fb8'',''e0e3b99f-59ed-4d81-8b53-83b925a18d31'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''32795bc3-e71b-488d-91a7-a8fe44d87988'' AND GUID_ObjectReference=''f2f3ae8e-d891-47a9-a14a-56afeeee6e20'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''32795bc3-e71b-488d-91a7-a8fe44d87988'',''f2f3ae8e-d891-47a9-a14a-56afeeee6e20'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f10253cf-f5c4-4777-8f4b-abc61217e28b'' AND GUID_ObjectReference=''a3eefd82-7501-4d2a-b95b-0314be945223'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f10253cf-f5c4-4777-8f4b-abc61217e28b'',''a3eefd82-7501-4d2a-b95b-0314be945223'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''9a1564a4-a5e8-464d-b901-b3b716aaa24f'' AND GUID_ObjectReference=''c114a19f-3fed-41e4-a18b-e3705c2a42bc'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''9a1564a4-a5e8-464d-b901-b3b716aaa24f'',''c114a19f-3fed-41e4-a18b-e3705c2a42bc'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f1ba23ed-ab41-4d34-8e09-b4e485671478'' AND GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b63ef338-285a-4358-94fc-bb31b8bfebd0'' AND GUID_ObjectReference=''87649bbb-7f48-4204-9b92-887d795f12d7'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b63ef338-285a-4358-94fc-bb31b8bfebd0'',''87649bbb-7f48-4204-9b92-887d795f12d7'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''59df733f-6853-4af3-87d6-bd769bc34684'' AND GUID_ObjectReference=''dc545b73-2319-4914-a798-126b9e4c6d4c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''59df733f-6853-4af3-87d6-bd769bc34684'',''dc545b73-2319-4914-a798-126b9e4c6d4c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''5a9ea127-d417-47bb-84f8-c0655a84815b'' AND GUID_ObjectReference=''8429b97a-f6f1-4785-923e-cbf78d60b3cd'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''5a9ea127-d417-47bb-84f8-c0655a84815b'',''8429b97a-f6f1-4785-923e-cbf78d60b3cd'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6b4eb5ee-7009-49eb-a355-c5144275e004'' AND GUID_ObjectReference=''f5255a9e-34a9-4982-bbf5-cb77d7f6937c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6b4eb5ee-7009-49eb-a355-c5144275e004'',''f5255a9e-34a9-4982-bbf5-cb77d7f6937c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''a144f6f2-756d-4a12-ab01-c579174a64f0'' AND GUID_ObjectReference=''4251fed1-6f44-490a-9393-941af0af7fba'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''a144f6f2-756d-4a12-ab01-c579174a64f0'',''4251fed1-6f44-490a-9393-941af0af7fba'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''a1339a65-c133-42e9-8e2c-c5b0b98c2e02'' AND GUID_ObjectReference=''3340f1ca-b31c-45ef-9263-8d6e1ebe4c2a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''a1339a65-c133-42e9-8e2c-c5b0b98c2e02'',''3340f1ca-b31c-45ef-9263-8d6e1ebe4c2a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''bf1af2ef-5cc5-4219-ad93-c846d18b02f4'' AND GUID_ObjectReference=''b4032ce4-d3f5-4153-9f40-6222dc414bc5'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''bf1af2ef-5cc5-4219-ad93-c846d18b02f4'',''b4032ce4-d3f5-4153-9f40-6222dc414bc5'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3ed4e4e7-1acf-4724-9d57-ca0b5366d49d'' AND GUID_ObjectReference=''a2172ef6-37ac-4493-9ea5-d902bd03d623'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3ed4e4e7-1acf-4724-9d57-ca0b5366d49d'',''a2172ef6-37ac-4493-9ea5-d902bd03d623'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8618f96e-8494-432a-99da-cc91e6c117d5'' AND GUID_ObjectReference=''c09ca6bf-b5fb-4121-b169-d389981a2ad4'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8618f96e-8494-432a-99da-cc91e6c117d5'',''c09ca6bf-b5fb-4121-b169-d389981a2ad4'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''2c8b2594-908b-4e85-bd14-ce0727e2456a'' AND GUID_ObjectReference=''71669480-1af5-4bce-b5b8-6cf2541dd18c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''2c8b2594-908b-4e85-bd14-ce0727e2456a'',''71669480-1af5-4bce-b5b8-6cf2541dd18c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''594ef5cd-f083-4a78-8a5d-d0aabee43967'' AND GUID_ObjectReference=''4fdbc15a-7211-4dce-92af-40f3caf3916a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''594ef5cd-f083-4a78-8a5d-d0aabee43967'',''4fdbc15a-7211-4dce-92af-40f3caf3916a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''22faaa6d-8fbe-4b5a-8856-dec1fbcb5959'' AND GUID_ObjectReference=''3e2f1b1a-b99a-4269-bcf2-47de2f20084b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''22faaa6d-8fbe-4b5a-8856-dec1fbcb5959'',''3e2f1b1a-b99a-4269-bcf2-47de2f20084b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ab57193e-56cc-4f75-81a1-e2529fa99196'' AND GUID_ObjectReference=''c2d7ef23-f69c-4905-bf07-733a1d08cac1'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ab57193e-56cc-4f75-81a1-e2529fa99196'',''c2d7ef23-f69c-4905-bf07-733a1d08cac1'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''82be9300-79bd-407f-8c77-e429a2dafc58'' AND GUID_ObjectReference=''93b946ef-dce6-4de0-8ae1-9d45ed6f5457'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''82be9300-79bd-407f-8c77-e429a2dafc58'',''93b946ef-dce6-4de0-8ae1-9d45ed6f5457'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''97ce5aad-fd31-479c-9164-e6e26f35a650'' AND GUID_ObjectReference=''b49a69ce-7d5f-4c25-90f6-1db7e4402be9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''97ce5aad-fd31-479c-9164-e6e26f35a650'',''b49a69ce-7d5f-4c25-90f6-1db7e4402be9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''470abd26-c317-4625-91a7-e9828b751893'' AND GUID_ObjectReference=''ecbf4898-09f4-4d14-ab48-c15966e92ff1'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''470abd26-c317-4625-91a7-e9828b751893'',''ecbf4898-09f4-4d14-ab48-c15966e92ff1'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''92121dac-d796-4dac-acc8-ea779f9cb1cd'' AND GUID_ObjectReference=''a8abe90f-6ac3-42e4-a3a7-4144e836f8a6'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''92121dac-d796-4dac-acc8-ea779f9cb1cd'',''a8abe90f-6ac3-42e4-a3a7-4144e836f8a6'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3faebef6-8e7d-4e06-8085-eba30e529f72'' AND GUID_ObjectReference=''e350da57-ca79-4c4c-8764-06ab442cb3a0'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3faebef6-8e7d-4e06-8085-eba30e529f72'',''e350da57-ca79-4c4c-8764-06ab442cb3a0'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e1627ced-e28d-4864-bcad-ee1af3f783ca'' AND GUID_ObjectReference=''c0cdddc5-3a1d-48a2-881a-967a8e44f6a6'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e1627ced-e28d-4864-bcad-ee1af3f783ca'',''c0cdddc5-3a1d-48a2-881a-967a8e44f6a6'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''7e3ffe0b-3974-4db7-8ffe-ee37609d7ec8'' AND GUID_ObjectReference=''19fda1b9-1a35-4bd7-8f9d-166d44a1334b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''7e3ffe0b-3974-4db7-8ffe-ee37609d7ec8'',''19fda1b9-1a35-4bd7-8f9d-166d44a1334b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ea755e36-262f-4c2e-956c-f120cbf638ce'' AND GUID_ObjectReference=''9e93042e-fd3f-4fa5-bf5f-d14e659be359'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ea755e36-262f-4c2e-956c-f120cbf638ce'',''9e93042e-fd3f-4fa5-bf5f-d14e659be359'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''4fbada37-ac86-49f2-b06e-f6c5d7db8d2d'' AND GUID_ObjectReference=''fc30c0af-0d33-4cce-9624-7ee679945959'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''4fbada37-ac86-49f2-b06e-f6c5d7db8d2d'',''fc30c0af-0d33-4cce-9624-7ee679945959'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b4d86c89-dbd6-432f-a048-f71d29dd39b1'' AND GUID_ObjectReference=''e35ae637-4933-4aa7-9e92-f377a4b5c0ef'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b4d86c89-dbd6-432f-a048-f71d29dd39b1'',''e35ae637-4933-4aa7-9e92-f377a4b5c0ef'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''eb37c6a5-1ea2-4bf6-9951-fa2310fd38c9'' AND GUID_ObjectReference=''fedeccdf-0a8e-433e-a972-344dfb44e57f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''eb37c6a5-1ea2-4bf6-9951-fa2310fd38c9'',''fedeccdf-0a8e-433e-a972-344dfb44e57f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''7dbbd3e8-635a-4dc5-a30b-fc3814271b8d'' AND GUID_ObjectReference=''7d1dac48-aecd-44d7-bbad-e0f964050a98'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''7dbbd3e8-635a-4dc5-a30b-fc3814271b8d'',''7d1dac48-aecd-44d7-bbad-e0f964050a98'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8f978e33-6565-4144-b2e3-ff28e652310a'' AND GUID_ObjectReference=''17266d34-3ac7-4acb-9426-72d65e299b12'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8f978e33-6565-4144-b2e3-ff28e652310a'',''17266d34-3ac7-4acb-9426-72d65e299b12'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''13c09f11-175c-4eef-bc8a-0fd8e86d557f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''13c09f11-175c-4eef-bc8a-0fd8e86d557f'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''d84fa125-dbce-44b0-9153-9abeb66ad27f'' AND GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	INSERT INTO semtbl_Type_OR VALUES(''d84fa125-dbce-44b0-9153-9abeb66ad27f'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''f62cf1cc-ee51-475f-9c00-7094f1809b56'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''f62cf1cc-ee51-475f-9c00-7094f1809b56'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''d0f58213-7db4-4882-bd15-962163015d13'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''d0f58213-7db4-4882-bd15-962163015d13'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''351d4591-2495-4501-82ab-a425f5235db9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''e51633ca-e76f-4a3b-b4eb-95aace386755'' AND GUID_RelationType=''1f063a79-ddde-44c5-95ba-50391fe6f0e3'')=0
	INSERT INTO semtbl_Type_OR VALUES(''e51633ca-e76f-4a3b-b4eb-95aace386755'',''1f063a79-ddde-44c5-95ba-50391fe6f0e3'',1,-1)'
GO
