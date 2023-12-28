Imports System.Diagnostics

Module Program
    Sub Main()
        OpenBrowser("https://www.example.com")
    End Sub

    Private Sub OpenBrowser(url As String)
        Try
            Process.Start(url)
            Console.WriteLine($"Tarayıcı başarıyla açıldı: {url}")
        Catch ex As Exception
            Console.WriteLine($"Hata: {ex.Message}")
        End Try
    End Sub
End Module
