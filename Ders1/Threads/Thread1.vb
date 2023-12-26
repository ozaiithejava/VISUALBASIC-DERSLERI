Imports System.Threading

Public Class Form1
    Private Sub btnStartThread_Click(sender As Object, e As EventArgs) Handles btnStartThread.Click
        Dim thread As New Thread(AddressOf WorkerMethod)
        thread.Start()
    End Sub

    Private Sub WorkerMethod()
        ' Burada thread tarafından gerçekleştirilecek işlemleri tanımlayın
        For i As Integer = 1 To 5
            Console.WriteLine($"Thread çalışıyor... Adım: {i}")
            Thread.Sleep(1000) ' 1 saniye bekle
        Next
    End Sub
End Class
