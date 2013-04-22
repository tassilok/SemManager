use [sem_db_work]
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''4e173916-e8d7-4640-8ef1-965b74371124'') = 0
	insert into semtbl_Attribute VALUES(''4e173916-e8d7-4640-8ef1-965b74371124'',''Codepage'',''3a4f5b7b-da75-4980-933e-fbc33cc51439'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''581597d8-dde6-4779-9ef0-37d29d0a67a2'') = 0
	insert into semtbl_Attribute VALUES(''581597d8-dde6-4779-9ef0-37d29d0a67a2'',''LCID'',''3a4f5b7b-da75-4980-933e-fbc33cc51439'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''04048642-e81e-4026-841a-fb377a02dbc5'') = 0
	insert into semtbl_Attribute VALUES(''04048642-e81e-4026-841a-fb377a02dbc5'',''Short'',''065e644e-c7df-4007-8672-aa5414131c78'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''408db9f1-ae42-4807-b656-729270646f0a'')=0
	insert into semtbl_RelationType VALUES(''408db9f1-ae42-4807-b656-729270646f0a'',''is subordinated'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''fafc1464-815f-4596-9737-bcbc96bd744a'')=0
	insert into semtbl_RelationType VALUES(''fafc1464-815f-4596-9737-bcbc96bd744a'',''needs'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type=''49fdcd27-e105-4770-941d-7485dcad08c1'') = 0
	insert into semtbl_Type (GUID_Type,Name_Type) VALUES(''49fdcd27-e105-4770-941d-7485dcad08c1'',''Root'')'
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
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='73e32abf-e577-4d31-9a46-bc07e9e15de3') = 0
	insert into semtbl_Type VALUES('73e32abf-e577-4d31-9a46-bc07e9e15de3','Software-Management','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='71415eeb-ce46-4b2c-b0a2-f72116b55438') = 0
	insert into semtbl_Type VALUES('71415eeb-ce46-4b2c-b0a2-f72116b55438','Software-Development','73e32abf-e577-4d31-9a46-bc07e9e15de3')
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9b0183f0-c787-4fe8-b5bd-fe038ccd4a7c'') = 0
	insert into semtbl_Token VALUES(''9b0183f0-c787-4fe8-b5bd-fe038ccd4a7c'',''Bill-Module'',''71415eeb-ce46-4b2c-b0a2-f72116b55438'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4b469beb-262c-4c70-9d46-6e2f0304e92a'') = 0
	insert into semtbl_Token VALUES(''4b469beb-262c-4c70-9d46-6e2f0304e92a'',''€'',''e864f198-1df0-4d53-bb87-959bc8884919'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c4fa1f93-a20e-41e2-ac71-fa2d4e560567'') = 0
	insert into semtbl_Token VALUES(''c4fa1f93-a20e-41e2-ac71-fa2d4e560567'',''Afrikaans'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''06348e30-ef97-4fec-b271-eb664fc9da02'') = 0
	insert into semtbl_Token VALUES(''06348e30-ef97-4fec-b271-eb664fc9da02'',''Albanian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''218696d3-4fea-47d4-b051-b77d3bc5e863'') = 0
	insert into semtbl_Token VALUES(''218696d3-4fea-47d4-b051-b77d3bc5e863'',''Arabic (Algeria)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e2f9ad6e-f8bc-4ba7-9c70-7e44024aaea8'') = 0
	insert into semtbl_Token VALUES(''e2f9ad6e-f8bc-4ba7-9c70-7e44024aaea8'',''Arabic (Bahrain)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''60e2b73a-557f-4d6c-8edf-f3af4f27e658'') = 0
	insert into semtbl_Token VALUES(''60e2b73a-557f-4d6c-8edf-f3af4f27e658'',''Arabic (Egypt)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4afb7f8a-8642-4759-afa5-e7c7da442b8d'') = 0
	insert into semtbl_Token VALUES(''4afb7f8a-8642-4759-afa5-e7c7da442b8d'',''Arabic (Iraq)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''06843000-dc76-4ad7-af52-92df1fdef1de'') = 0
	insert into semtbl_Token VALUES(''06843000-dc76-4ad7-af52-92df1fdef1de'',''Arabic (Jordan)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a5c8f86c-862d-447c-9a25-085da9254102'') = 0
	insert into semtbl_Token VALUES(''a5c8f86c-862d-447c-9a25-085da9254102'',''Arabic (Kuwait)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''42fa87f2-a243-4685-be71-537f82dbccbf'') = 0
	insert into semtbl_Token VALUES(''42fa87f2-a243-4685-be71-537f82dbccbf'',''Arabic (Lebanon)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8a589e7c-c4f9-429e-b680-0064ad82c599'') = 0
	insert into semtbl_Token VALUES(''8a589e7c-c4f9-429e-b680-0064ad82c599'',''Arabic (Libya)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4fa7d29c-676e-484c-b7f4-4a3c5107772f'') = 0
	insert into semtbl_Token VALUES(''4fa7d29c-676e-484c-b7f4-4a3c5107772f'',''Arabic (Morocco)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ae22b33f-bc22-4388-8d57-98a7cf2e8172'') = 0
	insert into semtbl_Token VALUES(''ae22b33f-bc22-4388-8d57-98a7cf2e8172'',''Arabic (Oman)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''292315cb-3d35-484d-bda7-ca4a0edba366'') = 0
	insert into semtbl_Token VALUES(''292315cb-3d35-484d-bda7-ca4a0edba366'',''Arabic (Qatar)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''edc5b6da-6134-4cc3-a7af-a41456d60fe1'') = 0
	insert into semtbl_Token VALUES(''edc5b6da-6134-4cc3-a7af-a41456d60fe1'',''Arabic (Saudi Arabia)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''17b675cc-d57a-43cd-b427-006694feeea6'') = 0
	insert into semtbl_Token VALUES(''17b675cc-d57a-43cd-b427-006694feeea6'',''Arabic (Syria)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e504e18d-9f59-4ce3-82b8-d04f9c074fdd'') = 0
	insert into semtbl_Token VALUES(''e504e18d-9f59-4ce3-82b8-d04f9c074fdd'',''Arabic (Tunisia)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0345bbfd-8879-403d-bb5f-b682a391118f'') = 0
	insert into semtbl_Token VALUES(''0345bbfd-8879-403d-bb5f-b682a391118f'',''Arabic (U.A.E.)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ac70f8b9-1ef5-4dd2-936b-10deb1020ad0'') = 0
	insert into semtbl_Token VALUES(''ac70f8b9-1ef5-4dd2-936b-10deb1020ad0'',''Arabic (Yemen)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c07cebad-a87e-4b19-a14d-568db71189df'') = 0
	insert into semtbl_Token VALUES(''c07cebad-a87e-4b19-a14d-568db71189df'',''Armenian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1b1d7941-f461-4556-8d16-481979f9811c'') = 0
	insert into semtbl_Token VALUES(''1b1d7941-f461-4556-8d16-481979f9811c'',''Azeri (Cyrillic)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cb347ce2-21b9-4dc6-bfcc-04ce463e4718'') = 0
	insert into semtbl_Token VALUES(''cb347ce2-21b9-4dc6-bfcc-04ce463e4718'',''Azeri (Latin)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''25ee93f1-9728-4080-86b6-ebb96479874f'') = 0
	insert into semtbl_Token VALUES(''25ee93f1-9728-4080-86b6-ebb96479874f'',''Basque'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a84b6a1b-bacd-4e75-a764-6da76bce4320'') = 0
	insert into semtbl_Token VALUES(''a84b6a1b-bacd-4e75-a764-6da76bce4320'',''Belarusian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ac29369d-b137-41fb-a3ad-45f62c75520c'') = 0
	insert into semtbl_Token VALUES(''ac29369d-b137-41fb-a3ad-45f62c75520c'',''Bulgarian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''70d5aadf-0f4e-4454-87fc-1a6770f88700'') = 0
	insert into semtbl_Token VALUES(''70d5aadf-0f4e-4454-87fc-1a6770f88700'',''Catalan'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cbe616f3-62d4-4952-9f08-498bc512fe13'') = 0
	insert into semtbl_Token VALUES(''cbe616f3-62d4-4952-9f08-498bc512fe13'',''Chinese (Hong Kong S.A.R.)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''64a33fc4-2b64-4671-b765-30bd59472a67'') = 0
	insert into semtbl_Token VALUES(''64a33fc4-2b64-4671-b765-30bd59472a67'',''Chinese (Macau S.A.R.)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b17e81f9-d0d2-4842-8d30-a5fb21b3cd16'') = 0
	insert into semtbl_Token VALUES(''b17e81f9-d0d2-4842-8d30-a5fb21b3cd16'',''Chinese (PRC)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1616a947-46fb-492b-831f-dff38a20b1b8'') = 0
	insert into semtbl_Token VALUES(''1616a947-46fb-492b-831f-dff38a20b1b8'',''Chinese (Singapore)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''33f7a97d-6375-47b4-b376-6215f311b4bc'') = 0
	insert into semtbl_Token VALUES(''33f7a97d-6375-47b4-b376-6215f311b4bc'',''Chinese (Taiwan)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''33582b69-5d51-4e62-924e-1a6abfd5b14c'') = 0
	insert into semtbl_Token VALUES(''33582b69-5d51-4e62-924e-1a6abfd5b14c'',''Croatian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''72e36d98-6cd9-4832-975c-23f064a8d1d4'') = 0
	insert into semtbl_Token VALUES(''72e36d98-6cd9-4832-975c-23f064a8d1d4'',''Czech'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''008d943f-dad7-475b-b3c2-286048b4049d'') = 0
	insert into semtbl_Token VALUES(''008d943f-dad7-475b-b3c2-286048b4049d'',''Danish'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''32f064e6-75ac-4c4c-a3af-18b1e11bdbe3'') = 0
	insert into semtbl_Token VALUES(''32f064e6-75ac-4c4c-a3af-18b1e11bdbe3'',''Divehi'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''99eeb55d-a5c5-4654-96e0-5c9b32cf10b6'') = 0
	insert into semtbl_Token VALUES(''99eeb55d-a5c5-4654-96e0-5c9b32cf10b6'',''Dutch (Belgium)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8827d139-113b-4d82-9dd6-af25de47c68f'') = 0
	insert into semtbl_Token VALUES(''8827d139-113b-4d82-9dd6-af25de47c68f'',''Dutch (Netherlands)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''99ad4502-6ab2-4c93-89be-dd2974833ec3'') = 0
	insert into semtbl_Token VALUES(''99ad4502-6ab2-4c93-89be-dd2974833ec3'',''English (Australia)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1c17407d-0153-4981-89f0-3284040a176f'') = 0
	insert into semtbl_Token VALUES(''1c17407d-0153-4981-89f0-3284040a176f'',''English (Belize)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a24a8c04-213b-47e8-a6d0-22f03c15efed'') = 0
	insert into semtbl_Token VALUES(''a24a8c04-213b-47e8-a6d0-22f03c15efed'',''English (Canada)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c4252f4b-fff4-421f-90a8-0b9604fda36e'') = 0
	insert into semtbl_Token VALUES(''c4252f4b-fff4-421f-90a8-0b9604fda36e'',''English (Caribbean)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''64ccdb6d-1596-4f5c-bbfe-c19742952b64'') = 0
	insert into semtbl_Token VALUES(''64ccdb6d-1596-4f5c-bbfe-c19742952b64'',''English (Ireland)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ea47c4ae-c0be-47cc-ad19-341b8c598f5f'') = 0
	insert into semtbl_Token VALUES(''ea47c4ae-c0be-47cc-ad19-341b8c598f5f'',''English (Jamaica)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1a286a0f-03dd-48d0-96e0-ecdf5715aae8'') = 0
	insert into semtbl_Token VALUES(''1a286a0f-03dd-48d0-96e0-ecdf5715aae8'',''English (New Zealand)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6509bdbc-1ed9-49df-a530-1aa108478f2b'') = 0
	insert into semtbl_Token VALUES(''6509bdbc-1ed9-49df-a530-1aa108478f2b'',''English (Philippines)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f649e13c-bd3d-456e-8d6c-a42204cbc22a'') = 0
	insert into semtbl_Token VALUES(''f649e13c-bd3d-456e-8d6c-a42204cbc22a'',''English (South Africa)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e681c7d8-1a80-4f49-a2cf-3c610879a7fb'') = 0
	insert into semtbl_Token VALUES(''e681c7d8-1a80-4f49-a2cf-3c610879a7fb'',''English (Trinidad)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0205e668-03d2-4eff-84c0-e46be0c7d4c0'') = 0
	insert into semtbl_Token VALUES(''0205e668-03d2-4eff-84c0-e46be0c7d4c0'',''English (United Kingdom)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''63188e16-0cd7-4384-90a8-558b47564b7b'') = 0
	insert into semtbl_Token VALUES(''63188e16-0cd7-4384-90a8-558b47564b7b'',''English (United States)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''78b80a6e-0d74-4734-9ecf-f56bccb3b7e9'') = 0
	insert into semtbl_Token VALUES(''78b80a6e-0d74-4734-9ecf-f56bccb3b7e9'',''English (Zimbabwe)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''cb2a0bd2-47be-4c39-8123-ef5c8d0716b0'') = 0
	insert into semtbl_Token VALUES(''cb2a0bd2-47be-4c39-8123-ef5c8d0716b0'',''Estonian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''61468373-5730-4c02-93ad-831771e4c46d'') = 0
	insert into semtbl_Token VALUES(''61468373-5730-4c02-93ad-831771e4c46d'',''Faroese'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''252cb7f4-929e-435a-bb37-37c34f8eee7f'') = 0
	insert into semtbl_Token VALUES(''252cb7f4-929e-435a-bb37-37c34f8eee7f'',''Farsi'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''abc695dd-307d-4bd8-9e9e-89e5d6a10c9b'') = 0
	insert into semtbl_Token VALUES(''abc695dd-307d-4bd8-9e9e-89e5d6a10c9b'',''Finnish'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''018f6434-6c6c-4ea4-82ea-5ad9afef3a31'') = 0
	insert into semtbl_Token VALUES(''018f6434-6c6c-4ea4-82ea-5ad9afef3a31'',''French (Belgium)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ef0b4629-ac58-43c5-a218-232c0fb49740'') = 0
	insert into semtbl_Token VALUES(''ef0b4629-ac58-43c5-a218-232c0fb49740'',''French (Canada)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''02d2019b-dccf-4235-ae92-6882eea2ff0d'') = 0
	insert into semtbl_Token VALUES(''02d2019b-dccf-4235-ae92-6882eea2ff0d'',''French (France)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a89c0ae6-c792-4cbb-9a3f-caf82e9c4d34'') = 0
	insert into semtbl_Token VALUES(''a89c0ae6-c792-4cbb-9a3f-caf82e9c4d34'',''French (Luxembourg)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''50036ceb-6386-44c2-8342-6d05401b6841'') = 0
	insert into semtbl_Token VALUES(''50036ceb-6386-44c2-8342-6d05401b6841'',''French (Monaco)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c9746268-13b1-42c9-9b49-b01843c210ab'') = 0
	insert into semtbl_Token VALUES(''c9746268-13b1-42c9-9b49-b01843c210ab'',''French (Switzerland)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b2f6a723-7d4e-4706-8290-bf22e86b54ee'') = 0
	insert into semtbl_Token VALUES(''b2f6a723-7d4e-4706-8290-bf22e86b54ee'',''FYRO Macedonian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''6934ea66-210e-4c21-a750-d8468dd1eaa2'') = 0
	insert into semtbl_Token VALUES(''6934ea66-210e-4c21-a750-d8468dd1eaa2'',''Galician'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a52f984b-9dec-40d1-b992-16da249bb84b'') = 0
	insert into semtbl_Token VALUES(''a52f984b-9dec-40d1-b992-16da249bb84b'',''Georgian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a70a8dbb-32a1-427b-b649-e452716008e0'') = 0
	insert into semtbl_Token VALUES(''a70a8dbb-32a1-427b-b649-e452716008e0'',''German (Austria)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8b1691d9-b296-4841-b01e-a7b6452eab2f'') = 0
	insert into semtbl_Token VALUES(''8b1691d9-b296-4841-b01e-a7b6452eab2f'',''German (Germany)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b0b0b703-d066-483a-b340-a8017899bf61'') = 0
	insert into semtbl_Token VALUES(''b0b0b703-d066-483a-b340-a8017899bf61'',''German (Liechtenstein)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''64d71ff6-18c2-4984-89f8-7193e42ecc3d'') = 0
	insert into semtbl_Token VALUES(''64d71ff6-18c2-4984-89f8-7193e42ecc3d'',''German (Luxembourg)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e1ce8149-d8be-4f96-a20b-0800b856567b'') = 0
	insert into semtbl_Token VALUES(''e1ce8149-d8be-4f96-a20b-0800b856567b'',''German (Switzerland)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7c0341b0-0d4d-4c31-b487-79aef88d2e8c'') = 0
	insert into semtbl_Token VALUES(''7c0341b0-0d4d-4c31-b487-79aef88d2e8c'',''Greek'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0af393e7-bbbc-4271-b4a4-0856e086af20'') = 0
	insert into semtbl_Token VALUES(''0af393e7-bbbc-4271-b4a4-0856e086af20'',''Gujarati'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''07963a9c-a9c8-4dc2-8e35-f93c43eea049'') = 0
	insert into semtbl_Token VALUES(''07963a9c-a9c8-4dc2-8e35-f93c43eea049'',''Hebrew'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e47307a7-bf54-4e1c-9741-5d93944aa89f'') = 0
	insert into semtbl_Token VALUES(''e47307a7-bf54-4e1c-9741-5d93944aa89f'',''Hindi'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2cd5aeb3-dc62-47c9-9531-95a416073303'') = 0
	insert into semtbl_Token VALUES(''2cd5aeb3-dc62-47c9-9531-95a416073303'',''Hungarian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''79ace185-b0b3-4528-9bff-0900caf1723e'') = 0
	insert into semtbl_Token VALUES(''79ace185-b0b3-4528-9bff-0900caf1723e'',''Icelandic'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''44981266-77b3-4b8a-b7e6-0a92882277c9'') = 0
	insert into semtbl_Token VALUES(''44981266-77b3-4b8a-b7e6-0a92882277c9'',''Indonesian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3807cefa-38cc-4337-aac1-26fb6e74d4e8'') = 0
	insert into semtbl_Token VALUES(''3807cefa-38cc-4337-aac1-26fb6e74d4e8'',''Italian (Italy)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''24a9bba2-0b69-4a27-9053-201b6383ce97'') = 0
	insert into semtbl_Token VALUES(''24a9bba2-0b69-4a27-9053-201b6383ce97'',''Italian (Switzerland)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8c3c894a-0dfe-48fe-b90b-bc153e453bf8'') = 0
	insert into semtbl_Token VALUES(''8c3c894a-0dfe-48fe-b90b-bc153e453bf8'',''Japanese'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''b8e421ed-fa3c-414e-b78c-e2cc4953f06a'') = 0
	insert into semtbl_Token VALUES(''b8e421ed-fa3c-414e-b78c-e2cc4953f06a'',''Kannada'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''db470f18-a94d-4c72-9df3-7c9c81926882'') = 0
	insert into semtbl_Token VALUES(''db470f18-a94d-4c72-9df3-7c9c81926882'',''Kazakh'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''468bacd0-0ba3-4dc5-8106-f686c7dd62fc'') = 0
	insert into semtbl_Token VALUES(''468bacd0-0ba3-4dc5-8106-f686c7dd62fc'',''Konkani'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c402aa47-aa42-49cf-93fb-06b96b308b25'') = 0
	insert into semtbl_Token VALUES(''c402aa47-aa42-49cf-93fb-06b96b308b25'',''Korean'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e14a709e-ef54-4dc8-b3db-98aff4466109'') = 0
	insert into semtbl_Token VALUES(''e14a709e-ef54-4dc8-b3db-98aff4466109'',''Kyrgyz (Cyrillic)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''333d115d-79b9-45fe-b54a-8ccd53e6e993'') = 0
	insert into semtbl_Token VALUES(''333d115d-79b9-45fe-b54a-8ccd53e6e993'',''Latvian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''5e57ccc2-4a1d-4291-9432-15357a9bfdf7'') = 0
	insert into semtbl_Token VALUES(''5e57ccc2-4a1d-4291-9432-15357a9bfdf7'',''Lithuanian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''43004171-d1a9-444c-867c-e23d33daf448'') = 0
	insert into semtbl_Token VALUES(''43004171-d1a9-444c-867c-e23d33daf448'',''Malay (Brunei Darussalam)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''40dae110-1cec-4819-944c-5580e1dfe5d9'') = 0
	insert into semtbl_Token VALUES(''40dae110-1cec-4819-944c-5580e1dfe5d9'',''Malay (Malaysia)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''91c14368-44d2-4d55-b78a-df813b08b114'') = 0
	insert into semtbl_Token VALUES(''91c14368-44d2-4d55-b78a-df813b08b114'',''Marathi'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0f9c25f5-e637-4d40-b9b0-aaccc003eabf'') = 0
	insert into semtbl_Token VALUES(''0f9c25f5-e637-4d40-b9b0-aaccc003eabf'',''Mongolian (Cyrillic)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2533f16f-bc8a-40e8-ab66-68968ba6ca82'') = 0
	insert into semtbl_Token VALUES(''2533f16f-bc8a-40e8-ab66-68968ba6ca82'',''Norwegian (Bokmal)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''bfd06795-9a1c-4d42-87ec-a21fefad13d3'') = 0
	insert into semtbl_Token VALUES(''bfd06795-9a1c-4d42-87ec-a21fefad13d3'',''Norwegian (Nynorsk)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0fb4cca8-cb62-49be-845d-3ab3df4c558f'') = 0
	insert into semtbl_Token VALUES(''0fb4cca8-cb62-49be-845d-3ab3df4c558f'',''Polish'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7b628560-0554-4184-b4d6-f12f2c1875af'') = 0
	insert into semtbl_Token VALUES(''7b628560-0554-4184-b4d6-f12f2c1875af'',''Portuguese (Brazil)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''975e6418-8766-4339-b24b-21b9660d5902'') = 0
	insert into semtbl_Token VALUES(''975e6418-8766-4339-b24b-21b9660d5902'',''Portuguese (Portugal)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''72209641-7b00-40e7-a0de-0eb26747c2ff'') = 0
	insert into semtbl_Token VALUES(''72209641-7b00-40e7-a0de-0eb26747c2ff'',''Punjabi'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8eb9d2c2-3c45-4180-b90a-e7c12d0b2e90'') = 0
	insert into semtbl_Token VALUES(''8eb9d2c2-3c45-4180-b90a-e7c12d0b2e90'',''Romanian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''98d3016c-bcda-4d5a-b1c1-e19fb7531780'') = 0
	insert into semtbl_Token VALUES(''98d3016c-bcda-4d5a-b1c1-e19fb7531780'',''Russian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''25079f72-fd8a-41c1-8bc8-8a8572f61f98'') = 0
	insert into semtbl_Token VALUES(''25079f72-fd8a-41c1-8bc8-8a8572f61f98'',''Sanskrit'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ebe0699a-f61c-4938-94c7-ff2d2063ae63'') = 0
	insert into semtbl_Token VALUES(''ebe0699a-f61c-4938-94c7-ff2d2063ae63'',''Serbian (Cyrillic)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fc61bfb6-d437-47e5-8078-d7394b064a57'') = 0
	insert into semtbl_Token VALUES(''fc61bfb6-d437-47e5-8078-d7394b064a57'',''Serbian (Latin)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''12d1f7d3-044b-4280-88a4-6056bb2e4678'') = 0
	insert into semtbl_Token VALUES(''12d1f7d3-044b-4280-88a4-6056bb2e4678'',''Slovak'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''9a5986b5-6666-4bfe-955b-028b6da10e8d'') = 0
	insert into semtbl_Token VALUES(''9a5986b5-6666-4bfe-955b-028b6da10e8d'',''Slovenian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f1673f79-a090-4929-afaa-b7fecbfd6e7c'') = 0
	insert into semtbl_Token VALUES(''f1673f79-a090-4929-afaa-b7fecbfd6e7c'',''Spanish (Argentina)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''922b008f-cd4a-4f2b-abf0-e5e341d51a45'') = 0
	insert into semtbl_Token VALUES(''922b008f-cd4a-4f2b-abf0-e5e341d51a45'',''Spanish (Bolivia)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fc27df06-ec8c-4a79-b1d3-2ddce8907c3e'') = 0
	insert into semtbl_Token VALUES(''fc27df06-ec8c-4a79-b1d3-2ddce8907c3e'',''Spanish (Chile)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e845d63e-2c3a-41ef-bf48-ab80559aa828'') = 0
	insert into semtbl_Token VALUES(''e845d63e-2c3a-41ef-bf48-ab80559aa828'',''Spanish (Colombia)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2a178dd8-9ff5-4824-8a99-89d24f0a3b4b'') = 0
	insert into semtbl_Token VALUES(''2a178dd8-9ff5-4824-8a99-89d24f0a3b4b'',''Spanish (Costa Rica)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''834df072-a0e3-4c1b-b2a7-d0eecabaa9c2'') = 0
	insert into semtbl_Token VALUES(''834df072-a0e3-4c1b-b2a7-d0eecabaa9c2'',''Spanish (Dominican Republic)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ebb255f3-3cc9-4bd2-ab9f-00aa610b6b6f'') = 0
	insert into semtbl_Token VALUES(''ebb255f3-3cc9-4bd2-ab9f-00aa610b6b6f'',''Spanish (Ecuador)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''7853af10-78ab-40f0-a717-9b198805970a'') = 0
	insert into semtbl_Token VALUES(''7853af10-78ab-40f0-a717-9b198805970a'',''Spanish (El Salvador)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''29c455c7-c354-4d4c-bc9e-608af47a80df'') = 0
	insert into semtbl_Token VALUES(''29c455c7-c354-4d4c-bc9e-608af47a80df'',''Spanish (Guatemala)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ea775924-7fb5-437e-82a1-deddef020942'') = 0
	insert into semtbl_Token VALUES(''ea775924-7fb5-437e-82a1-deddef020942'',''Spanish (Honduras)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''be46dc41-558e-4447-b49e-c0c5e01e3f5f'') = 0
	insert into semtbl_Token VALUES(''be46dc41-558e-4447-b49e-c0c5e01e3f5f'',''Spanish (International Sort)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''288be3d1-55b1-45fd-b73e-9d46f084913c'') = 0
	insert into semtbl_Token VALUES(''288be3d1-55b1-45fd-b73e-9d46f084913c'',''Spanish (Mexico)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c17b5d35-8aef-4723-8101-9a8dd041661a'') = 0
	insert into semtbl_Token VALUES(''c17b5d35-8aef-4723-8101-9a8dd041661a'',''Spanish (Nicaragua)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''4af0cc5c-b03d-4a0d-aecb-49ef260a1008'') = 0
	insert into semtbl_Token VALUES(''4af0cc5c-b03d-4a0d-aecb-49ef260a1008'',''Spanish (Panama)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''8874a989-724c-40a5-9d79-2bc3a3f07d25'') = 0
	insert into semtbl_Token VALUES(''8874a989-724c-40a5-9d79-2bc3a3f07d25'',''Spanish (Paraguay)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d075ba5e-8639-4a88-aa1f-0538a624c5fa'') = 0
	insert into semtbl_Token VALUES(''d075ba5e-8639-4a88-aa1f-0538a624c5fa'',''Spanish (Peru)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''2a119ac7-3fad-4fe2-bda6-47a8fd1b2c97'') = 0
	insert into semtbl_Token VALUES(''2a119ac7-3fad-4fe2-bda6-47a8fd1b2c97'',''Spanish (Puerto Rico)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f3eb11e5-bd99-402c-8d2b-0521faf5c823'') = 0
	insert into semtbl_Token VALUES(''f3eb11e5-bd99-402c-8d2b-0521faf5c823'',''Spanish (Traditional Sort)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e3106354-aca9-40e7-9189-2e17e19ea72e'') = 0
	insert into semtbl_Token VALUES(''e3106354-aca9-40e7-9189-2e17e19ea72e'',''Spanish (Uruguay)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d6033c6e-e2f5-4b38-bee1-24240d0c3392'') = 0
	insert into semtbl_Token VALUES(''d6033c6e-e2f5-4b38-bee1-24240d0c3392'',''Spanish (Venezuela)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''afab9ecd-4d3e-4caa-b016-f36cc8d95fe5'') = 0
	insert into semtbl_Token VALUES(''afab9ecd-4d3e-4caa-b016-f36cc8d95fe5'',''Swahili'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''f85e7c2a-bb57-4f67-a4a0-2c4a641e816e'') = 0
	insert into semtbl_Token VALUES(''f85e7c2a-bb57-4f67-a4a0-2c4a641e816e'',''Swedish'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''ad7b0d53-7af0-4284-a319-0c3d06afb4aa'') = 0
	insert into semtbl_Token VALUES(''ad7b0d53-7af0-4284-a319-0c3d06afb4aa'',''Swedish (Finland)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''09c605df-dbc1-4582-9b1d-bdb0f52b5691'') = 0
	insert into semtbl_Token VALUES(''09c605df-dbc1-4582-9b1d-bdb0f52b5691'',''Syriac'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''216eeaf8-5fc7-4faf-9978-36e4504d3754'') = 0
	insert into semtbl_Token VALUES(''216eeaf8-5fc7-4faf-9978-36e4504d3754'',''Tamil'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''1a99fde1-c57b-4f28-b093-d9f883ed9fc0'') = 0
	insert into semtbl_Token VALUES(''1a99fde1-c57b-4f28-b093-d9f883ed9fc0'',''Tatar'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e577a60c-edf2-45a8-8628-2fcd348f71c0'') = 0
	insert into semtbl_Token VALUES(''e577a60c-edf2-45a8-8628-2fcd348f71c0'',''Telugu'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a0d3af81-f9d8-4b5c-8a3d-ea69402f4d47'') = 0
	insert into semtbl_Token VALUES(''a0d3af81-f9d8-4b5c-8a3d-ea69402f4d47'',''Thai'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''76032ec6-9e6b-4fc5-9c51-9ec467e63d54'') = 0
	insert into semtbl_Token VALUES(''76032ec6-9e6b-4fc5-9c51-9ec467e63d54'',''Turkish'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''da90319a-487c-4ef8-999b-b0d19ed2a72e'') = 0
	insert into semtbl_Token VALUES(''da90319a-487c-4ef8-999b-b0d19ed2a72e'',''Ukrainian'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''a85cdae9-a7dc-47f2-971e-b370b5a55fb1'') = 0
	insert into semtbl_Token VALUES(''a85cdae9-a7dc-47f2-971e-b370b5a55fb1'',''Urdu'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''86f2611e-301c-4e28-b8b6-cb6008cfc7b0'') = 0
	insert into semtbl_Token VALUES(''86f2611e-301c-4e28-b8b6-cb6008cfc7b0'',''Uzbek (Cyrillic)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''d466f715-ab0b-462f-b276-3705d84e5263'') = 0
	insert into semtbl_Token VALUES(''d466f715-ab0b-462f-b276-3705d84e5263'',''Uzbek (Latin)'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''0d58697c-0035-43ff-8705-ab4aaf4e6140'') = 0
	insert into semtbl_Token VALUES(''0d58697c-0035-43ff-8705-ab4aaf4e6140'',''Vietnamese'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''fad74770-776f-44a8-bf0e-beb6a070218e'') = 0
	insert into semtbl_Token VALUES(''fad74770-776f-44a8-bf0e-beb6a070218e'',''19 %'',''53aa29b7-36e1-4511-b9a4-a743a5fc4535'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''3bad019e-0b9b-480c-8704-1cff0078aad0'') = 0
	insert into semtbl_Token VALUES(''3bad019e-0b9b-480c-8704-1cff0078aad0'',''7 %'',''53aa29b7-36e1-4511-b9a4-a743a5fc4535'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''9b0183f0-c787-4fe8-b5bd-fe038ccd4a7c'' AND GUID_Token_Right=''8b1691d9-b296-4841-b01e-a7b6452eab2f'' AND GUID_RelationType=''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'')=0
	INSERT INTO semtbl_Token_Token VALUES(''9b0183f0-c787-4fe8-b5bd-fe038ccd4a7c'',''8b1691d9-b296-4841-b01e-a7b6452eab2f'',''b18b99bf-08fa-48cf-ba51-765c0bf5a7b7'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''9b0183f0-c787-4fe8-b5bd-fe038ccd4a7c'' AND GUID_Token_Right=''8b1691d9-b296-4841-b01e-a7b6452eab2f'' AND GUID_RelationType=''d91da85b-793c-431c-9724-8ddc1ace170e'')=0
	INSERT INTO semtbl_Token_Token VALUES(''9b0183f0-c787-4fe8-b5bd-fe038ccd4a7c'',''8b1691d9-b296-4841-b01e-a7b6452eab2f'',''d91da85b-793c-431c-9724-8ddc1ace170e'',0)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''46ff89f6-3dcc-40cc-80a5-2cab5b8e1329'' AND GUID_Token_Right=''63188e16-0cd7-4384-90a8-558b47564b7b'' AND GUID_RelationType=''1700a8b9-5f32-44ec-8687-1c5ddb84e109'')=0
	INSERT INTO semtbl_Token_Token VALUES(''46ff89f6-3dcc-40cc-80a5-2cab5b8e1329'',''63188e16-0cd7-4384-90a8-558b47564b7b'',''1700a8b9-5f32-44ec-8687-1c5ddb84e109'',2)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''46ff89f6-3dcc-40cc-80a5-2cab5b8e1329'' AND GUID_Token_Right=''4b469beb-262c-4c70-9d46-6e2f0304e92a'' AND GUID_RelationType=''d91da85b-793c-431c-9724-8ddc1ace170e'')=0
	INSERT INTO semtbl_Token_Token VALUES(''46ff89f6-3dcc-40cc-80a5-2cab5b8e1329'',''4b469beb-262c-4c70-9d46-6e2f0304e92a'',''d91da85b-793c-431c-9724-8ddc1ace170e'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''46ff89f6-3dcc-40cc-80a5-2cab5b8e1329'' AND GUID_Token_Right=''8b1691d9-b296-4841-b01e-a7b6452eab2f'' AND GUID_RelationType=''1700a8b9-5f32-44ec-8687-1c5ddb84e109'')=0
	INSERT INTO semtbl_Token_Token VALUES(''46ff89f6-3dcc-40cc-80a5-2cab5b8e1329'',''8b1691d9-b296-4841-b01e-a7b6452eab2f'',''1700a8b9-5f32-44ec-8687-1c5ddb84e109'',1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Token WHERE GUID_Token_Left=''46ff89f6-3dcc-40cc-80a5-2cab5b8e1329'' AND GUID_Token_Right=''d457a21a-30a3-4751-a7d5-ad3892145c22'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Token_Token VALUES(''46ff89f6-3dcc-40cc-80a5-2cab5b8e1329'',''d457a21a-30a3-4751-a7d5-ad3892145c22'',''e07469d9-766c-443e-8526-6d9c684f944f'',1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',0,1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''e79ff4de-2e39-4101-b5a1-0055c40f41cd'' AND GUID_RelationType=''d91da85b-793c-431c-9724-8ddc1ace170e'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'',''d91da85b-793c-431c-9724-8ddc1ace170e'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''71415eeb-ce46-4b2c-b0a2-f72116b55438'' AND GUID_Type_Right=''e79ff4de-2e39-4101-b5a1-0055c40f41cd'' AND GUID_RelationType=''dd5a24ec-e2bd-47c2-9761-d4a7db114aed'')=0
	INSERT INTO semtbl_Type_Type VALUES(''71415eeb-ce46-4b2c-b0a2-f72116b55438'',''e79ff4de-2e39-4101-b5a1-0055c40f41cd'',''dd5a24ec-e2bd-47c2-9761-d4a7db114aed'',0,-1,-1)'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''dcdff000-be51-47b7-9af7-27a6787d8511'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''dcdff000-be51-47b7-9af7-27a6787d8511'',''c4fa1f93-a20e-41e2-ac71-fa2d4e560567'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''1eba7ba8-8f04-4e97-b79d-9bd59bf71c36'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''1eba7ba8-8f04-4e97-b79d-9bd59bf71c36'',''c4fa1f93-a20e-41e2-ac71-fa2d4e560567'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''b0996793-8f77-4c7e-8ebf-169f9ed8ca61'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''b0996793-8f77-4c7e-8ebf-169f9ed8ca61'',''06348e30-ef97-4fec-b271-eb664fc9da02'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''11d1c68b-579f-4708-bade-929cdd5a11be'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''11d1c68b-579f-4708-bade-929cdd5a11be'',''06348e30-ef97-4fec-b271-eb664fc9da02'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''3c35979f-ef0d-44f7-abfc-047de2e27735'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''3c35979f-ef0d-44f7-abfc-047de2e27735'',''218696d3-4fea-47d4-b051-b77d3bc5e863'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''83a3931e-7b3e-4a9d-88ba-92852845590f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''83a3931e-7b3e-4a9d-88ba-92852845590f'',''218696d3-4fea-47d4-b051-b77d3bc5e863'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''53b0d55a-43da-4625-9849-4506d2a3c4a4'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''53b0d55a-43da-4625-9849-4506d2a3c4a4'',''e2f9ad6e-f8bc-4ba7-9c70-7e44024aaea8'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''f54f0f32-0e7b-406c-9c9e-5ac9fda5c279'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''f54f0f32-0e7b-406c-9c9e-5ac9fda5c279'',''e2f9ad6e-f8bc-4ba7-9c70-7e44024aaea8'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''14c72f86-6226-43b7-bade-05f1908e944d'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''14c72f86-6226-43b7-bade-05f1908e944d'',''60e2b73a-557f-4d6c-8edf-f3af4f27e658'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''c7377283-d869-4f59-bff7-40350fe3ad90'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''c7377283-d869-4f59-bff7-40350fe3ad90'',''60e2b73a-557f-4d6c-8edf-f3af4f27e658'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''fbcce51b-84a6-4f99-9b95-7fab2ddf3d04'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''fbcce51b-84a6-4f99-9b95-7fab2ddf3d04'',''4afb7f8a-8642-4759-afa5-e7c7da442b8d'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''7eb24d1f-e772-48e2-ba7e-c008305395e9'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''7eb24d1f-e772-48e2-ba7e-c008305395e9'',''4afb7f8a-8642-4759-afa5-e7c7da442b8d'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''9be8b2df-9af9-47c9-9890-698261f1b663'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''9be8b2df-9af9-47c9-9890-698261f1b663'',''06843000-dc76-4ad7-af52-92df1fdef1de'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''cec59da6-0dfb-47ec-8f8f-fc32b900047c'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''cec59da6-0dfb-47ec-8f8f-fc32b900047c'',''06843000-dc76-4ad7-af52-92df1fdef1de'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''71a8de47-0f18-499b-a4b7-088c50efbba1'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''71a8de47-0f18-499b-a4b7-088c50efbba1'',''a5c8f86c-862d-447c-9a25-085da9254102'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''1eae3f08-a1eb-4d73-b908-c5b9b783859c'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''1eae3f08-a1eb-4d73-b908-c5b9b783859c'',''a5c8f86c-862d-447c-9a25-085da9254102'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''386f0381-ae6f-4272-af8a-bd091479688f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''386f0381-ae6f-4272-af8a-bd091479688f'',''42fa87f2-a243-4685-be71-537f82dbccbf'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''0bcd3f00-119e-4caa-a7fd-dcb7f62f9956'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''0bcd3f00-119e-4caa-a7fd-dcb7f62f9956'',''42fa87f2-a243-4685-be71-537f82dbccbf'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''378c7c7e-2969-4c1e-8e63-1c004fbcf6bb'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''378c7c7e-2969-4c1e-8e63-1c004fbcf6bb'',''8a589e7c-c4f9-429e-b680-0064ad82c599'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''5162eae9-d6e0-4cd3-9c35-7b0f1686ba7a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''5162eae9-d6e0-4cd3-9c35-7b0f1686ba7a'',''8a589e7c-c4f9-429e-b680-0064ad82c599'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''c3c1b431-ebb2-4764-ac8b-1c9e44434a45'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''c3c1b431-ebb2-4764-ac8b-1c9e44434a45'',''4fa7d29c-676e-484c-b7f4-4a3c5107772f'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ca1212a1-1c27-45a2-8f8a-c285a00ec888'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ca1212a1-1c27-45a2-8f8a-c285a00ec888'',''4fa7d29c-676e-484c-b7f4-4a3c5107772f'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''98dbf914-2ae5-428e-8017-18846ad17542'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''98dbf914-2ae5-428e-8017-18846ad17542'',''ae22b33f-bc22-4388-8d57-98a7cf2e8172'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''831d8f70-1cc7-49b9-b213-63d23a546e34'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''831d8f70-1cc7-49b9-b213-63d23a546e34'',''ae22b33f-bc22-4388-8d57-98a7cf2e8172'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''6018f4aa-e9d5-4e40-a264-11b222f03067'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''6018f4aa-e9d5-4e40-a264-11b222f03067'',''292315cb-3d35-484d-bda7-ca4a0edba366'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''81b5dc51-e845-4c05-8d1c-667d8ff7ed50'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''81b5dc51-e845-4c05-8d1c-667d8ff7ed50'',''292315cb-3d35-484d-bda7-ca4a0edba366'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''df8b6aa7-f639-4b72-a600-00d3eae26575'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''df8b6aa7-f639-4b72-a600-00d3eae26575'',''edc5b6da-6134-4cc3-a7af-a41456d60fe1'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''c2ca6a82-969a-40bf-a266-45eb961d32aa'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''c2ca6a82-969a-40bf-a266-45eb961d32aa'',''edc5b6da-6134-4cc3-a7af-a41456d60fe1'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''83775dc6-128d-4d22-8d55-6149246f7356'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''83775dc6-128d-4d22-8d55-6149246f7356'',''17b675cc-d57a-43cd-b427-006694feeea6'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''8e24a1f2-c10c-4a07-84f9-f2e6c76b84f4'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''8e24a1f2-c10c-4a07-84f9-f2e6c76b84f4'',''17b675cc-d57a-43cd-b427-006694feeea6'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ef9362b3-fa86-4dab-a2f3-3562239129bf'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ef9362b3-fa86-4dab-a2f3-3562239129bf'',''e504e18d-9f59-4ce3-82b8-d04f9c074fdd'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e6a85f24-87ae-4a92-92c6-fa78ed78419f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e6a85f24-87ae-4a92-92c6-fa78ed78419f'',''e504e18d-9f59-4ce3-82b8-d04f9c074fdd'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''4ad7c14b-dae7-4cac-99be-25de06296928'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''4ad7c14b-dae7-4cac-99be-25de06296928'',''0345bbfd-8879-403d-bb5f-b682a391118f'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''8f19c3f9-7aaf-4fb4-a9b2-cef1fb7b31e3'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''8f19c3f9-7aaf-4fb4-a9b2-cef1fb7b31e3'',''0345bbfd-8879-403d-bb5f-b682a391118f'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''c4ec2a85-5f04-4517-8778-30b76b8acc94'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''c4ec2a85-5f04-4517-8778-30b76b8acc94'',''ac70f8b9-1ef5-4dd2-936b-10deb1020ad0'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''bcdcd63a-efdb-42b9-a3ff-e3f52a345387'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''bcdcd63a-efdb-42b9-a3ff-e3f52a345387'',''ac70f8b9-1ef5-4dd2-936b-10deb1020ad0'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ecbeb237-24cb-474d-aa06-0393f9427582'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ecbeb237-24cb-474d-aa06-0393f9427582'',''c07cebad-a87e-4b19-a14d-568db71189df'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''83c2bf3a-362a-4a24-90db-2303576c0603'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''83c2bf3a-362a-4a24-90db-2303576c0603'',''c07cebad-a87e-4b19-a14d-568db71189df'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''2a18a0b6-9801-48a5-8744-1138bc573f99'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''2a18a0b6-9801-48a5-8744-1138bc573f99'',''1b1d7941-f461-4556-8d16-481979f9811c'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''03b62c88-70ca-40f0-a09f-c34841fe642d'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''03b62c88-70ca-40f0-a09f-c34841fe642d'',''1b1d7941-f461-4556-8d16-481979f9811c'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''7575fcec-34b3-41f0-a228-13c91cd72cf5'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''7575fcec-34b3-41f0-a228-13c91cd72cf5'',''cb347ce2-21b9-4dc6-bfcc-04ce463e4718'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''d17cffd0-da2d-410b-976c-442bfd231083'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''d17cffd0-da2d-410b-976c-442bfd231083'',''cb347ce2-21b9-4dc6-bfcc-04ce463e4718'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ac02d238-54ac-4b95-b957-5e2a10fa1369'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ac02d238-54ac-4b95-b957-5e2a10fa1369'',''25ee93f1-9728-4080-86b6-ebb96479874f'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''64004e4d-6736-4899-8de8-a96b12b347c2'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''64004e4d-6736-4899-8de8-a96b12b347c2'',''25ee93f1-9728-4080-86b6-ebb96479874f'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''eb8068fd-da3e-4893-8d7f-f7889356d2fb'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''eb8068fd-da3e-4893-8d7f-f7889356d2fb'',''a84b6a1b-bacd-4e75-a764-6da76bce4320'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''d94a0426-e965-4cd8-ad0b-fc9a8074968a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''d94a0426-e965-4cd8-ad0b-fc9a8074968a'',''a84b6a1b-bacd-4e75-a764-6da76bce4320'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''a4de92a8-6194-4b8d-a7b8-3000767ed895'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''a4de92a8-6194-4b8d-a7b8-3000767ed895'',''ac29369d-b137-41fb-a3ad-45f62c75520c'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''144414ad-7c9d-48f3-8746-e0d360bbf2e1'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''144414ad-7c9d-48f3-8746-e0d360bbf2e1'',''ac29369d-b137-41fb-a3ad-45f62c75520c'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''bf97ffd7-fe3f-4587-a29b-2c3dcbbe54d3'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''bf97ffd7-fe3f-4587-a29b-2c3dcbbe54d3'',''70d5aadf-0f4e-4454-87fc-1a6770f88700'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''4d716fca-aeec-4870-9b77-7f2d54501185'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''4d716fca-aeec-4870-9b77-7f2d54501185'',''70d5aadf-0f4e-4454-87fc-1a6770f88700'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''7375de25-cf9d-4067-a196-91e81cca3278'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''7375de25-cf9d-4067-a196-91e81cca3278'',''cbe616f3-62d4-4952-9f08-498bc512fe13'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''84470114-6254-4fab-8885-f5a09bc781b3'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''84470114-6254-4fab-8885-f5a09bc781b3'',''cbe616f3-62d4-4952-9f08-498bc512fe13'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e1b8072b-58bf-446d-a621-2b6138bfdb2e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e1b8072b-58bf-446d-a621-2b6138bfdb2e'',''64a33fc4-2b64-4671-b765-30bd59472a67'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''60903e4f-bb4d-4d9e-833f-558e5deda75a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''60903e4f-bb4d-4d9e-833f-558e5deda75a'',''64a33fc4-2b64-4671-b765-30bd59472a67'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''deca2ae2-c0de-495f-bd0f-543d79ff0019'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''deca2ae2-c0de-495f-bd0f-543d79ff0019'',''b17e81f9-d0d2-4842-8d30-a5fb21b3cd16'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''7896daf6-30fe-4453-8a2c-fbdab5598dc5'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''7896daf6-30fe-4453-8a2c-fbdab5598dc5'',''b17e81f9-d0d2-4842-8d30-a5fb21b3cd16'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''c2a99db5-a925-4aaa-a8ee-5fa5fea0b770'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''c2a99db5-a925-4aaa-a8ee-5fa5fea0b770'',''1616a947-46fb-492b-831f-dff38a20b1b8'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ef974980-9bd2-4330-a6a8-8a386240d816'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ef974980-9bd2-4330-a6a8-8a386240d816'',''1616a947-46fb-492b-831f-dff38a20b1b8'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ea306c2f-0db7-4575-ae80-3ff7eff9313f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ea306c2f-0db7-4575-ae80-3ff7eff9313f'',''33f7a97d-6375-47b4-b376-6215f311b4bc'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''f79a6a4a-239a-4197-90a4-6859f2636ad9'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''f79a6a4a-239a-4197-90a4-6859f2636ad9'',''33f7a97d-6375-47b4-b376-6215f311b4bc'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''c6741539-a335-4752-8133-a25f903aa293'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''c6741539-a335-4752-8133-a25f903aa293'',''33582b69-5d51-4e62-924e-1a6abfd5b14c'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''a93942f3-0c61-4881-a24d-a2641833dc1c'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''a93942f3-0c61-4881-a24d-a2641833dc1c'',''33582b69-5d51-4e62-924e-1a6abfd5b14c'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''2d7824ca-e800-4dc3-b2d7-abea1605887d'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''2d7824ca-e800-4dc3-b2d7-abea1605887d'',''72e36d98-6cd9-4832-975c-23f064a8d1d4'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''59d5841b-ecd3-43ac-b22b-b7d4b7887cac'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''59d5841b-ecd3-43ac-b22b-b7d4b7887cac'',''72e36d98-6cd9-4832-975c-23f064a8d1d4'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''6ee402fb-1371-446b-806a-940bb0e15f4b'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''6ee402fb-1371-446b-806a-940bb0e15f4b'',''008d943f-dad7-475b-b3c2-286048b4049d'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''9f81bafe-acb8-43bf-a17f-c63bdcccc0e8'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''9f81bafe-acb8-43bf-a17f-c63bdcccc0e8'',''008d943f-dad7-475b-b3c2-286048b4049d'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''29f7bd42-cbea-4933-bec0-5764f3fe3cf2'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''29f7bd42-cbea-4933-bec0-5764f3fe3cf2'',''32f064e6-75ac-4c4c-a3af-18b1e11bdbe3'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''089c76d4-4268-43ab-9d75-ba0e033095f7'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''089c76d4-4268-43ab-9d75-ba0e033095f7'',''32f064e6-75ac-4c4c-a3af-18b1e11bdbe3'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''679b9323-b5c6-440b-ba4c-9988b3ae4fc4'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''679b9323-b5c6-440b-ba4c-9988b3ae4fc4'',''99eeb55d-a5c5-4654-96e0-5c9b32cf10b6'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''266f922b-e2e8-4b3e-b4d9-fcfbdeb257a6'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''266f922b-e2e8-4b3e-b4d9-fcfbdeb257a6'',''99eeb55d-a5c5-4654-96e0-5c9b32cf10b6'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''0f9a9667-ec96-494b-a4e4-81a7d7acb6ac'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''0f9a9667-ec96-494b-a4e4-81a7d7acb6ac'',''8827d139-113b-4d82-9dd6-af25de47c68f'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''5f3189e6-649e-42fc-b856-b60e22ffac2f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''5f3189e6-649e-42fc-b856-b60e22ffac2f'',''8827d139-113b-4d82-9dd6-af25de47c68f'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''86e689f4-5c4f-4f7f-8281-22aa30df1702'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''86e689f4-5c4f-4f7f-8281-22aa30df1702'',''99ad4502-6ab2-4c93-89be-dd2974833ec3'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''66a48aa6-744a-4ec9-9409-3930ed79dc25'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''66a48aa6-744a-4ec9-9409-3930ed79dc25'',''99ad4502-6ab2-4c93-89be-dd2974833ec3'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''2bb78495-92d1-4d5e-9d2b-2765d7c7e3bd'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''2bb78495-92d1-4d5e-9d2b-2765d7c7e3bd'',''1c17407d-0153-4981-89f0-3284040a176f'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''b00c6b4c-5706-4d61-bb2a-beedfb616b95'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''b00c6b4c-5706-4d61-bb2a-beedfb616b95'',''1c17407d-0153-4981-89f0-3284040a176f'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''01b89986-7976-48d9-a2f2-3816c418a34b'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''01b89986-7976-48d9-a2f2-3816c418a34b'',''a24a8c04-213b-47e8-a6d0-22f03c15efed'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''90472e62-5fe4-4519-b3b5-54212b69d4bd'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''90472e62-5fe4-4519-b3b5-54212b69d4bd'',''a24a8c04-213b-47e8-a6d0-22f03c15efed'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''674c2e6e-12f9-4ca3-a358-7dd902f71281'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''674c2e6e-12f9-4ca3-a358-7dd902f71281'',''c4252f4b-fff4-421f-90a8-0b9604fda36e'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''53718060-46ef-4095-887a-fec5645710c1'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''53718060-46ef-4095-887a-fec5645710c1'',''c4252f4b-fff4-421f-90a8-0b9604fda36e'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''21a504b2-fbc4-4b15-bc51-149b0099063a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''21a504b2-fbc4-4b15-bc51-149b0099063a'',''64ccdb6d-1596-4f5c-bbfe-c19742952b64'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''19641462-9172-44d1-af06-7d2e10bdbdbb'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''19641462-9172-44d1-af06-7d2e10bdbdbb'',''64ccdb6d-1596-4f5c-bbfe-c19742952b64'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''cbc73fab-57c7-49f4-8e35-cd942a899cc7'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''cbc73fab-57c7-49f4-8e35-cd942a899cc7'',''ea47c4ae-c0be-47cc-ad19-341b8c598f5f'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''7db92acf-dbd4-4806-b27c-df30a374908b'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''7db92acf-dbd4-4806-b27c-df30a374908b'',''ea47c4ae-c0be-47cc-ad19-341b8c598f5f'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''5298be9c-47a5-44d2-8c24-c811e5cc0e0e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''5298be9c-47a5-44d2-8c24-c811e5cc0e0e'',''1a286a0f-03dd-48d0-96e0-ecdf5715aae8'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''f2fdfb74-69f2-4d3a-89b2-ee994c099f05'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''f2fdfb74-69f2-4d3a-89b2-ee994c099f05'',''1a286a0f-03dd-48d0-96e0-ecdf5715aae8'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''5de8f524-eb15-441c-b488-f49a3906f9d8'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''5de8f524-eb15-441c-b488-f49a3906f9d8'',''6509bdbc-1ed9-49df-a530-1aa108478f2b'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''fb4fac55-6142-4034-94e1-f9281f0a54e2'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''fb4fac55-6142-4034-94e1-f9281f0a54e2'',''6509bdbc-1ed9-49df-a530-1aa108478f2b'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''46794ead-2009-498a-8b61-47153c8085e9'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''46794ead-2009-498a-8b61-47153c8085e9'',''f649e13c-bd3d-456e-8d6c-a42204cbc22a'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''53f2aa43-056c-4658-ac9e-4f133d85e212'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''53f2aa43-056c-4658-ac9e-4f133d85e212'',''f649e13c-bd3d-456e-8d6c-a42204cbc22a'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''c3682d33-7f87-487d-8e44-8af9bb041a23'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''c3682d33-7f87-487d-8e44-8af9bb041a23'',''e681c7d8-1a80-4f49-a2cf-3c610879a7fb'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ed34d46e-500d-42d5-aa4d-a9fa7bec5dda'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ed34d46e-500d-42d5-aa4d-a9fa7bec5dda'',''e681c7d8-1a80-4f49-a2cf-3c610879a7fb'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''5ff74470-9b7b-4512-a276-92493a9fff0a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''5ff74470-9b7b-4512-a276-92493a9fff0a'',''0205e668-03d2-4eff-84c0-e46be0c7d4c0'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''829aa3fa-d192-42cf-94be-96a0e2460898'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''829aa3fa-d192-42cf-94be-96a0e2460898'',''0205e668-03d2-4eff-84c0-e46be0c7d4c0'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''57e6d7d0-0c8c-4d5c-b5eb-b749182e6ca5'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''57e6d7d0-0c8c-4d5c-b5eb-b749182e6ca5'',''63188e16-0cd7-4384-90a8-558b47564b7b'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''04f1d2e9-3138-4ef0-8de1-e8b4f23e53c4'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''04f1d2e9-3138-4ef0-8de1-e8b4f23e53c4'',''63188e16-0cd7-4384-90a8-558b47564b7b'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''34ac1372-06ec-4d38-8abb-5dbd10ccffa3'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''34ac1372-06ec-4d38-8abb-5dbd10ccffa3'',''63188e16-0cd7-4384-90a8-558b47564b7b'',''04048642-e81e-4026-841a-fb377a02dbc5'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''d2494060-c251-4171-97d3-2e75b5bc6eae'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''d2494060-c251-4171-97d3-2e75b5bc6eae'',''78b80a6e-0d74-4734-9ecf-f56bccb3b7e9'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e8cea458-1ce8-4ec5-baef-fccc797189ff'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e8cea458-1ce8-4ec5-baef-fccc797189ff'',''78b80a6e-0d74-4734-9ecf-f56bccb3b7e9'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''8ea96efc-1426-445c-a84d-95a3b3230952'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''8ea96efc-1426-445c-a84d-95a3b3230952'',''cb2a0bd2-47be-4c39-8123-ef5c8d0716b0'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''a461db06-051f-4ec4-8d9c-aa2dc5876b15'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''a461db06-051f-4ec4-8d9c-aa2dc5876b15'',''cb2a0bd2-47be-4c39-8123-ef5c8d0716b0'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''4115d43e-23ed-494e-9358-bb5aa4433020'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''4115d43e-23ed-494e-9358-bb5aa4433020'',''61468373-5730-4c02-93ad-831771e4c46d'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''0b2d84d1-8599-441a-bd05-f24880d0396e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''0b2d84d1-8599-441a-bd05-f24880d0396e'',''61468373-5730-4c02-93ad-831771e4c46d'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''71b0898c-0e26-42e4-8a68-4a9da99396c5'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''71b0898c-0e26-42e4-8a68-4a9da99396c5'',''252cb7f4-929e-435a-bb37-37c34f8eee7f'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''98c2921a-4290-4137-a1e5-7141dce87842'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''98c2921a-4290-4137-a1e5-7141dce87842'',''252cb7f4-929e-435a-bb37-37c34f8eee7f'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''b14a72a7-a11f-49d0-832c-77fb39824ad5'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''b14a72a7-a11f-49d0-832c-77fb39824ad5'',''abc695dd-307d-4bd8-9e9e-89e5d6a10c9b'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ed6f17b3-ce43-494e-a46b-da98bcae3d39'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ed6f17b3-ce43-494e-a46b-da98bcae3d39'',''abc695dd-307d-4bd8-9e9e-89e5d6a10c9b'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ccf99630-9a77-47b0-94bb-1e472646fd39'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ccf99630-9a77-47b0-94bb-1e472646fd39'',''018f6434-6c6c-4ea4-82ea-5ad9afef3a31'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e8af9247-58af-41fb-a971-da43bcec778a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e8af9247-58af-41fb-a971-da43bcec778a'',''018f6434-6c6c-4ea4-82ea-5ad9afef3a31'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''2c7c6d5d-94b7-478a-a723-19df8f0e260e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''2c7c6d5d-94b7-478a-a723-19df8f0e260e'',''ef0b4629-ac58-43c5-a218-232c0fb49740'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ffe2640a-2bdb-4172-9a64-e7714372d850'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ffe2640a-2bdb-4172-9a64-e7714372d850'',''ef0b4629-ac58-43c5-a218-232c0fb49740'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''c5e80de3-fd7a-498d-bb30-f7f44cc2712b'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''c5e80de3-fd7a-498d-bb30-f7f44cc2712b'',''02d2019b-dccf-4235-ae92-6882eea2ff0d'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''19732f72-55fa-4d0c-baef-f818ae8b8062'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''19732f72-55fa-4d0c-baef-f818ae8b8062'',''02d2019b-dccf-4235-ae92-6882eea2ff0d'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''d626e82d-3be7-4456-841b-7ac37b518794'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''d626e82d-3be7-4456-841b-7ac37b518794'',''a89c0ae6-c792-4cbb-9a3f-caf82e9c4d34'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''53deac9e-f7a3-4f85-bde8-ef540a00c117'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''53deac9e-f7a3-4f85-bde8-ef540a00c117'',''a89c0ae6-c792-4cbb-9a3f-caf82e9c4d34'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''b743204c-657a-4405-be07-3c024f27e0f4'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''b743204c-657a-4405-be07-3c024f27e0f4'',''50036ceb-6386-44c2-8342-6d05401b6841'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''671f7c1e-6bff-41cc-a206-533a76325eba'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''671f7c1e-6bff-41cc-a206-533a76325eba'',''50036ceb-6386-44c2-8342-6d05401b6841'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''5b29b20f-cd20-4885-b912-a10935addd61'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''5b29b20f-cd20-4885-b912-a10935addd61'',''c9746268-13b1-42c9-9b49-b01843c210ab'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''8cb78f05-bf46-46f8-99b0-eeecf30f51dc'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''8cb78f05-bf46-46f8-99b0-eeecf30f51dc'',''c9746268-13b1-42c9-9b49-b01843c210ab'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''b876562f-8192-4493-89c6-217f39f5c22d'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''b876562f-8192-4493-89c6-217f39f5c22d'',''b2f6a723-7d4e-4706-8290-bf22e86b54ee'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''539a3fbf-ae99-4081-8d57-851416d6cbb5'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''539a3fbf-ae99-4081-8d57-851416d6cbb5'',''b2f6a723-7d4e-4706-8290-bf22e86b54ee'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''bd2165fc-e47c-4f6c-991d-78fab0fd03ad'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''bd2165fc-e47c-4f6c-991d-78fab0fd03ad'',''6934ea66-210e-4c21-a750-d8468dd1eaa2'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''8b6cd1fa-7322-4dd4-b6cd-fe96253ded61'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''8b6cd1fa-7322-4dd4-b6cd-fe96253ded61'',''6934ea66-210e-4c21-a750-d8468dd1eaa2'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''99daedd4-53db-4d31-9dff-2cc60a6948fa'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''99daedd4-53db-4d31-9dff-2cc60a6948fa'',''a52f984b-9dec-40d1-b992-16da249bb84b'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ba070723-4403-4fcc-9597-9f7bb26bc98b'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ba070723-4403-4fcc-9597-9f7bb26bc98b'',''a52f984b-9dec-40d1-b992-16da249bb84b'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''dd58bd84-5b65-4520-b0e7-84d67b22628c'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''dd58bd84-5b65-4520-b0e7-84d67b22628c'',''a70a8dbb-32a1-427b-b649-e452716008e0'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''d38aa2ed-ba46-439d-b39c-a0ebf25771a7'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''d38aa2ed-ba46-439d-b39c-a0ebf25771a7'',''a70a8dbb-32a1-427b-b649-e452716008e0'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
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
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''0e00ded7-6586-4654-a876-649b65724d85'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''0e00ded7-6586-4654-a876-649b65724d85'',''b0b0b703-d066-483a-b340-a8017899bf61'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e110aa17-5622-42c5-b949-d365b1b9d6bb'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e110aa17-5622-42c5-b949-d365b1b9d6bb'',''b0b0b703-d066-483a-b340-a8017899bf61'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''3492099a-9927-41b1-97ea-0a6619955a6f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''3492099a-9927-41b1-97ea-0a6619955a6f'',''64d71ff6-18c2-4984-89f8-7193e42ecc3d'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ebd3a062-8201-4fb2-ac67-de2e6e660d7a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ebd3a062-8201-4fb2-ac67-de2e6e660d7a'',''64d71ff6-18c2-4984-89f8-7193e42ecc3d'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e7a94810-826a-4971-b88a-4942ae6ce1de'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e7a94810-826a-4971-b88a-4942ae6ce1de'',''e1ce8149-d8be-4f96-a20b-0800b856567b'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e2175206-076a-45e7-852f-ef2724b736b8'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e2175206-076a-45e7-852f-ef2724b736b8'',''e1ce8149-d8be-4f96-a20b-0800b856567b'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''b0d8dd2b-36a8-4134-868f-7ef4ab3bce19'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''b0d8dd2b-36a8-4134-868f-7ef4ab3bce19'',''7c0341b0-0d4d-4c31-b487-79aef88d2e8c'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''c77e6036-91f0-4ab1-89a4-ab6c6e5025e4'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''c77e6036-91f0-4ab1-89a4-ab6c6e5025e4'',''7c0341b0-0d4d-4c31-b487-79aef88d2e8c'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''f1a29c7a-8155-4427-a09d-9a75cac52498'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''f1a29c7a-8155-4427-a09d-9a75cac52498'',''0af393e7-bbbc-4271-b4a4-0856e086af20'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''35ce2355-00ab-4697-9b38-f0602b02a8aa'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''35ce2355-00ab-4697-9b38-f0602b02a8aa'',''0af393e7-bbbc-4271-b4a4-0856e086af20'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''5b9d880d-4e47-4de1-8027-1ebbc5cf99ed'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''5b9d880d-4e47-4de1-8027-1ebbc5cf99ed'',''07963a9c-a9c8-4dc2-8e35-f93c43eea049'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''b4766e07-4f85-44ee-b898-496ef7e9f91f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''b4766e07-4f85-44ee-b898-496ef7e9f91f'',''07963a9c-a9c8-4dc2-8e35-f93c43eea049'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''b8f47c9b-0565-4d34-833f-07e0371d97e6'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''b8f47c9b-0565-4d34-833f-07e0371d97e6'',''e47307a7-bf54-4e1c-9741-5d93944aa89f'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''7dc84ec6-bda2-4d4b-83e0-7f1d1ffa6a83'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''7dc84ec6-bda2-4d4b-83e0-7f1d1ffa6a83'',''e47307a7-bf54-4e1c-9741-5d93944aa89f'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''b77569f2-77a0-4d07-bafc-ae4651f5c244'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''b77569f2-77a0-4d07-bafc-ae4651f5c244'',''2cd5aeb3-dc62-47c9-9531-95a416073303'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''f7cc55cd-ec1b-488f-a374-c179e305be9e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''f7cc55cd-ec1b-488f-a374-c179e305be9e'',''2cd5aeb3-dc62-47c9-9531-95a416073303'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''db137b63-a662-44b8-94ce-51c079999c3f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''db137b63-a662-44b8-94ce-51c079999c3f'',''79ace185-b0b3-4528-9bff-0900caf1723e'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''4aa5bd56-6986-40f1-81ad-71c2476b9128'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''4aa5bd56-6986-40f1-81ad-71c2476b9128'',''79ace185-b0b3-4528-9bff-0900caf1723e'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''81682b59-2aa0-446d-abf6-089258c5ef99'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''81682b59-2aa0-446d-abf6-089258c5ef99'',''44981266-77b3-4b8a-b7e6-0a92882277c9'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''f434c5be-fb7e-4c77-82ef-99c89620ebed'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''f434c5be-fb7e-4c77-82ef-99c89620ebed'',''44981266-77b3-4b8a-b7e6-0a92882277c9'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''fdae0590-ce65-4fbd-910b-8e6c0181d2e0'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''fdae0590-ce65-4fbd-910b-8e6c0181d2e0'',''3807cefa-38cc-4337-aac1-26fb6e74d4e8'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''8ef9bdd2-ea71-456f-97bc-ff1422d84d54'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''8ef9bdd2-ea71-456f-97bc-ff1422d84d54'',''3807cefa-38cc-4337-aac1-26fb6e74d4e8'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''42371320-7c4a-4db3-84c3-3120085295bf'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''42371320-7c4a-4db3-84c3-3120085295bf'',''24a9bba2-0b69-4a27-9053-201b6383ce97'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''8931cee5-b3d7-40ea-950b-8e242b7e06cf'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''8931cee5-b3d7-40ea-950b-8e242b7e06cf'',''24a9bba2-0b69-4a27-9053-201b6383ce97'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''f7f2bbd2-3ef9-4fca-8143-a5502282cc3f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''f7f2bbd2-3ef9-4fca-8143-a5502282cc3f'',''8c3c894a-0dfe-48fe-b90b-bc153e453bf8'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''1fbabf26-f6e4-438e-99e6-f01785188291'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''1fbabf26-f6e4-438e-99e6-f01785188291'',''8c3c894a-0dfe-48fe-b90b-bc153e453bf8'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''3b73181a-bf4c-46a2-9bc7-1ba1a2963617'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''3b73181a-bf4c-46a2-9bc7-1ba1a2963617'',''b8e421ed-fa3c-414e-b78c-e2cc4953f06a'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''6debca91-7219-4c15-b958-59a7fae2c728'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''6debca91-7219-4c15-b958-59a7fae2c728'',''b8e421ed-fa3c-414e-b78c-e2cc4953f06a'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''9eee34b2-4955-40a3-9edf-9b70d65b9878'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''9eee34b2-4955-40a3-9edf-9b70d65b9878'',''db470f18-a94d-4c72-9df3-7c9c81926882'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''d88d56b5-cddf-4e9c-89fd-cf5c408b0256'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''d88d56b5-cddf-4e9c-89fd-cf5c408b0256'',''db470f18-a94d-4c72-9df3-7c9c81926882'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''96c6d13b-1633-40d3-8a2c-a551e224960d'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''96c6d13b-1633-40d3-8a2c-a551e224960d'',''468bacd0-0ba3-4dc5-8106-f686c7dd62fc'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''39b93e74-9c9a-44ec-975a-c8974c10d9dc'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''39b93e74-9c9a-44ec-975a-c8974c10d9dc'',''468bacd0-0ba3-4dc5-8106-f686c7dd62fc'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''1293e051-dbf8-4727-9768-767e5546105c'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''1293e051-dbf8-4727-9768-767e5546105c'',''c402aa47-aa42-49cf-93fb-06b96b308b25'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''3c6848f5-5dac-4b18-b798-e9887ceac16c'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''3c6848f5-5dac-4b18-b798-e9887ceac16c'',''c402aa47-aa42-49cf-93fb-06b96b308b25'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''854f1921-a471-4923-bfb3-55a3fb55084f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''854f1921-a471-4923-bfb3-55a3fb55084f'',''e14a709e-ef54-4dc8-b3db-98aff4466109'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''798f76a8-8550-432d-9c04-ece755e2f6ed'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''798f76a8-8550-432d-9c04-ece755e2f6ed'',''e14a709e-ef54-4dc8-b3db-98aff4466109'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''7d23a9b7-b9fa-497f-b60d-0cf70433b891'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''7d23a9b7-b9fa-497f-b60d-0cf70433b891'',''333d115d-79b9-45fe-b54a-8ccd53e6e993'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''eb44ccc4-5958-4eaf-a0ad-b2363bce60d4'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''eb44ccc4-5958-4eaf-a0ad-b2363bce60d4'',''333d115d-79b9-45fe-b54a-8ccd53e6e993'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''70d59e70-25df-4906-bc8b-6ab6cbc9237d'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''70d59e70-25df-4906-bc8b-6ab6cbc9237d'',''5e57ccc2-4a1d-4291-9432-15357a9bfdf7'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''1b087aa9-ae91-4383-98b8-89437766afdc'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''1b087aa9-ae91-4383-98b8-89437766afdc'',''5e57ccc2-4a1d-4291-9432-15357a9bfdf7'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''bf19078e-e857-4672-903d-57765529673f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''bf19078e-e857-4672-903d-57765529673f'',''43004171-d1a9-444c-867c-e23d33daf448'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''6b33be20-33ba-47f6-b430-7d90e651ff13'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''6b33be20-33ba-47f6-b430-7d90e651ff13'',''43004171-d1a9-444c-867c-e23d33daf448'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''3f31079f-30be-49fd-9b8d-343fe480a648'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''3f31079f-30be-49fd-9b8d-343fe480a648'',''40dae110-1cec-4819-944c-5580e1dfe5d9'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''8b7b1328-f6c5-4055-b148-a22b12ae8740'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''8b7b1328-f6c5-4055-b148-a22b12ae8740'',''40dae110-1cec-4819-944c-5580e1dfe5d9'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''81d2a5a7-e96a-4129-bef1-827828e63acf'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''81d2a5a7-e96a-4129-bef1-827828e63acf'',''91c14368-44d2-4d55-b78a-df813b08b114'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ccfa9465-4cef-4984-8260-85136b68bb74'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ccfa9465-4cef-4984-8260-85136b68bb74'',''91c14368-44d2-4d55-b78a-df813b08b114'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e715ebe3-236a-4854-b4fe-3879bad7c48d'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e715ebe3-236a-4854-b4fe-3879bad7c48d'',''0f9c25f5-e637-4d40-b9b0-aaccc003eabf'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''3ce7cbf9-e7c7-421a-aa45-55d4c2b8089a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''3ce7cbf9-e7c7-421a-aa45-55d4c2b8089a'',''0f9c25f5-e637-4d40-b9b0-aaccc003eabf'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ed271007-3d71-483b-b598-86bce7d80dca'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ed271007-3d71-483b-b598-86bce7d80dca'',''2533f16f-bc8a-40e8-ab66-68968ba6ca82'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ceffa477-e8a9-4587-ad85-9d60f0e2bfbe'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ceffa477-e8a9-4587-ad85-9d60f0e2bfbe'',''2533f16f-bc8a-40e8-ab66-68968ba6ca82'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''164a220e-5133-459c-a65c-16bc17b242d0'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''164a220e-5133-459c-a65c-16bc17b242d0'',''bfd06795-9a1c-4d42-87ec-a21fefad13d3'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e533f717-0180-4db0-a869-9978ad5f8511'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e533f717-0180-4db0-a869-9978ad5f8511'',''bfd06795-9a1c-4d42-87ec-a21fefad13d3'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''46fcb4b4-26d3-45a4-9fdb-3e3052a84a1e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''46fcb4b4-26d3-45a4-9fdb-3e3052a84a1e'',''0fb4cca8-cb62-49be-845d-3ab3df4c558f'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''03b9258d-22aa-4ce7-b64b-633a60a7ba21'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''03b9258d-22aa-4ce7-b64b-633a60a7ba21'',''0fb4cca8-cb62-49be-845d-3ab3df4c558f'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''4cfd6494-911a-4146-ba53-3807fca8c5d5'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''4cfd6494-911a-4146-ba53-3807fca8c5d5'',''7b628560-0554-4184-b4d6-f12f2c1875af'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''39e2b610-45c7-4033-ac92-c7401cc547d2'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''39e2b610-45c7-4033-ac92-c7401cc547d2'',''7b628560-0554-4184-b4d6-f12f2c1875af'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ffede54d-14c9-4807-a75d-963f68ed4d13'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ffede54d-14c9-4807-a75d-963f68ed4d13'',''975e6418-8766-4339-b24b-21b9660d5902'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''46cd5909-d6d5-4175-953b-a3e6ca5c5bd3'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''46cd5909-d6d5-4175-953b-a3e6ca5c5bd3'',''975e6418-8766-4339-b24b-21b9660d5902'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''7d252c64-ec27-4a7c-9ba0-62376958ef89'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''7d252c64-ec27-4a7c-9ba0-62376958ef89'',''72209641-7b00-40e7-a0de-0eb26747c2ff'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''91cef11c-0a79-41a8-9ee8-bb89a63f699a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''91cef11c-0a79-41a8-9ee8-bb89a63f699a'',''72209641-7b00-40e7-a0de-0eb26747c2ff'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''95359cbb-7eed-4364-a915-385426c49d59'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''95359cbb-7eed-4364-a915-385426c49d59'',''8eb9d2c2-3c45-4180-b90a-e7c12d0b2e90'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e7acb3fb-5775-4646-b618-c9bdaf36dbba'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e7acb3fb-5775-4646-b618-c9bdaf36dbba'',''8eb9d2c2-3c45-4180-b90a-e7c12d0b2e90'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''395a25c4-7c9e-443b-bf9b-89ff22047723'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''395a25c4-7c9e-443b-bf9b-89ff22047723'',''98d3016c-bcda-4d5a-b1c1-e19fb7531780'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''c9c42b26-a369-4e69-9c07-a3c6303f306f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''c9c42b26-a369-4e69-9c07-a3c6303f306f'',''98d3016c-bcda-4d5a-b1c1-e19fb7531780'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''bdf63994-2fc8-402f-9b58-ba2920bb07be'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''bdf63994-2fc8-402f-9b58-ba2920bb07be'',''25079f72-fd8a-41c1-8bc8-8a8572f61f98'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''c496006f-682a-45a3-b3a3-d04091449f6b'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''c496006f-682a-45a3-b3a3-d04091449f6b'',''25079f72-fd8a-41c1-8bc8-8a8572f61f98'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''a3d64e4a-74a9-4c8f-9874-1b560034242c'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''a3d64e4a-74a9-4c8f-9874-1b560034242c'',''ebe0699a-f61c-4938-94c7-ff2d2063ae63'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''a110b8a6-2809-4bec-bb2d-77d33bb40d7a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''a110b8a6-2809-4bec-bb2d-77d33bb40d7a'',''ebe0699a-f61c-4938-94c7-ff2d2063ae63'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''3ca1ffb8-3af8-40c3-b9af-5d515348bc8b'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''3ca1ffb8-3af8-40c3-b9af-5d515348bc8b'',''fc61bfb6-d437-47e5-8078-d7394b064a57'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''69200ca9-5d05-4360-a072-afdeb8986422'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''69200ca9-5d05-4360-a072-afdeb8986422'',''fc61bfb6-d437-47e5-8078-d7394b064a57'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''7eac02f4-ed48-4b68-8982-3ba095d87910'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''7eac02f4-ed48-4b68-8982-3ba095d87910'',''12d1f7d3-044b-4280-88a4-6056bb2e4678'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''48fd3cd7-2082-491b-b15d-e0de41f56950'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''48fd3cd7-2082-491b-b15d-e0de41f56950'',''12d1f7d3-044b-4280-88a4-6056bb2e4678'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''4f84c7e0-5d06-4a2b-acbf-eba913e890e9'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''4f84c7e0-5d06-4a2b-acbf-eba913e890e9'',''9a5986b5-6666-4bfe-955b-028b6da10e8d'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''5ab877e9-c4b0-4593-a513-fbdf9f173e62'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''5ab877e9-c4b0-4593-a513-fbdf9f173e62'',''9a5986b5-6666-4bfe-955b-028b6da10e8d'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''9c3fa2ef-9504-47af-8632-334b16869c3e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''9c3fa2ef-9504-47af-8632-334b16869c3e'',''f1673f79-a090-4929-afaa-b7fecbfd6e7c'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ad485cb4-d55c-4992-9a5f-4ec5471fabfd'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ad485cb4-d55c-4992-9a5f-4ec5471fabfd'',''f1673f79-a090-4929-afaa-b7fecbfd6e7c'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''671eda6c-2a2b-4d4c-a042-9322ca1f2859'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''671eda6c-2a2b-4d4c-a042-9322ca1f2859'',''922b008f-cd4a-4f2b-abf0-e5e341d51a45'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''2e02a91f-1d29-4568-b4ed-a0a62d64361e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''2e02a91f-1d29-4568-b4ed-a0a62d64361e'',''922b008f-cd4a-4f2b-abf0-e5e341d51a45'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''1deb502e-3b54-48ff-905d-364a41171821'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''1deb502e-3b54-48ff-905d-364a41171821'',''fc27df06-ec8c-4a79-b1d3-2ddce8907c3e'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''473be761-85b2-4678-ac4b-b6cc3757cd2a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''473be761-85b2-4678-ac4b-b6cc3757cd2a'',''fc27df06-ec8c-4a79-b1d3-2ddce8907c3e'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''38143a5d-cee1-4558-bfb2-81c66f0f5066'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''38143a5d-cee1-4558-bfb2-81c66f0f5066'',''e845d63e-2c3a-41ef-bf48-ab80559aa828'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''a86517a8-2f99-4000-926e-d6cee9365e58'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''a86517a8-2f99-4000-926e-d6cee9365e58'',''e845d63e-2c3a-41ef-bf48-ab80559aa828'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''db4b52f0-b231-4ba2-85e7-5fe61b265675'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''db4b52f0-b231-4ba2-85e7-5fe61b265675'',''2a178dd8-9ff5-4824-8a99-89d24f0a3b4b'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''94b7bb4b-ff4f-4fea-8cad-8889c3092587'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''94b7bb4b-ff4f-4fea-8cad-8889c3092587'',''2a178dd8-9ff5-4824-8a99-89d24f0a3b4b'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''5500d764-9d02-4aae-831f-25570fa59764'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''5500d764-9d02-4aae-831f-25570fa59764'',''834df072-a0e3-4c1b-b2a7-d0eecabaa9c2'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''9de5da9b-b28f-4304-85c1-574b4039bc7a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''9de5da9b-b28f-4304-85c1-574b4039bc7a'',''834df072-a0e3-4c1b-b2a7-d0eecabaa9c2'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''9d2980af-6530-45e3-bcb4-a67070395d30'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''9d2980af-6530-45e3-bcb4-a67070395d30'',''ebb255f3-3cc9-4bd2-ab9f-00aa610b6b6f'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''86f3379c-34d9-4c5d-b16b-cbe056ac075a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''86f3379c-34d9-4c5d-b16b-cbe056ac075a'',''ebb255f3-3cc9-4bd2-ab9f-00aa610b6b6f'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''814812e7-776a-4630-9ca0-54029d920a98'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''814812e7-776a-4630-9ca0-54029d920a98'',''7853af10-78ab-40f0-a717-9b198805970a'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''88728a60-2605-4fa8-9e9b-e769a77b625e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''88728a60-2605-4fa8-9e9b-e769a77b625e'',''7853af10-78ab-40f0-a717-9b198805970a'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''fd1ab722-b0fc-4732-8d50-3ce9901f5f78'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''fd1ab722-b0fc-4732-8d50-3ce9901f5f78'',''29c455c7-c354-4d4c-bc9e-608af47a80df'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''29b0779a-9e4c-43bc-8ad2-401869e44fca'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''29b0779a-9e4c-43bc-8ad2-401869e44fca'',''29c455c7-c354-4d4c-bc9e-608af47a80df'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''b1f3cfce-21f1-4ead-b0b0-080650cfbc56'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''b1f3cfce-21f1-4ead-b0b0-080650cfbc56'',''ea775924-7fb5-437e-82a1-deddef020942'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''d45d0901-c415-4931-ab6c-55d63c1204cd'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''d45d0901-c415-4931-ab6c-55d63c1204cd'',''ea775924-7fb5-437e-82a1-deddef020942'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''86011f4a-091b-4c51-a0de-08c85950d8b9'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''86011f4a-091b-4c51-a0de-08c85950d8b9'',''be46dc41-558e-4447-b49e-c0c5e01e3f5f'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''536cb6c5-3049-4e9e-bb57-5f3c7877f3ba'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''536cb6c5-3049-4e9e-bb57-5f3c7877f3ba'',''be46dc41-558e-4447-b49e-c0c5e01e3f5f'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''630207e9-4a62-4b1d-9878-ac526f1d27c7'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''630207e9-4a62-4b1d-9878-ac526f1d27c7'',''288be3d1-55b1-45fd-b73e-9d46f084913c'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''a33525ce-c266-4f23-a224-b93774f4a6e8'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''a33525ce-c266-4f23-a224-b93774f4a6e8'',''288be3d1-55b1-45fd-b73e-9d46f084913c'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''da1fa09c-bc62-4e36-9e4f-cba35f7d669a'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''da1fa09c-bc62-4e36-9e4f-cba35f7d669a'',''c17b5d35-8aef-4723-8101-9a8dd041661a'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''83d56e8d-925d-44fd-852f-e12f4cd5991e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''83d56e8d-925d-44fd-852f-e12f4cd5991e'',''c17b5d35-8aef-4723-8101-9a8dd041661a'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''66699f78-5cc1-4453-aebd-081eceede38c'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''66699f78-5cc1-4453-aebd-081eceede38c'',''4af0cc5c-b03d-4a0d-aecb-49ef260a1008'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''a4471851-758f-464f-b948-9d848be6deea'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''a4471851-758f-464f-b948-9d848be6deea'',''4af0cc5c-b03d-4a0d-aecb-49ef260a1008'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''594fd382-977c-43d9-95ab-b9c0f27aea48'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''594fd382-977c-43d9-95ab-b9c0f27aea48'',''8874a989-724c-40a5-9d79-2bc3a3f07d25'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''3637e8b0-d6ae-462b-98c1-df9394112461'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''3637e8b0-d6ae-462b-98c1-df9394112461'',''8874a989-724c-40a5-9d79-2bc3a3f07d25'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''a9c3554b-d547-4f0d-a19f-469aa645124f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''a9c3554b-d547-4f0d-a19f-469aa645124f'',''d075ba5e-8639-4a88-aa1f-0538a624c5fa'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''a2cca6e6-7db6-4674-92c2-61c756b7913c'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''a2cca6e6-7db6-4674-92c2-61c756b7913c'',''d075ba5e-8639-4a88-aa1f-0538a624c5fa'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''7a6d6eb9-395d-409f-9a08-0d9b7523572c'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''7a6d6eb9-395d-409f-9a08-0d9b7523572c'',''2a119ac7-3fad-4fe2-bda6-47a8fd1b2c97'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''33fb6e8d-a81b-4045-a9e9-a0fa1eb0a3a1'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''33fb6e8d-a81b-4045-a9e9-a0fa1eb0a3a1'',''2a119ac7-3fad-4fe2-bda6-47a8fd1b2c97'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''9ae4bab3-afc0-4ef9-b841-457207151604'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''9ae4bab3-afc0-4ef9-b841-457207151604'',''f3eb11e5-bd99-402c-8d2b-0521faf5c823'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''7fbe8549-cd3d-467e-b4b5-b5a4024a91ae'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''7fbe8549-cd3d-467e-b4b5-b5a4024a91ae'',''f3eb11e5-bd99-402c-8d2b-0521faf5c823'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''d62ef94c-9208-4f79-a879-2b67cc44a1a8'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''d62ef94c-9208-4f79-a879-2b67cc44a1a8'',''e3106354-aca9-40e7-9189-2e17e19ea72e'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''df39bab1-2605-4551-98fa-cb98f1a8340f'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''df39bab1-2605-4551-98fa-cb98f1a8340f'',''e3106354-aca9-40e7-9189-2e17e19ea72e'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''9779eb5a-9d7e-4c87-86de-29b0aa129400'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''9779eb5a-9d7e-4c87-86de-29b0aa129400'',''d6033c6e-e2f5-4b38-bee1-24240d0c3392'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''b9fb6b0c-e744-4b40-8e8d-93da89361f62'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''b9fb6b0c-e744-4b40-8e8d-93da89361f62'',''d6033c6e-e2f5-4b38-bee1-24240d0c3392'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''399e6928-f982-477d-b7ea-c69da45d54a6'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''399e6928-f982-477d-b7ea-c69da45d54a6'',''afab9ecd-4d3e-4caa-b016-f36cc8d95fe5'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''763fcc54-be3e-499b-acaa-e91d47c1ffb6'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''763fcc54-be3e-499b-acaa-e91d47c1ffb6'',''afab9ecd-4d3e-4caa-b016-f36cc8d95fe5'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''5fa2787a-efda-433d-96ac-8007955e5cd0'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''5fa2787a-efda-433d-96ac-8007955e5cd0'',''f85e7c2a-bb57-4f67-a4a0-2c4a641e816e'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''7b1fd989-492f-4dec-9fca-896b21440dee'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''7b1fd989-492f-4dec-9fca-896b21440dee'',''f85e7c2a-bb57-4f67-a4a0-2c4a641e816e'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''5eaf101f-105e-445e-b7f5-86b6af5c85e9'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''5eaf101f-105e-445e-b7f5-86b6af5c85e9'',''ad7b0d53-7af0-4284-a319-0c3d06afb4aa'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''85ffab14-466e-4a40-af90-e10c2bb72069'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''85ffab14-466e-4a40-af90-e10c2bb72069'',''ad7b0d53-7af0-4284-a319-0c3d06afb4aa'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''e849b0dd-3187-4187-95a2-5fdd5975649b'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''e849b0dd-3187-4187-95a2-5fdd5975649b'',''09c605df-dbc1-4582-9b1d-bdb0f52b5691'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''23dacea2-de04-40bc-b93c-766cbf0bc6f1'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''23dacea2-de04-40bc-b93c-766cbf0bc6f1'',''09c605df-dbc1-4582-9b1d-bdb0f52b5691'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''848d33e4-9df2-4aae-b09c-2136571fdb3e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''848d33e4-9df2-4aae-b09c-2136571fdb3e'',''216eeaf8-5fc7-4faf-9978-36e4504d3754'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''afc1a19c-5f43-4786-848f-eba2d20d87e3'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''afc1a19c-5f43-4786-848f-eba2d20d87e3'',''216eeaf8-5fc7-4faf-9978-36e4504d3754'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''396f5f5d-3e3c-486f-b243-6b29cb21cdc7'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''396f5f5d-3e3c-486f-b243-6b29cb21cdc7'',''1a99fde1-c57b-4f28-b093-d9f883ed9fc0'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''2d5f4484-93d4-4e6e-956d-7a5a06381f57'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''2d5f4484-93d4-4e6e-956d-7a5a06381f57'',''1a99fde1-c57b-4f28-b093-d9f883ed9fc0'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ef87b02f-1851-4be7-97dd-6a52b3905275'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ef87b02f-1851-4be7-97dd-6a52b3905275'',''e577a60c-edf2-45a8-8628-2fcd348f71c0'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''bb889e3c-896e-4c02-92e3-feaecc426bf8'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''bb889e3c-896e-4c02-92e3-feaecc426bf8'',''e577a60c-edf2-45a8-8628-2fcd348f71c0'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''753425bc-e632-450a-a04f-7c3198902c2e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''753425bc-e632-450a-a04f-7c3198902c2e'',''a0d3af81-f9d8-4b5c-8a3d-ea69402f4d47'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''386931dc-3ef7-419d-bb5e-d8a977adb97e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''386931dc-3ef7-419d-bb5e-d8a977adb97e'',''a0d3af81-f9d8-4b5c-8a3d-ea69402f4d47'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''ffd617ca-c72e-4dc5-b2b0-6dd513120230'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''ffd617ca-c72e-4dc5-b2b0-6dd513120230'',''76032ec6-9e6b-4fc5-9c51-9ec467e63d54'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''f940ebd3-95a4-41f3-9be7-e689c7cee122'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''f940ebd3-95a4-41f3-9be7-e689c7cee122'',''76032ec6-9e6b-4fc5-9c51-9ec467e63d54'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''c809f62d-ff6c-4746-a359-3d714fa4e7ba'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''c809f62d-ff6c-4746-a359-3d714fa4e7ba'',''da90319a-487c-4ef8-999b-b0d19ed2a72e'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''583bcacf-755d-4aeb-928a-876b719c54ac'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''583bcacf-755d-4aeb-928a-876b719c54ac'',''da90319a-487c-4ef8-999b-b0d19ed2a72e'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''d4207698-d429-42ec-9b63-06716268bcc2'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''d4207698-d429-42ec-9b63-06716268bcc2'',''a85cdae9-a7dc-47f2-971e-b370b5a55fb1'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''2fa1ebfe-b63b-4066-b47a-56baeac2d35d'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''2fa1ebfe-b63b-4066-b47a-56baeac2d35d'',''a85cdae9-a7dc-47f2-971e-b370b5a55fb1'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''693f251f-f05a-450b-bbc1-73dfb55f851e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''693f251f-f05a-450b-bbc1-73dfb55f851e'',''86f2611e-301c-4e28-b8b6-cb6008cfc7b0'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''b1f48dd6-7562-4bd1-9966-f7676930d674'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''b1f48dd6-7562-4bd1-9966-f7676930d674'',''86f2611e-301c-4e28-b8b6-cb6008cfc7b0'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''f1ed50b4-4bc0-40b0-bb99-3db617c03c4e'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''f1ed50b4-4bc0-40b0-bb99-3db617c03c4e'',''d466f715-ab0b-462f-b276-3705d84e5263'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''cbefbf36-8676-43a9-813b-63dd178bc826'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''cbefbf36-8676-43a9-813b-63dd178bc826'',''d466f715-ab0b-462f-b276-3705d84e5263'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''5b4f3283-38e5-4eae-a154-11e5bc7638cd'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''5b4f3283-38e5-4eae-a154-11e5bc7638cd'',''0d58697c-0035-43ff-8705-ab4aaf4e6140'',''4e173916-e8d7-4640-8ef1-965b74371124'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''d5c53165-a33a-4b87-b86b-3ffc0a67850c'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''d5c53165-a33a-4b87-b86b-3ffc0a67850c'',''0d58697c-0035-43ff-8705-ab4aaf4e6140'',''581597d8-dde6-4779-9ef0-37d29d0a67a2'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''57693e62-6629-4415-8aaa-38404d98e0a4'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''57693e62-6629-4415-8aaa-38404d98e0a4'',''fad74770-776f-44a8-bf0e-beb6a070218e'',''cee3873e-c7ae-48d5-a4b7-d4ffd293fe14'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute WHERE GUID_TokenAttribute=''bbba0a9c-5b4d-474f-ad51-454d446bebb1'' )=0
	INSERT INTO semtbl_Token_Attribute VALUES(''bbba0a9c-5b4d-474f-ad51-454d446bebb1'',''3bad019e-0b9b-480c-8704-1cff0078aad0'',''cee3873e-c7ae-48d5-a4b7-d4ffd293fe14'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''dcdff000-be51-47b7-9af7-27a6787d8511'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''dcdff000-be51-47b7-9af7-27a6787d8511'',1078,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''1eba7ba8-8f04-4e97-b79d-9bd59bf71c36'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''1eba7ba8-8f04-4e97-b79d-9bd59bf71c36'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''b0996793-8f77-4c7e-8ebf-169f9ed8ca61'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''b0996793-8f77-4c7e-8ebf-169f9ed8ca61'',1052,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''11d1c68b-579f-4708-bade-929cdd5a11be'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''11d1c68b-579f-4708-bade-929cdd5a11be'',1250,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''3c35979f-ef0d-44f7-abfc-047de2e27735'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''3c35979f-ef0d-44f7-abfc-047de2e27735'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''83a3931e-7b3e-4a9d-88ba-92852845590f'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''83a3931e-7b3e-4a9d-88ba-92852845590f'',5121,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''53b0d55a-43da-4625-9849-4506d2a3c4a4'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''53b0d55a-43da-4625-9849-4506d2a3c4a4'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''f54f0f32-0e7b-406c-9c9e-5ac9fda5c279'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''f54f0f32-0e7b-406c-9c9e-5ac9fda5c279'',15361,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''14c72f86-6226-43b7-bade-05f1908e944d'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''14c72f86-6226-43b7-bade-05f1908e944d'',3073,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''c7377283-d869-4f59-bff7-40350fe3ad90'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''c7377283-d869-4f59-bff7-40350fe3ad90'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''fbcce51b-84a6-4f99-9b95-7fab2ddf3d04'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''fbcce51b-84a6-4f99-9b95-7fab2ddf3d04'',2049,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''7eb24d1f-e772-48e2-ba7e-c008305395e9'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''7eb24d1f-e772-48e2-ba7e-c008305395e9'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''9be8b2df-9af9-47c9-9890-698261f1b663'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''9be8b2df-9af9-47c9-9890-698261f1b663'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''cec59da6-0dfb-47ec-8f8f-fc32b900047c'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''cec59da6-0dfb-47ec-8f8f-fc32b900047c'',11265,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''71a8de47-0f18-499b-a4b7-088c50efbba1'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''71a8de47-0f18-499b-a4b7-088c50efbba1'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''1eae3f08-a1eb-4d73-b908-c5b9b783859c'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''1eae3f08-a1eb-4d73-b908-c5b9b783859c'',13313,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''386f0381-ae6f-4272-af8a-bd091479688f'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''386f0381-ae6f-4272-af8a-bd091479688f'',12289,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''0bcd3f00-119e-4caa-a7fd-dcb7f62f9956'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''0bcd3f00-119e-4caa-a7fd-dcb7f62f9956'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''378c7c7e-2969-4c1e-8e63-1c004fbcf6bb'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''378c7c7e-2969-4c1e-8e63-1c004fbcf6bb'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''5162eae9-d6e0-4cd3-9c35-7b0f1686ba7a'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''5162eae9-d6e0-4cd3-9c35-7b0f1686ba7a'',4097,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''c3c1b431-ebb2-4764-ac8b-1c9e44434a45'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''c3c1b431-ebb2-4764-ac8b-1c9e44434a45'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ca1212a1-1c27-45a2-8f8a-c285a00ec888'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ca1212a1-1c27-45a2-8f8a-c285a00ec888'',6145,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''98dbf914-2ae5-428e-8017-18846ad17542'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''98dbf914-2ae5-428e-8017-18846ad17542'',8193,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''831d8f70-1cc7-49b9-b213-63d23a546e34'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''831d8f70-1cc7-49b9-b213-63d23a546e34'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''6018f4aa-e9d5-4e40-a264-11b222f03067'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''6018f4aa-e9d5-4e40-a264-11b222f03067'',16385,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''81b5dc51-e845-4c05-8d1c-667d8ff7ed50'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''81b5dc51-e845-4c05-8d1c-667d8ff7ed50'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''df8b6aa7-f639-4b72-a600-00d3eae26575'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''df8b6aa7-f639-4b72-a600-00d3eae26575'',1025,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''c2ca6a82-969a-40bf-a266-45eb961d32aa'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''c2ca6a82-969a-40bf-a266-45eb961d32aa'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''83775dc6-128d-4d22-8d55-6149246f7356'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''83775dc6-128d-4d22-8d55-6149246f7356'',10241,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''8e24a1f2-c10c-4a07-84f9-f2e6c76b84f4'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''8e24a1f2-c10c-4a07-84f9-f2e6c76b84f4'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ef9362b3-fa86-4dab-a2f3-3562239129bf'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ef9362b3-fa86-4dab-a2f3-3562239129bf'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''e6a85f24-87ae-4a92-92c6-fa78ed78419f'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''e6a85f24-87ae-4a92-92c6-fa78ed78419f'',7169,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''4ad7c14b-dae7-4cac-99be-25de06296928'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''4ad7c14b-dae7-4cac-99be-25de06296928'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''8f19c3f9-7aaf-4fb4-a9b2-cef1fb7b31e3'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''8f19c3f9-7aaf-4fb4-a9b2-cef1fb7b31e3'',14337,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''c4ec2a85-5f04-4517-8778-30b76b8acc94'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''c4ec2a85-5f04-4517-8778-30b76b8acc94'',9217,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''bcdcd63a-efdb-42b9-a3ff-e3f52a345387'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''bcdcd63a-efdb-42b9-a3ff-e3f52a345387'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ecbeb237-24cb-474d-aa06-0393f9427582'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ecbeb237-24cb-474d-aa06-0393f9427582'',0,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''83c2bf3a-362a-4a24-90db-2303576c0603'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''83c2bf3a-362a-4a24-90db-2303576c0603'',1067,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''2a18a0b6-9801-48a5-8744-1138bc573f99'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''2a18a0b6-9801-48a5-8744-1138bc573f99'',1251,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''03b62c88-70ca-40f0-a09f-c34841fe642d'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''03b62c88-70ca-40f0-a09f-c34841fe642d'',2092,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''7575fcec-34b3-41f0-a228-13c91cd72cf5'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''7575fcec-34b3-41f0-a228-13c91cd72cf5'',1068,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''d17cffd0-da2d-410b-976c-442bfd231083'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''d17cffd0-da2d-410b-976c-442bfd231083'',1254,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ac02d238-54ac-4b95-b957-5e2a10fa1369'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ac02d238-54ac-4b95-b957-5e2a10fa1369'',1069,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''64004e4d-6736-4899-8de8-a96b12b347c2'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''64004e4d-6736-4899-8de8-a96b12b347c2'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''eb8068fd-da3e-4893-8d7f-f7889356d2fb'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''eb8068fd-da3e-4893-8d7f-f7889356d2fb'',1251,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''d94a0426-e965-4cd8-ad0b-fc9a8074968a'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''d94a0426-e965-4cd8-ad0b-fc9a8074968a'',1059,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''a4de92a8-6194-4b8d-a7b8-3000767ed895'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''a4de92a8-6194-4b8d-a7b8-3000767ed895'',1251,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''144414ad-7c9d-48f3-8746-e0d360bbf2e1'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''144414ad-7c9d-48f3-8746-e0d360bbf2e1'',1026,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''bf97ffd7-fe3f-4587-a29b-2c3dcbbe54d3'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''bf97ffd7-fe3f-4587-a29b-2c3dcbbe54d3'',1027,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''4d716fca-aeec-4870-9b77-7f2d54501185'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''4d716fca-aeec-4870-9b77-7f2d54501185'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''7375de25-cf9d-4067-a196-91e81cca3278'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''7375de25-cf9d-4067-a196-91e81cca3278'',950,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''84470114-6254-4fab-8885-f5a09bc781b3'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''84470114-6254-4fab-8885-f5a09bc781b3'',3076,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''e1b8072b-58bf-446d-a621-2b6138bfdb2e'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''e1b8072b-58bf-446d-a621-2b6138bfdb2e'',950,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''60903e4f-bb4d-4d9e-833f-558e5deda75a'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''60903e4f-bb4d-4d9e-833f-558e5deda75a'',5124,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''deca2ae2-c0de-495f-bd0f-543d79ff0019'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''deca2ae2-c0de-495f-bd0f-543d79ff0019'',936,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''7896daf6-30fe-4453-8a2c-fbdab5598dc5'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''7896daf6-30fe-4453-8a2c-fbdab5598dc5'',2052,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''c2a99db5-a925-4aaa-a8ee-5fa5fea0b770'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''c2a99db5-a925-4aaa-a8ee-5fa5fea0b770'',936,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ef974980-9bd2-4330-a6a8-8a386240d816'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ef974980-9bd2-4330-a6a8-8a386240d816'',4100,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ea306c2f-0db7-4575-ae80-3ff7eff9313f'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ea306c2f-0db7-4575-ae80-3ff7eff9313f'',1028,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''f79a6a4a-239a-4197-90a4-6859f2636ad9'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''f79a6a4a-239a-4197-90a4-6859f2636ad9'',950,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''c6741539-a335-4752-8133-a25f903aa293'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''c6741539-a335-4752-8133-a25f903aa293'',1250,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''a93942f3-0c61-4881-a24d-a2641833dc1c'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''a93942f3-0c61-4881-a24d-a2641833dc1c'',1050,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''2d7824ca-e800-4dc3-b2d7-abea1605887d'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''2d7824ca-e800-4dc3-b2d7-abea1605887d'',1250,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''59d5841b-ecd3-43ac-b22b-b7d4b7887cac'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''59d5841b-ecd3-43ac-b22b-b7d4b7887cac'',1029,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''6ee402fb-1371-446b-806a-940bb0e15f4b'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''6ee402fb-1371-446b-806a-940bb0e15f4b'',1030,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''9f81bafe-acb8-43bf-a17f-c63bdcccc0e8'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''9f81bafe-acb8-43bf-a17f-c63bdcccc0e8'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''29f7bd42-cbea-4933-bec0-5764f3fe3cf2'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''29f7bd42-cbea-4933-bec0-5764f3fe3cf2'',0,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''089c76d4-4268-43ab-9d75-ba0e033095f7'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''089c76d4-4268-43ab-9d75-ba0e033095f7'',1125,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''679b9323-b5c6-440b-ba4c-9988b3ae4fc4'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''679b9323-b5c6-440b-ba4c-9988b3ae4fc4'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''266f922b-e2e8-4b3e-b4d9-fcfbdeb257a6'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''266f922b-e2e8-4b3e-b4d9-fcfbdeb257a6'',2067,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''0f9a9667-ec96-494b-a4e4-81a7d7acb6ac'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''0f9a9667-ec96-494b-a4e4-81a7d7acb6ac'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''5f3189e6-649e-42fc-b856-b60e22ffac2f'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''5f3189e6-649e-42fc-b856-b60e22ffac2f'',1043,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''86e689f4-5c4f-4f7f-8281-22aa30df1702'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''86e689f4-5c4f-4f7f-8281-22aa30df1702'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''66a48aa6-744a-4ec9-9409-3930ed79dc25'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''66a48aa6-744a-4ec9-9409-3930ed79dc25'',3081,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''2bb78495-92d1-4d5e-9d2b-2765d7c7e3bd'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''2bb78495-92d1-4d5e-9d2b-2765d7c7e3bd'',10249,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''b00c6b4c-5706-4d61-bb2a-beedfb616b95'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''b00c6b4c-5706-4d61-bb2a-beedfb616b95'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''01b89986-7976-48d9-a2f2-3816c418a34b'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''01b89986-7976-48d9-a2f2-3816c418a34b'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''90472e62-5fe4-4519-b3b5-54212b69d4bd'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''90472e62-5fe4-4519-b3b5-54212b69d4bd'',4105,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''674c2e6e-12f9-4ca3-a358-7dd902f71281'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''674c2e6e-12f9-4ca3-a358-7dd902f71281'',9225,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''53718060-46ef-4095-887a-fec5645710c1'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''53718060-46ef-4095-887a-fec5645710c1'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''21a504b2-fbc4-4b15-bc51-149b0099063a'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''21a504b2-fbc4-4b15-bc51-149b0099063a'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''19641462-9172-44d1-af06-7d2e10bdbdbb'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''19641462-9172-44d1-af06-7d2e10bdbdbb'',6153,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''cbc73fab-57c7-49f4-8e35-cd942a899cc7'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''cbc73fab-57c7-49f4-8e35-cd942a899cc7'',8201,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''7db92acf-dbd4-4806-b27c-df30a374908b'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''7db92acf-dbd4-4806-b27c-df30a374908b'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''5298be9c-47a5-44d2-8c24-c811e5cc0e0e'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''5298be9c-47a5-44d2-8c24-c811e5cc0e0e'',5129,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''f2fdfb74-69f2-4d3a-89b2-ee994c099f05'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''f2fdfb74-69f2-4d3a-89b2-ee994c099f05'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''5de8f524-eb15-441c-b488-f49a3906f9d8'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''5de8f524-eb15-441c-b488-f49a3906f9d8'',13321,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''fb4fac55-6142-4034-94e1-f9281f0a54e2'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''fb4fac55-6142-4034-94e1-f9281f0a54e2'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''46794ead-2009-498a-8b61-47153c8085e9'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''46794ead-2009-498a-8b61-47153c8085e9'',7177,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''53f2aa43-056c-4658-ac9e-4f133d85e212'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''53f2aa43-056c-4658-ac9e-4f133d85e212'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''c3682d33-7f87-487d-8e44-8af9bb041a23'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''c3682d33-7f87-487d-8e44-8af9bb041a23'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ed34d46e-500d-42d5-aa4d-a9fa7bec5dda'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ed34d46e-500d-42d5-aa4d-a9fa7bec5dda'',11273,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''5ff74470-9b7b-4512-a276-92493a9fff0a'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''5ff74470-9b7b-4512-a276-92493a9fff0a'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''829aa3fa-d192-42cf-94be-96a0e2460898'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''829aa3fa-d192-42cf-94be-96a0e2460898'',2057,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''57e6d7d0-0c8c-4d5c-b5eb-b749182e6ca5'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''57e6d7d0-0c8c-4d5c-b5eb-b749182e6ca5'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''04f1d2e9-3138-4ef0-8de1-e8b4f23e53c4'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''04f1d2e9-3138-4ef0-8de1-e8b4f23e53c4'',1033,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''d2494060-c251-4171-97d3-2e75b5bc6eae'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''d2494060-c251-4171-97d3-2e75b5bc6eae'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''e8cea458-1ce8-4ec5-baef-fccc797189ff'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''e8cea458-1ce8-4ec5-baef-fccc797189ff'',12297,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''8ea96efc-1426-445c-a84d-95a3b3230952'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''8ea96efc-1426-445c-a84d-95a3b3230952'',1257,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''a461db06-051f-4ec4-8d9c-aa2dc5876b15'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''a461db06-051f-4ec4-8d9c-aa2dc5876b15'',1061,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''4115d43e-23ed-494e-9358-bb5aa4433020'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''4115d43e-23ed-494e-9358-bb5aa4433020'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''0b2d84d1-8599-441a-bd05-f24880d0396e'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''0b2d84d1-8599-441a-bd05-f24880d0396e'',1080,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''71b0898c-0e26-42e4-8a68-4a9da99396c5'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''71b0898c-0e26-42e4-8a68-4a9da99396c5'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''98c2921a-4290-4137-a1e5-7141dce87842'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''98c2921a-4290-4137-a1e5-7141dce87842'',1065,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''b14a72a7-a11f-49d0-832c-77fb39824ad5'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''b14a72a7-a11f-49d0-832c-77fb39824ad5'',1035,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ed6f17b3-ce43-494e-a46b-da98bcae3d39'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ed6f17b3-ce43-494e-a46b-da98bcae3d39'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ccf99630-9a77-47b0-94bb-1e472646fd39'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ccf99630-9a77-47b0-94bb-1e472646fd39'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''e8af9247-58af-41fb-a971-da43bcec778a'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''e8af9247-58af-41fb-a971-da43bcec778a'',2060,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''2c7c6d5d-94b7-478a-a723-19df8f0e260e'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''2c7c6d5d-94b7-478a-a723-19df8f0e260e'',3084,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ffe2640a-2bdb-4172-9a64-e7714372d850'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ffe2640a-2bdb-4172-9a64-e7714372d850'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''c5e80de3-fd7a-498d-bb30-f7f44cc2712b'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''c5e80de3-fd7a-498d-bb30-f7f44cc2712b'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''19732f72-55fa-4d0c-baef-f818ae8b8062'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''19732f72-55fa-4d0c-baef-f818ae8b8062'',1036,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''d626e82d-3be7-4456-841b-7ac37b518794'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''d626e82d-3be7-4456-841b-7ac37b518794'',5132,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''53deac9e-f7a3-4f85-bde8-ef540a00c117'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''53deac9e-f7a3-4f85-bde8-ef540a00c117'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''b743204c-657a-4405-be07-3c024f27e0f4'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''b743204c-657a-4405-be07-3c024f27e0f4'',6156,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''671f7c1e-6bff-41cc-a206-533a76325eba'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''671f7c1e-6bff-41cc-a206-533a76325eba'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''5b29b20f-cd20-4885-b912-a10935addd61'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''5b29b20f-cd20-4885-b912-a10935addd61'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''8cb78f05-bf46-46f8-99b0-eeecf30f51dc'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''8cb78f05-bf46-46f8-99b0-eeecf30f51dc'',4108,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''b876562f-8192-4493-89c6-217f39f5c22d'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''b876562f-8192-4493-89c6-217f39f5c22d'',1071,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''539a3fbf-ae99-4081-8d57-851416d6cbb5'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''539a3fbf-ae99-4081-8d57-851416d6cbb5'',1251,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''bd2165fc-e47c-4f6c-991d-78fab0fd03ad'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''bd2165fc-e47c-4f6c-991d-78fab0fd03ad'',1110,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''8b6cd1fa-7322-4dd4-b6cd-fe96253ded61'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''8b6cd1fa-7322-4dd4-b6cd-fe96253ded61'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''99daedd4-53db-4d31-9dff-2cc60a6948fa'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''99daedd4-53db-4d31-9dff-2cc60a6948fa'',0,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ba070723-4403-4fcc-9597-9f7bb26bc98b'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ba070723-4403-4fcc-9597-9f7bb26bc98b'',1079,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''dd58bd84-5b65-4520-b0e7-84d67b22628c'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''dd58bd84-5b65-4520-b0e7-84d67b22628c'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''d38aa2ed-ba46-439d-b39c-a0ebf25771a7'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''d38aa2ed-ba46-439d-b39c-a0ebf25771a7'',3079,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''8e31154b-c54e-4350-81f6-0b113cdb302b'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''8e31154b-c54e-4350-81f6-0b113cdb302b'',1031,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''e9d487e9-d7cc-401b-b032-9f0d8a9121ab'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''e9d487e9-d7cc-401b-b032-9f0d8a9121ab'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''0e00ded7-6586-4654-a876-649b65724d85'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''0e00ded7-6586-4654-a876-649b65724d85'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''e110aa17-5622-42c5-b949-d365b1b9d6bb'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''e110aa17-5622-42c5-b949-d365b1b9d6bb'',5127,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''3492099a-9927-41b1-97ea-0a6619955a6f'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''3492099a-9927-41b1-97ea-0a6619955a6f'',4103,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ebd3a062-8201-4fb2-ac67-de2e6e660d7a'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ebd3a062-8201-4fb2-ac67-de2e6e660d7a'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''e7a94810-826a-4971-b88a-4942ae6ce1de'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''e7a94810-826a-4971-b88a-4942ae6ce1de'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''e2175206-076a-45e7-852f-ef2724b736b8'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''e2175206-076a-45e7-852f-ef2724b736b8'',2055,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''b0d8dd2b-36a8-4134-868f-7ef4ab3bce19'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''b0d8dd2b-36a8-4134-868f-7ef4ab3bce19'',1253,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''c77e6036-91f0-4ab1-89a4-ab6c6e5025e4'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''c77e6036-91f0-4ab1-89a4-ab6c6e5025e4'',1032,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''f1a29c7a-8155-4427-a09d-9a75cac52498'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''f1a29c7a-8155-4427-a09d-9a75cac52498'',1095,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''35ce2355-00ab-4697-9b38-f0602b02a8aa'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''35ce2355-00ab-4697-9b38-f0602b02a8aa'',0,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''5b9d880d-4e47-4de1-8027-1ebbc5cf99ed'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''5b9d880d-4e47-4de1-8027-1ebbc5cf99ed'',1037,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''b4766e07-4f85-44ee-b898-496ef7e9f91f'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''b4766e07-4f85-44ee-b898-496ef7e9f91f'',1255,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''b8f47c9b-0565-4d34-833f-07e0371d97e6'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''b8f47c9b-0565-4d34-833f-07e0371d97e6'',0,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''7dc84ec6-bda2-4d4b-83e0-7f1d1ffa6a83'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''7dc84ec6-bda2-4d4b-83e0-7f1d1ffa6a83'',1081,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''b77569f2-77a0-4d07-bafc-ae4651f5c244'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''b77569f2-77a0-4d07-bafc-ae4651f5c244'',1038,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''f7cc55cd-ec1b-488f-a374-c179e305be9e'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''f7cc55cd-ec1b-488f-a374-c179e305be9e'',1250,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''db137b63-a662-44b8-94ce-51c079999c3f'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''db137b63-a662-44b8-94ce-51c079999c3f'',1039,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''4aa5bd56-6986-40f1-81ad-71c2476b9128'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''4aa5bd56-6986-40f1-81ad-71c2476b9128'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''81682b59-2aa0-446d-abf6-089258c5ef99'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''81682b59-2aa0-446d-abf6-089258c5ef99'',1057,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''f434c5be-fb7e-4c77-82ef-99c89620ebed'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''f434c5be-fb7e-4c77-82ef-99c89620ebed'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''fdae0590-ce65-4fbd-910b-8e6c0181d2e0'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''fdae0590-ce65-4fbd-910b-8e6c0181d2e0'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''8ef9bdd2-ea71-456f-97bc-ff1422d84d54'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''8ef9bdd2-ea71-456f-97bc-ff1422d84d54'',1040,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''42371320-7c4a-4db3-84c3-3120085295bf'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''42371320-7c4a-4db3-84c3-3120085295bf'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''8931cee5-b3d7-40ea-950b-8e242b7e06cf'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''8931cee5-b3d7-40ea-950b-8e242b7e06cf'',2064,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''f7f2bbd2-3ef9-4fca-8143-a5502282cc3f'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''f7f2bbd2-3ef9-4fca-8143-a5502282cc3f'',932,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''1fbabf26-f6e4-438e-99e6-f01785188291'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''1fbabf26-f6e4-438e-99e6-f01785188291'',1041,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''3b73181a-bf4c-46a2-9bc7-1ba1a2963617'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''3b73181a-bf4c-46a2-9bc7-1ba1a2963617'',0,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''6debca91-7219-4c15-b958-59a7fae2c728'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''6debca91-7219-4c15-b958-59a7fae2c728'',1099,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''9eee34b2-4955-40a3-9edf-9b70d65b9878'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''9eee34b2-4955-40a3-9edf-9b70d65b9878'',1251,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''d88d56b5-cddf-4e9c-89fd-cf5c408b0256'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''d88d56b5-cddf-4e9c-89fd-cf5c408b0256'',1087,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''96c6d13b-1633-40d3-8a2c-a551e224960d'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''96c6d13b-1633-40d3-8a2c-a551e224960d'',1111,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''39b93e74-9c9a-44ec-975a-c8974c10d9dc'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''39b93e74-9c9a-44ec-975a-c8974c10d9dc'',0,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''1293e051-dbf8-4727-9768-767e5546105c'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''1293e051-dbf8-4727-9768-767e5546105c'',949,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''3c6848f5-5dac-4b18-b798-e9887ceac16c'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''3c6848f5-5dac-4b18-b798-e9887ceac16c'',1042,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''854f1921-a471-4923-bfb3-55a3fb55084f'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''854f1921-a471-4923-bfb3-55a3fb55084f'',1088,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''798f76a8-8550-432d-9c04-ece755e2f6ed'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''798f76a8-8550-432d-9c04-ece755e2f6ed'',1251,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''7d23a9b7-b9fa-497f-b60d-0cf70433b891'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''7d23a9b7-b9fa-497f-b60d-0cf70433b891'',1257,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''eb44ccc4-5958-4eaf-a0ad-b2363bce60d4'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''eb44ccc4-5958-4eaf-a0ad-b2363bce60d4'',1062,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''70d59e70-25df-4906-bc8b-6ab6cbc9237d'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''70d59e70-25df-4906-bc8b-6ab6cbc9237d'',1257,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''1b087aa9-ae91-4383-98b8-89437766afdc'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''1b087aa9-ae91-4383-98b8-89437766afdc'',1063,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''bf19078e-e857-4672-903d-57765529673f'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''bf19078e-e857-4672-903d-57765529673f'',2110,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''6b33be20-33ba-47f6-b430-7d90e651ff13'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''6b33be20-33ba-47f6-b430-7d90e651ff13'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''3f31079f-30be-49fd-9b8d-343fe480a648'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''3f31079f-30be-49fd-9b8d-343fe480a648'',1086,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''8b7b1328-f6c5-4055-b148-a22b12ae8740'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''8b7b1328-f6c5-4055-b148-a22b12ae8740'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''81d2a5a7-e96a-4129-bef1-827828e63acf'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''81d2a5a7-e96a-4129-bef1-827828e63acf'',0,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ccfa9465-4cef-4984-8260-85136b68bb74'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ccfa9465-4cef-4984-8260-85136b68bb74'',1102,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''e715ebe3-236a-4854-b4fe-3879bad7c48d'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''e715ebe3-236a-4854-b4fe-3879bad7c48d'',1104,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''3ce7cbf9-e7c7-421a-aa45-55d4c2b8089a'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''3ce7cbf9-e7c7-421a-aa45-55d4c2b8089a'',1251,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ed271007-3d71-483b-b598-86bce7d80dca'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ed271007-3d71-483b-b598-86bce7d80dca'',1044,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ceffa477-e8a9-4587-ad85-9d60f0e2bfbe'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ceffa477-e8a9-4587-ad85-9d60f0e2bfbe'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''164a220e-5133-459c-a65c-16bc17b242d0'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''164a220e-5133-459c-a65c-16bc17b242d0'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''e533f717-0180-4db0-a869-9978ad5f8511'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''e533f717-0180-4db0-a869-9978ad5f8511'',2068,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''46fcb4b4-26d3-45a4-9fdb-3e3052a84a1e'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''46fcb4b4-26d3-45a4-9fdb-3e3052a84a1e'',1250,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''03b9258d-22aa-4ce7-b64b-633a60a7ba21'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''03b9258d-22aa-4ce7-b64b-633a60a7ba21'',1045,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''4cfd6494-911a-4146-ba53-3807fca8c5d5'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''4cfd6494-911a-4146-ba53-3807fca8c5d5'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''39e2b610-45c7-4033-ac92-c7401cc547d2'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''39e2b610-45c7-4033-ac92-c7401cc547d2'',1046,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ffede54d-14c9-4807-a75d-963f68ed4d13'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ffede54d-14c9-4807-a75d-963f68ed4d13'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''46cd5909-d6d5-4175-953b-a3e6ca5c5bd3'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''46cd5909-d6d5-4175-953b-a3e6ca5c5bd3'',2070,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''7d252c64-ec27-4a7c-9ba0-62376958ef89'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''7d252c64-ec27-4a7c-9ba0-62376958ef89'',1094,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''91cef11c-0a79-41a8-9ee8-bb89a63f699a'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''91cef11c-0a79-41a8-9ee8-bb89a63f699a'',0,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''95359cbb-7eed-4364-a915-385426c49d59'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''95359cbb-7eed-4364-a915-385426c49d59'',1250,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''e7acb3fb-5775-4646-b618-c9bdaf36dbba'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''e7acb3fb-5775-4646-b618-c9bdaf36dbba'',1048,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''395a25c4-7c9e-443b-bf9b-89ff22047723'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''395a25c4-7c9e-443b-bf9b-89ff22047723'',1049,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''c9c42b26-a369-4e69-9c07-a3c6303f306f'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''c9c42b26-a369-4e69-9c07-a3c6303f306f'',1251,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''bdf63994-2fc8-402f-9b58-ba2920bb07be'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''bdf63994-2fc8-402f-9b58-ba2920bb07be'',0,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''c496006f-682a-45a3-b3a3-d04091449f6b'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''c496006f-682a-45a3-b3a3-d04091449f6b'',1103,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''a3d64e4a-74a9-4c8f-9874-1b560034242c'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''a3d64e4a-74a9-4c8f-9874-1b560034242c'',3098,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''a110b8a6-2809-4bec-bb2d-77d33bb40d7a'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''a110b8a6-2809-4bec-bb2d-77d33bb40d7a'',1251,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''3ca1ffb8-3af8-40c3-b9af-5d515348bc8b'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''3ca1ffb8-3af8-40c3-b9af-5d515348bc8b'',1250,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''69200ca9-5d05-4360-a072-afdeb8986422'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''69200ca9-5d05-4360-a072-afdeb8986422'',2074,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''7eac02f4-ed48-4b68-8982-3ba095d87910'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''7eac02f4-ed48-4b68-8982-3ba095d87910'',1051,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''48fd3cd7-2082-491b-b15d-e0de41f56950'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''48fd3cd7-2082-491b-b15d-e0de41f56950'',1250,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''4f84c7e0-5d06-4a2b-acbf-eba913e890e9'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''4f84c7e0-5d06-4a2b-acbf-eba913e890e9'',1250,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''5ab877e9-c4b0-4593-a513-fbdf9f173e62'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''5ab877e9-c4b0-4593-a513-fbdf9f173e62'',1060,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''9c3fa2ef-9504-47af-8632-334b16869c3e'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''9c3fa2ef-9504-47af-8632-334b16869c3e'',11274,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ad485cb4-d55c-4992-9a5f-4ec5471fabfd'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ad485cb4-d55c-4992-9a5f-4ec5471fabfd'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''671eda6c-2a2b-4d4c-a042-9322ca1f2859'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''671eda6c-2a2b-4d4c-a042-9322ca1f2859'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''2e02a91f-1d29-4568-b4ed-a0a62d64361e'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''2e02a91f-1d29-4568-b4ed-a0a62d64361e'',16394,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''1deb502e-3b54-48ff-905d-364a41171821'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''1deb502e-3b54-48ff-905d-364a41171821'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''473be761-85b2-4678-ac4b-b6cc3757cd2a'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''473be761-85b2-4678-ac4b-b6cc3757cd2a'',13322,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''38143a5d-cee1-4558-bfb2-81c66f0f5066'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''38143a5d-cee1-4558-bfb2-81c66f0f5066'',9226,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''a86517a8-2f99-4000-926e-d6cee9365e58'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''a86517a8-2f99-4000-926e-d6cee9365e58'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''db4b52f0-b231-4ba2-85e7-5fe61b265675'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''db4b52f0-b231-4ba2-85e7-5fe61b265675'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''94b7bb4b-ff4f-4fea-8cad-8889c3092587'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''94b7bb4b-ff4f-4fea-8cad-8889c3092587'',5130,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''5500d764-9d02-4aae-831f-25570fa59764'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''5500d764-9d02-4aae-831f-25570fa59764'',7178,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''9de5da9b-b28f-4304-85c1-574b4039bc7a'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''9de5da9b-b28f-4304-85c1-574b4039bc7a'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''9d2980af-6530-45e3-bcb4-a67070395d30'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''9d2980af-6530-45e3-bcb4-a67070395d30'',12298,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''86f3379c-34d9-4c5d-b16b-cbe056ac075a'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''86f3379c-34d9-4c5d-b16b-cbe056ac075a'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''814812e7-776a-4630-9ca0-54029d920a98'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''814812e7-776a-4630-9ca0-54029d920a98'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''88728a60-2605-4fa8-9e9b-e769a77b625e'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''88728a60-2605-4fa8-9e9b-e769a77b625e'',17418,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''fd1ab722-b0fc-4732-8d50-3ce9901f5f78'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''fd1ab722-b0fc-4732-8d50-3ce9901f5f78'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''29b0779a-9e4c-43bc-8ad2-401869e44fca'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''29b0779a-9e4c-43bc-8ad2-401869e44fca'',4106,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''b1f3cfce-21f1-4ead-b0b0-080650cfbc56'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''b1f3cfce-21f1-4ead-b0b0-080650cfbc56'',18442,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''d45d0901-c415-4931-ab6c-55d63c1204cd'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''d45d0901-c415-4931-ab6c-55d63c1204cd'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''86011f4a-091b-4c51-a0de-08c85950d8b9'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''86011f4a-091b-4c51-a0de-08c85950d8b9'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''536cb6c5-3049-4e9e-bb57-5f3c7877f3ba'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''536cb6c5-3049-4e9e-bb57-5f3c7877f3ba'',3082,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''630207e9-4a62-4b1d-9878-ac526f1d27c7'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''630207e9-4a62-4b1d-9878-ac526f1d27c7'',2058,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''a33525ce-c266-4f23-a224-b93774f4a6e8'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''a33525ce-c266-4f23-a224-b93774f4a6e8'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''da1fa09c-bc62-4e36-9e4f-cba35f7d669a'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''da1fa09c-bc62-4e36-9e4f-cba35f7d669a'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''83d56e8d-925d-44fd-852f-e12f4cd5991e'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''83d56e8d-925d-44fd-852f-e12f4cd5991e'',19466,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''66699f78-5cc1-4453-aebd-081eceede38c'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''66699f78-5cc1-4453-aebd-081eceede38c'',6154,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''a4471851-758f-464f-b948-9d848be6deea'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''a4471851-758f-464f-b948-9d848be6deea'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''594fd382-977c-43d9-95ab-b9c0f27aea48'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''594fd382-977c-43d9-95ab-b9c0f27aea48'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''3637e8b0-d6ae-462b-98c1-df9394112461'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''3637e8b0-d6ae-462b-98c1-df9394112461'',15370,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''a9c3554b-d547-4f0d-a19f-469aa645124f'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''a9c3554b-d547-4f0d-a19f-469aa645124f'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''a2cca6e6-7db6-4674-92c2-61c756b7913c'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''a2cca6e6-7db6-4674-92c2-61c756b7913c'',10250,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''7a6d6eb9-395d-409f-9a08-0d9b7523572c'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''7a6d6eb9-395d-409f-9a08-0d9b7523572c'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''33fb6e8d-a81b-4045-a9e9-a0fa1eb0a3a1'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''33fb6e8d-a81b-4045-a9e9-a0fa1eb0a3a1'',20490,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''9ae4bab3-afc0-4ef9-b841-457207151604'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''9ae4bab3-afc0-4ef9-b841-457207151604'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''7fbe8549-cd3d-467e-b4b5-b5a4024a91ae'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''7fbe8549-cd3d-467e-b4b5-b5a4024a91ae'',1034,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''d62ef94c-9208-4f79-a879-2b67cc44a1a8'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''d62ef94c-9208-4f79-a879-2b67cc44a1a8'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''df39bab1-2605-4551-98fa-cb98f1a8340f'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''df39bab1-2605-4551-98fa-cb98f1a8340f'',14346,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''9779eb5a-9d7e-4c87-86de-29b0aa129400'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''9779eb5a-9d7e-4c87-86de-29b0aa129400'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''b9fb6b0c-e744-4b40-8e8d-93da89361f62'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''b9fb6b0c-e744-4b40-8e8d-93da89361f62'',8202,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''399e6928-f982-477d-b7ea-c69da45d54a6'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''399e6928-f982-477d-b7ea-c69da45d54a6'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''763fcc54-be3e-499b-acaa-e91d47c1ffb6'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''763fcc54-be3e-499b-acaa-e91d47c1ffb6'',1089,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''5fa2787a-efda-433d-96ac-8007955e5cd0'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''5fa2787a-efda-433d-96ac-8007955e5cd0'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''7b1fd989-492f-4dec-9fca-896b21440dee'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''7b1fd989-492f-4dec-9fca-896b21440dee'',1053,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''5eaf101f-105e-445e-b7f5-86b6af5c85e9'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''5eaf101f-105e-445e-b7f5-86b6af5c85e9'',1252,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''85ffab14-466e-4a40-af90-e10c2bb72069'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''85ffab14-466e-4a40-af90-e10c2bb72069'',2077,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''e849b0dd-3187-4187-95a2-5fdd5975649b'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''e849b0dd-3187-4187-95a2-5fdd5975649b'',1114,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''23dacea2-de04-40bc-b93c-766cbf0bc6f1'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''23dacea2-de04-40bc-b93c-766cbf0bc6f1'',0,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''848d33e4-9df2-4aae-b09c-2136571fdb3e'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''848d33e4-9df2-4aae-b09c-2136571fdb3e'',0,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''afc1a19c-5f43-4786-848f-eba2d20d87e3'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''afc1a19c-5f43-4786-848f-eba2d20d87e3'',1097,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''396f5f5d-3e3c-486f-b243-6b29cb21cdc7'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''396f5f5d-3e3c-486f-b243-6b29cb21cdc7'',1092,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''2d5f4484-93d4-4e6e-956d-7a5a06381f57'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''2d5f4484-93d4-4e6e-956d-7a5a06381f57'',1251,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ef87b02f-1851-4be7-97dd-6a52b3905275'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ef87b02f-1851-4be7-97dd-6a52b3905275'',0,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''bb889e3c-896e-4c02-92e3-feaecc426bf8'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''bb889e3c-896e-4c02-92e3-feaecc426bf8'',1098,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''753425bc-e632-450a-a04f-7c3198902c2e'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''753425bc-e632-450a-a04f-7c3198902c2e'',874,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''386931dc-3ef7-419d-bb5e-d8a977adb97e'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''386931dc-3ef7-419d-bb5e-d8a977adb97e'',1054,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''ffd617ca-c72e-4dc5-b2b0-6dd513120230'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''ffd617ca-c72e-4dc5-b2b0-6dd513120230'',1254,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''f940ebd3-95a4-41f3-9be7-e689c7cee122'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''f940ebd3-95a4-41f3-9be7-e689c7cee122'',1055,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''c809f62d-ff6c-4746-a359-3d714fa4e7ba'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''c809f62d-ff6c-4746-a359-3d714fa4e7ba'',1251,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''583bcacf-755d-4aeb-928a-876b719c54ac'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''583bcacf-755d-4aeb-928a-876b719c54ac'',1058,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''d4207698-d429-42ec-9b63-06716268bcc2'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''d4207698-d429-42ec-9b63-06716268bcc2'',1256,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''2fa1ebfe-b63b-4066-b47a-56baeac2d35d'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''2fa1ebfe-b63b-4066-b47a-56baeac2d35d'',1056,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''693f251f-f05a-450b-bbc1-73dfb55f851e'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''693f251f-f05a-450b-bbc1-73dfb55f851e'',2115,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''b1f48dd6-7562-4bd1-9966-f7676930d674'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''b1f48dd6-7562-4bd1-9966-f7676930d674'',1251,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''f1ed50b4-4bc0-40b0-bb99-3db617c03c4e'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''f1ed50b4-4bc0-40b0-bb99-3db617c03c4e'',1091,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''cbefbf36-8676-43a9-813b-63dd178bc826'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''cbefbf36-8676-43a9-813b-63dd178bc826'',1254,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''5b4f3283-38e5-4eae-a154-11e5bc7638cd'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''5b4f3283-38e5-4eae-a154-11e5bc7638cd'',1066,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Int WHERE GUID_TokenAttribute=''d5c53165-a33a-4b87-b86b-3ffc0a67850c'' )=0
	INSERT INTO semtbl_Token_Attribute_Int VALUES(''d5c53165-a33a-4b87-b86b-3ffc0a67850c'',1258,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Real WHERE GUID_TokenAttribute=''57693e62-6629-4415-8aaa-38404d98e0a4'' )=0
	INSERT INTO semtbl_Token_Attribute_Real VALUES(''57693e62-6629-4415-8aaa-38404d98e0a4'',19,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Real WHERE GUID_TokenAttribute=''bbba0a9c-5b4d-474f-ad51-454d446bebb1'' )=0
	INSERT INTO semtbl_Token_Attribute_Real VALUES(''bbba0a9c-5b4d-474f-ad51-454d446bebb1'',7,0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Varchar255 WHERE GUID_TokenAttribute=''93a909b4-9cab-40d1-8d16-69c3786dbc91'' )=0
	INSERT INTO semtbl_Token_Attribute_Varchar255 VALUES(''93a909b4-9cab-40d1-8d16-69c3786dbc91'',''bill_module'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Varchar255 WHERE GUID_TokenAttribute=''34ac1372-06ec-4d38-8abb-5dbd10ccffa3'' )=0
	INSERT INTO semtbl_Token_Attribute_Varchar255 VALUES(''34ac1372-06ec-4d38-8abb-5dbd10ccffa3'',''US'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token_Attribute_Varchar255 WHERE GUID_TokenAttribute=''d264ff27-c287-43ce-b602-092b37018e40'' )=0
	INSERT INTO semtbl_Token_Attribute_Varchar255 VALUES(''d264ff27-c287-43ce-b602-092b37018e40'',''DE'',0)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''4a6430a8-89f3-409b-883c-3641a8b88898'' AND GUID_RelationType=''51f3c615-a01e-400d-b81b-58cadd07e773'')=0
	INSERT INTO semtbl_Type_OR VALUES(''4a6430a8-89f3-409b-883c-3641a8b88898'',''51f3c615-a01e-400d-b81b-58cadd07e773'',0,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''b6551e7a-b9c8-4d98-94c6-076dcf8cd12b'' AND GUID_RelationType=''79671239-9c8f-493c-b5e7-49700f9543f4'')=0
	INSERT INTO semtbl_Type_OR VALUES(''b6551e7a-b9c8-4d98-94c6-076dcf8cd12b'',''79671239-9c8f-493c-b5e7-49700f9543f4'',1,1)'
GO
