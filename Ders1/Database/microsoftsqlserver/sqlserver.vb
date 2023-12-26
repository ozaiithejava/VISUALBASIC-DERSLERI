Imports System.Data.SqlClient

Public Class Form1
    ' SQL Server bağlantı dizesi
    Dim connectionString As String = "Data Source=your_server;Initial Catalog=your_database;User ID=your_username;Password=your_password"
    Dim connection As SqlConnection = New SqlConnection(connectionString)

    ' Veritabanı ve tablo oluşturma butonu
    Private Sub btnCreateDatabase_Click(sender As Object, e As EventArgs) Handles btnCreateDatabase.Click
        Try
            ' Veritabanı oluşturma sorgusu
            Dim createDatabaseQuery As String = "CREATE DATABASE mydatabase"
            ExecuteQuery(createDatabaseQuery)

            ' Kullanılacak veritabanını seç
            connection.ChangeDatabase("mydatabase")

            ' Tablo oluşturma sorgusu
            Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS users (id INT PRIMARY KEY, name NVARCHAR(50), age INT)"
            ExecuteQuery(createTableQuery)

            MessageBox.Show("Veritabanı ve Tablo Oluşturuldu!")
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub

    ' Veri ekleme butonu
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            ' Kullanıcıdan alınan veriler
            Dim userId As Integer = Convert.ToInt32(txtId.Text)
            Dim userName As String = txtName.Text
            Dim userAge As Integer = Convert.ToInt32(txtAge.Text)

            ' Veri ekleme sorgusu
            Dim insertQuery As String = $"INSERT INTO users (id, name, age) VALUES ({userId}, N'{userName}', {userAge})"
            ExecuteQuery(insertQuery)

            MessageBox.Show("Veri Eklendi!")
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub

    ' Veri silme butonu
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Kullanıcıdan alınan ID
            Dim userId As Integer = Convert.ToInt32(txtDeleteId.Text)

            ' Veri silme sorgusu
            Dim deleteQuery As String = $"DELETE FROM users WHERE id = {userId}"
            ExecuteQuery(deleteQuery)

            MessageBox.Show("Veri Silindi!")
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub

    ' Veri sorgulama butonu
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            ' Sorgu yapısı
            Dim selectQuery As String = "SELECT * FROM users"

            ' Sorguyu çalıştır ve sonuçları oku
            Using command As New SqlCommand(selectQuery, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                ' Sonuçları işle
                While reader.Read()
                    Dim userId As Integer = reader.GetInt32(0)
                    Dim userName As String = reader.GetString(1)
                    Dim userAge As Integer = reader.GetInt32(2)

                    ' Sonuçları ekrana yazdır
                    lstResults.Items.Add($"ID: {userId}, Name: {userName}, Age: {userAge}")
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Genel SQL sorgularını çalıştırmak için kullanılan yardımcı fonksiyon
    Private Sub ExecuteQuery(query As String)
        Try
            ' Bağlantıyı aç
            connection.Open()

            ' SQL komut nesnesi oluştur
            Using command As New SqlCommand(query, connection)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        Finally
            ' Bağlantıyı kapat
            connection.Close()
        End Try
    End Sub
End Class
