Dim productManager As New ProductManager()

productManager.AddProduct("Laptop", 1500.0D)
productManager.AddProduct("Smartphone", 800.0D)
productManager.DisplayProductInfo()

productManager.UpdateProductPrice("Laptop", 1600.0D)
productManager.DisplayProductInfo()

productManager.RemoveProduct("Smartphone")
productManager.DisplayProductInfo()
