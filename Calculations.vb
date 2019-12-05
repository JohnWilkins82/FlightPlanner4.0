Imports FSUIPC
Public Class Calculations

    Public Function timeToTarget(ByVal distance As Integer, ByVal spd As Integer) As TimeSpan

        If spd = 0 Then
            spd = 1
        End If
        Dim ttt As TimeSpan = TimeSpan.FromMinutes((distance / spd * 60))
        Return ttt
    End Function

    Public Function FuelReq(ByVal distance As Integer, ByVal fuelFlow As Integer, ByVal speed As Integer, ByVal Altdest As Integer) As Integer
        Dim fuelEnroute As Double = 0

        Dim totalFuel As Double = 0
        Dim resvr As Integer = FuelResvr(fuelFlow, speed, Altdest)

        Dim ttt As TimeSpan = timeToTarget(distance, speed)
        fuelEnroute = fuelFlow * ttt.TotalMinutes / 60

        Return CInt(fuelEnroute + resvr)
    End Function

    Public Function FuelResvr(ByVal fuelflow As Integer, ByVal speed As Integer, ByVal altDest As Integer) As Integer
        Dim resvrTotal As Integer
        Dim onehour As Integer = fuelflow
        Dim Alternate As Integer

        Alternate = CInt(fuelflow * timeToTarget(altDest, speed).Minutes / 60)

        resvrTotal = onehour + Alternate

        Return resvrTotal
    End Function
    ''fob = fuel on board fb = fuel burn
    Public Function Endurace(ByVal fob, ByVal fb) As TimeSpan

        If fb = 0 Then
            fb = 1
        End If
        Dim endur As Double = fob / fb
        If endur > 1440 Then
            endur = 1440
        Else

        End If

        Dim endurTime As TimeSpan = TimeSpan.FromHours(endur)
        Return endurTime
    End Function

    Public Function Range(ByVal e As TimeSpan, ByVal gs As Integer) As Integer
        Dim endure As Integer = 0
        If e.TotalMinutes > 1440 Then
            endure = 1440
        Else
            endure = e.TotalMinutes
        End If


        Dim r As Integer
        r = gs * endure \ 60
        Return r
    End Function

    'Finds Airport from Runway.csv and returnes a list of Runways
    Public Function FindRunways(ByVal airport As String, ByVal runwayList As List(Of runway))
        Dim searchedlist As List(Of runway) = New List(Of runway)

        For Each r In runwayList
            If r.getAirport.Equals(airport) Then
                searchedlist.Add(r)

            End If
        Next
        Return searchedlist
    End Function

    Public Function getLocation(ByVal dest As List(Of runway)) As FsLatLonPoint
        Dim destlat As FsLatitude = New FsLatitude(dest.Item(0).getLat)
        Dim destlon As FsLongitude = New FsLongitude(dest.Item(0).getLon)
        Dim destlatlon As FsLatLonPoint = New FsLatLonPoint(destlat, destlon)
        Return destlatlon
    End Function
    ''calc distance to go in miles t is target lat lon, c is current lat lon
    Public Function milesToGoCalc(ByVal t As FsLatLonPoint, ByVal c As FsLatLonPoint) As Double
        Dim mtg As Double = 0.0

        mtg = c.DistanceFromInNauticalMiles(t)

        Return mtg
    End Function

    Public Function todCalc(ByVal CruiseAlt As Integer, ByVal TargetAlt As Integer) As Integer

        Dim Tod As Integer
        Tod = (CruiseAlt - TargetAlt) / 3

        Tod = Tod / 100
        Return Tod
    End Function

    Public Function getGW(ByVal zfw As Integer, ByVal fuel As Integer) As Integer
        Dim gw As Integer
        gw = zfw + fuel
        Return gw

    End Function
End Class
