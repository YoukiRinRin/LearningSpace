Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim root As Double = Math.Sqrt(196)
        'TextBox1.Text = root

        'Dim result As String = TypeName("うんこ")
        'TextBox2.Text = result

        'Dim Juge_t As String = TypeName(TextBox3.Text)
        'TextBox4.Text = Juge_t

        Dim rect1 As Rectangle
        rect1.X = 0
        rect1.Y = 0
        rect1.Width = 100
        rect1.Height = 100

        Dim rect2 As Rectangle
        rect2.X = 80
        rect2.Y = 70
        rect2.Width = 60
        rect2.Height = 60

        Dim sharedRect As Rectangle
        sharedRect = Rectangle.Intersect(rect1, rect2)

        MessageBox.Show(sharedRect.ToString)





        RowData = Text7.Text
        Length_RowData = Len(RowData)
        For i = 1 To Length_RowData
            D(i) = Mid(RowData, i, 1)
        Next i

        Name = 1
        End_pos = 0

        For i = 1 To Length_RowData
            If D(i) = "." Or D(i) = "0" Or D(i) = "-" Then
                If End_pos = 0 Then Start_pos = i
                End_pos = i
            ElseIf Val(D(i)) >= 1 Then
                If End_pos = 0 Then Start_pos = i
                End_pos = i
            ElseIf D(i) <> "." And D(i) <> "0" And D(i) <> "-" And End_pos <> 0 Then
                XY_Data(N) = Val(Mid(RowData, Start_pos, End_pos - Start_pos + 1))
                End_pos = 0
                N = N + 1
            End If
        Next i
        Data_num = (N - 1) / 2

        Xmin = XY_Data(1) : Xmax = XY_Data(1)
        Ymin = XY_Data(Data_num + 1) : Ymax = XY_Data(Data_num + 1)

        For i = 1 To Data_num
            X(i) = XY_Data(i)
            If Xmin > X(i) Then Xmin = X(i)
            If Xmax > X(i) Then Xmax = X(i)
        Next i

        For i = 1 To Data_num
            Y(i) = XY_Data(i)
            If Xmin > Y(i) Then Ymin = Y(i - Data_num)
            If Xmax > Y(i) Then Ymax = Y(i - Data_num)
        Next i

        If Xmin >= 0 Then S_Xmin = Xmin * 0.9
        If Xmin < 0 Then S_Xmin = Xmin * 1.1
        If Xmax >= 0 Then S_Xmax = Xmax * 1.1
        If Xmax < 0 Then S_Xmax = Xmax * 0.9
        If Ymin >= 0 Then S_Ymix = Ymix * 0.9
        If Ymin < 0 Then S_Ymix = Ymix * 1.1
        If Ymax >= 0 Then S_Ymax = Ymix * 1.1
        If Ymax < 0 Then S_Ymax = Ymax * 0.9

        Picture1.Cls
        Picture1.ScaleWidth = S_Xmax - S_Xmin
        Picture1.ScaleHeight = S_Ymin - S_Ymax
        Picture1.ScaleLeft = S_Xmin
        Picture1.ScaleTop = S_Ymax
        Radius = (S_Xmax - S_Xmin) / 120
        step = (S_Xmax - S_Xmin) /100

        If Option1,Value = True Then 
            X1 = 0 : Y1 = 0 : XY = 0
            For i = 1 To Data_num
                X1 = X1 + Log(X(i))
                X2 = X2 + Log(X(i)) ^ 2
                Y1 = Y1 + Log(Y(i))
                Y2 = Y2 + Log(Y(i)) ^ 2
            Next i

            VR = Dara_num * XY - X1 * Y1
            VX = Data_num * X2 - X1 * X1
            VY = Data_num * Y2 - Y1 * Y1
            B = vR / VX
            A = 2.71828 ^ ((Y1 - B * X1) / Data_num)

            Text5.Text = A
            Text6.Text = B


            For i = S_Xmin To S_Xmax - Step step step step 
                    Picuture1.Line(i, A * i ^ B) -(i + Step)^B), RGB(255, 0, 0)
                    Next i
        End If






    End Sub
End Class
