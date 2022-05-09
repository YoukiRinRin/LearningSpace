Public Class Form1

    Dim time As Date = Now.ToString("hh:mm;ss")


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        time = time + 1

        Label1.Text = time

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Label1.Text = time



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub
End Class
