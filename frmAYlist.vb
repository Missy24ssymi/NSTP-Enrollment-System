Imports MySql.Data.MySqlClient

Public Class frmAYlist

    Dim connect As New MySqlConnection("server=127.0.0.1; uid='root'; pwd=''; database= 'NSTPers'")
    Dim cm As MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Sub LoadRecords()
        DataGridView1.Rows.Clear()
        Dim i As Integer
        connect.Open()
        cm = New MySqlCommand("SELECT * from datab_ay", connect)
        dr = cm.ExecuteReader
        While dr.Read
            i += i
            DataGridView1.Rows.Add(i, dr.Item("aycode").ToString, dr.Item("year1").ToString, dr.Item("year2").ToString, dr.Item("semester").ToString, dr.Item("status").ToString)
        End While
        dr.Close()
        connect.Close()
    End Sub

    Private Sub addnewbtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addnewbtn.LinkClicked
        With frmAY
            .ShowDialog()

        End With
    End Sub

    Private Sub frmAYlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "colOPEN" Then
            If MsgBox("OPEN THIS ACADEMIC YEAR " & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "?", vbYesNo + vbQuestion) = vbYes Then
                connect.Open()
                cm = New MySqlCommand("UPDATE datab_ay set status = 'CLOSE", connect)
                connect.Close()

                connect.Open()
                cm = New MySqlCommand("UPDATE datab_ay set status = 'OPEN' WHERE aycode like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", connect)
                cm.ExecuteNonQuery()
                connect.Close()

                MsgBox("ACADEMIC YEAR HAS BEEN SUCCESSFULLY OPENED", vbInformation)
                LoadRecords()

            End If

        ElseIf colName = "colCLOSE" Then
            If MsgBox("CLOSE THIS ACADEMIC YEAR " & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "?", vbYesNo + vbQuestion) = vbYes Then
                connect.Open()
                cm = New MySqlCommand("UPDATE datab_ay set status = 'CLOSE' WHERE aycode like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", connect)
                cm.ExecuteNonQuery()
                connect.Close()

                MsgBox("ACADEMIC YEAR" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & " HAS BEEN SUCCESSFULLY CLOSED", vbInformation)
                LoadRecords()
            End If
        End If
    End Sub
End Class