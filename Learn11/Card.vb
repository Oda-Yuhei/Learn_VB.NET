Public Class Card
    Public ReadOnly Property Suit() As Integer
    Public ReadOnly Property Rank() As Integer
    
    Public Sub New(suit As Integer,rank as Integer)
        _Suit = suit
        _Rank = rank
    End Sub
    Public Function ToString() As String
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
                result = MyClass.suit
        End Select
        Dim resultR As String
        Select Case MyClass.suit
            Case 0
                resultR = "スペード"
            Case 1
                resultR = "ハート"
            Case 2
                resultR = "ダイアモンド"
            Case 3
                resultR = "クラブ"
            Case Else
                resultR = "範囲外"
        End Select

        Return $"{resultR} {result}"
    End Function
End Class

Module Cards
    Sub main()
        Dim card1 As New Card(13,12)
        Dim card2 As New Card(1,2)
        Console.WriteLine(Card1)
        Console.WriteLine(Card2)
    End Sub
End Module