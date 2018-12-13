Public Class Form1
    Private Sub btnExe_Click(sender As Object, e As EventArgs) Handles btnExe.Click
        Dim intDateArray(3) As Integer
        intDateArray(0) = mtbThisHour.Text
        intDateArray(1) = mtbThisDay.Text
        intDateArray(2) = mtbThisMonth.Text
        intDateArray(3) = mtbThisYear.Text

        Dim intDesiredFutureArray(1) As Integer
        intDesiredFutureArray(0) = mtbFutureHour.Text
        intDesiredFutureArray(1) = mtbFutureDay.Text

        Dim intFutureDateArray(3) As Integer
        intFutureDateArray = {0, 0, 0, 0}
        ReDim intFutureDateArray(3) ' -- Hour, Day, Month, Year values.

        'for data validation, mtb prevents anything but integer values, and this For and If statement assures that all inputs make sense.
        For i = intDateArray.GetLowerBound(0) To (intDateArray.GetUpperBound(0))
            If intDateArray(i) < 0 Then 'make sure input exists for DateArray
                MessageBox.Show("Make sure all text boxes are filled out.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf intDateArray(2) > 12 Or intDateArray(2) < 0 Then 'validates months
                MessageBox.Show("Your months must be between 1 and 12", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf intDateArray(0) > 24 Or intDateArray(1) <= -1 Then 'validates days
                MessageBox.Show("Your Hours must be between 0 and 24", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                For c = intDesiredFutureArray.GetLowerBound(0) To intDesiredFutureArray.GetUpperBound(0)
                    If intDesiredFutureArray(c) < 0 Then 'make sure input exists for Desired Future Array
                        MessageBox.Show("Make sure all text boxes are filled out.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf intDateArray(2) > 12 Or intDesiredFutureArray(1) < 0 Then 'validates months
                        MessageBox.Show("Your Desired months must be between 1 and 12", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf intDateArray(0) > 24 Or intDesiredFutureArray(0) <= -1 Then 'validates days
                        MessageBox.Show("Your Desired Hours must be between 0 and 24", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        'CODE GOES HERE
                        Call DoTheStuff(intDateArray, intDesiredFutureArray, intFutureDateArray)
                        Call subOutput(intDesiredFutureArray)
                    End If
                Next
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
        'THIS ONE INCLUDES LEAP YEARS
        'instead of breaking down, just compare units to maximum values, and if they exceed maximums, then add to next largest denomination, like a cash register.
        'leap year hours = 8784, normal year hours = 8760
        'Depending on the month, take day value (24 hrs) and multiply by number of days.
        'Link for how many days: https://www.timeanddate.com/calendar/months/

        'Might need to change when this is assigned, testing needed for these.
        intFutureDateArray(0) = IntDateArray(0) + IntDesiredFutureArray(0)
        intFutureDateArray(1) = IntDateArray(1) + IntDesiredFutureArray(1) + intFutureDateArray(1)
        intFutureDateArray(2) = IntDateArray(2) + intFutureDateArray(2)
        intFutureDateArray(3) = IntDateArray(3) + intFutureDateArray(3)

        If intFutureDateArray(0) > 24 Then
            Do Until intFutureDateArray(0) < 24
                intFutureDateArray(1) = intFutureDateArray(1) + 1
                intFutureDateArray(0) = intFutureDateArray(0) - 24
            Loop
        End If

        Dim j As Integer = 1
        For i = 0 To j
            Select Case intFutureDateArray(2) 'need to figure out what month it is, so I know when to switch from X ammount of days, to 0 and then add 1 to the month value.
                Case Is = 1
                    If intFutureDateArray(1) > 31 Then
                        Do Until intFutureDateArray(1) < 31
                            intFutureDateArray(2) = intFutureDateArray(2) + 1
                            intFutureDateArray(1) = intFutureDateArray(1) - 31
                        Loop
                        j = j + 1
                    End If
                Case Is = 2
                    If intFutureDateArray(1) > 29 Then
                        Do Until intFutureDateArray(1) < 29
                            intFutureDateArray(2) = intFutureDateArray(2) + 1
                            intFutureDateArray(1) = intFutureDateArray(1) - 29
                        Loop
                        j = j + 1
                    End If
                Case Is = 3
                    If intFutureDateArray(1) > 31 Then
                        Do Until intFutureDateArray(1) < 31
                            intFutureDateArray(2) = intFutureDateArray(2) + 1
                            intFutureDateArray(1) = intFutureDateArray(1) - 31
                        Loop
                        j = j + 1
                    End If
                Case Is = 4
                    If intFutureDateArray(1) > 30 Then
                        Do Until intFutureDateArray(1) < 30
                            intFutureDateArray(2) = intFutureDateArray(2) + 1
                            intFutureDateArray(1) = intFutureDateArray(1) - 30
                        Loop
                        j = j + 1
                    End If
                Case Is = 5
                    If intFutureDateArray(1) > 31 Then
                        Do Until intFutureDateArray(1) < 31
                            intFutureDateArray(2) = intFutureDateArray(2) + 1
                            intFutureDateArray(1) = intFutureDateArray(1) - 31
                        Loop
                        j = j + 1
                    End If
                Case Is = 6
                    If intFutureDateArray(1) > 30 Then
                        Do Until intFutureDateArray(1) < 30
                            intFutureDateArray(2) = intFutureDateArray(2) + 1
                            intFutureDateArray(1) = intFutureDateArray(1) - 30
                        Loop
                        j = j + 1
                    End If
                Case Is = 7
                    If intFutureDateArray(1) > 31 Then
                        Do Until intFutureDateArray(1) < 31
                            intFutureDateArray(2) = intFutureDateArray(2) + 1
                            intFutureDateArray(1) = intFutureDateArray(1) - 31
                        Loop
                        j = j + 1
                    End If
                Case Is = 8
                    If intFutureDateArray(1) > 31 Then
                        Do Until intFutureDateArray(1) < 31
                            intFutureDateArray(2) = intFutureDateArray(2) + 1
                            intFutureDateArray(1) = intFutureDateArray(1) - 31
                        Loop
                        j = j + 1
                    End If
                Case Is = 9
                    If intFutureDateArray(1) > 30 Then
                        Do Until intFutureDateArray(1) < 30
                            intFutureDateArray(2) = intFutureDateArray(2) + 1
                            intFutureDateArray(1) = intFutureDateArray(1) - 30
                        Loop
                        j = j + 1
                    End If
                Case Is = 10
                    If intFutureDateArray(1) > 31 Then
                        Do Until intFutureDateArray(1) < 31
                            intFutureDateArray(2) = intFutureDateArray(2) + 1
                            intFutureDateArray(1) = intFutureDateArray(1) - 31
                        Loop
                        j = j + 1
                    End If
                Case Is = 11
                    If intFutureDateArray(1) > 30 Then
                        Do Until intFutureDateArray(1) < 30
                            intFutureDateArray(2) = intFutureDateArray(2) + 1
                            intFutureDateArray(1) = intFutureDateArray(1) - 30
                        Loop
                        j = j + 1
                    End If
                Case Is = 12
                    If intFutureDateArray(1) > 31 Then
                        Do Until intFutureDateArray(1) < 31
                            intFutureDateArray(2) = intFutureDateArray(2) + 1
                            intFutureDateArray(1) = intFutureDateArray(1) - 31
                        Loop
                        j = j + 1
                    End If
            End Select
        Next
        'Year value
        j = 1
        intFutureDateArray(3) = intFutureDateArray(3) + IntDateArray(3)
        For i = 0 To j
            If intFutureDateArray(2) > 12 Then
                Do Until intFutureDateArray(3) > 12
                    intFutureDateArray(3) = intFutureDateArray(3) + 1
                    intFutureDateArray(2) = intFutureDateArray(2) - 12
                Loop
                j = j + 1
            End If
        Next

        Return intFutureDateArray(0)
        Return intFutureDateArray(1)
        Return intFutureDateArray(2)
        Return intFutureDateArray(3)
    End Function

    Private Function NoLeapYear(ByVal IntDateArray() As Integer, ByVal IntDesiredFutureArray() As Integer, ByVal intFutureDateArray() As Integer)

    End Function
    Private Sub subOutput(ByVal intFutureDateArray() As Integer)
        ReDim Preserve intFutureDateArray(3)
        lblOutput.Text = (intFutureDateArray(0) & " Military Time on " & intFutureDateArray(2) & "/" & intFutureDateArray(1) & "/" & intFutureDateArray(3))
        lblOutput.Visible = True
    End Sub
End Class

