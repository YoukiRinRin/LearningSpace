Public Class Form1

    Dim MyLabel As New Label()
    Dim MytextBox As New TextBox()



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        MyLabel.Text = "今日の日付"
        MyLabel.Location = New Point(25, 60)

        MytextBox.Text = Now.ToLongDateString
        MytextBox.Location = New Point(25, 90)
        MytextBox.Size = New Size(200, 20)

        Me.Controls.Add(MyLabel)
        Me.Controls.Add(MytextBox)

        Button1.Visible = False
        Button2.Visible = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Visible = False
    End Sub
End Class
