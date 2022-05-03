Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim s As String = "あいうえお"

        'Dim s1 As String = s.Substring(0, 2)

        'Dim s2 As String = s.Substring(1, 3)

        'Dim s3 As String = s.Substring(3)

        'MessageBox.Show(s)
        'MessageBox.Show(s1)
        'MessageBox.Show(s2)
        'MessageBox.Show(s3)

        Dim s As String = "a" & ChrW(&H301) & "a" & ChrW(&H302) & "a" & ChrW(&H303) & "a" & ChrW(&H304) & ChrW(&H305)

        Dim si As New System.Globalization.StringInfo(s)

        Dim s1 As String = si.SubstringByTextElements(0, 2)
        Dim s2 As String = si.SubstringByTextElements(1, 3)
        Dim s3 As String = si.SubstringByTextElements(3)

        MessageBox.Show(s1)
        MessageBox.Show(s2)
        MessageBox.Show(s3)



    End Sub
End Class
