'Prologue

Public Class frmLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim strLogin As String
        Const strAccess As String = "CUP"
        Dim shoAttempts As Short

        'Loop up to three times to get login
        Do
            shoAttempts = shoAttempts + 1
            strLogin = InputBox("Enter your login", "System Access")
            strLogin = strLogin.ToUpper
            If strLogin <> strAccess Then
                MsgBox("Login failed", MsgBoxStyle.OkOnly)
            End If
        Loop Until strLogin = strAccess Or shoAttempts >= 3

        'If login isn't correct, then end the program
        If strLogin <> strAccess Then
            End
        Else
            MsgBox("Welcome!", MsgBoxStyle.OkOnly)
        End If
    End Sub
End Class
