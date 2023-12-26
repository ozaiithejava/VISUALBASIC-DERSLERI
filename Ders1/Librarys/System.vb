Public Class Form1
    Private Sub btnSystemOperations_Click(sender As Object, e As EventArgs) Handles btnSystemOperations.Click
        ' Environment Sınıfı Kullanımı
        Dim newLine As String = Environment.NewLine
        Console.WriteLine($"Yeni Satır: {newLine}")

        Dim commandLineArgs() As String = Environment.GetCommandLineArgs()
        Console.WriteLine("Komut Satırı Argümanları:")
        For Each arg In commandLineArgs
            Console.WriteLine($" - {arg}")
        Next

        ' Dizin ve Klasör Yönetimi
        Dim currentDirectory As String = Environment.CurrentDirectory
        Console.WriteLine($"Çalışma Dizini: {currentDirectory}")

        Dim myDocumentsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Console.WriteLine($"Belgelerim Klasörü Yolu: {myDocumentsPath}")

        ' Zaman ve Saat İşlemleri
        Dim currentTime As DateTime = DateTime.Now
        Console.WriteLine($"Şu Anki Tarih ve Saat: {currentTime}")

        Dim tickCount As Integer = Environment.TickCount
        Console.WriteLine($"Sistem Başlangıcından Beri Geçen Milisaniyeler: {tickCount}")

        ' Platform Bilgileri
        Dim osVersion As OperatingSystem = Environment.OSVersion
        Console.WriteLine($"İşletim Sistemi Sürümü: {osVersion}")

        Dim processorCount As Integer = Environment.ProcessorCount
        Console.WriteLine($"Sistemdeki İşlemci Sayısı: {processorCount}")
    End Sub
End Class
