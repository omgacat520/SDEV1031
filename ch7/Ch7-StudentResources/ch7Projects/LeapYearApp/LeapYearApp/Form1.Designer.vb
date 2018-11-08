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
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.btnMethodA = New System.Windows.Forms.Button()
        Me.btnMethodB = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a year to get the days in February"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(17, 51)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 1
        '
        'btnMethodA
        '
        Me.btnMethodA.BackColor = System.Drawing.Color.Azure
        Me.btnMethodA.Location = New System.Drawing.Point(123, 38)
        Me.btnMethodA.Name = "btnMethodA"
        Me.btnMethodA.Size = New System.Drawing.Size(112, 47)
        Me.btnMethodA.TabIndex = 2
        Me.btnMethodA.Text = "Method A"
        Me.btnMethodA.UseVisualStyleBackColor = False
        '
        'btnMethodB
        '
        Me.btnMethodB.BackColor = System.Drawing.Color.Moccasin
        Me.btnMethodB.Location = New System.Drawing.Point(241, 38)
        Me.btnMethodB.Name = "btnMethodB"
        Me.btnMethodB.Size = New System.Drawing.Size(112, 47)
        Me.btnMethodB.TabIndex = 3
        Me.btnMethodB.Text = "Method B"
        Me.btnMethodB.UseVisualStyleBackColor = False
        '
        'lblOutput
        '
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(17, 88)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(336, 82)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.Text = "LIKE SCOOB THIS IS THE OUTPUT ZOINKS"
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOutput.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(412, 179)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnMethodB)
        Me.Controls.Add(Me.btnMethodA)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Leap Year Check - Jake Ildefonso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents btnMethodA As Button
    Friend WithEvents btnMethodB As Button
    Friend WithEvents lblOutput As Label
End Class
