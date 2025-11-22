<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditMenu))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PrepTime = New InformationManagement.RoundedTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.OrderCount = New InformationManagement.RoundedTextBox()
        Me.ServingSize = New InformationManagement.RoundedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ProductCode = New InformationManagement.RoundedTextBox()
        Me.Description = New InformationManagement.RoundedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Product = New System.Windows.Forms.Label()
        Me.txtProductName = New InformationManagement.RoundedTextBox()
        Me.ProductID = New InformationManagement.RoundedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtImageUrl = New InformationManagement.RoundedTextBox()
        Me.numericPrice = New System.Windows.Forms.NumericUpDown()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Availability = New System.Windows.Forms.ComboBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.numericPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(994, 27)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(39, 33)
        Me.btnClose.TabIndex = 26
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 32)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Edit Menu Item"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 475)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 23)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Date Added"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(41, 501)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(270, 22)
        Me.DateTimePicker1.TabIndex = 83
        '
        'PrepTime
        '
        Me.PrepTime.BackColor = System.Drawing.Color.Transparent
        Me.PrepTime.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.PrepTime.Location = New System.Drawing.Point(533, 434)
        Me.PrepTime.MaxLength = 32767
        Me.PrepTime.MinimumSize = New System.Drawing.Size(50, 20)
        Me.PrepTime.Multiline = False
        Me.PrepTime.Name = "PrepTime"
        Me.PrepTime.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PrepTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PrepTime.Size = New System.Drawing.Size(432, 40)
        Me.PrepTime.TabIndex = 82
        Me.PrepTime.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.PrepTime.TextColor = System.Drawing.Color.Black
        Me.PrepTime.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(527, 406)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 23)
        Me.Label20.TabIndex = 81
        Me.Label20.Text = "Prep Time"
        '
        'OrderCount
        '
        Me.OrderCount.BackColor = System.Drawing.Color.Transparent
        Me.OrderCount.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.OrderCount.Location = New System.Drawing.Point(523, 102)
        Me.OrderCount.MaxLength = 32767
        Me.OrderCount.MinimumSize = New System.Drawing.Size(50, 20)
        Me.OrderCount.Multiline = True
        Me.OrderCount.Name = "OrderCount"
        Me.OrderCount.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.OrderCount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.OrderCount.Size = New System.Drawing.Size(432, 40)
        Me.OrderCount.TabIndex = 80
        Me.OrderCount.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.OrderCount.TextColor = System.Drawing.Color.Black
        Me.OrderCount.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ServingSize
        '
        Me.ServingSize.BackColor = System.Drawing.Color.Transparent
        Me.ServingSize.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.ServingSize.Location = New System.Drawing.Point(39, 408)
        Me.ServingSize.MaxLength = 32767
        Me.ServingSize.MinimumSize = New System.Drawing.Size(50, 20)
        Me.ServingSize.Multiline = False
        Me.ServingSize.Name = "ServingSize"
        Me.ServingSize.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ServingSize.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ServingSize.Size = New System.Drawing.Size(432, 40)
        Me.ServingSize.TabIndex = 76
        Me.ServingSize.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.ServingSize.TextColor = System.Drawing.Color.Black
        Me.ServingSize.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(523, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 23)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Order Count"
        '
        'ProductCode
        '
        Me.ProductCode.BackColor = System.Drawing.Color.Transparent
        Me.ProductCode.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.ProductCode.Location = New System.Drawing.Point(42, 570)
        Me.ProductCode.MaxLength = 32767
        Me.ProductCode.MinimumSize = New System.Drawing.Size(50, 20)
        Me.ProductCode.Multiline = False
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ProductCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProductCode.Size = New System.Drawing.Size(432, 40)
        Me.ProductCode.TabIndex = 78
        Me.ProductCode.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.ProductCode.TextColor = System.Drawing.Color.Black
        Me.ProductCode.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Description
        '
        Me.Description.BackColor = System.Drawing.Color.Transparent
        Me.Description.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.Description.Location = New System.Drawing.Point(43, 261)
        Me.Description.MaxLength = 32767
        Me.Description.MinimumSize = New System.Drawing.Size(50, 20)
        Me.Description.Multiline = False
        Me.Description.Name = "Description"
        Me.Description.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Description.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Description.Size = New System.Drawing.Size(432, 40)
        Me.Description.TabIndex = 74
        Me.Description.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.Description.TextColor = System.Drawing.Color.Black
        Me.Description.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(35, 382)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 23)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Serving Size"
        '
        'Product
        '
        Me.Product.AutoSize = True
        Me.Product.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product.Location = New System.Drawing.Point(36, 542)
        Me.Product.Name = "Product"
        Me.Product.Size = New System.Drawing.Size(120, 23)
        Me.Product.TabIndex = 77
        Me.Product.Text = "Product Code "
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.Color.Transparent
        Me.txtProductName.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtProductName.Location = New System.Drawing.Point(40, 173)
        Me.txtProductName.MaxLength = 32767
        Me.txtProductName.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtProductName.Multiline = True
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtProductName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductName.Size = New System.Drawing.Size(432, 40)
        Me.txtProductName.TabIndex = 72
        Me.txtProductName.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProductName.TextColor = System.Drawing.Color.Black
        Me.txtProductName.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ProductID
        '
        Me.ProductID.BackColor = System.Drawing.Color.Transparent
        Me.ProductID.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.ProductID.Location = New System.Drawing.Point(43, 102)
        Me.ProductID.MaxLength = 32767
        Me.ProductID.MinimumSize = New System.Drawing.Size(50, 20)
        Me.ProductID.Multiline = False
        Me.ProductID.Name = "ProductID"
        Me.ProductID.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ProductID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProductID.Size = New System.Drawing.Size(432, 40)
        Me.ProductID.TabIndex = 71
        Me.ProductID.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.ProductID.TextColor = System.Drawing.Color.Black
        Me.ProductID.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 23)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Description"
        '
        'txtImageUrl
        '
        Me.txtImageUrl.BackColor = System.Drawing.Color.Transparent
        Me.txtImageUrl.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtImageUrl.Location = New System.Drawing.Point(528, 356)
        Me.txtImageUrl.MaxLength = 32767
        Me.txtImageUrl.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtImageUrl.Multiline = False
        Me.txtImageUrl.Name = "txtImageUrl"
        Me.txtImageUrl.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtImageUrl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtImageUrl.Size = New System.Drawing.Size(432, 40)
        Me.txtImageUrl.TabIndex = 70
        Me.txtImageUrl.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtImageUrl.TextColor = System.Drawing.Color.Black
        Me.txtImageUrl.TextFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'numericPrice
        '
        Me.numericPrice.AutoSize = True
        Me.numericPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numericPrice.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericPrice.Location = New System.Drawing.Point(525, 212)
        Me.numericPrice.Name = "numericPrice"
        Me.numericPrice.Size = New System.Drawing.Size(435, 28)
        Me.numericPrice.TabIndex = 69
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.White
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.ItemHeight = 30
        Me.cmbCategory.Items.AddRange(New Object() {"Bilao", "Platter", "Rice Meal", "Rice", "Spaghetti", "Sandwiches", "Snacks ", "Desserts"})
        Me.cmbCategory.Location = New System.Drawing.Point(528, 291)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(432, 36)
        Me.cmbCategory.TabIndex = 68
        '
        'Availability
        '
        Me.Availability.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Availability.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Availability.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Availability.FormattingEnabled = True
        Me.Availability.ItemHeight = 30
        Me.Availability.Items.AddRange(New Object() {"Available", "Unvailable"})
        Me.Availability.Location = New System.Drawing.Point(39, 343)
        Me.Availability.Name = "Availability"
        Me.Availability.Size = New System.Drawing.Size(432, 36)
        Me.Availability.TabIndex = 67
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(535, 644)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(432, 42)
        Me.btnAddItem.TabIndex = 65
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 23)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Availability"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(525, 327)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 23)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Image"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(522, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 23)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(525, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 23)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 23)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(715, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 23)
        Me.Label3.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 23)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Product ID"
        '
        'FormEditMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1068, 807)
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
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormEditMenu"
        Me.Text = "FormEditMenu"
        CType(Me.numericPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PrepTime As RoundedTextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents OrderCount As RoundedTextBox
    Friend WithEvents ServingSize As RoundedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ProductCode As RoundedTextBox
    Friend WithEvents Description As RoundedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Product As Label
    Friend WithEvents txtProductName As RoundedTextBox
    Friend WithEvents ProductID As RoundedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtImageUrl As RoundedTextBox
    Friend WithEvents numericPrice As NumericUpDown
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Availability As ComboBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
