Public Class jimSoxSportsSales
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intFootballs As Integer
        Dim intBasketballs As Integer
        Dim intVolleyballs As Integer
        Dim intTotalitems As Integer
        Dim decSubtotal As Decimal
        Dim DecVolleyballTotal As Decimal
        Dim decFootballTotal As Decimal
        Dim decBasketballTotal As Decimal

        'constants posed by equation, including constant pricing, constant tax rates, and a second version of tax rates for having the total ammount + the tax rate added to output total cost.'

        Const decFBallPrice As Decimal = 44.95
        Const decBBallPrice As Decimal = 49.95
        Const decVBallPrice As Decimal = 39.95
        Const decTaxAndTotal As Decimal = 1.05
        Const DecTax As Decimal = 0.05

        intFootballs = txtFootball.Text
        intBasketballs = txtBasketball.Text
        intVolleyballs = txtVolleyball.Text

        'This will return the total number of balls, for the totalitem output,'

        'P.S., I also made totalitem outside of camelCase so that I could tell that the I next to the L in totalitem looked distinguishably different no matter the font. Sans-Serif makes the characters look almost identical.'
        intTotalitems = (intBasketballs + intVolleyballs + intFootballs)
        lblTotalitems.Text = intTotalitems.ToString

        'This will calculate cost of each number of each type of ball, as well as subtotal and totals.'
        DecVolleyballTotal = (intVolleyballs * decVBallPrice)
        decBasketballTotal = (intBasketballs * decBBallPrice)
        decFootballTotal = (intFootballs * decFBallPrice)

        lblVolleyballOutput.Text = DecVolleyballTotal.ToString("c")
        lblBasketballOutput.Text = decBasketballTotal.ToString("c")
        lblFootbalOutput.Text = decFootballTotal.ToString("c")

        decSubtotal = (DecVolleyballTotal) + (decBasketballTotal) + (decFootballTotal)
        lblSubtotalOutput.Text = decSubtotal.ToString("c")
        lblTaxOutput.Text = (decSubtotal * DecTax).ToString("c")
        lblTotalOutput.Text = (decSubtotal * decTaxAndTotal).ToString("c")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
