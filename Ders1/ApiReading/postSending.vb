Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks

Public Class Form1
    Private Async Sub btnSendPost_Click(sender As Object, e As EventArgs) Handles btnSendPost.Click
        ' API URL'i
        Dim apiUrl As String = "https://jsonplaceholder.typicode.com/posts"

        ' HttpClient oluşturma
        Using httpClient As New HttpClient()
            Try
                ' Gönderilecek JSON verisi
                Dim postData As String = "{ ""title"": ""Sample Title"", ""body"": ""Sample Body"", ""userId"": 1 }"

                ' JSON verisini StringContent nesnesine dönüştürme
                Dim content As New StringContent(postData, Encoding.UTF8, "application/json")

                ' API'ye Post isteği gönderme
                Dim response As HttpResponseMessage = Await httpClient.PostAsync(apiUrl, content)

                ' Başarılı bir yanıt alındıysa devam et
                If response.IsSuccessStatusCode Then
                    ' Yanıttan JSON verisini al
                    Dim jsonString As String = Await response.Content.ReadAsStringAsync()

                    ' JSON verisini ekrana yazdır
                    Console.WriteLine(jsonString)
                Else
                    ' Başarısız yanıt durumunu işle
                    Console.WriteLine($"API'ye Post isteği gönderilemedi. Durum Kodu: {response.StatusCode}")
                End If
            Catch ex As Exception
                ' Hata durumunu işle
                Console.WriteLine($"Hata: {ex.Message}")
            End Try
        End Using
    End Sub
End Class
