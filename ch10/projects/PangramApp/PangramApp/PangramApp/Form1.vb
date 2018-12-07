Public Class Form1
    Private Sub btnExe_Click(sender As Object, e As EventArgs) Handles btnExe.Click
        Dim strInput As String
        Dim strOriginalInput As String
        Dim strChar As String
        Dim strNewString As String
        Dim strLetterArray = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Dim intInputArray = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim strNotThere As String
        Dim boolGoodPangram As Boolean = True

        strInput = txtInput.Text
        strOriginalInput = txtInput.Text
        strInput = strInput.ToLower()
        strInput = strInput.Trim()

        'INPUT SANITATION
        For i = 0 To strInput.Length - 1 'takes input, removes space, and condenses into new variable
            strChar = strInput.Substring(i, 1)
            If strChar <> " " Then
                strNewString &= strChar
            End If
        Next


        For i = 0 To strNewString.Length - 1 'loops for entire string so every character gets checked
            strChar = strNewString.Substring(i, 1)
            For j = 0 To strLetterArray.GetUpperBound(0) 'loops for all letters in alphabet
                If strLetterArray(j) = strChar Then 'if current letter doesn't match array letter
                    intInputArray(j) = intInputArray(j) + 1
                End If
            Next
        Next
        'Check after calc, then display outputs.
        For i = 0 To intInputArray.GetUpperBound(0)
            If intInputArray(i) = 0 Then
                boolGoodPangram = False
            End If
        Next

        If boolGoodPangram = True Then
            'Good output
            lblOutput.Text = strInput & " is a Pangram."
        Else
            'bad output
            For i = intInputArray.GetLowerBound(0) To intInputArray.GetUpperBound(0)
                If intInputArray(i) = 0 Then
                    strNotThere = strNotThere + " " & strLetterArray(i)
                End If
            Next
            lblOutput.Text = (strOriginalInput & " is not a Pangram." & vbNewLine & "Missing letters: " & strNotThere)
        End If
        lblOutput.Visible = True
    End Sub
End Class
'im getting the exact opposite of what I want lol
