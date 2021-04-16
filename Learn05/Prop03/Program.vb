Module Program
    Sub main(args As String())
        Dim book1 As New Book(args(0), 680)

        'bookk.Title = "ああああ"　コンパイルエラー
        book1.disp()
    End Sub

End Module