<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2", 1, 1)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3", 2, 2)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node4", 3, 3)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node5", 4, 4)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node6", 5, 5)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7", 6, 6)
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.mnuNew = New System.Windows.Forms.ToolStripButton()
        Me.mnuEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFind = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDelOne = New System.Windows.Forms.ToolStripButton()
        Me.mnuDelAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuReset = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAddToDetails = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCalculator = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuChangeUser = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstDates = New System.Windows.Forms.ListView()
        Me.clmTarih = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.tssDates = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.trvUsers = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SeçiliSipariþiEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SeçiliSipariþiSilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TümSipariþleriSilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SipariþleriYazdýrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssRowCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssCellCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssCellAddress = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SiparisIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MusteriAdiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiparisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiparisAdediDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiparisDurumuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiparisTarihiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiparisNotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblKimlik = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuEdit, Me.ToolStripSeparator4, Me.mnuFind, Me.ToolStripSeparator1, Me.mnuDelOne, Me.mnuDelAll, Me.ToolStripSeparator2, Me.mnuReset, Me.ToolStripSeparator3, Me.mnuAddToDetails, Me.ToolStripSeparator5, Me.mnuCalculator, Me.ToolStripSeparator6, Me.mnuChangeUser})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1120, 70)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'mnuNew
        '
        Me.mnuNew.Image = CType(resources.GetObject("mnuNew.Image"), System.Drawing.Image)
        Me.mnuNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(58, 67)
        Me.mnuNew.Text = "Yeni Ekle"
        Me.mnuNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnuEdit
        '
        Me.mnuEdit.Image = CType(resources.GetObject("mnuEdit.Image"), System.Drawing.Image)
        Me.mnuEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(52, 67)
        Me.mnuEdit.Text = "Düzelt"
        Me.mnuEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 70)
        '
        'mnuFind
        '
        Me.mnuFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.mnuFind.Image = CType(resources.GetObject("mnuFind.Image"), System.Drawing.Image)
        Me.mnuFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuFind.Name = "mnuFind"
        Me.mnuFind.Size = New System.Drawing.Size(52, 67)
        Me.mnuFind.Text = "Ara"
        Me.mnuFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 70)
        '
        'mnuDelOne
        '
        Me.mnuDelOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.mnuDelOne.Image = CType(resources.GetObject("mnuDelOne.Image"), System.Drawing.Image)
        Me.mnuDelOne.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuDelOne.Name = "mnuDelOne"
        Me.mnuDelOne.Size = New System.Drawing.Size(52, 67)
        Me.mnuDelOne.Text = "Sil"
        Me.mnuDelOne.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnuDelAll
        '
        Me.mnuDelAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.mnuDelAll.Image = CType(resources.GetObject("mnuDelAll.Image"), System.Drawing.Image)
        Me.mnuDelAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuDelAll.Name = "mnuDelAll"
        Me.mnuDelAll.Size = New System.Drawing.Size(66, 67)
        Me.mnuDelAll.Text = "Hepsini Sil"
        Me.mnuDelAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 70)
        '
        'mnuReset
        '
        Me.mnuReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.mnuReset.Image = CType(resources.GetObject("mnuReset.Image"), System.Drawing.Image)
        Me.mnuReset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuReset.Name = "mnuReset"
        Me.mnuReset.Size = New System.Drawing.Size(52, 67)
        Me.mnuReset.Text = "Reset"
        Me.mnuReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 70)
        '
        'mnuAddToDetails
        '
        Me.mnuAddToDetails.Image = CType(resources.GetObject("mnuAddToDetails.Image"), System.Drawing.Image)
        Me.mnuAddToDetails.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuAddToDetails.Name = "mnuAddToDetails"
        Me.mnuAddToDetails.Size = New System.Drawing.Size(84, 67)
        Me.mnuAddToDetails.Text = "Detaylara Ekle"
        Me.mnuAddToDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 70)
        '
        'mnuCalculator
        '
        Me.mnuCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.mnuCalculator.Image = CType(resources.GetObject("mnuCalculator.Image"), System.Drawing.Image)
        Me.mnuCalculator.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuCalculator.Name = "mnuCalculator"
        Me.mnuCalculator.Size = New System.Drawing.Size(94, 67)
        Me.mnuCalculator.Text = "Hesap Makinesi"
        Me.mnuCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 70)
        '
        'mnuChangeUser
        '
        Me.mnuChangeUser.Image = CType(resources.GetObject("mnuChangeUser.Image"), System.Drawing.Image)
        Me.mnuChangeUser.ImageTransparentColor = System.Drawing.Color.White
        Me.mnuChangeUser.Name = "mnuChangeUser"
        Me.mnuChangeUser.Size = New System.Drawing.Size(99, 67)
        Me.mnuChangeUser.Text = "Kullanýcý Deðiþtir"
        Me.mnuChangeUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lstDates)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.StatusStrip2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(178, 460)
        Me.Panel1.TabIndex = 3
        '
        'lstDates
        '
        Me.lstDates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstDates.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmTarih})
        Me.lstDates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstDates.FullRowSelect = True
        Me.lstDates.Location = New System.Drawing.Point(0, 23)
        Me.lstDates.Name = "lstDates"
        Me.lstDates.Size = New System.Drawing.Size(176, 413)
        Me.lstDates.SmallImageList = Me.ImageList1
        Me.lstDates.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.lstDates.TabIndex = 0
        Me.lstDates.UseCompatibleStateImageBehavior = False
        Me.lstDates.View = System.Windows.Forms.View.SmallIcon
        '
        'clmTarih
        '
        Me.clmTarih.Text = "Sipariþ Tarihi"
        Me.clmTarih.Width = 6
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "User.ico")
        Me.ImageList1.Images.SetKeyName(3, "Telefon.png")
        Me.ImageList1.Images.SetKeyName(4, "iCal.ico")
        Me.ImageList1.Images.SetKeyName(5, "file.ico")
        Me.ImageList1.Images.SetKeyName(6, "Computer.png")
        Me.ImageList1.Images.SetKeyName(7, "Aksesuar.png")
        Me.ImageList1.Images.SetKeyName(8, "Word Processor-Word.ico")
        Me.ImageList1.Images.SetKeyName(9, "info.png")
        Me.ImageList1.Images.SetKeyName(10, "User.png")
        Me.ImageList1.Images.SetKeyName(11, "iCal.ico")
        Me.ImageList1.Images.SetKeyName(12, "info.png")
        Me.ImageList1.Images.SetKeyName(13, "hand.png")
        Me.ImageList1.Images.SetKeyName(14, "file.ico")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sipariþ Tarihleri"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssDates})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 436)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(176, 22)
        Me.StatusStrip2.TabIndex = 0
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'tssDates
        '
        Me.tssDates.Name = "tssDates"
        Me.tssDates.Size = New System.Drawing.Size(63, 17)
        Me.tssDates.Text = "Toplam : 0"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.trvUsers)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(814, 70)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(306, 460)
        Me.Panel3.TabIndex = 8
        '
        'trvUsers
        '
        Me.trvUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.trvUsers.ContextMenuStrip = Me.ContextMenuStrip1
        Me.trvUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trvUsers.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.trvUsers.ImageIndex = 0
        Me.trvUsers.ImageList = Me.ImageList1
        Me.trvUsers.ItemHeight = 25
        Me.trvUsers.Location = New System.Drawing.Point(0, 23)
        Me.trvUsers.Name = "trvUsers"
        TreeNode1.Name = "Node0"
        TreeNode1.Text = "Node0"
        TreeNode2.ImageIndex = 1
        TreeNode2.Name = "Node2"
        TreeNode2.SelectedImageIndex = 1
        TreeNode2.Text = "Node2"
        TreeNode3.ImageIndex = 2
        TreeNode3.Name = "Node3"
        TreeNode3.SelectedImageIndex = 2
        TreeNode3.Text = "Node3"
        TreeNode4.ImageIndex = 3
        TreeNode4.Name = "Node4"
        TreeNode4.SelectedImageIndex = 3
        TreeNode4.Text = "Node4"
        TreeNode5.ImageIndex = 4
        TreeNode5.Name = "Node5"
        TreeNode5.SelectedImageIndex = 4
        TreeNode5.Text = "Node5"
        TreeNode6.ImageIndex = 5
        TreeNode6.Name = "Node6"
        TreeNode6.SelectedImageIndex = 5
        TreeNode6.Text = "Node6"
        TreeNode7.ImageIndex = 6
        TreeNode7.Name = "Node7"
        TreeNode7.SelectedImageIndex = 6
        TreeNode7.Text = "Node7"
        Me.trvUsers.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7})
        Me.trvUsers.SelectedImageIndex = 0
        Me.trvUsers.Size = New System.Drawing.Size(304, 435)
        Me.trvUsers.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeçiliSipariþiEkleToolStripMenuItem, Me.ToolStripMenuItem1, Me.SeçiliSipariþiSilToolStripMenuItem, Me.TümSipariþleriSilToolStripMenuItem, Me.ToolStripMenuItem2, Me.SipariþleriYazdýrToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(240, 104)
        '
        'SeçiliSipariþiEkleToolStripMenuItem
        '
        Me.SeçiliSipariþiEkleToolStripMenuItem.Name = "SeçiliSipariþiEkleToolStripMenuItem"
        Me.SeçiliSipariþiEkleToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.SeçiliSipariþiEkleToolStripMenuItem.Text = "Tablodan Seçili Kaydý Listeye Al"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(236, 6)
        '
        'SeçiliSipariþiSilToolStripMenuItem
        '
        Me.SeçiliSipariþiSilToolStripMenuItem.Name = "SeçiliSipariþiSilToolStripMenuItem"
        Me.SeçiliSipariþiSilToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.SeçiliSipariþiSilToolStripMenuItem.Text = "Seçili Kaydý Sil"
        '
        'TümSipariþleriSilToolStripMenuItem
        '
        Me.TümSipariþleriSilToolStripMenuItem.Name = "TümSipariþleriSilToolStripMenuItem"
        Me.TümSipariþleriSilToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.TümSipariþleriSilToolStripMenuItem.Text = "Tüm Kayýtlarý Sil"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(236, 6)
        '
        'SipariþleriYazdýrToolStripMenuItem
        '
        Me.SipariþleriYazdýrToolStripMenuItem.Name = "SipariþleriYazdýrToolStripMenuItem"
        Me.SipariþleriYazdýrToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.SipariþleriYazdýrToolStripMenuItem.Text = "Kayýtlarý Yazdýr"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sipariþ Detaylarý"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter1.Location = New System.Drawing.Point(806, 70)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(8, 460)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(178, 70)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(8, 460)
        Me.Splitter2.TabIndex = 10
        Me.Splitter2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dgv)
        Me.Panel2.Controls.Add(Me.StatusStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(186, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(620, 460)
        Me.Panel2.TabIndex = 11
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.Size = New System.Drawing.Size(618, 436)
        Me.dgv.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssRowCount, Me.tssCellCount, Me.tssCellAddress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 436)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(618, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssRowCount
        '
        Me.tssRowCount.Name = "tssRowCount"
        Me.tssRowCount.Size = New System.Drawing.Size(77, 17)
        Me.tssRowCount.Text = "Satýr Sayýsý : 0"
        '
        'tssCellCount
        '
        Me.tssCellCount.Name = "tssCellCount"
        Me.tssCellCount.Size = New System.Drawing.Size(77, 17)
        Me.tssCellCount.Text = "Hücre Sayýsý :"
        '
        'tssCellAddress
        '
        Me.tssCellAddress.Name = "tssCellAddress"
        Me.tssCellAddress.Size = New System.Drawing.Size(117, 17)
        Me.tssCellAddress.Text = "Hücre Adresi : {-1;-1}"
        '
        'SiparisIDDataGridViewTextBoxColumn
        '
        Me.SiparisIDDataGridViewTextBoxColumn.Name = "SiparisIDDataGridViewTextBoxColumn"
        '
        'MusteriAdiDataGridViewTextBoxColumn
        '
        Me.MusteriAdiDataGridViewTextBoxColumn.Name = "MusteriAdiDataGridViewTextBoxColumn"
        '
        'SiparisDataGridViewTextBoxColumn
        '
        Me.SiparisDataGridViewTextBoxColumn.Name = "SiparisDataGridViewTextBoxColumn"
        '
        'SiparisAdediDataGridViewTextBoxColumn
        '
        Me.SiparisAdediDataGridViewTextBoxColumn.Name = "SiparisAdediDataGridViewTextBoxColumn"
        '
        'SiparisDurumuDataGridViewTextBoxColumn
        '
        Me.SiparisDurumuDataGridViewTextBoxColumn.Name = "SiparisDurumuDataGridViewTextBoxColumn"
        '
        'SiparisTarihiDataGridViewTextBoxColumn
        '
        Me.SiparisTarihiDataGridViewTextBoxColumn.Name = "SiparisTarihiDataGridViewTextBoxColumn"
        '
        'SiparisNotDataGridViewTextBoxColumn
        '
        Me.SiparisNotDataGridViewTextBoxColumn.Name = "SiparisNotDataGridViewTextBoxColumn"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.lblKimlik)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(754, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel4.Size = New System.Drawing.Size(366, 70)
        Me.Panel4.TabIndex = 12
        '
        'lblKimlik
        '
        Me.lblKimlik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKimlik.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKimlik.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblKimlik.Location = New System.Drawing.Point(5, 5)
        Me.lblKimlik.Name = "lblKimlik"
        Me.lblKimlik.Size = New System.Drawing.Size(351, 60)
        Me.lblKimlik.TabIndex = 12
        Me.lblKimlik.Text = "Label3"
        Me.lblKimlik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(356, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 60)
        Me.Panel5.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 530)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yetkili Teknik Servis Otomasyonu"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents mnuDelOne As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuReset As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDelAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCalculator As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstDates As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents trvUsers As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents mnuAddToDetails As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SiparisIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MusteriAdiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SiparisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SiparisAdediDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SiparisDurumuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SiparisTarihiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SiparisNotDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents clmTarih As System.Windows.Forms.ColumnHeader
    Friend WithEvents tssDates As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssRowCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssCellCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssCellAddress As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SeçiliSipariþiEkleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SeçiliSipariþiSilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TümSipariþleriSilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SipariþleriYazdýrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblKimlik As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuChangeUser As System.Windows.Forms.ToolStripButton

End Class
