<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formuser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formuser))
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bprint = New System.Windows.Forms.Button()
        Me.bbatal = New System.Windows.Forms.Button()
        Me.bhapus = New System.Windows.Forms.Button()
        Me.bbaru = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.clevel = New System.Windows.Forms.ComboBox()
        Me.tpassword = New System.Windows.Forms.TextBox()
        Me.tiduser = New System.Windows.Forms.TextBox()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tcari = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(478, 109)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bprint)
        Me.GroupBox3.Controls.Add(Me.bbatal)
        Me.GroupBox3.Controls.Add(Me.bhapus)
        Me.GroupBox3.Controls.Add(Me.bsimpan)
        Me.GroupBox3.Controls.Add(Me.bbaru)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(463, 90)
        Me.GroupBox3.TabIndex = 2
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
        Me.GroupBox1.Controls.Add(Me.clevel)
        Me.GroupBox1.Controls.Add(Me.tpassword)
        Me.GroupBox1.Controls.Add(Me.tiduser)
        Me.GroupBox1.Controls.Add(Me.tnama)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 137)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'clevel
        '
        Me.clevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.clevel.FormattingEnabled = True
        Me.clevel.Location = New System.Drawing.Point(137, 100)
        Me.clevel.Name = "clevel"
        Me.clevel.Size = New System.Drawing.Size(150, 21)
        Me.clevel.TabIndex = 4
        '
        'tpassword
        '
        Me.tpassword.Location = New System.Drawing.Point(137, 72)
        Me.tpassword.Name = "tpassword"
        Me.tpassword.Size = New System.Drawing.Size(150, 20)
        Me.tpassword.TabIndex = 3
        '
        'tiduser
        '
        Me.tiduser.Location = New System.Drawing.Point(137, 14)
        Me.tiduser.Name = "tiduser"
        Me.tiduser.Size = New System.Drawing.Size(150, 20)
        Me.tiduser.TabIndex = 1
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
        Me.Label4.Text = "Level"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama User"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id User"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(3, 313)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(466, 196)
        Me.DGV.TabIndex = 15
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tcari)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 246)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(478, 61)
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
        Me.tcari.Size = New System.Drawing.Size(472, 42)
        Me.tcari.TabIndex = 0
        '
        'Formuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 521)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Formuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUser"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bsimpan As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents bprint As System.Windows.Forms.Button
    Friend WithEvents bbatal As System.Windows.Forms.Button
    Friend WithEvents bhapus As System.Windows.Forms.Button
    Friend WithEvents bbaru As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents clevel As System.Windows.Forms.ComboBox
    Friend WithEvents tpassword As System.Windows.Forms.TextBox
    Friend WithEvents tiduser As System.Windows.Forms.TextBox
    Friend WithEvents tnama As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tcari As System.Windows.Forms.TextBox

End Class
