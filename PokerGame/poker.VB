Imports System.Collections.Generic
' プレイヤーの作成-----------------
Public Class Player
    Public hands As List(Of Card)
    Public Sub New()
        hands = New List(Of Card)
    End Sub

    Public Sub DrawCard(card As Card)
        hands.Add(card)
    End Sub
    Public Overloads Function ToString() As String
        ' ここリンク
        ' 要復習
        ' それとラムダ式
        Dim result As String = String.Join("", hands.Select(Function(c) c.ToString()))
        Return $"[手札={result}]"
    End Function
    Public Overridable Sub ShowHand()
        Console.WriteLine(ToString())
    End Sub

End Class
Public Class Computer : Inherits Player
    Public Overrides Sub ShowHand()
        ' 一枚目以外は隠す
        Dim result As String = "[---]"
        For i As Integer = 1 To hands.Count - 1
            result &= "[---]"
        Next
        Console.WriteLine($"[手札={result}]")
    End Sub
End Class

' カード・デッキ作成-------------------
Public Enum Suit
    Spade
    Heart
    Diamond
    Club
End Enum
Public Class Card
    Public ReadOnly Property Suit() As Suit
    Public ReadOnly Property Rank() As Integer
    Sub New(suit As Suit, rank As Integer)
        _Suit = suit
        _Rank = rank
    End Sub
    Public Overloads Function ToString() As String
        Dim rankStr As String
        Select Case Rank
            Case 1
                rankStr = "A"
            Case 11
                rankStr = "j"
            Case 12
                rankStr = "Q"
            Case 13
                rankStr = "K"
            Case Else
                rankStr = Rank
        End Select
        Return $"[{Suit} {rankStr}]"
    End Function
End Class
Public Class Deck
    Public Const RANK_MAX As Integer = 13
    Private ReadOnly cards As New List(Of Card)
    Public Sub New()
        For Each suit As Suit In [Enum].GetValues(GetType(Suit))
            For rank As Integer = 1 To 13
                cards.Add(New Card(suit, rank))
            Next rank
        Next
        Util.Shuffle(cards)
    End Sub
    Public Function DrawCard() As Card
        Dim card As Card = cards.Item(0)
        cards.Remove(card)
        Return card
    End Function
End Class

Public Class GameLogic
    Private ReadOnly deck As Deck
    Private ReadOnly player As Player
    Private ReadOnly computer As Computer
    Public computers As New List(Of Computer)
    Public Sub New()
        deck = New Deck()
        player = New Player()

        Console.Write("何人対戦にしますか？[2 ~ 5] : ")
        Dim player_count As Integer

        While True
            player_count = CInt(Console.ReadLine())
            If player_count >= 1 And player_count <= 5 Then
                Exit While
            End If
        End While
        For i As Integer = 0 To player_count - 1
            computers.Add(New Computer())
        Next

        For i As Integer = 1 To 5
            player.DrawCard(deck.DrawCard())
        Next
        player.hands.Sort(Function(c1, c2) c1.Rank - c2.Rank)
        For i As Integer = 0 To player_count - 1
            For j As Integer = 1 To 5
                computers(i).DrawCard(deck.DrawCard)
            Next j
        Next i
    End Sub
    Private Sub ShowResult()
        Console.WriteLine("----------------------------------------------")
        Dim count As Integer = 1
        For Each com As Computer In computers
            Console.WriteLine($"コンピューター{count}")
            Console.WriteLine(com.ToString)
            Console.WriteLine(Role_jadge(com.hands).ToString())

            count += 1
        Next
        Console.WriteLine()
        Console.WriteLine("あなた")
        Console.WriteLine(player.ToString)
        Console.WriteLine(Role_jadge(player.hands).ToString())

        Dim make_count As Integer
        Dim kati_count As Integer
        Dim Drow_count As Integer

        For Each com As Computer In computers
            If Role_jadge(player.hands) < Role_jadge(com.hands) Then
                make_count += 1
            ElseIf Role_jadge(player.hands) > Role_jadge(com.hands) Then
                kati_count += 1
            Else
                Drow_count += 1
            End If
        Next

        If make_count > 0 Then
            Console.WriteLine("あなたの負け")
        ElseIf kati_count > 0 Then
            Console.WriteLine("あなたの勝ち")
        Else
            Console.WriteLine("ドロー")
        End If



    End Sub
    Private Sub ShowTurn()
        Console.WriteLine("コンピューター")
        For Each con As Computer In computers
            con.ShowHand()
        Next
        Console.WriteLine()
        Console.WriteLine("あなた")
        player.ShowHand()
        Console.WriteLine()
    End Sub
    Public Sub Start()
        While True
            ShowTurn()
            For i As Integer = 2 To 0 Step -1
                If i = 0 Then
                    Console.WriteLine()
                    Exit While
                End If
                Console.Write($"ドローしますか？(残り{i}回)[ y / それ以外] : ")
                Dim draw_select As String
                draw_select = Console.ReadLine()
                If draw_select = "y" Then
                    Dim drop_cards As String
                    Console.Write($"捨てるカードを選択してください。左から[1 ~ {player.hands.Count}]番目 / 無ければそれ以外 : ")
                    While True
                        drop_cards = Console.ReadLine()
                        Select Case drop_cards
                            Case "1"
                                player.hands.RemoveAt(0)
                            Case "2"
                                player.hands.RemoveAt(1)
                            Case "3"
                                player.hands.RemoveAt(2)
                            Case "4"
                                player.hands.RemoveAt(3)
                            Case "5"
                                player.hands.RemoveAt(4)
                            Case Else
                                Exit While

                        End Select
                        player.ShowHand()

                    End While
                    ' 捨てるカードを選択
                    ' 捨てた枚数分ドロー
                    For j As Integer = 1 To 5 - player.hands.Count
                        player.DrawCard(deck.DrawCard())
                        Console.WriteLine($"新しく{player.hands(player.hands.Count - 1).ToString} をドローしました")
                    Next
                    player.hands.Sort(Function(c1, c2) c1.Rank - c2.Rank)
                    player.ShowHand()


                Else
                    Exit While
                End If
            Next
        End While
        Console.WriteLine("結果発表をします。任意のキーを押して下さい")
        Console.ReadLine()

        ShowResult()
    End Sub

    Enum yaku
        NO_PAIR
        ONE_PAIR
        TWO_PAIR
        THREE_CARD
        STRAIGHT
        FLASH
        FULL_HOUSE
        FOUR_CARD
        STRAIGHT_FLASH
        LOYAL_STRAIGHT_FLASH
    End Enum
    Public Function Role_jadge(player_hands As List(Of Card)) As yaku
        Dim count As Integer = 0

        'player_hands.Sort()
        If player_hands(0).Rank = 1 And player_hands(1).Rank = 10 And player_hands(2).Rank = 11 And player_hands(3).Rank = 12 And player_hands(4).Rank = 13 Then
            Return yaku.LOYAL_STRAIGHT_FLASH
        End If

        If (player_hands(0).Suit = player_hands(1).Suit And player_hands(2).Suit = player_hands(3).Suit And player_hands(3).Suit = player_hands(4).Suit And player_hands(4).Suit = player_hands(0).Suit) And (player_hands(0).Rank + 1 = player_hands(1).Rank And player_hands(1).Rank + 1 = player_hands(2).Rank And player_hands(2).Rank + 1 = player_hands(3).Rank And player_hands(3).Rank + 1 = player_hands(4).Rank) Then
            Return yaku.STRAIGHT_FLASH
        End If



        For i As Integer = 0 To player_hands.Count - 1
            For j As Integer = i + 1 To player_hands.Count - 1
                If player_hands(i).Rank = player_hands(j).Rank Then
                    count += 1
                End If
            Next
        Next

        Select Case count
            Case 0
                If frash(player_hands) = yaku.STRAIGHT Or frash(player_hands) = yaku.FLASH Then
                    Return frash(player_hands)
                Else
                    Return yaku.NO_PAIR
                End If
            Case 1
                If frash(player_hands) = yaku.STRAIGHT Or frash(player_hands) = yaku.FLASH Then
                    Return frash(player_hands)
                Else
                    Return yaku.ONE_PAIR
                End If
            Case 2
                If frash(player_hands) = yaku.STRAIGHT Or frash(player_hands) = yaku.FLASH Then
                    Return frash(player_hands)
                Else
                    Return yaku.TWO_PAIR
                End If
            Case 3
                If frash(player_hands) = yaku.STRAIGHT Or frash(player_hands) = yaku.FLASH Then
                    Return frash(player_hands)
                Else
                    Return yaku.THREE_CARD
                End If
            Case 4
                Return yaku.FULL_HOUSE
            Case 6
                Return yaku.FOUR_CARD
        End Select
    End Function
    Public Function frash(player_hands As List(Of Card)) As String
        If player_hands(0).Suit = player_hands(1).Suit And player_hands(2).Suit = player_hands(3).Suit And player_hands(3).Suit = player_hands(4).Suit And player_hands(4).Suit = player_hands(0).Suit Then
            Return yaku.FLASH
        ElseIf player_hands(0).Rank + 1 = player_hands(1).Rank And player_hands(1).Rank + 1 = player_hands(2).Rank And player_hands(2).Rank + 1 = player_hands(3).Rank And player_hands(3).Rank + 1 = player_hands(4).Rank Then
            Return yaku.STRAIGHT
        End If
    End Function


End Class

' クラス作成終了-----------------------------
Module Util
    Public Sub Shuffle(Of T)(list As IList(Of T))
        Dim r As Random = New Random()
        For i = 0 To list.Count - 1
            Dim index As Integer = r.Next(i, list.Count)
            If i <> index Then
                Dim temp As T = list(i)
                list(i) = list(index)
                list(index) = temp
            End If
        Next
    End Sub
End Module


Module Program
    Sub Main()
        Dim logic As New GameLogic()
        logic.Start()
    End Sub
End Module
