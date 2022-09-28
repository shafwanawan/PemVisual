Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare variable
        Dim strName As String
        'Get the name
        strName = txtName3.Text
        'Compare the name
        If String.Compare(strName, "BRYAN", True) = 0 Then
            MessageBox.Show("Hello, Bryan!", "And Or Demo")
        End If

    End Sub
End Class
