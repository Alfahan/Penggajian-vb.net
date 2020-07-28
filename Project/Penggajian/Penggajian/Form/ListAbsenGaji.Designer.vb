<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListAbsenGaji
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tcari = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.dtptgl = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tcari)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(964, 51)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'tcari
        '
        Me.tcari.Dock = System.Windows.Forms.DockStyle.Top
        Me.tcari.Location = New System.Drawing.Point(3, 16)
        Me.tcari.Name = "tcari"
        Me.tcari.Size = New System.Drawing.Size(958, 20)
        Me.tcari.TabIndex = 0
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(0, 46)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(959, 253)
        Me.DGV.TabIndex = 2
        '
        'dtptgl
        '
        Me.dtptgl.Location = New System.Drawing.Point(773, 321)
        Me.dtptgl.Name = "dtptgl"
        Me.dtptgl.Size = New System.Drawing.Size(200, 20)
        Me.dtptgl.TabIndex = 4
        '
        'ListAbsenGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 311)
        Me.Controls.Add(Me.dtptgl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV)
        Me.Name = "ListAbsenGaji"
        Me.Text = "ListAbsenGaji"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tcari As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents dtptgl As System.Windows.Forms.DateTimePicker
End Class
