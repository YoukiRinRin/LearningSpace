Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim ans As String

        Console.WriteLine("�J���~���Ă��܂����H")
        ans = Console.ReadLine()
        If ans = "y" Then
            Console.WriteLine("�P�������Ă����܂��傤�B")
        ElseIf ans = "n" Then
            Console.WriteLine("����͓܂�ł����H")
            ans = Console.ReadLine()
            If ans = "y" Then
                Console.WriteLine("�N�̈׎P�������Ă����܂��傤")
            ElseIf ans = "n" Then
                Console.WriteLine("�V�C�\��͌��܂������B")

            End If

        End If


    End Sub
End Module
