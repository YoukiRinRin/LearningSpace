Public Class Form1

    Dim Player1 = 0  'プレイヤー１の選んだ手
    Dim Player2 = 0 'プレイヤー１の選んだ手

    Dim Rock = 1 'グーを選択
    Dim Scissors = 2 'チョキを選択
    Dim Paper = 3 'パーを選択

    Dim Result As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RadioButton1.Text = "グー"
        RadioButton2.Text = "チョキ"
        RadioButton3.Text = "パー"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If RadioButton1.Checked = True Then
            Player1 = Rock
        ElseIf RadioButton2.Checked = True Then
            Player1 = Scissors
        ElseIf RadioButton3.Checked = True Then
            Player1 = Paper
        End If

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If RadioButton1.Checked = True Then
            Player2 = Rock
        ElseIf RadioButton2.Checked = True Then
            Player2 = Scissors
        ElseIf RadioButton3.Checked = True Then
            Player2 = Paper
        End If

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If Player1 = 0 Or Player2 = 0 Then

        End If

        Result = Player1 + Player2


        Select Case Result Then
            Case 3                  'グーとチョキの場合
                If Player1 = 1 Then
                    Label1.Text = 'Player1の勝ちです'　
                End If





    End Sub
End Class
