Imports System.IO

Public Class Main
    WithEvents tb As TextBox
    Dim tab As TabPage
    Dim f As Font = New Font("MS UI Gothic", 12)


    Private Sub 開く_Click(sender As Object, e As EventArgs) Handles 開く.Click
        Od.showDialog

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Od.InitialDirectory = My.Settings.file
        Od.ShowDialog()
        If My.Settings.fname <> "" Then
            f = New Font(My.Settings.fname, 12)
        End If
    End Sub

    Private Sub ShiftJIS_Click(sender As Object, e As EventArgs) Handles ShiftJIS.Click
        CType(Tc.SelectedTab.Controls(0), TextBox).Text =
            File.ReadAllText(Tc.SelectedTab.Tag, System.Text.Encoding.GetEncoding("Unicode"))
    End Sub

    Private Sub 終了_Click(sender As Object, e As EventArgs) Handles 終了.Click

    End Sub

    Private Sub fclose_Click(sender As Object, e As EventArgs) Handles fclose.Click
        If MsgBox("変更を保存しますか？", 36) = vbYes Then
            File.WriteAllText(Tc.SelectedTab.Tag, CType(Tc.SelectedTab.Controls(0), TextBox).Text,
                              System.Text.Encoding.GetEncoding("SHIFT-jis"))
        End If
        Tc.SelectedTab.Dispose()
        If Tc.TabCount = 0 Then
            Application.Exit()
        End If
    End Sub

    Private Sub Od_FileOk() Handles Od.FileOk
        Call dcandfc()
    End Sub

    Private Sub 終了_Click() Handles 終了.Click
        Application.Exit()
    End Sub

    Private Sub Ow_Click() Handles Ow.Click
        File.WriteAllText(Tc.SelectTab.Tag, CType(Tc.SelectTab.Controls(0), TextBox), Text,
                          System.Text.Encoding.GetEncoding("SHIFT-jis"))
    End Sub

    Private Sub sFont_Click(sender As Object, e As EventArgs) Handles sFont.Click
        Fd.Font = Tc.SelectTab.Controls(0).Font
        If Fd.ShoeDialog <> DialogResult.Cancel Then
            f = Fd.Font
            My.Settings.fname = Fd.Font.Name

            Dim s(4) As String
            For i = 0 To Tc.TabCount - 1
                s(i) = Tc.SelectedTab.Tag
            Next
            Tc.TabPages.Clear()
            For i = 0 To 4
                dcandfc(True, s(i))
            Next
        End If
    End Sub

    Sub dcandfc(Optional ByVal b As Boolean = False, Optional s As String = "")
        Try
            If Tc.TabCount <= 5 Then
                tb = New TextBox
                With tb
                    .ScrollBars = ScrollBars.Both
                    .Multiline = True
                    .Font = f
                    .Size = New Size(Tc.Width, Tc.Height)
                    .Dock = DockStyle.Fill
                End With

                tab = New TabPage
                If b = False Then
                    tab.Text = IO.Path.GetFileName(Od.FileName)
                    tab.Tag = Od.FileName

                End If



            End If

        Catch ex As Exception

        End Try

    End Sub


End Class
