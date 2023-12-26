' ServiceStack.Redis kütüphanesini kullanabilmek için import ekleyin
Imports ServiceStack.Redis

Module Program
    Sub Main()
        ' Redis bağlantı bilgilerini belirtin
        Dim redisHost As String = "localhost"
        Dim redisPort As Integer = 6379

        ' Redis bağlantısını oluşturun
        Dim redisManager As New RedisManagerPool($"{redisHost}:{redisPort}")

        ' Redis client oluşturun
        Using redisClient As IRedisClient = redisManager.GetClient()
            ' String (tek bir değer) yazma
            redisClient.Set("myKey", "Hello, Redis!")

            ' String değeri okuma
            Dim value As String = redisClient.Get(Of String)("myKey")
            Console.WriteLine("myKey: " & value)

            ' Liste (list) yazma
            redisClient.AddItemToList("myList", "Item1")
            redisClient.AddItemToList("myList", "Item2")

            ' Liste değerini okuma
            Dim listItems As List(Of String) = redisClient.GetAllItemsFromList("myList")
            Console.WriteLine("myList: " & String.Join(", ", listItems))
        End Using
    End Sub
End Module
