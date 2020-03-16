Imports MySql.Data.MySqlClient
Public Class SignUpForComment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Form tidak boleh kosong")
        ElseIf Button1.Text = "Sign Up" Then
            Call Koneksi()
            cmd = New MySqlCommand("insert into user(username, password) values ('" & TextBox1.Text & "','" & TextBox2.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Sign Up berhasil")
            Me.Close()
            LoginForComment.Show()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginForComment.Show()
    End Sub
End Class