Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim c1 As New Class1
        Dim c2 As New Class1
        Dim c3 As New Class1

        c1.setName("��")
        c2.setName("��")
        c3.setName("��")

        Console.WriteLine(c1.getName())
        Console.WriteLine(c2.getName())
        Console.WriteLine(c3.getName())

    End Sub
End Module
