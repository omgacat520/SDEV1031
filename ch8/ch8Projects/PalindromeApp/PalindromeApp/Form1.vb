﻿Public Class Form1
    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        Dim strInput As String

        strInput = txtInput.Text

        strInput = strInput.Replace(" ", "") 'input data correction
        Debug.WriteLine("strInput after space replace is " & strInput)

        'REVERSE
        Dim strInputUpdated As String
        Dim intTotalLength As Integer

        'still need to figure out a loop I can call that reverses the integers of all the characters, as well as knows when its a Capital and when it swaps, and call a sub to display the output, and I probably wont modularize any of this, considering the entire application has one button and one output and one entire purpose. Modularizing it would be redundant.



        'using index values for a "Man in the middle, AKA the space, we're trying to separate those strings into two substrings, but I keep getting an error at strLastName saying that one of these variable values is outside the (length, I think?) value, even though the variables are assigned integer values. I put a -1 since the character index counts from 1 and the characters are indexed from 0.

        intTotalLength = strInput.Length 'Total String Length

        'having it substringed before this function actually splits the original string, causing it to be significantly smaller than when we first got its length value at the beginning, meaning that we'll need to reassign the length value twice.

        Dim c As String
        For i = (strInput.Length) To 1 Step -1

            c = GetChar(strInput, i)

            strInputUpdated &= c
            Debug.WriteLine("GetCharacter Loop = '" & strInputUpdated & "' loop #" & i)

        Next i
        If strInputUpdated = strInput Then
            lblOutput.Text = "It's a palindrome."
        Else
            lblOutput.Text = "It's not a palindrome."
        End If
        lblOutput.Visible = True

    End Sub
End Class
