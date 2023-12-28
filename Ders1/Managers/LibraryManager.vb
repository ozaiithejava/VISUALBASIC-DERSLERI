Imports System.Collections.Generic

Public Class Book
    Public Property Title As String
    Public Property Author As String
    Public Property PublishedDate As DateTime
    Public Property PublicationYear As Integer
    Public Property Publisher As String
    Public Property Price As Decimal

    Public Sub New(title As String, author As String, Optional publishedDate As DateTime = Nothing,
                   Optional publicationYear As Integer = 0, Optional publisher As String = "", Optional price As Decimal = 0D)
        Me.Title = title
        Me.Author = author
        Me.PublishedDate = publishedDate
        Me.PublicationYear = publicationYear
        Me.Publisher = publisher
        Me.Price = price
    End Sub
End Class

Public Class LibraryManager
    Private Books As New List(Of Book)()

    Public Sub ListBooks()
        ' Kitapları listele
        Console.WriteLine("----- Kitaplar -----")
        For Each book As Book In Books
            Console.WriteLine($"Başlık: {book.Title}, Yazar: {book.Author}, Yayın Tarihi: {book.PublishedDate}, " &
                              $"Basım Yılı: {book.PublicationYear}, Yayıncı: {book.Publisher}, Fiyat: {book.Price:C}")
        Next
        Console.WriteLine("---------------------")
    End Sub

    Public Sub AddBook(title As String, author As String, Optional publishedDate As DateTime = Nothing,
                       Optional publicationYear As Integer = 0, Optional publisher As String = "", Optional price As Decimal = 0D)
        ' Kitap ekleyin
        Dim newBook As New Book(title, author, publishedDate, publicationYear, publisher, price)
        Books.Add(newBook)
        Console.WriteLine($"Kitap eklendi: {newBook.Title}")
    End Sub

    Public Sub RemoveBook(title As String)
        ' Kitabı kaldır
        Dim bookToRemove As Book = Books.Find(Function(book) book.Title = title)

        If bookToRemove IsNot Nothing Then
            Books.Remove(bookToRemove)
            Console.WriteLine($"Kitap kaldırıldı: {title}")
        Else
            Console.WriteLine($"Hata: Kitap bulunamadı - {title}")
        End If
    End Sub
End Class

Module Program
    Sub Main()
        ' LibraryManager örneği oluşturun
        Dim libraryManager As New LibraryManager()

        ' Kitapları listele
        libraryManager.ListBooks()

        ' Kitap ekleyin
        libraryManager.AddBook("Book1", "Author1", #1/1/2022#, 2022, "Publisher1", 29.99D)
        libraryManager.AddBook("Book2", "Author2", #2/1/2022#, 2022, "Publisher2", 19.99D)

        ' Kitapları tekrar listele
        libraryManager.ListBooks()

        ' Belirli bir kitabı kaldır
        Dim bookToRemove As String = "Book1"
        libraryManager.RemoveBook(bookToRemove)

        ' Kitapları tekrar listele
        libraryManager.ListBooks()

        ' Konsolu açık tutmak için bekleme
        Console.ReadLine()
    End Sub
End Module
