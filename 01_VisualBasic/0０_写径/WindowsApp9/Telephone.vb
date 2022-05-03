Imports Microsoft.VisualBasic

Public Class Telephone

    Private Declare Ansi Function PlaySound Lib "Winmm.dll" Alias "PlaySoundA" (ByVal lpzName As String, ByVal dwFlags As Integer) As Integer

    Private Const SND_ASYNC = &H1

    Public Sub Bell()
        Dim WaveFile As String

        WaveFile = Enviroment.GerEnviromentVariable("WINDIR") & "\media\ringin.wav"
        PlaySound(WaveFile, 0, SND_ASYNC)

    End Sub


End Class
