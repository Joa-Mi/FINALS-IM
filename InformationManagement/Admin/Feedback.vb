Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Feedback
    ' Database connection string
    Private connectionString As String = "Server=localhost;Database=tabeya_system;Uid=root;Pwd=;"
    Private conn As MySqlConnection
    Private adapter As MySqlDataAdapter
    Private dt As DataTable

    ' Form Load Event
    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeConnection()
        LoadReviews()
        SetupDataGridView()
        LoadReservations()
    End Sub

    ' Initialize Database Connection
    Private Sub InitializeConnection()
        Try
            conn = New MySqlConnection(connectionString)
        Catch ex As Exception
            MessageBox.Show("Connection Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Setup DataGridView Appearance
    Private Sub SetupDataGridView()
        With DataGridView1
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
            .RowHeadersVisible = False

            ' Add Action Buttons if not exists
            If Not .Columns.Contains("Approve") Then
                Dim btnApprove As New DataGridViewButtonColumn()
                btnApprove.Name = "Approve"
                btnApprove.HeaderText = "Approve"
                btnApprove.Text = "Approve"
                btnApprove.UseColumnTextForButtonValue = True
                .Columns.Add(btnApprove)
            End If

            If Not .Columns.Contains("Reject") Then
                Dim btnReject As New DataGridViewButtonColumn()
                btnReject.Name = "Reject"
                btnReject.HeaderText = "Reject"
                btnReject.Text = "Reject"
                btnReject.UseColumnTextForButtonValue = True
                .Columns.Add(btnReject)
            End If
        End With
    End Sub

    ' Load All Reviews from Database
    Private Sub LoadReviews(Optional status As String = "")
        Try
            conn.Open()

            Dim query As String = "SELECT 
                cr.ReviewID,
                cr.CustomerID,
                CONCAT(c.FirstName, ' ', c.LastName) AS CustomerName,
                cr.OverallRating,
                cr.FoodTasteRating,
                cr.PortionSizeRating,
                cr.CustomerServiceRating,
                cr.AmbienceRating,
                cr.CleanlinessRating,
                cr.GeneralComment,
                cr.Status,
                cr.CreatedDate,
                cr.ApprovedDate
                FROM customer_reviews cr
                INNER JOIN customers c ON cr.CustomerID = c.CustomerID"

            If status <> "" Then
                query &= " WHERE cr.Status = @status"
            End If

            query &= " ORDER BY cr.CreatedDate DESC"

            adapter = New MySqlDataAdapter(query, conn)

            If status <> "" Then
                adapter.SelectCommand.Parameters.AddWithValue("@status", status)
            End If

            dt = New DataTable()
            adapter.Fill(dt)

            DataGridView1.DataSource = dt

            ' Format columns
            FormatColumns()

            ' Update status label
            lblTotalReviews.Text = "Total Reviews: " & dt.Rows.Count

        Catch ex As Exception
            MessageBox.Show("Error loading reviews: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Format DataGridView Columns
    Private Sub FormatColumns()
        With DataGridView1
            If .Columns.Contains("ReviewID") Then .Columns("ReviewID").HeaderText = "Review ID"
            If .Columns.Contains("CustomerID") Then .Columns("CustomerID").Visible = False
            If .Columns.Contains("CustomerName") Then .Columns("CustomerName").HeaderText = "Customer Name"
            If .Columns.Contains("OverallRating") Then .Columns("OverallRating").HeaderText = "Overall Rating"
            If .Columns.Contains("FoodTasteRating") Then .Columns("FoodTasteRating").HeaderText = "Food"
            If .Columns.Contains("PortionSizeRating") Then .Columns("PortionSizeRating").HeaderText = "Portion"
            If .Columns.Contains("CustomerServiceRating") Then .Columns("CustomerServiceRating").HeaderText = "Service"
            If .Columns.Contains("AmbienceRating") Then .Columns("AmbienceRating").HeaderText = "Ambience"
            If .Columns.Contains("CleanlinessRating") Then .Columns("CleanlinessRating").HeaderText = "Cleanliness"
            If .Columns.Contains("GeneralComment") Then .Columns("GeneralComment").HeaderText = "Comment"
            If .Columns.Contains("Status") Then .Columns("Status").HeaderText = "Status"
            If .Columns.Contains("CreatedDate") Then .Columns("CreatedDate").HeaderText = "Date Created"
            If .Columns.Contains("ApprovedDate") Then .Columns("ApprovedDate").HeaderText = "Date Approved"
        End With
    End Sub

    ' DataGridView Cell Click Event (for action buttons)
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim columnName As String = DataGridView1.Columns(e.ColumnIndex).Name
        Dim reviewId As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("ReviewID").Value)
        Dim currentStatus As String = DataGridView1.Rows(e.RowIndex).Cells("Status").Value.ToString()

        If columnName = "Approve" Then
            If currentStatus = "Approved" Then
                MessageBox.Show("This review is already approved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If MessageBox.Show("Are you sure you want to approve this review?", "Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                UpdateReviewStatus(reviewId, "Approved")
            End If

        ElseIf columnName = "Reject" Then
            If currentStatus = "Rejected" Then
                MessageBox.Show("This review is already rejected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If MessageBox.Show("Are you sure you want to reject this review?", "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                UpdateReviewStatus(reviewId, "Rejected")
            End If
        End If
    End Sub

    ' Update Review Status (Approve/Reject)
    Private Sub UpdateReviewStatus(reviewId As Integer, status As String)
        Try
            conn.Open()

            Dim query As String = "UPDATE customer_reviews 
                                  SET Status = @status, 
                                      ApprovedDate = IF(@status = 'Approved', NOW(), NULL),
                                      UpdatedDate = NOW()
                                  WHERE ReviewID = @reviewId"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@status", status)
            cmd.Parameters.AddWithValue("@reviewId", reviewId)

End Class