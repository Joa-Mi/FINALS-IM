Imports MySqlConnector

Public Class Inventory

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventoryData()
    End Sub

    Private Sub LoadInventoryData()
        Try
            openConn()

            Dim sql As String = "
                SELECT 
                    item_name AS 'Item Name',
                    inventory_id AS 'Inventory ID',
                    product_id AS 'Product ID',
                    quantity AS 'Quantity',
                    status AS 'Status',
                    cost_per_unit AS 'Cost/Unit',
                    total_value AS 'Total Value',
                    last_stock AS 'Last Stock',
                    unit_type AS 'Unit Type',
                    expiration_date AS 'Expiration Date'
                FROM inventory
            "

            Dim cmd As New MySqlCommand(sql, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            InventoryGrid.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error loading inventory: " & ex.Message)
        End Try
    End Sub

    ' Opens the Add New Items Form
    Private Sub AddItem_Click(sender As Object, e As EventArgs) Handles AddItem.Click
        With AddNewItems
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
            .BringToFront()
        End With
    End Sub

End Class