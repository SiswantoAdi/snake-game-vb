Imports MySql.Data.MySqlClient
Public Class LoginForComment
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SignUpForComment.Show()
        Me.Hide()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Call Koneksi()
            Dim str As String
            str = "select * from user where username = '" & TxtUsername.Text & "' and password = '" & TxtPass.Text & "'"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            If rd.HasRows Then

                If Button1.Text = "Send" Then
                    Call Koneksi()
                    cmd = New MySqlCommand("insert into comment(username, comment) values ('" & TxtUsername.Text & "','" & TextBox1.Text & "')", conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Comment berhasil dikirim")
                    CommentGame.TampilDGV()
                    CommentGame.aturDGV()
                    Me.Close()
                    CommentGame.Show()
                End If

                Me.Close()
            Else
                rd.Close()
                MessageBox.Show("Mengirim gagal, username atau Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtPass.Text = ""
                TxtUsername.Text = ""
                TextBox1.Text = ""
                TxtUsername.Focus()
            End If
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoginForComment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class