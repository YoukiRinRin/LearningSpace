Public Class Form1
    Dim CountTime As DateTime = (0, 0, 0, 0, 3, 0, 0)


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Timer1.Interval = 1000
        Timer1.Start()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class
