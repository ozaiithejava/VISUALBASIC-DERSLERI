' Visual Basic (VB) - Ders 3

' Yorum Satırları: Kodun anlaşılması için yorumlar eklenir.

' --- FONKSİYONLAR (Functions) ---

' Fonksiyonlar, belirli bir görevi yerine getiren ve bir değer döndüren alt programlardır.

' Örnek 1: Toplama Fonksiyonu
Function Topla(a As Integer, b As Integer) As Integer
    Return a + b
End Function

Dim sonucToplama As Integer = Topla(5, 3)
Console.WriteLine("Toplama Sonucu: " & sonucToplama) ' Çıktı: 8

' Örnek 2: Çarpma Fonksiyonu
Function Carp(a As Double, b As Double) As Double
    Return a * b
End Function

Dim sonucCarpma As Double = Carp(2.5, 4.0)
Console.WriteLine("Çarpma Sonucu: " & sonucCarpma) ' Çıktı: 10.0

' Örnek 3: Metin Birleştirme Fonksiyonu
Function Birlestir(isim As String, soyisim As String) As String
    Return isim & " " & soyisim
End Function

Dim tamIsim As String = Birlestir("Ahmet", "Yılmaz")
Console.WriteLine("Birleştirilen İsim: " & tamIsim) ' Çıktı: Ahmet Yılmaz

' --- KOŞUL İFADELERİ (Conditional Statements) ---

' Koşul ifadeleri, belirli şartlara bağlı olarak farklı kod bloklarının çalışmasını sağlar.

' Örnek 4: Yaşa Göre Mesaj Veren Program
Dim yas As Integer = 25

If yas < 18 Then
    Console.WriteLine("Ergensin.")
ElseIf yas >= 18 AndAlso yas < 65 Then
    Console.WriteLine("Yetişkinsin.")
Else
    Console.WriteLine("Yaşlısın.")
End If

' Örnek 5: Tek veya Çift Sayı Kontrolü
Dim sayiKontrol As Integer = 7

If sayiKontrol Mod 2 = 0 Then
    Console.WriteLine("Sayı çifttir.")
Else
    Console.WriteLine("Sayı tektir.")
End If

' --- DÖNGLER (Loops) ---

' Döngüler, belirli bir işlemi tekrarlamak için kullanılır.

' Örnek 6: For Döngüsü
Console.WriteLine("1'den 5'e Kadar Olan Sayılar:")
For j = 1 To 5
    Console.Write(j & " ")
Next j
Console.WriteLine()

' Örnek 7: While Döngüsü
Dim sayac As Integer = 0

While sayac < 3
    Console.WriteLine("Döngü {0}", sayac)
    sayac += 1
End While
