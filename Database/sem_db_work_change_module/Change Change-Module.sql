-- Change RelationType to unique
UPDATE semtbl_Token_OR
SET semtbl_Token_OR.GUID_RelationType = '92619f7e-cbf3-4230-8ca3-4b7e7e8883f6'
FROM semtbl_Token
INNER JOIN semtbl_Token_OR ON semtbl_Token_OR.GUID_Token_Left = semtbl_Token.GUID_Token
WHERE GUID_Type='c30af86e-4016-416f-8196-8ec6a52efcae'
AND GUID_RelationType = 'e07469d9-766c-443e-8526-6d9c684f944f'
