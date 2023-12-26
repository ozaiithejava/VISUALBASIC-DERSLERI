Imports MySql.Data.MySqlClient

Public Class Form1
    ' MySQL veritabanı bağlantısı için kullanılan bağlantı dizesi
    Dim connectionString As String = "server=your_server;user id=your_username;password=your_password;database=your_database"

    ' Bağlantı nesnesi oluşturuluyor
    Dim connection As MySqlConnection = New MySqlConnection(connectionString)

    ' Tablo oluşturma butonuna tıklandığında çalışacak işlemler
    Private Sub btnTabloOlustur_Click(sender As Object, e As EventArgs) Handles btnTabloOlustur.Click
        ' Yeni bir tablo oluşturma sorgusu
        Dim query As String = "CREATE TABLE IF NOT EXISTS Ogrenciler (Id INT AUTO_INCREMENT PRIMARY KEY, Ad VARCHAR(50), Soyad VARCHAR(50))"

        ' Oluşturulan sorguyu çalıştırmak için yardımcı fonksiyon çağrılıyor
        ExecuteQuery(query)

        ' Kullanıcıya tablonun oluşturulduğuna dair bilgi veriliyor
        MessageBox.Show("Tablo Oluşturuldu!")
    End Sub

    ' Veri ekleme butonuna tıklandığında çalışacak işlemler
    Private Sub btnVeriEkle_Click(sender As Object, e As EventArgs) Handles btnVeriEkle.Click
        ' Kullanıcıdan alınan ad ve soyad bilgileri
        Dim ad As String = txtAd.Text
        Dim soyad As String = txtSoyad.Text

        ' Veri ekleme sorgusu
        Dim query As String = "INSERT INTO Ogrenciler (Ad, Soyad) VALUES (@ad, @soyad)"

        ' Oluşturulan sorguyu çalıştırmak için yardımcı fonksiyon çağrılıyor
        ExecuteParameterizedQuery(query, "@ad", ad, "@soyad", soyad)

        ' Kullanıcıya veri eklendiğine dair bilgi veriliyor
        MessageBox.Show("Veri Eklendi!")
    End Sub

    ' Veri güncelleme butonuna tıklandığında çalışacak işlemler
    Private Sub btnVeriGuncelle_Click(sender As Object, e As EventArgs) Handles btnVeriGuncelle.Click
        ' Kullanıcıdan alınan güncellenecek verinin ID'si, yeni ad ve soyad bilgileri
        Dim id As Integer = Convert.ToInt32(txtID.Text)
        Dim yeniAd As String = txtYeniAd.Text
        Dim yeniSoyad As String = txtYeniSoyad.Text

        ' Veri güncelleme sorgusu
        Dim query As String = "UPDATE Ogrenciler SET Ad = @yeniAd, Soyad = @yeniSoyad WHERE Id = @id"

        ' Oluşturulan sorguyu çalıştırmak için yardımcı fonksiyon çağrılıyor
        ExecuteParameterizedQuery(query, "@yeniAd", yeniAd, "@yeniSoyad", yeniSoyad, "@id", id)

        ' Kullanıcıya veri güncellendiğine dair bilgi veriliyor
        MessageBox.Show("Veri Güncellendi!")
    End Sub

    ' Veri silme butonuna tıklandığında çalışacak işlemler
    Private Sub btnVeriSil_Click(sender As Object, e As EventArgs) Handles btnVeriSil.Click
        ' Kullanıcıdan alınan silinecek verinin ID'si
        Dim id As Integer = Convert.ToInt32(txtID.Text)

        ' Veri silme sorgusu
        Dim query As String = "DELETE FROM Ogrenciler WHERE Id = @id"

        ' Oluşturulan sorguyu çalıştırmak için yardımcı fonksiyon çağrılıyor
        ExecuteParameterizedQuery(query, "@id", id)

        ' Kullanıcıya veri silindiğine dair bilgi veriliyor
        MessageBox.Show("Veri Silindi!")
    End Sub

    ' Genel SQL sorgularını çalıştırmak için kullanılan yardımcı fonksiyon
    Private Sub ExecuteQuery(query As String)
        Try
            ' Bağlantıyı aç
            connection.Open()

            ' MySQL komut nesnesi oluştur
            Dim cmd As MySqlCommand = New MySqlCommand(query, connection)

            ' Sorguyu çalıştır
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            ' Hata durumunda kullanıcıya bilgi ver
            MessageBox.Show("Hata: " & ex.Message)
        Finally
            ' Bağlantıyı kapat
            connection.Close()
        End Try
    End Sub

    ' Parametreli SQL sorgularını çalıştırmak için kullanılan yardımcı fonksiyon
    Private Sub ExecuteParameterizedQuery(query As String, ParamArray parameters As Object())
        Try
            ' Bağlantıyı aç
            connection.Open()

            ' MySQL komut nesnesi oluştur
            Dim cmd As MySqlCommand = New MySqlCommand(query, connection)

            ' Parametreleri sorguya ekle
            For i As Integer = 0 To parameters.Length - 1 Step 2
                cmd.Parameters.AddWithValue(parameters(i).ToString(), parameters(i + 1))
            Next

            ' Sorguyu çalıştır
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            ' Hata durumunda kullanıcıya bilgi ver
            MessageBox.Show("Hata: " & ex.Message)
        Finally
            ' Bağlantıyı kapat
            connection.Close()
        End Try
    End Sub
End Class
