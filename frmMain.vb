Imports FSUIPC
Public Class frmMain

    Dim fs As FsInterface = New FsInterface
    Dim calc As Calculations = New Calculations
    Dim a As aircraft = New aircraft
    Dim reqFuel As Integer = 0
    Dim db As File = New File
    Dim xmlDb As New XmlData
    Dim currPos As FsLatLonPoint = New FsLatLonPoint
    Dim destLatLon As FsLatLonPoint = New FsLatLonPoint
    Dim gs As Integer
    Dim range As Integer = New Integer
    Dim endurTime As TimeSpan = New TimeSpan
    Dim alt As Int64
    Dim mach As Double

    Dim mtg As Double
    Dim eta As TimeSpan = New TimeSpan
    Dim disToTOD As Double
    Dim tod As Integer = 0
    Dim destnation As String
    Dim todEta As TimeSpan = New TimeSpan

    Dim runwayList As List(Of runway)
    Dim searchedRunway As List(Of runway)
    Dim airports As List(Of runway)
    Dim acList As List(Of String)
    Dim p As List(Of perf)
    Dim h As List(Of aircraft)

    'pid
    Dim asPid As PidControler = New PidControler
    Dim asPv As Double = New Double
    Dim asOutput As Double = 1000

    Dim apMachVal As UInteger = New UInteger
    Dim apMachEnable As Boolean = New Boolean
    Dim apIasVal As UInteger = New UInteger
    Dim apIsaEnable As Boolean = New Boolean
    Dim desiredMach As UInteger = New UInteger
    Dim ias As UInteger = New UInteger

    Dim defaultATS As Boolean = True

    Dim asP As Double = 0.0
    Dim asI As Double = 0.0
    Dim AsD As Double = 0.0
    Dim asPfine As Double = 0.0

    Dim dt As Double = New Double
    Dim windup As Boolean = False




    Private Sub btnFcCalc_Click(sender As Object, e As EventArgs) Handles btnFcCalc.Click
        Dim distance As Integer = CInt(Me.txbFcDist.Text.ToString)
        Dim fuelBurn As Integer = CInt(Me.txbFcFuelBurn.Text.ToString)
        Dim altDistance As Integer = CInt(Me.txbFcAltDist.Text.ToString)
        Dim speed As Integer = CInt(Me.txbFcSpeed.Text.ToString)
        Dim timeEnroute As TimeSpan = New TimeSpan

        destnation = txbFcDest.Text.ToString.ToUpper
        searchedRunway = calc.FindRunways(destnation, runwayList)
        destLatLon = calc.getLocation(searchedRunway)

        reqFuel = calc.FuelReq(distance, fuelBurn, speed, altDistance)

        lblFcFuelReq.Text = CInt(reqFuel)

        timeEnroute = calc.timeToTarget(distance, speed)

        If timeEnroute.Minutes >= 9 Then
            lblFcEte.Text = timeEnroute.Hours.ToString + ":" + timeEnroute.Minutes.ToString
        Else
            lblFcEte.Text = timeEnroute.Hours.ToString + ":0" + timeEnroute.Minutes.ToString
        End If

    End Sub

    Private Sub btnAiConnect_Click(sender As Object, e As EventArgs) Handles btnAiConnect.Click
        fs.connect()
        If fs.connected = True Then
            tmrOneTic.Start()
            lblBarberpoleIasData.Text = fs.barberpole

            tmrDataUpdate.Enabled = True

            btnAiConnect.Enabled = False
            'btnLoadFuel.Enabled = True
            btnAiDiscon.Enabled = True
            ' loadFuelPanel()
        End If
    End Sub

    Private Sub tmrOneTic_Tick(sender As Object, e As EventArgs) Handles tmrOneTic.Tick
        If fs.connected = True Then
            a = fs.updateAc(a)
            currPos = fs.updatePos(currPos)
            alt = a.CurrAlt
            lblAiAlt.Text = FormatNumber(alt, 0)

            'speed
            gs = (CInt(a.currGs * 3600.0 / 65536 / 1852))
            lblAiGndSpd.Text = gs
            mach = (a.currMach / 20480)
            lblAiMach.Text = FormatNumber(mach, 2)

            'fuel
            lblAitotalfuel.Text = a.fuelOnBoard
            lblAiFuelBun.Text = FormatNumber(a.GetTotalFuelBurn, 0)
            endurTime = calc.Endurace(a.fuelOnBoard, a.GetTotalFuelBurn)
            lblAiEndur.Text = endurTime.ToString
            lblAiRange.Text = calc.Range(endurTime, gs)

            'weights
            lblAiGw.Text = FormatNumber(calc.getGW(a.zeroFuelWeight, a.fuelOnBoard), 0)
            lblAiZFW.Text = FormatNumber(a.zeroFuelWeight, 0)

            'distance to target
            mtg = calc.milesToGoCalc(destLatLon, currPos)
            disToTOD = mtg - tod

            eta = calc.timeToTarget(mtg, gs)
            todEta = calc.timeToTarget(disToTOD, gs)

            lblPtocDist.Text = FormatNumber(disToTOD, 0)
            lblPtocEta.Text = todEta.ToString()
            lblPtodDisttodest.Text = FormatNumber(mtg, 0)
            lblPtodTimetodest.Text = eta.ToString

            'pause at TOD
            If ckbPtodArmPtod.Checked Then
                If mtg <= tod Then
                    fs.pause(True)
                End If
            End If

        End If
    End Sub

    Private Sub btnAiDiscon_Click(sender As Object, e As EventArgs) Handles btnAiDiscon.Click
        fs.disconect()
        tmrOneTic.Stop()
        tmrDataUpdate.Enabled = False

        btnAiDiscon.Enabled = False
        btnAiConnect.Enabled = True
    End Sub

    Private Sub btnPtodCalc_Click(sender As Object, e As EventArgs) Handles btnPtodCalc.Click
        Dim airport As String = txbPtodDest.Text.ToUpper

        searchedRunway = calc.FindRunways(airport, runwayList)

        Dim crzAlt As Integer = txbPtodCrzAlt.Text
        Dim tgtAlt As Integer = txbPtodTgtAlt.Text

        If searchedRunway.Count = 0 Then
            MessageBox.Show("Airport " + airport.ToString + " is not found")
        Else
            destLatLon = calc.getLocation(searchedRunway)
        End If

        tod = calc.todCalc(crzAlt, tgtAlt)
        nudPtodDist.Value = tod

    End Sub

    Private Sub ckbPtodArmPtod_CheckedChanged(sender As Object, e As EventArgs) Handles ckbPtodArmPtod.CheckedChanged
        If ckbPtodArmPtod.Checked = True Then
            ckbPtodArmPtod.ForeColor = Color.DarkGreen
        Else
            ckbPtodArmPtod.ForeColor = Color.Brown
        End If
    End Sub
    'Private Sub txbFcDest_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txbFcDest.Validating
    '    Dim cntl As Control = CType(sender, Control)
    '    If IsNumeric(cntl.Text) Then
    '        e.Cancel = True
    '        ErrProMain.SetError(cntl, "Needs text")
    '    End If
    '    If cntl.Text = "" Then
    '        e.Cancel = True
    '        ErrProMain.SetError(cntl, "Needs Airport Code")
    '    End If

    '    If cntl.Text = "Code" Then
    '        e.Cancel = True
    '        ErrProMain.SetError(cntl, "Needs Airport Code")

    '    End If
    'End Sub

    'Private Sub txbFcDest_Validated(sender As Object, e As EventArgs) Handles txbFcDest.Validated
    '    Dim cntl As Control = CType(sender, Control)
    '    ErrProMain.SetError(cntl, "")
    'End Sub

    Private Sub txbFcDist_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txbFcDist.Validating
        Dim cntl As Control = CType(sender, Control)
        If cntl.Text = "0000" Then
            e.Cancel = True
            ErrProMain.SetError(cntl, "Enter a distance to travel")
        End If
        If IsNumeric(cntl.Text) = False Then
            e.Cancel = True
            ErrProMain.SetError(cntl, "Enter a Number")
        End If
    End Sub

    Private Sub txbFcDist_Validated(sender As Object, e As EventArgs) Handles txbFcDist.Validated
        Dim cntl As Control = CType(sender, Control)
        ErrProMain.SetError(cntl, "")
    End Sub

    Private Sub txbFcSpeed_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txbFcSpeed.Validating
        Dim cntl As Control = CType(sender, Control)
        If cntl.Text = "000" Then
            e.Cancel = True
            ErrProMain.SetError(cntl, "Enter Speed")
        End If
        If IsNumeric(cntl.Text) = False Then
            e.Cancel = True
            ErrProMain.SetError(cntl, "Enter a Number")
        End If

    End Sub

    Private Sub txbFcSpeed_Validated(sender As Object, e As EventArgs) Handles txbFcSpeed.Validated
        Dim cntl As Control = CType(sender, Control)
        ErrProMain.SetError(cntl, "")
    End Sub

    Private Sub txbFcFuelBurn_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txbFcFuelBurn.Validating
        Dim cntl As Control = CType(sender, Control)
        If cntl.Text = "00000" Then
            e.Cancel = True
            ErrProMain.SetError(cntl, "Enter Fuel Burn")
        End If
        If IsNumeric(cntl.Text) = False Then
            e.Cancel = True
            ErrProMain.SetError(cntl, "Enter a Number")
        End If
    End Sub

    Private Sub txbFcFuelBurn_Validated(sender As Object, e As EventArgs) Handles txbFcFuelBurn.Validated
        Dim cntl As Control = CType(sender, Control)
        ErrProMain.SetError(cntl, "")
    End Sub

    Private Sub txbFcAltDist_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txbFcAltDist.Validating
        Dim cntl As Control = CType(sender, Control)
        If cntl.Text = "000" Then
            e.Cancel = True
            ErrProMain.SetError(cntl, "Enter a Alternate Distance")
        End If
        If IsNumeric(cntl.Text) = False Then
            e.Cancel = True
            ErrProMain.SetError(cntl, "Enter a Number")
        End If
    End Sub

    Private Sub txbFcAltDist_Validated(sender As Object, e As EventArgs) Handles txbFcAltDist.Validated
        Dim cntl As Control = CType(sender, Control)
        ErrProMain.SetError(cntl, "")
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        runwayList = db.getRunways
        acList = db.getAcList()
        For Each ac As String In acList
            cmbAsAircraft.Items.Add(ac)
        Next
    End Sub

    Private Sub nudPtodDist_ValueChanged(sender As Object, e As EventArgs) Handles nudPtodDist.ValueChanged
        tod = nudPtodDist.Value
    End Sub

    Private Sub txbFcDest_TextChanged(sender As Object, e As EventArgs) Handles txbFcDest.TextChanged


    End Sub

    Private Sub cmbAsAircraft_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAsAircraft.SelectedIndexChanged
        cmbAsPerfs.Items.Clear()
        cmbAsPerfs.Text = "Select Performace"
        Dim ac As String = cmbAsAircraft.SelectedItem.ToString
        xmlDb.loadAc(ac)
        a = xmlDb.Aircraft
        p = xmlDb.Perfs
        For Each pe As perf In p
            cmbAsPerfs.Items.Add(pe.Name)
        Next
        txbAsCrzAtl.Text = FormatNumber(a.CruzAlt, 0)
        txbPtodCrzAlt.Text = FormatNumber(a.CruzAlt, 0)
    End Sub

    Private Sub cmbAsPerfs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAsPerfs.SelectedIndexChanged
        Dim loadedPerf As perf
        loadedPerf = p.Item(cmbAsPerfs.SelectedIndex)

        txtAcGS.Text = loadedPerf.Speed
        txbAsFuelBurn.Text = loadedPerf.FuelFlow

        txbFcFuelBurn.Text = loadedPerf.FuelFlow
        txbFcSpeed.Text = loadedPerf.Speed

    End Sub

    Private Sub btnHanger_Click(sender As Object, e As EventArgs) Handles btnHanger.Click
        frmHanger.Show()
        cmbAsAircraft.Items.Clear()
        'acList = db.getAcList()
        'For Each ac As String In acList
        '    cmbAsAircraft.Items.Add(ac)
        'Next
    End Sub

    Private Sub txbFcDest_Leave(sender As Object, e As EventArgs) Handles txbFcDest.Leave
        txbFcDest.Text = txbFcDest.Text.ToUpper
        txbPtodDest.Text = txbFcDest.Text
    End Sub



    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        cmbAsAircraft.Items.Clear()
        acList.Clear()
        acList = db.getAcList()
        For Each ac As String In acList
            cmbAsAircraft.Items.Add(ac)
        Next
    End Sub

    Private Sub HangerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HangerToolStripMenuItem.Click
        frmHanger.Show()
        cmbAsAircraft.Items.Clear()
    End Sub

    Private Sub AutoThrottleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoThrottleToolStripMenuItem.Click
        If fs.connected = True Then
            Dim frmAt As frmAutoThrottle = New frmAutoThrottle(fs)
            frmAt.Show()
        Else
            MessageBox.Show("Please connect to Sim")
        End If
    End Sub

    Private Sub bthFsuipcASTEngaged_Click(sender As Object, e As EventArgs) Handles bthFsuipcASTEngaged.Click
        If bthFsuipcASTEngaged.Text = "Engaged" Then
            bthFsuipcASTEngaged.Text = "Disengaged"
            bthFsuipcASTEngaged.BackColor = Color.DarkRed

            TmrThrPV.Enabled = False
            tmrThrPIDCntl.Enabled = False
            ' trmChart.Enabled = False
        Else
            bthFsuipcASTEngaged.Text = "Engaged"
            bthFsuipcASTEngaged.BackColor = Color.DarkGreen
            tmrThrPIDCntl.Enabled = True
            TmrThrPV.Enabled = True
            'trmChart.Enabled = True
            asOutput = fs.readThrottle
        End If
    End Sub

    Private Sub TmrasPV_Tick(sender As Object, e As EventArgs) Handles TmrThrPV.Tick
        If fs.connected = True Then
            asPv = fs.Ias
            ' pv = pv + (output * 0.2) - (pv * 0.1)


            'pv = pv + (output * 0.2) - (pv * 0.1)
        End If

    End Sub

    Private Sub machUpdate_Tick(sender As Object, e As EventArgs) Handles machUpdate.Tick

        fs.setMach(numApMach.Value)
    End Sub

    Private Sub tmrMaxSpeed_Tick(sender As Object, e As EventArgs) Handles tmrMaxSpeed.Tick

    End Sub

    Private Sub rdbFsuipcATS_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFsuipcATS.CheckedChanged
        'using FSUIPC
        defaultATS = False
        bthFsuipcASTEngaged.Enabled = True
    End Sub

    Private Sub rdbFsATS_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFsATS.CheckedChanged
        'using FS
        defaultATS = True
        bthFsuipcASTEngaged.Enabled = False
    End Sub

    Private Sub tmrasPIDCntl_Tick(sender As Object, e As EventArgs) Handles tmrThrPIDCntl.Tick
        'pid.SetPoint1 = numApIas.Value
        'err = pid.getError(0.2, 0.01, 1, 30, 100)


        'lblPidResult.Text = err.ToString
        tslFine.ForeColor = Color.Red
        If asPid.Err <= 3 Or asPid.Err <= -3 Then
            '' asPid.Kp = numPFine.Value
            tslFine.ForeColor = Color.DarkOliveGreen
        Else
            asPid.Kp = numAsP.Value
        End If
        If asOutput >= 16300 Then
            windup = True
        Else
            windup = False
        End If

        asOutput = asPid.Run(asPv, numApIas.Value, windup)


        If asOutput >= 16300 Then
            fs.SetTHrottle(CInt(16300))
            asOutput = 16300
        ElseIf asOutput <= 1000 Then
            fs.SetTHrottle(CInt(1000))
            asOutput = 1000
        Else
            fs.SetTHrottle(CInt(asOutput))
        End If
        tslThrottleErr.Text = asPid.Err
        tspThrottle.Value = FormatNumber(asOutput, 0)
        tslTHrottle.Text = FormatNumber(asOutput, 0)

        tslIsa.Text = fs.Ias.ToString
        tslP.Text = asPid.Kp.ToString


    End Sub

    Private Sub NumAsP_ValueChanged(sender As Object, e As EventArgs) Handles numAsP.ValueChanged
        asPid.Kp = numAsP.Value

    End Sub

    Private Sub NumAsI_ValueChanged(sender As Object, e As EventArgs) Handles numAsI.ValueChanged
        asPid.Ki = numAsI.Value
    End Sub

    Private Sub NumAsD_ValueChanged(sender As Object, e As EventArgs) Handles numAsD.ValueChanged
        asPid.Kd = numAsD.Value

    End Sub

    Private Sub tmrDataUpdate_Tick(sender As Object, e As EventArgs) Handles tmrDataUpdate.Tick
        tslIsa.Text = fs.Ias
        lblBarberpoleIasData.Text = fs.barberpole

        lblAsMachNum.Text = fs.machVal
        tslThrottleErr.Text = asPid.Err
        tspThrottle.Value = asOutput
        tslTHrottle.Text = asOutput
        tspThrottle.Value = asOutput

    End Sub
End Class
