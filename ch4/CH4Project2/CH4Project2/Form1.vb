Public Class Form1
    'variables for numeric processing in both subs.
    Dim shoCounter As Short
    Dim bytNewRating As Byte
    Dim decAverage As Decimal
    Dim shoRatingAccum As Short

    Private Sub btnRateIt_Click(sender As Object, e As EventArgs) Handles btnRateIt.Click
        'variables for word processing---------------------------------------------
        Dim strConcatPhrase As String
        Dim strAdj As String
        Dim strRating As String


        'Rating Processing (numeric values only)----------------------------------------
        'Star-Average Accumulator process
        bytNewRating = nudStars.Value
        shoRatingAccum = shoRatingAccum + bytNewRating
        'Rating Counter process per click
        shoCounter = shoCounter + 1

        lblTotalRatings.Text = "Total ratings: " & shoCounter.ToString

        'Word Processing--------------------------------------------------------------
        strAdj = txtWord.Text
        strRating = nudStars.Value.ToString

        strConcatPhrase = "Thank you for rating this movie " & strAdj.ToUpper & " with " & strRating & " stars."

        lblWordOutput.Text = strConcatPhrase
        lblWordOutput.Visible = True
    End Sub

    Private Sub btnAvgRating_Click(sender As Object, e As EventArgs) Handles btnAvgRating.Click

        'this needs an accumulator, without one the function becomes steadily decreasing as it creates a sort of negative function, getting closer and closer to zero.
        decAverage = shoRatingAccum / shoCounter

        lblAvg.Text = decAverage.ToString("f1")
        lblTotalRatings.Text = "Total ratings: " & shoCounter.ToString
        lblAvg.Visible = True
        lblStarOut.Visible = True
    End Sub
End Class
