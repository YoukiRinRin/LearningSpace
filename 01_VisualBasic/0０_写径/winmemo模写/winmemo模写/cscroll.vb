Public Class cscroll
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Main.Tc.Tag < NumericUpDown1.Value Then
            For i = Main.Tc.Tag To NumericUpDown1.Value
                SendKeys.Send("{Down}")
            Next
        ElseIf Main.Tc.Tag > NumericUpDown1.Value Then
            For i = Main.Tc.Tag To NumericUpDown1.Value Step -1
                SendKeys.Send("{Up}")
            Next
        End If
        Me.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class