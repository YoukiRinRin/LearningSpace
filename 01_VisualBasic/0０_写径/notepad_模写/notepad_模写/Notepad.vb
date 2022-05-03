Public Class Notepad
    Private Sub Notepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Open(ByVal TextBox As TextBox, ByVal Form As Form)
        Dim _OpenFile As New OpenFileDialog With {
            .Filter = "Open Text File|*.txt|Open With Other Extension|*.*",
            .FilterIndex = "1"
            }
        If _OpenFile.ShowDialog = MsgBoxResult.Ok Then
            TextBox.Text = My.Computer.FileSystem.ReadAllText(_OpenFile.FileName)
            SetVales(True, _OpenFile.FileName, Form)
        End If
    End Sub

    Public Sub OpenAs(ByValTextBox As TextBox, ByVal Form As Form)

        Dim _OpenFile As New OpenFileDialog With {
            .Filter = "OpenAs Texzt File"}




    End Sub


    Public Function ClosingAlert(ByVal TextBox As TextBox, B　Form As Form) As Boolean
        Dim _GetAction As Boolean
        Dim _GetFileName As String

        If String.IsNullOrWhiteSpace(_FileName) Then
            _GetFileName = String.Empty
        Else
            _GetFileName = vbNewLine & ""
        End If

        If _TextChange = True Then
            Select Case MessageBox.Show("Text dcument has been changed," &
                                        vbNewLine & "do you want to save the changes?" & _GetFileName,
"Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                Case DialogResult.Cancel
                    _GetAction = True
                Case DialogResult.No
                    _GetAction = False
                Case DialogResult.Yes
                    _GetAction = False
            End Select
            _GetAction = False
        End If
        Return _GetAction
    End Function

    Public Sub NewTextDocument(ByVal TextBox As TextBox, ByVal Form As Form)
        TextBox.Clear()
        SetVales(False, "", Form)
    End Sub
    Public Sub Open(ByVal TextBox As TextBox, ByVal Form As Form)

        Dim _OpenFile As New OpenFileDialog With ｛
            .Filter = "Open text File|*.txt|Open With Other Extension|*.*",
            .FilterIndex = "1"
            }
        If _OpenFile.ShowDialog = MsgBoxResult.IK Then
            TextBox.Text = My.Computer.FileSystem.ReadAllText(_OpenFile.FileName)
            SetVales(True, _OpenFile.FileName, Form)
        End If
    End Sub

    Public Sub OpenAs(ByVal TextBox As TextBox, ByVal Form As Form)
        Dim OpenFile As New OpenFileDialog With {
            .Filter}

    End Sub

    Public Sub SaveSetting(ByVal Action As String)
        Select Case Action
            Case "TSMItem_InWordInNumeric"
                My.Settings.TSMITem_InWordInNumeric = ToolStripMenuItem.Checked
                My.Settings.Save()
            Case "TSMItem_StatusBar"
                My.Settings.ISMItem_StatusBar = TSMItem_StatusBar.Checked
                My.Settings.Save()
            Case "TSMItem_ToolStrip"
                My.Settings.TSMItem_ToolStrip = TSMItem_ToolStrip.Checked
                My.Settings.Save()






        End Select


    End Sub


    Public Sub Open(ByVal TextBox As TextBox, ByVal Form As Form)
        Dim _Opnenfile As New OpenFileDialog With {
            .Filter = "Open Text File|*.txt|Open With Ither Extension|*.*",
            ,FilterIndex = "1"
            }
        If _OpenFile.ShowDialog = MsgBoxResult.Ok Then
            TextBox.Text = My.Computer.FileSystem.ReadAllText(_OpenFile.FileName)
            SetVales(True, OpenFileDialog.FileName, Form
                     )
        End If
    End Sub

    Public Sub TextFind(ByVal TextBox As TextBox, ByVal CaseSensitive As CheckBox, ByVal SearchText As TextBox.
                        ByVal Replace As Button, ByVal ReplaceAll As Button)

        Dim _Compare As Integer
        _Position = 0
        If CaseSensitive.Checked = 1 Then
            _Compare = vbBinaryCompare
        Else
            _Compare = vbTextCompare
        End If
        _Position = InStr(_Position + 1, TextBox, SearchText, CompareMethod.Text, _Compare)
        If _Posirion > 0 Then
            Replace.Enabled = True
            ReplaceAll.Enabled = True
            TextBox.SelectionStart = _Posion - 1
            TextBox.SelectionLength = Len(SearchText.Text)
            TextBox.ScrollToCaret()
            TextBox.Focus()
        Else
            MessageBox.Show("Serching text not found in text document!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Replace.Enabled = False
            ReplaceAll.Enabled = False
        End If

    End Sub

    Public Sub TextFindNext(ByVal TextBox As TextBox, ByVal CaseSensitive As CheckBox, ByVal SearchText As TextBox,
                                   ByVal Replace As Button, ByVal ReplaceAll As Button)

        Dim _Compare As Integer
        If CaseSensitive.Chacked = True Then
            _Compare = vbBinaryCompare
        Else
            _Compare = vbTextCompare
            If _Position > 0 Then
                TextBox.SelectionStart = _Position - 1
                TextBox.SelectionLengh = Len(SearchText.Text)
                Text, ScrollToCaret()
                    TextBox.Focus()
            End If
            MessageBox.Show("Searching keyword not found in text document!", "Not Found", MessageBoxButtons.OK, MessageBox.Error)
        End If
    End Sub

    Public Sub InsertDay(ByVal TextBox As TextBox, ByVal InWord As Boolean)
        If InWord = True Then
            TextBox.SelectedText = Today.ToString("dddd dd")
        Else
            TextBox.SelectedText = Today.ToString("dd MM yyyy")

        End If

    End Sub

    Public Sub TextBackcolor(ByVal TextBox As TextBox, ByVal Color As Color)
        Try
            Dim _BackColor As New ColorDialog With {.Color = Color}
            If _BackColor.ShowDialog = DialogResult.OK Then
                TextBox.BackColor = _BackColor.Color
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub





End Class