<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJabatan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJabatan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tidjab = New System.Windows.Forms.TextBox()
        Me.tnamajab = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tcari = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.bbaru = New System.Windows.Forms.Button()
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.bhapus = New System.Windows.Forms.Button()
        Me.bbatal = New System.Windows.Forms.Button()
        Me.bprint = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tidjab)
        Me.GroupBox1.Controls.Add(Me.tnamajab)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 85)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'tidjab
        '
        Me.tidjab.Location = New System.Drawing.Point(137, 14)
        Me.tidjab.Name = "tidjab"
        Me.tidjab.Size = New System.Drawing.Size(150, 20)
        Me.tidjab.TabIndex = 1
        '
        'tnamajab
        '
        Me.tnamajab.Location = New System.Drawing.Point(137, 42)
        Me.tnamajab.Name = "tnamajab"
        Me.tnamajab.Size = New System.Drawing.Size(318, 20)
        Me.tnamajab.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Jabatan"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Jabatan"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tcari)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 181)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(467, 46)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cari Data"
        '
        'tcari
        '
        Me.tcari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcari.Location = New System.Drawing.Point(3, 16)
        Me.tcari.Multiline = True
        Me.tcari.Name = "tcari"
        Me.tcari.Size = New System.Drawing.Size(461, 27)
        Me.tcari.TabIndex = 0
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(3, 233)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(473, 133)
        Me.DGV.TabIndex = 19
        '
        'bbaru
        '
        Me.bbaru.Dock = System.Windows.Forms.DockStyle.Left
        Me.bbaru.Image = CType(resources.GetObject("bbaru.Image"), System.Drawing.Image)
        Me.bbaru.Location = New System.Drawing.Point(3, 16)
        Me.bbaru.Name = "bbaru"
        Me.bbaru.Size = New System.Drawing.Size(93, 71)
        Me.bbaru.TabIndex = 4
        Me.bbaru.Text = "Baru"
        Me.bbaru.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bbaru.UseVisualStyleBackColor = True
        '
        'bsimpan
        '
        Me.bsimpan.Dock = System.Windows.Forms.DockStyle.Left
        Me.bsimpan.Image = CType(resources.GetObject("bsimpan.Image"), System.Drawing.Image)
        Me.bsimpan.Location = New System.Drawing.Point(96, 16)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(93, 71)
        Me.bsimpan.TabIndex = 5
        Me.bsimpan.Text = "Simpan"
        Me.bsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bsimpan.UseVisualStyleBackColor = True
        '
        'bhapus
        '
        Me.bhapus.Dock = System.Windows.Forms.DockStyle.Left
        Me.bhapus.Image = CType(resources.GetObject("bhapus.Image"), System.Drawing.Image)
        Me.bhapus.Location = New System.Drawing.Point(189, 16)
        Me.bhapus.Name = "bhapus"
        Me.bhapus.Size = New System.Drawing.Size(93, 71)
        Me.bhapus.TabIndex = 6
        Me.bhapus.Text = "Hapus"
        Me.bhapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bhapus.UseVisualStyleBackColor = True
        '
        'bbatal
        '
        Me.bbatal.Dock = System.Windows.Forms.DockStyle.Left
        Me.bbatal.Image = CType(resources.GetObject("bbatal.Image"), System.Drawing.Image)
        Me.bbatal.Location = New System.Drawing.Point(282, 16)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(93, 71)
        Me.bbatal.TabIndex = 7
        Me.bbatal.Text = "Batal"
        Me.bbatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bbatal.UseVisualStyleBackColor = True
        '
        'bprint
        '
        Me.bprint.Dock = System.Windows.Forms.DockStyle.Left
        Me.bprint.Image = CType(resources.GetObject("bprint.Image"), System.Drawing.Image)
        Me.bprint.Location = New System.Drawing.Point(375, 16)
        Me.bprint.Name = "bprint"
        Me.bprint.Size = New System.Drawing.Size(93, 71)
        Me.bprint.TabIndex = 8
        Me.bprint.Text = "Print"
        Me.bprint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bprint.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bprint)
        Me.GroupBox3.Controls.Add(Me.bbatal)
        Me.GroupBox3.Controls.Add(Me.bhapus)
        Me.GroupBox3.Controls.Add(Me.bsimpan)
        Me.GroupBox3.Controls.Add(Me.bbaru)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(484, 90)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Proses"
        '
        'FormJabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 375)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormJabatan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormJabatan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tidjab As System.Windows.Forms.TextBox
    Friend WithEvents tnamajab As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tcari As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents bbaru As System.Windows.Forms.Button
    Friend WithEvents bsimpan As System.Windows.Forms.Button
    Friend WithEvents bhapus As System.Windows.Forms.Button
    Friend WithEvents bbatal As System.Windows.Forms.Button
    Friend WithEvents bprint As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
