Imports MySql.Data.MySqlClient

Public Class frmlogin

#Region "Declares"
    Dim myconnection As New DTconnection
    Dim data_adapter As MySqlDataAdapter
    Dim dtable As New DataTable

#End Region

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        data_adapter = New MySqlDataAdapter("Select username, password FROM datab_login WHERE username='" & usernamebox.Text & "' AND password= '" & passwordbox.Text & "'", myconnection.open)
        dtable.Clear()
        data_adapter.Fill(dtable)

        If dtable.Rows.Count = Nothing Then
            MsgBox("Invalid")
        Else

            usernamebox.Clear()
            passwordbox.Clear()
            frmdashboard.Show()
            Me.Hide()

        End If
        myconnection.close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If passwordbox.UseSystemPasswordChar = True Then

            passwordbox.UseSystemPasswordChar = False
        Else

            passwordbox.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
