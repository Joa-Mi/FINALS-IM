Imports MySqlConnector

Public Class BatchManagement
    Private _ingredientID As Integer
    Private _ingredientName As String
    Private buttonsAdded As Boolean = False

    ' Constructor
    Public Sub New(ingredientID As Integer, ingredientName As String)
        InitializeComponent()
        _ingredientID = ingredientID
        _ingredientName = ingredientName
    End Sub

    ' Form Load
    Private Sub BatchManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Batch Management - " & _ingredientName
        lblIngredientName.Text = _ingredientName

        ' Add action buttons ONCE only
        If Not buttonsAdded Then
            AddActionButtons()
            buttonsAdded = True
        End If

        LoadBatchData()
    End Sub

    ' Add Edit + Discard buttons only (Delete button removed)
    Private Sub AddActionButtons()
        ' (1) Edit Button
        Dim btnEdit As New DataGridViewButtonColumn()
        btnEdit.Name = "btnEdit"
        btnEdit.HeaderText = "Edit"
        btnEdit.Text = "Edit"
        btnEdit.UseColumnTextForButtonValue = True
        dgvBatches.Columns.Add(btnEdit)

        ' (2) Discard Button
        Dim btnDiscard As New DataGridViewButtonColumn()
        btnDiscard.Name = "btnDiscard"
        btnDiscard.HeaderText = "Discard"
        btnDiscard.Text = "Discard"
        btnDiscard.UseColumnTextForButtonValue = True
        dgvBatches.Columns.Add(btnDiscard)
    End Sub

    ' Load batches
    Private Sub LoadBatchData()
        Try
            openConn()

            Dim sql As String = "
                SELECT 
                    BatchID AS 'Batch ID',
                    BatchNumber AS 'Batch Number',
                    StockQuantity AS 'Current Stock',
                    OriginalQuantity AS 'Original Qty',
                    UnitType AS 'Unit',
                    CostPerUnit AS 'Cost/Unit',
                    (StockQuantity * CostPerUnit) AS 'Total Cost',
                    PurchaseDate AS 'Purchase Date',
                    ExpirationDate AS 'Expiration',
                    CASE 
                        WHEN ExpirationDate IS NULL THEN NULL
                        ELSE DATEDIFF(ExpirationDate, CURDATE())
                    END AS 'Days Left',
                    CASE 
                        WHEN BatchStatus = 'Expired' THEN 'EXPIRED'
                        WHEN BatchStatus = 'Depleted' THEN 'Depleted'
                        WHEN ExpirationDate IS NULL THEN 'No Expiry'
                        WHEN ExpirationDate <= CURDATE() THEN 'EXPIRED'
                        WHEN DATEDIFF(ExpirationDate, CURDATE()) <= 3 THEN 'CRITICAL'
                        WHEN DATEDIFF(ExpirationDate, CURDATE()) <= 7 THEN 'WARNING'
                        WHEN DATEDIFF(ExpirationDate, CURDATE()) <= 14 THEN 'Monitor'
                        ELSE 'Fresh'
                    END AS 'Alert',
                    BatchStatus AS 'Status',
                    StorageLocation AS 'Storage Location',
                    ROUND((StockQuantity / OriginalQuantity) * 100, 1) AS 'Remaining %',
                    Notes
                FROM inventory_batches
                WHERE IngredientID = @ingredientID
                 AND BatchStatus <> 'Discarded'
                ORDER BY ExpirationDate ASC;
            "

            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@ingredientID", _ingredientID)

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvBatches.DataSource = dt

            FormatBatchGrid()
            ColorCodeBatches()
            LoadBatchStatistics()

        Catch ex As Exception
            MessageBox.Show("Error loading batches: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    ' Format grid
    Private Sub FormatBatchGrid()
        With dgvBatches
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowTemplate.Height = 35
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With

        ' Format currency
        If dgvBatches.Columns.Contains("Cost/Unit") Then
            dgvBatches.Columns("Cost/Unit").DefaultCellStyle.Format = "₱#,##0.00"
        End If
        If dgvBatches.Columns.Contains("Total Cost") Then
            dgvBatches.Columns("Total Cost").DefaultCellStyle.Format = "₱#,##0.00"
        End If

        ' Date formatting
        If dgvBatches.Columns.Contains("Purchase Date") Then
            dgvBatches.Columns("Purchase Date").DefaultCellStyle.Format = "MMM dd, yyyy"
        End If
        If dgvBatches.Columns.Contains("Expiration") Then
            dgvBatches.Columns("Expiration").DefaultCellStyle.Format = "MMM dd, yyyy"
        End If
    End Sub

    ' Apply row color codes
    Private Sub ColorCodeBatches()
        For Each row As DataGridViewRow In dgvBatches.Rows
            Dim alert As String = row.Cells("Alert").Value?.ToString()

            Select Case alert
                Case "EXPIRED"
                    row.Cells("Alert").Style.BackColor = Color.DarkRed
                    row.Cells("Alert").Style.ForeColor = Color.White

                Case "CRITICAL"
                    row.Cells("Alert").Style.BackColor = Color.Red
                    row.Cells("Alert").Style.ForeColor = Color.White

                Case "WARNING"
                    row.Cells("Alert").Style.BackColor = Color.Gold

                Case "Monitor"
                    row.Cells("Alert").Style.BackColor = Color.Khaki

                Case "Fresh"
                    row.Cells("Alert").Style.BackColor = Color.Green
                    row.Cells("Alert").Style.ForeColor = Color.White
            End Select
        Next
    End Sub

    ' Load statistics - Now fully dynamic with proper parameters
    Private Sub LoadBatchStatistics()
        Try
            openConn()

            ' Total stock
            Dim cmdTotalStock As New MySqlCommand("
                SELECT COALESCE(SUM(StockQuantity), 0)
                FROM inventory_batches
                WHERE IngredientID = @ingredientID AND BatchStatus='Active'", conn)
            cmdTotalStock.Parameters.AddWithValue("@ingredientID", _ingredientID)
            lblTotalStock.Text = cmdTotalStock.ExecuteScalar().ToString()

            ' Active batches
            Dim cmdActiveBatches As New MySqlCommand("
                SELECT COUNT(*)
                FROM inventory_batches
                WHERE IngredientID = @ingredientID AND BatchStatus='Active'", conn)
            cmdActiveBatches.Parameters.AddWithValue("@ingredientID", _ingredientID)
            lblActiveBatches.Text = cmdActiveBatches.ExecuteScalar().ToString()

            ' Total value
            Dim cmdTotalValue As New MySqlCommand("
                SELECT COALESCE(SUM(StockQuantity * CostPerUnit), 0)
                FROM inventory_batches
                WHERE IngredientID = @ingredientID AND BatchStatus='Active'", conn)
            cmdTotalValue.Parameters.AddWithValue("@ingredientID", _ingredientID)
            lblTotalValue.Text = "₱" & Convert.ToDecimal(cmdTotalValue.ExecuteScalar()).ToString("#,##0.00")

        Catch ex As Exception
            MessageBox.Show("Statistics error: " & ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    ' Handle action button clicks (Delete button removed)
    Private Sub dgvBatches_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBatches.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim batchID As Integer = dgvBatches.Rows(e.RowIndex).Cells("Batch ID").Value
        Dim batchStock As Decimal = dgvBatches.Rows(e.RowIndex).Cells("Current Stock").Value

        Select Case dgvBatches.Columns(e.ColumnIndex).Name
            Case "btnEdit"
                Dim f As New EditBatch(batchID, _ingredientName)
                If f.ShowDialog() = DialogResult.OK Then LoadBatchData()

            Case "btnDiscard"
                DiscardBatch(batchID, batchStock)
        End Select
    End Sub

    ' Discard batch
    Private Sub DiscardBatch(id As Integer, stock As Decimal)
        If MessageBox.Show("Discard this batch? This will mark it as discarded and set stock to zero.", "Confirm Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Exit Sub

        Try
            openConn()
            Dim cmd As New MySqlCommand("
                UPDATE inventory_batches 
                SET BatchStatus='Discarded', StockQuantity=0 
                WHERE BatchID=@id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Batch discarded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadBatchData()

        Catch ex As Exception
            MessageBox.Show("Error discarding batch: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConn()
        End Try
    End Sub

    ' View History
    Private Sub btnViewHistory_Click(sender As Object, e As EventArgs) Handles btnViewHistory.Click
        Try
            Dim historyForm As New Form()
            historyForm.Text = "Batch History - " & _ingredientName
            historyForm.Size = New Size(1200, 600)
            historyForm.StartPosition = FormStartPosition.CenterParent

            ' Create DataGridView for history
            Dim dgvHistory As New DataGridView()
            dgvHistory.Dock = DockStyle.Fill
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvHistory.ReadOnly = True
            dgvHistory.AllowUserToAddRows = False
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            ' Create panel for buttons
            Dim pnlButtons As New Panel()
            pnlButtons.Dock = DockStyle.Bottom
            pnlButtons.Height = 50

            ' Clear History Button
            Dim btnClearHistory As New Button()
            btnClearHistory.Text = "Clear History"
            btnClearHistory.Size = New Size(120, 35)
            btnClearHistory.Location = New Point(10, 8)
            AddHandler btnClearHistory.Click, Sub()
                                                  If MessageBox.Show("Are you sure you want to clear all discarded batch history for this ingredient?" & vbCrLf & "This action cannot be undone!", "Confirm Clear History", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                                                      Try
                                                          openConn()
                                                          Dim cmdClear As New MySqlCommand("DELETE FROM inventory_batches WHERE IngredientID = @ingredientID AND BatchStatus = 'Discarded'", conn)
                                                          cmdClear.Parameters.AddWithValue("@ingredientID", _ingredientID)
                                                          Dim rowsDeleted As Integer = cmdClear.ExecuteNonQuery()
                                                          closeConn()

                                                          MessageBox.Show(rowsDeleted & " discarded batch(es) removed from history.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                          historyForm.Close()
                                                      Catch ex As Exception
                                                          MessageBox.Show("Error clearing history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                          closeConn()
                                                      End Try
                                                  End If
                                              End Sub

            ' Close Button
            Dim btnCloseHistory As New Button()
            btnCloseHistory.Text = "Close"
            btnCloseHistory.Size = New Size(100, 35)
            btnCloseHistory.Location = New Point(140, 8)
            AddHandler btnCloseHistory.Click, Sub() historyForm.Close()

            pnlButtons.Controls.Add(btnClearHistory)
            pnlButtons.Controls.Add(btnCloseHistory)

            ' Load history data
            openConn()
            Dim sql As String = "
                SELECT 
                    BatchID AS 'Batch ID',
                    BatchNumber AS 'Batch Number',
                    OriginalQuantity AS 'Original Qty',
                    UnitType AS 'Unit',
                    CostPerUnit AS 'Cost/Unit',
                    PurchaseDate AS 'Purchase Date',
                    ExpirationDate AS 'Expiration',
                    BatchStatus AS 'Status',
                    StorageLocation AS 'Storage Location',
                    Notes
                FROM inventory_batches
                WHERE IngredientID = @ingredientID
                  AND BatchStatus = 'Discarded'
                ORDER BY BatchID DESC
            "
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@ingredientID", _ingredientID)

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            closeConn()

            dgvHistory.DataSource = dt

            ' Format currency columns
            If dgvHistory.Columns.Contains("Cost/Unit") Then
                dgvHistory.Columns("Cost/Unit").DefaultCellStyle.Format = "₱#,##0.00"
            End If
            If dgvHistory.Columns.Contains("Purchase Date") Then
                dgvHistory.Columns("Purchase Date").DefaultCellStyle.Format = "MMM dd, yyyy"
            End If
            If dgvHistory.Columns.Contains("Expiration") Then
                dgvHistory.Columns("Expiration").DefaultCellStyle.Format = "MMM dd, yyyy"
            End If

            historyForm.Controls.Add(dgvHistory)
            historyForm.Controls.Add(pnlButtons)
            historyForm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error loading history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            closeConn()
        End Try
    End Sub

    Private Sub btnAddBatch_Click(sender As Object, e As EventArgs) Handles btnAddBatch.Click
        Dim addForm As New AddNewBatch(_ingredientID, _ingredientName, "")
        If addForm.ShowDialog() = DialogResult.OK Then LoadBatchData()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class