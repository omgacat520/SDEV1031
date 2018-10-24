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
        Me.btnHigh = New System.Windows.Forms.Button()
        Me.btnLow = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rtbNumber = New System.Windows.Forms.RichTextBox()
        Me.rtbResults = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBet = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Will the number be high or low?"
        '
        'btnHigh
        '
        Me.btnHigh.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnHigh.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHigh.Location = New System.Drawing.Point(17, 40)
        Me.btnHigh.Name = "btnHigh"
        Me.btnHigh.Size = New System.Drawing.Size(135, 32)
        Me.btnHigh.TabIndex = 1
        Me.btnHigh.Text = "High!"
        Me.btnHigh.UseVisualStyleBackColor = False
        '
        'btnLow
        '
        Me.btnLow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLow.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLow.Location = New System.Drawing.Point(17, 78)
        Me.btnLow.Name = "btnLow"
        Me.btnLow.Size = New System.Drawing.Size(135, 35)
        Me.btnLow.TabIndex = 2
        Me.btnLow.Text = "Low!"
        Me.btnLow.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "The number is:"
        '
        'rtbNumber
        '
        Me.rtbNumber.Location = New System.Drawing.Point(253, 116)
        Me.rtbNumber.Name = "rtbNumber"
        Me.rtbNumber.ReadOnly = True
        Me.rtbNumber.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtbNumber.Size = New System.Drawing.Size(72, 24)
        Me.rtbNumber.TabIndex = 4
        Me.rtbNumber.Text = ""
        '
        'rtbResults
        '
        Me.rtbResults.Location = New System.Drawing.Point(17, 146)
        Me.rtbResults.Name = "rtbResults"
        Me.rtbResults.ReadOnly = True
        Me.rtbResults.Size = New System.Drawing.Size(308, 52)
        Me.rtbResults.TabIndex = 5
        Me.rtbResults.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Points:"
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.BackColor = System.Drawing.Color.White
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(158, 208)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(50, 24)
        Me.lblPoints.TabIndex = 7
        Me.lblPoints.Text = "1000"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(253, 49)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Bet amount"
        '
        'txtBet
        '
        Me.txtBet.Location = New System.Drawing.Point(124, 257)
        Me.txtBet.Name = "txtBet"
        Me.txtBet.Size = New System.Drawing.Size(201, 20)
        Me.txtBet.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(333, 285)
        Me.Controls.Add(Me.txtBet)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rtbResults)
        Me.Controls.Add(Me.rtbNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLow)
        Me.Controls.Add(Me.btnHigh)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Hi-Lo Game - Jake Ildefonso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnHigh As Button
    Friend WithEvents btnLow As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents rtbNumber As RichTextBox
    Friend WithEvents rtbResults As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBet As TextBox
End Class
