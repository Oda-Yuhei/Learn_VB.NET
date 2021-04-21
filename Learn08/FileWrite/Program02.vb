Imports System.Collections.Generic
Class Book
    Public Property Title() As String
    Public Property Price() As Integer
    Sub New(title As String, price As Integer)
        MyClass.Title = title
        MyClass.Price = price
    End Sub
End Class

Module Program
    Sub main()
        Dim books As New List(Of book)
        While True
            Console.Write("Title:")
            Dim title As String = Console.ReadLine()
            If title.Length = 0 Then
                Exit　While
            End IF
            Console.Write("Price:")
            Dim price As Integer = Val(Console.ReadLine())
            books.add(New Book(title, price))
        End While

        Using writer As New IO.StreamWriter("books.csv")
            For Each book As Book In books
                writer.WriteLine("{0},{1}",book.Title, book.Price)
            Next
        End Using

        Dim books2 As New List(Of Book)
        Using reader As New IO.StreamReader("books.csv")
            While True
                Dim line As String = reader.ReadLine()
                If line Is Nothing Then
                    Exit While
                End If
                Dim cols As String() = line.Split(",")
                books2.Add(New book(cols(0),Val(cols(1))))
            End While
        End Using

        For Each book As Book In books2
            Console.WriteLine("{0},{1}",book.Title,book.Price)
        Next
    End Sub
End Module