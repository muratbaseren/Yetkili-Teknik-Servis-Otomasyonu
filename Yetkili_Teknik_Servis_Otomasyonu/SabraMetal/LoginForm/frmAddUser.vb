Public Class frmAddUser

    Private db As myDbOperations.OLEDB = New myDbOperations.OLEDB(Application.StartupPath & "\" & "dbMus.mdb", "tblLogin")

    Private Sub frmAddUser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        lgnForm.Close()
    End Sub

    'Kendi oluþturduðum algoritma..
    ''' <summary>
    ''' Encryption to Text From ASCII Code Of Characters.
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ASCIIEncryption(ByVal str As String) As String
        Dim text As System.Text.StringBuilder = New System.Text.StringBuilder
        Dim strToChars() As Char

        If str.Trim = "" Then Exit Function

        'Her seferinde farklý þifreleme için Rastgele bi sayý belirleyip karakterin ASCII kodu ile toplayacaðým.
        Dim intCode As Integer = 167

        strToChars = str.ToCharArray
        text.Append(intCode.ToString)

        For Each chr As Char In strToChars
            Dim ascii As Integer = Asc(chr) + intCode

            Select Case ascii.ToString.Length
                Case 1
                    text.Append("00" & ascii.ToString)
                Case 2
                    text.Append("0" & ascii.ToString)
                Case Else
                    text.Append(ascii.ToString)
            End Select
        Next

        Return text.ToString
    End Function

    ''' <summary>
    ''' Decryption to Text From ASCII Code Of Characters.
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ASCIIDecryption(ByVal str As String) As String
        Dim text As System.Text.StringBuilder = New System.Text.StringBuilder
        Dim AsciiOfChars As ArrayList = New ArrayList

        If str.Trim = "" Then Exit Function

        'ilk 3 karakter þifrelenen her harfin ASCII koduna eklenen sayý deðeri oldugundan,her 3 rakamdan ilk 3 karakterdeki deðeri çýkartýp karaktere dönüþtüreceðiz.
        Dim intCode As Integer = CInt(str.Substring(0, 3))
        Dim intBegin As Integer

        For i As Integer = 3 To str.Length - 1

            If i Mod 3 = 0 Then intBegin = i

            If i Mod 3 = 2 Then
                Dim chr As String = str.Substring(intBegin, 3)
                AsciiOfChars.Add(CInt(chr))
            End If

        Next

        For Each int As Integer In AsciiOfChars
            int = int - intCode
            text.Append(Chr(int).ToString)
        Next

        Return text.ToString
    End Function

    Private Sub frmAddUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtKullaniciAdi.Text = ""
        Me.txtSifre.Text = ""
        Me.Panel1.Controls.Clear()

        Dim dt As DataTable = New DataTable
        dt = db.RunQuery(myDbOperations.QueryType.Select, "SELECT loginID,loginName FROM tblLogin WHERE loginID<>2")

        Dim chk As CheckBox
        Dim y As Integer = 10

        If Not dt.Rows.Count = 0 Then
            Me.Label3.Visible = False

            For Each dr As DataRow In dt.Rows
                Dim usrName As String = ASCIIDecryption(dr(1).ToString)

                chk = New CheckBox
                chk.Tag = CInt(dr(0).ToString)
                chk.Text = usrName

                chk.CheckState = CheckState.Unchecked
                chk.Location = New Point(20, y)
                chk.Size = New Size(150, 24)
                chk.AutoSize = False
                y += 30

                Me.Panel1.Controls.Add(chk)
            Next
        End If

    End Sub

    Private Sub btnKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKaydet.Click
        If Not Me.txtKullaniciAdi.Text.Trim.Length = 0 OrElse Not Me.txtSifre.Text.Trim.Length = 0 Then

            Dim usrName As String = ASCIIEncryption(Me.txtKullaniciAdi.Text)
            Dim pass As String = ASCIIEncryption(Me.txtSifre.Text)

            Dim UserViews As String = ""
            Dim chk As CheckBox

            For Each ctrl As Control In Me.Panel1.Controls
                If TypeOf ctrl Is CheckBox Then
                    chk = CType(ctrl, CheckBox)
                    If chk.CheckState = CheckState.Checked Then
                        UserViews &= chk.Tag.ToString & "-"
                    End If
                End If
            Next

            If Not UserViews.Trim.Length = 0 Then UserViews = UserViews.Remove(UserViews.Length - 1, 1)

            Dim ColsVals As ArrayList = New ArrayList

            ColsVals.Add(New myDbOperations.Parameters("loginName", usrName, myDbOperations.OLEVariableTypes.Text))
            ColsVals.Add(New myDbOperations.Parameters("loginPassword", pass, myDbOperations.OLEVariableTypes.Text))
            ColsVals.Add(New myDbOperations.Parameters("loginViewUser", UserViews, myDbOperations.OLEVariableTypes.Text))

            If db.Insert(ColsVals) = 1 Then
                MessageBox.Show(Me.txtKullaniciAdi.Text & " isimli kullanýcý sisteme eklenmiþtir..", "Kullanýcý Eklendi.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Dim dt As DataTable = New DataTable
                dt = db.RunQuery(myDbOperations.QueryType.Select, "SELECT loginID FROM tblLogin")

                Dim strID As String = ""

                For i As Integer = 0 To dt.Rows.Count - 1
                    strID &= dt.Rows(i)(0).ToString & "-"
                Next

                strID = strID.Remove(strID.Length - 1, 1)

                db.RunQuery(myDbOperations.QueryType.InsUpdDel, "UPDATE tblLogin SET loginViewUser='" & strID & "' WHERE loginID=2")

            Else
                MessageBox.Show(Me.txtKullaniciAdi.Text & " isimli kullanýcý sisteme eklenememiþtir..", "Kullanýcý Eklenemedi.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        Else
            MessageBox.Show("Kullanýcý Adý yada Þifre boþ olamaz...", "Hatalý Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

        frmAddUser_Load(sender, e)
    End Sub
End Class