Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim num1 As Integer = 0
        Try
            Dim ans As Integer = calc1(num1)
        Catch ex As testException
            Console.WriteLine(ex.Message)
        Finally
            Console.WriteLine("ˆ—‚ªI—¹‚µ‚Ü‚µ‚½")
        End Try


    End Sub

    Private Function calc1(num1 As Integer)

        If num1 = 1 Then
            Throw New Exception("ƒGƒ‰[‚ğ“Š‚°‚Ü‚·")
        End If
        Return num1
    End Function



End Module
