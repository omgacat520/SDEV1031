Public Class Form1

    Private Sub btnGo_Click(sender As System.Object, e As System.EventArgs) Handles btnGo.Click
        Dim dblRN, dblRN1, dblRN2, dblRN3 As Double
        Dim intLow, intHigh, intRange As Integer
        'get the data
        intLow = Convert.ToInt16(nudMin.Text)
        intHigh = Convert.ToInt16(nudMax.Text)
        'do the work
        intRange = intHigh - intLow + 1
        dblRN = Rnd()
        dblRN1 = dblRN * intRange
        dblRN2 = dblRN * intRange + intLow
        dblRN3 = Int(dblRN2)
        'display the result
        lblRange.Text = intRange.ToString
        lblRND.Text = dblRN.ToString
        lblRND1.Text = dblRN1.ToString
        lblRND2.Text = dblRN2.ToString
        lblFinal.Text = dblRN3.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class
