'Prologue

Public Class frmMarkup
    Dim mstrItem As String
    Dim mdecWholesale As Decimal
    Dim mdecRetail As Decimal

    Private Sub frmMarkup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ClearForm()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearForm()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnMarkup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkup.Click
        Call GetInput()
        Call DoProcessing()
        Call DisplayOutput()

    End Sub

    Private Sub GetInput()
        'Handles Input
        mstrItem = txtItem.Text
        mdecWholesale = txtWholesale.Text

    End Sub

    Private Sub DoProcessing()
        'Call CalcMarkup
        mdecRetail = CalcMarkup(mdecWholesale)

    End Sub

    Private Sub DisplayOutput()
        'Handles Output
        Dim strOut As String

        strOut = mstrItem & "      " & mdecWholesale.ToString("c") & "       50%     " & mdecRetail.ToString("c") & vbNewLine
        rtbOut.AppendText(strOut)

    End Sub

    Private Sub ClearForm()
        'Clear form
        rtbOut.Clear()
        rtbOut.AppendText("Item      Wholesale    Markup   Retail" & vbNewLine)
        txtItem.Clear()
        txtWholesale.Clear()

    End Sub

    Private Function CalcMarkup(ByVal decPrice As Decimal) As Decimal
        'Calculates 50% markup and returns retail price
        Const sngMarkup As Single = 0.5

        CalcMarkup = decPrice + (decPrice * sngMarkup)

    End Function

End Class
