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
        Me.lblTotalPoints = New System.Windows.Forms.Label()
        Me.txtRisk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnHigh = New System.Windows.Forms.Button()
        Me.btnLow = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCard = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter points to risk:"
        '
        'lblTotalPoints
        '
        Me.lblTotalPoints.AutoSize = True
        Me.lblTotalPoints.Location = New System.Drawing.Point(89, 18)
        Me.lblTotalPoints.Name = "lblTotalPoints"
        Me.lblTotalPoints.Size = New System.Drawing.Size(123, 17)
        Me.lblTotalPoints.TabIndex = 1
        Me.lblTotalPoints.Text = "Total Points: 1000"
        '
        'txtRisk
        '
        Me.txtRisk.Location = New System.Drawing.Point(171, 50)
        Me.txtRisk.Name = "txtRisk"
        Me.txtRisk.Size = New System.Drawing.Size(58, 23)
        Me.txtRisk.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Will the card be High or Low?"
        '
        'btnHigh
        '
        Me.btnHigh.BackColor = System.Drawing.Color.Salmon
        Me.btnHigh.Location = New System.Drawing.Point(38, 130)
        Me.btnHigh.Name = "btnHigh"
        Me.btnHigh.Size = New System.Drawing.Size(75, 36)
        Me.btnHigh.TabIndex = 4
        Me.btnHigh.Text = "High"
        Me.btnHigh.UseVisualStyleBackColor = False
        '
        'btnLow
        '
        Me.btnLow.BackColor = System.Drawing.Color.SkyBlue
        Me.btnLow.Location = New System.Drawing.Point(154, 130)
        Me.btnLow.Name = "btnLow"
        Me.btnLow.Size = New System.Drawing.Size(75, 36)
        Me.btnLow.TabIndex = 5
        Me.btnLow.Text = "Low"
        Me.btnLow.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "The card is:"
        '
        'lblCard
        '
        Me.lblCard.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCard.Location = New System.Drawing.Point(132, 180)
        Me.lblCard.Name = "lblCard"
        Me.lblCard.Size = New System.Drawing.Size(51, 37)
        Me.lblCard.TabIndex = 7
        Me.lblCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblResult.Location = New System.Drawing.Point(41, 241)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(188, 32)
        Me.lblResult.TabIndex = 8
        Me.lblResult.Text = "Result:"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 301)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblCard)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLow)
        Me.Controls.Add(Me.btnHigh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRisk)
        Me.Controls.Add(Me.lblTotalPoints)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Game of High-Low"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPoints As System.Windows.Forms.Label
    Friend WithEvents txtRisk As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnHigh As System.Windows.Forms.Button
    Friend WithEvents btnLow As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCard As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
