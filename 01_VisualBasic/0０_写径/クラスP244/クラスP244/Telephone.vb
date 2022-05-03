Public Class Telephone

    Private Declare Ansi Function PlaySound Lib "winmm.dll" Alias "PlaySoundA" (ByVal lpsxName As String, ByVal hModule As Integer, ByVal dwFlags As Integer) As Integer

    Private Const SND_ASYNC = &H1

    Public Sub Bell()

        Dim WaveFile As String

        WaveFile = Environment.GetEnvironmentVariable("WINDIR") & "\media\ringin.wav"
        PlaySound(WaveFile, 0, SND_ASYNC)

    End Sub


End Class
