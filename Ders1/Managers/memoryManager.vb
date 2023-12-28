Public Class MemoryManager
    Private Shared maxMemory As Long = Long.MaxValue
    Private Shared minMemory As Long = 0
    Private Shared currentMemory As Long = 0

    Public Shared Sub SetMax(max As Long)
        maxMemory = max
    End Sub

    Public Shared Sub SetMin(min As Long)
        minMemory = min
    End Sub

    Public Shared Function GetCurrent() As Long
        Return currentMemory
    End Function

    Public Shared Function GetFree() As Long
        Dim freeMemory As Long = maxMemory - currentMemory
        Return If(freeMemory >= 0, freeMemory, 0)
    End Function

    Public Shared Function AllocateMemory(size As Long) As Boolean
        If (currentMemory + size <= maxMemory) Then
            currentMemory += size
            Return True
        Else
            Return False ' Bellek sınırlarını aşarsa false döndür
        End If
    End Function

    Public Shared Sub DeallocateMemory(size As Long)
        If (currentMemory - size >= minMemory) Then
            currentMemory -= size
        End If
    End Sub
End Class
