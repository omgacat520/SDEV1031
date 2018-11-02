'Prologue


Public Class frmMinimumPaymentFunction

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
        'Declarations
        Dim decBalance As Decimal
        Dim decMinimum As Decimal

        'Input
        decBalance = txtBalance.Text

        'Processing
        'Calls function when there's a balance
        'CalcMinPayment returns minimum payment
        If decBalance > 0 Then
            decMinimum = CalcMinPayment(decBalance)
        Else
            decMinimum = 0
        End If

        'Output
        lblMinimum.Text = decMinimum.ToString("c")

    End Sub

    Private Function CalcMinPayment(ByVal decBal As Decimal) As Decimal
        'Balance must be paid in full when <= $25
        'Balances over $25 are the greater of 10% of the balance or $25
        'Function returns minimum payment

        Const sngMinPercent As Single = 0.1
        Const decPayInFull As Decimal = 25
        Const decMinPayOnBalance As Decimal = 25
        Dim decMinPayment As Decimal

        If decBal <= decPayInFull Then
            decMinPayment = decBal
        Else
            decMinPayment = decBal * sngMinPercent
            If decMinPayment < decMinPayOnBalance Then
                decMinPayment = decMinPayOnBalance
            End If
        End If

        Return decMinPayment
    End Function
End Class
