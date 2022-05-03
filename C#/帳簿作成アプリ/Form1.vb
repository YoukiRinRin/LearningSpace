Public Class form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_inp_shiwake.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg_inp_shiwake.RowCount = 16

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For Each ix In dg_inp_shiwake.Rows
            MessageBox.Show(ix.Cells(1).value)
            MessageBox.Show(ix.Cells(3).value)
        Next




    End Sub
End Class
