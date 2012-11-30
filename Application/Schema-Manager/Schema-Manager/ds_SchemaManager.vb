Namespace ds_SchemaManagerTableAdapters




    Partial Class proc_Creationscript_Of_DBSchema_WorkTableAdapter
        Public WriteOnly Property CommandTimeout() As Integer
            Set(ByVal value As Integer)
                Dim i As Integer = 0
                While (i < Me.CommandCollection.Length)
                    If (Me.CommandCollection(i) IsNot Nothing) Then
                        Me.CommandCollection(i).CommandTimeout = value
                    End If
                    i = (i + 1)
                End While
            End Set
        End Property
    End Class

    Partial Class func_CreationScript_belongsTo_DBSchemaTableAdapter
        Public WriteOnly Property CommandTimeout() As Integer
            Set(ByVal value As Integer)
                Dim i As Integer = 0
                While (i < Me.CommandCollection.Length)
                    If (Me.CommandCollection(i) IsNot Nothing) Then
                        Me.CommandCollection(i).CommandTimeout = value
                    End If
                    i = (i + 1)
                End While
            End Set
        End Property
    End Class

    
End Namespace

Partial Class ds_SchemaManager
End Class
