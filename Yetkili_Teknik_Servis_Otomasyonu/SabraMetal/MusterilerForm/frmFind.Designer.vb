<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFind))
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblDown = New System.Windows.Forms.Label
        Me.lblUp = New System.Windows.Forms.Label
        Me.grp = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rdbAciklama = New System.Windows.Forms.RadioButton
        Me.rdbUcret = New System.Windows.Forms.RadioButton
        Me.rdbIadeDurumu = New System.Windows.Forms.RadioButton
        Me.rdbIadeTarihi = New System.Windows.Forms.RadioButton
        Me.rdbSorumlu = New System.Windows.Forms.RadioButton
        Me.rdbCihazDurumu = New System.Windows.Forms.RadioButton
        Me.rdbArizaTuru = New System.Windows.Forms.RadioButton
        Me.rdbAksesuar = New System.Windows.Forms.RadioButton
        Me.rdbCihazTipi = New System.Windows.Forms.RadioButton
        Me.rdbSeriNo = New System.Windows.Forms.RadioButton
        Me.rdbTeslimTarihi = New System.Windows.Forms.RadioButton
        Me.rdbMusteriTelNo = New System.Windows.Forms.RadioButton
        Me.rdbMusteriSoyadi = New System.Windows.Forms.RadioButton
        Me.rdbMusteriAdi = New System.Windows.Forms.RadioButton
        Me.rdbMusteriID = New System.Windows.Forms.RadioButton
        Me.btnAra = New System.Windows.Forms.Button
        Me.Panel = New System.Windows.Forms.Panel
        Me.lblFindText = New System.Windows.Forms.Label
        Me.grp.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(12, 319)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Ýptal"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblDown
        '
        Me.lblDown.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDown.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDown.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblDown.ForeColor = System.Drawing.Color.White
        Me.lblDown.Location = New System.Drawing.Point(0, 310)
        Me.lblDown.Name = "lblDown"
        Me.lblDown.Size = New System.Drawing.Size(275, 39)
        Me.lblDown.TabIndex = 11
        Me.lblDown.Text = "Kayýt Ara !"
        Me.lblDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUp
        '
        Me.lblUp.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblUp.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblUp.ForeColor = System.Drawing.Color.White
        Me.lblUp.Location = New System.Drawing.Point(0, 0)
        Me.lblUp.Name = "lblUp"
        Me.lblUp.Size = New System.Drawing.Size(275, 39)
        Me.lblUp.TabIndex = 9
        Me.lblUp.Text = "Kayýt Ara !"
        Me.lblUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grp
        '
        Me.grp.Controls.Add(Me.Panel1)
        Me.grp.Location = New System.Drawing.Point(12, 52)
        Me.grp.Name = "grp"
        Me.grp.Padding = New System.Windows.Forms.Padding(15)
        Me.grp.Size = New System.Drawing.Size(251, 148)
        Me.grp.TabIndex = 12
        Me.grp.TabStop = False
        Me.grp.Text = "Arama Türü"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.rdbAciklama)
        Me.Panel1.Controls.Add(Me.rdbUcret)
        Me.Panel1.Controls.Add(Me.rdbIadeDurumu)
        Me.Panel1.Controls.Add(Me.rdbIadeTarihi)
        Me.Panel1.Controls.Add(Me.rdbSorumlu)
        Me.Panel1.Controls.Add(Me.rdbCihazDurumu)
        Me.Panel1.Controls.Add(Me.rdbArizaTuru)
        Me.Panel1.Controls.Add(Me.rdbAksesuar)
        Me.Panel1.Controls.Add(Me.rdbCihazTipi)
        Me.Panel1.Controls.Add(Me.rdbSeriNo)
        Me.Panel1.Controls.Add(Me.rdbTeslimTarihi)
        Me.Panel1.Controls.Add(Me.rdbMusteriTelNo)
        Me.Panel1.Controls.Add(Me.rdbMusteriSoyadi)
        Me.Panel1.Controls.Add(Me.rdbMusteriAdi)
        Me.Panel1.Controls.Add(Me.rdbMusteriID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(15, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(221, 105)
        Me.Panel1.TabIndex = 0
        '
        'rdbAciklama
        '
        Me.rdbAciklama.AutoSize = True
        Me.rdbAciklama.Location = New System.Drawing.Point(3, 325)
        Me.rdbAciklama.Name = "rdbAciklama"
        Me.rdbAciklama.Size = New System.Drawing.Size(93, 17)
        Me.rdbAciklama.TabIndex = 14
        Me.rdbAciklama.TabStop = True
        Me.rdbAciklama.Tag = "musAciklama"
        Me.rdbAciklama.Text = "Açýklama Ara !"
        Me.rdbAciklama.UseVisualStyleBackColor = True
        '
        'rdbUcret
        '
        Me.rdbUcret.AutoSize = True
        Me.rdbUcret.Location = New System.Drawing.Point(3, 302)
        Me.rdbUcret.Name = "rdbUcret"
        Me.rdbUcret.Size = New System.Drawing.Size(76, 17)
        Me.rdbUcret.TabIndex = 13
        Me.rdbUcret.TabStop = True
        Me.rdbUcret.Tag = "musUcret"
        Me.rdbUcret.Text = "Ücret Ara !"
        Me.rdbUcret.UseVisualStyleBackColor = True
        '
        'rdbIadeDurumu
        '
        Me.rdbIadeDurumu.AutoSize = True
        Me.rdbIadeDurumu.Location = New System.Drawing.Point(3, 279)
        Me.rdbIadeDurumu.Name = "rdbIadeDurumu"
        Me.rdbIadeDurumu.Size = New System.Drawing.Size(111, 17)
        Me.rdbIadeDurumu.TabIndex = 12
        Me.rdbIadeDurumu.TabStop = True
        Me.rdbIadeDurumu.Tag = "musIadeDurumu"
        Me.rdbIadeDurumu.Text = "Iade Durumu Ara !"
        Me.rdbIadeDurumu.UseVisualStyleBackColor = True
        '
        'rdbIadeTarihi
        '
        Me.rdbIadeTarihi.AutoSize = True
        Me.rdbIadeTarihi.Location = New System.Drawing.Point(3, 256)
        Me.rdbIadeTarihi.Name = "rdbIadeTarihi"
        Me.rdbIadeTarihi.Size = New System.Drawing.Size(100, 17)
        Me.rdbIadeTarihi.TabIndex = 11
        Me.rdbIadeTarihi.TabStop = True
        Me.rdbIadeTarihi.Tag = "musIadeTarihi"
        Me.rdbIadeTarihi.Text = "Iade Tarihi Ara !"
        Me.rdbIadeTarihi.UseVisualStyleBackColor = True
        '
        'rdbSorumlu
        '
        Me.rdbSorumlu.AutoSize = True
        Me.rdbSorumlu.Location = New System.Drawing.Point(3, 233)
        Me.rdbSorumlu.Name = "rdbSorumlu"
        Me.rdbSorumlu.Size = New System.Drawing.Size(88, 17)
        Me.rdbSorumlu.TabIndex = 10
        Me.rdbSorumlu.TabStop = True
        Me.rdbSorumlu.Tag = "musSorumlu"
        Me.rdbSorumlu.Text = "Sorumlu Ara !"
        Me.rdbSorumlu.UseVisualStyleBackColor = True
        '
        'rdbCihazDurumu
        '
        Me.rdbCihazDurumu.AutoSize = True
        Me.rdbCihazDurumu.Location = New System.Drawing.Point(3, 210)
        Me.rdbCihazDurumu.Name = "rdbCihazDurumu"
        Me.rdbCihazDurumu.Size = New System.Drawing.Size(116, 17)
        Me.rdbCihazDurumu.TabIndex = 9
        Me.rdbCihazDurumu.TabStop = True
        Me.rdbCihazDurumu.Tag = "musCihazDurumu"
        Me.rdbCihazDurumu.Text = "Cihaz Durumu Ara !"
        Me.rdbCihazDurumu.UseVisualStyleBackColor = True
        '
        'rdbArizaTuru
        '
        Me.rdbArizaTuru.AutoSize = True
        Me.rdbArizaTuru.Location = New System.Drawing.Point(3, 187)
        Me.rdbArizaTuru.Name = "rdbArizaTuru"
        Me.rdbArizaTuru.Size = New System.Drawing.Size(98, 17)
        Me.rdbArizaTuru.TabIndex = 8
        Me.rdbArizaTuru.TabStop = True
        Me.rdbArizaTuru.Tag = "musArizaTuru"
        Me.rdbArizaTuru.Text = "Arýza Türü Ara !"
        Me.rdbArizaTuru.UseVisualStyleBackColor = True
        '
        'rdbAksesuar
        '
        Me.rdbAksesuar.AutoSize = True
        Me.rdbAksesuar.Location = New System.Drawing.Point(3, 164)
        Me.rdbAksesuar.Name = "rdbAksesuar"
        Me.rdbAksesuar.Size = New System.Drawing.Size(94, 17)
        Me.rdbAksesuar.TabIndex = 7
        Me.rdbAksesuar.TabStop = True
        Me.rdbAksesuar.Tag = "musAksesuar"
        Me.rdbAksesuar.Text = "Aksesuar Ara !"
        Me.rdbAksesuar.UseVisualStyleBackColor = True
        '
        'rdbCihazTipi
        '
        Me.rdbCihazTipi.AutoSize = True
        Me.rdbCihazTipi.Location = New System.Drawing.Point(3, 141)
        Me.rdbCihazTipi.Name = "rdbCihazTipi"
        Me.rdbCihazTipi.Size = New System.Drawing.Size(96, 17)
        Me.rdbCihazTipi.TabIndex = 6
        Me.rdbCihazTipi.TabStop = True
        Me.rdbCihazTipi.Tag = "musCihazTipi"
        Me.rdbCihazTipi.Text = "Cihaz Tipi Ara !"
        Me.rdbCihazTipi.UseVisualStyleBackColor = True
        '
        'rdbSeriNo
        '
        Me.rdbSeriNo.AutoSize = True
        Me.rdbSeriNo.Location = New System.Drawing.Point(3, 118)
        Me.rdbSeriNo.Name = "rdbSeriNo"
        Me.rdbSeriNo.Size = New System.Drawing.Size(85, 17)
        Me.rdbSeriNo.TabIndex = 5
        Me.rdbSeriNo.TabStop = True
        Me.rdbSeriNo.Tag = "musSeriNo"
        Me.rdbSeriNo.Text = "Seri No Ara !"
        Me.rdbSeriNo.UseVisualStyleBackColor = True
        '
        'rdbTeslimTarihi
        '
        Me.rdbTeslimTarihi.AutoSize = True
        Me.rdbTeslimTarihi.Location = New System.Drawing.Point(3, 95)
        Me.rdbTeslimTarihi.Name = "rdbTeslimTarihi"
        Me.rdbTeslimTarihi.Size = New System.Drawing.Size(135, 17)
        Me.rdbTeslimTarihi.TabIndex = 4
        Me.rdbTeslimTarihi.TabStop = True
        Me.rdbTeslimTarihi.Tag = "musTarihSaat"
        Me.rdbTeslimTarihi.Text = "Teslim Alma Tarihi Ara !"
        Me.rdbTeslimTarihi.UseVisualStyleBackColor = True
        '
        'rdbMusteriTelNo
        '
        Me.rdbMusteriTelNo.AutoSize = True
        Me.rdbMusteriTelNo.Location = New System.Drawing.Point(3, 72)
        Me.rdbMusteriTelNo.Name = "rdbMusteriTelNo"
        Me.rdbMusteriTelNo.Size = New System.Drawing.Size(119, 17)
        Me.rdbMusteriTelNo.TabIndex = 3
        Me.rdbMusteriTelNo.TabStop = True
        Me.rdbMusteriTelNo.Tag = "musTelNo"
        Me.rdbMusteriTelNo.Text = "Müþteri Tel No Ara !"
        Me.rdbMusteriTelNo.UseVisualStyleBackColor = True
        '
        'rdbMusteriSoyadi
        '
        Me.rdbMusteriSoyadi.AutoSize = True
        Me.rdbMusteriSoyadi.Location = New System.Drawing.Point(3, 49)
        Me.rdbMusteriSoyadi.Name = "rdbMusteriSoyadi"
        Me.rdbMusteriSoyadi.Size = New System.Drawing.Size(119, 17)
        Me.rdbMusteriSoyadi.TabIndex = 2
        Me.rdbMusteriSoyadi.TabStop = True
        Me.rdbMusteriSoyadi.Tag = "musSoyadi"
        Me.rdbMusteriSoyadi.Text = "Müþteri Soyadý Ara !"
        Me.rdbMusteriSoyadi.UseVisualStyleBackColor = True
        '
        'rdbMusteriAdi
        '
        Me.rdbMusteriAdi.AutoSize = True
        Me.rdbMusteriAdi.Location = New System.Drawing.Point(3, 26)
        Me.rdbMusteriAdi.Name = "rdbMusteriAdi"
        Me.rdbMusteriAdi.Size = New System.Drawing.Size(102, 17)
        Me.rdbMusteriAdi.TabIndex = 1
        Me.rdbMusteriAdi.TabStop = True
        Me.rdbMusteriAdi.Tag = "musAdi"
        Me.rdbMusteriAdi.Text = "Müþteri Adý Ara !"
        Me.rdbMusteriAdi.UseVisualStyleBackColor = True
        '
        'rdbMusteriID
        '
        Me.rdbMusteriID.AutoSize = True
        Me.rdbMusteriID.Location = New System.Drawing.Point(3, 3)
        Me.rdbMusteriID.Name = "rdbMusteriID"
        Me.rdbMusteriID.Size = New System.Drawing.Size(98, 17)
        Me.rdbMusteriID.TabIndex = 0
        Me.rdbMusteriID.TabStop = True
        Me.rdbMusteriID.Tag = "musID"
        Me.rdbMusteriID.Text = "Müþteri ID Ara !"
        Me.rdbMusteriID.UseVisualStyleBackColor = True
        '
        'btnAra
        '
        Me.btnAra.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAra.Location = New System.Drawing.Point(93, 319)
        Me.btnAra.Name = "btnAra"
        Me.btnAra.Size = New System.Drawing.Size(75, 23)
        Me.btnAra.TabIndex = 1
        Me.btnAra.Text = "Ara !"
        Me.btnAra.UseVisualStyleBackColor = True
        '
        'Panel
        '
        Me.Panel.Location = New System.Drawing.Point(12, 245)
        Me.Panel.Name = "Panel"
        Me.Panel.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel.Size = New System.Drawing.Size(251, 56)
        Me.Panel.TabIndex = 0
        '
        'lblFindText
        '
        Me.lblFindText.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblFindText.Location = New System.Drawing.Point(12, 207)
        Me.lblFindText.Name = "lblFindText"
        Me.lblFindText.Size = New System.Drawing.Size(251, 35)
        Me.lblFindText.TabIndex = 0
        Me.lblFindText.Text = "FindText"
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 349)
        Me.Controls.Add(Me.lblFindText)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.btnAra)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblDown)
        Me.Controls.Add(Me.lblUp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kayýt Ara !"
        Me.grp.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblDown As System.Windows.Forms.Label
    Friend WithEvents lblUp As System.Windows.Forms.Label
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents btnAra As System.Windows.Forms.Button
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents lblFindText As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdbCihazDurumu As System.Windows.Forms.RadioButton
    Friend WithEvents rdbArizaTuru As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAksesuar As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCihazTipi As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSeriNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTeslimTarihi As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMusteriTelNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMusteriSoyadi As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMusteriAdi As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMusteriID As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAciklama As System.Windows.Forms.RadioButton
    Friend WithEvents rdbUcret As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIadeDurumu As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIadeTarihi As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSorumlu As System.Windows.Forms.RadioButton
End Class
