Public Class card

    Private _Num As Integer
    Private _Mark As Integer

    Private Num_Mark As String = _Num + _Mark


    Property Num() As Integer
        Get
            Return _Num
        End Get
        Set(ByVal value As Integer)
            _Num = value
        End Set
    End Property

    Property Mark() As Integer
        Get
            Return _Mark
        End Get
        Set(ByVal value As Integer)
            _Mark = value
        End Set
    End Property



End Class
