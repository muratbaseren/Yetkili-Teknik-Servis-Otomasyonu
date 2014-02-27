<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNew
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddNew))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMusteriAdi = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMusteriSoyad = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblUp = New System.Windows.Forms.Label
        Me.btnEkle = New System.Windows.Forms.Button
        Me.lblDown = New System.Windows.Forms.Label
        Me.lblMusteriID = New System.Windows.Forms.Label
        Me.txtMusteriID = New System.Windows.Forms.TextBox
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtMusteriTelNo = New System.Windows.Forms.MaskedTextBox
        Me.dtpTarih = New System.Windows.Forms.DateTimePicker
        Me.grpCihazDetaylari = New System.Windows.Forms.GroupBox
        Me.cmbArizaTuru = New System.Windows.Forms.ComboBox
        Me.cmbCihazDurumu = New System.Windows.Forms.ComboBox
        Me.cmbAksesuar = New System.Windows.Forms.ComboBox
        Me.cmbCihazTipi = New System.Windows.Forms.ComboBox
        Me.txtSeriNo = New System.Windows.Forms.TextBox
        Me.grpCihazDurumu = New System.Windows.Forms.GroupBox
        Me.cmbIadeDurumu = New System.Windows.Forms.ComboBox
        Me.dtpIadeTarih = New System.Windows.Forms.DateTimePicker
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtUcret = New System.Windows.Forms.MaskedTextBox
        Me.txtAciklama = New System.Windows.Forms.TextBox
        Me.txtSorumlu = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpCihazDetaylari.SuspendLayout()
        Me.grpCihazDurumu.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Müþteri Adý :"
        '
        'txtMusteriAdi
        '
        Me.txtMusteriAdi.Location = New System.Drawing.Point(130, 55)
        Me.txtMusteriAdi.MaxLength = 20
        Me.txtMusteriAdi.Name = "txtMusteriAdi"
        Me.txtMusteriAdi.Size = New System.Drawing.Size(200, 20)
        Me.txtMusteriAdi.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Müþteri Soyad :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Müþteri Tel No :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Teslim Alma Tarih : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Iade Tarihi :"
        '
        'txtMusteriSoyad
        '
        Me.txtMusteriSoyad.Location = New System.Drawing.Point(130, 81)
        Me.txtMusteriSoyad.MaxLength = 30
        Me.txtMusteriSoyad.Name = "txtMusteriSoyad"
        Me.txtMusteriSoyad.Size = New System.Drawing.Size(200, 20)
        Me.txtMusteriSoyad.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(12, 368)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Kapat"
        Me.btnCancel.UseVisualStyleBackColor = True
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
        Me.lblUp.Size = New System.Drawing.Size(747, 39)
        Me.lblUp.TabIndex = 0
        Me.lblUp.Text = "Yeni Kayýt Ekleme..."
        Me.lblUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEkle
        '
        Me.btnEkle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEkle.Location = New System.Drawing.Point(669, 329)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(75, 23)
        Me.btnEkle.TabIndex = 0
        Me.btnEkle.Text = "Ekl&e"
        Me.btnEkle.UseVisualStyleBackColor = True
        '
        'lblDown
        '
        Me.lblDown.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDown.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDown.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblDown.ForeColor = System.Drawing.Color.White
        Me.lblDown.Location = New System.Drawing.Point(0, 359)
        Me.lblDown.Name = "lblDown"
        Me.lblDown.Size = New System.Drawing.Size(747, 39)
        Me.lblDown.TabIndex = 8
        Me.lblDown.Text = "Yeni Kayýt Ekleme..."
        Me.lblDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMusteriID
        '
        Me.lblMusteriID.AutoSize = True
        Me.lblMusteriID.Font = New System.Drawing.Font("Times New Roman", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMusteriID.Location = New System.Drawing.Point(6, 31)
        Me.lblMusteriID.Name = "lblMusteriID"
        Me.lblMusteriID.Size = New System.Drawing.Size(75, 16)
        Me.lblMusteriID.TabIndex = 0
        Me.lblMusteriID.Text = "Müþteri ID :"
        Me.lblMusteriID.Visible = False
        '
        'txtMusteriID
        '
        Me.txtMusteriID.Location = New System.Drawing.Point(130, 29)
        Me.txtMusteriID.Name = "txtMusteriID"
        Me.txtMusteriID.ReadOnly = True
        Me.txtMusteriID.Size = New System.Drawing.Size(121, 20)
        Me.txtMusteriID.TabIndex = 0
        Me.txtMusteriID.Visible = False
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Iade Durumu :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Sorumlu : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Arýza Türü :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Cihaz Durumu :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Aksesuar :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Seri No :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Cihaz Tipi :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMusteriTelNo)
        Me.GroupBox1.Controls.Add(Me.dtpTarih)
        Me.GroupBox1.Controls.Add(Me.txtMusteriID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblMusteriID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMusteriAdi)
        Me.GroupBox1.Controls.Add(Me.txtMusteriSoyad)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 160)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Müþteri Detaylarý"
        '
        'txtMusteriTelNo
        '
        Me.txtMusteriTelNo.Location = New System.Drawing.Point(130, 106)
        Me.txtMusteriTelNo.Mask = "(999) 000-0000"
        Me.txtMusteriTelNo.Name = "txtMusteriTelNo"
        Me.txtMusteriTelNo.Size = New System.Drawing.Size(200, 20)
        Me.txtMusteriTelNo.TabIndex = 2
        '
        'dtpTarih
        '
        Me.dtpTarih.Location = New System.Drawing.Point(130, 130)
        Me.dtpTarih.Name = "dtpTarih"
        Me.dtpTarih.Size = New System.Drawing.Size(200, 20)
        Me.dtpTarih.TabIndex = 3
        '
        'grpCihazDetaylari
        '
        Me.grpCihazDetaylari.Controls.Add(Me.cmbArizaTuru)
        Me.grpCihazDetaylari.Controls.Add(Me.cmbCihazDurumu)
        Me.grpCihazDetaylari.Controls.Add(Me.cmbAksesuar)
        Me.grpCihazDetaylari.Controls.Add(Me.cmbCihazTipi)
        Me.grpCihazDetaylari.Controls.Add(Me.txtSeriNo)
        Me.grpCihazDetaylari.Controls.Add(Me.Label12)
        Me.grpCihazDetaylari.Controls.Add(Me.Label13)
        Me.grpCihazDetaylari.Controls.Add(Me.Label11)
        Me.grpCihazDetaylari.Controls.Add(Me.Label10)
        Me.grpCihazDetaylari.Controls.Add(Me.Label9)
        Me.grpCihazDetaylari.Location = New System.Drawing.Point(381, 46)
        Me.grpCihazDetaylari.Name = "grpCihazDetaylari"
        Me.grpCihazDetaylari.Size = New System.Drawing.Size(363, 160)
        Me.grpCihazDetaylari.TabIndex = 23
        Me.grpCihazDetaylari.TabStop = False
        Me.grpCihazDetaylari.Text = "Cihaz Detaylarý"
        '
        'cmbArizaTuru
        '
        Me.cmbArizaTuru.FormattingEnabled = True
        Me.cmbArizaTuru.Location = New System.Drawing.Point(130, 133)
        Me.cmbArizaTuru.MaxLength = 100
        Me.cmbArizaTuru.Name = "cmbArizaTuru"
        Me.cmbArizaTuru.Size = New System.Drawing.Size(200, 21)
        Me.cmbArizaTuru.TabIndex = 4
        Me.cmbArizaTuru.Tag = "musArizaTuru"
        '
        'cmbCihazDurumu
        '
        Me.cmbCihazDurumu.FormattingEnabled = True
        Me.cmbCihazDurumu.Location = New System.Drawing.Point(130, 106)
        Me.cmbCihazDurumu.MaxLength = 50
        Me.cmbCihazDurumu.Name = "cmbCihazDurumu"
        Me.cmbCihazDurumu.Size = New System.Drawing.Size(200, 21)
        Me.cmbCihazDurumu.TabIndex = 3
        Me.cmbCihazDurumu.Tag = "musCihazDurumu"
        '
        'cmbAksesuar
        '
        Me.cmbAksesuar.FormattingEnabled = True
        Me.cmbAksesuar.Location = New System.Drawing.Point(130, 81)
        Me.cmbAksesuar.Name = "cmbAksesuar"
        Me.cmbAksesuar.Size = New System.Drawing.Size(200, 21)
        Me.cmbAksesuar.TabIndex = 2
        Me.cmbAksesuar.Tag = "musAksesuar"
        '
        'cmbCihazTipi
        '
        Me.cmbCihazTipi.FormattingEnabled = True
        Me.cmbCihazTipi.Location = New System.Drawing.Point(130, 54)
        Me.cmbCihazTipi.MaxLength = 50
        Me.cmbCihazTipi.Name = "cmbCihazTipi"
        Me.cmbCihazTipi.Size = New System.Drawing.Size(200, 21)
        Me.cmbCihazTipi.TabIndex = 1
        Me.cmbCihazTipi.Tag = "musCihazTipi"
        '
        'txtSeriNo
        '
        Me.txtSeriNo.Location = New System.Drawing.Point(130, 29)
        Me.txtSeriNo.MaxLength = 20
        Me.txtSeriNo.Name = "txtSeriNo"
        Me.txtSeriNo.Size = New System.Drawing.Size(200, 20)
        Me.txtSeriNo.TabIndex = 0
        '
        'grpCihazDurumu
        '
        Me.grpCihazDurumu.Controls.Add(Me.cmbIadeDurumu)
        Me.grpCihazDurumu.Controls.Add(Me.dtpIadeTarih)
        Me.grpCihazDurumu.Controls.Add(Me.Label7)
        Me.grpCihazDurumu.Controls.Add(Me.Label6)
        Me.grpCihazDurumu.Location = New System.Drawing.Point(12, 212)
        Me.grpCihazDurumu.Name = "grpCihazDurumu"
        Me.grpCihazDurumu.Size = New System.Drawing.Size(363, 111)
        Me.grpCihazDurumu.TabIndex = 24
        Me.grpCihazDurumu.TabStop = False
        Me.grpCihazDurumu.Text = "Cihaz Durum Teslim Detaylarý"
        '
        'cmbIadeDurumu
        '
        Me.cmbIadeDurumu.FormattingEnabled = True
        Me.cmbIadeDurumu.Location = New System.Drawing.Point(130, 57)
        Me.cmbIadeDurumu.MaxLength = 50
        Me.cmbIadeDurumu.Name = "cmbIadeDurumu"
        Me.cmbIadeDurumu.Size = New System.Drawing.Size(200, 21)
        Me.cmbIadeDurumu.TabIndex = 1
        Me.cmbIadeDurumu.Tag = "musIadeDurumu"
        '
        'dtpIadeTarih
        '
        Me.dtpIadeTarih.Location = New System.Drawing.Point(130, 31)
        Me.dtpIadeTarih.Name = "dtpIadeTarih"
        Me.dtpIadeTarih.Size = New System.Drawing.Size(200, 20)
        Me.dtpIadeTarih.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtUcret)
        Me.GroupBox4.Controls.Add(Me.txtAciklama)
        Me.GroupBox4.Controls.Add(Me.txtSorumlu)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(381, 212)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(363, 111)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sorumlu Detaylarý"
        '
        'txtUcret
        '
        Me.txtUcret.Location = New System.Drawing.Point(130, 55)
        Me.txtUcret.Mask = "00000,00 $"
        Me.txtUcret.Name = "txtUcret"
        Me.txtUcret.Size = New System.Drawing.Size(200, 20)
        Me.txtUcret.TabIndex = 1
        '
        'txtAciklama
        '
        Me.txtAciklama.Location = New System.Drawing.Point(130, 81)
        Me.txtAciklama.MaxLength = 255
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.Size = New System.Drawing.Size(200, 20)
        Me.txtAciklama.TabIndex = 2
        '
        'txtSorumlu
        '
        Me.txtSorumlu.Location = New System.Drawing.Point(130, 29)
        Me.txtSorumlu.Name = "txtSorumlu"
        Me.txtSorumlu.ReadOnly = True
        Me.txtSorumlu.Size = New System.Drawing.Size(200, 20)
        Me.txtSorumlu.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 16)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Açýklama :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.5!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 16)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Ücret : "
        '
        'frmAddNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(747, 398)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grpCihazDurumu)
        Me.Controls.Add(Me.grpCihazDetaylari)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblDown)
        Me.Controls.Add(Me.btnEkle)
        Me.Controls.Add(Me.lblUp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAddNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yeni Kayýt Ekleme..."
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpCihazDetaylari.ResumeLayout(False)
        Me.grpCihazDetaylari.PerformLayout()
        Me.grpCihazDurumu.ResumeLayout(False)
        Me.grpCihazDurumu.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMusteriAdi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMusteriSoyad As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblUp As System.Windows.Forms.Label
    Friend WithEvents btnEkle As System.Windows.Forms.Button
    Friend WithEvents lblDown As System.Windows.Forms.Label
    Friend WithEvents lblMusteriID As System.Windows.Forms.Label
    Friend WithEvents txtMusteriID As System.Windows.Forms.TextBox
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents grpCihazDetaylari As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpCihazDurumu As System.Windows.Forms.GroupBox
    Friend WithEvents txtSeriNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtAciklama As System.Windows.Forms.TextBox
    Friend WithEvents txtSorumlu As System.Windows.Forms.TextBox
    Friend WithEvents dtpTarih As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbIadeDurumu As System.Windows.Forms.ComboBox
    Friend WithEvents dtpIadeTarih As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbArizaTuru As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCihazDurumu As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAksesuar As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCihazTipi As System.Windows.Forms.ComboBox
    Friend WithEvents txtUcret As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtMusteriTelNo As System.Windows.Forms.MaskedTextBox
End Class
