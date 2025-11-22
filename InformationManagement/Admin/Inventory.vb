Public Class Inventory
    Private Sub AddItem_Click(sender As Object, e As EventArgs) Handles AddItem.Click
        With AddNewItems
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
            .BringToFront()

        End With

    End Sub
End Class