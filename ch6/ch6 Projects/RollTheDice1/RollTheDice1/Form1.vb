Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        rtbInfo.Clear() 'This just resets the rtb
        If IsNumeric(txtRollNumber.Text) Then

            Dim shoRolls As Short
            Dim i As Short
            Dim bytNumber As Byte
            Dim shoRolls1 As Short
            Dim shoRolls2 As Short
            Dim shoRolls3 As Short
            Dim shoRolls4 As Short
            Dim shoRolls5 As Short
            Dim shoRolls6 As Short

            i = 0
            shoRolls = txtRollNumber.Text
            While shoRolls > i
                i = i + 1

                bytNumber = Int(Rnd() * 6)

                Select Case bytNumber
                    Case Is = 0 'this technically gives zero, but will represent #1
                        rtbInfo.AppendText("roll #" & i.ToString & " is 1" & vbNewLine)
                        shoRolls1 = shoRolls1 + 1
                        lblOut1.Text = shoRolls1.ToString
                    Case Is = 1
                        rtbInfo.AppendText("roll #" & i.ToString & " is 2" & vbNewLine)
                        shoRolls2 = shoRolls2 + 1
                        lblOut2.Text = shoRolls2.ToString
                    Case Is = 2
                        rtbInfo.AppendText("roll #" & i.ToString & " is 3" & vbNewLine)
                        shoRolls3 = shoRolls3 + 1
                        lblOut3.Text = shoRolls3.ToString
                    Case Is = 3
                        rtbInfo.AppendText("roll #" & i.ToString & " is 4" & vbNewLine)
                        shoRolls4 = shoRolls4 + 1
                        lblOut4.Text = shoRolls4.ToString
                    Case Is = 4
                        rtbInfo.AppendText("roll #" & i.ToString & " is 5" & vbNewLine)
                        shoRolls5 = shoRolls5 + 1
                        lblOut5.Text = shoRolls5.ToString
                    Case Is = 5
                        rtbInfo.AppendText("roll #" & i.ToString & " is 6" & vbNewLine)
                        shoRolls6 = shoRolls6 + 1
                        lblOut6.Text = shoRolls6.ToString
                End Select
            End While
        Else
            rtbInfo.AppendText("Sorry, please input a valid number.")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class
