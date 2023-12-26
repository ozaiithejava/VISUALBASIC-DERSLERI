' Visual Basic (VB) - Dosya İçeriği Okuma ve Yazma (Detaylı)

' Yorum Satırları: Kodun anlaşılması için yorumlar eklenir.

Imports System.IO ' Dosya işlemleri için gerekli import

Module Program
    Sub Main()
        ' --- Dosya Yazma (Metin Ekleme) ---
        Dim yazilacakDosya As String = "C:\Temp\yazilacakDosyaDetayli.txt"

        ' StreamWriter kullanarak dosyaya yazma (varolan dosyanın üzerine ekler)
        Using writer As StreamWriter = New StreamWriter(yazilacakDosya, append:=True)
            writer.WriteLine("Bu bir yazıdır.")
            writer.WriteLine("İkinci satır.")
        End Using

        Console.WriteLine("Dosyaya metin ekleme işlemi tamamlandı.")

        ' --- Dosya Okuma (Tüm İçeriği Okuma) ---
        Dim okunacakDosya As String = "C:\Temp\yazilacakDosyaDetayli.txt"

        ' Dosyanın var olup olmadığını kontrol etme
        If File.Exists(okunacakDosya) Then
            ' StreamReader kullanarak dosyadan tüm içeriği okuma
            Using reader As StreamReader = New StreamReader(okunacakDosya)
                Dim dosyaIcerigi As String = reader.ReadToEnd()
                Console.WriteLine("Dosya İçeriği:")
                Console.WriteLine(dosyaIcerigi)
            End Using

            Console.WriteLine("Dosya okuma işlemi tamamlandı.")
        Else
            Console.WriteLine("Dosya bulunamadı.")
        End If
    End Sub
End Module
