Public Class runway
    Private m_Airport As String
    Private m_heading As Integer
    Private m_lat As Double
    Private m_lon As Double
    Private m_alt As Integer
    Private m_magHeading As Integer
    Private m_lenght As Integer
    Private m_ilsFreq

    Public Sub New()

    End Sub

    Public Sub New(ByVal airport As String, ByVal heading As Integer, ByVal lat As Double, ByVal lon As Double, ByVal alt As Integer, ByVal magheading As Integer, ByVal lenght As Integer, ByVal ilsFreq As Double)
        Me.m_Airport = airport
        Me.m_heading = heading
        Me.m_lat = lat
        Me.m_lon = lon
        Me.m_alt = alt
        Me.m_magHeading = magheading
        Me.m_lenght = lenght
        Me.m_ilsFreq = ilsFreq


    End Sub
    Public Sub setAirport(ByVal a As String)
        m_Airport = a
    End Sub

    Public Function getAirport() As String
        Return m_Airport.ToString
    End Function

    Public Sub setHeading(ByVal h As Integer)
        m_heading = h
    End Sub

    Public Function getHeading() As Integer
        Return m_heading
    End Function

    Public Sub setLat(ByVal la As Double)
        m_lat = la
    End Sub

    Public Function getLat() As Double
        Return m_lat
    End Function

    Public Sub setLon(ByVal ln As Double)
        m_lon = ln
    End Sub

    Public Function getLon() As Double
        Return m_lon
    End Function

    Public Sub setAlt(ByVal a As Integer)
        m_alt = a
    End Sub

    Public Function getAlt() As Integer
        Return m_alt
    End Function

    Public Sub setMagHeading(ByVal mh As Integer)
        m_magHeading = mh
    End Sub

    Public Function getMagHeading() As Integer
        Return m_magHeading
    End Function

    Public Sub setLength(ByVal l As Integer)
        m_lenght = l
    End Sub

    Public Function getLenght() As Integer
        Return m_lenght
    End Function

    Public Sub setIls(ByVal i As Double)
        m_ilsFreq = i
    End Sub
    Public Function getIls() As Double
        Return m_ilsFreq
    End Function
End Class
