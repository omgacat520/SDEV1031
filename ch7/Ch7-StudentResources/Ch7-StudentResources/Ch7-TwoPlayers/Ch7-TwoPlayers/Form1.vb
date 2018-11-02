Public Class Form1

    Private Sub btnGo_Click(sender As System.Object, e As System.EventArgs) Handles btnGo.Click
        Dim intP1Guess, intP2Guess As Integer
        Dim intP1Score As Integer = 100
        Dim intP2Score As Integer = 100
        'get the data
        intP1Guess = Convert.ToInt16(txtP1Guess.Text)
        intP2Guess = Convert.ToInt16(txtP2Guess.Text)
        'do the work -- compare
        If intP1Guess > intP2Guess Then
            Call ChangePoints(intP1Score, intP2Score)
            lblResult.Text = "Result: Player 1 wins"
        ElseIf intP2Guess > intP1Guess Then
            Call ChangePoints(intP2Score, intP1Score)
            lblResult.Text = "Result: Player 2 wins"
        Else
            'the guesses were the same, it's a tie
            lblResult.Text = "Result: " & "Tie, play again"
        End If
        'display results
        lblP1Points.Text = intP1Score.ToString
        lblP2Points.Text = intP2Score.ToString
    End Sub

    Private Sub ChangePoints(ByVal intWinnerScore As Integer, ByVal intLoserScore As Integer)
        'winner gets 25 points, loser loses 10 points
        intWinnerScore += 25
        intLoserScore -= 10
    End Sub
End Class
