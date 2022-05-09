Public Class Form1

    Dim Name As String

    Dim Result1 As String = "い"
    Dim Result2 As String = "ろ"
    Dim Result3 As String = "は"
    Dim Result4 As String = "に"
    Dim Result5 As String = "ほ"
    Dim Result6 As String = "へ"
    Dim Result7 As String = "と"
    Dim Result8 As String = "ち"

    Dim Count As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click








        Name = TextBox1.Text

        Count = Name.Length


        Select Case Count
            Case Count = 1
                Label2.Text = Result1

            Case Count = 2
                Label2.Text = Result2
            Case Count = 3
                Label2.Text = Result3
            Case Count = 4
                Label2.Text = Result4
            Case Count = 5
                Label2.Text = Result5
            Case Count = 6
                Label2.Text = Result6
            Case Count = 7
                Label2.Text = Result7
            Case Count = 8
                Label2.Text = Result8
        End Select











    End Sub
End Class
