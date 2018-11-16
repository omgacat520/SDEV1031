Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        Dim strInput As String

        strInput = txtInput.Text

        'trim sides for data quality, no extra spaces.
        strInput = strInput.Trim
        Debug.WriteLine("strInput = '" & strInput & "' after trim.")
        'still need to figure out a loop I can call that reverses the integers of all the characters, as well as knows when its a Capital and when it swaps, and call a sub to display the output, and I probably wont modularize any of this, considering the entire application has one button and one output and one entire purpose. Modularizing it would be redundant.
    End Sub
End Class
