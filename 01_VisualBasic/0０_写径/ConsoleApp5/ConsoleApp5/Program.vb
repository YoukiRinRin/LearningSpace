Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim num1 As Integer = 4
        Dim num2 As Integer = 0

        Try
            Dim ans As Integer = cals1(num1, num2)
            Console.WriteLine(ans)

        Catch ex As ArithmeticException
            Console.WriteLine(ex.Message)
        Finally
            Console.WriteLine("ˆ—‚ªI—¹‚µ‚Ü‚µ‚½")

        End Try




    End Sub
    Private Function cals1(num1 As Integer, num2 As Integer)
        Return num1 / num2
    End Function
End Module
