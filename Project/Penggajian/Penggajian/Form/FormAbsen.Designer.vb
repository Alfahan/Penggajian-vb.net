<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbsen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAbsen))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtptgl = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tidabsen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bbaru = New System.Windows.Forms.Button()
        Me.bimport = New System.Windows.Forms.Button()
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.bbatal = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtptgl)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tidabsen)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(866, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dtptgl
        '
        Me.dtptgl.Location = New System.Drawing.Point(121, 50)
        Me.dtptgl.Name = "dtptgl"
        Me.dtptgl.Size = New System.Drawing.Size(200, 20)
        Me.dtptgl.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tanggal"
        '
        'tidabsen
        '
        Me.tidabsen.Location = New System.Drawing.Point(121, 16)
        Me.tidabsen.Name = "tidabsen"
        Me.tidabsen.Size = New System.Drawing.Size(150, 20)
        Me.tidabsen.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Id Absen"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bbaru)
        Me.GroupBox2.Controls.Add(Me.bimport)
        Me.GroupBox2.Controls.Add(Me.bsimpan)
        Me.GroupBox2.Controls.Add(Me.bbatal)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(866, 101)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'bbaru
        '
        Me.bbaru.Dock = System.Windows.Forms.DockStyle.Right
        Me.bbaru.Image = CType(resources.GetObject("bbaru.Image"), System.Drawing.Image)
        Me.bbaru.Location = New System.Drawing.Point(491, 16)
        Me.bbaru.Name = "bbaru"
        Me.bbaru.Size = New System.Drawing.Size(93, 82)
        Me.bbaru.TabIndex = 21
        Me.bbaru.Text = "Baru"
        Me.bbaru.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bbaru.UseVisualStyleBackColor = True
        '
        'bimport
        '
        Me.bimport.Dock = System.Windows.Forms.DockStyle.Right
        Me.bimport.Image = CType(resources.GetObject("bimport.Image"), System.Drawing.Image)
        Me.bimport.Location = New System.Drawing.Point(584, 16)
        Me.bimport.Name = "bimport"
        Me.bimport.Size = New System.Drawing.Size(93, 82)
        Me.bimport.TabIndex = 20
        Me.bimport.Text = "Import"
        Me.bimport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bimport.UseVisualStyleBackColor = True
        '
        'bsimpan
        '
        Me.bsimpan.Dock = System.Windows.Forms.DockStyle.Right
        Me.bsimpan.Image = CType(resources.GetObject("bsimpan.Image"), System.Drawing.Image)
        Me.bsimpan.Location = New System.Drawing.Point(677, 16)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(93, 82)
        Me.bsimpan.TabIndex = 19
        Me.bsimpan.Text = "Simpan"
        Me.bsimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bsimpan.UseVisualStyleBackColor = True
        '
        'bbatal
        '
        Me.bbatal.Dock = System.Windows.Forms.DockStyle.Right
        Me.bbatal.Image = CType(resources.GetObject("bbatal.Image"), System.Drawing.Image)
        Me.bbatal.Location = New System.Drawing.Point(770, 16)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(93, 82)
        Me.bbatal.TabIndex = 18
        Me.bbatal.Text = "Batal"
        Me.bbatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bbatal.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(3, 202)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(851, 201)
        Me.DGV.TabIndex = 2
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormAbsen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 413)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAbsen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAbsen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tidabsen As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bbaru As System.Windows.Forms.Button
    Friend WithEvents bimport As System.Windows.Forms.Button
    Friend WithEvents bsimpan As System.Windows.Forms.Button
    Friend WithEvents bbatal As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dtptgl As System.Windows.Forms.DateTimePicker
End Class
