Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUppercase.Click
        'UPPERCASE
        Dim strInput As String

        strInput = txtInput.Text
        lblOutput.Text = strInput.ToUpper
        lblOutput.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLowercase.Click
        'lowercase
        Dim strInput As String

        strInput = txtInput.Text
        lblOutput.Text = strInput.ToLower
        lblOutput.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLength.Click
        'Length
        Dim strInput As String

        strInput = txtInput.Text
        lblOutput.Text = strInput.Length.ToString
        lblOutput.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnTrim.Click
        'Trim
        Dim strInput As String

        strInput = txtInput.Text
        lblOutput.Text = strInput.Trim
        lblOutput.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        'REVERSE
        Dim strInput As String
        Dim strInputUpdated As String
        Dim intTotalLength As Integer
        'input
        strInput = txtInput.Text

        'still need to figure out a loop I can call that reverses the integers of all the characters, as well as knows when its a Capital and when it swaps, and call a sub to display the output, and I probably wont modularize any of this, considering the entire application has one button and one output and one entire purpose. Modularizing it would be redundant.



        'using index values for a "Man in the middle, AKA the space, we're trying to separate those strings into two substrings, but I keep getting an error at strLastName saying that one of these variable values is outside the (length, I think?) value, even though the variables are assigned integer values. I put a -1 since the character index counts from 1 and the characters are indexed from 0.

        intTotalLength = strInput.Length 'Total String Length

        'having it substringed before this function actually splits the original string, causing it to be significantly smaller than when we first got its length value at the beginning, meaning that we'll need to reassign the length value twice.

        For i = (strInput.Length - 1) To 0 Step -1

            'c = GetChar(strFirstName, i)
            'strFirstNameUpdated = strFirstNameUpdated & c

            strInputUpdated &= strInput.Substring(i, 1) 'Ok, I copied the code over from the Project File, but I genuinely just don't understand how this works, doesn't the computer index strings by doing (Lowest part of index, highest part of index) for a substring? How does it take this higher value and go to one? Can it work backwards like that? This is blowing my mind.

            If strInput.Length = 1 Then 'capitalizes first character
                strInput = strInput.ToUpper
            End If

            'Debug.WriteLine("ReverseSubstring Loop = '" & strFirstNameUpdated & "' loop #" & i)

        Next i
        lblOutput.Text = strInputUpdated
        lblOutput.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnIndexSpace.Click
        'Space Index
        Dim intSpaceIndex As Integer
        Dim strInput As String
        Dim strInputUpdated As String
        Dim intStringMax As Integer

        strInput = txtInput.Text

        intSpaceIndex = strInput.IndexOf(" ") 'character index of space in string.
        intStringMax = strInput.Length
        strInputUpdated = strInput.Substring(intSpaceIndex, (intStringMax - intSpaceIndex))

        lblOutput.Text = strInputUpdated
        lblOutput.Visible = True
    End Sub

    Private Sub btnPadLeft_Click(sender As Object, e As EventArgs) Handles btnPadLeft.Click
        'PAD LEFT - this doesn't work if the string is multi-worded or has a space.
        Dim strMasterString As String
        Dim intMaxChars As Integer = 18
        Dim strInput As String
        Dim intPaddedNeeded As Integer

        strInput = txtInput.Text

        If intMaxChars - strInput.Length >= 0 Then
            intPaddedNeeded = (intMaxChars - strInput.Length) 'amount of padding needed to make 20 characters

            strMasterString = "@" & strInput.PadLeft(18) & "@" 'I'm acting on the assumption that the 20 character limit acts while accounting the @ symbols.

            lblOutput.Text = strMasterString
            lblOutput.Visible = True

        Else
            'Error message, can't display 20 chars if the input exceeds 20 chars.
            MessageBox.Show("A string with extra padding and additional characters thats 20 characters long can't exist if the initial string is greater than 20.")
        End If
        'Debug.WriteLine("Length of masterstring is " & strMasterString.Length)
    End Sub

    Private Sub btnPadRight_Click(sender As Object, e As EventArgs) Handles btnPadRight.Click
        'PAD RIGHT
        Dim strMasterString As String
        Dim intMaxChars As Integer = 18
        Dim strInput As String
        Dim intPaddedNeeded As Integer

        strInput = txtInput.Text

        If intMaxChars - strInput.Length >= 0 Then
            intPaddedNeeded = (intMaxChars - strInput.Length)

            strMasterString = "@" & strInput.PadRight(18, "*") & "@" 'I'm acting on the assumption that the 20 character limit acts while accounting the @ symbols.

            lblOutput.Text = strMasterString
            lblOutput.Visible = True
        Else
            'Error message, can't display 20 chars if the input exceeds 20 chars.
            MessageBox.Show("A string with extra padding and additional characters thats 20 characters long can't exist if the initial string is greater than 20.")
        End If
    End Sub

    Private Sub btnSubStr5_Click(sender As Object, e As EventArgs) Handles btnSubStr5.Click
        'SubString 5
        Dim strInput As String
        Dim strOutputString As String

        strInput = txtInput.Text
        If strInput.Length < 10 Then
            MessageBox.Show("The character minimum is 10 characters, 5 to skip, 5 to display.")
        ElseIf strInput.Length >= 10 Then
            strOutputString = strInput.Substring(5, 5)
        End If
        lblOutput.Text = strOutputString
        lblOutput.Visible = True
    End Sub
End Class
