' Visual Basic (VB) - Ders 9

' Yorum Satırları: Kodun anlaşılması için yorumlar eklenir.

' --- İSTİSNALAR (EXCEPTIONS) ---

' İstisnalar, programın çalışması sırasında meydana gelen hataları işlemek için kullanılır.

' Örnek 1: Temel İstisna Yönetimi
Try
    ' Hata oluşturacak bir işlem
    Dim sayi1 As Integer = 5
    Dim sayi2 As Integer = 0
    Dim sonuc As Integer = sayi1 / sayi2 ' Hata: Sıfıra bölme

Catch ex As DivideByZeroException
    ' Sıfıra bölme hatası durumunda çalışacak kod bloğu
    Console.WriteLine("Hata: Sıfıra bölme!")
    
Catch ex As Exception
    ' Diğer türdeki hatalar durumunda çalışacak genel kod bloğu
    Console.WriteLine($"Bir hata oluştu: {ex.Message}")

Finally
    ' Her durumda çalışacak olan kod bloğu
    Console.WriteLine("İşlem tamamlandı.")
End Try

' Örnek 2: Kullanıcıdan Sayı Girişi Alma ve İstisna Yönetimi
Try
    Console.Write("Bir sayı girin: ")
    Dim kullaniciSayi As Integer = Integer.Parse(Console.ReadLine())
    Console.WriteLine($"Girilen sayı: {kullaniciSayi}")

Catch ex As FormatException
    Console.WriteLine("Hata: Geçersiz sayı formatı!")

Catch ex As Exception
    Console.WriteLine($"Bir hata oluştu: {ex.Message}")

Finally
    Console.WriteLine("İşlem tamamlandı.")
End Try
