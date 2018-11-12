Public Class Form1
    Dim intTotalPoints As Integer = 1000
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub btnHigh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHigh.Click

        Dim intRisk As Integer
        Dim strCardType As String   'values can be "high", "low", or "seven"
        Dim strStatus As String     'values can be "win", "lose", or "seven"
        Dim intcard As Integer

        intRisk = Val(txtRisk.Text) 'get number of points to risk, check if valid

        System.Diagnostics.Debug.WriteLine("intRisk is " & intRisk) 'functional to this point.

        If GoodRisk(intRisk, intTotalPoints) = True Then   'enough points so play //For some dumb reason, assigning variables to this function makes it not a boolean? Wtf.

            'get type of new card, is it high, low, or seven?

            strCardType = GetCard(intcard) 'this is supposed to assign strCardType as GetCard() return, but it isn't assigning???? Why? - fixed. GoodRisk Returns syntax was incorrect.

            System.Diagnostics.Debug.WriteLine("strCardType Variable = " & strCardType)

            'This is working, sorta. Card output and point alteration is primary concerns.


            If strCardType = "high" Then 'check if card is in high range, as guessed
                strStatus = "win"
            ElseIf strCardType = "low" Then
                strStatus = "lose"
            Else
                strStatus = strCardType   'strCardType was seven, same as strStatus
            End If

            FixPoints(intRisk, intTotalPoints, strStatus, intcard) 'fix the points based on status and risk, and display the outcome

            IsGameOver(intTotalPoints) 'check if game is over
        Else
            System.Diagnostics.Debug.WriteLine("GetCard() = " & intcard & strCardType & " and If_strCardType statement has failed.")
            lblResult.Text = "Check your risk, try again" 'not enough points to play, let user know, or this means that your string was not a valid return.
        End If

    End Sub
    'HIGH MASTER FUNCTION ABOVE HERE --------------------------------------------
    Private Sub btnLow_Click(sender As Object, e As EventArgs) Handles btnLow.Click
        Dim intRisk As Integer
        Dim strCardType As String   'values can be "high", "low", or "seven"
        Dim strStatus As String     'values can be "win", "lose", or "seven"
        Dim intcard As Integer

        intRisk = Val(txtRisk.Text) 'get number of points to risk, check if valid

        System.Diagnostics.Debug.WriteLine("intRisk is " & intRisk) 'functional to this point.

        If GoodRisk(intRisk, intTotalPoints) = True Then   'enough points so play //For some dumb reason, assigning variables to this function makes it not a boolean? Wtf.

            'get type of new card, is it high, low, or seven?

            strCardType = GetCard(intcard) 'this is supposed to assign strCardType as GetCard() return, but it isn't assigning???? Why? - fixed. GoodRisk Returns syntax was incorrect.

            System.Diagnostics.Debug.WriteLine("strCardType Variable = " & strCardType)

            'This is working, sorta. Card output and point alteration is primary concerns.


            If strCardType = "high" Then 'check if card is in high range, as guessed
                strStatus = "lose"
            ElseIf strCardType = "low" Then
                strStatus = "win"
            Else
                strStatus = strCardType   'strCardType was seven, same as strStatus
            End If

            FixPoints(intRisk, intTotalPoints, strStatus, intcard) 'fix the points based on status and risk, and display the outcome

            IsGameOver(intTotalPoints) 'check if game is over
        Else
            System.Diagnostics.Debug.WriteLine("GetCard() = " & intcard & strCardType & " and If_strCardType statement has failed.")
            lblResult.Text = "Check your risk, try again" 'not enough points to play, let user know, or this means that your string was not a valid return.
        End If

    End Sub
    'LOW MASTER FUNCTION ABOVE HERE --------------------------------------------
    Function GoodRisk(ByRef intRisk As Integer, ByRef intTotalPointsLocal As Integer) As Boolean 'outside As__ statements define entire function as one variable.
        'check if the risk is within the bounds of 0 and the total points
        'if it is within the range, return "true", otherwise, return "false"


        If ((intRisk <= intTotalPointsLocal) And (0 < intRisk)) Then
            System.Diagnostics.Debug.WriteLine("GoodRisk returned with True")
            Return True

        Else
            System.Diagnostics.Debug.WriteLine("GoodRisk returned with False")
            Return False
        End If
        System.Diagnostics.Debug.WriteLine("Finished GoodRisk, No result.")
    End Function

    Function GetCard(ByRef intcard As Integer) As String 'This function is somehow broken.

        'create the new card with random number and display it,
        'which simulates flipping the card over
        'determine if card is "high", "low", or "seven" and return that result

        Dim NewCardLocal As Decimal

        NewCardLocal = Int((Rnd() * 13) + 1) 'Random number between 1 and 13 generated here, which is stored in NewCardLocal as a local variable for modularized function.

        System.Diagnostics.Debug.WriteLine("PostCalc NewCardLocal (GetCardFunc) = " & NewCardLocal)

        intcard = NewCardLocal

        System.Diagnostics.Debug.WriteLine("Intcard post assignment = " & intcard)

        If NewCardLocal > 7 Then
            System.Diagnostics.Debug.WriteLine("GetCard() returned with high")

            Return "high"
            'Return NewCardLocal as high, since 7 is technically the middlepoint, then just getting something bigger than 7 is the best way to ask for high returns.

        ElseIf NewCardLocal < 7 And NewCardLocal <> 7 Then
            System.Diagnostics.Debug.WriteLine("GetCard() returned with low")

            Return "low"
            'Return NewCardLocal as low
        Else
            System.Diagnostics.Debug.WriteLine("GetCard() returned with seven")
            Return "seven"
            'if it generates a number between 1 and 13, and its not 1-6 or 8-13, then it must be 7.
            'Return NewCardLocal as seven
        End If
    End Function

    Sub FixPoints(ByVal intRiskLocal As Integer, ByRef intTotalPoints As Integer, ByVal strStatusLocal As String, intcardlocal As Integer)
        'change total points based on status of "win", "lose", or "seven"
        'display new total points
        'display message about result: in lblResult, display:
        ' "You win!", or "You lose", or "Sorry, you lose double"

        If strStatusLocal = "win" Then
            intTotalPoints = (intTotalPoints + intRiskLocal)
            lblResult.Text = "Result: You win!"
            lblTotalPoints.Text = intTotalPoints.ToString
        ElseIf strStatusLocal = "seven" Then
            intTotalPoints = (intTotalPoints - (intRiskLocal * 2))
            lblResult.Text = "sorry, you lose double."
            lblTotalPoints.Text = intTotalPoints.ToString
        ElseIf strStatusLocal = "lose" Then
            intTotalPoints = (intTotalPoints - intRiskLocal)
            lblResult.Text = "Result: You lose."
            lblTotalPoints.Text = intTotalPoints.ToString
        Else
            lblResult.Text = "Something has gone horribly wrong."
        End If
        lblCard.Text = intcardlocal.ToString 'PUT FUNCTION OUTPUT HERE
        lblTotalPoints.Text = intTotalPoints.ToString

    End Sub

    Sub IsGameOver(ByVal intTotalPointsLocal As Integer)
        'check if game is over
        'if it is, disable buttons and display message
        If intTotalPointsLocal = 0 Then
            btnHigh.Visible = False
            btnLow.Visible = False
            lblResult.Text = "No More Points, you lose!"
        End If

    End Sub

End Class
