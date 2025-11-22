<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddNewmenuItem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddNewmenuItem))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Availability = New System.Windows.Forms.ComboBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.numericPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Product = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PrepTime = New InformationManagement.RoundedTextBox()
        Me.OrderCount = New InformationManagement.RoundedTextBox()
        Me.ServingSize = New InformationManagement.RoundedTextBox()
        Me.ProductCode = New InformationManagement.RoundedTextBox()
        Me.Description = New InformationManagement.RoundedTextBox()
        Me.txtProductName = New InformationManagement.RoundedTextBox()
        Me.ProductID = New InformationManagement.RoundedTextBox()
        Me.txtImageUrl = New InformationManagement.RoundedTextBox()
        CType(Me.numericPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add New Menu Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Product ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(701, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 23)
        Me.Label3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Product Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(511, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(508, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Category"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(511, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Image"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 23)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Availability"
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(521, 627)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(432, 42)
        Me.btnAddItem.TabIndex = 17
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(1030, 21)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(29, 27)
        Me.btnClose.TabIndex = 25
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Availability
        '
        Me.Availability.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Availability.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Availability.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Availability.FormattingEnabled = True
        Me.Availability.ItemHeight = 30
        Me.Availability.Items.AddRange(New Object() {"Available", "Unvailable"})
        Me.Availability.Location = New System.Drawing.Point(25, 326)
        Me.Availability.Name = "Availability"
        Me.Availability.Size = New System.Drawing.Size(432, 36)
        Me.Availability.TabIndex = 26
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Silver
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.ForeColor = System.Drawing.Color.Black
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.ItemHeight = 30
        Me.cmbCategory.Items.AddRange(New Object() {"Bilao", "Platter", "Rice Meal", "Rice", "Spaghetti", "Sandwiches", "Snacks ", "Desserts"})
        Me.cmbCategory.Location = New System.Drawing.Point(514, 274)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(432, 36)
        Me.cmbCategory.TabIndex = 27
        '
        'numericPrice
        '
        Me.numericPrice.AutoSize = True
        Me.numericPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numericPrice.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericPrice.Location = New System.Drawing.Point(511, 195)
        Me.numericPrice.Name = "numericPrice"
        Me.numericPrice.Size = New System.Drawing.Size(435, 28)
        Me.numericPrice.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 23)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Description"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 365)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 23)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Serving Size"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(509, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 23)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Order Count"
        '
        'Product
        '
        Me.Product.AutoSize = True
        Me.Product.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product.Location = New System.Drawing.Point(22, 525)
        Me.Product.Name = "Product"
        Me.Product.Size = New System.Drawing.Size(120, 23)
        Me.Product.TabIndex = 40
        Me.Product.Text = "Product Code "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(513, 389)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 23)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Prep Time"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(27, 484)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(270, 26)
        Me.DateTimePicker1.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 458)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 23)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Date Added"
        '
        'PrepTime
        '
        Me.PrepTime.BackColor = System.Drawing.Color.Transparent
        Me.PrepTime.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.PrepTime.Location = New System.Drawing.Point(519, 417)
        Me.PrepTime.MaxLength = 32767
        Me.PrepTime.MinimumSize = New System.Drawing.Size(50, 20)
        Me.PrepTime.Multiline = False
        Me.PrepTime.Name = "PrepTime"
        Me.PrepTime.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PrepTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PrepTime.Size = New System.Drawing.Size(432, 40)
        Me.PrepTime.TabIndex = 50
        Me.PrepTime.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.PrepTime.TextColor = System.Drawing.Color.Black
        Me.PrepTime.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'OrderCount
        '
        Me.OrderCount.BackColor = System.Drawing.Color.Transparent
        Me.OrderCount.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.OrderCount.Location = New System.Drawing.Point(509, 85)
        Me.OrderCount.MaxLength = 32767
        Me.OrderCount.MinimumSize = New System.Drawing.Size(50, 20)
        Me.OrderCount.Multiline = True
        Me.OrderCount.Name = "OrderCount"
        Me.OrderCount.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.OrderCount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.OrderCount.Size = New System.Drawing.Size(432, 40)
        Me.OrderCount.TabIndex = 47
        Me.OrderCount.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.OrderCount.TextColor = System.Drawing.Color.Black
        Me.OrderCount.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ServingSize
        '
        Me.ServingSize.BackColor = System.Drawing.Color.Transparent
        Me.ServingSize.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.ServingSize.Location = New System.Drawing.Point(25, 391)
        Me.ServingSize.MaxLength = 32767
        Me.ServingSize.MinimumSize = New System.Drawing.Size(50, 20)
        Me.ServingSize.Multiline = False
        Me.ServingSize.Name = "ServingSize"
        Me.ServingSize.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ServingSize.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ServingSize.Size = New System.Drawing.Size(432, 40)
        Me.ServingSize.TabIndex = 38
        Me.ServingSize.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.ServingSize.TextColor = System.Drawing.Color.Black
        Me.ServingSize.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ProductCode
        '
        Me.ProductCode.BackColor = System.Drawing.Color.Transparent
        Me.ProductCode.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.ProductCode.Location = New System.Drawing.Point(28, 553)
        Me.ProductCode.MaxLength = 32767
        Me.ProductCode.MinimumSize = New System.Drawing.Size(50, 20)
        Me.ProductCode.Multiline = False
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ProductCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProductCode.Size = New System.Drawing.Size(432, 40)
        Me.ProductCode.TabIndex = 42
        Me.ProductCode.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.ProductCode.TextColor = System.Drawing.Color.Black
        Me.ProductCode.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Description
        '
        Me.Description.BackColor = System.Drawing.Color.Transparent
        Me.Description.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.Description.Location = New System.Drawing.Point(29, 244)
        Me.Description.MaxLength = 32767
        Me.Description.MinimumSize = New System.Drawing.Size(50, 20)
        Me.Description.Multiline = False
        Me.Description.Name = "Description"
        Me.Description.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Description.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Description.Size = New System.Drawing.Size(432, 40)
        Me.Description.TabIndex = 34
        Me.Description.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.Description.TextColor = System.Drawing.Color.Black
        Me.Description.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.Color.Transparent
        Me.txtProductName.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtProductName.Location = New System.Drawing.Point(26, 156)
        Me.txtProductName.MaxLength = 32767
        Me.txtProductName.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtProductName.Multiline = True
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtProductName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductName.Size = New System.Drawing.Size(432, 40)
        Me.txtProductName.TabIndex = 31
        Me.txtProductName.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProductName.TextColor = System.Drawing.Color.Black
        Me.txtProductName.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ProductID
        '
        Me.ProductID.BackColor = System.Drawing.Color.Transparent
        Me.ProductID.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.ProductID.Location = New System.Drawing.Point(29, 85)
        Me.ProductID.MaxLength = 32767
        Me.ProductID.MinimumSize = New System.Drawing.Size(50, 20)
        Me.ProductID.Multiline = False
        Me.ProductID.Name = "ProductID"
        Me.ProductID.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ProductID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProductID.Size = New System.Drawing.Size(432, 40)
        Me.ProductID.TabIndex = 30
        Me.ProductID.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.ProductID.TextColor = System.Drawing.Color.Black
        Me.ProductID.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtImageUrl
        '
        Me.txtImageUrl.BackColor = System.Drawing.Color.Transparent
        Me.txtImageUrl.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtImageUrl.Location = New System.Drawing.Point(514, 339)
        Me.txtImageUrl.MaxLength = 32767
        Me.txtImageUrl.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtImageUrl.Multiline = False
        Me.txtImageUrl.Name = "txtImageUrl"
        Me.txtImageUrl.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtImageUrl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtImageUrl.Size = New System.Drawing.Size(432, 40)
        Me.txtImageUrl.TabIndex = 29
        Me.txtImageUrl.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtImageUrl.TextColor = System.Drawing.Color.Black
        Me.txtImageUrl.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FormAddNewmenuItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1005, 572)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PrepTime)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.OrderCount)
        Me.Controls.Add(Me.ServingSize)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ProductCode)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Product)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.ProductID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtImageUrl)
        Me.Controls.Add(Me.numericPrice)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.Availability)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormAddNewmenuItem"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Silver
        CType(Me.numericPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Availability As ComboBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents numericPrice As NumericUpDown
    Friend WithEvents txtImageUrl As RoundedTextBox
    Friend WithEvents ProductID As RoundedTextBox
    Friend WithEvents txtProductName As RoundedTextBox
    Friend WithEvents Description As RoundedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ServingSize As RoundedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents OrderCount As RoundedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ProductCode As RoundedTextBox
    Friend WithEvents Product As Label
    Friend WithEvents PrepTime As RoundedTextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label9 As Label
End Class
