Module Module1

    Dim B_Height As Integer
    Dim B_Width As Integer
    Dim A_Height As Integer
    Dim A_Width As Integer

    Dim Field(9, 9) As Integer '左:縦　右:横

    Dim Player1 As Integer
    Dim Player2 As Integer

    Dim Motigoma1() As Integer '1P持ち駒
    Dim Motigoma2() As Integer '2P持ち駒

    Dim Oushou As Integer = 1 '王将
    Dim Gyokushou As Integer = 11 '玉将

    Dim Hisha As Integer = 2 '飛車
    Dim Kakugyou As Integer = 3 '角行
    Dim Kinshou As Integer = 4 '金将
    Dim Ginshou As Integer = 5 '銀将
    Dim Keima As Integer = 6　'桂馬
    Dim Kyousha As Integer = 7 '香車
    Dim Hohei As Integer = 8 '歩兵

    Dim Koma = New String() {"□", "王", "飛", "角", "金", "銀", "桂", "香", "歩", "■", "□",
                                   "玉", "飛", "角", "金", "銀", "桂", "香", "歩"}
    Dim Koma_selected As Integer

    Sub Main()

        '駒の初期配置
        '玉将
        Field(1, 5) = 11 'Player2
        '王将
        Field(9, 5) = 1 'Player1
        '飛車
        Field(2, 2) = 12 'Player2
        Field(8, 8) = 2 'Player1
        '角行
        Field(2, 8) = 13 'Player2
        Field(8, 2) = 3 'Player1
        '金将
        Field(1, 4) = 14 'Player2
        Field(1, 6) = 14
        Field(9, 4) = 4 'Player1
        Field(9, 6) = 4
        '銀将
        Field(1, 3) = 15 'Player2
        Field(1, 7) = 15
        Field(9, 3) = 5 'Player1
        Field(9, 7) = 5
        '桂馬
        Field(1, 2) = 16 'Player2
        Field(1, 8) = 6
        Field(9, 2) = 6 'Player1
        Field(9, 8) = 6
        '香車
        Field(1, 1) = 17 'Player2
        Field(1, 9) = 17
        Field(9, 1) = 7 'Player1
        Field(9, 9) = 7
        '歩兵を3行め７行目に配置
        For x As Integer = 1 To 9
            Field(3, x) = 18 'Player2
            Field(7, x) = 8 'Player1
        Next

        Do While Player1 = 0
            '盤上を出力
            'Console.Write()
            Console.WriteLine()
            For i As Integer = 1 To 9
                For j As Integer = 1 To 9
                    Console.Write(Koma(Field(i, j)))
                    If j = 9 Then
                        Console.Write(i)
                        Console.WriteLine()
                    End If
                Next
            Next

            Console.WriteLine("動かす駒を指定してください：")
            If Integer.TryParse(Console.ReadLine(), B_Height) = False Then
                Console.WriteLine("正しい値を入力して下さい")
            End If
            If Integer.TryParse(Console.ReadLine(), B_Width) = False Then
                Console.WriteLine("正しい値を入力して下さい")
            End If
            Koma_selected = Field(B_Height, B_Width)

            F_Oushou()

            Console.WriteLine("(" & B_Height & "," & B_Width & ")" & Koma(Field(B_Height, B_Width)) & "を何所に置きますか:")
            If Integer.TryParse(Console.ReadLine(), A_Height) = False Then
                Console.WriteLine("正しい値を入力して下さい")
            End If
            If Integer.TryParse(Console.ReadLine(), A_Width) = False Then
                Console.WriteLine("正しい値を入力して下さい")
            End If

            Field(A_Height, A_Width) = Koma_selected
            Field(B_Height, B_Width) = 0



            Field(2, 5) = Gyokushou
            Field(1, 5) = 0


        Loop

        Console.ReadLine()
    End Sub

    '駒が動ける場所の判定用
    Dim Migi As Integer　'右
    Dim Hidari As Integer '左
    Dim Ue As Integer '上
    Dim Sita As Integer '下
    Dim Migi_Ue As Integer '右上
    Dim Hidari_Ue As Integer '左下
    Dim Migi_Shita As Integer '右下
    Dim Hidari_Shita As Integer '左下

    Public Function F_Oushou() As Integer

        Console.WriteLine("置ける場所:(" & B_Height & "," & B_Width + 1 & "),(" & B_Height & "," & B_Width - 1 & ")")

        '右に何があるか判定
        If Field(B_Height, B_Width + 1) = 0 Then
            '何もなくそこに置ければ１
            Migi = 1
        ElseIf Field(B_Height, B_Width + 1) > 1 And Field(B_Height, B_Width + 1) < 10 Then
            '味方の駒があれば２
            Migi = 2
        ElseIf Field(B_Height, B_Width + 1) > 10 And Field(B_Height, B_Width + 1) < 20 Then
            '敵の駒があれば３
            Migi = 3
        Else
            'それ以外は０
            Migi = 0
        End If

        '左に何があるか判定
        If Field(B_Height, B_Width - 1) = 0 Then
            Hidari = 1
        ElseIf Field(B_Height, B_Width - 1) > 1 And Field(B_Height, B_Width - 1) < 10 Then
            Hidari = 2
        ElseIf Field(B_Height, B_Width - 1) > 10 And Field(B_Height, B_Width - 1) < 20 Then
            Hidari = 3
        Else
            Hidari = 0
        End If

        '上に何があるか判定
        If Field(B_Height - 1, B_Width) = 0 Then
            Ue = 1
        ElseIf Field(B_Height + 1, B_Width) > 1 And Field(B_Height + 1, B_Width) < 10 Then
            Ue = 2
        ElseIf Field(B_Height + 1, B_Width) > 10 And Field(B_Height + 1, B_Width) < 20 Then
            Ue = 3
        Else
            Ue = 0
        End If

        '下に何があるか判定
        If Field(B_Height + 1, B_Width) = 0 Then
            Sita = 1
        ElseIf Field(B_Height - 1, B_Width) > 1 And Field(B_Height - 1, B_Width) < 10 Then
            Sita = 2
        ElseIf Field(B_Height - 1, B_Width) > 10 And Field(B_Height - 1, B_Width) < 20 Then
            Sita = 3
        Else
            Sita = 0
        End If

        '右上に何があるか判定
        If Field(B_Height + 1, B_Width + 1) = 0 Then
            Migi_Ue = 1
        ElseIf Field(B_Height + 1, B_Width + 1) > 1 And Field(B_Height + 1, B_Width + 1) < 10 Then
            Migi_Ue = 2
        ElseIf Field(B_Height + 1, B_Width + 1) > 10 And Field(B_Height + 1, B_Width + 1) < 20 Then
            Migi_Ue = 3
        Else
            Migi_Ue = 0
        End If

        '左上に何があるか判定
        If Field(B_Height + 1, B_Width - 1) = 0 Then
            Hidari_Ue = 1
        ElseIf Field(B_Height + 1, B_Width - 1) > 1 And Field(B_Height + 1, B_Width - 1) < 10 Then
            Hidari_Ue = 2
        ElseIf Field(B_Height + 1, B_Width + 1) > 10 And Field(B_Height + 1, B_Width - 1) < 20 Then
            Hidari_Ue = 3
        Else
            Hidari_Ue = 0
        End If

        '右下に何があるか判定
        If Field(B_Height - 1, B_Width + 1) = 0 Then
            Migi_Shita = 1
        ElseIf Field(B_Height - 1, B_Width + 1) > 1 And Field(B_Height - 1, B_Width + 1) < 10 Then
            Migi_Shita = 2
        ElseIf Field(B_Height - 1, B_Width + 1) > 10 And Field(B_Height - 1, B_Width + 1) < 20 Then
            Migi_Shita = 3
        Else
            Migi_Shita = 0
        End If

        '左下に何があるか判定
        If Field(B_Height - 1, B_Width - 1) = 0 Then
            Hidari_Shita = 1
        ElseIf Field(B_Height - 1, B_Width - 1) > 1 And Field(B_Height - 1, B_Width - 1) < 10 Then
            Hidari_Shita = 2
        ElseIf Field(B_Height - 1, B_Width - 1) > 10 And Field(B_Height - 1, B_Width - 1) < 20 Then
            Hidari_Shita = 3
        Else
            Hidari_Shita = 0
        End If

        Select Case Migi
            Case 1

        End Select
        'Field(B_Height, B_Width + 1)
        'Field(B_Height, B_Width - 1)
        'Field(B_Height + 1, B_Width) 
        'Field(B_Height - 1, B_Width) 


        'Field(B_Height + 1, B_Width + 1) 
        'Field(B_Height + 1, B_Width - 1) 
        'Field(B_Height - 1, B_Width + 1) 
        'Field(B_Height - 1, B_Width - 1) 

    End Function

    Public Function F_Gyokushou() As Integer

    End Function

    Public Function F_Hisha() As Integer

        Do While Migi <> 0
            If Field(B_Height, B_Width + 1) = 0 Then
                Migi = 1
            ElseIf Field(B_Height, B_Width + 1) > 1 And Field(B_Height, B_Width + 1) < 10 Then
                Migi = 2
            ElseIf Field(B_Height, B_Width + 1) > 10 And Field(B_Height, B_Width + 1) < 20 Then
                Migi = 3
            Else
                Migi = 0
            End If
            B_Width = B_Width + 1
        Loop

        Do While Hidari <> 0
            If Field(B_Height, B_Width - 1) = 0 Then
                Hidari = 1
            ElseIf Field(B_Height, B_Width - 1) > 1 And Field(B_Height, B_Width - 1) < 10 Then
                Hidari = 2
            ElseIf Field(B_Height, B_Width - 1) > 10 And Field(B_Height, B_Width - 1) < 20 Then
                Hidari = 3
            Else
                Hidari = 0
            End If
            Hidari = Hidari - 1
        Loop

        Do While Ue <> 0
            If Field(B_Height - 1, B_Width) = 0 Then
                Hidari = 1
            ElseIf Field(B_Height - 1, B_Width) > 1 And Field(B_Height - 1, B_Width - 1) < 10 Then
                Hidari = 2
            ElseIf Field(B_Height - 1, B_Width - 1) > 10 And Field(B_Height - 1, B_Width - 1) < 20 Then
                Hidari = 3
            Else
                Hidari = 0
            End If
            Hidari = Hidari - 1
        Loop


    End Function

    Public Function F_Kakugyou() As Integer

    End Function

    Public Function F_Kinshou() As Integer

    End Function

    Public Function F_Ginshou() As Integer

    End Function

    Public Function F_Keima() As Integer

    End Function

    Public Function F_Kyousha() As Integer

    End Function

    Public Function F_Hohei() As Integer

    End Function










End Module
