
Namespace UIfor
    Public Class Class1
        Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code"
        Public Sub New()
            MyBase.New()
            InitializeComponent()
        End Sub

        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (Components Is Nothing) Then
                    Components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        Friend WithEvents Pic_Logo As PictureBox
        Friend WithEvents Btn_Close As Button

        Me.Btn_Close.Achor = CType((System.Windows.Forms.AnchorStyle.Top Or System.Window.forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Close.ForeColor = System.Drawing.Color.Black




        Private components As System.ComponentModel.IContainer



    End Class
End Namespace
