Public Class Form1

    Dim Ichigo As Integer
    Dim Ringo As Integer
    Dim Banana As Integer

    Dim Cost As Integer



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If RadioButton1.Checked = True Then

            Ichigo = 400
        Else
            Ichigo = 0
        End If

        If RadioButton2.Checked = True Then

            Ringo = 100
        Else
            Ringo = 0
        End If

        If RadioButton3.Checked = True Then

            Banana = 200
        Else
            Banana = 0
        End If


        Cost = Ichigo + Ringo + Banana

        Label2.Text = Cost



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MessageBox.Show("注文を完了しました")

    End Sub


End Class
