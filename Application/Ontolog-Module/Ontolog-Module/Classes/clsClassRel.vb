﻿Public Class clsClassRel
    Dim strID_Class_Left As String
    Dim strName_Class_Left As String
    Dim strID_Class_Right As String
    Dim strName_Class_Right As String
    Dim strID_RelationType As String
    Dim strName_RelationType As String
    Dim strOntology As String
    Dim lngMin_Forw As Long
    Dim lngMax_Forw As Long
    Dim lngMax_Backw As Long

    Public Property Name_Class_Left As String
        Get
            Return strName_Class_Left
        End Get
        Set(ByVal value As String)
            strName_Class_Left = value
        End Set
    End Property

    Public Property Name_Class_Right As String
        Get
            Return strName_Class_Right
        End Get
        Set(ByVal value As String)
            strName_Class_Right = value
        End Set
    End Property

    Public Property Name_RelationType As String
        Get
            Return strName_RelationType
        End Get
        Set(ByVal value As String)
            strName_RelationType = value
        End Set
    End Property

    Public Property Ontology As String
        Get
            Return strOntology
        End Get
        Set(ByVal value As String)
            strOntology = value
        End Set
    End Property

    Public Property ID_Class_Left As String
        Get
            Return strID_Class_Left
        End Get
        Set(ByVal value As String)
            strID_Class_Left = value
        End Set
    End Property

    Public Property ID_Class_Right As String
        Get
            Return strID_Class_Right
        End Get
        Set(ByVal value As String)
            strID_Class_Right = value
        End Set
    End Property

    Public Property ID_RelationType As String
        Get
            Return strID_RelationType
        End Get
        Set(ByVal value As String)
            strID_RelationType = value
        End Set
    End Property

    Public Property Min_Forw As Long
        Get
            Return lngMin_Forw
        End Get
        Set(ByVal value As Long)
            lngMin_Forw = value
        End Set
    End Property

    Public Property Max_Forw As Long
        Get
            Return lngMax_Forw
        End Get
        Set(ByVal value As Long)
            lngMax_Forw = value
        End Set
    End Property

    Public Property Max_Backw As Long
        Get
            Return lngMax_Backw
        End Get
        Set(ByVal value As Long)
            lngMax_Backw = value
        End Set
    End Property

    Public Sub New(ByVal ID_Class_Left As String, ByVal ID_Class_Right As String, ByVal ID_RelationType As String, ByVal Ontology As String, ByVal Min_forw As Long, ByVal Max_forw As Long, ByVal Max_backw As Long)
        strID_Class_Left = ID_Class_Left
        strID_Class_Right = ID_Class_Right
        strID_RelationType = ID_RelationType
        strOntology = Ontology
        lngMin_Forw = Min_forw
        lngMax_Forw = Max_forw
        lngMax_Backw = Max_backw
    End Sub

    Public Sub New(ByVal ID_Class_Left As String, _
                   ByVal Name_Class_Left As String, _
                   ByVal ID_Class_Right As String,
                   ByVal Name_Class_Right As String, _
                   ByVal ID_RelationType As String, _
                   ByVal Name_RelationType As String, _
                   ByVal Ontology As String, _
                   ByVal Min_forw As Long, _
                   ByVal Max_forw As Long, _
                   ByVal Max_backw As Long)

        strID_Class_Left = ID_Class_Left
        strName_Class_Left = Name_Class_Left
        strID_Class_Right = ID_Class_Right
        strName_Class_Right = Name_Class_Right
        strID_RelationType = ID_RelationType
        strName_RelationType = Name_RelationType
        strOntology = Ontology
        lngMin_Forw = Min_forw
        lngMax_Forw = Max_forw
        lngMax_Backw = Max_backw
    End Sub
End Class
