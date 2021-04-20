Public Class Kihon
    Public Sub New()
        Console.WriteLine("Kihonクラスのコンストラクタが呼び出されました")
    End Sub
    Public Sub New(Byval hikisu As String)
        Console.WriteLine("Kihonクラスのコンストラクタが呼び出されました")
        Console.WriteLine($"受け取った引数は{hikisu}です")
    End Sub
End Class

Public Class Hasei : Inherits Kihon
    Public Sub New()
        MyBase.New("Visual Basic")
        Console.WriteLine("Haseiクラスのコンストラクタが呼び出されました")
    End Sub
End Class