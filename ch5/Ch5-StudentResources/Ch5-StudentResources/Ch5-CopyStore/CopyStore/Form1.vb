'Prologue

Public Class Form1

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        'Declarations
        Dim shoNumCopies As Short
        Dim bytWeight As Byte
        Dim strWC As String
        Dim strBusType As String
        Dim sngSalesTaxRate As Single
        Dim decPrice As Decimal
        Dim decSubtotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotal As Decimal

        'Input
        If IsNumeric(txtNumCopies.Text) Then
            MsgBox("Please enter the number of copies.", MsgBoxStyle.OkOnly, "Sorry, I didn't understand.")

        Else
            shoNumCopies = Convert.ToInt16(txtNumCopies.Text)

        End If

        bytWeight = nudWeight.Value
        strWC = txtWC.Text
        strBusType = txtBusType.Text

        'Processing
        'Determine the number of copies with the first case
        '    Then determine if the paper is white or colored
        '        The If determines the weight, either 50 or 100#
        '            Price comes from pricing table

        Select Case shoNumCopies
            Case 1 To 9
                Select Case strWC
                    Case Is = "W", "w"
                        If bytWeight = 50 Then
                            decPrice = 0.1
                        Else
                            decPrice = 0.15
                        End If

                    Case Is = "C", "c"
                        If bytWeight = 50 Then
                            decPrice = 0.15
                        Else
                            decPrice = 0.2
                        End If

                    Case Else
                        MsgBox("Please W or C for the paper type.", MsgBoxStyle.OkOnly, "Sorry, I didn't understand.")

                End Select

            Case 10 To 15
                Select Case strWC
                    Case Is = "W", "w"
                        If bytWeight = 50 Then
                            decPrice = 0.08
                        Else
                            decPrice = 0.14
                        End If

                    Case Is = "C", "c"
                        If bytWeight = 50 Then
                            decPrice = 0.13
                        Else
                            decPrice = 0.18
                        End If

                    Case Else
                        MsgBox("Please W or C for the paper type.", MsgBoxStyle.OkOnly, "Sorry, I didn't understand.")

                End Select

            Case 25 To 99
                Select Case strWC
                    Case Is = "W", "w"
                        If bytWeight = 50 Then
                            decPrice = 0.16
                        Else
                            decPrice = 0.12
                        End If

                    Case Is = "C", "c"
                        If bytWeight = 50 Then
                            decPrice = 0.13
                        Else
                            decPrice = 0.06
                        End If

                    Case Else
                        MsgBox("Please W or C for the paper type.", MsgBoxStyle.OkOnly, "Sorry, I didn't understand.")

                End Select

            Case Is >= 100
                Select Case strWC
                    Case Is = "W", "w"
                        If bytWeight = 50 Then
                            decPrice = 0.05
                        Else
                            decPrice = 0.12
                        End If

                    Case Is = "C", "c"
                        If bytWeight = 50 Then
                            decPrice = 0.1
                        Else
                            decPrice = 0.15
                        End If

                    Case Else
                        MsgBox("Please W or C for the paper type.", MsgBoxStyle.OkOnly, "Sorry, I didn't understand.")

                End Select
        End Select

        'Determine if sales tax must be paid
        If strBusType = "B" And strBusType = "P" Then
            'Sales Tax
            sngSalesTaxRate = 0.07
        ElseIf strBusType = "" Then
            MsgBox("Please B, P, C or N for the business type.", MsgBoxStyle.OkOnly, "Sorry, I didn't understand.")

        End If

        'Calculate costs
        decSubtotal = decPrice * shoNumCopies
        decSalesTax = decSubtotal * sngSalesTaxRate
        decTotal = decSubtotal + decSalesTax

        'Output
        lblPrice.Text = decPrice.ToString("c")
        lblSubtotal.Text = decSubtotal.ToString("c")
        lblSalesTax.Text = decSalesTax.ToString("c")
        lblTotal.Text = decTotal.ToString("c")

    End Sub
End Class
