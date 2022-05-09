Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("ファイルを上書きしますか?", "質問", MessageBoxButtons, YesNoCancel,
  MessageBoxIcon.Exclamation,

MessageBoxOptions.RightAlign)


    End Sub
End Class
