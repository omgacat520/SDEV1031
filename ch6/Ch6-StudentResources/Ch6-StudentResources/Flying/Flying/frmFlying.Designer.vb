<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlying
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
        Me.btnBiplane = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPlaneII = New System.Windows.Forms.Button()
        Me.btnBalloon = New System.Windows.Forms.Button()
        Me.btnParachute = New System.Windows.Forms.Button()
        Me.btnKite = New System.Windows.Forms.Button()
        Me.picKite = New System.Windows.Forms.PictureBox()
        Me.picParachute = New System.Windows.Forms.PictureBox()
        Me.picBalloon = New System.Windows.Forms.PictureBox()
        Me.picPlaneII = New System.Windows.Forms.PictureBox()
        Me.picBiplane = New System.Windows.Forms.PictureBox()
        CType(Me.picKite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picParachute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBalloon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlaneII, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBiplane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBiplane
        '
        Me.btnBiplane.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBiplane.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBiplane.Location = New System.Drawing.Point(12, 310)
        Me.btnBiplane.Name = "btnBiplane"
        Me.btnBiplane.Size = New System.Drawing.Size(91, 30)
        Me.btnBiplane.TabIndex = 0
        Me.btnBiplane.Text = "&Biplane"
        Me.btnBiplane.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(12, 540)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnPlaneII
        '
        Me.btnPlaneII.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlaneII.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaneII.Location = New System.Drawing.Point(12, 356)
        Me.btnPlaneII.Name = "btnPlaneII"
        Me.btnPlaneII.Size = New System.Drawing.Size(91, 30)
        Me.btnPlaneII.TabIndex = 1
        Me.btnPlaneII.Text = "&Plane"
        Me.btnPlaneII.UseVisualStyleBackColor = False
        '
        'btnBalloon
        '
        Me.btnBalloon.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBalloon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBalloon.Location = New System.Drawing.Point(12, 448)
        Me.btnBalloon.Name = "btnBalloon"
        Me.btnBalloon.Size = New System.Drawing.Size(91, 30)
        Me.btnBalloon.TabIndex = 3
        Me.btnBalloon.Text = "B&alloon"
        Me.btnBalloon.UseVisualStyleBackColor = False
        '
        'btnParachute
        '
        Me.btnParachute.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnParachute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParachute.Location = New System.Drawing.Point(12, 402)
        Me.btnParachute.Name = "btnParachute"
        Me.btnParachute.Size = New System.Drawing.Size(91, 30)
        Me.btnParachute.TabIndex = 2
        Me.btnParachute.Text = "Pa&rachute"
        Me.btnParachute.UseVisualStyleBackColor = False
        '
        'btnKite
        '
        Me.btnKite.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnKite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKite.Location = New System.Drawing.Point(12, 494)
        Me.btnKite.Name = "btnKite"
        Me.btnKite.Size = New System.Drawing.Size(91, 30)
        Me.btnKite.TabIndex = 4
        Me.btnKite.Text = "&Kite"
        Me.btnKite.UseVisualStyleBackColor = False
        '
        'picKite
        '
        Me.picKite.Image = Global.Flying.My.Resources.Resources.kite
        Me.picKite.Location = New System.Drawing.Point(500, 500)
        Me.picKite.Name = "picKite"
        Me.picKite.Size = New System.Drawing.Size(91, 75)
        Me.picKite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picKite.TabIndex = 10
        Me.picKite.TabStop = False
        '
        'picParachute
        '
        Me.picParachute.Image = Global.Flying.My.Resources.Resources.parachute
        Me.picParachute.Location = New System.Drawing.Point(375, 0)
        Me.picParachute.Name = "picParachute"
        Me.picParachute.Size = New System.Drawing.Size(75, 107)
        Me.picParachute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picParachute.TabIndex = 8
        Me.picParachute.TabStop = False
        '
        'picBalloon
        '
        Me.picBalloon.Image = Global.Flying.My.Resources.Resources.balloon
        Me.picBalloon.Location = New System.Drawing.Point(121, 471)
        Me.picBalloon.Name = "picBalloon"
        Me.picBalloon.Size = New System.Drawing.Size(64, 104)
        Me.picBalloon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBalloon.TabIndex = 6
        Me.picBalloon.TabStop = False
        '
        'picPlaneII
        '
        Me.picPlaneII.Image = Global.Flying.My.Resources.Resources.planeII
        Me.picPlaneII.Location = New System.Drawing.Point(514, 228)
        Me.picPlaneII.Name = "picPlaneII"
        Me.picPlaneII.Size = New System.Drawing.Size(80, 59)
        Me.picPlaneII.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPlaneII.TabIndex = 3
        Me.picPlaneII.TabStop = False
        '
        'picBiplane
        '
        Me.picBiplane.Image = Global.Flying.My.Resources.Resources.biplane
        Me.picBiplane.Location = New System.Drawing.Point(0, 150)
        Me.picBiplane.Name = "picBiplane"
        Me.picBiplane.Size = New System.Drawing.Size(74, 62)
        Me.picBiplane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBiplane.TabIndex = 0
        Me.picBiplane.TabStop = False
        '
        'frmFlying
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(592, 573)
        Me.Controls.Add(Me.picKite)
        Me.Controls.Add(Me.btnKite)
        Me.Controls.Add(Me.picParachute)
        Me.Controls.Add(Me.btnParachute)
        Me.Controls.Add(Me.picBalloon)
        Me.Controls.Add(Me.btnBalloon)
        Me.Controls.Add(Me.btnPlaneII)
        Me.Controls.Add(Me.picPlaneII)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBiplane)
        Me.Controls.Add(Me.picBiplane)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFlying"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Using Loops to Fly"
        CType(Me.picKite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picParachute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBalloon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlaneII, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBiplane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBiplane As System.Windows.Forms.PictureBox
    Friend WithEvents btnBiplane As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picPlaneII As System.Windows.Forms.PictureBox
    Friend WithEvents btnPlaneII As System.Windows.Forms.Button
    Friend WithEvents btnBalloon As System.Windows.Forms.Button
    Friend WithEvents picBalloon As System.Windows.Forms.PictureBox
    Friend WithEvents btnParachute As System.Windows.Forms.Button
    Friend WithEvents picParachute As System.Windows.Forms.PictureBox
    Friend WithEvents btnKite As System.Windows.Forms.Button
    Friend WithEvents picKite As System.Windows.Forms.PictureBox

End Class
