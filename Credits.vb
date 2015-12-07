Public Class Credits
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frmMain.Show()
        frmMain.Music.URL = "music\menu song.wav"
        frmMain.Music.Ctlcontrols.play()
    End Sub
End Class
