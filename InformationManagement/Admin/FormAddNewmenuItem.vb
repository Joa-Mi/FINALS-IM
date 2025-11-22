Imports MySqlConnector

Public Class FormAddNewmenuItem

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Try
            openConn()

            Dim sql As String =
                "INSERT INTO products 
                (ProductID, ProductName, Category, Description, Price, Availability, ServingSize, 
                 DateAdded, LastUpdated, ProductCode, PopularityTag, MealTime, 
                 OrderCount, Image, PrepTime)
                 VALUES
                (@ProductID, @ProductName, @Category, @Description, @Price, @Availability, @ServingSize,
                 NOW(), NOW(), @ProductCode, @PopularityTag, @MealTime,
                 0, @Image, @PrepTime)"

            Dim cmd As New MySqlCommand(sql, conn)

            ' -------------------------
            '  BIND VALUES
            ' -------------------------
            ' -------------------------
            cmd.Parameters.AddWithValue("@ProductID", ProductID.Text)
            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
            cmd.Parameters.AddWithValue("@Category", cmbCategory.Text)
            cmd.Parameters.AddWithValue("@Description", Description.Text)
            cmd.Parameters.AddWithValue("@Price", numericPrice.Value)
            cmd.Parameters.AddWithValue("@Availability", Availability.Text)
            cmd.Parameters.AddWithValue("@ServingSize", ServingSize.Text)
            cmd.Parameters.AddWithValue("@ProductCode", ProductCode.Text)
            cmd.Parameters.AddWithValue("@Image", txtImageUrl.Text)
            cmd.Parameters.AddWithValue("@PrepTime", PrepTime.Text)

            ' -------------------------
            '  EXECUTE
            ' -------------------------
            cmd.ExecuteNonQuery()

            MsgBox("Item added successfully!", MsgBoxStyle.Information)

            conn.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub DateAdded_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub
End Class