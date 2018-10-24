'Prologue
Public Class frmDustyLenzkapp
    'Total sales for the day - P.S. Put m at the beginning to represent how big the variable scope is, and how in this case its public for just this module, so I'm using the abbrevation M for Module.
    Dim mdecTotalSales As Decimal
    'On Load - FUNCTIONAL
    Private Sub frmDustyLenzkapp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Clears the rtb and adds a header
        rtbOutput.Clear()
        rtbOutput.AppendText("         Dusty Lenzkapp's Camerarama" & vbNewLine)
        rtbOutput.AppendText("             Daily Sales Totals" & vbNewLine & vbNewLine)
        rtbOutput.AppendText("Employee        Sales   Rate  Commission" & vbNewLine)

    End Sub
    'On btnClear Click - FUNCTIONAL
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clears the rtb and adds a header
        rtbOutput.Clear()

    End Sub
    'On btnAdd Click - CURRENTLY FUNCTIONAL
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Finds and displays today's date

        Dim datToday As Date

        datToday = Now()

        lblDate.Text = datToday.ToLongDateString

        'Calculates commission and adds a detail line
        'Dim decTotalSales As Decimal - Commented out, but not sure if I want to completely delete it just yet, trying functionality by declaring Total Sales as a global variable for the form module.
        Dim strName As String
        Dim decSales As Decimal
        Dim sngCommRate As Single
        Dim decComm As Decimal
        Dim strOut As String

        'Input
        strName = txtName.Text
        decSales = Convert.ToDecimal(txtSales.Text)
        sngCommRate = nudCommRate.Value / 100 'Divide by 100 to get percent instead of val*100

        'Processing
        decComm = (sngCommRate * decSales) + sngCommRate
        mdecTotalSales = mdecTotalSales + decSales
        'Output

        'when displaying results, I'm going to create an index function that counts (indexes) the number of characters for each individual piece of output and minus it from a pool of available characters per output section, which will make the outputs look waaaay better, that way the actual table looks like a good aligned table rather than this jumbled mess of whatever it is right now, and it will still preserve the format of the document as originally intended. - EDIT: Nevermind, I think I'm overcomplicating this project.

        'Code for counting length is resultNumber = specificString.length
        'gonna need to count strName, ControlChars.Tab, sngCommRate(The String), decSales(The String)

        'Calculating employee characters
        'Dim shoEmployeeName As Short = strName.Length
        'Const EmployeeNamePool As Short = 16

        'Name + 1 space until total characters = 16
        'Do Until EmployeeNamePool = shoEmployeeName
        'strName = strName + " "
        'Loop
        'listed as follows, name, sales, rate, commmission
        strOut = strName & ControlChars.Tab & decSales.ToString("c") & ControlChars.Tab & sngCommRate.ToString("p1") & ControlChars.Tab & decComm.ToString("c") & vbNewLine
        rtbOutput.AppendText(strOut)


    End Sub
    'On btnTotal Click
    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        'Display total
        rtbOutput.AppendText("Total       " & mdecTotalSales.ToString("c"))
    End Sub
    'On btnExit Click
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

End Class
