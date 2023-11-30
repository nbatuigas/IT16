Imports System.Text

Public Class Form1
    Function Caesar_Cipher(ByVal Text As String, ByVal N As Integer, ByVal Encrypt As Boolean)
        Dim Result As String = ""

        For Each c As Char In Text
            Dim x As Integer
            If Encrypt Then
                x = Asc(c) + N
            Else
                x = Asc(c) + 26 - N
            End If

            If Char.IsLower(c) Then
                If x > Asc("z") Then
                    x -= 26

                End If
                Result += Chr(x)

            ElseIf Char.IsUpper(c) Then
                If x > Asc("Z") Then
                    x -= 26

                End If
                Result += Chr(x)
            Else
                Result += c
            End If


        Next


        Return Result
    End Function

    Private Sub decbutton_Click(sender As Object, e As EventArgs) Handles decbutton.Click
        orgtextbox.Text = Caesar_Cipher(enctextbox.Text, numupdown.Value, False)
    End Sub

    Private Sub encbutton_Click(sender As Object, e As EventArgs) Handles encbutton.Click
        enctextbox.Text = Caesar_Cipher(orgtextbox.Text, numupdown.Value, True)
    End Sub
End Class