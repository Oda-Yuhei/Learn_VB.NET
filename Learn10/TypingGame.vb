Imports System.Collections.Generic
Imports System
Module Program
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
    Sub Main(args As String())
        Console.WriteLine("---------------------------------------------------")
        Console.WriteLine("これからタイピングゲームを開始します")
        ' ファイルを読み込む
        Dim tangolist01 As New List(Of String)
        Using reader As New IO.StreamReader("Text.txt")
            While True
                Dim line As String = reader.ReadLine()
                If line Is Nothing Then
                    Exit While
                End If
                tangolist01.Add(line)

            End While
        End Using
        Shuffle(tangolist01)
        Dim misslist As New List(Of String)

        ' 問題数を選択
        Console.Write("問題数を指定してください:")
        Dim gamecount As Integer = Cint(Console.ReadLine())
        Console.WriteLine("enterをおしてゲームスタート")
        Console.ReadLine()
        Dim StartSecond As Integer = Second(Now)
        Dim StartMinute As Integer = Minute(Now)

        ' ゲーム開始
        Dim misscount As Integer = 0


        For i As Integer = 0 To gamecount - 1

        ' 問題出台
            Console.WriteLine(tangolist01(i))

        ' 解答
            Dim count As Integer = 0
        ' 次の問題
            While True
                Dim Type As String = Console.ReadLine()
                If Type = tangolist01(i) Then
                    Console.WriteLine("OK")
                    Exit While
                End If
                misscount += 1
                Console.WriteLine("NG")
                count += 1
                
            End While
            If count >= 2 Then
                misslist.add(tangolist01(i))
            End If
            
            
        Next i
        Dim finishSecond As Integer = Second(Now)
        Dim finishMinute As Integer = Minute(Now)


        Dim times As Integer = if(finishSecond - StartSecond >= 0, finishSecond - StartSecond, 60 - finishMinute - StartMinute)
        Dim timem As Integer = if(finishMinute - StartMinute >= 0, finishMinute - StartMinute, 60 - finishMinute - StartMinute)



        ' かかった時間
        Console.WriteLine($"かかった時間{timem}:{times}秒")
        ' ミス回数
        COnsole.WriteLine($"ミス回数:{misscount}")
        ' 苦手な単語
        Console.WriteLine("苦手な単語")
        For i As Integer = 0 To misslist.count -1
            Console.WriteLine(misslist(i))
        Next i
    End Sub
End Module
