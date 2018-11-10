Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub btnHigh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHigh.Click
        Dim intTotalPoints As Integer = 1000
        Dim intRisk As Integer
        Dim strCardType As String   'values can be "high", "low", or "seven"
        Dim strStatus As String     'values can be "win", "lose", or "seven"

        Dim intCard As Integer = 0
        System.Diagnostics.Debug.WriteLine("Starting Intcard = " & intCard)

        'get number of points to risk, check if valid
        intRisk = Val(txtRisk.Text)
        System.Diagnostics.Debug.WriteLine("intRisk is " & intRisk) 'functional here
        If GoodRisk(intRisk, intTotalPoints) = True Then   'enough points so play
            'get type of new card, is it high, low, or seven?

            strCardType = GetCard(intCard)
            'check if card is in high range, as guessed
            If strCardType = "high" Then
                strStatus = "win"
            ElseIf strCardType = "low" Then
                strStatus = "lose"
            Else
                strStatus = strCardType   'strCardType was seven, same as strStatus
            End If
            'fix the points based on status and risk, and display the outcome
            FixPoints(intRisk, intTotalPoints, strStatus, intCard)
            'check if game is over
            IsGameOver(intTotalPoints)
        Else
            'not enough points to play, let user know
            lblResult.Text = "Check your risk, try again"
        End If

    End Sub

    Function GoodRisk(ByRef intRisk As Integer, ByRef intTotalPointsLocal As Integer) As Boolean
        'check if the risk is within the bounds of 0 and the total points
        'if it is within the range, return "true", otherwise, return "false"
        If ((intRisk >= intTotalPointsLocal) And (0 > intRisk)) Then
            System.Diagnostics.Debug.WriteLine("returned with True")
            Return GoodRisk = True

        Else
            System.Diagnostics.Debug.WriteLine("returned with False")
            Return GoodRisk = False
        End If
        System.Diagnostics.Debug.WriteLine("Finished GoodRisk, No result.")
    End Function

    Function GetCard(ByRef intcard) As String
        'create the new card with random number and display it,
        'which simulates flipping the card over
        'determine if card is "high", "low", or "seven" and return that result
        Dim NewCardLocal As Decimal

        NewCardLocal = Int((Rnd() * 52) + 1)
        System.Diagnostics.Debug.WriteLine("NewCardLocal = " & NewCardLocal)

        If NewCardLocal > 26 And NewCardLocal <> 7 Then
            System.Diagnostics.Debug.WriteLine("returned with high")
            Return "high" & NewCardLocal
            Return NewCardLocal

        ElseIf NewCardLocal = 7 Then
            System.Diagnostics.Debug.WriteLine("returned with seven")
            Return "seven" & NewCardLocal
            Return NewCardLocal
        Else
            System.Diagnostics.Debug.WriteLine("returned with low")
            Return "low" & NewCardLocal
            Return NewCardLocal
        End If
    End Function

    Sub FixPoints(ByVal intRiskLocal As Integer, ByRef intTotalPoints As Integer, ByVal strStatusLocal As String, ByRef intCard As Integer)
        'change total points based on status of "win", "lose", or "seven"
        'display new total points
        'display message about result: in lblResult, display:
        ' "You win!", or "You lose", or "Sorry, you lose double"

        If strStatusLocal = "win" Then
            intTotalPoints = intTotalPoints + intRiskLocal
            lblResult.Text = "Result: You win!"
        ElseIf strStatusLocal = "seven" Then
            intTotalPoints = intTotalPoints - (intRiskLocal * 2)
            lblResult.Text = "sorry, you lose double."
        ElseIf strStatusLocal = "lose" Then
            intTotalPoints = intTotalPoints - intRiskLocal
            lblResult.Text = "Result: You lose."
        Else
            lblResult.Text = "DEBUG TIME"
        End If
        System.Diagnostics.Debug.WriteLine("ending intcard = " & intCard)
        lblCard.Text = intCard.ToString

    End Sub

    Sub IsGameOver(ByVal intTotalPointsLocal As Integer)
        'check if game is over
        'if it is, disable buttons and display message
        If intTotalPointsLocal = 0 Then
            btnHigh.Visible = False
            btnLow.Visible = False
            lblResult.Text = "Result: You have no more points! You lose!"
        End If

    End Sub
End Class
