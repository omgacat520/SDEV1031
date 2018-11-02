<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Choose = New System.Windows.Forms.Label()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOutput1 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.nudDesired = New System.Windows.Forms.NumericUpDown()
        Me.rtbInfo = New System.Windows.Forms.RichTextBox()
        CType(Me.nudDesired, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Choose
        '
        Me.Choose.AutoSize = True
        Me.Choose.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Choose.Location = New System.Drawing.Point(12, 9)
        Me.Choose.Name = "Choose"
        Me.Choose.Size = New System.Drawing.Size(294, 18)
        Me.Choose.TabIndex = 1
        Me.Choose.Text = "Choose a number between 1 and 6!"
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(15, 30)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 2
        Me.btnRoll.Text = "Roll!"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(96, 30)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Quit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblOutput1
        '
        Me.lblOutput1.AutoSize = True
        Me.lblOutput1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput1.Location = New System.Drawing.Point(12, 110)
        Me.lblOutput1.Name = "lblOutput1"
        Me.lblOutput1.Size = New System.Drawing.Size(141, 18)
        Me.lblOutput1.TabIndex = 4
        Me.lblOutput1.Text = "Number of rolls: "
        Me.lblOutput1.Visible = False
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(159, 110)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(83, 18)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.Text = "lblOutput"
        Me.lblOutput.Visible = False
        '
        'nudDesired
        '
        Me.nudDesired.Location = New System.Drawing.Point(15, 59)
        Me.nudDesired.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudDesired.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDesired.Name = "nudDesired"
        Me.nudDesired.Size = New System.Drawing.Size(120, 20)
        Me.nudDesired.TabIndex = 6
        Me.nudDesired.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rtbInfo
        '
        Me.rtbInfo.Location = New System.Drawing.Point(177, 30)
        Me.rtbInfo.Name = "rtbInfo"
        Me.rtbInfo.Size = New System.Drawing.Size(143, 77)
        Me.rtbInfo.TabIndex = 7
        Me.rtbInfo.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 142)
        Me.Controls.Add(Me.rtbInfo)
        Me.Controls.Add(Me.nudDesired)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblOutput1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.Choose)
        Me.Name = "Form1"
        Me.Text = "How Many Rolls?"
        CType(Me.nudDesired, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Choose As Label
    Friend WithEvents btnRoll As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblOutput1 As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents nudDesired As NumericUpDown
    Friend WithEvents rtbInfo As RichTextBox
End Class
