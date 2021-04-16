Module Exec
    Sub main()
        Dim book1 As New Book("吾輩は猫である", 680)

        ' Dim Book2 As New Book()

        Console.WriteLine(book1.title & vbTab & book1.price)
        ' Console.WriteLine(book2.title & vbTab & book2.price)
    End Sub
End Module