<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanGaji
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
        Me.dtptgl = New System.Windows.Forms.DateTimePicker()
        Me.bcetak = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtptgl
        '
        Me.dtptgl.Location = New System.Drawing.Point(76, 62)
        Me.dtptgl.Name = "dtptgl"
        Me.dtptgl.Size = New System.Drawing.Size(200, 20)
        Me.dtptgl.TabIndex = 0
        '
        'bcetak
        '
        Me.bcetak.Location = New System.Drawing.Point(201, 105)
        Me.bcetak.Name = "bcetak"
        Me.bcetak.Size = New System.Drawing.Size(75, 23)
        Me.bcetak.TabIndex = 1
        Me.bcetak.Text = "Cetak"
        Me.bcetak.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LAPORAN PENGGAJIAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tanggal"
        '
        'FormLaporanGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 142)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bcetak)
        Me.Controls.Add(Me.dtptgl)
        Me.Name = "FormLaporanGaji"
        Me.Text = "FormLaporanGaji"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtptgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents bcetak As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
