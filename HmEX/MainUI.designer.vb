<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainUI
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainUI))
        Me.LsvProfile = New System.Windows.Forms.ListView()
        Me.ClhEnabled = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhProfileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhVideoResolution = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhVideoCodec = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhVideoBitrate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAudioCoding = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAudioBitrate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhEncrypt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhOptions = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LblProfiles = New System.Windows.Forms.Label()
        Me.ChkEnabled = New System.Windows.Forms.CheckBox()
        Me.LblProfileName = New System.Windows.Forms.Label()
        Me.TxtVResolution = New System.Windows.Forms.TextBox()
        Me.CboVCoding = New System.Windows.Forms.ComboBox()
        Me.TxtVBitrate = New System.Windows.Forms.TextBox()
        Me.CboACoding = New System.Windows.Forms.ComboBox()
        Me.TxtABitrate = New System.Windows.Forms.TextBox()
        Me.ChkEncryption = New System.Windows.Forms.CheckBox()
        Me.TxtOptionsInput = New System.Windows.Forms.TextBox()
        Me.LblOptions = New System.Windows.Forms.Label()
        Me.LblWatermark = New System.Windows.Forms.Label()
        Me.ChkWatermarkReverse = New System.Windows.Forms.CheckBox()
        Me.LblCoordinates = New System.Windows.Forms.Label()
        Me.TxtWatermarkC = New System.Windows.Forms.TextBox()
        Me.BtnWatermarkChoose = New System.Windows.Forms.Button()
        Me.BtnWatermarkAdd = New System.Windows.Forms.Button()
        Me.LblTasks = New System.Windows.Forms.Label()
        Me.LblVideoInput = New System.Windows.Forms.Label()
        Me.LblOutputFolder = New System.Windows.Forms.Label()
        Me.TxtInputPath = New System.Windows.Forms.TextBox()
        Me.BtnInputBrowse = New System.Windows.Forms.Button()
        Me.BtnOutputBrowse = New System.Windows.Forms.Button()
        Me.TxtOutputPath = New System.Windows.Forms.TextBox()
        Me.BtnQueue = New System.Windows.Forms.Button()
        Me.BtnUpdateList = New System.Windows.Forms.Button()
        Me.BtnSaveList = New System.Windows.Forms.Button()
        Me.OfdInput = New System.Windows.Forms.OpenFileDialog()
        Me.FbdOutput = New System.Windows.Forms.FolderBrowserDialog()
        Me.VideoWorker = New System.ComponentModel.BackgroundWorker()
        Me.SegWorker = New System.ComponentModel.BackgroundWorker()
        Me.BtnManageProfile = New System.Windows.Forms.Button()
        Me.BtnAbout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LsvProfile
        '
        Me.LsvProfile.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClhEnabled, Me.ClhProfileName, Me.ClhVideoResolution, Me.ClhVideoCodec, Me.ClhVideoBitrate, Me.ClhAudioCoding, Me.ClhAudioBitrate, Me.ClhEncrypt, Me.ClhOptions})
        Me.LsvProfile.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LsvProfile.FullRowSelect = True
        Me.LsvProfile.HideSelection = False
        Me.LsvProfile.Location = New System.Drawing.Point(12, 49)
        Me.LsvProfile.MultiSelect = False
        Me.LsvProfile.Name = "LsvProfile"
        Me.LsvProfile.Size = New System.Drawing.Size(760, 169)
        Me.LsvProfile.TabIndex = 10
        Me.LsvProfile.UseCompatibleStateImageBehavior = False
        Me.LsvProfile.View = System.Windows.Forms.View.Details
        '
        'ClhEnabled
        '
        Me.ClhEnabled.Text = "ENBL"
        Me.ClhEnabled.Width = 50
        '
        'ClhProfileName
        '
        Me.ClhProfileName.Text = "Profile"
        '
        'ClhVideoResolution
        '
        Me.ClhVideoResolution.Text = "V.Resolution"
        Me.ClhVideoResolution.Width = 100
        '
        'ClhVideoCodec
        '
        Me.ClhVideoCodec.Text = "V.Codec"
        Me.ClhVideoCodec.Width = 90
        '
        'ClhVideoBitrate
        '
        Me.ClhVideoBitrate.Text = "V.Bitrate"
        Me.ClhVideoBitrate.Width = 90
        '
        'ClhAudioCoding
        '
        Me.ClhAudioCoding.Text = "A.Coding"
        Me.ClhAudioCoding.Width = 75
        '
        'ClhAudioBitrate
        '
        Me.ClhAudioBitrate.Text = "A.Bitrate"
        Me.ClhAudioBitrate.Width = 90
        '
        'ClhEncrypt
        '
        Me.ClhEncrypt.Text = "ENC"
        Me.ClhEncrypt.Width = 50
        '
        'ClhOptions
        '
        Me.ClhOptions.Text = "Options"
        Me.ClhOptions.Width = 150
        '
        'LblProfiles
        '
        Me.LblProfiles.AutoSize = True
        Me.LblProfiles.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblProfiles.Location = New System.Drawing.Point(8, 14)
        Me.LblProfiles.Name = "LblProfiles"
        Me.LblProfiles.Size = New System.Drawing.Size(72, 22)
        Me.LblProfiles.TabIndex = 11
        Me.LblProfiles.Text = "Profiles"
        '
        'ChkEnabled
        '
        Me.ChkEnabled.AutoSize = True
        Me.ChkEnabled.Location = New System.Drawing.Point(28, 233)
        Me.ChkEnabled.Name = "ChkEnabled"
        Me.ChkEnabled.Size = New System.Drawing.Size(15, 14)
        Me.ChkEnabled.TabIndex = 12
        Me.ChkEnabled.UseVisualStyleBackColor = True
        '
        'LblProfileName
        '
        Me.LblProfileName.AutoSize = True
        Me.LblProfileName.Location = New System.Drawing.Point(66, 229)
        Me.LblProfileName.Name = "LblProfileName"
        Me.LblProfileName.Size = New System.Drawing.Size(50, 21)
        Me.LblProfileName.TabIndex = 13
        Me.LblProfileName.Text = "        "
        '
        'TxtVResolution
        '
        Me.TxtVResolution.Location = New System.Drawing.Point(123, 226)
        Me.TxtVResolution.Name = "TxtVResolution"
        Me.TxtVResolution.Size = New System.Drawing.Size(95, 29)
        Me.TxtVResolution.TabIndex = 14
        '
        'CboVCoding
        '
        Me.CboVCoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboVCoding.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CboVCoding.FormattingEnabled = True
        Me.CboVCoding.Items.AddRange(New Object() {"x264", "h264_qsv", "h264_nvenc", "x265", "h265_qsv", "h265_nvenc"})
        Me.CboVCoding.Location = New System.Drawing.Point(224, 226)
        Me.CboVCoding.Name = "CboVCoding"
        Me.CboVCoding.Size = New System.Drawing.Size(85, 28)
        Me.CboVCoding.TabIndex = 15
        '
        'TxtVBitrate
        '
        Me.TxtVBitrate.Location = New System.Drawing.Point(315, 226)
        Me.TxtVBitrate.Name = "TxtVBitrate"
        Me.TxtVBitrate.Size = New System.Drawing.Size(85, 29)
        Me.TxtVBitrate.TabIndex = 16
        '
        'CboACoding
        '
        Me.CboACoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboACoding.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CboACoding.FormattingEnabled = True
        Me.CboACoding.Items.AddRange(New Object() {"AAC"})
        Me.CboACoding.Location = New System.Drawing.Point(406, 226)
        Me.CboACoding.Name = "CboACoding"
        Me.CboACoding.Size = New System.Drawing.Size(70, 28)
        Me.CboACoding.TabIndex = 17
        '
        'TxtABitrate
        '
        Me.TxtABitrate.Location = New System.Drawing.Point(482, 226)
        Me.TxtABitrate.Name = "TxtABitrate"
        Me.TxtABitrate.Size = New System.Drawing.Size(78, 29)
        Me.TxtABitrate.TabIndex = 18
        '
        'ChkEncryption
        '
        Me.ChkEncryption.AutoSize = True
        Me.ChkEncryption.Location = New System.Drawing.Point(576, 233)
        Me.ChkEncryption.Name = "ChkEncryption"
        Me.ChkEncryption.Size = New System.Drawing.Size(15, 14)
        Me.ChkEncryption.TabIndex = 19
        Me.ChkEncryption.UseVisualStyleBackColor = True
        '
        'TxtOptionsInput
        '
        Me.TxtOptionsInput.Location = New System.Drawing.Point(88, 268)
        Me.TxtOptionsInput.Multiline = True
        Me.TxtOptionsInput.Name = "TxtOptionsInput"
        Me.TxtOptionsInput.Size = New System.Drawing.Size(684, 91)
        Me.TxtOptionsInput.TabIndex = 43
        '
        'LblOptions
        '
        Me.LblOptions.AutoSize = True
        Me.LblOptions.Location = New System.Drawing.Point(8, 268)
        Me.LblOptions.Name = "LblOptions"
        Me.LblOptions.Size = New System.Drawing.Size(74, 21)
        Me.LblOptions.TabIndex = 24
        Me.LblOptions.Text = "Options:"
        '
        'LblWatermark
        '
        Me.LblWatermark.AutoSize = True
        Me.LblWatermark.Location = New System.Drawing.Point(8, 370)
        Me.LblWatermark.Name = "LblWatermark"
        Me.LblWatermark.Size = New System.Drawing.Size(99, 21)
        Me.LblWatermark.TabIndex = 25
        Me.LblWatermark.Text = "Watermark:"
        '
        'ChkWatermarkReverse
        '
        Me.ChkWatermarkReverse.AutoSize = True
        Me.ChkWatermarkReverse.Location = New System.Drawing.Point(118, 370)
        Me.ChkWatermarkReverse.Name = "ChkWatermarkReverse"
        Me.ChkWatermarkReverse.Size = New System.Drawing.Size(87, 25)
        Me.ChkWatermarkReverse.TabIndex = 45
        Me.ChkWatermarkReverse.Text = "Reverse"
        Me.ChkWatermarkReverse.UseVisualStyleBackColor = True
        '
        'LblCoordinates
        '
        Me.LblCoordinates.AutoSize = True
        Me.LblCoordinates.Location = New System.Drawing.Point(238, 371)
        Me.LblCoordinates.Name = "LblCoordinates"
        Me.LblCoordinates.Size = New System.Drawing.Size(106, 21)
        Me.LblCoordinates.TabIndex = 27
        Me.LblCoordinates.Text = "Coordinates:"
        '
        'TxtWatermarkC
        '
        Me.TxtWatermarkC.Location = New System.Drawing.Point(351, 368)
        Me.TxtWatermarkC.Name = "TxtWatermarkC"
        Me.TxtWatermarkC.Size = New System.Drawing.Size(206, 29)
        Me.TxtWatermarkC.TabIndex = 47
        Me.TxtWatermarkC.Text = "0:0"
        '
        'BtnWatermarkChoose
        '
        Me.BtnWatermarkChoose.Location = New System.Drawing.Point(617, 368)
        Me.BtnWatermarkChoose.Name = "BtnWatermarkChoose"
        Me.BtnWatermarkChoose.Size = New System.Drawing.Size(82, 29)
        Me.BtnWatermarkChoose.TabIndex = 51
        Me.BtnWatermarkChoose.Text = "Choose"
        Me.BtnWatermarkChoose.UseVisualStyleBackColor = True
        '
        'BtnWatermarkAdd
        '
        Me.BtnWatermarkAdd.Location = New System.Drawing.Point(705, 368)
        Me.BtnWatermarkAdd.Name = "BtnWatermarkAdd"
        Me.BtnWatermarkAdd.Size = New System.Drawing.Size(67, 29)
        Me.BtnWatermarkAdd.TabIndex = 53
        Me.BtnWatermarkAdd.Text = "Add"
        Me.BtnWatermarkAdd.UseVisualStyleBackColor = True
        '
        'LblTasks
        '
        Me.LblTasks.AutoSize = True
        Me.LblTasks.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblTasks.Location = New System.Drawing.Point(8, 441)
        Me.LblTasks.Name = "LblTasks"
        Me.LblTasks.Size = New System.Drawing.Size(55, 22)
        Me.LblTasks.TabIndex = 31
        Me.LblTasks.Text = "Tasks"
        '
        'LblVideoInput
        '
        Me.LblVideoInput.AutoSize = True
        Me.LblVideoInput.Location = New System.Drawing.Point(8, 479)
        Me.LblVideoInput.Name = "LblVideoInput"
        Me.LblVideoInput.Size = New System.Drawing.Size(104, 21)
        Me.LblVideoInput.TabIndex = 32
        Me.LblVideoInput.Text = "Video Input:"
        '
        'LblOutputFolder
        '
        Me.LblOutputFolder.AutoSize = True
        Me.LblOutputFolder.Location = New System.Drawing.Point(8, 517)
        Me.LblOutputFolder.Name = "LblOutputFolder"
        Me.LblOutputFolder.Size = New System.Drawing.Size(122, 21)
        Me.LblOutputFolder.TabIndex = 33
        Me.LblOutputFolder.Text = "Output Folder:"
        '
        'TxtInputPath
        '
        Me.TxtInputPath.Location = New System.Drawing.Point(136, 476)
        Me.TxtInputPath.Name = "TxtInputPath"
        Me.TxtInputPath.Size = New System.Drawing.Size(503, 29)
        Me.TxtInputPath.TabIndex = 61
        '
        'BtnInputBrowse
        '
        Me.BtnInputBrowse.Location = New System.Drawing.Point(645, 476)
        Me.BtnInputBrowse.Name = "BtnInputBrowse"
        Me.BtnInputBrowse.Size = New System.Drawing.Size(30, 29)
        Me.BtnInputBrowse.TabIndex = 63
        Me.BtnInputBrowse.Text = "..."
        Me.BtnInputBrowse.UseVisualStyleBackColor = True
        '
        'BtnOutputBrowse
        '
        Me.BtnOutputBrowse.Location = New System.Drawing.Point(645, 514)
        Me.BtnOutputBrowse.Name = "BtnOutputBrowse"
        Me.BtnOutputBrowse.Size = New System.Drawing.Size(30, 29)
        Me.BtnOutputBrowse.TabIndex = 69
        Me.BtnOutputBrowse.Text = "..."
        Me.BtnOutputBrowse.UseVisualStyleBackColor = True
        '
        'TxtOutputPath
        '
        Me.TxtOutputPath.Location = New System.Drawing.Point(136, 514)
        Me.TxtOutputPath.Name = "TxtOutputPath"
        Me.TxtOutputPath.Size = New System.Drawing.Size(503, 29)
        Me.TxtOutputPath.TabIndex = 67
        '
        'BtnQueue
        '
        Me.BtnQueue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnQueue.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnQueue.ForeColor = System.Drawing.Color.White
        Me.BtnQueue.Location = New System.Drawing.Point(681, 476)
        Me.BtnQueue.Name = "BtnQueue"
        Me.BtnQueue.Size = New System.Drawing.Size(91, 67)
        Me.BtnQueue.TabIndex = 71
        Me.BtnQueue.Text = "Queue"
        Me.BtnQueue.UseVisualStyleBackColor = False
        '
        'BtnUpdateList
        '
        Me.BtnUpdateList.Location = New System.Drawing.Point(617, 226)
        Me.BtnUpdateList.Name = "BtnUpdateList"
        Me.BtnUpdateList.Size = New System.Drawing.Size(82, 29)
        Me.BtnUpdateList.TabIndex = 40
        Me.BtnUpdateList.Text = "Update"
        Me.BtnUpdateList.UseVisualStyleBackColor = True
        '
        'BtnSaveList
        '
        Me.BtnSaveList.Location = New System.Drawing.Point(705, 226)
        Me.BtnSaveList.Name = "BtnSaveList"
        Me.BtnSaveList.Size = New System.Drawing.Size(67, 29)
        Me.BtnSaveList.TabIndex = 41
        Me.BtnSaveList.Text = "Save"
        Me.BtnSaveList.UseVisualStyleBackColor = True
        '
        'OfdInput
        '
        Me.OfdInput.Filter = "All Files|*.*"
        '
        'VideoWorker
        '
        '
        'SegWorker
        '
        '
        'BtnManageProfile
        '
        Me.BtnManageProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnManageProfile.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnManageProfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnManageProfile.Location = New System.Drawing.Point(98, 9)
        Me.BtnManageProfile.Name = "BtnManageProfile"
        Me.BtnManageProfile.Size = New System.Drawing.Size(107, 33)
        Me.BtnManageProfile.TabIndex = 6
        Me.BtnManageProfile.Text = "Manage"
        Me.BtnManageProfile.UseVisualStyleBackColor = False
        '
        'BtnAbout
        '
        Me.BtnAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAbout.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAbout.Location = New System.Drawing.Point(666, 9)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(107, 33)
        Me.BtnAbout.TabIndex = 8
        Me.BtnAbout.Text = "About"
        Me.BtnAbout.UseVisualStyleBackColor = False
        '
        'MainUI
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.BtnAbout)
        Me.Controls.Add(Me.BtnManageProfile)
        Me.Controls.Add(Me.BtnSaveList)
        Me.Controls.Add(Me.BtnUpdateList)
        Me.Controls.Add(Me.BtnQueue)
        Me.Controls.Add(Me.BtnOutputBrowse)
        Me.Controls.Add(Me.TxtOutputPath)
        Me.Controls.Add(Me.BtnInputBrowse)
        Me.Controls.Add(Me.TxtInputPath)
        Me.Controls.Add(Me.LblOutputFolder)
        Me.Controls.Add(Me.LblVideoInput)
        Me.Controls.Add(Me.LblTasks)
        Me.Controls.Add(Me.BtnWatermarkAdd)
        Me.Controls.Add(Me.BtnWatermarkChoose)
        Me.Controls.Add(Me.TxtWatermarkC)
        Me.Controls.Add(Me.LblCoordinates)
        Me.Controls.Add(Me.ChkWatermarkReverse)
        Me.Controls.Add(Me.LblWatermark)
        Me.Controls.Add(Me.LblOptions)
        Me.Controls.Add(Me.TxtOptionsInput)
        Me.Controls.Add(Me.ChkEncryption)
        Me.Controls.Add(Me.TxtABitrate)
        Me.Controls.Add(Me.CboACoding)
        Me.Controls.Add(Me.TxtVBitrate)
        Me.Controls.Add(Me.CboVCoding)
        Me.Controls.Add(Me.TxtVResolution)
        Me.Controls.Add(Me.LblProfileName)
        Me.Controls.Add(Me.ChkEnabled)
        Me.Controls.Add(Me.LblProfiles)
        Me.Controls.Add(Me.LsvProfile)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "MainUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents LsvProfile As ListView
    Friend WithEvents ClhEnabled As ColumnHeader
    Friend WithEvents ClhProfileName As ColumnHeader
    Friend WithEvents ClhVideoCodec As ColumnHeader
    Friend WithEvents ClhVideoBitrate As ColumnHeader
    Friend WithEvents ClhAudioCoding As ColumnHeader
    Friend WithEvents ClhAudioBitrate As ColumnHeader
    Friend WithEvents ClhEncrypt As ColumnHeader
    Friend WithEvents ClhOptions As ColumnHeader
    Friend WithEvents LblProfiles As Label
    Friend WithEvents ClhVideoResolution As ColumnHeader
    Friend WithEvents ChkEnabled As CheckBox
    Friend WithEvents LblProfileName As Label
    Friend WithEvents TxtVResolution As TextBox
    Private WithEvents CboVCoding As ComboBox
    Friend WithEvents TxtVBitrate As TextBox
    Private WithEvents CboACoding As ComboBox
    Friend WithEvents TxtABitrate As TextBox
    Friend WithEvents ChkEncryption As CheckBox
    Friend WithEvents TxtOptionsInput As TextBox
    Friend WithEvents LblOptions As Label
    Friend WithEvents LblWatermark As Label
    Friend WithEvents ChkWatermarkReverse As CheckBox
    Friend WithEvents LblCoordinates As Label
    Friend WithEvents TxtWatermarkC As TextBox
    Friend WithEvents BtnWatermarkChoose As Button
    Friend WithEvents BtnWatermarkAdd As Button
    Friend WithEvents LblTasks As Label
    Friend WithEvents LblVideoInput As Label
    Friend WithEvents LblOutputFolder As Label
    Friend WithEvents TxtInputPath As TextBox
    Friend WithEvents BtnInputBrowse As Button
    Friend WithEvents BtnOutputBrowse As Button
    Friend WithEvents TxtOutputPath As TextBox
    Friend WithEvents BtnQueue As Button
    Friend WithEvents BtnUpdateList As Button
    Friend WithEvents BtnSaveList As Button
    Friend WithEvents OfdInput As OpenFileDialog
    Friend WithEvents FbdOutput As FolderBrowserDialog
    Friend WithEvents VideoWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents SegWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnManageProfile As Button
    Friend WithEvents BtnAbout As Button
End Class
