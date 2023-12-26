' Visual Basic (VB) - Dosya İçeriği Satır Satır Okuma ve Yazma

' Yorum Satırları: Kodun anlaşılması için yorumlar eklenir.

Imports System.IO ' Dosya işlemleri için gerekli import

Module Program
    Sub Main()
        ' --- Dosya Yazma (Satır Satır) ---
        Dim yazilacakDosya As String = "C:\Temp\yazilacakDosyaSatirSatir.txt"

        ' StreamWriter kullanarak dosyaya satır satır yazma
        Using writer As StreamWriter = New StreamWriter(yazilacakDosya)
            writer.WriteLine("Satır 1")
            writer.WriteLine("Satır 2")
            writer.WriteLine("Satır 3")
        End Using

        Console.WriteLine("Dosyaya satır satır yazma işlemi tamamlandı.")

        ' --- Dosya Okuma (Satır Satır) ---
        Dim okunacakDosya As String = "C:\Temp\yazilacakDosyaSatirSatir.txt"

        ' Dosyanın var olup olmadığını kontrol etme
        If File.Exists(okunacakDosya) Then
            ' StreamReader kullanarak dosyadan satır satır okuma
            Using reader As StreamReader = New StreamReader(okunacakDosya)
                Console.WriteLine("Dosya İçeriği (Satır Satır):")
                While Not reader.EndOfStream
                    Dim satir As String = reader.ReadLine()
                    Console.WriteLine(satir)
                End While
            End Using

            Console.WriteLine("Dosya okuma işlemi tamamlandı.")
        Else
            Console.WriteLine("Dosya bulunamadı.")
        End If

        ' --- Dosya İçeriğini Değiştirme ---
        Dim duzenlenecekDosya As String = "C:\Temp\duzenlenecekDosya.txt"

        ' Dosyanın var olup olmadığını kontrol etme
        If File.Exists(duzenlenecekDosya) Then
            ' Dosyanın içeriğini değiştirme (varsayılan olarak üzerine yazar)
            File.WriteAllText(duzenlenecekDosya, "Yeni içerik")

            Console.WriteLine("Dosya içeriği değiştirildi.")
        Else
            Console.WriteLine("Dosya bulunamadı.")
        End If
    End Sub
End Module
