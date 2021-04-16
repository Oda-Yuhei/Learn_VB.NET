Public Class Book
    'パッキングフィールド
    Private _Title As String
    Public ReadOnly Property Title() As String
        'ゲッター
        Get
            Return _Title
        End Get
    End Property

    Private _Price As Integer
    Public ReadOnly Property Price() As Integer
        Get
            Return _Price
        End Get
    End Property

    Public Sub New(title As String, price As Integer)
        _Title = title
        _Price = price
    End Sub
    Public Sub disp()
        Console.WriteLine("{0} {1}", _Title, _Price)
    End Sub
End Class