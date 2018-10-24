Public Class Form1
    Dim mstrFirstName As String = "Stranger"
    Dim mstrLastName As String = "McStrangerface"
    Private Sub btnGreetings_Click(sender As Object, e As EventArgs) Handles btnGreetings.Click

        mstrFirstName = InputBox("Greetings, whats ya name?", "Greetings")
        mstrLastName = InputBox("Okay, and your last name?", "Greetings Part Two")

        MessageBox.Show("Your name is " & mstrFirstName & " " & mstrLastName, "Greetings", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

        rtbOutput.AppendText("Your name is " & mstrFirstName & " " & mstrLastName & vbNewLine)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtbOutput.AppendText("What's up?" & vbNewLine)
    End Sub

    Private Sub btnHobby_Click(sender As Object, e As EventArgs) Handles btnHobby.Click
        Dim strHobby As String
        strHobby = InputBox("What's your favorite hobby?", "Tell me your hobby")

        MessageBox.Show("Your favorite hobby is " & strHobby, "Hobby", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        rtbOutput.AppendText(mstrFirstName & "'s favorite hobby is " & strHobby & vbNewLine)
    End Sub

    Private Sub btnFood_Click(sender As Object, e As EventArgs) Handles btnFood.Click
        Dim strFood As String
        strFood = InputBox("Whats your favorite food?", "Tell me your favorite food")

        MessageBox.Show("Your favorite food is " & strFood, "Food", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        rtbOutput.AppendText(mstrFirstName & "'s favorite food is " & strFood & vbNewLine)
    End Sub

    Private Sub btnSeason_Click(sender As Object, e As EventArgs) Handles btnSeason.Click
        Dim strSeason As String
        strSeason = InputBox("Whats your favorite Season?", "Tell me your favorite Season")

        MessageBox.Show("Your favorite Season is " & strSeason, "Season", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        rtbOutput.AppendText(mstrFirstName & "'s favorite Season is " & strSeason & vbNewLine)
    End Sub
End Class
