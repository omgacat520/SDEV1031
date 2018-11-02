<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuExample
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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShape = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShapeRectangle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShapeRectanglePerimeter = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuShapeRectangleArea = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShapeTriangle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShapeTrianglePerimeter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShapeTriangleArea = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShapeCircle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShapeCircleCircumference = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShapeCircleArea = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRecPerimeter = New System.Windows.Forms.Button()
        Me.btnRecArea = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblRecPerimeter = New System.Windows.Forms.Label()
        Me.lblRecArea = New System.Windows.Forms.Label()
        Me.txtSide = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTriPerimeter = New System.Windows.Forms.Label()
        Me.lblTriArea = New System.Windows.Forms.Label()
        Me.btnTriPerimeter = New System.Windows.Forms.Button()
        Me.btnTriArea = New System.Windows.Forms.Button()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCircumference = New System.Windows.Forms.Button()
        Me.btnCircArea = New System.Windows.Forms.Button()
        Me.lblCircumference = New System.Windows.Forms.Label()
        Me.lblCircArea = New System.Windows.Forms.Label()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuShape})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(492, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuShape
        '
        Me.mnuShape.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShapeRectangle, Me.mnuShapeTriangle, Me.mnuShapeCircle})
        Me.mnuShape.Name = "mnuShape"
        Me.mnuShape.Size = New System.Drawing.Size(51, 20)
        Me.mnuShape.Text = "&Shape"
        '
        'mnuShapeRectangle
        '
        Me.mnuShapeRectangle.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShapeRectanglePerimeter, Me.menuShapeRectangleArea})
        Me.mnuShapeRectangle.Name = "mnuShapeRectangle"
        Me.mnuShapeRectangle.Size = New System.Drawing.Size(152, 22)
        Me.mnuShapeRectangle.Text = "&Rectangle"
        '
        'mnuShapeRectanglePerimeter
        '
        Me.mnuShapeRectanglePerimeter.Name = "mnuShapeRectanglePerimeter"
        Me.mnuShapeRectanglePerimeter.Size = New System.Drawing.Size(125, 22)
        Me.mnuShapeRectanglePerimeter.Text = "Perimeter"
        '
        'menuShapeRectangleArea
        '
        Me.menuShapeRectangleArea.Name = "menuShapeRectangleArea"
        Me.menuShapeRectangleArea.Size = New System.Drawing.Size(125, 22)
        Me.menuShapeRectangleArea.Text = "Area"
        '
        'mnuShapeTriangle
        '
        Me.mnuShapeTriangle.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShapeTrianglePerimeter, Me.mnuShapeTriangleArea})
        Me.mnuShapeTriangle.Name = "mnuShapeTriangle"
        Me.mnuShapeTriangle.Size = New System.Drawing.Size(152, 22)
        Me.mnuShapeTriangle.Text = "&Triangle"
        '
        'mnuShapeTrianglePerimeter
        '
        Me.mnuShapeTrianglePerimeter.Name = "mnuShapeTrianglePerimeter"
        Me.mnuShapeTrianglePerimeter.Size = New System.Drawing.Size(125, 22)
        Me.mnuShapeTrianglePerimeter.Text = "Perimeter"
        '
        'mnuShapeTriangleArea
        '
        Me.mnuShapeTriangleArea.Name = "mnuShapeTriangleArea"
        Me.mnuShapeTriangleArea.Size = New System.Drawing.Size(125, 22)
        Me.mnuShapeTriangleArea.Text = "Area"
        '
        'mnuShapeCircle
        '
        Me.mnuShapeCircle.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShapeCircleCircumference, Me.mnuShapeCircleArea})
        Me.mnuShapeCircle.Name = "mnuShapeCircle"
        Me.mnuShapeCircle.Size = New System.Drawing.Size(152, 22)
        Me.mnuShapeCircle.Text = "&Circle"
        '
        'mnuShapeCircleCircumference
        '
        Me.mnuShapeCircleCircumference.Name = "mnuShapeCircleCircumference"
        Me.mnuShapeCircleCircumference.Size = New System.Drawing.Size(152, 22)
        Me.mnuShapeCircleCircumference.Text = "Circumference"
        '
        'mnuShapeCircleArea
        '
        Me.mnuShapeCircleArea.Name = "mnuShapeCircleArea"
        Me.mnuShapeCircleArea.Size = New System.Drawing.Size(152, 22)
        Me.mnuShapeCircleArea.Text = "Area"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(358, 418)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 30)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRecPerimeter
        '
        Me.btnRecPerimeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecPerimeter.Location = New System.Drawing.Point(358, 50)
        Me.btnRecPerimeter.Name = "btnRecPerimeter"
        Me.btnRecPerimeter.Size = New System.Drawing.Size(122, 30)
        Me.btnRecPerimeter.TabIndex = 5
        Me.btnRecPerimeter.Text = "Perimeter"
        Me.btnRecPerimeter.UseVisualStyleBackColor = True
        '
        'btnRecArea
        '
        Me.btnRecArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecArea.Location = New System.Drawing.Point(358, 95)
        Me.btnRecArea.Name = "btnRecArea"
        Me.btnRecArea.Size = New System.Drawing.Size(122, 30)
        Me.btnRecArea.TabIndex = 6
        Me.btnRecArea.Text = "Area"
        Me.btnRecArea.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(492, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Rectangle"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(492, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Triangle"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(492, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Circle"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtLength
        '
        Me.txtLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLength.Location = New System.Drawing.Point(12, 50)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(94, 26)
        Me.txtLength.TabIndex = 0
        Me.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWidth
        '
        Me.txtWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWidth.Location = New System.Drawing.Point(12, 97)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(94, 26)
        Me.txtWidth.TabIndex = 1
        Me.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Length"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Width"
        '
        'lblRecPerimeter
        '
        Me.lblRecPerimeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecPerimeter.Location = New System.Drawing.Point(262, 53)
        Me.lblRecPerimeter.Name = "lblRecPerimeter"
        Me.lblRecPerimeter.Size = New System.Drawing.Size(83, 23)
        Me.lblRecPerimeter.TabIndex = 11
        Me.lblRecPerimeter.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRecArea
        '
        Me.lblRecArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecArea.Location = New System.Drawing.Point(262, 99)
        Me.lblRecArea.Name = "lblRecArea"
        Me.lblRecArea.Size = New System.Drawing.Size(83, 23)
        Me.lblRecArea.TabIndex = 12
        Me.lblRecArea.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSide
        '
        Me.txtSide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSide.Location = New System.Drawing.Point(12, 182)
        Me.txtSide.Name = "txtSide"
        Me.txtSide.Size = New System.Drawing.Size(94, 26)
        Me.txtSide.TabIndex = 2
        Me.txtSide.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(112, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Side"
        '
        'lblTriPerimeter
        '
        Me.lblTriPerimeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTriPerimeter.Location = New System.Drawing.Point(262, 182)
        Me.lblTriPerimeter.Name = "lblTriPerimeter"
        Me.lblTriPerimeter.Size = New System.Drawing.Size(83, 23)
        Me.lblTriPerimeter.TabIndex = 15
        Me.lblTriPerimeter.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTriArea
        '
        Me.lblTriArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTriArea.Location = New System.Drawing.Point(262, 229)
        Me.lblTriArea.Name = "lblTriArea"
        Me.lblTriArea.Size = New System.Drawing.Size(83, 23)
        Me.lblTriArea.TabIndex = 16
        Me.lblTriArea.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnTriPerimeter
        '
        Me.btnTriPerimeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTriPerimeter.Location = New System.Drawing.Point(358, 177)
        Me.btnTriPerimeter.Name = "btnTriPerimeter"
        Me.btnTriPerimeter.Size = New System.Drawing.Size(122, 30)
        Me.btnTriPerimeter.TabIndex = 7
        Me.btnTriPerimeter.Text = "Perimeter"
        Me.btnTriPerimeter.UseVisualStyleBackColor = True
        '
        'btnTriArea
        '
        Me.btnTriArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTriArea.Location = New System.Drawing.Point(358, 224)
        Me.btnTriArea.Name = "btnTriArea"
        Me.btnTriArea.Size = New System.Drawing.Size(122, 30)
        Me.btnTriArea.TabIndex = 8
        Me.btnTriArea.Text = "Area"
        Me.btnTriArea.UseVisualStyleBackColor = True
        '
        'txtRadius
        '
        Me.txtRadius.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRadius.Location = New System.Drawing.Point(12, 308)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(94, 26)
        Me.txtRadius.TabIndex = 4
        Me.txtRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(112, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 23)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Radius"
        '
        'btnCircumference
        '
        Me.btnCircumference.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCircumference.Location = New System.Drawing.Point(358, 306)
        Me.btnCircumference.Name = "btnCircumference"
        Me.btnCircumference.Size = New System.Drawing.Size(122, 30)
        Me.btnCircumference.TabIndex = 9
        Me.btnCircumference.Text = "Circumference"
        Me.btnCircumference.UseVisualStyleBackColor = True
        '
        'btnCircArea
        '
        Me.btnCircArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCircArea.Location = New System.Drawing.Point(358, 349)
        Me.btnCircArea.Name = "btnCircArea"
        Me.btnCircArea.Size = New System.Drawing.Size(122, 30)
        Me.btnCircArea.TabIndex = 10
        Me.btnCircArea.Text = "Area"
        Me.btnCircArea.UseVisualStyleBackColor = True
        '
        'lblCircumference
        '
        Me.lblCircumference.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCircumference.Location = New System.Drawing.Point(262, 311)
        Me.lblCircumference.Name = "lblCircumference"
        Me.lblCircumference.Size = New System.Drawing.Size(83, 23)
        Me.lblCircumference.TabIndex = 25
        Me.lblCircumference.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCircArea
        '
        Me.lblCircArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCircArea.Location = New System.Drawing.Point(262, 354)
        Me.lblCircArea.Name = "lblCircArea"
        Me.lblCircArea.Size = New System.Drawing.Size(83, 23)
        Me.lblCircArea.TabIndex = 26
        Me.lblCircArea.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmMenuExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 473)
        Me.Controls.Add(Me.lblCircArea)
        Me.Controls.Add(Me.lblCircumference)
        Me.Controls.Add(Me.btnCircArea)
        Me.Controls.Add(Me.btnCircumference)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.btnTriArea)
        Me.Controls.Add(Me.btnTriPerimeter)
        Me.Controls.Add(Me.lblTriArea)
        Me.Controls.Add(Me.lblTriPerimeter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSide)
        Me.Controls.Add(Me.lblRecArea)
        Me.Controls.Add(Me.lblRecPerimeter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRecArea)
        Me.Controls.Add(Me.btnRecPerimeter)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenuExample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menus"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShape As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShapeRectangle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShapeRectanglePerimeter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuShapeRectangleArea As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShapeTriangle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShapeCircle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShapeTrianglePerimeter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShapeTriangleArea As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShapeCircleCircumference As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShapeCircleArea As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRecPerimeter As System.Windows.Forms.Button
    Friend WithEvents btnRecArea As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblRecPerimeter As System.Windows.Forms.Label
    Friend WithEvents lblRecArea As System.Windows.Forms.Label
    Friend WithEvents txtSide As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTriPerimeter As System.Windows.Forms.Label
    Friend WithEvents lblTriArea As System.Windows.Forms.Label
    Friend WithEvents btnTriPerimeter As System.Windows.Forms.Button
    Friend WithEvents btnTriArea As System.Windows.Forms.Button
    Friend WithEvents txtRadius As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCircumference As System.Windows.Forms.Button
    Friend WithEvents btnCircArea As System.Windows.Forms.Button
    Friend WithEvents lblCircumference As System.Windows.Forms.Label
    Friend WithEvents lblCircArea As System.Windows.Forms.Label

End Class
