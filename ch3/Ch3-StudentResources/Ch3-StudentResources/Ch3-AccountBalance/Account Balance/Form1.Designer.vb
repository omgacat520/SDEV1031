<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountBalance
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEndingBalance = New System.Windows.Forms.Label()
        Me.txtBeginningBalance = New System.Windows.Forms.TextBox()
        Me.txtDeposits = New System.Windows.Forms.TextBox()
        Me.txtWithdrawals = New System.Windows.Forms.TextBox()
        Me.btnBalance = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(153, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Beginning Balance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(153, 99)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Deposits"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(153, 147)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Withdrawals"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(153, 195)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ending Balance"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEndingBalance
        '
        Me.lblEndingBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEndingBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEndingBalance.Location = New System.Drawing.Point(13, 195)
        Me.lblEndingBalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndingBalance.Name = "lblEndingBalance"
        Me.lblEndingBalance.Size = New System.Drawing.Size(133, 28)
        Me.lblEndingBalance.TabIndex = 4
        Me.lblEndingBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBeginningBalance
        '
        Me.txtBeginningBalance.Location = New System.Drawing.Point(13, 51)
        Me.txtBeginningBalance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBeginningBalance.Name = "txtBeginningBalance"
        Me.txtBeginningBalance.Size = New System.Drawing.Size(132, 23)
        Me.txtBeginningBalance.TabIndex = 5
        Me.txtBeginningBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDeposits
        '
        Me.txtDeposits.Location = New System.Drawing.Point(13, 99)
        Me.txtDeposits.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeposits.Name = "txtDeposits"
        Me.txtDeposits.Size = New System.Drawing.Size(132, 23)
        Me.txtDeposits.TabIndex = 6
        Me.txtDeposits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWithdrawals
        '
        Me.txtWithdrawals.Location = New System.Drawing.Point(13, 147)
        Me.txtWithdrawals.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWithdrawals.Name = "txtWithdrawals"
        Me.txtWithdrawals.Size = New System.Drawing.Size(132, 23)
        Me.txtWithdrawals.TabIndex = 7
        Me.txtWithdrawals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnBalance
        '
        Me.btnBalance.Location = New System.Drawing.Point(156, 243)
        Me.btnBalance.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBalance.Name = "btnBalance"
        Me.btnBalance.Size = New System.Drawing.Size(100, 28)
        Me.btnBalance.TabIndex = 8
        Me.btnBalance.Text = "&Balance"
        Me.btnBalance.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(156, 295)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-1, 2)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(307, 28)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Savings Account Balance"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAccountBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 336)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBalance)
        Me.Controls.Add(Me.txtWithdrawals)
        Me.Controls.Add(Me.txtDeposits)
        Me.Controls.Add(Me.txtBeginningBalance)
        Me.Controls.Add(Me.lblEndingBalance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccountBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Balance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblEndingBalance As System.Windows.Forms.Label
    Friend WithEvents txtBeginningBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtDeposits As System.Windows.Forms.TextBox
    Friend WithEvents txtWithdrawals As System.Windows.Forms.TextBox
    Friend WithEvents btnBalance As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
