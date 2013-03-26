Module app_setup
    '[程式基本設定] ///////////////////////////////////////

    '標題
    Public App_Title As String = "環保局空氣品質不良即時通報"
    '路徑設定
    Public Path_App As String = "C:\KH_bulletin\"
    '最新時間名稱檔案
    Public FileName_LastestTime As String = "time.ini"
    'Log檔案名稱
    Public FileName_log As String = "bulletin_" & Now.Date.ToString("yyyy_MM_dd") & ".log"

    '[郵件設定] ///////////////////////////////////////

    '收件人清單檔案名稱
    Public FileName_MailList As String = "email.ini"
    '信件內容檔案名稱
    Public FileName_MailBody As String = "email_body.ini"

    '寄件者信箱
    Public Mail_SenderEmail As String = "username@email"
    '寄件者名稱
    Public Mail_SenderName As String = "環保局"
    '寄件標題
    Public Mail_Sender_Subject As String = "環保局空氣品質不良即時通報"

    '[簡訊設定] ///////////////////////////////////////

    '簡訊檔案名稱
    Public FileName_SMS As String = "sms.ini"

    '[程式設定] ///////////////////////////////////////

    'PSI限制
    Public ValPsiLimit As Integer = 100
End Module