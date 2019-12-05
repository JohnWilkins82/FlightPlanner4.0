Imports FSUIPC

Public Class FsInterface
    Private Property m_connected As Boolean

    Dim m_altmeter As Offset(Of Int64) = New FSUIPC.Offset(Of Int64)(&H570)
    Dim fuelWeight As Offset(Of Int32) = New FSUIPC.Offset(Of Int32)(&H126C)
    Dim payload As Offset(Of Double) = New FSUIPC.Offset(Of Double)(&H30C0)
    Dim fweight As Offset(Of Int32) = New FSUIPC.Offset(Of Int32)(&HAF4)
    Dim eng1FuelBurn As Offset(Of Double) = New FSUIPC.Offset(Of Double)(&H918)
    Dim eng3FuelBurn As Offset(Of Double) = New FSUIPC.Offset(Of Double)(&HA48)
    Dim eng4FuelBurn As Offset(Of Double) = New FSUIPC.Offset(Of Double)(&HAE0)
    Dim eng2FuelBurn As Offset(Of Double) = New FSUIPC.Offset(Of Double)(&H9B0)

    'airspeed
    Dim groundSpeed As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H2B4)
    Dim mach As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H11C6)


    'latlon
    Dim acLat As Offset(Of Long) = New Offset(Of Long)(&H560)
    Dim acLon As Offset(Of Long) = New Offset(Of Long)(&H568)

    'autothrottle
    Private m_machVal As Offset(Of Int32) = New Offset(Of Int32)(&H7E8)
    Private m_apIsaVal As Offset(Of Int32) = New Offset(Of Int32)(&H7E2)
    Private m_barberpole As Offset(Of Int32) = New Offset(Of Int32)(&H2C4)
    Private m_alt As Offset(Of Integer) = New Offset(Of Integer)(&H3324)
    Private m_ias As Offset(Of Integer) = New Offset(Of Integer)(&H2BC)

    Private m_ThrottleOne As Offset(Of Integer) = New Offset(Of Integer)(&H88C)
    Private m_ThrottleTwo As Offset(Of Integer) = New Offset(Of Integer)(&H924)
    Private m_ThrottleThree As Offset(Of Integer) = New Offset(Of Integer)(&H9BC)
    Private m_ThrottleFour As Offset(Of Integer) = New Offset(Of Integer)(&HA54)

    Dim alttemp As Int32 = 0
    Dim machRound As Decimal = 0.0
    Dim tempias As Integer = 0

    'pause
    Dim pauseSim As Offset(Of UInt16) = New Offset(Of UInt16)(&H262)

    Public Property connected As Boolean
        Get
            Return m_connected
        End Get
        Set(value As Boolean)
            m_connected = value
        End Set
    End Property

    Public Sub connect()
        Try

            FSUIPCConnection.Open()
            m_connected = True


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            m_connected = False
        End Try


    End Sub

    Public Property machVal As Int32
        Get

        End Get
        Set(value As Int32)
            m_machVal.Value = value
        End Set
    End Property
    Public Property Ias As Integer
        Get
            FSUIPCConnection.Process()
            Return (m_ias.Value / 128)
        End Get
        Set(value As Integer)

        End Set
    End Property
    Public Property barberpole As Int32
        Get
            Return (m_barberpole.Value / 128)
        End Get
        Set(value As Int32)

        End Set
    End Property

    Public Property Altmeter As Offset(Of Long)
        Get
            Return m_altmeter 
        End Get
        Set(value As Offset(Of Long))
            m_altmeter = value
        End Set
    End Property

    Public Sub pause(ByVal p As Boolean)
        pauseSim.Value = p
        FSUIPCConnection.Process()



    End Sub
    Public Function getAlt() As Integer
        Dim alt As Integer
        alt = m_altmeter.Value * 3.28084 / 4294967296
        Return alt
    End Function

    Public Function getMach() As Decimal
        FSUIPCConnection.Process()
        machRound = mach.Value / 65536
        Return machRound.Round(machRound, 2)

    End Function
    Public Function updateAc(ByVal a As aircraft) As aircraft
        Try
            FSUIPCConnection.Process()
            a.fuelOnBoard = fuelWeight.Value
            a.payload = payload.Value

            a.currGs = groundSpeed.Value
            a.currMach = mach.Value

            a.CurrAlt = getAlt()
            'fuelburn
            a.eng1FuelBurn = eng1FuelBurn.Value / 128
            a.eng2Fuelburn = eng2FuelBurn.Value / 128
            a.eng3FuelBurn = eng3FuelBurn.Value / 128
            a.eng4FuelBurn = eng4FuelBurn.Value / 128

            'fueltanks
            'For Each t As Tank In a.tanks
            '    If t.getName = "main L" Then
            '        t.setPercent(leftMainLevel.Value)
            '        t.setcap(leftMainCap.Value * cfw)
            '        t.findLevel(t.getCap, t.getLevel)
            '    ElseIf t.getName = "Left Aux" Then
            '        t.setPercent(LeftAuxLevel.Value)
            '        t.setcap(LeftAuxCap.Value * 6.69)


            '    End If



            'Next


        Catch ex As Exception
            m_connected = False
            FSUIPCConnection.Close()
            m_connected = False
        End Try
        Return a
    End Function

    Public Function updatePos(ByVal i As FsLatLonPoint) As FsLatLonPoint
        Try
            FSUIPCConnection.Process()
            Dim lat As FsLatitude = New FsLatitude(acLat.Value)
            Dim lon As FsLongitude = New FsLongitude(acLon.Value)

            Dim c As FsLatLonPoint = New FsLatLonPoint(lat, lon)

            'c.lat = lat.Value * 90D / (10001750D * 65536D * 65536D)
            'c.lon = lon.Value * 360D / (65536D * 65536D * 65536D * 65536D)
            Return c
        Catch ex As Exception
            FSUIPCConnection.Close()
            MessageBox.Show(ex.Message)

            m_connected = False
        End Try

    End Function

    Public Sub setMach(v As Decimal)
        'getBarberPole()
        'If defATS = True Then
        m_machVal.Value = (v * 65536)
        FSUIPCConnection.Process()

        'Try
        '    FSUIPCConnection.Process()
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)

        'End Try
        'Else

        'End If





    End Sub

    Public Sub setIsa(v As Int32, defATS As Boolean)
        If defATS = True Then
            m_apIsaVal.Value = v

        End If

        FSUIPCConnection.Process()

        'Try
        '    FSUIPCConnection.Process()
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try
    End Sub

    Public Sub SetTHrottle(ByVal value As Integer)
        ''value = value * 100 / 16384
        m_ThrottleOne.Value = value
        m_ThrottleTwo.Value = value
        m_ThrottleThree.Value = value
        m_ThrottleFour.Value = value
    End Sub
    Public Function readThrottle() As Integer
        Dim throttlePos As Integer
        throttlePos = m_ThrottleOne.Value
        Return throttlePos

    End Function

    Public Sub disconect()
        FSUIPCConnection.Close()
        m_connected = False
    End Sub
End Class
