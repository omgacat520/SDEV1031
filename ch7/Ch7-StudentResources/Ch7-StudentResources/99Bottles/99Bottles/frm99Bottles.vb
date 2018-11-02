Public Class frm99Bottles

    Private Sub btnSing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSing.Click
        Dim i As Integer

        rtbLyrics.Clear()

        'Loop starts at 99 and goes to zero
        i = 99
        Do While i > 0
            Verse(i)
        Loop

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Public Sub Verse(ByRef bytVerse As Byte)
        'Display first two line
        rtbLyrics.AppendText(bytVerse & " bottles of beer on the wall, " & bytVerse & " bottles of beer." & vbNewLine)
        rtbLyrics.AppendText("You take one down and pass it around, " & vbNewLine)

        'Update number of bottles
        bytVerse = bytVerse - 1

        'Display last line
        rtbLyrics.AppendText(bytVerse & " bottles of beer on the wall!" & vbNewLine)
        rtbLyrics.AppendText(vbNewLine)

    End Sub
End Class
