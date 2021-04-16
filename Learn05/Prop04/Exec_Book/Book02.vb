Public Class book 'クラス
    Public title As String 'フィールド
    Public price As Integer 'フィールド

    Public Sub New(title As String, price As Integer) 'コンストラクタ
        MyClass.title = title
        MyClass.price = price
    End Sub
    Public Sub New()

    End Sub
End Class