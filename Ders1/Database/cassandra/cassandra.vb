Imports Cassandra

Public Class Form1
    ' Cassandra bağlantı noktaları ve anahtar alanı
    Dim cluster As Cluster = Cluster.Builder().AddContactPoints("127.0.0.1").Build()
    Dim session As ISession = cluster.Connect("mykeyspace")

    ' Form yüklendiğinde çalışacak işlemler
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cassandra keyspace ve tablo oluştur
        CreateKeyspaceAndTable()
    End Sub

    ' Veritabanı ve tablo oluşturmayı sağlayan fonksiyon
    Private Sub CreateKeyspaceAndTable()
        Try
            ' Keyspace (veritabanı) oluşturma sorgusu
            Dim createKeyspaceQuery As String = "CREATE KEYSPACE IF NOT EXISTS mykeyspace WITH replication = {'class':'SimpleStrategy', 'replication_factor':3}"
            session.Execute(createKeyspaceQuery)

            ' Kullanılacak keyspace'i seç
            session = cluster.Connect("mykeyspace")

            ' Tablo oluşturma sorgusu
            Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS users (id UUID PRIMARY KEY, name TEXT, age INT)"
            session.Execute(createTableQuery)
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub

    ' Veri ekleme işlemi
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            ' Yeni bir UUID oluştur
            Dim newId As Guid = Guid.NewGuid()

            ' Kullanıcıdan alınan veriler
            Dim name As String = txtName.Text
            Dim age As Integer = Convert.ToInt32(txtAge.Text)

            ' Veri ekleme sorgusu
            Dim insertQuery As String = $"INSERT INTO users (id, name, age) VALUES ({newId}, '{name}', {age})"
            session.Execute(insertQuery)

            MessageBox.Show("Veri Eklendi!")
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub

    ' Veri silme işlemi
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Kullanıcıdan alınan ID
            Dim deleteId As Guid = Guid.Parse(txtDeleteId.Text)

            ' Veri silme sorgusu
            Dim deleteQuery As String = $"DELETE FROM users WHERE id = {deleteId}"
            session.Execute(deleteQuery)

            MessageBox.Show("Veri Silindi!")
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub

    ' Veri sorgulama işlemi
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            ' Sorgu yapısı
            Dim selectQuery As String = "SELECT * FROM users"

            ' Sorguyu çalıştır
            Dim resultSet As RowSet = session.Execute(selectQuery)

            ' Sonuçları işle
            For Each row As Row In resultSet
                Dim userId As Guid = row.GetValue(Of Guid)("id")
                Dim userName As String = row.GetValue(Of String)("name")
                Dim userAge As Integer = row.GetValue(Of Integer)("age")

                ' Sonuçları ekrana yazdır
                lstResults.Items.Add($"ID: {userId}, Name: {userName}, Age: {userAge}")
            Next
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub
End Class
