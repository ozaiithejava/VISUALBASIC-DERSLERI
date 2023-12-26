Imports MongoDB.Driver
Imports MongoDB.Bson

Public Class Form1
    ' MongoDB bağlantı adresi
    Dim connectionString As String = "mongodb://localhost:27017"
    ' MongoDB istemcisini oluştur
    Dim client As MongoClient = New MongoClient(connectionString)
    ' Veritabanı adı
    Dim dbName As String = "myDatabase"
    ' Koleksiyon adı
    Dim collectionName As String = "myCollection"
    ' MongoDB veritabanı nesnesi
    Dim database As IMongoDatabase = client.GetDatabase(dbName)
    ' MongoDB koleksiyon nesnesi
    Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionName)

    ' Veritabanı ve koleksiyon oluşturma butonu
    Private Sub btnCreateDatabase_Click(sender As Object, e As EventArgs) Handles btnCreateDatabase.Click
        ' Veritabanı ve koleksiyonu oluştur
        database.CreateCollection(collectionName)
        MessageBox.Show("Veritabanı ve Koleksiyon Oluşturuldu!")
    End Sub

    ' Belge ekleme butonu
    Private Sub btnInsertDocument_Click(sender As Object, e As EventArgs) Handles btnInsertDocument.Click
        ' Yeni bir belge oluştur
        Dim document As BsonDocument = New BsonDocument()
        document.Add("Name", txtName.Text)
        document.Add("Age", Convert.ToInt32(txtAge.Text))

        ' Belgeyi koleksiyona ekle
        collection.InsertOne(document)
        MessageBox.Show("Belge Eklendi!")
    End Sub

    ' Belge güncelleme butonu
    Private Sub btnUpdateDocument_Click(sender As Object, e As EventArgs) Handles btnUpdateDocument.Click
        ' Güncellenecek belgenin filtresi
        Dim filter = Builders(Of BsonDocument).Filter.Eq("Name", txtName.Text)

        ' Güncellenecek veri
        Dim update = Builders(Of BsonDocument).Update.Set("Age", Convert.ToInt32(txtNewAge.Text))

        ' Belgeyi güncelle
        collection.UpdateOne(filter, update)
        MessageBox.Show("Belge Güncellendi!")
    End Sub

    ' Belge silme butonu
    Private Sub btnDeleteDocument_Click(sender As Object, e As EventArgs) Handles btnDeleteDocument.Click
        ' Silinecek belgenin filtresi
        Dim filter = Builders(Of BsonDocument).Filter.Eq("Name", txtName.Text)

        ' Belgeyi sil
        collection.DeleteOne(filter)
        MessageBox.Show("Belge Silindi!")
    End Sub
End Class
