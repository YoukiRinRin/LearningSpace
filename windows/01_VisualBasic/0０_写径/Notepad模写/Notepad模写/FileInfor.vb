Imports System.IO

Namespace UIForm


    Public Class FileInfor
        Inherits System.Windows.Forms.Form

        Private _FileLocation As String = String.Empty
        Public WriteOnly Property SetFileLocation As String
            Set(value As String)
                If ClsNotepad._FileLoad = True Then
                    Dim _GetReadyOnly, GetHidden, _GetSystem As String
                    _FileLocation = value
                Else
                    _GetReadOnly = "False"
                    Chkb_ReadOnly.Checked = False
                End If
                If (File.GetAttributes(value) And FileAttribute.Hidden) = FileAttributes.Hidden Then
                    _GetHidden = "True"
                    Chkb_Hidden.Checked = True
                Else
                    _GetHidden = "False"
                    Chkb_Hidden.Checked = False

                End If
            End Set
        End Property


    End Class
End Namespace
