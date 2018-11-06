Public Class Form1
    Dim intP1Score As Integer = 100
    Dim intP2Score As Integer = 100 'These need to be module-level to keep from destroying values.

    Private Sub btnGo_Click(sender As System.Object, e As System.EventArgs) Handles btnGo.Click
        Dim intP1Guess, intP2Guess As Integer




        'get the data
        intP1Guess = Convert.ToInt16(txtP1Guess.Text)
        intP2Guess = Convert.ToInt16(txtP2Guess.Text)


        'do the work -- compare
        If intP1Guess > intP2Guess Then
            Call ChangePoints(intP1Score, intP2Score) 'winner/loser designations
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


    Private Function ChangePoints(ByRef intWinnerScore As Integer, ByRef intLoserScore As Integer)
        'winner gets 25 points, loser loses 10 points - sends output for calculations straight into variable references.

        'depending on the output for the IF statement above, the intWinner or intLoser changes, but i need these changes to accumulate rather than just do it once and stop altogether and then swap the values the second the other person wins.

        'These variables also don't exist or are defined until this function call, which means they're destroyed or reset after each iteration of this function.
        intWinnerScore += 25
        intLoserScore -= 10

        Return intWinnerScore
        Return intLoserScore
    End Function
End Class
