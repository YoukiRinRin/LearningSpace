Public Class frmUser

    Private Sub frm_adduser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cbol_type.Text = "Administrator"
            reloadDtg("Student User AS 'ID',Fullname as 'Name',User_name as 'UserName',UserType as 'Type'From tbluseraccount", dtg_listUser)
            If lbl_id.Text = "id" Then
                btn_update.Enabled = False
                btn_delete.Enabled = False
                btn_saveuser.Enabled = True
            Else
                btn_saveuser.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        lbl_id.Text = "id"
        Call frm_adduser_Load(sender, e)
        cleartext(Me)
    End Sub

    Private Sub btn_saveuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_saveuser.Click

        If txt_name.Text = "" Or txt_pass.Text = "" Or txt_username.Text = "" Then
            emptymessage()
        End If
        Sql = "insert into tbluseraccount (`Fullname`,`User_name`,`Pass`,`UserType`)" &
            ""



    End Sub




End Class
