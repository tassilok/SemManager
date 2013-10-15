use [sem_db_work]
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''0b183be9-c13d-4157-989b-63b0362aeee6'') = 0
	insert into semtbl_Attribute VALUES(''0b183be9-c13d-4157-989b-63b0362aeee6'',''ID'',''3a4f5b7b-da75-4980-933e-fbc33cc51439'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'') = 0
	insert into semtbl_Attribute VALUES(''64cf93ce-5b71-4a5c-b2cc-1b9638949cfe'',''db_postfix'',''065e644e-c7df-4007-8672-aa5414131c78'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''2e5fd016-c574-4924-b724-d1b30640243a'') = 0
	insert into semtbl_Attribute VALUES(''2e5fd016-c574-4924-b724-d1b30640243a'',''DateTimestamp'',''905fda81-788f-4e3d-8329-3e55ae984b9e'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Attribute WHERE GUID_Attribute=''0d2c794d-281d-44ff-9767-eb8549d4ad16'') = 0
	insert into semtbl_Attribute VALUES(''0d2c794d-281d-44ff-9767-eb8549d4ad16'',''Message'',''64530b52-d96c-4df1-86fe-183f44513450'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''cf27679f-cbe7-4010-a3ae-472072762b33'')=0
	insert into semtbl_RelationType VALUES(''cf27679f-cbe7-4010-a3ae-472072762b33'',''is in State'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''79671239-9c8f-493c-b5e7-49700f9543f4'')=0
	insert into semtbl_RelationType VALUES(''79671239-9c8f-493c-b5e7-49700f9543f4'',''belonging'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''d513be0d-5832-445a-b9e4-0c5e85818a12'')=0
	insert into semtbl_RelationType VALUES(''d513be0d-5832-445a-b9e4-0c5e85818a12'',''provides'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_RelationType WHERE GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	insert into semtbl_RelationType VALUES(''e07469d9-766c-443e-8526-6d9c684f944f'',''belongs to'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type=''49fdcd27-e105-4770-941d-7485dcad08c1'') = 0
	insert into semtbl_Type (GUID_Type,Name_Type) VALUES(''49fdcd27-e105-4770-941d-7485dcad08c1'',''Root'')'
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='665dd88b-792e-4256-a27a-68ee1e10ece6') = 0
	insert into semtbl_Type VALUES('665dd88b-792e-4256-a27a-68ee1e10ece6','System','49fdcd27-e105-4770-941d-7485dcad08c1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='53136d10-b7e7-47fc-94ad-7887a354d6e1') = 0
	insert into semtbl_Type VALUES('53136d10-b7e7-47fc-94ad-7887a354d6e1','Log-Management','665dd88b-792e-4256-a27a-68ee1e10ece6')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='8e34e46a-4808-46fa-8d13-968a850ba63a') = 0
	insert into semtbl_Type VALUES('8e34e46a-4808-46fa-8d13-968a850ba63a','Timemanagement','53136d10-b7e7-47fc-94ad-7887a354d6e1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='351d4591-2495-4501-82ab-a425f5235db9') = 0
	insert into semtbl_Type VALUES('351d4591-2495-4501-82ab-a425f5235db9','Logentry','53136d10-b7e7-47fc-94ad-7887a354d6e1')
GO
IF (SELECT COUNT(*) FROM semtbl_Type WHERE GUID_Type='1d9568af-b6da-4990-8f4d-907dfdd30749') = 0
	insert into semtbl_Type VALUES('1d9568af-b6da-4990-8f4d-907dfdd30749','Logstate','53136d10-b7e7-47fc-94ad-7887a354d6e1')
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''27c1f519-febd-432f-877e-46a18d135dda'') = 0
	insert into semtbl_Token VALUES(''27c1f519-febd-432f-877e-46a18d135dda'',''Work'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e323b5c2-d403-4ec5-a854-c5d3ab70f75d'') = 0
	insert into semtbl_Token VALUES(''e323b5c2-d403-4ec5-a854-c5d3ab70f75d'',''Krank'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''e0dcba44-1ede-4e7c-8a08-907d00316d97'') = 0
	insert into semtbl_Token VALUES(''e0dcba44-1ede-4e7c-8a08-907d00316d97'',''Urlaub'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Token WHERE GUID_Token=''c7539a94-72d4-41c8-acc3-119dc12fd210'') = 0
	insert into semtbl_Token VALUES(''c7539a94-72d4-41c8-acc3-119dc12fd210'',''private'',''1d9568af-b6da-4990-8f4d-907dfdd30749'')'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_Attribute=''2e5fd016-c574-4924-b724-d1b30640243a'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''351d4591-2495-4501-82ab-a425f5235db9'',''2e5fd016-c574-4924-b724-d1b30640243a'',1,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Attribute WHERE GUID_Type=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_Attribute=''0d2c794d-281d-44ff-9767-eb8549d4ad16'')=0
	INSERT INTO semtbl_Type_Attribute VALUES(''351d4591-2495-4501-82ab-a425f5235db9'',''0d2c794d-281d-44ff-9767-eb8549d4ad16'',0,1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_Type_Right=''1d9568af-b6da-4990-8f4d-907dfdd30749'' AND GUID_RelationType=''d513be0d-5832-445a-b9e4-0c5e85818a12'')=0
	INSERT INTO semtbl_Type_Type VALUES(''351d4591-2495-4501-82ab-a425f5235db9'',''1d9568af-b6da-4990-8f4d-907dfdd30749'',''d513be0d-5832-445a-b9e4-0c5e85818a12'',1,1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_Type WHERE GUID_Type_Left=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_Type_Right=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_Type VALUES(''351d4591-2495-4501-82ab-a425f5235db9'',''351d4591-2495-4501-82ab-a425f5235db9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1,-1)'
GO
execute dbo.sp_executesql @statement = N'IF (SELECT COUNT(*) FROM semtbl_Type_OR WHERE GUID_Type=''351d4591-2495-4501-82ab-a425f5235db9'' AND GUID_RelationType=''e07469d9-766c-443e-8526-6d9c684f944f'')=0
	INSERT INTO semtbl_Type_OR VALUES(''351d4591-2495-4501-82ab-a425f5235db9'',''e07469d9-766c-443e-8526-6d9c684f944f'',0,-1)'
GO
