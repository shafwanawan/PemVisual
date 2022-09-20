Public Class Contoh18
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Call your method
        SayHello()
    End Sub

    Private Sub SayHello()
        'Display a message box
        MessageBox.Show("Hello World!", "Three Buttons")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Call your method
        SayHello()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Call your method
        SayHello()
    End Sub
End Class