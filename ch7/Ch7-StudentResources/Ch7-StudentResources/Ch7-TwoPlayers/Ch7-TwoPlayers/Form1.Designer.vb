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
        Me.lblP1Points = New System.Windows.Forms.Label()
        Me.lblP2Points = New System.Windows.Forms.Label()
        Me.txtP1Guess = New System.Windows.Forms.TextBox()
        Me.txtP2Guess = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Player 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Points"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(211, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Points"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Guess"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Guess"
        '
        'lblP1Points
        '
        Me.lblP1Points.Location = New System.Drawing.Point(93, 73)
        Me.lblP1Points.Name = "lblP1Points"
        Me.lblP1Points.Size = New System.Drawing.Size(38, 17)
        Me.lblP1Points.TabIndex = 6
        Me.lblP1Points.Text = "100"
        '
        'lblP2Points
        '
        Me.lblP2Points.Location = New System.Drawing.Point(276, 73)
        Me.lblP2Points.Name = "lblP2Points"
        Me.lblP2Points.Size = New System.Drawing.Size(38, 17)
        Me.lblP2Points.TabIndex = 7
        Me.lblP2Points.Text = "100"
        '
        'txtP1Guess
        '
        Me.txtP1Guess.Location = New System.Drawing.Point(96, 115)
        Me.txtP1Guess.Name = "txtP1Guess"
        Me.txtP1Guess.Size = New System.Drawing.Size(52, 23)
        Me.txtP1Guess.TabIndex = 8
        '
        'txtP2Guess
        '
        Me.txtP2Guess.Location = New System.Drawing.Point(279, 115)
        Me.txtP2Guess.Name = "txtP2Guess"
        Me.txtP2Guess.Size = New System.Drawing.Size(52, 23)
        Me.txtP2Guess.TabIndex = 9
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(142, 163)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(70, 32)
        Me.btnGo.TabIndex = 10
        Me.btnGo.Text = "Play"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(93, 214)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(175, 43)
        Me.lblResult.TabIndex = 11
        Me.lblResult.Text = "Result:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 285)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtP2Guess)
        Me.Controls.Add(Me.txtP1Guess)
        Me.Controls.Add(Me.lblP2Points)
        Me.Controls.Add(Me.lblP1Points)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Play"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblP1Points As System.Windows.Forms.Label
    Friend WithEvents lblP2Points As System.Windows.Forms.Label
    Friend WithEvents txtP1Guess As System.Windows.Forms.TextBox
    Friend WithEvents txtP2Guess As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
