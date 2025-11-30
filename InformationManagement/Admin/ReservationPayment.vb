Imports MySqlConnector
Imports System.Data

Public Class ReservationPayment

    Private Sub ReservationPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReservationPayments()
        UpdateTotal()
    End Sub

    ' =============================================================
    ' LOAD RESERVATION PAYMENTS WITH CUSTOMER INFO
    ' =============================================================
    Private Sub LoadReservationPayments(Optional condition As String = "")
        Try
            Dim query As String =
            "SELECT 
                rp.ReservationPaymentID,
                rp.ReservationID,
                r.CustomerID,
                c.FirstName,
                c.LastName,
                c.Email,
                c.ContactNumber AS CustomerContact,
                r.ContactNumber AS ReservationContact,
                r.EventType,
                r.EventDate,
                rp.PaymentDate,
                rp.PaymentMethod,
                rp.PaymentStatus,
                rp.AmountPaid,
                rp.PaymentSource,
                rp.ProofOfPayment,
                rp.ReceiptFileName,
                rp.TransactionID,
                rp.UpdatedDate
            FROM reservation_payments rp
            INNER JOIN reservations r ON rp.ReservationID = r.ReservationID
            INNER JOIN customers c ON r.CustomerID = c.CustomerID"

            If condition <> "" Then
                query &= " WHERE " & condition
            End If

            query &= " ORDER BY rp.PaymentDate DESC"

            LoadToDGV(query, Reservation, "")

            FormatGrid()

        Catch ex As Exception
            MessageBox.Show("Error loading reservation payments: " & ex.Message)
        End Try
    End Sub

    ' Dummy wrapper to call modDB.LoadToDGV
    Private Sub LoadToDGV(query As String, dgv As DataGridView, filter As String)
        modDB.LoadToDGV(query, dgv, filter)
    End Sub

    ' =============================================================
    ' FORMAT GRID + HIDE COLUMNS + SET WIDTHS
    ' =============================================================
    Private Sub FormatGrid()
        If Reservation.Columns.Count = 0 Then Exit Sub

        ' Hide ID and file columns
        Dim hideCols() As String = {
            "ReservationPaymentID",
            "ReservationID",
            "CustomerID",
            "ProofOfPayment",
            "ReceiptFileName",
            "TransactionID"
        }

        For Each colName In hideCols
            If Reservation.Columns.Contains(colName) Then
                Reservation.Columns(colName).Visible = False
            End If
        Next

        ' Set fixed column widths and order
        If Reservation.Columns.Contains("FirstName") Then
            Reservation.Columns("FirstName").HeaderText = "First Name"
            Reservation.Columns("FirstName").Width = 120
            Reservation.Columns("FirstName").DisplayIndex = 0
        End If

        If Reservation.Columns.Contains("LastName") Then
            Reservation.Columns("LastName").HeaderText = "Last Name"
            Reservation.Columns("LastName").Width = 120
            Reservation.Columns("LastName").DisplayIndex = 1
        End If

        If Reservation.Columns.Contains("Email") Then
            Reservation.Columns("Email").HeaderText = "Email"
            Reservation.Columns("Email").Width = 180
            Reservation.Columns("Email").DisplayIndex = 2
        End If

        If Reservation.Columns.Contains("CustomerContact") Then
            Reservation.Columns("CustomerContact").HeaderText = "Customer Phone"
            Reservation.Columns("CustomerContact").Width = 120
            Reservation.Columns("CustomerContact").DisplayIndex = 3
        End If

        If Reservation.Columns.Contains("ReservationContact") Then
            Reservation.Columns("ReservationContact").HeaderText = "Reservation Phone"
            Reservation.Columns("ReservationContact").Width = 130
            Reservation.Columns("ReservationContact").DisplayIndex = 4
        End If

        If Reservation.Columns.Contains("EventType") Then
            Reservation.Columns("EventType").HeaderText = "Event Type"
            Reservation.Columns("EventType").Width = 120
            Reservation.Columns("EventType").DisplayIndex = 5
        End If

        If Reservation.Columns.Contains("EventDate") Then
            Reservation.Columns("EventDate").HeaderText = "Event Date"
            Reservation.Columns("EventDate").Width = 100
            Reservation.Columns("EventDate").DefaultCellStyle.Format = "MM/dd/yyyy"
            Reservation.Columns("EventDate").DisplayIndex = 6
        End If

        If Reservation.Columns.Contains("PaymentDate") Then
            Reservation.Columns("PaymentDate").HeaderText = "Payment Date"
            Reservation.Columns("PaymentDate").Width = 110
            Reservation.Columns("PaymentDate").DefaultCellStyle.Format = "MM/dd/yyyy"
            Reservation.Columns("PaymentDate").DisplayIndex = 7
        End If

        If Reservation.Columns.Contains("PaymentMethod") Then
            Reservation.Columns("PaymentMethod").HeaderText = "Payment Method"
            Reservation.Columns("PaymentMethod").Width = 120
            Reservation.Columns("PaymentMethod").DisplayIndex = 8
        End If

        If Reservation.Columns.Contains("PaymentStatus") Then
            Reservation.Columns("PaymentStatus").HeaderText = "Payment Status"
            Reservation.Columns("PaymentStatus").Width = 110
            Reservation.Columns("PaymentStatus").DisplayIndex = 9
        End If

        If Reservation.Columns.Contains("AmountPaid") Then
            Reservation.Columns("AmountPaid").HeaderText = "Amount Paid"
            Reservation.Columns("AmountPaid").Width = 120
            Reservation.Columns("AmountPaid").DefaultCellStyle.Format = "₱ #,##0.00"
            Reservation.Columns("AmountPaid").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Reservation.Columns("AmountPaid").DisplayIndex = 10
        End If

        If Reservation.Columns.Contains("PaymentSource") Then
            Reservation.Columns("PaymentSource").HeaderText = "Payment Source"
            Reservation.Columns("PaymentSource").Width = 120
            Reservation.Columns("PaymentSource").DisplayIndex = 11
        End If

        If Reservation.Columns.Contains("UpdatedDate") Then
            Reservation.Columns("UpdatedDate").HeaderText = "Updated Date"
            Reservation.Columns("UpdatedDate").Width = 110
            Reservation.Columns("UpdatedDate").DefaultCellStyle.Format = "MM/dd/yyyy"
            Reservation.Columns("UpdatedDate").DisplayIndex = 12
        End If

        ' Disable auto-sizing to keep fixed widths
        Reservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        Reservation.ScrollBars = ScrollBars.Both

        ' Other formatting
        Reservation.RowHeadersVisible = False
        Reservation.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        Reservation.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 10)
        Reservation.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 60, 85)
        Reservation.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Reservation.EnableHeadersVisualStyles = False
    End Sub

    ' =============================================================
    ' DATA BIND COMPLETE (ensures hidden columns stay hidden)
    ' =============================================================
    Private Sub Reservation_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Reservation.DataBindingComplete
        FormatGrid()
    End Sub

    ' =============================================================
    ' SEARCH - Updated to include customer name and email
    ' =============================================================
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword As String = txtSearch.Text.Trim()

        If keyword = "" Then
            LoadReservationPayments()
        Else
            LoadReservationPayments(
                $"rp.ReservationPaymentID LIKE '%{keyword}%' 
                  OR rp.ReservationID LIKE '%{keyword}%' 
                  OR rp.PaymentStatus LIKE '%{keyword}%'
                  OR c.FirstName LIKE '%{keyword}%'
                  OR c.LastName LIKE '%{keyword}%'
                  OR c.Email LIKE '%{keyword}%'
                  OR r.EventType LIKE '%{keyword}%'")
        End If

        UpdateTotal()
    End Sub

    ' =============================================================
    ' REFRESH
    ' =============================================================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        LoadReservationPayments()
        UpdateTotal()
    End Sub

    ' =============================================================
    ' UPDATE TOTAL COUNT
    ' =============================================================
    Private Sub UpdateTotal()
        lblTotalRecords.Text = "Total: " & Reservation.Rows.Count.ToString()
    End Sub

    ' =============================================================
    ' UPDATE PAYMENT STATUS - Allows changing status to Completed, Refunded, or Failed
    ' =============================================================
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            ' Check if a row is selected
            If Reservation.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a payment record to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Get the selected row
            Dim selectedRow As DataGridViewRow = Reservation.SelectedRows(0)
            Dim paymentID As String = selectedRow.Cells("ReservationPaymentID").Value.ToString()
            Dim currentStatus As String = selectedRow.Cells("PaymentStatus").Value.ToString()
            Dim reservationID As String = selectedRow.Cells("ReservationID").Value.ToString()
            Dim customerName As String = selectedRow.Cells("FirstName").Value.ToString() & " " & selectedRow.Cells("LastName").Value.ToString()

            ' Show dialog to select new status
            Dim statusForm As New Form()
            statusForm.Text = "Update Payment Status"
            statusForm.Size = New Size(400, 280)
            statusForm.StartPosition = FormStartPosition.CenterParent
            statusForm.FormBorderStyle = FormBorderStyle.FixedDialog
            statusForm.MaximizeBox = False
            statusForm.MinimizeBox = False

            ' Label
            Dim lblInfo As New Label()
            lblInfo.Text = $"Payment ID: {paymentID}" & vbCrLf &
                          $"Reservation ID: {reservationID}" & vbCrLf &
                          $"Customer: {customerName}" & vbCrLf &
                          $"Current Status: {currentStatus}" & vbCrLf & vbCrLf &
                          "Select new status:"
            lblInfo.Location = New Point(20, 20)
            lblInfo.Size = New Size(350, 100)
            lblInfo.Font = New Font("Segoe UI", 10)
            statusForm.Controls.Add(lblInfo)

            ' Radio buttons for status options
            Dim rbCompleted As New RadioButton()
            rbCompleted.Text = "Completed"
            rbCompleted.Location = New Point(30, 130)
            rbCompleted.Size = New Size(120, 25)
            rbCompleted.Font = New Font("Segoe UI", 10)
            rbCompleted.Checked = True
            statusForm.Controls.Add(rbCompleted)

            Dim rbRefunded As New RadioButton()
            rbRefunded.Text = "Refunded"
            rbRefunded.Location = New Point(160, 130)
            rbRefunded.Size = New Size(120, 25)
            rbRefunded.Font = New Font("Segoe UI", 10)
            statusForm.Controls.Add(rbRefunded)

            Dim rbFailed As New RadioButton()
            rbFailed.Text = "Failed"
            rbFailed.Location = New Point(290, 130)
            rbFailed.Size = New Size(100, 25)
            rbFailed.Font = New Font("Segoe UI", 10)
            statusForm.Controls.Add(rbFailed)

            ' Buttons
            Dim btnOK As New Button()
            btnOK.Text = "Update"
            btnOK.Location = New Point(200, 180)
            btnOK.Size = New Size(80, 35)
            btnOK.DialogResult = DialogResult.OK
            btnOK.Font = New Font("Segoe UI", 9)
            statusForm.Controls.Add(btnOK)

            Dim btnCancel As New Button()
            btnCancel.Text = "Cancel"
            btnCancel.Location = New Point(290, 180)
            btnCancel.Size = New Size(80, 35)
            btnCancel.DialogResult = DialogResult.Cancel
            btnCancel.Font = New Font("Segoe UI", 9)
            statusForm.Controls.Add(btnCancel)

            statusForm.AcceptButton = btnOK
            statusForm.CancelButton = btnCancel

            ' Show the dialog
            If statusForm.ShowDialog() = DialogResult.OK Then
                Dim newStatus As String = ""

                If rbCompleted.Checked Then
                    newStatus = "Completed"
                ElseIf rbRefunded.Checked Then
                    newStatus = "Refunded"
                ElseIf rbFailed.Checked Then
                    newStatus = "Failed"
                End If

                ' Check if status is actually changing
                If newStatus.ToLower() = currentStatus.ToLower() Then
                    MessageBox.Show($"Payment status is already '{currentStatus}'.", "No Change", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                ' Update the payment status
                Dim updateQuery As String = $"UPDATE reservation_payments 
                                             SET PaymentStatus = '{newStatus}', 
                                                 UpdatedDate = NOW() 
                                             WHERE ReservationPaymentID = '{paymentID}'"

                modDB.readQuery(updateQuery)

                MessageBox.Show($"Payment status updated to '{newStatus}' successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Reload the grid
                LoadReservationPayments()
                UpdateTotal()
            End If

        Catch ex As Exception
            MessageBox.Show("Error updating payment status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =============================================================
    ' DELETE PAYMENT - Removes payment record from database
    ' =============================================================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Check if a row is selected
            If Reservation.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a payment record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Get the selected row
            Dim selectedRow As DataGridViewRow = Reservation.SelectedRows(0)
            Dim paymentID As String = selectedRow.Cells("ReservationPaymentID").Value.ToString()
            Dim reservationID As String = selectedRow.Cells("ReservationID").Value.ToString()
            Dim amountPaid As Decimal = Convert.ToDecimal(selectedRow.Cells("AmountPaid").Value)
            Dim customerName As String = selectedRow.Cells("FirstName").Value.ToString() & " " & selectedRow.Cells("LastName").Value.ToString()

            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show(
                $"Are you sure you want to delete this payment record?" & vbCrLf &
                $"Payment ID: {paymentID}" & vbCrLf &
                $"Reservation ID: {reservationID}" & vbCrLf &
                $"Customer: {customerName}" & vbCrLf &
                $"Amount: ₱{amountPaid:N2}" & vbCrLf & vbCrLf &
                "This action cannot be undone!",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Delete the payment record
                Dim deleteQuery As String = $"DELETE FROM reservation_payments 
                                             WHERE ReservationPaymentID = '{paymentID}'"

                modDB.readQuery(deleteQuery)

                MessageBox.Show("Payment record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Reload the grid
                LoadReservationPayments()
                UpdateTotal()
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class