Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Use a Select Case statement to display a person's gender
        Select Case strName.ToLower
            Case "bryan", "edward"
                MessageBox.Show("This person's gender is male.", "Select
Demo")
            Case "stephanie", "cathy", "betty"
                MessageBox.Show("This person's gender is female.", "Select
Demo")
            Case Else
                MessageBox.Show("I don't know this person's gender.",
                "Select Demo")
        End Select
    End Sub
End Class
