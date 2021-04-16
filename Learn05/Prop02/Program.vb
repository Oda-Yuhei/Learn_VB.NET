Imports System

Module Program
    Sub main(args As String())
        Dim book1 As Book = New Book With {
            .Title = "吾輩は猫である",
            .Price = 680
        }

        With book1
            Console.WriteLine("{0} {1}", .Title, .Price)
        End With
    End Sub
End Module