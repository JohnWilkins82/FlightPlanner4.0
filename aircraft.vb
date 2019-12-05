Public Class aircraft
    Private m_fuelOnBoard As Double
    Private m_payload As Double
    Private m_MGW As Integer
    Private m_zeroFuelWeight As Double
    'Private m_tanks As List(Of Tank) = New List(Of Tank)
    Private m_totalCap As Integer
    Private m_curGs As Integer
    Private m_curMach As Integer
    Private m_currAlt As Double

    Private m_type As String
    Private m_cruzAlt As Integer
    Private m_eng1FuelBurn As Double
    Private m_eng2FuelBurn As Double
    Private m_eng3FuelBurn As Double
    Private m_eng4FuelBurn As Double


    Public Sub New()

    End Sub
    Public Property fuelOnBoard As Double
        Get
            Return m_fuelOnBoard
        End Get
        Set(value As Double)
            m_fuelOnBoard = value
        End Set
    End Property

    Public Property payload As Double
        Get
            Return Math.Round(m_payload)
        End Get
        Set(value As Double)
            m_payload = value
        End Set
    End Property

    Public Property zeroFuelWeight As Double
        Get
            m_zeroFuelWeight = m_payload - m_fuelOnBoard
            'm_zeroFuelWeight = ps.AircraftZeroFuelWeightLbs
            Return m_zeroFuelWeight
        End Get
        Set(value As Double)

        End Set
    End Property

    Public Property MGW As Integer
        Get
            Return m_MGW
        End Get
        Set(value As Integer)
            m_MGW = value
        End Set
    End Property

    'Public Sub addTank(ByVal n As Tank)
    '    m_tanks.Add(n)
    'End Sub

    'Public Property tanks As List(Of Tank)
    '    Get
    '        Return m_tanks
    '    End Get
    '    Set(value As List(Of Tank))
    '        m_tanks = value
    '    End Set
    'End Property
    Public Property totalFuelCap As Integer
        Get
            Return m_totalCap
        End Get
        Set(value As Integer)
            m_totalCap = value
        End Set
    End Property



    Public Property currGs As Integer
        Get
            Return m_curGs
        End Get
        Set(value As Integer)
            m_curGs = value
        End Set
    End Property

    Public Property currMach As Integer
        Get
            Return m_curMach
        End Get
        Set(value As Integer)
            m_curMach = value
        End Set
    End Property

    Public Property Type As String
        Get
            Return m_type
        End Get
        Set(value As String)
            m_type = value
        End Set
    End Property

    Public Property CruzAlt As Integer
        Get
            Return m_cruzAlt
        End Get
        Set(value As Integer)
            m_cruzAlt = value
        End Set
    End Property
    Public Property eng1FuelBurn As Double
        Get
            Return m_eng1FuelBurn
        End Get
        Set(value As Double)
            m_eng1FuelBurn = value
        End Set
    End Property

    Public Property eng2Fuelburn As Double
        Get
            Return m_eng2FuelBurn
        End Get
        Set(value As Double)
            m_eng2FuelBurn = value
        End Set
    End Property

    Public Property eng3FuelBurn As Double
        Get
            Return m_eng3FuelBurn
        End Get
        Set(value As Double)
            m_eng3FuelBurn = value
        End Set
    End Property

    Public Property eng4FuelBurn As Double
        Get
            Return m_eng4FuelBurn
        End Get
        Set(value As Double)
            m_eng4FuelBurn = value
        End Set
    End Property

    Public Property CurrAlt As Double
        Get
            Return m_currAlt
        End Get
        Set(value As Double)
            m_currAlt = value
        End Set
    End Property

    Public Function GetTotalFuelBurn() As Double
        Dim totalfuelburn As Double

        totalfuelburn = eng1FuelBurn + eng2Fuelburn + eng3FuelBurn + eng4FuelBurn
        totalfuelburn = totalfuelburn * 128

        Return totalfuelburn
    End Function


End Class
