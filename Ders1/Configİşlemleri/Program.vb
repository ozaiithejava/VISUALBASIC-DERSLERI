' YamlDotNet kütüphanesini kullanabilmek için import ekleyin
Imports YamlDotNet.Serialization
Imports System.IO

Module Program
    Sub Main()
        ' YAML dosyasını okuma
        Dim yamlFilePath As String = "C:\Temp\config.yaml"

        If File.Exists(yamlFilePath) Then
            Dim deserializer As New Deserializer()
            Dim yamlContent As String = File.ReadAllText(yamlFilePath)

            ' YAML içeriğini bir nesneye dönüştürme
            Dim data As Object = deserializer.Deserialize(New StringReader(yamlContent))

            ' Veriyi kullanma
            Console.WriteLine("Server IP: " & data("server")("ip"))
            Console.WriteLine("Database Name: " & data("database")("name"))

            ' YAML içeriğini nesne olarak değiştirme
            data("users")(0)("name") = "Charlie"

            ' YAML dosyasına yazma
            Dim serializer As New SerializerBuilder().Build()
            Dim updatedYamlContent As String = serializer.Serialize(data)

            File.WriteAllText(yamlFilePath, updatedYamlContent)

            Console.WriteLine("YAML dosyası güncellendi.")
        Else
            Console.WriteLine("YAML dosyası bulunamadı.")
        End If
    End Sub
End Module
