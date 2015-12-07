Public Class frmMain
    Dim ms As New System.IO.MemoryStream(My.Resources.FF6Cursor)
    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim Loc As Point
        Select Case e.KeyCode
            Case Keys.Left
                If Not player.Location.X - 8 < 0 Then
                    Loc = New Point(player.Location.X - 8, player.Location.Y)
                    player.Location = Loc
                End If
            Case Keys.Right
                If Not player.Location.X + 8 > Me.Width - player.Width - 5 Then
                    Loc = New Point(player.Location.X + 8, player.Location.Y)
                    player.Location = Loc
                End If
            Case Keys.Up
                If Not player.Location.Y - 8 < 0 Then
                    Loc = New Point(player.Location.X, player.Location.Y - 8)
                    player.Location = Loc
                End If
            Case Keys.Down
                If Not player.Location.Y - 8 > Me.Height - player.Height * 1.5 Then
                    Loc = New Point(player.Location.X, player.Location.Y + 8)
                    player.Location = Loc
                End If
        End Select
        'item Pick up (coin)
        If player.Bounds.IntersectsWith(Item.Bounds) Then
            Item.Hide()
            Item.Location = New Point(RandomNumber(Me.Width), RandomNumber(Me.Height))
            My.Computer.Audio.Play(My.Resources.picked, _
           AudioPlayMode.Background)
            Item.Show()
            'score
            Label2.Text += 1
        End If
        'item Pick up (coin)
        If player.Bounds.IntersectsWith(item2.Bounds) Then
            item2.Hide()
            item2.Location = New Point(RandomNumber(Me.Width), RandomNumber(Me.Height))
            My.Computer.Audio.Play(My.Resources.picked, _
           AudioPlayMode.Background)
            item2.Show()
            'score
            Label2.Text += 1
        End If
    End Sub
    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Music.URL = "music\menu song.wav"
        Music.Ctlcontrols.play()
        Item.Hide()
        item2.Hide()
        player.Hide()
        Sboard.Hide()
        SLabel.Hide()
        SLabel1.Hide()
        SLabel2.Hide()
        SLabel3.Hide()
        SLabeln1.Hide()
        SLabeln2.Hide()
        SLabeln3.Hide()
        BlinkLabel.Hide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Sboard.BackColor = Color.Black
        Music.Hide()
        Spawn.Hide()

        'Monsters
        Dragon.Hide()

    End Sub
    Public Class DoubleBufferPanel
        Inherits Panel
        Public Sub New()
            Me.DoubleBuffered = True
        End Sub
    End Class
    Private Sub ChestWindow_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Space
                SLabel.Hide()
                SLabel1.Hide()
                SLabel2.Hide()
                SLabel3.Hide()
                SLabeln1.Hide()
                SLabeln2.Hide()
                SLabeln3.Hide()
                BlinkLabel.Hide()
                Sboard.Hide()
                player.Show()
                Item.Show()
                item2.Show()
                'Just In Case or added extra code
                If Label2.Text = 10 Then
                    Lvl1.Enabled = False

                End If
                If Label2.Text = 20 Then
                    'add new song
                    lvl2.Enabled = False
                    Dragon.Show()
                    Dragon.Location = New Point(160, 99)
                End If
                If Label2.Text = 30 Then
                    'add new song
                    lvl3.Enabled = False

                End If
                If Label2.Text = 40 Then
                    'add new song
                    lvl4.Enabled = False

                End If
                If Label2.Text = 50 Then
                    'add new song
                    lvl5.Enabled = False

                End If
                Music.Ctlcontrols.stop()
        End Select
    End Sub
    Public Function RandomNumber(ByVal MaxNumber As Integer, _
        Optional ByVal MinNumber As Integer = 0) As Integer

        'initialize random number generator
        Dim r As New Random(System.DateTime.Now.Millisecond)

        'if passed incorrect arguments, swap them
        'can also throw exception or return 0

        If MinNumber > MaxNumber Then
            Dim t As Integer = MinNumber
            MinNumber = MaxNumber
            MaxNumber = t
        End If

        Return r.Next(MinNumber, MaxNumber)

    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartGame.Click
        Title.Hide()
        Button5.Hide()
        Button3.Hide()
        StartGame.Hide()
        Item.Show()
        item2.Show()
        player.Show()
        Me.Hide()
        Me.Show()
        Label1.Show()
        Label2.Show()
        Label4.Show()
        Label3.Show()
        'add levels here
        Lvl1.Enabled = True
        lvl2.Enabled = True
        lvl3.Enabled = True
        lvl4.Enabled = True
        lvl5.Enabled = True
        Blinker.Enabled = True
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Music.Ctlcontrols.stop()
        Credits.Show()
    End Sub
    Private Sub BlinkLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlinkLabel.Click
        'not click Blink Label
        'and press space to restart with new back ground and high level enemys
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lvl1.Tick
        'level 1
        If Label2.Text = 10 Then
            Lvl1.Enabled = False
            SLabel.Show()
            SLabel1.Show()
            SLabel2.Show()
            SLabel3.Show()
            SLabeln1.Show()
            SLabeln2.Show()
            SLabeln3.Show()
            BlinkLabel.Show()
            Sboard.Show()
            player.Hide()
            Item.Hide()
            item2.Hide()
            SLabeln1.Text = Label2.Text
            Sboard.Dock = DockStyle.Fill
            Sboard.Location = New Point(177, 114)
            Music.URL = "music\song 2.wav"
            Music.Ctlcontrols.play()
        End If
        If Label2.Text = 10 Then
            SLabeln2.Text += 1
            SLabeln3.Text += 10
        End If
        If BlinkLabel.Visible = True Then
            BlinkLabel.Visible = False
        Else
            If BlinkLabel.Visible = False Then
                BlinkLabel.Visible = True
            End If
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvl2.Tick
        'level 2
        If Label2.Text = 20 Then
            Monsta.Enabled = True
            lvl2.Enabled = False
            'BG Image
            Me.BackgroundImage = Global.game_menu.My.Resources.Resources.title2
            SLabel.Show()
            SLabel1.Show()
            SLabel2.Show()
            SLabel3.Show()
            SLabeln1.Show()
            SLabeln2.Show()
            SLabeln3.Show()
            BlinkLabel.Show()
            Sboard.Show()
            player.Hide()
            Item.Hide()
            item2.Hide()
            Dragon.Hide()
            SLabeln1.Text = Label2.Text
            Sboard.Dock = DockStyle.Fill
            Sboard.Location = New Point(177, 114)
            Music.URL = "music\song 2.wav"
            Music.Ctlcontrols.play()
        End If
        If Label2.Text = 20 Then
            SLabeln2.Text += 1
            SLabeln3.Text += 10
        End If
    End Sub
    Private Sub lvl3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvl3.Tick
        'Level 3
        If Label2.Text = 30 Then
            Monsta.Enabled = False
            lvl3.Enabled = False
            'BG Image
            Me.BackgroundImage = Global.game_menu.My.Resources.Resources.Main_Title_menu
            SLabel.Show()
            SLabel1.Show()
            SLabel2.Show()
            SLabel3.Show()
            SLabeln1.Show()
            SLabeln2.Show()
            SLabeln3.Show()
            BlinkLabel.Show()
            Sboard.Show()
            player.Hide()
            Item.Hide()
            item2.Hide()
            Dragon.Hide()
            SLabeln1.Text = Label2.Text
            Sboard.Dock = DockStyle.Fill
            Sboard.Location = New Point(177, 114)
            Music.URL = "music\song 2.wav"
            Music.Ctlcontrols.play()
        End If
        If Label2.Text = 30 Then
            SLabeln2.Text += 1
            SLabeln3.Text += 10
        End If
    End Sub
    Private Sub lvl4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvl4.Tick
        'Level 4
        If Label2.Text = 40 Then
            lvl4.Enabled = False
            'BG Image
            Me.BackgroundImage = Global.game_menu.My.Resources.Resources.smenu
            SLabel.Show()
            SLabel1.Show()
            SLabel2.Show()
            SLabel3.Show()
            SLabeln1.Show()
            SLabeln2.Show()
            SLabeln3.Show()
            BlinkLabel.Show()
            Sboard.Show()
            player.Hide()
            Dragon.Hide()
            Item.Hide()
            item2.Hide()
            SLabeln1.Text = Label2.Text
            Sboard.Dock = DockStyle.Fill
            Sboard.Location = New Point(177, 114)
            Music.URL = "music\song 2.wav"
            Music.Ctlcontrols.play()
        End If
        If Label2.Text = 40 Then
            SLabeln2.Text += 1
            SLabeln3.Text += 10
        End If
    End Sub
    Private Sub lvl5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvl5.Tick
        'Level 5
        If Label2.Text = 50 Then
            lvl5.Enabled = False
            'BG Image
            Me.BackgroundImage = Global.game_menu.My.Resources.Resources.title2
            SLabel.Show()
            SLabel1.Show()
            SLabel2.Show()
            SLabel3.Show()
            SLabeln1.Show()
            SLabeln2.Show()
            SLabeln3.Show()
            BlinkLabel.Show()
            Sboard.Show()
            Dragon.Hide()
            player.Hide()
            Item.Hide()
            item2.Hide()
            SLabeln1.Text = Label2.Text
            Sboard.Dock = DockStyle.Fill
            Sboard.Location = New Point(177, 114)
            Music.URL = "music\song 2.wav"
            Music.Ctlcontrols.play()
        End If
        If Label2.Text = 50 Then
            SLabeln2.Text += 1
            SLabeln3.Text += 10
        End If
    End Sub
    Private Sub Monsta_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monsta.Tick
        lvl2.Interval = Spawn.Value
        Dragon.Left = Dragon.Left - 20
        If Dragon.Left < 0 - Dragon.Width Then
            Dragon.Left = Me.Width
        End If
    End Sub
    Private Sub Dragon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dragon.Click
        Dragon.Hide()
        Label4.Text += 1
    End Sub
    Private Sub Blinker_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blinker.Tick
        If BlinkLabel.Visible = True Then
            BlinkLabel.Visible = False
        Else
            If BlinkLabel.Visible = False Then
                BlinkLabel.Visible = True
            End If
        End If
    End Sub
End Class
