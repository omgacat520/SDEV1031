'Prologue

Public Class frmRetirementSavings

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        'Declarations
        Dim decYearly As Decimal
        Dim sngIntRate As Single
        Dim decIntEarned As Decimal
        Dim shoYears As Short
        Dim decTotal As Decimal

        'Input
        decYearly = nudYearly.Value
        sngIntRate = nudIntRate.Value
        sngIntRate = sngIntRate / 100

        'Processing
        Do While decTotal < 1000000
            decIntEarned = (decTotal + decYearly) * sngIntRate
            decTotal = decTotal + decYearly + decIntEarned
            shoYears = shoYears + 1
        Loop

        'Output
        lblYears.Text = shoYears.ToString
        lblTotal.Text = decTotal.ToString("c")

    End Sub

  
End Class
