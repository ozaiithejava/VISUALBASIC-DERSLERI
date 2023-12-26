' Visual Basic (VB) - Abstract Class (Soyut Sınıf)

' Yorum Satırları: Kodun anlaşılması için yorumlar eklenir.

' --- ABSTRACT CLASS (SOYUT SINIF) ---

' Soyut sınıflar, genel bir şablon sağlamak ve alt sınıfların bu şablona uymasını zorlamak için kullanılır.

' Örnek: Sekil Soyut Sınıfı
MustInherit Class Sekil
    ' Soyut metod - Alt sınıflar bu metodu implement etmek zorundadır
    Public MustOverride Sub AlanHesapla()

    ' Normal metot - Alt sınıflar bu metodu override edebilir
    Public Sub BilgiGoster()
        Console.WriteLine("Bu bir şekildir.")
    End Sub
End Class

' Kare sınıfı, Sekil soyut sınıfından türetilir
Class Kare
    Inherits Sekil

    ' Soyut metodun implementasyonu
    Public Overrides Sub AlanHesapla()
        Console.WriteLine("Kare alanı hesaplandı.")
    End Sub
End Class

' Daire sınıfı, Sekil soyut sınıfından türetilir
Class Daire
    Inherits Sekil

    ' Soyut metodun implementasyonu
    Public Overrides Sub AlanHesapla()
        Console.WriteLine("Daire alanı hesaplandı.")
    End Sub
End Class

' Kullanım örneği
Dim kare1 As New Kare()
Dim daire1 As New Daire()

' Alan hesaplamaları
kare1.AlanHesapla() ' Kare sınıfından türetilen bir nesnenin alan hesaplaması
daire1.AlanHesapla() ' Daire sınıfından türetilen bir nesnenin alan hesaplaması

' Genel bilgi gösterme
kare1.BilgiGoster() ' Kare sınıfından türetilen bir nesnenin genel bilgi göstermesi
daire1.BilgiGoster() ' Daire sınıfından türetilen bir nesnenin genel bilgi göstermesi
