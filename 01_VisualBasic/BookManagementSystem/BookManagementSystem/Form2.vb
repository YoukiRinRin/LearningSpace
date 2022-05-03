Public Class Form2

    Dim Title As String
    Dim Author As String
    Dim Publisher As String
    Dim ISBN As String

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Title = txtTitle.Text
        Author = txtAuthor.Text
        Publisher = txtPublisher.Text
        ISBN = txtISBN.Text



    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub
End Class