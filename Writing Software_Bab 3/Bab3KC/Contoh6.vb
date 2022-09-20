Public Class Contoh6
    Private Sub btnConcatenation_Click(sender As Object, e As EventArgs) Handles btnConcatenation.Click
        'Declare variables
        Dim strResults As String
        Dim strOne As String
        Dim strTwo As String
        Dim strThree As String
        'Set the string values
        strOne = "Hello"
        strTwo = " World!"
        strThree = " Shafwan Rahmani Putera"
        'Concatenate the strings
        strResults = strOne & strTwo & strThree
        'Display the results
        MessageBox.Show(strResults, "Strings")
    End Sub
End Class