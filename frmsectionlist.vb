Imports MySql.Data.MySqlClient

Public Class frmsectionlist

    Dim connect As New MySqlConnection("server=127.0.0.1; uid='root'; pwd=''; database='NSTPers'")
    Dim cm As MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub addnewbtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addnewbtn.LinkClicked
        With frmsection
            .sectionidbox.Enabled = False
            .sectionidbox.Text = "(Auto)"
            .savebtn.Enabled = True
            .updatebtn.Enabled = False
            .LoadProgramCode()
            .ShowDialog()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Sub LoadRecords()
        DataGridView1.Rows.Clear()
        Dim i As Integer
        connect.Open()
        cm = New MySqlCommand("SELECT * from datab_section", connect)
        dr = cm.ExecuteReader
        While dr.Read
            i += i
            DataGridView1.Rows.Add(i, dr.Item("sectionid").ToString, dr.Item("section").ToString, dr.Item("programcode").ToString)
        End While
        dr.Close()
        connect.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "colEDIT" Then
            With frmsection

                .sectionidbox.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .sectionbox.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .Pcodebox.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .LoadProgramCode()
                .savebtn.Enabled = False
                .ShowDialog()



            End With


        ElseIf colName = "colDELETE" Then
            If (MsgBox("DELETE THIS RECORD?", vbYesNo + vbQuestion) = vbYes) Then
                connect.Open()
                cm = New MySqlCommand("DELETE FROM datab_section WHERE sectionid like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", connect)
                cm.ExecuteNonQuery()
                connect.Close()
                MsgBox("RECORD HAS BEEN SUCCESSFULLY DELETED", vbInformation)
                LoadRecords()

            End If
        End If
    End Sub

    Private Sub frmsectionlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class