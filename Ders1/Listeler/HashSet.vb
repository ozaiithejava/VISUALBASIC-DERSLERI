Imports System.Collections.Generic

Public Class Form1
    Private Sub HashSetExample()
        ' HashSet oluşturma
        Dim fruitHashSet As New HashSet(Of String)()

        ' Eleman ekleme
        fruitHashSet.Add("Apple")
        fruitHashSet.Add("Banana")
        fruitHashSet.Add("Orange")

        ' Elemanları ekrana yazdırma
        For Each fruit In fruitHashSet
            Console.WriteLine(fruit)
        Next
    End Sub
End Class
