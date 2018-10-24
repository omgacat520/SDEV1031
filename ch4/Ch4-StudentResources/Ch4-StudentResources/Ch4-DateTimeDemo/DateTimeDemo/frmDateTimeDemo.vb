'Prologue

Public Class frmDateTimeDemo

    Private Sub btnCurrentDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrentDate.Click
        'Finds the current date and displays it
        Dim datCurrentDate As Date
        datCurrentDate = Now
        lblCurrentDate.Text = datCurrentDate.ToShortDateString
    End Sub

    Private Sub btnCurrentDate_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCurrentDate.MouseHover
        rtbCode.Clear()
        rtbCode.AppendText("'Finds the current date and displays it" & vbNewLine)
        rtbCode.AppendText("Dim datCurrentDate As Date" & vbNewLine & vbNewLine)
        rtbCode.AppendText("datCurrentDate = Now" & vbNewLine & vbNewLine)
        rtbCode.AppendText("lblCurrentDate.Text = datCurrentDate.ToShortDateString" & vbNewLine & vbNewLine)
    End Sub

    Private Sub btnCurrentTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrentTime.Click
        'Finds the current time and displays it
        Dim datCurrentTime As Date
        datCurrentTime = Now
        lblCurrentTime.Text = datCurrentTime.ToLongTimeString
    End Sub

    Private Sub btnCurrentTime_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCurrentTime.MouseHover
        rtbCode.Clear()
        rtbCode.AppendText("'Finds the current time and displays it" & vbNewLine)
        rtbCode.AppendText("Dim datCurrentTime As Date" & vbNewLine & vbNewLine)
        rtbCode.AppendText("datCurrentTime = Now" & vbNewLine & vbNewLine)
        rtbCode.AppendText("lblCurrentTime.Text = datCurrentTime.ToLongTimeString" & vbNewLine)
    End Sub

    Private Sub btnDaysPast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDaysPast.Click
        'Finds the days since the start of the new millennium
        Const datNewMillennium As Date = #1/1/2001#
        Dim datCurrentDate As Date = Now
        Dim lngDaysPast As Long
        lngDaysPast = DateDiff(DateInterval.Day, datNewMillennium, datCurrentDate)
        lblDaysPast.Text = lngDaysPast.ToString("n0")
    End Sub

    Private Sub btnDaysPast_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDaysPast.MouseHover
        rtbCode.Clear()
        rtbCode.AppendText("'Finds the past since the start of the new millennium" & vbNewLine)
        rtbCode.AppendText("Const datNewMillennium As Date = #1/1/2001#" & vbNewLine)
        rtbCode.AppendText("Dim datCurrentDate As Date = Now" & vbNewLine)
        rtbCode.AppendText("Dim lngDaysPast As Long" & vbNewLine & vbNewLine)
        rtbCode.AppendText("lngDaysPast = DateDiff(DateInterval.Day, datNewMillennium, datCurrentDate)" & vbNewLine & vbNewLine)
        rtbCode.AppendText("lblDaysPast.Text = lngDaysPast.ToString" & vbNewLine)
    End Sub

    Private Sub btnCurrentMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrentMonth.Click
        'Finds the current month and displays it
        Dim datCurrentDate As Date
        datCurrentDate = Now
        lblCurrentMonth.Text = datCurrentDate.Month.ToString
    End Sub

    Private Sub btnCurrentMonth_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCurrentMonth.MouseHover
        rtbCode.Clear()
        rtbCode.AppendText("'Finds the current month and displays it" & vbNewLine)
        rtbCode.AppendText("Dim datCurrentDate As Date" & vbNewLine & vbNewLine)
        rtbCode.AppendText("datCurrentDate = Now" & vbNewLine & vbNewLine)
        rtbCode.AppendText("lblCurrentMonth.Text = datCurrentDate.Month.ToString" & vbNewLine)
    End Sub

    Private Sub btnCurrentDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrentDay.Click
        'Finds the current day and displays it
        Dim datCurrentDate As Date
        datCurrentDate = Now
        lblCurrentDay.Text = datCurrentDate.Day.ToString
    End Sub

    Private Sub btnCurrentDay_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCurrentDay.MouseHover
        rtbCode.Clear()
        rtbCode.AppendText("'Finds the current day and displays it" & vbNewLine)
        rtbCode.AppendText("Dim datCurrentDate As Date" & vbNewLine & vbNewLine)
        rtbCode.AppendText("datCurrentDate = Now" & vbNewLine & vbNewLine)
        rtbCode.AppendText("lblCurrentMonth.Text = datCurrentDate.Day.ToString" & vbNewLine)
    End Sub

    Private Sub btnCurrentYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrentYear.Click
        'Finds the current year and displays it
        Dim datCurrentDate As Date
        datCurrentDate = Now
        lblCurrentYear.Text = datCurrentDate.Year.ToString
    End Sub

    Private Sub btnCurrentYear_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCurrentYear.MouseHover
        rtbCode.Clear()
        rtbCode.AppendText("'Finds the current year and displays it" & vbNewLine)
        rtbCode.AppendText("Dim datCurrentDate As Date" & vbNewLine & vbNewLine)
        rtbCode.AppendText("datCurrentDate = Now" & vbNewLine & vbNewLine)
        rtbCode.AppendText("lblCurrentYear.Text = datCurrentDate.Year.ToString" & vbNewLine)
    End Sub

    Private Sub btnDayOfWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDayOfWeek.Click
        'Finds the current day of the week and displays it
        Dim datCurrentDate As Date
        datCurrentDate = Now.Date
        lblDayOfWeek.Text = datCurrentDate.DayOfWeek.ToString
    End Sub

    Private Sub btnDayOfWeek_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDayOfWeek.MouseHover
        rtbCode.Clear()
        rtbCode.AppendText("'Finds the current day of the week and displays it" & vbNewLine)
        rtbCode.AppendText("Dim datCurrentDate As Date" & vbNewLine & vbNewLine)
        rtbCode.AppendText("datCurrentDate = Now.Date" & vbNewLine & vbNewLine)
        rtbCode.AppendText("lblDayOfWeek.Text = datCurrentDate.DayOfWeek.ToString" & vbNewLine)
    End Sub

    Private Sub btnCurrentHour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrentHour.Click
        'Finds the current hour and displays it
        'Current hour is based on military time, hours run from 0 to 23
        Dim datCurrentHour As Date
        datCurrentHour = Now
        lblCurrentHour.Text = datCurrentHour.Hour
    End Sub

    Private Sub btnCurrentHour_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCurrentHour.MouseHover
        rtbCode.Clear()
        rtbCode.AppendText("'Finds the current hour and displays it" & vbNewLine)
        rtbCode.AppendText("'Current hour is based on military time, hours run from 0 to 23" & vbNewLine)
        rtbCode.AppendText("Dim datCurrentHour As Date" & vbNewLine & vbNewLine)
        rtbCode.AppendText("datCurrentHour = Now" & vbNewLine & vbNewLine)
        rtbCode.AppendText("lblCurrentHour.Text = datCurrentHour.Hour" & vbNewLine)
    End Sub

    Private Sub btnCurrentMinute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrentMinute.Click
        'Finds the current minute and displays it
        Dim datCurrentMinute As Date
        datCurrentMinute = Now
        lblCurrentMinute.Text = datCurrentMinute.Minute
    End Sub

    Private Sub btnCurrentMinute_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCurrentMinute.MouseHover
        rtbCode.Clear()
        rtbCode.AppendText("'Finds the current minute and displays it" & vbNewLine)
        rtbCode.AppendText("Dim datCurrentMinute As Date" & vbNewLine & vbNewLine)
        rtbCode.AppendText("datCurrentMinute = Now" & vbNewLine & vbNewLine)
        rtbCode.AppendText("lblCurrentMinute.Text = datCurrentMinute.Minute" & vbNewLine)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
