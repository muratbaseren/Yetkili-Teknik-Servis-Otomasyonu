Public Class Form1

    Private db As myDbOperations.OLEDB = New myDbOperations.OLEDB(Application.StartupPath & "\" & "dbMus.mdb", "tblMusteriler")

    Private Sub InformationLabels()
        Me.tssRowCount.Text = "Satýr Sayýsý : " & Me.dgv.Rows.Count.ToString
        Me.tssCellCount.Text = "Hücre Sayýsý : " & Me.dgv.GetCellCount(DataGridViewElementStates.Displayed).ToString
        Me.tssCellAddress.Text = "Hücre Adresi : " & Me.dgv.CurrentCellAddress.ToString
    End Sub

    Private Sub ChangeKimlikID()

        Dim dt As DataTable = CType(Me.dgv.DataSource, DataTable)
        Dim dc As DataColumn = New DataColumn("Sorumlu Kiþi", dt.Columns(1).DataType)

        dt.Columns.Add(dc)

        For Each dr As DataRow In dt.Rows
            For Each cls As clsKimlik In Module1.UserViewsKimlik
                If dr(10).ToString = cls.KimlikID.ToString Then
                    dr(15) = cls.KimlikName
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub Fill(ByVal sender As Object, ByVal e As EventArgs)
        Me.dgv.DataSource = Nothing

        Dim dt As DataTable = New DataTable
        dt = CType(db.RunQuery(myDbOperations.QueryType.Select, "SELECT * FROM tblMusteriler WHERE " & Module1.Kimlik.KimlikViewUSerQuery), DataTable)

        dt.Columns(0).ColumnName = "Müþteri ID"
        dt.Columns(1).ColumnName = "Müþteri Adý"
        dt.Columns(2).ColumnName = "Müþteri Soyadý"
        dt.Columns(3).ColumnName = "Müþteri Tel No"
        dt.Columns(4).ColumnName = "Teslim Alýnan Tarih"
        dt.Columns(5).ColumnName = "Seri No"
        dt.Columns(6).ColumnName = "Cihaz Tipi"
        dt.Columns(7).ColumnName = "Aksesuar"
        dt.Columns(8).ColumnName = "Arýza Türü"
        dt.Columns(9).ColumnName = "Cihaz Durumu"
        dt.Columns(10).ColumnName = "Sorumlu"
        dt.Columns(11).ColumnName = "Iade Tarihi"
        dt.Columns(12).ColumnName = "Iade Durumu"
        dt.Columns(13).ColumnName = "Ücret"
        dt.Columns(14).ColumnName = "Açýklama"

        Me.dgv.DataSource = dt
        'Me.dgv.Columns(0).Visible = False
        Me.dgv.Columns(10).Visible = False

        InformationLabels()

        Me.lstDates.Items.Clear()

        Dim dt2 As DataTable = New DataTable
        dt2 = CType(db.RunQuery(myDbOperations.QueryType.Select, "SELECT DISTINCT tblMusteriler.musTarihSaat FROM tblMusteriler WHERE " & Module1.Kimlik.KimlikViewUSerQuery), DataTable)

        For Each dr As DataRow In dt2.Rows
            Dim itm As ListViewItem = New ListViewItem
            itm.Text = CType(dr(0).ToString, Date).ToShortDateString
            itm.ImageIndex = 4
            Me.lstDates.Items.Add(itm)
        Next

        ChangeKimlikID()

        Me.tssDates.Text = "Toplam : " & Me.lstDates.Items.Count.ToString
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        lgnForm.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblKimlik.Text = "Kullanýcý" & vbCrLf & Module1.Kimlik.KimlikName.ToString
        Fill(sender, e)
        Me.lstDates.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Me.trvUsers.Nodes.Clear()
    End Sub

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        Dim frm As frmAddNew = New frmAddNew
        AddHandler frm.MeClose, AddressOf Fill
        frm.Show()
    End Sub

    Private Sub mnuAddToDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAddToDetails.Click, SeçiliSipariþiEkleToolStripMenuItem.Click

        If Not Me.dgv.CurrentCellAddress.X = -1 AndAlso Not Me.dgv.CurrentCellAddress.Y = -1 Then
            Dim dr As DataGridViewRow = Me.dgv.CurrentRow

            Dim clsSip As clsSiparis = New clsSiparis(dr, Module1.Kimlik)

            Me.trvUsers.Nodes.Add(clsSip.DoTreeNode(dr, Module1.Kimlik))
        End If
    End Sub

    Private Sub lstDates_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDates.SelectedIndexChanged
        '
        Me.dgv.DataSource = Nothing
        Dim dt As DataTable = New DataTable
        Dim itm As Date = CDate(Me.lstDates.FocusedItem.Text)

        dt = db.RunQuery(myDbOperations.QueryType.Select, "SELECT * FROM tblMusteriler WHERE tblMusteriler.musTarihSaat=#" & itm.Month.ToString & "/" & itm.Day.ToString & "/" & itm.Year.ToString & "# AND " & Module1.Kimlik.KimlikViewUSerQuery)

        dt.Columns(0).ColumnName = "Müþteri ID"
        dt.Columns(1).ColumnName = "Müþteri Adý"
        dt.Columns(2).ColumnName = "Müþteri Soyadý"
        dt.Columns(3).ColumnName = "Müþteri Tel No"
        dt.Columns(4).ColumnName = "Teslim Alýnan Tarih"
        dt.Columns(5).ColumnName = "Seri No"
        dt.Columns(6).ColumnName = "Cihaz Tipi"
        dt.Columns(7).ColumnName = "Aksesuar"
        dt.Columns(8).ColumnName = "Arýza Türü"
        dt.Columns(9).ColumnName = "Cihaz Durumu"
        dt.Columns(10).ColumnName = "Sorumlu"
        dt.Columns(11).ColumnName = "Iade Tarihi"
        dt.Columns(12).ColumnName = "Iade Durumu"
        dt.Columns(13).ColumnName = "Ücret"
        dt.Columns(14).ColumnName = "Açýklama"

        Me.dgv.DataSource = dt
        'Me.dgv.Columns(0).Visible = False
        Me.dgv.Columns(10).Visible = False

        InformationLabels()

        ChangeKimlikID()
    End Sub

    Private Sub mnuReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReset.Click
        Fill(sender, e)
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        If Not Me.dgv.CurrentRow.Index = -1 Then
            Dim frm As frmAddNew = New frmAddNew
            frm.FormLoad(False, Me.dgv.CurrentRow)
            AddHandler frm.MeClose, AddressOf Fill
            frm.Show()
        Else
            MessageBox.Show("Seçili bir satýr yada hücre yok!Lütfen tablodan düzeltmek istediðiniz bir satýrý yada o satýrdaki bir hücreyi seçiniz..", "Seçili Satýr Yada Hücre Yok!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub dgv_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.CurrentCellChanged
        Me.tssCellAddress.Text = "Hücre Adresi : " & Me.dgv.CurrentCellAddress.ToString
    End Sub

    Private Sub mnuDelOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelOne.Click
        If Not Me.dgv.CurrentRow.Index = -1 Then
            Dim dr As DataGridViewRow = Me.dgv.CurrentRow

            DialogResult = MessageBox.Show("Müþteri Adý,Soyadý : " & dr.Cells(1).Value.ToString & " " & dr.Cells(2).Value.ToString & _
                        vbCrLf & "Cihaz Tipi : " & dr.Cells(6).Value.ToString & _
                        vbCrLf & "Aksesuar : " & dr.Cells(7).Value.ToString & _
                        vbCrLf & "Arýza Türü : " & dr.Cells(8).Value.ToString & _
                        vbCrLf & "Cihaz Durumu : " & dr.Cells(9).Value.ToString & _
                        vbCrLf & "Sorumlu : " & dr.Cells(10).Value.ToString & _
                        vbCrLf & vbCrLf & "Bilgilerini içeren kayýt silinsin mi?", "Kayýt Sil", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If DialogResult = Windows.Forms.DialogResult.Yes Then
                db.Delete(New myDbOperations.Parameters("musID", dr.Cells(0).Value.ToString, myDbOperations.OLEVariableTypes.Number))

                Fill(sender, e)
            End If
        End If
    End Sub

    Private Sub mnuDelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelAll.Click
        DialogResult = MessageBox.Show("Tüm Kayýtlar Silinsin Mi?", "Tüm Kayýtlarý Sil", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If DialogResult = Windows.Forms.DialogResult.Yes Then
            db.Delete()

            Fill(sender, e)
        End If
    End Sub

    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        Dim frm As frmFind = New frmFind
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim dt As DataTable = New DataTable
            dt = CType(db.RunQuery(myDbOperations.QueryType.Select, frm.Tag.ToString), DataTable)
            Me.dgv.DataSource = Nothing
            Me.dgv.DataSource = dt
            'Me.dgv.Columns(0).Visible = False
            'Me.dgv.Columns(10).Visible = False

            InformationLabels()

            ChangeKimlikID()
        End If
    End Sub

    Private Sub mnuCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCalculator.Click
        Shell("calc.exe", AppWinStyle.NormalFocus)
    End Sub


    Private Sub SeçiliSipariþiSilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeçiliSipariþiSilToolStripMenuItem.Click
        If Not Me.trvUsers.SelectedNode Is Nothing Then
            Me.trvUsers.Nodes.Remove(Me.trvUsers.SelectedNode)
        End If
    End Sub

    Private Sub TümSipariþleriSilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TümSipariþleriSilToolStripMenuItem.Click
        DialogResult = MessageBox.Show("Tüm kayýtlar listeden silinsin mi?", "Tüm Kayýtlarý Listeden Kaldýr", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If DialogResult = Windows.Forms.DialogResult.Yes Then
            Me.trvUsers.Nodes.Clear()
        End If
    End Sub

    Private Sub SipariþleriYazdýrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SipariþleriYazdýrToolStripMenuItem.Click
        If Not Me.trvUsers.Nodes.Count = 0 Then

            Dim fbd As FolderBrowserDialog = New FolderBrowserDialog
            fbd.SelectedPath = My.Computer.FileSystem.SpecialDirectories.Desktop

            If fbd.ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim destPath As String = fbd.SelectedPath & "\"

                For Each itm As TreeNode In Me.trvUsers.Nodes
                    'Þablon dosya bilgisi.
                    Dim file As System.IO.FileInfo = New System.IO.FileInfo(Application.StartupPath & "\" & "form.htm")

                    'Þablon dosya içeriði okunur...
                    Dim strHtml As String = New System.IO.StreamReader(file.FullName, System.Text.Encoding.GetEncoding("ISO-8859-9")).ReadToEnd

                    If Not System.IO.Directory.Exists(destPath & "form_dosyalar") = True Then
                        Dim sourceDir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(Application.StartupPath & "\" & "form_dosyalar")

                        System.IO.Directory.CreateDirectory(destPath & "form_dosyalar")

                        For Each f As System.IO.FileInfo In sourceDir.GetFiles
                            f.CopyTo(destPath & "form_dosyalar" & "\" & f.Name)
                        Next
                    End If

                    Dim newFilePath As String = destPath & itm.Tag.ToString & "-" & itm.Text & ".htm"

                    strHtml = strHtml.Replace("[musID]", itm.Tag.ToString)
                    strHtml = strHtml.Replace("[musAdiSoyadi]", itm.Text)

                    'child lardan gelen deðerler Replace edilecek..
                    For Each itm2 As TreeNode In itm.Nodes
                        If itm2.Text.Trim.Length = 0 Then
                            strHtml = strHtml.Replace(itm2.Tag.ToString, " ")
                        Else
                            strHtml = strHtml.Replace(itm2.Tag.ToString, itm2.Text)
                        End If
                    Next

                    'If System.IO.File.Exists(newFilePath) = True Then System.IO.File.Delete(newFilePath)

                    IO.File.WriteAllText(newFilePath, strHtml, System.Text.Encoding.GetEncoding("ISO-8859-9"))

                    Dim file2 As System.IO.FileInfo = New System.IO.FileInfo(newFilePath)
                    file2.IsReadOnly = False
                Next

            End If
        Else
            MessageBox.Show("Listede yazdýrýlacak kayýt yok !", "Kayýt Yok!", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub mnuChangeUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChangeUser.Click
        lgnForm.Visible = True
        lgnForm.txtUserName.Text = ""
        lgnForm.txtPassword.Text = ""

        Me.Dispose()
    End Sub
End Class
