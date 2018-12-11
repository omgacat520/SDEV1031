Public Class Form1
    Private Sub btnExe_Click(sender As Object, e As EventArgs) Handles btnExe.Click
        Dim intDateArray() As Integer = { '-- Hour, Day, Month, Year values.
            (mtbThisHour.Text), '0
            (mtbThisDay.Text), '1
            (mtbThisMonth.Text), '2
            (mtbThisYear.Text)} '3

        Dim intDesiredFutureArray() As Integer = {
            (mtbFutureHour.Text),
            (mtbFutureDay.Text)} ' -- Hour, Day values.

        Dim intFutureDateArray() As Integer = {
            0,
            0,
            0,
            0} ' -- Hour, Day, Month, Year values.

        'for data validation, mtb prevents anything but integer values, and this For and If statement assures that all inputs make sense.
        For i = intDateArray.GetLowerBound(0) To (intDateArray.GetUpperBound(0) + intDesiredFutureArray.GetUpperBound(0))
            If intDateArray(i) = 0 Then 'make sure input exists for DateArray
                MessageBox.Show("Make sure all text boxes are filled out.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf intDesiredFutureArray(i) = 0 Then 'make sure input exists for Desired Future Array
                MessageBox.Show("Make sure all text boxes are filled out.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf intDateArray(2) > 12 Or intDateArray(2) < 0 Then 'validates months
                MessageBox.Show("Your months must be between 1 and 12", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf intDateArray(0) > 24 Or intDateArray(1) <= -1 Then 'validates days
                MessageBox.Show("Your Hours must be between 0 and 24", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf intDateArray(2) > 12 Or intDesiredFutureArray(2) < 0 Then 'validates months
                MessageBox.Show("Your months must be between 1 and 12", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf intDateArray(0) > 24 Or intDesiredFutureArray(1) <= -1 Then 'validates days
                MessageBox.Show("Your Hours must be between 0 and 24", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'CODE GOES HERE
                Call DoTheStuff(intDateArray, intDesiredFutureArray, intFutureDateArray)

            End If
        Next
    End Sub
    Private Function DoTheStuff(ByVal IntDateArray() As Integer, ByVal IntDesiredFutureArray() As Integer, ByVal intFutureDateArray() As Integer)

        Dim boolIsLeap As Boolean ' this determines whether its a leap year, and then defines it for future code
        If IntDateArray(3) Mod 4 = 0 Then
            boolIsLeap = True
        Else
            boolIsLeap = False
        End If

        If boolIsLeap = True Then 'Has 29 days in february
            Call HasLeapYear(IntDateArray, IntDesiredFutureArray, intFutureDateArray)
        Else 'has 28 days in february
            Call NoLeapYear(IntDateArray, IntDesiredFutureArray, intFutureDateArray)
        End If

    End Function

    Private Function HasLeapYear(ByVal IntDateArray() As Integer, ByVal IntDesiredFutureArray() As Integer, ByVal intFutureDateArray() As Integer)

    End Function

    Private Function NoLeapYear(ByVal IntDateArray() As Integer, ByVal IntDesiredFutureArray() As Integer, ByVal intFutureDateArray() As Integer)

    End Function
End Class

