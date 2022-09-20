Public Class Contoh12
    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        'Declare variable
        Dim dteResults As Date
        'Get the current date and time
        dteResults = Now
        'Display the results
        MessageBox.Show(dteResults.ToString, "Date Demo")
        'Display the results
        MessageBox.Show(dteResults.ToString, "Date Demo")
        'Display dates
        MessageBox.Show(dteResults.ToLongDateString, "Date Demo")
        MessageBox.Show(dteResults.ToShortDateString, "Date Demo")
        'Display times
        MessageBox.Show(dteResults.ToLongTimeString, "Date Demo")
        MessageBox.Show(dteResults.ToShortTimeString, "Date Demo")
    End Sub
End Class