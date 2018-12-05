Public Class Form1


    Private Sub btnStudentsAscnd_Click(sender As Object, e As EventArgs) Handles btnStudentsAscnd.Click
        Dim strStudentName() As String = {"Ambrose", "Bjorn", "Carob", "Daffyth", "Jake"}
        Dim decStudentScore() As Decimal = {82.3, 98.5, 70.0, 89.1, 92.1}
        'SORT STUDENTS ASCENDING - list is already alphabetized, so technically could just display names.
        rtbScores.Clear()
        rtbStudents.Clear()
        For i = strStudentName.GetLowerBound(0) To strStudentName.GetUpperBound(0)
            rtbStudents.AppendText(strStudentName(i) & vbNewLine)
            rtbScores.AppendText(decStudentScore(i) & vbNewLine)
        Next

    End Sub

    Private Sub btnStudentsDescnd_Click(sender As Object, e As EventArgs) Handles btnStudentsDescnd.Click
        Dim strStudentName() As String = {"Ambrose", "Bjorn", "Carob", "Daffyth", "Jake"}
        Dim decStudentScore() As Decimal = {82.3, 98.5, 70.0, 89.1, 92.1}
        'SORT STUDENTS DESCENDING - just reverse the list, as its already alphabetized.
        rtbScores.Clear()
        rtbStudents.Clear()

        Array.Reverse(strStudentName)
        Array.Reverse(decStudentScore)

        For i = strStudentName.GetLowerBound(0) To strStudentName.GetUpperBound(0)
            rtbStudents.AppendText(strStudentName(i) & vbNewLine)
            rtbScores.AppendText(decStudentScore(i) & vbNewLine)
        Next
    End Sub

    Private Sub btnScoresDescnd_Click(sender As Object, e As EventArgs) Handles btnScoresDescnd.Click
        'SORT SCORES DESCENDING - do process for sort scores, and then reverse the output for that function.
    End Sub

    Private Sub btnScoresAscnd_Click(sender As Object, e As EventArgs) Handles btnScoresAscnd.Click
        'SORT SCORES ASCENDING - bubble sort by comparing decimal values, and changing positions for decimal array and corresponding name.
        Dim strStudentName() As String = {"Ambrose", "Bjorn", "Carob", "Daffyth", "Jake"}
        Dim decStudentScore() As Decimal = {82.3, 98.5, 70.0, 89.1, 92.1}
        Dim strTemporary As String
        Dim decTemporary As Decimal

        rtbScores.Clear()
        rtbStudents.Clear()
        'loop from [Minimum index] to ([Maximum index] - 1)
        'the (-1) part exists because the algorithm uses [current index] + 1 as a comparison value, and if current index is set to be the maximum index, then comparing max index + 1 would fall outside of an acceptable value for comparison, causing a runtime error.
        For i = strStudentName.GetLowerBound(0) To strStudentName.GetUpperBound(0) - 1
            If decStudentScore(i) > decStudentScore(i + 1) Then 'if the next term is greater than current one

                'NAMES
                strTemporary = strStudentName(i) ' temp = current
                strStudentName(i) = strStudentName(i + 1) ' current = next
                strStudentName(i + 1) = strTemporary 'next = temp
                'SCORES
                decTemporary = decStudentScore(i)
                decStudentScore(i) = decStudentScore(i + 1)
                decStudentScore(i + 1) = decTemporary
            End If
            'output, set to loop after conversion ([Max index] - 1) times.
            rtbStudents.AppendText(strStudentName(i) & vbNewLine)
            rtbScores.AppendText(decStudentScore(i) & vbNewLine)
        Next


    End Sub
End Class
