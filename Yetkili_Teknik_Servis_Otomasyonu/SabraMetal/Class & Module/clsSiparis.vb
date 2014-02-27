#Region "Imports"
#End Region

Public Class clsSiparis

#Region "LocalVariables"
    Private musID_ As Integer
    Private musAdi_ As String
    Private musSoyadi_ As String
    Private musTelNo_ As String
    Private musTarihSaat_ As Date
    Private musSeriNo_ As String
    Private musCihazTipi_ As String
    Private musAksesuar_ As String
    Private musArizaTuru_ As String
    Private musCihazDurumu_ As String
    Private musSorumlu_ As clsKimlik
    Private musIadeTarihi_ As Date
    Private musIadeDurumu_ As String
    Private musUcret_ As Single
    Private musAciklama_ As String
#End Region

#Region "Properties"
    Public Property musID() As Integer
        Get
            Return Me.musID_
        End Get
        Set(ByVal value As Integer)
            Me.musID_ = value
        End Set
    End Property
    Public Property musAdi() As String
        Get
            Return Me.musAdi_
        End Get
        Set(ByVal value As String)
            Me.musAdi_ = value
        End Set
    End Property
    Public Property musSoyadi() As String
        Get
            Return Me.musSoyadi_
        End Get
        Set(ByVal value As String)
            Me.musSoyadi_ = value
        End Set
    End Property
    Public Property musTelNo() As String
        Get
            Return Me.musTelNo_
        End Get
        Set(ByVal value As String)
            Me.musTelNo_ = value
        End Set
    End Property
    Public Property musTarihSaat() As Date
        Get
            Return Me.musTarihSaat_
        End Get
        Set(ByVal value As Date)
            Me.musTarihSaat_ = value
        End Set
    End Property
    Public Property musSeriNo() As String
        Get
            Return Me.musSeriNo_
        End Get
        Set(ByVal value As String)
            Me.musSeriNo_ = value
        End Set
    End Property
    Public Property musCihazTipi() As String
        Get
            Return Me.musCihazTipi_
        End Get
        Set(ByVal value As String)
            Me.musCihazTipi_ = value
        End Set
    End Property
    Public Property musAksesuar() As String
        Get
            Return Me.musAksesuar_
        End Get
        Set(ByVal value As String)
            Me.musAksesuar_ = value
        End Set
    End Property
    Public Property musArizaTuru() As String
        Get
            Return Me.musArizaTuru_
        End Get
        Set(ByVal value As String)
            Me.musArizaTuru_ = value
        End Set
    End Property
    Public Property musCihazDurumu() As String
        Get
            Return Me.musCihazDurumu_
        End Get
        Set(ByVal value As String)
            Me.musCihazDurumu_ = value
        End Set
    End Property
    Public ReadOnly Property musSorumlu() As clsKimlik
        Get
            Return Me.musSorumlu_
        End Get
    End Property
    Public Property musIadeTarihi() As Date
        Get
            Return Me.musIadeTarihi_
        End Get
        Set(ByVal value As Date)
            Me.musIadeTarihi_ = value
        End Set
    End Property
    Public Property musIadeDurumu() As String
        Get
            Return Me.musIadeDurumu_
        End Get
        Set(ByVal value As String)
            Me.musIadeDurumu_ = value
        End Set
    End Property
    Public Property musUcret() As Single
        Get
            Return Me.musUcret_
        End Get
        Set(ByVal value As Single)
            Me.musUcret_ = value
        End Set
    End Property
    Public Property musAciklama() As String
        Get
            Return Me.musAciklama_
        End Get
        Set(ByVal value As String)
            Me.musAciklama_ = value
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New()
    End Sub

    Public Sub New(ByVal dr As DataGridViewRow, ByVal Sorumlu As clsKimlik)
        Me.musID_ = CInt(dr.Cells(0).Value.ToString)
        Me.musAdi_ = dr.Cells(1).Value.ToString
        Me.musSoyadi_ = dr.Cells(2).Value.ToString
        Me.musTelNo_ = dr.Cells(3).Value.ToString
        Me.musTarihSaat_ = CDate(dr.Cells(4).Value.ToString)
        Me.musSeriNo_ = dr.Cells(5).Value.ToString
        Me.musCihazTipi_ = dr.Cells(6).Value.ToString
        Me.musAksesuar_ = dr.Cells(7).Value.ToString
        Me.musArizaTuru_ = dr.Cells(8).Value.ToString
        Me.musCihazDurumu_ = dr.Cells(9).Value.ToString
        Me.musSorumlu_ = Sorumlu
        Me.musIadeTarihi_ = CDate(dr.Cells(11).Value.ToString)
        Me.musIadeDurumu_ = dr.Cells(12).Value.ToString
        Me.musUcret_ = CType(dr.Cells(13).Value.ToString, Single)
        Me.musAciklama_ = dr.Cells(14).Value.ToString
    End Sub

#End Region

#Region "Methods"
    Public Function DoTreeNode(ByVal dr As DataGridViewRow, ByVal Sorumlu As clsKimlik) As TreeNode
        DoTreeNode = New TreeNode
        DoTreeNode.Text = dr.Cells(1).Value.ToString & " " & dr.Cells(2).Value.ToString
        DoTreeNode.Tag = CInt(dr.Cells(0).Value)
        DoTreeNode.ImageIndex = 1
        DoTreeNode.SelectedImageIndex = 1

        Dim child_nd As TreeNode

        For i As Integer = 3 To 14
            If i <> 10 Then
                child_nd = New TreeNode(dr.Cells(i).Value.ToString)
            Else
                child_nd = New TreeNode(dr.Cells(15).Value.ToString)
            End If

            child_nd.ImageIndex = i
            child_nd.SelectedImageIndex = i

            Select Case i
                Case 3
                    child_nd.Tag = "[musTelNo]"
                Case 4
                    child_nd.Tag = "[musTarihSaat]"
                Case 5
                    child_nd.Tag = "[musSeriNo]"
                Case 6
                    child_nd.Tag = "[musCihazTipi]"
                Case 7
                    child_nd.Tag = "[musAksesuar]"
                Case 8
                    child_nd.Tag = "[musArizaTuru]"
                Case 9
                    child_nd.Tag = "[musCihazDurumu]"
                Case 10
                    child_nd.Tag = "[musSorumlu]"
                Case 11
                    child_nd.Tag = "[musIadeTarihi]"
                Case 12
                    child_nd.Tag = "[musIadeDurumu]"
                Case 13
                    child_nd.Tag = "[musUcret]"
                Case 14
                    child_nd.Tag = "[musAciklama]"
            End Select

            DoTreeNode.Nodes.Add(child_nd)
        Next

        Return DoTreeNode
    End Function
#End Region
End Class
