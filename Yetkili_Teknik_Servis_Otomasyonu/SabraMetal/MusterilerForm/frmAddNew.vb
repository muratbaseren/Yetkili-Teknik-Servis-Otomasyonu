Public Class frmAddNew

    Private db As myDbOperations.OLEDB = New myDbOperations.OLEDB(Application.StartupPath & "\" & "dbMus.mdb", "tblMusteriler")

    Public Event MeClose(ByVal sender As Object, ByVal e As EventArgs)

    Private Function OnErr() As Boolean
        OnErr = False

        If Me.txtMusteriAdi.Text.Trim.Length = 0 Then
            Me.err.SetError(Me.txtMusteriAdi, "Bu Alan Boþ Býrakýlamaz...")
            OnErr = True
        Else
            Me.err.SetError(Me.txtMusteriAdi, "")
        End If

        If Me.txtMusteriSoyad.Text.Trim.Length = 0 Then
            Me.err.SetError(Me.txtMusteriSoyad, "Bu Alan Boþ Býrakýlamaz...")
            OnErr = True
        Else
            Me.err.SetError(Me.txtMusteriSoyad, "")
        End If

        Return OnErr
    End Function

    Private Sub Ekle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEkle.Click
        Dim ColsVals As ArrayList

        If OnErr() = True Then Exit Sub

        ColsVals = New ArrayList

        ColsVals.Add(New myDbOperations.Parameters("musAdi", Me.txtMusteriAdi.Text, myDbOperations.OLEVariableTypes.Text))
        ColsVals.Add(New myDbOperations.Parameters("musSoyadi", Me.txtMusteriSoyad.Text, myDbOperations.OLEVariableTypes.Text))
        ColsVals.Add(New myDbOperations.Parameters("musTelNo", Me.txtMusteriTelNo.Text, myDbOperations.OLEVariableTypes.Text))
        ColsVals.Add(New myDbOperations.Parameters("musTarihSaat", Me.dtpTarih.Value.ToShortDateString, myDbOperations.OLEVariableTypes.DateTime))
        ColsVals.Add(New myDbOperations.Parameters("musSeriNo", Me.txtSeriNo.Text, myDbOperations.OLEVariableTypes.Text))
        ColsVals.Add(New myDbOperations.Parameters("musCihazTipi", Me.cmbCihazTipi.Text, myDbOperations.OLEVariableTypes.Text))
        ColsVals.Add(New myDbOperations.Parameters("musAksesuar", Me.cmbAksesuar.Text, myDbOperations.OLEVariableTypes.Text))
        ColsVals.Add(New myDbOperations.Parameters("musArizaTuru", Me.cmbArizaTuru.Text, myDbOperations.OLEVariableTypes.Text))
        ColsVals.Add(New myDbOperations.Parameters("musCihazDurumu", Me.cmbCihazDurumu.Text, myDbOperations.OLEVariableTypes.Text))
        ColsVals.Add(New myDbOperations.Parameters("musSorumlu", Module1.Kimlik.KimlikID.ToString, myDbOperations.OLEVariableTypes.Number))
        ColsVals.Add(New myDbOperations.Parameters("musIadeTarihi", Me.dtpIadeTarih.Value.ToShortDateString, myDbOperations.OLEVariableTypes.DateTime))
        ColsVals.Add(New myDbOperations.Parameters("musIadeDurumu", Me.cmbIadeDurumu.Text, myDbOperations.OLEVariableTypes.Text))
        ColsVals.Add(New myDbOperations.Parameters("musUcret", Me.txtUcret.Text, myDbOperations.OLEVariableTypes.Text))
        ColsVals.Add(New myDbOperations.Parameters("musAciklama", Me.txtAciklama.Text, myDbOperations.OLEVariableTypes.Text))

        If Me.btnEkle.Text = "Ekl&e" Then

            db.Insert(ColsVals)

            MessageBox.Show("Kayýt Eklenmiþtir.")
            Me.Close()

        ElseIf Me.btnEkle.Text = "Düzelt" Then

            If db.Update(New myDbOperations.Parameters("musID", Me.txtMusteriID.Text, myDbOperations.OLEVariableTypes.Number), ColsVals) = 1 Then
                MessageBox.Show("Kayýt Düzeltilmiþtir..", "Kayýt Düzeltildi..", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show("Kayýt Düzeltilememiþtir..", "Kayýt Düzeltilemedi..", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FillCombobox(ByVal ControlCollection As System.Windows.Forms.Control.ControlCollection)

        Dim Query As String = ""

        For Each ctrl As Control In ControlCollection
            If TypeOf ctrl Is ComboBox Then
                Dim cmb As ComboBox = CType(ctrl, ComboBox)
                cmb.Items.Clear()

                Query = "SELECT DISTINCT tblMusteriler." & cmb.Tag.ToString & " FROM tblMusteriler " & " WHERE " & Module1.Kimlik.KimlikViewUSerQuery

                Dim dt As DataTable = New DataTable
                dt = db.RunQuery(myDbOperations.QueryType.Select, Query)

                If Not dt.Rows.Count = 0 Then
                    For Each dataR As DataRow In dt.Rows
                        If Not dataR(0).ToString.Trim.Length = 0 Then cmb.Items.Add(dataR(0).ToString)
                    Next
                End If
            End If
        Next
    End Sub

    Public Sub FormLoad(ByVal IsInsertMode As Boolean, ByVal dr As DataGridViewRow)

        If IsInsertMode = False Then
            Me.Text = "Kayýt Düzeltme.."
            Me.lblDown.Text = "Kayýt Düzeltme.."
            Me.lblUp.Text = "Kayýt Düzeltme.."
            Me.txtMusteriID.Visible = True
            Me.lblMusteriID.Visible = True
            Me.btnEkle.Text = "Düzelt"

            Me.txtMusteriID.Text = dr.Cells(0).Value.ToString
            Me.txtMusteriAdi.Text = dr.Cells(1).Value.ToString
            Me.txtMusteriSoyad.Text = dr.Cells(2).Value.ToString
            Me.txtMusteriTelNo.Text = dr.Cells(3).Value.ToString
            Me.dtpTarih.Value = CDate(dr.Cells(4).Value.ToString)
            Me.txtSeriNo.Text = dr.Cells(5).Value.ToString
            Me.cmbCihazTipi.Text = dr.Cells(6).Value.ToString
            Me.cmbAksesuar.Text = dr.Cells(7).Value.ToString
            Me.cmbArizaTuru.Text = dr.Cells(8).Value.ToString
            Me.cmbIadeDurumu.Text = dr.Cells(9).Value.ToString
            Me.txtSorumlu.Text = Module1.Kimlik.KimlikName
            Me.dtpIadeTarih.Value = CDate(dr.Cells(11).Value.ToString)
            Me.cmbCihazDurumu.Text = dr.Cells(12).Value.ToString
            Me.txtUcret.Text = dr.Cells(13).Value.ToString
            Me.txtAciklama.Text = dr.Cells(14).Value.ToString
        End If
    End Sub

    Private Sub frmAddNew_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        RaiseEvent MeClose(sender, e)
    End Sub

    Private Sub frmAddNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtSorumlu.Text = Module1.Kimlik.KimlikName
        'Me.txtUcret.Text = "00000.00 YTL"

        Me.FillCombobox(Me.grpCihazDurumu.Controls)
        Me.FillCombobox(Me.grpCihazDetaylari.Controls)
    End Sub
End Class