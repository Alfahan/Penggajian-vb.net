<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKaryawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKaryawan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tnamadept = New System.Windows.Forms.TextBox()
        Me.cpendidikan = New System.Windows.Forms.ComboBox()
        Me.tjab = New System.Windows.Forms.TextBox()
        Me.cstatus = New System.Windows.Forms.ComboBox()
        Me.dtpgabung = New System.Windows.Forms.DateTimePicker()
        Me.temail = New System.Windows.Forms.TextBox()
        Me.tnpwp = New System.Windows.Forms.TextBox()
        Me.talamat = New System.Windows.Forms.TextBox()
        Me.ttelp = New System.Windows.Forms.TextBox()
        Me.dtplahir = New System.Windows.Forms.DateTimePicker()
        Me.cjab = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cdept = New System.Windows.Forms.ComboBox()
        Me.ttempatlahir = New System.Windows.Forms.TextBox()
        Me.tnik = New System.Windows.Forms.TextBox()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bbaru = New System.Windows.Forms.Button()
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.bhapus = New System.Windows.Forms.Button()
        Me.bbatal = New System.Windows.Forms.Button()
        Me.bprint = New System.Windows.Forms.Button()
        Me.tcari = New System.Windows.Forms.TextBox()
        Me.tdept = New System.Windows.Forms.TextBox()
        Me.bimport = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bimport)
        Me.GroupBox1.Controls.Add(Me.tnamadept)
        Me.GroupBox1.Controls.Add(Me.cpendidikan)
        Me.GroupBox1.Controls.Add(Me.tjab)
        Me.GroupBox1.Controls.Add(Me.cstatus)
        Me.GroupBox1.Controls.Add(Me.dtpgabung)
        Me.GroupBox1.Controls.Add(Me.temail)
        Me.GroupBox1.Controls.Add(Me.tnpwp)
        Me.GroupBox1.Controls.Add(Me.talamat)
        Me.GroupBox1.Controls.Add(Me.ttelp)
        Me.GroupBox1.Controls.Add(Me.dtplahir)
        Me.GroupBox1.Controls.Add(Me.cjab)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cdept)
        Me.GroupBox1.Controls.Add(Me.ttempatlahir)
        Me.GroupBox1.Controls.Add(Me.tnik)
        Me.GroupBox1.Controls.Add(Me.tnama)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1112, 240)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'tnamadept
        '
        Me.tnamadept.Location = New System.Drawing.Point(930, 42)
        Me.tnamadept.Name = "tnamadept"
        Me.tnamadept.Size = New System.Drawing.Size(170, 20)
        Me.tnamadept.TabIndex = 27
        '
        'cpendidikan
        '
        Me.cpendidikan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cpendidikan.FormattingEnabled = True
        Me.cpendidikan.Location = New System.Drawing.Point(620, 14)
        Me.cpendidikan.Name = "cpendidikan"
        Me.cpendidikan.Size = New System.Drawing.Size(178, 21)
        Me.cpendidikan.TabIndex = 26
        '
        'tjab
        '
        Me.tjab.Location = New System.Drawing.Point(930, 95)
        Me.tjab.Name = "tjab"
        Me.tjab.Size = New System.Drawing.Size(170, 20)
        Me.tjab.TabIndex = 25
        '
        'cstatus
        '
        Me.cstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cstatus.FormattingEnabled = True
        Me.cstatus.Location = New System.Drawing.Point(620, 100)
        Me.cstatus.Name = "cstatus"
        Me.cstatus.Size = New System.Drawing.Size(178, 21)
        Me.cstatus.TabIndex = 23
        '
        'dtpgabung
        '
        Me.dtpgabung.Location = New System.Drawing.Point(620, 129)
        Me.dtpgabung.Name = "dtpgabung"
        Me.dtpgabung.Size = New System.Drawing.Size(200, 20)
        Me.dtpgabung.TabIndex = 22
        '
        'temail
        '
        Me.temail.Location = New System.Drawing.Point(620, 70)
        Me.temail.Name = "temail"
        Me.temail.Size = New System.Drawing.Size(178, 20)
        Me.temail.TabIndex = 20
        '
        'tnpwp
        '
        Me.tnpwp.Location = New System.Drawing.Point(620, 44)
        Me.tnpwp.Name = "tnpwp"
        Me.tnpwp.Size = New System.Drawing.Size(178, 20)
        Me.tnpwp.TabIndex = 19
        '
        'talamat
        '
        Me.talamat.Location = New System.Drawing.Point(137, 158)
        Me.talamat.Multiline = True
        Me.talamat.Name = "talamat"
        Me.talamat.Size = New System.Drawing.Size(687, 76)
        Me.talamat.TabIndex = 17
        '
        'ttelp
        '
        Me.ttelp.Location = New System.Drawing.Point(137, 129)
        Me.ttelp.Name = "ttelp"
        Me.ttelp.Size = New System.Drawing.Size(150, 20)
        Me.ttelp.TabIndex = 16
        '
        'dtplahir
        '
        Me.dtplahir.Location = New System.Drawing.Point(137, 100)
        Me.dtplahir.Name = "dtplahir"
        Me.dtplahir.Size = New System.Drawing.Size(200, 20)
        Me.dtplahir.TabIndex = 15
        '
        'cjab
        '
        Me.cjab.FormattingEnabled = True
        Me.cjab.Location = New System.Drawing.Point(930, 68)
        Me.cjab.Name = "cjab"
        Me.cjab.Size = New System.Drawing.Size(170, 21)
        Me.cjab.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(824, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 20)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Jabatan"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(824, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Departemen"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(514, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Tanggal Gabung"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(514, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Status Karyawan"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(514, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Email"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(514, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "NPWP"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(514, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Pendidikan"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(12, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(12, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "No Telepon"
        '
        'cdept
        '
        Me.cdept.FormattingEnabled = True
        Me.cdept.Location = New System.Drawing.Point(930, 14)
        Me.cdept.Name = "cdept"
        Me.cdept.Size = New System.Drawing.Size(170, 21)
        Me.cdept.TabIndex = 4
        '
        'ttempatlahir
        '
        Me.ttempatlahir.Location = New System.Drawing.Point(137, 72)
        Me.ttempatlahir.Name = "ttempatlahir"
        Me.ttempatlahir.Size = New System.Drawing.Size(150, 20)
        Me.ttempatlahir.TabIndex = 3
        '
        'tnik
        '
        Me.tnik.Location = New System.Drawing.Point(137, 14)
        Me.tnik.Name = "tnik"
        Me.tnik.Size = New System.Drawing.Size(150, 20)
        Me.tnik.TabIndex = 1
        '
        'tnama
        '
        Me.tnama.Location = New System.Drawing.Point(137, 42)
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(329, 20)
        Me.tnama.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(12, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Karyawan"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nik"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(6, 355)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(1094, 324)
        Me.DGV.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1112, 109)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bbaru)
        Me.GroupBox3.Controls.Add(Me.bsimpan)
        Me.GroupBox3.Controls.Add(Me.bhapus)
        Me.GroupBox3.Controls.Add(Me.bbatal)
        Me.GroupBox3.Controls.Add(Me.bprint)
        Me.GroupBox3.Controls.Add(Me.tcari)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1103, 90)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Proses"
        '
        'bbaru
        '
        Me.bbaru.Dock = System.Windows.Forms.DockStyle.Right
        Me.bbaru.Image = CType(resources.GetObject("bbaru.Image"), System.Drawing.Image)
        Me.bbaru.Location = New System.Drawing.Point(635, 16)
        Me.bbaru.Name = "bbaru"
        Me.bbaru.Size = New System.Drawing.Size(93, 71)
        Me.bbaru.TabIndex = 21
        Me.bbaru.Text = "Baru"
        Me.bbaru.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bbaru.UseVisualStyleBackColor = True
        '
        'bsimpan
        '
        Me.bsimpan.Dock = System.Windows.Forms.DockStyle.Right
        Me.bsimpan.Image = CType(resources.GetObject("bsimpan.Image"), System.Drawing.Image)
        Me.bsimpan.Location = New System.Drawing.Point(728, 16)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(93, 71)
        Me.bsimpan.TabIndex = 20
        Me.bsimpan.Text = "Simpan"
        Me.bsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bsimpan.UseVisualStyleBackColor = True
        '
        'bhapus
        '
        Me.bhapus.Dock = System.Windows.Forms.DockStyle.Right
        Me.bhapus.Image = CType(resources.GetObject("bhapus.Image"), System.Drawing.Image)
        Me.bhapus.Location = New System.Drawing.Point(821, 16)
        Me.bhapus.Name = "bhapus"
        Me.bhapus.Size = New System.Drawing.Size(93, 71)
        Me.bhapus.TabIndex = 19
        Me.bhapus.Text = "Hapus"
        Me.bhapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bhapus.UseVisualStyleBackColor = True
        '
        'bbatal
        '
        Me.bbatal.Dock = System.Windows.Forms.DockStyle.Right
        Me.bbatal.Image = CType(resources.GetObject("bbatal.Image"), System.Drawing.Image)
        Me.bbatal.Location = New System.Drawing.Point(914, 16)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(93, 71)
        Me.bbatal.TabIndex = 18
        Me.bbatal.Text = "Batal"
        Me.bbatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bbatal.UseVisualStyleBackColor = True
        '
        'bprint
        '
        Me.bprint.Dock = System.Windows.Forms.DockStyle.Right
        Me.bprint.Image = CType(resources.GetObject("bprint.Image"), System.Drawing.Image)
        Me.bprint.Location = New System.Drawing.Point(1007, 16)
        Me.bprint.Name = "bprint"
        Me.bprint.Size = New System.Drawing.Size(93, 71)
        Me.bprint.TabIndex = 9
        Me.bprint.Text = "Print"
        Me.bprint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bprint.UseVisualStyleBackColor = True
        '
        'tcari
        '
        Me.tcari.Location = New System.Drawing.Point(3, 32)
        Me.tcari.Multiline = True
        Me.tcari.Name = "tcari"
        Me.tcari.Size = New System.Drawing.Size(627, 42)
        Me.tcari.TabIndex = 0
        '
        'tdept
        '
        Me.tdept.Location = New System.Drawing.Point(930, 42)
        Me.tdept.Name = "tdept"
        Me.tdept.Size = New System.Drawing.Size(170, 20)
        Me.tdept.TabIndex = 24
        '
        'bimport
        '
        Me.bimport.Location = New System.Drawing.Point(293, 14)
        Me.bimport.Name = "bimport"
        Me.bimport.Size = New System.Drawing.Size(75, 23)
        Me.bimport.TabIndex = 28
        Me.bimport.Text = "..."
        Me.bimport.UseVisualStyleBackColor = True
        '
        'FormKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 691)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormKaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKaryawan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cstatus As System.Windows.Forms.ComboBox
    Friend WithEvents dtpgabung As System.Windows.Forms.DateTimePicker
    Friend WithEvents temail As System.Windows.Forms.TextBox
    Friend WithEvents tnpwp As System.Windows.Forms.TextBox
    Friend WithEvents talamat As System.Windows.Forms.TextBox
    Friend WithEvents ttelp As System.Windows.Forms.TextBox
    Friend WithEvents dtplahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents cjab As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cdept As System.Windows.Forms.ComboBox
    Friend WithEvents ttempatlahir As System.Windows.Forms.TextBox
    Friend WithEvents tnik As System.Windows.Forms.TextBox
    Friend WithEvents tnama As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents bbaru As System.Windows.Forms.Button
    Friend WithEvents bsimpan As System.Windows.Forms.Button
    Friend WithEvents bhapus As System.Windows.Forms.Button
    Friend WithEvents bbatal As System.Windows.Forms.Button
    Friend WithEvents bprint As System.Windows.Forms.Button
    Friend WithEvents tcari As System.Windows.Forms.TextBox
    Friend WithEvents tjab As System.Windows.Forms.TextBox
    Friend WithEvents cpendidikan As System.Windows.Forms.ComboBox
    Friend WithEvents tdept As System.Windows.Forms.TextBox
    Friend WithEvents tnamadept As System.Windows.Forms.TextBox
    Friend WithEvents bimport As System.Windows.Forms.Button
End Class
