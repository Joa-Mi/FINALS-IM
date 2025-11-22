Imports System.Security.Policy

Public Class UsersAccounts
    Private Sub UsersAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateUserCounts()

    End Sub

    Private Sub UsersAccountData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersAccountData.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = UsersAccountData.Rows(e.RowIndex)
            Dim username As String = selectedRow.Cells("Name").Value.ToString()

            ' --- EDIT BUTTON ---
            If e.ColumnIndex = UsersAccountData.Columns("colEdit").Index Then
                Dim editForm As New FormEditUser()

                ' Pass data to edit form
                editForm.txtFullName.Text = selectedRow.Cells("Name").Value.ToString()
                editForm.cmbRole.Text = selectedRow.Cells("colRole").Value.ToString()
                editForm.cmbStatus.Text = selectedRow.Cells("colStatus").Value.ToString()

                ' Show form centered
                editForm.StartPosition = FormStartPosition.CenterParent
                editForm.ShowDialog()

                ' OPTIONAL: Update DataGridView if form was saved
                If editForm.DialogResult = DialogResult.OK Then
                    selectedRow.Cells("Name").Value = editForm.txtFullName.Text
                    selectedRow.Cells("colRole").Value = editForm.cmbRole.Text
                    selectedRow.Cells("colStatus").Value = editForm.cmbStatus.Text
                End If

                ' --- DELETE BUTTON ---
            ElseIf e.ColumnIndex = UsersAccountData.Columns("colDelete").Index Then
                Dim result As DialogResult = MessageBox.Show(
                    "Are you sure you want to delete " & username & "?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                )

                If result = DialogResult.Yes Then
                    UsersAccountData.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        End If
    End Sub
    ' Helper to apply rounded corners and active style
    Private Sub SetActiveButton(activeBtn As Button)
        ' Reset all buttons to default
        Dim buttons() As Button = {AllUsersbtn, Staffbtn, Employeesbtn, Customerbtn}

        For Each btn As Button In buttons
            btn.BackColor = Color.White
            btn.ForeColor = Color.Black
            btn.FlatAppearance.BorderSize = 0
        Next

        ' Highlight the active button
        activeBtn.BackColor = Color.FromArgb(25, 25, 35) ' Dark background
        activeBtn.ForeColor = Color.White
    End Sub


    Private Sub AllUsersbtn_Click(sender As Object, e As EventArgs) Handles AllUsersbtn.Click
        SetActiveButton(AllUsersbtn)
        For Each row As DataGridViewRow In UsersAccountData.Rows
            row.Visible = True
        Next
    End Sub

    Private Sub Staffbtn_Click(sender As Object, e As EventArgs) Handles Staffbtn.Click
        SetActiveButton(Staffbtn)
        For Each row As DataGridViewRow In UsersAccountData.Rows
            Dim role As String = row.Cells("colRole").Value.ToString().ToLower()
            row.Visible = (role = "staff")
        Next
    End Sub

    Private Sub Employeesbtn_Click(sender As Object, e As EventArgs) Handles Employeesbtn.Click
        SetActiveButton(Employeesbtn)
        For Each row As DataGridViewRow In UsersAccountData.Rows
            Dim role As String = row.Cells("colRole").Value.ToString().ToLower()
            row.Visible = (role = "employee" Or role = "employees")
        Next
    End Sub

    Private Sub Customerbtn_Click(sender As Object, e As EventArgs) Handles Customerbtn.Click
        SetActiveButton(Customerbtn)
        For Each row As DataGridViewRow In UsersAccountData.Rows
            Dim role As String = row.Cells("colRole").Value.ToString().ToLower()
            row.Visible = (role = "customer" Or role = "customers")
        Next

    End Sub

    Private Sub UpdateUserCounts()
        Dim totalUsers As Integer = UsersAccountData.Rows.Count
        Dim staffCount As Integer = 0
        Dim employeeCount As Integer = 0
        Dim customerCount As Integer = 0

        ' Loop through the DataGridView rows
        For Each row As DataGridViewRow In UsersAccountData.Rows
            If Not row.IsNewRow Then
                Dim role As String = row.Cells("colRole").Value.ToString().ToLower()

                Select Case role
                    Case "staff"
                        staffCount += 1
                    Case "employee"
                        employeeCount += 1
                    Case "customer"
                        customerCount += 1
                End Select
            End If
        Next

        ' Update labels
        lblTotalUsers.Text = totalUsers.ToString()
        lblStaffs.Text = staffCount.ToString()
        lblEmployees.Text = employeeCount.ToString()
        lblCustomers.Text = customerCount.ToString()
    End Sub

    Private Sub UsersAccountData_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles UsersAccountData.RowsAdded
        UpdateUserCounts()
    End Sub

    Private Sub UsersAccountData_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles UsersAccountData.RowsRemoved
        UpdateUserCounts()
    End Sub
    Private Sub RoundButton(btn As Button)
        Dim radius As Integer = 12
        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(btn.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, btn.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()
        btn.Region = New Region(path)
    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButton(AllUsersbtn)
        RoundButton(Staffbtn)
        RoundButton(Employeesbtn)
        RoundButton(Customerbtn)
        SetActiveButton(AllUsersbtn) ' Default active
        RoundButton(Adduserbtn)
    End Sub

    Private Sub Adduserbtn_Click(sender As Object, e As EventArgs) Handles Adduserbtn.Click

        With FormAddUser
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
            .BringToFront()

        End With


    End Sub


End Class