<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tasks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tasks))
        Me.LblTaskQueue = New System.Windows.Forms.Label()
        Me.LsvQueue = New System.Windows.Forms.ListView()
        Me.ClhTask = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnPause = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTaskQueue
        '
        Me.LblTaskQueue.AutoSize = True
        Me.LblTaskQueue.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblTaskQueue.Location = New System.Drawing.Point(10, 11)
        Me.LblTaskQueue.Name = "LblTaskQueue"
        Me.LblTaskQueue.Size = New System.Drawing.Size(123, 26)
        Me.LblTaskQueue.TabIndex = 27
        Me.LblTaskQueue.Text = "Task Queue"
        '
        'LsvQueue
        '
        Me.LsvQueue.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClhTask, Me.ClhStatus})
        Me.LsvQueue.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LsvQueue.FullRowSelect = True
        Me.LsvQueue.HideSelection = False
        Me.LsvQueue.Location = New System.Drawing.Point(15, 47)
        Me.LsvQueue.MultiSelect = False
        Me.LsvQueue.Name = "LsvQueue"
        Me.LsvQueue.Size = New System.Drawing.Size(445, 351)
        Me.LsvQueue.TabIndex = 28
        Me.LsvQueue.UseCompatibleStateImageBehavior = False
        Me.LsvQueue.View = System.Windows.Forms.View.Details
        '
        'ClhTask
        '
        Me.ClhTask.Text = "Task"
        Me.ClhTask.Width = 300
        '
        'ClhStatus
        '
        Me.ClhStatus.Text = "Status"
        Me.ClhStatus.Width = 120
        '
        'BtnPause
        '
        Me.BtnPause.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPause.Location = New System.Drawing.Point(14, 405)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Size = New System.Drawing.Size(220, 41)
        Me.BtnPause.TabIndex = 29
        Me.BtnPause.Text = "Pause"
        Me.BtnPause.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(241, 405)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(220, 41)
        Me.BtnDelete.TabIndex = 30
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Tasks
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(474, 457)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.LsvQueue)
        Me.Controls.Add(Me.LblTaskQueue)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "Tasks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Task Queue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTaskQueue As Label
    Public WithEvents LsvQueue As ListView
    Friend WithEvents ClhTask As ColumnHeader
    Friend WithEvents ClhStatus As ColumnHeader
    Friend WithEvents BtnPause As Button
    Friend WithEvents BtnDelete As Button
End Class
