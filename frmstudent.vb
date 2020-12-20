Imports MySql.Data.MySqlClient

Public Class frmstudent
    Dim connect As New MySqlConnection("server=127.0.0.1; uid='root'; pwd=''; database='NSTPers'")
    Dim cm As MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub closebtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles closebtn.LinkClicked
        Me.Dispose()

    End Sub

    Private Sub frmstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Try
            If MsgBox("SAVE THIS RECORD?", vbYesNo + vbQuestion) = vbYes Then


                connect.Open()
                cm = New MySqlCommand("INSERT INTO datab_structure(studentno, firstname, middlename, lastname, address, contactno, nstpprogram, levelprog)values(@studentno, @firstname, @middlename, @lastname, @address, @contactno, @nstpprogram, @levelprog)", connect)
                With cm
                    .Parameters.AddWithValue("@studentno", studentnobox.Text)
                    .Parameters.AddWithValue("@firstname", fnbox.Text)
                    .Parameters.AddWithValue("@middlename", mnbox.Text)
                    .Parameters.AddWithValue("@lastname", lnbox.Text)
                    .Parameters.AddWithValue("@address", addressbox.Text)
                    .Parameters.AddWithValue("@contactno", contactnobox.Text)
                    .Parameters.AddWithValue("@nstpprogram", programbox.Text)
                    .Parameters.AddWithValue("@levelprog", levelbox.Text)
                    .ExecuteNonQuery()
                End With
                connect.Close()
                MsgBox("RECORD HAS BEEN SUCCESSFULLY SAVED!", vbInformation)
                clear()
                With frmstudentlist
                    .loadStudentlist()
                End With
            End If
        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub clear()


        addressbox.Clear()
        fnbox.Clear()
        mnbox.Clear()
        lnbox.Clear()
        contactnobox.Clear()
        studentnobox.Clear()
        studentnobox.Enabled = True
        savebtn.Enabled = True
        updatebtn.Enabled = False
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Try
            If MsgBox("Update Record?", vbYesNo + vbQuestion) = vbYes Then
                connect.Open()
                cm = New MySqlCommand("UPDATE datab_structure SET firstname=@firstname, middlename=@middlename, lastname =@lastname, address = @address, contactno = @contactno, nstpprogram=@nstpprogram, levelprog=@levelprog WHERE studentno= @studentno", connect)
                With cm
                    .Parameters.AddWithValue("@firstname", fnbox.Text)
                    .Parameters.AddWithValue("@middlename", mnbox.Text)
                    .Parameters.AddWithValue("@lastname", lnbox.Text)
                    .Parameters.AddWithValue("@address", addressbox.Text)
                    .Parameters.AddWithValue("@contactno", contactnobox.Text)
                    .Parameters.AddWithValue("@nstpprogram", programbox.Text)
                    .Parameters.AddWithValue("@levelprog", levelbox.Text)
                    .ExecuteNonQuery()

                End With
                connect.Close()
                MsgBox("RECORD HAS BEEN SUCCESSFULLY UPDATED!", vbInformation)
                clear()
                With frmstudentlist
                    .loadStudentlist()
                End With

                Me.Dispose()
            End If
        Catch ex As Exception
            connect.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub programbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles programbox.SelectedIndexChanged

    End Sub

    Private Sub programbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles programbox.KeyPress
        e.Handled = True
    End Sub

    Private Sub levelbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles levelbox.SelectedIndexChanged

    End Sub

    Private Sub levelbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles levelbox.KeyPress
        e.Handled = True
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        clear()
    End Sub
End Class