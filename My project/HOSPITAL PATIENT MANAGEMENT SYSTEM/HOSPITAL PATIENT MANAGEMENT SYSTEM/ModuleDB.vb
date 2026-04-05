Imports MySql.Data.MySqlClient

Module ModuleDb

    Public conn As MySqlConnection

    Public Sub OpenConnection()
        Try
            If conn Is Nothing Then
                conn = New MySqlConnection("server=localhost;user id=root;password=;database=hospital_DBs;SslMode=Required;AllowPublicKeyRetrieval=True")
            End If

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

        Catch ex As Exception
            MessageBox.Show("Connection Error: " & ex.Message)
        End Try
    End Sub

    Public Sub CloseConnection()
        Try
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module