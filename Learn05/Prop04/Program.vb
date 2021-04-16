Module Program
    Sub main()
        Dim book1 As Book = New Book With {
            .Title = "吾輩はねこである",
            .Price = 680
        }

        With book1
            Console.WriteLine("{0} {1}", book1.Title, book1.Price)
        End With
    End Sub
End Module