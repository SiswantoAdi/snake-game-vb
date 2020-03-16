Imports MySql.Data.MySqlClient
Module Module1

    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String
    Public conn As MySqlConnection
    Public textusername As String
    Sub Koneksi()
        Try
            str = "Server=localhost;user id=root;password=;database=snakegame;"

            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
