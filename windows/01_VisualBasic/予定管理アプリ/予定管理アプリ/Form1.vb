Imports System.IO
Public Class Form1


    Dim Yotei As String
    Dim P_Date As Date
    Dim dt_Plan As New DataTable
    Dim dtRow As DataRow

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Yotei = Inp_Plan.Text
        P_Date = DateTimePicker1.Value

        'Dim dt As New DataTable("DataTable1")

        dtRow = dt_Plan.NewRow

        dt_Plan.Columns.Add("Date")
        dt_Plan.Columns.Add("Plan", Type.GetType("System.String"))

        dtRow("Date") = P_Date
        dtRow("Plan") = Yotei

        dt_Plan.Rows.Add()

        MessageBox.Show(P_Date & Yotei)

        dt_Plan.Rows.Add(dtRow)

        DataGridView1.DataSource = dt_Plan


        If 


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub
End Class
