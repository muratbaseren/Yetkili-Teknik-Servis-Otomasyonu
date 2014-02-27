Public Class frmFind

    Private db As myDbOperations.OLEDB = New myDbOperations.OLEDB(Application.StartupPath & "\" & "dbMus.mdb", "tblMusteriler")

    Private Function DoCombobox(ByVal Query As String) As ComboBox
        DoCombobox = New ComboBox
        Dim dt As DataTable = New DataTable

        dt = CType(db.RunQuery(myDbOperations.QueryType.Select, Query), DataTable)

        For Each dr As DataRow In dt.Rows
            DoCombobox.Items.Add(dr(0).ToString)
        Next

        DoCombobox.SelectedIndex = 0

        Return DoCombobox
    End Function

    Private Sub RadioButons_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAciklama.Click, rdbAksesuar.Click, rdbArizaTuru.Click, rdbCihazDurumu.Click, rdbCihazTipi.Click, rdbIadeDurumu.Click, rdbIadeTarihi.Click, rdbMusteriAdi.Click, rdbMusteriID.Click, rdbMusteriSoyadi.Click, rdbMusteriTelNo.Click, rdbSeriNo.Click, rdbSorumlu.Click, rdbTeslimTarihi.Click, rdbUcret.Click

        Me.Panel.Controls.Clear()

        Dim rdb As RadioButton = CType(sender, RadioButton)
        Dim txt As TextBox
        Dim ctrl As Control
        Dim where As String = Module1.Kimlik.KimlikViewUSerQuery

        Select Case rdb.Name
            Case "rdbMusteriID", "rdbMusteriAdi", "rdbMusteriSoyadi", "rdbMusteriTelNo", "rdbCihazDurumu", "rdbArizaTuru", "rdbCihazTipi", "rdbIadeDurumu", "rdbSeriNo"
                ctrl = DoCombobox("SELECT DISTINCT tblMusteriler." & rdb.Tag.ToString & " FROM tblMusteriler " & " WHERE " & where)
                ctrl.Dock = DockStyle.Top
                ctrl.Tag = "SELECT tblMusteriler.* FROM tblMusteriler WHERE " & rdb.Tag.ToString & "='[Kriter]'" & " AND " & where
            Case "rdbUcret"
                ctrl = New MaskedTextBox("00000.00 $")
                ctrl.Dock = DockStyle.Top
                ctrl.Tag = "SELECT tblMusteriler.* FROM tblMusteriler WHERE " & rdb.Tag.ToString & "='[Kriter]'" & " AND " & where
            Case "rdbAciklama", "rdbAksesuar"
                ctrl = New TextBox
                ctrl.Dock = DockStyle.Top
                ctrl.Tag = "SELECT  tblMusteriler.* FROM tblMusteriler WHERE " & rdb.Tag.ToString & "='[Kriter]'" & " AND " & where
            Case "rdbTeslimTarihi", "rdbIadeTarihi"
                ctrl = New DateTimePicker
                ctrl.Dock = DockStyle.Top
                ctrl.Tag = "SELECT tblMusteriler.* FROM tblMusteriler WHERE " & rdb.Tag.ToString & "=#[Kriter]#" & " AND " & where
            Case "rdbSorumlu"
                ctrl = New ComboBox
                ctrl.Name = "Sorumlu"

                For Each cls As clsKimlik In Module1.UserViewsKimlik
                    CType(ctrl, ComboBox).Items.Add(cls)
                Next

                ctrl.Dock = DockStyle.Top
                ctrl.Tag = "SELECT tblMusteriler.* FROM tblMusteriler WHERE " & rdb.Tag.ToString & "=[Kriter]" & " AND " & where
        End Select

        If Not TypeOf ctrl Is DateTimePicker Then
            Me.Panel.Controls.Add(ctrl)

            Me.lblFindText.Text = CType(sender, RadioButton).Text
        ElseIf TypeOf ctrl Is DateTimePicker Then
            Me.Panel.Controls.Add(ctrl)

            Dim ctrl2 As Control
            ctrl2 = New DateTimePicker
            ctrl2.Dock = DockStyle.Bottom
            ctrl2.Tag = "SELECT tblMusteriler.* FROM tblMusteriler WHERE " & ctrl.Tag.ToString & ">=#[Kriter1]# AND " & ctrl.Tag.ToString & "<=#[Kriter2]#" & " AND " & where

            Me.Panel.Controls.Add(ctrl2)

            Me.lblFindText.Text = CType(sender, RadioButton).Text & " - (Baþlangýç Ve Bitiþ Tarihleri)"

        ElseIf TypeOf ctrl Is MaskedTextBox Then
            Me.Panel.Controls.Add(ctrl)

            Dim ctrl2 As Control
            ctrl2 = New MaskedTextBox("00000.00 $")
            ctrl2.Dock = DockStyle.Bottom
            ctrl2.Tag = "SELECT tblMusteriler.* FROM tblMusteriler WHERE " & ctrl.Tag.ToString & ">='[Kriter1]' AND " & ctrl.Tag.ToString & "<='[Kriter2]'" & " AND " & where

            Me.Panel.Controls.Add(ctrl2)

            Me.lblFindText.Text = CType(sender, RadioButton).Text & " - (Minimum Ve Maksimum Miktarý)"
        End If

    End Sub

    Private Sub frmFind_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lblFindText.Text = ""
    End Sub

    Private Sub btnAra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAra.Click
        Dim ctrl As Control
        Dim cmb As ComboBox
        Dim dtp1 As DateTimePicker
        Dim dtp2 As DateTimePicker
        Dim msk1 As MaskedTextBox
        Dim msk2 As MaskedTextBox
        Dim nud As NumericUpDown

        ctrl = Me.Panel.Controls(0)

        If Me.Panel.Controls.Count = 1 Then
            If TypeOf ctrl Is ComboBox Then
                cmb = CType(ctrl, ComboBox)
                If cmb.Name = "Sorumlu" Then
                    cmb.Tag = cmb.Tag.ToString.Replace("[Kriter]", CInt(CType(cmb.SelectedItem, clsKimlik).KimlikID))
                Else
                    cmb.Tag = cmb.Tag.ToString.Replace("[Kriter]", cmb.Text)
                End If

                ctrl = cmb
            ElseIf TypeOf ctrl Is NumericUpDown Then
                nud = CType(ctrl, NumericUpDown)
                nud.Tag = nud.Tag.ToString.Replace("[Kriter]", nud.Value.ToString)
                ctrl = nud
            End If
        ElseIf TypeOf ctrl Is DateTimePicker Then
            dtp1 = CType(Me.Panel.Controls(0), DateTimePicker)
            dtp2 = CType(Me.Panel.Controls(1), DateTimePicker)

            If dtp1.Value.ToShortDateString = dtp2.Value.ToShortDateString Then
                dtp1.Tag = dtp1.Tag.ToString.Replace("[Kriter]", dtp1.Value.Month.ToString & "/" & dtp1.Value.Day.ToString & "/" & dtp1.Value.Year.ToString)
                ctrl.Tag = dtp1.Tag
            Else
                If dtp1.Value > dtp2.Value Then
                    MessageBox.Show("Baþlangýç Tarihi, Bitiþ Tarihinden sonra olamaz..!" & vbCrLf & "Baþlangýç ile bitiþ tarihi yer deðiþtirilerek(uygun þekilde) arama yapýlacaktýr..", "Tarih Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Dim Hafiza As DateTime = dtp1.Value
                    dtp1.Value = dtp2.Value
                    dtp2.Value = Hafiza
                End If

                dtp2.Tag = dtp2.Tag.ToString.Replace("[Kriter1]", dtp1.Value.Month.ToString & "/" & dtp1.Value.Day.ToString & "/" & dtp1.Value.Year.ToString)
                dtp2.Tag = dtp2.Tag.ToString.Replace("[Kriter2]", dtp2.Value.Month.ToString & "/" & dtp2.Value.Day.ToString & "/" & dtp2.Value.Year.ToString)
                ctrl.Tag = dtp2.Tag
            End If

        ElseIf TypeOf ctrl Is MaskedTextBox Then
            msk1 = CType(Me.Panel.Controls(0), MaskedTextBox)
            msk2 = CType(Me.Panel.Controls(1), MaskedTextBox)

            If Not CType(msk1.Text.Remove(msk1.Text.Length - 4, 4), Single) > CType(msk2.Text.Remove(msk2.Text.Length - 4, 4), Single) Then
                If msk1.Text = msk2.Text Then
                    msk1.Tag = msk1.Tag.ToString.Replace("[Kriter]", msk1.Text)
                    ctrl.Tag = msk1.Tag
                Else
                    msk2.Tag = msk2.Tag.ToString.Replace("[Kriter1]", msk1.Text)
                    msk2.Tag = msk2.Tag.ToString.Replace("[Kriter2]", msk2.Text)
                    ctrl.Tag = msk2.Tag
                End If
            Else
                MessageBox.Show("Minimum deðer, maksimum deðerden büyük olamaz..", "Hatalý Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

                frmFind_Load(sender, e)
            End If
        End If

        Me.Tag = ctrl.Tag
    End Sub
End Class

Public Enum DBColumns
    [SiparisID] = 0
    [MusteriAdi] = 1
    [Siparis] = 2
    [SiparisAdedi] = 3
    [SiparisDurumu] = 4
    [SiparisTarihi] = 5
    [SiparisNot] = 6
End Enum