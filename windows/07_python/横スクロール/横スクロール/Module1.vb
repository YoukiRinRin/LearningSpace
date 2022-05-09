Module Module1

    Sub Main()


        Dim F_Hight = 20
        Dim F_Weight = 50
        Dim Filed(F_Weight, F_Hight) As String
        Dim Player As String
        Dim Enemy As String

        Player = "〇"
        Enemy = "☆"

        'ステージ作成
        For ix As Integer = 0 To F_Hight
            For ix2 As Integer = 0 To F_Weight
                Filed(ix2, ix) = "■"
                If ix < 17 Then
                    Filed(ix2, ix) = " "
                Else
                    Filed(ix2, ix) = "■"
                End If
            Next
        Next
        For ix As Integer = 0 To F_Hight
            For ix2 As Integer = 0 To F_Weight
                Console.Write(Filed(ix2, ix))
                If ix2 = F_Weight Then
                    Console.Write(vbCrLf)
                End If
            Next
        Next









        Console.ReadLine()
    End Sub

End Module
