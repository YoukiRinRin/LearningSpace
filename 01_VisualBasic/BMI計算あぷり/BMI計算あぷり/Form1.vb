Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Shincho As Integer
        Dim Taiju As Integer

        Dim BMI As Integer
        Dim tekisei As Integer


        Shincho = Integer.Parse(TextBox1.Text)
        Taiju = Integer.Parse(TextBox2.Text)

        BMI = Taiju / Shincho * Shincho



    End Sub
End Class
