Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks

Public Class WebhookManager
    Private Shared webhookUrl As String = "YOUR_WEBHOOK_URL"

    Public Shared Async Function CreateWebhook(webhookName As String) As Task(Of String)
        Using httpClient As New HttpClient()
            ' Discord API'ye yeni bir Webhook oluşturma isteği gönderme
            Dim requestBody As String = $"{{ ""name"": ""{webhookName}"" }}"
            Dim content As New StringContent(requestBody, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await httpClient.PostAsync(webhookUrl, content)

            ' Başarılı bir yanıt alındıysa Webhook URL'sini döndürme
            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Return jsonResponse
            Else
                ' Başarısız yanıt durumunu konsola yazdırma
                Console.WriteLine($"Webhook oluşturma başarısız. Durum Kodu: {response.StatusCode}")
                Return String.Empty
            End If
        End Using
    End Function

    Public Shared Async Function SendMessage(messageContent As String, username As String) As Task
        Using httpClient As New HttpClient()
            ' Discord API'ye Webhook üzerinden mesaj gönderme isteği gönderme
            Dim requestBody As String = $"{{ ""content"": ""{messageContent}"", ""username"": ""{username}"" }}"
            Dim content As New StringContent(requestBody, Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await httpClient.PostAsync(webhookUrl, content)

            ' Başarılı bir yanıt alındıysa
            If response.IsSuccessStatusCode Then
                Console.WriteLine("Mesaj başarıyla gönderildi.")
            Else
                ' Başarısız yanıt durumunu konsola yazdırma
                Console.WriteLine($"Mesaj gönderme başarısız. Durum Kodu: {response.StatusCode}")
            End If
        End Using
    End Function
End Class

Module Program
    Sub Main()
        MainAsync().GetAwaiter().GetResult()
    End Sub

    Async Function MainAsync() As Task
        ' Yeni bir Webhook oluşturma
        Dim createdWebhook As String = Await WebhookManager.CreateWebhook("MyWebhook")
        Console.WriteLine($"Oluşturulan Webhook: {createdWebhook}")

        ' Webhook üzerinden mesaj gönderme
        Await WebhookManager.SendMessage("Merhaba, bu bir test mesajıdır.", "MyBot")

        Console.ReadLine() ' Konsolun kapanmaması için bekleme
    End Function
End Module
