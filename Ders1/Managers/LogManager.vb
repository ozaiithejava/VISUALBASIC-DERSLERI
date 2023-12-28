Imports System.IO
Imports System.Text

Public Class LogManager
    Private logFilePath As String

    Public Sub New(logFileName As String)
        logFilePath = Path.Combine(Directory.GetCurrentDirectory(), logFileName)
    End Sub

    Public Sub LogInfo(message As String)
        LogMessage("INFO", message)
    End Sub

    Public Sub LogWarning(message As String)
        LogMessage("WARNING", message)
    End Sub

    Public Sub LogError(message As String)
        LogMessage("ERROR", message)
    End Sub

    Private Sub LogMessage(logLevel As String, message As String)
        Dim logEntry As String = $"{DateTime.Now} [{logLevel}] - {message}"

        ' Log dosyasına yazma
        Using writer As New StreamWriter(logFilePath, True, Encoding.UTF8)
            writer.WriteLine(logEntry)
        End Using
    End Sub
End Class
