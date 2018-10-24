Public Class Form1
    Dim mintCounter1, mintCounter2, mintAccumA As Integer
    Dim mintCounter3 As Integer = 10
    Dim mintAccumS As Integer = 100

    Private Sub btnCounter1_Click(sender As System.Object, e As System.EventArgs) Handles btnCounter1.Click
        'counter goes up by 1
        mintCounter1 = mintCounter1 + 1
        lblC1.Text = mintCounter1.ToString
    End Sub

    Private Sub btnCounter5_Click(sender As System.Object, e As System.EventArgs) Handles btnCounter5.Click
        'counter goes up by 5
        mintCounter2 = mintCounter2 + 5
        lblC5.Text = mintCounter2.ToString
    End Sub

    Private Sub btnCountDown_Click(sender As System.Object, e As System.EventArgs) Handles btnCountDown.Click
        'counter goes down by 1
        mintCounter3 = mintCounter3 - 1
        lblCminus1.Text = mintCounter3.ToString
    End Sub

    Private Sub btnAccumAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAccumAdd.Click
        'add number in textbox to total
        Dim intUserNum As Integer
        intUserNum = Convert.ToInt16(txtAdd.Text)
        mintAccumA = mintAccumA + intUserNum
        lblAplus.Text = mintAccumA.ToString

    End Sub

    Private Sub btnAccumSubtract_Click(sender As System.Object, e As System.EventArgs) Handles btnAccumSubtract.Click
        'subtract number in textbox from total which starts at 100
        Dim intUserNum As Integer
        intUserNum = Convert.ToInt16(txtSubtract.Text)
        mintAccumS = mintAccumS - intUserNum
        lblAminus.Text = mintAccumS.ToString
    End Sub
End Class
