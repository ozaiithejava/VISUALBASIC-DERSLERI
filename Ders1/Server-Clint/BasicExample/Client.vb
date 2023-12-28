Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class Client
    Private clientSocket As TcpClient
    Private clientThread As Thread

    Public Sub StartClient()
        clientSocket = New TcpClient()
        clientSocket.Connect("127.0.0.1", 8888)

        clientThread = New Thread(AddressOf ListenForMessages)
        clientThread.Start()
    End Sub

    Private Sub ListenForMessages()
        Dim message As Byte() = New Byte(4095) {}
        Dim bytesRead As Integer

        Try
            While True
                Dim clientStream As NetworkStream = clientSocket.GetStream()
                bytesRead = clientStream.Read(message, 0, message.Length)

                Dim encoder As New ASCIIEncoding()
                Console.WriteLine("Sunucu: " + encoder.GetString(message, 0, bytesRead))
            End While
        Catch ex As Exception
            Console.WriteLine($"Sunucu bağlantısı kesildi: {ex.Message}")
        End Try
    End Sub

    Public Sub SendMessage(message As String)
        Dim writer As New StreamWriter(clientSocket.GetStream())
        writer.Write(message)
        writer.Flush()
    End Sub

    Public Sub StopClient()
        clientThread.Abort()
        clientSocket.Close()
        Console.WriteLine("İstemci durduruldu.")
    End Sub
End Class

Module Program
    Dim client As New Client()

    Sub Main()
        client.StartClient()

        While True
            Console.Write("Mesaj girin (çıkmak için 'exit'): ")
            Dim input As String = Console.ReadLine()

            If input.ToLower() = "exit" Then
                Exit While
            Else
                client.SendMessage(input)
            End If
        End While

        client.StopClient()
    End Sub
End Module
