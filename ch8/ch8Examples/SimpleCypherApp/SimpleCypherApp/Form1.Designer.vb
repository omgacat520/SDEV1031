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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnSubEnc = New System.Windows.Forms.Button()
        Me.lblSubOutput = New System.Windows.Forms.Label()
        Me.btnTransEnc = New System.Windows.Forms.Button()
        Me.lblTransOutput2 = New System.Windows.Forms.Label()
        Me.lblTransOutput1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type a sentence"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(15, 25)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(263, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnSubEnc
        '
        Me.btnSubEnc.Location = New System.Drawing.Point(15, 51)
        Me.btnSubEnc.Name = "btnSubEnc"
        Me.btnSubEnc.Size = New System.Drawing.Size(263, 23)
        Me.btnSubEnc.TabIndex = 2
        Me.btnSubEnc.Text = "Substitution encryption"
        Me.btnSubEnc.UseVisualStyleBackColor = True
        '
        'lblSubOutput
        '
        Me.lblSubOutput.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSubOutput.Location = New System.Drawing.Point(12, 77)
        Me.lblSubOutput.Name = "lblSubOutput"
        Me.lblSubOutput.Size = New System.Drawing.Size(266, 39)
        Me.lblSubOutput.TabIndex = 3
        Me.lblSubOutput.Text = "OutputGoesHere"
        Me.lblSubOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSubOutput.Visible = False
        '
        'btnTransEnc
        '
        Me.btnTransEnc.Location = New System.Drawing.Point(15, 119)
        Me.btnTransEnc.Name = "btnTransEnc"
        Me.btnTransEnc.Size = New System.Drawing.Size(263, 23)
        Me.btnTransEnc.TabIndex = 4
        Me.btnTransEnc.Text = "Transposition encryption"
        Me.btnTransEnc.UseVisualStyleBackColor = True
        '
        'lblTransOutput2
        '
        Me.lblTransOutput2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTransOutput2.Location = New System.Drawing.Point(15, 184)
        Me.lblTransOutput2.Name = "lblTransOutput2"
        Me.lblTransOutput2.Size = New System.Drawing.Size(263, 39)
        Me.lblTransOutput2.TabIndex = 5
        Me.lblTransOutput2.Text = "OutputGoesHere"
        Me.lblTransOutput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTransOutput2.Visible = False
        '
        'lblTransOutput1
        '
        Me.lblTransOutput1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTransOutput1.Location = New System.Drawing.Point(15, 145)
        Me.lblTransOutput1.Name = "lblTransOutput1"
        Me.lblTransOutput1.Size = New System.Drawing.Size(263, 39)
        Me.lblTransOutput1.TabIndex = 6
        Me.lblTransOutput1.Text = "OutputGoesHere"
        Me.lblTransOutput1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTransOutput1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 264)
        Me.Controls.Add(Me.lblTransOutput1)
        Me.Controls.Add(Me.lblTransOutput2)
        Me.Controls.Add(Me.btnTransEnc)
        Me.Controls.Add(Me.lblSubOutput)
        Me.Controls.Add(Me.btnSubEnc)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Simple Cipher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnSubEnc As Button
    Friend WithEvents lblSubOutput As Label
    Friend WithEvents btnTransEnc As Button
    Friend WithEvents lblTransOutput2 As Label
    Friend WithEvents lblTransOutput1 As Label
End Class
