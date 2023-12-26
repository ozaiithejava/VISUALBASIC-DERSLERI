' Visual Basic (VB) - Enum (Numaralandırma)

' Yorum Satırları: Kodun anlaşılması için yorumlar eklenir.

' --- ENUM TÜRÜ ---

' Enum, belirli değerleri isimlendirmek için kullanılır.

' Örnek: Ay Numaralandırması
Enum Aylar
    Ocak = 1
    Subat
    Mart
    Nisan
    Mayis
    Haziran
    Temmuz
    Agustos
    Eylul
    Ekim
    Kasim
    Aralik
End Enum

' Enum kullanımı
Dim simdikiAy As Aylar = Aylar.Ocak
Console.WriteLine("Şu anki ay: " & simdikiAy) ' Çıktı: Ocak

' Enum içindeki değerlere erişim
Dim martAy As Integer = Aylar.Mart
Console.WriteLine("Mart ayının numarası: " & martAy) ' Çıktı: 3
