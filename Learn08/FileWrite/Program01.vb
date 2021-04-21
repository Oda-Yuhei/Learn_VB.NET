
Module Program
    Sub main()
        Dim Writer As New IO.StreamWriter("file01.txt")

        writer.WriteLine("一行目")
        writer.WriteLine("二行目")
        writer.WriteLine("三行目")

        'StreamWriterは利用し終わったら必ずクローズする
        writer.Close()

        'StreamReaderも利用し終わったら必ずクローズする
        'Usingステートメントを利用するとEnd Usingの時点で自動的にクローズされる
        Using reader As New IO.StreamReader("file01.txt")
            While True
                Dim line As String = reader.ReadLine()
                If line Is Nothing Then
                    Exit While
                End If
                Console.WriteLine(line)
            End While
        End Using
    End Sub
End Module