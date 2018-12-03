Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim monthName() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "september", "October", "November", "december"}
        Dim shoMonthDays() As Short = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}

        Dim i As Integer 'i is gonna be this weird in-between variable that can be shared between all of the arrays.
        If IsNumeric(txtInput.Text) = True Then
            i = txtInput.Text - 1 'since indexes are 0 based, and traditional calendars are 1 based.
            lblOutput.Text = ("There are " & shoMonthDays(i).ToString & " days in " & monthName(i).ToString & ".")
            lblOutput.Visible = True
        End If

    End Sub
End Class
