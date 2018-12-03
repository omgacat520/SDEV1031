Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'input and variable define
        Dim IntNumArray() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        Dim intSum As Integer
        Dim intAvg As Integer
        Dim i As Short 'counter
        Dim intLargest As Integer
        Dim intSmallest As Integer

        rtbOutput.Clear() 'clear rtb

        For i = IntNumArray.GetLowerBound(0) To IntNumArray.GetUpperBound(0)
            rtbOutput.AppendText(IntNumArray(i).ToString & vbNewLine)
            intSum += IntNumArray(i)

            If intLargest < IntNumArray(i) Then
                intLargest = IntNumArray(i)
            End If
            If intSmallest > IntNumArray(i) Then
                intSmallest = IntNumArray(i)
            End If
            Debug.WriteLine("Loop #" & i)
        Next
        intAvg = intSum / IntNumArray.Length
        rtbOutput.AppendText("Total Items: " & IntNumArray.Length.ToString & vbNewLine)
        rtbOutput.AppendText("Sum: " & intSum & vbNewLine)
        rtbOutput.AppendText("Average: " & intAvg & vbNewLine)

        intSmallest = IntNumArray(IntNumArray.GetLowerBound(0))
        intLargest = intLargest

        rtbOutput.AppendText("smallest number: " & intSmallest.ToString & vbNewLine)
        rtbOutput.AppendText("largest number: " & intLargest.ToString & vbNewLine)
    End Sub
End Class
