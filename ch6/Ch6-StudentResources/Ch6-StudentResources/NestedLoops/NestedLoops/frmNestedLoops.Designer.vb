<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNestedLoops
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
        Me.btnNested = New System.Windows.Forms.Button
        Me.btnCount = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.rtbOut = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'btnNested
        '
        Me.btnNested.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNested.Location = New System.Drawing.Point(53, 313)
        Me.btnNested.Name = "btnNested"
        Me.btnNested.Size = New System.Drawing.Size(75, 30)
        Me.btnNested.TabIndex = 0
        Me.btnNested.Text = "&Nested"
        Me.btnNested.UseVisualStyleBackColor = True
        '
        'btnCount
        '
        Me.btnCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCount.Location = New System.Drawing.Point(159, 313)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(75, 30)
        Me.btnCount.TabIndex = 1
        Me.btnCount.Text = "&Count"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(265, 313)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'rtbOut
        '
        Me.rtbOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.rtbOut.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbOut.Location = New System.Drawing.Point(0, 0)
        Me.rtbOut.Name = "rtbOut"
        Me.rtbOut.Size = New System.Drawing.Size(392, 270)
        Me.rtbOut.TabIndex = 3
        Me.rtbOut.Text = ""
        '
        'frmNestedLoops
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 373)
        Me.Controls.Add(Me.rtbOut)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.btnNested)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNestedLoops"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nested Loops Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNested As System.Windows.Forms.Button
    Friend WithEvents btnCount As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents rtbOut As System.Windows.Forms.RichTextBox

End Class
