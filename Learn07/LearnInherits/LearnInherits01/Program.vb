Module Program
    Sub main()
        Dim desktop1 As New Desktop()
        Dim notebook1 As New Notebook()

        Console.WriteLine("===== Desktopクラスのインスタンス====")
        '基本クラスのメンバを使用
        desktop1.CPU = 3.2
        desktop1.DispCPU()
        desktop1.SeyHello()
        'Desktopクラスの独自のメンバを使用
        desktop1.HasDvdRom = True
        desktop1.HasMediaReader = True
        desktop1.Disphardware()

        Console.WriteLine("===== Notebookクラスのインスタンス====")
        notebook1.CPU = 2.2
        notebook1.DispCPU()
        notebook1.SeyHello()
        'Notebookクラスの独自のメンバを使用
        notebook1.Hasbattery = True
        notebook1.HasWirelessLan = True
        notebook1.Disphardware()

    End Sub
End Module