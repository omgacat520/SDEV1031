'Prologue
'Prog3.2 Syntax Errors
'Program contains syntax errors

Public Class frmSyntaxErrors

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'End

    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        'Declarations

        Constant sngSalesTaxRate As Single = 0.05
        Const decPrice As Decimal = 4.95
        Dim shoNumItems As Short
        Dim decSubtotal As Decimal
        Dimm decSalesTax As Decimal
        Dim decTotal As Decimal

        'Input
        shoNumItems = txtNum

        'Processing
        shoNumItems * decPrice = decSubtotal 
        decSalesTax = decSubtotal * sngSalesTaxRate
        decTotal = decSubtotal + decSalesTax

        'Output
        lblSubtotal.Text = decSubtotal.ToString("c")
        lblSalesTax.Text = decSalesTax.ToString("c")
        decTotal.ToString("c") = lblTotal.Text

    End Sub
End Class
