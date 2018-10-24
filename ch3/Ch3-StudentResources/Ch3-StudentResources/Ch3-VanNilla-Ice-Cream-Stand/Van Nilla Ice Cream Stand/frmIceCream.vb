'Prologue
'Program has bugs

Public Class frmIceCream

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub
    'btnClear_Click
    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        'Declarations
        Const decSinglePrice As Single = 1.75
        Const decDoublePrice As Single = 2.75
        Const decTriplePrice As Single = 3.5

        Dim bytSingle As Byte
        Dim bytDouble As Byte
        Dim bytTriple As Byte

        Dim decSingle As Decimal
        Dim decDouble As Decimal
        Dim decTriple As Decimal
        Dim decTotal As Decimal

        'Input
        bytSingle = Convert.ToByte(txtSingle.Text)
        bytDouble = Convert.ToByte(txtDouble.Text)
        bytTriple = Convert.ToByte(txtTriple.Text)


        'Processing
        decSingle = decSinglePrice * bytSingle
        decDouble = decDoublePrice * bytDouble
        decTriple = decTriplePrice * bytTriple
        decTotal = decSingle + decDouble + decTriple

        'Output
        lblSingle.Text = decSingle.ToString("c")
        lblDouble.Text = decDouble.ToString("c")
        lblTriple.Text = decTriple.ToString("c")
        lblTotal.Text = decTotal.ToString("c")

    End Sub
    'btnOrder_Click
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clear textboxes and labels
        txtSingle.Clear()
        txtDouble.Clear()
        txtTriple.Clear()
        lblSingle.ResetText()
        lblDouble.ResetText()
        lblTriple.ResetText()
        lblTotal.ResetText()

    End Sub
End Class
