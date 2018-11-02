'Prologue

Public Class frmCountdown
    Dim mshoCountdown As Short

    Private Sub tmrCountdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCountdown.Tick
        'Display count
        lblCountdown.Text = "Countdown: " & mshoCountdown.ToString
        'Take one from count
        mshoCountdown -= 1
        'Check to see if count is 0
        If mshoCountdown < 0 Then
            lblCountdown.Text = "Blast Off!"
            tmrCountdown.Enabled = False

        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnCountdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCountdown.Click
        'Turn timer on and set count to 10
        tmrCountdown.Enabled = True
        mshoCountdown = 10

    End Sub
End Class
