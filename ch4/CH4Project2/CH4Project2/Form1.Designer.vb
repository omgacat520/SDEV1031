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
        Me.nudStars = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.btnRateIt = New System.Windows.Forms.Button()
        Me.btnAvgRating = New System.Windows.Forms.Button()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.lblTotalRatings = New System.Windows.Forms.Label()
        Me.lblWordOutput = New System.Windows.Forms.Label()
        Me.lblStarOut = New System.Windows.Forms.Label()
        CType(Me.nudStars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please rate the movie 1 to 5 stars"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "How many stars?"
        '
        'nudStars
        '
        Me.nudStars.Location = New System.Drawing.Point(111, 54)
        Me.nudStars.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudStars.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStars.Name = "nudStars"
        Me.nudStars.Size = New System.Drawing.Size(30, 20)
        Me.nudStars.TabIndex = 1
        Me.nudStars.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "(1 = trash movie / 5 = best movie ever)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "What one word describes the movie?"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(15, 107)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(180, 20)
        Me.txtWord.TabIndex = 2
        '
        'btnRateIt
        '
        Me.btnRateIt.Location = New System.Drawing.Point(15, 133)
        Me.btnRateIt.Name = "btnRateIt"
        Me.btnRateIt.Size = New System.Drawing.Size(75, 23)
        Me.btnRateIt.TabIndex = 5
        Me.btnRateIt.Text = "Rate it!"
        Me.btnRateIt.UseVisualStyleBackColor = True
        '
        'btnAvgRating
        '
        Me.btnAvgRating.Location = New System.Drawing.Point(15, 212)
        Me.btnAvgRating.Name = "btnAvgRating"
        Me.btnAvgRating.Size = New System.Drawing.Size(90, 23)
        Me.btnAvgRating.TabIndex = 6
        Me.btnAvgRating.Text = "Average Rating"
        Me.btnAvgRating.UseVisualStyleBackColor = True
        '
        'lblAvg
        '
        Me.lblAvg.AutoSize = True
        Me.lblAvg.Location = New System.Drawing.Point(111, 217)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(13, 13)
        Me.lblAvg.TabIndex = 7
        Me.lblAvg.Text = "0"
        Me.lblAvg.Visible = False
        '
        'lblTotalRatings
        '
        Me.lblTotalRatings.AutoSize = True
        Me.lblTotalRatings.Location = New System.Drawing.Point(17, 250)
        Me.lblTotalRatings.Name = "lblTotalRatings"
        Me.lblTotalRatings.Size = New System.Drawing.Size(82, 13)
        Me.lblTotalRatings.TabIndex = 8
        Me.lblTotalRatings.Text = "Total Ratings: 0"
        '
        'lblWordOutput
        '
        Me.lblWordOutput.AutoSize = True
        Me.lblWordOutput.Location = New System.Drawing.Point(12, 171)
        Me.lblWordOutput.Name = "lblWordOutput"
        Me.lblWordOutput.Size = New System.Drawing.Size(235, 13)
        Me.lblWordOutput.TabIndex = 9
        Me.lblWordOutput.Text = "Thank you for rating this movie ____ with _ stars"
        Me.lblWordOutput.Visible = False
        '
        'lblStarOut
        '
        Me.lblStarOut.AutoSize = True
        Me.lblStarOut.Location = New System.Drawing.Point(130, 217)
        Me.lblStarOut.Name = "lblStarOut"
        Me.lblStarOut.Size = New System.Drawing.Size(29, 13)
        Me.lblStarOut.TabIndex = 10
        Me.lblStarOut.Text = "stars"
        Me.lblStarOut.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 291)
        Me.Controls.Add(Me.lblStarOut)
        Me.Controls.Add(Me.lblWordOutput)
        Me.Controls.Add(Me.lblTotalRatings)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.btnAvgRating)
        Me.Controls.Add(Me.btnRateIt)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudStars)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Rate this movie!"
        CType(Me.nudStars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nudStars As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtWord As TextBox
    Friend WithEvents btnRateIt As Button
    Friend WithEvents btnAvgRating As Button
    Friend WithEvents lblAvg As Label
    Friend WithEvents lblTotalRatings As Label
    Friend WithEvents lblWordOutput As Label
    Friend WithEvents lblStarOut As Label
End Class
