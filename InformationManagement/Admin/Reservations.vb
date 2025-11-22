Public Class Reservations
    Private Sub btnAddNewReservation_Click(sender As Object, e As EventArgs) Handles btnAddNewReservation.Click
        With PanelCreateReservation
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
            .BringToFront()
        End With

    End Sub
End Class