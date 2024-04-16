<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileManage
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfileManage))
        Me.LblProfileManagement = New System.Windows.Forms.Label()
        Me.LstProfile = New System.Windows.Forms.ListBox()
        Me.BtnPRemove = New System.Windows.Forms.Button()
        Me.BtnPAdd = New System.Windows.Forms.Button()
        Me.TxtProfileName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblProfileManagement
        '
        Me.LblProfileManagement.AutoSize = True
        Me.LblProfileManagement.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblProfileManagement.Location = New System.Drawing.Point(10, 12)
        Me.LblProfileManagement.Name = "LblProfileManagement"
        Me.LblProfileManagement.Size = New System.Drawing.Size(209, 26)
        Me.LblProfileManagement.TabIndex = 26
        Me.LblProfileManagement.Text = "Profile Management"
        '
        'LstProfile
        '
        Me.LstProfile.FormattingEnabled = True
        Me.LstProfile.ItemHeight = 21
        Me.LstProfile.Location = New System.Drawing.Point(14, 47)
        Me.LstProfile.Name = "LstProfile"
        Me.LstProfile.Size = New System.Drawing.Size(315, 298)
        Me.LstProfile.TabIndex = 29
        '
        'BtnPRemove
        '
        Me.BtnPRemove.BackColor = System.Drawing.Color.IndianRed
        Me.BtnPRemove.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPRemove.ForeColor = System.Drawing.Color.White
        Me.BtnPRemove.Location = New System.Drawing.Point(175, 390)
        Me.BtnPRemove.Name = "BtnPRemove"
        Me.BtnPRemove.Size = New System.Drawing.Size(155, 34)
        Me.BtnPRemove.TabIndex = 65
        Me.BtnPRemove.Text = "Remove"
        Me.BtnPRemove.UseVisualStyleBackColor = False
        '
        'BtnPAdd
        '
        Me.BtnPAdd.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnPAdd.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPAdd.ForeColor = System.Drawing.Color.Black
        Me.BtnPAdd.Location = New System.Drawing.Point(13, 390)
        Me.BtnPAdd.Name = "BtnPAdd"
        Me.BtnPAdd.Size = New System.Drawing.Size(155, 34)
        Me.BtnPAdd.TabIndex = 61
        Me.BtnPAdd.Text = "Add"
        Me.BtnPAdd.UseVisualStyleBackColor = False
        '
        'TxtProfileName
        '
        Me.TxtProfileName.Location = New System.Drawing.Point(14, 354)
        Me.TxtProfileName.Name = "TxtProfileName"
        Me.TxtProfileName.Size = New System.Drawing.Size(315, 29)
        Me.TxtProfileName.TabIndex = 41
        '
        'ProfileManage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(344, 433)
        Me.Controls.Add(Me.TxtProfileName)
        Me.Controls.Add(Me.LstProfile)
        Me.Controls.Add(Me.BtnPRemove)
        Me.Controls.Add(Me.BtnPAdd)
        Me.Controls.Add(Me.LblProfileManagement)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProfileManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile Management (Advanced)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblProfileManagement As Label
    Friend WithEvents LstProfile As ListBox
    Friend WithEvents BtnPRemove As Button
    Friend WithEvents BtnPAdd As Button
    Friend WithEvents TxtProfileName As TextBox
End Class
