Module Program02
    Sub main()
        Dim enzan As New ShisokuEnzan()
        Dim keisan1 As Calculate = AddressOf enzan.Tashizan
        Dim keisan2 As Calculate = AddressOf enzan.Hikizan
        Dim keisan3 As Calculate = AddressOf enzan.Kakezan
        Dim keisan4 As Calculate = AddressOf enzan.Warizan


        keisan1 = System.Delegate.Combine(keisan1,keisan2,keisan3,keisan4)

        keisan1(10, 2)

        keisan1 = System.Delegate.Remove(keisan1, keisan2)
        keisan1(18,6)
    End Sub
End Module