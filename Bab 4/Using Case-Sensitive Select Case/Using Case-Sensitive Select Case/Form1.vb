Public Class Form1
    Private Sub lsrData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsrData.SelectedIndexChanged
        'Declare variables
        Dim strName As String
        Dim strFavoriteColor As String
        'Get the selected name
        strName = lstData.Items(lstData.SelectedIndex).ToString
        'Use a Select Case statement to get the favorite color
        'of the selected name
        Select Case strName.ToLower
            Case "bryan"
                strFavoriteColor = "Madras Yellow"
            Case "ashley"
                strFavoriteColor = "Sea Blue"
            Case "jennifer"
                strFavoriteColor = "Morning Mist"
            Case "eddie"
                strFavoriteColor = "Passionate Purple"
            Case "katelyn"
                strFavoriteColor = "Red"
        End Select
        'Display the favorite color of the selected name
        MessageBox.Show(strName & "'s favorite color is " &
        strFavoriteColor,
        "Select Demo")
    End Sub
End Class
