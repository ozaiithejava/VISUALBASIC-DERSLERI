Imports System.Collections.Generic
Imports System.Threading

Public Class Todo
    Public Property Description As String
    Public Property Priority As TodoPriority
    Public Property DueDate As DateTime
End Class

Public Enum TodoPriority
    Low
    Normal
    High
End Enum

Public Class TodoManager
    Private todos As New List(Of Todo)()

    Public Sub AddTodo(description As String, priority As TodoPriority, dueDate As DateTime)
        Dim newTodo As New Todo With {
            .Description = description,
            .Priority = priority,
            .DueDate = dueDate
        }

        todos.Add(newTodo)
        Console.WriteLine($"Yeni görev eklendi: {description}")
    End Sub

    Public Sub DisplayTodos()
        Console.WriteLine("----- Görevler -----")
        For Each todo In todos
            Console.WriteLine($"Açıklama: {todo.Description}, Öncelik: {todo.Priority}, Bitiş Tarihi: {todo.DueDate}")
        Next
        Console.WriteLine("---------------------")
    End Sub

    Public Sub CheckReminders()
        For Each todo In todos
            If DateTime.Now > todo.DueDate Then
                Console.WriteLine($"Hatırlatma: {todo.Description} - Bitiş tarihi geçmiştir!")
            End If
        Next
    End Sub
End Class

Module Program
    Dim todoManager As New TodoManager()

    Sub Main()
        ' Görevler ekleyin
        todoManager.AddTodo("Örnek Görev 1", TodoPriority.Low, DateTime.Now.AddMinutes(5))
        todoManager.AddTodo("Örnek Görev 2", TodoPriority.Normal, DateTime.Now.AddHours(2))
        todoManager.AddTodo("Örnek Görev 3", TodoPriority.High, DateTime.Now.AddSeconds(30))

        ' Görevleri görüntüleyin
        todoManager.DisplayTodos()

        ' Hatırlatmaları kontrol edin
        todoManager.CheckReminders()

        ' Konsolu açık tutmak için bekleme
        Console.ReadLine()
    End Sub
End Module
