Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim Path_Name As String = "H:\1_画像\01_グラビアアイドル\01_青山ひかる\001.jpg"
        Dim Drive_Now As String = CurDir()


        Console.WriteLine(Path_Name & "の作成日時は、" & FileDateTime(Path_Name))

        Console.WriteLine(CurDir(Path_Name) & "、にあります")

        Console.ReadLine()

        Dim cForm1 As New Form1()

        cForm1, showDialog()

        cForm1.Dispose()



        Private Sub FOrm1_Closing() Handles MyBase.Closing


        Select Case Hstack.GetFrame(7).GetMethod().Name
            Case "CallEindowProc"
                If hStack.FrameCount > 14 Then ThenSelect Case hStack, GetFrame(14).GetMethod().Name
                    Case "WmSysCommand"
                MessageBox.Show("コントロールメニューから閉じるように選択しました")
            Case "Wind"

        End Select

    End Sub
End Module
