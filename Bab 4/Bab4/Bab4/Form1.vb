Public Class Form1
    Private Sub btnNestedLoops_Click(sender As Object, e As EventArgs) Handles btnNestedLoops.Click
        For intOuterLoop As Integer = 1 To 2
            'Process a nested (inner) loop
            For intInnerLoop As Integer = 1 To 3
                lstData.Items.Add(intOuterLoop.ToString & ", " & intInnerLoop.ToString)
            Next
        Next
    End Sub

    Private Sub btnQuittingAForLoop_Click(sender As Object, e As EventArgs) Handles btnQuittingAForLoop.Click
        For Each strFolder As String In My.Computer.FileSystem.GetDirectories("C:\")
            'Add the item to the list
            lstData.Items.Add(strFolder)
            'Do you have the folder C:\Program Files?
            If String.Compare(strFolder, "c:\program files", True) = 0 Then
                'Tell the user
                MessageBox.Show("Found it, exiting the loop now.", "Loops")
                'Quit the loop early
                Exit For
            End If
        Next
    End Sub
End Class
