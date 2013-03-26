Imports System.IO
Imports System.Text

Public Class FuncFile

    '最新時間設定檔
    Dim FileTimeValue As String = Path_App & FileName_LastestTime
    Dim FileLog As String = Path_App & FileName_log

    ''' <summary>
    ''' 取得Email address
    ''' </summary>
    ''' <param name="FileName">檔案名稱</param>
    ''' <returns>使用者Email列表</returns>
    ''' <remarks>取得Email address</remarks>
    Public Function GetEmailAddress(ByVal FileName As String) As String
        Dim Value As String = ""
        If File.Exists(FileName) Then
            Dim EmailStreamReader As StreamReader
            EmailStreamReader = New StreamReader(FileName, Encoding.Default)
            Do
                Value += Trim(EmailStreamReader.ReadLine) & ";"
            Loop Until EmailStreamReader.EndOfStream
        End If
        Return Value
    End Function

    ''' <summary>
    ''' 取得Email Body
    ''' </summary>
    ''' <param name="FileName">檔案名稱</param>
    ''' <returns>使用者Email內容</returns>
    ''' <remarks>取得Email內容</remarks>
    Public Function GetEmailBody(ByVal FileName As String) As String
        Dim Value As String = ""
        If File.Exists(FileName) Then
            Dim BodyStreamReader As StreamReader
            BodyStreamReader = New StreamReader(FileName, Encoding.Default)
            Value = BodyStreamReader.ReadToEnd
        End If
        Return Value
    End Function

    ''' <summary>
    ''' 取得簡訊 SMS
    ''' </summary>
    ''' <param name="FileName">檔案名稱</param>
    ''' <returns>使用者SMS內容</returns>
    ''' <remarks>取得SMS內容</remarks>
    Public Function GetSMS(ByVal FileName As String) As String
        Dim Value As String = ""
        If File.Exists(FileName) Then
            Dim SMSStreamReader As StreamReader
            SMSStreamReader = New StreamReader(FileName, Encoding.Default)
            Value = SMSStreamReader.ReadToEnd
        End If
        Return Value
    End Function

    ''' <summary>
    ''' 取得最新時間
    ''' </summary>
    ''' <returns>最新執行時間</returns>
    ''' <remarks>取得最新執行時間</remarks>
    Public Function GetLeastTimeValue() As Date
        Dim Result As Date = Now
        If File.Exists(FileTimeValue) Then
            Dim Val As String = File.ReadAllText(FileTimeValue)
            If IsDate(Val) Then
                Result = CDate(Val)
            End If
        Else
            File.WriteAllText(FileTimeValue, Now.ToString)
            Result = Now
        End If
        Return Result
    End Function

    ''' <summary>
    ''' 寫入最新時間
    ''' </summary>
    ''' <remarks>寫入最新執行時間</remarks>
    Public Sub SetLeastTimeValue()
        File.WriteAllText(FileTimeValue, Now.ToString)
    End Sub

    ''' <summary>
    ''' 寫入Log
    ''' </summary>
    ''' <param name="ActionTime">執行時間</param>
    ''' <param name="ActionName">動作名稱</param>
    ''' <remarks>寫入Log</remarks>
    Public Sub LogSave(ByVal ActionTime As Date, ByVal ActionName As String)
        If File.Exists(FileLog) Then
            Dim LogStreamWriter As StreamWriter
            LogStreamWriter = File.AppendText(FileLog)
            LogStreamWriter.WriteLine("{0} | {1}", ActionTime.ToString("yyyy-MM-dd hh:mm:ss"), ActionName)
            LogStreamWriter.Flush()
            LogStreamWriter.Close()
        Else
            Dim LogStreamWriter As StreamWriter
            LogStreamWriter = File.CreateText(FileLog)
            LogStreamWriter.WriteLine("{0} | {1}", ActionTime.ToString("yyyy-MM-dd hh:mm:ss"), ActionName)
            LogStreamWriter.Flush()
            LogStreamWriter.Close()
        End If
    End Sub
End Class
