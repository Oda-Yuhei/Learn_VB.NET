Public Class Book
    'バッキングフィールド
    Private _Title As String
    Public Property Title() As String
        'ゲッター
        Get
            Return _Title
        End Get
        'セッター
        Set(ByVal value As String)
        'valueがNothingか空文字の場合
            If String.IsnullOrEmpty(value) Then
                _Title = "名無し"
            Else
                _Title = value
            End If
        End Set
    End Property

    Private _Price As Integer
    Public Property Price() As Integer
        Get
            Return _Price
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then
                value = 0
            End If
            _Price = value
        End Set
    End Property
End Class