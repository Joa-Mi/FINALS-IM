Imports MySqlConnector
Imports System.IO

Public Class FormEditMenu

    Public SelectedProductID As Integer   ' The ID you are editing

    '===========================================================
    ' LOAD PRODUCT
    '===========================================================
    Public Sub LoadProduct(id As Integer)
        SelectedProductID = id

        Try
            openConn()

            Dim sql As String = "SELECT * FROM products WHERE ProductID=@id"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", id)

            Dim rd = cmd.ExecuteReader()

            If rd.Read() Then
                txtProductName.Text = rd("ProductName").ToString()
                cmbCategory.Text = rd("Category").ToString()
                Description.Text = rd("Description").ToString()
                numericPrice.Value = Convert.ToDecimal(rd("Price"))
                Availability.Text = rd("Availability").ToString()
                ServingSize.Text = rd("ServingSize").ToString()
                ProductCode.Text = rd("ProductCode").ToString()
                PrepTime.Text = rd("PrepTime").ToString()

                ' image load
                If Not IsDBNull(rd("Image")) Then
                    Dim imgBytes As Byte() = CType(rd("Image"), Byte())
                    Using ms As New MemoryStream(imgBytes)
                        Product.Image = Image.FromStream(ms)
                    End Using
                Else
                    Product.Image = Nothing
                End If

            End If

            rd.Close()

        Catch ex As Exception
            MsgBox("Error loading product: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    '===========================================================
    ' UPDATE PRODUCT
    '===========================================================
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Try
            openConn()

            Dim sql As String =
                "UPDATE products SET 
                    ProductName=@name,
                    Category=@category,
                    Description=@desc,
                    Price=@price,
                    Availability=@availability,
                    ServingSize=@serve,
                    ProductCode=@pcode,
                    PrepTime=@prep,
                    LastUpdated=NOW(),
                    Image=@img
                 WHERE ProductID=@id"

            Dim cmd As New MySqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@name", txtProductName.Text)
            cmd.Parameters.AddWithValue("@category", cmbCategory.Text)
            cmd.Parameters.AddWithValue("@desc", Description.Text)
            cmd.Parameters.AddWithValue("@price", numericPrice.Value)
            cmd.Parameters.AddWithValue("@availability", Availability.Text)
            cmd.Parameters.AddWithValue("@serve", ServingSize.Text)
            cmd.Parameters.AddWithValue("@pcode", ProductCode.Text)
            cmd.Parameters.AddWithValue("@prep", PrepTime.Text)

            ' Handle image
            If Product.Image IsNot Nothing Then
                Using ms As New MemoryStream()
                    Product.Image.Save(ms, Product.Image.RawFormat)
                    cmd.Parameters.AddWithValue("@img", ms.ToArray())
                End Using
            Else
                cmd.Parameters.AddWithValue("@img", DBNull.Value)
            End If

            ' USE THE SELECTED ID — NOT THE TEXTBOX
            cmd.Parameters.AddWithValue("@id", SelectedProductID)

            cmd.ExecuteNonQuery()

            MsgBox("Product updated successfully!")

            Me.Close()

        Catch ex As Exception
            MsgBox("Update error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class