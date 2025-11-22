Public Class FormAddNewPayrollRecord
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub FormAddNewPayrollRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedTextBox1.TextBoxBackColor = Color.WhiteSmoke
    End Sub
    Private Sub ComboBox_DrawItem(sender As Object, e As DrawItemEventArgs) _
       Handles cmbPosition.DrawItem, cmbPayperiod.DrawItem

        If e.Index < 0 Then Return
        Dim cmb As ComboBox = DirectCast(sender, ComboBox)
        e.DrawBackground()
        e.Graphics.DrawString(cmb.Items(e.Index).ToString(), cmb.Font, Brushes.Black, e.Bounds)
        e.DrawFocusRectangle()
    End Sub
    Private Sub FormAddNewPayrollRecord_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Close()
    End Sub
End Class