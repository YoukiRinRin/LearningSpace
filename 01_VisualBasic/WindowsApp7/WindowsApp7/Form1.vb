Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ps As System.Diagnostics.Process() = System.Diagnostics.Process.GetProcesses()

        For Each p As System.Diagnostics.Process In ps

            Try
                Console.WriteLine("プロセス名:{0}", p.ProcessName)
                Console.WriteLine("ID:{0}", p.Id)
                Console.WriteLine("ファイル名:｛0｝", p.MainModule.FileName)
                Console.WriteLine("合計プロセッサ時間:{0}", p.TotalProcessorTime)
                Console.WriteLine("物理メモリ使用量:{0}", p.WorkingSet64)

                Console.WriteLine()
            Catch ex As Exception
                Console.WriteLine("エラー{0}", ex.Message)
            End Try

        Next


        Dim num16 As Integer = Convert.ToInt32("FFFF", 16)

        MessageBox.Show(num16)


        ListBox1.Items.Add("Apple")
        ListBox1.Items.Add("ちんこ")
        ListBox1.Items.Add("まんこ")
        ListBox1.Items.Add("うんこ")
        ListBox1.Items.Add("Apple")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ListBox1.Items.Insert(2, "Zoo")

        ListBox1.Items.AddRange(New String() {"すい星", "規制", "地球", "火星"})


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim UserName As String

        UserName = SystemInformation.UserName

        MsgBox(UserName,, "ユーザ名")


        Dim X As Integer
        Dim Y As Integer
        Dim Pos As Point = Windows.Forms.Cursor.Position

        X = Pos.X
        Y = Pos.Y

        MessageBox.Show(X, Y)


        Dim Rect As Rectangle

        Rect = Screen.PrimaryScreen.Bounds
        MsgBox(Rect.Width & "," & Rect.Height)
    End Sub

    Private Sub Form1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            MsgBox("上方向にスクロールしました")
        Else
            MsgBox("下方向にスクロールしました")
        End If

    End Sub
End Class
