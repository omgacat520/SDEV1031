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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUppercase = New System.Windows.Forms.Button()
        Me.btnLowercase = New System.Windows.Forms.Button()
        Me.btnLength = New System.Windows.Forms.Button()
        Me.btnPadLeft = New System.Windows.Forms.Button()
        Me.btnTrim = New System.Windows.Forms.Button()
        Me.btnPadRight = New System.Windows.Forms.Button()
        Me.btnIndexSpace = New System.Windows.Forms.Button()
        Me.btnSubStr5 = New System.Windows.Forms.Button()
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a name or phrase"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(12, 25)
        Me.txtInput.MaxLength = 55
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(301, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnUppercase
        '
        Me.btnUppercase.Location = New System.Drawing.Point(16, 108)
        Me.btnUppercase.Name = "btnUppercase"
        Me.btnUppercase.Size = New System.Drawing.Size(95, 22)
        Me.btnUppercase.TabIndex = 2
        Me.btnUppercase.Text = "UPPERCASE"
        Me.ToolTip1.SetToolTip(Me.btnUppercase, "Turns all characters Uppercase")
        Me.btnUppercase.UseVisualStyleBackColor = True
        '
        'btnLowercase
        '
        Me.btnLowercase.Location = New System.Drawing.Point(117, 108)
        Me.btnLowercase.Name = "btnLowercase"
        Me.btnLowercase.Size = New System.Drawing.Size(95, 22)
        Me.btnLowercase.TabIndex = 3
        Me.btnLowercase.Text = "lowercase"
        Me.ToolTip1.SetToolTip(Me.btnLowercase, "Turns all characters lowercase.")
        Me.btnLowercase.UseVisualStyleBackColor = True
        '
        'btnLength
        '
        Me.btnLength.Location = New System.Drawing.Point(218, 108)
        Me.btnLength.Name = "btnLength"
        Me.btnLength.Size = New System.Drawing.Size(95, 22)
        Me.btnLength.TabIndex = 4
        Me.btnLength.Text = "Length"
        Me.ToolTip1.SetToolTip(Me.btnLength, "Displays length")
        Me.btnLength.UseVisualStyleBackColor = True
        '
        'btnPadLeft
        '
        Me.btnPadLeft.Location = New System.Drawing.Point(16, 136)
        Me.btnPadLeft.Name = "btnPadLeft"
        Me.btnPadLeft.Size = New System.Drawing.Size(95, 22)
        Me.btnPadLeft.TabIndex = 5
        Me.btnPadLeft.Text = "Pad Left 20"
        Me.ToolTip1.SetToolTip(Me.btnPadLeft, "Creates a phrase 20 characters long, using spaces and one @ symbol")
        Me.btnPadLeft.UseVisualStyleBackColor = True
        '
        'btnTrim
        '
        Me.btnTrim.Location = New System.Drawing.Point(117, 137)
        Me.btnTrim.Name = "btnTrim"
        Me.btnTrim.Size = New System.Drawing.Size(95, 22)
        Me.btnTrim.TabIndex = 6
        Me.btnTrim.Text = "Trim"
        Me.ToolTip1.SetToolTip(Me.btnTrim, "Trims outside spaces")
        Me.btnTrim.UseVisualStyleBackColor = True
        '
        'btnPadRight
        '
        Me.btnPadRight.Location = New System.Drawing.Point(218, 137)
        Me.btnPadRight.Name = "btnPadRight"
        Me.btnPadRight.Size = New System.Drawing.Size(95, 22)
        Me.btnPadRight.TabIndex = 7
        Me.btnPadRight.Text = "Pad Right 20"
        Me.ToolTip1.SetToolTip(Me.btnPadRight, "Does what Padleft does but with asterisks.")
        Me.btnPadRight.UseVisualStyleBackColor = True
        '
        'btnIndexSpace
        '
        Me.btnIndexSpace.Location = New System.Drawing.Point(16, 165)
        Me.btnIndexSpace.Name = "btnIndexSpace"
        Me.btnIndexSpace.Size = New System.Drawing.Size(95, 22)
        Me.btnIndexSpace.TabIndex = 8
        Me.btnIndexSpace.Text = "Index Space"
        Me.ToolTip1.SetToolTip(Me.btnIndexSpace, "tells you what index value the first space character has in the string.")
        Me.btnIndexSpace.UseVisualStyleBackColor = True
        '
        'btnSubStr5
        '
        Me.btnSubStr5.Location = New System.Drawing.Point(117, 165)
        Me.btnSubStr5.Name = "btnSubStr5"
        Me.btnSubStr5.Size = New System.Drawing.Size(95, 22)
        Me.btnSubStr5.TabIndex = 9
        Me.btnSubStr5.Text = "Substring 5"
        Me.ToolTip1.SetToolTip(Me.btnSubStr5, "starts on the fifth character, and displays a string 5 characters long.")
        Me.btnSubStr5.UseVisualStyleBackColor = True
        '
        'btnReverse
        '
        Me.btnReverse.Location = New System.Drawing.Point(218, 165)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(95, 22)
        Me.btnReverse.TabIndex = 10
        Me.btnReverse.Text = "Reverse"
        Me.ToolTip1.SetToolTip(Me.btnReverse, "Reverses input")
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblOutput.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(12, 48)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(301, 49)
        Me.lblOutput.TabIndex = 11
        Me.lblOutput.Text = "OutputGoesHere"
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOutput.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 200)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.btnSubStr5)
        Me.Controls.Add(Me.btnIndexSpace)
        Me.Controls.Add(Me.btnPadRight)
        Me.Controls.Add(Me.btnTrim)
        Me.Controls.Add(Me.btnPadLeft)
        Me.Controls.Add(Me.btnLength)
        Me.Controls.Add(Me.btnLowercase)
        Me.Controls.Add(Me.btnUppercase)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "String Processing - Jake Ildefonso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnUppercase As Button
    Friend WithEvents btnLowercase As Button
    Friend WithEvents btnLength As Button
    Friend WithEvents btnPadLeft As Button
    Friend WithEvents btnTrim As Button
    Friend WithEvents btnPadRight As Button
    Friend WithEvents btnIndexSpace As Button
    Friend WithEvents btnSubStr5 As Button
    Friend WithEvents btnReverse As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
