Public Class Form1
    Private Sub btnExe_Click(sender As Object, e As EventArgs) Handles btnExe.Click
        Dim intNumArray() As Integer = {0, 0, 0, 0, 0, 0} '6 array values, for each random number.
        Dim intTemporary As Integer

        For i = intNumArray.GetLowerBound(0) To intNumArray.GetUpperBound(0)
            intNumArray(i) = Int(Rnd() * 100) ' assigns random integer value to each NumArray value.
        Next

        'sort array list from highest to lowest, making upper and lower bounds the largest and smallest.
        For j = intNumArray.GetLowerBound(0) To intNumArray.GetUpperBound(0) - 1
            For i = intNumArray.GetLowerBound(0) To intNumArray.GetUpperBound(0) - 1
                If intNumArray(i) > intNumArray(i + 1) Then
                    intTemporary = intNumArray(i)
                    intNumArray(i) = intNumArray(i + 1)
                    intNumArray(i + 1) = intTemporary
                End If

            Next
        Next
        lblNum1.Text = intNumArray(0).ToString
        lblNum2.Text = intNumArray(1).ToString
        lblNum3.Text = intNumArray(2).ToString
        lblNum4.Text = intNumArray(3).ToString
        lblNum5.Text = intNumArray(4).ToString
        lblNum6.Text = intNumArray(5).ToString
        lblBiggest.Text = "Biggest number is " & intNumArray(intNumArray.GetUpperBound(0)).ToString
        lblSmallest.Text = "Smallest number is " & intNumArray(intNumArray.GetLowerBound(0)).ToString

        lblBiggest.Visible = True
        lblSmallest.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class
