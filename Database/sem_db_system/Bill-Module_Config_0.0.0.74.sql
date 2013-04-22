use [sem_db_system]
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''96405d28-0826-40e6-8e55-30d1ecc0542a'') = 0
	insert into semtbl_Attribute VALUES(''96405d28-0826-40e6-8e55-30d1ecc0542a'',''Valutatag'',''905fda81-788f-4e3d-8329-3e55ae984b9e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''daf53cbc-2cb4-42ed-8722-ee85f6b33512'') = 0
	insert into semtbl_Attribute VALUES(''daf53cbc-2cb4-42ed-8722-ee85f6b33512'',''Menge'',''a1244d0e-187f-46ee-8574-2fc334077b7d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''417f6a60-e5d5-4470-8871-8079c0cac065'') = 0
	insert into semtbl_Attribute VALUES(''417f6a60-e5d5-4470-8871-8079c0cac065'',''Begünstigter/Zahlungspflichtiger'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''cee3873e-c7ae-48d5-a4b7-d4ffd293fe14'') = 0
	insert into semtbl_Attribute VALUES(''cee3873e-c7ae-48d5-a4b7-d4ffd293fe14'',''percent'',''a1244d0e-187f-46ee-8574-2fc334077b7d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''9342e9b0-842c-4a01-baea-50d77881a195'') = 0
	insert into semtbl_Attribute VALUES(''9342e9b0-842c-4a01-baea-50d77881a195'',''Zahlungsausgang'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''212ca6eb-3c72-4cd4-8609-0fef351f08cc'') = 0
	insert into semtbl_Attribute VALUES(''212ca6eb-3c72-4cd4-8609-0fef351f08cc'',''Gross (Standard)'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''2424da1a-59f9-463b-8d13-473377702fc2'') = 0
	insert into semtbl_Attribute VALUES(''2424da1a-59f9-463b-8d13-473377702fc2'',''Transaction-ID'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''dc5045bb-1b83-4139-b6d4-a1a561529dca'') = 0
	insert into semtbl_Attribute VALUES(''dc5045bb-1b83-4139-b6d4-a1a561529dca'',''Betrag'',''a1244d0e-187f-46ee-8574-2fc334077b7d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''8824ecf1-5957-44ee-9114-de52c1305a39'') = 0
	insert into semtbl_Attribute VALUES(''8824ecf1-5957-44ee-9114-de52c1305a39'',''Transaction-Date'',''905fda81-788f-4e3d-8329-3e55ae984b9e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''eb9f0536-d97b-40b6-b7ee-b7018f6caa0e'') = 0
	insert into semtbl_Attribute VALUES(''eb9f0536-d97b-40b6-b7ee-b7018f6caa0e'',''Amount'',''a1244d0e-187f-46ee-8574-2fc334077b7d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''eaf21eed-54e0-4afc-8b50-8497db6e0cdd'') = 0
	insert into semtbl_Attribute VALUES(''eaf21eed-54e0-4afc-8b50-8497db6e0cdd'',''gross'',''dd858f27-d5e1-4363-a5c3-3e561e432333'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''5d09a3e9-03fb-436c-8450-1a50bf1267b6'') = 0
	insert into semtbl_Attribute VALUES(''5d09a3e9-03fb-436c-8450-1a50bf1267b6'',''to Pay'',''a1244d0e-187f-46ee-8574-2fc334077b7d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''1bb51893-8518-49d9-b7b3-e9ee140ab526'') = 0
	insert into semtbl_Attribute VALUES(''1bb51893-8518-49d9-b7b3-e9ee140ab526'',''part / %'',''a1244d0e-187f-46ee-8574-2fc334077b7d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''699e0400-0b0d-4447-91eb-1df6d861eacb'') = 0
	insert into semtbl_Attribute VALUES(''699e0400-0b0d-4447-91eb-1df6d861eacb'',''Info'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''dec493e8-b24b-4f45-9d67-c33d5da30939'') = 0
	insert into semtbl_Attribute VALUES(''dec493e8-b24b-4f45-9d67-c33d5da30939'',''Buchungstext'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''48f8f02d-6068-4319-8526-e66f8063af4e'') = 0
	insert into semtbl_Attribute VALUES(''48f8f02d-6068-4319-8526-e66f8063af4e'',''Verwendungszweck'',''065e644e-c7df-4007-8672-aa5414131c78'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''b0b91f06-5c33-470b-8b1a-4c5c93d53ea2'') = 0
	insert into semtbl_Attribute VALUES(''b0b91f06-5c33-470b-8b1a-4c5c93d53ea2'',''factor'',''a1244d0e-187f-46ee-8574-2fc334077b7d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''51074f19-35fa-4f63-b9fd-1bbceb81aa0d'')=0
	insert into semtbl_RelationType VALUES(''51074f19-35fa-4f63-b9fd-1bbceb81aa0d'',''belonging Payment'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''d91da85b-793c-431c-9724-8ddc1ace170e'')=0
	insert into semtbl_RelationType VALUES(''d91da85b-793c-431c-9724-8ddc1ace170e'',''Standard'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''74585903-16e3-48a1-9ee7-0329c8569a56'')=0
	insert into semtbl_RelationType VALUES(''74585903-16e3-48a1-9ee7-0329c8569a56'',''belonging Amount'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''fd4bacff-5ab6-4681-9b7c-a43d0fcbdf3d'')=0
	insert into semtbl_RelationType VALUES(''fd4bacff-5ab6-4681-9b7c-a43d0fcbdf3d'',''belonging Currency'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	insert into semtbl_RelationType VALUES(''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',''offered by'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''4b0ffa28-3fe2-4303-8880-226530f363cb'')=0
	insert into semtbl_RelationType VALUES(''4b0ffa28-3fe2-4303-8880-226530f363cb'',''zugehörige Mandanten'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''0b9a8992-349c-4e4b-9f06-1d954222bd8f'')=0
	insert into semtbl_RelationType VALUES(''0b9a8992-349c-4e4b-9f06-1d954222bd8f'',''belonging Tax-Rate'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''ad99b56c-f3b5-4cca-9442-459b9a835098'')=0
	insert into semtbl_RelationType VALUES(''ad99b56c-f3b5-4cca-9442-459b9a835098'',''belonging Contractor'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	insert into semtbl_RelationType VALUES(''e07469d9-766c-443e-8526-6d9c684f944f'',''belongs to'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''b07efa3b-6184-4cf0-8f8b-0ce49a4f397e'')=0
	insert into semtbl_RelationType VALUES(''b07efa3b-6184-4cf0-8f8b-0ce49a4f397e'',''accountings'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''59fc1def-0977-44fc-af4c-70dad8f7d723'')=0
	insert into semtbl_RelationType VALUES(''59fc1def-0977-44fc-af4c-70dad8f7d723'',''belonging Contractee'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''06b93890-d922-47ed-b70e-5e9cbd03df52'')=0
	insert into semtbl_RelationType VALUES(''06b93890-d922-47ed-b70e-5e9cbd03df52'',''Gegenkonto'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'')=0
	insert into semtbl_RelationType VALUES(''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'',''located in'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'')=0
	insert into semtbl_RelationType VALUES(''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'',''offers'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''51f3c615-a01e-400d-b81b-58cadd07e773'')=0
	insert into semtbl_RelationType VALUES(''51f3c615-a01e-400d-b81b-58cadd07e773'',''belonging Sem-Item'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''f9543325-338b-45ef-9fbd-453563cdcc6a'')=0
	insert into semtbl_RelationType VALUES(''f9543325-338b-45ef-9fbd-453563cdcc6a'',''Auftragskonto'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''79671239-9c8f-493c-b5e7-49700f9543f4'')=0
	insert into semtbl_RelationType VALUES(''79671239-9c8f-493c-b5e7-49700f9543f4'',''belonging'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''f77ee633-19d8-4ea6-947f-9fb6efad3547'')=0
	insert into semtbl_RelationType VALUES(''f77ee633-19d8-4ea6-947f-9fb6efad3547'',''is partner of'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''c9670b90-e5f0-4e30-a26d-ad3d6576ceac'')=0
	insert into semtbl_RelationType VALUES(''c9670b90-e5f0-4e30-a26d-ad3d6576ceac'',''contact'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''5d8f540c-3e92-4999-a710-ce7f2dd611de'')=0
	insert into semtbl_RelationType VALUES(''5d8f540c-3e92-4999-a710-ce7f2dd611de'',''Base'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''dd5a24ec-e2bd-47c2-9761-d4a7db114aed'')=0
	insert into semtbl_RelationType VALUES(''dd5a24ec-e2bd-47c2-9761-d4a7db114aed'',''additional'')'
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='fc3872da-2516-4d8a-a21b-297c6b2b40dd') = 0
	insert into semtbl_Type VALUES('fc3872da-2516-4d8a-a21b-297c6b2b40dd','Financial-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='6401e369-4445-49a3-9822-1029a4c1b8b8') = 0
	insert into semtbl_Type VALUES('6401e369-4445-49a3-9822-1029a4c1b8b8','Bank-Transaktionen (Sparkasse)','fc3872da-2516-4d8a-a21b-297c6b2b40dd')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='6a812e6c-52b1-407b-aceb-9412f5c1cfaf') = 0
	insert into semtbl_Type VALUES('6a812e6c-52b1-407b-aceb-9412f5c1cfaf','Bank-Transaktionen (Sparkasse) - Archiv','6401e369-4445-49a3-9822-1029a4c1b8b8')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='4a6430a8-89f3-409b-883c-3641a8b88898') = 0
	insert into semtbl_Type VALUES('4a6430a8-89f3-409b-883c-3641a8b88898','Financial-Transaction','fc3872da-2516-4d8a-a21b-297c6b2b40dd')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='b7ea6186-327a-43eb-be5b-8f39ea599155') = 0
	insert into semtbl_Type VALUES('b7ea6186-327a-43eb-be5b-8f39ea599155','Payment','4a6430a8-89f3-409b-883c-3641a8b88898')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='51cda3ce-2ad8-46f1-a098-b7bcf0c2eba2') = 0
	insert into semtbl_Type VALUES('51cda3ce-2ad8-46f1-a098-b7bcf0c2eba2','Offset','4a6430a8-89f3-409b-883c-3641a8b88898')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='68ca7f8f-4172-4186-8687-95385899783c') = 0
	insert into semtbl_Type VALUES('68ca7f8f-4172-4186-8687-95385899783c','Financial-Transaction - Archive','4a6430a8-89f3-409b-883c-3641a8b88898')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='d4ef7be6-afaf-42e2-8596-61d70b886c23') = 0
	insert into semtbl_Type VALUES('d4ef7be6-afaf-42e2-8596-61d70b886c23','Bankkonto','fc3872da-2516-4d8a-a21b-297c6b2b40dd')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='b6551e7a-b9c8-4d98-94c6-076dcf8cd12b') = 0
	insert into semtbl_Type VALUES('b6551e7a-b9c8-4d98-94c6-076dcf8cd12b','Bankinstitut','fc3872da-2516-4d8a-a21b-297c6b2b40dd')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747') = 0
	insert into semtbl_Type VALUES('b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747','Module-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='aa616051-e521-4fac-abdb-cbba6f8c6e73') = 0
	insert into semtbl_Type VALUES('aa616051-e521-4fac-abdb-cbba6f8c6e73','Module','b5224e7f-7d0d-4bee-bf8e-b9a0eeba5747')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='9e508361-7de6-4087-bdae-30933cdb8843') = 0
	insert into semtbl_Type VALUES('9e508361-7de6-4087-bdae-30933cdb8843','Bill-Module','aa616051-e521-4fac-abdb-cbba6f8c6e73')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='7415f32e-fb56-4aeb-a413-42e37457fdb7') = 0
	insert into semtbl_Type VALUES('7415f32e-fb56-4aeb-a413-42e37457fdb7','Media-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='57642009-3978-4db7-9b38-c2a526cdeaee') = 0
	insert into semtbl_Type VALUES('57642009-3978-4db7-9b38-c2a526cdeaee','Container (Physical)','7415f32e-fb56-4aeb-a413-42e37457fdb7')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='7d0178e2-9c04-4485-b81c-6d79253c6f64') = 0
	insert into semtbl_Type VALUES('7d0178e2-9c04-4485-b81c-6d79253c6f64','Localization-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='8aa50712-fda9-4222-a350-6378f36e49f8') = 0
	insert into semtbl_Type VALUES('8aa50712-fda9-4222-a350-6378f36e49f8','Formats','7d0178e2-9c04-4485-b81c-6d79253c6f64')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='5f7a0238-859e-4eec-9f69-3038192cf56f') = 0
	insert into semtbl_Type VALUES('5f7a0238-859e-4eec-9f69-3038192cf56f','Menge','8aa50712-fda9-4222-a350-6378f36e49f8')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='e864f198-1df0-4d53-bb87-959bc8884919') = 0
	insert into semtbl_Type VALUES('e864f198-1df0-4d53-bb87-959bc8884919','Currencies','8aa50712-fda9-4222-a350-6378f36e49f8')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='d88808d0-0473-4594-a8f9-6c4cb3439297') = 0
	insert into semtbl_Type VALUES('d88808d0-0473-4594-a8f9-6c4cb3439297','Einheit','8aa50712-fda9-4222-a350-6378f36e49f8')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='53aa29b7-36e1-4511-b9a4-a743a5fc4535') = 0
	insert into semtbl_Type VALUES('53aa29b7-36e1-4511-b9a4-a743a5fc4535','Tax-Rates','8aa50712-fda9-4222-a350-6378f36e49f8')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='e79ff4de-2e39-4101-b5a1-0055c40f41cd') = 0
	insert into semtbl_Type VALUES('e79ff4de-2e39-4101-b5a1-0055c40f41cd','Language','7d0178e2-9c04-4485-b81c-6d79253c6f64')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='83317bac-b4b1-4db8-bf84-9fca0a93ddd5') = 0
	insert into semtbl_Type VALUES('83317bac-b4b1-4db8-bf84-9fca0a93ddd5','Information-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='105e9a10-6c41-4e8e-9306-0bf795bb9b04') = 0
	insert into semtbl_Type VALUES('105e9a10-6c41-4e8e-9306-0bf795bb9b04','Document-Management','83317bac-b4b1-4db8-bf84-9fca0a93ddd5')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='952ba315-3c21-44fb-9bbc-2192e971b906') = 0
	insert into semtbl_Type VALUES('952ba315-3c21-44fb-9bbc-2192e971b906','Beleg','105e9a10-6c41-4e8e-9306-0bf795bb9b04')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='3f806e96-422c-46ef-b9e5-609e91a8c27b') = 0
	insert into semtbl_Type VALUES('3f806e96-422c-46ef-b9e5-609e91a8c27b','Belegsart','952ba315-3c21-44fb-9bbc-2192e971b906')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='499ec20d-af6f-4e72-bf55-ffb6eac101bf') = 0
	insert into semtbl_Type VALUES('499ec20d-af6f-4e72-bf55-ffb6eac101bf','Search-Template','83317bac-b4b1-4db8-bf84-9fca0a93ddd5')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='3d1dc6cf-b964-4986-9808-f39b7c5c3907') = 0
	insert into semtbl_Type VALUES('3d1dc6cf-b964-4986-9808-f39b7c5c3907','Direction','83317bac-b4b1-4db8-bf84-9fca0a93ddd5')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='2a127013-81ca-42a4-bcf3-c3f28d62bf1c') = 0
	insert into semtbl_Type VALUES('2a127013-81ca-42a4-bcf3-c3f28d62bf1c','Adress-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='a2d7d0fe-0495-4afe-85e1-1dcb88a27546') = 0
	insert into semtbl_Type VALUES('a2d7d0fe-0495-4afe-85e1-1dcb88a27546','Partner','2a127013-81ca-42a4-bcf3-c3f28d62bf1c')
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b6f1f499-a905-43d9-838b-11a2977299cc'') = 0
	insert into semtbl_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''Bill-Module'',''c6c9bcb8-0ac9-4713-9417-eeec1453026c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9b0183f0-c787-4fe8-b5bd-fe038ccd4a7c'') = 0
	insert into semtbl_Token VALUES(''9b0183f0-c787-4fe8-b5bd-fe038ccd4a7c'',''Bill-Module'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''935cc11d-12c8-46c8-922d-041d0d603edf'') = 0
	insert into semtbl_Token VALUES(''935cc11d-12c8-46c8-922d-041d0d603edf'',''Attribute_Valutatag'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''02e20c29-88bf-4887-9767-05245f5245a9'') = 0
	insert into semtbl_Token VALUES(''02e20c29-88bf-4887-9767-05245f5245a9'',''Type_Bank_Transaktionen__Sparkasse_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''269a5f7e-f51e-4f51-bb51-06c3ad50e3b8'') = 0
	insert into semtbl_Token VALUES(''269a5f7e-f51e-4f51-bb51-06c3ad50e3b8'',''Type_Container__physical_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a4fdcad2-0b82-42aa-848b-08b89b4f1354'') = 0
	insert into semtbl_Token VALUES(''a4fdcad2-0b82-42aa-848b-08b89b4f1354'',''RelationType_belonging_Payment'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f2aca284-8ee0-4150-938b-09a43e7eafb7'') = 0
	insert into semtbl_Token VALUES(''f2aca284-8ee0-4150-938b-09a43e7eafb7'',''Attribute_Menge'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'') = 0
	insert into semtbl_Token VALUES(''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''Type_Module'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e26211f2-d7ee-44fd-ac09-0ffa5f82fa2b'') = 0
	insert into semtbl_Token VALUES(''e26211f2-d7ee-44fd-ac09-0ffa5f82fa2b'',''Token_Search_Template_Related_Sem_Item_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a2e20bb7-6423-4807-98c1-107837996076'') = 0
	insert into semtbl_Token VALUES(''a2e20bb7-6423-4807-98c1-107837996076'',''Attribute_Beg_nstigter_Zahlungspflichtiger'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e39c0ac5-21b0-4c4b-b365-1a88e4b517de'') = 0
	insert into semtbl_Token VALUES(''e39c0ac5-21b0-4c4b-b365-1a88e4b517de'',''Type_Bank_Transaktionen__Sparkasse____Archiv'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e8305ca1-2e88-4267-b33d-1ae571916997'') = 0
	insert into semtbl_Token VALUES(''e8305ca1-2e88-4267-b33d-1ae571916997'',''Type_Menge'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''93ef4864-7a54-45aa-ad5e-1e38da9ebcfc'') = 0
	insert into semtbl_Token VALUES(''93ef4864-7a54-45aa-ad5e-1e38da9ebcfc'',''Token_Direction_Up'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''407f4a7e-db85-47ab-b58c-20169856f25c'') = 0
	insert into semtbl_Token VALUES(''407f4a7e-db85-47ab-b58c-20169856f25c'',''Token_Search_Template_Contractee_Contractor_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6e913914-7ca1-48c3-b342-20fba8c57c9b'') = 0
	insert into semtbl_Token VALUES(''6e913914-7ca1-48c3-b342-20fba8c57c9b'',''Type_Payment'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''669c5918-f565-428b-b3a6-387fbe2a3c58'') = 0
	insert into semtbl_Token VALUES(''669c5918-f565-428b-b3a6-387fbe2a3c58'',''Token_Direction_Down'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0f211b81-efac-4dc0-9c7a-3aeba969ad46'') = 0
	insert into semtbl_Token VALUES(''0f211b81-efac-4dc0-9c7a-3aeba969ad46'',''Type_Financial_Transaction'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fb69b5e3-2b0a-47ad-8424-4692c2e83175'') = 0
	insert into semtbl_Token VALUES(''fb69b5e3-2b0a-47ad-8424-4692c2e83175'',''RelationType_Standard'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3fcdf63c-8f33-4e7e-912b-4e3fc4e92dd9'') = 0
	insert into semtbl_Token VALUES(''3fcdf63c-8f33-4e7e-912b-4e3fc4e92dd9'',''Attribute_percent'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d27bed40-7392-493f-ab1f-4ef2bbc64575'') = 0
	insert into semtbl_Token VALUES(''d27bed40-7392-493f-ab1f-4ef2bbc64575'',''Type_Beleg'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bf074291-2897-48d3-b704-52368c845f09'') = 0
	insert into semtbl_Token VALUES(''bf074291-2897-48d3-b704-52368c845f09'',''Attribute_Zahlungsausgang'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d2cdfee8-39e6-4b0a-b1dc-555da5c2a3b5'') = 0
	insert into semtbl_Token VALUES(''d2cdfee8-39e6-4b0a-b1dc-555da5c2a3b5'',''Type_Bill_Module'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b7db9126-e04e-42ff-8e1e-66a1b872574d'') = 0
	insert into semtbl_Token VALUES(''b7db9126-e04e-42ff-8e1e-66a1b872574d'',''RelationType_belonging_Amount'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1306f4a9-7754-44b6-a33f-68884a947568'') = 0
	insert into semtbl_Token VALUES(''1306f4a9-7754-44b6-a33f-68884a947568'',''Attribute_Gross__Standard_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6c966e3c-c737-4af1-9970-68c8323679bc'') = 0
	insert into semtbl_Token VALUES(''6c966e3c-c737-4af1-9970-68c8323679bc'',''RelationType_contains'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'') = 0
	insert into semtbl_Token VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''attribute_dbPostfix'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''15820ab1-0945-4e72-9792-6dd480e73954'') = 0
	insert into semtbl_Token VALUES(''15820ab1-0945-4e72-9792-6dd480e73954'',''RelationType_isDescribedBy'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e9944776-131a-4333-8730-70555b96f1c9'') = 0
	insert into semtbl_Token VALUES(''e9944776-131a-4333-8730-70555b96f1c9'',''Attribute_Transaction_ID'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6e494944-f602-4dcb-906f-70e5efe8f1dd'') = 0
	insert into semtbl_Token VALUES(''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''RelationType_is_of_Type'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cb8555b7-9128-4a29-a9f7-76e9c8ec25f9'') = 0
	insert into semtbl_Token VALUES(''cb8555b7-9128-4a29-a9f7-76e9c8ec25f9'',''RelationType_belonging_Currency'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f2cde058-614e-41cb-96eb-78bbcf285171'') = 0
	insert into semtbl_Token VALUES(''f2cde058-614e-41cb-96eb-78bbcf285171'',''RelationType_offered_by'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c473b0f4-f7b1-4ef5-8f8e-8cd17ae1abb3'') = 0
	insert into semtbl_Token VALUES(''c473b0f4-f7b1-4ef5-8f8e-8cd17ae1abb3'',''Token_Search_Template_Amount_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''46551f18-1c7b-4b0d-8c48-8cf7582d4c64'') = 0
	insert into semtbl_Token VALUES(''46551f18-1c7b-4b0d-8c48-8cf7582d4c64'',''Type_Kontonummer'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f75d75b7-d053-4b73-93d3-9319c7ae8c82'') = 0
	insert into semtbl_Token VALUES(''f75d75b7-d053-4b73-93d3-9319c7ae8c82'',''RelationType_zugeh_rige_Mandanten'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5221f303-5fc8-4d8c-9f99-9c5422159c79'') = 0
	insert into semtbl_Token VALUES(''5221f303-5fc8-4d8c-9f99-9c5422159c79'',''RelationType_belonging_Tax_Rate'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6a59f3d6-033e-4db5-95a9-a5130c482c76'') = 0
	insert into semtbl_Token VALUES(''6a59f3d6-033e-4db5-95a9-a5130c482c76'',''Attribute_Betrag'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''00acaf8d-b90b-426b-84d9-a58ff944f66c'') = 0
	insert into semtbl_Token VALUES(''00acaf8d-b90b-426b-84d9-a58ff944f66c'',''RelationType_belonging_Contractor'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''075cb4b9-65bf-4fd5-abf8-a6c4deb57282'') = 0
	insert into semtbl_Token VALUES(''075cb4b9-65bf-4fd5-abf8-a6c4deb57282'',''Type_Currencies'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''87eb4dc0-bdae-4c49-bf3c-a70ea7a6a4d6'') = 0
	insert into semtbl_Token VALUES(''87eb4dc0-bdae-4c49-bf3c-a70ea7a6a4d6'',''Type_Language'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''87068490-d91a-4d25-b400-a836b040603e'') = 0
	insert into semtbl_Token VALUES(''87068490-d91a-4d25-b400-a836b040603e'',''Token_Search_Template_Payment_Date_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3186cc5e-023b-4edc-b6c7-a89919320839'') = 0
	insert into semtbl_Token VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''RelationType_belongsTo'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9b18d3ce-ffcf-4948-ad4d-abcc02664d75'') = 0
	insert into semtbl_Token VALUES(''9b18d3ce-ffcf-4948-ad4d-abcc02664d75'',''Attribute_Transaction_Date'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''38aa4fbc-2d5f-44e3-ba23-b523c2a0a0f8'') = 0
	insert into semtbl_Token VALUES(''38aa4fbc-2d5f-44e3-ba23-b523c2a0a0f8'',''Type_Belegsart'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''246cc967-805d-416d-8d85-b6dd5ead1f09'') = 0
	insert into semtbl_Token VALUES(''246cc967-805d-416d-8d85-b6dd5ead1f09'',''Token_Software_Development_Bill_Module'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3fc83b93-335a-4334-b2b3-b6edee0e92a6'') = 0
	insert into semtbl_Token VALUES(''3fc83b93-335a-4334-b2b3-b6edee0e92a6'',''Type_Bankleitzahl'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''860ea080-d714-4d1d-a717-b9fed7fd4697'') = 0
	insert into semtbl_Token VALUES(''860ea080-d714-4d1d-a717-b9fed7fd4697'',''RelationType_accountings'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''59df733f-6853-4af3-87d6-bd769bc34684'') = 0
	insert into semtbl_Token VALUES(''59df733f-6853-4af3-87d6-bd769bc34684'',''Type_Search_Template'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''af023fc2-9351-43ad-8c3b-beffe7ec3b54'') = 0
	insert into semtbl_Token VALUES(''af023fc2-9351-43ad-8c3b-beffe7ec3b54'',''Token_Module_Bill_Module'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''182cb7bc-21ae-4b32-9e14-bfc1f43ccf6f'') = 0
	insert into semtbl_Token VALUES(''182cb7bc-21ae-4b32-9e14-bfc1f43ccf6f'',''Type_Einheit'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ab503cd6-0b71-4939-9bbd-c4af5380c016'') = 0
	insert into semtbl_Token VALUES(''ab503cd6-0b71-4939-9bbd-c4af5380c016'',''Attribute_Amount'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''19cc7e70-8782-4052-ab78-c62be7ecd550'') = 0
	insert into semtbl_Token VALUES(''19cc7e70-8782-4052-ab78-c62be7ecd550'',''RelationType_belonging_Contractee'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cc820013-24df-4024-8511-cc616b6962e6'') = 0
	insert into semtbl_Token VALUES(''cc820013-24df-4024-8511-cc616b6962e6'',''RelationType_Gegenkonto'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8618f96e-8494-432a-99da-cc91e6c117d5'') = 0
	insert into semtbl_Token VALUES(''8618f96e-8494-432a-99da-cc91e6c117d5'',''RelationType_located_in'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''da14dafa-132a-4273-8c6a-d03b7b6d72c4'') = 0
	insert into semtbl_Token VALUES(''da14dafa-132a-4273-8c6a-d03b7b6d72c4'',''Attribute_gross'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6562615e-a995-491c-806b-d17280d11528'') = 0
	insert into semtbl_Token VALUES(''6562615e-a995-491c-806b-d17280d11528'',''Token_Search_Template_Transaction_Date_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''03dd731a-986b-4d76-b6eb-d426b897edff'') = 0
	insert into semtbl_Token VALUES(''03dd731a-986b-4d76-b6eb-d426b897edff'',''Type_Tax_Rates'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''05494c25-0ab5-4166-a6eb-db7ce0c45c2c'') = 0
	insert into semtbl_Token VALUES(''05494c25-0ab5-4166-a6eb-db7ce0c45c2c'',''Type_Offset'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e0a7a86d-b267-4929-b0b5-dbe2c1f562de'') = 0
	insert into semtbl_Token VALUES(''e0a7a86d-b267-4929-b0b5-dbe2c1f562de'',''Attribute_to_Pay'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2bdea47c-49c1-4af3-a605-dd0396f75122'') = 0
	insert into semtbl_Token VALUES(''2bdea47c-49c1-4af3-a605-dd0396f75122'',''Token_Search_Template_to_Pay_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''22faaa6d-8fbe-4b5a-8856-dec1fbcb5959'') = 0
	insert into semtbl_Token VALUES(''22faaa6d-8fbe-4b5a-8856-dec1fbcb5959'',''RelationType_offers'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''82be9300-79bd-407f-8c77-e429a2dafc58'') = 0
	insert into semtbl_Token VALUES(''82be9300-79bd-407f-8c77-e429a2dafc58'',''Token_Search_Template_Name_'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5ec2ef03-1fdc-44d1-8af8-e43ff33f7065'') = 0
	insert into semtbl_Token VALUES(''5ec2ef03-1fdc-44d1-8af8-e43ff33f7065'',''RelationType_belonging_Sem_Item'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6f48ee26-dad5-40c5-8e68-e53c5f98583a'') = 0
	insert into semtbl_Token VALUES(''6f48ee26-dad5-40c5-8e68-e53c5f98583a'',''Attribute_part____'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''92121dac-d796-4dac-acc8-ea779f9cb1cd'') = 0
	insert into semtbl_Token VALUES(''92121dac-d796-4dac-acc8-ea779f9cb1cd'',''Type_Partner'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cdf1e2a4-accf-4092-9f46-ea9ca54b825e'') = 0
	insert into semtbl_Token VALUES(''cdf1e2a4-accf-4092-9f46-ea9ca54b825e'',''Type_Financial_Transaction___Archive'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9cff47c6-3a76-4c35-b0bc-8bf26addbd3c'') = 0
	insert into semtbl_Token VALUES(''9cff47c6-3a76-4c35-b0bc-8bf26addbd3c'',''Related Sem-Item:'',''499ec20d-af6f-4e72-bf55-ffb6eac101bf'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''14cc9088-fd98-45f9-957e-b4bf519bf6f5'') = 0
	insert into semtbl_Token VALUES(''14cc9088-fd98-45f9-957e-b4bf519bf6f5'',''Up'',''3d1dc6cf-b964-4986-9808-f39b7c5c3907'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e7dd29f6-8966-4dd7-8230-ea716ada368a'') = 0
	insert into semtbl_Token VALUES(''e7dd29f6-8966-4dd7-8230-ea716ada368a'',''Contractee/Contractor:'',''499ec20d-af6f-4e72-bf55-ffb6eac101bf'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ef419235-2d55-4ce7-a0f4-6702ab57fbb7'') = 0
	insert into semtbl_Token VALUES(''ef419235-2d55-4ce7-a0f4-6702ab57fbb7'',''Down'',''3d1dc6cf-b964-4986-9808-f39b7c5c3907'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2bd1ea49-dc70-402e-90c8-8267b1c5ca6a'') = 0
	insert into semtbl_Token VALUES(''2bd1ea49-dc70-402e-90c8-8267b1c5ca6a'',''Amount:'',''499ec20d-af6f-4e72-bf55-ffb6eac101bf'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1668fb78-fdc6-4618-b5cc-1be00741a2ab'') = 0
	insert into semtbl_Token VALUES(''1668fb78-fdc6-4618-b5cc-1be00741a2ab'',''Payment-Date:'',''499ec20d-af6f-4e72-bf55-ffb6eac101bf'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d457a21a-30a3-4751-a7d5-ad3892145c22'') = 0
	insert into semtbl_Token VALUES(''d457a21a-30a3-4751-a7d5-ad3892145c22'',''Bill-Module'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''47ac1a66-8e2c-4966-b1c6-4b27e829efa6'') = 0
	insert into semtbl_Token VALUES(''47ac1a66-8e2c-4966-b1c6-4b27e829efa6'',''Transaction-Date:'',''499ec20d-af6f-4e72-bf55-ffb6eac101bf'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a67061a5-1e92-4625-96ad-5b4f01ba61b7'') = 0
	insert into semtbl_Token VALUES(''a67061a5-1e92-4625-96ad-5b4f01ba61b7'',''to Pay:'',''499ec20d-af6f-4e72-bf55-ffb6eac101bf'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a030d27f-d920-4a87-a513-faaf4ccd2af7'') = 0
	insert into semtbl_Token VALUES(''a030d27f-d920-4a87-a513-faaf4ccd2af7'',''Name/GUID:'',''499ec20d-af6f-4e72-bf55-ffb6eac101bf'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''46ff89f6-3dcc-40cc-80a5-2cab5b8e1329'') = 0
	insert into semtbl_Token VALUES(''46ff89f6-3dcc-40cc-80a5-2cab5b8e1329'',''Base-Config'',''9e508361-7de6-4087-bdae-30933cdb8843'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''935cc11d-12c8-46c8-922d-041d0d603edf'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''935cc11d-12c8-46c8-922d-041d0d603edf'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''02e20c29-88bf-4887-9767-05245f5245a9'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''02e20c29-88bf-4887-9767-05245f5245a9'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''269a5f7e-f51e-4f51-bb51-06c3ad50e3b8'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''269a5f7e-f51e-4f51-bb51-06c3ad50e3b8'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''a4fdcad2-0b82-42aa-848b-08b89b4f1354'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''a4fdcad2-0b82-42aa-848b-08b89b4f1354'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''f2aca284-8ee0-4150-938b-09a43e7eafb7'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''f2aca284-8ee0-4150-938b-09a43e7eafb7'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''e26211f2-d7ee-44fd-ac09-0ffa5f82fa2b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''e26211f2-d7ee-44fd-ac09-0ffa5f82fa2b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''a2e20bb7-6423-4807-98c1-107837996076'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''a2e20bb7-6423-4807-98c1-107837996076'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''e39c0ac5-21b0-4c4b-b365-1a88e4b517de'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''e39c0ac5-21b0-4c4b-b365-1a88e4b517de'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''e8305ca1-2e88-4267-b33d-1ae571916997'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''e8305ca1-2e88-4267-b33d-1ae571916997'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''93ef4864-7a54-45aa-ad5e-1e38da9ebcfc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''93ef4864-7a54-45aa-ad5e-1e38da9ebcfc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''407f4a7e-db85-47ab-b58c-20169856f25c'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''407f4a7e-db85-47ab-b58c-20169856f25c'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''6e913914-7ca1-48c3-b342-20fba8c57c9b'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''6e913914-7ca1-48c3-b342-20fba8c57c9b'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''669c5918-f565-428b-b3a6-387fbe2a3c58'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''669c5918-f565-428b-b3a6-387fbe2a3c58'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''0f211b81-efac-4dc0-9c7a-3aeba969ad46'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''0f211b81-efac-4dc0-9c7a-3aeba969ad46'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''fb69b5e3-2b0a-47ad-8424-4692c2e83175'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''fb69b5e3-2b0a-47ad-8424-4692c2e83175'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''3fcdf63c-8f33-4e7e-912b-4e3fc4e92dd9'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''3fcdf63c-8f33-4e7e-912b-4e3fc4e92dd9'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''d27bed40-7392-493f-ab1f-4ef2bbc64575'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''d27bed40-7392-493f-ab1f-4ef2bbc64575'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''bf074291-2897-48d3-b704-52368c845f09'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''bf074291-2897-48d3-b704-52368c845f09'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''d2cdfee8-39e6-4b0a-b1dc-555da5c2a3b5'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''d2cdfee8-39e6-4b0a-b1dc-555da5c2a3b5'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''b7db9126-e04e-42ff-8e1e-66a1b872574d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''b7db9126-e04e-42ff-8e1e-66a1b872574d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''1306f4a9-7754-44b6-a33f-68884a947568'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''1306f4a9-7754-44b6-a33f-68884a947568'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''6c966e3c-c737-4af1-9970-68c8323679bc'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''6c966e3c-c737-4af1-9970-68c8323679bc'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''15820ab1-0945-4e72-9792-6dd480e73954'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''15820ab1-0945-4e72-9792-6dd480e73954'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''e9944776-131a-4333-8730-70555b96f1c9'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''e9944776-131a-4333-8730-70555b96f1c9'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''6e494944-f602-4dcb-906f-70e5efe8f1dd'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''cb8555b7-9128-4a29-a9f7-76e9c8ec25f9'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''cb8555b7-9128-4a29-a9f7-76e9c8ec25f9'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''f2cde058-614e-41cb-96eb-78bbcf285171'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''f2cde058-614e-41cb-96eb-78bbcf285171'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''c473b0f4-f7b1-4ef5-8f8e-8cd17ae1abb3'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''c473b0f4-f7b1-4ef5-8f8e-8cd17ae1abb3'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''46551f18-1c7b-4b0d-8c48-8cf7582d4c64'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''46551f18-1c7b-4b0d-8c48-8cf7582d4c64'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''f75d75b7-d053-4b73-93d3-9319c7ae8c82'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''f75d75b7-d053-4b73-93d3-9319c7ae8c82'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''5221f303-5fc8-4d8c-9f99-9c5422159c79'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''5221f303-5fc8-4d8c-9f99-9c5422159c79'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''6a59f3d6-033e-4db5-95a9-a5130c482c76'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''6a59f3d6-033e-4db5-95a9-a5130c482c76'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''00acaf8d-b90b-426b-84d9-a58ff944f66c'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''00acaf8d-b90b-426b-84d9-a58ff944f66c'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''075cb4b9-65bf-4fd5-abf8-a6c4deb57282'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''075cb4b9-65bf-4fd5-abf8-a6c4deb57282'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''87eb4dc0-bdae-4c49-bf3c-a70ea7a6a4d6'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''87eb4dc0-bdae-4c49-bf3c-a70ea7a6a4d6'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''87068490-d91a-4d25-b400-a836b040603e'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''87068490-d91a-4d25-b400-a836b040603e'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''3186cc5e-023b-4edc-b6c7-a89919320839'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''9b18d3ce-ffcf-4948-ad4d-abcc02664d75'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''9b18d3ce-ffcf-4948-ad4d-abcc02664d75'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''38aa4fbc-2d5f-44e3-ba23-b523c2a0a0f8'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''38aa4fbc-2d5f-44e3-ba23-b523c2a0a0f8'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''246cc967-805d-416d-8d85-b6dd5ead1f09'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''246cc967-805d-416d-8d85-b6dd5ead1f09'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''3fc83b93-335a-4334-b2b3-b6edee0e92a6'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''3fc83b93-335a-4334-b2b3-b6edee0e92a6'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''860ea080-d714-4d1d-a717-b9fed7fd4697'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''860ea080-d714-4d1d-a717-b9fed7fd4697'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''59df733f-6853-4af3-87d6-bd769bc34684'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''59df733f-6853-4af3-87d6-bd769bc34684'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''af023fc2-9351-43ad-8c3b-beffe7ec3b54'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''af023fc2-9351-43ad-8c3b-beffe7ec3b54'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''182cb7bc-21ae-4b32-9e14-bfc1f43ccf6f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''182cb7bc-21ae-4b32-9e14-bfc1f43ccf6f'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''ab503cd6-0b71-4939-9bbd-c4af5380c016'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''ab503cd6-0b71-4939-9bbd-c4af5380c016'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''19cc7e70-8782-4052-ab78-c62be7ecd550'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''19cc7e70-8782-4052-ab78-c62be7ecd550'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''cc820013-24df-4024-8511-cc616b6962e6'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''cc820013-24df-4024-8511-cc616b6962e6'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''8618f96e-8494-432a-99da-cc91e6c117d5'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''8618f96e-8494-432a-99da-cc91e6c117d5'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''da14dafa-132a-4273-8c6a-d03b7b6d72c4'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''da14dafa-132a-4273-8c6a-d03b7b6d72c4'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''6562615e-a995-491c-806b-d17280d11528'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''6562615e-a995-491c-806b-d17280d11528'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''03dd731a-986b-4d76-b6eb-d426b897edff'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''03dd731a-986b-4d76-b6eb-d426b897edff'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''05494c25-0ab5-4166-a6eb-db7ce0c45c2c'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''05494c25-0ab5-4166-a6eb-db7ce0c45c2c'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''e0a7a86d-b267-4929-b0b5-dbe2c1f562de'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''e0a7a86d-b267-4929-b0b5-dbe2c1f562de'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''2bdea47c-49c1-4af3-a605-dd0396f75122'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''2bdea47c-49c1-4af3-a605-dd0396f75122'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''22faaa6d-8fbe-4b5a-8856-dec1fbcb5959'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''22faaa6d-8fbe-4b5a-8856-dec1fbcb5959'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''82be9300-79bd-407f-8c77-e429a2dafc58'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''82be9300-79bd-407f-8c77-e429a2dafc58'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''5ec2ef03-1fdc-44d1-8af8-e43ff33f7065'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''5ec2ef03-1fdc-44d1-8af8-e43ff33f7065'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''6f48ee26-dad5-40c5-8e68-e53c5f98583a'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''6f48ee26-dad5-40c5-8e68-e53c5f98583a'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''92121dac-d796-4dac-acc8-ea779f9cb1cd'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''92121dac-d796-4dac-acc8-ea779f9cb1cd'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_Token_Right=''cdf1e2a4-accf-4092-9f46-ea9ca54b825e'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Token_Token VALUES(''b6f1f499-a905-43d9-838b-11a2977299cc'',''cdf1e2a4-accf-4092-9f46-ea9ca54b825e'',''e9711603-47db-44d8-a476-fe88290639a4'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''9b0183f0-c787-4fe8-b5bd-fe038ccd4a7c'' AND GUID_Token_Right=''b6f1f499-a905-43d9-838b-11a2977299cc'' AND GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	INSERT INTO semtbl_Token_Token VALUES(''9b0183f0-c787-4fe8-b5bd-fe038ccd4a7c'',''b6f1f499-a905-43d9-838b-11a2977299cc'',''fafc1464-815f-4596-9737-bcbc96bd744a'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d457a21a-30a3-4751-a7d5-ad3892145c22'' AND GUID_Token_Right=''1668fb78-fdc6-4618-b5cc-1be00741a2ab'' AND GUID_RelationType=''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d457a21a-30a3-4751-a7d5-ad3892145c22'',''1668fb78-fdc6-4618-b5cc-1be00741a2ab'',''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'',3)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d457a21a-30a3-4751-a7d5-ad3892145c22'' AND GUID_Token_Right=''47ac1a66-8e2c-4966-b1c6-4b27e829efa6'' AND GUID_RelationType=''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d457a21a-30a3-4751-a7d5-ad3892145c22'',''47ac1a66-8e2c-4966-b1c6-4b27e829efa6'',''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'',5)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d457a21a-30a3-4751-a7d5-ad3892145c22'' AND GUID_Token_Right=''a67061a5-1e92-4625-96ad-5b4f01ba61b7'' AND GUID_RelationType=''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d457a21a-30a3-4751-a7d5-ad3892145c22'',''a67061a5-1e92-4625-96ad-5b4f01ba61b7'',''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'',4)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d457a21a-30a3-4751-a7d5-ad3892145c22'' AND GUID_Token_Right=''2bd1ea49-dc70-402e-90c8-8267b1c5ca6a'' AND GUID_RelationType=''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d457a21a-30a3-4751-a7d5-ad3892145c22'',''2bd1ea49-dc70-402e-90c8-8267b1c5ca6a'',''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'',2)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d457a21a-30a3-4751-a7d5-ad3892145c22'' AND GUID_Token_Right=''9cff47c6-3a76-4c35-b0bc-8bf26addbd3c'' AND GUID_RelationType=''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d457a21a-30a3-4751-a7d5-ad3892145c22'',''9cff47c6-3a76-4c35-b0bc-8bf26addbd3c'',''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d457a21a-30a3-4751-a7d5-ad3892145c22'' AND GUID_Token_Right=''e7dd29f6-8966-4dd7-8230-ea716ada368a'' AND GUID_RelationType=''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d457a21a-30a3-4751-a7d5-ad3892145c22'',''e7dd29f6-8966-4dd7-8230-ea716ada368a'',''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d457a21a-30a3-4751-a7d5-ad3892145c22'' AND GUID_Token_Right=''a030d27f-d920-4a87-a513-faaf4ccd2af7'' AND GUID_RelationType=''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d457a21a-30a3-4751-a7d5-ad3892145c22'',''a030d27f-d920-4a87-a513-faaf4ccd2af7'',''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''d457a21a-30a3-4751-a7d5-ad3892145c22'' AND GUID_Token_Right=''9b0183f0-c787-4fe8-b5bd-fe038ccd4a7c'' AND GUID_RelationType=''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')=0
	INSERT INTO semtbl_Token_Token VALUES(''d457a21a-30a3-4751-a7d5-ad3892145c22'',''9b0183f0-c787-4fe8-b5bd-fe038ccd4a7c'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''46ff89f6-3dcc-40cc-80a5-2cab5b8e1329'' AND GUID_Token_Right=''d457a21a-30a3-4751-a7d5-ad3892145c22'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''46ff89f6-3dcc-40cc-80a5-2cab5b8e1329'',''d457a21a-30a3-4751-a7d5-ad3892145c22'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6401e369-4445-49a3-9822-1029a4c1b8b8'' AND GUID_Attribute=''699e0400-0b0d-4447-91eb-1df6d861eacb'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6401e369-4445-49a3-9822-1029a4c1b8b8'',''699e0400-0b0d-4447-91eb-1df6d861eacb'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6401e369-4445-49a3-9822-1029a4c1b8b8'' AND GUID_Attribute=''96405d28-0826-40e6-8e55-30d1ecc0542a'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6401e369-4445-49a3-9822-1029a4c1b8b8'',''96405d28-0826-40e6-8e55-30d1ecc0542a'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6401e369-4445-49a3-9822-1029a4c1b8b8'' AND GUID_Attribute=''9342e9b0-842c-4a01-baea-50d77881a195'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6401e369-4445-49a3-9822-1029a4c1b8b8'',''9342e9b0-842c-4a01-baea-50d77881a195'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6401e369-4445-49a3-9822-1029a4c1b8b8'' AND GUID_Attribute=''417f6a60-e5d5-4470-8871-8079c0cac065'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6401e369-4445-49a3-9822-1029a4c1b8b8'',''417f6a60-e5d5-4470-8871-8079c0cac065'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6401e369-4445-49a3-9822-1029a4c1b8b8'' AND GUID_Attribute=''dc5045bb-1b83-4139-b6d4-a1a561529dca'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6401e369-4445-49a3-9822-1029a4c1b8b8'',''dc5045bb-1b83-4139-b6d4-a1a561529dca'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6401e369-4445-49a3-9822-1029a4c1b8b8'' AND GUID_Attribute=''dec493e8-b24b-4f45-9d67-c33d5da30939'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6401e369-4445-49a3-9822-1029a4c1b8b8'',''dec493e8-b24b-4f45-9d67-c33d5da30939'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''6401e369-4445-49a3-9822-1029a4c1b8b8'' AND GUID_Attribute=''48f8f02d-6068-4319-8526-e66f8063af4e'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''6401e369-4445-49a3-9822-1029a4c1b8b8'',''48f8f02d-6068-4319-8526-e66f8063af4e'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''5f7a0238-859e-4eec-9f69-3038192cf56f'' AND GUID_Attribute=''daf53cbc-2cb4-42ed-8722-ee85f6b33512'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''5f7a0238-859e-4eec-9f69-3038192cf56f'',''daf53cbc-2cb4-42ed-8722-ee85f6b33512'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''b7ea6186-327a-43eb-be5b-8f39ea599155'' AND GUID_Attribute=''eb9f0536-d97b-40b6-b7ee-b7018f6caa0e'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''b7ea6186-327a-43eb-be5b-8f39ea599155'',''eb9f0536-d97b-40b6-b7ee-b7018f6caa0e'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''b7ea6186-327a-43eb-be5b-8f39ea599155'' AND GUID_Attribute=''8824ecf1-5957-44ee-9114-de52c1305a39'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''b7ea6186-327a-43eb-be5b-8f39ea599155'',''8824ecf1-5957-44ee-9114-de52c1305a39'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''b7ea6186-327a-43eb-be5b-8f39ea599155'' AND GUID_Attribute=''1bb51893-8518-49d9-b7b3-e9ee140ab526'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''b7ea6186-327a-43eb-be5b-8f39ea599155'',''1bb51893-8518-49d9-b7b3-e9ee140ab526'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''4a6430a8-89f3-409b-883c-3641a8b88898'' AND GUID_Attribute=''5d09a3e9-03fb-436c-8450-1a50bf1267b6'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''4a6430a8-89f3-409b-883c-3641a8b88898'',''5d09a3e9-03fb-436c-8450-1a50bf1267b6'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''4a6430a8-89f3-409b-883c-3641a8b88898'' AND GUID_Attribute=''2424da1a-59f9-463b-8d13-473377702fc2'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''4a6430a8-89f3-409b-883c-3641a8b88898'',''2424da1a-59f9-463b-8d13-473377702fc2'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''4a6430a8-89f3-409b-883c-3641a8b88898'' AND GUID_Attribute=''eaf21eed-54e0-4afc-8b50-8497db6e0cdd'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''4a6430a8-89f3-409b-883c-3641a8b88898'',''eaf21eed-54e0-4afc-8b50-8497db6e0cdd'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''4a6430a8-89f3-409b-883c-3641a8b88898'' AND GUID_Attribute=''8824ecf1-5957-44ee-9114-de52c1305a39'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''4a6430a8-89f3-409b-883c-3641a8b88898'',''8824ecf1-5957-44ee-9114-de52c1305a39'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''9e508361-7de6-4087-bdae-30933cdb8843'' AND GUID_Attribute=''212ca6eb-3c72-4cd4-8609-0fef351f08cc'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''9e508361-7de6-4087-bdae-30933cdb8843'',''212ca6eb-3c72-4cd4-8609-0fef351f08cc'',1,1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''d88808d0-0473-4594-a8f9-6c4cb3439297'' AND GUID_Attribute=''b0b91f06-5c33-470b-8b1a-4c5c93d53ea2'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''d88808d0-0473-4594-a8f9-6c4cb3439297'',''b0b91f06-5c33-470b-8b1a-4c5c93d53ea2'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''53aa29b7-36e1-4511-b9a4-a743a5fc4535'' AND GUID_Attribute=''cee3873e-c7ae-48d5-a4b7-d4ffd293fe14'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''53aa29b7-36e1-4511-b9a4-a743a5fc4535'',''cee3873e-c7ae-48d5-a4b7-d4ffd293fe14'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''51cda3ce-2ad8-46f1-a098-b7bcf0c2eba2'' AND GUID_Attribute=''dc5045bb-1b83-4139-b6d4-a1a561529dca'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''51cda3ce-2ad8-46f1-a098-b7bcf0c2eba2'',''dc5045bb-1b83-4139-b6d4-a1a561529dca'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6401e369-4445-49a3-9822-1029a4c1b8b8'' AND GUID_Type_Right=''d4ef7be6-afaf-42e2-8596-61d70b886c23'' AND GUID_RelationType=''f9543325-338b-45ef-9fbd-453563cdcc6a'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6401e369-4445-49a3-9822-1029a4c1b8b8'',''d4ef7be6-afaf-42e2-8596-61d70b886c23'',''f9543325-338b-45ef-9fbd-453563cdcc6a'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6401e369-4445-49a3-9822-1029a4c1b8b8'' AND GUID_Type_Right=''d4ef7be6-afaf-42e2-8596-61d70b886c23'' AND GUID_RelationType=''06b93890-d922-47ed-b70e-5e9cbd03df52'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6401e369-4445-49a3-9822-1029a4c1b8b8'',''d4ef7be6-afaf-42e2-8596-61d70b886c23'',''06b93890-d922-47ed-b70e-5e9cbd03df52'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6401e369-4445-49a3-9822-1029a4c1b8b8'' AND GUID_Type_Right=''b7ea6186-327a-43eb-be5b-8f39ea599155'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6401e369-4445-49a3-9822-1029a4c1b8b8'',''b7ea6186-327a-43eb-be5b-8f39ea599155'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''6401e369-4445-49a3-9822-1029a4c1b8b8'' AND GUID_Type_Right=''e864f198-1df0-4d53-bb87-959bc8884919'' AND GUID_RelationType=''79671239-9c8f-493c-b5e7-49700f9543f4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''6401e369-4445-49a3-9822-1029a4c1b8b8'',''e864f198-1df0-4d53-bb87-959bc8884919'',''79671239-9c8f-493c-b5e7-49700f9543f4'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'' AND GUID_Type_Right=''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'' AND GUID_RelationType=''f77ee633-19d8-4ea6-947f-9fb6efad3547'')=0
	INSERT INTO semtbl_Type_Type VALUES(''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'',''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'',''f77ee633-19d8-4ea6-947f-9fb6efad3547'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'' AND GUID_Type_Right=''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'' AND GUID_RelationType=''c9670b90-e5f0-4e30-a26d-ad3d6576ceac'')=0
	INSERT INTO semtbl_Type_Type VALUES(''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'',''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'',''c9670b90-e5f0-4e30-a26d-ad3d6576ceac'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''952ba315-3c21-44fb-9bbc-2192e971b906'' AND GUID_Type_Right=''3f806e96-422c-46ef-b9e5-609e91a8c27b'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Type_Type VALUES(''952ba315-3c21-44fb-9bbc-2192e971b906'',''3f806e96-422c-46ef-b9e5-609e91a8c27b'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''952ba315-3c21-44fb-9bbc-2192e971b906'' AND GUID_Type_Right=''57642009-3978-4db7-9b38-c2a526cdeaee'' AND GUID_RelationType=''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'')=0
	INSERT INTO semtbl_Type_Type VALUES(''952ba315-3c21-44fb-9bbc-2192e971b906'',''57642009-3978-4db7-9b38-c2a526cdeaee'',''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''5f7a0238-859e-4eec-9f69-3038192cf56f'' AND GUID_Type_Right=''d88808d0-0473-4594-a8f9-6c4cb3439297'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Type_Type VALUES(''5f7a0238-859e-4eec-9f69-3038192cf56f'',''d88808d0-0473-4594-a8f9-6c4cb3439297'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9e508361-7de6-4087-bdae-30933cdb8843'' AND GUID_Type_Right=''e79ff4de-2e39-4101-b5a1-0055c40f41cd'' AND GUID_RelationType=''1700a8b9-5f32-44ec-8687-1c5ddb84e109'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9e508361-7de6-4087-bdae-30933cdb8843'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'',''1700a8b9-5f32-44ec-8687-1c5ddb84e109'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9e508361-7de6-4087-bdae-30933cdb8843'' AND GUID_Type_Right=''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'' AND GUID_RelationType=''4b0ffa28-3fe2-4303-8880-226530f363cb'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9e508361-7de6-4087-bdae-30933cdb8843'',''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'',''4b0ffa28-3fe2-4303-8880-226530f363cb'',1,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9e508361-7de6-4087-bdae-30933cdb8843'' AND GUID_Type_Right=''e864f198-1df0-4d53-bb87-959bc8884919'' AND GUID_RelationType=''d91da85b-793c-431c-9724-8ddc1ace170e'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9e508361-7de6-4087-bdae-30933cdb8843'',''e864f198-1df0-4d53-bb87-959bc8884919'',''d91da85b-793c-431c-9724-8ddc1ace170e'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9e508361-7de6-4087-bdae-30933cdb8843'' AND GUID_Type_Right=''53aa29b7-36e1-4511-b9a4-a743a5fc4535'' AND GUID_RelationType=''d91da85b-793c-431c-9724-8ddc1ace170e'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9e508361-7de6-4087-bdae-30933cdb8843'',''53aa29b7-36e1-4511-b9a4-a743a5fc4535'',''d91da85b-793c-431c-9724-8ddc1ace170e'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''9e508361-7de6-4087-bdae-30933cdb8843'' AND GUID_Type_Right=''aa616051-e521-4fac-abdb-cbba6f8c6e73'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''9e508361-7de6-4087-bdae-30933cdb8843'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''4a6430a8-89f3-409b-883c-3641a8b88898'' AND GUID_Type_Right=''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'' AND GUID_RelationType=''ad99b56c-f3b5-4cca-9442-459b9a835098'')=0
	INSERT INTO semtbl_Type_Type VALUES(''4a6430a8-89f3-409b-883c-3641a8b88898'',''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'',''ad99b56c-f3b5-4cca-9442-459b9a835098'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''4a6430a8-89f3-409b-883c-3641a8b88898'' AND GUID_Type_Right=''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'' AND GUID_RelationType=''59fc1def-0977-44fc-af4c-70dad8f7d723'')=0
	INSERT INTO semtbl_Type_Type VALUES(''4a6430a8-89f3-409b-883c-3641a8b88898'',''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'',''59fc1def-0977-44fc-af4c-70dad8f7d723'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''4a6430a8-89f3-409b-883c-3641a8b88898'' AND GUID_Type_Right=''952ba315-3c21-44fb-9bbc-2192e971b906'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''4a6430a8-89f3-409b-883c-3641a8b88898'',''952ba315-3c21-44fb-9bbc-2192e971b906'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''4a6430a8-89f3-409b-883c-3641a8b88898'' AND GUID_Type_Right=''5f7a0238-859e-4eec-9f69-3038192cf56f'' AND GUID_RelationType=''74585903-16e3-48a1-9ee7-0329c8569a56'')=0
	INSERT INTO semtbl_Type_Type VALUES(''4a6430a8-89f3-409b-883c-3641a8b88898'',''5f7a0238-859e-4eec-9f69-3038192cf56f'',''74585903-16e3-48a1-9ee7-0329c8569a56'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''4a6430a8-89f3-409b-883c-3641a8b88898'' AND GUID_Type_Right=''4a6430a8-89f3-409b-883c-3641a8b88898'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''4a6430a8-89f3-409b-883c-3641a8b88898'',''4a6430a8-89f3-409b-883c-3641a8b88898'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''4a6430a8-89f3-409b-883c-3641a8b88898'' AND GUID_Type_Right=''b7ea6186-327a-43eb-be5b-8f39ea599155'' AND GUID_RelationType=''51074f19-35fa-4f63-b9fd-1bbceb81aa0d'')=0
	INSERT INTO semtbl_Type_Type VALUES(''4a6430a8-89f3-409b-883c-3641a8b88898'',''b7ea6186-327a-43eb-be5b-8f39ea599155'',''51074f19-35fa-4f63-b9fd-1bbceb81aa0d'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''4a6430a8-89f3-409b-883c-3641a8b88898'' AND GUID_Type_Right=''e864f198-1df0-4d53-bb87-959bc8884919'' AND GUID_RelationType=''fd4bacff-5ab6-4681-9b7c-a43d0fcbdf3d'')=0
	INSERT INTO semtbl_Type_Type VALUES(''4a6430a8-89f3-409b-883c-3641a8b88898'',''e864f198-1df0-4d53-bb87-959bc8884919'',''fd4bacff-5ab6-4681-9b7c-a43d0fcbdf3d'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''4a6430a8-89f3-409b-883c-3641a8b88898'' AND GUID_Type_Right=''53aa29b7-36e1-4511-b9a4-a743a5fc4535'' AND GUID_RelationType=''0b9a8992-349c-4e4b-9f06-1d954222bd8f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''4a6430a8-89f3-409b-883c-3641a8b88898'',''53aa29b7-36e1-4511-b9a4-a743a5fc4535'',''0b9a8992-349c-4e4b-9f06-1d954222bd8f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''d4ef7be6-afaf-42e2-8596-61d70b886c23'' AND GUID_Type_Right=''b6551e7a-b9c8-4d98-94c6-076dcf8cd12b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''d4ef7be6-afaf-42e2-8596-61d70b886c23'',''b6551e7a-b9c8-4d98-94c6-076dcf8cd12b'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''d88808d0-0473-4594-a8f9-6c4cb3439297'' AND GUID_Type_Right=''d88808d0-0473-4594-a8f9-6c4cb3439297'' AND GUID_RelationType=''5d8f540c-3e92-4999-a710-ce7f2dd611de'')=0
	INSERT INTO semtbl_Type_Type VALUES(''d88808d0-0473-4594-a8f9-6c4cb3439297'',''d88808d0-0473-4594-a8f9-6c4cb3439297'',''5d8f540c-3e92-4999-a710-ce7f2dd611de'',0,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''53aa29b7-36e1-4511-b9a4-a743a5fc4535'' AND GUID_Type_Right=''d88808d0-0473-4594-a8f9-6c4cb3439297'' AND GUID_RelationType=''9996494a-ef6a-4357-a6ef-71a92b5ff596'')=0
	INSERT INTO semtbl_Type_Type VALUES(''53aa29b7-36e1-4511-b9a4-a743a5fc4535'',''d88808d0-0473-4594-a8f9-6c4cb3439297'',''9996494a-ef6a-4357-a6ef-71a92b5ff596'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''51cda3ce-2ad8-46f1-a098-b7bcf0c2eba2'' AND GUID_Type_Right=''51cda3ce-2ad8-46f1-a098-b7bcf0c2eba2'' AND GUID_RelationType=''b07efa3b-6184-4cf0-8f8b-0ce49a4f397e'')=0
	INSERT INTO semtbl_Type_Type VALUES(''51cda3ce-2ad8-46f1-a098-b7bcf0c2eba2'',''51cda3ce-2ad8-46f1-a098-b7bcf0c2eba2'',''b07efa3b-6184-4cf0-8f8b-0ce49a4f397e'',2,2,-1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''c6c9bcb8-0ac9-4713-9417-eeec1453026c'' AND GUID_Type_Right=''13c09f11-175c-4eef-bc8a-0fd8e86d557f'' AND GUID_RelationType=''e9711603-47db-44d8-a476-fe88290639a4'')=0
	INSERT INTO semtbl_Type_Type VALUES(''c6c9bcb8-0ac9-4713-9417-eeec1453026c'',''13c09f11-175c-4eef-bc8a-0fd8e86d557f'',''e9711603-47db-44d8-a476-fe88290639a4'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''e79ff4de-2e39-4101-b5a1-0055c40f41cd'' AND GUID_RelationType=''d91da85b-793c-431c-9724-8ddc1ace170e'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'',''d91da85b-793c-431c-9724-8ddc1ace170e'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''e79ff4de-2e39-4101-b5a1-0055c40f41cd'' AND GUID_RelationType=''dd5a24ec-e2bd-47c2-9761-d4a7db114aed'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'',''dd5a24ec-e2bd-47c2-9761-d4a7db114aed'',0,-1,-1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''93a909b4-9cab-40d1-8d16-69c3786dbc91'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''93a909b4-9cab-40d1-8d16-69c3786dbc91'',''9b0183f0-c787-4fe8-b5bd-fe038ccd4a7c'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Varchar255 WHERE GUID_TokenAttribute=''93a909b4-9cab-40d1-8d16-69c3786dbc91'' )=0
	INSERT INTO semtbl_Token_Attribute_Varchar255 VALUES(''93a909b4-9cab-40d1-8d16-69c3786dbc91'',''bill_module'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ce7ff21a-b472-4089-bdd8-633697c4ef75'')=0
	INSERT INTO semtbl_OR VALUES(''ce7ff21a-b472-4089-bdd8-633697c4ef75'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''dea74d8c-87f3-4dd1-8578-5f514325784c'')=0
	INSERT INTO semtbl_OR VALUES(''dea74d8c-87f3-4dd1-8578-5f514325784c'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8d75e64a-1bb7-4a94-85e3-d9bd5f309361'')=0
	INSERT INTO semtbl_OR VALUES(''8d75e64a-1bb7-4a94-85e3-d9bd5f309361'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''22c309ef-476e-4f8f-ae16-499b3a0f5850'')=0
	INSERT INTO semtbl_OR VALUES(''22c309ef-476e-4f8f-ae16-499b3a0f5850'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''32d040af-504c-436a-8839-b57db67d158a'')=0
	INSERT INTO semtbl_OR VALUES(''32d040af-504c-436a-8839-b57db67d158a'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'')=0
	INSERT INTO semtbl_OR VALUES(''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''5c06ce69-3cc0-495f-b95c-6219eeacdccc'')=0
	INSERT INTO semtbl_OR VALUES(''5c06ce69-3cc0-495f-b95c-6219eeacdccc'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''883daddb-7e9c-4b2d-b39c-edf8488f801d'')=0
	INSERT INTO semtbl_OR VALUES(''883daddb-7e9c-4b2d-b39c-edf8488f801d'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''26a6b04d-1012-4e2a-bf88-ed8a6a58081d'')=0
	INSERT INTO semtbl_OR VALUES(''26a6b04d-1012-4e2a-bf88-ed8a6a58081d'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6564fe74-1e10-4042-8266-fb870071fc84'')=0
	INSERT INTO semtbl_OR VALUES(''6564fe74-1e10-4042-8266-fb870071fc84'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''17739da9-759a-4312-8ab2-3e6900d1aa89'')=0
	INSERT INTO semtbl_OR VALUES(''17739da9-759a-4312-8ab2-3e6900d1aa89'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d046be26-4567-4b5d-80a0-c81104e30a55'')=0
	INSERT INTO semtbl_OR VALUES(''d046be26-4567-4b5d-80a0-c81104e30a55'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d64382b9-d639-48c2-b318-d03429ee1d9d'')=0
	INSERT INTO semtbl_OR VALUES(''d64382b9-d639-48c2-b318-d03429ee1d9d'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6c237ce7-4323-4abc-8a21-eb0929ba7470'')=0
	INSERT INTO semtbl_OR VALUES(''6c237ce7-4323-4abc-8a21-eb0929ba7470'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''990d4113-c2a3-49a9-9ee0-205c474da4d6'')=0
	INSERT INTO semtbl_OR VALUES(''990d4113-c2a3-49a9-9ee0-205c474da4d6'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''94639963-9017-4100-a6ab-a0b748ababce'')=0
	INSERT INTO semtbl_OR VALUES(''94639963-9017-4100-a6ab-a0b748ababce'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d54b4651-82c7-4990-8dca-a0b65a3b1797'')=0
	INSERT INTO semtbl_OR VALUES(''d54b4651-82c7-4990-8dca-a0b65a3b1797'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''68574556-640e-4701-a960-b60887a31bc1'')=0
	INSERT INTO semtbl_OR VALUES(''68574556-640e-4701-a960-b60887a31bc1'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e3e975d9-5d87-4966-9b3d-51cfcce5187b'')=0
	INSERT INTO semtbl_OR VALUES(''e3e975d9-5d87-4966-9b3d-51cfcce5187b'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''cc057336-11e7-4418-aad0-265f415b8d3c'')=0
	INSERT INTO semtbl_OR VALUES(''cc057336-11e7-4418-aad0-265f415b8d3c'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''60a5457a-66d2-4905-8dd5-9555589aff93'')=0
	INSERT INTO semtbl_OR VALUES(''60a5457a-66d2-4905-8dd5-9555589aff93'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''6e87d417-fe31-4f4c-9a92-3af93decd7ec'')=0
	INSERT INTO semtbl_OR VALUES(''6e87d417-fe31-4f4c-9a92-3af93decd7ec'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'')=0
	INSERT INTO semtbl_OR VALUES(''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''47121a8b-e65a-4683-b101-9dc5cd1966ac'')=0
	INSERT INTO semtbl_OR VALUES(''47121a8b-e65a-4683-b101-9dc5cd1966ac'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''48c6c6e8-e21c-489c-911e-b885aa90a5a8'')=0
	INSERT INTO semtbl_OR VALUES(''48c6c6e8-e21c-489c-911e-b885aa90a5a8'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'')=0
	INSERT INTO semtbl_OR VALUES(''008817a6-14e7-4295-9a69-6835575ae53b'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''c96f5af3-bb8a-4cec-9c06-6c1a6b6ce285'')=0
	INSERT INTO semtbl_OR VALUES(''c96f5af3-bb8a-4cec-9c06-6c1a6b6ce285'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'')=0
	INSERT INTO semtbl_OR VALUES(''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''4d749c0b-2896-4f64-ac73-37774038dd91'')=0
	INSERT INTO semtbl_OR VALUES(''4d749c0b-2896-4f64-ac73-37774038dd91'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''f3307576-4382-447f-912a-df5286da5d2a'')=0
	INSERT INTO semtbl_OR VALUES(''f3307576-4382-447f-912a-df5286da5d2a'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''ca9f765e-d27c-486d-addc-e4b4a0377183'')=0
	INSERT INTO semtbl_OR VALUES(''ca9f765e-d27c-486d-addc-e4b4a0377183'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''47404714-d512-4978-a925-e8d93ac51e22'')=0
	INSERT INTO semtbl_OR VALUES(''47404714-d512-4978-a925-e8d93ac51e22'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''c521a5b4-7d17-4e2e-add1-a8da88f93610'')=0
	INSERT INTO semtbl_OR VALUES(''c521a5b4-7d17-4e2e-add1-a8da88f93610'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''5baa6510-c430-4d29-ae46-6f7eb48ab706'')=0
	INSERT INTO semtbl_OR VALUES(''5baa6510-c430-4d29-ae46-6f7eb48ab706'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''3e82da63-d982-4fe8-8404-9c0cdbd3666f'')=0
	INSERT INTO semtbl_OR VALUES(''3e82da63-d982-4fe8-8404-9c0cdbd3666f'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''5b7370d1-c850-4203-9265-eabc2bcd2021'')=0
	INSERT INTO semtbl_OR VALUES(''5b7370d1-c850-4203-9265-eabc2bcd2021'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d5446649-f12d-4c7c-97cd-419987aa3362'')=0
	INSERT INTO semtbl_OR VALUES(''d5446649-f12d-4c7c-97cd-419987aa3362'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'')=0
	INSERT INTO semtbl_OR VALUES(''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''167400ed-21e9-4f2b-99f7-f2c92a912643'')=0
	INSERT INTO semtbl_OR VALUES(''167400ed-21e9-4f2b-99f7-f2c92a912643'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''200f575a-61eb-41ae-9b21-26324b1447e0'')=0
	INSERT INTO semtbl_OR VALUES(''200f575a-61eb-41ae-9b21-26324b1447e0'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''9bb12af4-6f81-47d2-927f-8171a0441026'')=0
	INSERT INTO semtbl_OR VALUES(''9bb12af4-6f81-47d2-927f-8171a0441026'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''7f4279a4-f539-4a59-b129-f713b516b891'')=0
	INSERT INTO semtbl_OR VALUES(''7f4279a4-f539-4a59-b129-f713b516b891'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''317ecc85-ce37-428e-96f2-3e273379bf94'')=0
	INSERT INTO semtbl_OR VALUES(''317ecc85-ce37-428e-96f2-3e273379bf94'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''dc545b73-2319-4914-a798-126b9e4c6d4c'')=0
	INSERT INTO semtbl_OR VALUES(''dc545b73-2319-4914-a798-126b9e4c6d4c'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''4fb1e8a0-b652-4545-98cb-b39c1b63a82a'')=0
	INSERT INTO semtbl_OR VALUES(''4fb1e8a0-b652-4545-98cb-b39c1b63a82a'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''9c9b2aba-8dbe-41eb-9ceb-3102b24a1cbd'')=0
	INSERT INTO semtbl_OR VALUES(''9c9b2aba-8dbe-41eb-9ceb-3102b24a1cbd'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''9b214b2c-dd5f-4a85-8833-42fa4bdd8fff'')=0
	INSERT INTO semtbl_OR VALUES(''9b214b2c-dd5f-4a85-8833-42fa4bdd8fff'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''9706f0c4-012a-4972-a490-c19f5313d0ac'')=0
	INSERT INTO semtbl_OR VALUES(''9706f0c4-012a-4972-a490-c19f5313d0ac'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''97049a1d-57f9-4840-b4a8-d55d674e600a'')=0
	INSERT INTO semtbl_OR VALUES(''97049a1d-57f9-4840-b4a8-d55d674e600a'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''c09ca6bf-b5fb-4121-b169-d389981a2ad4'')=0
	INSERT INTO semtbl_OR VALUES(''c09ca6bf-b5fb-4121-b169-d389981a2ad4'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''4d43b956-6c71-4a3b-9bc1-81eac2e03d3b'')=0
	INSERT INTO semtbl_OR VALUES(''4d43b956-6c71-4a3b-9bc1-81eac2e03d3b'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''7ff1a805-ceb6-4bbf-93d9-8c7dda5e0ec7'')=0
	INSERT INTO semtbl_OR VALUES(''7ff1a805-ceb6-4bbf-93d9-8c7dda5e0ec7'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''589bf9b6-abfd-47af-8392-5878838c70fc'')=0
	INSERT INTO semtbl_OR VALUES(''589bf9b6-abfd-47af-8392-5878838c70fc'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''1be4b9a6-563d-441e-9b7d-3d34f765827d'')=0
	INSERT INTO semtbl_OR VALUES(''1be4b9a6-563d-441e-9b7d-3d34f765827d'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''8ded19cf-ba7b-4dce-b521-579527200894'')=0
	INSERT INTO semtbl_OR VALUES(''8ded19cf-ba7b-4dce-b521-579527200894'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''cd7109d9-aa37-41ac-acb1-de96301e5cb4'')=0
	INSERT INTO semtbl_OR VALUES(''cd7109d9-aa37-41ac-acb1-de96301e5cb4'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''3e2f1b1a-b99a-4269-bcf2-47de2f20084b'')=0
	INSERT INTO semtbl_OR VALUES(''3e2f1b1a-b99a-4269-bcf2-47de2f20084b'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''93b946ef-dce6-4de0-8ae1-9d45ed6f5457'')=0
	INSERT INTO semtbl_OR VALUES(''93b946ef-dce6-4de0-8ae1-9d45ed6f5457'',''4cef5745-b03c-4d34-9165-b865a7d384b1'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''b67776c5-9a28-42a2-ac02-b36568383ef3'')=0
	INSERT INTO semtbl_OR VALUES(''b67776c5-9a28-42a2-ac02-b36568383ef3'',''761b8a7e-e65c-428a-804b-8e1d3def7c4b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''422439f5-b08a-40f0-b111-30658fd32fa9'')=0
	INSERT INTO semtbl_OR VALUES(''422439f5-b08a-40f0-b111-30658fd32fa9'',''66a7f5c9-bff6-40dc-a893-15bdb65dbf26'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''a8abe90f-6ac3-42e4-a3a7-4144e836f8a6'')=0
	INSERT INTO semtbl_OR VALUES(''a8abe90f-6ac3-42e4-a3a7-4144e836f8a6'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR WHERE GUID_ObjectReference=''e3bb1da7-88d2-47c8-acc2-2baac60c455b'')=0
	INSERT INTO semtbl_OR VALUES(''e3bb1da7-88d2-47c8-acc2-2baac60c455b'',''5c78451d-fe48-48cc-bd49-0a47f947dfc6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''dea74d8c-87f3-4dd1-8578-5f514325784c'')=0
	INSERT INTO semtbl_OR_Type VALUES(''dea74d8c-87f3-4dd1-8578-5f514325784c'',''6401e369-4445-49a3-9822-1029a4c1b8b8'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''8d75e64a-1bb7-4a94-85e3-d9bd5f309361'')=0
	INSERT INTO semtbl_OR_Type VALUES(''8d75e64a-1bb7-4a94-85e3-d9bd5f309361'',''57642009-3978-4db7-9b38-c2a526cdeaee'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'')=0
	INSERT INTO semtbl_OR_Type VALUES(''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''aa616051-e521-4fac-abdb-cbba6f8c6e73'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''26a6b04d-1012-4e2a-bf88-ed8a6a58081d'')=0
	INSERT INTO semtbl_OR_Type VALUES(''26a6b04d-1012-4e2a-bf88-ed8a6a58081d'',''6a812e6c-52b1-407b-aceb-9412f5c1cfaf'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''6564fe74-1e10-4042-8266-fb870071fc84'')=0
	INSERT INTO semtbl_OR_Type VALUES(''6564fe74-1e10-4042-8266-fb870071fc84'',''5f7a0238-859e-4eec-9f69-3038192cf56f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''d64382b9-d639-48c2-b318-d03429ee1d9d'')=0
	INSERT INTO semtbl_OR_Type VALUES(''d64382b9-d639-48c2-b318-d03429ee1d9d'',''b7ea6186-327a-43eb-be5b-8f39ea599155'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''990d4113-c2a3-49a9-9ee0-205c474da4d6'')=0
	INSERT INTO semtbl_OR_Type VALUES(''990d4113-c2a3-49a9-9ee0-205c474da4d6'',''4a6430a8-89f3-409b-883c-3641a8b88898'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''68574556-640e-4701-a960-b60887a31bc1'')=0
	INSERT INTO semtbl_OR_Type VALUES(''68574556-640e-4701-a960-b60887a31bc1'',''952ba315-3c21-44fb-9bbc-2192e971b906'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''cc057336-11e7-4418-aad0-265f415b8d3c'')=0
	INSERT INTO semtbl_OR_Type VALUES(''cc057336-11e7-4418-aad0-265f415b8d3c'',''9e508361-7de6-4087-bdae-30933cdb8843'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''f3307576-4382-447f-912a-df5286da5d2a'')=0
	INSERT INTO semtbl_OR_Type VALUES(''f3307576-4382-447f-912a-df5286da5d2a'',''d4ef7be6-afaf-42e2-8596-61d70b886c23'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''3e82da63-d982-4fe8-8404-9c0cdbd3666f'')=0
	INSERT INTO semtbl_OR_Type VALUES(''3e82da63-d982-4fe8-8404-9c0cdbd3666f'',''e864f198-1df0-4d53-bb87-959bc8884919'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''5b7370d1-c850-4203-9265-eabc2bcd2021'')=0
	INSERT INTO semtbl_OR_Type VALUES(''5b7370d1-c850-4203-9265-eabc2bcd2021'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''200f575a-61eb-41ae-9b21-26324b1447e0'')=0
	INSERT INTO semtbl_OR_Type VALUES(''200f575a-61eb-41ae-9b21-26324b1447e0'',''3f806e96-422c-46ef-b9e5-609e91a8c27b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''7f4279a4-f539-4a59-b129-f713b516b891'')=0
	INSERT INTO semtbl_OR_Type VALUES(''7f4279a4-f539-4a59-b129-f713b516b891'',''b6551e7a-b9c8-4d98-94c6-076dcf8cd12b'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''dc545b73-2319-4914-a798-126b9e4c6d4c'')=0
	INSERT INTO semtbl_OR_Type VALUES(''dc545b73-2319-4914-a798-126b9e4c6d4c'',''499ec20d-af6f-4e72-bf55-ffb6eac101bf'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''9c9b2aba-8dbe-41eb-9ceb-3102b24a1cbd'')=0
	INSERT INTO semtbl_OR_Type VALUES(''9c9b2aba-8dbe-41eb-9ceb-3102b24a1cbd'',''d88808d0-0473-4594-a8f9-6c4cb3439297'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''589bf9b6-abfd-47af-8392-5878838c70fc'')=0
	INSERT INTO semtbl_OR_Type VALUES(''589bf9b6-abfd-47af-8392-5878838c70fc'',''53aa29b7-36e1-4511-b9a4-a743a5fc4535'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''1be4b9a6-563d-441e-9b7d-3d34f765827d'')=0
	INSERT INTO semtbl_OR_Type VALUES(''1be4b9a6-563d-441e-9b7d-3d34f765827d'',''51cda3ce-2ad8-46f1-a098-b7bcf0c2eba2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''a8abe90f-6ac3-42e4-a3a7-4144e836f8a6'')=0
	INSERT INTO semtbl_OR_Type VALUES(''a8abe90f-6ac3-42e4-a3a7-4144e836f8a6'',''a2d7d0fe-0495-4afe-85e1-1dcb88a27546'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Type WHERE GUID_ObjectReference=''e3bb1da7-88d2-47c8-acc2-2baac60c455b'')=0
	INSERT INTO semtbl_OR_Type VALUES(''e3bb1da7-88d2-47c8-acc2-2baac60c455b'',''68ca7f8f-4172-4186-8687-95385899783c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''ce7ff21a-b472-4089-bdd8-633697c4ef75'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''ce7ff21a-b472-4089-bdd8-633697c4ef75'',''96405d28-0826-40e6-8e55-30d1ecc0542a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''32d040af-504c-436a-8839-b57db67d158a'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''32d040af-504c-436a-8839-b57db67d158a'',''daf53cbc-2cb4-42ed-8722-ee85f6b33512'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''883daddb-7e9c-4b2d-b39c-edf8488f801d'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''883daddb-7e9c-4b2d-b39c-edf8488f801d'',''417f6a60-e5d5-4470-8871-8079c0cac065'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''d54b4651-82c7-4990-8dca-a0b65a3b1797'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''d54b4651-82c7-4990-8dca-a0b65a3b1797'',''cee3873e-c7ae-48d5-a4b7-d4ffd293fe14'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''e3e975d9-5d87-4966-9b3d-51cfcce5187b'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''e3e975d9-5d87-4966-9b3d-51cfcce5187b'',''9342e9b0-842c-4a01-baea-50d77881a195'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''6e87d417-fe31-4f4c-9a92-3af93decd7ec'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''6e87d417-fe31-4f4c-9a92-3af93decd7ec'',''212ca6eb-3c72-4cd4-8609-0fef351f08cc'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''48c6c6e8-e21c-489c-911e-b885aa90a5a8'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''48c6c6e8-e21c-489c-911e-b885aa90a5a8'',''2424da1a-59f9-463b-8d13-473377702fc2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''c521a5b4-7d17-4e2e-add1-a8da88f93610'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''c521a5b4-7d17-4e2e-add1-a8da88f93610'',''dc5045bb-1b83-4139-b6d4-a1a561529dca'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''167400ed-21e9-4f2b-99f7-f2c92a912643'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''167400ed-21e9-4f2b-99f7-f2c92a912643'',''8824ecf1-5957-44ee-9114-de52c1305a39'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''9b214b2c-dd5f-4a85-8833-42fa4bdd8fff'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''9b214b2c-dd5f-4a85-8833-42fa4bdd8fff'',''eb9f0536-d97b-40b6-b7ee-b7018f6caa0e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''4d43b956-6c71-4a3b-9bc1-81eac2e03d3b'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''4d43b956-6c71-4a3b-9bc1-81eac2e03d3b'',''eaf21eed-54e0-4afc-8b50-8497db6e0cdd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''8ded19cf-ba7b-4dce-b521-579527200894'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''8ded19cf-ba7b-4dce-b521-579527200894'',''5d09a3e9-03fb-436c-8450-1a50bf1267b6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Attribute WHERE GUID_ObjectReference=''422439f5-b08a-40f0-b111-30658fd32fa9'')=0
	INSERT INTO semtbl_OR_Attribute VALUES(''422439f5-b08a-40f0-b111-30658fd32fa9'',''1bb51893-8518-49d9-b7b3-e9ee140ab526'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''22c309ef-476e-4f8f-ae16-499b3a0f5850'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''22c309ef-476e-4f8f-ae16-499b3a0f5850'',''51074f19-35fa-4f63-b9fd-1bbceb81aa0d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''94639963-9017-4100-a6ab-a0b748ababce'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''94639963-9017-4100-a6ab-a0b748ababce'',''d91da85b-793c-431c-9724-8ddc1ace170e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''60a5457a-66d2-4905-8dd5-9555589aff93'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''60a5457a-66d2-4905-8dd5-9555589aff93'',''74585903-16e3-48a1-9ee7-0329c8569a56'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''c96f5af3-bb8a-4cec-9c06-6c1a6b6ce285'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''c96f5af3-bb8a-4cec-9c06-6c1a6b6ce285'',''fd4bacff-5ab6-4681-9b7c-a43d0fcbdf3d'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''5c893080-9e8c-4fe2-97aa-87878d38ac4a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''ca9f765e-d27c-486d-addc-e4b4a0377183'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''ca9f765e-d27c-486d-addc-e4b4a0377183'',''4b0ffa28-3fe2-4303-8880-226530f363cb'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''47404714-d512-4978-a925-e8d93ac51e22'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''47404714-d512-4978-a925-e8d93ac51e22'',''0b9a8992-349c-4e4b-9f06-1d954222bd8f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''5baa6510-c430-4d29-ae46-6f7eb48ab706'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''5baa6510-c430-4d29-ae46-6f7eb48ab706'',''ad99b56c-f3b5-4cca-9442-459b9a835098'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''e07469d9-766c-443e-8526-6d9c684f944f'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''317ecc85-ce37-428e-96f2-3e273379bf94'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''317ecc85-ce37-428e-96f2-3e273379bf94'',''b07efa3b-6184-4cf0-8f8b-0ce49a4f397e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''9706f0c4-012a-4972-a490-c19f5313d0ac'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''9706f0c4-012a-4972-a490-c19f5313d0ac'',''59fc1def-0977-44fc-af4c-70dad8f7d723'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''97049a1d-57f9-4840-b4a8-d55d674e600a'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''97049a1d-57f9-4840-b4a8-d55d674e600a'',''06b93890-d922-47ed-b70e-5e9cbd03df52'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''c09ca6bf-b5fb-4121-b169-d389981a2ad4'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''c09ca6bf-b5fb-4121-b169-d389981a2ad4'',''439e614d-fb8a-4ae7-b5a2-7be25a058e6c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''3e2f1b1a-b99a-4269-bcf2-47de2f20084b'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''3e2f1b1a-b99a-4269-bcf2-47de2f20084b'',''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_RelationType WHERE GUID_ObjectReference=''b67776c5-9a28-42a2-ac02-b36568383ef3'')=0
	INSERT INTO semtbl_OR_RelationType VALUES(''b67776c5-9a28-42a2-ac02-b36568383ef3'',''51f3c615-a01e-400d-b81b-58cadd07e773'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''5c06ce69-3cc0-495f-b95c-6219eeacdccc'')=0
	INSERT INTO semtbl_OR_Token VALUES(''5c06ce69-3cc0-495f-b95c-6219eeacdccc'',''9cff47c6-3a76-4c35-b0bc-8bf26addbd3c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''17739da9-759a-4312-8ab2-3e6900d1aa89'')=0
	INSERT INTO semtbl_OR_Token VALUES(''17739da9-759a-4312-8ab2-3e6900d1aa89'',''14cc9088-fd98-45f9-957e-b4bf519bf6f5'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''d046be26-4567-4b5d-80a0-c81104e30a55'')=0
	INSERT INTO semtbl_OR_Token VALUES(''d046be26-4567-4b5d-80a0-c81104e30a55'',''e7dd29f6-8966-4dd7-8230-ea716ada368a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''6c237ce7-4323-4abc-8a21-eb0929ba7470'')=0
	INSERT INTO semtbl_OR_Token VALUES(''6c237ce7-4323-4abc-8a21-eb0929ba7470'',''ef419235-2d55-4ce7-a0f4-6702ab57fbb7'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''4d749c0b-2896-4f64-ac73-37774038dd91'')=0
	INSERT INTO semtbl_OR_Token VALUES(''4d749c0b-2896-4f64-ac73-37774038dd91'',''2bd1ea49-dc70-402e-90c8-8267b1c5ca6a'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''d5446649-f12d-4c7c-97cd-419987aa3362'')=0
	INSERT INTO semtbl_OR_Token VALUES(''d5446649-f12d-4c7c-97cd-419987aa3362'',''1668fb78-fdc6-4618-b5cc-1be00741a2ab'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''9bb12af4-6f81-47d2-927f-8171a0441026'')=0
	INSERT INTO semtbl_OR_Token VALUES(''9bb12af4-6f81-47d2-927f-8171a0441026'',''9b0183f0-c787-4fe8-b5bd-fe038ccd4a7c'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''4fb1e8a0-b652-4545-98cb-b39c1b63a82a'')=0
	INSERT INTO semtbl_OR_Token VALUES(''4fb1e8a0-b652-4545-98cb-b39c1b63a82a'',''d457a21a-30a3-4751-a7d5-ad3892145c22'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''7ff1a805-ceb6-4bbf-93d9-8c7dda5e0ec7'')=0
	INSERT INTO semtbl_OR_Token VALUES(''7ff1a805-ceb6-4bbf-93d9-8c7dda5e0ec7'',''47ac1a66-8e2c-4966-b1c6-4b27e829efa6'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''cd7109d9-aa37-41ac-acb1-de96301e5cb4'')=0
	INSERT INTO semtbl_OR_Token VALUES(''cd7109d9-aa37-41ac-acb1-de96301e5cb4'',''a67061a5-1e92-4625-96ad-5b4f01ba61b7'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_OR_Token WHERE GUID_ObjectReference=''93b946ef-dce6-4de0-8ae1-9d45ed6f5457'')=0
	INSERT INTO semtbl_OR_Token VALUES(''93b946ef-dce6-4de0-8ae1-9d45ed6f5457'',''a030d27f-d920-4a87-a513-faaf4ccd2af7'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''935cc11d-12c8-46c8-922d-041d0d603edf'' AND GUID_ObjectReference=''ce7ff21a-b472-4089-bdd8-633697c4ef75'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''935cc11d-12c8-46c8-922d-041d0d603edf'',''ce7ff21a-b472-4089-bdd8-633697c4ef75'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''02e20c29-88bf-4887-9767-05245f5245a9'' AND GUID_ObjectReference=''dea74d8c-87f3-4dd1-8578-5f514325784c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''02e20c29-88bf-4887-9767-05245f5245a9'',''dea74d8c-87f3-4dd1-8578-5f514325784c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''269a5f7e-f51e-4f51-bb51-06c3ad50e3b8'' AND GUID_ObjectReference=''8d75e64a-1bb7-4a94-85e3-d9bd5f309361'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''269a5f7e-f51e-4f51-bb51-06c3ad50e3b8'',''8d75e64a-1bb7-4a94-85e3-d9bd5f309361'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''a4fdcad2-0b82-42aa-848b-08b89b4f1354'' AND GUID_ObjectReference=''22c309ef-476e-4f8f-ae16-499b3a0f5850'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''a4fdcad2-0b82-42aa-848b-08b89b4f1354'',''22c309ef-476e-4f8f-ae16-499b3a0f5850'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f2aca284-8ee0-4150-938b-09a43e7eafb7'' AND GUID_ObjectReference=''32d040af-504c-436a-8839-b57db67d158a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f2aca284-8ee0-4150-938b-09a43e7eafb7'',''32d040af-504c-436a-8839-b57db67d158a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''99ca8ff9-2940-493a-a276-0bcbd8a9f227'' AND GUID_ObjectReference=''5faff2d0-12f8-4820-83c9-03c8a72e0083'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''99ca8ff9-2940-493a-a276-0bcbd8a9f227'',''5faff2d0-12f8-4820-83c9-03c8a72e0083'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e26211f2-d7ee-44fd-ac09-0ffa5f82fa2b'' AND GUID_ObjectReference=''5c06ce69-3cc0-495f-b95c-6219eeacdccc'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e26211f2-d7ee-44fd-ac09-0ffa5f82fa2b'',''5c06ce69-3cc0-495f-b95c-6219eeacdccc'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''a2e20bb7-6423-4807-98c1-107837996076'' AND GUID_ObjectReference=''883daddb-7e9c-4b2d-b39c-edf8488f801d'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''a2e20bb7-6423-4807-98c1-107837996076'',''883daddb-7e9c-4b2d-b39c-edf8488f801d'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e39c0ac5-21b0-4c4b-b365-1a88e4b517de'' AND GUID_ObjectReference=''26a6b04d-1012-4e2a-bf88-ed8a6a58081d'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e39c0ac5-21b0-4c4b-b365-1a88e4b517de'',''26a6b04d-1012-4e2a-bf88-ed8a6a58081d'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e8305ca1-2e88-4267-b33d-1ae571916997'' AND GUID_ObjectReference=''6564fe74-1e10-4042-8266-fb870071fc84'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e8305ca1-2e88-4267-b33d-1ae571916997'',''6564fe74-1e10-4042-8266-fb870071fc84'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''93ef4864-7a54-45aa-ad5e-1e38da9ebcfc'' AND GUID_ObjectReference=''17739da9-759a-4312-8ab2-3e6900d1aa89'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''93ef4864-7a54-45aa-ad5e-1e38da9ebcfc'',''17739da9-759a-4312-8ab2-3e6900d1aa89'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''407f4a7e-db85-47ab-b58c-20169856f25c'' AND GUID_ObjectReference=''d046be26-4567-4b5d-80a0-c81104e30a55'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''407f4a7e-db85-47ab-b58c-20169856f25c'',''d046be26-4567-4b5d-80a0-c81104e30a55'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6e913914-7ca1-48c3-b342-20fba8c57c9b'' AND GUID_ObjectReference=''d64382b9-d639-48c2-b318-d03429ee1d9d'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6e913914-7ca1-48c3-b342-20fba8c57c9b'',''d64382b9-d639-48c2-b318-d03429ee1d9d'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''669c5918-f565-428b-b3a6-387fbe2a3c58'' AND GUID_ObjectReference=''6c237ce7-4323-4abc-8a21-eb0929ba7470'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''669c5918-f565-428b-b3a6-387fbe2a3c58'',''6c237ce7-4323-4abc-8a21-eb0929ba7470'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''0f211b81-efac-4dc0-9c7a-3aeba969ad46'' AND GUID_ObjectReference=''990d4113-c2a3-49a9-9ee0-205c474da4d6'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''0f211b81-efac-4dc0-9c7a-3aeba969ad46'',''990d4113-c2a3-49a9-9ee0-205c474da4d6'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''fb69b5e3-2b0a-47ad-8424-4692c2e83175'' AND GUID_ObjectReference=''94639963-9017-4100-a6ab-a0b748ababce'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''fb69b5e3-2b0a-47ad-8424-4692c2e83175'',''94639963-9017-4100-a6ab-a0b748ababce'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3fcdf63c-8f33-4e7e-912b-4e3fc4e92dd9'' AND GUID_ObjectReference=''d54b4651-82c7-4990-8dca-a0b65a3b1797'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3fcdf63c-8f33-4e7e-912b-4e3fc4e92dd9'',''d54b4651-82c7-4990-8dca-a0b65a3b1797'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d27bed40-7392-493f-ab1f-4ef2bbc64575'' AND GUID_ObjectReference=''68574556-640e-4701-a960-b60887a31bc1'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d27bed40-7392-493f-ab1f-4ef2bbc64575'',''68574556-640e-4701-a960-b60887a31bc1'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''bf074291-2897-48d3-b704-52368c845f09'' AND GUID_ObjectReference=''e3e975d9-5d87-4966-9b3d-51cfcce5187b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''bf074291-2897-48d3-b704-52368c845f09'',''e3e975d9-5d87-4966-9b3d-51cfcce5187b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''d2cdfee8-39e6-4b0a-b1dc-555da5c2a3b5'' AND GUID_ObjectReference=''cc057336-11e7-4418-aad0-265f415b8d3c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''d2cdfee8-39e6-4b0a-b1dc-555da5c2a3b5'',''cc057336-11e7-4418-aad0-265f415b8d3c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''b7db9126-e04e-42ff-8e1e-66a1b872574d'' AND GUID_ObjectReference=''60a5457a-66d2-4905-8dd5-9555589aff93'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''b7db9126-e04e-42ff-8e1e-66a1b872574d'',''60a5457a-66d2-4905-8dd5-9555589aff93'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''1306f4a9-7754-44b6-a33f-68884a947568'' AND GUID_ObjectReference=''6e87d417-fe31-4f4c-9a92-3af93decd7ec'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''1306f4a9-7754-44b6-a33f-68884a947568'',''6e87d417-fe31-4f4c-9a92-3af93decd7ec'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6c966e3c-c737-4af1-9970-68c8323679bc'' AND GUID_ObjectReference=''e8784d4a-42cd-410a-805b-9b1f71a9f297'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6c966e3c-c737-4af1-9970-68c8323679bc'',''e8784d4a-42cd-410a-805b-9b1f71a9f297'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'' AND GUID_ObjectReference=''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8ca3c197-69bd-4d3c-bb3b-6b8e4483eb0d'',''88e201d4-a2fd-4b5e-93ba-c3f6241a3f92'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''15820ab1-0945-4e72-9792-6dd480e73954'' AND GUID_ObjectReference=''47121a8b-e65a-4683-b101-9dc5cd1966ac'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''15820ab1-0945-4e72-9792-6dd480e73954'',''47121a8b-e65a-4683-b101-9dc5cd1966ac'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e9944776-131a-4333-8730-70555b96f1c9'' AND GUID_ObjectReference=''48c6c6e8-e21c-489c-911e-b885aa90a5a8'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e9944776-131a-4333-8730-70555b96f1c9'',''48c6c6e8-e21c-489c-911e-b885aa90a5a8'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6e494944-f602-4dcb-906f-70e5efe8f1dd'' AND GUID_ObjectReference=''008817a6-14e7-4295-9a69-6835575ae53b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6e494944-f602-4dcb-906f-70e5efe8f1dd'',''008817a6-14e7-4295-9a69-6835575ae53b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''cb8555b7-9128-4a29-a9f7-76e9c8ec25f9'' AND GUID_ObjectReference=''c96f5af3-bb8a-4cec-9c06-6c1a6b6ce285'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''cb8555b7-9128-4a29-a9f7-76e9c8ec25f9'',''c96f5af3-bb8a-4cec-9c06-6c1a6b6ce285'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f2cde058-614e-41cb-96eb-78bbcf285171'' AND GUID_ObjectReference=''66db51c4-c0bd-4612-b39e-451ae9164a7c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f2cde058-614e-41cb-96eb-78bbcf285171'',''66db51c4-c0bd-4612-b39e-451ae9164a7c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''c473b0f4-f7b1-4ef5-8f8e-8cd17ae1abb3'' AND GUID_ObjectReference=''4d749c0b-2896-4f64-ac73-37774038dd91'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''c473b0f4-f7b1-4ef5-8f8e-8cd17ae1abb3'',''4d749c0b-2896-4f64-ac73-37774038dd91'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''46551f18-1c7b-4b0d-8c48-8cf7582d4c64'' AND GUID_ObjectReference=''f3307576-4382-447f-912a-df5286da5d2a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''46551f18-1c7b-4b0d-8c48-8cf7582d4c64'',''f3307576-4382-447f-912a-df5286da5d2a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''f75d75b7-d053-4b73-93d3-9319c7ae8c82'' AND GUID_ObjectReference=''ca9f765e-d27c-486d-addc-e4b4a0377183'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''f75d75b7-d053-4b73-93d3-9319c7ae8c82'',''ca9f765e-d27c-486d-addc-e4b4a0377183'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''5221f303-5fc8-4d8c-9f99-9c5422159c79'' AND GUID_ObjectReference=''47404714-d512-4978-a925-e8d93ac51e22'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''5221f303-5fc8-4d8c-9f99-9c5422159c79'',''47404714-d512-4978-a925-e8d93ac51e22'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6a59f3d6-033e-4db5-95a9-a5130c482c76'' AND GUID_ObjectReference=''c521a5b4-7d17-4e2e-add1-a8da88f93610'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6a59f3d6-033e-4db5-95a9-a5130c482c76'',''c521a5b4-7d17-4e2e-add1-a8da88f93610'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''00acaf8d-b90b-426b-84d9-a58ff944f66c'' AND GUID_ObjectReference=''5baa6510-c430-4d29-ae46-6f7eb48ab706'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''00acaf8d-b90b-426b-84d9-a58ff944f66c'',''5baa6510-c430-4d29-ae46-6f7eb48ab706'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''075cb4b9-65bf-4fd5-abf8-a6c4deb57282'' AND GUID_ObjectReference=''3e82da63-d982-4fe8-8404-9c0cdbd3666f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''075cb4b9-65bf-4fd5-abf8-a6c4deb57282'',''3e82da63-d982-4fe8-8404-9c0cdbd3666f'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''87eb4dc0-bdae-4c49-bf3c-a70ea7a6a4d6'' AND GUID_ObjectReference=''5b7370d1-c850-4203-9265-eabc2bcd2021'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''87eb4dc0-bdae-4c49-bf3c-a70ea7a6a4d6'',''5b7370d1-c850-4203-9265-eabc2bcd2021'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''87068490-d91a-4d25-b400-a836b040603e'' AND GUID_ObjectReference=''d5446649-f12d-4c7c-97cd-419987aa3362'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''87068490-d91a-4d25-b400-a836b040603e'',''d5446649-f12d-4c7c-97cd-419987aa3362'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3186cc5e-023b-4edc-b6c7-a89919320839'' AND GUID_ObjectReference=''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3186cc5e-023b-4edc-b6c7-a89919320839'',''d3c1742e-e3f9-4bb0-883f-3b927fe4f8ff'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''9b18d3ce-ffcf-4948-ad4d-abcc02664d75'' AND GUID_ObjectReference=''167400ed-21e9-4f2b-99f7-f2c92a912643'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''9b18d3ce-ffcf-4948-ad4d-abcc02664d75'',''167400ed-21e9-4f2b-99f7-f2c92a912643'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''38aa4fbc-2d5f-44e3-ba23-b523c2a0a0f8'' AND GUID_ObjectReference=''200f575a-61eb-41ae-9b21-26324b1447e0'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''38aa4fbc-2d5f-44e3-ba23-b523c2a0a0f8'',''200f575a-61eb-41ae-9b21-26324b1447e0'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''246cc967-805d-416d-8d85-b6dd5ead1f09'' AND GUID_ObjectReference=''9bb12af4-6f81-47d2-927f-8171a0441026'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''246cc967-805d-416d-8d85-b6dd5ead1f09'',''9bb12af4-6f81-47d2-927f-8171a0441026'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''3fc83b93-335a-4334-b2b3-b6edee0e92a6'' AND GUID_ObjectReference=''7f4279a4-f539-4a59-b129-f713b516b891'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''3fc83b93-335a-4334-b2b3-b6edee0e92a6'',''7f4279a4-f539-4a59-b129-f713b516b891'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''860ea080-d714-4d1d-a717-b9fed7fd4697'' AND GUID_ObjectReference=''317ecc85-ce37-428e-96f2-3e273379bf94'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''860ea080-d714-4d1d-a717-b9fed7fd4697'',''317ecc85-ce37-428e-96f2-3e273379bf94'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''59df733f-6853-4af3-87d6-bd769bc34684'' AND GUID_ObjectReference=''dc545b73-2319-4914-a798-126b9e4c6d4c'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''59df733f-6853-4af3-87d6-bd769bc34684'',''dc545b73-2319-4914-a798-126b9e4c6d4c'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''af023fc2-9351-43ad-8c3b-beffe7ec3b54'' AND GUID_ObjectReference=''4fb1e8a0-b652-4545-98cb-b39c1b63a82a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''af023fc2-9351-43ad-8c3b-beffe7ec3b54'',''4fb1e8a0-b652-4545-98cb-b39c1b63a82a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''182cb7bc-21ae-4b32-9e14-bfc1f43ccf6f'' AND GUID_ObjectReference=''9c9b2aba-8dbe-41eb-9ceb-3102b24a1cbd'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''182cb7bc-21ae-4b32-9e14-bfc1f43ccf6f'',''9c9b2aba-8dbe-41eb-9ceb-3102b24a1cbd'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''ab503cd6-0b71-4939-9bbd-c4af5380c016'' AND GUID_ObjectReference=''9b214b2c-dd5f-4a85-8833-42fa4bdd8fff'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''ab503cd6-0b71-4939-9bbd-c4af5380c016'',''9b214b2c-dd5f-4a85-8833-42fa4bdd8fff'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''19cc7e70-8782-4052-ab78-c62be7ecd550'' AND GUID_ObjectReference=''9706f0c4-012a-4972-a490-c19f5313d0ac'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''19cc7e70-8782-4052-ab78-c62be7ecd550'',''9706f0c4-012a-4972-a490-c19f5313d0ac'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''cc820013-24df-4024-8511-cc616b6962e6'' AND GUID_ObjectReference=''97049a1d-57f9-4840-b4a8-d55d674e600a'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''cc820013-24df-4024-8511-cc616b6962e6'',''97049a1d-57f9-4840-b4a8-d55d674e600a'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''8618f96e-8494-432a-99da-cc91e6c117d5'' AND GUID_ObjectReference=''c09ca6bf-b5fb-4121-b169-d389981a2ad4'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''8618f96e-8494-432a-99da-cc91e6c117d5'',''c09ca6bf-b5fb-4121-b169-d389981a2ad4'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''da14dafa-132a-4273-8c6a-d03b7b6d72c4'' AND GUID_ObjectReference=''4d43b956-6c71-4a3b-9bc1-81eac2e03d3b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''da14dafa-132a-4273-8c6a-d03b7b6d72c4'',''4d43b956-6c71-4a3b-9bc1-81eac2e03d3b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6562615e-a995-491c-806b-d17280d11528'' AND GUID_ObjectReference=''7ff1a805-ceb6-4bbf-93d9-8c7dda5e0ec7'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6562615e-a995-491c-806b-d17280d11528'',''7ff1a805-ceb6-4bbf-93d9-8c7dda5e0ec7'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''03dd731a-986b-4d76-b6eb-d426b897edff'' AND GUID_ObjectReference=''589bf9b6-abfd-47af-8392-5878838c70fc'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''03dd731a-986b-4d76-b6eb-d426b897edff'',''589bf9b6-abfd-47af-8392-5878838c70fc'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''05494c25-0ab5-4166-a6eb-db7ce0c45c2c'' AND GUID_ObjectReference=''1be4b9a6-563d-441e-9b7d-3d34f765827d'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''05494c25-0ab5-4166-a6eb-db7ce0c45c2c'',''1be4b9a6-563d-441e-9b7d-3d34f765827d'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''e0a7a86d-b267-4929-b0b5-dbe2c1f562de'' AND GUID_ObjectReference=''8ded19cf-ba7b-4dce-b521-579527200894'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''e0a7a86d-b267-4929-b0b5-dbe2c1f562de'',''8ded19cf-ba7b-4dce-b521-579527200894'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''2bdea47c-49c1-4af3-a605-dd0396f75122'' AND GUID_ObjectReference=''cd7109d9-aa37-41ac-acb1-de96301e5cb4'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''2bdea47c-49c1-4af3-a605-dd0396f75122'',''cd7109d9-aa37-41ac-acb1-de96301e5cb4'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''22faaa6d-8fbe-4b5a-8856-dec1fbcb5959'' AND GUID_ObjectReference=''3e2f1b1a-b99a-4269-bcf2-47de2f20084b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''22faaa6d-8fbe-4b5a-8856-dec1fbcb5959'',''3e2f1b1a-b99a-4269-bcf2-47de2f20084b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''82be9300-79bd-407f-8c77-e429a2dafc58'' AND GUID_ObjectReference=''93b946ef-dce6-4de0-8ae1-9d45ed6f5457'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''82be9300-79bd-407f-8c77-e429a2dafc58'',''93b946ef-dce6-4de0-8ae1-9d45ed6f5457'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''5ec2ef03-1fdc-44d1-8af8-e43ff33f7065'' AND GUID_ObjectReference=''b67776c5-9a28-42a2-ac02-b36568383ef3'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''5ec2ef03-1fdc-44d1-8af8-e43ff33f7065'',''b67776c5-9a28-42a2-ac02-b36568383ef3'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''6f48ee26-dad5-40c5-8e68-e53c5f98583a'' AND GUID_ObjectReference=''422439f5-b08a-40f0-b111-30658fd32fa9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''6f48ee26-dad5-40c5-8e68-e53c5f98583a'',''422439f5-b08a-40f0-b111-30658fd32fa9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''92121dac-d796-4dac-acc8-ea779f9cb1cd'' AND GUID_ObjectReference=''a8abe90f-6ac3-42e4-a3a7-4144e836f8a6'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''92121dac-d796-4dac-acc8-ea779f9cb1cd'',''a8abe90f-6ac3-42e4-a3a7-4144e836f8a6'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_OR WHERE GUID_Token_Left=''cdf1e2a4-accf-4092-9f46-ea9ca54b825e'' AND GUID_ObjectReference=''e3bb1da7-88d2-47c8-acc2-2baac60c455b'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_OR VALUES(''cdf1e2a4-accf-4092-9f46-ea9ca54b825e'',''e3bb1da7-88d2-47c8-acc2-2baac60c455b'',''e07469d9-766c-443e-8526-6d9c684f944f'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''13c09f11-175c-4eef-bc8a-0fd8e86d557f'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''13c09f11-175c-4eef-bc8a-0fd8e86d557f'',''e07469d9-766c-443e-8526-6d9c684f944f'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''4a6430a8-89f3-409b-883c-3641a8b88898'' AND GUID_RelationType=''51f3c615-a01e-400d-b81b-58cadd07e773'')=0
	INSERT INTO semtbl_Type_OR VALUES(''4a6430a8-89f3-409b-883c-3641a8b88898'',''51f3c615-a01e-400d-b81b-58cadd07e773'',0,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''b6551e7a-b9c8-4d98-94c6-076dcf8cd12b'' AND GUID_RelationType=''79671239-9c8f-493c-b5e7-49700f9543f4'')=0
	INSERT INTO semtbl_Type_OR VALUES(''b6551e7a-b9c8-4d98-94c6-076dcf8cd12b'',''79671239-9c8f-493c-b5e7-49700f9543f4'',1,1)'
GO
