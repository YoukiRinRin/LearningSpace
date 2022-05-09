Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim year As Integer
        Dim month As Integer
        Dim day As Integer

        'Dim W_Day As Integer



        'Dim F_W_Day As String = "M"
        'Dim F_Year As Integer = 1900
        'Dim F_month As Integer = 1
        'Dim F_Day As Integer = 1

        'Dim Uru As Integer = 1904

        'Dim x As Integer

        year = TextBox1.Text
        month = TextBox2.Text
        day = TextBox3.Text

        'x = year - F_Year

        'x = x / 4

        Dim theDay = New DateTime(year, month, day)

        Dim LongDay As String = theDay.ToString("dddd")

        MessageBox.Show(LongDay)

    End Sub




End Class
