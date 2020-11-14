Class MainWindow
    Private Sub AddToTotal(initial As Double)
        Dim total As Double = Double.Parse(txtInitial.Text)
        total += initial
        If (total <= 0) Then
            total = 1
        End If
        txtInitial.Text = total.ToString()
    End Sub

    Private Sub btnIncrease_Click(sender As Object, e As RoutedEventArgs) Handles btnIncrease.Click
        AddToTotal(1)
    End Sub

    Private Sub btnDecrease_Click(sender As Object, e As RoutedEventArgs) Handles btnDecrease.Click
        AddToTotal(-1)
    End Sub

    Private Sub txtInitial_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtInitial.TextChanged
        Me.txtInitial = txtInitial
        txtHalfLife.Text = ""
    End Sub

    Public Sub Calculate()
        Dim initial As Double = Double.Parse(txtInitial.Text)
        Dim current As Double = Double.Parse(txtCurrent.Text)
        Dim elapsed As Double = Double.Parse(txtElapsed.Text)
        Dim sum As Double = 0

        sum = Math.Log(2) * elapsed / Math.Log(initial / current)

        txtHalfLife.Text = "Half life is " + sum.ToString()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As RoutedEventArgs) Handles btnReset.Click
        txtInitial.Text = 100
        txtCurrent.Text = 25
        txtElapsed.Text = 2
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As TextChangedEventArgs)
        Calculate()
    End Sub
End Class
