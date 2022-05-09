



Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("フォームX座標　＝ {0}", Me.Left)
        Console.WriteLine("フォームY座標　＝ {0}", Me.Top)
        Console.WriteLine("フォームの横幅　＝｛0｝", Me.Width)
        Console.WriteLine("フォームの高さ　＝ {0}", Me.Height)

        Console.WriteLine("フォームX座標　＝ {0}", Me.Location.X)
        Console.WriteLine("フォームY座標　＝ {0}", Me.Location.Y)

        Console.WriteLine("フォームの横幅　＝｛0｝", Me.Size.Width)
        Console.WriteLine("フォームの高さ　＝ {0}", Me.Size.Height)

        Console.WriteLine("フォームX座標　＝ {0}", Me.Bounds.X)
        Console.WriteLine("フォームY座標　＝ {0}", Me.Bounds.Y)
        Console.WriteLine("フォームの横幅　＝｛0｝", Me.Bounds.Width)
        Console.WriteLine("フォームの高さ　＝ {0}", Me.Bounds.Height)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim fi As New System.IO.FileInfo("C:test\1.txt")
        'Dim copyFile As System.IO.FileInfo = fi.CopyTo("C:\test\2.txt")

        'fi.MoveTo("C:\text\3.txt")
        'fi.Delete()

        'copyFile.Delete()

        Me.Left = 0
        Me.Top += 10
        Me.Width = 400
        Me.Height -= 50
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Location = New Point(10, 20)

        Me.Location = New Size(200, 100)

        Me.Bounds = New Rectangle(10, 20, 200, 100)





    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sw As New System.IO.StreamWriter("W:\01_Youki\Desktop\うんこ.txt", False, System.Text.Encoding.GetEncoding("shift_jis"))

        sw.Write(TextBox1.Text)

        sw.Close()
        Me.Close()



    End Sub
End Class
