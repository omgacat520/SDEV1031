Public Class Form1

    Dim intCountDown As Integer = 11

    Private Sub tmrCountDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCountDown.Tick
        If intCountDown <= 0 Then
            lblCountDown.Text = "Blast Off!"
            tmrCountDown.Enabled = False
        Else
            intCountDown -= 1
            lblCountDown.Text = "Count Down: " & intCountDown
        End If
    End Sub
End Class
