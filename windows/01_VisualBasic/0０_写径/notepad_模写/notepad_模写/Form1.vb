Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub SetFileTextValue(ByVal TotalLine As Integer, ByVal TotalChar As Integer, ByVal TotalWord As Integer)
        If ClsNotepad.FileLoad = True Then
            Lbl_GetFileTotalLines.Text = TotalLine


        End If


    End Sub


End Class


Public Module ClassLink
    Public ClsNotepad As New UICode.Notepad
    Public ClsSYsSpeech As New UICode.SysSpeech
    Public RTFIleIntfor As UIForm.FileInfor
End Module

