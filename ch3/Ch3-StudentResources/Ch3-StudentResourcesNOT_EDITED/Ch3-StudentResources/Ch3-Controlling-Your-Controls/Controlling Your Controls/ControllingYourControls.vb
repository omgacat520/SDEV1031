'Prologue
'Controlling Your Controls
'Practice setting and changing controls on a form

Public Class ControllingYourControls

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        'Declarations
        Const decPriceStudyGuides As Decimal = 40
        Dim shoNumStudyGuides As Short
        Dim decCostStudyGuides As Decimal

        'Input
        shoNumStudyGuides = txtStudyGuide.text

        'Processing
        decCostStudyGuides = shoNumStudyGuides * decPriceStudyGuides

        'Output
        lblCostStudyGuides.Text = decCostStudyGuides.ToString("c")

    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
