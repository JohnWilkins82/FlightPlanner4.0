<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblFpDistance = New System.Windows.Forms.Label()
        Me.gpbFuelCalc = New System.Windows.Forms.GroupBox()
        Me.btnFcCalc = New System.Windows.Forms.Button()
        Me.lblFcEte = New System.Windows.Forms.Label()
        Me.lblFcEteTxt = New System.Windows.Forms.Label()
        Me.lblFcFuelReq = New System.Windows.Forms.Label()
        Me.lblFcFuelReqTxt = New System.Windows.Forms.Label()
        Me.lblFcAltDist = New System.Windows.Forms.Label()
        Me.txbFcDest = New System.Windows.Forms.TextBox()
        Me.txbFcAltDist = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbFcFuelBurn = New System.Windows.Forms.Label()
        Me.txbFcFuelBurn = New System.Windows.Forms.TextBox()
        Me.txbFcSpeed = New System.Windows.Forms.TextBox()
        Me.lblFpSpeed = New System.Windows.Forms.Label()
        Me.txbFcDist = New System.Windows.Forms.TextBox()
        Me.ErrProMain = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gpbAcInfo = New System.Windows.Forms.GroupBox()
        Me.lblPtodTimetodest = New System.Windows.Forms.Label()
        Me.lblPtodtimetoDesttxt = New System.Windows.Forms.Label()
        Me.lblPtodDisttodest = New System.Windows.Forms.Label()
        Me.lblAiZFW = New System.Windows.Forms.Label()
        Me.lblAiZFWTxt = New System.Windows.Forms.Label()
        Me.lblAitotalfuel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAiEndur = New System.Windows.Forms.Label()
        Me.lblPtocEta = New System.Windows.Forms.Label()
        Me.lblAiRange = New System.Windows.Forms.Label()
        Me.lblPtocEtaTxt = New System.Windows.Forms.Label()
        Me.lblAiGw = New System.Windows.Forms.Label()
        Me.lblAiFuelBun = New System.Windows.Forms.Label()
        Me.lblAiMach = New System.Windows.Forms.Label()
        Me.lblAiAlt = New System.Windows.Forms.Label()
        Me.lblPtocDist = New System.Windows.Forms.Label()
        Me.lblAiGndSpd = New System.Windows.Forms.Label()
        Me.lblPtodTimetoTodTxt = New System.Windows.Forms.Label()
        Me.lblAiTotalFueltx = New System.Windows.Forms.Label()
        Me.lblAiEndutx = New System.Windows.Forms.Label()
        Me.lblAiRangetx = New System.Windows.Forms.Label()
        Me.lblAiGwtx = New System.Windows.Forms.Label()
        Me.lblAiGndSpdText = New System.Windows.Forms.Label()
        Me.lblAiFuelBurntx = New System.Windows.Forms.Label()
        Me.lblAiMachtx = New System.Windows.Forms.Label()
        Me.lblAiAlttx = New System.Windows.Forms.Label()
        Me.btnAiDiscon = New System.Windows.Forms.Button()
        Me.btnAiConnect = New System.Windows.Forms.Button()
        Me.tmrOneTic = New System.Windows.Forms.Timer(Me.components)
        Me.gpbPauseTod = New System.Windows.Forms.GroupBox()
        Me.nudPtodDist = New System.Windows.Forms.NumericUpDown()
        Me.btnPtodCalc = New System.Windows.Forms.Button()
        Me.txbPtodDest = New System.Windows.Forms.TextBox()
        Me.lblPtodDest = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txbPtodTgtAlt = New System.Windows.Forms.TextBox()
        Me.txbPtodCrzAlt = New System.Windows.Forms.TextBox()
        Me.lblPtodCrzAlt = New System.Windows.Forms.Label()
        Me.lblPtodTod = New System.Windows.Forms.Label()
        Me.ckbPtodArmPtod = New System.Windows.Forms.CheckBox()
        Me.btnHanger = New System.Windows.Forms.Button()
        Me.lblAsFuelBurn = New System.Windows.Forms.Label()
        Me.txbAsFuelBurn = New System.Windows.Forms.TextBox()
        Me.txbAsCrzAtl = New System.Windows.Forms.TextBox()
        Me.txtAcGS = New System.Windows.Forms.TextBox()
        Me.lblAsCrzAlt = New System.Windows.Forms.Label()
        Me.lblAsGs = New System.Windows.Forms.Label()
        Me.cmbAsPerfs = New System.Windows.Forms.ComboBox()
        Me.cmbAsAircraft = New System.Windows.Forms.ComboBox()
        Me.lblAsAircraft = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AircraftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HangerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoThrottleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tclMain = New System.Windows.Forms.TabControl()
        Me.tbpAcSel = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblBarberpoleIasData = New System.Windows.Forms.Label()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.nudCylie = New System.Windows.Forms.NumericUpDown()
        Me.gbxSpeedHold = New System.Windows.Forms.GroupBox()
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GpbAcSeletor = New System.Windows.Forms.GroupBox()
        Me.TmrThrPV = New System.Windows.Forms.Timer(Me.components)
        Me.tmrThrPIDCntl = New System.Windows.Forms.Timer(Me.components)
        Me.machUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMaxSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.TmrasPV = New System.Windows.Forms.Timer(Me.components)
        Me.stsThrottle = New System.Windows.Forms.StatusStrip()
        Me.tslThrottletxt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslTHrottle = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tspThrottle = New System.Windows.Forms.ToolStripProgressBar()
        Me.tslThrottleErr = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslIsa = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslFine = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrDataUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.gpbFuelCalc.SuspendLayout()
        CType(Me.ErrProMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbAcInfo.SuspendLayout()
        Me.gpbPauseTod.SuspendLayout()
        CType(Me.nudPtodDist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.tclMain.SuspendLayout()
        Me.tbpAcSel.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.nudCylie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxSpeedHold.SuspendLayout()
        CType(Me.numAsD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAsI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numApIas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAsP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numApMach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.stsThrottle.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFpDistance
        '
        Me.lblFpDistance.AutoSize = True
        Me.lblFpDistance.Font = New System.Drawing.Font("Bitstream Vera Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFpDistance.Location = New System.Drawing.Point(36, 153)
        Me.lblFpDistance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFpDistance.Name = "lblFpDistance"
        Me.lblFpDistance.Size = New System.Drawing.Size(97, 24)
        Me.lblFpDistance.TabIndex = 0
        Me.lblFpDistance.Text = "Distance"
        '
        'gpbFuelCalc
        '
        Me.gpbFuelCalc.BackColor = System.Drawing.Color.Silver
        Me.gpbFuelCalc.Controls.Add(Me.btnFcCalc)
        Me.gpbFuelCalc.Controls.Add(Me.lblFcEte)
        Me.gpbFuelCalc.Controls.Add(Me.lblFcEteTxt)
        Me.gpbFuelCalc.Controls.Add(Me.lblFcFuelReq)
        Me.gpbFuelCalc.Controls.Add(Me.lblFcFuelReqTxt)
        Me.gpbFuelCalc.Controls.Add(Me.lblFcAltDist)
        Me.gpbFuelCalc.Controls.Add(Me.txbFcDest)
        Me.gpbFuelCalc.Controls.Add(Me.txbFcAltDist)
        Me.gpbFuelCalc.Controls.Add(Me.Label1)
        Me.gpbFuelCalc.Controls.Add(Me.lbFcFuelBurn)
        Me.gpbFuelCalc.Controls.Add(Me.txbFcFuelBurn)
        Me.gpbFuelCalc.Controls.Add(Me.txbFcSpeed)
        Me.gpbFuelCalc.Controls.Add(Me.lblFpSpeed)
        Me.gpbFuelCalc.Controls.Add(Me.txbFcDist)
        Me.gpbFuelCalc.Controls.Add(Me.lblFpDistance)
        Me.gpbFuelCalc.Font = New System.Drawing.Font("Air America", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbFuelCalc.Location = New System.Drawing.Point(7, 18)
        Me.gpbFuelCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbFuelCalc.Name = "gpbFuelCalc"
        Me.gpbFuelCalc.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbFuelCalc.Size = New System.Drawing.Size(305, 514)
        Me.gpbFuelCalc.TabIndex = 2
        Me.gpbFuelCalc.TabStop = False
        Me.gpbFuelCalc.Text = "Fuel Calculator"
        '
        'btnFcCalc
        '
        Me.btnFcCalc.Font = New System.Drawing.Font("basic title font", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFcCalc.Location = New System.Drawing.Point(111, 449)
        Me.btnFcCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFcCalc.Name = "btnFcCalc"
        Me.btnFcCalc.Size = New System.Drawing.Size(144, 47)
        Me.btnFcCalc.TabIndex = 5
        Me.btnFcCalc.Text = "Calculate"
        Me.btnFcCalc.UseVisualStyleBackColor = True
        '
        'lblFcEte
        '
        Me.lblFcEte.BackColor = System.Drawing.Color.Black
        Me.lblFcEte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFcEte.Font = New System.Drawing.Font("Electronic Highway Sign", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFcEte.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblFcEte.Location = New System.Drawing.Point(64, 414)
        Me.lblFcEte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFcEte.Name = "lblFcEte"
        Me.lblFcEte.Size = New System.Drawing.Size(119, 30)
        Me.lblFcEte.TabIndex = 14
        Me.lblFcEte.Text = "00:00:00"
        Me.lblFcEte.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFcEteTxt
        '
        Me.lblFcEteTxt.AutoSize = True
        Me.lblFcEteTxt.Font = New System.Drawing.Font("Bitstream Vera Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFcEteTxt.Location = New System.Drawing.Point(39, 386)
        Me.lblFcEteTxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFcEteTxt.Name = "lblFcEteTxt"
        Me.lblFcEteTxt.Size = New System.Drawing.Size(48, 24)
        Me.lblFcEteTxt.TabIndex = 13
        Me.lblFcEteTxt.Text = "ETE"
        '
        'lblFcFuelReq
        '
        Me.lblFcFuelReq.BackColor = System.Drawing.Color.Black
        Me.lblFcFuelReq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFcFuelReq.Font = New System.Drawing.Font("Electronic Highway Sign", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFcFuelReq.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblFcFuelReq.Location = New System.Drawing.Point(87, 357)
        Me.lblFcFuelReq.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFcFuelReq.Name = "lblFcFuelReq"
        Me.lblFcFuelReq.Size = New System.Drawing.Size(96, 30)
        Me.lblFcFuelReq.TabIndex = 12
        Me.lblFcFuelReq.Text = "0"
        Me.lblFcFuelReq.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFcFuelReqTxt
        '
        Me.lblFcFuelReqTxt.AutoSize = True
        Me.lblFcFuelReqTxt.Font = New System.Drawing.Font("Bitstream Vera Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFcFuelReqTxt.Location = New System.Drawing.Point(36, 327)
        Me.lblFcFuelReqTxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFcFuelReqTxt.Name = "lblFcFuelReqTxt"
        Me.lblFcFuelReqTxt.Size = New System.Drawing.Size(150, 24)
        Me.lblFcFuelReqTxt.TabIndex = 11
        Me.lblFcFuelReqTxt.Text = "Fuel Required"
        '
        'lblFcAltDist
        '
        Me.lblFcAltDist.AutoSize = True
        Me.lblFcAltDist.Font = New System.Drawing.Font("Bitstream Vera Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFcAltDist.Location = New System.Drawing.Point(36, 274)
        Me.lblFcAltDist.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFcAltDist.Name = "lblFcAltDist"
        Me.lblFcAltDist.Size = New System.Drawing.Size(109, 24)
        Me.lblFcAltDist.TabIndex = 10
        Me.lblFcAltDist.Text = "Alternate "
        '
        'txbFcDest
        '
        Me.txbFcDest.Font = New System.Drawing.Font("basic title font", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFcDest.Location = New System.Drawing.Point(181, 102)
        Me.txbFcDest.Margin = New System.Windows.Forms.Padding(4)
        Me.txbFcDest.MaxLength = 4
        Me.txbFcDest.Name = "txbFcDest"
        Me.txbFcDest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txbFcDest.Size = New System.Drawing.Size(72, 30)
        Me.txbFcDest.TabIndex = 0
        Me.txbFcDest.Text = "Klnk"
        Me.txbFcDest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txbFcAltDist
        '
        Me.txbFcAltDist.Font = New System.Drawing.Font("basic title font", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFcAltDist.Location = New System.Drawing.Point(193, 274)
        Me.txbFcAltDist.Margin = New System.Windows.Forms.Padding(4)
        Me.txbFcAltDist.MaxLength = 4
        Me.txbFcAltDist.Name = "txbFcAltDist"
        Me.txbFcAltDist.Size = New System.Drawing.Size(60, 30)
        Me.txbFcAltDist.TabIndex = 4
        Me.txbFcAltDist.Text = "100"
        Me.txbFcAltDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bitstream Vera Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Destnation"
        '
        'lbFcFuelBurn
        '
        Me.lbFcFuelBurn.AutoSize = True
        Me.lbFcFuelBurn.Font = New System.Drawing.Font("Bitstream Vera Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFcFuelBurn.Location = New System.Drawing.Point(36, 239)
        Me.lbFcFuelBurn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFcFuelBurn.Name = "lbFcFuelBurn"
        Me.lbFcFuelBurn.Size = New System.Drawing.Size(107, 24)
        Me.lbFcFuelBurn.TabIndex = 7
        Me.lbFcFuelBurn.Text = "Fuel Burn"
        '
        'txbFcFuelBurn
        '
        Me.txbFcFuelBurn.Font = New System.Drawing.Font("basic title font", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFcFuelBurn.Location = New System.Drawing.Point(181, 235)
        Me.txbFcFuelBurn.Margin = New System.Windows.Forms.Padding(4)
        Me.txbFcFuelBurn.MaxLength = 5
        Me.txbFcFuelBurn.Name = "txbFcFuelBurn"
        Me.txbFcFuelBurn.Size = New System.Drawing.Size(72, 30)
        Me.txbFcFuelBurn.TabIndex = 3
        Me.txbFcFuelBurn.Text = "7672"
        Me.txbFcFuelBurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txbFcSpeed
        '
        Me.txbFcSpeed.Font = New System.Drawing.Font("basic title font", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFcSpeed.Location = New System.Drawing.Point(193, 192)
        Me.txbFcSpeed.Margin = New System.Windows.Forms.Padding(4)
        Me.txbFcSpeed.Name = "txbFcSpeed"
        Me.txbFcSpeed.Size = New System.Drawing.Size(60, 30)
        Me.txbFcSpeed.TabIndex = 2
        Me.txbFcSpeed.Text = "540"
        Me.txbFcSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFpSpeed
        '
        Me.lblFpSpeed.AutoSize = True
        Me.lblFpSpeed.Font = New System.Drawing.Font("Bitstream Vera Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFpSpeed.Location = New System.Drawing.Point(36, 196)
        Me.lblFpSpeed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFpSpeed.Name = "lblFpSpeed"
        Me.lblFpSpeed.Size = New System.Drawing.Size(73, 24)
        Me.lblFpSpeed.TabIndex = 2
        Me.lblFpSpeed.Text = "Speed"
        '
        'txbFcDist
        '
        Me.txbFcDist.Font = New System.Drawing.Font("basic title font", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFcDist.Location = New System.Drawing.Point(193, 149)
        Me.txbFcDist.Margin = New System.Windows.Forms.Padding(4)
        Me.txbFcDist.MaxLength = 4
        Me.txbFcDist.Name = "txbFcDist"
        Me.txbFcDist.Size = New System.Drawing.Size(60, 30)
        Me.txbFcDist.TabIndex = 1
        Me.txbFcDist.Text = "1500"
        Me.txbFcDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ErrProMain
        '
        Me.ErrProMain.ContainerControl = Me
        '
        'gpbAcInfo
        '
        Me.gpbAcInfo.BackColor = System.Drawing.Color.Silver
        Me.gpbAcInfo.Controls.Add(Me.lblPtodTimetodest)
        Me.gpbAcInfo.Controls.Add(Me.lblPtodtimetoDesttxt)
        Me.gpbAcInfo.Controls.Add(Me.lblPtodDisttodest)
        Me.gpbAcInfo.Controls.Add(Me.lblAiZFW)
        Me.gpbAcInfo.Controls.Add(Me.lblAiZFWTxt)
        Me.gpbAcInfo.Controls.Add(Me.lblAitotalfuel)
        Me.gpbAcInfo.Controls.Add(Me.Label2)
        Me.gpbAcInfo.Controls.Add(Me.lblAiEndur)
        Me.gpbAcInfo.Controls.Add(Me.lblPtocEta)
        Me.gpbAcInfo.Controls.Add(Me.lblAiRange)
        Me.gpbAcInfo.Controls.Add(Me.lblPtocEtaTxt)
        Me.gpbAcInfo.Controls.Add(Me.lblAiGw)
        Me.gpbAcInfo.Controls.Add(Me.lblAiFuelBun)
        Me.gpbAcInfo.Controls.Add(Me.lblAiMach)
        Me.gpbAcInfo.Controls.Add(Me.lblAiAlt)
        Me.gpbAcInfo.Controls.Add(Me.lblPtocDist)
        Me.gpbAcInfo.Controls.Add(Me.lblAiGndSpd)
        Me.gpbAcInfo.Controls.Add(Me.lblPtodTimetoTodTxt)
        Me.gpbAcInfo.Controls.Add(Me.lblAiTotalFueltx)
        Me.gpbAcInfo.Controls.Add(Me.lblAiEndutx)
        Me.gpbAcInfo.Controls.Add(Me.lblAiRangetx)
        Me.gpbAcInfo.Controls.Add(Me.lblAiGwtx)
        Me.gpbAcInfo.Controls.Add(Me.lblAiGndSpdText)
        Me.gpbAcInfo.Controls.Add(Me.lblAiFuelBurntx)
        Me.gpbAcInfo.Controls.Add(Me.lblAiMachtx)
        Me.gpbAcInfo.Controls.Add(Me.lblAiAlttx)
        Me.gpbAcInfo.Font = New System.Drawing.Font("Air America", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbAcInfo.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.gpbAcInfo.Location = New System.Drawing.Point(7, 4)
        Me.gpbAcInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbAcInfo.Name = "gpbAcInfo"
        Me.gpbAcInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbAcInfo.Size = New System.Drawing.Size(347, 598)
        Me.gpbAcInfo.TabIndex = 3
        Me.gpbAcInfo.TabStop = False
        Me.gpbAcInfo.Text = "Aircraft Info"
        '
        'lblPtodTimetodest
        '
        Me.lblPtodTimetodest.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPtodTimetodest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPtodTimetodest.Font = New System.Drawing.Font("Electronic Highway Sign", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtodTimetodest.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblPtodTimetodest.Location = New System.Drawing.Point(199, 447)
        Me.lblPtodTimetodest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPtodTimetodest.Name = "lblPtodTimetodest"
        Me.lblPtodTimetodest.Size = New System.Drawing.Size(137, 34)
        Me.lblPtodTimetodest.TabIndex = 22
        Me.lblPtodTimetodest.Text = "25:25:00"
        Me.lblPtodTimetodest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPtodtimetoDesttxt
        '
        Me.lblPtodtimetoDesttxt.AutoSize = True
        Me.lblPtodtimetoDesttxt.Font = New System.Drawing.Font("Air America", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtodtimetoDesttxt.Location = New System.Drawing.Point(11, 448)
        Me.lblPtodtimetoDesttxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPtodtimetoDesttxt.Name = "lblPtodtimetoDesttxt"
        Me.lblPtodtimetoDesttxt.Size = New System.Drawing.Size(160, 29)
        Me.lblPtodtimetoDesttxt.TabIndex = 23
        Me.lblPtodtimetoDesttxt.Text = "Time to Destnation"
        '
        'lblPtodDisttodest
        '
        Me.lblPtodDisttodest.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPtodDisttodest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPtodDisttodest.Font = New System.Drawing.Font("Electronic Highway Sign", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtodDisttodest.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblPtodDisttodest.Location = New System.Drawing.Point(229, 410)
        Me.lblPtodDisttodest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPtodDisttodest.Name = "lblPtodDisttodest"
        Me.lblPtodDisttodest.Size = New System.Drawing.Size(107, 34)
        Me.lblPtodDisttodest.TabIndex = 21
        Me.lblPtodDisttodest.Text = "9999.99"
        Me.lblPtodDisttodest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAiZFW
        '
        Me.lblAiZFW.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAiZFW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAiZFW.Font = New System.Drawing.Font("Electronic Highway Sign", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiZFW.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblAiZFW.Location = New System.Drawing.Point(198, 319)
        Me.lblAiZFW.Name = "lblAiZFW"
        Me.lblAiZFW.Size = New System.Drawing.Size(141, 34)
        Me.lblAiZFW.TabIndex = 28
        Me.lblAiZFW.Text = "000000"
        Me.lblAiZFW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAiZFWTxt
        '
        Me.lblAiZFWTxt.AutoSize = True
        Me.lblAiZFWTxt.Font = New System.Drawing.Font("Air America", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiZFWTxt.Location = New System.Drawing.Point(108, 326)
        Me.lblAiZFWTxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAiZFWTxt.Name = "lblAiZFWTxt"
        Me.lblAiZFWTxt.Size = New System.Drawing.Size(42, 29)
        Me.lblAiZFWTxt.TabIndex = 27
        Me.lblAiZFWTxt.Text = "ZFW"
        '
        'lblAitotalfuel
        '
        Me.lblAitotalfuel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAitotalfuel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAitotalfuel.Font = New System.Drawing.Font("Electronic Highway Sign", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAitotalfuel.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblAitotalfuel.Location = New System.Drawing.Point(198, 276)
        Me.lblAitotalfuel.Name = "lblAitotalfuel"
        Me.lblAitotalfuel.Size = New System.Drawing.Size(141, 34)
        Me.lblAitotalfuel.TabIndex = 26
        Me.lblAitotalfuel.Text = "000000"
        Me.lblAitotalfuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Air America", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 410)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 29)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Distance to Destnation"
        '
        'lblAiEndur
        '
        Me.lblAiEndur.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAiEndur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAiEndur.Font = New System.Drawing.Font("Electronic Highway Sign", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiEndur.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblAiEndur.Location = New System.Drawing.Point(199, 231)
        Me.lblAiEndur.Name = "lblAiEndur"
        Me.lblAiEndur.Size = New System.Drawing.Size(141, 34)
        Me.lblAiEndur.TabIndex = 25
        Me.lblAiEndur.Text = "24:24:24"
        Me.lblAiEndur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPtocEta
        '
        Me.lblPtocEta.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPtocEta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPtocEta.Font = New System.Drawing.Font("Electronic Highway Sign", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtocEta.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblPtocEta.Location = New System.Drawing.Point(212, 517)
        Me.lblPtocEta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPtocEta.Name = "lblPtocEta"
        Me.lblPtocEta.Size = New System.Drawing.Size(127, 34)
        Me.lblPtocEta.TabIndex = 19
        Me.lblPtocEta.Text = "10:20:20"
        Me.lblPtocEta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAiRange
        '
        Me.lblAiRange.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAiRange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAiRange.Font = New System.Drawing.Font("Electronic Highway Sign", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiRange.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblAiRange.Location = New System.Drawing.Point(199, 195)
        Me.lblAiRange.Name = "lblAiRange"
        Me.lblAiRange.Size = New System.Drawing.Size(141, 34)
        Me.lblAiRange.TabIndex = 24
        Me.lblAiRange.Text = "1234"
        Me.lblAiRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPtocEtaTxt
        '
        Me.lblPtocEtaTxt.AutoSize = True
        Me.lblPtocEtaTxt.Font = New System.Drawing.Font("Air America", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtocEtaTxt.Location = New System.Drawing.Point(11, 521)
        Me.lblPtocEtaTxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPtocEtaTxt.Name = "lblPtocEtaTxt"
        Me.lblPtocEtaTxt.Size = New System.Drawing.Size(101, 29)
        Me.lblPtocEtaTxt.TabIndex = 18
        Me.lblPtocEtaTxt.Text = "Time to TOD"
        '
        'lblAiGw
        '
        Me.lblAiGw.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAiGw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAiGw.Font = New System.Drawing.Font("Electronic Highway Sign", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiGw.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblAiGw.Location = New System.Drawing.Point(198, 362)
        Me.lblAiGw.Name = "lblAiGw"
        Me.lblAiGw.Size = New System.Drawing.Size(141, 34)
        Me.lblAiGw.TabIndex = 23
        Me.lblAiGw.Text = "000000"
        Me.lblAiGw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAiFuelBun
        '
        Me.lblAiFuelBun.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAiFuelBun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAiFuelBun.Font = New System.Drawing.Font("Electronic Highway Sign", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiFuelBun.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblAiFuelBun.Location = New System.Drawing.Point(199, 162)
        Me.lblAiFuelBun.Name = "lblAiFuelBun"
        Me.lblAiFuelBun.Size = New System.Drawing.Size(141, 34)
        Me.lblAiFuelBun.TabIndex = 22
        Me.lblAiFuelBun.Text = "123456"
        Me.lblAiFuelBun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAiMach
        '
        Me.lblAiMach.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAiMach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAiMach.Font = New System.Drawing.Font("Electronic Highway Sign", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiMach.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblAiMach.Location = New System.Drawing.Point(199, 117)
        Me.lblAiMach.Name = "lblAiMach"
        Me.lblAiMach.Size = New System.Drawing.Size(141, 34)
        Me.lblAiMach.TabIndex = 21
        Me.lblAiMach.Text = ".00"
        Me.lblAiMach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAiAlt
        '
        Me.lblAiAlt.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAiAlt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAiAlt.Font = New System.Drawing.Font("Electronic Highway Sign", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiAlt.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblAiAlt.Location = New System.Drawing.Point(199, 46)
        Me.lblAiAlt.Name = "lblAiAlt"
        Me.lblAiAlt.Size = New System.Drawing.Size(141, 34)
        Me.lblAiAlt.TabIndex = 20
        Me.lblAiAlt.Text = "12345"
        Me.lblAiAlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPtocDist
        '
        Me.lblPtocDist.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPtocDist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPtocDist.Font = New System.Drawing.Font("Electronic Highway Sign", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtocDist.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblPtocDist.Location = New System.Drawing.Point(254, 476)
        Me.lblPtocDist.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPtocDist.Name = "lblPtocDist"
        Me.lblPtocDist.Size = New System.Drawing.Size(85, 34)
        Me.lblPtocDist.TabIndex = 12
        Me.lblPtocDist.Text = "0000"
        Me.lblPtocDist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAiGndSpd
        '
        Me.lblAiGndSpd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAiGndSpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAiGndSpd.Font = New System.Drawing.Font("Electronic Highway Sign", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiGndSpd.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblAiGndSpd.Location = New System.Drawing.Point(199, 82)
        Me.lblAiGndSpd.Name = "lblAiGndSpd"
        Me.lblAiGndSpd.Size = New System.Drawing.Size(141, 34)
        Me.lblAiGndSpd.TabIndex = 19
        Me.lblAiGndSpd.Text = "123"
        Me.lblAiGndSpd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPtodTimetoTodTxt
        '
        Me.lblPtodTimetoTodTxt.AutoSize = True
        Me.lblPtodTimetoTodTxt.Font = New System.Drawing.Font("Air America", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtodTimetoTodTxt.Location = New System.Drawing.Point(11, 482)
        Me.lblPtodTimetoTodTxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPtodTimetoTodTxt.Name = "lblPtodTimetoTodTxt"
        Me.lblPtodTimetoTodTxt.Size = New System.Drawing.Size(134, 29)
        Me.lblPtodTimetoTodTxt.TabIndex = 11
        Me.lblPtodTimetoTodTxt.Text = "Distance to TOD"
        '
        'lblAiTotalFueltx
        '
        Me.lblAiTotalFueltx.AutoSize = True
        Me.lblAiTotalFueltx.Font = New System.Drawing.Font("Air America", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiTotalFueltx.Location = New System.Drawing.Point(8, 276)
        Me.lblAiTotalFueltx.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAiTotalFueltx.Name = "lblAiTotalFueltx"
        Me.lblAiTotalFueltx.Size = New System.Drawing.Size(154, 29)
        Me.lblAiTotalFueltx.TabIndex = 13
        Me.lblAiTotalFueltx.Text = "Total Fuel Weight"
        '
        'lblAiEndutx
        '
        Me.lblAiEndutx.AutoSize = True
        Me.lblAiEndutx.Font = New System.Drawing.Font("Air America", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiEndutx.Location = New System.Drawing.Point(55, 231)
        Me.lblAiEndutx.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAiEndutx.Name = "lblAiEndutx"
        Me.lblAiEndutx.Size = New System.Drawing.Size(96, 29)
        Me.lblAiEndutx.TabIndex = 12
        Me.lblAiEndutx.Text = "Endurance"
        '
        'lblAiRangetx
        '
        Me.lblAiRangetx.AutoSize = True
        Me.lblAiRangetx.Font = New System.Drawing.Font("Air America", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiRangetx.Location = New System.Drawing.Point(106, 200)
        Me.lblAiRangetx.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAiRangetx.Name = "lblAiRangetx"
        Me.lblAiRangetx.Size = New System.Drawing.Size(60, 29)
        Me.lblAiRangetx.TabIndex = 11
        Me.lblAiRangetx.Text = "Range"
        '
        'lblAiGwtx
        '
        Me.lblAiGwtx.AutoSize = True
        Me.lblAiGwtx.Font = New System.Drawing.Font("Air America", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiGwtx.Location = New System.Drawing.Point(42, 363)
        Me.lblAiGwtx.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAiGwtx.Name = "lblAiGwtx"
        Me.lblAiGwtx.Size = New System.Drawing.Size(117, 29)
        Me.lblAiGwtx.TabIndex = 10
        Me.lblAiGwtx.Text = "Gross Weight"
        '
        'lblAiGndSpdText
        '
        Me.lblAiGndSpdText.AutoSize = True
        Me.lblAiGndSpdText.Font = New System.Drawing.Font("Air America", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiGndSpdText.Location = New System.Drawing.Point(13, 88)
        Me.lblAiGndSpdText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAiGndSpdText.Name = "lblAiGndSpdText"
        Me.lblAiGndSpdText.Size = New System.Drawing.Size(119, 29)
        Me.lblAiGndSpdText.TabIndex = 8
        Me.lblAiGndSpdText.Text = "Ground Speed"
        '
        'lblAiFuelBurntx
        '
        Me.lblAiFuelBurntx.AutoSize = True
        Me.lblAiFuelBurntx.Font = New System.Drawing.Font("Air America", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiFuelBurntx.Location = New System.Drawing.Point(69, 166)
        Me.lblAiFuelBurntx.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAiFuelBurntx.Name = "lblAiFuelBurntx"
        Me.lblAiFuelBurntx.Size = New System.Drawing.Size(91, 29)
        Me.lblAiFuelBurntx.TabIndex = 7
        Me.lblAiFuelBurntx.Text = "Fuel Burn"
        '
        'lblAiMachtx
        '
        Me.lblAiMachtx.AutoSize = True
        Me.lblAiMachtx.Font = New System.Drawing.Font("Air America", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiMachtx.Location = New System.Drawing.Point(118, 122)
        Me.lblAiMachtx.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAiMachtx.Name = "lblAiMachtx"
        Me.lblAiMachtx.Size = New System.Drawing.Size(55, 29)
        Me.lblAiMachtx.TabIndex = 2
        Me.lblAiMachtx.Text = "Mach"
        '
        'lblAiAlttx
        '
        Me.lblAiAlttx.AutoSize = True
        Me.lblAiAlttx.Font = New System.Drawing.Font("Air America", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAiAlttx.Location = New System.Drawing.Point(90, 46)
        Me.lblAiAlttx.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAiAlttx.Name = "lblAiAlttx"
        Me.lblAiAlttx.Size = New System.Drawing.Size(79, 29)
        Me.lblAiAlttx.TabIndex = 0
        Me.lblAiAlttx.Text = "Altitude"
        '
        'btnAiDiscon
        '
        Me.btnAiDiscon.BackColor = System.Drawing.Color.DarkRed
        Me.btnAiDiscon.Font = New System.Drawing.Font("basic title font", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAiDiscon.Location = New System.Drawing.Point(746, 631)
        Me.btnAiDiscon.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAiDiscon.Name = "btnAiDiscon"
        Me.btnAiDiscon.Size = New System.Drawing.Size(135, 47)
        Me.btnAiDiscon.TabIndex = 18
        Me.btnAiDiscon.Text = "Disconnect"
        Me.btnAiDiscon.UseVisualStyleBackColor = False
        '
        'btnAiConnect
        '
        Me.btnAiConnect.BackColor = System.Drawing.Color.Green
        Me.btnAiConnect.Font = New System.Drawing.Font("basic title font", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAiConnect.Location = New System.Drawing.Point(894, 631)
        Me.btnAiConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAiConnect.Name = "btnAiConnect"
        Me.btnAiConnect.Size = New System.Drawing.Size(109, 47)
        Me.btnAiConnect.TabIndex = 5
        Me.btnAiConnect.Text = "Connect"
        Me.btnAiConnect.UseVisualStyleBackColor = False
        '
        'tmrOneTic
        '
        Me.tmrOneTic.Interval = 1000
        '
        'gpbPauseTod
        '
        Me.gpbPauseTod.BackColor = System.Drawing.Color.Silver
        Me.gpbPauseTod.Controls.Add(Me.nudPtodDist)
        Me.gpbPauseTod.Controls.Add(Me.btnPtodCalc)
        Me.gpbPauseTod.Controls.Add(Me.txbPtodDest)
        Me.gpbPauseTod.Controls.Add(Me.lblPtodDest)
        Me.gpbPauseTod.Controls.Add(Me.Label8)
        Me.gpbPauseTod.Controls.Add(Me.txbPtodTgtAlt)
        Me.gpbPauseTod.Controls.Add(Me.txbPtodCrzAlt)
        Me.gpbPauseTod.Controls.Add(Me.lblPtodCrzAlt)
        Me.gpbPauseTod.Controls.Add(Me.lblPtodTod)
        Me.gpbPauseTod.Font = New System.Drawing.Font("Air America", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbPauseTod.Location = New System.Drawing.Point(328, 18)
        Me.gpbPauseTod.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbPauseTod.Name = "gpbPauseTod"
        Me.gpbPauseTod.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbPauseTod.Size = New System.Drawing.Size(343, 351)
        Me.gpbPauseTod.TabIndex = 15
        Me.gpbPauseTod.TabStop = False
        Me.gpbPauseTod.Text = "Pause at TOD"
        '
        'nudPtodDist
        '
        Me.nudPtodDist.Font = New System.Drawing.Font("basic title font", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPtodDist.Location = New System.Drawing.Point(215, 245)
        Me.nudPtodDist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudPtodDist.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudPtodDist.Name = "nudPtodDist"
        Me.nudPtodDist.Size = New System.Drawing.Size(120, 31)
        Me.nudPtodDist.TabIndex = 16
        '
        'btnPtodCalc
        '
        Me.btnPtodCalc.Font = New System.Drawing.Font("Bitstream Vera Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPtodCalc.Location = New System.Drawing.Point(107, 185)
        Me.btnPtodCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPtodCalc.Name = "btnPtodCalc"
        Me.btnPtodCalc.Size = New System.Drawing.Size(144, 47)
        Me.btnPtodCalc.TabIndex = 5
        Me.btnPtodCalc.Text = "Calculate"
        Me.btnPtodCalc.UseVisualStyleBackColor = True
        '
        'txbPtodDest
        '
        Me.txbPtodDest.Font = New System.Drawing.Font("basic title font", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPtodDest.Location = New System.Drawing.Point(261, 49)
        Me.txbPtodDest.Margin = New System.Windows.Forms.Padding(4)
        Me.txbPtodDest.MaxLength = 4
        Me.txbPtodDest.Name = "txbPtodDest"
        Me.txbPtodDest.Size = New System.Drawing.Size(72, 30)
        Me.txbPtodDest.TabIndex = 1
        Me.txbPtodDest.Text = "Code"
        Me.txbPtodDest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPtodDest
        '
        Me.lblPtodDest.AutoSize = True
        Me.lblPtodDest.Font = New System.Drawing.Font("Bitstream Vera Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtodDest.Location = New System.Drawing.Point(36, 55)
        Me.lblPtodDest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPtodDest.Name = "lblPtodDest"
        Me.lblPtodDest.Size = New System.Drawing.Size(139, 28)
        Me.lblPtodDest.TabIndex = 8
        Me.lblPtodDest.Text = "Destnation"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bitstream Vera Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 148)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 28)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Target Alt"
        '
        'txbPtodTgtAlt
        '
        Me.txbPtodTgtAlt.Font = New System.Drawing.Font("basic title font", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPtodTgtAlt.Location = New System.Drawing.Point(261, 139)
        Me.txbPtodTgtAlt.Margin = New System.Windows.Forms.Padding(4)
        Me.txbPtodTgtAlt.MaxLength = 5
        Me.txbPtodTgtAlt.Name = "txbPtodTgtAlt"
        Me.txbPtodTgtAlt.Size = New System.Drawing.Size(72, 30)
        Me.txbPtodTgtAlt.TabIndex = 3
        Me.txbPtodTgtAlt.Text = "2500"
        Me.txbPtodTgtAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txbPtodCrzAlt
        '
        Me.txbPtodCrzAlt.Font = New System.Drawing.Font("basic title font", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPtodCrzAlt.Location = New System.Drawing.Point(261, 100)
        Me.txbPtodCrzAlt.Margin = New System.Windows.Forms.Padding(4)
        Me.txbPtodCrzAlt.Name = "txbPtodCrzAlt"
        Me.txbPtodCrzAlt.Size = New System.Drawing.Size(72, 30)
        Me.txbPtodCrzAlt.TabIndex = 2
        Me.txbPtodCrzAlt.Text = "25000"
        Me.txbPtodCrzAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPtodCrzAlt
        '
        Me.lblPtodCrzAlt.AutoSize = True
        Me.lblPtodCrzAlt.Font = New System.Drawing.Font("Bitstream Vera Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtodCrzAlt.Location = New System.Drawing.Point(36, 105)
        Me.lblPtodCrzAlt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPtodCrzAlt.Name = "lblPtodCrzAlt"
        Me.lblPtodCrzAlt.Size = New System.Drawing.Size(126, 28)
        Me.lblPtodCrzAlt.TabIndex = 2
        Me.lblPtodCrzAlt.Text = "Cruise Alt"
        '
        'lblPtodTod
        '
        Me.lblPtodTod.AutoSize = True
        Me.lblPtodTod.Font = New System.Drawing.Font("Bitstream Vera Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtodTod.Location = New System.Drawing.Point(36, 251)
        Me.lblPtodTod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPtodTod.Name = "lblPtodTod"
        Me.lblPtodTod.Size = New System.Drawing.Size(64, 28)
        Me.lblPtodTod.TabIndex = 0
        Me.lblPtodTod.Text = "TOD"
        '
        'ckbPtodArmPtod
        '
        Me.ckbPtodArmPtod.AutoSize = True
        Me.ckbPtodArmPtod.Font = New System.Drawing.Font("Bitstream Vera Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbPtodArmPtod.ForeColor = System.Drawing.Color.DarkRed
        Me.ckbPtodArmPtod.Location = New System.Drawing.Point(748, 684)
        Me.ckbPtodArmPtod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ckbPtodArmPtod.Name = "ckbPtodArmPtod"
        Me.ckbPtodArmPtod.Size = New System.Drawing.Size(252, 32)
        Me.ckbPtodArmPtod.TabIndex = 17
        Me.ckbPtodArmPtod.Text = "Arm Pause at TOD"
        Me.ckbPtodArmPtod.UseVisualStyleBackColor = True
        '
        'btnHanger
        '
        Me.btnHanger.Font = New System.Drawing.Font("Bitstream Vera Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHanger.Location = New System.Drawing.Point(6, 367)
        Me.btnHanger.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHanger.Name = "btnHanger"
        Me.btnHanger.Size = New System.Drawing.Size(163, 57)
        Me.btnHanger.TabIndex = 19
        Me.btnHanger.Text = "Hanger"
        Me.btnHanger.UseVisualStyleBackColor = True
        '
        'lblAsFuelBurn
        '
        Me.lblAsFuelBurn.AutoSize = True
        Me.lblAsFuelBurn.Font = New System.Drawing.Font("Bitstream Vera Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsFuelBurn.Location = New System.Drawing.Point(130, 215)
        Me.lblAsFuelBurn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsFuelBurn.Name = "lblAsFuelBurn"
        Me.lblAsFuelBurn.Size = New System.Drawing.Size(107, 24)
        Me.lblAsFuelBurn.TabIndex = 18
        Me.lblAsFuelBurn.Text = "Fuel Burn"
        '
        'txbAsFuelBurn
        '
        Me.txbAsFuelBurn.Font = New System.Drawing.Font("basic title font", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbAsFuelBurn.Location = New System.Drawing.Point(276, 211)
        Me.txbAsFuelBurn.Margin = New System.Windows.Forms.Padding(4)
        Me.txbAsFuelBurn.MaxLength = 5
        Me.txbAsFuelBurn.Name = "txbAsFuelBurn"
        Me.txbAsFuelBurn.Size = New System.Drawing.Size(72, 30)
        Me.txbAsFuelBurn.TabIndex = 17
        Me.txbAsFuelBurn.Text = "0"
        Me.txbAsFuelBurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txbAsCrzAtl
        '
        Me.txbAsCrzAtl.Font = New System.Drawing.Font("basic title font", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbAsCrzAtl.Location = New System.Drawing.Point(276, 131)
        Me.txbAsCrzAtl.Margin = New System.Windows.Forms.Padding(4)
        Me.txbAsCrzAtl.MaxLength = 4
        Me.txbAsCrzAtl.Name = "txbAsCrzAtl"
        Me.txbAsCrzAtl.Size = New System.Drawing.Size(72, 30)
        Me.txbAsCrzAtl.TabIndex = 2
        Me.txbAsCrzAtl.Text = "12345"
        Me.txbAsCrzAtl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAcGS
        '
        Me.txtAcGS.Font = New System.Drawing.Font("basic title font", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcGS.Location = New System.Drawing.Point(286, 167)
        Me.txtAcGS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAcGS.Name = "txtAcGS"
        Me.txtAcGS.Size = New System.Drawing.Size(60, 30)
        Me.txtAcGS.TabIndex = 15
        Me.txtAcGS.Text = "0"
        Me.txtAcGS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAsCrzAlt
        '
        Me.lblAsCrzAlt.AutoSize = True
        Me.lblAsCrzAlt.Font = New System.Drawing.Font("Bitstream Vera Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsCrzAlt.Location = New System.Drawing.Point(130, 128)
        Me.lblAsCrzAlt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsCrzAlt.Name = "lblAsCrzAlt"
        Me.lblAsCrzAlt.Size = New System.Drawing.Size(107, 24)
        Me.lblAsCrzAlt.TabIndex = 3
        Me.lblAsCrzAlt.Text = "Cruise Alt"
        '
        'lblAsGs
        '
        Me.lblAsGs.AutoSize = True
        Me.lblAsGs.Font = New System.Drawing.Font("Bitstream Vera Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsGs.Location = New System.Drawing.Point(130, 172)
        Me.lblAsGs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsGs.Name = "lblAsGs"
        Me.lblAsGs.Size = New System.Drawing.Size(73, 24)
        Me.lblAsGs.TabIndex = 16
        Me.lblAsGs.Text = "Speed"
        '
        'cmbAsPerfs
        '
        Me.cmbAsPerfs.Font = New System.Drawing.Font("basic title font", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAsPerfs.FormattingEnabled = True
        Me.cmbAsPerfs.Location = New System.Drawing.Point(104, 86)
        Me.cmbAsPerfs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbAsPerfs.Name = "cmbAsPerfs"
        Me.cmbAsPerfs.Size = New System.Drawing.Size(248, 31)
        Me.cmbAsPerfs.TabIndex = 1
        Me.cmbAsPerfs.Text = "Select Performace"
        '
        'cmbAsAircraft
        '
        Me.cmbAsAircraft.Font = New System.Drawing.Font("basic title font", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAsAircraft.FormattingEnabled = True
        Me.cmbAsAircraft.Location = New System.Drawing.Point(134, 49)
        Me.cmbAsAircraft.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbAsAircraft.Name = "cmbAsAircraft"
        Me.cmbAsAircraft.Size = New System.Drawing.Size(219, 31)
        Me.cmbAsAircraft.TabIndex = 0
        Me.cmbAsAircraft.Text = "Select Aircraft"
        '
        'lblAsAircraft
        '
        Me.lblAsAircraft.AutoSize = True
        Me.lblAsAircraft.Font = New System.Drawing.Font("Bitstream Vera Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsAircraft.Location = New System.Drawing.Point(6, 43)
        Me.lblAsAircraft.Name = "lblAsAircraft"
        Me.lblAsAircraft.Size = New System.Drawing.Size(84, 24)
        Me.lblAsAircraft.TabIndex = 0
        Me.lblAsAircraft.Text = "Aircraft"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AircraftToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1475, 28)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AircraftToolStripMenuItem
        '
        Me.AircraftToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HangerToolStripMenuItem, Me.AutoThrottleToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.AircraftToolStripMenuItem.Name = "AircraftToolStripMenuItem"
        Me.AircraftToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.AircraftToolStripMenuItem.Text = "Aircraft"
        '
        'HangerToolStripMenuItem
        '
        Me.HangerToolStripMenuItem.Name = "HangerToolStripMenuItem"
        Me.HangerToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.HangerToolStripMenuItem.Text = "Hanger"
        '
        'AutoThrottleToolStripMenuItem
        '
        Me.AutoThrottleToolStripMenuItem.Name = "AutoThrottleToolStripMenuItem"
        Me.AutoThrottleToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.AutoThrottleToolStripMenuItem.Text = "Auto Throttle"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'tclMain
        '
        Me.tclMain.Controls.Add(Me.tbpAcSel)
        Me.tclMain.Controls.Add(Me.TabPage2)
        Me.tclMain.Controls.Add(Me.TabPage1)
        Me.tclMain.Font = New System.Drawing.Font("Air America", 18.0!)
        Me.tclMain.Location = New System.Drawing.Point(37, 31)
        Me.tclMain.Name = "tclMain"
        Me.tclMain.SelectedIndex = 0
        Me.tclMain.Size = New System.Drawing.Size(679, 682)
        Me.tclMain.TabIndex = 18
        '
        'tbpAcSel
        '
        Me.tbpAcSel.BackColor = System.Drawing.Color.Silver
        Me.tbpAcSel.Controls.Add(Me.btnHanger)
        Me.tbpAcSel.Controls.Add(Me.lblAsFuelBurn)
        Me.tbpAcSel.Controls.Add(Me.lblAsAircraft)
        Me.tbpAcSel.Controls.Add(Me.txbAsFuelBurn)
        Me.tbpAcSel.Controls.Add(Me.cmbAsAircraft)
        Me.tbpAcSel.Controls.Add(Me.txbAsCrzAtl)
        Me.tbpAcSel.Controls.Add(Me.cmbAsPerfs)
        Me.tbpAcSel.Controls.Add(Me.txtAcGS)
        Me.tbpAcSel.Controls.Add(Me.lblAsGs)
        Me.tbpAcSel.Controls.Add(Me.lblAsCrzAlt)
        Me.tbpAcSel.Location = New System.Drawing.Point(4, 45)
        Me.tbpAcSel.Name = "tbpAcSel"
        Me.tbpAcSel.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAcSel.Size = New System.Drawing.Size(671, 633)
        Me.tbpAcSel.TabIndex = 0
        Me.tbpAcSel.Text = "Aircraft Selctor"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.lblBarberpoleIasData)
        Me.TabPage2.Controls.Add(Me.lblInterval)
        Me.TabPage2.Controls.Add(Me.nudCylie)
        Me.TabPage2.Controls.Add(Me.gbxSpeedHold)
        Me.TabPage2.Controls.Add(Me.gpbAcInfo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 45)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(671, 633)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Flight Info"
        '
        'lblBarberpoleIasData
        '
        Me.lblBarberpoleIasData.AutoSize = True
        Me.lblBarberpoleIasData.Location = New System.Drawing.Point(592, 487)
        Me.lblBarberpoleIasData.Name = "lblBarberpoleIasData"
        Me.lblBarberpoleIasData.Size = New System.Drawing.Size(58, 36)
        Me.lblBarberpoleIasData.TabIndex = 16
        Me.lblBarberpoleIasData.Text = "1000"
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(361, 482)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(160, 36)
        Me.lblInterval.TabIndex = 22
        Me.lblInterval.Text = "Cycle Interval"
        '
        'nudCylie
        '
        Me.nudCylie.Location = New System.Drawing.Point(361, 521)
        Me.nudCylie.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudCylie.Name = "nudCylie"
        Me.nudCylie.Size = New System.Drawing.Size(120, 43)
        Me.nudCylie.TabIndex = 21
        Me.nudCylie.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'gbxSpeedHold
        '
        Me.gbxSpeedHold.BackColor = System.Drawing.Color.Silver
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
        Me.gbxSpeedHold.Font = New System.Drawing.Font("Air America", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxSpeedHold.Location = New System.Drawing.Point(371, 17)
        Me.gbxSpeedHold.Name = "gbxSpeedHold"
        Me.gbxSpeedHold.Size = New System.Drawing.Size(250, 453)
        Me.gbxSpeedHold.TabIndex = 20
        Me.gbxSpeedHold.TabStop = False
        Me.gbxSpeedHold.Text = "Speed Hold"
        '
        'cxbMaxSpeed
        '
        Me.cxbMaxSpeed.AutoSize = True
        Me.cxbMaxSpeed.Location = New System.Drawing.Point(119, 250)
        Me.cxbMaxSpeed.Name = "cxbMaxSpeed"
        Me.cxbMaxSpeed.Size = New System.Drawing.Size(130, 33)
        Me.cxbMaxSpeed.TabIndex = 5
        Me.cxbMaxSpeed.Text = "Max Speed -"
        Me.cxbMaxSpeed.UseVisualStyleBackColor = True
        '
        'CbxHoldMach
        '
        Me.CbxHoldMach.AutoSize = True
        Me.CbxHoldMach.Location = New System.Drawing.Point(119, 293)
        Me.CbxHoldMach.Name = "CbxHoldMach"
        Me.CbxHoldMach.Size = New System.Drawing.Size(118, 33)
        Me.CbxHoldMach.TabIndex = 4
        Me.CbxHoldMach.Text = "Hold Mach"
        Me.CbxHoldMach.UseVisualStyleBackColor = True
        '
        'bthFsuipcASTEngaged
        '
        Me.bthFsuipcASTEngaged.BackColor = System.Drawing.Color.DarkRed
        Me.bthFsuipcASTEngaged.Enabled = False
        Me.bthFsuipcASTEngaged.Location = New System.Drawing.Point(106, 378)
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
        Me.numAsD.Location = New System.Drawing.Point(6, 348)
        Me.numAsD.Name = "numAsD"
        Me.numAsD.Size = New System.Drawing.Size(96, 35)
        Me.numAsD.TabIndex = 15
        '
        'lblAsIas
        '
        Me.lblAsIas.AutoSize = True
        Me.lblAsIas.Location = New System.Drawing.Point(75, 57)
        Me.lblAsIas.Name = "lblAsIas"
        Me.lblAsIas.Size = New System.Drawing.Size(157, 29)
        Me.lblAsIas.TabIndex = 3
        Me.lblAsIas.Text = "Indcated Airspeed"
        '
        'numAsI
        '
        Me.numAsI.DecimalPlaces = 4
        Me.numAsI.Increment = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.numAsI.Location = New System.Drawing.Point(6, 306)
        Me.numAsI.Name = "numAsI"
        Me.numAsI.Size = New System.Drawing.Size(96, 35)
        Me.numAsI.TabIndex = 14
        Me.numAsI.Value = New Decimal(New Integer() {6, 0, 0, 196608})
        '
        'numApIas
        '
        Me.numApIas.Font = New System.Drawing.Font("Yu Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numApIas.Location = New System.Drawing.Point(9, 57)
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
        Me.numAsP.Location = New System.Drawing.Point(7, 256)
        Me.numAsP.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.numAsP.Name = "numAsP"
        Me.numAsP.Size = New System.Drawing.Size(96, 35)
        Me.numAsP.TabIndex = 12
        Me.numAsP.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'lblAsMachNum
        '
        Me.lblAsMachNum.AutoSize = True
        Me.lblAsMachNum.Location = New System.Drawing.Point(93, 114)
        Me.lblAsMachNum.Name = "lblAsMachNum"
        Me.lblAsMachNum.Size = New System.Drawing.Size(120, 29)
        Me.lblAsMachNum.TabIndex = 1
        Me.lblAsMachNum.Text = "Mach Number"
        '
        'numApMach
        '
        Me.numApMach.DecimalPlaces = 2
        Me.numApMach.Font = New System.Drawing.Font("Yu Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numApMach.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numApMach.Location = New System.Drawing.Point(9, 110)
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
        Me.rdbFsuipcATS.Location = New System.Drawing.Point(6, 212)
        Me.rdbFsuipcATS.Name = "rdbFsuipcATS"
        Me.rdbFsuipcATS.Size = New System.Drawing.Size(237, 33)
        Me.rdbFsuipcATS.TabIndex = 7
        Me.rdbFsuipcATS.Text = "Use Program Auto Thrust"
        Me.rdbFsuipcATS.UseVisualStyleBackColor = True
        '
        'rdbFsATS
        '
        Me.rdbFsATS.AutoSize = True
        Me.rdbFsATS.Checked = True
        Me.rdbFsATS.Location = New System.Drawing.Point(7, 174)
        Me.rdbFsATS.Name = "rdbFsATS"
        Me.rdbFsATS.Size = New System.Drawing.Size(184, 33)
        Me.rdbFsATS.TabIndex = 6
        Me.rdbFsATS.TabStop = True
        Me.rdbFsATS.Text = "Use FS Auto Thrust"
        Me.rdbFsATS.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gpbFuelCalc)
        Me.TabPage1.Controls.Add(Me.gpbPauseTod)
        Me.TabPage1.Location = New System.Drawing.Point(4, 45)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(671, 633)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Flight Planner"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GpbAcSeletor
        '
        Me.GpbAcSeletor.BackColor = System.Drawing.Color.Silver
        Me.GpbAcSeletor.Font = New System.Drawing.Font("Air America", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpbAcSeletor.Location = New System.Drawing.Point(835, 22)
        Me.GpbAcSeletor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GpbAcSeletor.Name = "GpbAcSeletor"
        Me.GpbAcSeletor.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GpbAcSeletor.Size = New System.Drawing.Size(218, 39)
        Me.GpbAcSeletor.TabIndex = 16
        Me.GpbAcSeletor.TabStop = False
        Me.GpbAcSeletor.Text = "Aircraft Selector"
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
        'stsThrottle
        '
        Me.stsThrottle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.stsThrottle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslThrottletxt, Me.tslTHrottle, Me.tspThrottle, Me.tslThrottleErr, Me.tslIsa, Me.tslFine, Me.tslP})
        Me.stsThrottle.Location = New System.Drawing.Point(0, 722)
        Me.stsThrottle.Name = "stsThrottle"
        Me.stsThrottle.Size = New System.Drawing.Size(1475, 25)
        Me.stsThrottle.TabIndex = 19
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1475, 747)
        Me.Controls.Add(Me.stsThrottle)
        Me.Controls.Add(Me.ckbPtodArmPtod)
        Me.Controls.Add(Me.tclMain)
        Me.Controls.Add(Me.GpbAcSeletor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnAiDiscon)
        Me.Controls.Add(Me.btnAiConnect)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "Flight Planner "
        Me.gpbFuelCalc.ResumeLayout(False)
        Me.gpbFuelCalc.PerformLayout()
        CType(Me.ErrProMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbAcInfo.ResumeLayout(False)
        Me.gpbAcInfo.PerformLayout()
        Me.gpbPauseTod.ResumeLayout(False)
        Me.gpbPauseTod.PerformLayout()
        CType(Me.nudPtodDist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tclMain.ResumeLayout(False)
        Me.tbpAcSel.ResumeLayout(False)
        Me.tbpAcSel.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.nudCylie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxSpeedHold.ResumeLayout(False)
        Me.gbxSpeedHold.PerformLayout()
        CType(Me.numAsD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAsI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numApIas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAsP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numApMach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.stsThrottle.ResumeLayout(False)
        Me.stsThrottle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFpDistance As Label
    Friend WithEvents gpbFuelCalc As GroupBox
    Friend WithEvents lblFpSpeed As Label
    Friend WithEvents txbFcDist As TextBox
    Friend WithEvents lbFcFuelBurn As Label
    Friend WithEvents txbFcDest As TextBox
    Friend WithEvents txbFcFuelBurn As TextBox
    Friend WithEvents txbFcSpeed As TextBox
    Friend WithEvents btnFcCalc As Button
    Friend WithEvents lblFcEte As Label
    Friend WithEvents lblFcEteTxt As Label
    Friend WithEvents lblFcFuelReq As Label
    Friend WithEvents lblFcFuelReqTxt As Label
    Friend WithEvents lblFcAltDist As Label
    Friend WithEvents txbFcAltDist As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrProMain As ErrorProvider
    Friend WithEvents gpbAcInfo As GroupBox
    Friend WithEvents btnAiConnect As Button
    Friend WithEvents lblAiTotalFueltx As Label
    Friend WithEvents lblAiEndutx As Label
    Friend WithEvents lblAiRangetx As Label
    Friend WithEvents lblAiGwtx As Label
    Friend WithEvents lblAiGndSpdText As Label
    Friend WithEvents lblAiFuelBurntx As Label
    Friend WithEvents lblAiMachtx As Label
    Friend WithEvents lblAiAlttx As Label
    Friend WithEvents tmrOneTic As Timer
    Friend WithEvents btnAiDiscon As Button
    Friend WithEvents gpbPauseTod As GroupBox
    Friend WithEvents btnPtodCalc As Button
    Friend WithEvents lblPtocDist As Label
    Friend WithEvents lblPtodTimetoTodTxt As Label
    Friend WithEvents txbPtodDest As TextBox
    Friend WithEvents lblPtodDest As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txbPtodTgtAlt As TextBox
    Friend WithEvents txbPtodCrzAlt As TextBox
    Friend WithEvents lblPtodCrzAlt As Label
    Friend WithEvents lblPtodTod As Label
    Friend WithEvents nudPtodDist As NumericUpDown
    Friend WithEvents ckbPtodArmPtod As CheckBox
    Friend WithEvents lblPtocEta As Label
    Friend WithEvents lblPtocEtaTxt As Label
    Friend WithEvents lblAiGndSpd As Label
    Friend WithEvents lblAiAlt As Label
    Friend WithEvents lblAiMach As Label
    Friend WithEvents lblAitotalfuel As Label
    Friend WithEvents lblAiEndur As Label
    Friend WithEvents lblAiRange As Label
    Friend WithEvents lblAiGw As Label
    Friend WithEvents lblAiFuelBun As Label
    Friend WithEvents cmbAsAircraft As ComboBox
    Friend WithEvents lblAsAircraft As Label
    Friend WithEvents lblPtodtimetoDesttxt As Label
    Friend WithEvents lblPtodTimetodest As Label
    Friend WithEvents lblPtodDisttodest As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAiZFW As Label
    Friend WithEvents lblAiZFWTxt As Label
    Friend WithEvents cmbAsPerfs As ComboBox
    Friend WithEvents lblAsFuelBurn As Label
    Friend WithEvents txbAsFuelBurn As TextBox
    Friend WithEvents txbAsCrzAtl As TextBox
    Friend WithEvents txtAcGS As TextBox
    Friend WithEvents lblAsCrzAlt As Label
    Friend WithEvents lblAsGs As Label
    Friend WithEvents btnHanger As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AircraftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HangerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoThrottleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tclMain As TabControl
    Friend WithEvents tbpAcSel As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GpbAcSeletor As GroupBox
    Friend WithEvents lblInterval As Label
    Friend WithEvents nudCylie As NumericUpDown
    Friend WithEvents gbxSpeedHold As GroupBox
    Friend WithEvents lblBarberpoleIasData As Label
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
    Friend WithEvents TmrThrPV As Timer
    Friend WithEvents tmrThrPIDCntl As Timer
    Friend WithEvents machUpdate As Timer
    Friend WithEvents tmrMaxSpeed As Timer
    Friend WithEvents TmrasPV As Timer
    Friend WithEvents stsThrottle As StatusStrip
    Friend WithEvents tslThrottletxt As ToolStripStatusLabel
    Friend WithEvents tslTHrottle As ToolStripStatusLabel
    Friend WithEvents tspThrottle As ToolStripProgressBar
    Friend WithEvents tslThrottleErr As ToolStripStatusLabel
    Friend WithEvents tslIsa As ToolStripStatusLabel
    Friend WithEvents tslFine As ToolStripStatusLabel
    Friend WithEvents tslP As ToolStripStatusLabel
    Friend WithEvents tmrDataUpdate As Timer
End Class
