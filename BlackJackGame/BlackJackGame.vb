
Imports System.Collections.Generic

Public Enum Suit
    Diamond = 1
    Heart
    Club
    Spade
End Enum

Public Class Deck
    Private cards As New List(Of Card)
    Private drawIndex As Integer

    Public Sub New()
        For i As Integer = 1 To 4
            For j As Integer = 1 To 13
                cards.Add(New Card(i,j))
            Next j
        Next i
        Program.Shuffle(cards)
    End Sub

    Public Function DrawCard() As Card
            Dim card As card = cards.Item(cards.count-1)
            cards.Remove(card)
            Return card
    End Function


End Class
Public Class Player
    Public Property name() As String
    Public mycards As New List(Of Card)
    Public sum As Integer

    Public Sub New(Name As String, usingDeck As Deck)

        _Name = name
        mycards.Add(usingDeck.DrawCard)
        mycards.Add(usingDeck.DrawCard)
        Console.WriteLine($"{name}さんの初手にドローしたカード")
        For i As Integer = 0 To 1
            Console.WriteLine(mycards(i))
        Next i
        GetTotal(mycards)
        Console.WriteLine($"合計：{sum}")
        Console.WriteLine()
        
       
    End Sub
    Public Sub New(usingDeck As Deck)
        mycards.Add(usingDeck.DrawCard)
        mycards.Add(usingDeck.DrawCard)
        Console.WriteLine($"Computerの初手にドローしたカード")
        Console.WriteLine(mycards(0))
        GetTotal(mycards)
        While sum < 17
            ' Console.WriteLine($"comさんが追加でドローしたカード")
            mycards.Add(usingDeck.DrawCard)
            ' Console.WriteLine(mycards(mycards.Count-1))
            sum = GetTotal(mycards)
        End While
        ' Console.WriteLine($"debug----合計：{sum}")
        Console.WriteLine()
    End Sub
    
    Public Function GetTotal(mycards) As Integer
        sum = 0
        For Each card As card In mycards
            If card.Rank >= 10 Then
                sum += 10
            Else If Card.Rank = 1 And sum > 10 Then        
                sum += 1
            Else If Card.Rank = 1 And Sum <= 10 Then
                    sum += 10
            Else
                sum += Card.Rank
            End If

        Next
        Return sum
    End Function
End Class

Public Class com
    Inherits Player
    Public Sub New(usingDeck As Deck)
        MyBase.New(usingDeck)

    End Sub

End Class

Public Class Card

    Public ReadOnly Property Rank() As Integer
    Public ReadOnly Property Suit() As Suit

    Public Sub New(Suit As Suit,Rank As Integer)
        _Rank = rank
        _Suit = suit

    End Sub
    Public Overrides Function ToString() As String
        Dim result As String
        Select Case MyClass.rank
            Case 1
              result = "A"
            Case　11
                result = "J"
            Case 12
                result = "Q"
            Case 13
                result = "K"
            Case Else
                result = MyClass.rank
        End Select
        Dim resultR As Suit = MyClass.Suit
        Return $"{resultR} {result}"
    End Function

End Class



Module Program
    Sub judge(Comnum, Playernum, Name)
        Dim Comjudge As Boolean = True
        Dim Playerjudge As Boolean = True
        If Playernum > 21 Then
            Playerjudge = false
        End If

        If Comnum > 21 Then
            Comjudge = false
        End If
        Console.WriteLine("------------------------")
        Console.WriteLine($"{Name}さん：{Playernum}")
        Console.WriteLine($"com  :{Comnum}")


        If Playerjudge = false Then
            Console.WriteLine("Computerの勝ち")
        Else If Comnum >= Playernum And Comjudge = True Then
            Console.WriteLine("Computerの勝ち")
        Else 
            Console.WriteLine($"{Name}さんの勝ち")
        End If
    End Sub
    Sub Shuffle(Of T)(list As IList(Of T))
        Dim r As Random = New Random()
        For i = 0 To list.Count -1
            Dim index As Integer = r.Next(i,list.Count)
            If i <> index Then
                Dim temp As T = list(i)
                list(i) = list(index)
                list(index) = temp
            End If
        Next
    End Sub

    Sub main()
        Dim deck As New Deck
        Dim Player1 As New Player("Yuhei",deck)
        Dim com1 As New com(deck)
        While True
            Console.WriteLine("0:スタンド")
            Console.WriteLine("1:ヒット")
            Dim sentaku As String = Console.ReadLine()
            Console.WriteLine()
            Select Case sentaku
                Case "0"
                    Exit While
                Case "1"
                    ' カードを引く
                    Player1.mycards.Add(Deck.DrawCard)
                    Console.Write("引いたカードは：")
                    Console.WriteLine(Player1.mycards(Player1.mycards.Count-1))
                    Console.WriteLine()
                    Dim Sum As Integer
                    Sum = Player1.GetTotal(Player1.mycards)
                    Console.WriteLine($"現在の合計は{Player1.sum}")
                Case Else
                    Console.WriteLine("入力を間違えていますもう一度入力してください")
            End Select
        End While

        judge(com1.sum,Player1.sum,Player1.Name)
    End Sub
End Module
