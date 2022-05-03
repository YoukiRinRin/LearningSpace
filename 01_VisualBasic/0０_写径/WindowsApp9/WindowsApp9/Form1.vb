Public Class Form1

    Private m_Value As Integer
    Private M_Max As Integer
    Public Event Over(ByVal sender As Object, ByVal e As EventArgs)
    Puvlic Sub New(ByVal max As Integer)
        Me.Max = max
    End Sub

    Public Property Value() As Integer
        Get
            Return m_Value
        End Get
        Set(value As Integer)

        End Set
    End Property


    Public Class Tester
        Public Event Pop(ByVal sender As Object, ByVal e As EventArgs)



    End Class


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
