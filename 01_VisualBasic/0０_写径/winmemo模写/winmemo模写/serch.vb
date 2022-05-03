Public Class serch

    Dim st As TextBox
    Dim i As Integer



    Private Sub serch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub snext_Click(sender As Object, e As EventArgs) Handles snext.Click

        st = CType(Main.Tc.SelectedTab.Controls(0), TextBox)
        i = st.Text.IndexOf(sw.Text, i)
        Main.Focus()
        If 0 <= i Then
            st.Select(i, sw.Text.Length)
            st.Select()
            i += sw.Text.Length
        Else
            MsgBox("これ以上指定された文字列が見つかりません", 64)

        End If







    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click

    End Sub

    Private Sub sw_TextChanged(sender As Object, e As EventArgs) Handles sw.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class