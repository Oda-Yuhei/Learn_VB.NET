Imports System.Collections.Generic
Class Kojinjoho
    Public Property Name() As String
    Public Property Ruby() As String
    Public Property Mail() As String
    Public Property Phone() As String
    Sub New(Name As String, Ruby As String, Mail As String, Phone As String)
        MyClass.Name = name
        MyClass.Ruby = ruby
        MyClass.Mail = mail
        MyClass.Phone = phone
    End Sub
End Class

Module Program
    Sub main()
        Dim kojinjoho01 As New List(Of Kojinjoho)
        Using reader As New IO.StreamReader("dummy.cgi")
            While True
                Dim line As String = reader.ReadLine()
                If line Is Nothing Then
                    Exit While
                End IF
                Dim cols As String() = line.Split(",")
                kojinjoho01.Add(New Kojinjoho(cols(0),cols(1),cols(2),cols(3)))
            End While
        End Using
        While True
            Console.WriteLine("0.一覧")
            Console.WriteLine("1.レコード追加")
            Console.WriteLine("2.保存")
            Console.Write("番号を選択してください:")
            Dim selectnum As Integer = Cint(Console.ReadLine())
            Console.WriteLine()

            If selectnum = 0 Then
                For Each kojinjoho As Kojinjoho In kojinjoho01
                    Console.WriteLine("{0},{1},{2},{3}", kojinjoho.Name, kojinjoho.Ruby,kojinjoho.Mail,kojinjoho.Phone)
                Next
                
                Console.WriteLine()
                Console.WriteLine("0.データベースを編集する")
                Console.WriteLine("1.終了する")
                Console.Write("番号を選択してください:")
                selectnum = Cint(Console.ReadLine())
                If selectnum = 0 Then
                    '編集
                    '誰を編集しますか？
                    Console.Write("どのデータを編集しますか？(index number):")
                    Dim indexnumber As Integer = Cint(Console.ReadLine())
                    Console.WriteLine("{0},{1},{2},{3}", kojinjoho01(indexnumber).Name, kojinjoho01(indexnumber).Ruby,kojinjoho01(indexnumber).Mail,kojinjoho01(indexnumber).Phone)
                    'どこを編集しますか？
                    Console.WriteLine()
                    Console.WriteLine("---------------------")
                    
                    Console.WriteLine("0.名前")
                    Console.WriteLine("1.ふりがな")
                    Console.WriteLine("2.メールアドレス")
                    Console.WriteLine("3.電話番号")
                    Console.WriteLine("4.このデータを削除")
                    Console.Write("どこを編集しますか？:")
                    selectnum = Cint(Console.ReadLine())
                    If selectnum = 0 Then
                        Console.Write("入力してください:")
                        Dim x As String = Console.ReadLine()
                        kojinjoho01(indexnumber).name = x
                    Else If selectnum = 1 Then
                        Console.Write("入力してください:")
                        Dim x As String = Console.ReadLine()
                        kojinjoho01(indexnumber).ruby = x
                    Else If selectnum = 2 Then
                        Console.Write("入力してください:")
                        Dim x As String = Console.ReadLine()
                        kojinjoho01(indexnumber).mail = x
                    Else If selectnum = 3 Then
                        Console.Write("入力してください:")
                        Dim x As String = Console.ReadLine()
                        kojinjoho01(indexnumber).phone = x
                    Else If selectnum = 4 Then
                        Console.WriteLine("削除しました")
                        kojinjoho01.RemoveAt(indexnumber)
                    Else
                        Console.WriteLine("正しい数値を入力してください")
                        Continue While
                    End If
                    Console.WriteLine("修正が完了しました")

                Else If selectnum = 1 Then
                    Console.WriteLine("終了します")
                    Continue While
                Else
                    Console.WriteLine("正しい数値を入力してください")
                    Continue While
                End If

            Else If selectnum = 1 Then
                While True
                    Console.Write("名前を入力してください:")
                    Dim name As String = Console.ReadLine()
                    Console.Write("ふりがなを入力してください:")
                    Dim ruby As String = Console.ReadLine()
                    Console.Write("メールアドレスを入力してください:")
                    Dim mail As String = Console.ReadLine()
                    Console.Write("携帯番号を入力してください:")
                    Dim phone As String = Console.ReadLine()
                    Console.WriteLine()
                    Console.WriteLine("{0} : {1} : {2} : {3}", name, ruby, mail, phone)
                    Console.Write("情報に間違いはないですか？[y / n]:")
                    Dim saveans As String = Console.ReadLine()
                    If  saveans = "y" Then
                        kojinjoho01.add(New Kojinjoho(name, ruby, mail, phone))
                        Exit While
                    Else If saveans = "n"
                        Console.WriteLine("入力しなおしてください")
                        Continue While
                    Else
                        Console.WriteLine("正しい数値を入力してください")
                        Continue While
                    End If
                End While

            Else If selectnum = 2 Then
                Console.Write("保存してもよろしいですか？[y / n]:")
                Dim saveans As String = Console.ReadLine()
                If saveans = "y" Then
                    Using writer As New IO.StreamWriter("dummy.cgi")
                        For Each kojinjoho As Kojinjoho In kojinjoho01
                            writer.WriteLine("{0},{1},{2},{3}", kojinjoho.Name, kojinjoho.Ruby,kojinjoho.Mail,kojinjoho.Phone)
                        Next
                    End Using
                    Console.WriteLine("保存しました。")
                    Exit While
                Else If saveans = "n" Then
                    continue While
                Else
                    Console.WriteLine("正しい数値を入力してください")
                    Continue While
                End If
            Else
                Console.WriteLine("正しい数値を入力してください")
                Continue While
            End If
        End While
    End Sub
ENd Module