Public Class PersonalComputer
    Public Sub New()
        _cpu = 2.6
        Console.WriteLine($"CPUの値を{_cpu}GHzで初期化しました")
    End Sub

    Public Sub SeyHello()
        Console.WriteLine("こんにちは")
    End Sub

    Public Sub DispCPU()
        Console.WriteLine($"CPUは{_cpu}GHzです。")
    End Sub

    Private _cpu As Single

    Public Property CPU() As Single
        Get
            Return _cpu
        End Get
        Set(ByVal value As Single)
            _cpu = value
        End Set
    End Property


End Class
Public Class Notebook : Inherits PersonalComputer
    Private _hasBattery As Boolean
    Public Property Hasbattery As Boolean
        Get
            Return _hasBattery
        End Get
        Set(ByVal value As Boolean)
            _hasBattery = value
        End Set
    End Property

    Private _hasWirelessLan As Boolean
    Public Property HasWirelessLan As Boolean
        Get
            Return _hasWirelessLan
        End Get
        Set
            _hasWirelessLan = value
        End Set
    End Property
    Public Sub Disphardware()
        If _hasBattery = True Then
            Console.WriteLine("バッテリーを搭載しています")
        Else
            Console.WriteLine("バッテリーを搭載していません")
        End If

        If _hasWirelessLan = True Then
            Console.WriteLine("無線LANを搭載しています")
        Else
            Console.WriteLine("無線LANを搭載していません")
        End If
    End Sub
End Class
Public Class Desktop : Inherits PersonalComputer
    Private _hasDvdRom As Boolean
    Public Property HasDvdRom() As Boolean
        Get
            Return _hasDvdRom
        End Get
        Set(ByVal value As Boolean)
            _hasDvdRom = value
        End Set
    End Property

    Private _hasMediaReader As Boolean
    Public Property HasMediaReader() As Boolean
        Get
            Return _hasMediaReader
        End Get
        Set(ByVal value As Boolean)
            _hasMediaReader = value
        End Set
    End Property

    Public Sub Disphardware()
        If _hasDvdRom = True Then
            Console.WriteLine("DVD-ROMドライブを搭載しています")
        Else
            Console.WriteLine("DVD-ROMを搭載していません")
        End If

        If _hasMediaReader = True Then
            Console.WriteLine("メディアリーダを搭載しています")
        Else
            Console.WriteLine("メディアリーダを搭載していません")
        End If
    End Sub
End Class