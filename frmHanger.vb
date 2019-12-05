Public Class frmHanger
    Dim db As File = New File
    Dim xmlDb As XmlData = New XmlData
    Dim aclist As List(Of String) = New List(Of String)
    Dim a As aircraft
    Dim p As perf
    Dim perfs As List(Of perf) = New List(Of perf)


    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnAddAc.Click
        Dim edit As Boolean = False
        For Each i As String In aclist
            If i = cmbType.Text Then

                edit = True

            End If
        Next
        If perfs.Count = 0 Then
            MessageBox.Show("Please add preformance data")
        Else
            If edit = True Then
                xmlDb.EditXml(a, perfs)
            Else
                Dim a As New aircraft
                Dim p As New perf
                ' perfs.Clear()

                a.Type = cmbType.Text
                a.CruzAlt = txbCrzAlt.Text


                xmlDb.CreateXml(a, perfs)
                perfs.Clear()
            End If
        End If



    End Sub

    Private Sub Hanger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aclist = db.getAcList
        For Each i As String In aclist
            cmbType.Items.Add(i)
        Next
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        lbxPerfs.Items.Clear()

        Dim acString As String = cmbType.SelectedItem.ToString

        xmlDb.loadAc(acString)
        a = xmlDb.Aircraft
        perfs = xmlDb.Perfs
        txbCrzAlt.Text = FormatNumber(a.CruzAlt, 0)

        For Each i As perf In perfs
            lbxPerfs.Items.Add(i.Name)
        Next
    End Sub

    Private Sub lbxPerfs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxPerfs.SelectedIndexChanged
        Dim loadedPerf As perf = New perf

        loadedPerf = perfs.Item(lbxPerfs.SelectedIndex)

        txbPerfName.Text = loadedPerf.Name
        txbFuelBurn.Text = FormatNumber(loadedPerf.FuelFlow, 0)
        txbSpeed.Text = FormatNumber(loadedPerf.Speed, 0)

    End Sub

    Private Sub btnAddPerf_Click(sender As Object, e As EventArgs) Handles btnAddPerf.Click
        Dim edit As Boolean = False
        For Each i As perf In perfs
            If txbPerfName.Name = i.Name.ToString Then
                edit = True
            End If
        Next

        If edit = True Then
            perfs.RemoveRange(lbxPerfs.SelectedIndex, 1)
        End If

        p = New perf
        p.Name = txbPerfName.Text
        p.Speed = txbSpeed.Text
        p.FuelFlow = txbFuelBurn.Text
        perfs.Add(p)
        lbxPerfs.Items.Clear()
        For Each i As perf In perfs
            lbxPerfs.Items.Add(i.Name)
        Next

    End Sub
End Class