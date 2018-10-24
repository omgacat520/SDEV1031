'Prologue

Public Class frmPersonalDates
    Dim mdatToday As Date

    Private Sub frmPersonalDates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Finds and displays today's date

        mdatToday = Today

        lblToday.Text = mdatToday.ToShortDateString

    End Sub

    Private Sub btnDaysOld_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDaysOld.Click
        'Finds how many days old the user is

        Dim bytMonth As Byte
        Dim bytDay As Byte
        Dim shoYear As Short
        Dim strBirthday As String
        Dim lngDaysOld As Long
        Dim datBirthday As Date

        'Get user's birthday
        bytMonth = nudMonth.Value
        bytDay = nudDay.Value
        shoYear = nudYear.Value

        'Convert birtday to a date
        strBirthday = "#" & bytMonth.ToString & "/" & bytDay.ToString & "/" & shoYear.ToString & "#"
        datBirthday = Convert.ToDateTime(strBirthday)

        'Finds difference between days
        lngDaysOld = DateDiff(DateInterval.Day, datBirthday, mdatToday)

        lblDaysOld.Text = lngDaysOld.ToString

    End Sub

    Private Sub btnCountdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCountdown.Click
        'Finds the days until Christmas
        Dim bytMonth As Byte
        Dim bytDay As Byte
        Dim shoYear As Short
        Dim strResult As String
        Dim lngTilHoliday As Long
        Dim datTilHoliday As Date

        'Get holiday
        bytMonth = nudHolMonth.Value
        bytDay = nudHolDay.Value
        shoYear = nudHolYear.Value

        'Convert holiday to a date
        strResult = "#" & bytMonth.ToString & "/" & bytDay.ToString & "/" & shoYear.ToString & "#"
        datTilHoliday = Convert.ToDateTime(strResult)

        'Finds difference between days
        lngTilHoliday = DateDiff(DateInterval.Day, mdatToday, datTilHoliday)

        lblTilHoliday.Text = lngTilHoliday.ToString

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub
End Class
