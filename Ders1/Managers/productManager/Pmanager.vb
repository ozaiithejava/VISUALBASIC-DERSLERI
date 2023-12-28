Public Class ProductManager
    Private products As New List(Of Product)()

    Public Sub AddProduct(productName As String, productPrice As Decimal)
        Dim newProduct As New Product(productName, productPrice)
        products.Add(newProduct)
        Console.WriteLine($"Ürün eklenmiştir: {productName}")
    End Sub

    Public Sub UpdateProductPrice(productName As String, newPrice As Decimal)
        Dim productToUpdate = products.Find(Function(p) p.Name = productName)
        If productToUpdate IsNot Nothing Then
            productToUpdate.Price = newPrice
            Console.WriteLine($"Ürün fiyatı güncellenmiştir: {productName}, Yeni Fiyat: {newPrice}")
        Else
            Console.WriteLine($"Ürün bulunamadı: {productName}")
        End If
    End Sub

    Public Sub DisplayProductInfo()
        Console.WriteLine("----- Ürün Bilgileri -----")
        For Each product In products
            Console.WriteLine($"Ürün Adı: {product.Name}, Fiyat: {product.Price:C}")
        Next
        Console.WriteLine("--------------------------")
    End Sub

    Public Sub RemoveProduct(productName As String)
        Dim productToRemove = products.Find(Function(p) p.Name = productName)
        If productToRemove IsNot Nothing Then
            products.Remove(productToRemove)
            Console.WriteLine($"Ürün silinmiştir: {productName}")
        Else
            Console.WriteLine($"Ürün bulunamadı: {productName}")
        End If
    End Sub
End Class

Public Class Product
    Public Property Name As String
    Public Property Price As Decimal

    Public Sub New(name As String, price As Decimal)
        Me.Name = name
        Me.Price = price
    End Sub
End Class
