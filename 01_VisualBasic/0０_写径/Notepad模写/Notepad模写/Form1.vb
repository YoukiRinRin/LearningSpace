Imports System.ComponentModel
Imports System.Speech.Synthesis
Imports System.Text.RegularExpressions
Namespace UIForm
    Public Class Notepad
        Inherits System.Windows.Forms.Form
    End Class

End Namespace

Namespace UIForm
    Public Class Notepad
        Public _FileLoad, _TextChange As Boolean
        Private _Posirion As Integer
        Private _FormTitle, _FileLocation, _FileName As String
        Public Sub New()
            _FormTitle = String.Empty
            _FileLocation = String.Empty
            _FileName = String.Empty
            _FileLoad = False
            _TextChange = False
        End Sub

        Private Sub SetVales(ByVal SetValue As Boolean, ByVal FileLocation As String, ByVal Form As Form)
            _FormTitle = "Notepad[{0}]"
            If SetValue Then
                _FileLocation = FileLocation
                _FileName = FileLocation.Split("\")(FileLocation.Split("\").Count - 1)
                _FileLoad = False
                _TextChange = False
                Form.Text = String.Format(_FormTitle, _FileName)
            End If
        End Sub
        Public Function ClosingAlert(ByVal TextBox As TextBox, ByVal Form As Form) As Boolean
            Dim _GetAction As Boolean
            Dim _GetFileName As String
            If String.IsNullOrWhiteSpace(_FileName) Then
                _GetFileName = String.Empty
            Else
                _GetFileName = vbNewLine & "file name is " & _FileName & vbNewLine & "take Action for close messagebox"
            End If
            If _TextChange = True Then

                Select Case MessageBox.Show("Text document has been changed," &
                                            vbNewLine & "do you want to save the changes?" & _GetFileName,
"Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                    Case DialogResult.Cancel
                        _GetAction = True
                    Case DialogResult.No
                        _GetAction = False
                    Case DialogResult.Yes
                        Save(TextBox, Form)
                        _GetAction = False
                End Select
            Else
                _GetAction = False
            End If
            Return _GetAction
        End Function

        Public Sub NewTextDocument(ByVal TextBox As TextBox, ByVal Form As Form)
            TextBox.Clear()
            satVales(False, "", Form)
        End Sub
        Public Sub Open(ByVal TextBox As TextBox, ByVal Form As Form)
            Dim _OpenFile As New OpenFileDialog With
                {.Filter = "OpenAs Text File|*.txt|OpenaAs With Other Extension|*,*",
                .FilterIndex = "1"
                }
            If _OpenFile.ShowDialog = MsgBoxResult.Ok Then
                TextBox.Text = My.Computer.FileSystem,ReadAllText(_OpenFile.FileName)
                    SetVales(False, _OpenFile.FileName, Form)
            End If
        End Sub
        Public Sub Save(ByVal TextBox As TextBox, ByVal Form As Form)

            If My.Computer.FileSystem.FileExists(_FileLocation) Then
                My.Computer.FileSystem.WriteAllText(_FileLocation, TextBox.Text, False)
                SetVales(True, _FileLocation, Form)
            End If
            Public Sub Save(ByVal TextBox, ByVal Form As Form)
            If My.Computer.FileSystem.FileExitsts(_FileLocation) Then
                My.Computer.FileSystem.WriteAllText(_FileLocation, TextBox.Text, False)
                SetVales(True, _SaveFile.FileName, Form)
            Else
                Dim _SaveFile As New SaveFileDialog With {
                    .Filter = "Save Text File|*.txt|Save With Other Extension|*.*",
                    .FilterIndex = "|"}
                If _SaveFile.ShowDialog = MsgBoxResult.Ok Then
                    My.Computer.FileSystem.WriteAllBytes;;Text(_SaveFile.FileName,TextBox.True)
                        SetVales(True, _SaveFile.FileName, Form)
                End If
            End If
        End Sub
        Public Sub SaveAs(ByVal TextBox As TextBox, ByVal Form As Form)


            Dim _SaveFile As New SaveFileDialog With {
                .Filter = "Save Text File|*.txt|Save With Other Extension|*.*",
                .FilterIndex = "I",
                .FileName = "Copy" & _FileName}
            If _SaveFile.ShowDialog = MsgBoxResult.Ok Then
                My.Computer.FileSystem.WriteAllText()
                SetValues(True, _SsveFileName, Form)
            End If
        End Sub




        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
