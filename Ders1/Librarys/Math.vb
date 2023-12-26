Public Class Form1
    Private Sub btnMathOperations_Click(sender As Object, e As EventArgs) Handles btnMathOperations.Click
        ' Aritmetik Operasyonlar
        Dim num1 As Double = 5.2
        Dim num2 As Double = 3.7

        ' Mutlak Değer
        Dim absoluteValue As Double = Math.Abs(-5.2) ' absoluteValue şimdi 5.2

        ' Yukarı Yuvarlama
        Dim roundedUp As Double = Math.Ceiling(4.7) ' roundedUp şimdi 5

        ' Aşağı Yuvarlama
        Dim roundedDown As Double = Math.Floor(4.7) ' roundedDown şimdi 4

        ' Üs Alma
        Dim powerResult As Double = Math.Pow(2, 3) ' powerResult şimdi 8

        ' Karekök Alma
        Dim squareRootResult As Double = Math.Sqrt(25) ' squareRootResult şimdi 5

        ' Trigonometrik Fonksiyonlar
        Dim sinValue As Double = Math.Sin(Math.PI / 2) ' sinValue şimdi 1 (90 derece)
        Dim cosValue As Double = Math.Cos(0) ' cosValue şimdi 1 (0 derece)
        Dim tanValue As Double = Math.Tan(Math.PI / 4) ' tanValue şimdi 1

        ' Sonuçları Gösterme
        Console.WriteLine($"Mutlak Değer: {absoluteValue}")
        Console.WriteLine($"Yukarı Yuvarlama: {roundedUp}")
        Console.WriteLine($"Aşağı Yuvarlama: {roundedDown}")
        Console.WriteLine($"Üs Alma: {powerResult}")
        Console.WriteLine($"Karekök Alma: {squareRootResult}")
        Console.WriteLine($"Sinüs: {sinValue}")
        Console.WriteLine($"Kosinüs: {cosValue}")
        Console.WriteLine($"Tanjant: {tanValue}")
    End Sub
End Class
