Public Class lgnForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private db As myDbOperations.OLEDB = New myDbOperations.OLEDB(Application.StartupPath & "\" & "dbMus.mdb", "tblLogin")

    Private Function OnErr() As Boolean
        OnErr = False

        If Me.txtUserName.Text.Trim.Length = 0 Then
            Me.Err.SetError(Me.txtUserName, "Bu Alan Boþ Býrakýlamaz...")
            OnErr = True
        Else
            Me.Err.SetError(Me.txtUserName, "")
        End If

        If Me.txtPassword.Text.Trim.Length = 0 Then
            Me.Err.SetError(Me.txtPassword, "Bu Alan Boþ Býrakýlamaz...")
            OnErr = True
        Else
            Me.Err.SetError(Me.txtPassword, "")
        End If

        Return OnErr
    End Function

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

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If OnErr() = True Then Exit Sub

        Dim usrName As String = ASCIIEncryption(Me.txtUserName.Text)
        Dim pass As String = ASCIIEncryption(Me.txtPassword.Text)

        Dim dt As DataTable = New DataTable
        dt = db.RunQuery(myDbOperations.QueryType.Select, "SELECT loginID,loginViewUser FROM tblLogin WHERE loginName='" & usrName & "' AND " & "loginPassword='" & pass & "'")

        If dt.Rows.Count = 0 Then
            Me.Err.SetError(Me.txtUserName, "Yanlýþ Kullanýcý Adý...")
            Me.Err.SetError(Me.txtPassword, "Yanlýþ Þifre...")
        Else
            Me.Err.SetError(Me.txtUserName, "")
            Me.Err.SetError(Me.txtPassword, "")

            'Kullanýcýnýn kendi ID 'sini de UserViews 'a ekleme..Böylece kendi msjlarýnýda görebilecek..
            'Ve kimlikte loginViewUser en az bir ID içermiþ olacak..
            Dim UserViews As String = dt.Rows(0)(1).ToString
            If UserViews.Trim.Length = 0 Then
                UserViews = dt.Rows(0)(0).ToString
            Else
                UserViews &= "-" & dt.Rows(0)(0).ToString
            End If

            Dim kimlik As clsKimlik = New clsKimlik(CInt(dt.Rows(0)(0).ToString), Me.txtUserName.Text, UserViews)
            Module1.Kimlik = kimlik

            'Kullanýcýnýn görebildiði diðer kimlik bilgilerinin arrayList'i.
            Dim dt3 As DataTable = New DataTable
            dt3 = db.RunQuery(myDbOperations.QueryType.Select, "SELECT loginID,loginName FROM tblLogin WHERE loginName='" & usrName & "' AND " & "loginPassword='" & pass & "'")

            Dim Views() As String = {}
            Views = UserViews.Split("-")

            Dim ViewsUsers As ArrayList = New ArrayList

            For i As Integer = 0 To Views.Length - 1
                Dim viewUserName As String = ASCIIDecryption(CType(db.RunQuery(myDbOperations.QueryType.Select, "SELECT loginName FROM tblLogin WHERE loginID=" & CInt(Views(i))), DataTable).Rows(0)(0).ToString)
                ViewsUsers.Add(New clsKimlik(CInt(Views(i)), viewUserName))
            Next

            Module1.UserViewsKimlik = ViewsUsers

            Dim frm As Form1 = New Form1
            frm.Show()
            Me.Visible = False
            'Me.Dispose()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked, KullaniciSil.LinkClicked

        If OnErr() = True Then Exit Sub

        Dim usrName As String = ASCIIEncryption(Me.txtUserName.Text)
        Dim pass As String = ASCIIEncryption(Me.txtPassword.Text)

        Dim dt As DataTable = New DataTable
        dt = db.RunQuery(myDbOperations.QueryType.Select, "SELECT * FROM tblLogin WHERE loginName='" & usrName & "' AND " & "loginPassword='" & pass & "'" & " AND " & "loginID=2")

        If dt.Rows.Count = 0 Then
            Me.Err.SetError(Me.txtUserName, "Yanlýþ Kullanýcý Adý...")
            Me.Err.SetError(Me.txtPassword, "Yanlýþ Þifre...")
        Else
            Me.Err.SetError(Me.txtUserName, "")
            Me.Err.SetError(Me.txtPassword, "")

            Select Case CType(sender, LinkLabel).Text
                Case "Kullanýcý Ekle"
                    Dim frm As frmAddUser = New frmAddUser
                    frm.Show()
                    Me.Visible = False
                Case "Kullanýcý Sil"
                    Dim frm As frmDelUser = New frmDelUser
                    frm.Show()
                    Me.Visible = False
            End Select

        End If
    End Sub

End Class
