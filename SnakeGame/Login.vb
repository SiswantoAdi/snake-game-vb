Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SignUp.Show()
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
                textusername = TxtUsername.Text
                Game.Show()
                Me.Close()
            Else
                rd.Close()
                MessageBox.Show("Login gagal, username atau Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPass.Text = ""
                txtUsername.Text = ""
                txtUsername.Focus()
            End If
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class