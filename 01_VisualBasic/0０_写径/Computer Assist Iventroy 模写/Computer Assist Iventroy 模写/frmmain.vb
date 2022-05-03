Imports MySql.data.MySqlClient
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmmain
    Dim cmd As New MySqlCommand
    Dim cn As New MysqlConnection

    Dim str2 As String
    Dim rdr As MySqlDataReader = Nothing
    Dim da As New MysqlDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata()
    End Sub

    Public Sub Showdata()
        Dim st As String
        cn = New MySqlConnection(cs)
        cn.Open()
        st = "Select * from tbl_inventory"
        da = New MySqldataAdapter(st, cn)
        ds = New DataSet
        DataGridView1.DataSource = ds.Tables("tbl_inventory")
        da.Dispose()
        cn.Close()
        DataGridView1.Colums(0).Visible = False
    End Sub


    Sub reset()
        txitid.Clear()
        txtname.Clear()
        txtprocessor.Clear()
        txtproceccprod.clear()
        txtmotherboard.clear()
        txtmotherboadserial.clear()
        txtpsu.Clear()
        txtpsuserial.Clear()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click

        reset()
        btnsave.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False



    End Sub

    Private Sub btnexport_Click(sender As Object, e As EventArgs) Handles btnexport.Click

        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Curent = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try
            Dim excelBook As Excel.Workbook = xlApp.WorkBook.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook)
            xlApp.Visble = True

            rowsTotal = DataGridView1.RowCount - 1
            colsTotal = DataGridView1.Colums.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGrideView1.Columns(iC).HeaderText
                Next

                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Calls(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
                    Next j
                Next I

                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message."Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            xlApp = Nothing
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If Len(Trim(txtname.Text)) = 0 Then
            MessageBox.Show("Please Enter Computer Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtname.Focus()
        End If

        If Len(Trim(txtprocessor.Text)) = 0 Then
            MessageBox.Show("Please Enter Processor Serial Brand", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtprocessor.Focus()
        End If

        If Len(Trim(txtprocessorid.Text)) = 0 Then
            MessageBox.Show("Please Enter Processor Seroal Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtprosessor.Focus()
        End If


        If Len(Trim(txtmotherboard.Text)) = 0 Then
            MessageBox.Show("Please Enter Matherboad Brand", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtmotherboard.Focus()
        End If


        If Len(Trim(txtmatherboardserial.Text)) = 0 Then
            MessageBox.Show("Please Enter Motherboard Serial", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtmatherboardserial.Focus()
        End If

        If Len(Trim(txtpsu.Text)) = 0 Then
            MessageBox.Show("Please Enter PowerSupply", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtpsu.Focus()
        End If

        If Len(Trim(txthdd.Text)) = 0 Then
            MessageBox.Show("Please Enter Hard Drive Disk Brand", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txthdd.Focus()
        End If

        If Len(Trim(txthddsize.Text)) = 0 Then
            MessageBox.Show("Please Enter Hard Drive Disk Size", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txthddsize.Focus()
        End If

        If Len(Trim(txthddserial.Text)) = 0 Then
            MessageBox.Show("Please Enter Hard Drive Disk Serial", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txthddserial.Focus()
        End If

        If Len(Trim(txtmemory.Text)) = 0 Then
            MessageBox.Show("Please Enter Memory Model", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtmemory.Focus()
        End If

        If Len(Trim(txtmemorysize.Text)) = 0 Then
            MessageBox.Show("Please Enter Memory Size", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtmemorysize.Focus()
        End If

        If Len(Trim(txtmemoryserial.Text)) = 0 Then
            MessageBox.Show("Please Enter Memory Serial", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtmemoryserial.Focus()
        End If

        If Len(Trim(txtkeyboard.Text)) = 0 Then
            MessageBox.Show("Please Enter Keyboard Brand", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtkeyboard.Focus()
        End If

        If Len(Trim(txtkeyboardserial.Text)) = 0 Then
            MessageBox.Show("Please Enter Keyboard Serial", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtkeyboardserial.Focus()
        End If

        If Len(Trim(txtmouse.Text)) = 0 Then
            MessageBox.Show("Please Enter Mouse Brand", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtmouse.Focus()
        End If

        If Len(Trim(txtmouseserial.Text)) = 0 Then
            MessageBox.Show("Please Enter Mouse Brand Serial", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtmouseserial.Focus()
        End If

        Try
            cn = New MySqlConnection(cs)
            cn.Open()
            Dim cb As String = "Isert into tbl_inventory(ComputerName,Processor,ProcessorID,Motherboard,MotherboardSerial,PSU,PSUSrial,HDD,HDDSize,HDDSerial,MemoryModel,MemorySize,MemorySerial,KeyboardBrand,KeyboardSerial,MouseBrand,Serial)VALUES(@name,@processor,@processorid,@motherboard,@motherboardserial,@psu,@psuserial,@hdd@hddsize,@hddserial,@memorym,@memorysize.@memoryserial,@keyboard,@keyboardserialm,@mouse,@mousesirial)"
            cmd.Paramaters.AddWithValuse("@name", txtname.Text)
            cmd.Paramaters.AddWithValuse("@processor", txtprocessor.Text)
            cmd.Paramaters.AddWithValuse("@processorid", txtprocessorid.Text)
            cmd.Paramaters.AddWithValuse("@motherboard", txtmotherboard.Text)
            cmd.Paramaters.AddWithValuse("@psu", txtpsu.Text)
            cmd.Paramaters.AddWithValuse("@psuserial", txtpsuserial.Text)
            cmd.Paramaters.AddWithValuse("@hdd", txthdd.Text)
            cmd.Paramaters.AddWithValuse("@hddsize", txthddsize.Text)
            cmd.Paramaters.AddWithValuse("@hddserial", txthddserial.Text)
            cmd.Paramaters.AddWithValuse("@hddmemory", txtmemory.Text)
            cmd.Paramaters.AddWithValuse("@hddmemorysize", txtmemorysize.Text)
            cmd.Paramaters.AddWithValuse("@hddmemoryserial", txtmemoryserial.Text)
            cmd.Paramaters.AddWithValuse("@keyboard", txtkeyboard, Text)
            cmd.Paramaters.AddWithValuse("@keyboardserial", txtkeyboardserial.Text)
            cmd.Paramaters.AddWithValuse("@mouse", txtmouse.Text)
            cmd.ExcuteReader()

            cn.Close()
            Showdata()
            MessageBox.Show("Successfully saved", "Computer Inventory Asset", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnsave.Enabled = False
            reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try





    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        Try
            If MessageBox.Show("Do you really want to delete this recode?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                cn = New MySqlConnection(cs)
                cn.Open()

                'Dim cbv As String = "Update tbl_inventory set ComputerName = @name.Processor = @processor.ProcessorID = @processorid.Motherboard = @motherboard,MotherboardSerial = @motherboardserial, PSU = @psu, PSUSerial = @psuserial,HDD = @hdd,HDDSize,HDDSerial = @hddserial, MemoryModel = @memory, MemorySize = @memorysize,MemorySerial = @memoryserial, KeyboardBrand = @keyboard,keyboardSerial, MouseBrand = @mouse, MouseSerial = @mouseserial where ID = @id"
                Dim cb As String = " Delete from tbl_inventory where ID = @id"
                cmd = New MySqlCommand(cb)
                cmd.Paramaters.AddWithValue("@id", txtid.Text)
                cmd.Connection = cn
                cmd.ExecuteReader()
                cn.Close()
                Showdata()
                MessageBox.Show("Successfully deleted", "Computer Iventory Asset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reset()
                btnupdate.Enabled = False
                btndelete.Enabled = False
                btnsave.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChaenged

    Dim search As String = txtsearch.Text
    Try
        If txtsearch.Text = "" Then
            showdata()
        Else
            cn = New MySqlConnection(cs)
            cn.Open()
            Dim st As String
            st = "Select * from tbl_inventory where ComputerName like '" + search + "%' or Processo like"

        End If

    Catch ex As Exception
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

End Sub


