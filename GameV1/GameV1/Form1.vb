Public Class Form1

    Dim yoffset As Integer
    Dim r As New Random
    Dim score As Integer
    Sub RandMove(p As PictureBox)
        Dim x As Integer
        Dim y As Integer
        'x = r.Next(-10, 11)
        y = r.Next(-10, 11)
        MoveTo(p, x, y)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.R
                Mario.Image.RotateFlip(RotateFlipType.Rotate90FlipX)
                Me.Refresh()
                'Case Keys.W
                'MoveTo(Mario, 0, -5)
            Case Keys.S
                MoveTo(Mario, 0, 5)
            Case Keys.A
                MoveTo(Mario, -5, 0)
            Case Keys.D
                MoveTo(Mario, 5, 0)
            Case Keys.Space
                If Mario.Location.Y >= 352 Then
                    yoffset = 15
                End If
            Case Keys.Right
                BulletRightTimer.Enabled = True
                Bullet.Visible = True
                Bullet.Location = Mario.Location
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles BowserTimer.Tick
        chase(Bowser)
        RandMove(Bowser)
    End Sub
    Sub Move(p As PictureBox, x As Integer, y As Integer)
        p.Location = New Point(p.Location.X + x, p.Location.Y + y)
        If Collision(p, "wall") Then
            MsgBox("Game Over")
        End If
    End Sub

    Sub follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(Mario.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub

    Public Sub chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > Mario.Location.X Then
            x = -5
        Else
            x = 5
        End If
        MoveTo(p, x, 0)
        If p.Location.Y < Mario.Location.Y Then
            y = 5
        Else
            y = -5
        End If
        MoveTo(p, x, y)
    End Sub

    Function Collision(p As PictureBox, t As String, Optional ByRef other As Object = vbNull)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If obj.Visible AndAlso p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
                other = obj
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function

    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If

        If p.Name.Contains("Bullet") And Collision(p, "Bowser") Then
            p.Visible = False
            'Bowser.Visible = False
            Bowser.Location = BowserAway.Location

        End If

        If p.Name = "Mario" And Collision(p, "WIN") Then
            Me.BackColor = Color.Green
            Return
        End If

    End Sub



    Private Sub BulletRightTimer_Tick(sender As Object, e As EventArgs) Handles BulletRightTimer.Tick
        MoveTo(Bullet, 10, 0)
        Bullet.Image.RotateFlip(RotateFlipType.Rotate90FlipX)
    End Sub

    Private Sub GravityTimer_Tick(sender As Object, e As EventArgs) Handles GravityTimer.Tick
        MoveTo(Mario, 0, 5 - yoffset)
        If yoffset > 0 Then
            yoffset = yoffset - 2
        End If
    End Sub
End Class
