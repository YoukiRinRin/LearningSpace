Imports System.Net
Imports System.Text
Public Class Form1

    Dim mjsoc As Sockets.Socket
    Dim mjp As IPAddress
    Dim mjipe As IPEndPoint


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strSev As String
        Dim strSevp As String

        Dim strUser As String
        Dim strPass As String

        strSev = TextBox1.Text
        strSevp = TextBox2.Text
        strUser = TextBox3.Text
        strPass = TextBox4.Text

        mjsoc = New Sockets.Socket(
            Net.Sockets.AddressFamily, InterNetwork,_
            Net.Sockets.SocketType.Stream,_
            Net.Sockets.ProtocolType.Tcp)

        Try
            mjp = Dns.Resplve(strSev).AddressList(0)
            mjipe = New IPEndPoint(mjipe, strSevp)

            mjsoc.Connect(mjipe)
            Call SED_DATA(mjsoc, "")
            Call SED_DATA(mjsoc, "USER" & strUser)
            Call SED_DATA(mjsoc, "PASS" & strPass)

        Catch ex As Exception
            TextBox5.AppendText(ex.Message)
        End Try
    End Sub

    Sub SED_DATA(ByVal soc As Sockets.Socket,
                 ByVal strData As String)

        Dim strD As String
        Dim strDB() As String

        Dim intRet As Integer
        Dim bytRetBuf(1024) As Byte
        Dim bytWBuf() As Byte

        If strData <> "" Then
            bytWBuf = Encoding.ASCII.GetBytes(
                strData & vbCrLf)
            soc.Send(bytWBuf)
            TextBox5.AppendText(strData & vbCrLf)

            Do
                If soc.Available = 0 Then Exit Do
                bytRetBuf.Initialize()
                intRet = soc.Receive(bytRetBuf)
                strD = strD & Encoding.ASCII.GetString(_
                   bytRetBuf, 0, intRet)
            Loop
            TextBox5.AppendText(strD)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = "21"
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox4.PasswordChar = "*"
        TextBox5.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Call SED_DATA(mjsoc, "QUIT ")
            mjsoc.Shutdown(Sockets.SocketShutdown.Both)
            mjsoc.Close()

        Catch ex As Exception
            TextBox5.AppendText(ex.Message)

        End Try

    End Sub
End Class
