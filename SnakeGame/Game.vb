Imports MySql.Data.MySqlClient
Public Class Game


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        create_head()
        'tm_snakeMover.Start()
        create_mouse()
        TxtUsername.Text = textusername
    End Sub

#Region "Snake Stuff"
    Dim snake(1000) As PictureBox
    Dim length_of_snake As Integer = -1
    Dim left_right_mover As Integer = 0
    Dim up_down_mover As Integer = 0
    Dim score As Integer = 0
    Dim pesan As String
    Dim r As New Random

    Private Sub create_head()
        length_of_snake += 1

        snake(length_of_snake) = New PictureBox
        With snake(length_of_snake)
            .Height = 10
            .Width = 10
            .BackColor = Color.White
            .Top = (pb_field.Top + pb_field.Bottom) / 2
            .Left = (pb_field.Left + pb_field.Right) / 2
        End With
        Me.Controls.Add(snake(length_of_snake))
        snake(length_of_snake).BringToFront()

        lengthenSnake()
        lengthenSnake()

    End Sub

    Private Sub lengthenSnake()
        length_of_snake += 1
        snake(length_of_snake) = New PictureBox
        With snake(length_of_snake)
            .Height = 10
            .Width = 10
            .BackColor = Color.Purple
            .Top = snake(length_of_snake - 1).Top
            .Left = snake(length_of_snake - 1).Left + 10
        End With
        Me.Controls.Add(snake(length_of_snake))
        snake(length_of_snake).BringToFront()
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        tm_snakeMover.Start()
        Select Case e.KeyChar
            Case "a"
                left_right_mover = -10
                up_down_mover = 0
            Case "d"
                left_right_mover = 10
                up_down_mover = 0
            Case "w"
                up_down_mover = -10
                left_right_mover = 0
            Case "s"
                up_down_mover = 10
                left_right_mover = 0
        End Select
    End Sub

    Private Sub tm_snakeMover_Tick(sender As Object, e As EventArgs) Handles tm_snakeMover.Tick

        For i = length_of_snake To 1 Step -1
            snake(i).Top = snake(i - 1).Top
            snake(i).Left = snake(i - 1).Left


        Next
        snake(0).Top += up_down_mover
        snake(0).Left += left_right_mover

        collide_With_walls()
        collide_with_mouse()
        collide_with_self()

    End Sub

    Private Sub collide_with_self()
        For i = 1 To length_of_snake
            If snake(0).Bounds.IntersectsWith(snake(i).Bounds) Then
                tm_snakeMover.Stop()
                Call Koneksi()
                pesan = MsgBox("Your = " & score, MessageBoxIcon.Error + vbYesNo)
                If pesan = vbYes Then
                    cmd = New MySqlCommand("INSERT INTO highscore(username, score) VALUES('" & TxtUsername.Text & "', '" & TxtScore.Text & "')", conn)
                    cmd.ExecuteNonQuery()
                    Me.Close()
                    highscore.Show()
                Else
                    cmd = New MySqlCommand("INSERT INTO highscore(username, score) VALUES('" & TxtUsername.Text & "', '" & TxtScore.Text & "')", conn)
                    cmd.ExecuteNonQuery()
                    Me.Close()
                    Menuvb.Show()
                End If
            End If
        Next
    End Sub


#End Region

#Region "Collission"

    Private Sub collide_With_walls()
        If snake(0).Left < pb_field.Left Then
            tm_snakeMover.Stop()
            Call Koneksi()
            pesan = MsgBox("Your = " & score, MessageBoxIcon.Error + vbYesNo)
            If pesan = vbYes Then
                cmd = New MySqlCommand("INSERT INTO highscore(username, score) VALUES('" & TxtUsername.Text & "', '" & TxtScore.Text & "')", conn)
                cmd.ExecuteNonQuery()
                Me.Close()
                highscore.Show()
            Else
                cmd = New MySqlCommand("INSERT INTO highscore(username, score) VALUES('" & TxtUsername.Text & "', '" & TxtScore.Text & "')", conn)
                cmd.ExecuteNonQuery()
                Me.Close()
                Menuvb.Show()
            End If
        End If

        If snake(0).Right > pb_field.Right Then
            Call Koneksi()
            pesan = MsgBox("Your = " & score, MessageBoxIcon.Error + vbYesNo)
            If pesan = vbYes Then
                cmd = New MySqlCommand("INSERT INTO highscore(username, score) VALUES('" & TxtUsername.Text & "', '" & TxtScore.Text & "')", conn)
                cmd.ExecuteNonQuery()
                Me.Close()
                highscore.Show()
            Else
                cmd = New MySqlCommand("INSERT INTO highscore(username, score) VALUES('" & TxtUsername.Text & "', '" & TxtScore.Text & "')", conn)
                cmd.ExecuteNonQuery()
                Me.Close()
                Menuvb.Show()
            End If
        End If

        If snake(0).Top < pb_field.Top Then
            tm_snakeMover.Stop()
            Call Koneksi()
            pesan = MsgBox("Your = " & score, MessageBoxIcon.Error + vbYesNo)
            If pesan = vbYes Then
                cmd = New MySqlCommand("INSERT INTO highscore(username, score) VALUES('" & TxtUsername.Text & "', '" & TxtScore.Text & "')", conn)
                cmd.ExecuteNonQuery()
                Me.Close()
                highscore.Show()
            Else
                cmd = New MySqlCommand("INSERT INTO highscore(username, score) VALUES('" & TxtUsername.Text & "', '" & TxtScore.Text & "')", conn)
                cmd.ExecuteNonQuery()
                Me.Close()
                Menuvb.Show()
            End If
        End If

        If snake(0).Bottom > pb_field.Bottom Then
            tm_snakeMover.Stop()
            Call Koneksi()
            pesan = MsgBox("Your = " & score, MessageBoxIcon.Error + vbYesNo)
            If pesan = vbYes Then
                cmd = New MySqlCommand("INSERT INTO highscore(username, score) VALUES('" & TxtUsername.Text & "', '" & TxtScore.Text & "')", conn)
                cmd.ExecuteNonQuery()
                Me.Close()
                highscore.Show()
            Else
                cmd = New MySqlCommand("INSERT INTO highscore(username, score) VALUES('" & TxtUsername.Text & "', '" & TxtScore.Text & "')", conn)
                cmd.ExecuteNonQuery()
                Me.Close()
                Menuvb.Show()
            End If
        End If


    End Sub

    Private Sub collide_with_mouse()

        If snake(0).Bounds.IntersectsWith(mouse.Bounds) Then
            lengthenSnake()
            mouse.Top = r.Next(pb_field.Top, pb_field.Bottom - 10)
            mouse.Left = r.Next(pb_field.Left, pb_field.Right - 10)
            score = score + 1
            TxtScore.Text = score
        End If
    End Sub
#End Region

#Region "Mouse Stuff"

    Dim mouse As PictureBox

    Private Sub create_mouse()
        mouse = New PictureBox
        With mouse
            .Width = 10
            .Height = 10
            .BackColor = Color.Red
            .Top = r.Next(pb_field.Top, pb_field.Bottom - 10)
            .Left = r.Next(pb_field.Left, pb_field.Right - 10)
        End With

        Me.Controls.Add(mouse)
        mouse.BringToFront()



    End Sub



    Private Sub TxtScore_TextChanged(sender As Object, e As EventArgs) Handles TxtScore.TextChanged, Label3.TextChanged, TxtUsername.TextChanged

    End Sub




#End Region
End Class
