Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim objData As DataSet
        Dim objTable As DataTable
        Dim Col As DataColumn

        objData = New DataSet("Data")
        objTable = New DataTable("Table")

        Col = New DataColumn("NO")

        Col.AutoIncrement = True
        Col.DataType = Type.GetType("System.Int32")
        objTable.Columns.Add(Col)

        Col = New DataColumn("料金")
        Col.DataType = Type.GetType("System.Int32")
        objTable.Columns.Add(Col)

        objData.Tables.Add(objTable)
        DataGrid1.SetDataBinding(objData, "Table")
    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.MouseDown

        Dim Hit As DataGrid.HitTestInfo

        Hit = DataGridView1.HitTest(e.X, e.Y)
        Select Case Hit.Type
            Case DataGrid.HitTestType.Cell
                Label1.Text = CStr(Hit.Row + 1) + "行"
                    "+" CStr(Hit.Column + 1) + "行目を編集"
                    Case Else
                Label1.Text = ""

        End Select


    End Sub
End Class
