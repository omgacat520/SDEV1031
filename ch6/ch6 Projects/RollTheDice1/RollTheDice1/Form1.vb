Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
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
                        shoRolls1 = shoRolls1 + 1
                        lblOut1.Text = shoRolls1.ToString
                        lblOut1.Visible = True
                    Case Is = 1
                        shoRolls2 = shoRolls2 + 1
                        lblOut2.Text = shoRolls2.ToString
                        lblOut2.Visible = True
                    Case Is = 2
                        shoRolls3 = shoRolls3 + 1
                        lblOut3.Text = shoRolls3.ToString
                        lblOut3.Visible = True
                    Case Is = 3
                        shoRolls4 = shoRolls4 + 1
                        lblOut4.Text = shoRolls4.ToString
                        lblOut4.Visible = True
                    Case Is = 4
                        shoRolls5 = shoRolls5 + 1
                        lblOut5.Text = shoRolls5.ToString
                        lblOut5.Visible = True
                    Case Is = 5
                        shoRolls6 = shoRolls6 + 1
                        lblOut6.Text = shoRolls6.ToString
                        lblOut6.Visible = True
                End Select
            End While






        Else
            MessageBox.Show("Please input a valid number.", "try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class
