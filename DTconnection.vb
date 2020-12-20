Imports MySql.Data.MySqlClient

Public Class DTconnection
    Dim connect As New MySqlConnection("server='localhost'; uid='root'; pwd=''; database='NSTPers'")
    Dim cm As MySqlCommand
    Dim dr As MySqlDataReader
    Public Function open() As MySqlConnection

        Try
            connect.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connect

    End Function

    Public Function close() As MySqlConnection

        Try
            connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connect

    End Function

    Function GetAy() As String
        Dim _ay As String
        connect.Open()
        cm = New MySqlCommand("select aycode from datab_ay where status like 'OPEN'", connect)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            _ay = dr.Item(0).ToString
        Else
            _ay = ""

        End If

        dr.Close()
        connect.Close()
        Return _ay

    End Function
    Sub Main()
        frmmain.Label4.Text = GetAy()
        connect.Open()
        cm = New MySqlCommand("select count(*) from student", connect)
        frmmain.Label5.Text = Format(CLng(cm.ExecuteScalar), "#,##0")
        connect.Close()
    End Sub
End Class
