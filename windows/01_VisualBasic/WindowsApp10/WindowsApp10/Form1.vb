Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim stFilePath As String = System.IO.Path.Combine("C:\Hoge\Foo", "Bar.txt")
        MessageBox.Show(stFilePath)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iLength As Integer = Me.TextBox1.SelectionLength

        MessageBox.Show(iLength.ToString())

        Me.TextBox1.SelectionLength = 3

        MessageBox.Show(iLength.ToString())


    End Sub
End Class
