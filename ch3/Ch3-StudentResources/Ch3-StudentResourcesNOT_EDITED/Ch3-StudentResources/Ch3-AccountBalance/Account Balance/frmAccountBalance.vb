'Prologue
'Prog 3.3 Account Balance
'Savings Account Balance
'Calculates the balance of a savings account
'Program has logic errors

Public Class frmAccountBalance

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Declarations

        Dim decBeginningBalance As Decimal
        Dim decEndingBalance As Decimal
        Dim decDeposits As Decimal
        Dim decWithdrawals As Decimal

        'Input
        decBeginningBalance = txtDeposits.Text
        decDeposits = txtBeginningBalance.Text
        decWithdrawals = txtWithdrawals.Text

        'Output
        lblEndingBalance.Text = decEndingBalance.ToString("c")

        'Processing
        decBeginningBalance = decEndingBalance - decDeposits + decWithdrawals


    End Sub

    Private Sub btnBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBalance.Click
        End
    End Sub


End Class
