<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChristmasLights
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
        Me.components = New System.ComponentModel.Container
        Me.picOff = New System.Windows.Forms.PictureBox
        Me.picOn = New System.Windows.Forms.PictureBox
        Me.btnFlash = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.tmrTwinkle = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picOff
        '
        Me.picOff.Image = Global.ChristmasLights.My.Resources.Resources.LightsOff
        Me.picOff.Location = New System.Drawing.Point(0, 0)
        Me.picOff.Name = "picOff"
        Me.picOff.Size = New System.Drawing.Size(398, 129)
        Me.picOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picOff.TabIndex = 1
        Me.picOff.TabStop = False
        Me.picOff.Visible = False
        '
        'picOn
        '
        Me.picOn.Image = Global.ChristmasLights.My.Resources.Resources.LightsOn
        Me.picOn.Location = New System.Drawing.Point(0, 0)
        Me.picOn.Name = "picOn"
        Me.picOn.Size = New System.Drawing.Size(398, 129)
        Me.picOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picOn.TabIndex = 0
        Me.picOn.TabStop = False
        '
        'btnFlash
        '
        Me.btnFlash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFlash.Location = New System.Drawing.Point(72, 148)
        Me.btnFlash.Name = "btnFlash"
        Me.btnFlash.Size = New System.Drawing.Size(75, 30)
        Me.btnFlash.TabIndex = 2
        Me.btnFlash.Text = "&Flash"
        Me.btnFlash.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(234, 148)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tmrTwinkle
        '
        Me.tmrTwinkle.Interval = 1000
        '
        'frmChristmasLights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 199)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFlash)
        Me.Controls.Add(Me.picOff)
        Me.Controls.Add(Me.picOn)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChristmasLights"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timer Demo"
        CType(Me.picOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picOn As System.Windows.Forms.PictureBox
    Friend WithEvents picOff As System.Windows.Forms.PictureBox
    Friend WithEvents btnFlash As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents tmrTwinkle As System.Windows.Forms.Timer

End Class
