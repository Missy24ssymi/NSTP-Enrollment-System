Imports MySql.Data.MySqlClient
Public Class frmprogram


    Dim connect As New MySqlConnection("server=127.0.0.1; uid='root'; pwd=''; database='NSTPers'")
    Dim cm As MySqlCommand
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles closebtn.LinkClicked
        Me.Dispose()

    End Sub
    Private Sub levelcmbbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles levelcmbbox.KeyPress
        e.Handled = True
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

        Try
            If MsgBox("Save Record?", vbYesNo + vbQuestion) = vbYes Then
                connect.Open()
                cm = New MySqlCommand("INSERT INTO datab_program(programcode, description, type)values(@programcode, @description, @type)", connect)
                With cm
                    .Parameters.AddWithValue("@programcode", codebox.Text)
                    .Parameters.AddWithValue("@description", descriptionbox.Text)
                    .Parameters.AddWithValue("@type", levelcmbbox.Text)
                    .ExecuteNonQuery()
                End With
                connect.Close()
                MsgBox("RECORD HAS BEEN SUCCESSFULLY SAVED", vbInformation)
                Clear()
                With frmprogramlist
                    .LoadRecords()
                End With
            End If
        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Clear()
        codebox.Clear()
        descriptionbox.Clear()
        codebox.Enabled = True
        savebtn.Enabled = True
        updatebtn.Enabled = False
        levelcmbbox.Text = ""

    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Try
            If MsgBox("Update Record?", vbYesNo + vbQuestion) = vbYes Then
                connect.Open()
                cm = New MySqlCommand("UPDATE datab_program SET description=@description, type=@type WHERE programcode= @programcode", connect)
                With cm
                    .Parameters.AddWithValue("@description", descriptionbox.Text)
                    .Parameters.AddWithValue("@type", levelcmbbox.Text)
                    .Parameters.AddWithValue("@programcode", codebox.Text)
                    .ExecuteNonQuery()

                End With
                connect.Close()
                MsgBox("RECORD HAS BEEN SUCCESSFULLY UPDATED", vbInformation)
                Clear()
                With frmprogramlist
                    .LoadRecords()
                End With
                Me.Dispose()
            End If
        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Clear()

    End Sub

    Private Sub frmprogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub levelcmbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles levelcmbbox.SelectedIndexChanged

    End Sub
End Class