'Prologue

Public Class frmSalesTaxFunction

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        'Declarations
        Dim decSale As Decimal
        Dim decSalesTax As Decimal
        Dim decTotal As Decimal

        'Input
        decSale = txtSale.Text

        'Processing
        'Call CalcSalesTax function and pass it the amount of the sale
        'Function returns the sales tax at 5%
        decSalesTax = CalcSalesTax(decSale)

        decTotal = decSale + decSalesTax

        'Output
        lblSalesTax.Text = decSalesTax.ToString("c")
        lblTotal.Text = decTotal.ToString("c")

    End Sub

    Private Function CalcSalesTax(ByVal decAmtSale As Decimal) As Decimal
        'Function determines the amount of the sales tax
        'Tax rate is 5% of the sale

        Const sngTaxRate As Single = 0.05
        Dim decSalesTax As Decimal

        decSalesTax = decAmtSale * sngTaxRate

        'Can send the answer back by assigning it to the function name:
        'CalcSalesTax = decSalesTax
        'or by using the keyword Return
        'Return decSalesTax

        Return decSalesTax

    End Function
End Class
