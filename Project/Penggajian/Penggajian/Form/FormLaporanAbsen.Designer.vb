<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanAbsen
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
        Me.bcetak = New System.Windows.Forms.Button()
        Me.dtptgl = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bcetak
        '
        Me.bcetak.Location = New System.Drawing.Point(192, 90)
        Me.bcetak.Name = "bcetak"
        Me.bcetak.Size = New System.Drawing.Size(75, 23)
        Me.bcetak.TabIndex = 2
        Me.bcetak.Text = "Cetak"
        Me.bcetak.UseVisualStyleBackColor = True
        '
        'dtptgl
        '
        Me.dtptgl.Location = New System.Drawing.Point(67, 50)
        Me.dtptgl.Name = "dtptgl"
        Me.dtptgl.Size = New System.Drawing.Size(200, 20)
        Me.dtptgl.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LAPORAN ABSEN"
        '
        'FormLaporanAbsen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 134)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtptgl)
        Me.Controls.Add(Me.bcetak)
        Me.Name = "FormLaporanAbsen"
        Me.Text = "FormLaporanAbsen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bcetak As System.Windows.Forms.Button
    Friend WithEvents dtptgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
