Public Class Form1

    Dim StartTime As New TimeSpan(0, 3, 0)
    Dim DownSecond As New TimeSpan(0, 0, 1)
    Dim FinishTime As New TimeSpan(0, 0, 0)



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        StartTime = StartTime - DownSecond
        Label1.Text = StartTime.ToString

        If StartTime = FinishTime Then
            Timer1.Enabled = False

            MessageBox.Show("3分たったよ！")
        End If



    End Sub
End Class
