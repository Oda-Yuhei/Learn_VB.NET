Public MustInherit Class PersonalComputer
    Public MustOverride Sub DispComputerType()
End Class

Public Class Notebook : Inherits PersonalComputer
    Public Overrides Sub DispComputerType()
        Console.WriteLine("このパソコンはノートブック型です")
    End Sub
End Class

Public Class Desktop : Inherits PersonalComputer
    Public Overrides Sub DispComputerType()
        Console.WriteLine("このパソコンはデスクトップ型です")
    End Sub
End Class

