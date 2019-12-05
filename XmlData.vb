Imports FlightPlanner4
Imports System.Xml
Public Class XmlData
    Private m_perfs As New List(Of perf)
    Private m_aircraft As aircraft
    Dim myDocPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Dim path As String
    Dim doc As XmlDocument = New XmlDocument
    Dim reader As XmlReader
    Dim p As perf



    Public Property Perfs As List(Of perf)
        Get
            Return m_perfs
        End Get
        Set(value As List(Of perf))
            m_perfs = value
        End Set
    End Property

    Public Property Aircraft As aircraft
        Get
            Return m_aircraft
        End Get
        Set(value As aircraft)
            m_aircraft = value
        End Set
    End Property



    Public Sub loadAc(ByVal n As String)
        path = myDocPath + "\Flightplanner\Aircraft\" + n + ".xml"
        ''path = "d:\hanger\" + n + ".xml"

        ReadXml()

    End Sub

    Private Sub ReadXml()
        Try
            Dim h As XElement = XElement.Load(path)
            Aircraft = New aircraft

            Perfs.Clear()

            Dim ac As IEnumerable(Of XElement) = h.Descendants

            For Each ai As XElement In ac
                Select Case ai.Name
                    Case "Aircraft"
                        Aircraft = New aircraft
                    Case "Model"
                        Aircraft.Type = ai.Value

                    Case "Perf"
                        p = New perf
                        p.AcType = Aircraft.Type
                    Case "Name"
                        p.Name = ai.Value
                    Case "Speed"
                        p.Speed = ai.Value
                    Case "FuelFlow"
                        p.FuelFlow = ai.Value
                        m_perfs.Add(p)
                    Case "Alt"
                        Aircraft.CruzAlt = ai.Value
                        'this must go last


                    Case Else

                End Select
            Next
        Catch ex As Exception
            MessageBox.Show("XmlDb" + ex.Message)
        End Try
    End Sub

    Public Sub CreateXml(ByVal a As aircraft, ByVal perfs As List(Of perf))

        path = myDocPath + "\Flightplanner\Aircraft\" + a.Type + ".xml"
        Dim settings As New XmlWriterSettings
        settings.Indent = True
        Try




            Dim xmlWrt As XmlWriter = XmlWriter.Create(path, settings)

            With xmlWrt
                .WriteStartDocument()

                .WriteStartElement("Aircraft")

                .WriteStartElement("Model")
                .WriteString(a.Type.ToString)
                .WriteEndElement()

                .WriteStartElement("Alt")
                .WriteString(a.CruzAlt.ToString)
                .WriteEndElement()

                For Each p As perf In perfs
                    .WriteStartElement("Perf")
                    .WriteAttributeString("Id", perfs.IndexOf(p))

                    .WriteStartElement("Name")
                    .WriteString(p.Name.ToString)
                    .WriteEndElement()

                    .WriteStartElement("Speed")
                    .WriteString(p.Speed.ToString)
                    .WriteEndElement()

                    .WriteStartElement("FuelFlow")
                    .WriteString(p.FuelFlow.ToString)
                    .WriteEndElement()


                    .WriteEndElement()
                Next
                .WriteEndElement()

                .WriteEndDocument()
                .Close()
            End With
        Catch ex As Exception
            MessageBox.Show("WriteXML  " + ex.Message)
        End Try
    End Sub

    Public Sub EditXml(ByVal a As aircraft, ByVal p As List(Of perf))
        path = myDocPath + "\Flightplanner\Aircraft\" + a.Type + ".xml"
        Try
            My.Computer.FileSystem.DeleteFile(path)
            CreateXml(a, p)
        Catch ex As Exception
            MessageBox.Show("File Delete Error " + ex.Message)
        End Try

    End Sub

End Class
