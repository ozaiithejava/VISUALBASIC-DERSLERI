' Visual Basic (VB) - Dosya Okuma ve Yazma

' Yorum Satırları: Kodun anlaşılması için yorumlar eklenir.

Imports System.IO ' Dosya işlemleri için gerekli import

Module Program
    Sub Main()
        ' --- Dosya Yazma ---
        Dim yazilacakDosya As String = "C:\Temp\yazilacakDosya.txt"

        ' StreamWriter kullanarak dosyaya yazma
        Using writer As StreamWriter = New StreamWriter(yazilacakDosya)
            writer.WriteLine("Bu bir yazıdır.")
            writer.WriteLine("İkinci satır.")
        End Using

        Console.WriteLine("Dosya yazma işlemi tamamlandı.")

        ' --- Dosya Okuma ---
        Dim okunacakDosya As String = "C:\Temp\yazilacakDosya.txt"

        ' Dosyanın var olup olmadığını kontrol etme
        If File.Exists(okunacakDosya) Then
            ' StreamReader kullanarak dosyadan okuma
            Using reader As StreamReader = New StreamReader(okunacakDosya)
                ' Dosyanın sonuna kadar satır okuma
                While Not reader.EndOfStream
                    Dim satir As String = reader.ReadLine()
                    Console.WriteLine(satir)
                End While
            End Using

            Console.WriteLine("Dosya okuma işlemi tamamlandı.")
        Else
            Console.WriteLine("Dosya bulunamadı.")
        End If
    End Sub
End Module
