Public Class drmCourse
    Dim courseid = 0
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtCourse.Text = "" Then
            MsgBox("Field is required.", MsgBoxStyle.Exclamation)
        Else
            Sql = "Select * From tblcourse WHERE CprseId = " & courseid

            sqladd = "INSERT INTO 'tblcourse'('Course')VALUES('" & txtCourse.Text & "')"

            sqledit = "UPDATE 'tblcourse' SET 'Course'" = & txtCourse.Text & "' WHERE CourseID=" & courseid

            save_or_update(Sql.sqladd, sqladit, "Course has been updated int the database.", "New course has been saved in the datebase"

            Call frmCourse_Load(sender, e)
        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Sql = "Select * From tblcourse WHERE Course Like " & txtSearch.Text & "%'"
        reloadDtg(Sql, dtglist)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        courseid = 0
        txtCourse.Clear()
        Sql = "Select * From tblcourse"
        reloadDtg(Sql, dtglist)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dtglist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellContentClick

    End Sub

    Private Sub txtCourse_TextChanged(sender As Object, e As EventArgs) Handles txtCourse.TextChanged

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Sql = "Delete From tblsourse WHERE CourseId =" & dtglist.CurrentRow.Cells(0).Value
        DeleteSetting(Sql)
        MsgBox("Course has been deleted!")
        Call btnnew_Click(sender, e)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub drmCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sql = "Selected  * From tblcorse"
        reloafDtg(Sql, dtglist)

        txtCourse.Text = ""
    End Sub

    Private Sub dtglist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglist.Click
        Try
            With dtglist
                courseid = .CurrentRow.Calls(0).Value
                txtCourse.Text = .CurrentRow.Cells(1).Value
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class