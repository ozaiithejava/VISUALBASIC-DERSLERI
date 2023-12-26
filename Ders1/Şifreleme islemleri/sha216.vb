Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    ' SHA-256 ile şifreleme
    Private Function SHA256Hash(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim sb As New StringBuilder()

            For Each hashByte In hashBytes
                sb.Append(hashByte.ToString("X2"))
            Next

            Return sb.ToString()
        End Using
    End Function

    ' Örnek kullanım
    Private Sub btnSHA256_Click(sender As Object, e As EventArgs) Handles btnSHA256.Click
        Dim password As String = txtPassword.Text
        Dim hashedPassword As String = SHA256Hash(password)
        MessageBox.Show($"SHA-256 Hash: {hashedPassword}")
    End Sub
End Class
