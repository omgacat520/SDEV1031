'Prologue

Public Class frmLargest

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnLargest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLargest.Click
        'Declarations
        Dim shoNum1, shoNum2, shoNum3 As Short
        Dim shoLargest As Short

        'Input
        shoNum1 = nudNum1.Value
        shoNum2 = nudNum2.Value
        shoNum3 = nudNum3.Value

        'Processing
        If shoNum1 > shoNum2 Then
            shoLargest = shoNum1
        Else
            shoLargest = shoNum2
        End If
        If shoNum3 > shoLargest Then
            shoLargest = shoNum3
        End If

        'Output
        lblLargest.Text = shoLargest.ToString

    End Sub
End Class
