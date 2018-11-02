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
        Me.rtbLyrics = New System.Windows.Forms.RichTextBox()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSongWheels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSongWipers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSongHorn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSongRiders = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSongSprings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSongMotor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSongSignals = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSongBrakes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoreMoney = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoreDoors = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoreBell = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoreDriver = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoreBaby = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMoreMother = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMorePeople = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtbLyrics
        '
        Me.rtbLyrics.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbLyrics.Location = New System.Drawing.Point(13, 23)
        Me.rtbLyrics.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rtbLyrics.Name = "rtbLyrics"
        Me.rtbLyrics.Size = New System.Drawing.Size(475, 175)
        Me.rtbLyrics.TabIndex = 0
        Me.rtbLyrics.Text = ""
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuSong, Me.mnuMore})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnuMain.Size = New System.Drawing.Size(501, 24)
        Me.mnuMain.TabIndex = 1
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuSong
        '
        Me.mnuSong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSongWheels, Me.mnuSongWipers, Me.mnuSongHorn, Me.mnuSongRiders, Me.mnuSongSprings, Me.mnuSongMotor, Me.mnuSongSignals, Me.mnuSongBrakes})
        Me.mnuSong.Name = "mnuSong"
        Me.mnuSong.Size = New System.Drawing.Size(46, 20)
        Me.mnuSong.Text = "Song"
        '
        'mnuSongWheels
        '
        Me.mnuSongWheels.Name = "mnuSongWheels"
        Me.mnuSongWheels.Size = New System.Drawing.Size(152, 22)
        Me.mnuSongWheels.Text = "Wheels"
        '
        'mnuSongWipers
        '
        Me.mnuSongWipers.Name = "mnuSongWipers"
        Me.mnuSongWipers.Size = New System.Drawing.Size(152, 22)
        Me.mnuSongWipers.Text = "Wipers"
        '
        'mnuSongHorn
        '
        Me.mnuSongHorn.Name = "mnuSongHorn"
        Me.mnuSongHorn.Size = New System.Drawing.Size(152, 22)
        Me.mnuSongHorn.Text = "Horn"
        '
        'mnuSongRiders
        '
        Me.mnuSongRiders.Name = "mnuSongRiders"
        Me.mnuSongRiders.Size = New System.Drawing.Size(152, 22)
        Me.mnuSongRiders.Text = "Riders"
        '
        'mnuSongSprings
        '
        Me.mnuSongSprings.Name = "mnuSongSprings"
        Me.mnuSongSprings.Size = New System.Drawing.Size(152, 22)
        Me.mnuSongSprings.Text = "Springs"
        '
        'mnuSongMotor
        '
        Me.mnuSongMotor.Name = "mnuSongMotor"
        Me.mnuSongMotor.Size = New System.Drawing.Size(152, 22)
        Me.mnuSongMotor.Text = "Motor"
        '
        'mnuSongSignals
        '
        Me.mnuSongSignals.Name = "mnuSongSignals"
        Me.mnuSongSignals.Size = New System.Drawing.Size(152, 22)
        Me.mnuSongSignals.Text = "Signals"
        '
        'mnuSongBrakes
        '
        Me.mnuSongBrakes.Name = "mnuSongBrakes"
        Me.mnuSongBrakes.Size = New System.Drawing.Size(152, 22)
        Me.mnuSongBrakes.Text = "Brakes"
        '
        'mnuMore
        '
        Me.mnuMore.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMoreMoney, Me.mnuMoreDoors, Me.mnuMoreBell, Me.mnuMoreDriver, Me.mnuMoreBaby, Me.mnuMoreMother, Me.mnuMorePeople})
        Me.mnuMore.Name = "mnuMore"
        Me.mnuMore.Size = New System.Drawing.Size(47, 20)
        Me.mnuMore.Text = "More"
        '
        'mnuMoreMoney
        '
        Me.mnuMoreMoney.Name = "mnuMoreMoney"
        Me.mnuMoreMoney.Size = New System.Drawing.Size(113, 22)
        Me.mnuMoreMoney.Text = "Money"
        '
        'mnuMoreDoors
        '
        Me.mnuMoreDoors.Name = "mnuMoreDoors"
        Me.mnuMoreDoors.Size = New System.Drawing.Size(113, 22)
        Me.mnuMoreDoors.Text = "Doors"
        '
        'mnuMoreBell
        '
        Me.mnuMoreBell.Name = "mnuMoreBell"
        Me.mnuMoreBell.Size = New System.Drawing.Size(113, 22)
        Me.mnuMoreBell.Text = "Bell"
        '
        'mnuMoreDriver
        '
        Me.mnuMoreDriver.Name = "mnuMoreDriver"
        Me.mnuMoreDriver.Size = New System.Drawing.Size(113, 22)
        Me.mnuMoreDriver.Text = "Driver"
        '
        'mnuMoreBaby
        '
        Me.mnuMoreBaby.Name = "mnuMoreBaby"
        Me.mnuMoreBaby.Size = New System.Drawing.Size(113, 22)
        Me.mnuMoreBaby.Text = "Baby"
        '
        'mnuMoreMother
        '
        Me.mnuMoreMother.Name = "mnuMoreMother"
        Me.mnuMoreMother.Size = New System.Drawing.Size(113, 22)
        Me.mnuMoreMother.Text = "Mother"
        '
        'mnuMorePeople
        '
        Me.mnuMorePeople.Name = "mnuMorePeople"
        Me.mnuMorePeople.Size = New System.Drawing.Size(113, 22)
        Me.mnuMorePeople.Text = "People"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 212)
        Me.Controls.Add(Me.rtbLyrics)
        Me.Controls.Add(Me.mnuMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.mnuMain
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "The Wheels On the Bus"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbLyrics As System.Windows.Forms.RichTextBox
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSongWheels As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSongWipers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSongHorn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSongRiders As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSongSprings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSongMotor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSongSignals As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSongBrakes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoreMoney As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoreDoors As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoreBell As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoreDriver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoreBaby As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoreMother As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMorePeople As System.Windows.Forms.ToolStripMenuItem

End Class
