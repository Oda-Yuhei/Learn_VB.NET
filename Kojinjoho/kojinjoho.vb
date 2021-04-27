Imports System.Collections.Generic

Public Class Address
	Public Property Name() As String
	Public Property Kana() As String
	Public Property Mail() As String
	Public Property Phone() As String
	Public Sub New(name As String, kana As String, mail As String, phone As String)
		MyClass.Name = name
		MyClass.Kana = kana
		MyClass.Mail = mail
		MyClass.Phone = phone
	End Sub
	Public Function GetCsvString()
		Return $"{Name},{Kana},{Mail},{Phone}"
	End Function
	Public Overrides Function ToString() As String
		Return GetCsvString()
	End Function
End Class

Public Class AddressDao
	Private Const FILE_NAME = "dummy.cgi"
	Public ReadOnly Property Addresses() As List(Of Address)
	Public Sub New()
		Addresses = LoadFile()
	End Sub
	Public Sub ShowList()
		Console.WriteLine(Addresses.Item(0))
		For i = 1 To Addresses.Count - 1
			Console.WriteLine(i & "," & Addresses.Item(i).ToString)
		Next
	End Sub
	Function LoadFile() As List(Of Address)
		Dim addresses As New List(Of Address)
		Using reader As New IO.StreamReader(FILE_NAME)
			While True
				Dim line As String = reader.ReadLine()
				If line Is Nothing Then
					Exit While
				End If
				Dim cols As String() =line.Split(",")
				addresses.Add(New Address(cols(0),cols(1),cols(2),cols(3)))
			End While
		End Using
		Return addresses
	End Function
	Public Sub SaveFile()
		Using writer As New IO.StreamWriter(FILE_NAME)
			For Each address As Address In Addresses
				writer.WriteLine(address)
			Next
		End Using
	End Sub
End Class

Public Class AddressLogic
	Private _addressDao As AddressDao
	Public Sub New()
		_addressDao = New AddressDao
	End Sub
	Private Function MainMenu()
		Dim result As Integer
		Do
			Console.WriteLine("電話帳メインメニュー")
			Console.WriteLine("１：一覧表示")
			Console.WriteLine("２：レコード追加")
			Console.WriteLine("０：保存して終了")
			Console.Write("選択してください[0-2]:")
			Dim input As String = Console.ReadLine()
			Select Case input
				Case "0","1","2"
					result = Cint(input)
					Exit Do
				Case Else
					Console.WriteLine("入力が間違えていますもう一度入力してください")
			End Select
		Loop While True
		Return result

	End Function
	Private Function ShowList()
		_addressDao.ShowList()
		Dim result As Integer
		Do
			Console.Write("0:メインメニューへ,編集:列番号:")
			Dim input As String =Console.ReadLine()
			If IsNumeric(input) Then
				result = CInt(input)
				Exit Do
			Else
				Console.WriteLine("入力が間違えていますもう一度入力してください")
			End If
		Loop While True
		Return result

	End Function
	Private Sub EditMenu(index As Integer)
		If index > 0 AndAlso index <= _addressDao.Addresses.Count Then
			Dim address = _addressDao.Addresses.Item(index)
			Console.WriteLine("個別データ処理")
			Console.WriteLine(address)
			Console.WriteLine("---------------------------------")
			Console.WriteLine("１：データ編集")
			Console.WriteLine("２：データ削除")
			Console.WriteLine("それ以外：一覧に戻る")
			Console.Write("選択してください：")

			Dim input As String = Console.ReadLine()
			Select Case input
				Case "1"
					Modify(address)
				Case "2"
					Delete(address)
				Case Else
					Console.WriteLine("一覧に戻ります")
                End Select
            Else 
                Console.WriteLine("その番号は見つかりませんでした")
        End If
    End Sub

    Private Sub Modify(address As Address)
        Console.WriteLine("変更を処理します（各項目未入力は変更しない）")
        Console.Write($"名前({address.Name}):")
        Dim name As String = Console.ReadLine()
        If Not name = address.Name AndAlso name IsNot Nothing Then
            address.Name = name
        End If

        Console.Write($"かな（{address.Kana}）:")
        Dim kana As String = Console.ReadLine()
        If Not kana = address.Kana AndAlso kana IsNot Nothing Then
            address.Kana = kana
        End If

        Console.WriteLine($"携帯電話（{address.Mail}）:")
        Dim phone As String = Console.ReadLine()
        If Not phone = address.Mail AndAlso phone IsNot Nothing Then
            address.Phone = phone
        End If
        Console.WriteLine("変更処理が完了しました。")

    End Sub
    Private Sub Delete(address As Address)
        Console.Write("削除しますよろしいでしょうか[y/y以外]：")
        If "y" = Console.ReadLine() Then
            _addressDao.Addresses.Remove(address)
            Console.WriteLine("削除しました")
        Else
            Console.WriteLine("削除をキャンセルしました")
        End If
    End Sub
    Private Sub SaveFile()
        Console.Write("ファイルに保存しますよろしいでしょうか[y/y以外]：")
        If "y" = Console.ReadLine() Then
            _addressDao.SaveFile()
            Console.WriteLine("ファイルに保存しました")
        Else
            Console.WriteLine("保存をキャンセルしました")
        End If
    End Sub
    Private Sub AddAddress()
        Console.WriteLine("レコード追加")
        Console.Write("名前　　：")
        Dim name As String = Console.ReadLine()
        If name Is Nothing Then
            Console.WriteLine("名前が未入力なので登録をキャンセルしました")
            Return
        End If

        Console.Write("かな　　：")
        Dim kana As String = Console.ReadLine()
        If kana Is Nothing Then
            Console.WriteLine("かなが未入力なので登録をキャンセルしました")
            Return
        End If

        Console.Write("メール：")
        Dim mail As String = Console.ReadLine()
        If mail Is Nothing Then
            Console.WriteLine("メールが未入力なので登録をキャンセルしました")
            Return
        End If

        Console.Write("携帯番号：")
        Dim phone As String = Console.ReadLine()
        If phone Is Nothing Then
            Console.WriteLine("携帯電話番号が未入力なので登録をキャンセルしました")
            Return
        End If

        Console.Write("登録しますよろしいでしょうか[y/y以外]:")
        If "y" = Console.ReadLine() Then
            _addressDao.Addresses.Add(New Address(name,kana,mail,phone))
            Console.WriteLine("登録しました")
        Else
            Console.WriteLine("登録をキャンセルしました")

        End If
    end Sub
	Public Sub Start()
		Dim input As Integer
		Do
			input = MainMenu()
			Select Case input
				Case 1
					Dim subInput As Integer
					Do
						subInput = ShowList()
						If subInput <> 0 Then
							EditMenu(input)
						End If
					Loop Until subInput = 0
				Case 2
					AddAddress()
			End Select
		Loop Until input = 0
	End Sub
End Class

Module Program
	Sub main()
		Dim logic As New AddressLogic()
		logic.Start
	End Sub
End Module

