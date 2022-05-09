Public Class Form1

    Friend Teisi As Boolean = False
    Friend RepSaisei As Boolean = False
    Friend Syoon As Boolean = False
    Friend MusicSelect As Boolean = True

    Friend Cnt As Integer = 0
    Friend Adress1 As String
    Friend Name1 As String
    Friend Index1 As Integer

    Friend Jikan As Double = 0
    Friend T1 As Integer = 0
    Friend T2 As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Screen_Width As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim Screen_Heigh As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Size = New Size(768, 480)

        Me.MaximizeBox = Not Me.MaximizeBox
        Me.Location = New Point(CInt(Screen_Width \ 2 - Me.Width \ 2), CInt(Screen_Heigh \ 2 - Me.Height \ 2))
        Me.BackColor = Color.MidnightBlue
        Me.Text = "☆☆☆☆　My_Music Player2 ☆☆☆☆"

        Contlol_Add()
        Control_Condittion("s初期化")

        AddHandler Timer1.Tick, AddressOf Timer1_Tick
        AddHandler Timer2.Tick, AddressOf Timer2_Tick
        AddHandler Timer3.Tick, AddressOf Timer3_Tick

    End Sub
End Class
