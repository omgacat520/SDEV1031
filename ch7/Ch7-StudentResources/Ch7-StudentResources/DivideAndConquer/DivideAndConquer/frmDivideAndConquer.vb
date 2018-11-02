'Prologue

Public Class frmDivideAndConquer
    'Declarations
    Dim msngDivisor As Single
    Dim msngDividend As Single
    Dim msngQuotient As Single

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        'Call Procedures 
        Call Input()
        Call Processing()
        Call Output()

    End Sub

    Private Sub Input()
        msngDivisor = txtDivisor.Text
        msngDividend = txtDividend.Text

    End Sub

    Private Sub Processing()
        msngQuotient = msngDivisor / msngDividend

    End Sub

    Private Sub Output()
        lblQuotient.Text = msngQuotient.ToString("n1")

    End Sub
End Class
