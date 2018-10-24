<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLargest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nudNum1 = New System.Windows.Forms.NumericUpDown
        Me.nudNum2 = New System.Windows.Forms.NumericUpDown
        Me.nudNum3 = New System.Windows.Forms.NumericUpDown
        Me.lblLargest = New System.Windows.Forms.Label
        Me.btnLargest = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        CType(Me.nudNum1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNum2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNum3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudNum1
        '
        Me.nudNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNum1.Location = New System.Drawing.Point(200, 9)
        Me.nudNum1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudNum1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNum1.Name = "nudNum1"
        Me.nudNum1.Size = New System.Drawing.Size(59, 26)
        Me.nudNum1.TabIndex = 0
        Me.nudNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudNum1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudNum2
        '
        Me.nudNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNum2.Location = New System.Drawing.Point(200, 56)
        Me.nudNum2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudNum2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNum2.Name = "nudNum2"
        Me.nudNum2.Size = New System.Drawing.Size(59, 26)
        Me.nudNum2.TabIndex = 1
        Me.nudNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudNum2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudNum3
        '
        Me.nudNum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNum3.Location = New System.Drawing.Point(200, 103)
        Me.nudNum3.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudNum3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNum3.Name = "nudNum3"
        Me.nudNum3.Size = New System.Drawing.Size(59, 26)
        Me.nudNum3.TabIndex = 2
        Me.nudNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudNum3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblLargest
        '
        Me.lblLargest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLargest.Location = New System.Drawing.Point(200, 150)
        Me.lblLargest.Name = "lblLargest"
        Me.lblLargest.Size = New System.Drawing.Size(59, 23)
        Me.lblLargest.TabIndex = 3
        Me.lblLargest.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnLargest
        '
        Me.btnLargest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLargest.Location = New System.Drawing.Point(45, 219)
        Me.btnLargest.Name = "btnLargest"
        Me.btnLargest.Size = New System.Drawing.Size(75, 30)
        Me.btnLargest.TabIndex = 4
        Me.btnLargest.Text = "&Largest"
        Me.btnLargest.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(184, 219)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmLargest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLargest)
        Me.Controls.Add(Me.lblLargest)
        Me.Controls.Add(Me.nudNum3)
        Me.Controls.Add(Me.nudNum2)
        Me.Controls.Add(Me.nudNum1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLargest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Largest"
        CType(Me.nudNum1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNum2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNum3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nudNum1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudNum2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudNum3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblLargest As System.Windows.Forms.Label
    Friend WithEvents btnLargest As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
