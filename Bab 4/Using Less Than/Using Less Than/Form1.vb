Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare variable
        Dim intNumber As Integer
        Try
            'Get the number from the text box
            intNumber = CType(txtValue.Text, Integer)
        Catch
            Exit Sub
        End Try
        'Is intNumber less than 27?
        If intNumber < 27 Then
            MessageBox.Show("Is 'intNumber' less than 27? Yes!", "If Demo")
        Else
            MessageBox.Show("Is 'intNumber' less than 27? No!", "If Demo")
        End If
    End Sub
End Class
