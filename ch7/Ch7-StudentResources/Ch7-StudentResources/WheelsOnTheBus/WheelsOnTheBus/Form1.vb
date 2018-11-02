Public Class Form1

    Private Sub Title()
        'Clears the rich text box and displays the title
        rtbLyrics.Clear()
        rtbLyrics.AppendText("             The Wheels on the Bus" & ControlChars.Cr & ControlChars.Cr)

    End Sub

    Private Sub Verse(ByVal strThing As String, ByVal strVerb As String, ByVal strSound As String)
        'Displays a verse of the song
        'The object making the noise, strThing, is passed along with the noise, strSound, and the verb, strVerb
        'Parameters are mixed with the lyrics to make the verse
        rtbLyrics.AppendText("The " & strThing & " on the bus " & strVerb & strSound & "," & ControlChars.Cr)
        rtbLyrics.AppendText(strSound & ", " & strSound & "." & ControlChars.Cr)
        rtbLyrics.AppendText("The " & strThing & " on the bus " & strVerb & strSound & "," & ControlChars.Cr)
        rtbLyrics.AppendText("down the country road!")

    End Sub

    Private Sub mnuSongWheels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSongWheels.Click
        'Variables declared for necessary words in the verse
        'Title is called to clear the screen and display the title
        'These values are passed to Verse procedure to produce a verse

        Dim strThings As String = "wheels"
        Dim strVerb As String = "go "
        Dim strSound As String = "round and round"

        Call Title()
        Call Verse(strThings, strVerb, strSound)

    End Sub


    Private Sub mnuSongWipers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSongWipers.Click
        Dim strThings As String = "wipers"
        Dim strVerb As String = "go "
        Dim strSound As String = "swish, swish, swish"

        Call Title()
        Call Verse(strThings, strVerb, strSound)

    End Sub

    Private Sub mnuSongHorn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSongHorn.Click
        Dim strThings As String = "horn"
        Dim strVerb As String = "goes "
        Dim strSound As String = "toot toot toot"

        Call Title()
        Call Verse(strThings, strVerb, strSound)

    End Sub

    Private Sub mnuSongRiders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSongRiders.Click
        Dim strThings As String = "riders"
        Dim strVerb As String = "go "
        Dim strSound As String = "up and down"

        Call Title()
        Call Verse(strThings, strVerb, strSound)

    End Sub

    Private Sub mnuSongSprings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSongSprings.Click
        Dim strThings As String = "springs"
        Dim strVerb As String = "go "
        Dim strSound As String = "boing, boing, boing"

        Call Title()
        Call Verse(strThings, strVerb, strSound)

    End Sub

    Private Sub mnuSongMotor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSongMotor.Click
        Dim strThings As String = "motor"
        Dim strVerb As String = "goes "
        Dim strSound As String = "vroom, vroom, vroom"

        Call Title()
        Call Verse(strThings, strVerb, strSound)

    End Sub

    Private Sub mnuSongSignals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSongSignals.Click
        Dim strThings As String = "signals"
        Dim strVerb As String = "go "
        Dim strSound As String = "blink, blink, blink"

        Call Title()
        Call Verse(strThings, strVerb, strSound)

    End Sub

    Private Sub mnuMoreMoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoreMoney.Click
        Dim strThings As String = "money"
        Dim strVerb As String = "goes "
        Dim strSound As String = "clink, clink, clink"

        Call Title()
        Call Verse(strThings, strVerb, strSound)

    End Sub


    Private Sub mnuMoreDoors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoreDoors.Click
        Dim strThings As String = "doors"
        Dim strVerb As String = "go "
        Dim strSound As String = "open and shut"

        Call Title()
        Call Verse(strThings, strVerb, strSound)

    End Sub

    Private Sub mnuMoreBell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoreBell.Click
        Dim strThings As String = "bell"
        Dim strVerb As String = "goes "
        Dim strSound As String = "ding, ding, ding"

        Call Title()
        Call Verse(strThings, strVerb, strSound)

    End Sub

    Private Sub mnuMoreDriver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoreDriver.Click
        Dim strThings As String = "driver"
        Dim strVerb As String = "says "
        Dim strSound As String = "move on back"

        Call Title()
        Call Verse(strThings, strVerb, strSound)

    End Sub

    Private Sub mnuMoreBaby_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoreBaby.Click
        Dim strThings As String = "baby"
        Dim strVerb As String = "says "
        Dim strSound As String = "wah, wah, wah"

        Call Title()
        Call Verse(strThings, strVerb, strSound)

    End Sub

    Private Sub mnuMoreMother_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoreMother.Click
        Dim strThings As String = "mother"
        Dim strVerb As String = "says "
        Dim strSound As String = "shush, shush, shush"

        Call Title()
        Call Verse(strThings, strVerb, strSound)

    End Sub

    Private Sub mnuMorePeople_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMorePeople.Click
        Dim strThings As String = "people"
        Dim strVerb As String = "say "
        Dim strSound As String = "thanks for the ride"

        Call Title()
        Call Verse(strThings, strVerb, strSound)

    End Sub

    Private Sub mnuSongBrakes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSongBrakes.Click
        Dim strThings As String = "brakes"
        Dim strVerb As String = "go "
        Dim strSound As String = "squeak, squeak, squeak"

        Call Title()
        Call Verse(strThings, strVerb, strSound)

    End Sub


    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        'Ends the program
        End
    End Sub
End Class
