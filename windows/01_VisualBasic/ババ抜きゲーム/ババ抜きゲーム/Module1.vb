Module Module1

    Dim Player1() As Integer
    Dim Player2() As Integer

    Dim Deck() As Integer


    'Dim Heart_1 As New card
    'Dim Heart_2 As New card
    'Dim Heart_3 As New card
    'Dim Heart_4 As New card
    'Dim Heart_5 As New card
    'Dim Heart_6 As New card
    'Dim Heart_7 As New card
    'Dim Heart_8 As New card
    'Dim Heart_9 As New card
    'Dim Heart_10 As New card
    'Dim Heart_11 As New card
    'Dim Heart_12 As New card
    'Dim Heart_13 As New card

    'Dim Spade_1 As New card
    'Dim Spade_2 As New card
    'Dim Spade_3 As New card
    'Dim Spade_4 As New card
    'Dim Spade_5 As New card
    'Dim Spade_6 As New card
    'Dim Spade_7 As New card
    'Dim Spade_8 As New card
    'Dim Spade_9 As New card
    'Dim Spade_10 As New card
    'Dim Spade_11 As New card
    'Dim Spade_12 As New card
    'Dim Spade_13 As New card

    'Dim Clorver_1 As New card
    'Dim Clorver_2 As New card
    'Dim Clorver_3 As New card
    'Dim Clorver_4 As New card
    'Dim Clorver_5 As New card
    'Dim Clorver_6 As New card
    'Dim Clorver_7 As New card
    'Dim Clorver_8 As New card
    'Dim Clorver_9 As New card
    'Dim Clorver_10 As New card
    'Dim Clorver_11 As New card
    'Dim Clorver_12 As New card
    'Dim Clorver_13 As New card

    'Dim Dia_1 As New card
    'Dim Dia_2 As New card
    'Dim Dia_3 As New card
    'Dim Dia_4 As New card
    'Dim Dia_5 As New card
    'Dim Dia_6 As New card
    'Dim Dia_7 As New card
    'Dim Dia_8 As New card
    'Dim Dia_9 As New card
    'Dim Dia_10 As New card
    'Dim Dia_11 As New card
    'Dim Dia_12 As New card
    'Dim Dia_13 As New card




    'Dim H_1 As New card
    'Dim H_2 As New card
    'Dim Heart_3 As New card
    'Dim Heart_4 As New card
    'Dim Heart_5 As New card
    'Dim Heart_6 As New card
    'Dim Heart_7 As New card
    'Dim Heart_8 As New card
    'Dim Heart_9 As New card
    'Dim Heart_10 As New card
    'Dim Heart_11 As New card
    'Dim Heart_12 As New card
    'Dim Heart_13 As New card

    'Dim Spade_1 As New card
    'Dim Spade_2 As New card
    'Dim Spade_3 As New card
    'Dim Spade_4 As New card
    'Dim Spade_5 As New card
    'Dim Spade_6 As New card
    'Dim Spade_7 As New card
    'Dim Spade_8 As New card
    'Dim Spade_9 As New card
    'Dim Spade_10 As New card
    'Dim Spade_11 As New card
    'Dim Spade_12 As New card
    'Dim Spade_13 As New card

    'Dim Clorver_1 As New card
    'Dim Clorver_2 As New card
    'Dim Clorver_3 As New card
    'Dim Clorver_4 As New card
    'Dim Clorver_5 As New card
    'Dim Clorver_6 As New card
    'Dim Clorver_7 As New card
    'Dim Clorver_8 As New card
    'Dim Clorver_9 As New card
    'Dim Clorver_10 As New card
    'Dim Clorver_11 As New card
    'Dim Clorver_12 As New card
    'Dim Clorver_13 As New card

    'Dim Dia_1 As New card
    'Dim Dia_2 As New card
    'Dim Dia_3 As New card
    'Dim Dia_4 As New card
    'Dim Dia_5 As New card
    'Dim Dia_6 As New card
    'Dim Dia_7 As New card
    'Dim Dia_8 As New card
    'Dim Dia_9 As New card
    'Dim Dia_10 As New card
    'Dim Dia_11 As New card
    'Dim Dia_12 As New card
    'Dim Dia_13 As New card




    Dim Card_1 As New card
    Dim Card_2 As New card
    Dim Card_3 As New card
    Dim Card_4 As New card
    Dim Card_5 As New card
    Dim Card_6 As New card
    Dim Card_7 As New card
    Dim Card_8 As New card
    Dim Card_9 As New card
    Dim Card_10 As New card
    Dim Card_11 As New card
    Dim Card_12 As New card
    Dim Card_13 As New card







    'カードは4×13種類
    'スペード = s　クローバ = k　ハート = h　ダイヤ = d ×　1～13 +　ジョーカー　＝　ｊ

    Sub Main()
        Dim Card_1 As New card
        Dim Mark() As String = {"H", "S", "D", "C"}
        Dim Num As Integer

        Dim Base_C As String = "Card_"

        For Ix As Integer = 1 To 13

            Dim Card_N As String
            Card_N = Base_C + Ix

            Card_1.Num = Ix

        Next





    End Sub


    '山札をシャッフルする
    Private Sub Shuffle()

        '配列Deckにカードを順番に格納する

        Dim ix = 0

        For ix = 0 To 12
            Deck(ix) = 



        Next




    End Sub

    'カードを分配する
    Private Sub Distribtion()

    End Sub

    '同じカードが当た場合捨てる
    Private Sub Throw_away()

    End Sub




End Module
