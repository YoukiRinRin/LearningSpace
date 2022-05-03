Public Class Form1

    Private Button1 As System.Windows.Forms.Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Button1 = New System.Windows.Forms.Button()

        Me.Button1.Name = "Button1"
        Me.Button1.Text = "押してね"

        Me.Button1.Location = New Point(10, 10)
        Me.Button1.Size = New System.Drawing.Size(80, 20)

        Me.Controls.Add(Me.Button1)
    End Sub

    Private Sub Button1_Click(ByVal sender As Object,
                             ByVal e As EventArgs)
        Dim x As Long

        x = FileLen("W:\01_Youki\Desktop\heart-panty136012.jpg")

        MessageBox.Show("うんちー！")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim x As Long

        x = FileLen("W:\01_Youki\Desktop\heart-panty136012.jpg")

        MessageBox.Show(x)





        Dim s As String = "こんにちは"

        If Not s Is Nothing Then

            Dim len As Integer = s.Length

            MessageBox.Show(s)
            MessageBox.Show(len)


        End If




    End Sub
End Class
