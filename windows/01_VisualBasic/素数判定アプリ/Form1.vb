Public Class Form1

    Dim num As Integer
    Dim flg As Integer
    Dim i As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        flg = 0
        num = TextBox1.Text

        For i = 2 To num
            If num Mod i = 0 Then
                flg = 1

            Else
                flg = 0


            End If

        Next

        If flg = 0 Then
            Label2.Text = "入力された数は素数です。"
        Else
            Label2.Text = "入力された数は素数ではありません。"
        End If




    End Sub
End Class
