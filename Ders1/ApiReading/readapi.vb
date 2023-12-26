Imports System.Net.Http
Imports System.Threading.Tasks

Public Class Form1
    Private Async Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        ' API URL'i
        Dim apiUrl As String = "https://jsonplaceholder.typicode.com/todos/1"

        ' HttpClient oluşturma
        Using httpClient As New HttpClient()
            Try
                ' API'den veriyi al
                Dim response As HttpResponseMessage = Await httpClient.GetAsync(apiUrl)

                ' Başarılı bir yanıt alındıysa devam et
                If response.IsSuccessStatusCode Then
                    ' Yanıttan JSON verisini al
                    Dim jsonString As String = Await response.Content.ReadAsStringAsync()

                    ' JSON verisini ekrana yazdır
                    Console.WriteLine(jsonString)
                Else
                    ' Başarısız yanıt durumunu işle
                    Console.WriteLine($"API'den veri alınamadı. Durum Kodu: {response.StatusCode}")
                End If
            Catch ex As Exception
                ' Hata durumunu işle
                Console.WriteLine($"Hata: {ex.Message}")
            End Try
        End Using
    End Sub
End Class
