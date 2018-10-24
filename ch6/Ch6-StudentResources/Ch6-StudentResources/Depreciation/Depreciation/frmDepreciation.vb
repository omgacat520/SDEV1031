'Prologue

Public Class frmDepreciation

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnDepreciate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepreciate.Click
        'Declarations
        Dim decSalvage As Decimal
        Dim bytLife As Byte
        Dim decDeprec As Decimal
        Dim decValue As Decimal
        Dim bytYear As Byte

        'Input
        decValue = nudValue.Value
        decSalvage = nudSalvage.Value
        bytLife = nudLife.Value

        'Processing
        rtbOut.Clear()
        rtbOut.AppendText("Year  Value" & vbNewLine)

        decDeprec = (decValue - decSalvage) / bytLife
        Do While decValue > decSalvage
            bytYear += 1
            decValue = decValue - decDeprec

            'Output
            rtbOut.AppendText(bytYear.ToString & "     " & decValue.ToString("c") & vbNewLine)

        Loop

    End Sub

  
End Class
