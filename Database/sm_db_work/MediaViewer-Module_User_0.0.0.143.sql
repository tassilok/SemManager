use [sem_db_work]
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''b67c3f3c-da03-4693-9afc-d2014997e328'') = 0
	insert into semtbl_Attribute VALUES(''b67c3f3c-da03-4693-9afc-d2014997e328'',''Datetimestamp (Create)'',''905fda81-788f-4e3d-8329-3e55ae984b9e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'') = 0
	insert into semtbl_Attribute VALUES(''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'',''Blob'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type=''49fdcd27-e105-4770-941d-7485dcad08c1'') = 0
	insert into semtbl_Type (GUID_Type,Name_Type) VALUES(''49fdcd27-e105-4770-941d-7485dcad08c1'',''Root'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''49c6293d-838e-4b9c-b0de-d4ae569e605b'') = 0
	insert into semtbl_Token VALUES(''49c6293d-838e-4b9c-b0de-d4ae569e605b'',''Base-Config'',''460cb016-8fbb-47ae-91c8-cd9d8db5d8f4'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''1cff98ca-b773-4bec-a511-59c704558965'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''1cff98ca-b773-4bec-a511-59c704558965'',''ea90b682-91fe-468d-8787-82dd86a2d7a8'',''68ac4472-ee22-4229-96ec-9753a016900a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''16c1b959-0a3f-43f1-9168-a33715c26737'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''16c1b959-0a3f-43f1-9168-a33715c26737'',''db1a6d4e-bb72-4f80-8c16-67d9081cbdc9'',''68ac4472-ee22-4229-96ec-9753a016900a'')'
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
