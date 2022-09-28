Public Class Form1
    Private Sub btnAnotherIf_Click(sender As Object, e As EventArgs) Handles btnAnotherIf.Click
        'Declare and set a variable
        Dim intNumber As Integer = 27
        'Here's where you make a decision,
        'and tell the user what happened
        If intNumber = 1000 Then
            MessageBox.Show("'intNumber' is, indeed, 1000!", "Simple If")
        End If

    End Sub
End Class
