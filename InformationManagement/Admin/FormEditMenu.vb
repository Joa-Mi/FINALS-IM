Imports MySqlConnector
Imports System.IO
Imports System.Drawing.Imaging

Public Class FormEditMenu

    Public SelectedProductID As Integer
    Private SelectedImageBytes As Byte() = Nothing
    Private OriginalImagePath As String = "" ' Store original image path

    Private Sub FormEditMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeForm()
    End Sub

    ' =======================================================
    ' INITIALIZE FORM
    ' =======================================================
    Private Sub InitializeForm()
        Availability.Items.Clear()
        Availability.Items.Add("Available")
        Availability.Items.Add("Not Available")
        Availability.SelectedIndex = 0

        cmbCategory.Items.Clear()
        cmbCategory.Items.Add("SPAGHETTI MEAL")
        cmbCategory.Items.Add("DESSERT")
        cmbCategory.Items.Add("DRINKS & BEVERAGES")
        cmbCategory.Items.Add("PLATTER")
        cmbCategory.Items.Add("RICE MEAL")
        cmbCategory.Items.Add("RICE")
        cmbCategory.Items.Add("NOODLES & PASTA") ' Database value for "Bilao"
        cmbCategory.Items.Add("Snacks")
        cmbCategory.SelectedIndex = -1

        cmbMealTime.Items.Clear()
        cmbMealTime.Items.Add("All Day")
        cmbMealTime.Items.Add("Breakfast")
        cmbMealTime.Items.Add("Lunch")
        cmbMealTime.Items.Add("Dinner")
        cmbMealTime.SelectedIndex = 0

        numericPrice.Value = 0
        numericPrice.DecimalPlaces = 2
        numericPrice.Minimum = 0
        numericPrice.Maximum = 999999

        ProductID.ReadOnly = True
        OrderCount.ReadOnly = True

        PictureBox1.Image = Nothing
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        SelectedImageBytes = Nothing
        OriginalImagePath = ""
    End Sub

    ' =======================================================
    ' LOAD PRODUCT DATA - RENAMED TO MATCH MenuItems.vb CALL
    ' =======================================================
    Public Sub LoadProductData(id As Integer)
        SelectedProductID = id
        Try
            openConn()
            Dim sql As String = "SELECT * FROM products WHERE ProductID = @id"
            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", id)
            Dim rd = cmd.ExecuteReader()

            If rd.Read() Then
                ' Load basic product info
                ProductID.Text = rd("ProductID").ToString()
                txtProductName.Text = rd("ProductName").ToString()
                Description.Text = rd("Description").ToString()
                numericPrice.Value = Convert.ToDecimal(rd("Price"))
                ServingSize.Text = rd("ServingSize").ToString()
                ProductCode.Text = rd("ProductCode").ToString()
                PrepTime.Text = If(IsDBNull(rd("PrepTime")), "", rd("PrepTime").ToString())
                OrderCount.Text = rd("OrderCount").ToString()

                ' Handle Availability
                Dim availStatus As String = rd("Availability").ToString()
                Availability.Text = availStatus

                ' Handle Category
                cmbCategory.Text = rd("Category").ToString()

                ' Handle MealTime
                Dim mealTime As String = If(IsDBNull(rd("MealTime")), "All Day", rd("MealTime").ToString())
                cmbMealTime.Text = mealTime

                ' ========== LOAD IMAGE FROM URL PATH ==========
                If Not IsDBNull(rd("Image")) Then
                    Dim imageData = rd("Image").ToString()
                    OriginalImagePath = imageData ' Store for saving later

                    Try
                        ' Load image from URL
                        Dim imageUrl As String = ConvertToWebUrl(imageData)
                        Dim webClient As New System.Net.WebClient()
                        Dim imageBytes() As Byte = webClient.DownloadData(imageUrl)

                        Using ms As New MemoryStream(imageBytes)
                            PictureBox1.Image = Image.FromStream(ms)
                        End Using

                        ' Store the bytes in case user doesn't change image
                        SelectedImageBytes = imageBytes
                    Catch ex As Exception
                        ' If image fails to load, show placeholder
                        PictureBox1.Image = Nothing
                        SelectedImageBytes = Nothing
                        Console.WriteLine($"Failed to load image: {ex.Message}")
                    End Try
                Else
                    PictureBox1.Image = Nothing
                    SelectedImageBytes = Nothing
                    OriginalImagePath = ""
                End If

                ' Update form title with product name
                Me.Text = $"✏️ Edit Product - {txtProductName.Text}"
            End If
            rd.Close()

        Catch ex As Exception
            MessageBox.Show("❌ Error loading product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' =======================================================
    ' LEGACY METHOD - KEEP FOR BACKWARD COMPATIBILITY
    ' =======================================================
    Public Sub LoadProduct(id As Integer)
        ' Call the new method name
        LoadProductData(id)
    End Sub

    ' =======================================================
    ' CONVERT FILE PATH TO WEB URL (SAME AS MenuItems.vb)
    ' =======================================================
    Private Function ConvertToWebUrl(imagePath As String) As String
        Const WEB_BASE_URL As String = "http://localhost/TrialWeb/TrialWorkIM/Tabeya/"

        ' If already a URL, return as-is
        If imagePath.StartsWith("http://") OrElse imagePath.StartsWith("https://") Then
            Return imagePath
        End If

        ' If path contains full system path with htdocs
        If imagePath.Contains(":\") AndAlso imagePath.ToLower().Contains("htdocs") Then
            Dim htdocsIndex As Integer = imagePath.ToLower().IndexOf("htdocs")
            If htdocsIndex > 0 Then
                Dim webPath As String = imagePath.Substring(htdocsIndex + 7) ' Skip "htdocs\"
                webPath = webPath.Replace("\", "/")
                Return "http://localhost/" & webPath
            End If
        End If

        ' If relative path
        Dim cleanPath As String = imagePath.Replace("\", "/")
        If cleanPath.StartsWith("/") Then
            cleanPath = cleanPath.Substring(1)
        End If

        Return WEB_BASE_URL & cleanPath
    End Function

    ' =======================================================
    ' BROWSE NEW IMAGE
    ' =======================================================
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        ofd.Title = "Select Product Image"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox1.Image = Image.FromFile(ofd.FileName)
                SelectedImageBytes = File.ReadAllBytes(ofd.FileName)

                ' Clear original path since user selected new image
                OriginalImagePath = ""

                MessageBox.Show("✓ New image selected. Click 'Update Item' to save changes.",
                              "Image Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("❌ Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' =======================================================
    ' UPDATE PRODUCT + SAVE TO DATABASE
    ' =======================================================
    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click

        ' Validation
        If String.IsNullOrWhiteSpace(txtProductName.Text) Then
            MessageBox.Show("⚠️ Product Name is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProductName.Focus()
            Return
        End If

        If cmbCategory.SelectedIndex = -1 Then
            MessageBox.Show("⚠️ Please select a Category!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCategory.Focus()
            Return
        End If

        If numericPrice.Value <= 0 Then
            MessageBox.Show("⚠️ Price must be greater than 0!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            numericPrice.Focus()
            Return
        End If

        Try
            openConn()

            ' ========== SAVE IMAGE TO htdocs FOLDER ==========
            Dim imagePath As String = OriginalImagePath ' Keep existing path by default

            If SelectedImageBytes IsNot Nothing AndAlso String.IsNullOrEmpty(OriginalImagePath) Then
                ' User selected a new image - save it to htdocs
                Dim uploadsFolder As String = "D:\XAMPP\htdocs\TrialWeb\TrialWorkIM\Tabeya\uploads\products\"

                ' Create folder if it doesn't exist
                If Not Directory.Exists(uploadsFolder) Then
                    Directory.CreateDirectory(uploadsFolder)
                End If

                ' Generate unique filename
                Dim fileName As String = $"{ProductCode.Text}_{DateTime.Now:yyyyMMddHHmmss}.jpg"
                Dim fullPath As String = Path.Combine(uploadsFolder, fileName)

                ' Save image to htdocs
                File.WriteAllBytes(fullPath, SelectedImageBytes)

                ' Store relative path for database
                imagePath = $"uploads/products/{fileName}"
            End If

            ' ========== UPDATE DATABASE ==========
            Dim sql As String =
            "UPDATE products SET 
                ProductName=@ProductName,
                Category=@Category,
                Description=@Description,
                Price=@Price,
                Availability=@Availability,
                ServingSize=@ServingSize,
                ProductCode=@ProductCode,
                PrepTime=@PrepTime,
                MealTime=@MealTime,
                LastUpdated=NOW(),
                Image=@Image
             WHERE ProductID=@id"

            Dim cmd As New MySqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim())
            cmd.Parameters.AddWithValue("@Category", cmbCategory.Text.Trim())
            cmd.Parameters.AddWithValue("@Description", Description.Text.Trim())
            cmd.Parameters.AddWithValue("@Price", numericPrice.Value)
            cmd.Parameters.AddWithValue("@Availability", Availability.Text)
            cmd.Parameters.AddWithValue("@ServingSize", ServingSize.Text.Trim())
            cmd.Parameters.AddWithValue("@ProductCode", ProductCode.Text.Trim())
            cmd.Parameters.AddWithValue("@PrepTime", PrepTime.Text.Trim())
            cmd.Parameters.AddWithValue("@MealTime", cmbMealTime.Text)
            cmd.Parameters.AddWithValue("@id", SelectedProductID)

            ' Save image path (not BLOB)
            cmd.Parameters.AddWithValue("@Image", If(String.IsNullOrEmpty(imagePath), DBNull.Value, imagePath))

            cmd.ExecuteNonQuery()

            MessageBox.Show("✓ Menu item updated successfully!" & vbCrLf & vbCrLf &
                          "Product: " & txtProductName.Text,
                          "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Set DialogResult to OK so MenuItems.vb knows to refresh
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("❌ Error updating item: " & ex.Message & vbCrLf & vbCrLf &
                          "Stack Trace: " & ex.StackTrace,
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ' =======================================================
    ' CLOSE BUTTON
    ' =======================================================
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to close without saving changes?",
            "Confirm Close",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    ' =======================================================
    ' FORM CLOSING EVENT - CLEANUP
    ' =======================================================
    Private Sub FormEditMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Dispose of image to free memory
        If PictureBox1.Image IsNot Nothing Then
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Nothing
        End If
    End Sub

    ' =======================================================
    ' OPTIONAL: ADD BUTTON TO REMOVE IMAGE
    ' =======================================================


End Class