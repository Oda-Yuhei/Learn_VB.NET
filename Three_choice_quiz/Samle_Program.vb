Imports System
Imports Npgsql
Public Class QuizDao
    Private Const connectionString As String = "Server=localhost;Port5432;User Id=postgres;Password=0403;DataBase=Sample"
    Public Const QUIZ_COUNT As Integer = 2
    Public Function GetGenres() As List(Of Genre)
        Dim genres As New List(Of Genre)
        Using con As New NpgsqlConnection(connectionString)
            con.Open()
            Dim command As New NpgsqlCommand("SELECT * FROM genre;", con)
            Dim reader As NpgsqlDataReader = command.ExecuteReader()
            While reader.Read()
                genres.Add(New Genre(reader("id"), reader("name")))
            End While
            reader.Close()
            command.Dispose()

        End Using
        Return genres
    End Function
    Public Function GetQuizzes(genre_id As Integer) As List(Of Quiz)
        Dim quizzes As New List(Of Quiz)
        Dim choices As New List(Of Choice)
        Using con As New NpgsqlConnection(connectionString)
            con.Open()
            Dim command As New NpgsqlCommand("SELECT * FROM quiz WHERE genre_id = @genre_id", con)
            command.Parameters.AddWithValue("genre_id", genre_id)
            command.Prepare()
            Dim reader As NpgsqlDataReader = command.ExecuteReader()
            While reader.Read()
                quizzes.Add(New Quiz(reader("id"), reader("genre_id"), reader("question")))
            End While
            reader.Close()
            command.Dispose()
            Util.Shuffle(quizzes)
            quizzes.RemoveRange(QUIZ_COUNT, quizzes.Count - QUIZ_COUNT)
            Dim quiz_ids As String = String.Join(",", quizzes.Select(Function(q) q.Id))
            '関数型リンク（ラムダ式）
            command = New NpgsqlCommand($"SELECT * FROM choice WHERE quiz_id IN ({quiz_ids});", con)
            reader = command.ExecuteReader()
            While reader.Read()
                choices.Add(New Choice(reader("id"), reader("quiz_id"), reader("choice"), reader("is_correct")))

            End While
            reader.Close()
            command.Dispose()
            For Each quiz As Quiz In quizzes
                quiz.Choices = New List(Of Choice)(choices.Where(Function(c) c.Quiz_id = quiz.Id))
                '問題と選択肢の連結

            Next
        End Using
        Return quizzes
    End Function

End Class

Public Class Choice
    Public ReadOnly Property Id() As Integer
    Public ReadOnly Property Quiz_id() As Integer
    Public ReadOnly Property Choise() As String
    Public ReadOnly Property Is_correct As Boolean
    Public Sub New(id As Integer, quiz_id As Integer, choise As String, is_correct As Boolean)
        Me.Id = id
        Me.Quiz_id = quiz_id
        Me.Choise = choise
        Me.Is_correct = is_correct

    End Sub
End Class
Public Class Genre
    Public ReadOnly Property Id() As Integer
    Public ReadOnly Property Name() As String
    Public Sub New(id As Integer, name As String)
        Me.Id = id
        Me.Name = name
    End Sub
    Public Overloads Function ToString()
        Return $"[{Id}] {Name}"
    End Function

End Class
Public Class Quiz
    Public ReadOnly Property Id() As String
    Public ReadOnly Property Genre_id() As String
    Public ReadOnly Property Question() As String
    Private _Choise As List(Of Choice)
    Public Property Choices() As List(Of Choice)
        Get
            Return _Choise
        End Get
        Set(value As List(Of Choice))
            _Choise = value
        End Set
    End Property
    Public Sub New(id As Integer, genre_id As Integer, question As String, choices As List(Of Choice))
        Me.Id = id
        Me.Genre_id = genre_id
        Me.Question = question
        Me.Choices = choices

    End Sub
    Public Sub New(id As Integer, genre_id As Integer, question As String)
        Me.Id = id
        Me.Genre_id = genre_id
        Me.Question = question
    End Sub
    Public Sub ShowQuestion()
        Console.WriteLine(Question)
        For i As Integer = 1 To Choices.Count
            Console.WriteLine($"[{i}],{Choices(i - 1).Choise}")

        Next
        Console.Write($"選択してください[1 - {Choices.Count}] : ")

    End Sub
    Public Function IsCorrect(index As Integer) As Boolean
        If index < 1 AndAlso index > Choices.Count Then
            Throw New IndexOutOfRangeException("解答の入力が正しくない")
        End If
        Return Choices(index - 1).Is_correct
    End Function
End Class
Public Class QuizLogic
    Private ReadOnly genres As List(Of Genre)
    Private ReadOnly quizDao As QuizDao
    Public Sub New()
        quizDao = New QuizDao()
        genres = quizDao.Getgenres()
    End Sub
    Public Function SelectGenre() As Integer
        Console.WriteLine("選択クイズ")
        For Each genre As Genre In genres
            Console.WriteLine(genre.ToString())

        Next
        Console.Write("ジャンルを選択してください : ")
        Return CInt(Console.ReadLine())

    End Function
    Public Sub Start()
        Dim genreId As Integer = SelectGenre()
        Dim quizzes As List(Of Quiz) = quizDao.GetQuizzes(genreId)
        Dim correctCount As Integer = 0
        For i As Integer = 1 To quizzes.Count
            With quizzes(i - 1)
                .ShowQuestion()
                If .IsCorrect(CInt(Console.ReadLine())) Then
                    correctCount += 1
                    Console.WriteLine("正解")
                Else
                    Console.WriteLine("不正解")
                End If
            End With
        Next
        Console.WriteLine($"結果発表 {quizzes.Count} 問中 {correctCount} 問正解")
    End Sub
End Class
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

    Sub Main(args As String())
        Dim logic As New QuizLogic()
        logic.Start()
    End Sub
End Module


'CREATE TABLE choice
'(
'    id SERIAL,
'    quiz_id INT Not NULL,
'    choice VARCHAR(50) Not NULL,
'    is_correct BOOL Not NULL,
'    PRIMARY KEY(id)
');

'CREATE TABLE genre
'(
'    id SERIAL,
'    name VARCHAR(50) Not NULL,
'    is_correct BOOL Not NULL,
'    PRIMARY KEY(id)
');

'CREATE TABLE quiz
'(
'    id SERIAL,
'    genre_id INT Not NULL,
'    question VARCHAR(100) COLLATE pg_catalog. "default" Not NULL,
'    PRIMARY KEY(id)
');
