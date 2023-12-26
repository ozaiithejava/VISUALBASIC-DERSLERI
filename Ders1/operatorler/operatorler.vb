Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Aritmetik Operatörler
        Dim num1 As Integer = 5
        Dim num2 As Integer = 3
        Dim result As Integer

        ' Toplama
        result = num1 + num2
        Console.WriteLine($"Toplama: {result}")

        ' Çıkarma
        result = num1 - num2
        Console.WriteLine($"Çıkarma: {result}")

        ' Çarpma
        result = num1 * num2
        Console.WriteLine($"Çarpma: {result}")

        ' Bölme
        result = num1 / num2
        Console.WriteLine($"Bölme: {result}")

        ' Mod
        result = num1 Mod num2
        Console.WriteLine($"Mod: {result}")

        ' Atama Operatörleri
        Dim x As Integer = 5

        ' Toplama ve Atama
        x += 3
        Console.WriteLine($"Toplama ve Atama: {x}")

        ' Çıkarma ve Atama
        x -= 2
        Console.WriteLine($"Çıkarma ve Atama: {x}")

        ' Karşılaştırma Operatörleri
        Dim isEqual As Boolean = (x = 6)
        Console.WriteLine($"Eşittir: {isEqual}")

        Dim isNotEqual As Boolean = (x <> 6)
        Console.WriteLine($"Eşit Değildir: {isNotEqual}")

        Dim isGreater As Boolean = (x > 4)
        Console.WriteLine($"Büyüktür: {isGreater}")

        Dim isLess As Boolean = (x < 10)
        Console.WriteLine($"Küçüktür: {isLess}")

        ' Mantıksal Operatörler
        Dim condition1 As Boolean = (x > 4)
        Dim condition2 As Boolean = (x < 5)

        ' VE (And)
        Dim andResult As Boolean = condition1 And condition2
        Console.WriteLine($"VE (And): {andResult}")

        ' VEYA (Or)
        Dim orResult As Boolean = condition1 Or (x < 5)
        Console.WriteLine($"VEYA (Or): {orResult}")

        ' DEĞİL (Not)
        Dim notResult As Boolean = Not condition1
        Console.WriteLine($"DEĞİL (Not): {notResult}")
    End Sub
End Class
