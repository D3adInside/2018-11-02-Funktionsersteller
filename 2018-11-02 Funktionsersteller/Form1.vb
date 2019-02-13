Public Class Form1
    Dim erste As Integer
    Dim zweite As Integer
    Dim groeste As Integer

    Private Sub cmdRechnen_Click(sender As Object, e As EventArgs) Handles cmdRechnen.Click
        erste = txtErste.Text
        zweite = txtZweite.Text

        groeste = FctMaximum(erste, zweite)

        txtGroeste.Text = groeste
        '
    End Sub

    Function FctMaximum(parE, parZ)
        If parE > parZ Then
            FctMaximum = parE
        Else
            FctMaximum = parZ
        End If
    End Function

End Class
