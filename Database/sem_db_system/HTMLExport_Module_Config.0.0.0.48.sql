execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''aea35976-b4f7-4c1d-b338-92f3f57e84e0'') = 0
	insert into semtbl_Attribute VALUES(''aea35976-b4f7-4c1d-b338-92f3f57e84e0'',''Level'',''3a4f5b7b-da75-4980-933e-fbc33cc51439'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''68ac4472-ee22-4229-96ec-9753a016900a'') = 0
	insert into semtbl_Attribute VALUES(''68ac4472-ee22-4229-96ec-9753a016900a'',''XML-Text'',''64530b52-d96c-4df1-86fe-183f44513450'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''f816b8da-bd8b-4bce-965f-306d7a186287'') = 0
	insert into semtbl_Attribute VALUES(''f816b8da-bd8b-4bce-965f-306d7a186287'',''Intro'',''64530b52-d96c-4df1-86fe-183f44513450'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''0b183be9-c13d-4157-989b-63b0362aeee6'') = 0
	insert into semtbl_Attribute VALUES(''0b183be9-c13d-4157-989b-63b0362aeee6'',''ID'',''3a4f5b7b-da75-4980-933e-fbc33cc51439'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''6092162a-d4cb-4655-8753-e18a662fb28f'') = 0
	insert into semtbl_Attribute VALUES(''6092162a-d4cb-4655-8753-e18a662fb28f'',''taking'',''905fda81-788f-4e3d-8329-3e55ae984b9e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'') = 0
	insert into semtbl_Attribute VALUES(''8b1a9015-0922-4a5c-9d6b-c9d3f8f6d318'',''Blob'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''b67c3f3c-da03-4693-9afc-d2014997e328'') = 0
	insert into semtbl_Attribute VALUES(''b67c3f3c-da03-4693-9afc-d2014997e328'',''Datetimestamp (Create)'',''905fda81-788f-4e3d-8329-3e55ae984b9e'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''2e5fd016-c574-4924-b724-d1b30640243a'') = 0
	insert into semtbl_Attribute VALUES(''2e5fd016-c574-4924-b724-d1b30640243a'',''DateTimestamp'',''905fda81-788f-4e3d-8329-3e55ae984b9e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''0d2c794d-281d-44ff-9767-eb8549d4ad16'') = 0
	insert into semtbl_Attribute VALUES(''0d2c794d-281d-44ff-9767-eb8549d4ad16'',''Message'',''64530b52-d96c-4df1-86fe-183f44513450'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''fb8a3635-9532-42ac-9889-9f116abe6c53'')=0
	insert into semtbl_RelationType VALUES(''fb8a3635-9532-42ac-9889-9f116abe6c53'',''happened'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''be8c7e8f-9b0b-4adc-8f0b-8f8f1ae47f87'')=0
	insert into semtbl_RelationType VALUES(''be8c7e8f-9b0b-4adc-8f0b-8f8f1ae47f87'',''relative'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''62632706-1829-43e4-8034-52c7fd14e353'')=0
	insert into semtbl_RelationType VALUES(''62632706-1829-43e4-8034-52c7fd14e353'',''Tag-Start'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	insert into semtbl_RelationType VALUES(''3e104b75-e01c-48a0-b041-12908fd446a0'',''is'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''3126254c-d84e-4f34-82a4-47aeb7be4bda'')=0
	insert into semtbl_RelationType VALUES(''3126254c-d84e-4f34-82a4-47aeb7be4bda'',''Tag-End-Init'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''95ca984f-e8bd-4d54-b56c-d982c2a0b9e7'')=0
	insert into semtbl_RelationType VALUES(''95ca984f-e8bd-4d54-b56c-d982c2a0b9e7'',''Tag-End'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	insert into semtbl_RelationType VALUES(''e9711603-47db-44d8-a476-fe88290639a4'',''contains'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''cf27679f-cbe7-4010-a3ae-472072762b33'')=0
	insert into semtbl_RelationType VALUES(''cf27679f-cbe7-4010-a3ae-472072762b33'',''is in State'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''aaf3e012-a822-4ba6-9d9d-d5bb35821757'')=0
	insert into semtbl_RelationType VALUES(''aaf3e012-a822-4ba6-9d9d-d5bb35821757'',''export to'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	insert into semtbl_RelationType VALUES(''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',''offered by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	insert into semtbl_RelationType VALUES(''e07469d9-766c-443e-8526-6d9c684f944f'',''belongs to'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''93dd2bd3-791a-4699-80d1-96bb52bdcae5'')=0
	insert into semtbl_RelationType VALUES(''93dd2bd3-791a-4699-80d1-96bb52bdcae5'',''Intro'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''f68a9438-fb8b-418d-8e0b-d9aefc9ecdf3'')=0
	insert into semtbl_RelationType VALUES(''f68a9438-fb8b-418d-8e0b-d9aefc9ecdf3'',''belonging Token'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	insert into semtbl_RelationType VALUES(''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',''belonging Source'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''7e709649-5791-4116-af93-263864214ffe'')=0
	insert into semtbl_RelationType VALUES(''7e709649-5791-4116-af93-263864214ffe'',''Sources located in'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	insert into semtbl_RelationType VALUES(''408db9f1-ae42-4807-b656-729270646f0a'',''is subordinated'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''fb90fea9-586d-4e7b-afd6-e5ccb009268a'')=0
	insert into semtbl_RelationType VALUES(''fb90fea9-586d-4e7b-afd6-e5ccb009268a'',''Request'')'
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='f30436d6-2ffc-4071-af5e-3ce708b8c2d9') = 0
	insert into semtbl_Type VALUES('f30436d6-2ffc-4071-af5e-3ce708b8c2d9','Development-Version','71415eeb-ce46-4b2c-b0a2-f72116b55438')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='83317bac-b4b1-4db8-bf84-9fca0a93ddd5') = 0
	insert into semtbl_Type VALUES('83317bac-b4b1-4db8-bf84-9fca0a93ddd5','Information-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='cec96ab6-5066-4d38-89ab-47bc67d94463') = 0
	insert into semtbl_Type VALUES('cec96ab6-5066-4d38-89ab-47bc67d94463','HTML-Management','83317bac-b4b1-4db8-bf84-9fca0a93ddd5')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='902b2cd2-0fe6-4f49-92fd-97bcf28e2dad') = 0
	insert into semtbl_Type VALUES('902b2cd2-0fe6-4f49-92fd-97bcf28e2dad','HTML-Document','cec96ab6-5066-4d38-89ab-47bc67d94463')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='83ae48a6-7cdf-4ac7-a635-48494c39f67e') = 0
	insert into semtbl_Type VALUES('83ae48a6-7cdf-4ac7-a635-48494c39f67e','Document-Parts','902b2cd2-0fe6-4f49-92fd-97bcf28e2dad')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='44e1125d-41c5-418e-b012-5f7f7b8f3063') = 0
	insert into semtbl_Type VALUES('44e1125d-41c5-418e-b012-5f7f7b8f3063','HTML-Tags','cec96ab6-5066-4d38-89ab-47bc67d94463')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='afe18e83-a290-4660-9e6b-ced83ab2a429') = 0
	insert into semtbl_Type VALUES('afe18e83-a290-4660-9e6b-ced83ab2a429','Tag-Attributes','44e1125d-41c5-418e-b012-5f7f7b8f3063')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='de988c64-dd59-41f4-bf1f-4b54c56e8fe7') = 0
	insert into semtbl_Type VALUES('de988c64-dd59-41f4-bf1f-4b54c56e8fe7','Templates','83317bac-b4b1-4db8-bf84-9fca0a93ddd5')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='327e9773-fca6-458c-a44d-338a556e0ad9') = 0
	insert into semtbl_Type VALUES('327e9773-fca6-458c-a44d-338a556e0ad9','XML','de988c64-dd59-41f4-bf1f-4b54c56e8fe7')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='176cb03d-11c5-4d59-8de0-44cf5d1832e2') = 0
	insert into semtbl_Type VALUES('176cb03d-11c5-4d59-8de0-44cf5d1832e2','Sprache','83317bac-b4b1-4db8-bf84-9fca0a93ddd5')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='c8e580ed-be06-49a2-8ee8-17e8e0160393') = 0
	insert into semtbl_Type VALUES('c8e580ed-be06-49a2-8ee8-17e8e0160393','Zeichen','176cb03d-11c5-4d59-8de0-44cf5d1832e2')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='35e350f6-cfae-4c87-98bd-dea4831ebaab') = 0
	insert into semtbl_Type VALUES('35e350f6-cfae-4c87-98bd-dea4831ebaab','Document-Tag-Type','83317bac-b4b1-4db8-bf84-9fca0a93ddd5')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='6fd4edc2-0220-405a-9baa-74449b2a2ae6') = 0
	insert into semtbl_Type VALUES('6fd4edc2-0220-405a-9baa-74449b2a2ae6','Attribute-Type','35e350f6-cfae-4c87-98bd-dea4831ebaab')
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='55e1e943-398d-49a8-a6e6-a573bc6dc740') = 0
	insert into semtbl_Type VALUES('55e1e943-398d-49a8-a6e6-a573bc6dc740','HTMLExport-Module','aa616051-e521-4fac-abdb-cbba6f8c6e73')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='2f05c250-be33-4b77-ba3c-b8a0228821b6') = 0
	insert into semtbl_Type VALUES('2f05c250-be33-4b77-ba3c-b8a0228821b6','Filesystem-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='f47a3e1c-50b4-4666-a41d-e975597c9adb') = 0
	insert into semtbl_Type VALUES('f47a3e1c-50b4-4666-a41d-e975597c9adb','Folder','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='8a894710-e08c-42c5-b829-ef4809830d33') = 0
	insert into semtbl_Type VALUES('8a894710-e08c-42c5-b829-ef4809830d33','Path','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='6eb4fdd3-2e25-4886-b288-e1bfc2857efb') = 0
	insert into semtbl_Type VALUES('6eb4fdd3-2e25-4886-b288-e1bfc2857efb','File','2f05c250-be33-4b77-ba3c-b8a0228821b6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='53136d10-b7e7-47fc-94ad-7887a354d6e1') = 0
	insert into semtbl_Type VALUES('53136d10-b7e7-47fc-94ad-7887a354d6e1','Log-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='351d4591-2495-4501-82ab-a425f5235db9') = 0
	insert into semtbl_Type VALUES('351d4591-2495-4501-82ab-a425f5235db9','Logentry','53136d10-b7e7-47fc-94ad-7887a354d6e1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='7415f32e-fb56-4aeb-a413-42e37457fdb7') = 0
	insert into semtbl_Type VALUES('7415f32e-fb56-4aeb-a413-42e37457fdb7','Media-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='d84fa125-dbce-44b0-9153-9abeb66ad27f') = 0
	insert into semtbl_Type VALUES('d84fa125-dbce-44b0-9153-9abeb66ad27f','Media-Item','7415f32e-fb56-4aeb-a413-42e37457fdb7')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='f62cf1cc-ee51-475f-9c00-7094f1809b56') = 0
	insert into semtbl_Type VALUES('f62cf1cc-ee51-475f-9c00-7094f1809b56','Images (Graphic)','7415f32e-fb56-4aeb-a413-42e37457fdb7')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='d0f58213-7db4-4882-bd15-962163015d13') = 0
	insert into semtbl_Type VALUES('d0f58213-7db4-4882-bd15-962163015d13','PDF-Documents','7415f32e-fb56-4aeb-a413-42e37457fdb7')
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'') = 0
	insert into semtbl_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''HTMLExport-Module'',''c6c9bcb8-0ac9-4713-9417-eeec1453026c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9d86d2b2-274b-49c1-83d1-c46dfe73d1ef'') = 0
	insert into semtbl_Token VALUES(''9d86d2b2-274b-49c1-83d1-c46dfe73d1ef'',''HTMLExport-Module'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''91061953-fa7f-4742-9c97-00472d7e5dfe'') = 0
	insert into semtbl_Token VALUES(''91061953-fa7f-4742-9c97-00472d7e5dfe'',''Type_Document_Parts'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''50440d4b-c144-48ac-970e-04b22c9a7784'') = 0
	insert into semtbl_Token VALUES(''50440d4b-c144-48ac-970e-04b22c9a7784'',''Token_Document_Tag_Type_Table'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d646c103-0f93-4646-ad96-071ac603992b'') = 0
	insert into semtbl_Token VALUES(''d646c103-0f93-4646-ad96-071ac603992b'',''RelationType_Happened'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'') = 0
	insert into semtbl_Token VALUES(''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''Type_Module'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1fafd5db-5c3c-4012-affd-134ae1ef990f'') = 0
	insert into semtbl_Token VALUES(''1fafd5db-5c3c-4012-affd-134ae1ef990f'',''Token_Tag_Attributes_src'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c1581f8a-3661-4512-94de-148eb8bbb784'') = 0
	insert into semtbl_Token VALUES(''c1581f8a-3661-4512-94de-148eb8bbb784'',''RelationType_relative'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''764e1872-78cc-48b7-b6dd-1808f7699c0c'') = 0
	insert into semtbl_Token VALUES(''764e1872-78cc-48b7-b6dd-1808f7699c0c'',''RelationType_Tag_Start'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b53826c1-bddc-4fc2-a922-180c32ea7207'') = 0
	insert into semtbl_Token VALUES(''b53826c1-bddc-4fc2-a922-180c32ea7207'',''Type_Media_Item'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d7a0c520-e098-426f-928f-24e05314631b'') = 0
	insert into semtbl_Token VALUES(''d7a0c520-e098-426f-928f-24e05314631b'',''Type_HTMLExport_Module'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bd416afc-f709-4bc6-9708-36f65be3a697'') = 0
	insert into semtbl_Token VALUES(''bd416afc-f709-4bc6-9708-36f65be3a697'',''Attribute_Level'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''747952da-2e66-49c1-8462-3a20addbc0ef'') = 0
	insert into semtbl_Token VALUES(''747952da-2e66-49c1-8462-3a20addbc0ef'',''RelationType_is'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'') = 0
	insert into semtbl_Token VALUES(''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'',''Attribute_XML_Text'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b1b184d4-47df-4153-b2dd-4076b221cb85'') = 0
	insert into semtbl_Token VALUES(''b1b184d4-47df-4153-b2dd-4076b221cb85'',''Token_Document_Tag_Type_Title'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5ec1507f-8df9-41ad-9f2a-4452fd87307c'') = 0
	insert into semtbl_Token VALUES(''5ec1507f-8df9-41ad-9f2a-4452fd87307c'',''Token_Document_Tag_Type_Bold'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9fc39c5e-112e-4076-9418-476b4c59edce'') = 0
	insert into semtbl_Token VALUES(''9fc39c5e-112e-4076-9418-476b4c59edce'',''RelationType_Tag_End_Init'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ea2bc0e5-c2b0-49a3-8ec8-497468bb67bb'') = 0
	insert into semtbl_Token VALUES(''ea2bc0e5-c2b0-49a3-8ec8-497468bb67bb'',''RelationType_Tag_End'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5e3ec8de-704f-44a3-bbcd-49eabc97bb4d'') = 0
	insert into semtbl_Token VALUES(''5e3ec8de-704f-44a3-bbcd-49eabc97bb4d'',''Token_Tag_Attributes_border'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''58c919ca-98d3-497b-bb00-4ae2d5391d27'') = 0
	insert into semtbl_Token VALUES(''58c919ca-98d3-497b-bb00-4ae2d5391d27'',''Token_Document_Tag_Type_Table_Col'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e3207993-b7f1-44bc-959e-530153e2f84d'') = 0
	insert into semtbl_Token VALUES(''e3207993-b7f1-44bc-959e-530153e2f84d'',''Token_Attribute_Type_Source_of_Resource'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''53a9ae75-7493-4fe2-b0f0-5c9aac78b1e2'') = 0
	insert into semtbl_Token VALUES(''53a9ae75-7493-4fe2-b0f0-5c9aac78b1e2'',''Token_Document_Tag_Type_Table_Row'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6c966e3c-c737-4af1-9970-68c8323679bc'') = 0
	insert into semtbl_Token VALUES(''6c966e3c-c737-4af1-9970-68c8323679bc'',''RelationType_contains'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''565ccbae-718f-4b3d-bd06-6a1906653220'') = 0
	insert into semtbl_Token VALUES(''565ccbae-718f-4b3d-bd06-6a1906653220'',''Type_Images__Graphic_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8e96640d-b873-4a50-b272-6b1376b26852'') = 0
	insert into semtbl_Token VALUES(''8e96640d-b873-4a50-b272-6b1376b26852'',''RelationType_isInState'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'') = 0
	insert into semtbl_Token VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''attribute_dbPostfix'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e3d4516d-4f74-44ff-8472-6c2f016d457e'') = 0
	insert into semtbl_Token VALUES(''e3d4516d-4f74-44ff-8472-6c2f016d457e'',''RelationType_export_to'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f2cde058-614e-41cb-96eb-78bbcf285171'') = 0
	insert into semtbl_Token VALUES(''f2cde058-614e-41cb-96eb-78bbcf285171'',''RelationType_offered_by'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cf987b9c-6671-4a93-b851-7b39935fe8f4'') = 0
	insert into semtbl_Token VALUES(''cf987b9c-6671-4a93-b851-7b39935fe8f4'',''Token_Document_Tag_Type_Content'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cbba043e-2016-4b53-9d35-8862cde34047'') = 0
	insert into semtbl_Token VALUES(''cbba043e-2016-4b53-9d35-8862cde34047'',''Token_HTML_Tag_Type_Heading'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''58fb3207-e0a1-4ec4-9653-8c29360d6d0c'') = 0
	insert into semtbl_Token VALUES(''58fb3207-e0a1-4ec4-9653-8c29360d6d0c'',''Token_Document_Tag_Type_Paragraph'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''663149f2-6645-4151-beb0-a24fdea6eb2b'') = 0
	insert into semtbl_Token VALUES(''663149f2-6645-4151-beb0-a24fdea6eb2b'',''Token_XML_HTML_Intro'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f936827c-e5b9-41aa-a897-a462d0bc2d72'') = 0
	insert into semtbl_Token VALUES(''f936827c-e5b9-41aa-a897-a462d0bc2d72'',''Type_PDF_Documents'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3186cc5e-023b-4edc-b6c7-a89919320839'') = 0
	insert into semtbl_Token VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''RelationType_belongsTo'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''aa5f0ec8-e754-4cf8-bc0a-a8ca94c38ec9'') = 0
	insert into semtbl_Token VALUES(''aa5f0ec8-e754-4cf8-bc0a-a8ca94c38ec9'',''Token_HTML_Tag_Type_Document_Init_Final'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''923108a1-c159-4d69-affe-ae048460dd24'') = 0
	insert into semtbl_Token VALUES(''923108a1-c159-4d69-affe-ae048460dd24'',''type_Folder'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cfba621b-5774-445b-8749-af12bb8bb472'') = 0
	insert into semtbl_Token VALUES(''cfba621b-5774-445b-8749-af12bb8bb472'',''Type_XML'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8a6a3874-7e7b-4c41-b43a-b0349e39113b'') = 0
	insert into semtbl_Token VALUES(''8a6a3874-7e7b-4c41-b43a-b0349e39113b'',''Type_Path'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d8a843bb-d595-418a-b7ec-b23cd6c8782c'') = 0
	insert into semtbl_Token VALUES(''d8a843bb-d595-418a-b7ec-b23cd6c8782c'',''RelationType_Intro'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f1ba23ed-ab41-4d34-8e09-b4e485671478'') = 0
	insert into semtbl_Token VALUES(''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''Type_File'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e9701def-6569-4d2b-8fe9-b4f75ae4f0ca'') = 0
	insert into semtbl_Token VALUES(''e9701def-6569-4d2b-8fe9-b4f75ae4f0ca'',''Token_HTML_Tag_Type_HTML_Head_Init_Final'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''40443821-c238-4ac1-b9c3-bce0ae4cbdb8'') = 0
	insert into semtbl_Token VALUES(''40443821-c238-4ac1-b9c3-bce0ae4cbdb8'',''Type_Zeichen'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''611e9e48-bc64-47a6-8fc5-bf859edd985c'') = 0
	insert into semtbl_Token VALUES(''611e9e48-bc64-47a6-8fc5-bf859edd985c'',''Token_Document_Tag_Type_Images'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4ce41b7a-2fb9-4df6-b67a-c5aca2e46da1'') = 0
	insert into semtbl_Token VALUES(''4ce41b7a-2fb9-4df6-b67a-c5aca2e46da1'',''type_DevelopmentVersion'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''da616527-550c-4925-8a26-d4ddf1859c85'') = 0
	insert into semtbl_Token VALUES(''da616527-550c-4925-8a26-d4ddf1859c85'',''Type_Tag_Attributes'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''952e8e12-3054-4113-bf5c-d627f9e4f283'') = 0
	insert into semtbl_Token VALUES(''952e8e12-3054-4113-bf5c-d627f9e4f283'',''Attribute_Intro'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''10204d0e-05fd-4c68-99c3-d6657f2cb8a2'') = 0
	insert into semtbl_Token VALUES(''10204d0e-05fd-4c68-99c3-d6657f2cb8a2'',''Type_HTML_Tags'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b7912802-9994-4019-bb41-dc2bc766c505'') = 0
	insert into semtbl_Token VALUES(''b7912802-9994-4019-bb41-dc2bc766c505'',''Type_HTML_Document'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''470abd26-c317-4625-91a7-e9828b751893'') = 0
	insert into semtbl_Token VALUES(''470abd26-c317-4625-91a7-e9828b751893'',''Type_LogEntry'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f8986792-3dbf-4a6b-a1a3-f763086d06d4'') = 0
	insert into semtbl_Token VALUES(''f8986792-3dbf-4a6b-a1a3-f763086d06d4'',''RelationType_belonging_Token'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4b0874f0-f9ff-489c-82e7-4181e96ffe88'') = 0
	insert into semtbl_Token VALUES(''4b0874f0-f9ff-489c-82e7-4181e96ffe88'',''Table'',''35e350f6-cfae-4c87-98bd-dea4831ebaab'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''738496bc-3d39-4592-ae4c-da4644b0542c'') = 0
	insert into semtbl_Token VALUES(''738496bc-3d39-4592-ae4c-da4644b0542c'',''src'',''afe18e83-a290-4660-9e6b-ced83ab2a429'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''540cb05f-659d-432c-bcc0-7edaf389d77f'') = 0
	insert into semtbl_Token VALUES(''540cb05f-659d-432c-bcc0-7edaf389d77f'',''Title'',''35e350f6-cfae-4c87-98bd-dea4831ebaab'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c9da3392-212e-46af-a3e1-79716e15ed1a'') = 0
	insert into semtbl_Token VALUES(''c9da3392-212e-46af-a3e1-79716e15ed1a'',''Bold'',''35e350f6-cfae-4c87-98bd-dea4831ebaab'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''451c1498-bcc7-492b-9399-a01464d35186'') = 0
	insert into semtbl_Token VALUES(''451c1498-bcc7-492b-9399-a01464d35186'',''border'',''afe18e83-a290-4660-9e6b-ced83ab2a429'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cd2f9d05-5faa-4ec8-b052-4e665b4c6dfb'') = 0
	insert into semtbl_Token VALUES(''cd2f9d05-5faa-4ec8-b052-4e665b4c6dfb'',''Table-Col'',''35e350f6-cfae-4c87-98bd-dea4831ebaab'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1b4f8484-85d4-4f80-8541-b3cc67e6a43f'') = 0
	insert into semtbl_Token VALUES(''1b4f8484-85d4-4f80-8541-b3cc67e6a43f'',''Source of Resource'',''6fd4edc2-0220-405a-9baa-74449b2a2ae6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d545b18f-3f07-411e-92c5-c0695126eab3'') = 0
	insert into semtbl_Token VALUES(''d545b18f-3f07-411e-92c5-c0695126eab3'',''Table-Row'',''35e350f6-cfae-4c87-98bd-dea4831ebaab'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a7403d39-150e-4f3a-9d2c-6870c2c00389'') = 0
	insert into semtbl_Token VALUES(''a7403d39-150e-4f3a-9d2c-6870c2c00389'',''Content'',''35e350f6-cfae-4c87-98bd-dea4831ebaab'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1f2af1f4-936e-4cec-898c-a89c66131d6f'') = 0
	insert into semtbl_Token VALUES(''1f2af1f4-936e-4cec-898c-a89c66131d6f'',''Heading'',''35e350f6-cfae-4c87-98bd-dea4831ebaab'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e2d4e55d-d5e1-4892-b54e-b8c1e21e54e2'') = 0
	insert into semtbl_Token VALUES(''e2d4e55d-d5e1-4892-b54e-b8c1e21e54e2'',''Paragraph'',''35e350f6-cfae-4c87-98bd-dea4831ebaab'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''39a83777-2b8b-4a76-8beb-b3585ebb0185'') = 0
	insert into semtbl_Token VALUES(''39a83777-2b8b-4a76-8beb-b3585ebb0185'',''HTML-Intro'',''327e9773-fca6-458c-a44d-338a556e0ad9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''77a523f0-5658-4012-bd28-b0237607ddbd'') = 0
	insert into semtbl_Token VALUES(''77a523f0-5658-4012-bd28-b0237607ddbd'',''Document-Init/Final'',''35e350f6-cfae-4c87-98bd-dea4831ebaab'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5bc7672e-3f5b-4665-b491-b7d23410c9e8'') = 0
	insert into semtbl_Token VALUES(''5bc7672e-3f5b-4665-b491-b7d23410c9e8'',''Document-Head-Init/Final'',''35e350f6-cfae-4c87-98bd-dea4831ebaab'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''326a9d6d-da29-4b5e-802f-da420e4b55a0'') = 0
	insert into semtbl_Token VALUES(''326a9d6d-da29-4b5e-802f-da420e4b55a0'',''Images'',''35e350f6-cfae-4c87-98bd-dea4831ebaab'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''40ac341a-95ca-4df8-84f3-b6dd22edd112'') = 0
	insert into semtbl_Token VALUES(''40ac341a-95ca-4df8-84f3-b6dd22edd112'',''HTMLExport'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''81690cd8-3907-4325-801d-eb266ea3af89'') = 0
	insert into semtbl_Token VALUES(''81690cd8-3907-4325-801d-eb266ea3af89'',''BaseConfig'',''55e1e943-398d-49a8-a6e6-a573bc6dc740'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''91061953-fa7f-4742-9c97-00472d7e5dfe'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''91061953-fa7f-4742-9c97-00472d7e5dfe'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''50440d4b-c144-48ac-970e-04b22c9a7784'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''50440d4b-c144-48ac-970e-04b22c9a7784'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''d646c103-0f93-4646-ad96-071ac603992b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''d646c103-0f93-4646-ad96-071ac603992b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''1fafd5db-5c3c-4012-affd-134ae1ef990f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''1fafd5db-5c3c-4012-affd-134ae1ef990f'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''c1581f8a-3661-4512-94de-148eb8bbb784'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''c1581f8a-3661-4512-94de-148eb8bbb784'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''764e1872-78cc-48b7-b6dd-1808f7699c0c'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''764e1872-78cc-48b7-b6dd-1808f7699c0c'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''b53826c1-bddc-4fc2-a922-180c32ea7207'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''b53826c1-bddc-4fc2-a922-180c32ea7207'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''d7a0c520-e098-426f-928f-24e05314631b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''d7a0c520-e098-426f-928f-24e05314631b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''bd416afc-f709-4bc6-9708-36f65be3a697'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''bd416afc-f709-4bc6-9708-36f65be3a697'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''747952da-2e66-49c1-8462-3a20addbc0ef'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''747952da-2e66-49c1-8462-3a20addbc0ef'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''b1b184d4-47df-4153-b2dd-4076b221cb85'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''b1b184d4-47df-4153-b2dd-4076b221cb85'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''5ec1507f-8df9-41ad-9f2a-4452fd87307c'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''5ec1507f-8df9-41ad-9f2a-4452fd87307c'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''9fc39c5e-112e-4076-9418-476b4c59edce'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''9fc39c5e-112e-4076-9418-476b4c59edce'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''ea2bc0e5-c2b0-49a3-8ec8-497468bb67bb'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''ea2bc0e5-c2b0-49a3-8ec8-497468bb67bb'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''5e3ec8de-704f-44a3-bbcd-49eabc97bb4d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''5e3ec8de-704f-44a3-bbcd-49eabc97bb4d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''58c919ca-98d3-497b-bb00-4ae2d5391d27'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''58c919ca-98d3-497b-bb00-4ae2d5391d27'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''e3207993-b7f1-44bc-959e-530153e2f84d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''e3207993-b7f1-44bc-959e-530153e2f84d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''53a9ae75-7493-4fe2-b0f0-5c9aac78b1e2'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''53a9ae75-7493-4fe2-b0f0-5c9aac78b1e2'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''6c966e3c-c737-4af1-9970-68c8323679bc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''6c966e3c-c737-4af1-9970-68c8323679bc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''565ccbae-718f-4b3d-bd06-6a1906653220'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''565ccbae-718f-4b3d-bd06-6a1906653220'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''8e96640d-b873-4a50-b272-6b1376b26852'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''8e96640d-b873-4a50-b272-6b1376b26852'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''e3d4516d-4f74-44ff-8472-6c2f016d457e'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''e3d4516d-4f74-44ff-8472-6c2f016d457e'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''f2cde058-614e-41cb-96eb-78bbcf285171'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''f2cde058-614e-41cb-96eb-78bbcf285171'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''cf987b9c-6671-4a93-b851-7b39935fe8f4'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''cf987b9c-6671-4a93-b851-7b39935fe8f4'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''cbba043e-2016-4b53-9d35-8862cde34047'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''cbba043e-2016-4b53-9d35-8862cde34047'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''58fb3207-e0a1-4ec4-9653-8c29360d6d0c'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''58fb3207-e0a1-4ec4-9653-8c29360d6d0c'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''663149f2-6645-4151-beb0-a24fdea6eb2b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''663149f2-6645-4151-beb0-a24fdea6eb2b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''f936827c-e5b9-41aa-a897-a462d0bc2d72'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''f936827c-e5b9-41aa-a897-a462d0bc2d72'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''3186cc5e-023b-4edc-b6c7-a89919320839'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''aa5f0ec8-e754-4cf8-bc0a-a8ca94c38ec9'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''aa5f0ec8-e754-4cf8-bc0a-a8ca94c38ec9'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''923108a1-c159-4d69-affe-ae048460dd24'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''923108a1-c159-4d69-affe-ae048460dd24'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''cfba621b-5774-445b-8749-af12bb8bb472'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''cfba621b-5774-445b-8749-af12bb8bb472'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''8a6a3874-7e7b-4c41-b43a-b0349e39113b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''8a6a3874-7e7b-4c41-b43a-b0349e39113b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''d8a843bb-d595-418a-b7ec-b23cd6c8782c'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''d8a843bb-d595-418a-b7ec-b23cd6c8782c'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''f1ba23ed-ab41-4d34-8e09-b4e485671478'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''e9701def-6569-4d2b-8fe9-b4f75ae4f0ca'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''e9701def-6569-4d2b-8fe9-b4f75ae4f0ca'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''40443821-c238-4ac1-b9c3-bce0ae4cbdb8'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''40443821-c238-4ac1-b9c3-bce0ae4cbdb8'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''611e9e48-bc64-47a6-8fc5-bf859edd985c'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''611e9e48-bc64-47a6-8fc5-bf859edd985c'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''4ce41b7a-2fb9-4df6-b67a-c5aca2e46da1'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''4ce41b7a-2fb9-4df6-b67a-c5aca2e46da1'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''da616527-550c-4925-8a26-d4ddf1859c85'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''da616527-550c-4925-8a26-d4ddf1859c85'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''952e8e12-3054-4113-bf5c-d627f9e4f283'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''952e8e12-3054-4113-bf5c-d627f9e4f283'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''10204d0e-05fd-4c68-99c3-d6657f2cb8a2'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''10204d0e-05fd-4c68-99c3-d6657f2cb8a2'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''b7912802-9994-4019-bb41-dc2bc766c505'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''b7912802-9994-4019-bb41-dc2bc766c505'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''470abd26-c317-4625-91a7-e9828b751893'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''470abd26-c317-4625-91a7-e9828b751893'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_Token_Right=''f8986792-3dbf-4a6b-a1a3-f763086d06d4'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''f8986792-3dbf-4a6b-a1a3-f763086d06d4'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''9d86d2b2-274b-49c1-83d1-c46dfe73d1ef'' AND GUID_Token_Right=''d17e5672-a430-47c4-b6db-261c0d6dd9a4'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Token_Token VALUES(''9d86d2b2-274b-49c1-83d1-c46dfe73d1ef'',''d17e5672-a430-47c4-b6db-261c0d6dd9a4'',''fafc1464-815f-4596-9737-bcbc96bd744a'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''738496bc-3d39-4592-ae4c-da4644b0542c'' AND GUID_Token_Right=''1b4f8484-85d4-4f80-8541-b3cc67e6a43f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''738496bc-3d39-4592-ae4c-da4644b0542c'',''1b4f8484-85d4-4f80-8541-b3cc67e6a43f'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''40ac341a-95ca-4df8-84f3-b6dd22edd112'' AND GUID_Token_Right=''9d86d2b2-274b-49c1-83d1-c46dfe73d1ef'' AND GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	INSERT INTO semtbl_Token_Token VALUES(''40ac341a-95ca-4df8-84f3-b6dd22edd112'',''9d86d2b2-274b-49c1-83d1-c46dfe73d1ef'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''81690cd8-3907-4325-801d-eb266ea3af89'' AND GUID_Token_Right=''39a83777-2b8b-4a76-8beb-b3585ebb0185'' AND GUID_RelationType=''93dd2bd3-791a-4699-80d1-96bb52bdcae5'')=0
	INSERT INTO semtbl_Token_Token VALUES(''81690cd8-3907-4325-801d-eb266ea3af89'',''39a83777-2b8b-4a76-8beb-b3585ebb0185'',''93dd2bd3-791a-4699-80d1-96bb52bdcae5'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''81690cd8-3907-4325-801d-eb266ea3af89'' AND GUID_Token_Right=''40ac341a-95ca-4df8-84f3-b6dd22edd112'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''81690cd8-3907-4325-801d-eb266ea3af89'',''40ac341a-95ca-4df8-84f3-b6dd22edd112'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''83ae48a6-7cdf-4ac7-a635-48494c39f67e'' AND GUID_Attribute=''aea35976-b4f7-4c1d-b338-92f3f57e84e0'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''83ae48a6-7cdf-4ac7-a635-48494c39f67e'',''aea35976-b4f7-4c1d-b338-92f3f57e84e0'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''902b2cd2-0fe6-4f49-92fd-97bcf28e2dad'' AND GUID_Attribute=''f816b8da-bd8b-4bce-965f-306d7a186287'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''902b2cd2-0fe6-4f49-92fd-97bcf28e2dad'',''f816b8da-bd8b-4bce-965f-306d7a186287'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''d84fa125-dbce-44b0-9153-9abeb66ad27f'' AND GUID_Attribute=''0b183be9-c13d-4157-989b-63b0362aeee6'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''d84fa125-dbce-44b0-9153-9abeb66ad27f'',''0b183be9-c13d-4157-989b-63b0362aeee6'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''f62cf1cc-ee51-475f-9c00-7094f1809b56'' AND GUID_Attribute=''0b183be9-c13d-4157-989b-63b0362aeee6'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''f62cf1cc-ee51-475f-9c00-7094f1809b56'',''0b183be9-c13d-4157-989b-63b0362aeee6'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''f62cf1cc-ee51-475f-9c00-7094f1809b56'' AND GUID_Attribute=''6092162a-d4cb-4655-8753-e18a662fb28f'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''f62cf1cc-ee51-475f-9c00-7094f1809b56'',''6092162a-d4cb-4655-8753-e18a662fb28f'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''d0f58213-7db4-4882-bd15-962163015d13'' AND GUID_Attribute=''0b183be9-c13d-4157-989b-63b0362aeee6'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''d0f58213-7db4-4882-bd15-962163015d13'',''0b183be9-c13d-4157-989b-63b0362aeee6'',1,1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_Attribute=''2e5fd016-c574-4924-b724-d1b30640243a'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''351d4591-2495-4501-82ab-a425f5235db9'',''2e5fd016-c574-4924-b724-d1b30640243a'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_Attribute=''0d2c794d-281d-44ff-9767-eb8549d4ad16'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''351d4591-2495-4501-82ab-a425f5235db9'',''0d2c794d-281d-44ff-9767-eb8549d4ad16'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''83ae48a6-7cdf-4ac7-a635-48494c39f67e'' AND GUID_Type_Right=''83ae48a6-7cdf-4ac7-a635-48494c39f67e'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''83ae48a6-7cdf-4ac7-a635-48494c39f67e'',''83ae48a6-7cdf-4ac7-a635-48494c39f67e'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''83ae48a6-7cdf-4ac7-a635-48494c39f67e'' AND GUID_Type_Right=''d0f58213-7db4-4882-bd15-962163015d13'' AND GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	INSERT INTO semtbl_Type_Type VALUES(''83ae48a6-7cdf-4ac7-a635-48494c39f67e'',''d0f58213-7db4-4882-bd15-962163015d13'',''3e104b75-e01c-48a0-b041-12908fd446a0'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''83ae48a6-7cdf-4ac7-a635-48494c39f67e'' AND GUID_Type_Right=''d84fa125-dbce-44b0-9153-9abeb66ad27f'' AND GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	INSERT INTO semtbl_Type_Type VALUES(''83ae48a6-7cdf-4ac7-a635-48494c39f67e'',''d84fa125-dbce-44b0-9153-9abeb66ad27f'',''3e104b75-e01c-48a0-b041-12908fd446a0'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''83ae48a6-7cdf-4ac7-a635-48494c39f67e'' AND GUID_Type_Right=''35e350f6-cfae-4c87-98bd-dea4831ebaab'' AND GUID_RelationType=''3e104b75-e01c-48a0-b041-12908fd446a0'')=0
	INSERT INTO semtbl_Type_Type VALUES(''83ae48a6-7cdf-4ac7-a635-48494c39f67e'',''35e350f6-cfae-4c87-98bd-dea4831ebaab'',''3e104b75-e01c-48a0-b041-12908fd446a0'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''44e1125d-41c5-418e-b012-5f7f7b8f3063'' AND GUID_Type_Right=''35e350f6-cfae-4c87-98bd-dea4831ebaab'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''44e1125d-41c5-418e-b012-5f7f7b8f3063'',''35e350f6-cfae-4c87-98bd-dea4831ebaab'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''f62cf1cc-ee51-475f-9c00-7094f1809b56'' AND GUID_Type_Right=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	INSERT INTO semtbl_Type_Type VALUES(''f62cf1cc-ee51-475f-9c00-7094f1809b56'',''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''d0f58213-7db4-4882-bd15-962163015d13'' AND GUID_Type_Right=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	INSERT INTO semtbl_Type_Type VALUES(''d0f58213-7db4-4882-bd15-962163015d13'',''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''902b2cd2-0fe6-4f49-92fd-97bcf28e2dad'' AND GUID_Type_Right=''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'' AND GUID_RelationType=''cf27679f-cbe7-4010-a3ae-472072762b33'')=0
	INSERT INTO semtbl_Type_Type VALUES(''902b2cd2-0fe6-4f49-92fd-97bcf28e2dad'',''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'',''cf27679f-cbe7-4010-a3ae-472072762b33'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''902b2cd2-0fe6-4f49-92fd-97bcf28e2dad'' AND GUID_Type_Right=''83ae48a6-7cdf-4ac7-a635-48494c39f67e'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''902b2cd2-0fe6-4f49-92fd-97bcf28e2dad'',''83ae48a6-7cdf-4ac7-a635-48494c39f67e'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''902b2cd2-0fe6-4f49-92fd-97bcf28e2dad'' AND GUID_Type_Right=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_RelationType=''fb8a3635-9532-42ac-9889-9f116abe6c53'')=0
	INSERT INTO semtbl_Type_Type VALUES(''902b2cd2-0fe6-4f49-92fd-97bcf28e2dad'',''351d4591-2495-4501-82ab-a425f5235db9'',''fb8a3635-9532-42ac-9889-9f116abe6c53'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''d84fa125-dbce-44b0-9153-9abeb66ad27f'' AND GUID_Type_Right=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	INSERT INTO semtbl_Type_Type VALUES(''d84fa125-dbce-44b0-9153-9abeb66ad27f'',''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_Type_Right=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''351d4591-2495-4501-82ab-a425f5235db9'',''351d4591-2495-4501-82ab-a425f5235db9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''55e1e943-398d-49a8-a6e6-a573bc6dc740'' AND GUID_Type_Right=''c8e580ed-be06-49a2-8ee8-17e8e0160393'' AND GUID_RelationType=''3126254c-d84e-4f34-82a4-47aeb7be4bda'')=0
	INSERT INTO semtbl_Type_Type VALUES(''55e1e943-398d-49a8-a6e6-a573bc6dc740'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'',''3126254c-d84e-4f34-82a4-47aeb7be4bda'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''55e1e943-398d-49a8-a6e6-a573bc6dc740'' AND GUID_Type_Right=''c8e580ed-be06-49a2-8ee8-17e8e0160393'' AND GUID_RelationType=''62632706-1829-43e4-8034-52c7fd14e353'')=0
	INSERT INTO semtbl_Type_Type VALUES(''55e1e943-398d-49a8-a6e6-a573bc6dc740'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'',''62632706-1829-43e4-8034-52c7fd14e353'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''55e1e943-398d-49a8-a6e6-a573bc6dc740'' AND GUID_Type_Right=''c8e580ed-be06-49a2-8ee8-17e8e0160393'' AND GUID_RelationType=''95ca984f-e8bd-4d54-b56c-d982c2a0b9e7'')=0
	INSERT INTO semtbl_Type_Type VALUES(''55e1e943-398d-49a8-a6e6-a573bc6dc740'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'',''95ca984f-e8bd-4d54-b56c-d982c2a0b9e7'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''55e1e943-398d-49a8-a6e6-a573bc6dc740'' AND GUID_Type_Right=''327e9773-fca6-458c-a44d-338a556e0ad9'' AND GUID_RelationType=''93dd2bd3-791a-4699-80d1-96bb52bdcae5'')=0
	INSERT INTO semtbl_Type_Type VALUES(''55e1e943-398d-49a8-a6e6-a573bc6dc740'',''327e9773-fca6-458c-a44d-338a556e0ad9'',''93dd2bd3-791a-4699-80d1-96bb52bdcae5'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''55e1e943-398d-49a8-a6e6-a573bc6dc740'' AND GUID_Type_Right=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''55e1e943-398d-49a8-a6e6-a573bc6dc740'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''55e1e943-398d-49a8-a6e6-a573bc6dc740'' AND GUID_Type_Right=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_RelationType=''aaf3e012-a822-4ba6-9d9d-d5bb35821757'')=0
	INSERT INTO semtbl_Type_Type VALUES(''55e1e943-398d-49a8-a6e6-a573bc6dc740'',''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''aaf3e012-a822-4ba6-9d9d-d5bb35821757'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_Type_Right=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_RelationType=''7e709649-5791-4116-af93-263864214ffe'')=0
	INSERT INTO semtbl_Type_Type VALUES(''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''7e709649-5791-4116-af93-263864214ffe'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''afe18e83-a290-4660-9e6b-ced83ab2a429'' AND GUID_Type_Right=''44e1125d-41c5-418e-b012-5f7f7b8f3063'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''afe18e83-a290-4660-9e6b-ced83ab2a429'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''afe18e83-a290-4660-9e6b-ced83ab2a429'' AND GUID_Type_Right=''6fd4edc2-0220-405a-9baa-74449b2a2ae6'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''afe18e83-a290-4660-9e6b-ced83ab2a429'',''6fd4edc2-0220-405a-9baa-74449b2a2ae6'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'' AND GUID_RelationType=''cf27679f-cbe7-4010-a3ae-472072762b33'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'',''cf27679f-cbe7-4010-a3ae-472072762b33'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''f47a3e1c-50b4-4666-a41d-e975597c9adb'' AND GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''f47a3e1c-50b4-4666-a41d-e975597c9adb'',''408db9f1-ae42-4807-b656-729270646f0a'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_Type_Right=''8a894710-e08c-42c5-b829-ef4809830d33'' AND GUID_RelationType=''be8c7e8f-9b0b-4adc-8f0b-8f8f1ae47f87'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''8a894710-e08c-42c5-b829-ef4809830d33'',''be8c7e8f-9b0b-4adc-8f0b-8f8f1ae47f87'',0,1,-1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_RelationType=''fb8a3635-9532-42ac-9889-9f116abe6c53'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''351d4591-2495-4501-82ab-a425f5235db9'',''fb8a3635-9532-42ac-9889-9f116abe6c53'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_RelationType=''fb90fea9-586d-4e7b-afd6-e5ccb009268a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''351d4591-2495-4501-82ab-a425f5235db9'',''fb90fea9-586d-4e7b-afd6-e5ccb009268a'',0,-1,-1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''0fa86a85-6a61-4a9a-b158-07930724cc37'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''0fa86a85-6a61-4a9a-b158-07930724cc37'',''9d86d2b2-274b-49c1-83d1-c46dfe73d1ef'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''5394de2e-1eef-4483-bad8-f58ec565e5b3'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''5394de2e-1eef-4483-bad8-f58ec565e5b3'',''39a83777-2b8b-4a76-8beb-b3585ebb0185'',''68ac4472-ee22-4229-96ec-9753a016900a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Varchar255 WHERE GUID_TokenAttribute=''0fa86a85-6a61-4a9a-b158-07930724cc37'' )=0
	INSERT INTO semtbl_Token_Attribute_Varchar255 VALUES(''0fa86a85-6a61-4a9a-b158-07930724cc37'',''HTMLExport_Module'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_VarcharMax WHERE GUID_TokenAttribute=''5394de2e-1eef-4483-bad8-f58ec565e5b3'' )=0
	INSERT INTO semtbl_Token_Attribute_VarcharMax VALUES(''5394de2e-1eef-4483-bad8-f58ec565e5b3'',''<?xml version="1.0" encoding="utf-8"?>
<data>
<![CDATA[<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
       "http://www.w3.org/TR/html4/loose.dtd">]]>
</data>'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''24394f7e-fef6-4857-836c-8ef008917583'')=0
	INSERT INTO semtbl_OR VALUES(''24394f7e-fef6-4857-836c-8ef008917583'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''587776fb-4cdf-4853-9166-5268ff4b48e1'')=0
	INSERT INTO semtbl_OR VALUES(''587776fb-4cdf-4853-9166-5268ff4b48e1'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d9623c14-e859-4c7d-9d62-4a9fb27137d5'')=0
	INSERT INTO semtbl_OR VALUES(''d9623c14-e859-4c7d-9d62-4a9fb27137d5'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'')=0
	INSERT INTO semtbl_OR VALUES(''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''fd2c4ae8-6bf6-456a-914c-8acf5d039664'')=0
	INSERT INTO semtbl_OR VALUES(''fd2c4ae8-6bf6-456a-914c-8acf5d039664'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''a034fd72-33e1-422d-8ab4-7970e7679909'')=0
	INSERT INTO semtbl_OR VALUES(''a034fd72-33e1-422d-8ab4-7970e7679909'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6377566a-0a36-4a70-8d3e-d8098d5f5e94'')=0
	INSERT INTO semtbl_OR VALUES(''6377566a-0a36-4a70-8d3e-d8098d5f5e94'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6d8ef372-f34b-4519-a146-56beb208f6eb'')=0
	INSERT INTO semtbl_OR VALUES(''6d8ef372-f34b-4519-a146-56beb208f6eb'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b4e1d1ee-049e-42a7-baab-98f5a7b17d8e'')=0
	INSERT INTO semtbl_OR VALUES(''b4e1d1ee-049e-42a7-baab-98f5a7b17d8e'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''89f71fbe-53f5-41e2-8bc4-a0bff84bf491'')=0
	INSERT INTO semtbl_OR VALUES(''89f71fbe-53f5-41e2-8bc4-a0bff84bf491'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''98f5d1eb-3a56-4083-a51b-8fa68a184c09'')=0
	INSERT INTO semtbl_OR VALUES(''98f5d1eb-3a56-4083-a51b-8fa68a184c09'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b5a71e14-f203-4da9-b8e4-bd526ab5feba'')=0
	INSERT INTO semtbl_OR VALUES(''b5a71e14-f203-4da9-b8e4-bd526ab5feba'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''82896cf8-3662-463e-b0d4-3bf7ac37b842'')=0
	INSERT INTO semtbl_OR VALUES(''82896cf8-3662-463e-b0d4-3bf7ac37b842'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''2b23bc89-4671-4d05-b8da-01529b3be8a8'')=0
	INSERT INTO semtbl_OR VALUES(''2b23bc89-4671-4d05-b8da-01529b3be8a8'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''04d41d92-3229-44e7-b3b3-5c01e374c163'')=0
	INSERT INTO semtbl_OR VALUES(''04d41d92-3229-44e7-b3b3-5c01e374c163'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''4d75339c-b207-4436-931f-b8e36ad5c772'')=0
	INSERT INTO semtbl_OR VALUES(''4d75339c-b207-4436-931f-b8e36ad5c772'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''2edba852-bbb5-4196-87b2-21f4afe31ddf'')=0
	INSERT INTO semtbl_OR VALUES(''2edba852-bbb5-4196-87b2-21f4afe31ddf'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''54b3756b-7f66-4d69-b923-673f9c83c20f'')=0
	INSERT INTO semtbl_OR VALUES(''54b3756b-7f66-4d69-b923-673f9c83c20f'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''55adf879-1bbb-4f11-acb2-3e094bd3469b'')=0
	INSERT INTO semtbl_OR VALUES(''55adf879-1bbb-4f11-acb2-3e094bd3469b'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ccfc2662-0726-4896-9a13-0f25bcae5f84'')=0
	INSERT INTO semtbl_OR VALUES(''ccfc2662-0726-4896-9a13-0f25bcae5f84'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'')=0
	INSERT INTO semtbl_OR VALUES(''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''797de54b-28a5-4bd7-bb9d-cd212f5cce66'')=0
	INSERT INTO semtbl_OR VALUES(''797de54b-28a5-4bd7-bb9d-cd212f5cce66'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'')=0
	INSERT INTO semtbl_OR VALUES(''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8d26bffc-ae48-4ce9-b594-c911fa60ffe3'')=0
	INSERT INTO semtbl_OR VALUES(''8d26bffc-ae48-4ce9-b594-c911fa60ffe3'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'')=0
	INSERT INTO semtbl_OR VALUES(''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''edda8fb0-7f55-415a-af1a-05b5b63c18cc'')=0
	INSERT INTO semtbl_OR VALUES(''edda8fb0-7f55-415a-af1a-05b5b63c18cc'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''3d0f8295-df50-4235-8174-6b2a4544ee68'')=0
	INSERT INTO semtbl_OR VALUES(''3d0f8295-df50-4235-8174-6b2a4544ee68'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e47fec8c-59fb-4dc7-8f82-ea120a847138'')=0
	INSERT INTO semtbl_OR VALUES(''e47fec8c-59fb-4dc7-8f82-ea120a847138'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ace3520b-ccff-4902-8aca-ba90ae089914'')=0
	INSERT INTO semtbl_OR VALUES(''ace3520b-ccff-4902-8aca-ba90ae089914'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''3d6866ea-1cbf-4874-b0c7-f0df274a399f'')=0
	INSERT INTO semtbl_OR VALUES(''3d6866ea-1cbf-4874-b0c7-f0df274a399f'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'')=0
	INSERT INTO semtbl_OR VALUES(''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''5a9fd517-ef29-4d11-a0b2-ba0924cb8728'')=0
	INSERT INTO semtbl_OR VALUES(''5a9fd517-ef29-4d11-a0b2-ba0924cb8728'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''949df552-05f6-450c-8cc9-775901d1c5df'')=0
	INSERT INTO semtbl_OR VALUES(''949df552-05f6-450c-8cc9-775901d1c5df'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''1b02ff93-e616-4922-bcbb-b33fd9e25566'')=0
	INSERT INTO semtbl_OR VALUES(''1b02ff93-e616-4922-bcbb-b33fd9e25566'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'')=0
	INSERT INTO semtbl_OR VALUES(''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''da288099-4393-4cdf-8203-acd14ced544f'')=0
	INSERT INTO semtbl_OR VALUES(''da288099-4393-4cdf-8203-acd14ced544f'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'')=0
	INSERT INTO semtbl_OR VALUES(''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''205a5e24-3826-4d0b-955d-883b541c7cfe'')=0
	INSERT INTO semtbl_OR VALUES(''205a5e24-3826-4d0b-955d-883b541c7cfe'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''3c1c1069-7064-4e4d-802a-ce6feedb9de9'')=0
	INSERT INTO semtbl_OR VALUES(''3c1c1069-7064-4e4d-802a-ce6feedb9de9'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''dd705e18-780e-4403-8632-1d2ae17a0fb7'')=0
	INSERT INTO semtbl_OR VALUES(''dd705e18-780e-4403-8632-1d2ae17a0fb7'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''71aabfc8-0fc1-40b0-b3a3-ba3d854ab7c7'')=0
	INSERT INTO semtbl_OR VALUES(''71aabfc8-0fc1-40b0-b3a3-ba3d854ab7c7'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''bea331ff-d3df-4ee7-832c-7264931a1e82'')=0
	INSERT INTO semtbl_OR VALUES(''bea331ff-d3df-4ee7-832c-7264931a1e82'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''3a6f0faf-2f8e-43a0-8a7a-e88143c16a5b'')=0
	INSERT INTO semtbl_OR VALUES(''3a6f0faf-2f8e-43a0-8a7a-e88143c16a5b'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e922b0e3-2f9f-4033-a5f2-b592fe9df75a'')=0
	INSERT INTO semtbl_OR VALUES(''e922b0e3-2f9f-4033-a5f2-b592fe9df75a'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d8993a4c-c9d9-4cb1-bf19-5a61efe99eff'')=0
	INSERT INTO semtbl_OR VALUES(''d8993a4c-c9d9-4cb1-bf19-5a61efe99eff'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ecbf4898-09f4-4d14-ab48-c15966e92ff1'')=0
	INSERT INTO semtbl_OR VALUES(''ecbf4898-09f4-4d14-ab48-c15966e92ff1'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ce7fbcb0-6d6f-4e42-8749-b45750e9c889'')=0
	INSERT INTO semtbl_OR VALUES(''ce7fbcb0-6d6f-4e42-8749-b45750e9c889'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''24394f7e-fef6-4857-836c-8ef008917583'')=0
	INSERT INTO semtbl_OR_Type VALUES(''24394f7e-fef6-4857-836c-8ef008917583'',''83ae48a6-7cdf-4ac7-a635-48494c39f67e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'')=0
	INSERT INTO semtbl_OR_Type VALUES(''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''6d8ef372-f34b-4519-a146-56beb208f6eb'')=0
	INSERT INTO semtbl_OR_Type VALUES(''6d8ef372-f34b-4519-a146-56beb208f6eb'',''d84fa125-dbce-44b0-9153-9abeb66ad27f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''b4e1d1ee-049e-42a7-baab-98f5a7b17d8e'')=0
	INSERT INTO semtbl_OR_Type VALUES(''b4e1d1ee-049e-42a7-baab-98f5a7b17d8e'',''55e1e943-398d-49a8-a6e6-a573bc6dc740'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''797de54b-28a5-4bd7-bb9d-cd212f5cce66'')=0
	INSERT INTO semtbl_OR_Type VALUES(''797de54b-28a5-4bd7-bb9d-cd212f5cce66'',''f62cf1cc-ee51-475f-9c00-7094f1809b56'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''3d6866ea-1cbf-4874-b0c7-f0df274a399f'')=0
	INSERT INTO semtbl_OR_Type VALUES(''3d6866ea-1cbf-4874-b0c7-f0df274a399f'',''d0f58213-7db4-4882-bd15-962163015d13'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''949df552-05f6-450c-8cc9-775901d1c5df'')=0
	INSERT INTO semtbl_OR_Type VALUES(''949df552-05f6-450c-8cc9-775901d1c5df'',''f47a3e1c-50b4-4666-a41d-e975597c9adb'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''3c1c1069-7064-4e4d-802a-ce6feedb9de9'')=0
	INSERT INTO semtbl_OR_Type VALUES(''3c1c1069-7064-4e4d-802a-ce6feedb9de9'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''71aabfc8-0fc1-40b0-b3a3-ba3d854ab7c7'')=0
	INSERT INTO semtbl_OR_Type VALUES(''71aabfc8-0fc1-40b0-b3a3-ba3d854ab7c7'',''f30436d6-2ffc-4071-af5e-3ce708b8c2d9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''bea331ff-d3df-4ee7-832c-7264931a1e82'')=0
	INSERT INTO semtbl_OR_Type VALUES(''bea331ff-d3df-4ee7-832c-7264931a1e82'',''afe18e83-a290-4660-9e6b-ced83ab2a429'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''e922b0e3-2f9f-4033-a5f2-b592fe9df75a'')=0
	INSERT INTO semtbl_OR_Type VALUES(''e922b0e3-2f9f-4033-a5f2-b592fe9df75a'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''d8993a4c-c9d9-4cb1-bf19-5a61efe99eff'')=0
	INSERT INTO semtbl_OR_Type VALUES(''d8993a4c-c9d9-4cb1-bf19-5a61efe99eff'',''902b2cd2-0fe6-4f49-92fd-97bcf28e2dad'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''ecbf4898-09f4-4d14-ab48-c15966e92ff1'')=0
	INSERT INTO semtbl_OR_Type VALUES(''ecbf4898-09f4-4d14-ab48-c15966e92ff1'',''351d4591-2495-4501-82ab-a425f5235db9'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''89f71fbe-53f5-41e2-8bc4-a0bff84bf491'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''89f71fbe-53f5-41e2-8bc4-a0bff84bf491'',''aea35976-b4f7-4c1d-b338-92f3f57e84e0'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''b5a71e14-f203-4da9-b8e4-bd526ab5feba'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''b5a71e14-f203-4da9-b8e4-bd526ab5feba'',''68ac4472-ee22-4229-96ec-9753a016900a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''3a6f0faf-2f8e-43a0-8a7a-e88143c16a5b'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''3a6f0faf-2f8e-43a0-8a7a-e88143c16a5b'',''f816b8da-bd8b-4bce-965f-306d7a186287'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''d9623c14-e859-4c7d-9d62-4a9fb27137d5'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''d9623c14-e859-4c7d-9d62-4a9fb27137d5'',''fb8a3635-9532-42ac-9889-9f116abe6c53'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''a034fd72-33e1-422d-8ab4-7970e7679909'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''a034fd72-33e1-422d-8ab4-7970e7679909'',''be8c7e8f-9b0b-4adc-8f0b-8f8f1ae47f87'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''6377566a-0a36-4a70-8d3e-d8098d5f5e94'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''6377566a-0a36-4a70-8d3e-d8098d5f5e94'',''62632706-1829-43e4-8034-52c7fd14e353'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''98f5d1eb-3a56-4083-a51b-8fa68a184c09'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''98f5d1eb-3a56-4083-a51b-8fa68a184c09'',''3e104b75-e01c-48a0-b041-12908fd446a0'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''04d41d92-3229-44e7-b3b3-5c01e374c163'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''04d41d92-3229-44e7-b3b3-5c01e374c163'',''3126254c-d84e-4f34-82a4-47aeb7be4bda'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''4d75339c-b207-4436-931f-b8e36ad5c772'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''4d75339c-b207-4436-931f-b8e36ad5c772'',''95ca984f-e8bd-4d54-b56c-d982c2a0b9e7'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''e9711603-47db-44d8-a476-fe88290639a4'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'',''cf27679f-cbe7-4010-a3ae-472072762b33'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''8d26bffc-ae48-4ce9-b594-c911fa60ffe3'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''8d26bffc-ae48-4ce9-b594-c911fa60ffe3'',''aaf3e012-a822-4ba6-9d9d-d5bb35821757'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''e07469d9-766c-443e-8526-6d9c684f944f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''da288099-4393-4cdf-8203-acd14ced544f'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''da288099-4393-4cdf-8203-acd14ced544f'',''93dd2bd3-791a-4699-80d1-96bb52bdcae5'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''ce7fbcb0-6d6f-4e42-8749-b45750e9c889'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''ce7fbcb0-6d6f-4e42-8749-b45750e9c889'',''f68a9438-fb8b-418d-8e0b-d9aefc9ecdf3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''587776fb-4cdf-4853-9166-5268ff4b48e1'')=0
	INSERT INTO semtbl_OR_Token VALUES(''587776fb-4cdf-4853-9166-5268ff4b48e1'',''4b0874f0-f9ff-489c-82e7-4181e96ffe88'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''fd2c4ae8-6bf6-456a-914c-8acf5d039664'')=0
	INSERT INTO semtbl_OR_Token VALUES(''fd2c4ae8-6bf6-456a-914c-8acf5d039664'',''738496bc-3d39-4592-ae4c-da4644b0542c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''82896cf8-3662-463e-b0d4-3bf7ac37b842'')=0
	INSERT INTO semtbl_OR_Token VALUES(''82896cf8-3662-463e-b0d4-3bf7ac37b842'',''540cb05f-659d-432c-bcc0-7edaf389d77f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''2b23bc89-4671-4d05-b8da-01529b3be8a8'')=0
	INSERT INTO semtbl_OR_Token VALUES(''2b23bc89-4671-4d05-b8da-01529b3be8a8'',''c9da3392-212e-46af-a3e1-79716e15ed1a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''2edba852-bbb5-4196-87b2-21f4afe31ddf'')=0
	INSERT INTO semtbl_OR_Token VALUES(''2edba852-bbb5-4196-87b2-21f4afe31ddf'',''451c1498-bcc7-492b-9399-a01464d35186'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''54b3756b-7f66-4d69-b923-673f9c83c20f'')=0
	INSERT INTO semtbl_OR_Token VALUES(''54b3756b-7f66-4d69-b923-673f9c83c20f'',''cd2f9d05-5faa-4ec8-b052-4e665b4c6dfb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''55adf879-1bbb-4f11-acb2-3e094bd3469b'')=0
	INSERT INTO semtbl_OR_Token VALUES(''55adf879-1bbb-4f11-acb2-3e094bd3469b'',''1b4f8484-85d4-4f80-8541-b3cc67e6a43f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''ccfc2662-0726-4896-9a13-0f25bcae5f84'')=0
	INSERT INTO semtbl_OR_Token VALUES(''ccfc2662-0726-4896-9a13-0f25bcae5f84'',''d545b18f-3f07-411e-92c5-c0695126eab3'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''edda8fb0-7f55-415a-af1a-05b5b63c18cc'')=0
	INSERT INTO semtbl_OR_Token VALUES(''edda8fb0-7f55-415a-af1a-05b5b63c18cc'',''a7403d39-150e-4f3a-9d2c-6870c2c00389'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''3d0f8295-df50-4235-8174-6b2a4544ee68'')=0
	INSERT INTO semtbl_OR_Token VALUES(''3d0f8295-df50-4235-8174-6b2a4544ee68'',''1f2af1f4-936e-4cec-898c-a89c66131d6f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''e47fec8c-59fb-4dc7-8f82-ea120a847138'')=0
	INSERT INTO semtbl_OR_Token VALUES(''e47fec8c-59fb-4dc7-8f82-ea120a847138'',''e2d4e55d-d5e1-4892-b54e-b8c1e21e54e2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''ace3520b-ccff-4902-8aca-ba90ae089914'')=0
	INSERT INTO semtbl_OR_Token VALUES(''ace3520b-ccff-4902-8aca-ba90ae089914'',''39a83777-2b8b-4a76-8beb-b3585ebb0185'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''5a9fd517-ef29-4d11-a0b2-ba0924cb8728'')=0
	INSERT INTO semtbl_OR_Token VALUES(''5a9fd517-ef29-4d11-a0b2-ba0924cb8728'',''77a523f0-5658-4012-bd28-b0237607ddbd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''205a5e24-3826-4d0b-955d-883b541c7cfe'')=0
	INSERT INTO semtbl_OR_Token VALUES(''205a5e24-3826-4d0b-955d-883b541c7cfe'',''5bc7672e-3f5b-4665-b491-b7d23410c9e8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''dd705e18-780e-4403-8632-1d2ae17a0fb7'')=0
	INSERT INTO semtbl_OR_Token VALUES(''dd705e18-780e-4403-8632-1d2ae17a0fb7'',''326a9d6d-da29-4b5e-802f-da420e4b55a0'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''91061953-fa7f-4742-9c97-00472d7e5dfe'' AND GUID_ObjectReference=''24394f7e-fef6-4857-836c-8ef008917583'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''91061953-fa7f-4742-9c97-00472d7e5dfe'',''24394f7e-fef6-4857-836c-8ef008917583'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''50440d4b-c144-48ac-970e-04b22c9a7784'' AND GUID_ObjectReference=''587776fb-4cdf-4853-9166-5268ff4b48e1'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''50440d4b-c144-48ac-970e-04b22c9a7784'',''587776fb-4cdf-4853-9166-5268ff4b48e1'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d646c103-0f93-4646-ad96-071ac603992b'' AND GUID_ObjectReference=''d9623c14-e859-4c7d-9d62-4a9fb27137d5'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d646c103-0f93-4646-ad96-071ac603992b'',''d9623c14-e859-4c7d-9d62-4a9fb27137d5'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'' AND GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''1fafd5db-5c3c-4012-affd-134ae1ef990f'' AND GUID_ObjectReference=''fd2c4ae8-6bf6-456a-914c-8acf5d039664'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''1fafd5db-5c3c-4012-affd-134ae1ef990f'',''fd2c4ae8-6bf6-456a-914c-8acf5d039664'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''c1581f8a-3661-4512-94de-148eb8bbb784'' AND GUID_ObjectReference=''a034fd72-33e1-422d-8ab4-7970e7679909'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''c1581f8a-3661-4512-94de-148eb8bbb784'',''a034fd72-33e1-422d-8ab4-7970e7679909'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''764e1872-78cc-48b7-b6dd-1808f7699c0c'' AND GUID_ObjectReference=''6377566a-0a36-4a70-8d3e-d8098d5f5e94'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''764e1872-78cc-48b7-b6dd-1808f7699c0c'',''6377566a-0a36-4a70-8d3e-d8098d5f5e94'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b53826c1-bddc-4fc2-a922-180c32ea7207'' AND GUID_ObjectReference=''6d8ef372-f34b-4519-a146-56beb208f6eb'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b53826c1-bddc-4fc2-a922-180c32ea7207'',''6d8ef372-f34b-4519-a146-56beb208f6eb'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d7a0c520-e098-426f-928f-24e05314631b'' AND GUID_ObjectReference=''b4e1d1ee-049e-42a7-baab-98f5a7b17d8e'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d7a0c520-e098-426f-928f-24e05314631b'',''b4e1d1ee-049e-42a7-baab-98f5a7b17d8e'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''bd416afc-f709-4bc6-9708-36f65be3a697'' AND GUID_ObjectReference=''89f71fbe-53f5-41e2-8bc4-a0bff84bf491'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''bd416afc-f709-4bc6-9708-36f65be3a697'',''89f71fbe-53f5-41e2-8bc4-a0bff84bf491'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''747952da-2e66-49c1-8462-3a20addbc0ef'' AND GUID_ObjectReference=''98f5d1eb-3a56-4083-a51b-8fa68a184c09'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''747952da-2e66-49c1-8462-3a20addbc0ef'',''98f5d1eb-3a56-4083-a51b-8fa68a184c09'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'' AND GUID_ObjectReference=''b5a71e14-f203-4da9-b8e4-bd526ab5feba'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b6810c64-4c5a-4ef8-aa8f-3f0255fd950a'',''b5a71e14-f203-4da9-b8e4-bd526ab5feba'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b1b184d4-47df-4153-b2dd-4076b221cb85'' AND GUID_ObjectReference=''82896cf8-3662-463e-b0d4-3bf7ac37b842'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b1b184d4-47df-4153-b2dd-4076b221cb85'',''82896cf8-3662-463e-b0d4-3bf7ac37b842'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''5ec1507f-8df9-41ad-9f2a-4452fd87307c'' AND GUID_ObjectReference=''2b23bc89-4671-4d05-b8da-01529b3be8a8'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''5ec1507f-8df9-41ad-9f2a-4452fd87307c'',''2b23bc89-4671-4d05-b8da-01529b3be8a8'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''9fc39c5e-112e-4076-9418-476b4c59edce'' AND GUID_ObjectReference=''04d41d92-3229-44e7-b3b3-5c01e374c163'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''9fc39c5e-112e-4076-9418-476b4c59edce'',''04d41d92-3229-44e7-b3b3-5c01e374c163'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ea2bc0e5-c2b0-49a3-8ec8-497468bb67bb'' AND GUID_ObjectReference=''4d75339c-b207-4436-931f-b8e36ad5c772'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ea2bc0e5-c2b0-49a3-8ec8-497468bb67bb'',''4d75339c-b207-4436-931f-b8e36ad5c772'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''5e3ec8de-704f-44a3-bbcd-49eabc97bb4d'' AND GUID_ObjectReference=''2edba852-bbb5-4196-87b2-21f4afe31ddf'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''5e3ec8de-704f-44a3-bbcd-49eabc97bb4d'',''2edba852-bbb5-4196-87b2-21f4afe31ddf'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''58c919ca-98d3-497b-bb00-4ae2d5391d27'' AND GUID_ObjectReference=''54b3756b-7f66-4d69-b923-673f9c83c20f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''58c919ca-98d3-497b-bb00-4ae2d5391d27'',''54b3756b-7f66-4d69-b923-673f9c83c20f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e3207993-b7f1-44bc-959e-530153e2f84d'' AND GUID_ObjectReference=''55adf879-1bbb-4f11-acb2-3e094bd3469b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e3207993-b7f1-44bc-959e-530153e2f84d'',''55adf879-1bbb-4f11-acb2-3e094bd3469b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''53a9ae75-7493-4fe2-b0f0-5c9aac78b1e2'' AND GUID_ObjectReference=''ccfc2662-0726-4896-9a13-0f25bcae5f84'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''53a9ae75-7493-4fe2-b0f0-5c9aac78b1e2'',''ccfc2662-0726-4896-9a13-0f25bcae5f84'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6c966e3c-c737-4af1-9970-68c8323679bc'' AND GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6c966e3c-c737-4af1-9970-68c8323679bc'',''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''565ccbae-718f-4b3d-bd06-6a1906653220'' AND GUID_ObjectReference=''797de54b-28a5-4bd7-bb9d-cd212f5cce66'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''565ccbae-718f-4b3d-bd06-6a1906653220'',''797de54b-28a5-4bd7-bb9d-cd212f5cce66'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8e96640d-b873-4a50-b272-6b1376b26852'' AND GUID_ObjectReference=''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8e96640d-b873-4a50-b272-6b1376b26852'',''6e49b60e-ad60-48b5-8f3b-84dbb13dc5d3'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e3d4516d-4f74-44ff-8472-6c2f016d457e'' AND GUID_ObjectReference=''8d26bffc-ae48-4ce9-b594-c911fa60ffe3'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e3d4516d-4f74-44ff-8472-6c2f016d457e'',''8d26bffc-ae48-4ce9-b594-c911fa60ffe3'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f2cde058-614e-41cb-96eb-78bbcf285171'' AND GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f2cde058-614e-41cb-96eb-78bbcf285171'',''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''cf987b9c-6671-4a93-b851-7b39935fe8f4'' AND GUID_ObjectReference=''edda8fb0-7f55-415a-af1a-05b5b63c18cc'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''cf987b9c-6671-4a93-b851-7b39935fe8f4'',''edda8fb0-7f55-415a-af1a-05b5b63c18cc'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''cbba043e-2016-4b53-9d35-8862cde34047'' AND GUID_ObjectReference=''3d0f8295-df50-4235-8174-6b2a4544ee68'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''cbba043e-2016-4b53-9d35-8862cde34047'',''3d0f8295-df50-4235-8174-6b2a4544ee68'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''58fb3207-e0a1-4ec4-9653-8c29360d6d0c'' AND GUID_ObjectReference=''e47fec8c-59fb-4dc7-8f82-ea120a847138'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''58fb3207-e0a1-4ec4-9653-8c29360d6d0c'',''e47fec8c-59fb-4dc7-8f82-ea120a847138'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''663149f2-6645-4151-beb0-a24fdea6eb2b'' AND GUID_ObjectReference=''ace3520b-ccff-4902-8aca-ba90ae089914'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''663149f2-6645-4151-beb0-a24fdea6eb2b'',''ace3520b-ccff-4902-8aca-ba90ae089914'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f936827c-e5b9-41aa-a897-a462d0bc2d72'' AND GUID_ObjectReference=''3d6866ea-1cbf-4874-b0c7-f0df274a399f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f936827c-e5b9-41aa-a897-a462d0bc2d72'',''3d6866ea-1cbf-4874-b0c7-f0df274a399f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''aa5f0ec8-e754-4cf8-bc0a-a8ca94c38ec9'' AND GUID_ObjectReference=''5a9fd517-ef29-4d11-a0b2-ba0924cb8728'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''aa5f0ec8-e754-4cf8-bc0a-a8ca94c38ec9'',''5a9fd517-ef29-4d11-a0b2-ba0924cb8728'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''923108a1-c159-4d69-affe-ae048460dd24'' AND GUID_ObjectReference=''949df552-05f6-450c-8cc9-775901d1c5df'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''923108a1-c159-4d69-affe-ae048460dd24'',''949df552-05f6-450c-8cc9-775901d1c5df'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''cfba621b-5774-445b-8749-af12bb8bb472'' AND GUID_ObjectReference=''1b02ff93-e616-4922-bcbb-b33fd9e25566'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''cfba621b-5774-445b-8749-af12bb8bb472'',''1b02ff93-e616-4922-bcbb-b33fd9e25566'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8a6a3874-7e7b-4c41-b43a-b0349e39113b'' AND GUID_ObjectReference=''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8a6a3874-7e7b-4c41-b43a-b0349e39113b'',''97f0c149-423b-49b4-9aa2-06f7bf3d08a3'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d8a843bb-d595-418a-b7ec-b23cd6c8782c'' AND GUID_ObjectReference=''da288099-4393-4cdf-8203-acd14ced544f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d8a843bb-d595-418a-b7ec-b23cd6c8782c'',''da288099-4393-4cdf-8203-acd14ced544f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f1ba23ed-ab41-4d34-8e09-b4e485671478'' AND GUID_ObjectReference=''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f1ba23ed-ab41-4d34-8e09-b4e485671478'',''b8c40077-93a3-47a8-bceb-ae54ffdeaa53'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e9701def-6569-4d2b-8fe9-b4f75ae4f0ca'' AND GUID_ObjectReference=''205a5e24-3826-4d0b-955d-883b541c7cfe'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e9701def-6569-4d2b-8fe9-b4f75ae4f0ca'',''205a5e24-3826-4d0b-955d-883b541c7cfe'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''40443821-c238-4ac1-b9c3-bce0ae4cbdb8'' AND GUID_ObjectReference=''3c1c1069-7064-4e4d-802a-ce6feedb9de9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''40443821-c238-4ac1-b9c3-bce0ae4cbdb8'',''3c1c1069-7064-4e4d-802a-ce6feedb9de9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''611e9e48-bc64-47a6-8fc5-bf859edd985c'' AND GUID_ObjectReference=''dd705e18-780e-4403-8632-1d2ae17a0fb7'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''611e9e48-bc64-47a6-8fc5-bf859edd985c'',''dd705e18-780e-4403-8632-1d2ae17a0fb7'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''4ce41b7a-2fb9-4df6-b67a-c5aca2e46da1'' AND GUID_ObjectReference=''71aabfc8-0fc1-40b0-b3a3-ba3d854ab7c7'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''4ce41b7a-2fb9-4df6-b67a-c5aca2e46da1'',''71aabfc8-0fc1-40b0-b3a3-ba3d854ab7c7'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''da616527-550c-4925-8a26-d4ddf1859c85'' AND GUID_ObjectReference=''bea331ff-d3df-4ee7-832c-7264931a1e82'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''da616527-550c-4925-8a26-d4ddf1859c85'',''bea331ff-d3df-4ee7-832c-7264931a1e82'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''952e8e12-3054-4113-bf5c-d627f9e4f283'' AND GUID_ObjectReference=''3a6f0faf-2f8e-43a0-8a7a-e88143c16a5b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''952e8e12-3054-4113-bf5c-d627f9e4f283'',''3a6f0faf-2f8e-43a0-8a7a-e88143c16a5b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''10204d0e-05fd-4c68-99c3-d6657f2cb8a2'' AND GUID_ObjectReference=''e922b0e3-2f9f-4033-a5f2-b592fe9df75a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''10204d0e-05fd-4c68-99c3-d6657f2cb8a2'',''e922b0e3-2f9f-4033-a5f2-b592fe9df75a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b7912802-9994-4019-bb41-dc2bc766c505'' AND GUID_ObjectReference=''d8993a4c-c9d9-4cb1-bf19-5a61efe99eff'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b7912802-9994-4019-bb41-dc2bc766c505'',''d8993a4c-c9d9-4cb1-bf19-5a61efe99eff'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''470abd26-c317-4625-91a7-e9828b751893'' AND GUID_ObjectReference=''ecbf4898-09f4-4d14-ab48-c15966e92ff1'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''470abd26-c317-4625-91a7-e9828b751893'',''ecbf4898-09f4-4d14-ab48-c15966e92ff1'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f8986792-3dbf-4a6b-a1a3-f763086d06d4'' AND GUID_ObjectReference=''ce7fbcb0-6d6f-4e42-8749-b45750e9c889'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f8986792-3dbf-4a6b-a1a3-f763086d06d4'',''ce7fbcb0-6d6f-4e42-8749-b45750e9c889'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''13c09f11-175c-4eef-bc8a-0fd8e86d557f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''13c09f11-175c-4eef-bc8a-0fd8e86d557f'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''83ae48a6-7cdf-4ac7-a635-48494c39f67e'' AND GUID_RelationType=''f68a9438-fb8b-418d-8e0b-d9aefc9ecdf3'')=0
	INSERT INTO semtbl_Type_OR VALUES(''83ae48a6-7cdf-4ac7-a635-48494c39f67e'',''f68a9438-fb8b-418d-8e0b-d9aefc9ecdf3'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''d84fa125-dbce-44b0-9153-9abeb66ad27f'' AND GUID_RelationType=''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'')=0
	INSERT INTO semtbl_Type_OR VALUES(''d84fa125-dbce-44b0-9153-9abeb66ad27f'',''d34d545e-9ddf-46ce-bb6f-22db1b7bb025'',1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''f62cf1cc-ee51-475f-9c00-7094f1809b56'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''f62cf1cc-ee51-475f-9c00-7094f1809b56'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''d0f58213-7db4-4882-bd15-962163015d13'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''d0f58213-7db4-4882-bd15-962163015d13'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''6eb4fdd3-2e25-4886-b288-e1bfc2857efb'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''351d4591-2495-4501-82ab-a425f5235db9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1)'
GO
