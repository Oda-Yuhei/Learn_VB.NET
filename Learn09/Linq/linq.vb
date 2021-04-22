Imports System.Collections.Generic
Imports System.Data.Ling
Module Module1
    Public Class CustomerData
        Public Property CustID As Integer
        Public Property Name As String
    End Class

    Public Class SalesData
        Public Property No As Integer
        Public Property CustID As Integer
        Public Property Kingaku As Integer
        Public Property YMD As Date
    End Class

    Private CustList As List(Of CustomerData)
    Private SalesList As List(Of SalesData)

    Private Function GetCustomeList() As List(Of CustomerData)
        CustList = New List(Of CustomerData)

        CustList.Add(New CustomerData With{.CustID = 1, .Name = "花丸デパート"})
        CustList.Add(New CustomerData With{.CustID = 2, .Name = "銀座百貨店"})
        CustList.Add(New CustomerData With{.CustID = 3, .Name = "一本木ヒルズ"})
        CustList.Add(New CustomerData With{.CustID = 4, .Name = "さくらや"})

        Return CustList
    End Function

    Private Function GetSalesList() As List(Of SalesData)
        SalesList = New List(Of SalesData)
        SalesList.Add(New SalesData With{.No = 1, .CustId = 1, .Kingaku = 1000, .YMD = CDate("2017/10/01")})
        SalesList.Add(New SalesData With{.No = 2, .CustId = 2, .Kingaku = 1400, .YMD = CDate("2017/10/01")})
        SalesList.Add(New SalesData With{.No = 3, .CustId = 1, .Kingaku = 1500, .YMD = CDate("2017/10/02")})
        SalesList.Add(New SalesData With{.No = 4, .CustId = 3, .Kingaku = 2000, .YMD = CDate("2017/10/03")})
        SalesList.Add(New SalesData With{.No = 5, .CustId = 2, .Kingaku = 1300, .YMD = CDate("2017/10/03")})

        Return SalesList
    End Function

    Sub main()
        Dim customer = GetCustomerList()
        Dim sales = GetSalesList()

        Dim records = From kokyaku In customer join uriage In sales On kokyaku.CustID Equals uriage.CustID Order By uriage.No Select uriage.No,kokyaku.Name,uriage.Kingaku,uriage.YMD

        For Each r In records
            Console.WriteLine($"{r.No},{r.Name},{r.Kingaku},{r.YMD}")
        Next
    End Sub
End Module