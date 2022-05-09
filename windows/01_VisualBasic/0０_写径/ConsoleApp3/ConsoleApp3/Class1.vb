Public Class Class1

    Private _moji As String = "色は"
    Private _name As String

    Function getName()
        Return _moji + _name
    End Function

    Sub setName(a As String)
        _name = a
    End Sub
End Class
