Public Class clsFilter
    Private strFilter As String
    Private strFilter_Real As String
    Private strFilter_Offset As String
    Private dblFilter_Start As Double
    Private dblFilter_End As Double
    Private dateFilter_Start As Date
    Private dateFilter_End As Date
    Private intFilter_Offset As Integer

    Private _GUID_Type_Left As Guid
    Private _GUID_Token_Left As Guid
    Private _Name_Token_Left As String
    Private _GUID_Type_Right As Guid
    Private _GUID_Token_Right As Guid
    Private _Name_Token_Right As String
    Private _GUID_RelationType As Guid

    Private boolOtherNull As Boolean
    Private intDirectionLeftRight As Integer

    Private GUID_Type As Guid
    Private boolParseError As Boolean
    Private objGlobals As clsGlobals

    Private objSemItem_Ref As clsSemItem
    Private boolSeperate As Boolean

    Public Property isOtherNull As Boolean
        Get
            Return boolOtherNull
        End Get
        Set(ByVal value As Boolean)
            boolOtherNull = value
        End Set
    End Property

    Public Property DirectionLeftRight As Integer
        Get
            Return intDirectionLeftRight
        End Get
        Set(ByVal value As Integer)
            intDirectionLeftRight = value
        End Set
    End Property

    Public Property GUID_Type_Left As Guid
        Get
            Return _GUID_Type_Left
        End Get
        Set(ByVal value As Guid)
            _GUID_Type_Left = value
        End Set
    End Property

    Public Property GUID_Token_Left As Guid
        Get
            Return _GUID_Token_Left
        End Get
        Set(ByVal value As Guid)
            _GUID_Token_Left = value
        End Set
    End Property


    Public Property Name_Token_Left As String
        Get
            Return _Name_Token_Left
        End Get
        Set(ByVal value As String)
            _Name_Token_Left = value
        End Set
    End Property


    Public Property GUID_Type_Right As Guid
        Get
            Return _GUID_Type_Right
        End Get
        Set(ByVal value As Guid)
            _GUID_Type_Right = value
        End Set
    End Property

    Public Property GUID_Token_Right As Guid
        Get
            Return _GUID_Token_Right
        End Get
        Set(ByVal value As Guid)
            _GUID_Token_Right = value
        End Set
    End Property


    Public Property Name_Token_Right As String
        Get
            Return _Name_Token_Right
        End Get
        Set(ByVal value As String)
            _Name_Token_Right = value
        End Set
    End Property


    Public Property GUID_RelationType As Guid
        Get
            Return _GUID_RelationType
        End Get
        Set(ByVal value As Guid)
            _GUID_RelationType = value
        End Set
    End Property

    Public ReadOnly Property Filter As String
        Get
            Return strFilter
        End Get
    End Property
    Public ReadOnly Property SemItem_Ref As clsSemItem
        Get
            Return objSemItem_Ref
        End Get
    End Property

    Public ReadOnly Property Filter_Real_Start As Double
        Get
            Return dblFilter_Start
        End Get
    End Property

    Public ReadOnly Property Filter_Real_End As Double
        Get
            Return dblFilter_End
        End Get
    End Property

    Public ReadOnly Property Filter_Date_Start As Date
        Get
            Return dateFilter_Start
        End Get
    End Property

    Public ReadOnly Property Filter_Date_End As Date
        Get
            Return dateFilter_End
        End Get
    End Property

    Public ReadOnly Property Filter_Offset As Integer
        Get
            Return intFilter_Offset
        End Get
    End Property

    Public ReadOnly Property Filter_Error As Boolean
        Get
            Return boolParseError
        End Get
    End Property

    Private Sub parse_Filter()
        Dim strFilters() As String
        Try
            If objGlobals.is_GUID(strFilter) Then
                GUID_Token_Left = New Guid(strFilter)
                boolParseError = False
            ElseIf boolSeperate = False Then
                Select Case GUID_Type
                    Case objGlobals.AttributeType_Real.GUID
                        boolParseError = Not Double.TryParse(strFilter, dblFilter_Start)
                        dblFilter_End = dblFilter_Start
                    Case objGlobals.AttributeType_Date.GUID
                        boolParseError = Not Date.TryParse(strFilter, dateFilter_Start)
                        dateFilter_End = dateFilter_Start
                    Case objGlobals.AttributeType_Varchar255.GUID
                        boolParseError = False
                    Case Else
                        boolParseError = True
                End Select
                boolParseError = False
            Else

                strFilters = strFilter.Split(" ")
                Select Case strFilters.Count
                    Case 1

                        intFilter_Offset = 0
                        Select Case GUID_Type
                            Case objGlobals.AttributeType_Real.GUID
                                boolParseError = Not Double.TryParse(strFilters(0), dblFilter_Start)
                                dblFilter_End = dblFilter_Start
                            Case objGlobals.AttributeType_Date.GUID
                                boolParseError = Not Date.TryParse(strFilters(0), dateFilter_Start)
                                dateFilter_End = dateFilter_Start
                            Case objGlobals.AttributeType_Varchar255.GUID
                                boolParseError = False
                            Case Else
                                boolParseError = True
                        End Select


                    Case 2
                        intFilter_Offset = 0
                        Select Case GUID_Type
                            Case objGlobals.AttributeType_Real.GUID
                                dblFilter_Start = 0
                                dblFilter_End = 0
                                strFilters(0) = strFilters(0).Replace(".", ",")
                                strFilters(1) = strFilters(1).Replace(".", ",")
                                boolParseError = Not Double.TryParse(strFilters(0), dblFilter_Start)
                                If boolParseError = False Then
                                    If strFilters(1).Contains(",") Or strFilters(1).Contains(".") Then
                                        boolParseError = Not Double.TryParse(strFilters(1), dblFilter_End)
                                        intFilter_Offset = 0
                                    Else
                                        boolParseError = Not Integer.TryParse(strFilters(1), intFilter_Offset)
                                    End If


                                    If intFilter_Offset > 0 Then
                                        dblFilter_End = dblFilter_Start + intFilter_Offset
                                        dblFilter_Start = dblFilter_Start - intFilter_Offset
                                    End If

                                End If


                            Case objGlobals.AttributeType_Date.GUID
                                dateFilter_Start = Now
                                dateFilter_End = dateFilter_Start
                                boolParseError = Not Date.TryParse(strFilters(0), dateFilter_Start)
                                If boolParseError = False Then

                                    boolParseError = Not Date.TryParse(strFilters(1), dateFilter_End)
                                    intFilter_Offset = 0
                                    If boolParseError = True Then
                                        boolParseError = Not Integer.TryParse(strFilters(1), intFilter_Offset)
                                    End If

                                    If intFilter_Offset > 0 Then
                                        dateFilter_End = dateFilter_Start.AddDays(intFilter_Offset)
                                        dateFilter_Start = dateFilter_Start.AddDays(intFilter_Offset * -1)
                                    End If

                                End If
                            Case objGlobals.AttributeType_Varchar255.GUID
                                boolParseError = False
                            Case Else
                                boolParseError = True
                        End Select

                    Case Else
                        boolParseError = True
                End Select
            End If
            
        Catch ex As Exception
            boolParseError = True
        End Try

    End Sub

    Public Sub New(ByVal Filter As String, ByVal _GUID_Type As Guid, ByVal SemItem_Ref As clsSemItem, ByVal Globals As clsGlobals, Optional ByVal isSeperated As Boolean = True)
        strFilter = Filter

        GUID_Type = _GUID_Type
        objGlobals = Globals
        objSemItem_Ref = SemItem_Ref
        boolSeperate = isSeperated
        boolParseError = False
        parse_Filter()
    End Sub

    Public Sub New()

    End Sub
End Class

