Public Class 商品注文アプリ

    Dim Menu1Price = 300
    Dim Menu2Price = 500
    Dim Menu3Price = 400

    Dim Total As Integer


    Private Sub 商品注文アプリ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Menu1.Image = Image.FromFile("C:\Users\youki\source\repos\メニュー注文アプリ\お弁当メニュー\1981[1].jpg")
        Menu1.SizeMode = PictureBoxSizeMode.Zoom

        Menu2.Image = Image.FromFile("C:\Users\youki\source\repos\メニュー注文アプリ\お弁当メニュー\sp_2150[1].jpg")
        Menu2.SizeMode = PictureBoxSizeMode.Zoom

        Menu3.Image = Image.FromFile("C:\Users\youki\source\repos\メニュー注文アプリ\お弁当メニュー\sp_2449[1].jpg")
        Menu3.SizeMode = PictureBoxSizeMode.Zoom

        Label1.Text = ""
        Label2.Text = "円"
        Label3.Text = "合計"

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Total = Total + Menu1Price
        Else
            Total = Total - Menu1Price
        End If
        Label1.Text = Total
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Total = Total + Menu2Price
        Else
            Total = Total - Menu2Price
        End If
        Label1.Text = Total
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Total = Total + Menu3Price
        Else
            Total = Total - Menu3Price
        End If
        Label1.Text = Total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        MessageBox.Show("注文を承りました")

    End Sub
End Class
