Public Class PlayerManager
    Private players As New List(Of Player)()

    Public Sub AddPlayer(playerName As String, playerScore As Integer)
        Dim newPlayer As New Player(playerName, playerScore)
        players.Add(newPlayer)
        Console.WriteLine($"Oyuncu eklenmiştir: {playerName}")
    End Sub

    Public Sub RemovePlayer(playerName As String)
        Dim playerToRemove = players.Find(Function(p) p.Name = playerName)
        If playerToRemove IsNot Nothing Then
            players.Remove(playerToRemove)
            Console.WriteLine($"Oyuncu silinmiştir: {playerName}")
        Else
            Console.WriteLine($"Oyuncu bulunamadı: {playerName}")
        End If
    End Sub

    Public Sub DisplayPlayerInfo()
        Console.WriteLine("----- Oyuncu Bilgileri -----")
        For Each player In players
            Console.WriteLine($"Oyuncu Adı: {player.Name}, Skor: {player.Score}")
        Next
        Console.WriteLine("-----------------------------")
    End Sub

    Public Sub UpdatePlayerScore(playerName As String, newScore As Integer)
        Dim playerToUpdate = players.Find(Function(p) p.Name = playerName)
        If playerToUpdate IsNot Nothing Then
            playerToUpdate.Score = newScore
            Console.WriteLine($"Oyuncu skoru güncellenmiştir: {playerName}, Yeni Skor: {newScore}")
        Else
            Console.WriteLine($"Oyuncu bulunamadı: {playerName}")
        End If
    End Sub
End Class

Public Class Player
    Public Property Name As String
    Public Property Score As Integer

    Public Sub New(name As String, score As Integer)
        Me.Name = name
        Me.Score = score
    End Sub
End Class
