Public Class perf

    Private m_AcType As String
    Private m_Name As String
    Private m_FuelFlow As Integer
    Private m_Speed As Integer
    Public Sub New()

    End Sub

    Public Sub New(ByVal ac As String, ByVal n As String, ByVal f As Integer, ByVal s As Integer)
        m_AcType = ac
        m_Name = n
        m_FuelFlow = f
        m_Speed = s


    End Sub

    Public Property AcType As String
        Get
            Return m_AcType
        End Get
        Set(value As String)
            m_AcType = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property

    Public Property FuelFlow As Integer
        Get
            Return m_FuelFlow
        End Get
        Set(value As Integer)
            m_FuelFlow = value
        End Set
    End Property

    Public Property Speed As Integer
        Get
            Return m_Speed
        End Get
        Set(value As Integer)
            m_Speed = value
        End Set
    End Property
End Class
