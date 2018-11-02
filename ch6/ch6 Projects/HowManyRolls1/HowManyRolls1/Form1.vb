Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim bytDesired As Byte = nudDesired.Value
        Dim bytRolledNumber As Byte
        Dim shoCounter As Short

        rtbInfo.Clear() 'Resets the text box

        Do Until bytRolledNumber = bytDesired
            shoCounter = shoCounter + 1
            bytRolledNumber = Int(Rnd() * 6) + 1
            rtbInfo.AppendText("Roll #" & shoCounter.ToString & " is " & bytRolledNumber & vbNewLine)
        Loop
        lblOutput.Visible = True
        lblOutput1.Visible = True
        lblOutput.Text = shoCounter.ToString
    End Sub
End Class
