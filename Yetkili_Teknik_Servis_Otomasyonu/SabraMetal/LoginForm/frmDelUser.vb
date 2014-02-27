Public Class frmDelUser

#Region "Local Variables"
    Private db As myDbOperations.OLEDB = New myDbOperations.OLEDB(Application.StartupPath & "\" & "dbMus.mdb", "tblLogin")

    Private db2 As myDbOperations.OLEDB = New myDbOperations.OLEDB(Application.StartupPath & "\" & "dbMus.mdb", "tblMusteriler")
#End Region

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

    Private Sub frmDelUser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        lgnForm.Visible = True
    End Sub

    Private Sub frmDelUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Panel1.Controls.Clear()

        Dim dt As DataTable = New DataTable

        dt = CType(db.RunQuery(myDbOperations.QueryType.Select, "SELECT loginID,loginName FROM tblLogin WHERE loginID<>2"), DataTable)

        If dt.Rows.Count = 0 Then Exit Sub

        For Each dr As DataRow In dt.Rows
            Dim rdb As RadioButton
            rdb = New RadioButton
            rdb.Dock = DockStyle.Top

            Dim str As String = Me.ASCIIDecryption(dr(1).ToString)
            rdb.Text = str
            rdb.Tag = CInt(dr(0).ToString)

            Me.Panel1.Controls.Add(rdb)
        Next
    End Sub

    Private Sub btnKapat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKapat.Click
        Me.Close()
        lgnForm.Visible = True
    End Sub

    Private Sub btnSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSil.Click
        For Each rdb As RadioButton In Me.Panel1.Controls
            If rdb.Checked = True Then

                'Kullanýcý silinir....
                db.RunQuery(myDbOperations.QueryType.InsUpdDel, "DELETE FROM tblLogin WHERE loginID=" & CInt(rdb.Tag.ToString))

                'Diðer kullanýcýlarda silinen ID görüntülenebilir seçildiyse bununda silinmesi..
                Dim dt1 As DataTable = New DataTable
                Dim arr As ArrayList = New ArrayList

                arr.Add("loginID")
                arr.Add("loginViewUser")

                dt1 = db.Select(arr)

                If dt1.Rows.Count > 0 Then
                    For Each dr As DataRow In dt1.Rows

                        If dr(1).ToString.Trim.Length <> 0 Then
                            Dim views() As String = {}
                            views = dr(1).ToString.Split("-")

                            Dim str As String = ""
                            For i As Integer = 0 To views.Length - 1
                                If Not CInt(views(i)) = CInt(rdb.Tag.ToString) Then
                                    str &= views(i) & "-"
                                End If
                            Next

                            If str.Trim.Length > 0 Then str = str.Remove(str.Length - 1, 1)

                            db.RunQuery(myDbOperations.QueryType.InsUpdDel, "UPDATE tblLogin SET loginViewUser='" & str & "' WHERE loginID=" & dr(0).ToString)
                        End If

                    Next
                End If

                'Admin in görebileceði kiþilerin ifadesi düzenlenir..hata oluþmasýn diye..
                'Dim dt2 As DataTable = New DataTable
                'dt2 = db.RunQuery(myDbOperations.QueryType.Select, "SELECT loginID FROM tblLogin")

                'Dim strID As String = ""

                'For i As Integer = 0 To dt2.Rows.Count - 1
                '    strID &= dt2.Rows(i)(0).ToString & "-"
                'Next

                'strID = strID.Remove(strID.Length - 1, 1)

                'db.RunQuery(myDbOperations.QueryType.InsUpdDel, "UPDATE tblLogin SET loginViewUser='" & strID & "' WHERE loginID=2")

                'Musteriler tablosundaki silinen ID ye ait bilgiler silinir..
                db2.RunQuery(myDbOperations.QueryType.InsUpdDel, "DELETE FROM tblMusteriler WHERE musSorumlu=" & rdb.Tag.ToString)

                Exit For
            End If
        Next

        Me.frmDelUser_Load(sender, e)
    End Sub
End Class