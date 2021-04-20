Public Class Keisan
    Private _hdd As Integer
    Public Sub New()
        _hdd = 0
    End Sub
    
    Public Function Tasizan(x As Integer,y As Integer) As Integer
        Return x + y
    End Function
    Public Function Tasizan(x As Single, y As Single) As Single
        Return x + y
    End Function
    Public Function Tasizan(x As Integer, y As Integer, z As Integer) As Integer
        Return x + y + z
    End Function
End Class

Public Structure Keisan
    Private _hdd As Integer
    Public Sub New()
        _hdd = 0
    End Sub
    
    Public Function Tasizan(x As Integer,y As Integer) As Integer
        Return x + y
    End Function
    Public Function Tasizan(x As Single, y As Single) As Single
        Return x + y
    End Function
    Public Function Tasizan(x As Integer, y As Integer, z As Integer) As Integer
        Return x + y + z
    End Function

End Structure