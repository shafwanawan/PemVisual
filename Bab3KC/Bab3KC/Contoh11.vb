Public Class Contoh11
    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        'Declare variable
        Dim dteResults As Date
        'Get the current date and time
        dteResults = Now
        'Display the results
        MessageBox.Show(dteResults.ToString, "Date Demo")
    End Sub
End Class