Public Class Form1

    Dim No = 1 '問題番号
    Dim Answer = New Integer(4) {}　'回答を格納
    Dim Question As String() = {"Null", "問題文１", "問題文2", "問題文3", "問題文4"}　'問題文を格納
    Dim correct As Integer() = {1, 2, 3, 4} '正解番号を格納


    Dim Q1 As String() = {"Null", "い", "ろ", "は"}　'Q1の選択肢を格納
    Dim Q2 As String() = {"Null", "に", "ほ", "へ"}  'Q2の選択肢を格納
    Dim Q3 As String() = {"Null", "と", "ち", "り"}  'Q3の選択肢を格納
    Dim Q4 As String() = {"Null", "ぬ", "る", "お"}  'Q4の選択肢を格納

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "問" & No
        Label1.Text = Question(1)
        RadioButton1.Text = Q1(1)
        RadioButton2.Text = Q1(2)
        RadioButton3.Text = Q1(3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Select Case No '各問の回答を格納
            Case No = 1
                If RadioButton1.Checked = True Then
                    Answer(No) = 1
                ElseIf RadioButton2.Checked = True Then
                    Answer(No) = 2
                ElseIf RadioButton3.Checked = True Then
                    Answer(No) = 3
                End If
            Case No = 2
                If RadioButton1.Checked = True Then
                    Answer(No) = 1
                ElseIf RadioButton2.Checked = True Then
                    Answer(No) = 2
                ElseIf RadioButton3.Checked = True Then
                    Answer(No) = 3
                End If
            Case No = 3
                If RadioButton1.Checked = True Then
                    Answer(No) = 1
                ElseIf RadioButton2.Checked = True Then
                    Answer(No) = 2
                ElseIf RadioButton3.Checked = True Then
                    Answer(No) = 3
                End If
        End Select

        No = No + 1
        Label2.Text = "問" & No

        If No = 2 Then '各問題番号の回答の選択肢を表示
            Label1.Text = Question(No)
            RadioButton1.Text = Q2(1)
            RadioButton2.Text = Q2(2)
            RadioButton3.Text = Q2(3)
        ElseIf No = 3 Then
            Label1.Text = Question(No)
            RadioButton1.Text = Q3(1)
            RadioButton2.Text = Q3(2)
            RadioButton3.Text = Q3(3)
        ElseIf No = 4 Then
            Label1.Text = Question(No)
            RadioButton1.Text = Q4(1)
            RadioButton2.Text = Q4(2)
            RadioButton3.Text = Q4(3)
        ElseIf No = 5 Then
            MessageBox.Show("おわり")
        End If


    End Sub



End Class
