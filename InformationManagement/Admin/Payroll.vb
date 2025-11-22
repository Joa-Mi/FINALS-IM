Public Class Payroll
    Private Sub AddNewPayrollRecordbtn_Click(sender As Object, e As EventArgs) Handles AddNewPayrollRecordbtn.Click
        With FormAddNewPayrollRecord
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
            .BringToFront()
        End With
    End Sub
End Class