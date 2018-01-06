Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Net.Sockets
Imports System.Math
Imports System.Text


Public Class Main_Window
    ' --- UDP global variables*******************************************************UDP全局变量
    Dim receivingUdpClient As UdpClient
    Dim RemoteIpEndPoint As New System.Net.IPEndPoint(System.Net.IPAddress.Any, 0)
    Dim TelnetTimer As System.Windows.Forms.Timer = New Timer()
    Dim receiveBytes As Byte()
    ' --- Telnet global variables*********************************************************Telnet全局变量
    Dim networkStream As System.Net.Sockets.NetworkStream
    Dim tcpClient As System.Net.Sockets.TcpClient
    Dim connectResult As IAsyncResult
    Dim telnetInitCmd As eCmd
    Dim telnetInitDataTyp As eDataType
    Dim bWaitInitCmd As Boolean = False

    Dim PointColors(32) As Color
    Dim Range_Pic As New Bitmap(256, 256)
    Dim Doppler_Pic As New Bitmap(256, 256)
    Dim DopplerSerieSpeed, DopplerSerieDistance As Series
    Dim TargetDVSpec(32), TargetAngleSpec(32) As Series

    Dim thresholdLine1, thresholdLine2 As New HorizontalLineAnnotation()
    Dim RCSThreshold As Integer
    Dim SpeedRange As Double
    Dim DistRange As Double

    Public Sub New()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        ' Read screen size
        Dim nWorkingWidth As Integer
        Dim nWorkingHeight As Integer

        With Screen.PrimaryScreen.WorkingArea
            nWorkingWidth = .Width
            nWorkingHeight = .Height
        End With
        ' Set Height to working area height
        If (Me.Size.Height > nWorkingHeight) Then
            Me.Size = New Size(Me.Size.Width, nWorkingHeight)
        End If
        ' Set Width to working area height
        If (Me.Size.Width > nWorkingWidth) Then
            Me.Size = New Size(nWorkingWidth, Me.Size.Height)
        End If

        ' Init Telnet
        TelnetTimer.Interval = 50
        AddHandler TelnetTimer.Tick, AddressOf fPoll_Telnet
        ' Init new socket
        tcpClient = New System.Net.Sockets.TcpClient
        ' Starte asynchronen Connect
        connectResult = tcpClient.BeginConnect(TextBox_TelnetServerIP.Text, CInt(TextBox_TelnetSocketNb.Text), Nothing, Nothing)
        telnetInitCmd = eCmd.PcIP
        telnetInitDataTyp = eDataType.IP
        ' Start Telnet timer
        TelnetTimer.Start()

        ' Set text of window
        Me.Text &= " " & APP_VERSION

        For i = 0 To 32 Step 1
            TargetDVSpec(i) = New Series
            TargetDVSpec(i).ChartType = SeriesChartType.Point
            TargetDVSpec(i).MarkerStyle = MarkerStyle.Circle
            TargetDVSpec(i).MarkerSize = 14

            TargetAngleSpec(i) = New Series
            TargetAngleSpec(i).ChartType = SeriesChartType.Point
            TargetAngleSpec(i).MarkerStyle = MarkerStyle.Circle
            TargetAngleSpec(i).MarkerSize = 14

            ' Save color
            PointColors(i) = Color.Blue
        Next

        DopplerSerieSpeed = New Series
        DopplerSerieSpeed.ChartType = SeriesChartType.Line
        DopplerSerieSpeed.Color = Color.Blue
        For j = 0 To 127 Step 1
            DopplerSerieSpeed.Points.AddXY(j, 1)
        Next
        Chart_DopplerSpeed.Series.Add(DopplerSerieSpeed)

        DopplerSerieDistance = New Series
        DopplerSerieDistance.ChartType = SeriesChartType.Line
        DopplerSerieDistance.Color = Color.Blue
        For j = 0 To 127 Step 1
            DopplerSerieDistance.Points.AddXY(j, 1)
        Next

        ' Set threshold line
        thresholdLine1.IsInfinitive = True
        thresholdLine1.LineColor = Color.Red
        thresholdLine1.AxisY = Chart_DopplerSpeed.ChartAreas(0).AxisY
        thresholdLine1.ClipToChartArea = Chart_DopplerSpeed.ChartAreas(0).Name
        Chart_DopplerSpeed.Annotations.Add(thresholdLine1)
        thresholdLine2.IsInfinitive = True
        thresholdLine2.LineColor = Color.Red

        Button_UDPServerIP.Visible = False
        Button_UDPPort.Visible = False
        DistRange = 76.4R
        SpeedRange = 32.0R
    End Sub

    Private Sub BGWorker_Receive_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWorker_Receive.DoWork
        Try
            ' Warte auf Bytes
            receiveBytes = receivingUdpClient.Receive(RemoteIpEndPoint)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BGWorker_Receive_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGWorker_Receive.RunWorkerCompleted
        Dim RangeSpec, ADCVals1, ADCVals2 As New Series
        Dim Value, Ident, Targets, Sequence, RCS, Angle, Speed, Distance, ChirpNb, SampleNb As Integer
        Dim color As Color
        Dim longVal As Long
        Dim re, im As Long

        ' Show data first after all telnet commands
        If (telnetInitCmd = eCmd.No) Then
            ' IP anzeigen
            TextBox_UDPClientIP.Text = RemoteIpEndPoint.Address.ToString

            ' Read Identification
            Ident = receiveBytes(0) * 256 + receiveBytes(1)

            If (Ident = &H1973) Then
                ' ******** Targets *****************
                Try
                    ' Alle Linien löschen
                    Chart_TargetDV.Series.Clear()
                    Chart_Angle.Series.Clear()

                    ' Sequenz lesen
                    Sequence = receiveBytes(2) * 2 ^ 24 + receiveBytes(3) * 2 ^ 16 + receiveBytes(4) * 2 ^ 8 + receiveBytes(5)
                    'Label_Sequence.Text = (100.0 * 65536 * 16 / Sequence).ToString("0.0")  'wenn eth_freq hier gesendet wird
                    Label_Sequence.Text = Sequence.ToString()

                    'Label_Sequence.Text = Sequence.ToString
                    ' Anzahl Targets
                    Targets = receiveBytes(6) * 256 + receiveBytes(7)
                    Label_TargetCnt.Text = Targets.ToString

                    For i = 0 To Targets - 1 Step 1
                        ' Distanz
                        Distance = receiveBytes(8 + i * 8 + 0) * 256 + receiveBytes(8 + i * 8 + 1)
                        ' Geschwindigkeit
                        Speed = receiveBytes(8 + i * 8 + 2) * 256 + receiveBytes(8 + i * 8 + 3)
                        ' Winkel
                        Angle = receiveBytes(8 + i * 8 + 4) * 256 + receiveBytes(8 + i * 8 + 5)
                        ' RCS
                        RCS = receiveBytes(8 + i * 8 + 6) * 256 + receiveBytes(8 + i * 8 + 7)
                        If (Speed > &H8000) Then
                            Speed -= &H10000
                        End If
                        If (Angle > &H8000) Then
                            Angle -= &H10000
                        End If

                        ' Show Plot
                        TargetDVSpec(i).Points.Clear()
                        TargetDVSpec(i).Points.AddXY(SpeedRange * Speed / 64, DistRange * Distance / 128)
                        TargetDVSpec(i).MarkerColor = PointColors(i)
                        Chart_TargetDV.Series.Add(TargetDVSpec(i))

                        TargetAngleSpec(i).Points.Clear()
                        TargetAngleSpec(i).Points.AddXY(Angle, DistRange * Distance / 128)
                        TargetAngleSpec(i).MarkerColor = PointColors(i)
                        Chart_Angle.Series.Add(TargetAngleSpec(i))
                    Next

                    ' One point is always transparent, because of grafik bug of chart
                    ' Bug was: When only points with x=0 then they will be showed at x=1
                    TargetDVSpec(Targets).Points.AddXY(6, 6)
                    TargetDVSpec(Targets).MarkerColor = Drawing.Color.Transparent
                    Chart_TargetDV.Series.Add(TargetDVSpec(Targets))

                    TargetAngleSpec(Targets).Points.AddXY(6, 6)
                    TargetAngleSpec(Targets).MarkerColor = Drawing.Color.Transparent
                    Chart_Angle.Series.Add(TargetAngleSpec(Targets))
                Catch ex As Exception
                    Return
                End Try
            ElseIf (Ident = &H1984) Then
                ' ******** Range FFT ***************
                Try
                    ' Alle Linien löschen
                    ' Chirp Nummer auslesen
                    ChirpNb = receiveBytes(2)
                    Label_RangeChirp.Text = ChirpNb.ToString
                    If ChirpNb = 0 Then
                        Chart_Range.Series.Clear()
                    End If

                    For i = 0 To 127 Step 1
                        'longVal = receiveBytes(3 + i * 4) * 2 ^ 24 + receiveBytes(3 + i * 4 + 1) * 2 ^ 16 + receiveBytes(3 + i * 4 + 2) * 2 ^ 8 + receiveBytes(3 + i * 4 + 3)
                        re = (receiveBytes(3 + i * 4) * 256) + receiveBytes(4 + i * 4)
                        im = (receiveBytes(5 + i * 4) * 256) + receiveBytes(6 + i * 4)

                        If re > &H7FFF Then
                            re -= &H10000
                        End If
                        If im > &H7FFF Then
                            im -= &H10000
                        End If

                        longVal = Sqrt(re * re + im * im)
                        If (longVal <= 0) Then
                            longVal = 1
                        End If

                        If ChirpNb = 0 Then
                            RangeSpec.Points.AddXY(i, longVal)
                        End If

                        ' Set Range Frame
                        color = fGetColor(longVal, RCSThreshold)
                        Range_Pic.SetPixel(ChirpNb * 2, i * 2, color)
                        Range_Pic.SetPixel(ChirpNb * 2, i * 2 + 1, color)
                        Range_Pic.SetPixel(ChirpNb * 2 + 1, i * 2, color)
                        Range_Pic.SetPixel(ChirpNb * 2 + 1, i * 2 + 1, color)
                    Next

                    If ChirpNb = 0 Then
                        RangeSpec.ChartType = SeriesChartType.Line
                        Chart_Range.Series.Add(RangeSpec)
                    End If
                    Application.DoEvents()

                    ' Show Plot
                    PictureBox_Range.Image = Range_Pic
                Catch ex As Exception
                    Return
                End Try
            ElseIf (Ident = &H1995) Then
                ' ******** Doppler FFT ***************
                Try
                    ' Sample Nummer auslesen
                    SampleNb = receiveBytes(2)
                    Label_DoppSampNb.Text = SampleNb.ToString

                    For i = 0 To 127 Step 1
                        'longVal = receiveBytes(3 + i * 4) * 2 ^ 24 + receiveBytes(3 + i * 4 + 1) * 2 ^ 16 + receiveBytes(3 + i * 4 + 2) * 2 ^ 8 + receiveBytes(3 + i * 4 + 3)
                        re = (receiveBytes(3 + i * 4) * 256) + receiveBytes(4 + i * 4)
                        im = (receiveBytes(5 + i * 4) * 256) + receiveBytes(6 + i * 4)

                        If re > &H7FFF Then
                            re -= &H10000
                        End If
                        If im > &H7FFF Then
                            im -= &H10000
                        End If

                        longVal = Sqrt(re * re + im * im)
                        If (longVal <= 0) Then
                            longVal = 1
                        End If

                        color = fGetColor(longVal, RCSThreshold)

                        Doppler_Pic.SetPixel(i * 2, SampleNb * 2, color)
                        Doppler_Pic.SetPixel(i * 2, SampleNb * 2 + 1, color)
                        Doppler_Pic.SetPixel(i * 2 + 1, SampleNb * 2, color)
                        Doppler_Pic.SetPixel(i * 2 + 1, SampleNb * 2 + 1, color)

                        ' Save max. Values
                        If ((longVal > DopplerSerieSpeed.Points.Item(i).YValues(0)) And
                            (SampleNb < 64)) Then
                            DopplerSerieSpeed.Points.Item(i).YValues(0) = longVal
                        End If
                        ' Save max. Values
                        If (longVal > DopplerSerieDistance.Points.Item(SampleNb).YValues(0)) Then
                            DopplerSerieDistance.Points.Item(SampleNb).YValues(0) = longVal
                        End If
                    Next

                    If SampleNb = 0 Then
                        Chart_DopplerSpeed.Refresh()
                        ' Rescale first time
                        If (Chart_DopplerSpeed.ChartAreas(0).AxisY.Maximum = 1.0) Then
                            Chart_DopplerSpeed.ChartAreas(0).RecalculateAxesScale()
                        End If
                        ' Reset values
                        For i = 0 To 127 Step 1
                            DopplerSerieSpeed.Points.Item(i).YValues(0) = 1
                        Next

                        ' Reset values
                        For i = 0 To 127 Step 1
                            DopplerSerieDistance.Points.Item(i).YValues(0) = 1
                        Next
                    End If
                    Application.DoEvents()
                    ' Show Plot
                    PictureBox_Doppler.Image = Doppler_Pic
                Catch ex As Exception
                    Return
                End Try
            ElseIf (Ident = &H2014) Then
                ' ******** ADC Values ***************
                ' Alle Linien löschen
                Try
                    Chart_ADC.Series.Clear()

                    ' Chirp Nummer auslesen
                    ChirpNb = receiveBytes(2)
                    Label_ADCChirpNb.Text = ChirpNb.ToString

                    For i = 0 To 127 Step 1
                        Value = ScaleRaw(receiveBytes(3 + i * 2) * 2 ^ 8 + receiveBytes(3 + i * 2 + 1))
                        ADCVals1.Points.AddXY(i, Value)
                    Next

                    For i = 0 To 127 Step 1
                        Value = ScaleRaw(receiveBytes(256 + 3 + i * 2) * 2 ^ 8 + receiveBytes(256 + 3 + i * 2 + 1))

                        ADCVals2.Points.AddXY(i, Value)
                    Next

                    ADCVals1.ChartType = SeriesChartType.Line
                    Chart_ADC.Series.Add(ADCVals1)
                    ADCVals2.ChartType = SeriesChartType.Line
                    Chart_ADC.Series.Add(ADCVals2)
                Catch ex As Exception
                    Return
                End Try
            End If
        End If

        ' Starte Backgroundworker
        BGWorker_Receive.RunWorkerAsync()

    End Sub

    Function fGetColor(Value As Long, Threshold As Long) As System.Drawing.Color
        Dim color As System.Drawing.Color

        If (Value > (1.5 * Threshold)) Then
            color = Drawing.Color.Red
        ElseIf (Value > (1.2 * Threshold)) Then
            color = Drawing.Color.OrangeRed
        ElseIf (Value > (1.1 * Threshold)) Then
            color = Drawing.Color.Orange
        ElseIf (Value > (1 * Threshold)) Then
            color = Drawing.Color.Goldenrod
        ElseIf (Value > (0.9 * Threshold)) Then
            color = Drawing.Color.Gold
        ElseIf (Value > (0.7 * Threshold)) Then
            color = Drawing.Color.Yellow
        ElseIf (Value > (0.5 * Threshold)) Then
            color = Drawing.Color.LightCyan
        ElseIf (Value > (0.3 * Threshold)) Then
            color = Drawing.Color.SkyBlue
        ElseIf (Value > (0.1 * Threshold)) Then
            color = Drawing.Color.RoyalBlue
        Else
            color = Drawing.Color.MediumBlue
        End If

        Return color
    End Function

    Private Sub Button_TelnetConnect_Click(sender As System.Object, e As System.EventArgs) Handles Button_TelnetConnect.Click
        ' Init new socket
        tcpClient = New System.Net.Sockets.TcpClient
        ' Starte asynchronen Connect
        connectResult = tcpClient.BeginConnect(TextBox_TelnetServerIP.Text, CInt(TextBox_TelnetSocketNb.Text), Nothing, Nothing)
        ' Start Telnet timer
        TelnetTimer.Start()
    End Sub

    Private Sub fPoll_Telnet(ByVal e As Object, ByVal sender As EventArgs)
        Dim readBytes(1500) As Byte
        Dim cmd As eCmd
        Dim cmdType As eCmdType
        Dim value As String = ""
        Dim intVal, len As Integer

        If (tcpClient.Connected = True) Then
            ' Connected
            Button_TelnetConnect.Enabled = False
            ' Wait until init ends
            If (telnetInitCmd = eCmd.No) Then
                Button_TelnetDisconnect.Enabled = True
                Button_TargetThres.Enabled = True
                Button_TargetGap.Enabled = True
                Button_UDPPort.Enabled = True
                Button_UDPServerIP.Enabled = True
            End If

            ' Data received
            len = tcpClient.Available
            If (len > 0) Then
                ' Read bytes
                networkStream = tcpClient.GetStream()
                networkStream.Read(readBytes, 0, len)
                ' Decode command
                Telnet_DecodeCommand(readBytes, cmd, cmdType, value, len)

                If value.Length > 1 Then
                    If (value(value.Length - 2) = "\r") Or (value(value.Length - 2) = "\n") Then
                        value = value.Substring(0, value.Length - 2)
                    End If
                End If

                If (cmdType = eCmdType.Read) Then
                    ' Check command
                    Select Case (cmd)
                        Case eCmd.PcIP
                            ' UDP Server IP
                            TextBox_UDPServerIP.Text = value
                            ' Next command
                            telnetInitCmd = eCmd.UDP_Port
                            telnetInitDataTyp = eDataType.Dec
                        Case eCmd.UDP_Port
                            ' UDP Port
                            TextBox_UDPSocket.Text = value
                            ' Init UDP
                            receivingUdpClient = New System.Net.Sockets.UdpClient(CInt(TextBox_UDPSocket.Text))

                            'you have to initiate the udp communication by sending any byte you want, here "0"
                            receivingUdpClient.Connect(TextBox_TelnetServerIP.Text, 49152)
                            Dim sendbytes() As Byte = System.Text.Encoding.ASCII.GetBytes("0")
                            receivingUdpClient.Send(sendbytes, sendbytes.Length)

                            BGWorker_Receive.RunWorkerAsync()
                            ' Next command
                            telnetInitCmd = eCmd.DataOutMode
                            telnetInitDataTyp = eDataType.Dec
                        Case eCmd.DataOutMode
                            ' Data output mode
                            If (CInt(value) = eDataOutMode.TargetList) Then
                                TabControl.SelectedIndex = TabControl.TabPages.IndexOf(Tab_TargetList)
                            ElseIf (CInt(value) = eDataOutMode.RangeFFT) Then
                                TabControl.SelectedIndex = TabControl.TabPages.IndexOf(Tab_RangeFFT)
                            ElseIf (CInt(value) = eDataOutMode.DopplerFFT) Then
                                TabControl.SelectedIndex = TabControl.TabPages.IndexOf(Tab_DopplerFFT)
                            ElseIf (CInt(value) = eDataOutMode.ADCValues) Then
                                TabControl.SelectedIndex = TabControl.TabPages.IndexOf(Tab_ADCValues)
                            End If
                            ' Next command
                            telnetInitCmd = eCmd.RCSDetectionThreshold
                            telnetInitDataTyp = eDataType.Hex
                        Case eCmd.RCSDetectionThreshold
                            ' RCS detection threshold
                            value = Convert.ToInt32(value, 10).ToString
                            TextBox_TargetThres.Text = value
                            ' Save threshold
                            RCSThreshold = CInt(value)
                            SetThresholdLine(RCSThreshold)
                            ' Next command
                            telnetInitCmd = eCmd.TargetGap
                            telnetInitDataTyp = eDataType.Dec
                        Case eCmd.TargetGap
                            ' Kestrel gain
                            TextBox_TargetGap.Text = value
                            ' Next command
                            telnetInitCmd = eCmd.SWVersion
                            telnetInitDataTyp = eDataType.Dec
                        Case eCmd.SWVersion
                            ' Software Verstion
                            TextBox_SWVersion.Text = Format(value / 100, "00.00")
                            ' Next command
                            telnetInitCmd = eCmd.FilterStatics
                            telnetInitDataTyp = eDataType.Dec
                        Case eCmd.FilterStatics
                            ' Filter static objects
                            ComboBox_TargetFilter.SelectedIndex = value
                            ' Next command
                            telnetInitCmd = eCmd.RCSComp
                            telnetInitDataTyp = eDataType.Dec
                        Case eCmd.RCSComp
                            ' RCS compensation
                            ComboBox_RCSComp.SelectedIndex = value
                            ' Next command
                            telnetInitCmd = eCmd.RxAntenna
                            telnetInitDataTyp = eDataType.Dec
                        Case eCmd.RxAntenna
                            ' Rx Antenna
                            ComboBox_RxAntenna.SelectedIndex = value
                            ' Next command
                            telnetInitCmd = eCmd.RxGain
                            telnetInitDataTyp = eDataType.Dec
                        Case eCmd.RxGain
                            ' Rx Gain
                            ComboBox_RxGain.SelectedIndex = value
                            ' Next command
                            telnetInitCmd = eCmd.No
                            telnetInitDataTyp = eDataType.Dec
                    End Select
                ElseIf (cmdType = eCmdType.Err) Then
                    ' Show error
                    RichTextBox_TelnetErrors.Text = RichTextBox_TelnetErrors.Text & Encoding.ASCII.GetString(readBytes) & vbCrLf
                ElseIf (cmdType = eCmdType.Write) Then
                    If (cmd = eCmd.SPICommand) Then
                        intVal = Convert.ToInt32(Trim(value), 16)
                    End If
                End If
            End If

            ' Send next command
            If ((bWaitInitCmd = False) And (telnetInitCmd <> eCmd.No)) Then
                ' Not waiting for a command -> send
                Telnet_SendCommand(telnetInitCmd, eCmdType.Read, "", telnetInitDataTyp)
                ' Wait for answer
                bWaitInitCmd = True
            End If
        Else
            ' No connection
            Button_TelnetConnect.Enabled = True
            Button_TelnetDisconnect.Enabled = False
            Button_TargetThres.Enabled = False
            Button_TargetGap.Enabled = False
            Button_UDPPort.Enabled = False
            Button_UDPServerIP.Enabled = False

            ' At new connection -> new initialization
            telnetInitCmd = eCmd.PcIP
            telnetInitDataTyp = eDataType.IP
        End If
    End Sub

    Private Sub Button_TelnetDisconnect_Click(sender As System.Object, e As System.EventArgs) Handles Button_TelnetDisconnect.Click
        ' Stop telnet timer
        TelnetTimer.Stop()

        ' Close socket
        tcpClient.Close()
        tcpClient = Nothing

        ' Disable buttons
        Button_TelnetConnect.Enabled = True
        Button_TelnetDisconnect.Enabled = False
        Button_TargetThres.Enabled = False
        Button_TargetGap.Enabled = False
    End Sub

    Private Sub RadioButton_Linear_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton_Linear.CheckedChanged
        If (Chart_Range.ChartAreas.Count > 0) Then
            Chart_Range.ChartAreas(0).AxisY.IsLogarithmic = False
        End If
        If (Chart_DopplerSpeed.ChartAreas.Count > 0) Then
            Chart_DopplerSpeed.ChartAreas(0).AxisY.IsLogarithmic = False
        End If
    End Sub

    Private Sub RadioButton_Log_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton_Log.CheckedChanged
        If (Chart_Range.ChartAreas.Count > 0) Then
            Chart_Range.ChartAreas(0).AxisY.IsLogarithmic = True
        End If
        If (Chart_DopplerSpeed.ChartAreas.Count > 0) Then
            Chart_DopplerSpeed.ChartAreas(0).AxisY.IsLogarithmic = True
        End If
    End Sub

    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles TabControl.SelectedIndexChanged
        If (IsNothing(tcpClient) = False) Then
            If (tcpClient.Connected = True) Then
                If (TabControl.SelectedIndex = TabControl.TabPages.IndexOf(Tab_TargetList)) Then
                    ' Send command
                    Telnet_SendCommand(eCmd.DataOutMode, eCmdType.Write, CInt(eDataOutMode.TargetList).ToString, eDataType.Dec)
                ElseIf (TabControl.SelectedIndex = TabControl.TabPages.IndexOf(Tab_RangeFFT)) Then
                    ' Send command
                    Telnet_SendCommand(eCmd.DataOutMode, eCmdType.Write, CInt(eDataOutMode.RangeFFT).ToString, eDataType.Dec)
                ElseIf (TabControl.SelectedIndex = TabControl.TabPages.IndexOf(Tab_DopplerFFT)) Then
                    ' Send command
                    Telnet_SendCommand(eCmd.DataOutMode, eCmdType.Write, CInt(eDataOutMode.DopplerFFT).ToString, eDataType.Dec)
                ElseIf (TabControl.SelectedIndex = TabControl.TabPages.IndexOf(Tab_ADCValues)) Then
                    ' Send command
                    Telnet_SendCommand(eCmd.DataOutMode, eCmdType.Write, CInt(eDataOutMode.ADCValues).ToString, eDataType.Dec)
                End If
            End If
        End If
    End Sub

    Private Sub Button_TargetThres_Click(sender As System.Object, e As System.EventArgs) Handles Button_TargetThres.Click
        Dim value As String

        ' Save threshold
        RCSThreshold = CInt(TextBox_TargetThres.Text)
        SetThresholdLine(RCSThreshold)

        ' Send value as Hex
        value = RCSThreshold.ToString("")

        ' Send command
        Telnet_SendCommand(eCmd.RCSDetectionThreshold, eCmdType.Write, value, eDataType.Dec)
    End Sub

    Private Sub Button_RecalculateAxis_Click(sender As System.Object, e As System.EventArgs) Handles Button_RecalculateAxis.Click

        If (TabControl.SelectedIndex = TabControl.TabPages.IndexOf(Tab_TargetList)) Then
            ' Target List
            Chart_TargetDV.ChartAreas(0).RecalculateAxesScale()
            Chart_Angle.ChartAreas(0).RecalculateAxesScale()
        ElseIf (TabControl.SelectedIndex = TabControl.TabPages.IndexOf(Tab_RangeFFT)) Then
            ' Range FFT
            Chart_Range.ChartAreas(0).RecalculateAxesScale()
        ElseIf (TabControl.SelectedIndex = TabControl.TabPages.IndexOf(Tab_DopplerFFT)) Then
            ' Doppler FFT
            Chart_DopplerSpeed.ChartAreas(0).RecalculateAxesScale()
        ElseIf (TabControl.SelectedIndex = TabControl.TabPages.IndexOf(Tab_ADCValues)) Then
            ' ADC
            Chart_ADC.ChartAreas(0).RecalculateAxesScale()
        End If
    End Sub

    Private Sub Button_TargetGap_Click(sender As System.Object, e As System.EventArgs) Handles Button_TargetGap.Click
        Dim value As String
        ' Send command
        value = TextBox_TargetGap.Text
        Telnet_SendCommand(eCmd.TargetGap, eCmdType.Write, value, eDataType.Dec)
    End Sub

    Private Sub Telnet_SendCommand(ByVal Cmd As eCmd, ByVal CmdType As eCmdType, ByVal value As String, ByVal DataType As eDataType)
        Dim SendString, sDataType As String
        Dim writeBytes As Byte()

        If (DataType = eDataType.Dec) Then
            sDataType = "D"
        ElseIf (DataType = eDataType.Hex) Then
            sDataType = "H"
        Else
            sDataType = "I"
        End If

        If (CmdType = eCmdType.Read) Then
            SendString = String.Format("{0:00}", CInt(Cmd)) & "R" & sDataType & vbCrLf
        Else
            SendString = String.Format("{0:00}", CInt(Cmd)) & "W" & sDataType & " " & value & vbCrLf
        End If

        writeBytes = Encoding.Default.GetBytes(SendString)

        ' Send Bytes
        networkStream = tcpClient.GetStream
        networkStream.Write(writeBytes, 0, writeBytes.Length)
    End Sub

    Private Sub Telnet_DecodeCommand(ByVal recBytes As Byte(), ByRef Cmd As eCmd, ByRef CmdType As eCmdType, ByRef value As String, ByVal len As Integer)

        ' Decode command
        Cmd = CInt(Encoding.ASCII.GetString(recBytes, 0, 2))
        ' Save command type
        If (recBytes(2) = AscW("R"c)) Then
            CmdType = eCmdType.Read
        ElseIf (recBytes(2) = AscW("E"c)) Then
            CmdType = eCmdType.Err
        Else
            CmdType = eCmdType.Write
        End If

        ' Save value as string
        If (len > 7) Then
            '    pos = InStr(Encoding.ASCII.GetString(recBytes, 0, len), vbCrLf)
            '   value = Encoding.ASCII.GetString(recBytes, 5, pos - 6)
            value = Encoding.ASCII.GetString(recBytes, 5, len - 7)
            value = Trim(value)
        Else
            value = "0"
        End If

        ' Ready for next command
        bWaitInitCmd = False
    End Sub

    Private Sub Button_UDPPort_Click(sender As System.Object, e As System.EventArgs) Handles Button_UDPPort.Click
        ' Send command
        Telnet_SendCommand(eCmd.UDP_Port, eCmdType.Write, TextBox_UDPSocket.Text, eDataType.Dec)

        ' Init UDP
        receivingUdpClient.Close()

        receivingUdpClient = New System.Net.Sockets.UdpClient(CInt(TextBox_UDPSocket.Text))
        TextBox_UDPClientIP.Text = ""
    End Sub
    Private Sub Button_UDPServerIP_Click(sender As System.Object, e As System.EventArgs) Handles Button_UDPServerIP.Click
        ' Send command
        Telnet_SendCommand(eCmd.PcIP, eCmdType.Write, TextBox_UDPServerIP.Text, eDataType.IP)
        TextBox_UDPClientIP.Text = ""
    End Sub

    Private Sub ResetDistanceRange(maxVal As Double)
        Chart_TargetDV.ChartAreas(0).AxisY.Interval = maxVal / 8
        Chart_TargetDV.ChartAreas(0).AxisY.MajorGrid.Interval = maxVal / 8
        Chart_TargetDV.ChartAreas(0).AxisY.MajorTickMark.Interval = maxVal / 8
        Chart_TargetDV.ChartAreas(0).AxisY.Minimum = 0
        Chart_TargetDV.ChartAreas(0).AxisY.Maximum = maxVal

        Chart_Angle.ChartAreas(0).AxisY.Interval = maxVal / 8
        Chart_Angle.ChartAreas(0).AxisY.MajorGrid.Interval = maxVal / 8
        Chart_Angle.ChartAreas(0).AxisY.MajorTickMark.Interval = maxVal / 8
        Chart_Angle.ChartAreas(0).AxisY.Minimum = 0
        Chart_Angle.ChartAreas(0).AxisY.Maximum = maxVal
    End Sub

    Private Sub ResetSpeedRange(maxVal As Double)
        Chart_TargetDV.ChartAreas(0).AxisX.Interval = maxVal / 4
        Chart_TargetDV.ChartAreas(0).AxisX.MajorGrid.Interval = maxVal / 4
        Chart_TargetDV.ChartAreas(0).AxisX.MajorTickMark.Interval = maxVal / 4
        Chart_TargetDV.ChartAreas(0).AxisX.Minimum = -maxVal
        Chart_TargetDV.ChartAreas(0).AxisX.Maximum = maxVal
    End Sub

    Private Sub ComboBox_RxAntenna_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox_RxAntenna.SelectedIndexChanged
        Dim RxValue As Integer

        If (telnetInitCmd = eCmd.No) Then
            RxValue = ComboBox_RxAntenna.SelectedIndex
            ' Send Rx Antenna
            Telnet_SendCommand(eCmd.RxAntenna, eCmdType.Write, RxValue, eDataType.Dec)
        End If
        Label_ADCRxAnt.Text = ComboBox_RxAntenna.SelectedItem.ToString
        Label_DoppRxAnt.Text = ComboBox_RxAntenna.SelectedItem.ToString
        Label_RangeRxAnt.Text = ComboBox_RxAntenna.SelectedItem.ToString
    End Sub

    Private Sub ComboBoxRxGain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_RxGain.SelectedIndexChanged
        If (telnetInitCmd = eCmd.No) Then
            ' Send
            Telnet_SendCommand(eCmd.RxGain, eCmdType.Write, ComboBox_RxGain.SelectedIndex, eDataType.Dec)
        End If

    End Sub

    Private Sub ComboBox_TargetFilter_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox_TargetFilter.SelectedIndexChanged
        If (telnetInitCmd = eCmd.No) Then
            ' Send
            Telnet_SendCommand(eCmd.FilterStatics, eCmdType.Write, ComboBox_TargetFilter.SelectedIndex, eDataType.Dec)
        End If
    End Sub

    Private Sub ButtonZoomTarget_Click(sender As Object, e As EventArgs) Handles ButtonZoomTarget.Click
        If (ButtonZoomTarget.Text = "Zoom 10m") Then
            ResetDistanceRange(10.0R)
            ButtonZoomTarget.Text = "Zoom full"
        Else
            ResetDistanceRange(DistRange)
            ButtonZoomTarget.Text = "Zoom 10m"
        End If

    End Sub

    Private Sub ComboBox_RCSComp_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox_RCSComp.SelectedIndexChanged
        If (telnetInitCmd = eCmd.No) Then
            ' Send
            Telnet_SendCommand(eCmd.RCSComp, eCmdType.Write, ComboBox_RCSComp.SelectedIndex, eDataType.Dec)
        End If
    End Sub

    Private Sub SetThresholdLine(ByVal Threshold As Integer)
        thresholdLine1.AnchorY = Threshold
        thresholdLine2.AnchorY = Threshold
    End Sub

    Private Function ScaleRaw(ByVal amp As Integer) As Integer
        'Return (amp)
        If (amp >= &H4000) Then
            amp = amp - &H4000
        End If
        Return (amp)
    End Function
End Class
