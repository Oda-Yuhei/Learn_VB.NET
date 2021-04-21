Imports System.Collections.Generic
Module Program
    Sub main()
        Dim reservation As New Queue(Of String)

        reservation.Enqueue("Bさん")
        reservation.Enqueue("Cさん")
        reservation.Enqueue("Aさん")
        reservation.Enqueue("Dさん")

        Console.WriteLine(reservation.Dequeue)
        Console.WriteLine(reservation.Dequeue)

        Console.WriteLine(reservation.Dequeue)
    End Sub
End Module