Imports MySql.Data.MySqlClient

Module Dataconnection
    Dim connect As New MySqlConnection
    Dim cm As MySqlCommand
    Dim dr As MySqlDataReader
    Public _aycode As String

    Sub MyConnectiontoDatabase()
        connect = New MySqlConnection
        With connect
            .ConnectionString = ("server=127.0.0.1; uid='root'; pwd=''; database='NSTPers'")
        End With
    End Sub


End Module
