Imports System.Drawing.Drawing2D

Public Class FormEditUser

    Private Sub FormEditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundComboBox(cmbRole, 8)
        RoundComboBox(cmbStatus, 8)
    End Sub
    Private Sub RoundComboBox(cmb As ComboBox, radius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(cmb.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(cmb.Width - radius, cmb.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, cmb.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()
        cmb.Region = New Region(path)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' 🔹 Update button
    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private Sub ComboBox_DrawItem(sender As Object, e As DrawItemEventArgs) _
       Handles cmbRole.DrawItem, cmbStatus.DrawItem

        If e.Index < 0 Then Return
        Dim cmb As ComboBox = DirectCast(sender, ComboBox)
        e.DrawBackground()
        e.Graphics.DrawString(cmb.Items(e.Index).ToString(), cmb.Font, Brushes.Black, e.Bounds)
        e.DrawFocusRectangle()
    End Sub
    Private Sub FormEditUser_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Close()
    End Sub
End Class
