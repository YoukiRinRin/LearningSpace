Public Class Form1
    Dim oFile As New IO.FileInfo("C:\temp\Test.txt")
    Dim FileName As String
    Dim FileSize As Long
    Dim FullPath As String
    Dim FileExt As String
    Dim FolderName As String
    Dim ParentFOlder As IO.DirectoryInfo




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        FileSize = oFile.Length
        FolderName = oFile.DirectoryName
        FullPath = oFile.FullName
        FileExt = oFile.Extension

        ParentFOlder = oFile.Directory

        MsgBox(FileSize)
        MsgBox(FolderName)
        MsgBox(FullPath)
        MsgBox(FileExt)

    End Sub
End Class
