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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mtbThisYear = New System.Windows.Forms.MaskedTextBox()
        Me.mtbThisMonth = New System.Windows.Forms.MaskedTextBox()
        Me.mtbThisDay = New System.Windows.Forms.MaskedTextBox()
        Me.mtbThisHour = New System.Windows.Forms.MaskedTextBox()
        Me.mtbFutureHour = New System.Windows.Forms.MaskedTextBox()
        Me.mtbFutureDay = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnExe = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "wanna time travel, bro?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Month"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(12, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(13, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Hour"
        '
        'mtbThisYear
        '
        Me.mtbThisYear.Location = New System.Drawing.Point(55, 46)
        Me.mtbThisYear.Mask = "0000"
        Me.mtbThisYear.Name = "mtbThisYear"
        Me.mtbThisYear.Size = New System.Drawing.Size(33, 20)
        Me.mtbThisYear.TabIndex = 5
        '
        'mtbThisMonth
        '
        Me.mtbThisMonth.Location = New System.Drawing.Point(55, 72)
        Me.mtbThisMonth.Mask = "00"
        Me.mtbThisMonth.Name = "mtbThisMonth"
        Me.mtbThisMonth.Size = New System.Drawing.Size(17, 20)
        Me.mtbThisMonth.TabIndex = 6
        '
        'mtbThisDay
        '
        Me.mtbThisDay.Location = New System.Drawing.Point(55, 98)
        Me.mtbThisDay.Mask = "00"
        Me.mtbThisDay.Name = "mtbThisDay"
        Me.mtbThisDay.Size = New System.Drawing.Size(17, 20)
        Me.mtbThisDay.TabIndex = 7
        '
        'mtbThisHour
        '
        Me.mtbThisHour.Location = New System.Drawing.Point(55, 124)
        Me.mtbThisHour.Mask = "00"
        Me.mtbThisHour.Name = "mtbThisHour"
        Me.mtbThisHour.Size = New System.Drawing.Size(17, 20)
        Me.mtbThisHour.TabIndex = 8
        '
        'mtbFutureHour
        '
        Me.mtbFutureHour.Location = New System.Drawing.Point(137, 72)
        Me.mtbFutureHour.Mask = "00"
        Me.mtbFutureHour.Name = "mtbFutureHour"
        Me.mtbFutureHour.Size = New System.Drawing.Size(17, 20)
        Me.mtbFutureHour.TabIndex = 12
        '
        'mtbFutureDay
        '
        Me.mtbFutureDay.Location = New System.Drawing.Point(137, 46)
        Me.mtbFutureDay.Mask = "00"
        Me.mtbFutureDay.Name = "mtbFutureDay"
        Me.mtbFutureDay.Size = New System.Drawing.Size(17, 20)
        Me.mtbFutureDay.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(95, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Hour"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(94, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Day"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(94, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "How far in the future?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnExe
        '
        Me.btnExe.Location = New System.Drawing.Point(16, 145)
        Me.btnExe.Name = "btnExe"
        Me.btnExe.Size = New System.Drawing.Size(163, 23)
        Me.btnExe.TabIndex = 14
        Me.btnExe.Text = "traverse the fabric of spacetime"
        Me.btnExe.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Location = New System.Drawing.Point(12, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Todays date"
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblOutput.Location = New System.Drawing.Point(15, 171)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(188, 57)
        Me.lblOutput.TabIndex = 16
        Me.lblOutput.Text = "zis be mein output"
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOutput.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 237)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnExe)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.mtbFutureHour)
        Me.Controls.Add(Me.mtbFutureDay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mtbThisHour)
        Me.Controls.Add(Me.mtbThisDay)
        Me.Controls.Add(Me.mtbThisMonth)
        Me.Controls.Add(Me.mtbThisYear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "spooky time travel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents mtbThisYear As MaskedTextBox
    Friend WithEvents mtbThisMonth As MaskedTextBox
    Friend WithEvents mtbThisDay As MaskedTextBox
    Friend WithEvents mtbThisHour As MaskedTextBox
    Friend WithEvents mtbFutureHour As MaskedTextBox
    Friend WithEvents mtbFutureDay As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnExe As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lblOutput As Label
End Class
