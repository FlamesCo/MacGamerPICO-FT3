Public Class Form1
    Inherits Form

    Dim direction As Integer 'Direction Pacman is facing
    Dim mouth As Integer 'Mouth open or closed
    Dim dotcount As Integer 'Count of dots eaten
    Dim highscore As Integer 'Highscore

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Keydown event for Form1

        'Move Pacman
        If e.KeyCode = Keys.Right Then
            Pacman.Left += 5
        ElseIf e.KeyCode = Keys.Left Then
            Pacman.Left -= 5
        ElseIf e.KeyCode = Keys.Up Then
            Pacman.Top -= 5
        ElseIf e.KeyCode = Keys.Down Then
            Pacman.Top += 5
        End If

        'Close program
        If e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If

        'Change direction Pacman is facing
        If e.KeyCode = Keys.Right Then
            direction = 1
        ElseIf e.KeyCode = Keys.Left Then
            direction = 2
        ElseIf e.KeyCode = Keys.Up Then
            direction = 3
        ElseIf e.KeyCode = Keys.Down Then
            direction = 4
        End If

        'Open or close mouth
        If e.KeyCode = Keys.O Then
            mouth = 1
        ElseIf e.KeyCode = Keys.C Then
            mouth = 0
        End If

        'Ate a dot
        If Pacman.Bounds.IntersectsWith(Dot1.Bounds) Then
            Dot1.Top = 1000
            dotcount += 1
            Label1.Text = "Dots Eaten: " & dotcount
        End If

        'Ate a dot
        If Pacman.Bounds.IntersectsWith(Dot2.Bounds) Then
            Dot2.Top = 1000
            dotcount += 1
            Label1.Text = "Dots Eaten: " & dotcount
        End If

        'Ate a dot
        If Pacman.Bounds.IntersectsWith(Dot3.Bounds) Then
            Dot3.Top = 1000
            dotcount += 1
            Label1.Text = "Dots Eaten: " & dotcount
        End If

        'Ate a dot
        If Pacman.Bounds.IntersectsWith(Dot4.Bounds) Then
            Dot4.Top = 1000
            dotcount += 1
            Label1.Text = "Dots Eaten: " & dotcount
        End If

        'Ate a dot
        If Pacman.Bounds.IntersectsWith(Dot5.Bounds) Then
            Dot5.Top = 1000
            dotcount += 1
            Label1.Text = "Dots Eaten: " & dotcount
        End If

        'Ate a dot
        If Pacman.Bounds.IntersectsWith(Dot6.Bounds) Then
            Dot6.Top = 1000
            dotcount += 1
            Label1.Text = "Dots Eaten: " & dotcount
        End If

        'Ate a dot
        If Pacman.Bounds.IntersectsWith(Dot7.Bounds) Then
            Dot7.Top = 1000
            dotcount += 1
            Label1.Text = "Dots Eaten: " & dotcount
        End If

        'Ate a dot
        If Pacman.Bounds.IntersectsWith(Dot8.Bounds) Then
            Dot8.Top = 1000
            dotcount += 1
            Label1.Text = "Dots Eaten: " & dotcount
        End If

        'Ate a dot
        If Pacman.Bounds.IntersectsWith(Dot9.Bounds) Then
            Dot9.Top = 1000
            dotcount += 1
            Label1.Text = "Dots Eaten: " & dotcount
        End If

        'Ate a dot
        If Pacman.Bounds.IntersectsWith(Dot10.Bounds) Then
            Dot10.Top = 1000
            dotcount += 1
            Label1.Text = "Dots Eaten: " & dotcount
        End If

        'Ate a dot
        If Pacman.Bounds.IntersectsWith(Dot11.Bounds) Then
            Dot11.Top = 1000
            dotcount += 1
            Label1.Text = "Dots Eaten: " & dotcount
        End If

        'Ate a dot
        If Pacman.Bounds.IntersectsWith(Dot12.Bounds) Then
            Dot12.Top = 1000
            dotcount += 1
            Label1.Text = "Dots Eaten: " & dotcount
        End If

        'Ate a dot
        If Pacman.Bounds.IntersectsWith(Dot13.Bounds) Then
            Dot13.Top = 1000
            dotcount += 1
            Label1.Text = "Dots Eaten: " & dotcount
        End If

        'Ate a dot
        If Pacman.Bounds.IntersectsWith(Dot14.Bounds) Then
            Dot14.Top = 1000
            dotcount += 1
            Label1.Text = "Dots Eaten: " & dotcount
        End If

        'Ate a dot
        If Pacman.Bounds.IntersectsWith(Dot15.B)
