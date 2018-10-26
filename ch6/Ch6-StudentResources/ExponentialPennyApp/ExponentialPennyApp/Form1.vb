Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'so, this is gonna be a lot of loops and if-statements, but I gotta figure out a calculation for each month for the penny on each individual day, (Nest if-loops in loops that are designated to months) and I gotta figure out when it would be technically more profitable to work for salary and when it would be more profitable to have the penny expontential function (two separate functions, one exponential, the other is a linear increase of 5000$, graph the intersection for an if-statement.)
        'Reset variables below here
        rtbInfo.Clear()
        'variables below here
        Dim decRaise As Decimal
        Dim decPenny As Decimal
        Dim strmath As String
        'variables for each months counting-loops
        Dim bytDay As Byte
        Dim dblPennyTotal As Double
        'Processing below here
        decRaise = txtSalaryRaise.Text
        decPenny = 0.01
        bytDay = 0 + 1

        If IsNumeric(txtSalaryRaise.Text) = True Then
            'Per-Month If Statements
            'Jan (31 days)

            rtbInfo.AppendText("1 Month" & vbNewLine)
            Do Until bytDay = 31 + 1
                strmath = ((decPenny * 2).ToString("f2"))
                decPenny = Convert.ToDecimal(strmath)
                rtbInfo.AppendText(vbNewLine) 'Space between values
                rtbInfo.AppendText("Day " & bytDay & " " & decPenny.ToString("c") & vbNewLine)
                bytDay = bytDay + 1
            Loop
            dblPennyTotal = decPenny * 12
            rtbInfo.AppendText(vbNewLine & "Assumed yearly total: " & dblPennyTotal.ToString("c"))
        Else
            rtbInfo.AppendText("Please display salary without non-numeric characters.")
        End If
        'Result Outputs below here
        lblPennyVal.Text = "penny's value increases to " & decPenny.ToString("c") & " in one month" & vbNewLine & "yearly value: " & dblPennyTotal.ToString("c")

        If decRaise * 12 > dblPennyTotal Then
            lblRecommend.Text = "Take the raise, it's worth more yearly."
        Else
            lblRecommend.Text = "Take the penny, it's worth more yearly."
        End If


    End Sub
End Class
