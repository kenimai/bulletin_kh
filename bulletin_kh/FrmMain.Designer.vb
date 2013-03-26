<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.TB_psi_1 = New System.Windows.Forms.TextBox
        Me.Lab_site_1 = New System.Windows.Forms.Label
        Me.BTN_update_psi = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Lab_site_8 = New System.Windows.Forms.Label
        Me.TB_psi_8 = New System.Windows.Forms.TextBox
        Me.Lab_site_7 = New System.Windows.Forms.Label
        Me.TB_psi_7 = New System.Windows.Forms.TextBox
        Me.Lab_site_6 = New System.Windows.Forms.Label
        Me.TB_psi_6 = New System.Windows.Forms.TextBox
        Me.Lab_site_5 = New System.Windows.Forms.Label
        Me.TB_psi_5 = New System.Windows.Forms.TextBox
        Me.Lab_site_4 = New System.Windows.Forms.Label
        Me.TB_psi_4 = New System.Windows.Forms.TextBox
        Me.Lab_site_3 = New System.Windows.Forms.Label
        Me.TB_psi_3 = New System.Windows.Forms.TextBox
        Me.Lab_site_2 = New System.Windows.Forms.Label
        Me.TB_psi_2 = New System.Windows.Forms.TextBox
        Me.BTN_SetTimer = New System.Windows.Forms.Button
        Me.Lab_Timer_state = New System.Windows.Forms.Label
        Me.Lab_NextTimeDuring = New System.Windows.Forms.Label
        Me.Btn_Exit = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.NotifyIconMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Btn_Trip = New System.Windows.Forms.Button
        Me.LB_Message = New System.Windows.Forms.ListBox
        Me.Lab_psi_limit = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TB_psi_1
        '
        Me.TB_psi_1.Location = New System.Drawing.Point(6, 30)
        Me.TB_psi_1.Name = "TB_psi_1"
        Me.TB_psi_1.ReadOnly = True
        Me.TB_psi_1.Size = New System.Drawing.Size(139, 22)
        Me.TB_psi_1.TabIndex = 1
        '
        'Lab_site_1
        '
        Me.Lab_site_1.AutoSize = True
        Me.Lab_site_1.Location = New System.Drawing.Point(6, 15)
        Me.Lab_site_1.Name = "Lab_site_1"
        Me.Lab_site_1.Size = New System.Drawing.Size(29, 12)
        Me.Lab_site_1.TabIndex = 0
        Me.Lab_site_1.Text = "美濃"
        '
        'BTN_update_psi
        '
        Me.BTN_update_psi.Location = New System.Drawing.Point(207, 163)
        Me.BTN_update_psi.Name = "BTN_update_psi"
        Me.BTN_update_psi.Size = New System.Drawing.Size(231, 36)
        Me.BTN_update_psi.TabIndex = 8
        Me.BTN_update_psi.Text = "更新PSI"
        Me.BTN_update_psi.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lab_site_8)
        Me.GroupBox1.Controls.Add(Me.TB_psi_8)
        Me.GroupBox1.Controls.Add(Me.Lab_site_7)
        Me.GroupBox1.Controls.Add(Me.TB_psi_7)
        Me.GroupBox1.Controls.Add(Me.Lab_site_6)
        Me.GroupBox1.Controls.Add(Me.TB_psi_6)
        Me.GroupBox1.Controls.Add(Me.Lab_site_5)
        Me.GroupBox1.Controls.Add(Me.TB_psi_5)
        Me.GroupBox1.Controls.Add(Me.Lab_site_4)
        Me.GroupBox1.Controls.Add(Me.TB_psi_4)
        Me.GroupBox1.Controls.Add(Me.Lab_site_3)
        Me.GroupBox1.Controls.Add(Me.TB_psi_3)
        Me.GroupBox1.Controls.Add(Me.Lab_site_2)
        Me.GroupBox1.Controls.Add(Me.TB_psi_2)
        Me.GroupBox1.Controls.Add(Me.Lab_site_1)
        Me.GroupBox1.Controls.Add(Me.TB_psi_1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 365)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PSI值"
        '
        'Lab_site_8
        '
        Me.Lab_site_8.AutoSize = True
        Me.Lab_site_8.Location = New System.Drawing.Point(6, 315)
        Me.Lab_site_8.Name = "Lab_site_8"
        Me.Lab_site_8.Size = New System.Drawing.Size(29, 12)
        Me.Lab_site_8.TabIndex = 14
        Me.Lab_site_8.Text = "林園"
        '
        'TB_psi_8
        '
        Me.TB_psi_8.Location = New System.Drawing.Point(6, 330)
        Me.TB_psi_8.Name = "TB_psi_8"
        Me.TB_psi_8.ReadOnly = True
        Me.TB_psi_8.Size = New System.Drawing.Size(139, 22)
        Me.TB_psi_8.TabIndex = 15
        '
        'Lab_site_7
        '
        Me.Lab_site_7.AutoSize = True
        Me.Lab_site_7.Location = New System.Drawing.Point(6, 275)
        Me.Lab_site_7.Name = "Lab_site_7"
        Me.Lab_site_7.Size = New System.Drawing.Size(29, 12)
        Me.Lab_site_7.TabIndex = 12
        Me.Lab_site_7.Text = "前金"
        '
        'TB_psi_7
        '
        Me.TB_psi_7.Location = New System.Drawing.Point(6, 290)
        Me.TB_psi_7.Name = "TB_psi_7"
        Me.TB_psi_7.ReadOnly = True
        Me.TB_psi_7.Size = New System.Drawing.Size(139, 22)
        Me.TB_psi_7.TabIndex = 13
        '
        'Lab_site_6
        '
        Me.Lab_site_6.AutoSize = True
        Me.Lab_site_6.Location = New System.Drawing.Point(6, 235)
        Me.Lab_site_6.Name = "Lab_site_6"
        Me.Lab_site_6.Size = New System.Drawing.Size(29, 12)
        Me.Lab_site_6.TabIndex = 10
        Me.Lab_site_6.Text = "左營"
        '
        'TB_psi_6
        '
        Me.TB_psi_6.Location = New System.Drawing.Point(6, 250)
        Me.TB_psi_6.Name = "TB_psi_6"
        Me.TB_psi_6.ReadOnly = True
        Me.TB_psi_6.Size = New System.Drawing.Size(139, 22)
        Me.TB_psi_6.TabIndex = 11
        '
        'Lab_site_5
        '
        Me.Lab_site_5.AutoSize = True
        Me.Lab_site_5.Location = New System.Drawing.Point(6, 195)
        Me.Lab_site_5.Name = "Lab_site_5"
        Me.Lab_site_5.Size = New System.Drawing.Size(29, 12)
        Me.Lab_site_5.TabIndex = 8
        Me.Lab_site_5.Text = "楠梓"
        '
        'TB_psi_5
        '
        Me.TB_psi_5.Location = New System.Drawing.Point(6, 210)
        Me.TB_psi_5.Name = "TB_psi_5"
        Me.TB_psi_5.ReadOnly = True
        Me.TB_psi_5.Size = New System.Drawing.Size(139, 22)
        Me.TB_psi_5.TabIndex = 9
        '
        'Lab_site_4
        '
        Me.Lab_site_4.AutoSize = True
        Me.Lab_site_4.Location = New System.Drawing.Point(6, 151)
        Me.Lab_site_4.Name = "Lab_site_4"
        Me.Lab_site_4.Size = New System.Drawing.Size(29, 12)
        Me.Lab_site_4.TabIndex = 6
        Me.Lab_site_4.Text = "林園"
        '
        'TB_psi_4
        '
        Me.TB_psi_4.Location = New System.Drawing.Point(6, 166)
        Me.TB_psi_4.Name = "TB_psi_4"
        Me.TB_psi_4.ReadOnly = True
        Me.TB_psi_4.Size = New System.Drawing.Size(139, 22)
        Me.TB_psi_4.TabIndex = 7
        '
        'Lab_site_3
        '
        Me.Lab_site_3.AutoSize = True
        Me.Lab_site_3.Location = New System.Drawing.Point(6, 105)
        Me.Lab_site_3.Name = "Lab_site_3"
        Me.Lab_site_3.Size = New System.Drawing.Size(29, 12)
        Me.Lab_site_3.TabIndex = 4
        Me.Lab_site_3.Text = "大寮"
        '
        'TB_psi_3
        '
        Me.TB_psi_3.Location = New System.Drawing.Point(6, 120)
        Me.TB_psi_3.Name = "TB_psi_3"
        Me.TB_psi_3.ReadOnly = True
        Me.TB_psi_3.Size = New System.Drawing.Size(139, 22)
        Me.TB_psi_3.TabIndex = 5
        '
        'Lab_site_2
        '
        Me.Lab_site_2.AutoSize = True
        Me.Lab_site_2.Location = New System.Drawing.Point(6, 59)
        Me.Lab_site_2.Name = "Lab_site_2"
        Me.Lab_site_2.Size = New System.Drawing.Size(29, 12)
        Me.Lab_site_2.TabIndex = 2
        Me.Lab_site_2.Text = "仁武"
        '
        'TB_psi_2
        '
        Me.TB_psi_2.Location = New System.Drawing.Point(6, 74)
        Me.TB_psi_2.Name = "TB_psi_2"
        Me.TB_psi_2.ReadOnly = True
        Me.TB_psi_2.Size = New System.Drawing.Size(139, 22)
        Me.TB_psi_2.TabIndex = 3
        '
        'BTN_SetTimer
        '
        Me.BTN_SetTimer.Location = New System.Drawing.Point(18, 58)
        Me.BTN_SetTimer.Name = "BTN_SetTimer"
        Me.BTN_SetTimer.Size = New System.Drawing.Size(231, 38)
        Me.BTN_SetTimer.TabIndex = 12
        Me.BTN_SetTimer.Text = "計時器"
        Me.BTN_SetTimer.UseVisualStyleBackColor = True
        '
        'Lab_Timer_state
        '
        Me.Lab_Timer_state.AutoSize = True
        Me.Lab_Timer_state.Location = New System.Drawing.Point(16, 33)
        Me.Lab_Timer_state.Name = "Lab_Timer_state"
        Me.Lab_Timer_state.Size = New System.Drawing.Size(65, 12)
        Me.Lab_Timer_state.TabIndex = 13
        Me.Lab_Timer_state.Text = "計時器狀態"
        '
        'Lab_NextTimeDuring
        '
        Me.Lab_NextTimeDuring.AutoSize = True
        Me.Lab_NextTimeDuring.Location = New System.Drawing.Point(205, 135)
        Me.Lab_NextTimeDuring.Name = "Lab_NextTimeDuring"
        Me.Lab_NextTimeDuring.Size = New System.Drawing.Size(45, 12)
        Me.Lab_NextTimeDuring.TabIndex = 15
        Me.Lab_NextTimeDuring.Text = "----------"
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Location = New System.Drawing.Point(333, 421)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(127, 40)
        Me.Btn_Exit.TabIndex = 17
        Me.Btn_Exit.Text = "關閉程式"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BTN_SetTimer)
        Me.GroupBox3.Controls.Add(Me.Lab_Timer_state)
        Me.GroupBox3.Location = New System.Drawing.Point(189, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(271, 115)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "計時器"
        '
        'NotifyIconMain
        '
        Me.NotifyIconMain.Icon = CType(resources.GetObject("NotifyIconMain.Icon"), System.Drawing.Icon)
        Me.NotifyIconMain.Text = "PSI通知"
        Me.NotifyIconMain.Visible = True
        '
        'Btn_Trip
        '
        Me.Btn_Trip.Location = New System.Drawing.Point(189, 421)
        Me.Btn_Trip.Name = "Btn_Trip"
        Me.Btn_Trip.Size = New System.Drawing.Size(127, 40)
        Me.Btn_Trip.TabIndex = 19
        Me.Btn_Trip.Text = "縮小到系統列"
        Me.Btn_Trip.UseVisualStyleBackColor = True
        '
        'LB_Message
        '
        Me.LB_Message.FormattingEnabled = True
        Me.LB_Message.ItemHeight = 12
        Me.LB_Message.Location = New System.Drawing.Point(189, 219)
        Me.LB_Message.Name = "LB_Message"
        Me.LB_Message.Size = New System.Drawing.Size(271, 184)
        Me.LB_Message.TabIndex = 20
        '
        'Lab_psi_limit
        '
        Me.Lab_psi_limit.AutoSize = True
        Me.Lab_psi_limit.Location = New System.Drawing.Point(18, 394)
        Me.Lab_psi_limit.Name = "Lab_psi_limit"
        Me.Lab_psi_limit.Size = New System.Drawing.Size(45, 12)
        Me.Lab_psi_limit.TabIndex = 21
        Me.Lab_psi_limit.Text = "psi_limit"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 473)
        Me.Controls.Add(Me.Lab_psi_limit)
        Me.Controls.Add(Me.LB_Message)
        Me.Controls.Add(Me.Btn_Trip)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Lab_NextTimeDuring)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_update_psi)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.Text = "空氣品質不良即時通報"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_psi_1 As System.Windows.Forms.TextBox
    Friend WithEvents Lab_site_1 As System.Windows.Forms.Label
    Friend WithEvents BTN_update_psi As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_SetTimer As System.Windows.Forms.Button
    Friend WithEvents Lab_Timer_state As System.Windows.Forms.Label
    Friend WithEvents Lab_NextTimeDuring As System.Windows.Forms.Label
    Friend WithEvents Btn_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents NotifyIconMain As System.Windows.Forms.NotifyIcon
    Friend WithEvents Btn_Trip As System.Windows.Forms.Button
    Friend WithEvents LB_Message As System.Windows.Forms.ListBox
    Friend WithEvents Lab_psi_limit As System.Windows.Forms.Label
    Friend WithEvents Lab_site_2 As System.Windows.Forms.Label
    Friend WithEvents TB_psi_2 As System.Windows.Forms.TextBox
    Friend WithEvents Lab_site_3 As System.Windows.Forms.Label
    Friend WithEvents TB_psi_3 As System.Windows.Forms.TextBox
    Friend WithEvents Lab_site_4 As System.Windows.Forms.Label
    Friend WithEvents TB_psi_4 As System.Windows.Forms.TextBox
    Friend WithEvents Lab_site_8 As System.Windows.Forms.Label
    Friend WithEvents TB_psi_8 As System.Windows.Forms.TextBox
    Friend WithEvents Lab_site_7 As System.Windows.Forms.Label
    Friend WithEvents TB_psi_7 As System.Windows.Forms.TextBox
    Friend WithEvents Lab_site_6 As System.Windows.Forms.Label
    Friend WithEvents TB_psi_6 As System.Windows.Forms.TextBox
    Friend WithEvents Lab_site_5 As System.Windows.Forms.Label
    Friend WithEvents TB_psi_5 As System.Windows.Forms.TextBox

End Class
