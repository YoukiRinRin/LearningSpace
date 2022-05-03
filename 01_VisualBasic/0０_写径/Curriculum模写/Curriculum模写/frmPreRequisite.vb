Public Class frmPreRequisite
    Private Sub frmPreRequisite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = "SELECt SubjectId, 'Subject' as 'courseNo.','DescriptiveTitle', 'LecUnit','Course,'Course,'YearLeve','Semester','PreRequisite'FROM`tblsubject` s,tblcourse c WHERE s.CourseId = c.CourseId"
        reloadDtg(Sql.dtgList)
        dtgList.Colums(0).Visible = False
        txtPreRequisite.Clear()
        txtSemster.Clear()
        txtSubject.Clear()
        txtYear.Clear()
        txtdesc.Clear()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtSubject.Text = "" Then
                MsgBox("Select the subject you want to update.", MsgBoxStyle.Exclamation)
                Return
            End If
            Sql = "UPDATE `tblsubject` SET `PreRequisite` ='" & txtPreRequisite.Text.ToUpper() & "WHERE `SubjectId` =" & dtgList.CurrentRow.Cells(0).Value
            result = UpdateStatus(Sql)
            If result > 0 Then
                MsgBox("Subject Prerewuisites have been update.")

            End If

            Call frmPreRequisite_Load(sender, e)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click

        Sql = "SELECT `IdNo`,`Firstname`,`Lastname`,`MI`,`HomeAddress`,`Sex`,Coirse,`YearLevel`FROM`tblstudent`s,tblcourse c WHERE s, `CourseId`=c.`CourseId`"
        reloadDtg(Sql, dtg_ABorrowLists)
        PictureBox1.ImageLocation = ""

        cleartext(Me)


    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Try
            If txt_sid.Text = "" Then
                               Or txt_fname.Text = "" Or txt_lname.Text = ""
                               Or txt_mname.Text = "" Or cboCourse.Text = "Select"_
                               Or cboYearLevel.Text  = "Select" Then
                               employmessage()
            Else
                Dim gender As String
                If rdio_female.Checked = True Then
                    gender = "Female"
                Else gender = "Male"
                End If

                Sql = "SELECT * FROM `tblstudent` WHERE `IdNo`='" & txt_sid.Text & "'"

                sqladd = "insert into tblstudent (`IdNo`,`FirstName`,`LastName`.`MI`,`HomeAddress`,"_
                    &"`Sex`,`CourseId`,YearLevel, `StudentPhot`)"_
                    &"values('"& txt_sid.Text & "','"&txt_fname..Text & "','"& txt_lname.Text_
                    &"','"&txt_mname.Text&"','"&rch_address.Text _
                    &"',`StudentPhoto`='"&Path.GetFileName(PictureBox1.ImageLocation)&"'where `IdNo`='"&txt_sid.Text & "'"

                save_or_update(Sql, sqladd, Sqledit, "Student has been update in the database.", "New Student has been added in the database.")

                Sql = "SLECT * FROM `tblgrades`WHERE IdNo=" & txt_sid.Text &
                "AND `YearLevel`='" & cboYearLevel.Text & "'AND`CourseId` =" & cboCourse.SelectedValue

                If dt.Rows.Count > 0 Then
                Else
                    Sql = "SELECT * FROM `tblsubject`WHERE `CourseId`=" & cboCourse.SelectedValue
                    reloadtxt(Sql)

                    For Each r As DataRow In dt.Rows
                        With r
                            Sql = "INSERT INTO `tblgrades`(`CourseId`,`IdNo`,`SubjectId`,`YearLevel`,`Sem`)" &
                                "VALUES(" & cboCourse.SelectedValue & "," & txt_sid.Text & "'." & .Item
                        End With
                    Next

                End If


                If txtPhoto.Text <> "" Then
                    File.Copy(txtPhoto.Text, Application.StartupPath & "\StudentPhoto\" & Path.GetFileName(PictureBox1.ImageLocation), True)
                End If

                Call btn_New_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        Select_navigation("select IdNo from tblstudent")

        If inc <> maxrows - 1 Then
            inc = inc + 1
            navigate_records(txt_sid)
        Else
            If inc = ma Then
            End If

    End Sub

    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        Try
            Select_navigation("select IdNo from tblstudent")
            inc = 0
            navigate_records(txt_sid)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        Try
            select_navigation("select IdNo from tblStudent")
            inc = 0
            navigate_records(txt_sid)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPhoto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhoto.TextChanged
        PictureBox1.ImageLocation = txtPhoto_TextChanged.Text
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub dtg_ABorrowLists_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtg_ABorrowLists.Click
        Try
            txt_sid.text = dtg_ABorrowLists_Click.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub






    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dtgList_Click(sender As Object, e As EventArgs) Handles dtgList.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            Sql = "Delete From tblStudent Where Idno = '" & dtg_ABorrowLists.CurrentRow.Cells(0).Value & "'"
        Catch ex As Exception

        End Try
    End Sub

End Class