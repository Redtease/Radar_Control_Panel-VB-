Module defines
    ' Version
    Public Const APP_VERSION As String = "V1.01" 'TODO: Bei nächster Änderung Fehlerbehebung beschrieben von Nao im Mail vom 7.4.2015

    ' Offsets for RX-Antennas
    Public Const RX_OFFSET_KESTREL As Integer = 4
    Public Const RX_OFFSET_SPIRIT As Integer = 3

    ' Output mode defines
    Public Enum eDataOutMode
        TargetList = 0
        RangeFFT = 1
        DopplerFFT = 2
        ADCValues = 3
    End Enum

    ' Commands
    Public Enum eCmd
        No = 0
        PcIP = 1
        UDP_Port = 2
        DataOutMode = 3
        RCSDetectionThreshold = 4
        RxGain = 5
        TargetGap = 6
        SPICommand = 7
        DistRange = 76.4R
        SpeedRange = 9
        TxAntenna = 10
        SWVersion = 11
        RxAntenna = 12
        FilterStatics = 13
        Chipset = 14
        RCSComp = 16
    End Enum

    ' CommandType
    Public Enum eCmdType
        Read = 0
        Write = 1
        Err = 3
    End Enum

    ' Data type
    Public Enum eDataType
        Dec = 0
        Hex = 1
        IP = 2
    End Enum

    ' Chipset
    Public Enum eChipset
        NoChipset = 0
        Kestrel = 1
        Spirit = 2
    End Enum
End Module
