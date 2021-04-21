Imports System.Collections.Generic
Class Product
    Public Property Name() As String
    Public Property Price() As Integer

    Public Sub New(name As String, price As Integer)
        MyClass.Name = name
        MyClass.Price = price
    End Sub
End Class
Module Program
    Sub main()
        Dim p1 As New Product("Mac Book Pro",248000)
        Dim p2 As New Product("ThinkPad",148000)
        Dim p3 As New Product("VAIO",156200)
        Dim p4 As New Product("Surface",122800)

        Dim Products As New List(Of Product) From {p1,p2,p3,p4}

        For Each product As Product In products
            Console.WriteLine("{0} {1}", product.Name, product.Price)
        Next
        Console.WriteLine("--------------")

        Dim remove As New Product("Mac Book Pro", 248000)
        products.Remove(remove)

        For Each product As Product In products
            Console.WriteLine("{0} {1}", product.Name, product.Price)
        Next
        Console.WriteLine("--------------")
        
        products.Remove(p2)

        For Each product As Product In products
            Console.WriteLine("{0} {1}", product.Name, product.Price)
        Next
        Console.WriteLine("--------------")

        products.Add(p1)
        products.Add(p1)
        products.Add(p1)

        For Each product As Product In products
            Console.WriteLine("{0} {1}", product.Name, product.Price)
        Next
        Console.WriteLine("--------------")

        products.Remove(p1)

        For Each product As Product In products
            Console.WriteLine("{0} {1}", product.Name, product.Price)
        Next
        Console.WriteLine("--------------")



    End Sub
End Module
