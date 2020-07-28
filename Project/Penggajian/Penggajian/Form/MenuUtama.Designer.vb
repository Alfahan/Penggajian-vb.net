<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.blogoff = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.bpenggajian = New System.Windows.Forms.Button()
        Me.babsensi = New System.Windows.Forms.Button()
        Me.btutupaplikasi = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.bkaryawan = New System.Windows.Forms.Button()
        Me.bpotongan = New System.Windows.Forms.Button()
        Me.bpendapatan = New System.Windows.Forms.Button()
        Me.bjabatan = New System.Windows.Forms.Button()
        Me.bdept = New System.Windows.Forms.Button()
        Me.buser = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.blaporanpenggajian = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.panel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.panel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.panel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartemenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JabatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendapatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PotonganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaryawanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbsensiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenggajianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanAbsensiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenggajianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutupAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.blaporanabsensi = New System.Windows.Forms.Button()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'blogoff
        '
        Me.blogoff.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.blogoff.AutoSize = True
        Me.blogoff.BackColor = System.Drawing.Color.Transparent
        Me.blogoff.Dock = System.Windows.Forms.DockStyle.Left
        Me.blogoff.FlatAppearance.BorderSize = 0
        Me.blogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.blogoff.Image = CType(resources.GetObject("blogoff.Image"), System.Drawing.Image)
        Me.blogoff.Location = New System.Drawing.Point(0, 0)
        Me.blogoff.Name = "blogoff"
        Me.blogoff.Size = New System.Drawing.Size(91, 112)
        Me.blogoff.TabIndex = 5
        Me.blogoff.Text = "Log Off"
        Me.blogoff.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.blogoff.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.bpenggajian)
        Me.TabPage2.Controls.Add(Me.babsensi)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1032, 112)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Transaksi"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'bpenggajian
        '
        Me.bpenggajian.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.bpenggajian.AutoSize = True
        Me.bpenggajian.BackColor = System.Drawing.Color.Transparent
        Me.bpenggajian.Dock = System.Windows.Forms.DockStyle.Left
        Me.bpenggajian.FlatAppearance.BorderSize = 0
        Me.bpenggajian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bpenggajian.Image = CType(resources.GetObject("bpenggajian.Image"), System.Drawing.Image)
        Me.bpenggajian.Location = New System.Drawing.Point(77, 3)
        Me.bpenggajian.Name = "bpenggajian"
        Me.bpenggajian.Size = New System.Drawing.Size(84, 106)
        Me.bpenggajian.TabIndex = 3
        Me.bpenggajian.Text = "Penggajian"
        Me.bpenggajian.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bpenggajian.UseVisualStyleBackColor = False
        '
        'babsensi
        '
        Me.babsensi.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.babsensi.AutoSize = True
        Me.babsensi.BackColor = System.Drawing.Color.Transparent
        Me.babsensi.Dock = System.Windows.Forms.DockStyle.Left
        Me.babsensi.FlatAppearance.BorderSize = 0
        Me.babsensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.babsensi.Image = CType(resources.GetObject("babsensi.Image"), System.Drawing.Image)
        Me.babsensi.Location = New System.Drawing.Point(3, 3)
        Me.babsensi.Name = "babsensi"
        Me.babsensi.Size = New System.Drawing.Size(74, 106)
        Me.babsensi.TabIndex = 2
        Me.babsensi.Text = "Absensi"
        Me.babsensi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.babsensi.UseVisualStyleBackColor = False
        '
        'btutupaplikasi
        '
        Me.btutupaplikasi.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.btutupaplikasi.AutoSize = True
        Me.btutupaplikasi.BackColor = System.Drawing.Color.Transparent
        Me.btutupaplikasi.Dock = System.Windows.Forms.DockStyle.Left
        Me.btutupaplikasi.FlatAppearance.BorderSize = 0
        Me.btutupaplikasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btutupaplikasi.Image = CType(resources.GetObject("btutupaplikasi.Image"), System.Drawing.Image)
        Me.btutupaplikasi.Location = New System.Drawing.Point(91, 0)
        Me.btutupaplikasi.Name = "btutupaplikasi"
        Me.btutupaplikasi.Size = New System.Drawing.Size(106, 112)
        Me.btutupaplikasi.TabIndex = 6
        Me.btutupaplikasi.Text = "Tutup Aplikasi"
        Me.btutupaplikasi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btutupaplikasi.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1040, 138)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.bkaryawan)
        Me.TabPage1.Controls.Add(Me.bpotongan)
        Me.TabPage1.Controls.Add(Me.bpendapatan)
        Me.TabPage1.Controls.Add(Me.bjabatan)
        Me.TabPage1.Controls.Add(Me.bdept)
        Me.TabPage1.Controls.Add(Me.buser)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1032, 112)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "File"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'bkaryawan
        '
        Me.bkaryawan.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.bkaryawan.AutoSize = True
        Me.bkaryawan.BackColor = System.Drawing.Color.Transparent
        Me.bkaryawan.Dock = System.Windows.Forms.DockStyle.Left
        Me.bkaryawan.FlatAppearance.BorderSize = 0
        Me.bkaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bkaryawan.Image = CType(resources.GetObject("bkaryawan.Image"), System.Drawing.Image)
        Me.bkaryawan.Location = New System.Drawing.Point(351, 3)
        Me.bkaryawan.Name = "bkaryawan"
        Me.bkaryawan.Size = New System.Drawing.Size(66, 106)
        Me.bkaryawan.TabIndex = 8
        Me.bkaryawan.Text = "Karyawan"
        Me.bkaryawan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bkaryawan.UseVisualStyleBackColor = False
        '
        'bpotongan
        '
        Me.bpotongan.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.bpotongan.AutoSize = True
        Me.bpotongan.BackColor = System.Drawing.Color.Transparent
        Me.bpotongan.Dock = System.Windows.Forms.DockStyle.Left
        Me.bpotongan.FlatAppearance.BorderSize = 0
        Me.bpotongan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bpotongan.Image = CType(resources.GetObject("bpotongan.Image"), System.Drawing.Image)
        Me.bpotongan.Location = New System.Drawing.Point(285, 3)
        Me.bpotongan.Name = "bpotongan"
        Me.bpotongan.Size = New System.Drawing.Size(66, 106)
        Me.bpotongan.TabIndex = 7
        Me.bpotongan.Text = "Potongan"
        Me.bpotongan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bpotongan.UseVisualStyleBackColor = False
        '
        'bpendapatan
        '
        Me.bpendapatan.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.bpendapatan.AutoSize = True
        Me.bpendapatan.BackColor = System.Drawing.Color.Transparent
        Me.bpendapatan.Dock = System.Windows.Forms.DockStyle.Left
        Me.bpendapatan.FlatAppearance.BorderSize = 0
        Me.bpendapatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bpendapatan.Image = CType(resources.GetObject("bpendapatan.Image"), System.Drawing.Image)
        Me.bpendapatan.Location = New System.Drawing.Point(210, 3)
        Me.bpendapatan.Name = "bpendapatan"
        Me.bpendapatan.Size = New System.Drawing.Size(75, 106)
        Me.bpendapatan.TabIndex = 6
        Me.bpendapatan.Text = "Pendapatan"
        Me.bpendapatan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bpendapatan.UseVisualStyleBackColor = False
        '
        'bjabatan
        '
        Me.bjabatan.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.bjabatan.AutoSize = True
        Me.bjabatan.BackColor = System.Drawing.Color.Transparent
        Me.bjabatan.Dock = System.Windows.Forms.DockStyle.Left
        Me.bjabatan.FlatAppearance.BorderSize = 0
        Me.bjabatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bjabatan.Image = CType(resources.GetObject("bjabatan.Image"), System.Drawing.Image)
        Me.bjabatan.Location = New System.Drawing.Point(144, 3)
        Me.bjabatan.Name = "bjabatan"
        Me.bjabatan.Size = New System.Drawing.Size(66, 106)
        Me.bjabatan.TabIndex = 5
        Me.bjabatan.Text = "Jabatan"
        Me.bjabatan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bjabatan.UseVisualStyleBackColor = False
        '
        'bdept
        '
        Me.bdept.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.bdept.AutoSize = True
        Me.bdept.BackColor = System.Drawing.Color.Transparent
        Me.bdept.Dock = System.Windows.Forms.DockStyle.Left
        Me.bdept.FlatAppearance.BorderSize = 0
        Me.bdept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bdept.Image = CType(resources.GetObject("bdept.Image"), System.Drawing.Image)
        Me.bdept.Location = New System.Drawing.Point(69, 3)
        Me.bdept.Name = "bdept"
        Me.bdept.Size = New System.Drawing.Size(75, 106)
        Me.bdept.TabIndex = 4
        Me.bdept.Text = "Departemen"
        Me.bdept.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bdept.UseVisualStyleBackColor = False
        '
        'buser
        '
        Me.buser.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.buser.AutoSize = True
        Me.buser.BackColor = System.Drawing.Color.Transparent
        Me.buser.Dock = System.Windows.Forms.DockStyle.Left
        Me.buser.FlatAppearance.BorderSize = 0
        Me.buser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buser.Image = CType(resources.GetObject("buser.Image"), System.Drawing.Image)
        Me.buser.Location = New System.Drawing.Point(3, 3)
        Me.buser.Name = "buser"
        Me.buser.Size = New System.Drawing.Size(66, 106)
        Me.buser.TabIndex = 3
        Me.buser.Text = "User"
        Me.buser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.buser.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.blaporanpenggajian)
        Me.TabPage3.Controls.Add(Me.blaporanabsensi)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1032, 112)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "Laporan"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'blaporanpenggajian
        '
        Me.blaporanpenggajian.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.blaporanpenggajian.AutoSize = True
        Me.blaporanpenggajian.BackColor = System.Drawing.Color.Transparent
        Me.blaporanpenggajian.Dock = System.Windows.Forms.DockStyle.Left
        Me.blaporanpenggajian.FlatAppearance.BorderSize = 0
        Me.blaporanpenggajian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.blaporanpenggajian.Image = CType(resources.GetObject("blaporanpenggajian.Image"), System.Drawing.Image)
        Me.blaporanpenggajian.Location = New System.Drawing.Point(96, 0)
        Me.blaporanpenggajian.Name = "blaporanpenggajian"
        Me.blaporanpenggajian.Size = New System.Drawing.Size(112, 112)
        Me.blaporanpenggajian.TabIndex = 8
        Me.blaporanpenggajian.Text = "Laporan Penggajian"
        Me.blaporanpenggajian.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.blaporanpenggajian.UseVisualStyleBackColor = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btutupaplikasi)
        Me.TabPage4.Controls.Add(Me.blogoff)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1032, 112)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Keluar"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'panel3
        '
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(0, 17)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.panel1, Me.panel2, Me.panel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 500)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1040, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'panel1
        '
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(0, 17)
        '
        'panel2
        '
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(0, 17)
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1040, 498)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1040, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.DepartemenToolStripMenuItem, Me.JabatanToolStripMenuItem, Me.PendapatanToolStripMenuItem, Me.PotonganToolStripMenuItem, Me.KaryawanToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Image = CType(resources.GetObject("UserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'DepartemenToolStripMenuItem
        '
        Me.DepartemenToolStripMenuItem.Image = CType(resources.GetObject("DepartemenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DepartemenToolStripMenuItem.Name = "DepartemenToolStripMenuItem"
        Me.DepartemenToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.DepartemenToolStripMenuItem.Text = "Departemen"
        '
        'JabatanToolStripMenuItem
        '
        Me.JabatanToolStripMenuItem.Image = CType(resources.GetObject("JabatanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.JabatanToolStripMenuItem.Name = "JabatanToolStripMenuItem"
        Me.JabatanToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.JabatanToolStripMenuItem.Text = "Jabatan"
        '
        'PendapatanToolStripMenuItem
        '
        Me.PendapatanToolStripMenuItem.Image = CType(resources.GetObject("PendapatanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PendapatanToolStripMenuItem.Name = "PendapatanToolStripMenuItem"
        Me.PendapatanToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PendapatanToolStripMenuItem.Text = "Pendapatan"
        '
        'PotonganToolStripMenuItem
        '
        Me.PotonganToolStripMenuItem.Image = CType(resources.GetObject("PotonganToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PotonganToolStripMenuItem.Name = "PotonganToolStripMenuItem"
        Me.PotonganToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PotonganToolStripMenuItem.Text = "Potongan"
        '
        'KaryawanToolStripMenuItem1
        '
        Me.KaryawanToolStripMenuItem1.Image = CType(resources.GetObject("KaryawanToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.KaryawanToolStripMenuItem1.Name = "KaryawanToolStripMenuItem1"
        Me.KaryawanToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.KaryawanToolStripMenuItem1.Text = "Karyawan"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbsensiToolStripMenuItem, Me.PenggajianToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'AbsensiToolStripMenuItem
        '
        Me.AbsensiToolStripMenuItem.Image = CType(resources.GetObject("AbsensiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbsensiToolStripMenuItem.Name = "AbsensiToolStripMenuItem"
        Me.AbsensiToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.AbsensiToolStripMenuItem.Text = "Absensi"
        '
        'PenggajianToolStripMenuItem
        '
        Me.PenggajianToolStripMenuItem.Image = CType(resources.GetObject("PenggajianToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PenggajianToolStripMenuItem.Name = "PenggajianToolStripMenuItem"
        Me.PenggajianToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PenggajianToolStripMenuItem.Text = "Penggajian"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanAbsensiToolStripMenuItem, Me.LaporanPenggajianToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanAbsensiToolStripMenuItem
        '
        Me.LaporanAbsensiToolStripMenuItem.Image = CType(resources.GetObject("LaporanAbsensiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanAbsensiToolStripMenuItem.Name = "LaporanAbsensiToolStripMenuItem"
        Me.LaporanAbsensiToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.LaporanAbsensiToolStripMenuItem.Text = "Laporan Absensi"
        '
        'LaporanPenggajianToolStripMenuItem
        '
        Me.LaporanPenggajianToolStripMenuItem.Image = CType(resources.GetObject("LaporanPenggajianToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanPenggajianToolStripMenuItem.Name = "LaporanPenggajianToolStripMenuItem"
        Me.LaporanPenggajianToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.LaporanPenggajianToolStripMenuItem.Text = "Laporan Penggajian"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOffToolStripMenuItem, Me.TutupAplikasiToolStripMenuItem})
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.Image = CType(resources.GetObject("LogOffToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.LogOffToolStripMenuItem.Text = "Log Off"
        '
        'TutupAplikasiToolStripMenuItem
        '
        Me.TutupAplikasiToolStripMenuItem.Image = CType(resources.GetObject("TutupAplikasiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TutupAplikasiToolStripMenuItem.Name = "TutupAplikasiToolStripMenuItem"
        Me.TutupAplikasiToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.TutupAplikasiToolStripMenuItem.Text = "Tutup Aplikasi"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImageLocation = ""
        Me.PictureBox2.Location = New System.Drawing.Point(0, 162)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1040, 338)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.WaitOnLoad = True
        '
        'blaporanabsensi
        '
        Me.blaporanabsensi.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.blaporanabsensi.AutoSize = True
        Me.blaporanabsensi.BackColor = System.Drawing.Color.Transparent
        Me.blaporanabsensi.Dock = System.Windows.Forms.DockStyle.Left
        Me.blaporanabsensi.FlatAppearance.BorderSize = 0
        Me.blaporanabsensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.blaporanabsensi.Image = CType(resources.GetObject("blaporanabsensi.Image"), System.Drawing.Image)
        Me.blaporanabsensi.Location = New System.Drawing.Point(0, 0)
        Me.blaporanabsensi.Name = "blaporanabsensi"
        Me.blaporanabsensi.Size = New System.Drawing.Size(96, 112)
        Me.blaporanabsensi.TabIndex = 7
        Me.blaporanabsensi.Text = "Laporan Absensi"
        Me.blaporanabsensi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.blaporanabsensi.UseVisualStyleBackColor = False
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 522)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents blogoff As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents bpenggajian As System.Windows.Forms.Button
    Friend WithEvents babsensi As System.Windows.Forms.Button
    Friend WithEvents btutupaplikasi As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents bpendapatan As System.Windows.Forms.Button
    Friend WithEvents bjabatan As System.Windows.Forms.Button
    Friend WithEvents bdept As System.Windows.Forms.Button
    Friend WithEvents buser As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents panel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents panel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents panel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartemenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JabatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PendapatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bkaryawan As System.Windows.Forms.Button
    Friend WithEvents bpotongan As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents blaporanpenggajian As System.Windows.Forms.Button
    Friend WithEvents PotonganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KaryawanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbsensiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenggajianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanAbsensiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenggajianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TutupAplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents blaporanabsensi As System.Windows.Forms.Button
End Class
