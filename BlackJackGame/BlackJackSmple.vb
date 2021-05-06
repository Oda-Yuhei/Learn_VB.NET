
Imports System.Collections.Generic

Public Class Player
    Implements IComparable(Of Player)
    Protected hands As List(Of Card)
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
        Dim result As String = String.Join("", hands.Select(Function(c)c.ToString()))
        Return $"[手札={result},合計{GetTotal()}]"
    End Function
    Public Overridable Sub ShowHand()
        Console.WriteLine(ToString())
    End Sub
    Public Function GetTotal() As Integer
        ' ここリンク
        Dim hasAce As Boolean = hands.Any(Function(c) c.Rank = 1)
        Dim total As Integer = hands.Sum(Function(C) If (c.Rank >= 10, 10, c.Rank))
        Return If(hasAce AndAlso total <= 11, total +10, total)
    End Function
    Public Function IsBurst()
        Return GetTotal() > 21
    End Function
    Public Function CompareTo(other As Player) As Integer Implements IComparable(Of Player).CompareTo
        If Equals(other) Then
            Return 0
        ElseIf IsBurst() Then
            Return -1
        ElseIf other.IsBurst() Then
            Return 1
        End If
        Return GetTotal() - other.GetTotal()
    End Function
    Public Overloads Function Equals(obj As Object) As Boolean
        If obj Is Nothing OrElse TypeOf obj IsNot Player Then
            Return False
        End If
        Dim other As Player = DirectCast(obj, Player)
        Return IsBurst() AndAlso other. IsBurst() OrElse GetTotal() = other.GetTotal()
    End Function
End Class
Public Class GameLogic
    Private Const COM_HIT_TOTAL As Integer = 17
    Private ReadOnly deck As Deck
    Private ReadOnly player As Player
    Private ReadOnly computer As Computer
    Public Sub New()
        deck = New Deck()
        player = New Player()
        computer = New Computer()
        ' 二枚引く
        For i As Integer = 1 To 2
            player.DrawCard(deck.DrawCard())
            computer.DrawCard(deck.DrawCard())
        Next
    End Sub
    Private Sub Hit()
        player.DrawCard(deck.DrawCard())
        If computer.GetTotal() < COM_HIT_TOTAL Then
            computer.DrawCard(deck.DrawCard())
        End If
    End Sub
    Private Sub Stand()
        While computer.GetTotal() < COM_HIT_TOTAL
            computer.DrawCard(deck.DrawCard())
        End While
    End Sub
    Private Sub ShowResult()
        Console.WriteLine("----------------------------------------------")
        Console.WriteLine("コンピューター")
        Console.WriteLine(computer.ToString)
        Console.WriteLine()
        Console.WriteLine("あなた")
        Console.WriteLine(player.ToString)

        Dim result As Integer = player.CompareTo(computer)
        If player.IsBurst() OrElse result < 0 Then
            Console.WriteLine("コンピューターの勝ち")
        ElseIf result > 0 Then
            Console.WriteLine("あなたの勝ち")
        Else
            Console.WriteLine("引き分け")
        End If
    End Sub
    Private Sub ShowTurn()
        Console.WriteLine("コンピューター")
        computer.ShowHand()
        Console.WriteLine("あなた")
        player.ShowHand()
    End Sub
    Public Sub Start()
        While True
            ShowTurn()
            Console.Write("もう一枚引きますか？[y or それ以外]")
            If Console.ReadLine() = "y" Then
                Hit()
                If player.IsBurst() Then 
                    Console.WriteLine("あなたはバーストしました")
                    Exit While
                End If
            Else
                Exit While
            End If
        End While
        If Not player.IsBurst() Then
            Stand()
        End If
        ShowResult()
    End Sub
End Class

Public Class Computer : Inherits Player
    Public Overrides Sub ShowHand()
        ' 一枚目以外は隠す
        Dim result As String = hands.Item(0).ToString()
        For i As Integer = 1 To hands.Count -1
            result &= "[---]"
        Next
        Console.WriteLine($"[手札={result}]")
    End Sub
End Class
Public Enum Suit
    Spade
    Heart
    Diamond
    Club
End Enum
Public Class Card
    Public ReadOnly Property Suit() As Suit
    Public ReadOnly Property Rank() As Integer
    Sub New (suit As Suit, rank As Integer)
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
    Public Const RANK_MAX As INteger = 13
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

Module Util
    Public Sub Shuffle(Of T)(list As IList(Of T))
        Dim r As Random = New Random()
        For i = 0 To list.Count - 1
            Dim index As Integer = r.Next(i, list.Count)
            If i <> index Then
                Dim temp As T = list(i)
                list(i) = list (index)
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
