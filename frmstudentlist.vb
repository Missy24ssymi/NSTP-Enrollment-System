Imports MySql.Data.MySqlClient

Public Class frmstudentlist

    Dim connect As New MySqlConnection("server=127.0.0.1; uid='root'; pwd=''; database='NSTPers'")
    Dim cm As MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub

    Private Sub addnewbtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addnewbtn.LinkClicked
        With frmstudent
            .savebtn.Enabled = True
            .updatebtn.Enabled = False
            .ShowDialog()

        End With
    End Sub

    Sub loadStudentlist()
        DataGridView1.Rows.Clear()
        Dim i As Integer
        connect.Open()
        cm = New MySqlCommand(" SELECT * from datab_structure", connect)
        dr = cm.ExecuteReader
        While dr.Read
            i += i
            DataGridView1.Rows.Add(dr.Item("studentno").ToString, dr.Item("firstname").ToString, dr.Item("middlename").ToString, dr.Item("lastname").ToString, dr.Item("address").ToString, dr.Item("contactno").ToString, dr.Item("nstpprogram").ToString, dr.Item("levelprog").ToString)
        End While

        dr.Close()
        connect.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "colEDIT" Then
            With frmstudent
                .studentnobox.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .fnbox.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .mnbox.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .lnbox.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                .addressbox.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
                .contactnobox.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString
                .savebtn.Enabled = False
                .updatebtn.Enabled = True
                .ShowDialog()

            End With


        ElseIf colName = "colDELETE" Then
            If (MsgBox("DELETE THIS RECORD?", vbYesNo + vbQuestion) = vbYes) Then
                connect.Open()
                cm = New MySqlCommand("DELETE FROM datab_structure WHERE studentno like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", connect)
                cm.ExecuteNonQuery()
                connect.Close()
                MsgBox("RECORD HAS BEEN SUCCESSFULLY DELETED!", vbInformation)
                loadStudentlist()
            End If

        End If
    End Sub

    Private Sub frmstudentlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class