Public Class Form1
    Private Sub btnMethodA_Click(sender As Object, e As EventArgs) Handles btnMethodA.Click
        'METHOD A - (Instructor description as follows) 
        'This method will Get the year input by the user, then call a function that takes the year value as a parameter and returns an int for the number of days in February in that year. Assign that returned value to a variable in method A. Then call the sub that writes the result in the label. - REMEMBER TO USE MODULUS

        If IsNumeric(txtYear.Text) Then 'user friendliness or whatever so no crashes, but i don't have any implimentation knowledge of how to check if its a decimal and reject it if is.
            'CODE GOES HERE
            Dim bytYear As Byte
            txtYear.Text = bytYear


        Else
            lblOutput.Text = "Please input a number."
        End If
    End Sub

    Private Sub btnMethod2_Click(sender As Object, e As EventArgs) Handles btnMethod2.Click
        'METHOD B - (Instructor description as follows) 
        'This method will Get the year input by the user, then calls a function that takes the year value as a parameter And determines if it Is a leap year, returning True Or False. In method B, call the function to check if the year Is a leap year, And If true, assign 29 To the number Of days, otherwise assign 28 to the number of days. Then call the sub that writes the result in the label. - REMEMBER TO USE MODULUS
    End Sub
End Class
