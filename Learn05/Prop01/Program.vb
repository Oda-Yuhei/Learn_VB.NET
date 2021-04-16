Public Class Book
    'バッキングフィールド
    Private _Ttile As String
    Public Property Title() As String
        Get
            Return _Ttile
        End Get
        ' セッター
        Set(ByVal value As String)
            _Ttile = value
        End Set
    End Property

    Private _Price As Integer
    Public Property Price() As Integer
        Get
            Return _Price
        End Get
        Set(ByVal value As Integer)
            _Price = value
        End Set
    End Property
End Class