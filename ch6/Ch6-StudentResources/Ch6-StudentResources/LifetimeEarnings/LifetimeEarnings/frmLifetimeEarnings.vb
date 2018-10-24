'Prologue
'Program has bugs

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

        Do While shoYear = shoEndYear

            decRaise = decSalary * sngRaise
            decSalary += decRaise
            decLifetime += decSalary

            'Output

        Loop
        rtbOut.AppendText(shoYear.ToString & "   " & decRaise.ToString("c") & _
                "   " & decSalary.ToString("c") & "   " & decLifetime.ToString("c") & _
                vbNewLine)

    End Sub
End Class
