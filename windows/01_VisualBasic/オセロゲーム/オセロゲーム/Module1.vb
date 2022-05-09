Module Module1

    Public Field(7, 7) As String

    Sub Main()
        For Ix1 As Integer = 0 To 7
            For Ix2 As Integer = 0 To 7
                Field(Ix1, Ix2) = "■"
            Next
        Next

        Field(3, 3) = "〇"
        Field(3, 4) = "●"
        Field(4, 3) = "●"
        Field(4, 4) = "〇"

        Dim a As Integer
        Dis_Field()

        Console.WriteLine("")

    End Sub

    Public Sub Dis_Field()
        For Ix3 As Integer = 0 To 7
            For Ix4 As Integer = 0 To 7
                Console.Write(Field(Ix3, Ix4))
                If Ix4 = 7 Then
                    Console.Write(vbCrLf)
                End If
            Next
        Next
    End Sub




End Module
