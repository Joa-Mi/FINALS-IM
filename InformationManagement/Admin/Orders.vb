Public Class Orders

    Private Sub AddOrdersBtn_Click(sender As Object, e As EventArgs) Handles AddOrdersBtn.Click
        With FormAddOrder
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
            .BringToFront()
        End With
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class