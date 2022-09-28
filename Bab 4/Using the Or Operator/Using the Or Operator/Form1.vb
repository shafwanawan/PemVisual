Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare variables
        Dim strName1 As String, strName2 As String
        'Get the names
        strName1 = txtName1.Text
        strName2 = txtName2.Text
        'Is one of the names Wendy?
        If strName1 = "Wendy" Or strName2 = "Wendy" Then
            MessageBox.Show("One of the names is Wendy.",
            "And Or Demo")
        Else
            MessageBox.Show("Neither of the names is Wendy.",
            "And Or Demo")
        End If
    End Sub
End Class
