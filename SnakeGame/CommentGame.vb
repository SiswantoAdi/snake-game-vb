Imports MySql.Data.MySqlClient
Public Class CommentGame
    Private Sub CommentGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDGV()
        aturDGV()
    End Sub

    Sub aturDGV()
        With DGVcomment
            .Columns(0).Width = 50
            .Columns(1).Width = 70
            .Columns(2).Width = 350
            .Columns(0).HeaderText = "No"
            .Columns(1).HeaderText = "Username"
            .Columns(2).HeaderText = "Comment"
        End With
    End Sub

    Sub TampilDGV()
        Call Koneksi()
        da = New MySqlDataAdapter("SELECT * FROM comment", conn)
        ds = New DataSet
        da.Fill(ds, "comment")
        DGVcomment.DataSource = ds.Tables("comment")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginForComment.Show()

    End Sub
End Class