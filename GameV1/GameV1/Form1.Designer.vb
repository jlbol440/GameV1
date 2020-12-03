<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Mario = New System.Windows.Forms.PictureBox()
        Me.BowserTimer = New System.Windows.Forms.Timer(Me.components)
        Me.WallPictureBox4 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox3 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Bowser = New System.Windows.Forms.PictureBox()
        Me.BulletRightTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.WIN = New System.Windows.Forms.PictureBox()
        Me.BulletLeftTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BulletUpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BulletDownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GravityTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BowserAway = New System.Windows.Forms.PictureBox()
        Me.BottomPipe = New System.Windows.Forms.PictureBox()
        Me.WinPipe = New System.Windows.Forms.PictureBox()
        Me.WallBottomPipe = New System.Windows.Forms.PictureBox()
        Me.WallPipe = New System.Windows.Forms.PictureBox()
        CType(Me.Mario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bowser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BowserAway, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomPipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinPipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallBottomPipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mario
        '
        Me.Mario.BackColor = System.Drawing.Color.Transparent
        Me.Mario.Image = Global.GameV1.My.Resources.Resources.unnamed1
        Me.Mario.Location = New System.Drawing.Point(157, 364)
        Me.Mario.Name = "Mario"
        Me.Mario.Size = New System.Drawing.Size(30, 41)
        Me.Mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mario.TabIndex = 1
        Me.Mario.TabStop = False
        '
        'BowserTimer
        '
        Me.BowserTimer.Enabled = True
        '
        'WallPictureBox4
        '
        Me.WallPictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.WallPictureBox4.Location = New System.Drawing.Point(-3, 410)
        Me.WallPictureBox4.Name = "WallPictureBox4"
        Me.WallPictureBox4.Size = New System.Drawing.Size(805, 56)
        Me.WallPictureBox4.TabIndex = 2
        Me.WallPictureBox4.TabStop = False
        '
        'WallPictureBox3
        '
        Me.WallPictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.WallPictureBox3.Location = New System.Drawing.Point(797, -10)
        Me.WallPictureBox3.Name = "WallPictureBox3"
        Me.WallPictureBox3.Size = New System.Drawing.Size(10, 448)
        Me.WallPictureBox3.TabIndex = 3
        Me.WallPictureBox3.TabStop = False
        '
        'WallPictureBox1
        '
        Me.WallPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.WallPictureBox1.Location = New System.Drawing.Point(-3, -21)
        Me.WallPictureBox1.Name = "WallPictureBox1"
        Me.WallPictureBox1.Size = New System.Drawing.Size(10, 473)
        Me.WallPictureBox1.TabIndex = 4
        Me.WallPictureBox1.TabStop = False
        '
        'WallPictureBox2
        '
        Me.WallPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.WallPictureBox2.Location = New System.Drawing.Point(-3, -21)
        Me.WallPictureBox2.Name = "WallPictureBox2"
        Me.WallPictureBox2.Size = New System.Drawing.Size(805, 27)
        Me.WallPictureBox2.TabIndex = 5
        Me.WallPictureBox2.TabStop = False
        '
        'Bowser
        '
        Me.Bowser.BackColor = System.Drawing.Color.Transparent
        Me.Bowser.Image = Global.GameV1.My.Resources.Resources.ddijqpi_83384f99_cb62_43ea_9f60_0960f1965222
        Me.Bowser.Location = New System.Drawing.Point(452, 326)
        Me.Bowser.Name = "Bowser"
        Me.Bowser.Size = New System.Drawing.Size(84, 78)
        Me.Bowser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bowser.TabIndex = 6
        Me.Bowser.TabStop = False
        '
        'BulletRightTimer
        '
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.Color.Transparent
        Me.Bullet.Image = Global.GameV1.My.Resources.Resources.fireball_clipart_8_bit_1
        Me.Bullet.Location = New System.Drawing.Point(171, 268)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(29, 24)
        Me.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet.TabIndex = 7
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'WIN
        '
        Me.WIN.BackColor = System.Drawing.Color.Transparent
        Me.WIN.Location = New System.Drawing.Point(131, 101)
        Me.WIN.Name = "WIN"
        Me.WIN.Size = New System.Drawing.Size(15, 15)
        Me.WIN.TabIndex = 8
        Me.WIN.TabStop = False
        '
        'GravityTimer
        '
        Me.GravityTimer.Enabled = True
        '
        'BowserAway
        '
        Me.BowserAway.Location = New System.Drawing.Point(952, 209)
        Me.BowserAway.Name = "BowserAway"
        Me.BowserAway.Size = New System.Drawing.Size(100, 50)
        Me.BowserAway.TabIndex = 9
        Me.BowserAway.TabStop = False
        '
        'BottomPipe
        '
        Me.BottomPipe.BackColor = System.Drawing.Color.Transparent
        Me.BottomPipe.Location = New System.Drawing.Point(604, 352)
        Me.BottomPipe.Name = "BottomPipe"
        Me.BottomPipe.Size = New System.Drawing.Size(76, 61)
        Me.BottomPipe.TabIndex = 10
        Me.BottomPipe.TabStop = False
        Me.BottomPipe.Visible = False
        '
        'WinPipe
        '
        Me.WinPipe.Location = New System.Drawing.Point(661, 364)
        Me.WinPipe.Name = "WinPipe"
        Me.WinPipe.Size = New System.Drawing.Size(19, 40)
        Me.WinPipe.TabIndex = 11
        Me.WinPipe.TabStop = False
        '
        'WallBottomPipe
        '
        Me.WallBottomPipe.BackColor = System.Drawing.Color.Transparent
        Me.WallBottomPipe.Location = New System.Drawing.Point(604, 348)
        Me.WallBottomPipe.Name = "WallBottomPipe"
        Me.WallBottomPipe.Size = New System.Drawing.Size(76, 10)
        Me.WallBottomPipe.TabIndex = 12
        Me.WallBottomPipe.TabStop = False
        '
        'WallPipe
        '
        Me.WallPipe.BackColor = System.Drawing.Color.Transparent
        Me.WallPipe.Location = New System.Drawing.Point(676, 294)
        Me.WallPipe.Name = "WallPipe"
        Me.WallPipe.Size = New System.Drawing.Size(55, 120)
        Me.WallPipe.TabIndex = 13
        Me.WallPipe.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GameV1.My.Resources.Resources._1PeEfl
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 455)
        Me.Controls.Add(Me.WallPipe)
        Me.Controls.Add(Me.WallBottomPipe)
        Me.Controls.Add(Me.WinPipe)
        Me.Controls.Add(Me.BottomPipe)
        Me.Controls.Add(Me.BowserAway)
        Me.Controls.Add(Me.WIN)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.Bowser)
        Me.Controls.Add(Me.WallPictureBox2)
        Me.Controls.Add(Me.WallPictureBox1)
        Me.Controls.Add(Me.WallPictureBox3)
        Me.Controls.Add(Me.WallPictureBox4)
        Me.Controls.Add(Me.Mario)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Mario Shoots Bowser"
        CType(Me.Mario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bowser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BowserAway, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomPipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinPipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallBottomPipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Mario As PictureBox
    Friend WithEvents BowserTimer As Timer
    Friend WithEvents WallPictureBox4 As PictureBox
    Friend WithEvents WallPictureBox3 As PictureBox
    Friend WithEvents WallPictureBox1 As PictureBox
    Friend WithEvents WallPictureBox2 As PictureBox
    Friend WithEvents Bowser As PictureBox
    Friend WithEvents BulletRightTimer As Timer
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents WIN As PictureBox
    Friend WithEvents BulletLeftTimer As Timer
    Friend WithEvents BulletUpTimer As Timer
    Friend WithEvents BulletDownTimer As Timer
    Friend WithEvents GravityTimer As Timer
    Friend WithEvents BowserAway As PictureBox
    Friend WithEvents BottomPipe As PictureBox
    Friend WithEvents WinPipe As PictureBox
    Friend WithEvents WallBottomPipe As PictureBox
    Friend WithEvents WallPipe As PictureBox
End Class
