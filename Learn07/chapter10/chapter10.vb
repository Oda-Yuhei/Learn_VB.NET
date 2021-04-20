Public Class Kihon
    Public Sub New()
    End Sub

    Public Sub DispNowTime()
        Console.WriteLine(DateTime.Now)
    End Sub
End Class

Public Class Hasei : Inherits Kihon
    Public Sub DispYesterday()
        Console.WriteLine(DateTime.Now.AddDays(-1))
    End Sub


End Class

Module Program
    Sub main()
        Dim now As New Kihon()
        Dim yester As New Hasei()

        now.DispNowTime()
        yester.DispYesterday()
    End Sub
End Module