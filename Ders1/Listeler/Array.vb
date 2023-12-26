Public Class Form1
    Private Sub ArrayExample()
        ' Dizi oluşturma
        Dim fruits(2) As String

        ' Elemanları diziye ekleme
        fruits(0) = "Apple"
        fruits(1) = "Banana"
        fruits(2) = "Orange"

        ' Elemanları ekrana yazdırma
        For Each fruit In fruits
            Console.WriteLine(fruit)
        Next
    End Sub
End Class
