Imports System.Diagnostics

Public Class ProgramManager
    Public Sub GetAllPrograms()
        ' Bilgisayar üzerinde çalışan tüm programları getir
        Dim allProcesses As Process() = Process.GetProcesses()

        ' Her bir programın adını konsola yazdır
        For Each process As Process In allProcesses
            Console.WriteLine($"Program Adı: {process.ProcessName}")
        Next
    End Sub

    Public Function CheckProgramRunning(programName As String) As Boolean
        ' Belirli bir programın çalışıp çalışmadığını kontrol et
        Dim processesByName As Process() = Process.GetProcessesByName(programName)
        Return processesByName.Length > 0
    End Function

    Public Sub ShutdownComputer()
        ' Bilgisayarı kapat
        Process.Start("shutdown", "/s /t 0")
    End Sub

    Public Sub OpenProgram(programPath As String)
        ' Belirli bir programı aç
        Try
            Process.Start(programPath)
            Console.WriteLine($"Program başarıyla açıldı: {programPath}")
        Catch ex As Exception
            Console.WriteLine($"Hata: {ex.Message}")
        End Try
    End Sub
End Class

Module Program
    Sub Main()
        ' ProgramManager örneği oluşturun
        Dim programManager As New ProgramManager()

        ' Tüm programları getir
        programManager.GetAllPrograms()

        ' Belirli bir programın çalışıp çalışmadığını kontrol et
        Dim programNameToCheck As String = "notepad"
        Dim isProgramRunning As Boolean = programManager.CheckProgramRunning(programNameToCheck)
        Console.WriteLine($"{programNameToCheck} çalışıyor mu? {isProgramRunning}")

        ' Bilgisayarı kapat
        programManager.ShutdownComputer()

        ' Belirli bir programı aç
        Dim programPathToOpen As String = "C:\Program Files\Internet Explorer\iexplore.exe"
        programManager.OpenProgram(programPathToOpen)

        ' Konsolu açık tutmak için bekleme
        Console.ReadLine()
    End Sub
End Module
