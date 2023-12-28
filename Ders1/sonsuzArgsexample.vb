Sub SonsuzArgsFunc(ParamArray args() As Object)
    For Each arg In args
        Console.WriteLine(arg)
    Next
End Sub

' Kullanım örneği:
SonsuzArgsFunc(1, 2, 3, "a", "b", True)
