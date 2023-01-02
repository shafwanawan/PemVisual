Public Class Form1
    'Declare a form level array
    Private strFriends(4) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate the array
        strFriends(0) = "Wendy"
        strFriends(1) = "Harriet"
        strFriends(2) = "Jay"
        strFriends(3) = "Michelle"
        strFriends(4) = "Richard"
    End Sub

    Private Sub lstFriends_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFriends.SelectedIndexChanged

    End Sub

    Private Sub btnArrayElement_Click(sender As Object, e As EventArgs) Handles btnArrayElement.Click
        'clear the list
        ClearList()

        'Declare an array
        Dim strFriends(4) As String
        'Populate the array
        strFriends(0) = "Wendy"
        strFriends(1) = "Harriet"
        strFriends(2) = "Jay"
        strFriends(3) = "Michelle"
        strFriends(4) = "Richard"
        'Add the first array item to the list
        lstFriends.Items.Add(strFriends(0))

    End Sub
    Private Sub ClearList()
        'Clear the list
        lstFriends.Items.Clear()

    End Sub

    Private Sub btnEnumerateArray_Click(sender As Object, e As EventArgs) Handles btnEnumerateArray.Click
        'Clear the list
        ClearList()
        'Enumerate the array
        For Each strName As String In strFriends
            'Add the array item the list
            lstFriends.Items.Add(strName)
        Next
    End Sub

    Private Sub btnArrayAsParameters_Click(sender As Object, e As EventArgs) Handles btnArrayAsParameters.Click
        'Clear the list
        ClearList()

        'List your friends
        AddItemsToList(strFriends)
    End Sub

    Private Sub AddItemsToList(ByVal arrayList As String())
        'Enumerate the array
        For Each strName As String In arrayList
            'Add the array item to the list 
            lstFriends.Items.Add(strName)
        Next
    End Sub

    Private Sub btnMoreArrayParameters_Click(sender As Object, e As EventArgs) Handles btnMoreArrayParameters.Click
        'Clar th list
        ClearList()
        'Declare an array
        Dim strMoreFriends(1) As String
        'Populasi the array
        strMoreFriends(0) = "Elaine"
        strMoreFriends(1) = "Debra"
        'List your friends
        AddItemsToList(strFriends)
        AddItemsToList(strMoreFriends)

    End Sub

    Private Sub btnSortingArrays_Click(sender As Object, e As EventArgs) Handles btnSortingArrays.Click
        'Clear the list
        ClearList()

        'Sort the array
        Array.Sort(strFriends)

        'List your friends
        AddItemsToList(strFriends)

    End Sub

    Private Sub btnReversingAnArray_Click(sender As Object, e As EventArgs) Handles btnReversingAnArray.Click
        'Clear the list
        ClearList()

        'Reverse the order-elements will be in descending order 
        Array.Reverse(strFriends)

        'List your friends
        AddItemsToList(strFriends)
    End Sub

    Private Sub btnInitializingArraysWith_Click(sender As Object, e As EventArgs) Handles btnInitializingArraysWith.Click
        'Clear the list
        ClearList()
        'Declare and populate an array
        Dim strMyFriends() As String = {"Elaine", "Richard", "Debra",
        "Wendy", "Harriet"}
        'List your friends
        AddItemsToList(strMyFriends)
    End Sub
End Class
