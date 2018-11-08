Public Class Form1 'NEED TO REMAKE OPERATIONS FOR THIS ONE, CHECK NOTEBOOK FOR FLOWCHART AND OUTLINE FOR NEW CODE.
    Private Sub btnMethodA_Click(sender As Object, e As EventArgs) Handles btnMethodA.Click
        'METHOD A - (Instructor description as follows) 
        'This method will Get the year input by the user, then call a function that takes the year value as a parameter and returns an int for the number of days in February in that year. Assign that returned value to a variable in method A. Then call the sub that writes the result in the label. - REMEMBER TO USE MODULUS

        'INPUTS
        Dim intYear As Integer
        Dim bytFebDays As Byte


        If IsNumeric(txtYear.Text) Then 'attempt to make it user friendly

            'CODE GOES HERE #############################

            intYear = txtYear.Text

            Call FuncisItLeapA(intYear, bytFebDays)
            Call funcDisplayOutputA(intYear, bytFebDays)
            System.Diagnostics.Debug.WriteLine("int year is " & intYear)
            System.Diagnostics.Debug.WriteLine("bytFebDays is " & bytFebDays)

        Else
            lblOutput.Text = "Please input a number."
        End If

    End Sub

    Private Sub btnMethodB_Click(sender As Object, e As EventArgs) Handles btnMethodB.Click
        'METHOD B - (Instructor description as follows) 
        'This method will Get the year input by the user, then calls a function that takes the year value as a parameter And determines if it Is a leap year, returning True Or False. In method B, call the function to check if the year Is a leap year, And If true, assign 29 To the number Of days, otherwise assign 28 to the number of days. Then call the sub that writes the result in the label. - REMEMBER TO USE MODULUS

        If IsNumeric(txtYear.Text) Then 'user friendliness or whatever so no crashes, but i don't have any implimentation knowledge of how to check if its a decimal and reject it if is.
            'CODE GOES HERE
            Dim intYear As Integer
            Dim boolLeapYear As Boolean
            intYear = txtYear.Text
            Call FuncIsItLeapB(intYear, boolLeapYear)
            Call funcDisplayOutputB(intYear, boolLeapYear)
        Else
            lblOutput.Text = "Please input a number."
        End If

    End Sub

    'subroutines and functions go under here
    'CHECK LEAPYEAR FUNCTION METHOD A

    Private Function FuncisItLeapA(ByRef intYearLocal As Integer, ByRef bytFebDaysLocal As Byte)
        If (intYearLocal Mod 100) = 0 Then
            If (intYearLocal Mod 400) = 0 Then
                bytFebDaysLocal = 29
            Else
                bytFebDaysLocal = 28
            End If
        Else
            If (intYearLocal Mod 4) = 0 Then
                bytFebDaysLocal = 29
            Else
                bytFebDaysLocal = 28
            End If
        End If
        Return bytFebDaysLocal
    End Function

    'CHECK LEAPYEAR FUNCTION METHOD B
    Private Function FuncIsItLeapB(ByRef intYearLocal As Integer, ByRef boolYesNoLocal As Boolean)
        If (intYearLocal Mod 100) = 0 Then
            If (intYearLocal Mod 400) = 0 Then
                boolYesNoLocal = True
            Else
                boolYesNoLocal = False
            End If
        Else
            If (intYearLocal Mod 4) = 0 Then
                boolYesNoLocal = True
            Else
                boolYesNoLocal = False
            End If
        End If
        Return boolYesNoLocal
    End Function


    'OUTPUT METHOD A
    Private Sub funcDisplayOutputA(ByRef intYear As Integer, bytFebDaysLocal As Byte)
        If bytFebDaysLocal = 28 Then
            lblOutput.Text = intYear.ToString & " has " & bytFebDaysLocal.ToString & " days in February and is not a leap year."
        Else
            lblOutput.Text = intYear.ToString & " has " & bytFebDaysLocal.ToString & " days in February and is a leap year."
        End If

        lblOutput.Visible = True
    End Sub
    'OUTPUT METHOD B
    Private Sub funcDisplayOutputB(ByRef intYearLocal As Integer, boolYesNoLocal As Boolean)
        If boolYesNoLocal Then 'Still have to replace variables for it to display correctly.
            lblOutput.Text = intYearLocal.ToString & " has 29 days in February and is a leap year."
        Else
            lblOutput.Text = intYearLocal.ToString & " has 28 days in February and is not a leap year."
        End If

        lblOutput.Visible = True
    End Sub
End Class
