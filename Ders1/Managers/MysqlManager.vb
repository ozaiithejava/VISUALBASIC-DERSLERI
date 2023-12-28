Imports MySql.Data.MySqlClient
Imports System

Public Class MySQLManager
    Private connectionString As String
    Private connection As MySqlConnection

    Public Sub New(dbConnectionString As String)
        connectionString = dbConnectionString
        connection = New MySqlConnection(connectionString)
    End Sub

    Public Sub OpenConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
            Console.WriteLine("MySQL bağlantısı açıldı.")
        End If
    End Sub

    Public Sub CloseConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
            Console.WriteLine("MySQL bağlantısı kapatıldı.")
        End If
    End Sub

    Public Sub ExecuteNonQuery(query As String)
        Try
            OpenConnection()
            Using cmd As New MySqlCommand(query, connection)
                cmd.ExecuteNonQuery()
                Console.WriteLine("Sorgu başarıyla çalıştırıldı.")
            End Using
        Catch ex As Exception
            Console.WriteLine($"Hata: {ex.Message}")
        Finally
            CloseConnection()
        End Try
    End Sub

    Public Function ExecuteScalar(query As String) As Object
        Try
            OpenConnection()
            Using cmd As New MySqlCommand(query, connection)
                Return cmd.ExecuteScalar()
            End Using
        Catch ex As Exception
            Console.WriteLine($"Hata: {ex.Message}")
            Return Nothing
        Finally
            CloseConnection()
        End Try
    End Function
End Class

Module Program
    Sub Main()
        ' MySQL bağlantı dizesini buraya ekleyin
        Dim mysqlConnectionString As String = "Server=localhost;Database=your_database;User ID=root;Password=your_password;"

        ' MySQLManager örneği oluşturun
        Dim mysqlManager As New MySQLManager(mysqlConnectionString)

        ' MySQL sorgusu: Örnek bir tablo oluşturma
        Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS users (id INT AUTO_INCREMENT PRIMARY KEY, username VARCHAR(255))"
        mysqlManager.ExecuteNonQuery(createTableQuery)

        ' MySQL sorgusu: Veri ekleme
        Dim insertDataQuery As String = "INSERT INTO users (username) VALUES ('john_doe')"
        mysqlManager.ExecuteNonQuery(insertDataQuery)

        ' MySQL sorgusu: Veri sorgulama
        Dim selectDataQuery As String = "SELECT * FROM users"
        Dim result As Object = mysqlManager.ExecuteScalar(selectDataQuery)

        If result IsNot Nothing Then
            Console.WriteLine($"MySQL'den alınan veri: {result}")
        End If

        ' Konsolu açık tutmak için bekleme
        Console.ReadLine()
    End Sub
End Module
