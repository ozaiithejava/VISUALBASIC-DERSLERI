Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class Server
    Private serverSocket As TcpListener
    Private clientSocket As TcpClient
    Private clientThreads As New List(Of Thread)()

    Public Sub StartServer()
        serverSocket = New TcpListener(IPAddress.Any, 8888)
        serverSocket.Start()

        Console.WriteLine("Sunucu başlatıldı. İstemcileri bekliyor...")

        Try
            While True
                clientSocket = serverSocket.AcceptTcpClient()

                Dim clientThread As New Thread(AddressOf HandleClient)
                clientThreads.Add(clientThread)
                clientThread.Start(clientSocket)
            End While
        Catch ex As Exception
            Console.WriteLine($"Hata: {ex.Message}")
        End Try
    End Sub

    Private Sub HandleClient(client As Object)
        Dim tcpClient As TcpClient = DirectCast(client, TcpClient)
        Dim clientStream As NetworkStream = tcpClient.GetStream()

        Dim message As Byte() = New Byte(4095) {}
        Dim bytesRead As Integer

        Try
            While True
                bytesRead = clientStream.Read(message, 0, message.Length)
                If bytesRead = 0 Then Exit While

                Dim encoder As New ASCIIEncoding()
                Console.WriteLine("İstemci: " + encoder.GetString(message, 0, bytesRead))
            End While
        Catch ex As Exception
            Console.WriteLine($"İstemci bağlantısı kesildi: {ex.Message}")
        End Try
    End Sub

    Public Sub StopServer()
        For Each thread In clientThreads
            thread.Abort()
        Next

        serverSocket.Stop()
        Console.WriteLine("Sunucu durduruldu.")
    End Sub
End Class

Module Program
    Dim server As New Server()

    Sub Main()
        server.StartServer()

        Console.WriteLine("Sunucuyu durdurmak için bir tuşa basın.")
        Console.ReadKey()

        server.StopServer()
    End Sub
End Module
