Public Class Form1
    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        Dim decMonth As Decimal

        rtbOutput.Clear()

        decMonth = Convert.ToDecimal(txtMonthNumber.Text)
        'rtbOutput.AppendText("decMonth Is " & decMonth.ToString & vbNewLine) -used for debug
        If (IsNumeric(txtMonthNumber.Text) And decMonth < 13 And decMonth) > 0 = True Then
            Select Case decMonth
                Case Is = 1
                    rtbOutput.AppendText("The name of month " & decMonth.ToString & " is January")
                Case Is = 2
                    rtbOutput.AppendText("The name of month " & decMonth.ToString & " is February")
                Case Is = 3
                    rtbOutput.AppendText("The name of month " & decMonth.ToString & " is March")
                Case Is = 4
                    rtbOutput.AppendText("The name of month " & decMonth.ToString & " is April")
                Case Is = 5
                    rtbOutput.AppendText("The name of month " & decMonth.ToString & " is May")
                Case Is = 6
                    rtbOutput.AppendText("The name of month " & decMonth.ToString & " is June")
                Case Is = 7
                    rtbOutput.AppendText("The name of month " & decMonth.ToString & " is July")
                Case Is = 8
                    rtbOutput.AppendText("The name of month " & decMonth.ToString & " is August")
                Case Is = 9
                    rtbOutput.AppendText("The name of month " & decMonth.ToString & " is September")
                Case Is = 10
                    rtbOutput.AppendText("The name of month " & decMonth.ToString & " is October")
                Case Is = 11
                    rtbOutput.AppendText("The name of month " & decMonth.ToString & " is November")
                Case Is = 12
                    rtbOutput.AppendText("The name of month " & decMonth.ToString & " is December")
            End Select
        Else
            rtbOutput.AppendText("Sorry, that wasn't a valid month number.")
        End If 'end of 1-12 if-statement

    End Sub
End Class
