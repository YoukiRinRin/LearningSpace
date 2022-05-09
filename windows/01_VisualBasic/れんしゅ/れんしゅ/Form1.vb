Public Class Form1
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("知閉じますか？", "確認", "MessageBoxButtons.YesNo") = DialogResult.No Then
            e.Cancel = True
        End If


        Dim hStack As New System.Diagnostics.StackTrace(True)

        Select Case hStack,GetFrame(7).GetMEthod().Name
            Case "CallwindowProc"
                If hStack.FrameCount > 14 Then
                    Select Case hStack.GetFrame(14).GetMethod.Name
                        Case "WmSvsCommand"
                    End Select
                End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Private Shared _instance As Form2

        Public Shared ReadOnly Property Instance() As Form
        Get
            If _instance Is Nothing OrElse _instance.IsDisposed Then
                _instance = New Form2
            End If
            Return _instance
        End Get
    End Property


    End Sub
End Class
