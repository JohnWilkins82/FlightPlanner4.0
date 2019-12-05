<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutoThrottle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.gbxSpeedHold = New System.Windows.Forms.GroupBox()
        Me.lblBarberpoleIasData = New System.Windows.Forms.Label()
        Me.cxbMaxSpeed = New System.Windows.Forms.CheckBox()
        Me.CbxHoldMach = New System.Windows.Forms.CheckBox()
        Me.bthFsuipcASTEngaged = New System.Windows.Forms.Button()
        Me.numAsD = New System.Windows.Forms.NumericUpDown()
        Me.lblAsIas = New System.Windows.Forms.Label()
        Me.numAsI = New System.Windows.Forms.NumericUpDown()
        Me.numApIas = New System.Windows.Forms.NumericUpDown()
        Me.numAsP = New System.Windows.Forms.NumericUpDown()
        Me.lblAsMachNum = New System.Windows.Forms.Label()
        Me.numApMach = New System.Windows.Forms.NumericUpDown()
        Me.rdbFsuipcATS = New System.Windows.Forms.RadioButton()
        Me.rdbFsATS = New System.Windows.Forms.RadioButton()
        Me.stsThrottle = New System.Windows.Forms.StatusStrip()
        Me.tslThrottletxt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslTHrottle = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tspThrottle = New System.Windows.Forms.ToolStripProgressBar()
        Me.tslThrottleErr = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslIsa = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslFine = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrDataUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.TmrThrPV = New System.Windows.Forms.Timer(Me.components)
        Me.tmrThrPIDCntl = New System.Windows.Forms.Timer(Me.components)
        Me.machUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMaxSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.TmrasPV = New System.Windows.Forms.Timer(Me.components)
        Me.nudCylie = New System.Windows.Forms.NumericUpDown()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.chtPid = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.trmChart = New System.Windows.Forms.Timer(Me.components)
        Me.gbxSpeedHold.SuspendLayout()
        CType(Me.numAsD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAsI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numApIas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAsP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numApMach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stsThrottle.SuspendLayout()
        CType(Me.nudCylie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtPid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxSpeedHold
        '
        Me.gbxSpeedHold.BackColor = System.Drawing.Color.Silver
        Me.gbxSpeedHold.Controls.Add(Me.lblBarberpoleIasData)
        Me.gbxSpeedHold.Controls.Add(Me.cxbMaxSpeed)
        Me.gbxSpeedHold.Controls.Add(Me.CbxHoldMach)
        Me.gbxSpeedHold.Controls.Add(Me.bthFsuipcASTEngaged)
        Me.gbxSpeedHold.Controls.Add(Me.numAsD)
        Me.gbxSpeedHold.Controls.Add(Me.lblAsIas)
        Me.gbxSpeedHold.Controls.Add(Me.numAsI)
        Me.gbxSpeedHold.Controls.Add(Me.numApIas)
        Me.gbxSpeedHold.Controls.Add(Me.numAsP)
        Me.gbxSpeedHold.Controls.Add(Me.lblAsMachNum)
        Me.gbxSpeedHold.Controls.Add(Me.numApMach)
        Me.gbxSpeedHold.Controls.Add(Me.rdbFsuipcATS)
        Me.gbxSpeedHold.Controls.Add(Me.rdbFsATS)
        Me.gbxSpeedHold.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gbxSpeedHold.Location = New System.Drawing.Point(12, 61)
        Me.gbxSpeedHold.Name = "gbxSpeedHold"
        Me.gbxSpeedHold.Size = New System.Drawing.Size(250, 286)
        Me.gbxSpeedHold.TabIndex = 2
        Me.gbxSpeedHold.TabStop = False
        Me.gbxSpeedHold.Text = "Speed Hold"
        '
        'lblBarberpoleIasData
        '
        Me.lblBarberpoleIasData.AutoSize = True
        Me.lblBarberpoleIasData.Location = New System.Drawing.Point(181, 91)
        Me.lblBarberpoleIasData.Name = "lblBarberpoleIasData"
        Me.lblBarberpoleIasData.Size = New System.Drawing.Size(40, 17)
        Me.lblBarberpoleIasData.TabIndex = 16
        Me.lblBarberpoleIasData.Text = "1000"
        '
        'cxbMaxSpeed
        '
        Me.cxbMaxSpeed.AutoSize = True
        Me.cxbMaxSpeed.Location = New System.Drawing.Point(75, 90)
        Me.cxbMaxSpeed.Name = "cxbMaxSpeed"
        Me.cxbMaxSpeed.Size = New System.Drawing.Size(109, 21)
        Me.cxbMaxSpeed.TabIndex = 5
        Me.cxbMaxSpeed.Text = "Max Speed -"
        Me.cxbMaxSpeed.UseVisualStyleBackColor = True
        '
        'CbxHoldMach
        '
        Me.CbxHoldMach.AutoSize = True
        Me.CbxHoldMach.Location = New System.Drawing.Point(75, 46)
        Me.CbxHoldMach.Name = "CbxHoldMach"
        Me.CbxHoldMach.Size = New System.Drawing.Size(97, 21)
        Me.CbxHoldMach.TabIndex = 4
        Me.CbxHoldMach.Text = "Hold Mach"
        Me.CbxHoldMach.UseVisualStyleBackColor = True
        '
        'bthFsuipcASTEngaged
        '
        Me.bthFsuipcASTEngaged.BackColor = System.Drawing.Color.DarkRed
        Me.bthFsuipcASTEngaged.Enabled = False
        Me.bthFsuipcASTEngaged.Location = New System.Drawing.Point(7, 171)
        Me.bthFsuipcASTEngaged.Name = "bthFsuipcASTEngaged"
        Me.bthFsuipcASTEngaged.Size = New System.Drawing.Size(138, 35)
        Me.bthFsuipcASTEngaged.TabIndex = 8
        Me.bthFsuipcASTEngaged.Text = "Disngaged"
        Me.bthFsuipcASTEngaged.UseVisualStyleBackColor = False
        '
        'numAsD
        '
        Me.numAsD.DecimalPlaces = 3
        Me.numAsD.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numAsD.Location = New System.Drawing.Point(166, 222)
        Me.numAsD.Name = "numAsD"
        Me.numAsD.Size = New System.Drawing.Size(72, 22)
        Me.numAsD.TabIndex = 15
        '
        'lblAsIas
        '
        Me.lblAsIas.AutoSize = True
        Me.lblAsIas.Location = New System.Drawing.Point(72, 69)
        Me.lblAsIas.Name = "lblAsIas"
        Me.lblAsIas.Size = New System.Drawing.Size(122, 17)
        Me.lblAsIas.TabIndex = 3
        Me.lblAsIas.Text = "Indcated Airspeed"
        '
        'numAsI
        '
        Me.numAsI.DecimalPlaces = 4
        Me.numAsI.Increment = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.numAsI.Location = New System.Drawing.Point(7, 250)
        Me.numAsI.Name = "numAsI"
        Me.numAsI.Size = New System.Drawing.Size(72, 22)
        Me.numAsI.TabIndex = 14
        Me.numAsI.Value = New Decimal(New Integer() {6, 0, 0, 196608})
        '
        'numApIas
        '
        Me.numApIas.Font = New System.Drawing.Font("Yu Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numApIas.Location = New System.Drawing.Point(7, 63)
        Me.numApIas.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.numApIas.Name = "numApIas"
        Me.numApIas.Size = New System.Drawing.Size(60, 34)
        Me.numApIas.TabIndex = 2
        Me.numApIas.Value = New Decimal(New Integer() {250, 0, 0, 0})
        '
        'numAsP
        '
        Me.numAsP.DecimalPlaces = 3
        Me.numAsP.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numAsP.Location = New System.Drawing.Point(10, 222)
        Me.numAsP.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numAsP.Name = "numAsP"
        Me.numAsP.Size = New System.Drawing.Size(96, 22)
        Me.numAsP.TabIndex = 12
        Me.numAsP.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'lblAsMachNum
        '
        Me.lblAsMachNum.AutoSize = True
        Me.lblAsMachNum.Location = New System.Drawing.Point(72, 26)
        Me.lblAsMachNum.Name = "lblAsMachNum"
        Me.lblAsMachNum.Size = New System.Drawing.Size(96, 17)
        Me.lblAsMachNum.TabIndex = 1
        Me.lblAsMachNum.Text = "Mach Number"
        '
        'numApMach
        '
        Me.numApMach.DecimalPlaces = 2
        Me.numApMach.Font = New System.Drawing.Font("Yu Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numApMach.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numApMach.Location = New System.Drawing.Point(6, 20)
        Me.numApMach.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.numApMach.Minimum = New Decimal(New Integer() {20, 0, 0, 131072})
        Me.numApMach.Name = "numApMach"
        Me.numApMach.Size = New System.Drawing.Size(60, 34)
        Me.numApMach.TabIndex = 0
        Me.numApMach.Value = New Decimal(New Integer() {38, 0, 0, 131072})
        '
        'rdbFsuipcATS
        '
        Me.rdbFsuipcATS.AutoSize = True
        Me.rdbFsuipcATS.Location = New System.Drawing.Point(6, 144)
        Me.rdbFsuipcATS.Name = "rdbFsuipcATS"
        Me.rdbFsuipcATS.Size = New System.Drawing.Size(190, 21)
        Me.rdbFsuipcATS.TabIndex = 7
        Me.rdbFsuipcATS.Text = "Use Program Auto Thrust"
        Me.rdbFsuipcATS.UseVisualStyleBackColor = True
        '
        'rdbFsATS
        '
        Me.rdbFsATS.AutoSize = True
        Me.rdbFsATS.Checked = True
        Me.rdbFsATS.Location = New System.Drawing.Point(7, 117)
        Me.rdbFsATS.Name = "rdbFsATS"
        Me.rdbFsATS.Size = New System.Drawing.Size(153, 21)
        Me.rdbFsATS.TabIndex = 6
        Me.rdbFsATS.TabStop = True
        Me.rdbFsATS.Text = "Use FS Auto Thrust"
        Me.rdbFsATS.UseVisualStyleBackColor = True
        '
        'stsThrottle
        '
        Me.stsThrottle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.stsThrottle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslThrottletxt, Me.tslTHrottle, Me.tspThrottle, Me.tslThrottleErr, Me.tslIsa, Me.tslFine, Me.tslP})
        Me.stsThrottle.Location = New System.Drawing.Point(0, 425)
        Me.stsThrottle.Name = "stsThrottle"
        Me.stsThrottle.Size = New System.Drawing.Size(1039, 25)
        Me.stsThrottle.TabIndex = 17
        Me.stsThrottle.Text = "StatusStrip1"
        '
        'tslThrottletxt
        '
        Me.tslThrottletxt.Name = "tslThrottletxt"
        Me.tslThrottletxt.Size = New System.Drawing.Size(61, 20)
        Me.tslThrottletxt.Text = "Throttle"
        '
        'tslTHrottle
        '
        Me.tslTHrottle.AutoSize = False
        Me.tslTHrottle.Name = "tslTHrottle"
        Me.tslTHrottle.Size = New System.Drawing.Size(49, 20)
        Me.tslTHrottle.Text = "00000"
        Me.tslTHrottle.ToolTipText = "Output to sim"
        '
        'tspThrottle
        '
        Me.tspThrottle.Maximum = 16300
        Me.tspThrottle.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.tspThrottle.Minimum = 1000
        Me.tspThrottle.Name = "tspThrottle"
        Me.tspThrottle.Size = New System.Drawing.Size(75, 19)
        Me.tspThrottle.Value = 1000
        '
        'tslThrottleErr
        '
        Me.tslThrottleErr.Name = "tslThrottleErr"
        Me.tslThrottleErr.Size = New System.Drawing.Size(39, 20)
        Me.tslThrottleErr.Text = "-000"
        Me.tslThrottleErr.ToolTipText = "PID Error"
        '
        'tslIsa
        '
        Me.tslIsa.Name = "tslIsa"
        Me.tslIsa.Size = New System.Drawing.Size(41, 20)
        Me.tslIsa.Text = "0000"
        '
        'tslFine
        '
        Me.tslFine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tslFine.Name = "tslFine"
        Me.tslFine.Size = New System.Drawing.Size(36, 20)
        Me.tslFine.Text = "Fine"
        '
        'tslP
        '
        Me.tslP.Name = "tslP"
        Me.tslP.Size = New System.Drawing.Size(41, 20)
        Me.tslP.Text = "0000"
        '
        'tmrDataUpdate
        '
        '
        'TmrThrPV
        '
        Me.TmrThrPV.Interval = 17
        '
        'tmrThrPIDCntl
        '
        '
        'machUpdate
        '
        Me.machUpdate.Interval = 600
        '
        'tmrMaxSpeed
        '
        Me.tmrMaxSpeed.Interval = 500
        '
        'nudCylie
        '
        Me.nudCylie.Location = New System.Drawing.Point(12, 378)
        Me.nudCylie.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudCylie.Name = "nudCylie"
        Me.nudCylie.Size = New System.Drawing.Size(120, 22)
        Me.nudCylie.TabIndex = 18
        Me.nudCylie.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(12, 358)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(92, 17)
        Me.lblInterval.TabIndex = 19
        Me.lblInterval.Text = "Cycle Interval"
        '
        'chtPid
        '
        ChartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.Name = "ChartArea1"
        Me.chtPid.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtPid.Legends.Add(Legend1)
        Me.chtPid.Location = New System.Drawing.Point(298, 12)
        Me.chtPid.Name = "chtPid"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series1.Legend = "Legend1"
        Series1.Name = "Error"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Legend = "Legend1"
        Series2.Name = "PV"
        Me.chtPid.Series.Add(Series1)
        Me.chtPid.Series.Add(Series2)
        Me.chtPid.Size = New System.Drawing.Size(709, 410)
        Me.chtPid.TabIndex = 20
        Me.chtPid.Text = "chtPid"
        '
        'trmChart
        '
        Me.trmChart.Interval = 500
        '
        'frmAutoThrottle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 450)
        Me.Controls.Add(Me.chtPid)
        Me.Controls.Add(Me.lblInterval)
        Me.Controls.Add(Me.nudCylie)
        Me.Controls.Add(Me.stsThrottle)
        Me.Controls.Add(Me.gbxSpeedHold)
        Me.Name = "frmAutoThrottle"
        Me.Text = "frmAutoThrottle"
        Me.gbxSpeedHold.ResumeLayout(False)
        Me.gbxSpeedHold.PerformLayout()
        CType(Me.numAsD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAsI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numApIas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAsP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numApMach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stsThrottle.ResumeLayout(False)
        Me.stsThrottle.PerformLayout()
        CType(Me.nudCylie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtPid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxSpeedHold As GroupBox
    Friend WithEvents cxbMaxSpeed As CheckBox
    Friend WithEvents CbxHoldMach As CheckBox
    Friend WithEvents bthFsuipcASTEngaged As Button
    Friend WithEvents numAsD As NumericUpDown
    Friend WithEvents lblAsIas As Label
    Friend WithEvents numAsI As NumericUpDown
    Friend WithEvents numApIas As NumericUpDown
    Friend WithEvents numAsP As NumericUpDown
    Friend WithEvents lblAsMachNum As Label
    Friend WithEvents numApMach As NumericUpDown
    Friend WithEvents rdbFsuipcATS As RadioButton
    Friend WithEvents rdbFsATS As RadioButton
    Friend WithEvents stsThrottle As StatusStrip
    Friend WithEvents tslThrottletxt As ToolStripStatusLabel
    Friend WithEvents tslTHrottle As ToolStripStatusLabel
    Friend WithEvents tspThrottle As ToolStripProgressBar
    Friend WithEvents tslThrottleErr As ToolStripStatusLabel
    Friend WithEvents tslIsa As ToolStripStatusLabel
    Friend WithEvents lblBarberpoleIasData As Label
    Friend WithEvents tmrDataUpdate As Timer
    Friend WithEvents TmrThrPV As Timer
    Friend WithEvents tmrThrPIDCntl As Timer
    Friend WithEvents machUpdate As Timer
    Friend WithEvents tmrMaxSpeed As Timer
    Friend WithEvents TmrasPV As Timer
    Friend WithEvents tslFine As ToolStripStatusLabel
    Friend WithEvents tslP As ToolStripStatusLabel
    Friend WithEvents nudCylie As NumericUpDown
    Friend WithEvents lblInterval As Label
    Friend WithEvents chtPid As DataVisualization.Charting.Chart
    Friend WithEvents trmChart As Timer
End Class
