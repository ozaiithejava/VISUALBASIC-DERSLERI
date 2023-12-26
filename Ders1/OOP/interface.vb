' Visual Basic (VB) - Interface (Arayüz)

' Yorum Satırları: Kodun anlaşılması için yorumlar eklenir.

' --- INTERFACE (ARAYÜZ) ---

' Interface, bir sınıfın veya türün uyması gereken metotları, özellikleri ve olayları tanımlar.

' Örnek: IYazdirabilir Arayüzü
Interface IYazdirabilir
    Sub Yazdir() ' Yazdır metodu tanımlanıyor
End Interface

' Sınıf, belirli bir arayüzü uyguluyor
Class Rapor
    Implements IYazdirabilir ' Rapor sınıfı, IYazdirabilir arayüzünü uygular

    ' Arayüzden alınan metodu implement etme
    Public Sub Yazdir() Implements IYazdirabilir.Yazdir
        Console.WriteLine("Rapor yazdırılıyor...")
    End Sub
End Class

' Kullanım örneği
Dim rapor1 As New Rapor()
rapor1.Yazdir() ' Rapor sınıfının Yazdir metodu çağrılır
