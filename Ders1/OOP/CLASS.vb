' Visual Basic (VB) - Ders 6

' Yorum Satırları: Kodun anlaşılması için yorumlar eklenir.

' --- NESNE YÖNELİMLİ PROGRAMLAMA (OOP) ---

' Nesne Yönelimli Programlama (OOP), gerçek dünyadaki nesneleri modelleme üzerine kuruludur.

' Örnek 1: Sınıf Tanımlama ve Nesne Oluşturma
Class Araba
    ' Sınıfın özellikleri (alanları)
    Public Marka As String
    Public Model As String
    Public Renk As String

    ' Sınıfın davranışları (metodları)
    Public Sub Calis()
        Console.WriteLine("Araba çalıştı.")
    End Sub

    Public Sub Dur()
        Console.WriteLine("Araba durdu.")
    End Sub
End Class

' Araba sınıfından nesne oluşturma
Dim myCar As New Araba()

' Araba özelliklerine değer atama
myCar.Marka = "Toyota"
myCar.Model = "Corolla"
myCar.Renk = "Mavi"

' Araba metodlarını çağırma
myCar.Calis()
myCar.Dur()

' --- KALITIM (Inheritance) ---

' Kalıtım, bir sınıfın başka bir sınıftan özelliklerini ve davranışlarını miras almasıdır.

' Örnek 2: Hayvan Sınıfı ve Kalıtım
Class Hayvan
    Public Ad As String

    Public Sub YemekYe()
        Console.WriteLine("Hayvan yemek yiyor.")
    End Sub
End Class

' Kedi sınıfı, Hayvan sınıfından kalıtım alır
Class Kedi
    Inherits Hayvan

    ' Kedi sınıfına özgü özellikler veya davranışlar eklenir
    Public Sub Miyavla()
        Console.WriteLine("Kedi miyavladı.")
    End Sub
End Class

' Kedi sınıfından nesne oluşturma
Dim benimKedim As New Kedi()

' Hayvan özelliklerine ve metodlarına erişim
benimKedim.Ad = "Whiskers"
benimKedim.YemekYe()

' Kedi sınıfına özgü metodları çağırma
benimKedim.Miyavla()
