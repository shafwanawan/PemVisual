Public Class Bab4
    Private Sub btnForNextLoop_Click(sender As Object, e As EventArgs) Handles ForNextLoop.Click
        For intCount = 1 To 5
            'Add the item to the list
            btnData.Items.Add("I'm item " & intCount.ToString &
            " ")
        Next

    End Sub

    Private Sub btnForNextLoopWithStep1_Click(sender As Object, e As EventArgs) Handles btnForNextLoopWithStep.Click
        For intCount As Integer = 4 To 62 Step 7
            'Add the item to the list
            btnData.Items.Add(intCount.ToString)
        Next
    End Sub

    Private Sub btnBacwardsForNextLLoop_Click(sender As Object, e As EventArgs) Handles btnBacwardsForNextLLoop.Click
        For intCount As Integer = 10 To 1 Step -1
            'Add the item to the list
            btnData.Items.Add(intCount.ToString)
        Next

    End Sub

    Private Sub btnForEachLoop_Click(sender As Object, e As EventArgs) Handles btnForEachLoop.Click
        For Each strFolder As String In My.Computer.FileSystem.GetDirectories("C:\")
            'Add the item to the list
            btnData.Items.Add(strFolder)
        Next
    End Sub

    Private Sub btnDoUntilLoop_Click(sender As Object, e As EventArgs) Handles btnDoUntilLoop.Click
        Dim objRandom As New Random
        Dim intRandomNumber As Integer = 0
        'Clear the list
        'Process the loop until intRandomNumber = 10
        Do Until intRandomNumber = 10
            'Get a random number between 0 and 24
            intRandomNumber = objRandom.Next(25)
            'Add the number to the list
            btnData.Items.Add(intRandomNumber.ToString)
        Loop

    End Sub

    Private Sub btnDoWhileLoop_Click(sender As Object, e As EventArgs) Handles btnDoWhileLoop.Click
        Dim objRandom As New Random
        Dim intRandomNumber As Integer = 0
        'Clear the list

        'Process the loop while intRandomNumber < 15
        Do While intRandomNumber < 15
            'Get a random number between 0 and 24
            intRandomNumber = objRandom.Next(25)
            'Add the number to the list
            btnData.Items.Add(intRandomNumber.ToString)
        Loop

    End Sub

    Private Sub btnNestedLoops_Click(sender As Object, e As EventArgs) Handles btnNestedLoops.Click
        For intOuterLoop As Integer = 1 To 2
            'Process a nested (inner) loop
            For intInnerLoop As Integer = 1 To 3
                btnData.Items.Add(intOuterLoop.ToString & ", " & intInnerLoop.ToString)
            Next
        Next

    End Sub

    Private Sub btnQuittingAForLoop_Click(sender As Object, e As EventArgs) Handles btnQuittingAForLoop.Click
        For Each strFolder As String In My.Computer.FileSystem.GetDirectories("C:\")
            'Add the item to the list
            btnData.Items.Add(strFolder)
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
