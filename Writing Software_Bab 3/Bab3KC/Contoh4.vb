Public Class Contoh4
    Private Sub btnFloatMath_Click(sender As Object, e As EventArgs) Handles btnFloatMath.Click
        'Declare variable
        Dim dblNumber As Double
        'Set number, multiply numbers, and display results
        dblNumber = 45.34
        dblNumber *= 4.333
        MessageBox.Show("Multiplication test. " & dblNumber.ToString, "Floating Points")
        'Set number, divide numbers, and display results
        dblNumber = 12
        dblNumber /= 7
        MessageBox.Show("Division test. " & dblNumber.ToString, "Floating Points")
    End Sub
End Class