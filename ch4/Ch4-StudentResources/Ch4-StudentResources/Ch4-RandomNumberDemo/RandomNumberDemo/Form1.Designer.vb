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
        Me.nudMin = New System.Windows.Forms.NumericUpDown()
        Me.nudMax = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRND = New System.Windows.Forms.Label()
        Me.lblRND1 = New System.Windows.Forms.Label()
        Me.lblRND2 = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type in the high number and the low number of the range"
        '
        'nudMin
        '
        Me.nudMin.Location = New System.Drawing.Point(52, 86)
        Me.nudMin.Name = "nudMin"
        Me.nudMin.Size = New System.Drawing.Size(68, 23)
        Me.nudMin.TabIndex = 1
        Me.nudMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudMax
        '
        Me.nudMax.Location = New System.Drawing.Point(170, 86)
        Me.nudMax.Name = "nudMax"
        Me.nudMax.Size = New System.Drawing.Size(68, 23)
        Me.nudMax.TabIndex = 2
        Me.nudMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Low"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "High"
        '
        'lblRND
        '
        Me.lblRND.Location = New System.Drawing.Point(325, 180)
        Me.lblRND.Name = "lblRND"
        Me.lblRND.Size = New System.Drawing.Size(144, 17)
        Me.lblRND.TabIndex = 8
        Me.lblRND.Text = "0"
        '
        'lblRND1
        '
        Me.lblRND1.Location = New System.Drawing.Point(325, 218)
        Me.lblRND1.Name = "lblRND1"
        Me.lblRND1.Size = New System.Drawing.Size(119, 17)
        Me.lblRND1.TabIndex = 9
        Me.lblRND1.Text = "0"
        '
        'lblRND2
        '
        Me.lblRND2.Location = New System.Drawing.Point(325, 256)
        Me.lblRND2.Name = "lblRND2"
        Me.lblRND2.Size = New System.Drawing.Size(119, 17)
        Me.lblRND2.TabIndex = 10
        Me.lblRND2.Text = "0"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(279, 67)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 41)
        Me.btnGo.TabIndex = 11
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "result = Rnd( )"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "result = Rnd( ) * #Numbers"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(218, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "result = Rnd( ) * #Numbers + Low"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(255, 17)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "result = int ( Rnd( ) * #Numbers + Low )"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(49, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(180, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "#Numbers = High - Low + 1"
        '
        'lblRange
        '
        Me.lblRange.Location = New System.Drawing.Point(325, 142)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(119, 17)
        Me.lblRange.TabIndex = 17
        Me.lblRange.Text = "0"
        '
        'lblFinal
        '
        Me.lblFinal.Location = New System.Drawing.Point(325, 294)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(119, 17)
        Me.lblFinal.TabIndex = 18
        Me.lblFinal.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 354)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.lblRange)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblRND2)
        Me.Controls.Add(Me.lblRND1)
        Me.Controls.Add(Me.lblRND)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudMax)
        Me.Controls.Add(Me.nudMin)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Random Numbers With Randomize - Jake Ildefonso"
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRND As System.Windows.Forms.Label
    Friend WithEvents lblRND1 As System.Windows.Forms.Label
    Friend WithEvents lblRND2 As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblRange As System.Windows.Forms.Label
    Friend WithEvents lblFinal As System.Windows.Forms.Label

End Class
