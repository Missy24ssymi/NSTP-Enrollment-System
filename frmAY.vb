Imports MySql.Data.MySqlClient

Public Class frmAY

    Dim connect As New MySqlConnection("server=127.0.0.1; uid='root'; pwd=''; database='NSTPers'")
    Dim cm As MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub closebtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles closebtn.LinkClicked
        Me.Dispose()
    End Sub

    Private Sub semesterbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles semesterbox.SelectedIndexChanged
        Try
            yeartobox.Text = CLng(yearfrombox.Text) + 1
            aybox.Text = yearfrombox.Text & "-" & yeartobox.Text & " " & semesterbox.Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub semesterbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles semesterbox.KeyPress
        e.Handled = True
    End Sub

    Private Sub yearfrombox_TextChanged(sender As Object, e As EventArgs) Handles yearfrombox.TextChanged
        Try
            yeartobox.Text = CLng(yearfrombox.Text) + 1
            aybox.Text = yearfrombox.Text & "-" & yeartobox.Text & " " & semesterbox.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub yearfrombox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles yearfrombox.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub yeartobox_TextChanged(sender As Object, e As EventArgs) Handles yeartobox.TextChanged

    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Try
            If MsgBox("SAVE THIS ACADEMIC YEAR", vbYesNo + vbQuestion) = vbYes Then
                connect.Open()
                cm = New MySqlCommand("UPDATE datab_ay SET status = 'CLOSE'", connect)
                cm.ExecuteNonQuery()
                connect.Close()

                connect.Open()
                cm = New MySqlCommand("INSERT INTO datab_ay(aycode, year1, year2, semester)values(@aycode, @year1, @year2, @semester)", connect)
                With cm
                    .Parameters.AddWithValue("@aycode", aybox.Text)
                    .Parameters.AddWithValue("@year1", yearfrombox.Text)
                    .Parameters.AddWithValue("@year2", yeartobox.Text)
                    .Parameters.AddWithValue("@semester", semesterbox.Text)
                    .ExecuteNonQuery()
                End With
                connect.Close()
                MsgBox("NEW ACADEMIC YEAR HAS BEEN SUCCESSFULLY SAVED!", vbInformation)
                With frmAYlist
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
        semesterbox.Text = " "
        yeartobox.Clear()
        aybox.Clear()
        yearfrombox.Clear()

    End Sub
    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Clear()

    End Sub

    Private Sub frmAY_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class