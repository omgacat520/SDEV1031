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
        Me.components = New System.ComponentModel.Container()
        Me.picRocket = New System.Windows.Forms.PictureBox()
        Me.tmrCountDown = New System.Windows.Forms.Timer(Me.components)
        Me.lblCountDown = New System.Windows.Forms.Label()
        CType(Me.picRocket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picRocket
        '
        Me.picRocket.Image = Global.RocketBlastOff.My.Resources.Resources.rocket
        Me.picRocket.Location = New System.Drawing.Point(12, 406)
        Me.picRocket.Name = "picRocket"
        Me.picRocket.Size = New System.Drawing.Size(40, 110)
        Me.picRocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRocket.TabIndex = 0
        Me.picRocket.TabStop = False
        '
        'tmrCountDown
        '
        Me.tmrCountDown.Enabled = True
        Me.tmrCountDown.Interval = 1000
        '
        'lblCountDown
        '
        Me.lblCountDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountDown.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCountDown.Location = New System.Drawing.Point(76, 434)
        Me.lblCountDown.Name = "lblCountDown"
        Me.lblCountDown.Size = New System.Drawing.Size(123, 23)
        Me.lblCountDown.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.ClientSize = New System.Drawing.Size(230, 518)
        Me.Controls.Add(Me.lblCountDown)
        Me.Controls.Add(Me.picRocket)
        Me.Name = "Form1"
        Me.Text = "Countdown"
        CType(Me.picRocket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picRocket As System.Windows.Forms.PictureBox
    Friend WithEvents tmrCountDown As System.Windows.Forms.Timer
    Friend WithEvents lblCountDown As System.Windows.Forms.Label

End Class
