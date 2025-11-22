Public Class Employee
    Private Sub Splitter1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles Splitter1.SplitterMoved

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub AddEmployee_Click(sender As Object, e As EventArgs) Handles AddEmployee.Click
        With AddEmployee

            .Show()
            .BringToFront()
        End With

    End Sub
End Class