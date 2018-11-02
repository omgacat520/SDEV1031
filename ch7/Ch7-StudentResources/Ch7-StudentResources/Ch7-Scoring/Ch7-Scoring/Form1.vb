Public Class Form1
 
    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim intNewPoints As Integer
        Dim intScore As Integer = 100
        'get the data
        intNewPoints = Convert.ToInt16(txtPoints.Text)
        'do the work and display results
        Call FixScore(intNewPoints, intScore)
    End Sub

    Private Sub FixScore(ByVal intPoints As Integer, ByVal intTotal As Integer)
        'do the work
        intTotal += intPoints
        'display results
        lblScore.Text = intTotal.ToString
    End Sub
End Class
