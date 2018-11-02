Public Class Form1

    Private Sub btnFutureValue_Click(sender As Object, e As EventArgs) Handles btnFutureValue.Click
        'CALCULATING FUTURE VALUE / VALUE
        'if statements determine if users input was numeric and not something weird like letters. From outside in, the order goes, StartAmt, Growth, Target, and decAmount

        If IsNumeric(txtStartAmount.Text) Then
            If IsNumeric(txtGrowth.Text) Then
                'removed target, as it's not needed for just the calculation.
                If IsNumeric(txtCycles.Text) Then





                    'CODE GOES HERE FOR CALCULATION - Nested inside all of the error codes
                    Dim decStartAmount As Decimal = txtStartAmount.Text
                    'other variables for calculations
                    Dim intCycleCounter As Integer = 0
                    Dim intCycles As Integer = txtCycles.Text
                    Dim decGrowth As Decimal = (txtGrowth.Text / 100) + 1
                    Dim decAmount As Decimal = 0

                    decAmount = decStartAmount

                    Do Until intCycleCounter = intCycles 'So timeline begins counting at 1 instead of zero, which will make more sense logically imo.

                        decAmount = decAmount * decGrowth
                        intCycleCounter = intCycleCounter + 1
                        System.Diagnostics.Debug.WriteLine("Dec Amount is " & decAmount & " on cycle #" & intCycleCounter)
                    Loop
                    'output result
                    lblFutureValue.Text = "Future Value: " & decAmount.ToString("c")
                    lblFutureValue.Visible = True





                    'EVERYTHING UNDER HERE IS TO DETERMINE TXTBOX CONTENTS FOR ERROR MESSAGES
                Else
                    MessageBox.Show("Check your Cycle amount, numeric values only.", "try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Check your growth, numeric values only.", "try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Check the starting amount, numeric values only.", "try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click
        'CALCULATING HOW LONG UNTIL FUTURE VALUE / TIME

        'if statements determine if users input was numeric and not something weird like letters. From outside in, the order goes, StartAmt, Growth, Target, and 

        If IsNumeric(txtStartAmount.Text) Then
            If IsNumeric(txtGrowth.Text) Then
                If IsNumeric(txtTarget.Text) Then






                    'Removed Cycles, as it isn't required for this calculation.

                    'other variables needed for calculation
                    Dim decGrowth As Decimal = (txtGrowth.Text / 100) + 1
                    Dim decAmount As Decimal
                    Dim intCycleCounter As Integer = 0

                    decAmount = 0

                    'CODE GOES HERE FOR CALCULATION - nested inside all error codes
                    Dim decStartAmount As Decimal = txtStartAmount.Text
                    Dim decTargetAmount = txtTarget.Text

                    decAmount = decStartAmount

                    Do Until decTargetAmount <= decAmount
                        intCycleCounter = intCycleCounter + 1
                        decAmount = decAmount * decGrowth
                        System.Diagnostics.Debug.WriteLine("dec amount is " & decAmount & " @" & intCycleCounter)
                    Loop

                    lblHowLong.Visible = True
                    lblHowLong.Text = intCycleCounter.ToString & " Cycles to reach target value at " & decAmount.ToString("c")


                Else
                    MessageBox.Show("Check your Target amount, numeric values only.", "try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Check your growth, numeric values only.", "try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Check the starting amount, numeric values only.", "try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
