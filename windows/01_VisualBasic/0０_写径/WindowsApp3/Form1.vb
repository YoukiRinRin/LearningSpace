Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DateTimePicker1.Format = DateTimePickerFormat.Long
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker1.MinDate = #1/1/1960#
        DateTimePicker1.MaxDate = #12/31/2020#
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.text = DateTimePicker1.Value.ToShortDateString
        TextBox2.text = DateTimePicker1.Text




    End Sub
End Class
