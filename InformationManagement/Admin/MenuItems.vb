Imports MySqlConnector
Imports System.IO

Public Class MenuItems

    ' Track if buttons already added
    Dim ButtonsAdded As Boolean = False

    Private Sub MenuItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMenuItems()
    End Sub

    ' =======================================================
    ' LOAD DATA
    ' =======================================================
    Private Sub LoadMenuItems()

        Dim query As String = "
            SELECT 
                Image,
                ProductID, ProductName, Category, Description, Price,
                Availability, ServingSize, DateAdded, LastUpdated,
                ProductCode, OrderCount, PrepTime
            FROM products;
        "

        Try
            openConn()

            Dim cmd As New MySqlCommand(query, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            ' ---------------------------------------------------
            ' FIX IMAGE COLUMN
            ' ---------------------------------------------------
            If dt.Columns.Contains("Image") Then

                dt.Columns("Image").ColumnName = "ImageBlob"
                dt.Columns.Add("Image", GetType(Image))

                For Each row As DataRow In dt.Rows
                    If IsDBNull(row("ImageBlob")) OrElse Not TypeOf row("ImageBlob") Is Byte() Then
                        row("Image") = Nothing
                        Continue For
                    End If

                    Try
                        Dim imgBytes As Byte() = CType(row("ImageBlob"), Byte())
                        Using ms As New MemoryStream(imgBytes)
                            row("Image") = Image.FromStream(ms)
                        End Using
                    Catch
                        row("Image") = Nothing
                    End Try
                Next

            End If

            ' =======================================================
            ' CUSTOM CATEGORY SORTING (OPTION 2)
            ' =======================================================
            Dim categoryOrder As New Dictionary(Of String, Integer) From {
                {"Bilao", 1},
                {"Platter", 2},
                {"Rice Meal", 3},
                {"Rice", 4},
                {"Spaghetti", 5},
                {"Sandwiches", 6},
                {"Snacks", 7},
                {"Desserts", 8}
            }

            dt.Columns.Add("SortOrder", GetType(Integer))

            For Each row As DataRow In dt.Rows
                Dim cat As String = row("Category").ToString()
                If categoryOrder.ContainsKey(cat) Then
                    row("SortOrder") = categoryOrder(cat)
                Else
                    row("SortOrder") = 999 ' unknown categories go last
                End If
            Next

            dt.DefaultView.Sort = "SortOrder ASC"
            Dim sortedTable As DataTable = dt.DefaultView.ToTable()

            DataGridMenu.AutoGenerateColumns = True
            DataGridMenu.DataSource = sortedTable

            ' ---------------------------------------------------
            ' BUTTONS ADDED ONLY ONCE
            ' ---------------------------------------------------
            If Not ButtonsAdded Then
                AddActionButtons()
                ButtonsAdded = True
            End If

            ' ---------------------------------------------------
            ' FORMAT IMAGE COLUMN
            ' ---------------------------------------------------
            If DataGridMenu.Columns.Contains("Image") Then
                Dim imgCol As DataGridViewImageColumn =
                    CType(DataGridMenu.Columns("Image"), DataGridViewImageColumn)
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
                imgCol.Width = 120
            End If

            DataGridMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)

        Finally
            conn.Close()
        End Try

    End Sub

    ' =======================================================
    ' ADD UPDATE + DELETE BUTTONS
    ' =======================================================
    Private Sub AddActionButtons()

        ' DELETE BUTTON
        Dim deleteBtn As New DataGridViewButtonColumn()
        deleteBtn.HeaderText = "Delete"
        deleteBtn.Text = "Delete"
        deleteBtn.Name = "DeleteButton"
        deleteBtn.UseColumnTextForButtonValue = True
        DataGridMenu.Columns.Add(deleteBtn)

        ' EDIT BUTTON
        Dim updateBtn As New DataGridViewButtonColumn()
        updateBtn.HeaderText = "Update"
        updateBtn.Text = "Edit"
        updateBtn.Name = "UpdateButton"
        updateBtn.UseColumnTextForButtonValue = True
        DataGridMenu.Columns.Add(updateBtn)

    End Sub

    ' =======================================================
    ' BUTTON HANDLERS
    ' =======================================================
    Private Sub DataGridMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMenu.CellContentClick

        If e.RowIndex < 0 Then Exit Sub

        ' DELETE
        If DataGridMenu.Columns(e.ColumnIndex).Name = "DeleteButton" Then
            Dim id As Integer = DataGridMenu.Rows(e.RowIndex).Cells("ProductID").Value
            DeleteProduct(id)
            LoadMenuItems()
            Exit Sub
        End If

        ' EDIT
        If DataGridMenu.Columns(e.ColumnIndex).Name = "UpdateButton" Then
            Dim id As Integer = DataGridMenu.Rows(e.RowIndex).Cells("ProductID").Value
            Dim form As New FormEditMenu()
            form.LoadProduct(id)
            form.ShowDialog()
            LoadMenuItems()
            Exit Sub
        End If

    End Sub

    ' =======================================================
    ' DELETE FUNCTION
    ' =======================================================
    Private Sub DeleteProduct(productId As Integer)

        Dim query As String = "DELETE FROM products WHERE ProductID = @id"

        Try
            openConn()

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", productId)

            If MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) = DialogResult.Yes Then

                cmd.ExecuteNonQuery()
                MessageBox.Show("Product deleted successfully!")
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting: " & ex.Message)

        Finally
            conn.Close()
        End Try

    End Sub

    ' =======================================================
    ' ADD NEW MENU ITEM BUTTON
    ' =======================================================
    Private Sub AddMenuItemsbtn_Click(sender As Object, e As EventArgs) Handles AddMenuItemsbtn.Click

        With FormAddNewmenuItem
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With

        LoadMenuItems()

    End Sub

End Class