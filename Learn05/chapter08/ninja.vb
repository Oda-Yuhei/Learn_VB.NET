Module Program
    Sub main()
        Dim ThrowSyuriken As ninja = New ninja()
        ThrowSyuriken.Syuriken = "丸い"

        Console.WriteLine("{0}手裏剣を投げたよ", ThrowSyuriken.Syuriken)
    End Sub
End Module

Public Class ninja

    Private _Syuriken As String
    Public Property Syuriken() As String
        Get
            Return _Syuriken
        End Get
        Set(ByVal value As String)
            _Syuriken = value

        End Set
    End Property
End Class