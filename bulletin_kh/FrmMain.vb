Imports System.IO
Imports System.Text
Imports System.Xml

Public Class FrmMain

    '計時器
    Dim myTimer As New Windows.Forms.Timer

    '檔案讀取用
    Dim FS As New FuncFile

    '讀取PSI
    Dim Val_Psi_1 As Integer = 0
    Dim Val_Psi_2 As Integer = 0
    Dim Val_Psi_3 As Integer = 0
    Dim Val_Psi_4 As Integer = 0
    Dim Val_Psi_5 As Integer = 0
    Dim Val_Psi_6 As Integer = 0
    Dim Val_Psi_7 As Integer = 0
    Dim Val_Psi_8 As Integer = 0

    'PSI類型
    Dim Val_Type_1 As String = ""
    Dim Val_Type_2 As String = ""
    Dim Val_Type_3 As String = ""
    Dim Val_Type_4 As String = ""
    Dim Val_Type_5 As String = ""
    Dim Val_Type_6 As String = ""
    Dim Val_Type_7 As String = ""
    Dim Val_Type_8 As String = ""

    '下次執行時間
    Dim Time_NextRun As Date

    '表單載入
    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '設定標題
        Me.Text = App_Title
        NotifyIconMain.Text = App_Title

        '初次取得PSI值
        Get_PSI_Value()

        '計時器基本設定
        '預設10秒
        myTimer.Interval = 10000
        AddHandler myTimer.Tick, AddressOf TimeCheck

        TimerGO()

        '清除訊息
        LB_Message.Items.Clear()

        '計時器按鈕
        If myTimer.Enabled Then
            BTN_SetTimer.Text = "停止計時器"
        End If

        '其他設定
        Lab_psi_limit.Text = "目前PSI警告值為" & ValPsiLimit

        '系統列設定
        Me.NotifyIconMain.Visible = False
    End Sub

    '更新PSI值
    Private Sub BTN_update_psi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_update_psi.Click
        Get_PSI_Value()
    End Sub

    ''' <summary>
    ''' 加入message
    ''' </summary>
    ''' <param name="MsgTxt">文字內容</param>
    ''' <remarks></remarks>
    Private Sub ListBoxAdd(ByVal MsgTxt As String)
        If LB_Message.Items.Count < 8 Then
            LB_Message.Items.Add(MsgTxt)
        Else
            LB_Message.Items.Remove(LB_Message.Items(0).ToString)
            LB_Message.Items.Add(MsgTxt)
        End If
    End Sub

    ''' <summary>
    ''' 取得測站PSI值
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Get_PSI_Value()

        Val_Psi_1 = FuncXML.GetPsiValue("美濃", "psi")
        Val_Psi_2 = FuncXML.GetPsiValue("仁武", "psi")
        Val_Psi_3 = FuncXML.GetPsiValue("大寮", "psi")
        Val_Psi_4 = FuncXML.GetPsiValue("林園", "psi")
        Val_Psi_5 = FuncXML.GetPsiValue("楠梓", "psi")
        Val_Psi_6 = FuncXML.GetPsiValue("左營", "psi")
        Val_Psi_7 = FuncXML.GetPsiValue("前金", "psi")
        Val_Psi_8 = FuncXML.GetPsiValue("小港", "psi")

        Val_Type_1 = FuncXML.GetPsiValue("美濃", "pollution")
        Val_Type_2 = FuncXML.GetPsiValue("仁武", "pollution")
        Val_Type_3 = FuncXML.GetPsiValue("大寮", "pollution")
        Val_Type_4 = FuncXML.GetPsiValue("林園", "pollution")
        Val_Type_5 = FuncXML.GetPsiValue("楠梓", "pollution")
        Val_Type_6 = FuncXML.GetPsiValue("左營", "pollution")
        Val_Type_7 = FuncXML.GetPsiValue("前金", "pollution")
        Val_Type_8 = FuncXML.GetPsiValue("小港", "pollution")

        If IsNumeric(Val_Psi_1) Then
            TB_psi_1.Text = Val_Psi_1
        Else
            TB_psi_1.Text = 0
        End If
        If IsNumeric(Val_Psi_2) Then
            TB_psi_2.Text = Val_Psi_2
        Else
            TB_psi_2.Text = 0
        End If
        If IsNumeric(Val_Psi_3) Then
            TB_psi_3.Text = Val_Psi_3
        Else
            TB_psi_3.Text = 0
        End If
        If IsNumeric(Val_Psi_4) Then
            TB_psi_4.Text = Val_Psi_4
        Else
            TB_psi_4.Text = 0
        End If
        If IsNumeric(Val_Psi_5) Then
            TB_psi_5.Text = Val_Psi_5
        Else
            TB_psi_5.Text = 0
        End If
        If IsNumeric(Val_Psi_6) Then
            TB_psi_6.Text = Val_Psi_6
        Else
            TB_psi_6.Text = 0
        End If
        If IsNumeric(Val_Psi_7) Then
            TB_psi_7.Text = Val_Psi_7
        Else
            TB_psi_7.Text = 0
        End If
        If IsNumeric(Val_Psi_8) Then
            TB_psi_8.Text = Val_Psi_8
        Else
            TB_psi_8.Text = 0
        End If

        ListBoxAdd("已更新PSI值")

    End Sub

    ''' <summary>
    ''' 判斷是否超標
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Check_PSI_Value()

        Dim FlagOver As Integer = 0
        Dim Data_Email As String = ""
        Dim Data_SMS As String = ""

        '美濃
        If CInt(TB_psi_1.Text) > ValPsiLimit And Val_Type_1 = "懸浮微粒" Then
            FlagOver += 1
            Data_Email += "美濃 (" & Val_Type_1 & TB_psi_1.Text & ")、"
            Data_SMS += "美濃 (" & Val_Type_1 & TB_psi_1.Text & ")、"
        End If

        '仁武
        If CInt(TB_psi_2.Text) > ValPsiLimit And Val_Type_2 = "懸浮微粒" Then
            FlagOver += 1
            Data_Email += "仁武 (" & Val_Type_2 & TB_psi_2.Text & ")、"
            Data_SMS += "仁武 (" & Val_Type_2 & TB_psi_2.Text & ")、"
        End If

        '大寮
        If CInt(TB_psi_3.Text) > ValPsiLimit And Val_Type_3 = "懸浮微粒" Then
            FlagOver += 1
            Data_Email += "大寮 (" & Val_Type_3 & TB_psi_3.Text & ")、"
            Data_SMS += "大寮 (" & Val_Type_3 & TB_psi_3.Text & ")、"
        End If

        '林園
        If CInt(TB_psi_4.Text) > ValPsiLimit And Val_Type_4 = "懸浮微粒" Then
            FlagOver += 1
            Data_Email += "林園 (" & Val_Type_4 & TB_psi_4.Text & ")、"
            Data_SMS += "林園 (" & Val_Type_4 & TB_psi_4.Text & ")、"
        End If

        '楠梓
        If CInt(TB_psi_5.Text) > ValPsiLimit And Val_Type_5 = "懸浮微粒" Then
            FlagOver += 1
            Data_Email += "楠梓 (" & Val_Type_5 & TB_psi_5.Text & ")、"
            Data_SMS += "楠梓 (" & Val_Type_5 & TB_psi_5.Text & ")、"
        End If

        '左營
        If CInt(TB_psi_6.Text) > ValPsiLimit And Val_Type_6 = "懸浮微粒" Then
            FlagOver += 1
            Data_Email += "左營 (" & Val_Type_6 & TB_psi_6.Text & ")、"
            Data_SMS += "左營 (" & Val_Type_6 & TB_psi_6.Text & ")、"
        End If

        '前金
        If CInt(TB_psi_7.Text) > ValPsiLimit And Val_Type_7 = "懸浮微粒" Then
            FlagOver += 1
            Data_Email += "前金 (" & Val_Type_7 & TB_psi_7.Text & ")、"
            Data_SMS += "前金 (" & Val_Type_7 & TB_psi_7.Text & ")、"
        End If

        '小港
        If CInt(TB_psi_8.Text) > ValPsiLimit And Val_Type_8 = "懸浮微粒" Then
            FlagOver += 1
            Data_Email += "小港 (" & Val_Type_8 & TB_psi_8.Text & ")、"
            Data_SMS += "小港 (" & Val_Type_8 & TB_psi_8.Text & ")、"
        End If

        '有任一測站超過標準
        If FlagOver > 0 Then

            '如果是假日, 增加簡訊
            If TodayIsHoliday(Now.Date) Then
                Func_SendMail(Data_Email.Substring(0, Data_Email.Length - 1))
                Func_SendSMS(Data_SMS.Substring(0, Data_SMS.Length - 1))

                ListBoxAdd("超過標準, 已寄送郵件及簡訊")
                FS.LogSave(Now, "超過標準, 已寄送郵件及簡訊")
            Else
                Func_SendMail(Data_Email.Substring(0, Data_Email.Length - 1))

                ListBoxAdd("超過標準, 已寄送郵件")
                FS.LogSave(Now, "超過標準, 已寄送郵件")
            End If
        Else
            ListBoxAdd("此時段正常")
            FS.LogSave(Now, "此時段正常")
        End If
    End Sub

    '寄信通知
    Private Sub Func_SendMail(ByVal Mail_Data As String)
        Dim toMail As String = ""
        Dim toBody As String = ""

        toMail = FS.GetEmailAddress(Path_App & FileName_MailList)
        toBody = FS.GetEmailBody(Path_App & FileName_MailBody)
        toBody = Replace(toBody, "{0}", Mail_Data)
        toBody = Replace(toBody, vbCrLf, "<br />")

        If FuncMail.SendMail(toMail, toBody) Then
            ListBoxAdd("Email發送成功")
            FS.LogSave(Now, "Email發送成功")
        Else
            ListBoxAdd("Email發送失敗")
            FS.LogSave(Now, "Email發送失敗")
        End If
    End Sub

    '簡訊通知
    Private Sub Func_SendSMS(ByVal SMS_Data As String)
        Dim toSMS As String = ""

        toSMS = FS.GetSMS(Path_App & FileName_SMS)
        toSMS = Replace(toSMS, "{0}", SMS_Data)

        If FuncSMS.sendSMS(toSMS) Then
            ListBoxAdd("SMS發送成功")
            FS.LogSave(Now, "SMS發送成功")
        Else
            ListBoxAdd("SMS發送失敗")
            FS.LogSave(Now, "SMS發送失敗")
        End If
    End Sub

    '設定計時器
    Private Sub BTN_SetTimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SetTimer.Click
        TimerGO()
    End Sub

    '開啟或關閉計時器
    Private Sub TimerGO()
        If myTimer.Enabled Then
            myTimer.Stop()
            Lab_Timer_state.Text = "計時器停止中"
            BTN_SetTimer.Text = "啟動計時器"
        Else
            myTimer.Start()
            Lab_Timer_state.Text = "計時器執行中"
            BTN_SetTimer.Text = "停止計時器"
        End If
        FS.LogSave(Now, Lab_Timer_state.Text)
    End Sub

    '計時器程式
    Private Sub TimeCheck()
        '是否在早上八點到下午五點內
        If Now.Hour >= 8 And Now.Hour <= 17 Then

            '取得下一次執行時間
            Time_NextRun = GetTimeNext()

            '判斷是否到達設定時間
            If Time_NextRun <> Nothing Then
                If Now.CompareTo(Time_NextRun) > 0 Then

                    Lab_NextTimeDuring.Text = "Loading..."

                    '取得最新的psi
                    Get_PSI_Value()

                    '判斷是否超標
                    Check_PSI_Value()

                    '寫入最新執行時間
                    FS.SetLeastTimeValue()

                    Lab_NextTimeDuring.Text = FS.GetLeastTimeValue & "執行完成"

                    FS.LogSave(Now, "執行完成")
                Else
                    Lab_NextTimeDuring.Text = "下次執行時間：" & Time_NextRun.ToString
                End If
            Else
                Lab_NextTimeDuring.Text = "已無下次執行區間"
            End If
        Else
            '不在時間內
            Lab_NextTimeDuring.Text = "不在執行時段內"
        End If
    End Sub

    '下一次執行時間
    Private Function GetTimeNext() As DateTime
        '時間區間
        Dim During() As String = {"08:00:00", "09:00:00", "10:00:00", "11:00:00", "12:00:00", "13:00:00", "14:00:00", "15:00:00", "16:00:00", "17:00:00"}
        Dim DT_Least As New DateTime
        Dim DT_Dur As New DateTime

        Dim Result As DateTime = Nothing

        '取得上次更新時間
        DT_Least = FS.GetLeastTimeValue

        For i As Integer = 0 To UBound(During)
            DT_Dur = CDate(Now.Date & " " & During(i))
            If DT_Dur.CompareTo(DT_Least) > 0 Then
                Result = DT_Dur
                Exit For
            End If
        Next
        Return Result
    End Function

    ''' <summary>
    ''' 判斷今天是否為假日
    ''' </summary>
    ''' <param name="TodayDate">日期</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function TodayIsHoliday(ByVal TodayDate As Date) As Boolean
        Dim Result As Boolean = False
        If TodayDate.DayOfWeek = DayOfWeek.Saturday Or TodayDate.DayOfWeek = DayOfWeek.Sunday Then
            Result = True
        End If
        Return Result
    End Function

    '關閉程式
    Private Sub Btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Exit.Click
        If MsgBox("確定要關閉程式？", MsgBoxStyle.YesNo, "注意") = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    '縮小到系統列
    Private Sub Btn_Trip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Trip.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.Hide()
            Me.NotifyIconMain.Visible = True
        End If
    End Sub

    '由系統列放大
    Private Sub NotifyIconMain_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIconMain.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.NotifyIconMain.Visible = False
    End Sub
End Class