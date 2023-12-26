Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    ' SHA-512 ile şifreleme
    Private Function SHA512Hash(password As String) As String
        Using sha512 As SHA512 = SHA512.Create()
            Dim hashBytes As Byte() = sha512.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim sb As New StringBuilder()

            For Each hashByte In hashBytes
                sb.Append(hashByte.ToString("X2"))
            Next

            Return sb.ToString()
        End Using
    End Function

    ' Örnek kullanım
    Private Sub btnSHA512_Click(sender As Object, e As EventArgs) Handles btnSHA512.Click
        Dim password As String = txtPassword.Text
        Dim hashedPassword As String = SHA512Hash(password)
        MessageBox.Show($"SHA-512 Hash: {hashedPassword}")
    End Sub
End Class
