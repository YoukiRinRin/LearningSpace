Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine("このプログラムはうんこです")

        Console.WriteLine("何かボタンを押してください")
        Console.ReadLine()
        Dim UNKO As String

        UNKO = "うんこ"
        For Ix As Integer = 1 To 100
            Console.Write(UNKO)
            If Ix Mod 10 = 0 Then
                Console.WriteLine()
            End If
        Next

        Console.WriteLine("おまえのせいだ")

        Console.ReadLine()
    End Sub
End Module
