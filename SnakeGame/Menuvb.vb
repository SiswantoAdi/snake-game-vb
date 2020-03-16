Public Class Menuvb
    Private Sub BtnComment_Click(sender As Object, e As EventArgs) Handles BtnComment.Click
        CommentGame.Show()
    End Sub

    Private Sub BtnHighscore_Click(sender As Object, e As EventArgs) Handles BtnHighscore.Click
        highscore.Show()
    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        SIGNUPorLOGIN.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hint.Show()
    End Sub
End Class