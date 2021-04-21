Module Program
    Sub main()
        Dim enzan As New ShisokuEnzan()
        Dim keisan As Calculate

        keisan = New Calculate(AddressOf enzan.Tashizan)
        keisan(3,5)

        keisan = New Calculate(AddressOf enzan.Hikizan)
        keisan(5,3)

        keisan = New Calculate(AddressOf enzan.Kakezan)
        keisan(2,4)
        
        keisan = New Calculate(AddressOf enzan.Warizan)
        keisan(6,2)


    End Sub
End Module