'Prologue

Public Class IfGrades

    Private Sub btnGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrade.Click
        'Declarations
        Dim bytPercent As Byte
        Dim strGrade As String

        'Input
        bytPercent = nudPercent.Value

        'Processing
        If bytPercent >= 90 Then
            strGrade = "A"
        Else
            If bytPercent >= 80 Then
                strGrade = "B"
            Else
                If bytPercent >= 70 Then
                    strGrade = "C"
                Else
                    If bytPercent >= 60 Then
                        strGrade = "D"
                    Else
                        strGrade = "F"
                    End If
                End If
            End If
        End If

        'Output
        lblGrade.Text = strGrade

    End Sub

    Private Sub btnGradeII_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGradeII.Click
        'Declarations
        Dim bytPercent As Byte
        Dim strGrade As String

        'Input
        bytPercent = nudPercent.Value

        'Processing
        If bytPercent >= 90 Then
            strGrade = "A"
        End If
        If bytPercent >= 80 And bytPercent < 90 Then
            strGrade = "B"
        End If
        If bytPercent >= 70 And bytPercent < 80 Then
            strGrade = "C"
        End If
        If bytPercent >= 60 And bytPercent < 70 Then
            strGrade = "D"
        End If
        If bytPercent < 60 Then
            strGrade = "F"
        End If

        'Output
        lblGrade.Text = strGrade

    End Sub

    Private Sub btnGradesIII_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGradesIII.Click
        'Declarations
        Dim bytPercent As Byte
        Dim strGrade As String

        'Input
        bytPercent = nudPercent.Value

        'Processing
        If bytPercent >= 90 Then
            strGrade = "A"
        ElseIf bytPercent >= 80 Then
            strGrade = "B"
        ElseIf bytPercent >= 70 Then
            strGrade = "C"
        ElseIf bytPercent >= 60 Then
            strGrade = "D"
        Else
            strGrade = "F"
        End If

        'Output
        lblGrade.Text = strGrade

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

End Class
