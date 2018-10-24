<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonalDates
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
        Me.btnDaysOld = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblToday = New System.Windows.Forms.Label()
        Me.nudMonth = New System.Windows.Forms.NumericUpDown()
        Me.nudDay = New System.Windows.Forms.NumericUpDown()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudHolYear = New System.Windows.Forms.NumericUpDown()
        Me.nudHolDay = New System.Windows.Forms.NumericUpDown()
        Me.nudHolMonth = New System.Windows.Forms.NumericUpDown()
        Me.lblDaysOld = New System.Windows.Forms.Label()
        Me.lblTilHoliday = New System.Windows.Forms.Label()
        Me.btnCountdown = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.nudMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHolYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHolDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHolMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDaysOld
        '
        Me.btnDaysOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaysOld.Location = New System.Drawing.Point(380, 98)
        Me.btnDaysOld.Name = "btnDaysOld"
        Me.btnDaysOld.Size = New System.Drawing.Size(86, 30)
        Me.btnDaysOld.TabIndex = 3
        Me.btnDaysOld.Text = "Days &Old"
        Me.btnDaysOld.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Your Birthday"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Holiday"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblToday
        '
        Me.lblToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToday.Location = New System.Drawing.Point(0, 0)
        Me.lblToday.Name = "lblToday"
        Me.lblToday.Size = New System.Drawing.Size(494, 23)
        Me.lblToday.TabIndex = 2
        Me.lblToday.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nudMonth
        '
        Me.nudMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMonth.Location = New System.Drawing.Point(117, 51)
        Me.nudMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMonth.Name = "nudMonth"
        Me.nudMonth.Size = New System.Drawing.Size(67, 23)
        Me.nudMonth.TabIndex = 0
        Me.nudMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudDay
        '
        Me.nudDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDay.Location = New System.Drawing.Point(208, 51)
        Me.nudDay.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.nudDay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDay.Name = "nudDay"
        Me.nudDay.Size = New System.Drawing.Size(67, 23)
        Me.nudDay.TabIndex = 1
        Me.nudDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudDay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudYear
        '
        Me.nudYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudYear.Location = New System.Drawing.Point(296, 51)
        Me.nudYear.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(67, 23)
        Me.nudYear.TabIndex = 2
        Me.nudYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudYear.Value = New Decimal(New Integer() {2001, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(172, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Days Old"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(129, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Days Til Holiday"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'nudHolYear
        '
        Me.nudHolYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudHolYear.Location = New System.Drawing.Point(296, 145)
        Me.nudHolYear.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.nudHolYear.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudHolYear.Name = "nudHolYear"
        Me.nudHolYear.Size = New System.Drawing.Size(67, 23)
        Me.nudHolYear.TabIndex = 6
        Me.nudHolYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudHolYear.Value = New Decimal(New Integer() {2015, 0, 0, 0})
        '
        'nudHolDay
        '
        Me.nudHolDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudHolDay.Location = New System.Drawing.Point(208, 145)
        Me.nudHolDay.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.nudHolDay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudHolDay.Name = "nudHolDay"
        Me.nudHolDay.Size = New System.Drawing.Size(67, 23)
        Me.nudHolDay.TabIndex = 5
        Me.nudHolDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudHolDay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudHolMonth
        '
        Me.nudHolMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudHolMonth.Location = New System.Drawing.Point(117, 145)
        Me.nudHolMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudHolMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudHolMonth.Name = "nudHolMonth"
        Me.nudHolMonth.Size = New System.Drawing.Size(67, 23)
        Me.nudHolMonth.TabIndex = 4
        Me.nudHolMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudHolMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblDaysOld
        '
        Me.lblDaysOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaysOld.Location = New System.Drawing.Point(281, 101)
        Me.lblDaysOld.Name = "lblDaysOld"
        Me.lblDaysOld.Size = New System.Drawing.Size(82, 23)
        Me.lblDaysOld.TabIndex = 10
        Me.lblDaysOld.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTilHoliday
        '
        Me.lblTilHoliday.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTilHoliday.Location = New System.Drawing.Point(285, 190)
        Me.lblTilHoliday.Name = "lblTilHoliday"
        Me.lblTilHoliday.Size = New System.Drawing.Size(78, 23)
        Me.lblTilHoliday.TabIndex = 11
        Me.lblTilHoliday.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCountdown
        '
        Me.btnCountdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCountdown.Location = New System.Drawing.Point(380, 183)
        Me.btnCountdown.Name = "btnCountdown"
        Me.btnCountdown.Size = New System.Drawing.Size(86, 30)
        Me.btnCountdown.TabIndex = 7
        Me.btnCountdown.Text = "&Countdown"
        Me.btnCountdown.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(380, 244)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 30)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPersonalDates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 323)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCountdown)
        Me.Controls.Add(Me.lblTilHoliday)
        Me.Controls.Add(Me.lblDaysOld)
        Me.Controls.Add(Me.nudHolYear)
        Me.Controls.Add(Me.nudHolDay)
        Me.Controls.Add(Me.nudHolMonth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.nudDay)
        Me.Controls.Add(Me.nudMonth)
        Me.Controls.Add(Me.lblToday)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDaysOld)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPersonalDates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal Dates"
        CType(Me.nudMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHolYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHolDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHolMonth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDaysOld As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblToday As System.Windows.Forms.Label
    Friend WithEvents nudMonth As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudDay As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nudHolYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudHolDay As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudHolMonth As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDaysOld As System.Windows.Forms.Label
    Friend WithEvents lblTilHoliday As System.Windows.Forms.Label
    Friend WithEvents btnCountdown As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
