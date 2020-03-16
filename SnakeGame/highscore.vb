Imports MySql.Data.MySqlClient
Public Class highscore
    Private Sub highscore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tampilDGV()
    End Sub

    Sub aturDGV()
        DataGridView1.ColumnCount = 3
        With DataGridView1
            .Columns(0).Width = 50
            .Columns(1).Width = 70
            .Columns(2).Width = 50


        End With
    End Sub

    Sub AutoNumberRowsForGridView()

        If DataGridView1 IsNot Nothing Then

            Dim count As Integer = 0

            While (count <= (DataGridView1.Rows.Count - 2))

                DataGridView1.Rows(count).HeaderCell.Value = String.Format((count + 1).ToString(), "0")

                count += 1

            End While

        End If

    End Sub

    Sub tampilDGV()
        Call Koneksi()
        da = New MySqlDataAdapter("SELECT * FROM highscore ORDER BY score DESC LIMIT 5", conn)
        ds = New DataSet
        da.Fill(ds, "highscore")
        DataGridView1.DataSource = ds.Tables("highscore")
    End Sub





    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Call AutoNumberRowsForGridView()
    End Sub
End Class