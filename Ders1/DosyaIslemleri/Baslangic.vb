' Visual Basic (VB) - Dosya İşlemleri

' Yorum Satırları: Kodun anlaşılması için yorumlar eklenir.

Imports System.IO ' Dosya işlemleri için gerekli import

Module Program
    Sub Main()
        ' --- Dosya Oluşturma ---
        Dim dosyaYolu As String = "C:\Temp\ornekDosya.txt"

        ' Dosyanın var olup olmadığını kontrol etme
        If Not File.Exists(dosyaYolu) Then
            ' Dosya yoksa oluşturma
            File.Create(dosyaYolu).Close()
            Console.WriteLine("Dosya oluşturuldu.")
        Else
            Console.WriteLine("Dosya zaten var.")
        End If

        ' --- Dosya Silme ---
        ' Dosyanın var olup olmadığını kontrol etme
        If File.Exists(dosyaYolu) Then
            ' Dosya varsa silme
            File.Delete(dosyaYolu)
            Console.WriteLine("Dosya silindi.")
        Else
            Console.WriteLine("Dosya zaten yok.")
        End If

        ' --- Dosya Varlık Kontrolü ---
        Dim kontrolEdilenDosya As String = "C:\Temp\kontrolEdilenDosya.txt"

        ' Dosyanın var olup olmadığını kontrol etme
        If File.Exists(kontrolEdilenDosya) Then
            Console.WriteLine("Dosya mevcut.")
        Else
            Console.WriteLine("Dosya mevcut değil.")
        End If
    End Sub
End Module
