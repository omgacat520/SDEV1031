<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepreciation
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
        Me.rtbOut = New System.Windows.Forms.RichTextBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnDepreciate = New System.Windows.Forms.Button
        Me.nudValue = New System.Windows.Forms.NumericUpDown
        Me.nudSalvage = New System.Windows.Forms.NumericUpDown
        Me.nudLife = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSalvage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLife, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtbOut
        '
        Me.rtbOut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rtbOut.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbOut.Location = New System.Drawing.Point(0, 0)
        Me.rtbOut.Name = "rtbOut"
        Me.rtbOut.Size = New System.Drawing.Size(206, 278)
        Me.rtbOut.TabIndex = 0
        Me.rtbOut.Text = ""
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(355, 221)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDepreciate
        '
        Me.btnDepreciate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepreciate.Location = New System.Drawing.Point(355, 175)
        Me.btnDepreciate.Name = "btnDepreciate"
        Me.btnDepreciate.Size = New System.Drawing.Size(111, 30)
        Me.btnDepreciate.TabIndex = 5
        Me.btnDepreciate.Text = "&Depreciation"
        Me.btnDepreciate.UseVisualStyleBackColor = True
        '
        'nudValue
        '
        Me.nudValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudValue.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudValue.Location = New System.Drawing.Point(257, 25)
        Me.nudValue.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudValue.Name = "nudValue"
        Me.nudValue.Size = New System.Drawing.Size(92, 26)
        Me.nudValue.TabIndex = 6
        Me.nudValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudSalvage
        '
        Me.nudSalvage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSalvage.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudSalvage.Location = New System.Drawing.Point(257, 73)
        Me.nudSalvage.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudSalvage.Name = "nudSalvage"
        Me.nudSalvage.Size = New System.Drawing.Size(92, 26)
        Me.nudSalvage.TabIndex = 7
        Me.nudSalvage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLife
        '
        Me.nudLife.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLife.Location = New System.Drawing.Point(257, 121)
        Me.nudLife.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudLife.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLife.Name = "nudLife"
        Me.nudLife.Size = New System.Drawing.Size(92, 26)
        Me.nudLife.TabIndex = 8
        Me.nudLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudLife.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(355, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Initial Value"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(355, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Salvage Value"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(355, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Expected Life"
        '
        'frmDepreciation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 273)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudLife)
        Me.Controls.Add(Me.nudSalvage)
        Me.Controls.Add(Me.nudValue)
        Me.Controls.Add(Me.btnDepreciate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.rtbOut)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDepreciation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Depreciation Calculator"
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSalvage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLife, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbOut As System.Windows.Forms.RichTextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDepreciate As System.Windows.Forms.Button
    Friend WithEvents nudValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSalvage As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudLife As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
