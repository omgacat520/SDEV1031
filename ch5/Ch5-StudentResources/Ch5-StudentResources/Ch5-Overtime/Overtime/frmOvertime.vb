'Prologue

Public Class frmOvertime

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnWages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWages.Click
        Dim sngHours As Single
        Dim sngRegHours As Single
        Dim sngOTHours As Single
        Dim decPayRate As Decimal
        Dim decRegPay As Decimal
        Dim decOTPay As Decimal
        Dim decPay As Decimal

        'Input
        If IsNumeric(txtHoursWorked.Text) Then
            sngHours = Convert.ToSingle(txtHoursWorked.Text)
        Else
            MsgBox("Please enter the hours worked.", MsgBoxStyle.OkOnly, "Data Entry Error")
        End If

        If IsNumeric(txtPayRate.Text) Then
            decPayRate = Convert.ToDecimal(txtPayRate.Text)
        Else
            MsgBox("Please enter the pay rate.", MsgBoxStyle.OkOnly, "Data Entry Error")
        End If

        'Processing

        'Determine if there's overtime and apportion the hours accordingly
        If sngHours > 40 Then
            'OT
            sngRegHours = 40
            sngOTHours = sngHours - 40
        Else
            'No OT
            sngRegHours = sngHours
            sngOTHours = 0
        End If

        'Calculate wages based on regular and overtime hours
        decRegPay = sngRegHours * decPayRate
        decOTPay = sngOTHours * decPayRate * 1.5
        decPay = decRegPay + decOTPay

        'Output
        lblRegularPay.Text = decRegPay.ToString("c")
        lblOvertimePay.Text = decOTPay.ToString("c")
        lblTotalPay.Text = decPay.ToString("c")

    End Sub
End Class
