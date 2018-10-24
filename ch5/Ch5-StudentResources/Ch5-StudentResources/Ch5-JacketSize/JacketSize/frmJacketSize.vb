'Prologue

Public Class frmJacketSize

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrice.Click
        'Declarations
        Dim strSize As String
        Dim decPrice As Decimal

        'Input
        strSize = txtSize.Text

        strSize = strSize.ToUpper
        If strSize = "S" Or strSize = "M" Or strSize = "L" Or strSize = "XL" Then
            'Processing
            If strSize = "S" Then
                decPrice = 29.95
            End If
            If strSize = "M" Then
                decPrice = 34.95
            End If
            If strSize = "L" Then
                decPrice = 39.95
            End If
            If strSize = "XL" Then
                decPrice = 44.95
            End If

            'Output
            lblPrice.Text = decPrice.ToString("c")

        Else
            MsgBox("Please enter S, M, L or XL for the size.", MsgBoxStyle.OkOnly, "Jacket Size")

        End If

    End Sub
End Class
