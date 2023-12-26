Imports System.Collections.Generic

Public Class Form1
    Private Sub HashMapExample()
        ' HashMap (Dictionary) oluşturma
        Dim fruitDictionary As New Dictionary(Of String, Integer)()

        ' Anahtar-değer çifti ekleme
        fruitDictionary("Apple") = 3
        fruitDictionary("Banana") = 2
        fruitDictionary("Orange") = 5

        ' Değerlere erişme
        Dim appleQuantity As Integer = fruitDictionary("Apple")
        Console.WriteLine("Apple Quantity: " & appleQuantity)
    End Sub
End Class
