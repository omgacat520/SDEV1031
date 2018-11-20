Public Class Form1
    Dim intNumber1 As Integer
    Dim intNumber2 As Integer
    Dim intSum As Integer
    Private Sub btnNewProblem_Click(sender As Object, e As EventArgs) Handles btnNewProblem.Click


        intNumber1 = Int(Rnd() * 50)
        intNumber2 = Int(Rnd() * 50)

        intSum = intNumber1 + intNumber2

        Call DisplayOutput()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim intInput As Integer
        intInput = Val(mtbAnswer.Text.Trim)
        'Comparison code goes here
        If intSum = intInput Then
            lblResults.Text = "Nice job, Thats correct."
        Else
            lblResults.Text = "Try again, that's incorrect."
        End If
        Call DisplayOutput()
        lblResults.Visible = True
    End Sub


    Private Sub DisplayOutput()

        lblRndNum1.Text = intNumber1.ToString
        lblRndNum2.Text = intNumber2.ToString

        lblRndNum1.Visible = True
        lblRndNum2.Visible = True
        lblPlusSign.Visible = True
        lblEqualsSign.Visible = True

    End Sub
End Class
