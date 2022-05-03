Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim ans As String

        Console.WriteLine("雨が降っていますか？")
        ans = Console.ReadLine()
        If ans = "y" Then
            Console.WriteLine("傘を持っていきましょう。")
        ElseIf ans = "n" Then
            Console.WriteLine("そらは曇りですか？")
            ans = Console.ReadLine()
            If ans = "y" Then
                Console.WriteLine("年の為傘を持っていきましょう")
            ElseIf ans = "n" Then
                Console.WriteLine("天気予報は見ましたか。")

            End If

        End If


    End Sub
End Module
