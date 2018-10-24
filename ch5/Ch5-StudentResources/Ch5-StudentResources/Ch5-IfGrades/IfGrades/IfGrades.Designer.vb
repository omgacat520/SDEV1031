<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IfGrades
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
        Me.nudPercent = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblGrade = New System.Windows.Forms.Label
        Me.btnGrade = New System.Windows.Forms.Button
        Me.btnGradeII = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnGradesIII = New System.Windows.Forms.Button
        CType(Me.nudPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudPercent
        '
        Me.nudPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPercent.Location = New System.Drawing.Point(61, 7)
        Me.nudPercent.Name = "nudPercent"
        Me.nudPercent.Size = New System.Drawing.Size(66, 26)
        Me.nudPercent.TabIndex = 0
        Me.nudPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Percent"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(157, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Grade"
        '
        'lblGrade
        '
        Me.lblGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(61, 44)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(66, 23)
        Me.lblGrade.TabIndex = 3
        Me.lblGrade.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnGrade
        '
        Me.btnGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrade.Location = New System.Drawing.Point(161, 79)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(82, 30)
        Me.btnGrade.TabIndex = 4
        Me.btnGrade.Text = "&Grade"
        Me.btnGrade.UseVisualStyleBackColor = True
        '
        'btnGradeII
        '
        Me.btnGradeII.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGradeII.Location = New System.Drawing.Point(161, 121)
        Me.btnGradeII.Name = "btnGradeII"
        Me.btnGradeII.Size = New System.Drawing.Size(82, 30)
        Me.btnGradeII.TabIndex = 5
        Me.btnGradeII.Text = "Grade &II"
        Me.btnGradeII.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(161, 205)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 30)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnGradesIII
        '
        Me.btnGradesIII.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGradesIII.Location = New System.Drawing.Point(161, 163)
        Me.btnGradesIII.Name = "btnGradesIII"
        Me.btnGradesIII.Size = New System.Drawing.Size(82, 30)
        Me.btnGradesIII.TabIndex = 7
        Me.btnGradesIII.Text = "Grade III"
        Me.btnGradesIII.UseVisualStyleBackColor = True
        '
        'IfGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.btnGradesIII)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGradeII)
        Me.Controls.Add(Me.btnGrade)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudPercent)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IfGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Grades"
        CType(Me.nudPercent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nudPercent As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents btnGrade As System.Windows.Forms.Button
    Friend WithEvents btnGradeII As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnGradesIII As System.Windows.Forms.Button

End Class
