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
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblNum3 = New System.Windows.Forms.Label()
        Me.lblNum4 = New System.Windows.Forms.Label()
        Me.lblNum5 = New System.Windows.Forms.Label()
        Me.lblNum6 = New System.Windows.Forms.Label()
        Me.lblBiggest = New System.Windows.Forms.Label()
        Me.lblSmallest = New System.Windows.Forms.Label()
        Me.btnExe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(12, 9)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(13, 13)
        Me.lblNum1.TabIndex = 0
        Me.lblNum1.Text = "0"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Location = New System.Drawing.Point(57, 9)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(13, 13)
        Me.lblNum2.TabIndex = 1
        Me.lblNum2.Text = "0"
        '
        'lblNum3
        '
        Me.lblNum3.AutoSize = True
        Me.lblNum3.Location = New System.Drawing.Point(102, 9)
        Me.lblNum3.Name = "lblNum3"
        Me.lblNum3.Size = New System.Drawing.Size(13, 13)
        Me.lblNum3.TabIndex = 2
        Me.lblNum3.Text = "0"
        '
        'lblNum4
        '
        Me.lblNum4.AutoSize = True
        Me.lblNum4.Location = New System.Drawing.Point(147, 9)
        Me.lblNum4.Name = "lblNum4"
        Me.lblNum4.Size = New System.Drawing.Size(13, 13)
        Me.lblNum4.TabIndex = 3
        Me.lblNum4.Text = "0"
        '
        'lblNum5
        '
        Me.lblNum5.AutoSize = True
        Me.lblNum5.Location = New System.Drawing.Point(192, 9)
        Me.lblNum5.Name = "lblNum5"
        Me.lblNum5.Size = New System.Drawing.Size(13, 13)
        Me.lblNum5.TabIndex = 4
        Me.lblNum5.Text = "0"
        '
        'lblNum6
        '
        Me.lblNum6.AutoSize = True
        Me.lblNum6.Location = New System.Drawing.Point(237, 9)
        Me.lblNum6.Name = "lblNum6"
        Me.lblNum6.Size = New System.Drawing.Size(13, 13)
        Me.lblNum6.TabIndex = 5
        Me.lblNum6.Text = "0"
        '
        'lblBiggest
        '
        Me.lblBiggest.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblBiggest.Location = New System.Drawing.Point(12, 37)
        Me.lblBiggest.Name = "lblBiggest"
        Me.lblBiggest.Size = New System.Drawing.Size(264, 44)
        Me.lblBiggest.TabIndex = 6
        Me.lblBiggest.Text = "BIG BOY NUMBER WAH"
        Me.lblBiggest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBiggest.Visible = False
        '
        'lblSmallest
        '
        Me.lblSmallest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSmallest.Location = New System.Drawing.Point(12, 88)
        Me.lblSmallest.Name = "lblSmallest"
        Me.lblSmallest.Size = New System.Drawing.Size(264, 44)
        Me.lblSmallest.TabIndex = 7
        Me.lblSmallest.Text = "little boy number :("
        Me.lblSmallest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSmallest.Visible = False
        '
        'btnExe
        '
        Me.btnExe.Location = New System.Drawing.Point(12, 135)
        Me.btnExe.Name = "btnExe"
        Me.btnExe.Size = New System.Drawing.Size(264, 51)
        Me.btnExe.TabIndex = 8
        Me.btnExe.Text = "Pull the lever cronk!"
        Me.btnExe.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 198)
        Me.Controls.Add(Me.btnExe)
        Me.Controls.Add(Me.lblSmallest)
        Me.Controls.Add(Me.lblBiggest)
        Me.Controls.Add(Me.lblNum6)
        Me.Controls.Add(Me.lblNum5)
        Me.Controls.Add(Me.lblNum4)
        Me.Controls.Add(Me.lblNum3)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Name = "Form1"
        Me.Text = "6 numbers!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents lblNum3 As Label
    Friend WithEvents lblNum4 As Label
    Friend WithEvents lblNum5 As Label
    Friend WithEvents lblNum6 As Label
    Friend WithEvents lblBiggest As Label
    Friend WithEvents lblSmallest As Label
    Friend WithEvents btnExe As Button
End Class
