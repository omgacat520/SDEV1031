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

        Dim c As String
        For i = (strInput.Length) To 1 Step -1

            c = GetChar(strInput, i)

            strInputUpdated &= c
            Debug.WriteLine("GetCharacter Loop = '" & strInputUpdated & "' loop #" & i)

        Next i
        lblOutput.Text = strInputUpdated
        lblOutput.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnIndexSpace.Click
        'Space Index
        Dim intSpaceIndex As Integer
        Dim strInput As String

        strInput = txtInput.Text

        intSpaceIndex = strInput.IndexOf(" ") 'character index of space in string.

        lblOutput.Text = intSpaceIndex.ToString & " (Starts at 0)"
        lblOutput.Visible = True
    End Sub

    Private Sub btnPadLeft_Click(sender As Object, e As EventArgs) Handles btnPadLeft.Click
        'PAD LEFT
        Dim strMasterString As String
        Dim intMaxChars As Integer = 20
        Dim strInput As String
        Dim intPaddedNeeded As Integer

        strInput = txtInput.Text

        If intMaxChars - strInput.Length >= 0 Then
            intPaddedNeeded = (intMaxChars - strInput.Length)

            strMasterString = "@" & strInput.PadLeft(intPaddedNeeded) & "@" 'I'm acting on the assumption that the 20 character limit acts without accounting the @ symbols.

            lblOutput.Text = strMasterString
            lblOutput.Visible = True
        Else
            'Error message, can't display 20 chars if the input exceeds 20 chars.
            MessageBox.Show("A string with extra padding and additional characters thats 20 characters long can't exist if the initial string is greater than 20.")
        End If
    End Sub

    Private Sub btnPadRight_Click(sender As Object, e As EventArgs) Handles btnPadRight.Click
        'PAD RIGHT
        Dim strMasterString As String
        Dim intMaxChars As Integer = 20
        Dim strInput As String
        Dim intPaddedNeeded As Integer

        strInput = txtInput.Text

        If intMaxChars - strInput.Length >= 0 Then
            intPaddedNeeded = (intMaxChars - strInput.Length)

            strMasterString = "@" & strInput.PadRight(intPaddedNeeded, "*") & "@" 'I'm acting on the assumption that the 20 character limit acts without accounting the @ symbols.

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
            For i = 5 To 10 Step 1
                strOutputString &= GetChar(strInput, i)
            Next i
        End If
        lblOutput.Text = strOutputString
        lblOutput.Visible = True
    End Sub
End Class
