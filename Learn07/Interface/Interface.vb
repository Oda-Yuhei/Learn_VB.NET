Public Class Notebook 
    Implements IPersonalcomputer

    Public Property CPU As Single Implements IPersonalcomputer.CPU
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Single)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Function GetSpecification() As String Implements IPersonalcomputer.GetSpecification
        Throw New NotImplementedException()
    End Function
End Class

Public Interface IPersonalcomputer
    Property CPU() As Single

    Sub DispMessage()

    Function GetSpecification() As String
End Interface