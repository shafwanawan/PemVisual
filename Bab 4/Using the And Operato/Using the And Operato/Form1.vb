Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare variables
        Dim strName1 As String, strName2 As String
        'Get the namesqa
        strName1 = txtName1.Text
        strName2 = txtName2.Text
        'Are both names Wendy?
        If strName1 = "Wendy" And strName2 = "Wendy" Then
            MessageBox.Show("Both names are Wendy.", "And Or Demo")
        Else
            MessageBox.Show("One of the names is not Wendy.",
"And Or Demo")
        End If

    End Sub
End Class
