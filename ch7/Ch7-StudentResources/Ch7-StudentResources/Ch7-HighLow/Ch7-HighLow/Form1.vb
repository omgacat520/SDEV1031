Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub btnHigh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHigh.Click
        Dim intTotalPoints As Integer = 1000
        Dim intRisk As Integer
        Dim strCardType As String   'values can be "high", "low", or "seven"
        Dim strStatus As String     'values can be "win", "lose", or "seven"

        'get number of points to risk, check if valid
        intRisk = Val(txtRisk.Text)
        If GoodRisk(intRisk) Then   'enough points so play
            'get type of new card, is it high, low, or seven?
            strCardType = GetCard()
            'check if card is in high range, as guessed
            If strCardType = "high" Then
                strStatus = "win"
            ElseIf strCardType = "low" Then
                strStatus = "lose"
            Else
                strStatus = strCardType   'strCardType was seven, same as strStatus
            End If
            'fix the points based on status and risk, and display the outcome
            FixPoints(intRisk, strStatus)
            'check if game is over
            IsGameOver()
        Else
            'not enough points to play, let user know
            lblResult.Text = "Check your risk, try again"
        End If
    End Sub

    Function GoodRisk(ByVal intRisk As Integer) As Boolean
        'check if the risk is within the bounds of 0 and the total points
        'if it is within the range, return "true", otherwise, return "false"

    End Function
    Function GetCard() As String
        'create the new card with random number and display it,
        'which simulates flipping the card over
        'determine if card is "high", "low", or "seven" and return that result

    End Function
    Sub FixPoints(ByVal intRisk As Integer, ByVal strStatus As String)
        'change total points based on status of "win", "lose", or "seven"
        'display new total points
        'display message about result: in lblResult, display:
        ' "You win!", or "You lose", or "Sorry, you lose double"

    End Sub
    Sub IsGameOver()
        'check if game is over
        'if it is, disable buttons and display message

    End Sub
End Class
