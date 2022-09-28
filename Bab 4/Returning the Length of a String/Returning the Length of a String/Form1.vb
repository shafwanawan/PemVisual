Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare variable
        Dim strResults As String
        'Get the text from the TextBox
        strResults = txtString.Text
        'Display the length of the string
        MessageBox.Show(strResults.Length.ToString & " characters(s)",
        "Strings")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Declare variable
        Dim strResults As String
        'Get the text from the TextBox
        strResults = txtString.Text
        'Display the first three characters
        MessageBox.Show(strResults.Substring(0, 3), "Strings")
        'Display the middle three characters
        MessageBox.Show(strResults.Substring(3, 3), "Strings")
        'Display the last three characters
        MessageBox.Show(strResults.Substring(strResults.Length—3),

    End Sub
End Class
