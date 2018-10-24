'Prologue

Public Class frmSimpleGraphics

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Dim i, j As Byte

        rtbOut.Clear()
        For i = 1 To 10
            For j = 1 To i
                rtbOut.AppendText("*")
            Next j
            rtbOut.AppendText(vbNewLine)
        Next i
    End Sub

    Private Sub btnTry2_Click(sender As System.Object, e As System.EventArgs) Handles btnTry2.Click
        Dim i, j As Integer

        rtbOut.Clear()


        For i = 1 To 10
            For j = 1 To i
                rtbOut.AppendText("*")
            Next j
            rtbOut.AppendText(vbNewLine)
        Next i
        rtbOut.AppendText("***********")
        rtbOut.AppendText(vbNewLine)
        For i = 10 To 1 Step -1
            For j = 1 To i
                rtbOut.AppendText("*")
            Next j
            rtbOut.AppendText(vbNewLine)
        Next i
    End Sub
End Class
