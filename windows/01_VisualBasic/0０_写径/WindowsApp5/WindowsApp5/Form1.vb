Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim recScr As Rectangle

        recScr = Screen.PrimaryScreen.Bounds
        TextBox1.Text = recScr.ToString

        TextBox2.Text = "幅 =" & recScr.Width &
            " :高さ" & recScr.Height
    End Sub
End Class
