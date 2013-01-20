use [sem_db_work]
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''aea35976-b4f7-4c1d-b338-92f3f57e84e0'') = 0
	insert into semtbl_Attribute VALUES(''aea35976-b4f7-4c1d-b338-92f3f57e84e0'',''Level'',''3a4f5b7b-da75-4980-933e-fbc33cc51439'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''68ac4472-ee22-4229-96ec-9753a016900a'') = 0
	insert into semtbl_Attribute VALUES(''68ac4472-ee22-4229-96ec-9753a016900a'',''XML-Text'',''64530b52-d96c-4df1-86fe-183f44513450'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='73e32abf-e577-4d31-9a46-bc07e9e15de3') = 0
	insert into semtbl_Type VALUES('73e32abf-e577-4d31-9a46-bc07e9e15de3','Software-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='71415eeb-ce46-4b2c-b0a2-f72116b55438') = 0
	insert into semtbl_Type VALUES('71415eeb-ce46-4b2c-b0a2-f72116b55438','Software-Development','73e32abf-e577-4d31-9a46-bc07e9e15de3')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='f30436d6-2ffc-4071-af5e-3ce708b8c2d9') = 0
	insert into semtbl_Type VALUES('f30436d6-2ffc-4071-af5e-3ce708b8c2d9','Development-Version','71415eeb-ce46-4b2c-b0a2-f72116b55438')
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''61cb4137-17c5-48ba-bc5c-453cc844c498'') = 0
	insert into semtbl_Token VALUES(''61cb4137-17c5-48ba-bc5c-453cc844c498'','' '',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''320cf0bd-f7ad-46eb-94e8-45b316005879'') = 0
	insert into semtbl_Token VALUES(''320cf0bd-f7ad-46eb-94e8-45b316005879'','''''',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''862d0c08-bc8f-43f7-92e6-c06a0a350eb6'') = 0
	insert into semtbl_Token VALUES(''862d0c08-bc8f-43f7-92e6-c06a0a350eb6'',''-'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''24127395-9fd2-40b1-ba6b-b37014936546'') = 0
	insert into semtbl_Token VALUES(''24127395-9fd2-40b1-ba6b-b37014936546'',''­'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fbce0cad-a537-4fcb-bf1a-25011ed1d56f'') = 0
	insert into semtbl_Token VALUES(''fbce0cad-a537-4fcb-bf1a-25011ed1d56f'',''–'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2aa78e8e-ee83-4d52-b726-0720a439d97e'') = 0
	insert into semtbl_Token VALUES(''2aa78e8e-ee83-4d52-b726-0720a439d97e'',''—'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6a4d3a99-9e27-47b7-a3cb-6d707108f050'') = 0
	insert into semtbl_Token VALUES(''6a4d3a99-9e27-47b7-a3cb-6d707108f050'',''!'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a0ae1b6e-a7c7-4528-b7dd-48bcbe253d0b'') = 0
	insert into semtbl_Token VALUES(''a0ae1b6e-a7c7-4528-b7dd-48bcbe253d0b'',''"'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''aed29d82-cc16-4346-80d8-2b6c44b13a30'') = 0
	insert into semtbl_Token VALUES(''aed29d82-cc16-4346-80d8-2b6c44b13a30'',''#'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''60b26b88-ce2a-4702-9f9d-274dddc9bb26'') = 0
	insert into semtbl_Token VALUES(''60b26b88-ce2a-4702-9f9d-274dddc9bb26'',''$'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''300e6342-760f-43d0-b284-b43ffb2d0ac8'') = 0
	insert into semtbl_Token VALUES(''300e6342-760f-43d0-b284-b43ffb2d0ac8'',''%'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''dd624f01-68a9-433a-8752-059a9cbc099d'') = 0
	insert into semtbl_Token VALUES(''dd624f01-68a9-433a-8752-059a9cbc099d'',''&'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''125ef66f-0506-43be-8e39-6951decb19e0'') = 0
	insert into semtbl_Token VALUES(''125ef66f-0506-43be-8e39-6951decb19e0'',''('',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''60061a43-a7c6-4948-8605-2199007fc0e7'') = 0
	insert into semtbl_Token VALUES(''60061a43-a7c6-4948-8605-2199007fc0e7'','')'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c6b481fb-ce75-4343-bae3-629c6901baf3'') = 0
	insert into semtbl_Token VALUES(''c6b481fb-ce75-4343-bae3-629c6901baf3'',''*'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4045a66d-3d48-4dd0-8cb5-a08056b7696d'') = 0
	insert into semtbl_Token VALUES(''4045a66d-3d48-4dd0-8cb5-a08056b7696d'','','',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''46eb9f52-c886-44ca-9a59-703fe6a542c7'') = 0
	insert into semtbl_Token VALUES(''46eb9f52-c886-44ca-9a59-703fe6a542c7'',''.'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0c921230-e08d-4a3d-a87d-730c5ff285b3'') = 0
	insert into semtbl_Token VALUES(''0c921230-e08d-4a3d-a87d-730c5ff285b3'',''/'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2263b3ce-886f-4af7-8ae9-242d6a07dc91'') = 0
	insert into semtbl_Token VALUES(''2263b3ce-886f-4af7-8ae9-242d6a07dc91'','':'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''35e3f814-adff-45ea-b96f-2005f5bf6de9'') = 0
	insert into semtbl_Token VALUES(''35e3f814-adff-45ea-b96f-2005f5bf6de9'','';'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''16b6a1e8-2c79-489d-8471-816ffbdfac8d'') = 0
	insert into semtbl_Token VALUES(''16b6a1e8-2c79-489d-8471-816ffbdfac8d'',''?'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''31b3c405-97df-4142-a3f0-3611ce15687e'') = 0
	insert into semtbl_Token VALUES(''31b3c405-97df-4142-a3f0-3611ce15687e'',''@'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''77f399bd-ffd5-40c8-8865-721e042cc0d8'') = 0
	insert into semtbl_Token VALUES(''77f399bd-ffd5-40c8-8865-721e042cc0d8'',''['',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''94b34e22-db97-4f90-aae4-12e06f9dd602'') = 0
	insert into semtbl_Token VALUES(''94b34e22-db97-4f90-aae4-12e06f9dd602'',''\'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ddaf57bd-59cc-4dd2-98bc-e2f898344d08'') = 0
	insert into semtbl_Token VALUES(''ddaf57bd-59cc-4dd2-98bc-e2f898344d08'','']'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2a2b6e2d-b5a2-44fd-9321-042eeff599e9'') = 0
	insert into semtbl_Token VALUES(''2a2b6e2d-b5a2-44fd-9321-042eeff599e9'',''^'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b4bfb274-4e27-4074-b1e9-f13cbe6d20cb'') = 0
	insert into semtbl_Token VALUES(''b4bfb274-4e27-4074-b1e9-f13cbe6d20cb'',''ˆ'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a4c0a7f6-5cc9-4d8e-883c-ea32e1dd4bcb'') = 0
	insert into semtbl_Token VALUES(''a4c0a7f6-5cc9-4d8e-883c-ea32e1dd4bcb'',''_'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7087db8f-3b69-451a-bc09-1e320893d937'') = 0
	insert into semtbl_Token VALUES(''7087db8f-3b69-451a-bc09-1e320893d937'',''`'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''891a450e-10e4-4c7e-910f-7ab0a4ba672e'') = 0
	insert into semtbl_Token VALUES(''891a450e-10e4-4c7e-910f-7ab0a4ba672e'',''{'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8572cc87-77c7-4bce-9cad-79f456c1c798'') = 0
	insert into semtbl_Token VALUES(''8572cc87-77c7-4bce-9cad-79f456c1c798'',''|'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''941f9560-e2e5-4909-bc2c-991761300a9d'') = 0
	insert into semtbl_Token VALUES(''941f9560-e2e5-4909-bc2c-991761300a9d'',''}'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4a8461b3-5d4f-4f31-b02e-ea40f21e0bae'') = 0
	insert into semtbl_Token VALUES(''4a8461b3-5d4f-4f31-b02e-ea40f21e0bae'',''~'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b7abba5d-3184-4a96-af71-00afae30af45'') = 0
	insert into semtbl_Token VALUES(''b7abba5d-3184-4a96-af71-00afae30af45'',''¡'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c38dcfcb-b948-416d-a1f7-a2132c3c471d'') = 0
	insert into semtbl_Token VALUES(''c38dcfcb-b948-416d-a1f7-a2132c3c471d'',''¦'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b5540c05-ac85-48ea-94ec-b03a4259ef5c'') = 0
	insert into semtbl_Token VALUES(''b5540c05-ac85-48ea-94ec-b03a4259ef5c'',''¨'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fc90be7f-8e87-4d2e-a572-a8c6cccfe41b'') = 0
	insert into semtbl_Token VALUES(''fc90be7f-8e87-4d2e-a572-a8c6cccfe41b'',''¯'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4e4b1fbe-75f9-45f7-a212-15e0c0b30ef4'') = 0
	insert into semtbl_Token VALUES(''4e4b1fbe-75f9-45f7-a212-15e0c0b30ef4'',''´'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''21864528-f0c2-44e4-b142-56634e1a8ce9'') = 0
	insert into semtbl_Token VALUES(''21864528-f0c2-44e4-b142-56634e1a8ce9'',''¸'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''86e0e1c1-b312-4206-a963-5339391583f8'') = 0
	insert into semtbl_Token VALUES(''86e0e1c1-b312-4206-a963-5339391583f8'',''¿'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bef84884-fe14-4747-83c7-b7db20c6b87f'') = 0
	insert into semtbl_Token VALUES(''bef84884-fe14-4747-83c7-b7db20c6b87f'',''’'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c3fc2a4b-bd3c-44d7-8e85-e6b318c470a5'') = 0
	insert into semtbl_Token VALUES(''c3fc2a4b-bd3c-44d7-8e85-e6b318c470a5'',''‚'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''18072a28-c4bd-44a7-96aa-43034fa88beb'') = 0
	insert into semtbl_Token VALUES(''18072a28-c4bd-44a7-96aa-43034fa88beb'',''“'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cfd8bd46-9078-4479-a661-41b6752a5f9e'') = 0
	insert into semtbl_Token VALUES(''cfd8bd46-9078-4479-a661-41b6752a5f9e'',''”'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''026df50a-6df9-4ffa-9a25-6708ec963689'') = 0
	insert into semtbl_Token VALUES(''026df50a-6df9-4ffa-9a25-6708ec963689'',''„'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5487e633-62c0-4163-b882-1f08daef061a'') = 0
	insert into semtbl_Token VALUES(''5487e633-62c0-4163-b882-1f08daef061a'',''‹'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7eadc3de-e302-4e92-89c8-28c8750c9f0e'') = 0
	insert into semtbl_Token VALUES(''7eadc3de-e302-4e92-89c8-28c8750c9f0e'',''›'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''53723a43-867b-4c37-b67d-9d111ab502f5'') = 0
	insert into semtbl_Token VALUES(''53723a43-867b-4c37-b67d-9d111ab502f5'',''+'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f0fe0294-7042-42f2-96ff-5429d34a04fc'') = 0
	insert into semtbl_Token VALUES(''f0fe0294-7042-42f2-96ff-5429d34a04fc'',''<'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0a934ffb-e5ee-4c21-82f0-6c11b8098de8'') = 0
	insert into semtbl_Token VALUES(''0a934ffb-e5ee-4c21-82f0-6c11b8098de8'',''='',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b994302e-3ddd-4603-8685-7bfb28fe2b51'') = 0
	insert into semtbl_Token VALUES(''b994302e-3ddd-4603-8685-7bfb28fe2b51'',''>'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''90b37ecf-a62e-43b4-b540-d1da3c87c498'') = 0
	insert into semtbl_Token VALUES(''90b37ecf-a62e-43b4-b540-d1da3c87c498'',''±'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f9eefce6-c0a5-433e-a9ae-2eec8cffcbf5'') = 0
	insert into semtbl_Token VALUES(''f9eefce6-c0a5-433e-a9ae-2eec8cffcbf5'',''«'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f370872d-75a7-4b4c-a22f-5eb4271b08e7'') = 0
	insert into semtbl_Token VALUES(''f370872d-75a7-4b4c-a22f-5eb4271b08e7'',''»'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''39dd91bc-412f-47aa-a6b8-658b35b60160'') = 0
	insert into semtbl_Token VALUES(''39dd91bc-412f-47aa-a6b8-658b35b60160'',''×'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ec8484fe-05d1-4817-8cfb-ce057645eff7'') = 0
	insert into semtbl_Token VALUES(''ec8484fe-05d1-4817-8cfb-ce057645eff7'',''÷'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''52cd28d0-8ffc-4c4a-81c4-b8ff14b7a713'') = 0
	insert into semtbl_Token VALUES(''52cd28d0-8ffc-4c4a-81c4-b8ff14b7a713'',''¢'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''50e65f5d-2214-41fd-b27e-144c7b1c2567'') = 0
	insert into semtbl_Token VALUES(''50e65f5d-2214-41fd-b27e-144c7b1c2567'',''£'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''90c488e5-1fb4-45e8-85cc-30fb8a3402bf'') = 0
	insert into semtbl_Token VALUES(''90c488e5-1fb4-45e8-85cc-30fb8a3402bf'',''¤'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9a036619-c05b-4571-9b64-df422bbd0eb8'') = 0
	insert into semtbl_Token VALUES(''9a036619-c05b-4571-9b64-df422bbd0eb8'',''¥'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''82981392-5306-4685-a77d-697db2126919'') = 0
	insert into semtbl_Token VALUES(''82981392-5306-4685-a77d-697db2126919'',''§'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cf5c902c-a8b3-482e-bc74-827631310511'') = 0
	insert into semtbl_Token VALUES(''cf5c902c-a8b3-482e-bc74-827631310511'',''©'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f20af911-a470-4e88-bc14-401888e55b5e'') = 0
	insert into semtbl_Token VALUES(''f20af911-a470-4e88-bc14-401888e55b5e'',''¬'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a7c4904b-a99f-448e-9798-b9c2e9ec682f'') = 0
	insert into semtbl_Token VALUES(''a7c4904b-a99f-448e-9798-b9c2e9ec682f'',''®'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d5f18e42-005e-44b8-ad3f-bbe2a6c7d3f5'') = 0
	insert into semtbl_Token VALUES(''d5f18e42-005e-44b8-ad3f-bbe2a6c7d3f5'',''°'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a7329811-6d0f-4f26-ac36-cedd71ada8c3'') = 0
	insert into semtbl_Token VALUES(''a7329811-6d0f-4f26-ac36-cedd71ada8c3'',''µ'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c7a585d4-7191-4a52-9002-7843841274da'') = 0
	insert into semtbl_Token VALUES(''c7a585d4-7191-4a52-9002-7843841274da'',''¶'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e5ae4579-3e37-463b-9c57-c0d3a084a54c'') = 0
	insert into semtbl_Token VALUES(''e5ae4579-3e37-463b-9c57-c0d3a084a54c'',''·'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b6472cf1-692f-42ae-8f77-ab8e42c9e5be'') = 0
	insert into semtbl_Token VALUES(''b6472cf1-692f-42ae-8f77-ab8e42c9e5be'',''†'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c46f9081-e77a-4791-819f-d73e0ad33b53'') = 0
	insert into semtbl_Token VALUES(''c46f9081-e77a-4791-819f-d73e0ad33b53'',''‡'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8f181b50-701b-4206-82dc-20829b06a634'') = 0
	insert into semtbl_Token VALUES(''8f181b50-701b-4206-82dc-20829b06a634'',''•'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''94bc3941-9481-43a8-82b0-b3f406f28eff'') = 0
	insert into semtbl_Token VALUES(''94bc3941-9481-43a8-82b0-b3f406f28eff'',''…'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fd0c5c7b-b704-4916-bed7-9f09270bef64'') = 0
	insert into semtbl_Token VALUES(''fd0c5c7b-b704-4916-bed7-9f09270bef64'',''‰'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''82d6cac3-1f4f-4641-92ee-039824f52fa5'') = 0
	insert into semtbl_Token VALUES(''82d6cac3-1f4f-4641-92ee-039824f52fa5'',''€'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7c61a4d3-994e-4a9f-a958-c42c5ca36a24'') = 0
	insert into semtbl_Token VALUES(''7c61a4d3-994e-4a9f-a958-c42c5ca36a24'',''0'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6d000357-af3e-4a31-9957-e0903ddc033c'') = 0
	insert into semtbl_Token VALUES(''6d000357-af3e-4a31-9957-e0903ddc033c'',''¼'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f5bf4b6a-a6f9-4678-b186-39a224726d13'') = 0
	insert into semtbl_Token VALUES(''f5bf4b6a-a6f9-4678-b186-39a224726d13'',''½'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''65449d08-be9c-4a3f-b456-fde8c7522417'') = 0
	insert into semtbl_Token VALUES(''65449d08-be9c-4a3f-b456-fde8c7522417'',''¾'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0e31e135-a615-42ae-bb36-da4d14256e58'') = 0
	insert into semtbl_Token VALUES(''0e31e135-a615-42ae-bb36-da4d14256e58'',''1'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0b6b926f-8dfb-49f0-bc38-6a5e45bf8f6a'') = 0
	insert into semtbl_Token VALUES(''0b6b926f-8dfb-49f0-bc38-6a5e45bf8f6a'',''¹'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ad492751-0021-49b8-b747-4e6efe00e435'') = 0
	insert into semtbl_Token VALUES(''ad492751-0021-49b8-b747-4e6efe00e435'',''²'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6cf95faa-9152-4192-be6a-ba059190a7be'') = 0
	insert into semtbl_Token VALUES(''6cf95faa-9152-4192-be6a-ba059190a7be'',''2'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''23f2d74c-3dcf-4321-aa54-d23c4b176322'') = 0
	insert into semtbl_Token VALUES(''23f2d74c-3dcf-4321-aa54-d23c4b176322'',''³'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0931a9a1-50e7-4751-b691-970fbe00a82b'') = 0
	insert into semtbl_Token VALUES(''0931a9a1-50e7-4751-b691-970fbe00a82b'',''3'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bc02a887-0d92-4dd9-a00e-7658f04dd645'') = 0
	insert into semtbl_Token VALUES(''bc02a887-0d92-4dd9-a00e-7658f04dd645'',''4'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fa134129-561b-4c95-8d1f-20a2c946405f'') = 0
	insert into semtbl_Token VALUES(''fa134129-561b-4c95-8d1f-20a2c946405f'',''5'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3d2ec9c9-f1da-4c47-a570-e7ffa3ffbe97'') = 0
	insert into semtbl_Token VALUES(''3d2ec9c9-f1da-4c47-a570-e7ffa3ffbe97'',''6'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2f4913a9-7d20-4d28-a7cc-52ca7dfe4fc3'') = 0
	insert into semtbl_Token VALUES(''2f4913a9-7d20-4d28-a7cc-52ca7dfe4fc3'',''7'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c227efb9-a02b-470e-8d67-09424fb929b8'') = 0
	insert into semtbl_Token VALUES(''c227efb9-a02b-470e-8d67-09424fb929b8'',''8'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b98c6423-614c-485b-aa0b-bef2cf07e405'') = 0
	insert into semtbl_Token VALUES(''b98c6423-614c-485b-aa0b-bef2cf07e405'',''9'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''be8f4e41-b63b-4c1b-8811-b253ed4af200'') = 0
	insert into semtbl_Token VALUES(''be8f4e41-b63b-4c1b-8811-b253ed4af200'',''a'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1c30c534-a7de-4588-88cd-1f804a50e733'') = 0
	insert into semtbl_Token VALUES(''1c30c534-a7de-4588-88cd-1f804a50e733'',''A'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b9721ba8-7bec-44a3-b307-5c768149b2eb'') = 0
	insert into semtbl_Token VALUES(''b9721ba8-7bec-44a3-b307-5c768149b2eb'',''ª'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''20a631d2-d709-48d3-b69b-5829c71a0608'') = 0
	insert into semtbl_Token VALUES(''20a631d2-d709-48d3-b69b-5829c71a0608'',''Á'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0c2673b6-cd94-4d68-b43b-785d99676fbe'') = 0
	insert into semtbl_Token VALUES(''0c2673b6-cd94-4d68-b43b-785d99676fbe'',''á'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ef5e554e-a56c-4562-9aae-1f8cae70a949'') = 0
	insert into semtbl_Token VALUES(''ef5e554e-a56c-4562-9aae-1f8cae70a949'',''à'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f76de01b-a592-4f7a-9acc-30b43b60bfc5'') = 0
	insert into semtbl_Token VALUES(''f76de01b-a592-4f7a-9acc-30b43b60bfc5'',''À'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1789c11e-5dd9-4f9d-ad13-49ef497e5d56'') = 0
	insert into semtbl_Token VALUES(''1789c11e-5dd9-4f9d-ad13-49ef497e5d56'',''â'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''56f1afb3-2d8f-4d0d-944e-ed317bf988c5'') = 0
	insert into semtbl_Token VALUES(''56f1afb3-2d8f-4d0d-944e-ed317bf988c5'',''Â'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3efb7240-c6c3-4bf4-9b62-c01692b25b06'') = 0
	insert into semtbl_Token VALUES(''3efb7240-c6c3-4bf4-9b62-c01692b25b06'',''Ä'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''489e6f6c-15f3-4513-aa3c-030d9527646a'') = 0
	insert into semtbl_Token VALUES(''489e6f6c-15f3-4513-aa3c-030d9527646a'',''ä'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''84f0e40c-6835-4b13-84b6-163438151126'') = 0
	insert into semtbl_Token VALUES(''84f0e40c-6835-4b13-84b6-163438151126'',''Ã'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f223b04e-3102-4829-adbd-1adbb6e6aeb3'') = 0
	insert into semtbl_Token VALUES(''f223b04e-3102-4829-adbd-1adbb6e6aeb3'',''ã'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fd6ee184-c620-45aa-9ca1-17efe85d9410'') = 0
	insert into semtbl_Token VALUES(''fd6ee184-c620-45aa-9ca1-17efe85d9410'',''Å'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cf4ae98c-a822-4a47-9490-ef7474625a3a'') = 0
	insert into semtbl_Token VALUES(''cf4ae98c-a822-4a47-9490-ef7474625a3a'',''å'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''344d6072-5a0b-438b-8123-f7ced6344189'') = 0
	insert into semtbl_Token VALUES(''344d6072-5a0b-438b-8123-f7ced6344189'',''æ'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2ccd4332-7762-4213-b979-c65416f82f13'') = 0
	insert into semtbl_Token VALUES(''2ccd4332-7762-4213-b979-c65416f82f13'',''Æ'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''eddf130c-27b4-4a4b-901e-abb85f021fe9'') = 0
	insert into semtbl_Token VALUES(''eddf130c-27b4-4a4b-901e-abb85f021fe9'',''b'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8bba7bea-efaa-414b-8c1c-aed0a3e3df77'') = 0
	insert into semtbl_Token VALUES(''8bba7bea-efaa-414b-8c1c-aed0a3e3df77'',''B'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8a062a0e-ac7d-4e33-bcd3-31ecf32a9502'') = 0
	insert into semtbl_Token VALUES(''8a062a0e-ac7d-4e33-bcd3-31ecf32a9502'',''c'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f9c617fd-e552-4dae-99c7-38518159e028'') = 0
	insert into semtbl_Token VALUES(''f9c617fd-e552-4dae-99c7-38518159e028'',''C'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''afaa7b98-cf62-48e4-bd0e-5d552205b56e'') = 0
	insert into semtbl_Token VALUES(''afaa7b98-cf62-48e4-bd0e-5d552205b56e'',''Ç'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''adabc633-f294-44fc-8908-d845b208b360'') = 0
	insert into semtbl_Token VALUES(''adabc633-f294-44fc-8908-d845b208b360'',''ç'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5c5169ec-b11d-4a1f-9d01-b454baff5713'') = 0
	insert into semtbl_Token VALUES(''5c5169ec-b11d-4a1f-9d01-b454baff5713'',''d'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0829e280-b5c7-4400-b879-8b9daa2ccf6a'') = 0
	insert into semtbl_Token VALUES(''0829e280-b5c7-4400-b879-8b9daa2ccf6a'',''D'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1dc54dab-6c31-4ca7-a8ac-91f01e80c556'') = 0
	insert into semtbl_Token VALUES(''1dc54dab-6c31-4ca7-a8ac-91f01e80c556'',''ð'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''68c1d6dc-d81d-4144-b505-5a56314a2425'') = 0
	insert into semtbl_Token VALUES(''68c1d6dc-d81d-4144-b505-5a56314a2425'',''Ð'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1e0e0708-c6e2-4cbf-b4b5-bc73578b6a3a'') = 0
	insert into semtbl_Token VALUES(''1e0e0708-c6e2-4cbf-b4b5-bc73578b6a3a'',''E'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''155cd732-e972-4a40-b666-ff0dcc618bef'') = 0
	insert into semtbl_Token VALUES(''155cd732-e972-4a40-b666-ff0dcc618bef'',''e'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ee967f46-0878-445a-8750-ff9b9b7da8a1'') = 0
	insert into semtbl_Token VALUES(''ee967f46-0878-445a-8750-ff9b9b7da8a1'',''É'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''77de7ed1-70a5-4408-8bb6-be56abc014b7'') = 0
	insert into semtbl_Token VALUES(''77de7ed1-70a5-4408-8bb6-be56abc014b7'',''é'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bb6f668d-bce6-41a8-9820-498587b21122'') = 0
	insert into semtbl_Token VALUES(''bb6f668d-bce6-41a8-9820-498587b21122'',''È'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8b0a0b22-faad-4721-b057-44cff47bad31'') = 0
	insert into semtbl_Token VALUES(''8b0a0b22-faad-4721-b057-44cff47bad31'',''è'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0b9aadf6-6fb6-4922-ba96-5363de0145c7'') = 0
	insert into semtbl_Token VALUES(''0b9aadf6-6fb6-4922-ba96-5363de0145c7'',''ê'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''24a89f6f-f5b5-45dc-b462-79f47d3d54a7'') = 0
	insert into semtbl_Token VALUES(''24a89f6f-f5b5-45dc-b462-79f47d3d54a7'',''Ê'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8dda68b2-b38e-4cb4-a0aa-1a179b1ff249'') = 0
	insert into semtbl_Token VALUES(''8dda68b2-b38e-4cb4-a0aa-1a179b1ff249'',''ë'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3dab38dc-cf81-4b82-9f61-c8dab7e84d27'') = 0
	insert into semtbl_Token VALUES(''3dab38dc-cf81-4b82-9f61-c8dab7e84d27'',''Ë'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3b286af3-559f-4d52-b759-fc2cded7a615'') = 0
	insert into semtbl_Token VALUES(''3b286af3-559f-4d52-b759-fc2cded7a615'',''F'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''782f82cc-9024-4021-b78c-4a69f29ab897'') = 0
	insert into semtbl_Token VALUES(''782f82cc-9024-4021-b78c-4a69f29ab897'',''f'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b819d907-c357-4322-9979-b320f2d10b34'') = 0
	insert into semtbl_Token VALUES(''b819d907-c357-4322-9979-b320f2d10b34'',''ƒ'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6631a5a1-d142-4207-99b7-c957cad4df2b'') = 0
	insert into semtbl_Token VALUES(''6631a5a1-d142-4207-99b7-c957cad4df2b'',''G'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3cd67df8-0ee3-40fd-bf85-452ca00a663c'') = 0
	insert into semtbl_Token VALUES(''3cd67df8-0ee3-40fd-bf85-452ca00a663c'',''g'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2dacd90b-ac41-472b-ac8b-31c9a7eb2158'') = 0
	insert into semtbl_Token VALUES(''2dacd90b-ac41-472b-ac8b-31c9a7eb2158'',''H'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b8f1d6f8-7a08-418d-b754-add0fbc9ba37'') = 0
	insert into semtbl_Token VALUES(''b8f1d6f8-7a08-418d-b754-add0fbc9ba37'',''h'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2a6dcd91-e61f-4a76-a08c-35a40638a060'') = 0
	insert into semtbl_Token VALUES(''2a6dcd91-e61f-4a76-a08c-35a40638a060'',''i'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''544f5980-0e55-49c8-bfa8-7e9913952dc3'') = 0
	insert into semtbl_Token VALUES(''544f5980-0e55-49c8-bfa8-7e9913952dc3'',''I'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''69219ad8-ddfa-4b70-b7aa-69e6dfe1181c'') = 0
	insert into semtbl_Token VALUES(''69219ad8-ddfa-4b70-b7aa-69e6dfe1181c'',''Í'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''05324e23-a8c0-4138-a70d-447c358ab808'') = 0
	insert into semtbl_Token VALUES(''05324e23-a8c0-4138-a70d-447c358ab808'',''í'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ed3dc046-7a3b-4220-a331-7f802c071870'') = 0
	insert into semtbl_Token VALUES(''ed3dc046-7a3b-4220-a331-7f802c071870'',''ì'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''940cbe81-b2c9-4807-98b1-d878e19ccc2e'') = 0
	insert into semtbl_Token VALUES(''940cbe81-b2c9-4807-98b1-d878e19ccc2e'',''Ì'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f445e32a-3278-4c23-b9a7-b6503af0c9f0'') = 0
	insert into semtbl_Token VALUES(''f445e32a-3278-4c23-b9a7-b6503af0c9f0'',''î'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''67183c0c-4fda-4d4f-afd5-4690bbc728f3'') = 0
	insert into semtbl_Token VALUES(''67183c0c-4fda-4d4f-afd5-4690bbc728f3'',''Î'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c1432e02-681d-4e5b-9f87-41485809b5ff'') = 0
	insert into semtbl_Token VALUES(''c1432e02-681d-4e5b-9f87-41485809b5ff'',''Ï'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''97c15bbb-d7cf-44e1-81de-125f151e7fee'') = 0
	insert into semtbl_Token VALUES(''97c15bbb-d7cf-44e1-81de-125f151e7fee'',''ï'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0240642a-4cc2-488a-b923-3ae44c3ee08f'') = 0
	insert into semtbl_Token VALUES(''0240642a-4cc2-488a-b923-3ae44c3ee08f'',''J'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f348c50a-3902-4ac6-a7bb-7ec0e0017ba2'') = 0
	insert into semtbl_Token VALUES(''f348c50a-3902-4ac6-a7bb-7ec0e0017ba2'',''j'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''56364e8f-4dbb-4728-93d3-d8cc7ee4a057'') = 0
	insert into semtbl_Token VALUES(''56364e8f-4dbb-4728-93d3-d8cc7ee4a057'',''k'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e4deb324-86b6-495e-921f-cf635458f347'') = 0
	insert into semtbl_Token VALUES(''e4deb324-86b6-495e-921f-cf635458f347'',''K'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''70b0724c-3460-490e-978a-ca4f50135018'') = 0
	insert into semtbl_Token VALUES(''70b0724c-3460-490e-978a-ca4f50135018'',''L'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4e0ad884-a581-427b-9cc9-d633eac6fac2'') = 0
	insert into semtbl_Token VALUES(''4e0ad884-a581-427b-9cc9-d633eac6fac2'',''l'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2b191666-58bf-45db-a7c0-933c2da385e6'') = 0
	insert into semtbl_Token VALUES(''2b191666-58bf-45db-a7c0-933c2da385e6'',''m'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3973b7ab-1263-41c3-8e0e-6dfbe339c109'') = 0
	insert into semtbl_Token VALUES(''3973b7ab-1263-41c3-8e0e-6dfbe339c109'',''M'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a7ff1145-07ff-456f-af7f-48cc789b58e9'') = 0
	insert into semtbl_Token VALUES(''a7ff1145-07ff-456f-af7f-48cc789b58e9'',''n'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d7cc6e6c-7a82-4f1b-93db-efc029409014'') = 0
	insert into semtbl_Token VALUES(''d7cc6e6c-7a82-4f1b-93db-efc029409014'',''N'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f1a45c22-1b4a-4c2a-ade2-f2314d74909c'') = 0
	insert into semtbl_Token VALUES(''f1a45c22-1b4a-4c2a-ade2-f2314d74909c'',''ñ'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c3d1d659-deb6-4642-82ce-5ad4d1769af1'') = 0
	insert into semtbl_Token VALUES(''c3d1d659-deb6-4642-82ce-5ad4d1769af1'',''Ñ'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''28fb9cde-f5db-4074-9727-54381abfe252'') = 0
	insert into semtbl_Token VALUES(''28fb9cde-f5db-4074-9727-54381abfe252'',''O'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6b44da4c-207f-4be6-b393-a7892b920c85'') = 0
	insert into semtbl_Token VALUES(''6b44da4c-207f-4be6-b393-a7892b920c85'',''o'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''dc1fe9d1-fcd2-494c-a643-db67bc382e51'') = 0
	insert into semtbl_Token VALUES(''dc1fe9d1-fcd2-494c-a643-db67bc382e51'',''º'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''55ea3f95-517c-4ef4-a321-ea1cb1c0be83'') = 0
	insert into semtbl_Token VALUES(''55ea3f95-517c-4ef4-a321-ea1cb1c0be83'',''Ó'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6ff3b9f0-c0b3-46ce-a0cb-19377c4ea8cc'') = 0
	insert into semtbl_Token VALUES(''6ff3b9f0-c0b3-46ce-a0cb-19377c4ea8cc'',''ó'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8d91d163-2c2a-41a6-b72d-217d088c93e3'') = 0
	insert into semtbl_Token VALUES(''8d91d163-2c2a-41a6-b72d-217d088c93e3'',''Ò'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6c37ffda-d7c9-4615-b838-63eb8ec4e6c0'') = 0
	insert into semtbl_Token VALUES(''6c37ffda-d7c9-4615-b838-63eb8ec4e6c0'',''ò'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b9dd8104-38e2-4077-bce9-58088d566af8'') = 0
	insert into semtbl_Token VALUES(''b9dd8104-38e2-4077-bce9-58088d566af8'',''ô'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''51a83a51-0e28-40f9-b0f7-1b0affc726b0'') = 0
	insert into semtbl_Token VALUES(''51a83a51-0e28-40f9-b0f7-1b0affc726b0'',''Ô'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8e3b690f-1079-4bf1-ac38-ff8c614e624b'') = 0
	insert into semtbl_Token VALUES(''8e3b690f-1079-4bf1-ac38-ff8c614e624b'',''ö'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f2802a05-51c3-40b1-a5dd-bb39abaaf4f1'') = 0
	insert into semtbl_Token VALUES(''f2802a05-51c3-40b1-a5dd-bb39abaaf4f1'',''Ö'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3c86701a-76ca-406f-8deb-933bb5eb68bc'') = 0
	insert into semtbl_Token VALUES(''3c86701a-76ca-406f-8deb-933bb5eb68bc'',''Õ'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''abafad44-f574-4699-880b-8b3911a179f3'') = 0
	insert into semtbl_Token VALUES(''abafad44-f574-4699-880b-8b3911a179f3'',''õ'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''01de6ca2-f585-4793-8c79-774d869fcb51'') = 0
	insert into semtbl_Token VALUES(''01de6ca2-f585-4793-8c79-774d869fcb51'',''ø'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''166e0e44-7d53-441a-a28e-b621141315a9'') = 0
	insert into semtbl_Token VALUES(''166e0e44-7d53-441a-a28e-b621141315a9'',''Ø'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''effce711-3ee3-4651-a118-50fb9f65ad38'') = 0
	insert into semtbl_Token VALUES(''effce711-3ee3-4651-a118-50fb9f65ad38'',''œ'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1e8ebd25-a113-4d8f-9fee-35e119eb561d'') = 0
	insert into semtbl_Token VALUES(''1e8ebd25-a113-4d8f-9fee-35e119eb561d'',''Œ'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ad8c15f0-c36f-46ae-abdb-359b71016b18'') = 0
	insert into semtbl_Token VALUES(''ad8c15f0-c36f-46ae-abdb-359b71016b18'',''P'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6a6f0ca0-be45-4f99-8942-6aa4021b6334'') = 0
	insert into semtbl_Token VALUES(''6a6f0ca0-be45-4f99-8942-6aa4021b6334'',''p'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''870b7d6e-0f1a-4f57-b197-905c21c3dd17'') = 0
	insert into semtbl_Token VALUES(''870b7d6e-0f1a-4f57-b197-905c21c3dd17'',''q'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b654863e-7f7c-4a22-8c13-97d14f65dee8'') = 0
	insert into semtbl_Token VALUES(''b654863e-7f7c-4a22-8c13-97d14f65dee8'',''Q'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3306e6a1-a7fc-4b1f-baaf-96af6e993dc4'') = 0
	insert into semtbl_Token VALUES(''3306e6a1-a7fc-4b1f-baaf-96af6e993dc4'',''r'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9be92fa3-c137-4a83-bc81-1f3672a36054'') = 0
	insert into semtbl_Token VALUES(''9be92fa3-c137-4a83-bc81-1f3672a36054'',''R'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bfa91489-56c2-4e03-b712-6d397314f507'') = 0
	insert into semtbl_Token VALUES(''bfa91489-56c2-4e03-b712-6d397314f507'',''S'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1ed2bb70-c01b-468f-b95d-af1d1cf1915b'') = 0
	insert into semtbl_Token VALUES(''1ed2bb70-c01b-468f-b95d-af1d1cf1915b'',''s'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3fb95fc9-1077-46a3-aa68-b7862f44bb43'') = 0
	insert into semtbl_Token VALUES(''3fb95fc9-1077-46a3-aa68-b7862f44bb43'',''Š'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4fbfed7b-73bc-4fc5-ba63-69641245594d'') = 0
	insert into semtbl_Token VALUES(''4fbfed7b-73bc-4fc5-ba63-69641245594d'',''š'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''76c14ad8-5021-47b2-af46-a6cdd6b76307'') = 0
	insert into semtbl_Token VALUES(''76c14ad8-5021-47b2-af46-a6cdd6b76307'',''ß'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''acf8aa00-921c-42ac-8d43-eb6f1dd203af'') = 0
	insert into semtbl_Token VALUES(''acf8aa00-921c-42ac-8d43-eb6f1dd203af'',''T'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''631eff6a-3277-4269-86f1-ec3bd1e50f57'') = 0
	insert into semtbl_Token VALUES(''631eff6a-3277-4269-86f1-ec3bd1e50f57'',''t'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''095cf819-84be-4800-9333-b9782a679247'') = 0
	insert into semtbl_Token VALUES(''095cf819-84be-4800-9333-b9782a679247'',''Þ'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''05556314-d36d-4b44-9f63-49f8cc77e9bf'') = 0
	insert into semtbl_Token VALUES(''05556314-d36d-4b44-9f63-49f8cc77e9bf'',''þ'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''443794f3-16f5-4833-81ba-7083d0ec9e48'') = 0
	insert into semtbl_Token VALUES(''443794f3-16f5-4833-81ba-7083d0ec9e48'',''™'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''974dee69-ed91-43e2-89db-49289a07972c'') = 0
	insert into semtbl_Token VALUES(''974dee69-ed91-43e2-89db-49289a07972c'',''u'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''798241af-2d39-4383-8fff-c65b474e96ce'') = 0
	insert into semtbl_Token VALUES(''798241af-2d39-4383-8fff-c65b474e96ce'',''U'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''31c81b7f-6bc1-48d9-93ca-bf68299b1f74'') = 0
	insert into semtbl_Token VALUES(''31c81b7f-6bc1-48d9-93ca-bf68299b1f74'',''ú'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8aae4a3b-4b71-4ffe-891b-d5d7f308beed'') = 0
	insert into semtbl_Token VALUES(''8aae4a3b-4b71-4ffe-891b-d5d7f308beed'',''Ú'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b70b577e-837c-4f1a-9bb4-63215567c459'') = 0
	insert into semtbl_Token VALUES(''b70b577e-837c-4f1a-9bb4-63215567c459'',''ù'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''59e935eb-e54d-445f-a47b-8436481a6e44'') = 0
	insert into semtbl_Token VALUES(''59e935eb-e54d-445f-a47b-8436481a6e44'',''Ù'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''eda55c2f-1084-45d5-a799-5ab472f965a0'') = 0
	insert into semtbl_Token VALUES(''eda55c2f-1084-45d5-a799-5ab472f965a0'',''Û'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7fd522e7-56c8-4019-a54d-e860e962af07'') = 0
	insert into semtbl_Token VALUES(''7fd522e7-56c8-4019-a54d-e860e962af07'',''û'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ed178c9f-5063-4cdd-ae23-8625b51ae10c'') = 0
	insert into semtbl_Token VALUES(''ed178c9f-5063-4cdd-ae23-8625b51ae10c'',''Ü'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2ad7a387-4122-49c0-94b2-502ebde0149e'') = 0
	insert into semtbl_Token VALUES(''2ad7a387-4122-49c0-94b2-502ebde0149e'',''ü'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a97f6b9c-010f-4ebe-82bd-a07da618b804'') = 0
	insert into semtbl_Token VALUES(''a97f6b9c-010f-4ebe-82bd-a07da618b804'',''V'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fba9628c-86f3-4bd9-9bdf-ba375fca4326'') = 0
	insert into semtbl_Token VALUES(''fba9628c-86f3-4bd9-9bdf-ba375fca4326'',''v'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''af590e3b-eb51-4cf4-87d6-ccc3ecaeec08'') = 0
	insert into semtbl_Token VALUES(''af590e3b-eb51-4cf4-87d6-ccc3ecaeec08'',''W'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''18a31cd6-0036-48d8-908a-65f9a4301348'') = 0
	insert into semtbl_Token VALUES(''18a31cd6-0036-48d8-908a-65f9a4301348'',''w'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''25f80f2d-4575-476f-b6a7-3dada0fc4133'') = 0
	insert into semtbl_Token VALUES(''25f80f2d-4575-476f-b6a7-3dada0fc4133'',''x'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9dceff39-f29a-4087-9224-2ddcd64ec50c'') = 0
	insert into semtbl_Token VALUES(''9dceff39-f29a-4087-9224-2ddcd64ec50c'',''X'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d6c5b840-bdd1-49de-8a4f-08dcf8d87f73'') = 0
	insert into semtbl_Token VALUES(''d6c5b840-bdd1-49de-8a4f-08dcf8d87f73'',''Y'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''23495a38-83b2-43d8-a49e-37f059c133d4'') = 0
	insert into semtbl_Token VALUES(''23495a38-83b2-43d8-a49e-37f059c133d4'',''y'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0ecb9fdc-30d7-4b11-bb72-9edbf170e532'') = 0
	insert into semtbl_Token VALUES(''0ecb9fdc-30d7-4b11-bb72-9edbf170e532'',''Ý'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0a6b2997-b450-4694-a355-e1b32acb1301'') = 0
	insert into semtbl_Token VALUES(''0a6b2997-b450-4694-a355-e1b32acb1301'',''ý'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b0dbe7a0-afaa-462b-aa19-9bd599ad6937'') = 0
	insert into semtbl_Token VALUES(''b0dbe7a0-afaa-462b-aa19-9bd599ad6937'',''Ÿ'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''176568cc-84b0-42ef-bd72-599f506fe78e'') = 0
	insert into semtbl_Token VALUES(''176568cc-84b0-42ef-bd72-599f506fe78e'',''ÿ'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''70f364d3-7c37-40d9-af55-66ff39f08390'') = 0
	insert into semtbl_Token VALUES(''70f364d3-7c37-40d9-af55-66ff39f08390'',''Z'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5d8d4c1d-dde9-4636-8fd4-beb90a3a4b43'') = 0
	insert into semtbl_Token VALUES(''5d8d4c1d-dde9-4636-8fd4-beb90a3a4b43'',''z'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''236dec61-2bfb-44f7-b6b7-f33c1fda254b'') = 0
	insert into semtbl_Token VALUES(''236dec61-2bfb-44f7-b6b7-f33c1fda254b'',''ž'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''06e0a43a-0abd-493a-acae-45d390a0dd02'') = 0
	insert into semtbl_Token VALUES(''06e0a43a-0abd-493a-acae-45d390a0dd02'',''Ž'',''c8e580ed-be06-49a2-8ee8-17e8e0160393'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c6e4d79c-01b7-40e8-9d7f-f51c30437ed5'') = 0
	insert into semtbl_Token VALUES(''c6e4d79c-01b7-40e8-9d7f-f51c30437ed5'',''align'',''afe18e83-a290-4660-9e6b-ced83ab2a429'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0e77d9c4-08fd-40cb-b00c-c4d9f8e31e4b'') = 0
	insert into semtbl_Token VALUES(''0e77d9c4-08fd-40cb-b00c-c4d9f8e31e4b'',''alt'',''afe18e83-a290-4660-9e6b-ced83ab2a429'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e258fd74-10e3-4db0-bbc5-77431463c78a'') = 0
	insert into semtbl_Token VALUES(''e258fd74-10e3-4db0-bbc5-77431463c78a'',''height'',''afe18e83-a290-4660-9e6b-ced83ab2a429'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''85759965-b809-457e-903e-5535d3c40517'') = 0
	insert into semtbl_Token VALUES(''85759965-b809-457e-903e-5535d3c40517'',''hspace'',''afe18e83-a290-4660-9e6b-ced83ab2a429'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fc272309-3bbb-4994-aeb4-9e934901cfd2'') = 0
	insert into semtbl_Token VALUES(''fc272309-3bbb-4994-aeb4-9e934901cfd2'',''longdesc'',''afe18e83-a290-4660-9e6b-ced83ab2a429'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b5a7d210-6715-452f-83db-d13f05e2ca40'') = 0
	insert into semtbl_Token VALUES(''b5a7d210-6715-452f-83db-d13f05e2ca40'',''name'',''afe18e83-a290-4660-9e6b-ced83ab2a429'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0ffd3687-65d0-41cc-b13e-fe64026f8097'') = 0
	insert into semtbl_Token VALUES(''0ffd3687-65d0-41cc-b13e-fe64026f8097'',''usemap'',''afe18e83-a290-4660-9e6b-ced83ab2a429'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''de4ca19e-ca22-4c39-bc32-e34e9ec8ef6c'') = 0
	insert into semtbl_Token VALUES(''de4ca19e-ca22-4c39-bc32-e34e9ec8ef6c'',''vspace'',''afe18e83-a290-4660-9e6b-ced83ab2a429'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''44568b90-dd80-4ea9-a051-47ace0fb2a51'') = 0
	insert into semtbl_Token VALUES(''44568b90-dd80-4ea9-a051-47ace0fb2a51'',''width'',''afe18e83-a290-4660-9e6b-ced83ab2a429'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''55845c08-a9cc-4c25-b92e-27b366d87ca0'') = 0
	insert into semtbl_Token VALUES(''55845c08-a9cc-4c25-b92e-27b366d87ca0'',''a'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9971aee7-423d-461d-b0e5-2c2f58bcbe07'') = 0
	insert into semtbl_Token VALUES(''9971aee7-423d-461d-b0e5-2c2f58bcbe07'',''abbr'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e480935f-912e-401d-a520-6f9fa0721ffe'') = 0
	insert into semtbl_Token VALUES(''e480935f-912e-401d-a520-6f9fa0721ffe'',''ACRONYM'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8c551215-8bdb-4b58-a968-e03a81054110'') = 0
	insert into semtbl_Token VALUES(''8c551215-8bdb-4b58-a968-e03a81054110'',''ADDRESS'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''90b78b6d-3edd-4e6d-acb6-f860e1c147da'') = 0
	insert into semtbl_Token VALUES(''90b78b6d-3edd-4e6d-acb6-f860e1c147da'',''APPLET'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cfa266e7-e593-4114-b710-136fb625a494'') = 0
	insert into semtbl_Token VALUES(''cfa266e7-e593-4114-b710-136fb625a494'',''AREA'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2e792e35-71df-4a1a-ae5d-fb616e708895'') = 0
	insert into semtbl_Token VALUES(''2e792e35-71df-4a1a-ae5d-fb616e708895'',''B'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''334e1535-2f58-4d1e-95ea-29a33f824ab2'') = 0
	insert into semtbl_Token VALUES(''334e1535-2f58-4d1e-95ea-29a33f824ab2'',''BASE'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''53f3f060-398c-4c65-a63f-ae94b55f182c'') = 0
	insert into semtbl_Token VALUES(''53f3f060-398c-4c65-a63f-ae94b55f182c'',''BASEFONT'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d8176bdd-b97d-4f33-b7ce-c399a860b5c6'') = 0
	insert into semtbl_Token VALUES(''d8176bdd-b97d-4f33-b7ce-c399a860b5c6'',''BIG'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''742b5f6c-f2d6-4fbc-b9ed-869732f00f35'') = 0
	insert into semtbl_Token VALUES(''742b5f6c-f2d6-4fbc-b9ed-869732f00f35'',''BLINK'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''93cfd618-678a-409e-a6d7-04c297e8260f'') = 0
	insert into semtbl_Token VALUES(''93cfd618-678a-409e-a6d7-04c297e8260f'',''BLOCKQUOTE'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''995db9c7-00ab-49c2-a4a6-b939c3ebe00c'') = 0
	insert into semtbl_Token VALUES(''995db9c7-00ab-49c2-a4a6-b939c3ebe00c'',''BODY'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c5d4d182-0eb0-4e94-80a2-5c4fe579f17d'') = 0
	insert into semtbl_Token VALUES(''c5d4d182-0eb0-4e94-80a2-5c4fe579f17d'',''BR'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''280fee87-8a27-4a60-bdbc-08bf5664c887'') = 0
	insert into semtbl_Token VALUES(''280fee87-8a27-4a60-bdbc-08bf5664c887'',''BUTTON'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ae833fe5-7aea-48e7-b093-759db3a0b119'') = 0
	insert into semtbl_Token VALUES(''ae833fe5-7aea-48e7-b093-759db3a0b119'',''CAPTION'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''aad00392-0394-499c-850a-d72145304f04'') = 0
	insert into semtbl_Token VALUES(''aad00392-0394-499c-850a-d72145304f04'',''CENTER'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''824afd14-09d4-4c5c-906c-c32bdb5ec01e'') = 0
	insert into semtbl_Token VALUES(''824afd14-09d4-4c5c-906c-c32bdb5ec01e'',''CITE'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5437ac1d-bd83-4d3b-94ef-7a9f88dd63d2'') = 0
	insert into semtbl_Token VALUES(''5437ac1d-bd83-4d3b-94ef-7a9f88dd63d2'',''CODE'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d24f7dc0-5c84-4701-9a0b-911fc04c367e'') = 0
	insert into semtbl_Token VALUES(''d24f7dc0-5c84-4701-9a0b-911fc04c367e'',''COL'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c034833e-88f0-47fb-9f7d-b1e34c58c268'') = 0
	insert into semtbl_Token VALUES(''c034833e-88f0-47fb-9f7d-b1e34c58c268'',''DD'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''27c4dfc6-a8ef-4982-8d71-e5385116dfa0'') = 0
	insert into semtbl_Token VALUES(''27c4dfc6-a8ef-4982-8d71-e5385116dfa0'',''DFN'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4d628455-184a-445b-b73e-a413710e7859'') = 0
	insert into semtbl_Token VALUES(''4d628455-184a-445b-b73e-a413710e7859'',''DIR'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a25974af-0876-497c-95f3-047d4c420dbf'') = 0
	insert into semtbl_Token VALUES(''a25974af-0876-497c-95f3-047d4c420dbf'',''DIV'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''52ec380e-40e7-49ce-a720-d549d52b622e'') = 0
	insert into semtbl_Token VALUES(''52ec380e-40e7-49ce-a720-d549d52b622e'',''DL'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bd5f2934-1ad3-40c4-b431-7aeacfc0110b'') = 0
	insert into semtbl_Token VALUES(''bd5f2934-1ad3-40c4-b431-7aeacfc0110b'',''DT'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''25d7b7bb-c36a-46c9-88da-ac4c0e9bff0e'') = 0
	insert into semtbl_Token VALUES(''25d7b7bb-c36a-46c9-88da-ac4c0e9bff0e'',''EM'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0a877542-a1a4-4ae5-8e72-420844488493'') = 0
	insert into semtbl_Token VALUES(''0a877542-a1a4-4ae5-8e72-420844488493'',''FONT'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0164a45b-ad13-466f-8414-b69eac1fe30f'') = 0
	insert into semtbl_Token VALUES(''0164a45b-ad13-466f-8414-b69eac1fe30f'',''FORM'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''78d2b1e7-3ea5-4932-9604-b62fa4c9b1ce'') = 0
	insert into semtbl_Token VALUES(''78d2b1e7-3ea5-4932-9604-b62fa4c9b1ce'',''H1'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5e72ad26-b780-4c30-b383-56220426b69e'') = 0
	insert into semtbl_Token VALUES(''5e72ad26-b780-4c30-b383-56220426b69e'',''H2'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ac8c026a-44d5-4e70-a468-55bdf652570d'') = 0
	insert into semtbl_Token VALUES(''ac8c026a-44d5-4e70-a468-55bdf652570d'',''H3'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''78d80931-9773-459c-92b8-5d1154769c82'') = 0
	insert into semtbl_Token VALUES(''78d80931-9773-459c-92b8-5d1154769c82'',''H4'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1e47e55b-b8fd-483f-a73d-95fcdc4bf2f0'') = 0
	insert into semtbl_Token VALUES(''1e47e55b-b8fd-483f-a73d-95fcdc4bf2f0'',''H5'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d312bdb1-9676-4736-80ad-d8a58203d511'') = 0
	insert into semtbl_Token VALUES(''d312bdb1-9676-4736-80ad-d8a58203d511'',''H6'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b236d7a0-da28-4c4e-9b29-b391518ed070'') = 0
	insert into semtbl_Token VALUES(''b236d7a0-da28-4c4e-9b29-b391518ed070'',''HEAD'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ed7b9938-8c32-4648-b909-9f0be58b7da9'') = 0
	insert into semtbl_Token VALUES(''ed7b9938-8c32-4648-b909-9f0be58b7da9'',''HR'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''aea1ce3d-9eac-4a0c-8e2e-d05178084d82'') = 0
	insert into semtbl_Token VALUES(''aea1ce3d-9eac-4a0c-8e2e-d05178084d82'',''HTML'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''77ce9412-5ae6-46ab-bfa9-512dbb87f57f'') = 0
	insert into semtbl_Token VALUES(''77ce9412-5ae6-46ab-bfa9-512dbb87f57f'',''I'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2e87759e-a9eb-4c7c-88ee-d91cded850f2'') = 0
	insert into semtbl_Token VALUES(''2e87759e-a9eb-4c7c-88ee-d91cded850f2'',''IMG '',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7a66e00c-4086-4715-aaaa-6a19591e67b2'') = 0
	insert into semtbl_Token VALUES(''7a66e00c-4086-4715-aaaa-6a19591e67b2'',''INPUT'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9a1af0e8-fc99-4531-9545-98c90b171ba3'') = 0
	insert into semtbl_Token VALUES(''9a1af0e8-fc99-4531-9545-98c90b171ba3'',''ISINDEX'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''efb740f3-910f-4f7b-96bb-c2320ab27ae1'') = 0
	insert into semtbl_Token VALUES(''efb740f3-910f-4f7b-96bb-c2320ab27ae1'',''KBD'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''dc8a60ec-2074-4212-83a8-708b58a14609'') = 0
	insert into semtbl_Token VALUES(''dc8a60ec-2074-4212-83a8-708b58a14609'',''LI'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d0b5f7cb-db7f-456a-b0dd-7576141c44e4'') = 0
	insert into semtbl_Token VALUES(''d0b5f7cb-db7f-456a-b0dd-7576141c44e4'',''LINK'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c0d62067-c690-4470-95d3-7590d3ff4d3c'') = 0
	insert into semtbl_Token VALUES(''c0d62067-c690-4470-95d3-7590d3ff4d3c'',''MAP'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''de4237ed-9348-47ae-8f66-fb1a3b4198dc'') = 0
	insert into semtbl_Token VALUES(''de4237ed-9348-47ae-8f66-fb1a3b4198dc'',''MARQUEE'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c1dcf5ea-878a-4b84-b83c-7fd4db62febc'') = 0
	insert into semtbl_Token VALUES(''c1dcf5ea-878a-4b84-b83c-7fd4db62febc'',''MENU'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5b73d632-1103-4c24-b9ba-27ea747c5ee9'') = 0
	insert into semtbl_Token VALUES(''5b73d632-1103-4c24-b9ba-27ea747c5ee9'',''META'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''34373e99-1e65-4cf6-b50b-edaf83e2a479'') = 0
	insert into semtbl_Token VALUES(''34373e99-1e65-4cf6-b50b-edaf83e2a479'',''OL'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9d6267f5-8a31-4104-9a1c-65a172539a4f'') = 0
	insert into semtbl_Token VALUES(''9d6267f5-8a31-4104-9a1c-65a172539a4f'',''OPTION'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f5910a41-91d3-480f-bc65-d4f8608649b1'') = 0
	insert into semtbl_Token VALUES(''f5910a41-91d3-480f-bc65-d4f8608649b1'',''P'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''26215765-ef8d-425b-a5c3-300cfae30e89'') = 0
	insert into semtbl_Token VALUES(''26215765-ef8d-425b-a5c3-300cfae30e89'',''PARAM'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7395759f-560b-426f-9f74-0bf0d8d44aff'') = 0
	insert into semtbl_Token VALUES(''7395759f-560b-426f-9f74-0bf0d8d44aff'',''PRE'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3052e1ff-c97b-44a5-b1d9-16cf1b7bf3a3'') = 0
	insert into semtbl_Token VALUES(''3052e1ff-c97b-44a5-b1d9-16cf1b7bf3a3'',''Q'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d1f8dc5d-b224-4c29-92ab-3b7f9ae91037'') = 0
	insert into semtbl_Token VALUES(''d1f8dc5d-b224-4c29-92ab-3b7f9ae91037'',''SAMP'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6b47992e-39c4-47c4-a0af-472ef6d12c99'') = 0
	insert into semtbl_Token VALUES(''6b47992e-39c4-47c4-a0af-472ef6d12c99'',''SCRIPT'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d67d6dfe-60a5-4e4d-b59e-c665d8ded959'') = 0
	insert into semtbl_Token VALUES(''d67d6dfe-60a5-4e4d-b59e-c665d8ded959'',''SELECT'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''41523d35-9ebd-45af-8b5c-cad9d93562ff'') = 0
	insert into semtbl_Token VALUES(''41523d35-9ebd-45af-8b5c-cad9d93562ff'',''SMALL'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cc9b6650-be4f-469b-aa95-d14570903816'') = 0
	insert into semtbl_Token VALUES(''cc9b6650-be4f-469b-aa95-d14570903816'',''SPAN'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''10a80b0a-9613-4d1b-aa70-0effadf9d66d'') = 0
	insert into semtbl_Token VALUES(''10a80b0a-9613-4d1b-aa70-0effadf9d66d'',''Strikeout'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8eb6335b-d527-44b8-a01b-ff8461e73939'') = 0
	insert into semtbl_Token VALUES(''8eb6335b-d527-44b8-a01b-ff8461e73939'',''STRONG'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3abd4c10-0f64-4d5b-9bd9-59ea821322a6'') = 0
	insert into semtbl_Token VALUES(''3abd4c10-0f64-4d5b-9bd9-59ea821322a6'',''STYLE'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''50ca2985-1b31-48d4-b026-6f900b212620'') = 0
	insert into semtbl_Token VALUES(''50ca2985-1b31-48d4-b026-6f900b212620'',''SUB'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''546c013e-5eb5-4ad4-9d47-824c617990b8'') = 0
	insert into semtbl_Token VALUES(''546c013e-5eb5-4ad4-9d47-824c617990b8'',''SUP'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bad62082-7645-4a43-96af-1102de3f8168'') = 0
	insert into semtbl_Token VALUES(''bad62082-7645-4a43-96af-1102de3f8168'',''TABLE'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''098de489-3c39-471b-b619-a95f8336bd4a'') = 0
	insert into semtbl_Token VALUES(''098de489-3c39-471b-b619-a95f8336bd4a'',''TBODY'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''05b883a7-55f9-466c-b0ea-bfd8df1c467b'') = 0
	insert into semtbl_Token VALUES(''05b883a7-55f9-466c-b0ea-bfd8df1c467b'',''TD'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''04e19c2a-a818-4bd9-a2b2-db260eb07f83'') = 0
	insert into semtbl_Token VALUES(''04e19c2a-a818-4bd9-a2b2-db260eb07f83'',''TEXTAREA'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''91f4531f-dbd8-43f3-a21c-64b0ecaa9e17'') = 0
	insert into semtbl_Token VALUES(''91f4531f-dbd8-43f3-a21c-64b0ecaa9e17'',''TFOOT'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c8f9c095-1d16-475c-af5d-a67090c889ea'') = 0
	insert into semtbl_Token VALUES(''c8f9c095-1d16-475c-af5d-a67090c889ea'',''TH'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ff7d86a4-9495-4aee-873a-cd4f43f1aa53'') = 0
	insert into semtbl_Token VALUES(''ff7d86a4-9495-4aee-873a-cd4f43f1aa53'',''THEAD'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c1135ec8-bbed-4b12-8c58-7c1f2c061808'') = 0
	insert into semtbl_Token VALUES(''c1135ec8-bbed-4b12-8c58-7c1f2c061808'',''TITLE'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cc8f2b2a-da8a-417a-bc64-a4f9be12e669'') = 0
	insert into semtbl_Token VALUES(''cc8f2b2a-da8a-417a-bc64-a4f9be12e669'',''TR'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''42950f2e-e9ab-4724-b909-adf37b72247d'') = 0
	insert into semtbl_Token VALUES(''42950f2e-e9ab-4724-b909-adf37b72247d'',''TT'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''aef7325e-4f3a-4dfb-b5ec-e12bb43c2a15'') = 0
	insert into semtbl_Token VALUES(''aef7325e-4f3a-4dfb-b5ec-e12bb43c2a15'',''U'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8f3d0623-cecc-405c-be83-e2799ba60a41'') = 0
	insert into semtbl_Token VALUES(''8f3d0623-cecc-405c-be83-e2799ba60a41'',''UL'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5596da87-2551-455c-953b-fe4bbd02e2c0'') = 0
	insert into semtbl_Token VALUES(''5596da87-2551-455c-953b-fe4bbd02e2c0'',''VAR'',''44e1125d-41c5-418e-b012-5f7f7b8f3063'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''81690cd8-3907-4325-801d-eb266ea3af89'') = 0
	insert into semtbl_Token VALUES(''81690cd8-3907-4325-801d-eb266ea3af89'',''BaseConfig'',''55e1e943-398d-49a8-a6e6-a573bc6dc740'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''738496bc-3d39-4592-ae4c-da4644b0542c'' AND GUID_Token_Right=''1b4f8484-85d4-4f80-8541-b3cc67e6a43f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''738496bc-3d39-4592-ae4c-da4644b0542c'',''1b4f8484-85d4-4f80-8541-b3cc67e6a43f'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''738496bc-3d39-4592-ae4c-da4644b0542c'' AND GUID_Token_Right=''2e87759e-a9eb-4c7c-88ee-d91cded850f2'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''738496bc-3d39-4592-ae4c-da4644b0542c'',''2e87759e-a9eb-4c7c-88ee-d91cded850f2'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''451c1498-bcc7-492b-9399-a01464d35186'' AND GUID_Token_Right=''2e87759e-a9eb-4c7c-88ee-d91cded850f2'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''451c1498-bcc7-492b-9399-a01464d35186'',''2e87759e-a9eb-4c7c-88ee-d91cded850f2'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''c6e4d79c-01b7-40e8-9d7f-f51c30437ed5'' AND GUID_Token_Right=''2e87759e-a9eb-4c7c-88ee-d91cded850f2'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''c6e4d79c-01b7-40e8-9d7f-f51c30437ed5'',''2e87759e-a9eb-4c7c-88ee-d91cded850f2'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''0e77d9c4-08fd-40cb-b00c-c4d9f8e31e4b'' AND GUID_Token_Right=''2e87759e-a9eb-4c7c-88ee-d91cded850f2'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''0e77d9c4-08fd-40cb-b00c-c4d9f8e31e4b'',''2e87759e-a9eb-4c7c-88ee-d91cded850f2'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''e258fd74-10e3-4db0-bbc5-77431463c78a'' AND GUID_Token_Right=''2e87759e-a9eb-4c7c-88ee-d91cded850f2'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''e258fd74-10e3-4db0-bbc5-77431463c78a'',''2e87759e-a9eb-4c7c-88ee-d91cded850f2'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''85759965-b809-457e-903e-5535d3c40517'' AND GUID_Token_Right=''2e87759e-a9eb-4c7c-88ee-d91cded850f2'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''85759965-b809-457e-903e-5535d3c40517'',''2e87759e-a9eb-4c7c-88ee-d91cded850f2'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''fc272309-3bbb-4994-aeb4-9e934901cfd2'' AND GUID_Token_Right=''2e87759e-a9eb-4c7c-88ee-d91cded850f2'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''fc272309-3bbb-4994-aeb4-9e934901cfd2'',''2e87759e-a9eb-4c7c-88ee-d91cded850f2'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b5a7d210-6715-452f-83db-d13f05e2ca40'' AND GUID_Token_Right=''2e87759e-a9eb-4c7c-88ee-d91cded850f2'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b5a7d210-6715-452f-83db-d13f05e2ca40'',''2e87759e-a9eb-4c7c-88ee-d91cded850f2'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''0ffd3687-65d0-41cc-b13e-fe64026f8097'' AND GUID_Token_Right=''2e87759e-a9eb-4c7c-88ee-d91cded850f2'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''0ffd3687-65d0-41cc-b13e-fe64026f8097'',''2e87759e-a9eb-4c7c-88ee-d91cded850f2'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''de4ca19e-ca22-4c39-bc32-e34e9ec8ef6c'' AND GUID_Token_Right=''2e87759e-a9eb-4c7c-88ee-d91cded850f2'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''de4ca19e-ca22-4c39-bc32-e34e9ec8ef6c'',''2e87759e-a9eb-4c7c-88ee-d91cded850f2'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''44568b90-dd80-4ea9-a051-47ace0fb2a51'' AND GUID_Token_Right=''2e87759e-a9eb-4c7c-88ee-d91cded850f2'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''44568b90-dd80-4ea9-a051-47ace0fb2a51'',''2e87759e-a9eb-4c7c-88ee-d91cded850f2'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''2e792e35-71df-4a1a-ae5d-fb616e708895'' AND GUID_Token_Right=''c9da3392-212e-46af-a3e1-79716e15ed1a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''2e792e35-71df-4a1a-ae5d-fb616e708895'',''c9da3392-212e-46af-a3e1-79716e15ed1a'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''995db9c7-00ab-49c2-a4a6-b939c3ebe00c'' AND GUID_Token_Right=''a7403d39-150e-4f3a-9d2c-6870c2c00389'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''995db9c7-00ab-49c2-a4a6-b939c3ebe00c'',''a7403d39-150e-4f3a-9d2c-6870c2c00389'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''78d2b1e7-3ea5-4932-9604-b62fa4c9b1ce'' AND GUID_Token_Right=''1f2af1f4-936e-4cec-898c-a89c66131d6f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''78d2b1e7-3ea5-4932-9604-b62fa4c9b1ce'',''1f2af1f4-936e-4cec-898c-a89c66131d6f'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''5e72ad26-b780-4c30-b383-56220426b69e'' AND GUID_Token_Right=''1f2af1f4-936e-4cec-898c-a89c66131d6f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''5e72ad26-b780-4c30-b383-56220426b69e'',''1f2af1f4-936e-4cec-898c-a89c66131d6f'',''e07469d9-766c-443e-8526-6d9c684f944f'',2)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''ac8c026a-44d5-4e70-a468-55bdf652570d'' AND GUID_Token_Right=''1f2af1f4-936e-4cec-898c-a89c66131d6f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''ac8c026a-44d5-4e70-a468-55bdf652570d'',''1f2af1f4-936e-4cec-898c-a89c66131d6f'',''e07469d9-766c-443e-8526-6d9c684f944f'',3)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''78d80931-9773-459c-92b8-5d1154769c82'' AND GUID_Token_Right=''1f2af1f4-936e-4cec-898c-a89c66131d6f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''78d80931-9773-459c-92b8-5d1154769c82'',''1f2af1f4-936e-4cec-898c-a89c66131d6f'',''e07469d9-766c-443e-8526-6d9c684f944f'',4)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''1e47e55b-b8fd-483f-a73d-95fcdc4bf2f0'' AND GUID_Token_Right=''1f2af1f4-936e-4cec-898c-a89c66131d6f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''1e47e55b-b8fd-483f-a73d-95fcdc4bf2f0'',''1f2af1f4-936e-4cec-898c-a89c66131d6f'',''e07469d9-766c-443e-8526-6d9c684f944f'',5)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d312bdb1-9676-4736-80ad-d8a58203d511'' AND GUID_Token_Right=''1f2af1f4-936e-4cec-898c-a89c66131d6f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d312bdb1-9676-4736-80ad-d8a58203d511'',''1f2af1f4-936e-4cec-898c-a89c66131d6f'',''e07469d9-766c-443e-8526-6d9c684f944f'',6)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b236d7a0-da28-4c4e-9b29-b391518ed070'' AND GUID_Token_Right=''5bc7672e-3f5b-4665-b491-b7d23410c9e8'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b236d7a0-da28-4c4e-9b29-b391518ed070'',''5bc7672e-3f5b-4665-b491-b7d23410c9e8'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''aea1ce3d-9eac-4a0c-8e2e-d05178084d82'' AND GUID_Token_Right=''77a523f0-5658-4012-bd28-b0237607ddbd'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''aea1ce3d-9eac-4a0c-8e2e-d05178084d82'',''77a523f0-5658-4012-bd28-b0237607ddbd'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''2e87759e-a9eb-4c7c-88ee-d91cded850f2'' AND GUID_Token_Right=''326a9d6d-da29-4b5e-802f-da420e4b55a0'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''2e87759e-a9eb-4c7c-88ee-d91cded850f2'',''326a9d6d-da29-4b5e-802f-da420e4b55a0'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''f5910a41-91d3-480f-bc65-d4f8608649b1'' AND GUID_Token_Right=''e2d4e55d-d5e1-4892-b54e-b8c1e21e54e2'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''f5910a41-91d3-480f-bc65-d4f8608649b1'',''e2d4e55d-d5e1-4892-b54e-b8c1e21e54e2'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''bad62082-7645-4a43-96af-1102de3f8168'' AND GUID_Token_Right=''4b0874f0-f9ff-489c-82e7-4181e96ffe88'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''bad62082-7645-4a43-96af-1102de3f8168'',''4b0874f0-f9ff-489c-82e7-4181e96ffe88'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''05b883a7-55f9-466c-b0ea-bfd8df1c467b'' AND GUID_Token_Right=''cd2f9d05-5faa-4ec8-b052-4e665b4c6dfb'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''05b883a7-55f9-466c-b0ea-bfd8df1c467b'',''cd2f9d05-5faa-4ec8-b052-4e665b4c6dfb'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''c1135ec8-bbed-4b12-8c58-7c1f2c061808'' AND GUID_Token_Right=''540cb05f-659d-432c-bcc0-7edaf389d77f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''c1135ec8-bbed-4b12-8c58-7c1f2c061808'',''540cb05f-659d-432c-bcc0-7edaf389d77f'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''cc8f2b2a-da8a-417a-bc64-a4f9be12e669'' AND GUID_Token_Right=''d545b18f-3f07-411e-92c5-c0695126eab3'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''cc8f2b2a-da8a-417a-bc64-a4f9be12e669'',''d545b18f-3f07-411e-92c5-c0695126eab3'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''81690cd8-3907-4325-801d-eb266ea3af89'' AND GUID_Token_Right=''f0fe0294-7042-42f2-96ff-5429d34a04fc'' AND GUID_RelationType=''62632706-1829-43e4-8034-52c7fd14e353'')=0
	INSERT INTO semtbl_Token_Token VALUES(''81690cd8-3907-4325-801d-eb266ea3af89'',''f0fe0294-7042-42f2-96ff-5429d34a04fc'',''62632706-1829-43e4-8034-52c7fd14e353'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''81690cd8-3907-4325-801d-eb266ea3af89'' AND GUID_Token_Right=''0c921230-e08d-4a3d-a87d-730c5ff285b3'' AND GUID_RelationType=''3126254c-d84e-4f34-82a4-47aeb7be4bda'')=0
	INSERT INTO semtbl_Token_Token VALUES(''81690cd8-3907-4325-801d-eb266ea3af89'',''0c921230-e08d-4a3d-a87d-730c5ff285b3'',''3126254c-d84e-4f34-82a4-47aeb7be4bda'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''81690cd8-3907-4325-801d-eb266ea3af89'' AND GUID_Token_Right=''b994302e-3ddd-4603-8685-7bfb28fe2b51'' AND GUID_RelationType=''95ca984f-e8bd-4d54-b56c-d982c2a0b9e7'')=0
	INSERT INTO semtbl_Token_Token VALUES(''81690cd8-3907-4325-801d-eb266ea3af89'',''b994302e-3ddd-4603-8685-7bfb28fe2b51'',''95ca984f-e8bd-4d54-b56c-d982c2a0b9e7'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''81690cd8-3907-4325-801d-eb266ea3af89'' AND GUID_Token_Right=''39a83777-2b8b-4a76-8beb-b3585ebb0185'' AND GUID_RelationType=''93dd2bd3-791a-4699-80d1-96bb52bdcae5'')=0
	INSERT INTO semtbl_Token_Token VALUES(''81690cd8-3907-4325-801d-eb266ea3af89'',''39a83777-2b8b-4a76-8beb-b3585ebb0185'',''93dd2bd3-791a-4699-80d1-96bb52bdcae5'',1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',0,1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''408db9f1-ae42-4807-b656-729270646f0a'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''fafc1464-815f-4596-9737-bcbc96bd744a'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''5394de2e-1eef-4483-bad8-f58ec565e5b3'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''5394de2e-1eef-4483-bad8-f58ec565e5b3'',''39a83777-2b8b-4a76-8beb-b3585ebb0185'',''68ac4472-ee22-4229-96ec-9753a016900a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_VarcharMax WHERE GUID_TokenAttribute=''5394de2e-1eef-4483-bad8-f58ec565e5b3'' )=0
	INSERT INTO semtbl_Token_Attribute_VarcharMax VALUES(''5394de2e-1eef-4483-bad8-f58ec565e5b3'',''<?xml version="1.0" encoding="utf-8"?>
<data>
<![CDATA[<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
       "http://www.w3.org/TR/html4/loose.dtd">]]>
</data>'',0)'
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
