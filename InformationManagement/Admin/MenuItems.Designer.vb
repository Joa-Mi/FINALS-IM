<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuItems
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuItems))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Category = New System.Windows.Forms.ComboBox()
        Me.DataGridMenu = New System.Windows.Forms.DataGridView()
        Me.AddMenuItemsbtn = New InformationManagement.RoundedButton()
        CType(Me.DataGridMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Items"
        '
        'Category
        '
        Me.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Category.FormattingEnabled = True
        Me.Category.ItemHeight = 16
        Me.Category.Items.AddRange(New Object() {"Bilao", "Platter", "Rice Meal", "Rice", "Spaghetti", "Sandwiches", "Snacks ", "Desserts"})
        Me.Category.Location = New System.Drawing.Point(1222, 118)
        Me.Category.Name = "Category"
        Me.Category.Size = New System.Drawing.Size(213, 24)
        Me.Category.TabIndex = 5
        '
        'DataGridMenu
        '
        Me.DataGridMenu.AllowUserToAddRows = False
        Me.DataGridMenu.AllowUserToDeleteRows = False
        Me.DataGridMenu.AllowUserToResizeColumns = False
        Me.DataGridMenu.AllowUserToResizeRows = False
        Me.DataGridMenu.BackgroundColor = System.Drawing.Color.White
        Me.DataGridMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridMenu.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridMenu.ColumnHeadersHeight = 48
        Me.DataGridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridMenu.EnableHeadersVisualStyles = False
        Me.DataGridMenu.Location = New System.Drawing.Point(46, 177)
        Me.DataGridMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridMenu.Name = "DataGridMenu"
        Me.DataGridMenu.RowHeadersVisible = False
        Me.DataGridMenu.RowHeadersWidth = 51
        Me.DataGridMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridMenu.Size = New System.Drawing.Size(1522, 753)
        Me.DataGridMenu.TabIndex = 7
        '
        'AddMenuItemsbtn
        '
        Me.AddMenuItemsbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AddMenuItemsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddMenuItemsbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.AddMenuItemsbtn.ForeColor = System.Drawing.Color.White
        Me.AddMenuItemsbtn.Image = CType(resources.GetObject("AddMenuItemsbtn.Image"), System.Drawing.Image)
        Me.AddMenuItemsbtn.Location = New System.Drawing.Point(1184, 20)
        Me.AddMenuItemsbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.AddMenuItemsbtn.Name = "AddMenuItemsbtn"
        Me.AddMenuItemsbtn.Size = New System.Drawing.Size(251, 48)
        Me.AddMenuItemsbtn.TabIndex = 4
        Me.AddMenuItemsbtn.Text = "   Add Menu Items"
        Me.AddMenuItemsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddMenuItemsbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddMenuItemsbtn.UseVisualStyleBackColor = False
        '
        'MenuItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1572, 979)
        Me.Controls.Add(Me.DataGridMenu)
        Me.Controls.Add(Me.Category)
        Me.Controls.Add(Me.AddMenuItemsbtn)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuItems"
        Me.Text = "MenuItems"
        CType(Me.DataGridMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AddMenuItemsbtn As RoundedButton
    Friend WithEvents Category As ComboBox
    Friend WithEvents DataGridMenu As DataGridView
End Class
