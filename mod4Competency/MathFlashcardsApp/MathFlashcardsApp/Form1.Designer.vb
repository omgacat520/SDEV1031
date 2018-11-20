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
        Me.lblRndNum1 = New System.Windows.Forms.Label()
        Me.lblRndNum2 = New System.Windows.Forms.Label()
        Me.lblPlusSign = New System.Windows.Forms.Label()
        Me.lblEqualsSign = New System.Windows.Forms.Label()
        Me.btnNewProblem = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.mtbAnswer = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lblRndNum1
        '
        Me.lblRndNum1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRndNum1.Location = New System.Drawing.Point(45, 9)
        Me.lblRndNum1.Name = "lblRndNum1"
        Me.lblRndNum1.Size = New System.Drawing.Size(161, 23)
        Me.lblRndNum1.TabIndex = 0
        Me.lblRndNum1.Text = "RandomNumber1"
        Me.lblRndNum1.Visible = False
        '
        'lblRndNum2
        '
        Me.lblRndNum2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRndNum2.Location = New System.Drawing.Point(45, 50)
        Me.lblRndNum2.Name = "lblRndNum2"
        Me.lblRndNum2.Size = New System.Drawing.Size(161, 25)
        Me.lblRndNum2.TabIndex = 1
        Me.lblRndNum2.Text = "RandomNumber2"
        Me.lblRndNum2.Visible = False
        '
        'lblPlusSign
        '
        Me.lblPlusSign.AutoSize = True
        Me.lblPlusSign.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlusSign.Location = New System.Drawing.Point(12, 52)
        Me.lblPlusSign.Name = "lblPlusSign"
        Me.lblPlusSign.Size = New System.Drawing.Size(22, 22)
        Me.lblPlusSign.TabIndex = 2
        Me.lblPlusSign.Text = "+"
        Me.lblPlusSign.Visible = False
        '
        'lblEqualsSign
        '
        Me.lblEqualsSign.AutoSize = True
        Me.lblEqualsSign.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEqualsSign.Location = New System.Drawing.Point(13, 87)
        Me.lblEqualsSign.Name = "lblEqualsSign"
        Me.lblEqualsSign.Size = New System.Drawing.Size(21, 22)
        Me.lblEqualsSign.TabIndex = 4
        Me.lblEqualsSign.Text = "="
        Me.lblEqualsSign.Visible = False
        '
        'btnNewProblem
        '
        Me.btnNewProblem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNewProblem.Location = New System.Drawing.Point(50, 115)
        Me.btnNewProblem.Name = "btnNewProblem"
        Me.btnNewProblem.Size = New System.Drawing.Size(156, 23)
        Me.btnNewProblem.TabIndex = 5
        Me.btnNewProblem.Text = "New problem"
        Me.btnNewProblem.UseVisualStyleBackColor = False
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCheck.Location = New System.Drawing.Point(50, 144)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(156, 23)
        Me.btnCheck.TabIndex = 6
        Me.btnCheck.Text = "Check my answer"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'lblResults
        '
        Me.lblResults.BackColor = System.Drawing.Color.White
        Me.lblResults.Location = New System.Drawing.Point(14, 183)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(192, 42)
        Me.lblResults.TabIndex = 7
        Me.lblResults.Text = "OutputResults"
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblResults.Visible = False
        '
        'mtbAnswer
        '
        Me.mtbAnswer.HidePromptOnLeave = True
        Me.mtbAnswer.Location = New System.Drawing.Point(50, 89)
        Me.mtbAnswer.Mask = "000"
        Me.mtbAnswer.Name = "mtbAnswer"
        Me.mtbAnswer.RejectInputOnFirstFailure = True
        Me.mtbAnswer.Size = New System.Drawing.Size(30, 20)
        Me.mtbAnswer.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(224, 234)
        Me.Controls.Add(Me.mtbAnswer)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnNewProblem)
        Me.Controls.Add(Me.lblEqualsSign)
        Me.Controls.Add(Me.lblPlusSign)
        Me.Controls.Add(Me.lblRndNum2)
        Me.Controls.Add(Me.lblRndNum1)
        Me.Name = "Form1"
        Me.Text = "Math Flash Cards - Jake Ildefonso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRndNum1 As Label
    Friend WithEvents lblRndNum2 As Label
    Friend WithEvents lblPlusSign As Label
    Friend WithEvents lblEqualsSign As Label
    Friend WithEvents btnNewProblem As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblResults As Label
    Friend WithEvents mtbAnswer As MaskedTextBox
End Class
