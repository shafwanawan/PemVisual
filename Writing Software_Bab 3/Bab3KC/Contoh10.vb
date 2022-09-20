Public Class Contoh10
    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        'Declare variables
        Dim strData As String
        Dim strResults As String
        'Get the text from the TextBox
        strData = txtString.Text
        'Replace the string occurrence
        strResults = strData.Replace("Hello", "Goodbye")
        'Display the new string
        MessageBox.Show(strResults, "Strings")
    End Sub
End Class