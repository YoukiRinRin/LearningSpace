Public Class Form1

    Imports System.Net
    Imports System.Text

    'Const SW_HIDE = 0
    'Const SW_SHOW = 5
    'Const SW_RESTORE = 9

    Dim mjsoc As Sockets.Socket
    Dim mjip As IPAddress
    Dim mjipe As IPEndPoint


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = ""
        TextBox2.Text = "21"
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox4.PasswordChar = "*"
        TextBox5.Text = ""

        ''タスクトレイで実行したアプリケーションのタイトル
        'NotifyIcon.Text = "Outlook Express"

        ''タスクトレイで実行したアプリケーションのアイコン
        'NotifyIcon.Icon = Me.Icon

        ''アプリーションを実行
        'ExecutionEngineException = System.Diagnostics.Ptocess.Start("C:\Program Files\Outlook Express\maimn.exe")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim strSev As String
        Dim strSevp As String

        Dim strUser As String
        Dim strPass As String

        strSev = TextBox1.Text
        strSevp = TextBox2.Text
        strUser = TextBox3.Text
        strPass = TextBox4.Text

        mjsoc = New Sockets.Socket(_
        Net.Sockets.AddressFamily.InterNetwork,
        Net.Sokets.SocketType.Stream,
        Net.Sockets.PtotocolType.Tep)


        Try

            mjip = Dns.Resolve(strSev).AddressList(0)
            mjipe = New IPEndPoint(mjip.strSevp)

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
        Dim ByRetBuf(1024) As Byte
        Dim byWBuf() As Byte

        If strData <> "" Then
            bytWBuf = Encoding.ASCII.GetBytes(strData & vbCrLf)
            soc.Send(bytWBuf)
            TextBox5.AppendText(strData & vbCrLf)
            Do
                If soc.Available = 0 Then Exit Do
                intRetBuf.Initialize()
                intRet = soc.Reccive(bytRetBuf)
                strD = strD & Encoding.ASCII.GetString(
                    ByRetBuf, 0, intRet)
            Loop
            TextBox5.AppendText(strD)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Call SED_DATA(mjsoc, "QUIT")

            mjsoc.Shutdown(SocketsShutDown.Both)
            mjsoc.Close()

        Catch ex As Exception
            TextBox5.AppendText(ex.Message)
        End Try


    End Sub


    'Private Sub NotifyIcon1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    Handle NotifyIcon1.MouseDown
    '       If e.Button = Windows.Forms.MouseButtons.Left Then
    '        If ExecutionEngineException Is Nothing = False AndAlso ExecutionEngineException.MainWindowHandlw <> 0 Then
    '            showWindow(exe.MainWindowHandle, SW_SHOW)
    '        Else
    '            ShowWindow(wxw.MainWindowHandle, SW_HIDE)
    '        End If
    '    End If


    'End Sub

    'Private Sub Form1_FormClosed()
    '    NotifyIcon1_MouseDown.Icon = Nothing
    'End Sub
End Class
