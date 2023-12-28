Imports System.Diagnostics

Module Program
    Sub Main()
        Dim browserProcess As Process = OpenBrowser("https://www.example.com")

        ' İşlem bekleme veya kapatma işlemleri burada yapılabilir.

        ' Tarayıcı penceresini kapatma
        CloseBrowser(browserProcess)
    End Sub

    Private Function OpenBrowser(url As String) As Process
        Try
            Dim process As Process = Process.Start("chrome.exe", url)
            Console.WriteLine($"Tarayıcı başarıyla açıldı: {url}")
            Return process
        Catch ex As Exception
            Console.WriteLine($"Hata: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Private Sub CloseBrowser(process As Process)
        Try
            If process IsNot Nothing AndAlso Not process.HasExited Then
                process.Kill()
                Console.WriteLine("Tarayıcı başarıyla kapatıldı.")
            Else
                Console.WriteLine("Tarayıcı zaten kapatılmış veya başlatılamamış.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Hata: {ex.Message}")
        End Try
    End Sub
End Module
