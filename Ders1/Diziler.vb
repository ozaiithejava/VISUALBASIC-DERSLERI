' Visual Basic (VB) - Dizi İşlemleri

' Dizi Tanımlama ve Elemanlara Değer Atama
Dim sayilar(4) As Integer ' 0'dan 4'e kadar olan 5 elemanlı bir tamsayı dizisi
sayilar(0) = 10
sayilar(1) = 20
sayilar(2) = 30
sayilar(3) = 40
sayilar(4) = 50

' Dizi Elemanlarına Erişim
Console.WriteLine(sayilar(2)) ' Çıktı: 30

' Dizi Elemanlarını Toplama
Dim toplam As Integer = 0
For i = 0 To 4
    toplam += sayilar(i)
Next i
Console.WriteLine("Dizi Elemanları Toplamı: " & toplam) ' Çıktı: 150

' Dizi Elemanlarını Ekrana Yazdırma
Console.WriteLine("Dizi Elemanları:")
For i = 0 To 4
    Console.Write(sayilar(i) & " ")
Next i
Console.WriteLine() ' Yeni bir satıra geç

' Dizi Sıralama ve Ters Çevirme
Array.Sort(sayilar) ' Küçükten büyüğe sırala
Array.Reverse(sayilar) ' Ters çevir

Console.WriteLine("Ters Çevrilen Dizi Elemanları:")
For i = 0 To 4
    Console.Write(sayilar(i) & " ")
Next i
Console.WriteLine()
