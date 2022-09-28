Public Class Form1
    Private Sub lstData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData.SelectedIndexChanged
        'Declare variables
        Dim strName As String
        Dim strFavoriteColor As String
        'Get the selected name
        strName = lstData.Items(lstData.SelectedIndex).ToString
        'Use a Select Case statement to get the favorite color
        'of the selected name
        Select Case strName
            Case "Bryan"
                strFavoriteColor = "Madras Yellow"
            Case "Ashley"
                strFavoriteColor = "Sea Blue"
            Case "Jennifer"
                strFavoriteColor = "Morning Mist"
            Case "Eddie"
                strFavoriteColor = "Passionate Purple"
            Case "Katelyn"
                strFavoriteColor = "Red"
        End Select
        'Display the favorite color of the selected name
        MessageBox.Show(strName & "'s favorite color is " &
strFavoriteColor, "Select Demo")

    End Sub
End Class
