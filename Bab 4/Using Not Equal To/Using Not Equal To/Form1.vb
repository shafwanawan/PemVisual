Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare a variable and get the name from the text box
        Dim strName As String
        strName = txtName.Text
        'Is the name Wendy?
        If strName <> "Wendy" Then
            MessageBox.Show("The name is *not* Wendy.", "If Demo")
        End If
    End Sub
End Class
