Imports System.Data.OleDb

Public Class Form1
    Public ReadOnly Crypto As ClsCypto
    Public ReadOnly CryptoKey As String = "12345678901234567890"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Main()
        Me.Size = New Size(490, 160)
        txtPasswordLogin.Focus()
    End Sub
    Private Sub GetPasswordFromDAtabass()
        Try
            Dim cmd As New OleDbCommand
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            With cmd
                .Connection = cnContacts
                .CommandType = CommandType.Text
                .CommandText = "SELECT [Password] FROM TblPasswords WHERE [Descrption]='AdministratorPasswordForDartabase'"
            End With
            Dim sdr As OleDbDataReader = cmd.ExcuteReader()
            If sdr.HasRows Then
                While sdr.Read()
                    PasswordString = sdr.Item("Password").ToString
                End While
                sdr.Close()
            End If
        Catch ex As Exception
            MsgBox("Check for exist Password:" & ex.Message)
        End Try

        If PasswordString = "" Then
        Else
            PasswordString = Crypto.DeryptString128Bit(Trim(PasswordString), CryptoKey)
        End If

    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        GetPasswordFromDataBase()
        If txtPasswordLogin.Text = PasswordString Then
            FrmMaim.show()
            txtPasswordLogin.Text = Nothing
            Me.Size = New Size(490, 160)
            Me.Hide()
        End If
    End Sub

    Private Sub TxtPasswordLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPasswordLogin.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.BtnLogin_Click.PerformClick()
        End If
    End Sub


End Class
