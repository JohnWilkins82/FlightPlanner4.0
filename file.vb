Imports System.Xml
Imports System.Configuration
Imports System.IO
Imports FlightPlanner4

Public Class File
    ' Dim xele As XElement
    Private m_perfs As List(Of perf) = New List(Of perf)
    Private m_hanger As List(Of aircraft) = New List(Of aircraft)
    Dim p As New perf
    Dim a As New aircraft
    Dim acList As List(Of String) = New List(Of String)


    Dim xmlNode As String = ""
    Dim xmlPath As String

    Public Property Perfs As List(Of perf)
        Get
            Return m_perfs
        End Get
        Set(value As List(Of perf))
            m_perfs = value
        End Set
    End Property

    Public Property Hanger As List(Of aircraft)
        Get
            Return m_hanger
        End Get
        Set(value As List(Of aircraft))
            m_hanger = value
        End Set
    End Property

    Public Property A1 As aircraft
        Get
            Return a
        End Get
        Set(value As aircraft)
            a = value
        End Set
    End Property





    'read make runways
    Public Shared Function getRunways() As List(Of runway)
        Dim runwayList As New List(Of runway)
        ' read runways.csv
        Dim myDocPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim filename As String
        filename = myDocPath + "\Flightplanner\" + "runways.csv"

        Dim fs As FileStream
        Try
            fs = New FileStream(filename, FileMode.Open, FileAccess.Read)

        Catch fnf As FileNotFoundException
            MessageBox.Show("File " + filename.ToString + " not found")


        End Try
        Dim fileReader As New StreamReader(fs)

        Do While fileReader.Peek <> -1
            Dim row As String = fileReader.ReadLine
            Dim dimliter As String = ","
            Dim placeholder As Integer = 0
            Dim temp As String() = Split(row, dimliter)
            Dim r As New runway

            r.setAirport(temp(0))
            r.setHeading(temp(1))
            r.setLat(temp(2))
            r.setLon(temp(3))
            r.setAlt(temp(4))
            r.setMagHeading(temp(5))
            r.setLength(temp(6))
            r.setIls(temp(7))

            runwayList.Add(r)
        Loop

        Return runwayList
    End Function

    Public Function getAcList() As List(Of String)
        Dim myDocPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim path As String
        path = myDocPath + "\Flightplanner\Aircraft"
        Dim di As DirectoryInfo = New DirectoryInfo(path)

        For Each fi In di.GetFiles
            acList.Add(IO.Path.GetFileNameWithoutExtension(fi.Name))
        Next

        Return acList
    End Function






End Class
