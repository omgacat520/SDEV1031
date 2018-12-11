Public Class Form1


    Private Sub btnStudentsAscnd_Click(sender As Object, e As EventArgs) Handles btnStudentsAscnd.Click
        Dim strStudentName() As String = {"Ambrose", "Bjorn", "Carob", "Daffyth", "Jake"}
        Dim decStudentScore() As Decimal = {82.3, 98.5, 70.0, 89.1, 92.1}
        Dim strTemporary As String
        Dim decTemporary As Decimal

        'SORT STUDENTS ASCENDING - list is already alphabetized, so technically could just display names. -- EDIT: Added sort algorithm.
        rtbScores.Clear()
        rtbStudents.Clear()
        For j = strStudentName.GetLowerBound(0) To strStudentName.GetUpperBound(0) - 1
            For i = strStudentName.GetLowerBound(0) To strStudentName.GetUpperBound(0) - 1
                If strStudentName(i) > strStudentName(i + 1) Then
                    'NAMES
                    strTemporary = strStudentName(i) ' temp = current
                    strStudentName(i) = strStudentName(i + 1) ' current = next
                    strStudentName(i + 1) = strTemporary 'next = temp
                    'SCORES
                    decTemporary = decStudentScore(i)
                    decStudentScore(i) = decStudentScore(i + 1)
                    decStudentScore(i + 1) = decTemporary
                End If
            Next
        Next
        For i = strStudentName.GetLowerBound(0) To strStudentName.GetUpperBound(0)
            rtbStudents.AppendText(strStudentName(i) & vbNewLine)
            rtbScores.AppendText(decStudentScore(i) & vbNewLine)
        Next
    End Sub

    Private Sub btnStudentsDescnd_Click(sender As Object, e As EventArgs) Handles btnStudentsDescnd.Click
        Dim strStudentName() As String = {"Ambrose", "Bjorn", "Carob", "Daffyth", "Jake"}
        Dim decStudentScore() As Decimal = {82.3, 98.5, 70.0, 89.1, 92.1}
        Dim strTemporary As String
        Dim decTemporary As Decimal
        'SORT STUDENTS DESCENDING - just reverse the list, as its already alphabetized.
        rtbScores.Clear()
        rtbStudents.Clear()
        For j = strStudentName.GetUpperBound(0) - 1 To strStudentName.GetLowerBound(0) Step -1
            For i = strStudentName.GetUpperBound(0) - 1 To strStudentName.GetLowerBound(0) Step -1
                If strStudentName(i) < strStudentName(i + 1) Then
                    'NAMES
                    strTemporary = strStudentName(i) ' temp = current
                    strStudentName(i) = strStudentName(i + 1) ' current = next
                    strStudentName(i + 1) = strTemporary 'next = temp
                    'SCORES
                    decTemporary = decStudentScore(i)
                    decStudentScore(i) = decStudentScore(i + 1)
                    decStudentScore(i + 1) = decTemporary
                End If
            Next
        Next
        For i = strStudentName.GetLowerBound(0) To strStudentName.GetUpperBound(0)
            rtbStudents.AppendText(strStudentName(i) & vbNewLine)
            rtbScores.AppendText(decStudentScore(i) & vbNewLine)
        Next
    End Sub

    Private Sub btnScoresDescnd_Click(sender As Object, e As EventArgs) Handles btnScoresDescnd.Click
        'SORT SCORES DESCENDING - do process for sort scores, and then reverse the output for that function.
        Dim strStudentName() As String = {"Ambrose", "Bjorn", "Carob", "Daffyth", "Jake"}
        Dim decStudentScore() As Decimal = {82.3, 98.5, 70.0, 89.1, 92.1}
        Dim strTemporary As String
        Dim decTemporary As Decimal

        rtbScores.Clear()
        rtbStudents.Clear()
        'loop from [Minimum index] to ([Maximum index] - 1)
        'Honestly, why you repeat the for loop to just account for the last term in the array, don't really know what THAT'S the solution. Feels like theres a better way to do that.
        For j = strStudentName.GetLowerBound(0) To strStudentName.GetUpperBound(0) - 1
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
            Next
        Next
        Array.Reverse(strStudentName)
        Array.Reverse(decStudentScore)
        For i = strStudentName.GetLowerBound(0) To strStudentName.GetUpperBound(0)
            rtbStudents.AppendText(strStudentName(i) & vbNewLine)
            rtbScores.AppendText(decStudentScore(i) & vbNewLine)
        Next
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
        'Honestly, why you repeat the for loop to just account for the last term in the array, don't really know what THAT'S the solution. Feels like theres a better way to do that.
        For j = strStudentName.GetLowerBound(0) To strStudentName.GetUpperBound(0) - 1
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
            Next
        Next
        For i = strStudentName.GetLowerBound(0) To strStudentName.GetUpperBound(0)
            rtbStudents.AppendText(strStudentName(i) & vbNewLine)
            rtbScores.AppendText(decStudentScore(i) & vbNewLine)
        Next
    End Sub
End Class
'Finished! :)
