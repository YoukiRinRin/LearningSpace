Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine("���̃v���O�����͂��񂱂ł�")

        Console.WriteLine("�����{�^���������Ă�������")
        Console.ReadLine()
        Dim UNKO As String

        UNKO = "����"
        For Ix As Integer = 1 To 100
            Console.Write(UNKO)
            If Ix Mod 10 = 0 Then
                Console.WriteLine()
            End If
        Next

        Console.WriteLine("���܂��̂�����")

        Console.ReadLine()
    End Sub
End Module
