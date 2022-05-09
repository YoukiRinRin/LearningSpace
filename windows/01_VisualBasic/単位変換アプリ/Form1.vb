Public Class Form1

    Dim Amount As Integer '変換前の長さ
    Dim AmountConverted As Integer　'返還後の長さ

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Amount = 0
        Amount = TextBox1.Text

        If ComboBox1.SelectedIndex = -1 Then '単位の入力がない場合のエラーメッセージ
            Label1.Text = "選択されていません"
        ElseIf ComboBox1.Text = "cm" Then 'cmをmに変換
            Amount = Amount / 100
        ElseIf ComboBox1.Text = "km" Then 'kmをmに変換
            Amount = Amount * 100
        End If

        Label1.Text = Amount

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("cm")
        ComboBox1.Items.Add("m")
        ComboBox1.Items.Add("km")
    End Sub
End Class
