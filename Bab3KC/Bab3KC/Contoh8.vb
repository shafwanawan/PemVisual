Public Class Contoh8
    Private Sub btnSubStrings_Click(sender As Object, e As EventArgs) Handles btnSubStrings.Click
        'Declare variable
        Dim strResults As String
        'Get the text from the TextBox
        strResults = txtString.Text
        'Display the first three characters
        MessageBox.Show(strResults.Substring(0, 3), "Strings")
        'Display the middle three characters
        MessageBox.Show(strResults.Substring(3, 3), "Strings")
        'Display the last three characters
        MessageBox.Show(strResults.Substring(strResults.Length - 3), "Strings")
    End Sub
End Class