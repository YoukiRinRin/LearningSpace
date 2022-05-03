Namespace UIForm
    Public Class Example
        Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code"
        Public Sub New()
            MyBase.New()
            InitializeComponent()
        End Sub
        Protected Overloads Overrides Sub Dispose(ByVal siposing As Boolean)
            If Disposing Then
                If Not (components Is Nothing) Then
                    componets.Dispose()
                End If
            End If
            MyBase.Dispose(Disposing)
        End Sub

        Friend WithEvents Pnl_Top As Panel
        Friend WithEvents Lbl_Header As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Pnl_MainScrean As Panel
        Friend WithEvents Pnl_TabControl As Panel
        Friend WithEvents TControl_Pages As TabControl
        Friend WithEvents TPage_Setting As TabPage
        Friend WithEvents Pnl_ListView As TabPage
        Friend WithEvents Lvw_TabControlMenu As ListView
        Friend WithEvents TPage_AddEditDel As TabPage
        Friend WithEvents TPage_Codes As TabPage






#End Region


    End Class
End Namespace


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
