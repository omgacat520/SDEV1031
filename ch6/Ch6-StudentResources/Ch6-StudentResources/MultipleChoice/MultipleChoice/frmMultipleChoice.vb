'Prologue


Public Class frmMultipleChoice

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnswer.Click
        Const strRightAnswer As String = "5"
        Dim strAnswer As String

        Do
            strAnswer = InputBox("How many different types of loops are there?", "Multiple Choice")

        Loop While strAnswer <> strRightAnswer

        MsgBox("That's right! For loops, Do While, Do Until, Do Loop While and Do Loop Until", MsgBoxStyle.OkOnly, "Correct Answer")

    End Sub
End Class
