<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHanger
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
        Me.btnAddAc = New System.Windows.Forms.Button()
        Me.lblType = New System.Windows.Forms.Label()
        Me.txbPerfName = New System.Windows.Forms.TextBox()
        Me.lblAlt = New System.Windows.Forms.Label()
        Me.txbCrzAlt = New System.Windows.Forms.TextBox()
        Me.txbSpeed = New System.Windows.Forms.TextBox()
        Me.lblGs = New System.Windows.Forms.Label()
        Me.lbxPerfs = New System.Windows.Forms.ListBox()
        Me.txbFuelBurn = New System.Windows.Forms.TextBox()
        Me.lblFuelBurn = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lblPerfName = New System.Windows.Forms.Label()
        Me.btnAddPerf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddAc
        '
        Me.btnAddAc.Location = New System.Drawing.Point(237, 444)
        Me.btnAddAc.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAddAc.Name = "btnAddAc"
        Me.btnAddAc.Size = New System.Drawing.Size(131, 82)
        Me.btnAddAc.TabIndex = 5
        Me.btnAddAc.Text = "Add Aircraft"
        Me.btnAddAc.UseVisualStyleBackColor = True
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(126, 140)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(71, 28)
        Me.lblType.TabIndex = 1
        Me.lblType.Text = "Type"
        '
        'txbPerfName
        '
        Me.txbPerfName.Location = New System.Drawing.Point(823, 222)
        Me.txbPerfName.Name = "txbPerfName"
        Me.txbPerfName.Size = New System.Drawing.Size(120, 34)
        Me.txbPerfName.TabIndex = 2
        '
        'lblAlt
        '
        Me.lblAlt.AutoSize = True
        Me.lblAlt.Location = New System.Drawing.Point(71, 188)
        Me.lblAlt.Name = "lblAlt"
        Me.lblAlt.Size = New System.Drawing.Size(126, 28)
        Me.lblAlt.TabIndex = 3
        Me.lblAlt.Text = "Cruise Alt"
        '
        'txbCrzAlt
        '
        Me.txbCrzAlt.Location = New System.Drawing.Point(237, 185)
        Me.txbCrzAlt.Name = "txbCrzAlt"
        Me.txbCrzAlt.Size = New System.Drawing.Size(100, 34)
        Me.txbCrzAlt.TabIndex = 1
        '
        'txbSpeed
        '
        Me.txbSpeed.Location = New System.Drawing.Point(823, 274)
        Me.txbSpeed.Name = "txbSpeed"
        Me.txbSpeed.Size = New System.Drawing.Size(120, 34)
        Me.txbSpeed.TabIndex = 3
        '
        'lblGs
        '
        Me.lblGs.AutoSize = True
        Me.lblGs.Location = New System.Drawing.Point(708, 280)
        Me.lblGs.Name = "lblGs"
        Me.lblGs.Size = New System.Drawing.Size(85, 28)
        Me.lblGs.TabIndex = 5
        Me.lblGs.Text = "Speed"
        '
        'lbxPerfs
        '
        Me.lbxPerfs.FormattingEnabled = True
        Me.lbxPerfs.ItemHeight = 26
        Me.lbxPerfs.Location = New System.Drawing.Point(823, 134)
        Me.lbxPerfs.Name = "lbxPerfs"
        Me.lbxPerfs.Size = New System.Drawing.Size(120, 82)
        Me.lbxPerfs.TabIndex = 7
        '
        'txbFuelBurn
        '
        Me.txbFuelBurn.Location = New System.Drawing.Point(823, 324)
        Me.txbFuelBurn.Name = "txbFuelBurn"
        Me.txbFuelBurn.Size = New System.Drawing.Size(120, 34)
        Me.txbFuelBurn.TabIndex = 4
        '
        'lblFuelBurn
        '
        Me.lblFuelBurn.AutoSize = True
        Me.lblFuelBurn.Location = New System.Drawing.Point(670, 330)
        Me.lblFuelBurn.Name = "lblFuelBurn"
        Me.lblFuelBurn.Size = New System.Drawing.Size(123, 28)
        Me.lblFuelBurn.TabIndex = 8
        Me.lblFuelBurn.Text = "Fuel Flow"
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(237, 134)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(209, 34)
        Me.cmbType.TabIndex = 0
        Me.cmbType.Text = "Seclect Aircraft"
        '
        'lblPerfName
        '
        Me.lblPerfName.AutoSize = True
        Me.lblPerfName.Location = New System.Drawing.Point(657, 225)
        Me.lblPerfName.Name = "lblPerfName"
        Me.lblPerfName.Size = New System.Drawing.Size(136, 28)
        Me.lblPerfName.TabIndex = 9
        Me.lblPerfName.Text = "Perf Name"
        '
        'btnAddPerf
        '
        Me.btnAddPerf.Location = New System.Drawing.Point(662, 444)
        Me.btnAddPerf.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAddPerf.Name = "btnAddPerf"
        Me.btnAddPerf.Size = New System.Drawing.Size(131, 82)
        Me.btnAddPerf.TabIndex = 10
        Me.btnAddPerf.Text = "Add Perf"
        Me.btnAddPerf.UseVisualStyleBackColor = True
        '
        'frmHanger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 731)
        Me.Controls.Add(Me.btnAddPerf)
        Me.Controls.Add(Me.lblPerfName)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.txbFuelBurn)
        Me.Controls.Add(Me.lblFuelBurn)
        Me.Controls.Add(Me.lbxPerfs)
        Me.Controls.Add(Me.txbSpeed)
        Me.Controls.Add(Me.lblGs)
        Me.Controls.Add(Me.txbCrzAlt)
        Me.Controls.Add(Me.lblAlt)
        Me.Controls.Add(Me.txbPerfName)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.btnAddAc)
        Me.Font = New System.Drawing.Font("Bitstream Vera Sans", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmHanger"
        Me.Text = "Hanger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddAc As Button
    Friend WithEvents lblType As Label
    Friend WithEvents txbPerfName As TextBox
    Friend WithEvents lblAlt As Label
    Friend WithEvents txbCrzAlt As TextBox
    Friend WithEvents txbSpeed As TextBox
    Friend WithEvents lblGs As Label
    Friend WithEvents lbxPerfs As ListBox
    Friend WithEvents txbFuelBurn As TextBox
    Friend WithEvents lblFuelBurn As Label
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents lblPerfName As Label
    Friend WithEvents btnAddPerf As Button
End Class
