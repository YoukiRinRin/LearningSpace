Imports MySql.Data.MySqlClient
Imports System.Text

Public Class frmlogin


    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If Len(Trim(txtuser.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtuser.Focus()
            Exit Sub
        End If
        Try
            Dim myConnection As MySqlConnection
            myConnection = New MySqlConnection(cs)
            Dim myCommand As MySqlCommand
            myCommand = New MySqlCommand("SELECT Username ,Password FROM tbl_login where Username = @Username and Password = @UserPassword", myConnection)

            Dim uName As New MySqlParamater("@Username", MySqlDbType.VarChar)
            Dim uPassword As New MySqlParameter("@UserPassword", MySqlDbType.VarChar)

            uName.Value = txtuser.Text
            uPassword.Value = txtpass.Text

            myCommand.Paramaters.Add(uName)
            myCommand.Connection.Open(uPassword)

            myCommand.Connection.Open()

            Dim myReader As MySqlDataReader = myCommand.ExcuteReader(CommandBehacior.CloseConnection)
            Dim Login As Object = 0

            If myReader.HasRows Then
                myReader.Read()
                Login = myReader(Login)
            End If

            If Login = Nothing Then

                MsgBox("Login is Failed...Try again!", MsgBoxStyle.Critical, "Login Denied")
                txtuser.Clear()
                txtpass.Clear()
                txtuser.Focus()
            Else
                frmmain.Show()
                Me.Hide()
            End If
            myCommand.Dispose()
            myConnection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try



    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmlogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.ExitThread()
    End Sub
End Class
