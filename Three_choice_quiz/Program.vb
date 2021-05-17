Imports System
Imports Npgsql
Imports NpgsqlTypes

Class Quiz
    Public Property quiz_id
    Public Property question As String
    Public Property genre As String
    Public Property ans_is_correct As String
    Public Property selects As String


    Sub New(quiz_id As String, question As String, genre As String, ans_is_correct As String, selects As String)
        MyClass.quiz_id = quiz_id
        MyClass.question = question
        MyClass.genre = genre
        MyClass.ans_is_correct = ans_is_correct
        MyClass.selects = selects

    End Sub

End Class

Class genre
    Public Property genre As String
    Public Property id As Integer

    Sub New(id As Integer, genre As String)
        MyClass.id = id
        MyClass.genre = genre
    End Sub
End Class

Class Q
    Public Property question() As String
    Sub New(question As String, id As String)
        MyClass.question = question
    End Sub
End Class
Module Util
    Sub Shuffle(Of T)(list As IList(Of T))
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
    Public Function resultans(count As Integer, q As List(Of Quiz)) As String
        If q(count).ans_is_correct = 1 Then
            Return q(count).selects
        ElseIf q(count + 1).ans_is_correct = 1 Then
            Return q(count + 1).selects
        Else
            Return q(count + 2).selects
        End If
    End Function
    Public Function counts(a As Integer)
        Dim count_list As New List(Of Integer)
        For i As Integer = 1 To a
            count_list.Add(i)
        Next
        Return count_list
    End Function


    Sub Main(args As String())
        Dim quizlist_IT As New List(Of Quiz)
        Dim quizlist_ZATUGAKU As New List(Of Quiz)
        Dim genrelist As New List(Of genre)
        Dim connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=0403;DataBase=choise_quiz"
        Dim configCount_IT As Integer
        Dim configCount_ZATUGAKU As Integer

        Using con As New NpgsqlConnection(connectionString)
            con.Open()
            Dim command5 As New NpgsqlCommand("SELECT Count(quiz_id) FROM quiz JOIN genre ON quiz.genre_id = genre.id WHERE genre.id = 1;", con)
            Dim reader5 As NpgsqlDataReader = command5.ExecuteReader()

            While reader5.Read()
                configCount_IT = CInt(reader5("count"))
            End While
            reader5.Close()

            Dim command6 As New NpgsqlCommand("SELECT Count(quiz_id) FROM quiz JOIN genre ON quiz.genre_id = genre.id WHERE genre.id = 2;", con)
            Dim reader6 As NpgsqlDataReader = command6.ExecuteReader()

            While reader6.Read()
                configCount_ZATUGAKU = CInt(reader6("count"))
            End While
            reader6.Close()

            Dim command As New NpgsqlCommand($"SELECT quiz_id,quiz.question, genre.genre, selects, quiz_select.ans_is_correct FROM quiz JOIN genre ON quiz.genre_id = genre.id JOIN quiz_select ON quiz_select.ID = quiz.quiz_ID WHERE genre.id = 1 ORDER BY quiz_id;", con)
            Dim reader As NpgsqlDataReader = command.ExecuteReader()

            While reader.Read()
                quizlist_IT.Add(New Quiz(reader("quiz_id"), reader("question"), reader("genre"), reader("ans_is_correct"), reader("selects")))
            End While
            reader.Close()

            Dim command4 As New NpgsqlCommand($"SELECT quiz_id,quiz.question, genre.genre, selects, quiz_select.ans_is_correct FROM quiz JOIN genre ON quiz.genre_id = genre.id JOIN quiz_select ON quiz_select.ID = quiz.quiz_ID WHERE genre.id = 2 ORDER BY quiz_id;", con)
            Dim reader4 As NpgsqlDataReader = command4.ExecuteReader()

            While reader4.Read()
                quizlist_ZATUGAKU.Add(New Quiz(reader4("quiz_id"), reader4("question"), reader4("genre"), reader4("ans_is_correct"), reader4("selects")))
            End While
            reader.Close()

            Dim command3 As New NpgsqlCommand("SELECT DISTINCT genre.id, genre.genre FROM genre;", con)
            Dim reader3 As NpgsqlDataReader = command3.ExecuteReader()
            While reader3.Read()
                genrelist.Add(New genre(reader3("id"), reader3("genre")))
            End While


        End Using

        Dim quizlist As New List(Of Quiz)
        Dim count_list As New List(Of Integer)
        Dim count As Integer = 1
        Dim questioncount As Integer = 0

        While True
            Console.WriteLine("ジャンルを選択してください")
            Console.WriteLine($"1. IT : 全{(quizlist_IT.Count) / 3}問")
            Console.WriteLine($"2. 雑学 : 全{(quizlist_ZATUGAKU.Count) / 3}問")
            Dim genre_select As Integer = CInt(Console.ReadLine())
            Select Case genre_select
                Case 1
                    quizlist = quizlist_IT
                    count_list = counts(quizlist.Count / 3)
                    Shuffle((count_list))
                    Exit While
                Case 2
                    quizlist_IT.AddRange(quizlist_ZATUGAKU)

                    quizlist = quizlist_IT
                    count_list = counts(quizlist_ZATUGAKU.Count / 3)
                    Shuffle((count_list))
                    For i As Integer = 9 To count_list.Count - 1
                        count_list.Insert(i, count_list(i) + 9)
                        count_list.RemoveAt(i + 1)
                        Console.WriteLine(count_list(i))
                    Next
                    Dim b As New List(Of Integer)
                    b = counts(quizlist_IT.Count / 3)
                    b.AddRange(count_list)
                    count_list = b
                    count += 9
                    questioncount = 9
                    Exit While
                Case Else
                    Console.WriteLine("正しい数値を入力してください")
                    Continue While
            End Select
        End While




        While True
            Console.Write("問題数を選択してください：")
            questioncount += CInt(Console.ReadLine())


            If questioncount <= quizlist.Count And questioncount > 0 Then
                Exit While
            Else
                Console.WriteLine("正しい数値を入力してください")
                Continue While
            End If
        End While

        Dim a As Integer = 1
        Dim correct As Integer = 0
        While count - 1 < questioncount
            ' 問題の表示
            Console.WriteLine("-----------------------------------")
            Console.WriteLine($"第{a}問")
            Console.WriteLine(quizlist(count_list(count) * 3 - 3).question)
            For i As Integer = 0 To count_list.Count - 1
                Console.WriteLine(count_list(i))
            Next
            ' 解答択３つを表示
            Console.Write("0:")
            Console.WriteLine(quizlist(count_list(count) * 3 - 3).selects)
            Console.Write("1:")
            Console.WriteLine(quizlist(count_list(count) * 3 + 1 - 3).selects)
            Console.Write("2:")
            Console.WriteLine(quizlist(count_list(count) * 3 + 2 - 3).selects)
            ' 解答選択   
            Dim ansNum As Integer = CInt(Console.ReadLine())

            If quizlist(count_list(count) * 3 - 3 + ansNum).ans_is_correct = 1 And (ansNum >= 0 And ansNum <= 2) Then
                correct += 1
                a += 1
                Console.WriteLine("正解")
                Console.WriteLine("次へ(何かキーを押してください)")
                Console.ReadLine()
            ElseIf quizlist(count_list(count) * 3 - 3 + ansNum).ans_is_correct = 0 And (ansNum >= 0 And ansNum <= 2) Then
                Console.WriteLine("不正解")
                Console.WriteLine($"正解は　{resultans(count_list(count) * 3 - 3, quizlist)}　です")
                Console.WriteLine("次へ(何かキーを押してください)")
                Console.ReadLine()
                a += 1


            Else
                Console.WriteLine("正しい数値を入力してください")
                ansNum = 0
                Continue While
            End If
            '答え合わせ
            '選択回数繰り返し
            count += 1
        End While
        ' 何問中何問正解したのか表示
        Console.WriteLine($"{questioncount}問中{correct}問正解")



    End Sub
End Module
