Public MustInherit Class Telephone
    Public MustOverride Sub Talk()
End Class

Public Class Smartphone : Inherits Telephone
    Public Overrides Sub Talk()
        Console.WriteLine("もしもし")
    End Sub
End Class

Public Interface PersonalComputer
    Sub PowerOn()
End Interface

Public Class Desktop
    Implements PersonalComputer
    Public Sub PowerOn() Implements PersonalComputer.PowerOn
        Console.WriteLine("電源を入れました")
    End Sub
End Class