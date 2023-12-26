Imports System.Collections.Generic

Public Class Form1
    Private Sub TreeMapExample()
        ' TreeMap (SortedDictionary) oluşturma
        Dim fruitTreeMap As New SortedDictionary(Of String, Integer)()

        ' Anahtar-değer çifti ekleme
        fruitTreeMap("Apple") = 3
        fruitTreeMap("Banana") = 2
        fruitTreeMap("Orange") = 5

        ' Anahtarları ekrana yazdırma
        For Each fruit In fruitTreeMap.Keys
            Console.WriteLine(fruit & ": " & fruitTreeMap(fruit))
        Next
    End Sub
End Class
