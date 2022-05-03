Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Console.WriteLine(DataGridView1.CurrentCell.Value)
        'Console.WriteLine(DataGridView1.CurrentCell.ColumnIndex)
        'Console.WriteLine(DataGridView1.CurrentCell.RowIndex)


        Dim ofd As New OpenFileDialog()

        ofd.FileName = "default.html"

        ofd.InitialDirectory = "c:\"

        ofd.Filter = "HTMLファイル(*.html;*.htm)|*.html;*htm|すべてのファイル(*.*)|*.*"

        ofd.FilterIndex = 2

        ofd.RestoreDirectory = True


        If ofd.ShowDialog() = DialogResult.OK Then
            MessageBox.Show(ofd.FileName
                            )
        End If



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
