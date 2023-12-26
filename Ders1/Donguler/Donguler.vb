' Visual Basic (VB) - Döngüler

' Yorum Satırları: Kodun anlaşılması için yorumlar eklenir.

' --- FOR DÖNGÜSÜ ---

' For döngüsü, belirli bir aralıktaki sayıları veya öğeleri üzerinde dolaşmak için kullanılır.

' Örnek 1: 1'den 5'e Kadar Olan Sayıları Yazdırma
Console.WriteLine("For Döngüsü İle Sayılar:")
For i = 1 To 5
    Console.Write(i & " ")
Next i
Console.WriteLine()

' Örnek 2: Çift Sayıları Yazdırma
Console.WriteLine("2'ye Bölünebilen Sayılar:")
For j = 1 To 10
    If j Mod 2 = 0 Then
        Console.Write(j & " ")
    End If
Next j
Console.WriteLine()

' --- WHILE DÖNGÜSÜ ---

' While döngüsü, belirli bir şart sağlandığı sürece bir kod bloğunu tekrarlar.

' Örnek 3: Sayıları 3'e Kadar Yazdırma
Console.WriteLine("While Döngüsü İle Sayılar:")
Dim sayac As Integer = 1
While sayac <= 3
    Console.Write(sayac & " ")
    sayac += 1
End While
Console.WriteLine()

' Örnek 4: Kullanıcının Girdiği Sayıya Kadar Olan Sayıları Yazdırma
Console.WriteLine("Kullanıcının Girdiği Sayıya Kadar Olan Sayılar:")
Console.Write("Bir sayı girin: ")
Dim limit As Integer = CInt(Console.ReadLine())
Dim index As Integer = 1

While index <= limit
    Console.Write(index & " ")
    index += 1
End While
Console.WriteLine()
