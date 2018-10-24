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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudAdults = New System.Windows.Forms.NumericUpDown()
        Me.nudKids = New System.Windows.Forms.NumericUpDown()
        Me.nudSeniors = New System.Windows.Forms.NumericUpDown()
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.nudPopcorn = New System.Windows.Forms.NumericUpDown()
        Me.nudDrink = New System.Windows.Forms.NumericUpDown()
        Me.lblSnacks = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnTickets = New System.Windows.Forms.Button()
        Me.btnSnacks = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.nudAdults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudKids, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSeniors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPopcorn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDrink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Ivory
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Movie Ticket Sales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Ivory
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "# of adults (10$)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Ivory
        Me.Label3.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "# of kids (6$)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Ivory
        Me.Label4.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "# of seniors (8$)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Ivory
        Me.Label6.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Snacks"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Ivory
        Me.Label7.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Popcorn (5$)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Ivory
        Me.Label8.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Drink (3$)"
        '
        'nudAdults
        '
        Me.nudAdults.Location = New System.Drawing.Point(271, 38)
        Me.nudAdults.Name = "nudAdults"
        Me.nudAdults.Size = New System.Drawing.Size(78, 20)
        Me.nudAdults.TabIndex = 10
        '
        'nudKids
        '
        Me.nudKids.Location = New System.Drawing.Point(271, 61)
        Me.nudKids.Name = "nudKids"
        Me.nudKids.Size = New System.Drawing.Size(78, 20)
        Me.nudKids.TabIndex = 11
        '
        'nudSeniors
        '
        Me.nudSeniors.Location = New System.Drawing.Point(271, 85)
        Me.nudSeniors.Name = "nudSeniors"
        Me.nudSeniors.Size = New System.Drawing.Size(78, 20)
        Me.nudSeniors.TabIndex = 12
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.BackColor = System.Drawing.Color.Yellow
        Me.lblTickets.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTickets.Location = New System.Drawing.Point(268, 129)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(22, 17)
        Me.lblTickets.TabIndex = 14
        Me.lblTickets.Text = "0$"
        '
        'nudPopcorn
        '
        Me.nudPopcorn.Location = New System.Drawing.Point(271, 189)
        Me.nudPopcorn.Name = "nudPopcorn"
        Me.nudPopcorn.Size = New System.Drawing.Size(78, 20)
        Me.nudPopcorn.TabIndex = 16
        '
        'nudDrink
        '
        Me.nudDrink.Location = New System.Drawing.Point(271, 214)
        Me.nudDrink.Name = "nudDrink"
        Me.nudDrink.Size = New System.Drawing.Size(78, 20)
        Me.nudDrink.TabIndex = 17
        '
        'lblSnacks
        '
        Me.lblSnacks.AutoSize = True
        Me.lblSnacks.BackColor = System.Drawing.Color.Yellow
        Me.lblSnacks.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnacks.Location = New System.Drawing.Point(268, 251)
        Me.lblSnacks.Name = "lblSnacks"
        Me.lblSnacks.Size = New System.Drawing.Size(22, 17)
        Me.lblSnacks.TabIndex = 18
        Me.lblSnacks.Text = "0$"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(268, 287)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(22, 17)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "0$"
        '
        'btnTickets
        '
        Me.btnTickets.BackColor = System.Drawing.Color.Yellow
        Me.btnTickets.Location = New System.Drawing.Point(31, 127)
        Me.btnTickets.Name = "btnTickets"
        Me.btnTickets.Size = New System.Drawing.Size(101, 23)
        Me.btnTickets.TabIndex = 20
        Me.btnTickets.Text = "Ticket Subtotal"
        Me.btnTickets.UseVisualStyleBackColor = False
        '
        'btnSnacks
        '
        Me.btnSnacks.BackColor = System.Drawing.Color.Yellow
        Me.btnSnacks.Location = New System.Drawing.Point(31, 245)
        Me.btnSnacks.Name = "btnSnacks"
        Me.btnSnacks.Size = New System.Drawing.Size(101, 23)
        Me.btnSnacks.TabIndex = 21
        Me.btnSnacks.Text = "Snack Subtotal"
        Me.btnSnacks.UseVisualStyleBackColor = False
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnTotal.Location = New System.Drawing.Point(31, 285)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(101, 23)
        Me.btnTotal.TabIndex = 22
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(271, 7)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(392, 323)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnSnacks)
        Me.Controls.Add(Me.btnTickets)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSnacks)
        Me.Controls.Add(Me.nudDrink)
        Me.Controls.Add(Me.nudPopcorn)
        Me.Controls.Add(Me.lblTickets)
        Me.Controls.Add(Me.nudSeniors)
        Me.Controls.Add(Me.nudKids)
        Me.Controls.Add(Me.nudAdults)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Movie Ticket Sales"
        CType(Me.nudAdults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudKids, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSeniors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPopcorn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDrink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nudAdults As NumericUpDown
    Friend WithEvents nudKids As NumericUpDown
    Friend WithEvents nudSeniors As NumericUpDown
    Friend WithEvents lblTickets As Label
    Friend WithEvents nudPopcorn As NumericUpDown
    Friend WithEvents nudDrink As NumericUpDown
    Friend WithEvents lblSnacks As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnTickets As Button
    Friend WithEvents btnSnacks As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnClear As Button
End Class
