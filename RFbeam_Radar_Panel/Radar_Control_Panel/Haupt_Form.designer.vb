<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Window
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Window))
        Me.Label_IPAdress = New System.Windows.Forms.Label()
        Me.TextBox_UDPClientIP = New System.Windows.Forms.TextBox()
        Me.TextBox_UDPSocket = New System.Windows.Forms.TextBox()
        Me.Label_ReceivingSocketNo = New System.Windows.Forms.Label()
        Me.BGWorker_Receive = New System.ComponentModel.BackgroundWorker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_TelnetServerIP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_TelnetSocketNb = New System.Windows.Forms.TextBox()
        Me.Button_TelnetConnect = New System.Windows.Forms.Button()
        Me.Button_TelnetDisconnect = New System.Windows.Forms.Button()
        Me.GroupBox_Telnet = New System.Windows.Forms.GroupBox()
        Me.RichTextBox_TelnetErrors = New System.Windows.Forms.RichTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ComboBox_TargetFilter = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox_RxAntenna = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_SWVersion = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Button_TargetGap = New System.Windows.Forms.Button()
        Me.TextBox_TargetGap = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button_TargetThres = New System.Windows.Forms.Button()
        Me.TextBox_TargetThres = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label_RxGain = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_UDPPort = New System.Windows.Forms.Button()
        Me.TextBox_UDPServerIP = New System.Windows.Forms.TextBox()
        Me.Button_UDPServerIP = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton_Linear = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Log = New System.Windows.Forms.RadioButton()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Tab_ADCValues = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label_ADCChirpNb = New System.Windows.Forms.Label()
        Me.Label_ADCRxAnt = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Chart_ADC = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Tab_RangeFFT = New System.Windows.Forms.TabPage()
        Me.Label_RangeRxAnt = New System.Windows.Forms.Label()
        Me.PictureBox_Range = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_RangeChirp = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chart_Range = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Tab_DopplerFFT = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label_DoppRxAnt = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Chart_DopplerSpeed = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label_DoppSampNb = New System.Windows.Forms.Label()
        Me.PictureBox_Doppler = New System.Windows.Forms.PictureBox()
        Me.Tab_TargetList = New System.Windows.Forms.TabPage()
        Me.ButtonZoomTarget = New System.Windows.Forms.Button()
        Me.Label_AngleCalculated = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label_Sequence = New System.Windows.Forms.Label()
        Me.Label_TargetCnt = New System.Windows.Forms.Label()
        Me.Chart_Angle = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart_TargetDV = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button_RecalculateAxis = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_RCSComp = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_RxGain = New System.Windows.Forms.ComboBox()
        Me.GroupBox_Telnet.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.Tab_ADCValues.SuspendLayout()
        CType(Me.Chart_ADC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_RangeFFT.SuspendLayout()
        CType(Me.PictureBox_Range, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_Range, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_DopplerFFT.SuspendLayout()
        CType(Me.Chart_DopplerSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Doppler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_TargetList.SuspendLayout()
        CType(Me.Chart_Angle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_TargetDV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_IPAdress
        '
        Me.Label_IPAdress.AutoSize = True
        Me.Label_IPAdress.Location = New System.Drawing.Point(7, 22)
        Me.Label_IPAdress.Name = "Label_IPAdress"
        Me.Label_IPAdress.Size = New System.Drawing.Size(70, 17)
        Me.Label_IPAdress.TabIndex = 1
        Me.Label_IPAdress.Text = "Client IP: "
        '
        'TextBox_UDPClientIP
        '
        Me.TextBox_UDPClientIP.Location = New System.Drawing.Point(111, 18)
        Me.TextBox_UDPClientIP.Name = "TextBox_UDPClientIP"
        Me.TextBox_UDPClientIP.ReadOnly = True
        Me.TextBox_UDPClientIP.Size = New System.Drawing.Size(116, 25)
        Me.TextBox_UDPClientIP.TabIndex = 2
        '
        'TextBox_UDPSocket
        '
        Me.TextBox_UDPSocket.Location = New System.Drawing.Point(111, 69)
        Me.TextBox_UDPSocket.Name = "TextBox_UDPSocket"
        Me.TextBox_UDPSocket.ReadOnly = True
        Me.TextBox_UDPSocket.Size = New System.Drawing.Size(116, 25)
        Me.TextBox_UDPSocket.TabIndex = 4
        '
        'Label_ReceivingSocketNo
        '
        Me.Label_ReceivingSocketNo.AutoSize = True
        Me.Label_ReceivingSocketNo.Location = New System.Drawing.Point(7, 76)
        Me.Label_ReceivingSocketNo.Name = "Label_ReceivingSocketNo"
        Me.Label_ReceivingSocketNo.Size = New System.Drawing.Size(83, 17)
        Me.Label_ReceivingSocketNo.TabIndex = 5
        Me.Label_ReceivingSocketNo.Text = "Socket No.:"
        '
        'BGWorker_Receive
        '
        Me.BGWorker_Receive.WorkerSupportsCancellation = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Server IP:"
        '
        'TextBox_TelnetServerIP
        '
        Me.TextBox_TelnetServerIP.Location = New System.Drawing.Point(96, 18)
        Me.TextBox_TelnetServerIP.Name = "TextBox_TelnetServerIP"
        Me.TextBox_TelnetServerIP.ReadOnly = True
        Me.TextBox_TelnetServerIP.Size = New System.Drawing.Size(124, 25)
        Me.TextBox_TelnetServerIP.TabIndex = 22
        Me.TextBox_TelnetServerIP.Text = "192.168.0.30"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Socket No.:"
        '
        'TextBox_TelnetSocketNb
        '
        Me.TextBox_TelnetSocketNb.Location = New System.Drawing.Point(96, 46)
        Me.TextBox_TelnetSocketNb.Name = "TextBox_TelnetSocketNb"
        Me.TextBox_TelnetSocketNb.ReadOnly = True
        Me.TextBox_TelnetSocketNb.Size = New System.Drawing.Size(124, 25)
        Me.TextBox_TelnetSocketNb.TabIndex = 24
        Me.TextBox_TelnetSocketNb.Text = "23"
        '
        'Button_TelnetConnect
        '
        Me.Button_TelnetConnect.Location = New System.Drawing.Point(226, 16)
        Me.Button_TelnetConnect.Name = "Button_TelnetConnect"
        Me.Button_TelnetConnect.Size = New System.Drawing.Size(87, 27)
        Me.Button_TelnetConnect.TabIndex = 26
        Me.Button_TelnetConnect.Text = "Connect"
        Me.Button_TelnetConnect.UseVisualStyleBackColor = True
        '
        'Button_TelnetDisconnect
        '
        Me.Button_TelnetDisconnect.Enabled = False
        Me.Button_TelnetDisconnect.Location = New System.Drawing.Point(226, 44)
        Me.Button_TelnetDisconnect.Name = "Button_TelnetDisconnect"
        Me.Button_TelnetDisconnect.Size = New System.Drawing.Size(87, 27)
        Me.Button_TelnetDisconnect.TabIndex = 27
        Me.Button_TelnetDisconnect.Text = "Disconnect"
        Me.Button_TelnetDisconnect.UseVisualStyleBackColor = True
        '
        'GroupBox_Telnet
        '
        Me.GroupBox_Telnet.Controls.Add(Me.RichTextBox_TelnetErrors)
        Me.GroupBox_Telnet.Controls.Add(Me.Label26)
        Me.GroupBox_Telnet.Controls.Add(Me.TextBox_TelnetSocketNb)
        Me.GroupBox_Telnet.Controls.Add(Me.Button_TelnetDisconnect)
        Me.GroupBox_Telnet.Controls.Add(Me.Button_TelnetConnect)
        Me.GroupBox_Telnet.Controls.Add(Me.TextBox_TelnetServerIP)
        Me.GroupBox_Telnet.Controls.Add(Me.Label6)
        Me.GroupBox_Telnet.Controls.Add(Me.Label7)
        Me.GroupBox_Telnet.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox_Telnet.Name = "GroupBox_Telnet"
        Me.GroupBox_Telnet.Size = New System.Drawing.Size(328, 114)
        Me.GroupBox_Telnet.TabIndex = 28
        Me.GroupBox_Telnet.TabStop = False
        Me.GroupBox_Telnet.Text = "Telnet"
        '
        'RichTextBox_TelnetErrors
        '
        Me.RichTextBox_TelnetErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox_TelnetErrors.ForeColor = System.Drawing.Color.Red
        Me.RichTextBox_TelnetErrors.Location = New System.Drawing.Point(96, 76)
        Me.RichTextBox_TelnetErrors.Name = "RichTextBox_TelnetErrors"
        Me.RichTextBox_TelnetErrors.ReadOnly = True
        Me.RichTextBox_TelnetErrors.Size = New System.Drawing.Size(217, 26)
        Me.RichTextBox_TelnetErrors.TabIndex = 56
        Me.RichTextBox_TelnetErrors.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(14, 82)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 17)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "Errors:"
        '
        'ComboBox_TargetFilter
        '
        Me.ComboBox_TargetFilter.FormattingEnabled = True
        Me.ComboBox_TargetFilter.Items.AddRange(New Object() {"OFF", "ON"})
        Me.ComboBox_TargetFilter.Location = New System.Drawing.Point(141, 105)
        Me.ComboBox_TargetFilter.Name = "ComboBox_TargetFilter"
        Me.ComboBox_TargetFilter.Size = New System.Drawing.Size(79, 25)
        Me.ComboBox_TargetFilter.TabIndex = 64
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 17)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Filter static objects:"
        '
        'ComboBox_RxAntenna
        '
        Me.ComboBox_RxAntenna.FormattingEnabled = True
        Me.ComboBox_RxAntenna.Items.AddRange(New Object() {"RX1", "RX2"})
        Me.ComboBox_RxAntenna.Location = New System.Drawing.Point(141, 20)
        Me.ComboBox_RxAntenna.Name = "ComboBox_RxAntenna"
        Me.ComboBox_RxAntenna.Size = New System.Drawing.Size(86, 25)
        Me.ComboBox_RxAntenna.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "RX Antenna:"
        '
        'TextBox_SWVersion
        '
        Me.TextBox_SWVersion.Location = New System.Drawing.Point(141, 27)
        Me.TextBox_SWVersion.Name = "TextBox_SWVersion"
        Me.TextBox_SWVersion.ReadOnly = True
        Me.TextBox_SWVersion.Size = New System.Drawing.Size(79, 25)
        Me.TextBox_SWVersion.TabIndex = 58
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(14, 30)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(126, 17)
        Me.Label27.TabIndex = 57
        Me.Label27.Text = "Firmware Version:"
        '
        'Button_TargetGap
        '
        Me.Button_TargetGap.Enabled = False
        Me.Button_TargetGap.Location = New System.Drawing.Point(226, 75)
        Me.Button_TargetGap.Name = "Button_TargetGap"
        Me.Button_TargetGap.Size = New System.Drawing.Size(87, 27)
        Me.Button_TargetGap.TabIndex = 49
        Me.Button_TargetGap.Text = "Set"
        Me.Button_TargetGap.UseVisualStyleBackColor = True
        '
        'TextBox_TargetGap
        '
        Me.TextBox_TargetGap.Location = New System.Drawing.Point(141, 78)
        Me.TextBox_TargetGap.Name = "TextBox_TargetGap"
        Me.TextBox_TargetGap.Size = New System.Drawing.Size(79, 25)
        Me.TextBox_TargetGap.TabIndex = 48
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 17)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Gap around target:"
        '
        'Button_TargetThres
        '
        Me.Button_TargetThres.Enabled = False
        Me.Button_TargetThres.Location = New System.Drawing.Point(226, 48)
        Me.Button_TargetThres.Name = "Button_TargetThres"
        Me.Button_TargetThres.Size = New System.Drawing.Size(87, 27)
        Me.Button_TargetThres.TabIndex = 46
        Me.Button_TargetThres.Text = "Set"
        Me.Button_TargetThres.UseVisualStyleBackColor = True
        '
        'TextBox_TargetThres
        '
        Me.TextBox_TargetThres.Location = New System.Drawing.Point(141, 52)
        Me.TextBox_TargetThres.Name = "TextBox_TargetThres"
        Me.TextBox_TargetThres.Size = New System.Drawing.Size(79, 25)
        Me.TextBox_TargetThres.TabIndex = 45
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(121, 17)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Target Threshold:"
        '
        'Label_RxGain
        '
        Me.Label_RxGain.AutoSize = True
        Me.Label_RxGain.Location = New System.Drawing.Point(7, 55)
        Me.Label_RxGain.Name = "Label_RxGain"
        Me.Label_RxGain.Size = New System.Drawing.Size(66, 17)
        Me.Label_RxGain.TabIndex = 31
        Me.Label_RxGain.Text = "RX Gain:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button_UDPPort)
        Me.GroupBox2.Controls.Add(Me.TextBox_UDPServerIP)
        Me.GroupBox2.Controls.Add(Me.Button_UDPServerIP)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label_IPAdress)
        Me.GroupBox2.Controls.Add(Me.TextBox_UDPClientIP)
        Me.GroupBox2.Controls.Add(Me.TextBox_UDPSocket)
        Me.GroupBox2.Controls.Add(Me.Label_ReceivingSocketNo)
        Me.GroupBox2.Location = New System.Drawing.Point(350, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 114)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "UDP"
        '
        'Button_UDPPort
        '
        Me.Button_UDPPort.Enabled = False
        Me.Button_UDPPort.Location = New System.Drawing.Point(249, 66)
        Me.Button_UDPPort.Name = "Button_UDPPort"
        Me.Button_UDPPort.Size = New System.Drawing.Size(87, 27)
        Me.Button_UDPPort.TabIndex = 51
        Me.Button_UDPPort.Text = "Set"
        Me.Button_UDPPort.UseVisualStyleBackColor = True
        '
        'TextBox_UDPServerIP
        '
        Me.TextBox_UDPServerIP.Location = New System.Drawing.Point(111, 44)
        Me.TextBox_UDPServerIP.Name = "TextBox_UDPServerIP"
        Me.TextBox_UDPServerIP.ReadOnly = True
        Me.TextBox_UDPServerIP.Size = New System.Drawing.Size(116, 25)
        Me.TextBox_UDPServerIP.TabIndex = 52
        '
        'Button_UDPServerIP
        '
        Me.Button_UDPServerIP.Enabled = False
        Me.Button_UDPServerIP.Location = New System.Drawing.Point(249, 41)
        Me.Button_UDPServerIP.Name = "Button_UDPServerIP"
        Me.Button_UDPServerIP.Size = New System.Drawing.Size(87, 27)
        Me.Button_UDPServerIP.TabIndex = 50
        Me.Button_UDPServerIP.Text = "Set"
        Me.Button_UDPServerIP.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Server IP:"
        '
        'RadioButton_Linear
        '
        Me.RadioButton_Linear.AutoSize = True
        Me.RadioButton_Linear.Location = New System.Drawing.Point(28, 43)
        Me.RadioButton_Linear.Name = "RadioButton_Linear"
        Me.RadioButton_Linear.Size = New System.Drawing.Size(69, 21)
        Me.RadioButton_Linear.TabIndex = 40
        Me.RadioButton_Linear.Text = "Linear"
        Me.RadioButton_Linear.UseVisualStyleBackColor = True
        '
        'RadioButton_Log
        '
        Me.RadioButton_Log.AutoSize = True
        Me.RadioButton_Log.Checked = True
        Me.RadioButton_Log.Location = New System.Drawing.Point(28, 23)
        Me.RadioButton_Log.Name = "RadioButton_Log"
        Me.RadioButton_Log.Size = New System.Drawing.Size(94, 21)
        Me.RadioButton_Log.TabIndex = 41
        Me.RadioButton_Log.TabStop = True
        Me.RadioButton_Log.Text = "Logarithm"
        Me.RadioButton_Log.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.Tab_ADCValues)
        Me.TabControl.Controls.Add(Me.Tab_RangeFFT)
        Me.TabControl.Controls.Add(Me.Tab_DopplerFFT)
        Me.TabControl.Controls.Add(Me.Tab_TargetList)
        Me.TabControl.Location = New System.Drawing.Point(12, 215)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1096, 500)
        Me.TabControl.TabIndex = 42
        '
        'Tab_ADCValues
        '
        Me.Tab_ADCValues.BackColor = System.Drawing.SystemColors.Control
        Me.Tab_ADCValues.Controls.Add(Me.Label19)
        Me.Tab_ADCValues.Controls.Add(Me.Label_ADCChirpNb)
        Me.Tab_ADCValues.Controls.Add(Me.Label_ADCRxAnt)
        Me.Tab_ADCValues.Controls.Add(Me.Label14)
        Me.Tab_ADCValues.Controls.Add(Me.Chart_ADC)
        Me.Tab_ADCValues.Location = New System.Drawing.Point(4, 26)
        Me.Tab_ADCValues.Name = "Tab_ADCValues"
        Me.Tab_ADCValues.Size = New System.Drawing.Size(1088, 470)
        Me.Tab_ADCValues.TabIndex = 3
        Me.Tab_ADCValues.Text = "ADC Values"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(24, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 17)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "Chirp Nb.:"
        '
        'Label_ADCChirpNb
        '
        Me.Label_ADCChirpNb.AutoSize = True
        Me.Label_ADCChirpNb.Location = New System.Drawing.Point(107, 18)
        Me.Label_ADCChirpNb.Name = "Label_ADCChirpNb"
        Me.Label_ADCChirpNb.Size = New System.Drawing.Size(16, 17)
        Me.Label_ADCChirpNb.TabIndex = 54
        Me.Label_ADCChirpNb.Text = "0"
        '
        'Label_ADCRxAnt
        '
        Me.Label_ADCRxAnt.AutoSize = True
        Me.Label_ADCRxAnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ADCRxAnt.Location = New System.Drawing.Point(121, 39)
        Me.Label_ADCRxAnt.Name = "Label_ADCRxAnt"
        Me.Label_ADCRxAnt.Size = New System.Drawing.Size(38, 17)
        Me.Label_ADCRxAnt.TabIndex = 53
        Me.Label_ADCRxAnt.Text = "RX1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 17)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "ADC Values of: "
        '
        'Chart_ADC
        '
        Me.Chart_ADC.BorderlineColor = System.Drawing.Color.Black
        Me.Chart_ADC.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.AxisX.Interval = 16.0R
        ChartArea1.AxisX.MajorGrid.Interval = 16.0R
        ChartArea1.AxisX.MajorTickMark.Interval = 16.0R
        ChartArea1.AxisX.Maximum = 128.0R
        ChartArea1.AxisX.Minimum = 0R
        ChartArea1.AxisX.Title = "ADC sample number"
        ChartArea1.AxisY.Title = "ADC bit value"
        ChartArea1.Name = "ChartArea1"
        Me.Chart_ADC.ChartAreas.Add(ChartArea1)
        Me.Chart_ADC.Location = New System.Drawing.Point(27, 55)
        Me.Chart_ADC.Name = "Chart_ADC"
        Me.Chart_ADC.Size = New System.Drawing.Size(914, 404)
        Me.Chart_ADC.TabIndex = 49
        Me.Chart_ADC.Text = "Chart1"
        '
        'Tab_RangeFFT
        '
        Me.Tab_RangeFFT.BackColor = System.Drawing.SystemColors.Control
        Me.Tab_RangeFFT.Controls.Add(Me.Label_RangeRxAnt)
        Me.Tab_RangeFFT.Controls.Add(Me.PictureBox_Range)
        Me.Tab_RangeFFT.Controls.Add(Me.Label8)
        Me.Tab_RangeFFT.Controls.Add(Me.Label_RangeChirp)
        Me.Tab_RangeFFT.Controls.Add(Me.Label2)
        Me.Tab_RangeFFT.Controls.Add(Me.Chart_Range)
        Me.Tab_RangeFFT.Location = New System.Drawing.Point(4, 26)
        Me.Tab_RangeFFT.Name = "Tab_RangeFFT"
        Me.Tab_RangeFFT.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_RangeFFT.Size = New System.Drawing.Size(1088, 470)
        Me.Tab_RangeFFT.TabIndex = 1
        Me.Tab_RangeFFT.Text = "Range FFT"
        '
        'Label_RangeRxAnt
        '
        Me.Label_RangeRxAnt.AutoSize = True
        Me.Label_RangeRxAnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RangeRxAnt.Location = New System.Drawing.Point(119, 46)
        Me.Label_RangeRxAnt.Name = "Label_RangeRxAnt"
        Me.Label_RangeRxAnt.Size = New System.Drawing.Size(38, 17)
        Me.Label_RangeRxAnt.TabIndex = 51
        Me.Label_RangeRxAnt.Text = "RX1"
        '
        'PictureBox_Range
        '
        Me.PictureBox_Range.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox_Range.Location = New System.Drawing.Point(819, 65)
        Me.PictureBox_Range.Name = "PictureBox_Range"
        Me.PictureBox_Range.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox_Range.TabIndex = 50
        Me.PictureBox_Range.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Chirp Nb.:"
        '
        'Label_RangeChirp
        '
        Me.Label_RangeChirp.AutoSize = True
        Me.Label_RangeChirp.Location = New System.Drawing.Point(96, 18)
        Me.Label_RangeChirp.Name = "Label_RangeChirp"
        Me.Label_RangeChirp.Size = New System.Drawing.Size(16, 17)
        Me.Label_RangeChirp.TabIndex = 48
        Me.Label_RangeChirp.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Range FFT of:"
        '
        'Chart_Range
        '
        Me.Chart_Range.BorderlineColor = System.Drawing.Color.Black
        Me.Chart_Range.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea2.AxisX.Interval = 32.0R
        ChartArea2.AxisX.MajorGrid.Interval = 32.0R
        ChartArea2.AxisX.MajorTickMark.Interval = 32.0R
        ChartArea2.AxisX.Maximum = 128.0R
        ChartArea2.AxisX.Minimum = 0R
        ChartArea2.AxisX.Title = "Sample Number"
        ChartArea2.AxisY.IsLogarithmic = True
        ChartArea2.AxisY.Title = "RCS"
        ChartArea2.Name = "ChartArea1"
        Me.Chart_Range.ChartAreas.Add(ChartArea2)
        Me.Chart_Range.Location = New System.Drawing.Point(16, 65)
        Me.Chart_Range.Name = "Chart_Range"
        Me.Chart_Range.Size = New System.Drawing.Size(797, 393)
        Me.Chart_Range.TabIndex = 46
        Me.Chart_Range.Text = "Chart1"
        '
        'Tab_DopplerFFT
        '
        Me.Tab_DopplerFFT.BackColor = System.Drawing.SystemColors.Control
        Me.Tab_DopplerFFT.Controls.Add(Me.Label10)
        Me.Tab_DopplerFFT.Controls.Add(Me.Label_DoppRxAnt)
        Me.Tab_DopplerFFT.Controls.Add(Me.Label20)
        Me.Tab_DopplerFFT.Controls.Add(Me.Label12)
        Me.Tab_DopplerFFT.Controls.Add(Me.Chart_DopplerSpeed)
        Me.Tab_DopplerFFT.Controls.Add(Me.Label9)
        Me.Tab_DopplerFFT.Controls.Add(Me.Label_DoppSampNb)
        Me.Tab_DopplerFFT.Controls.Add(Me.PictureBox_Doppler)
        Me.Tab_DopplerFFT.Location = New System.Drawing.Point(4, 26)
        Me.Tab_DopplerFFT.Name = "Tab_DopplerFFT"
        Me.Tab_DopplerFFT.Size = New System.Drawing.Size(1088, 470)
        Me.Tab_DopplerFFT.TabIndex = 2
        Me.Tab_DopplerFFT.Text = "Doppler FFT"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 17)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Doppler FFT of:"
        '
        'Label_DoppRxAnt
        '
        Me.Label_DoppRxAnt.AutoSize = True
        Me.Label_DoppRxAnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DoppRxAnt.Location = New System.Drawing.Point(114, 10)
        Me.Label_DoppRxAnt.Name = "Label_DoppRxAnt"
        Me.Label_DoppRxAnt.Size = New System.Drawing.Size(38, 17)
        Me.Label_DoppRxAnt.TabIndex = 53
        Me.Label_DoppRxAnt.Text = "RX1"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(37, 313)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 17)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "V-  --> | <--  V+"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(146, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(249, 17)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Maximal values of speed (upper half):"
        '
        'Chart_DopplerSpeed
        '
        Me.Chart_DopplerSpeed.BorderlineColor = System.Drawing.Color.Black
        Me.Chart_DopplerSpeed.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea3.AxisX.Interval = 16.0R
        ChartArea3.AxisX.MajorGrid.Interval = 16.0R
        ChartArea3.AxisX.MajorTickMark.Interval = 16.0R
        ChartArea3.AxisX.Maximum = 128.0R
        ChartArea3.AxisX.Minimum = 0R
        ChartArea3.AxisX.Title = "Speed sample number"
        ChartArea3.AxisY.IsLogarithmic = True
        ChartArea3.AxisY.Title = "RCS"
        ChartArea3.Name = "ChartArea1"
        Me.Chart_DopplerSpeed.ChartAreas.Add(ChartArea3)
        Me.Chart_DopplerSpeed.Location = New System.Drawing.Point(278, 54)
        Me.Chart_DopplerSpeed.Name = "Chart_DopplerSpeed"
        Me.Chart_DopplerSpeed.Size = New System.Drawing.Size(797, 393)
        Me.Chart_DopplerSpeed.TabIndex = 47
        Me.Chart_DopplerSpeed.Text = "Chart1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 17)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Sample Nb.:"
        '
        'Label_DoppSampNb
        '
        Me.Label_DoppSampNb.AutoSize = True
        Me.Label_DoppSampNb.Location = New System.Drawing.Point(94, 36)
        Me.Label_DoppSampNb.Name = "Label_DoppSampNb"
        Me.Label_DoppSampNb.Size = New System.Drawing.Size(16, 17)
        Me.Label_DoppSampNb.TabIndex = 39
        Me.Label_DoppSampNb.Text = "0"
        '
        'PictureBox_Doppler
        '
        Me.PictureBox_Doppler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox_Doppler.Location = New System.Drawing.Point(16, 54)
        Me.PictureBox_Doppler.Name = "PictureBox_Doppler"
        Me.PictureBox_Doppler.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox_Doppler.TabIndex = 38
        Me.PictureBox_Doppler.TabStop = False
        '
        'Tab_TargetList
        '
        Me.Tab_TargetList.BackColor = System.Drawing.SystemColors.Control
        Me.Tab_TargetList.Controls.Add(Me.ButtonZoomTarget)
        Me.Tab_TargetList.Controls.Add(Me.Label_AngleCalculated)
        Me.Tab_TargetList.Controls.Add(Me.Label18)
        Me.Tab_TargetList.Controls.Add(Me.Label_Sequence)
        Me.Tab_TargetList.Controls.Add(Me.Label_TargetCnt)
        Me.Tab_TargetList.Controls.Add(Me.Chart_Angle)
        Me.Tab_TargetList.Controls.Add(Me.Chart_TargetDV)
        Me.Tab_TargetList.Controls.Add(Me.Label3)
        Me.Tab_TargetList.Controls.Add(Me.Label5)
        Me.Tab_TargetList.Location = New System.Drawing.Point(4, 26)
        Me.Tab_TargetList.Name = "Tab_TargetList"
        Me.Tab_TargetList.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_TargetList.Size = New System.Drawing.Size(1088, 470)
        Me.Tab_TargetList.TabIndex = 0
        Me.Tab_TargetList.Text = "Target list"
        '
        'ButtonZoomTarget
        '
        Me.ButtonZoomTarget.Location = New System.Drawing.Point(864, 15)
        Me.ButtonZoomTarget.Name = "ButtonZoomTarget"
        Me.ButtonZoomTarget.Size = New System.Drawing.Size(87, 27)
        Me.ButtonZoomTarget.TabIndex = 52
        Me.ButtonZoomTarget.Text = "Zoom 10m"
        Me.ButtonZoomTarget.UseVisualStyleBackColor = True
        '
        'Label_AngleCalculated
        '
        Me.Label_AngleCalculated.AutoSize = True
        Me.Label_AngleCalculated.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_AngleCalculated.Location = New System.Drawing.Point(614, 36)
        Me.Label_AngleCalculated.Name = "Label_AngleCalculated"
        Me.Label_AngleCalculated.Size = New System.Drawing.Size(74, 18)
        Me.Label_AngleCalculated.TabIndex = 55
        Me.Label_AngleCalculated.Text = "RX1, RX2"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(483, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(148, 17)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "Angle calculated with:"
        '
        'Label_Sequence
        '
        Me.Label_Sequence.AutoSize = True
        Me.Label_Sequence.Location = New System.Drawing.Point(135, 36)
        Me.Label_Sequence.Name = "Label_Sequence"
        Me.Label_Sequence.Size = New System.Drawing.Size(16, 17)
        Me.Label_Sequence.TabIndex = 53
        Me.Label_Sequence.Text = "0"
        '
        'Label_TargetCnt
        '
        Me.Label_TargetCnt.AutoSize = True
        Me.Label_TargetCnt.Location = New System.Drawing.Point(135, 15)
        Me.Label_TargetCnt.Name = "Label_TargetCnt"
        Me.Label_TargetCnt.Size = New System.Drawing.Size(16, 17)
        Me.Label_TargetCnt.TabIndex = 52
        Me.Label_TargetCnt.Text = "0"
        '
        'Chart_Angle
        '
        Me.Chart_Angle.BorderlineColor = System.Drawing.Color.Black
        Me.Chart_Angle.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea4.AxisX.Interval = 8.0R
        ChartArea4.AxisX.IsStartedFromZero = False
        ChartArea4.AxisX.MajorGrid.Interval = 8.0R
        ChartArea4.AxisX.MajorTickMark.Interval = 4.0R
        ChartArea4.AxisX.Maximum = 32.0R
        ChartArea4.AxisX.Minimum = -32.0R
        ChartArea4.AxisX.ScaleView.Position = 0R
        ChartArea4.AxisX.Title = "Angle [°]"
        ChartArea4.AxisY.Crossing = -1.79769313486232R
        ChartArea4.AxisY.Interval = 10.0R
        ChartArea4.AxisY.MajorGrid.Interval = 10.0R
        ChartArea4.AxisY.MajorTickMark.Interval = 5.0R
        ChartArea4.AxisY.Maximum = 76.4R
        ChartArea4.AxisY.Minimum = 0R
        ChartArea4.AxisY.ScaleView.Position = 0R
        ChartArea4.AxisY.Title = "Distance [m]"
        ChartArea4.Name = "ChartArea1"
        Me.Chart_Angle.ChartAreas.Add(ChartArea4)
        Me.Chart_Angle.Location = New System.Drawing.Point(486, 59)
        Me.Chart_Angle.Name = "Chart_Angle"
        Me.Chart_Angle.Size = New System.Drawing.Size(465, 393)
        Me.Chart_Angle.TabIndex = 51
        Me.Chart_Angle.Text = "Chart1"
        '
        'Chart_TargetDV
        '
        Me.Chart_TargetDV.BorderlineColor = System.Drawing.Color.Black
        Me.Chart_TargetDV.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea5.AxisX.Interval = 16.0R
        ChartArea5.AxisX.IsMarginVisible = False
        ChartArea5.AxisX.IsStartedFromZero = False
        ChartArea5.AxisX.MajorGrid.Interval = 16.0R
        ChartArea5.AxisX.MajorTickMark.Interval = 16.0R
        ChartArea5.AxisX.Maximum = 32.0R
        ChartArea5.AxisX.Minimum = -32.0R
        ChartArea5.AxisX.ScaleView.Zoomable = False
        ChartArea5.AxisX.ScrollBar.Enabled = False
        ChartArea5.AxisX.Title = "Speed [km/h]"
        ChartArea5.AxisY.Crossing = -1.79769313486232R
        ChartArea5.AxisY.Interval = 10.0R
        ChartArea5.AxisY.MajorGrid.Interval = 10.0R
        ChartArea5.AxisY.MajorTickMark.Interval = 5.0R
        ChartArea5.AxisY.Maximum = 76.4R
        ChartArea5.AxisY.Minimum = 0R
        ChartArea5.AxisY.ScaleView.Position = 0R
        ChartArea5.AxisY.Title = "Distance [m]"
        ChartArea5.Name = "ChartArea1"
        Me.Chart_TargetDV.ChartAreas.Add(ChartArea5)
        Me.Chart_TargetDV.Location = New System.Drawing.Point(14, 59)
        Me.Chart_TargetDV.Name = "Chart_TargetDV"
        Me.Chart_TargetDV.Size = New System.Drawing.Size(465, 393)
        Me.Chart_TargetDV.TabIndex = 50
        Me.Chart_TargetDV.Text = "Chart1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Sequence:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Targets:"
        '
        'Button_RecalculateAxis
        '
        Me.Button_RecalculateAxis.Location = New System.Drawing.Point(199, 23)
        Me.Button_RecalculateAxis.Name = "Button_RecalculateAxis"
        Me.Button_RecalculateAxis.Size = New System.Drawing.Size(114, 27)
        Me.Button_RecalculateAxis.TabIndex = 51
        Me.Button_RecalculateAxis.Text = "Recalculate axis"
        Me.Button_RecalculateAxis.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton_Log)
        Me.GroupBox3.Controls.Add(Me.Button_RecalculateAxis)
        Me.GroupBox3.Controls.Add(Me.RadioButton_Linear)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 135)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(328, 72)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Graphic"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBox_RCSComp)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.TextBox_SWVersion)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.ComboBox_TargetFilter)
        Me.GroupBox4.Controls.Add(Me.Button_TargetGap)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.TextBox_TargetGap)
        Me.GroupBox4.Controls.Add(Me.Button_TargetThres)
        Me.GroupBox4.Controls.Add(Me.TextBox_TargetThres)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Location = New System.Drawing.Point(599, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(328, 165)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Target control"
        '
        'ComboBox_RCSComp
        '
        Me.ComboBox_RCSComp.FormattingEnabled = True
        Me.ComboBox_RCSComp.Items.AddRange(New Object() {"OFF", "ON"})
        Me.ComboBox_RCSComp.Location = New System.Drawing.Point(141, 132)
        Me.ComboBox_RCSComp.Name = "ComboBox_RCSComp"
        Me.ComboBox_RCSComp.Size = New System.Drawing.Size(79, 25)
        Me.ComboBox_RCSComp.TabIndex = 66
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 17)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "RCS Compensation:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ComboBox_RxGain)
        Me.GroupBox5.Controls.Add(Me.ComboBox_RxAntenna)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label_RxGain)
        Me.GroupBox5.Location = New System.Drawing.Point(350, 135)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(238, 87)
        Me.GroupBox5.TabIndex = 45
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Chip set control"
        '
        'ComboBox_RxGain
        '
        Me.ComboBox_RxGain.FormattingEnabled = True
        Me.ComboBox_RxGain.Items.AddRange(New Object() {"LOW", "HIGH"})
        Me.ComboBox_RxGain.Location = New System.Drawing.Point(141, 51)
        Me.ComboBox_RxGain.Name = "ComboBox_RxGain"
        Me.ComboBox_RxGain.Size = New System.Drawing.Size(86, 25)
        Me.ComboBox_RxGain.TabIndex = 67
        '
        'Main_Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1117, 723)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox_Telnet)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main_Window"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RFbeam Radar Panel"
        Me.GroupBox_Telnet.ResumeLayout(False)
        Me.GroupBox_Telnet.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.Tab_ADCValues.ResumeLayout(False)
        Me.Tab_ADCValues.PerformLayout()
        CType(Me.Chart_ADC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_RangeFFT.ResumeLayout(False)
        Me.Tab_RangeFFT.PerformLayout()
        CType(Me.PictureBox_Range, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_Range, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_DopplerFFT.ResumeLayout(False)
        Me.Tab_DopplerFFT.PerformLayout()
        CType(Me.Chart_DopplerSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Doppler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_TargetList.ResumeLayout(False)
        Me.Tab_TargetList.PerformLayout()
        CType(Me.Chart_Angle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_TargetDV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label_IPAdress As System.Windows.Forms.Label
    Friend WithEvents TextBox_UDPClientIP As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_UDPSocket As System.Windows.Forms.TextBox
    Friend WithEvents Label_ReceivingSocketNo As System.Windows.Forms.Label
    Friend WithEvents BGWorker_Receive As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_TelnetServerIP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox_TelnetSocketNb As System.Windows.Forms.TextBox
    Friend WithEvents Button_TelnetConnect As System.Windows.Forms.Button
    Friend WithEvents Button_TelnetDisconnect As System.Windows.Forms.Button
    Friend WithEvents GroupBox_Telnet As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_Linear As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Log As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents Tab_TargetList As System.Windows.Forms.TabPage
    Friend WithEvents Tab_RangeFFT As System.Windows.Forms.TabPage
    Friend WithEvents Chart_Angle As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart_TargetDV As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Tab_DopplerFFT As System.Windows.Forms.TabPage
    Friend WithEvents Tab_ADCValues As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label_RangeChirp As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Chart_Range As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents PictureBox_Range As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label_DoppSampNb As System.Windows.Forms.Label
    Friend WithEvents PictureBox_Doppler As System.Windows.Forms.PictureBox
    Friend WithEvents Chart_ADC As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button_TargetThres As System.Windows.Forms.Button
    Friend WithEvents TextBox_TargetThres As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label_RxGain As System.Windows.Forms.Label
    Friend WithEvents Button_RecalculateAxis As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Chart_DopplerSpeed As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_TargetGap As System.Windows.Forms.Button
    Friend WithEvents TextBox_TargetGap As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox_UDPServerIP As System.Windows.Forms.TextBox
    Friend WithEvents Button_UDPServerIP As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button_UDPPort As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox_TelnetErrors As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox_SWVersion As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_RxAntenna As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label_RangeRxAnt As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label_DoppRxAnt As System.Windows.Forms.Label
    Friend WithEvents Label_ADCRxAnt As System.Windows.Forms.Label
    Friend WithEvents Label_Sequence As System.Windows.Forms.Label
    Friend WithEvents Label_TargetCnt As System.Windows.Forms.Label
    Friend WithEvents ComboBox_TargetFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_RCSComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label_AngleCalculated As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label_ADCChirpNb As System.Windows.Forms.Label
    Friend WithEvents ComboBox_RxGain As ComboBox
    Friend WithEvents ButtonZoomTarget As Button
End Class
