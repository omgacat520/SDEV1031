'Prologue

Public Class frmSalesCommission

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnCommission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommission.Click
        'Declarations
        Dim decSales As Decimal
        Dim bytYears As Byte
        Dim sngRate As Single
        Dim decCommish As Decimal

        'Input
        decSales = Convert.ToDecimal(txtSales.Text)
        bytYears = Convert.ToInt16(txtYears.Text)

        'Processing
        If decSales >= 100000 Then
            If bytYears > 5 Then
                sngRate = 0.06
            Else
                sngRate = 0.04
            End If
        Else
            If bytYears > 5 Then
                sngRate = 0.05
            Else
                sngRate = 0.03
            End If
        End If

        decCommish = decSales * sngRate

        'Output
        lblRate.Text = sngRate.ToString("p0")
        lblCommish.Text = decCommish.ToString("c")

    End Sub
End Class
