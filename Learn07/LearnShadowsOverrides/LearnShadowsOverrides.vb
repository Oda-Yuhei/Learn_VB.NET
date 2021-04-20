Public Class Kihon
    Public Sub SayHello()
        Console.WriteLine("こんにちは")
    End Sub

    Public Overridable Sub SayHello(ByVal Name As String)
        Console.WriteLine("こんにちは{0}さん",Name)
    End Sub
End Class

Public Class Hasei1 : Inherits Kihon
    Public Shadows Sub SayHello()
        Console.WriteLine("Hello")
    End Sub
End Class

Public Class Hasei2 : Inherits Kihon
    Public Overrides Sub SayHello(ByVal Name As String)
        Console.WriteLine("Hello Mr.{0}", Name)
    End Sub
End Class
