'Prologue

Public Class frmCaseGrades

    Private Sub btnGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrade.Click
        'Declarations
        Dim bytPercent As Byte
        Dim strGrade As String

        'Input
        bytPercent = nudPercent.Value

        'Processing
        Select Case bytPercent
            Case Is >= 90
                strGrade = "A"
            Case Is >= 80
                strGrade = "B"
            Case Is >= 70
                strGrade = "C"
            Case Is >= 60
                strGrade = "D"
            Case Is < 60
                strGrade = "F"
        End Select

        'Output
        lblGrade.Text = strGrade
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnGradeII_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGradeII.Click
        'Declarations
        Dim bytPercent As Byte
        Dim strGrade As String

        'Input
        bytPercent = nudPercent.Value

        'Processing
        Select Case bytPercent
            Case 90 To 100
                strGrade = "A"
            Case 80 To 89
                strGrade = "B"
            Case 70 To 79
                strGrade = "C"
            Case 60 To 69
                strGrade = "D"
            Case 0 To 60
                strGrade = "F"
        End Select

        'Output
        lblGrade.Text = strGrade
    End Sub
End Class
