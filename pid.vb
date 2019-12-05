
Imports System.Math

Public Class PidControler

    Private m_kp As Double = New Double
    Private m_ki As Double = New Double
    Private m_kd As Double = New Double
    Private m_setPoint As Double = New Double
    Private m_err As Double = New Double
    Private m_prvErr As Double = New Double
    Private m_prvVarince As Double = New Double
    Private m_output As Double = New Double
    Private m_prvVal As Double = New Double
    Private m_deriv As Double = New Double

    Private windup As Boolean = False

    Dim derivative As Double = New Double
    Dim integral As Double = New Double




    Public Property SetPoint As Double
        Get
            Return m_setPoint
        End Get
        Set(value As Double)
            m_setPoint = value
        End Set
    End Property

    Public Property Err As Double
        Get
            Return m_err
        End Get
        Set(value As Double)
            m_err = value
        End Set
    End Property

    Public Property PrvErr As Double
        Get
            Return m_prvErr
        End Get
        Set(value As Double)
            m_prvErr = value
        End Set
    End Property

    Public Property PrvVarince As Double
        Get
            Return m_prvVarince
        End Get
        Set(value As Double)
            m_prvVarince = value
        End Set
    End Property

    Public Property Output As Double
        Get
            Return m_output
        End Get
        Set(value As Double)
            m_output = value
        End Set
    End Property

    Public Property PrvVal As Double
        Get
            Return m_prvVal
        End Get
        Set(value As Double)
            m_prvVal = value
        End Set
    End Property

    Public Property Deriv As Double
        Get
            Return m_deriv
        End Get
        Set(value As Double)
            m_deriv = value
        End Set
    End Property

    Public Property Kp As Double
        Get
            Return m_kp
        End Get
        Set(value As Double)
            m_kp = value
        End Set
    End Property

    Public Property Ki As Double
        Get
            Return m_ki
        End Get
        Set(value As Double)
            m_ki = value
        End Set
    End Property

    Public Property Kd As Double
        Get
            Return m_kd
        End Get
        Set(value As Double)
            m_kd = value
        End Set
    End Property

    Public Sub PidControler()

    End Sub

    Public Function Run(ByVal pv As Double, ByVal s As Double, ByVal wu As Boolean)
        SetPoint = s
        PrvVal = pv
        windup = wu
        Err = SetPoint - PrvVal
        If windup = True Then
            integral = integral
        Else
            integral = integral + (Err * 17)
        End If

        derivative = (Err - PrvErr) / 17
        Output = (Kp * Err) + (Ki * integral) + (Kd * derivative)
        PrvErr = Err
        ''Round(Output)

        Return Output
    End Function
End Class
