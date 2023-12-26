Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    ' MD5 ile şifreleme
    Private Function MD5Hash(password As String) As String
        Using md5 As MD5 = MD5.Create()
            Dim hashBytes As Byte() = md5.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim sb As New StringBuilder()

            For Each hashByte In hashBytes
                sb.Append(hashByte.ToString("X2"))
            Next

            Return sb.ToString()
        End Using
    End Function

    ' Örnek kullanım
    Private Sub btnMD5_Click(sender As Object, e As EventArgs) Handles btnMD5.Click
        Dim password As String = txtPassword.Text
        Dim hashedPassword As String = MD5Hash(password)
        MessageBox.Show($"MD5 Hash: {hashedPassword}")
    End Sub
End Class
