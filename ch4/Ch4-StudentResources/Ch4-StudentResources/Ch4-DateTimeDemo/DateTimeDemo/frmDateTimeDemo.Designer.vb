<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDateTimeDemo
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
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.btnCurrentDate = New System.Windows.Forms.Button()
        Me.rtbCode = New System.Windows.Forms.RichTextBox()
        Me.btnCurrentTime = New System.Windows.Forms.Button()
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.btnDaysPast = New System.Windows.Forms.Button()
        Me.lblDaysPast = New System.Windows.Forms.Label()
        Me.btnCurrentMonth = New System.Windows.Forms.Button()
        Me.lblCurrentMonth = New System.Windows.Forms.Label()
        Me.btnCurrentDay = New System.Windows.Forms.Button()
        Me.lblCurrentDay = New System.Windows.Forms.Label()
        Me.btnCurrentYear = New System.Windows.Forms.Button()
        Me.lblCurrentYear = New System.Windows.Forms.Label()
        Me.btnDayOfWeek = New System.Windows.Forms.Button()
        Me.lblDayOfWeek = New System.Windows.Forms.Label()
        Me.btnCurrentHour = New System.Windows.Forms.Button()
        Me.lblCurrentHour = New System.Windows.Forms.Label()
        Me.btnCurrentMinute = New System.Windows.Forms.Button()
        Me.lblCurrentMinute = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDate.Location = New System.Drawing.Point(12, 43)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(128, 23)
        Me.lblCurrentDate.TabIndex = 10
        Me.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCurrentDate
        '
        Me.btnCurrentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrentDate.Location = New System.Drawing.Point(154, 36)
        Me.btnCurrentDate.Name = "btnCurrentDate"
        Me.btnCurrentDate.Size = New System.Drawing.Size(113, 30)
        Me.btnCurrentDate.TabIndex = 0
        Me.btnCurrentDate.Text = "Current &Date"
        Me.btnCurrentDate.UseVisualStyleBackColor = True
        '
        'rtbCode
        '
        Me.rtbCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbCode.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCode.Location = New System.Drawing.Point(-3, 286)
        Me.rtbCode.Name = "rtbCode"
        Me.rtbCode.Size = New System.Drawing.Size(598, 189)
        Me.rtbCode.TabIndex = 19
        Me.rtbCode.TabStop = False
        Me.rtbCode.Text = ""
        '
        'btnCurrentTime
        '
        Me.btnCurrentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrentTime.Location = New System.Drawing.Point(325, 84)
        Me.btnCurrentTime.Name = "btnCurrentTime"
        Me.btnCurrentTime.Size = New System.Drawing.Size(113, 30)
        Me.btnCurrentTime.TabIndex = 6
        Me.btnCurrentTime.Text = "Current &Time"
        Me.btnCurrentTime.UseVisualStyleBackColor = True
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTime.Location = New System.Drawing.Point(455, 91)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(128, 23)
        Me.lblCurrentTime.TabIndex = 16
        '
        'btnDaysPast
        '
        Me.btnDaysPast.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaysPast.Location = New System.Drawing.Point(154, 236)
        Me.btnDaysPast.Name = "btnDaysPast"
        Me.btnDaysPast.Size = New System.Drawing.Size(113, 30)
        Me.btnDaysPast.TabIndex = 4
        Me.btnDaysPast.Text = "&Millennium"
        Me.btnDaysPast.UseVisualStyleBackColor = True
        '
        'lblDaysPast
        '
        Me.lblDaysPast.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaysPast.Location = New System.Drawing.Point(12, 243)
        Me.lblDaysPast.Name = "lblDaysPast"
        Me.lblDaysPast.Size = New System.Drawing.Size(128, 23)
        Me.lblDaysPast.TabIndex = 14
        Me.lblDaysPast.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCurrentMonth
        '
        Me.btnCurrentMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrentMonth.Location = New System.Drawing.Point(154, 84)
        Me.btnCurrentMonth.Name = "btnCurrentMonth"
        Me.btnCurrentMonth.Size = New System.Drawing.Size(113, 30)
        Me.btnCurrentMonth.TabIndex = 1
        Me.btnCurrentMonth.Text = "Current M&onth"
        Me.btnCurrentMonth.UseVisualStyleBackColor = True
        '
        'lblCurrentMonth
        '
        Me.lblCurrentMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMonth.Location = New System.Drawing.Point(12, 91)
        Me.lblCurrentMonth.Name = "lblCurrentMonth"
        Me.lblCurrentMonth.Size = New System.Drawing.Size(128, 23)
        Me.lblCurrentMonth.TabIndex = 11
        Me.lblCurrentMonth.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCurrentDay
        '
        Me.btnCurrentDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrentDay.Location = New System.Drawing.Point(154, 132)
        Me.btnCurrentDay.Name = "btnCurrentDay"
        Me.btnCurrentDay.Size = New System.Drawing.Size(113, 30)
        Me.btnCurrentDay.TabIndex = 2
        Me.btnCurrentDay.Text = "Current D&ate"
        Me.btnCurrentDay.UseVisualStyleBackColor = True
        '
        'lblCurrentDay
        '
        Me.lblCurrentDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDay.Location = New System.Drawing.Point(12, 139)
        Me.lblCurrentDay.Name = "lblCurrentDay"
        Me.lblCurrentDay.Size = New System.Drawing.Size(128, 23)
        Me.lblCurrentDay.TabIndex = 12
        Me.lblCurrentDay.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCurrentYear
        '
        Me.btnCurrentYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrentYear.Location = New System.Drawing.Point(154, 184)
        Me.btnCurrentYear.Name = "btnCurrentYear"
        Me.btnCurrentYear.Size = New System.Drawing.Size(113, 30)
        Me.btnCurrentYear.TabIndex = 3
        Me.btnCurrentYear.Text = "Current &Year"
        Me.btnCurrentYear.UseVisualStyleBackColor = True
        '
        'lblCurrentYear
        '
        Me.lblCurrentYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentYear.Location = New System.Drawing.Point(12, 187)
        Me.lblCurrentYear.Name = "lblCurrentYear"
        Me.lblCurrentYear.Size = New System.Drawing.Size(128, 23)
        Me.lblCurrentYear.TabIndex = 13
        Me.lblCurrentYear.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnDayOfWeek
        '
        Me.btnDayOfWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDayOfWeek.Location = New System.Drawing.Point(325, 32)
        Me.btnDayOfWeek.Name = "btnDayOfWeek"
        Me.btnDayOfWeek.Size = New System.Drawing.Size(113, 30)
        Me.btnDayOfWeek.TabIndex = 5
        Me.btnDayOfWeek.Text = "Day of &Week"
        Me.btnDayOfWeek.UseVisualStyleBackColor = True
        '
        'lblDayOfWeek
        '
        Me.lblDayOfWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayOfWeek.Location = New System.Drawing.Point(455, 39)
        Me.lblDayOfWeek.Name = "lblDayOfWeek"
        Me.lblDayOfWeek.Size = New System.Drawing.Size(128, 23)
        Me.lblDayOfWeek.TabIndex = 15
        '
        'btnCurrentHour
        '
        Me.btnCurrentHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrentHour.Location = New System.Drawing.Point(325, 132)
        Me.btnCurrentHour.Name = "btnCurrentHour"
        Me.btnCurrentHour.Size = New System.Drawing.Size(113, 30)
        Me.btnCurrentHour.TabIndex = 7
        Me.btnCurrentHour.Text = "Current &Hour"
        Me.btnCurrentHour.UseVisualStyleBackColor = True
        '
        'lblCurrentHour
        '
        Me.lblCurrentHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentHour.Location = New System.Drawing.Point(455, 139)
        Me.lblCurrentHour.Name = "lblCurrentHour"
        Me.lblCurrentHour.Size = New System.Drawing.Size(128, 23)
        Me.lblCurrentHour.TabIndex = 17
        '
        'btnCurrentMinute
        '
        Me.btnCurrentMinute.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrentMinute.Location = New System.Drawing.Point(325, 184)
        Me.btnCurrentMinute.Name = "btnCurrentMinute"
        Me.btnCurrentMinute.Size = New System.Drawing.Size(113, 30)
        Me.btnCurrentMinute.TabIndex = 8
        Me.btnCurrentMinute.Text = "Current M&inute"
        Me.btnCurrentMinute.UseVisualStyleBackColor = True
        '
        'lblCurrentMinute
        '
        Me.lblCurrentMinute.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMinute.Location = New System.Drawing.Point(455, 187)
        Me.lblCurrentMinute.Name = "lblCurrentMinute"
        Me.lblCurrentMinute.Size = New System.Drawing.Size(128, 23)
        Me.lblCurrentMinute.TabIndex = 18
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(325, 236)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 30)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmDateTimeDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 473)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCurrentMinute)
        Me.Controls.Add(Me.lblCurrentMinute)
        Me.Controls.Add(Me.btnCurrentHour)
        Me.Controls.Add(Me.lblCurrentHour)
        Me.Controls.Add(Me.btnDayOfWeek)
        Me.Controls.Add(Me.lblDayOfWeek)
        Me.Controls.Add(Me.btnCurrentYear)
        Me.Controls.Add(Me.lblCurrentYear)
        Me.Controls.Add(Me.btnCurrentDay)
        Me.Controls.Add(Me.lblCurrentDay)
        Me.Controls.Add(Me.btnCurrentMonth)
        Me.Controls.Add(Me.lblCurrentMonth)
        Me.Controls.Add(Me.btnDaysPast)
        Me.Controls.Add(Me.lblDaysPast)
        Me.Controls.Add(Me.btnCurrentTime)
        Me.Controls.Add(Me.lblCurrentTime)
        Me.Controls.Add(Me.rtbCode)
        Me.Controls.Add(Me.btnCurrentDate)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDateTimeDemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Date and Time Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCurrentDate As System.Windows.Forms.Label
    Friend WithEvents btnCurrentDate As System.Windows.Forms.Button
    Friend WithEvents rtbCode As System.Windows.Forms.RichTextBox
    Friend WithEvents btnCurrentTime As System.Windows.Forms.Button
    Friend WithEvents lblCurrentTime As System.Windows.Forms.Label
    Friend WithEvents btnDaysPast As System.Windows.Forms.Button
    Friend WithEvents lblDaysPast As System.Windows.Forms.Label
    Friend WithEvents btnCurrentMonth As System.Windows.Forms.Button
    Friend WithEvents lblCurrentMonth As System.Windows.Forms.Label
    Friend WithEvents btnCurrentDay As System.Windows.Forms.Button
    Friend WithEvents lblCurrentDay As System.Windows.Forms.Label
    Friend WithEvents btnCurrentYear As System.Windows.Forms.Button
    Friend WithEvents lblCurrentYear As System.Windows.Forms.Label
    Friend WithEvents btnDayOfWeek As System.Windows.Forms.Button
    Friend WithEvents lblDayOfWeek As System.Windows.Forms.Label
    Friend WithEvents btnCurrentHour As System.Windows.Forms.Button
    Friend WithEvents lblCurrentHour As System.Windows.Forms.Label
    Friend WithEvents btnCurrentMinute As System.Windows.Forms.Button
    Friend WithEvents lblCurrentMinute As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
