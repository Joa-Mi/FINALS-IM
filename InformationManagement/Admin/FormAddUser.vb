Imports System.Drawing.Drawing2D
Imports System.Net.Mime.MediaTypeNames

Public Class FormAddUser

    Private Sub FormAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        ' Validate all required fields
        If txtFullName.Text.Trim() = "" Then
            MessageBox.Show("Please enter full name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFullName.Focus()
            Return
        End If


        If cmbRole.SelectedIndex = -1 Then
            MessageBox.Show("Please select a role.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbRole.Focus()
            Return
        End If

        If cmbStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please select a status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbStatus.Focus()
            Return
        End If

        Dim dateJoined As String = DateTime.Now.ToString("MMMM dd, yyyy")

        UsersAccounts.UsersAccountData.Rows.Add(
        txtFullName.Text.Trim(),
        cmbRole.SelectedItem.ToString(),
        cmbStatus.SelectedItem.ToString(),
        dateJoined
    )

        txtFullName.Text = ""
        cmbRole.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1

        Me.Close()
    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
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


    Private Sub FormAddUser_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Me.Close()
    End Sub

End Class