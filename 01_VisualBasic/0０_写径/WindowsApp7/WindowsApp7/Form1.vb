Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ret = MessageBox.Show("アプリケーションを終了しますか", "確認", MessageBoxButtons.YesNo)
        If ret = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
