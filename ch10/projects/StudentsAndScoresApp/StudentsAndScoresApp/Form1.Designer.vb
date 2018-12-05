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
        Me.rtbStudents = New System.Windows.Forms.RichTextBox()
        Me.rtbScores = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStudentsAscnd = New System.Windows.Forms.Button()
        Me.btnStudentsDescnd = New System.Windows.Forms.Button()
        Me.btnScoresAscnd = New System.Windows.Forms.Button()
        Me.btnScoresDescnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbStudents
        '
        Me.rtbStudents.Location = New System.Drawing.Point(12, 45)
        Me.rtbStudents.Name = "rtbStudents"
        Me.rtbStudents.Size = New System.Drawing.Size(180, 148)
        Me.rtbStudents.TabIndex = 0
        Me.rtbStudents.Text = ""
        '
        'rtbScores
        '
        Me.rtbScores.Location = New System.Drawing.Point(198, 45)
        Me.rtbScores.Name = "rtbScores"
        Me.rtbScores.Size = New System.Drawing.Size(180, 148)
        Me.rtbScores.TabIndex = 1
        Me.rtbScores.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Students"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Scores"
        '
        'btnStudentsAscnd
        '
        Me.btnStudentsAscnd.Location = New System.Drawing.Point(15, 199)
        Me.btnStudentsAscnd.Name = "btnStudentsAscnd"
        Me.btnStudentsAscnd.Size = New System.Drawing.Size(177, 23)
        Me.btnStudentsAscnd.TabIndex = 4
        Me.btnStudentsAscnd.Text = "Sort students ascending"
        Me.btnStudentsAscnd.UseVisualStyleBackColor = True
        '
        'btnStudentsDescnd
        '
        Me.btnStudentsDescnd.Location = New System.Drawing.Point(15, 228)
        Me.btnStudentsDescnd.Name = "btnStudentsDescnd"
        Me.btnStudentsDescnd.Size = New System.Drawing.Size(177, 23)
        Me.btnStudentsDescnd.TabIndex = 5
        Me.btnStudentsDescnd.Text = "Sort students descending"
        Me.btnStudentsDescnd.UseVisualStyleBackColor = True
        '
        'btnScoresAscnd
        '
        Me.btnScoresAscnd.Location = New System.Drawing.Point(198, 199)
        Me.btnScoresAscnd.Name = "btnScoresAscnd"
        Me.btnScoresAscnd.Size = New System.Drawing.Size(177, 23)
        Me.btnScoresAscnd.TabIndex = 6
        Me.btnScoresAscnd.Text = "Sort scores ascending"
        Me.btnScoresAscnd.UseVisualStyleBackColor = True
        '
        'btnScoresDescnd
        '
        Me.btnScoresDescnd.Location = New System.Drawing.Point(198, 228)
        Me.btnScoresDescnd.Name = "btnScoresDescnd"
        Me.btnScoresDescnd.Size = New System.Drawing.Size(177, 23)
        Me.btnScoresDescnd.TabIndex = 7
        Me.btnScoresDescnd.Text = "Sort scores descending"
        Me.btnScoresDescnd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 279)
        Me.Controls.Add(Me.btnScoresDescnd)
        Me.Controls.Add(Me.btnScoresAscnd)
        Me.Controls.Add(Me.btnStudentsDescnd)
        Me.Controls.Add(Me.btnStudentsAscnd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtbScores)
        Me.Controls.Add(Me.rtbStudents)
        Me.Name = "Form1"
        Me.Text = "students and scores yeehaw"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbStudents As RichTextBox
    Friend WithEvents rtbScores As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnStudentsAscnd As Button
    Friend WithEvents btnStudentsDescnd As Button
    Friend WithEvents btnScoresAscnd As Button
    Friend WithEvents btnScoresDescnd As Button
End Class
