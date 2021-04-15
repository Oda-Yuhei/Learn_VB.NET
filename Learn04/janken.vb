Module janken
    Dim hand() As String = {"グー","チョキ","パー"}
    Dim win As Integer = 0
    Dim lose As Integer = 0
    Dim draw As Integer = 0


    Sub battle(a)
        
        Dim userHand As Integer = a - 1
        Console.WriteLine("あなたは"& hand(userHand) &"を出し")
        Console.WriteLine()
        Dim random As New System.random()
        Dim comHand As Integer = random.Next(3)
        Console.WriteLine("Computerは" & hand(comHand) & "を出しました")
        Console.WriteLine()

        Dim x As Integer
        x = userHand - comHand

        If x = -1 Or x = 2 Then
            Console.WriteLine("あなたの勝ちです")
            win += 1
        Else If x = 1 Or x = -2
            Console.WriteLine("あなたの負けです")
            lose += 1
        Else
            Console.WriteLine("引き分けです")
            draw +=1
        End If
    End Sub

    Sub main()
        Console.WriteLine("じゃんけんをはじめます")
        Console.WriteLine("出す手を選択してください")

        Dim count As Integer = 1
        Dim handNum As Integer

        While count <= 5
            Console.WriteLine("1：グー、2：チョキ、3：パー")
            Console.WriteLine(count & "回目の勝負")
            Dim judge As Integer
            Do
                handNum = Cint(Console.ReadLine())
                judge = handNum
                If judge > 3 Or judge < 1 Then
                    Console.WriteLine("正しい数値を選択してください")
                End If

                

            Loop While judge > 3 Or judge < 1
            battle(handNum)
            count += 1

        End While

        Console.WriteLine(win & "勝" & lose & "負" & draw & "分でした")


    End Sub
End Module