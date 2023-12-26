' Visual Basic (VB) - Tüm Exception Türlerini Kullanma

' Yorum Satırları: Kodun anlaşılması için yorumlar eklenir.

Try
    ' Hata oluşturacak bir işlem
    Dim sayi1 As Integer = 5
    Dim sayi2 As Integer = 0
    Dim sonuc As Integer = sayi1 / sayi2 ' Hata: Sıfıra bölme

    ' Format hatası oluşturacak bir işlem (Kullanıcıdan sayı bekler, ancak sayı yerine harf girerse)
    Console.Write("Bir sayı girin: ")
    Dim kullaniciSayi As Integer = Integer.Parse(Console.ReadLine())

    ' Dizide olmayan bir indeksi erişmeye çalışma
    Dim dizi() As Integer = {1, 2, 3}
    Dim eleman As Integer = dizi(10) ' Hata: Dizide olmayan bir indeksi erişme

Catch ex As DivideByZeroException
    Console.WriteLine("Hata: Sıfıra bölme!")

Catch ex As FormatException
    Console.WriteLine("Hata: Geçersiz sayı formatı!")

Catch ex As IndexOutOfRangeException
    Console.WriteLine("Hata: Dizide olmayan bir indeksi erişme!")

Catch ex As Exception
    ' Genel istisna durumunda çalışacak kod bloğu
    Console.WriteLine($"Bir hata oluştu: {ex.Message}")

Finally
    ' Her durumda çalışacak olan kod bloğu
    Console.WriteLine("İşlem tamamlandı.")
End Try
