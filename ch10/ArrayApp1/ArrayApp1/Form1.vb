Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'input and variable define
        Dim IntNumArray() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        Dim intSum As Integer
        Dim intAvg As Integer
        Dim i As Short 'counter

        For i = IntNumArray.GetLowerBound(0) To IntNumArray.GetUpperBound(0)

            IntNumArray(i) += intSum
            Debug.WriteLine("intSum = " & intSum)
        Next
        intAvg = intSum / IntNumArray.GetUpperBound(0) 'turns sum of integers into average
        rtbOutput.AppendText() 'display average

    End Sub
End Class
