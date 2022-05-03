Public Class Form1
    Dim Hi As Integer
    Dim Yotei As String



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Long
        DateTimePicker1.MinDate = #1/1/1960#
        DateTimePicker1.MaxDate = #12/31/2020#





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Hi = Label2.Text



    End Sub
End Class
