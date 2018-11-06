'Prologue

Public Class frmFICA

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnFICA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFICA.Click
        Dim decWages As Decimal
        Dim decFICA As Decimal

        'Input
        decWages = txtWages.Text

        'Processing
        decFICA = CalcFICA(decWages)

        'Output
        lblFICA.Text = decFICA.ToString("c")

    End Sub

    Private Function CalcFICA(ByVal decWages As Decimal)
        Const sngFICA As Single = 0.0765

        Return decWages * sngFICA
    End Function
End Class
