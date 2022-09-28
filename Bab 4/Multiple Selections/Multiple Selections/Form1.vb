Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Display the favorite color of the selected name
        MessageBox.Show(strName & "'s favorite color is " & strFavoriteColor,
        "Select Demo")
        'Use a Select Case statement to display a person's gender
        Select Case strName.ToLower
            Case "bryan", "eddie", "ashley"
                MessageBox.Show("This person's gender is male.", "Select
Demo")
            Case "jennifer", "katelyn"
                MessageBox.Show("This person's gender is female.", "Select
Demo")
        End Select
    End Sub
End Class
