Module Module1

    Sub Main()

        Console.WriteLine("数値を三つ入力してね")

        Dim num1 As Integer = Console.ReadLine()
        Dim num2 As Integer = Console.ReadLine()
        Dim num3 As Integer = Console.ReadLine()

        Dim Num() As Integer

        If num1 > num2 Then
            If num1 > num3 Then
                Num(0) = num1
            ElseIf num1 < num3 Then
                Num(0) = num3
            End If
        ElseIf num1 < num2 Then
            If num3 < num2 Then
                Num(0) = num2
            End If



        End If



    End Sub

End Module
