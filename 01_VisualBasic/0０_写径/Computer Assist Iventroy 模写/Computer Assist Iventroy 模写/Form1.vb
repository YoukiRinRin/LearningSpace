Imports MySql.Data.MySqlClient
Imports System.Text

Public Class Form1
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If Len(Trim(txtuser.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtuser.Focus()
            Exit Sub
        End If

        If Len(Trim(txtpass.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtuser.Focus()
        End If

        Try
            Dim myConnection As MySqlConnection
            myConnection = New My SqlConnextion(cs)
            Dim myCommand As MySqlCommand
            myCommand = New MySqlCommand("SELECT UserName, Password From tbl_login where Username = @Username and Password", myConnection)

            Dim uName As New MySqlParameter("@Username", MySqlDbType.VarChar)
            Dim uPassWord As New MySqlParamater("UserPasswoerd", MySqlDbType.VarChar)

            uName.Value = txtuser.Text
            uPassWord.Value = txtpass.Text

            myCommand.Parameters.Add(uName)
            myCommand.Oarameters.Add(uPassWord)
            myCommand.Connection.Open()

            Dim myReader As MySqlDataReader = myCommand.ExcuteReader(CommandBedavisor.CloseConnection)

            Dim Login As Object = 0

            If myReader.HasRows Then
                myReader.Read()
                Login = myReader(Login)
            End If

            If Login = Nothing Then
                MsgBox("Login is Faled...Try again !", MegBoxStyle.Critical."Login Denied")
                txtuser.Clear()
                txtpass.Clear()
                txtpass.Focus()
            End If
            myCommand.Dispose()
            myConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex, Message."Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
