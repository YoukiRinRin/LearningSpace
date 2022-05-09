Imports System.IO
Public Class Form1
    Const file_path = "W:\01_Youki\Desktop\todo\"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_add.Click

        Dim Get_Date As Date
        Dim ToDo As String
        Dim Write_Path As String
        Dim DateToDo As String

        Get_Date = Date_ToDo.Value
        DateToDo = Get_Date.ToString("yyyyMMdd")


        ToDo = Tx_ToDo.Text
        Write_Path = file_path + DateToDo + ".txt"

        Dim Writer = New StreamWriter(Write_Path, True)
        Writer.WriteLine(ToDo)
        Writer.Close()

        Tx_ToDo.Text = ""
        MessageBox.Show("登録が完了しました。")



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt1 As DateTime = DateTime.Now
        Dim Date_Today As String = dt1.ToString("yyyyMMdd")
        Dim Read_Path As String = file_path + Date_Today + ".txt"

        Dim boolFile_Exists As Boolean
        boolFile_Exists = System.IO.File.Exists(Read_Path)

        If boolFile_Exists = True Then

            Dim reader = New StreamReader(Read_Path)


            Dim f_Todo As String
            f_Todo = reader.ReadToEnd()
            reader.Close()

            MessageBox.Show(f_Todo, "今日やること")

        End If


    End Sub

    Private Sub Tx_ToDo_TextChanged(sender As Object, e As EventArgs) Handles Tx_ToDo.TextChanged

    End Sub

    Private Sub bt_hyoji_Click(sender As Object, e As EventArgs) Handles bt_hyoji.Click

        Dim Get_sel_date As Date
        Dim date_sel As String
        Get_sel_date = date_select.Value
        date_sel = Get_sel_date.ToString("yyyyMMdd")

        Dim Read_Path As String = file_path + date_sel + ".txt"

        Dim boolFile_Exists As Boolean
        boolFile_Exists = System.IO.File.Exists(Read_Path)

        Dim f_Todo As String

        If boolFile_Exists = True Then

            Dim reader = New StreamReader(Read_Path)
            f_Todo = reader.ReadLine()

            While reader.EndOfStream = False
                list_todo.Items.Add(reader.ReadLine())
            End While


            reader.Close()

        End If







    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_todo.SelectedIndexChanged

    End Sub
End Class
