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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRecommend = New System.Windows.Forms.Label()
        Me.lblPennyVal = New System.Windows.Forms.Label()
        Me.txtSalaryRaise = New System.Windows.Forms.TextBox()
        Me.rtbInfo = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Raise Amount (Per Month)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Penny Doubled every day will be:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(174, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Recommendation:"
        '
        'lblRecommend
        '
        Me.lblRecommend.AutoSize = True
        Me.lblRecommend.Location = New System.Drawing.Point(111, 104)
        Me.lblRecommend.Name = "lblRecommend"
        Me.lblRecommend.Size = New System.Drawing.Size(39, 13)
        Me.lblRecommend.TabIndex = 4
        Me.lblRecommend.Text = "Label4"
        '
        'lblPennyVal
        '
        Me.lblPennyVal.AutoSize = True
        Me.lblPennyVal.Location = New System.Drawing.Point(182, 37)
        Me.lblPennyVal.Name = "lblPennyVal"
        Me.lblPennyVal.Size = New System.Drawing.Size(39, 13)
        Me.lblPennyVal.TabIndex = 5
        Me.lblPennyVal.Text = "Label5"
        '
        'txtSalaryRaise
        '
        Me.txtSalaryRaise.Location = New System.Drawing.Point(149, 6)
        Me.txtSalaryRaise.Name = "txtSalaryRaise"
        Me.txtSalaryRaise.Size = New System.Drawing.Size(100, 20)
        Me.txtSalaryRaise.TabIndex = 6
        '
        'rtbInfo
        '
        Me.rtbInfo.Location = New System.Drawing.Point(12, 146)
        Me.rtbInfo.Name = "rtbInfo"
        Me.rtbInfo.Size = New System.Drawing.Size(467, 271)
        Me.rtbInfo.TabIndex = 7
        Me.rtbInfo.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 429)
        Me.Controls.Add(Me.rtbInfo)
        Me.Controls.Add(Me.txtSalaryRaise)
        Me.Controls.Add(Me.lblPennyVal)
        Me.Controls.Add(Me.lblRecommend)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Penny Application - Jake Ildefonso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRecommend As Label
    Friend WithEvents lblPennyVal As Label
    Friend WithEvents txtSalaryRaise As TextBox
    Friend WithEvents rtbInfo As RichTextBox
End Class
