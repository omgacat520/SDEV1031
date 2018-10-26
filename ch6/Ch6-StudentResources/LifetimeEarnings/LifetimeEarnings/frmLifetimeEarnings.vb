'Prologue
'Program has bugs - nonfunctional

Public Class frmLifetimeEarnings

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Declarations
        Dim shoYear As Short
        Dim bytWorkingYears As Byte
        Dim sngRaise As Single
        Dim decRaise As Decimal
        Dim decSalary As Decimal
        Dim decLifetime As Decimal
        Dim shoEndYear As Short

        'Input
        decSalary = Convert.ToDecimal(txtSalary.Text)
        shoYear = Convert.ToInt16(txtYear.Text)
        bytWorkingYears = Convert.ToByte(txtWorkingYears.Text)
        sngRaise = Convert.ToSingle(txtRaise.Text)

        'Processing
        sngRaise = sngRaise / 100
        shoEndYear = shoYear + bytWorkingYears
        decLifetime = decSalary

        rtbOut.Clear()
        rtbOut.AppendText("Year   Raise       Salary       Lifetime" & vbNewLine)

        rtbOut.AppendText(shoYear.ToString & "   " & decRaise.ToString("c") &
                "   " & decSalary.ToString("c") & "   " & decLifetime.ToString("c") &
                vbNewLine)

        Do While shoYear < shoEndYear

            decRaise = decSalary * sngRaise
            decSalary += decRaise
            decLifetime += decSalary
            shoYear = shoYear + 1

            'Output
            rtbOut.AppendText(shoYear.ToString & "   " & decRaise.ToString("c") &
                            "   " & decSalary.ToString("c") & "   " & decLifetime.ToString("c") &
                            vbNewLine)
        Loop

        'also gonna make a little reset part here, where i reset all the variable values to null just to guarantee no weird buggy behaviors.
        shoYear = 0
        bytWorkingYears = 0
        sngRaise = 0
        decRaise = 0
        decSalary = 0
        decLifetime = 0
        shoEndYear = 0
    End Sub
End Class
