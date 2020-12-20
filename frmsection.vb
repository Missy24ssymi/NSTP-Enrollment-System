Imports MySql.Data.MySqlClient

Public Class frmsection

    Dim connect As New MySqlConnection("server=127.0.0.1; uid='root'; pwd=''; database='NSTPers'")
    Dim cm As MySqlCommand
    Dim dr As MySqlDataReader
    Sub LoadProgramCode()
        Pcodebox.Items.Clear()
        connect.Open()
        cm = New MySqlCommand("SELECT * FROM datab_program ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Pcodebox.Items.Add(dr.Item("programcode").ToString)
        End While
        dr.Close()
        connect.Close()

    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

        Try
            If sectionbox.Text & sectionidbox.Text & Pcodebox.Text = String.Empty Then
                MsgBox("Required Field", vbCritical)
                Return
            End If

            If MsgBox("SAVE THIS RECORD?", vbYesNo + vbQuestion) = vbYes Then
                connect.Open()
                cm = New MySqlCommand("INSERT INTO datab_section (section, programcode)values(@section, @programcode)", connect)
                With cm
                    .Parameters.AddWithValue("@section", sectionbox.Text)
                    .Parameters.AddWithValue("@programcode", Pcodebox.Text)
                    .ExecuteNonQuery()
                End With
                connect.Close()
                MsgBox("RECORD HAS BEEN SUCCESSFULLY SAVED", vbInformation)
                With frmsectionlist
                    .LoadRecords()
                End With
                Clear()
            End If
        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Clear()
        sectionbox.Clear()
        sectionidbox.Text = "(Auto)"
        Pcodebox.Text = ""
        savebtn.Enabled = True
        updatebtn.Enabled = False

    End Sub

    Private Sub closebtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles closebtn.LinkClicked
        Me.Dispose()
    End Sub

    Private Sub Pcodebox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Pcodebox.SelectedIndexChanged

    End Sub

    Private Sub Pcodebox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Pcodebox.KeyPress
        e.Handled = True
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click


        Try
            If sectionbox.Text & sectionidbox.Text & Pcodebox.Text = String.Empty Then
                MsgBox("Required Field", vbCritical)
                Return
            End If

            If MsgBox("UPDATE RECORD?", vbYesNo + vbQuestion) = vbYes Then
                connect.Open()
                cm = New MySqlCommand("UPDATE datab_section SET section=@section, programcode=programcode WHERE sectionid=@sectionid ", connect)
                With cm
                    .Parameters.AddWithValue("@section", sectionbox.Text)
                    .Parameters.AddWithValue("@programcode", Pcodebox.Text)
                    .Parameters.AddWithValue("sectionid", sectionidbox.Text)
                    .ExecuteNonQuery()
                End With
                connect.Close()
                MsgBox("RECORD HAS BEEN SUCCESSFULLY UPDATED", vbInformation)
                With frmsectionlist
                    .LoadRecords()

                End With
                Clear()
                Me.Dispose()
            End If
        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frmsection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Clear()
    End Sub
End Class