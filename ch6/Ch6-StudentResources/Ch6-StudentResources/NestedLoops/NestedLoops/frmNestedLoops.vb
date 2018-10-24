Public Class frmNestedLoops

    Private Sub btnNested_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNested.Click
        'Declarations
        Dim i As Integer
        Dim j As Integer

        'Processing
        rtbOut.Clear()
        rtbOut.AppendText("i  j" & vbNewLine)
        For i = 1 To 3
            For j = 1 To 4
                'Output
                rtbOut.AppendText(i.ToString & "  " & j.ToString & vbNewLine)
            Next j
        Next i

    End Sub

    Private Sub btnCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCount.Click
        'Declarations
        Dim i As Integer
        Dim j As Integer
        Dim bytCount As Byte

        'Processing
        rtbOut.Clear()
        rtbOut.AppendText("i  j   Count" & vbNewLine)
        For i = 1 To 3
            For j = 1 To 4
                bytCount = bytCount + 1
                'Output
                rtbOut.AppendText(i.ToString & "  " & j.ToString & "   " & bytCount.ToString & vbNewLine)
            Next j
        Next i

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub
End Class
