Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare and set a variable
        Dim intNumber As Integer = 27
        'Here's where you make a decision,
        'and tell the user what happened
        If intNumber = 1000 Then
            MessageBox.Show("'intNumber' is, indeed, 1000!", "Simple If")
        ElseIf intNumber = 27 Then
            MessageBox.Show("'intNumber' is 27!", "Simple If")
        Else
            MessageBox.Show("'intNumber' is neither 1000 nor 27!", "Simple If")
        End If
    End Sub
End Class
