Public Class Form1
    'we could condense the two subs that provide the output arrays, by having a function based on a boolean value produced by finding out whether or not the year is a leap year, and if it is, it returns february as 29, if not, returns february as 28. Simplifies code, and makes it smaller.
    Dim intFutureDateArray(3) As Integer

    Private Sub btnExe_Click(sender As Object, e As EventArgs) Handles btnExe.Click
        Dim intDateArray(3) As Integer
        intDateArray(0) = mtbThisHour.Text
        intDateArray(1) = mtbThisDay.Text
        intDateArray(2) = mtbThisMonth.Text
        intDateArray(3) = mtbThisYear.Text

        Dim intDesiredFutureArray(1) As Integer
        intDesiredFutureArray(0) = mtbFutureHour.Text
        intDesiredFutureArray(1) = mtbFutureDay.Text

        intFutureDateArray = {0, 0, 0, 0}


        'NEED TO REMAKE DATA VALIDATION

        'CODE GOES HERE
        Call DoTheStuff(intDateArray, intDesiredFutureArray, intFutureDateArray)
        Call subOutput(intFutureDateArray)
    End Sub
    Private Sub DoTheStuff(ByVal IntDateArray() As Integer, ByVal IntDesiredFutureArray() As Integer, ByVal intFutureDateArray() As Integer)

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
    End Sub

    Private Sub HasLeapYear(ByVal IntDateArray() As Integer, ByVal IntDesiredFutureArray() As Integer, ByVal intFutureDateArray() As Integer)
        'THIS ONE INCLUDES LEAP YEARS
        'compare units to maximum values, and if they exceed maximums, then add to next largest denomination, like a cash register.
        'Depending on the month, take day value (24 hrs) and multiply by number of days.
        'Link for how many days: https://www.timeanddate.com/calendar/months/

        'Might need to change when this is assigned, testing needed for these.
        intFutureDateArray(0) = IntDateArray(0) + IntDesiredFutureArray(0) 'hours
        intFutureDateArray(1) = IntDateArray(1) + IntDesiredFutureArray(1) + intFutureDateArray(1) ' days
        intFutureDateArray(2) = IntDateArray(2) + intFutureDateArray(2) ' months
        intFutureDateArray(3) = IntDateArray(3) + intFutureDateArray(3) ' years
        'day value
        If intFutureDateArray(0) > 24 Then
            Do Until intFutureDateArray(0) < 24
                intFutureDateArray(1) = intFutureDateArray(1) + 1
                intFutureDateArray(0) = intFutureDateArray(0) - 24
            Loop
        End If
        'month value
        Dim intWhatMonth As Integer 'temporary variable
        Select Case intFutureDateArray(2)
                'Checks how many days per month
                Case Is = 1 Or 3 Or 5 Or 7 Or 8 Or 10 Or 12 '31 day months
                    intWhatMonth = 31
                Case Is = 2 'february / leap year month
                    intWhatMonth = 29
                Case Is = 4 Or 6 Or 9 Or 11 '30 day months
                    intWhatMonth = 30
            End Select

        If intFutureDateArray(1) > intWhatMonth Then
            Do Until intFutureDateArray(1) <= intWhatMonth
                intFutureDateArray(2) = intFutureDateArray(2) + 1
                intFutureDateArray(1) = intFutureDateArray(1) - intWhatMonth
            Loop
        End If
        'Year value
        Dim j As Integer = 1
        For i = 0 To j
            If intFutureDateArray(2) > 12 Then
                Do Until intFutureDateArray(3) > 12
                    intFutureDateArray(3) = intFutureDateArray(3) + 1
                    intFutureDateArray(2) = intFutureDateArray(2) - 12
                Loop
                j = j + 1
            End If
        Next

        Debug.WriteLine("returning with " & intFutureDateArray(0) & " As hours and " & intFutureDateArray(1) & " as days " & intFutureDateArray(2) & " as months and " & intFutureDateArray(3) & " as years")

    End Sub

    Private Function NoLeapYear(ByVal IntDateArray() As Integer, ByVal IntDesiredFutureArray() As Integer, ByVal intFutureDateArray() As Integer)

    End Function

    Private Sub subOutput(intAnotherFutureDateArray() As Integer)
        lblOutput.Text = (intAnotherFutureDateArray(0) & ":00 Military Time on " & intAnotherFutureDateArray(2) & "/" & intAnotherFutureDateArray(1) & "/" & intAnotherFutureDateArray(3))
        Debug.WriteLine("Finish with a intFutureDate array of " & intAnotherFutureDateArray(0) & " Hours, " & intAnotherFutureDateArray(1) & " Days, " & intAnotherFutureDateArray(2) & " Months, " & intAnotherFutureDateArray(3) & " Years.")
        lblOutput.Visible = True
    End Sub
End Class

