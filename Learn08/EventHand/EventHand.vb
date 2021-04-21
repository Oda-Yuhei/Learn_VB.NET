Public Class EventSample
    Public Event OnDataChanged()
    
    Public Sub TestMethod(ByRef X As Integer)
        x = X + 3
        RaiseEvent OnDataChanged()
    End Sub
End Class