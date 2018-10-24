Public Class Form1
    'module level variables'
    Dim snackTotal As Int16
    Dim ticketTotal As Int16
    'ticket subtotal stuff down here
    Private Sub btnTickets_Click(sender As Object, e As EventArgs) Handles btnTickets.Click
        Dim adults As Short = nudAdults.Value
        Dim kids As Short = nudKids.Value
        Dim seniors As Short = nudSeniors.Value

        Dim adultPrice As Short = (adults * 10)
        Dim kidsPrice As Short = (kids * 6)
        Dim seniorsPrice As Short = (seniors * 8)

        ticketTotal = (adultPrice + kidsPrice + seniorsPrice)

        lblTickets.Text = ticketTotal.ToString("c")
    End Sub
    'snack subtotal stuff down here
    Private Sub btnSnacks_Click(sender As Object, e As EventArgs) Handles btnSnacks.Click
        Dim popcorn As Short = nudPopcorn.Value
        Dim drink As Short = nudDrink.Value

        Dim popcornPrice As Short = (popcorn * 5)
        Dim drinkPrice As Short = (drink * 3)

        snackTotal = (popcornPrice + drinkPrice)

        lblSnacks.Text = snackTotal.ToString("c")
    End Sub
    'total stuff down here
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim total As Int16 = (ticketTotal + snackTotal)

        lblTotal.Text = total.ToString("c")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'this clears previous values and also clears totals to prevent unintentional accumulation of values.
        nudPopcorn.Value = 0
        nudDrink.Value = 0
        nudAdults.Value = 0
        nudKids.Value = 0
        nudSeniors.Value = 0

        ticketTotal = 0
        snackTotal = 0
        lblTickets.Text = "0$"
        lblSnacks.Text = "0$"
        lblTotal.Text = "0$"
    End Sub
End Class
