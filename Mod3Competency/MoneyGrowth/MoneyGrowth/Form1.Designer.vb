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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStartAmount = New System.Windows.Forms.TextBox()
        Me.txtGrowth = New System.Windows.Forms.TextBox()
        Me.txtCycles = New System.Windows.Forms.TextBox()
        Me.btnFutureValue = New System.Windows.Forms.Button()
        Me.btnTime = New System.Windows.Forms.Button()
        Me.txtTarget = New System.Windows.Forms.TextBox()
        Me.lblFutureValue = New System.Windows.Forms.Label()
        Me.lblHowLong = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Initial amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Growth rate (%)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "For future value after specified cycles"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Number of cycles"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(361, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "For number of cycles to reach target amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Target amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Answers:"
        '
        'txtStartAmount
        '
        Me.txtStartAmount.Location = New System.Drawing.Point(164, 22)
        Me.txtStartAmount.Name = "txtStartAmount"
        Me.txtStartAmount.Size = New System.Drawing.Size(53, 20)
        Me.txtStartAmount.TabIndex = 7
        '
        'txtGrowth
        '
        Me.txtGrowth.Location = New System.Drawing.Point(164, 56)
        Me.txtGrowth.Name = "txtGrowth"
        Me.txtGrowth.Size = New System.Drawing.Size(53, 20)
        Me.txtGrowth.TabIndex = 8
        '
        'txtCycles
        '
        Me.txtCycles.Location = New System.Drawing.Point(164, 142)
        Me.txtCycles.Name = "txtCycles"
        Me.txtCycles.Size = New System.Drawing.Size(63, 20)
        Me.txtCycles.TabIndex = 9
        '
        'btnFutureValue
        '
        Me.btnFutureValue.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFutureValue.Location = New System.Drawing.Point(106, 181)
        Me.btnFutureValue.Name = "btnFutureValue"
        Me.btnFutureValue.Size = New System.Drawing.Size(186, 61)
        Me.btnFutureValue.TabIndex = 10
        Me.btnFutureValue.Text = "Calculate future value"
        Me.btnFutureValue.UseVisualStyleBackColor = True
        '
        'btnTime
        '
        Me.btnTime.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTime.Location = New System.Drawing.Point(46, 325)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(304, 41)
        Me.btnTime.TabIndex = 11
        Me.btnTime.Text = "Calculate how long to reach target"
        Me.btnTime.UseVisualStyleBackColor = True
        '
        'txtTarget
        '
        Me.txtTarget.Location = New System.Drawing.Point(143, 291)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Size = New System.Drawing.Size(74, 20)
        Me.txtTarget.TabIndex = 12
        '
        'lblFutureValue
        '
        Me.lblFutureValue.AutoSize = True
        Me.lblFutureValue.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFutureValue.Location = New System.Drawing.Point(95, 380)
        Me.lblFutureValue.Name = "lblFutureValue"
        Me.lblFutureValue.Size = New System.Drawing.Size(156, 21)
        Me.lblFutureValue.TabIndex = 13
        Me.lblFutureValue.Text = "FutureValueOutput"
        Me.lblFutureValue.Visible = False
        '
        'lblHowLong
        '
        Me.lblHowLong.AutoSize = True
        Me.lblHowLong.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblHowLong.Location = New System.Drawing.Point(90, 423)
        Me.lblHowLong.Name = "lblHowLong"
        Me.lblHowLong.Size = New System.Drawing.Size(137, 21)
        Me.lblHowLong.TabIndex = 14
        Me.lblHowLong.Text = "HowLongOutput"
        Me.lblHowLong.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(457, 453)
        Me.Controls.Add(Me.lblHowLong)
        Me.Controls.Add(Me.lblFutureValue)
        Me.Controls.Add(Me.txtTarget)
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.btnFutureValue)
        Me.Controls.Add(Me.txtCycles)
        Me.Controls.Add(Me.txtGrowth)
        Me.Controls.Add(Me.txtStartAmount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Money Growth"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStartAmount As TextBox
    Friend WithEvents txtGrowth As TextBox
    Friend WithEvents txtCycles As TextBox
    Friend WithEvents btnFutureValue As Button
    Friend WithEvents btnTime As Button
    Friend WithEvents txtTarget As TextBox
    Friend WithEvents lblFutureValue As Label
    Friend WithEvents lblHowLong As Label
End Class
