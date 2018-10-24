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
        Me.btnCounter1 = New System.Windows.Forms.Button()
        Me.lblC1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCounter5 = New System.Windows.Forms.Button()
        Me.lblC5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCountDown = New System.Windows.Forms.Button()
        Me.lblCminus1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAccumAdd = New System.Windows.Forms.Button()
        Me.lblAplus = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSubtract = New System.Windows.Forms.TextBox()
        Me.btnAccumSubtract = New System.Windows.Forms.Button()
        Me.lblAminus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Counters"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(26, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 50)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "This counter goes up by 1 every time you click the button"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCounter1
        '
        Me.btnCounter1.Location = New System.Drawing.Point(246, 39)
        Me.btnCounter1.Name = "btnCounter1"
        Me.btnCounter1.Size = New System.Drawing.Size(83, 50)
        Me.btnCounter1.TabIndex = 2
        Me.btnCounter1.Text = "Count Up By 1"
        Me.btnCounter1.UseVisualStyleBackColor = True
        '
        'lblC1
        '
        Me.lblC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblC1.Location = New System.Drawing.Point(344, 48)
        Me.lblC1.Name = "lblC1"
        Me.lblC1.Size = New System.Drawing.Size(39, 30)
        Me.lblC1.TabIndex = 3
        Me.lblC1.Text = "0"
        Me.lblC1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(26, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 57)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "This counter goes up by 5 every time you click the button"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCounter5
        '
        Me.btnCounter5.Location = New System.Drawing.Point(246, 114)
        Me.btnCounter5.Name = "btnCounter5"
        Me.btnCounter5.Size = New System.Drawing.Size(83, 50)
        Me.btnCounter5.TabIndex = 5
        Me.btnCounter5.Text = "Count Up By 5"
        Me.btnCounter5.UseVisualStyleBackColor = True
        '
        'lblC5
        '
        Me.lblC5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblC5.Location = New System.Drawing.Point(344, 124)
        Me.lblC5.Name = "lblC5"
        Me.lblC5.Size = New System.Drawing.Size(39, 30)
        Me.lblC5.TabIndex = 6
        Me.lblC5.Text = "0"
        Me.lblC5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(26, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 57)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "This counter goes down by 1 every time you click the button"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCountDown
        '
        Me.btnCountDown.Location = New System.Drawing.Point(246, 193)
        Me.btnCountDown.Name = "btnCountDown"
        Me.btnCountDown.Size = New System.Drawing.Size(83, 50)
        Me.btnCountDown.TabIndex = 8
        Me.btnCountDown.Text = "Count Down By 1"
        Me.btnCountDown.UseVisualStyleBackColor = True
        '
        'lblCminus1
        '
        Me.lblCminus1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCminus1.Location = New System.Drawing.Point(344, 203)
        Me.lblCminus1.Name = "lblCminus1"
        Me.lblCminus1.Size = New System.Drawing.Size(39, 30)
        Me.lblCminus1.TabIndex = 9
        Me.lblCminus1.Text = "10"
        Me.lblCminus1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(26, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 57)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Type a number in the textbox"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Accumulators"
        '
        'btnAccumAdd
        '
        Me.btnAccumAdd.Location = New System.Drawing.Point(246, 287)
        Me.btnAccumAdd.Name = "btnAccumAdd"
        Me.btnAccumAdd.Size = New System.Drawing.Size(83, 50)
        Me.btnAccumAdd.TabIndex = 12
        Me.btnAccumAdd.Text = "Add to total"
        Me.btnAccumAdd.UseVisualStyleBackColor = True
        '
        'lblAplus
        '
        Me.lblAplus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAplus.Location = New System.Drawing.Point(344, 297)
        Me.lblAplus.Name = "lblAplus"
        Me.lblAplus.Size = New System.Drawing.Size(39, 30)
        Me.lblAplus.TabIndex = 13
        Me.lblAplus.Text = "0"
        Me.lblAplus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(169, 297)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(62, 23)
        Me.txtAdd.TabIndex = 14
        Me.txtAdd.Text = "0"
        Me.txtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(27, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 57)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Type a number in the textbox"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSubtract
        '
        Me.txtSubtract.Location = New System.Drawing.Point(169, 374)
        Me.txtSubtract.Name = "txtSubtract"
        Me.txtSubtract.Size = New System.Drawing.Size(62, 23)
        Me.txtSubtract.TabIndex = 16
        Me.txtSubtract.Text = "0"
        Me.txtSubtract.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAccumSubtract
        '
        Me.btnAccumSubtract.Location = New System.Drawing.Point(246, 360)
        Me.btnAccumSubtract.Name = "btnAccumSubtract"
        Me.btnAccumSubtract.Size = New System.Drawing.Size(83, 50)
        Me.btnAccumSubtract.TabIndex = 17
        Me.btnAccumSubtract.Text = "Subtract from total"
        Me.btnAccumSubtract.UseVisualStyleBackColor = True
        '
        'lblAminus
        '
        Me.lblAminus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAminus.Location = New System.Drawing.Point(344, 370)
        Me.lblAminus.Name = "lblAminus"
        Me.lblAminus.Size = New System.Drawing.Size(39, 30)
        Me.lblAminus.TabIndex = 18
        Me.lblAminus.Text = "100"
        Me.lblAminus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 482)
        Me.Controls.Add(Me.lblAminus)
        Me.Controls.Add(Me.btnAccumSubtract)
        Me.Controls.Add(Me.txtSubtract)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.lblAplus)
        Me.Controls.Add(Me.btnAccumAdd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCminus1)
        Me.Controls.Add(Me.btnCountDown)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblC5)
        Me.Controls.Add(Me.btnCounter5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblC1)
        Me.Controls.Add(Me.btnCounter1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Counters and Accumulators"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCounter1 As System.Windows.Forms.Button
    Friend WithEvents lblC1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCounter5 As System.Windows.Forms.Button
    Friend WithEvents lblC5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCountDown As System.Windows.Forms.Button
    Friend WithEvents lblCminus1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAccumAdd As System.Windows.Forms.Button
    Friend WithEvents lblAplus As System.Windows.Forms.Label
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSubtract As System.Windows.Forms.TextBox
    Friend WithEvents btnAccumSubtract As System.Windows.Forms.Button
    Friend WithEvents lblAminus As System.Windows.Forms.Label

End Class
