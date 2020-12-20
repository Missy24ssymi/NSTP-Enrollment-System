Public Class frmdashboard

    Private Sub frmdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With frmmain
            .TopLevel = False
            Panel2.Controls.Add(frmmain)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub programbtn_Click_1(sender As Object, e As EventArgs) Handles programbtn.Click
        With frmprogramlist
            .TopLevel = False
            Panel2.Controls.Add(frmprogramlist)
            .BringToFront()
            .LoadRecords()
            .Show()
        End With
    End Sub

    Private Sub sectionbtn_Click(sender As Object, e As EventArgs) Handles sectionbtn.Click
        With frmsectionlist
            .TopLevel = False
            Panel2.Controls.Add(frmsectionlist)
            .BringToFront()
            .LoadRecords()
            .Show()
        End With
    End Sub

    Private Sub yearbtn_Click(sender As Object, e As EventArgs) Handles yearbtn.Click
        With frmAYlist
            .TopLevel = False
            Panel2.Controls.Add(frmAYlist)
            .BringToFront()
            .LoadRecords()
            .Show()
        End With
    End Sub

    Private Sub entrybtn_Click(sender As Object, e As EventArgs) Handles entrybtn.Click
        With frmstudentlist
            .TopLevel = False
            Panel2.Controls.Add(frmstudentlist)
            .BringToFront()
            .loadStudentlist() '
            .Show()
        End With
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        frmlogin.Show()
        Me.Close()

    End Sub
End Class