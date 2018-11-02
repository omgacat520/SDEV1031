'Prologue


Public Class frmChristmasLights

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnFlash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlash.Click
        'Turn the lights on
        tmrTwinkle.Enabled = True

    End Sub

    Private Sub tmrTwinkle_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTwinkle.Tick
        'Makes the lights flash
        If picOn.Visible = True Then
            picOff.Visible = True
            picOn.Visible = False
        Else
            picOn.Visible = True
            picOff.Visible = False

        End If
    End Sub
End Class
