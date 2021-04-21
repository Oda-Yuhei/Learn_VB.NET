Module Program
    WithEvents EventSmpleClass As New EventSample
    Sub OnTimeOver() Handles EventSmpleClass .OnTimeOver
        Console.WriteLine("3秒経過しました")
    End Sub
    Sub main()
        Dim a As New Message()
        Dim mes As ShowMessage

        mes = New ShowMessage(AddressOf a.SayHello)
        mes()

        EventSmpleClass.TestMethod()

    End Sub
End Module

Delegate Sub ShowMessage()
Public Class Message
    Public Sub SayHello()
        Console.WriteLine("Hello")
    End Sub


End Class

Public Class EventSample
    Public Event OnTimeOver()
    Public Sub TestMethod()
        System.Threading.Thread.Sleep(3000)
        RaiseEvent OnTimeOver()
    End Sub
End Class
