'Prologue

Public Class frmComputerizedGuesses
    Dim mbytNum As Byte
    Dim mbytLow As Byte = 1
    Dim mbytHigh As Byte = 100

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub



    Private Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click
        Dim bytGuess As Byte
        Dim bytTries As Byte

        mbytLow = 1
        mbytHigh = 100
        mbytNum = Int(Rnd() * 100 + 1)

        rtbOut.Clear()
        rtbOut.AppendText("Tries   Guess   Low   High" & vbNewLine)

        Do
            bytTries += 1
            bytGuess = Int(Rnd() * (mbytHigh - mbytLow) + mbytLow + 1)
            rtbOut.AppendText(bytTries.ToString & "       " & bytGuess.ToString _
            & "      " & mbytLow.ToString & "     " & mbytHigh.ToString & vbNewLine)
            If bytGuess > mbytNum Then
                mbytHigh = bytGuess
            End If
            If bytGuess < mbytNum Then
                mbytLow = bytGuess
            End If

        Loop Until mbytNum = bytGuess

        rtbOut.AppendText(vbNewLine & "Random Number: " & mbytNum.ToString)

    End Sub


    Private Sub frmComputerizedGuesses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()

    End Sub
End Class
