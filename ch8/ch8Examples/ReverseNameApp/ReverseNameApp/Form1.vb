Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        Dim strInput As String
        Dim strFirstName As String
        Dim strFirstNameUpdated As String
        Dim strLastName As String
        Dim strLastNameUpdated As String
        Dim intSpaceIndex As Integer
        Dim intTotalLength As Integer
        'input
        strInput = txtInput.Text

        'trim sides for data quality, no extra spaces.
        strInput = strInput.Trim
        'Debug.WriteLine("strInput = '" & strInput & "' after trim.")

        'still need to figure out a loop I can call that reverses the integers of all the characters, as well as knows when its a Capital and when it swaps, and call a sub to display the output, and I probably wont modularize any of this, considering the entire application has one button and one output and one entire purpose. Modularizing it would be redundant.

        'makes all characters lowercase.
        strInput = strInput.ToLower
        'Debug.WriteLine("strInput = '" & strInput & "' after lowercase conversion.")

        intSpaceIndex = strInput.IndexOf(" ") 'character index of space in string.

        'using index values for a "Man in the middle, AKA the space, we're trying to separate those strings into two substrings, but I keep getting an error at strLastName saying that one of these variable values is outside the (length, I think?) value, even though the variables are assigned integer values. I put a -1 since the character index counts from 1 and the characters are indexed from 0.

        intTotalLength = strInput.Length 'Total String Length
        'Debug.WriteLine("intTotalLength = '" & intTotalLength & "' before Substring")
        strFirstName = strInput.Substring(0, (intSpaceIndex))
        strLastName = strInput.Substring(intSpaceIndex + 1)

        'having it substringed before this function actually splits the original string, causing it to be significantly smaller than when we first got its length value at the beginning, meaning that we'll need to reassign the length value twice.

        'Dim c As String
        For i = (strFirstName.Length - 1) To 0 Step -1

            'c = GetChar(strFirstName, i)
            'strFirstNameUpdated = strFirstNameUpdated & c

            strFirstNameUpdated &= strFirstName.Substring(i, 1) 'Ok, I copied the code over from the Project File, but I genuinely just don't understand how this works, doesn't the computer index strings by doing (Lowest part of index, highest part of index) for a substring? How does it take this higher value and go to one? Can it work backwards like that? This is blowing my mind.

            If strFirstName.Length = 1 Then 'capitalizes first character
                strFirstName = strFirstName.ToUpper
            End If

            'Debug.WriteLine("ReverseSubstring Loop = '" & strFirstNameUpdated & "' loop #" & i)

        Next i
        For i = (strLastName.Length - 1) To 0 Step -1

            'c = GetChar(strLastName, i)
            'strLastNameUpdated = strLastNameUpdated & c

            strLastNameUpdated &= strLastName.Substring(i, 1)

            If strLastName.Length = 1 Then 'capitalizes first character
                strLastName = strLastName.ToUpper
            End If

            'Debug.WriteLine("ReverseSubstring Loop = '" & strLastNameUpdated & "' loop #" & i)

        Next i
        lblOutput.Text = StrConv(strFirstNameUpdated, VbStrConv.ProperCase) & " " & StrConv(strLastNameUpdated, VbStrConv.ProperCase)
        lblOutput.Visible = True
    End Sub
End Class
