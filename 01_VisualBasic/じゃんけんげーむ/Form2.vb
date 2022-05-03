Public Class Form2
    Dim hand_player As Integer
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hand_player = 1
        show_message()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        hand_player = 3
        show_message()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hand_player = 2
        show_message()
    End Sub

    Sub show_message()
        Dim result As DialogResult = MessageBox.Show("じゃ～んけん")
        If result = DialogResult.OK Then
            Form3.ShowDialog(Me)
            Me.Close()
        End If

    End Sub
End Class