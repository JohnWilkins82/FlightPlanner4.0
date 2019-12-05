Public Class frmAutoThrottle
    Dim fs As FsInterface

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
    Public Sub New(ByVal f As FsInterface)
        fs = f

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub bthFsuipcASTEngaged_Click(sender As Object, e As EventArgs) Handles bthFsuipcASTEngaged.Click
        If bthFsuipcASTEngaged.Text = "Engaged" Then
            bthFsuipcASTEngaged.Text = "Disengaged"
            bthFsuipcASTEngaged.BackColor = Color.DarkRed

            TmrThrPV.Enabled = False
            tmrThrPIDCntl.Enabled = False
            trmChart.Enabled = False
        Else
            bthFsuipcASTEngaged.Text = "Engaged"
            bthFsuipcASTEngaged.BackColor = Color.DarkGreen
            tmrThrPIDCntl.Enabled = True
            TmrThrPV.Enabled = True
            trmChart.Enabled = True
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
        If fs.connected = True Then
            If CInt(fs.Altmeter.Value) < 10000 Then
                fs.setIsa(250, defaultATS)
            ElseIf fs.getMach > desiredMach Then

                fs.setIsa(fs.barberpole, defaultATS)
            Else
                ' cxbMaxSpeed.Checked = False
                'CbxHoldMach.Checked = True
            End If

        End If

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

    Private Sub frmAutoThrottle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = 17
        'If fs.connected = False Then


        ''fs.getBarberPole()
        lblBarberpoleIasData.Text = fs.barberpole
        'GbxConnect.BackColor = Color.DarkGreen
        'btnConnect.Text = "Disconect"

        tmrDataUpdate.Enabled = True

        'ElseIf fs.connected = True Then
        '    fs.disconect()
        '    tmrDataUpdate.Enabled = False
        '    tmrThrPIDCntl.Enabled = False
        '    TmrThrPV.Enabled = False
        '    bthFsuipcASTEngaged.Enabled = False
        '    rdbFsATS.Checked = True
        '    rdbFsuipcATS.Checked = False
        '    tmrMaxSpeed.Enabled = False
        '    tslIsa.Text = 0
        '    lblBarberpoleIasData.Text = 0
        '    'GbxConnect.BackColor = Color.DarkRed
        '    'btnConnect.Text = "Connect"
        'End If
    End Sub

    Private Sub cxbMaxSpeed_CheckedChanged(sender As Object, e As EventArgs) Handles cxbMaxSpeed.CheckedChanged

    End Sub

    Private Sub nudCylie_ValueChanged(sender As Object, e As EventArgs) Handles nudCylie.ValueChanged
        tmrThrPIDCntl.Interval = nudCylie.Value
    End Sub

    Private Sub trmChart_Tick(sender As Object, e As EventArgs) Handles trmChart.Tick
        Try
            '' Dim op As Point = New Point


            'chtPid.Series("Output").Points.AddY(asOutput / 100)

            'If chtPid.Series("Output").Points.Count = 20 Then
            '    chtPid.Series("Output").Points.RemoveAt(0)
            'End If

            chtPid.Series("Error").Points.AddY(asPid.Err)
            If chtPid.Series("Error").Points.Count = 20 Then
                chtPid.Series("Error").Points.RemoveAt(0)
            End If

            chtPid.Series("PV").Points.AddY(asPid.PrvVal)
            If chtPid.Series("PV").Points.Count = 20 Then
                chtPid.Series("PV").Points.RemoveAt(0)
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class