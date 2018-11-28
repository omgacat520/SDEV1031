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

        For i = 0 To strInput.Length - 1 'loop
            strLetter = strInput.Substring(i, 1)
            If strLetter <> " " Then 'if letter isn't space
                intAscLetterVal = Asc(strLetter) 'assigning ascii numerical value

                If i Mod 2 = 0 Then
                    'even ascii values
                    intAscEven = intAscLetterVal + 1
                    strLetter = Chr(intAscEven)
                    strTransOutput1 += strLetter
                Else
                    'odd ascii values
                    intAscOdd = intAscLetterVal + 1
                    strLetter = Chr(intAscOdd)
                    strTransOutput2 += strLetter
                End If

            End If
        Next
        Debug.WriteLine("Even string = " & strTransOutput1)
        Debug.WriteLine("Odd string = " & strTransOutput2)

        lblTransOutput1.Text = "Even ASCII characters: " & strTransOutput1
        lblTransOutput2.Text = "Odd ASCII characters: " & strTransOutput2
        lblTransOutput1.Visible = True
        lblTransOutput2.Visible = True
    End Sub
End Class
