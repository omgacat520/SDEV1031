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
        Me.btnExe = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please type sentence or phrase"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(15, 25)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(263, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnExe
        '
        Me.btnExe.Location = New System.Drawing.Point(15, 132)
        Me.btnExe.Name = "btnExe"
        Me.btnExe.Size = New System.Drawing.Size(263, 23)
        Me.btnExe.TabIndex = 2
        Me.btnExe.Text = "Is it a pangram?"
        Me.btnExe.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(12, 48)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(266, 81)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "zis be mein output"
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOutput.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 167)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnExe)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pangram App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnExe As Button
    Friend WithEvents lblOutput As Label
End Class
