Module End_of_chapter05
    Sub main()
        Console.WriteLine("VB博物館へようこそ")
        Console.WriteLine("年齢を入力してください:")

        Dim age As Integer = Cint(Console.ReadLine())

        If age < 7 Then
            Console.WriteLine("無料")
        Else If age <= 12
            Console.WriteLine("500円")
        Else If age <= 18
            Console.WriteLine("800円")
        Else If age <= 60
            Console.WriteLine("1000円")
        Else
            Console.WriteLine("500円")
        End If
        
        COnsole.WriteLine()
        Console.WriteLine()

        Console.WriteLine("うどん屋 VB")
        Console.WriteLine("メニューを番号で選択してください")
        Console.WriteLine("-------------=")
        Console.WriteLine("1:かけうどん")
        Console.WriteLine("2:ざるうどん")
        Console.WriteLine("3:天ぷらうどん")
        Console.WriteLine("4:たぬきうどん")
        Console.WriteLine("5:きつねうどん")
        Console.WriteLine("-------------=")

        Dim menuNum As Integer = Cint(Console.ReadLine())
        Dim price() As Integer
        price = New Integer() {300, 300, 450, 400, 400}
        Dim menu() As String
        menu = New String() {"かけうどん","ざるうどん","天ぷらうどん","たぬきうどん","きつねうどん"}

        Select Case menuNum
            Case Is = 1
                Console.WriteLine(menu(0) & price(0) & "円です")
            Case Is = 2
                Console.WriteLine(menu(1) & price(1) & "円です")
            Case Is = 3
                Console.WriteLine(menu(2) & price(2) & "円です")
            Case Is = 4
                Console.WriteLine(menu(3) & price(3) & "円です")
            Case Is = 5
                Console.WriteLine(menu(4) & price(4) & "円です")
            Case Else
                Console.WriteLine("正しい数値を入力してください")
        End Select
            

    End Sub
End Module