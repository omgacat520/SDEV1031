'Prologue
'Game of Even-Odd
'User predicts that the total of two dice will be even or odd - WANTED FUNCTIONALITY
'Note: a number is even if the result of modulus division by 2 is zero (no remainder when dividing by 2) - USE MODULUS DIVISION BY 2 TO ACHIEVE FUNCTIONALITY

Public Class frmDiceCaseStudy
    Dim sngPoints As Single = 1000
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub frmDiceCaseStudy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()


    End Sub

    'EVEN RESULTS --------------------------------------------------------------------------
    Private Sub btnEven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEven.Click
        'Declarations
        Dim bytDie1 As Byte
        Dim bytDie2 As Byte
        Dim bytTotal As Byte

        Dim sngBet As Single = Convert.ToSingle(txtBet.Text)


        'Input
        'Generate random numbers
        bytDie1 = Int(Rnd() * 6 + 1)
        bytDie2 = Int(Rnd() * 6 + 1)

        'Processing
        bytTotal = bytDie1 + bytDie2

        'Hide all dice
        picDie11.Visible = False
        picDie12.Visible = False
        picDie13.Visible = False
        picDie14.Visible = False
        picDie15.Visible = False
        picDie16.Visible = False
        picDie21.Visible = False
        picDie22.Visible = False
        picDie23.Visible = False
        picDie24.Visible = False
        picDie25.Visible = False
        picDie26.Visible = False

        'prediction results below
        If (bytTotal Mod 2 = 0) = True Then
            lblResult.Text = "Result: Nice guess, you won " & sngBet.ToString
            sngPoints = sngPoints + sngBet
        Else
            lblResult.Text = "Result: Sorry, wrong answer. -" & sngBet.ToString
            sngPoints = sngPoints - sngBet
        End If

        'Output
        'Display total
        lblTotal.Text = bytTotal.ToString
        lblPoints.Text = sngPoints.ToString


        'Display Die 1
        Select Case bytDie1
            Case 1
                picDie11.Visible = True
            Case 2
                picDie12.Visible = True
            Case 3
                picDie13.Visible = True
            Case 4
                picDie14.Visible = True
            Case 5
                picDie15.Visible = True
            Case 6
                picDie16.Visible = True
        End Select

        'Display Die 2
        Select Case bytDie2
            Case 1
                picDie21.Visible = True
            Case 2
                picDie22.Visible = True
            Case 3
                picDie23.Visible = True
            Case 4
                picDie24.Visible = True
            Case 5
                picDie25.Visible = True
            Case 6
                picDie26.Visible = True
        End Select


    End Sub

    'ODD RESULTS ----------------------------------------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOdd.Click
        'Declarations
        Dim bytDie1 As Byte
        Dim bytDie2 As Byte
        Dim bytTotal As Byte

        Dim sngBet As Single = Convert.ToSingle(txtBet.Text)

        'Input
        'Generate random numbers
        bytDie1 = Int(Rnd() * 6 + 1)
        bytDie2 = Int(Rnd() * 6 + 1)

        'Processing
        bytTotal = bytDie1 + bytDie2

        'Hide all dice
        picDie11.Visible = False
        picDie12.Visible = False
        picDie13.Visible = False
        picDie14.Visible = False
        picDie15.Visible = False
        picDie16.Visible = False
        picDie21.Visible = False
        picDie22.Visible = False
        picDie23.Visible = False
        picDie24.Visible = False
        picDie25.Visible = False
        picDie26.Visible = False


        'prediction results below
        If (bytTotal Mod 2 = 0) = True Then
            lblResult.Text = "Result: Sorry, wrong answer. -" & sngBet.ToString
            sngPoints = sngPoints - sngBet
        Else
            lblResult.Text = "Result: Nice guess, you won " & sngBet.ToString
            sngPoints = sngPoints + sngBet
        End If

        'Output
        'Display total
        lblTotal.Text = bytTotal.ToString
        lblPoints.Text = sngPoints.ToString

        'Display Die 1
        Select Case bytDie1
            Case 1
                picDie11.Visible = True
            Case 2
                picDie12.Visible = True
            Case 3
                picDie13.Visible = True
            Case 4
                picDie14.Visible = True
            Case 5
                picDie15.Visible = True
            Case 6
                picDie16.Visible = True
        End Select

        'Display Die 2
        Select Case bytDie2
            Case 1
                picDie21.Visible = True
            Case 2
                picDie22.Visible = True
            Case 3
                picDie23.Visible = True
            Case 4
                picDie24.Visible = True
            Case 5
                picDie25.Visible = True
            Case 6
                picDie26.Visible = True
        End Select
    End Sub
End Class
