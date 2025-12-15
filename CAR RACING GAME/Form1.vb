Imports System.Security.Authentication.ExtendedProtection

Public Class Form1
    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0

    Dim mudardirecao1 As Boolean
    Dim esquerda1 As Boolean

    Dim mudardirecao2 As Boolean
    Dim esquerda2 As Boolean

    Dim mudardirecao3 As Boolean
    Dim esquerda3 As Boolean

    Dim direcao1 As Integer = 0
    Dim direcao2 As Integer = 0
    Dim direcao3 As Integer = 0

    Dim duracao1 As Integer = 0
    Dim duracao2 As Integer = 0
    Dim duracao3 As Integer = 0

    Dim proximoMovimento1 As Integer = 0
    Dim proximoMovimento2 As Integer = 0
    Dim proximoMovimento3 As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.KeyPreview = True

        RoadMover.Stop()
        RaceMover1.Stop()
        RaceMover2.Stop()
        RaceMover3.Stop()

        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8

        Button2.Visible = True

        Randomize()

        proximoMovimento1 = CInt(Math.Ceiling(Rnd() * 300)) + 50
        proximoMovimento2 = CInt(Math.Ceiling(Rnd() * 300)) + 50
        proximoMovimento3 = CInt(Math.Ceiling(Rnd() * 300)) + 50

    End Sub

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next

        If score > 10 And score < 30 Then
            speed = 5
        End If
        If score > 30 And score < 50 Then
            speed = 6
        End If
        If score > 50 And score < 70 Then
            speed = 7
        End If
        If score > 100 Then
            speed = 9
        End If

        Label2.Text = "Speed " & speed
        If (car.Bounds.IntersectsWith(race1.Bounds)) Then
            endgame()
        End If
        If (car.Bounds.IntersectsWith(race2.Bounds)) Then
            endgame()
        End If
        If (car.Bounds.IntersectsWith(race3.Bounds)) Then
            endgame()
        End If
    End Sub

    Private Sub endgame()
        Button1.Visible = True
        Label3.Visible = True
        RoadMover.Stop()
        RaceMover1.Stop()
        RaceMover2.Stop()
        RaceMover3.Stop()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Right Then
            RightSide.Start()
        End If

        If e.KeyCode = Keys.Left Then
            LeftSide.Start()
        End If

        If e.KeyCode = Keys.Up Then
            UpSide.Start()
        End If

        If e.KeyCode = Keys.Down Then
            DownSide.Start()
        End If
    End Sub

    Private Sub RightSide_Tick(sender As Object, e As EventArgs) Handles RightSide.Tick
        If (car.Location.X < 287) Then
            car.Left += 5
        End If
    End Sub

    Private Sub LeftSide_Tick(sender As Object, e As EventArgs) Handles LeftSide.Tick
        If (car.Location.X > 0) Then
            car.Left -= 5
        End If
    End Sub
    Private Sub UpSide_Tick(sender As Object, e As EventArgs) Handles UpSide.Tick
        If (car.Location.Y > 0) Then
            car.Top -= 5
        End If
    End Sub

    Private Sub DownSide_Tick(sender As Object, e As EventArgs) Handles DownSide.Tick
        If (car.Location.Y < 370) Then
            car.Top += 5
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Right Then
            RightSide.Stop()
        End If

        If e.KeyCode = Keys.Left Then
            LeftSide.Stop()
        End If

        If e.KeyCode = Keys.Up Then
            UpSide.Stop()
        End If

        If e.KeyCode = Keys.Down Then
            DownSide.Stop()
        End If
    End Sub

    Private Sub RaceMover1_Tick(sender As Object, e As EventArgs) Handles RaceMover1.Tick
        race1.Top += speed / 2

        If duracao1 > 0 Then

            race1.Left += direcao1 * speed
            duracao1 -= 1
        End If

        If race1.Left < 0 Then race1.Left = 0
        If race1.Left > 280 Then race1.Left = 280

        If race1.Bounds.IntersectsWith(race2.Bounds) Then

            duracao1 = 0

            If direcao1 < 0 Then race1.Left -= 5
            If direcao1 > 0 Then race1.Left += 5

        End If

        If race1.Bounds.IntersectsWith(race3.Bounds) Then

            duracao1 = 0

            If direcao1 < 0 Then race1.Left -= 5
            If direcao1 > 0 Then race1.Left += 5

        End If

        If race1.Top >= Me.Height Then

            score += 1
            Label1.Text = "Score " & score

            race1.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + race1.Height)
            race1.Left = CInt(Math.Ceiling(Rnd() * 50)) + 0

            mudardirecao1 = (Rnd() < 0.5)
            esquerda1 = (Rnd() < 0.5)

            direcao1 = 0
            duracao1 = 0
            proximoMovimento1 = CInt(Math.Ceiling(Rnd() * 300)) + 50

        End If
    End Sub

    Private Sub RaceMover2_Tick(sender As Object, e As EventArgs) Handles RaceMover2.Tick
        race2.Top += speed / 3

        If duracao2 > 0 Then

            race2.Left += direcao2 * speed
            duracao2 -= 1

        End If

        If race2.Left < 0 Then race2.Left = 0
        If race2.Left > 280 Then race2.Left = 280

        If race2.Bounds.IntersectsWith(race1.Bounds) Then

            duracao2 = 0

            If direcao2 < 0 Then race2.Left -= 5
            If direcao2 > 0 Then race2.Left += 5

        End If

        If race2.Bounds.IntersectsWith(race3.Bounds) Then

            duracao2 = 0

            If direcao2 < 0 Then race2.Left -= 5
            If direcao2 > 0 Then race2.Left += 5

        End If

        If race2.Top >= Me.Height Then

            score += 1
            Label1.Text = "Score " & score

            race2.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + race2.Height)
            race2.Left = CInt(Math.Ceiling(Rnd() * 50)) + 100

            mudardirecao2 = (Rnd() < 0.5)
            esquerda2 = (Rnd() < 0.5)

            direcao2 = 0
            duracao2 = 0
            proximoMovimento2 = CInt(Math.Ceiling(Rnd() * 300)) + 50

        End If
    End Sub

    Private Sub RaceMover3_Tick(sender As Object, e As EventArgs) Handles RaceMover3.Tick
        race3.Top += speed * 1 / 2

        If duracao3 > 0 Then

            race3.Left += direcao3 * speed
            duracao3 -= 1

        End If

        If race3.Left < 0 Then race3.Left = 0
        If race3.Left > 290 Then race3.Left = 290

        If race3.Bounds.IntersectsWith(race1.Bounds) Then
            duracao3 = 0

            If direcao3 < 0 Then race3.Left -= 5
            If direcao3 > 0 Then race3.Left += 5

        End If

        If race3.Bounds.IntersectsWith(race2.Bounds) Then
            duracao3 = 0

            If direcao3 < 0 Then race3.Left -= 5
            If direcao3 > 0 Then race3.Left += 5

        End If

        If race3.Top >= Me.Height Then

            score += 1
            Label1.Text = "Score " & score

            race3.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + race3.Height)
            race3.Left = CInt(Math.Ceiling(Rnd() * 120)) + 180

            mudardirecao3 = (Rnd() < 0.5)
            esquerda3 = (Rnd() < 0.5)

            direcao3 = 0
            duracao3 = 0
            proximoMovimento3 = CInt(Math.Ceiling(Rnd() * 300)) + 50

        End If
    End Sub

    Private Sub RaceMoverSide1_Tick(sender As Object, e As EventArgs) Handles RaceMoverSide1.Tick
        If mudardirecao1 = True AndAlso duracao1 = 0 Then

            If race1.Top >= proximoMovimento1 Then

                direcao1 = CInt(Math.Floor(Rnd() * 3)) - 1
                duracao1 = CInt(Math.Ceiling(Rnd() * 100)) + 40
                proximoMovimento1 = race1.Top + CInt(Math.Ceiling(Rnd() * 300)) + 50

            End If

        End If
    End Sub

    Private Sub RaceMoverSide2_Tick(sender As Object, e As EventArgs) Handles RaceMoverSide2.Tick
        If mudardirecao2 = True AndAlso duracao2 = 0 Then

            If race2.Top >= proximoMovimento2 Then

                direcao2 = CInt(Math.Floor(Rnd() * 3)) - 1
                duracao2 = CInt(Math.Ceiling(Rnd() * 100)) + 40
                proximoMovimento2 = race2.Top + CInt(Math.Ceiling(Rnd() * 300)) + 50

            End If

        End If
    End Sub

    Private Sub RaceMoverSide3_Tick(sender As Object, e As EventArgs) Handles RaceMoverSide3.Tick
        If mudardirecao3 = True AndAlso duracao3 = 0 Then

            If race3.Top >= proximoMovimento3 Then

                direcao3 = CInt(Math.Floor(Rnd() * 3)) - 1
                duracao3 = CInt(Math.Ceiling(Rnd() * 100)) + 40
                proximoMovimento3 = race3.Top + CInt(Math.Ceiling(Rnd() * 300)) + 50

            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        score = 0
        Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Visible = False

        RoadMover.Start()
        RaceMover1.Start()
        RaceMover2.Start()
        RaceMover3.Start()
    End Sub

End Class