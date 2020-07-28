<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImportKaryawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormImportKaryawan))
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bimport = New System.Windows.Forms.Button()
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.bbatal = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(2, 3)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(874, 230)
        Me.DGV.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bimport)
        Me.GroupBox2.Controls.Add(Me.bsimpan)
        Me.GroupBox2.Controls.Add(Me.bbatal)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(877, 101)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'bimport
        '
        Me.bimport.Dock = System.Windows.Forms.DockStyle.Right
        Me.bimport.Image = CType(resources.GetObject("bimport.Image"), System.Drawing.Image)
        Me.bimport.Location = New System.Drawing.Point(595, 16)
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
        Me.bsimpan.Location = New System.Drawing.Point(688, 16)
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
        Me.bbatal.Location = New System.Drawing.Point(781, 16)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(93, 82)
        Me.bbatal.TabIndex = 18
        Me.bbatal.Text = "Batal"
        Me.bbatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bbatal.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormImportKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 332)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGV)
        Me.Name = "FormImportKaryawan"
        Me.Text = "FormImportKaryawan"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bimport As System.Windows.Forms.Button
    Friend WithEvents bsimpan As System.Windows.Forms.Button
    Friend WithEvents bbatal As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
