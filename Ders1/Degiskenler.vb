' Bu bir yorum satırıdır. Kodun anlaşılması için açıklama eklemek önemlidir.

' Integer: Tam sayıları temsil eder.
Dim sayi As Integer
sayi = 10

' Double: Ondalıklı sayıları temsil eder.
Dim ondalikSayi As Double
ondalikSayi = 3.14

' String: Metin verilerini temsil eder.
Dim metin As String
metin = "Merhaba, Dünya!"

' Boolean: Mantıksal değerleri temsil eder (True veya False).
Dim dogruMu As Boolean
dogruMu = True

' Char: Tek karakteri temsil eder.
Dim karakter As Char
karakter = "A"c

' Date: Tarih ve saat bilgisini temsil eder.
Dim bugun As Date
bugun = Date.Today

' Object: Her türlü nesneyi temsil eder.
Dim obje As Object
obje = New Object()

' Değişkenleri bir arada tanımlama:
Dim x As Integer = 5, y As Double = 3.0, isim As String = "John"

' Türlü Değişkenler (Type Inference) - Değişken türünü belirtmeden de tanımlama:
Dim sayi2 = 20
Dim ondalikSayi2 = 5.5
Dim isim2 = "Alice"

' Türlü değişkenler, değişkenin ilk atama değerine göre türünü belirler.

' Sabitler (Constants):
Const PI As Double = 3.14159265359
Const GUN As String = "Pazartesi"

' Not: Değişken isimleri anlamlı ve açıklayıcı olmalıdır. CamelCase tercih edilen isimleme stili.
' Örneğin: kucukHarfliDegisken, buyukHarfleBaslayanDegisken

' Kullanılan veri tiplerine göre matematiksel işlemler:
Dim toplam As Integer
toplam = sayi + 5

Dim carpim As Double
carpim = ondalikSayi * 2.0

' Metin birleştirme:
Dim tamIsim As String
tamIsim = "John" & " " & "Doe"

' Mantıksal işlemler:
Dim sonuc As Boolean
sonuc = (sayi > 5) AndAlso (ondalikSayi < 4.0)

' Tarih ve saat işlemleri:
Dim yarin As Date
yarin = bugun.AddDays(1)
