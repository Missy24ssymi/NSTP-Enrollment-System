Imports MySql.Data.MySqlClient
Public Class frmprogramlist

    Dim connect As New MySqlConnection("server='localhost'; uid='root'; pwd=''; database='NSTPers'")
    Dim cm As MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub addnewbtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addnewbtn.LinkClicked
        With frmprogram
            .savebtn.Enabled = True
            .updatebtn.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Sub LoadRecords()
        DataGridView1.Rows.Clear()
        Dim i As Integer
        connect.Open()
        cm = New MySqlCommand("SELECT * from datab_program", connect)
        dr = cm.ExecuteReader
        While dr.Read
            i += i
            DataGridView1.Rows.Add(i, dr.Item("programcode").ToString, dr.Item("description").ToString, dr.Item("type").ToString)
        End While
        dr.Close()
        connect.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "colEDIT" Then
            With frmprogram
                .codebox.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .descriptionbox.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .levelcmbbox.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .codebox.Enabled = False
                .savebtn.Enabled = False
                .updatebtn.Enabled = True
                .ShowDialog()


            End With
        ElseIf colName = "colDELETE" Then
            If (MsgBox("DELETE THIS RECORD?", vbYesNo + vbQuestion) = vbYes) Then
                connect.Open()
                cm = New MySqlCommand("DELETE FROM datab_program WHERE programcode like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", connect)
                cm.ExecuteNonQuery()
                connect.Close()
                MsgBox("RECORD HAS BEEN SUCCESSFULLY DELETED", vbInformation)
                LoadRecords()

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub

    Private Sub frmprogramlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class