<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orders))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Products = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderSource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfDiners = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderPriority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreparationTimeEstimate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialRequestFlag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsOrderedCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantities = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actions = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AddOrdersBtn = New InformationManagement.RoundedButton()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Orders"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeight = 40
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.OrderDate, Me.OrderTime, Me.Remarks, Me.OrderType, Me.Products, Me.OrderSource, Me.ReceiptNumber, Me.NumberOfDiners, Me.TotalAmount, Me.OrderPriority, Me.PreparationTimeEstimate, Me.SpecialRequestFlag, Me.ItemsOrderedCount, Me.Quantities, Me.UnitPrices, Me.TotalPrice, Me.Status, Me.Actions, Me.Delete})
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(13, 96)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1674, 241)
        Me.DataGridView2.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "colID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'OrderDate
        '
        Me.OrderDate.DataPropertyName = "colOrderDate"
        Me.OrderDate.HeaderText = "Order Date"
        Me.OrderDate.MinimumWidth = 6
        Me.OrderDate.Name = "OrderDate"
        Me.OrderDate.Width = 125
        '
        'OrderTime
        '
        Me.OrderTime.DataPropertyName = "colOrderTime"
        Me.OrderTime.HeaderText = "Order Time"
        Me.OrderTime.MinimumWidth = 6
        Me.OrderTime.Name = "OrderTime"
        Me.OrderTime.Width = 125
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "colRemarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.MinimumWidth = 6
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Width = 125
        '
        'OrderType
        '
        Me.OrderType.DataPropertyName = "colOrder_Type"
        Me.OrderType.HeaderText = "Order Type"
        Me.OrderType.MinimumWidth = 6
        Me.OrderType.Name = "OrderType"
        Me.OrderType.Width = 120
        '
        'Products
        '
        Me.Products.DataPropertyName = "colProducts"
        Me.Products.HeaderText = "Products"
        Me.Products.MinimumWidth = 6
        Me.Products.Name = "Products"
        Me.Products.Width = 150
        '
        'OrderSource
        '
        Me.OrderSource.DataPropertyName = "colOrderSource"
        Me.OrderSource.HeaderText = "OrderSource"
        Me.OrderSource.MinimumWidth = 6
        Me.OrderSource.Name = "OrderSource"
        Me.OrderSource.Width = 125
        '
        'ReceiptNumber
        '
        Me.ReceiptNumber.DataPropertyName = "colReceiptNumber"
        Me.ReceiptNumber.HeaderText = "Receipt Number"
        Me.ReceiptNumber.MinimumWidth = 6
        Me.ReceiptNumber.Name = "ReceiptNumber"
        Me.ReceiptNumber.Width = 130
        '
        'NumberOfDiners
        '
        Me.NumberOfDiners.DataPropertyName = "colNumberOfDiners"
        Me.NumberOfDiners.HeaderText = "Number Of Diners"
        Me.NumberOfDiners.MinimumWidth = 6
        Me.NumberOfDiners.Name = "NumberOfDiners"
        Me.NumberOfDiners.Width = 125
        '
        'TotalAmount
        '
        Me.TotalAmount.DataPropertyName = "colTotalAmount"
        Me.TotalAmount.HeaderText = "Total Amount"
        Me.TotalAmount.MinimumWidth = 6
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.Width = 125
        '
        'OrderPriority
        '
        Me.OrderPriority.DataPropertyName = "colOrderPriority"
        Me.OrderPriority.HeaderText = "Order Priority"
        Me.OrderPriority.MinimumWidth = 6
        Me.OrderPriority.Name = "OrderPriority"
        Me.OrderPriority.Width = 125
        '
        'PreparationTimeEstimate
        '
        Me.PreparationTimeEstimate.DataPropertyName = "colPreparationTimeEstimate"
        Me.PreparationTimeEstimate.HeaderText = "Preparation Time Estimate"
        Me.PreparationTimeEstimate.MinimumWidth = 6
        Me.PreparationTimeEstimate.Name = "PreparationTimeEstimate"
        Me.PreparationTimeEstimate.Width = 130
        '
        'SpecialRequestFlag
        '
        Me.SpecialRequestFlag.DataPropertyName = "colSpecialRequestFlag"
        Me.SpecialRequestFlag.HeaderText = "Special Request Flag"
        Me.SpecialRequestFlag.MinimumWidth = 6
        Me.SpecialRequestFlag.Name = "SpecialRequestFlag"
        Me.SpecialRequestFlag.Width = 125
        '
        'ItemsOrderedCount
        '
        Me.ItemsOrderedCount.DataPropertyName = "colItemsOrderedCount"
        Me.ItemsOrderedCount.HeaderText = "Items Ordered Count"
        Me.ItemsOrderedCount.MinimumWidth = 6
        Me.ItemsOrderedCount.Name = "ItemsOrderedCount"
        Me.ItemsOrderedCount.Width = 125
        '
        'Quantities
        '
        Me.Quantities.DataPropertyName = "colQuantities"
        Me.Quantities.HeaderText = "Quantities"
        Me.Quantities.MinimumWidth = 6
        Me.Quantities.Name = "Quantities"
        Me.Quantities.Width = 150
        '
        'UnitPrices
        '
        Me.UnitPrices.DataPropertyName = "colUnitPrices"
        Me.UnitPrices.HeaderText = "Unit Prices"
        Me.UnitPrices.MinimumWidth = 6
        Me.UnitPrices.Name = "UnitPrices"
        Me.UnitPrices.Width = 150
        '
        'TotalPrice
        '
        Me.TotalPrice.DataPropertyName = "colTotalPrice"
        Me.TotalPrice.HeaderText = "Total Price"
        Me.TotalPrice.MinimumWidth = 6
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Width = 120
        '
        'Status
        '
        Me.Status.DataPropertyName = "colStatus"
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 6
        Me.Status.Name = "Status"
        Me.Status.Width = 120
        '
        'Actions
        '
        Me.Actions.DataPropertyName = "colActions"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.Actions.DefaultCellStyle = DataGridViewCellStyle2
        Me.Actions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Actions.HeaderText = "Actions"
        Me.Actions.MinimumWidth = 6
        Me.Actions.Name = "Actions"
        Me.Actions.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Actions.Text = "Edit"
        Me.Actions.Width = 125
        '
        'Delete
        '
        Me.Delete.DataPropertyName = "colDelete"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.Delete.DefaultCellStyle = DataGridViewCellStyle3
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete.HeaderText = "Delete"
        Me.Delete.MinimumWidth = 6
        Me.Delete.Name = "Delete"
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Delete.Text = "Delete"
        Me.Delete.UseColumnTextForButtonValue = True
        Me.Delete.Width = 125
        '
        'AddOrdersBtn
        '
        Me.AddOrdersBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AddOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddOrdersBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.AddOrdersBtn.ForeColor = System.Drawing.Color.White
        Me.AddOrdersBtn.Image = CType(resources.GetObject("AddOrdersBtn.Image"), System.Drawing.Image)
        Me.AddOrdersBtn.Location = New System.Drawing.Point(1235, 17)
        Me.AddOrdersBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.AddOrdersBtn.Name = "AddOrdersBtn"
        Me.AddOrdersBtn.Size = New System.Drawing.Size(196, 52)
        Me.AddOrdersBtn.TabIndex = 4
        Me.AddOrdersBtn.Text = "   Add Orders"
        Me.AddOrdersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddOrdersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddOrdersBtn.UseVisualStyleBackColor = False
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1728, 699)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.AddOrdersBtn)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Orders"
        Me.Text = "Orders"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AddOrdersBtn As RoundedButton
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OrderDate As DataGridViewTextBoxColumn
    Friend WithEvents OrderTime As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents OrderType As DataGridViewTextBoxColumn
    Friend WithEvents Products As DataGridViewTextBoxColumn
    Friend WithEvents OrderSource As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptNumber As DataGridViewTextBoxColumn
    Friend WithEvents NumberOfDiners As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents OrderPriority As DataGridViewTextBoxColumn
    Friend WithEvents PreparationTimeEstimate As DataGridViewTextBoxColumn
    Friend WithEvents SpecialRequestFlag As DataGridViewTextBoxColumn
    Friend WithEvents ItemsOrderedCount As DataGridViewTextBoxColumn
    Friend WithEvents Quantities As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrices As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Actions As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
End Class
