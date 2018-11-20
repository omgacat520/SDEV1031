Public Class Form1
    Private Sub btnSubEnc_Click(sender As Object, e As EventArgs) Handles btnSubEnc.Click
        'variables
        Dim strInput As String
        Dim strLetter As String
        Dim intAscLetterVal As Integer
        Dim strOutputString As String
        'input
        strInput = txtInput.Text

        For i = 0 To strInput.Length - 1
            strLetter = strInput.Substring(i, 1)
            If strLetter <> " " Then
                intAscLetterVal = Asc(strLetter) 'ascii numerical value
                strLetter = Chr(intAscLetterVal + 1)
            End If
            strOutputString = strOutputString + strLetter
            lblSubOutput.Text = "Encrypted String: " & strOutputString
            lblSubOutput.Visible = True
        Next
    End Sub

    Private Sub btnTransEnc_Click(sender As Object, e As EventArgs) Handles btnTransEnc.Click
        'variables
        Dim strInput As String
        Dim strLetter As String
        Dim intAscLetterVal As Integer
        Dim strTransOutput1 As String
        Dim strTransOutput2 As String
        Dim strOutputString As String
        Dim intAscEven As String
        Dim intAscOdd As String
        'input
        strInput = txtInput.Text

        For i = 0 To strInput.Length - 1
            strLetter = strInput.Substring(i, 1)
            If strLetter <> " " Then
                intAscLetterVal = Asc(strLetter) 'ascii numerical value

                If i Mod 2 = 0 Then
                    'even ascii values
                    intAscEven = intAscLetterVal
                    strLetter = Chr(intAscLetterVal)
                    strTransOutput1 += strLetter
                Else
                    'odd ascii values
                    intAscOdd = intAscLetterVal
                    strLetter = Chr(intAscLetterVal)
                    strTransOutput2 += strLetter
                End If
            Else
                'this takes the i value of the space here, and chooses which string to put the space in based on whether or not its value within the string index is odd or even.
                If i Mod 2 = 0 Then
                    intAscLetterVal = Asc(strLetter)
                    strTransOutput1 += Chr(intAscLetterVal)
                Else
                    intAscLetterVal = Asc(strLetter)
                    strTransOutput2 += Chr(intAscLetterVal)
                End If
            End If
            lblTransOutput1.Text = "Even ASCII characters: " & strTransOutput1
            lblTransOutput2.Text = "Odd ASCII characters: " & strTransOutput2
            lblTransOutput1.Visible = True
            lblTransOutput2.Visible = True

        Next
        Debug.WriteLine("Even string = " & strTransOutput1)
        Debug.WriteLine("Odd string = " & strTransOutput2)
    End Sub
End Class
