Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'MessageBox.Show(My.Computer.Info.TotalPhysicalMemory)
        'MessageBox.Show(My.Computer.Info.AvailablePhysicalMemory)
        'MessageBox.Show(My.Computer.Info.TotalVirtualMemory)
        'MessageBox.Show(My.Computer.Info.AvailableVirtualMemory)


        'Dim subFolders As String() = System.IO.Directory.GetDirectories("S:\07_画像", "*", System.IO.SearchOption.AllDirectories)

        'ListBox1.Items.AddRange(subFolders
        '                        )


        Dim rs As New System.IO.StringReader(TextBox1.Text)

        While rs.Peek() > -1
            Console.WriteLine(rs.ReadLine())
        End While

        rs.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Cursor = Cursors.WaitCursor


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s As String = "こんにちは"

        If Not s Is Nothing Then
            Dim len As Integer = s.Length
        End If

        MessageBox.Show(s)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        'If Me.WindowState = FormWindowState.Maximized Then
        '    e.Cancel = True

        'End If


    End Sub
End Class
