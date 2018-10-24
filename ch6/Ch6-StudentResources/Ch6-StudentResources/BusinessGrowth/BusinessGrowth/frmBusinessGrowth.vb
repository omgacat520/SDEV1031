'Prologue


Public Class frmBusinessGrowth

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnGrowth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrowth.Click
        'Declarations
        Dim sngRate As Single
        Dim decGoal As Decimal
        Dim decValue As Decimal
        Dim shoYears As Short

        'Input
        decValue = Convert.ToDecimal(txtInitial.Text)
        sngRate = Convert.ToSingle(txtRate.Text)
        decGoal = Convert.ToDecimal(txtGoal.Text)

        'Processing
        sngRate = sngRate / 100
        Do Until decValue > decGoal
            decValue = decValue + (decValue * sngRate)
            shoYears += 1
        Loop
        'Output
        lblYears.Text = shoYears.ToString

    End Sub
End Class
