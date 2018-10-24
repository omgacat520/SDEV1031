<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOvertime
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTotalPayDesc = New System.Windows.Forms.Label
        Me.lblTotalPay = New System.Windows.Forms.Label
        Me.lblOvertimePayDesc = New System.Windows.Forms.Label
        Me.lblOvertimePay = New System.Windows.Forms.Label
        Me.lblRegularPayDesc = New System.Windows.Forms.Label
        Me.lblRegularPay = New System.Windows.Forms.Label
        Me.lblPayRate = New System.Windows.Forms.Label
        Me.lblHoursWorked = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnWages = New System.Windows.Forms.Button
        Me.txtPayRate = New System.Windows.Forms.TextBox
        Me.txtHoursWorked = New System.Windows.Forms.TextBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblTotalPayDesc
        '
        Me.lblTotalPayDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayDesc.Location = New System.Drawing.Point(103, 178)
        Me.lblTotalPayDesc.Name = "lblTotalPayDesc"
        Me.lblTotalPayDesc.Size = New System.Drawing.Size(88, 23)
        Me.lblTotalPayDesc.TabIndex = 26
        Me.lblTotalPayDesc.Text = "Total Pay"
        '
        'lblTotalPay
        '
        Me.lblTotalPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPay.Location = New System.Drawing.Point(15, 178)
        Me.lblTotalPay.Name = "lblTotalPay"
        Me.lblTotalPay.Size = New System.Drawing.Size(72, 23)
        Me.lblTotalPay.TabIndex = 25
        Me.lblTotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOvertimePayDesc
        '
        Me.lblOvertimePayDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOvertimePayDesc.Location = New System.Drawing.Point(103, 146)
        Me.lblOvertimePayDesc.Name = "lblOvertimePayDesc"
        Me.lblOvertimePayDesc.Size = New System.Drawing.Size(88, 23)
        Me.lblOvertimePayDesc.TabIndex = 24
        Me.lblOvertimePayDesc.Text = "Overtime Pay"
        '
        'lblOvertimePay
        '
        Me.lblOvertimePay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOvertimePay.Location = New System.Drawing.Point(15, 143)
        Me.lblOvertimePay.Name = "lblOvertimePay"
        Me.lblOvertimePay.Size = New System.Drawing.Size(72, 23)
        Me.lblOvertimePay.TabIndex = 23
        Me.lblOvertimePay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRegularPayDesc
        '
        Me.lblRegularPayDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegularPayDesc.Location = New System.Drawing.Point(103, 114)
        Me.lblRegularPayDesc.Name = "lblRegularPayDesc"
        Me.lblRegularPayDesc.Size = New System.Drawing.Size(80, 23)
        Me.lblRegularPayDesc.TabIndex = 22
        Me.lblRegularPayDesc.Text = "Regular Pay"
        '
        'lblRegularPay
        '
        Me.lblRegularPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegularPay.Location = New System.Drawing.Point(15, 111)
        Me.lblRegularPay.Name = "lblRegularPay"
        Me.lblRegularPay.Size = New System.Drawing.Size(72, 23)
        Me.lblRegularPay.TabIndex = 21
        Me.lblRegularPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPayRate
        '
        Me.lblPayRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayRate.Location = New System.Drawing.Point(103, 74)
        Me.lblPayRate.Name = "lblPayRate"
        Me.lblPayRate.Size = New System.Drawing.Size(100, 23)
        Me.lblPayRate.TabIndex = 20
        Me.lblPayRate.Text = "Pay Rate"
        '
        'lblHoursWorked
        '
        Me.lblHoursWorked.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursWorked.Location = New System.Drawing.Point(103, 34)
        Me.lblHoursWorked.Name = "lblHoursWorked"
        Me.lblHoursWorked.Size = New System.Drawing.Size(100, 23)
        Me.lblHoursWorked.TabIndex = 19
        Me.lblHoursWorked.Text = "Hours Worked"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(205, 205)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 28)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "E&xit"
        '
        'btnWages
        '
        Me.btnWages.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWages.Location = New System.Drawing.Point(207, 158)
        Me.btnWages.Name = "btnWages"
        Me.btnWages.Size = New System.Drawing.Size(75, 31)
        Me.btnWages.TabIndex = 17
        Me.btnWages.Text = "&Wages"
        '
        'txtPayRate
        '
        Me.txtPayRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayRate.Location = New System.Drawing.Point(23, 74)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(64, 23)
        Me.txtPayRate.TabIndex = 16
        Me.txtPayRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoursWorked.Location = New System.Drawing.Point(23, 34)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(64, 23)
        Me.txtHoursWorked.TabIndex = 15
        Me.txtHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(-1, -2)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(296, 23)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Overtime"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmOvertime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.lblTotalPayDesc)
        Me.Controls.Add(Me.lblTotalPay)
        Me.Controls.Add(Me.lblOvertimePayDesc)
        Me.Controls.Add(Me.lblOvertimePay)
        Me.Controls.Add(Me.lblRegularPayDesc)
        Me.Controls.Add(Me.lblRegularPay)
        Me.Controls.Add(Me.lblPayRate)
        Me.Controls.Add(Me.lblHoursWorked)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnWages)
        Me.Controls.Add(Me.txtPayRate)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.lblTitle)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOvertime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Overtime"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotalPayDesc As System.Windows.Forms.Label
    Friend WithEvents lblTotalPay As System.Windows.Forms.Label
    Friend WithEvents lblOvertimePayDesc As System.Windows.Forms.Label
    Friend WithEvents lblOvertimePay As System.Windows.Forms.Label
    Friend WithEvents lblRegularPayDesc As System.Windows.Forms.Label
    Friend WithEvents lblRegularPay As System.Windows.Forms.Label
    Friend WithEvents lblPayRate As System.Windows.Forms.Label
    Friend WithEvents lblHoursWorked As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnWages As System.Windows.Forms.Button
    Friend WithEvents txtPayRate As System.Windows.Forms.TextBox
    Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label

End Class
