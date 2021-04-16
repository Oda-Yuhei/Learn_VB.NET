Module Program
    Sub Main()
        Dim book1 As Book = New Book()
        book1.Title = "吾輩は猫である"
        book1.Price =　680

        Console.WriteLine("{0} {1}" , book1.Title, book1.Price)
    End Sub
End Module