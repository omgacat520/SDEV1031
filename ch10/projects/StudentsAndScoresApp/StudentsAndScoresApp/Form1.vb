Public Class Form1
    Dim strStudentName() As String = {"Ambrose", "Bjorn", "Carob", "Daffyth", "Jake"}
    Dim decStudentScore() As Decimal = {82.3, 98.5, 70.0, 89.1, 92.1}

    Private Sub btnStudentsAscnd_Click(sender As Object, e As EventArgs) Handles btnStudentsAscnd.Click
        'SORT STUDENTS ASCENDING
        Dim strTempSwap1 As String
        Dim decTempSwap2 As Decimal
        For i = strStudentName.GetLowerBound(0) To strStudentName.GetUpperBound(0) - 1
            If strStudentName(i) > strStudentName(i + 1) Then
                strTempSwap1 = strStudentName(i)
                strStudentName(i) = strStudentName(i + 1)
                strStudentName(i + 1) = strTempSwap1
                rtbStudents.AppendText(strStudentName(i) & vbNewLine)

                'since the data tables are parallel, if its true for one table, it by proxy will be true for the other table, meaning I can switch the values on the other tables by following the same logic.
                decTempSwap2 = decStudentScore(i)
                decStudentScore(i) = decStudentScore(i + 1)
                decStudentScore(i + 1) = decTempSwap2
                rtbScores.AppendText(decStudentScore(i) & vbNewLine)
            End If
        Next

    End Sub

    Private Sub btnStudentsDescnd_Click(sender As Object, e As EventArgs) Handles btnStudentsDescnd.Click
        'SORT STUDENTS DESCENDING
    End Sub

    Private Sub btnScoresDescnd_Click(sender As Object, e As EventArgs) Handles btnScoresDescnd.Click
        'SORT SCORES DESCENDING
    End Sub

    Private Sub btnScoresAscnd_Click(sender As Object, e As EventArgs) Handles btnScoresAscnd.Click
        'SORT SCORES ASCENDING
    End Sub
End Class
