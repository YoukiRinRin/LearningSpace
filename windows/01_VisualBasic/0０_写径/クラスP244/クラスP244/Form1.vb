Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Location
        a = New Location()
        a.latitude = 35.681
        a.longitude = 139.767
        MessageBox.Show(a.longitude)
        MessageBox.Show(a.latitude)

        Dim b As Location
        b = New Location()
        b.latitude = 58.732
        b.longitude = 281.512
        MessageBox.Show(b.longitude)
        MessageBox.Show(b.latitude)

        Dim Tel As New Telephone

        Tel.Bell()


    End Sub

End Class
