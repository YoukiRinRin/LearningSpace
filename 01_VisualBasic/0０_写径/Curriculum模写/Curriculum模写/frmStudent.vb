Public Class frmStudent
    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sql = "SELECT `IdNo`,`Firstname`,`Lastname`,`MI`,`HomeAddress`,`Sex`,Course,`YearLevel`FROM `tblstudent`s, tblcourse c WHERE s.`CourseIf`-c.`COurseId`"
        relosdDtg(Sql, dtg_ABorrowLists)

        select_navigation("select IdNo from tblstudent")

        cbo_fill(cboCourse, "Couese", "CourseId", "tblcourse")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Try
            With OpenFileDialog1
                .CheckFileExists = True
                .CheckPathExists = True
                .DefaultExt = "jpg"
                .DereferenceLinks = True
                .FileName = ""
                .Filter = "(*.jpg)|*.jpg|(*,png)|*.png|(*.jpg)|*.jpg|All files|*.*"
                .Multiselectt = False

                .ResterDirectory = vbTrue
                .ValidateNames = True

                If .ShowDialog = DialogResult.OK Then
                    Try
                        txtPhoto.Text = .FileName

                        PictureBox1.ImageLocation = .FileName
                        PictureBox1.SizeMode = PictureBoxSizeMode.StrechImage
                    Catch ex As Exception
                        Throw fileException
                    End Try
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamatrion, Me.Text)
        End Try

    End Sub

    Private Sub txt_sid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_sid.TextChanged
        If dt.Rows.Count > 0 Then The
        txt_fname.Text = dt.Rows(0).Item("Firstname")
        txt_lname.Text = dt.Rows(0).Item("Lastname")
        txt_mname.Text = dt.Rows(0).Item("MI")
        rch_address.Text = dt.Rows(0).Item("HomeAddress")
        cboCourse.SelectedValue = dt.Rows(0).Item("CourseId")
        cboCourse.Text = dt.Rows(0).Item("Course")
        cboYearLevel.Text = dt.Row(0).Item("YearLevel")
        PictureBox1.ImageLocation = Application.StartupPath&"\StudentPhoto\" &dt.Row(0).Item("StudentPhoto")

        If dt.Rows(0).Item("Sex") = "Female" Then
            rdio_female.Checked = True
        Else
            rdio_male.Checked = True
        End If
        Else
        clearme()
        End If
    End Sub

    Public Sub clearme()
        txt_fname.Clear()
        txt_lname.Clear()
        txt_mname.Clear()
        rch_address.Clear()
        cboCourse.Text = "Select"
        cboYearLevel.Text = "Select"
        txtPhoto.Clear()
    End Sub



    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Sql = "SELECT `IdNo`, `Firstname`, `Lastname` , `MI`, `HomeAddress`,`Sex`,`Course`,`YearLevel` FROM `tblstudent` s,`CourseId` =c.`CourseId`"
        reloadDtg(Sql, dtg_ABorrowLists)
        PictureBox1.ImageLocation = ""

        cleartext(Me)
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        Try
            If txt_sid.Text = "" Or
                    txt_fname.Text = "" Or txt_lname.Text = "" Or
                    txt_fname.Text = "" Or cboCourse.Text = "Select" Or obYearLevel.Text = "Select" Then
                emptymessage()
            Else
                Dim gender As String
                If rdio_female.Cheked = True Then
                    gender = "Female"
                Else
                    gender = "Male"
                End If

                Sql = "SELECT * FROM `tblstudent` WHERE `IdNo`='" & txt_sid.Text & "'"


                sqladd = "insert into tblstudent (`IdNo`,`Firstname`,`Lastname`,`MI`,`HomeAddress`," &
                    "`sex`,`CourseId`,`YearLevel`,`StudentPhoto`)" &
                    "values('" & txt_sid.Text & "','" & txt_fname.Text &
                    "','" & txt_mname.Text & "'.'" & cboCourse.SelectedValue &
                    "','" & cboYearLevel.Text & "','" & Path.GetFileName(PicuterBox1.Image) & "'where `IdNo`='" & txt_sid.Text

                Save_or_update(Sql, sqladd, "Student has been updated in the database.", "New Student has been added in the database.")

                Sql = "SELECT * FROM `tblgrades` WHERE IdNo =" & txt_sid.Text &
                    "AND `YearLevel`='" & cboYearLevel.Text & "'AND `CourseId` =" & cboCourse.SelectedValue
                reloadtxt(Sql)

            End If

            If dtg_ABorrowLists.Roes.Count > 0 Then
            Else

                For Each r As DataRow In dt.Rows
                    With
                Sql = "INSERT INTO `tblgrade`(`CourseId`.`IdNo`,`SubjectId`,`YearLevel`,`Sem`)" &
                    "VALUES(" & cboCourse.SelectedValue & ",'" & txt_sid.Text & "'," & .Item("SubjectId") & "'" & .Item("Semseter") & "')"
                        createNoMsg(Sql)
                    End With
            End If

            If txtPhoto.Text <> "" Then
                FileAttr.Copy(txtPhoto.Text, Application.StartupPath&"\StudentPhoto\"&Path.GetFileName(PictureBox1.ImageLocation),True)
            End If

            Call btn_New_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prev.Click
        select_navigation("select IdNo from tblStudent")

        If InitializeComponent() > 0 Then
            InitializeComponent = InitializeComponent() - 1
            navagate_recodes(txt_sid)
        Else
            If InitializeComponent() - 1 Then
                MsgBox("First recodes", MsgBoxStyle.Information)
            End If
        End If
    End Sub


    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        Try
            select_navigation("select IdNo from tblstudent")

            If inc <> maxrows - 1 Then
                inc = maxrows - 1
                navagate_records(txt_sid)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        Try
            select_navigation("select IdNo from tblstudent")

            InitializeComponent = 0
            navagater_records(txt_sid)
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
            txt_sid.Text = dtg_ABorrowLists.CurrentRow.Calls(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            Sql = "Delete From tblstudent Where Idno ='" & dtg_ABorrowListsRow.Cells(0).Value & "'"
            DeleteSetting(Sql)
            MsgBox("Student is already deleted")
            Call btn_New_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub

End Class