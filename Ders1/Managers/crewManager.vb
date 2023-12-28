Imports System.Collections.Generic

Public Class CrewMember
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Position As String
End Class

Public Class CrewManager
    Private crewMembers As New List(Of CrewMember)()

    Public Sub AddCrewMember(firstName As String, lastName As String, position As String)
        Dim newCrewMember As New CrewMember With {
            .FirstName = firstName,
            .LastName = lastName,
            .Position = position
        }

        crewMembers.Add(newCrewMember)
        Console.WriteLine($"Yeni ekip üyesi eklendi: {firstName} {lastName}, Pozisyon: {position}")
    End Sub

    Public Sub DisplayCrew()
        Console.WriteLine("----- Ekip Üyeleri -----")
        For Each member In crewMembers
            Console.WriteLine($"Adı: {member.FirstName}, Soyadı: {member.LastName}, Pozisyon: {member.Position}")
        Next
        Console.WriteLine("------------------------")
    End Sub

    Public Sub RemoveCrewMember(firstName As String, lastName As String)
        Dim memberToRemove = crewMembers.Find(Function(m) m.FirstName = firstName AndAlso m.LastName = lastName)

        If memberToRemove IsNot Nothing Then
            crewMembers.Remove(memberToRemove)
            Console.WriteLine($"Ekip üyesi silindi: {firstName} {lastName}")
        Else
            Console.WriteLine($"Ekip üyesi bulunamadı: {firstName} {lastName}")
        End If
    End Sub
End Class

Module Program
    Dim crewManager As New CrewManager()

    Sub Main()
        ' Ekip üyelerini ekleyin
        crewManager.AddCrewMember("John", "Doe", "Pilot")
        crewManager.AddCrewMember("Jane", "Smith", "Engineer")
        crewManager.AddCrewMember("Bob", "Johnson", "Navigator")

        ' Ekip üyelerini görüntüleyin
        crewManager.DisplayCrew()

        ' Ekip üyesini silin
        crewManager.RemoveCrewMember("John", "Doe")

        ' Ekip üyelerini tekrar görüntüleyin
        crewManager.DisplayCrew()

        ' Konsolu açık tutmak için bekleme
        Console.ReadLine()
    End Sub
End Module
