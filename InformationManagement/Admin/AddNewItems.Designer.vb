<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AddItem = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RoundedTextBox1 = New InformationManagement.RoundedTextBox()
        Me.Unit = New System.Windows.Forms.ComboBox()
        Me.Quantity = New InformationManagement.RoundedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Category = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFullName = New InformationManagement.RoundedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Restockby = New InformationManagement.RoundedTextBox()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddItem
        '
        Me.AddItem.BackColor = System.Drawing.Color.DarkRed
        Me.AddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddItem.Location = New System.Drawing.Point(594, 614)
        Me.AddItem.Name = "AddItem"
        Me.AddItem.Size = New System.Drawing.Size(121, 47)
        Me.AddItem.TabIndex = 61
        Me.AddItem.Text = "Add Item"
        Me.AddItem.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.SystemColors.Highlight
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cancel.Location = New System.Drawing.Point(470, 614)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(118, 47)
        Me.Cancel.TabIndex = 60
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(394, 360)
        Me.NumericUpDown2.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(240, 26)
        Me.NumericUpDown2.TabIndex = 58
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(18, 360)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(240, 26)
        Me.NumericUpDown1.TabIndex = 57
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(389, 331)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 25)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Max Stock Level :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(13, 331)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(179, 25)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Min Stock Level :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(394, 448)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(270, 22)
        Me.DateTimePicker1.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(389, 419)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 25)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Last Restocked :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(13, 419)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 25)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Cost per Unit :"
        '
        'RoundedTextBox1
        '
        Me.RoundedTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedTextBox1.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.RoundedTextBox1.Location = New System.Drawing.Point(18, 448)
        Me.RoundedTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RoundedTextBox1.MaxLength = 32767
        Me.RoundedTextBox1.MinimumSize = New System.Drawing.Size(67, 25)
        Me.RoundedTextBox1.Multiline = False
        Me.RoundedTextBox1.Name = "RoundedTextBox1"
        Me.RoundedTextBox1.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RoundedTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RoundedTextBox1.Size = New System.Drawing.Size(307, 44)
        Me.RoundedTextBox1.TabIndex = 48
        Me.RoundedTextBox1.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.RoundedTextBox1.TextColor = System.Drawing.Color.Black
        Me.RoundedTextBox1.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'Unit
        '
        Me.Unit.FormattingEnabled = True
        Me.Unit.Items.AddRange(New Object() {"kg", "liters", "pieces", "boxes", "grams", "bottles"})
        Me.Unit.Location = New System.Drawing.Point(394, 260)
        Me.Unit.Name = "Unit"
        Me.Unit.Size = New System.Drawing.Size(250, 24)
        Me.Unit.TabIndex = 51
        '
        'Quantity
        '
        Me.Quantity.BackColor = System.Drawing.Color.Transparent
        Me.Quantity.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.Quantity.Location = New System.Drawing.Point(18, 260)
        Me.Quantity.Margin = New System.Windows.Forms.Padding(4)
        Me.Quantity.MaxLength = 32767
        Me.Quantity.MinimumSize = New System.Drawing.Size(67, 25)
        Me.Quantity.Multiline = False
        Me.Quantity.Name = "Quantity"
        Me.Quantity.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Quantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Quantity.Size = New System.Drawing.Size(307, 44)
        Me.Quantity.TabIndex = 45
        Me.Quantity.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.Quantity.TextColor = System.Drawing.Color.Black
        Me.Quantity.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(13, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 25)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Stock Quantity :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(389, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 25)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Unit :"
        '
        'Category
        '
        Me.Category.FormattingEnabled = True
        Me.Category.Items.AddRange(New Object() {"Meat & Poultry", "Vegetables", "Dairy", "Dry Goods", "Oils & Condiments", "Herbs & Spices", "Beverages", "Seafood"})
        Me.Category.Location = New System.Drawing.Point(394, 162)
        Me.Category.Name = "Category"
        Me.Category.Size = New System.Drawing.Size(250, 24)
        Me.Category.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(389, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 25)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Catergory :"
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.Transparent
        Me.txtFullName.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtFullName.Location = New System.Drawing.Point(18, 162)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFullName.MaxLength = 32767
        Me.txtFullName.MinimumSize = New System.Drawing.Size(67, 25)
        Me.txtFullName.Multiline = False
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtFullName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFullName.Size = New System.Drawing.Size(307, 44)
        Me.txtFullName.TabIndex = 43
        Me.txtFullName.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFullName.TextColor = System.Drawing.Color.Black
        Me.txtFullName.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(13, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 25)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Item Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(15, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(377, 18)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Enter the details of the new inventory item below."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 32)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Add New Inventory Item"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(394, 547)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(270, 22)
        Me.DateTimePicker2.TabIndex = 63
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(389, 518)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(172, 25)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Expiration Date :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(13, 518)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 25)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Restock by :"
        '
        'Restockby
        '
        Me.Restockby.BackColor = System.Drawing.Color.Transparent
        Me.Restockby.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.Restockby.Location = New System.Drawing.Point(18, 547)
        Me.Restockby.Margin = New System.Windows.Forms.Padding(4)
        Me.Restockby.MaxLength = 32767
        Me.Restockby.MinimumSize = New System.Drawing.Size(67, 25)
        Me.Restockby.Multiline = False
        Me.Restockby.Name = "Restockby"
        Me.Restockby.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Restockby.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Restockby.Size = New System.Drawing.Size(307, 44)
        Me.Restockby.TabIndex = 64
        Me.Restockby.TextBoxBackColor = System.Drawing.Color.WhiteSmoke
        Me.Restockby.TextColor = System.Drawing.Color.Black
        Me.Restockby.TextFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'AddNewItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(731, 759)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Restockby)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.AddItem)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RoundedTextBox1)
        Me.Controls.Add(Me.Unit)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Category)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddNewItems"
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddItem As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RoundedTextBox1 As RoundedTextBox
    Friend WithEvents Unit As ComboBox
    Friend WithEvents Quantity As RoundedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Category As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFullName As RoundedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Restockby As RoundedTextBox
End Class
