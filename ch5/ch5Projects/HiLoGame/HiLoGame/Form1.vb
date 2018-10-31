Public Class Form1
    Dim bytResult As Byte
    Dim decRandom As Decimal
    Dim decPoints As Decimal = 1000
    Dim decBet As Decimal
    Private Sub btnHigh_Click(sender As Object, e As EventArgs) Handles btnHigh.Click
        'HIGH NUMBER BET
        If IsNumeric(txtBet.Text) Then

            'reset btn
            bytResult = 0
            decRandom = 0
            decBet = 0
            rtbResults.Clear()
            rtbNumber.Clear()

            'get random number
            decRandom = Rnd()
            rtbResults.AppendText("Pre-Calculation result is " & decRandom.ToString & vbNewLine) '<-debug tool

            bytResult = Int((decRandom * 13) + 1)
            'covert to card
            rtbResults.AppendText("Post-Calculation result is " & bytResult.ToString & vbNewLine) '<-debug tool

            'determine high/low
            decBet = Convert.ToDecimal(txtBet.Text)
            Select Case bytResult
                Case < 8
                    rtbResults.AppendText("Sorry, you lose. -" & decBet.ToString & vbNewLine)
                    rtbNumber.AppendText(bytResult.ToString & vbNewLine)
                    decPoints = decPoints - decBet
                Case >= 8
                    rtbResults.AppendText("Nice guess, you win! +" & decBet.ToString & vbNewLine)
                    rtbNumber.AppendText(bytResult.ToString & vbNewLine)
                    decPoints = decPoints + decBet
            End Select

            'display new point value
            lblPoints.Text = decPoints.ToString

            'lose condition
            If decPoints < 0 Then
                btnHigh.Visible = False
                btnLow.Visible = False
                rtbResults.Clear()
                rtbResults.AppendText("You got nothing to bet with! You lose!")
            End If
        Else
            rtbResults.AppendText("Sorry, thats not a valid betting number." & vbNewLine)
        End If
    End Sub

    Private Sub btnLow_Click(sender As Object, e As EventArgs) Handles btnLow.Click
        'LOW NUMBER BET
        If IsNumeric(txtBet.Text) Then

            'reset btn
            bytResult = 0
            decRandom = 0
            decBet = 0
            rtbResults.Clear()
            rtbNumber.Clear()

            'get random number
            decRandom = Rnd()
            rtbResults.AppendText("Pre-calculation result is " & decRandom.ToString & vbNewLine) '<-debug tool

            bytResult = Int((decRandom * 13) + 1)
            'covert to card
            rtbResults.AppendText("Post-Calculation result is " & bytResult.ToString & vbNewLine) '<-debug tool

            'determine high/low
            decBet = Convert.ToDecimal(txtBet.Text)
            Select Case bytResult
                Case < 8
                    rtbResults.AppendText("Nice guess, you win! +" & decBet.ToString & vbNewLine)
                    rtbNumber.AppendText(bytResult.ToString & vbNewLine)
                    decPoints = decPoints + decBet
                Case >= 8
                    rtbResults.AppendText("Sorry, you lose. -" & decBet.ToString & vbNewLine)
                    rtbNumber.AppendText(bytResult.ToString & vbNewLine)
                    decPoints = decPoints - decBet
            End Select

            'display new point value
            lblPoints.Text = decPoints.ToString

            'lose condition
            If decPoints <= 0 Then
                btnHigh.Visible = False
                btnLow.Visible = False
                rtbResults.Clear()
                rtbResults.AppendText("You got nothing to bet with! You lose!")
            End If
        Else
            rtbResults.AppendText("Sorry, thats not a valid betting number." & vbNewLine)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
