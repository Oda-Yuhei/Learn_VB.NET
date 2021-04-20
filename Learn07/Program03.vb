Module Program03
    Sub Main()
        Dim weekString As String() = {"日","月","火","水","木","金","土"}
        Dim gdate As New GDate (2019, 4, 23)

        Console.WriteLine(weekString(gdate.WeekDay))
        
    End Sub

End Module