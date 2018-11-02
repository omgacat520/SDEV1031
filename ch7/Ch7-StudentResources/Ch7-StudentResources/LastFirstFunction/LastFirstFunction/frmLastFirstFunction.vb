'Prologue


Public Class frmLastFirstFunction

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnLastFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLastFirst.Click
        'Declarations
        Dim strFirst As String
        Dim strLast As String
        Dim strLastFirst As String

        'Input
        strFirst = txtFirst.Text
        strLast = txtLast.Text

        'Processing
        'Call LastFirst function and pass it the first name and last name
        'Function returns a string Last, First
        strLastFirst = LastFirst(strFirst, strLast)
        'Output
        lblLastFirst.Text = strLastFirst

    End Sub

    Private Function LastFirst(ByVal strFName As String, ByVal strLName As String) As String
        'Gets first and last name and returns them in Last, First format
        Return strLName & ", " & strFName

    End Function
End Class
