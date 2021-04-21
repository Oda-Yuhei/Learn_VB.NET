Imports System.Collections.Generic
Class Student
    Public Property Name() As String
    Public Property Score() As Integer

    Public Sub New (name As String, Score As Integer)
        MyClass.Name = name
        MyClass.Score = score
    End Sub
End Class
Module Program
    Sub Main()
        Dim students As New List(Of Student) From{
            New Student("持木",95),
            New Student("太田",90),
            New Student("勝野",5),
            New Student("山田",70),
            New Student("佐々木",60),
            New Student("進藤",10)
        }
        For Each Student As Student In students
            With Student
                Console.WriteLine("{0}{1}", .Name,.Score)
            End With
        Next
    End Sub
End Module