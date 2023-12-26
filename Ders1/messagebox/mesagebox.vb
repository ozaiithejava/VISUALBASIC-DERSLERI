' Visual Basic (VB) - MessageBox Kullanımı

' Yorum Satırları: Kodun anlaşılması için yorumlar eklenir.

Imports System.Windows.Forms ' MessageBox sınıfını kullanabilmek için gerekli import

Module Program
    Sub Main()
        ' Temel MessageBox
        MessageBox.Show("Merhaba, MessageBox Temel Kullanımı")

        ' İki butonlu MessageBox
        Dim result As DialogResult = MessageBox.Show("Evet veya Hayır seçeneğini seçin.", "Soru", MessageBoxButtons.YesNo)

        ' Kullanıcının seçimine göre işlem yapma
        If result = DialogResult.Yes Then
            Console.WriteLine("Evet seçildi.")
        Else
            Console.WriteLine("Hayır seçildi.")
        End If

        ' İkonlu MessageBox
        MessageBox.Show("Bu bir bilgi mesajıdır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Özel düğmelerle MessageBox
        Dim customButtons As MessageBoxButtons = MessageBoxButtons.YesNoCancel
        Dim customIcon As MessageBoxIcon = MessageBoxIcon.Question

        Dim customResult As DialogResult = MessageBox.Show("Özel düğmelerle MessageBox", "Özel MessageBox", customButtons, customIcon)

        ' Kullanıcının seçimine göre işlem yapma
        Select Case customResult
            Case DialogResult.Yes
                Console.WriteLine("Evet seçildi.")
            Case DialogResult.No
                Console.WriteLine("Hayır seçildi.")
            Case DialogResult.Cancel
                Console.WriteLine("İptal seçildi.")
        End Select

        ' MessageBox'ta kullanıcının metin girmesini isteme
        Dim inputResult As String = InputBox("Lütfen bir metin girin:", "Metin Girişi")

        ' Kullanıcının girdiği metni kontrol etme
        If Not String.IsNullOrEmpty(inputResult) Then
            MessageBox.Show($"Girilen metin: {inputResult}", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Metin girişi iptal edildi.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Module
