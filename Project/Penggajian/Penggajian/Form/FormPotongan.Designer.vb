<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPotongan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPotongan))
        Me.tcari = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bprint = New System.Windows.Forms.Button()
        Me.bbatal = New System.Windows.Forms.Button()
        Me.bhapus = New System.Windows.Forms.Button()
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.bbaru = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tjumlah = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tidpotongan = New System.Windows.Forms.TextBox()
        Me.tnamapotongan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bprint)
        Me.GroupBox3.Controls.Add(Me.bbatal)
        Me.GroupBox3.Controls.Add(Me.bhapus)
        Me.GroupBox3.Controls.Add(Me.bsimpan)
        Me.GroupBox3.Controls.Add(Me.bbaru)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 108)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(483, 90)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Proses"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tjumlah)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tidpotongan)
        Me.GroupBox1.Controls.Add(Me.tnamapotongan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 108)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'tjumlah
        '
        Me.tjumlah.Location = New System.Drawing.Point(137, 68)
        Me.tjumlah.Name = "tjumlah"
        Me.tjumlah.Size = New System.Drawing.Size(150, 20)
        Me.tjumlah.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jumlah"
        '
        'tidpotongan
        '
        Me.tidpotongan.Location = New System.Drawing.Point(137, 14)
        Me.tidpotongan.Name = "tidpotongan"
        Me.tidpotongan.Size = New System.Drawing.Size(150, 20)
        Me.tidpotongan.TabIndex = 1
        '
        'tnamapotongan
        '
        Me.tnamapotongan.Location = New System.Drawing.Point(137, 42)
        Me.tnamapotongan.Name = "tnamapotongan"
        Me.tnamapotongan.Size = New System.Drawing.Size(333, 20)
        Me.tnamapotongan.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Potongan"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Potongan"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(3, 256)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(473, 147)
        Me.DGV.TabIndex = 27
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tcari)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 204)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(467, 46)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cari Data"
        '
        'FormPotongan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 409)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPotongan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPotongan"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcari As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents bprint As System.Windows.Forms.Button
    Friend WithEvents bbatal As System.Windows.Forms.Button
    Friend WithEvents bhapus As System.Windows.Forms.Button
    Friend WithEvents bsimpan As System.Windows.Forms.Button
    Friend WithEvents bbaru As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tidpotongan As System.Windows.Forms.TextBox
    Friend WithEvents tnamapotongan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
