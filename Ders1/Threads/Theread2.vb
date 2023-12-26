Imports System.Threading

Public Class Form1
    Private counter As Integer
    Private lockObject As New Object()

    Private Sub btnIncrement_Click(sender As Object, e As EventArgs) Handles btnIncrement.Click
        Dim thread As New Thread(AddressOf IncrementCounter)
        thread.Start()
    End Sub

    Private Sub IncrementCounter()
        ' Thread güvenliği için kilitleme mekanizması kullanılıyor
        SyncLock lockObject
            counter += 1
            Console.WriteLine($"Counter değeri: {counter}")
        End SyncLock
    End Sub
End Class
