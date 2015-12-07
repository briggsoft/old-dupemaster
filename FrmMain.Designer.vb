<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Button3 = New System.Windows.Forms.Button
        Me.StartGame = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Title = New System.Windows.Forms.PictureBox
        Me.player = New System.Windows.Forms.PictureBox
        Me.Item = New System.Windows.Forms.PictureBox
        Me.item2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SLabel = New System.Windows.Forms.Label
        Me.BlinkLabel = New System.Windows.Forms.Label
        Me.SLabel1 = New System.Windows.Forms.Label
        Me.SLabeln1 = New System.Windows.Forms.Label
        Me.SLabeln2 = New System.Windows.Forms.Label
        Me.SLabeln3 = New System.Windows.Forms.Label
        Me.SLabel2 = New System.Windows.Forms.Label
        Me.SLabel3 = New System.Windows.Forms.Label
        Me.Sboard = New System.Windows.Forms.Panel
        Me.Music = New AxWMPLib.AxWindowsMediaPlayer
        Me.Lvl1 = New System.Windows.Forms.Timer(Me.components)
        Me.lvl2 = New System.Windows.Forms.Timer(Me.components)
        Me.lvl4 = New System.Windows.Forms.Timer(Me.components)
        Me.lvl5 = New System.Windows.Forms.Timer(Me.components)
        Me.lvl3 = New System.Windows.Forms.Timer(Me.components)
        Me.Dragon = New System.Windows.Forms.PictureBox
        Me.Spawn = New System.Windows.Forms.NumericUpDown
        Me.Monsta = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Blinker = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sboard.SuspendLayout()
        CType(Me.Music, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dragon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spawn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Dungeon", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Cyan
        Me.Button3.Location = New System.Drawing.Point(652, 466)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 44)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "[Exit]"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'StartGame
        '
        Me.StartGame.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartGame.BackColor = System.Drawing.Color.Transparent
        Me.StartGame.FlatAppearance.BorderSize = 0
        Me.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartGame.Font = New System.Drawing.Font("Dungeon", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartGame.ForeColor = System.Drawing.Color.Cyan
        Me.StartGame.Location = New System.Drawing.Point(12, 468)
        Me.StartGame.Name = "StartGame"
        Me.StartGame.Size = New System.Drawing.Size(115, 41)
        Me.StartGame.TabIndex = 0
        Me.StartGame.Text = "[Start]"
        Me.StartGame.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Dungeon", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Cyan
        Me.Button5.Location = New System.Drawing.Point(353, 471)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(115, 33)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "[Credits]"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Title.Image = Global.game_menu.My.Resources.Resources.Ntitle1
        Me.Title.Location = New System.Drawing.Point(-6, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(716, 98)
        Me.Title.TabIndex = 1
        Me.Title.TabStop = False
        '
        'player
        '
        Me.player.BackColor = System.Drawing.Color.Blue
        Me.player.Location = New System.Drawing.Point(742, 470)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(38, 33)
        Me.player.TabIndex = 2
        Me.player.TabStop = False
        '
        'Item
        '
        Me.Item.BackColor = System.Drawing.Color.Lime
        Me.Item.Location = New System.Drawing.Point(749, 104)
        Me.Item.Name = "Item"
        Me.Item.Size = New System.Drawing.Size(31, 33)
        Me.Item.TabIndex = 3
        Me.Item.TabStop = False
        '
        'item2
        '
        Me.item2.BackColor = System.Drawing.Color.Lime
        Me.item2.Location = New System.Drawing.Point(12, 104)
        Me.item2.Name = "item2"
        Me.item2.Size = New System.Drawing.Size(31, 33)
        Me.item2.TabIndex = 3
        Me.item2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Dungeon", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(0, 492)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Score ="
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Dungeon", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(66, 492)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "0"
        '
        'SLabel
        '
        Me.SLabel.AutoSize = True
        Me.SLabel.Font = New System.Drawing.Font("Dungeon", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SLabel.Location = New System.Drawing.Point(247, 119)
        Me.SLabel.Name = "SLabel"
        Me.SLabel.Size = New System.Drawing.Size(289, 35)
        Me.SLabel.TabIndex = 0
        Me.SLabel.Text = "You Leveled Up!"
        '
        'BlinkLabel
        '
        Me.BlinkLabel.AutoSize = True
        Me.BlinkLabel.Font = New System.Drawing.Font("Dungeon", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlinkLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BlinkLabel.Location = New System.Drawing.Point(182, 363)
        Me.BlinkLabel.Name = "BlinkLabel"
        Me.BlinkLabel.Size = New System.Drawing.Size(440, 35)
        Me.BlinkLabel.TabIndex = 0
        Me.BlinkLabel.Text = "Press Space to Continue"
        '
        'SLabel1
        '
        Me.SLabel1.AutoSize = True
        Me.SLabel1.Font = New System.Drawing.Font("Dungeon", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SLabel1.Location = New System.Drawing.Point(292, 198)
        Me.SLabel1.Name = "SLabel1"
        Me.SLabel1.Size = New System.Drawing.Size(64, 21)
        Me.SLabel1.TabIndex = 0
        Me.SLabel1.Text = "Level"
        '
        'SLabeln1
        '
        Me.SLabeln1.AutoSize = True
        Me.SLabeln1.Font = New System.Drawing.Font("Dungeon", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabeln1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SLabeln1.Location = New System.Drawing.Point(421, 293)
        Me.SLabeln1.Name = "SLabeln1"
        Me.SLabeln1.Size = New System.Drawing.Size(24, 21)
        Me.SLabeln1.TabIndex = 0
        Me.SLabeln1.Text = "0"
        '
        'SLabeln2
        '
        Me.SLabeln2.AutoSize = True
        Me.SLabeln2.Font = New System.Drawing.Font("Dungeon", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabeln2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SLabeln2.Location = New System.Drawing.Point(421, 198)
        Me.SLabeln2.Name = "SLabeln2"
        Me.SLabeln2.Size = New System.Drawing.Size(24, 21)
        Me.SLabeln2.TabIndex = 0
        Me.SLabeln2.Text = "0"
        '
        'SLabeln3
        '
        Me.SLabeln3.AutoSize = True
        Me.SLabeln3.Font = New System.Drawing.Font("Dungeon", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabeln3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SLabeln3.Location = New System.Drawing.Point(421, 246)
        Me.SLabeln3.Name = "SLabeln3"
        Me.SLabeln3.Size = New System.Drawing.Size(31, 21)
        Me.SLabeln3.TabIndex = 0
        Me.SLabeln3.Text = "10"
        '
        'SLabel2
        '
        Me.SLabel2.AutoSize = True
        Me.SLabel2.Font = New System.Drawing.Font("Dungeon", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SLabel2.Location = New System.Drawing.Point(269, 246)
        Me.SLabel2.Name = "SLabel2"
        Me.SLabel2.Size = New System.Drawing.Size(117, 21)
        Me.SLabel2.TabIndex = 0
        Me.SLabel2.Text = "Next Level"
        '
        'SLabel3
        '
        Me.SLabel3.AutoSize = True
        Me.SLabel3.Font = New System.Drawing.Font("Dungeon", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SLabel3.Location = New System.Drawing.Point(269, 293)
        Me.SLabel3.Name = "SLabel3"
        Me.SLabel3.Size = New System.Drawing.Size(135, 21)
        Me.SLabel3.TabIndex = 0
        Me.SLabel3.Text = "Score so far"
        '
        'Sboard
        '
        Me.Sboard.BackColor = System.Drawing.Color.Yellow
        Me.Sboard.Controls.Add(Me.SLabel3)
        Me.Sboard.Controls.Add(Me.SLabel2)
        Me.Sboard.Controls.Add(Me.SLabeln3)
        Me.Sboard.Controls.Add(Me.SLabeln2)
        Me.Sboard.Controls.Add(Me.SLabeln1)
        Me.Sboard.Controls.Add(Me.SLabel1)
        Me.Sboard.Controls.Add(Me.BlinkLabel)
        Me.Sboard.Controls.Add(Me.SLabel)
        Me.Sboard.Location = New System.Drawing.Point(773, 491)
        Me.Sboard.Name = "Sboard"
        Me.Sboard.Size = New System.Drawing.Size(446, 317)
        Me.Sboard.TabIndex = 4
        '
        'Music
        '
        Me.Music.Enabled = True
        Me.Music.Location = New System.Drawing.Point(749, 491)
        Me.Music.Name = "Music"
        Me.Music.OcxState = CType(resources.GetObject("Music.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Music.Size = New System.Drawing.Size(18, 27)
        Me.Music.TabIndex = 6
        '
        'Lvl1
        '
        '
        'lvl2
        '
        '
        'lvl4
        '
        '
        'lvl5
        '
        '
        'lvl3
        '
        '
        'Dragon
        '
        Me.Dragon.BackColor = System.Drawing.Color.Red
        Me.Dragon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dragon.Location = New System.Drawing.Point(773, 66)
        Me.Dragon.Name = "Dragon"
        Me.Dragon.Size = New System.Drawing.Size(160, 32)
        Me.Dragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dragon.TabIndex = 7
        Me.Dragon.TabStop = False
        '
        'Spawn
        '
        Me.Spawn.Location = New System.Drawing.Point(773, 468)
        Me.Spawn.Name = "Spawn"
        Me.Spawn.Size = New System.Drawing.Size(18, 20)
        Me.Spawn.TabIndex = 8
        Me.Spawn.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Monsta
        '
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Dungeon", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(110, 492)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kills ="
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Dungeon", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(152, 492)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "0"
        '
        'Blinker
        '
        Me.Blinker.Interval = 350
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.game_menu.My.Resources.Resources.Main_Title_menu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 515)
        Me.Controls.Add(Me.Spawn)
        Me.Controls.Add(Me.Dragon)
        Me.Controls.Add(Me.Music)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Sboard)
        Me.Controls.Add(Me.item2)
        Me.Controls.Add(Me.Item)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.StartGame)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackSpace<< The Adventures of Blu Square"
        CType(Me.Title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sboard.ResumeLayout(False)
        Me.Sboard.PerformLayout()
        CType(Me.Music, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dragon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spawn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents StartGame As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.PictureBox
    Friend WithEvents player As System.Windows.Forms.PictureBox
    Friend WithEvents Item As System.Windows.Forms.PictureBox
    Friend WithEvents item2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SLabel As System.Windows.Forms.Label
    Friend WithEvents BlinkLabel As System.Windows.Forms.Label
    Friend WithEvents SLabel1 As System.Windows.Forms.Label
    Friend WithEvents SLabeln1 As System.Windows.Forms.Label
    Friend WithEvents SLabeln2 As System.Windows.Forms.Label
    Friend WithEvents SLabeln3 As System.Windows.Forms.Label
    Friend WithEvents SLabel2 As System.Windows.Forms.Label
    Friend WithEvents SLabel3 As System.Windows.Forms.Label
    Friend WithEvents Sboard As System.Windows.Forms.Panel
    Friend WithEvents Music As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Lvl1 As System.Windows.Forms.Timer
    Friend WithEvents lvl2 As System.Windows.Forms.Timer
    Friend WithEvents lvl4 As System.Windows.Forms.Timer
    Friend WithEvents lvl5 As System.Windows.Forms.Timer
    Friend WithEvents lvl3 As System.Windows.Forms.Timer
    Friend WithEvents Dragon As System.Windows.Forms.PictureBox
    Friend WithEvents Spawn As System.Windows.Forms.NumericUpDown
    Friend WithEvents Monsta As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Blinker As System.Windows.Forms.Timer

End Class
