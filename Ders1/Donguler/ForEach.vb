' Visual Basic (VB) - For Each Döngüsü

' Yorum Satırları: Kodun anlaşılması için yorumlar eklenir.

' --- FOR EACH DÖNGÜSÜ ---

' For Each döngüsü, bir koleksiyonun her elemanı üzerinde dolaşmak için kullanılır.

' Örnek 1: Bir Dizi Üzerinde Dolaşma
Dim sayilar() As Integer = {1, 2, 3, 4, 5}

Console.WriteLine("Dizi Elemanları:")
For Each sayi As Integer In sayilar
    Console.Write(sayi & " ")
Next sayi
Console.WriteLine()

' Örnek 2: Bir Liste Üzerinde Dolaşma
Dim meyveler As New List(Of String) From {"Elma", "Armut", "Çilek"}

Console.WriteLine("Meyve Listesi:")
For Each meyve As String In meyveler
    Console.Write(meyve & " ")
Next meyve
Console.WriteLine()

' Örnek 3: Bir String Üzerinde Karakterlere Dolaşma
Dim kelime As String = "Merhaba"

Console.WriteLine("Kelime Karakterleri:")
For Each harf As Char In kelime
    Console.Write(harf & " ")
Next harf
Console.WriteLine()

' Örnek 4: Bir Koleksiyon Üzerinde Dolaşma (ArrayList Kullanımı)
Dim koleksiyon As New ArrayList
koleksiyon.Add(10)
koleksiyon.Add("Merhaba")
koleksiyon.Add(True)

Console.WriteLine("Koleksiyon Elemanları:")
For Each eleman In koleksiyon
    Console.Write(eleman & " ")
Next eleman
Console.WriteLine()
