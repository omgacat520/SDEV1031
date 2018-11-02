Public Class frmMenuExample

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        EndProgram()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        EndProgram()

    End Sub

    Private Sub btnRecPerimeter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecPerimeter.Click
        RectanglePerimeter()

    End Sub

    Private Sub mnuShapeRectanglePerimeter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShapeRectanglePerimeter.Click
        RectanglePerimeter()

    End Sub

    Private Sub btnRecArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecArea.Click
        RectangleArea()

    End Sub

    Private Sub menuShapeRectangleArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuShapeRectangleArea.Click
        RectangleArea()

    End Sub



    'Procedures

    Private Sub EndProgram()
        End
    End Sub

    Private Sub RectanglePerimeter()
        'Declarations
        Dim sngLength As Single
        Dim sngWidth As Single
        Dim sngRecPerimeter As Single

        'Input
        sngLength = txtLength.Text
        sngWidth = txtWidth.Text

        'Processing
        sngRecPerimeter = CalcRecPerimeter(sngLength, sngWidth)

        'Output
        lblRecPerimeter.Text = sngRecPerimeter.ToString

    End Sub

    Private Sub RectangleArea()
        'Declarations
        Dim sngLength As Single
        Dim sngWidth As Single
        Dim sngRecArea As Single

        'Input
        sngLength = txtLength.Text
        sngWidth = txtWidth.Text

        'Processing
        sngRecArea = CalcRecArea(sngLength, sngWidth)

        'Output
        lblRecArea.Text = sngRecArea.ToString

    End Sub


    'Functions

    'Determines perimeter of a rectangle
    'Formula is 2(length + width)
    Private Function CalcRecPerimeter(ByVal sngL As Single, ByVal sngW As Single) As Single
        Return 2 * (sngL + sngW)

    End Function

    'Determines area of a rectangle
    'Formula is length * width
    Private Function CalcRecArea(ByVal sngL As Single, ByVal sngW As Single) As Single
        Return (sngL * sngW)

    End Function


    'Determines perimeter of an equilateral triangle
    'Formula is 3 * length


    'Determines area of an equilateral triangle
    'Formula is (length * width) / 2


    'Determines circumference of a circle
    'Formula is 2 * pi * radius


    'Determines area of a circle
    'Formula is pi * radius ^ 2



End Class
