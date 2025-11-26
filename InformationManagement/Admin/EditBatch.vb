Imports MySqlConnector

Public Class EditBatch

    Private _batchID As Integer
    Private _ingredientName As String
    Private _ingredientID As Integer

    Public Sub New(batchID As Integer, ingredientName As String)
        InitializeComponent()
        _batchID = batchID
        _ingredientName = ingredientName
    End Sub

    Private Sub EditBatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigureFormLayout()
        LoadBatchData()
    End Sub

    ' Configure form layout and styling
    Private Sub ConfigureFormLayout()
        Try
            Me.BackColor = Color.White
            Me.Font = New Font("Segoe UI", 10)

            ' Header styling
            Label1.Font = New Font("Segoe UI", 18, FontStyle.Bold)
            Label1.ForeColor = Color.FromArgb(26, 38, 50)

            Label2.Font = New Font("Segoe UI", 11, FontStyle.Regular)
            Label2.ForeColor = Color.FromArgb(108, 117, 125)

            ' Label styling
            For Each ctrl In Me.Controls.OfType(Of Label)()
                If ctrl.Name.StartsWith("Label") AndAlso ctrl.Name <> "Label1" AndAlso ctrl.Name <> "Label2" Then
                    ctrl.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                    ctrl.ForeColor = Color.FromArgb(26, 38, 50)
                End If
            Next

            ' Button styling
            SaveChanges.BackColor = Color.FromArgb(40, 167, 69)
            SaveChanges.ForeColor = Color.White
            SaveChanges.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            SaveChanges.FlatStyle = FlatStyle.Flat
            SaveChanges.FlatAppearance.BorderSize = 0
            SaveChanges.Cursor = Cursors.Hand

            Cancel.BackColor = Color.FromArgb(108, 117, 125)
            Cancel.ForeColor = Color.White
            Cancel.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            Cancel.FlatStyle = FlatStyle.Flat
            Cancel.FlatAppearance.BorderSize = 0
            Cancel.Cursor = Cursors.Hand

            ' Make identifying fields read-only
            txtItemName.ReadOnly = True
            txtBatchNumber.ReadOnly = True

        Catch ex As Exception
            MessageBox.Show("Error configuring form: " & ex.Message)
        End Try
    End Sub

    ' Load existing batch data
    Private Sub LoadBatchData()
        Try
            openConn()

            Dim sql As String = "
                SELECT 
                    ib.IngredientID,
                    i.IngredientName,
                    ib.BatchNumber,
                    ib.StockQuantity,
                    ib.OriginalQuantity,
                    ib.UnitType,
                    ib.CostPerUnit,
                    ib.PurchaseDate,
                    ib.ExpirationDate,
                    i.MinStockLevel,
                    i.MaxStockLevel
                FROM inventory_batches ib
                JOIN ingredients i ON ib.IngredientID = i.IngredientID
                WHERE ib.BatchID = @batchID
            "

            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@batchID", _batchID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                _ingredientID = reader.GetInt32("IngredientID")

                ' Fill in the form
                txtItemName.Text = reader.GetString("IngredientName")
                txtBatchNumber.Text = reader.GetString("BatchNumber")
                Quantity.Text = reader.GetDecimal("StockQuantity").ToString()
                txtOriginalQty.Text = reader.GetDecimal("OriginalQuantity").ToString()
                Unit.Text = reader.GetString("UnitType")
                RoundedTextBox1.Text = reader.GetDecimal("CostPerUnit").ToString()
                DateTimePicker1.Value = reader.GetDateTime("PurchaseDate")

                If Not reader.IsDBNull(reader.GetOrdinal("ExpirationDate")) Then
                    DateTimePicker2.Value = reader.GetDateTime("ExpirationDate")
                Else
                    DateTimePicker2.Value = Date.Now.AddDays(30)
                End If

                NumericUpDown1.Value = reader.GetDecimal("MinStockLevel")
                NumericUpDown2.Value = reader.GetDecimal("MaxStockLevel")
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading batch data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConn()
        End Try
    End Sub

    ' Save Changes Button Click
    Private Sub SaveChanges_Click(sender As Object, e As EventArgs) Handles SaveChanges.Click
        If ValidateInputs() Then
            UpdateBatch()
        End If
    End Sub

    ' Validate all inputs
    Private Function ValidateInputs() As Boolean
        ' Quantity
        If String.IsNullOrWhiteSpace(Quantity.Text) OrElse Not IsNumeric(Quantity.Text) Then
            MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Quantity.Focus()
            Return False
        End If

        If Convert.ToDecimal(Quantity.Text) < 0 Then
            MessageBox.Show("Quantity cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Quantity.Focus()
            Return False
        End If

        ' Check if current stock is greater than original quantity
        Dim originalQty As Decimal = Convert.ToDecimal(txtOriginalQty.Text)
        Dim currentQty As Decimal = Convert.ToDecimal(Quantity.Text)

        If currentQty > originalQty Then
            MessageBox.Show("Current stock quantity cannot exceed original quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Quantity.Focus()
            Return False
        End If

        ' Unit
        If Unit.SelectedIndex < 0 Then
            MessageBox.Show("Please select a unit type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Unit.Focus()
            Return False
        End If

        ' Cost per Unit
        If String.IsNullOrWhiteSpace(RoundedTextBox1.Text) OrElse Not IsNumeric(RoundedTextBox1.Text) Then
            MessageBox.Show("Please enter a valid cost per unit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            RoundedTextBox1.Focus()
            Return False
        End If

        If Convert.ToDecimal(RoundedTextBox1.Text) < 0 Then
            MessageBox.Show("Cost per unit cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            RoundedTextBox1.Focus()
            Return False
        End If

        ' Stock Levels
        If NumericUpDown1.Value <= 0 Then
            MessageBox.Show("Minimum stock level must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            NumericUpDown1.Focus()
            Return False
        End If

        If NumericUpDown2.Value <= NumericUpDown1.Value Then
            MessageBox.Show("Maximum stock level must be greater than minimum stock level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            NumericUpDown2.Focus()
            Return False
        End If

        ' Expiration Date
        If DateTimePicker2.Value < Date.Now.Date Then
            Dim result As DialogResult = MessageBox.Show(
                "The expiration date is in the past. Are you sure you want to continue?",
                "Expired Item Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

            If result = DialogResult.No Then
                DateTimePicker2.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    ' Update batch in database
    Private Sub UpdateBatch()
        Try
            openConn()

            Dim transaction As MySqlTransaction = conn.BeginTransaction()

            Try
                ' Get old quantity for transaction log
                Dim sqlGetOldQty As String = "SELECT StockQuantity FROM inventory_batches WHERE BatchID = @id"
                Dim cmdGetOldQty As New MySqlCommand(sqlGetOldQty, conn, transaction)
                cmdGetOldQty.Parameters.AddWithValue("@id", _batchID)
                Dim oldQuantity As Decimal = Convert.ToDecimal(cmdGetOldQty.ExecuteScalar())

                ' Update batch
                Dim sqlUpdateBatch As String = "
                    UPDATE inventory_batches
                    SET StockQuantity = @quantity,
                        UnitType = @unit,
                        CostPerUnit = @cost,
                        TotalCost = @quantity * @cost,
                        PurchaseDate = @purchaseDate,
                        ExpirationDate = @expirationDate
                    WHERE BatchID = @id
                "

                Dim cmdUpdate As New MySqlCommand(sqlUpdateBatch, conn, transaction)
                cmdUpdate.Parameters.AddWithValue("@id", _batchID)
                cmdUpdate.Parameters.AddWithValue("@quantity", Convert.ToDecimal(Quantity.Text))
                cmdUpdate.Parameters.AddWithValue("@unit", Unit.Text)
                cmdUpdate.Parameters.AddWithValue("@cost", Convert.ToDecimal(RoundedTextBox1.Text))
                cmdUpdate.Parameters.AddWithValue("@purchaseDate", DateTimePicker1.Value.Date)
                cmdUpdate.Parameters.AddWithValue("@expirationDate", DateTimePicker2.Value.Date)
                cmdUpdate.ExecuteNonQuery()

                ' Update ingredient min/max levels
                Dim sqlUpdateIngredient As String = "
                    UPDATE ingredients
                    SET MinStockLevel = @minStock,
                        MaxStockLevel = @maxStock,
                        UnitType = @unit
                    WHERE IngredientID = @id
                "

                Dim cmdUpdateIng As New MySqlCommand(sqlUpdateIngredient, conn, transaction)
                cmdUpdateIng.Parameters.AddWithValue("@id", _ingredientID)
                cmdUpdateIng.Parameters.AddWithValue("@minStock", NumericUpDown1.Value)
                cmdUpdateIng.Parameters.AddWithValue("@maxStock", NumericUpDown2.Value)
                cmdUpdateIng.Parameters.AddWithValue("@unit", Unit.Text)
                cmdUpdateIng.ExecuteNonQuery()

                ' Log the update if quantity changed
                Dim newQuantity As Decimal = Convert.ToDecimal(Quantity.Text)
                If oldQuantity <> newQuantity Then
                    Dim sqlLog As String = "
                        INSERT INTO batch_transactions (
                            BatchID, TransactionType, QuantityChanged,
                            StockBefore, StockAfter, Reason, Notes
                        ) VALUES (
                            @batch, 'Adjustment', @qtyChange,
                            @before, @after, 'Manual Edit', @notes
                        )
                    "
                    Dim cmdLog As New MySqlCommand(sqlLog, conn, transaction)
                    cmdLog.Parameters.AddWithValue("@batch", _batchID)
                    cmdLog.Parameters.AddWithValue("@qtyChange", newQuantity - oldQuantity)
                    cmdLog.Parameters.AddWithValue("@before", oldQuantity)
                    cmdLog.Parameters.AddWithValue("@after", newQuantity)
                    cmdLog.Parameters.AddWithValue("@notes", "Batch edited by user")
                    cmdLog.ExecuteNonQuery()
                End If

                transaction.Commit()

                MessageBox.Show(
                    "Batch updated successfully!" & vbCrLf & vbCrLf &
                    "Batch #: " & txtBatchNumber.Text & vbCrLf &
                    "New Quantity: " & Quantity.Text & " " & Unit.Text,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                Me.DialogResult = DialogResult.OK
                Me.Close()

            Catch ex As Exception
                transaction.Rollback()
                Throw
            End Try

        Catch ex As Exception
            MessageBox.Show("Error updating batch: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConn()
        End Try
    End Sub

    ' Cancel Button
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    ' Auto-calculate total cost when quantity or cost per unit changes
    Private Sub Quantity_TextChanged(sender As Object, e As EventArgs) Handles Quantity.TextChanged
        UpdateTotalCost()
    End Sub

    Private Sub RoundedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RoundedTextBox1.TextChanged
        UpdateTotalCost()
    End Sub

    Private Sub UpdateTotalCost()
        Try
            If IsNumeric(Quantity.Text) AndAlso IsNumeric(RoundedTextBox1.Text) Then
                Dim qty As Decimal = Convert.ToDecimal(Quantity.Text)
                Dim cost As Decimal = Convert.ToDecimal(RoundedTextBox1.Text)
                Dim total As Decimal = qty * cost
                ' Display in form title or add a label if needed
                Me.Text = "Edit Batch - Total: ₱" & total.ToString("#,##0.00")
            End If
        Catch ex As Exception
            ' Ignore calculation errors during typing
        End Try
    End Sub

End Class