<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderSource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfDiners = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsOrderedCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderPriority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreparationTimeEstimate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialRequestFlag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(14, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Track and manage "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 36)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Costumer"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1453, 105)
        Me.Splitter1.TabIndex = 36
        Me.Splitter1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderID, Me.CustomerID, Me.EmployeeID, Me.OrderType, Me.OrderSource, Me.ReceiptNumber, Me.NumberOfDiners, Me.OrderDate, Me.OrderTime, Me.ItemsOrderedCount, Me.TotalAmount, Me.OrderStatus, Me.Remarks, Me.OrderPriority, Me.PreparationTimeEstimate, Me.SpecialRequestFlag})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(18, 152)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1516, 181)
        Me.DataGridView1.TabIndex = 42
        '
        'OrderID
        '
        Me.OrderID.DataPropertyName = "colOrderID"
        Me.OrderID.Frozen = True
        Me.OrderID.HeaderText = "OrderID"
        Me.OrderID.MinimumWidth = 6
        Me.OrderID.Name = "OrderID"
        Me.OrderID.ReadOnly = True
        Me.OrderID.Width = 150
        '
        'CustomerID
        '
        Me.CustomerID.DataPropertyName = "colCustomerID"
        Me.CustomerID.HeaderText = "Customer ID"
        Me.CustomerID.MinimumWidth = 6
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.ReadOnly = True
        Me.CustomerID.Width = 125
        '
        'EmployeeID
        '
        Me.EmployeeID.DataPropertyName = "colEmployeeID"
        Me.EmployeeID.HeaderText = "EmployeeID"
        Me.EmployeeID.MinimumWidth = 6
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.ReadOnly = True
        Me.EmployeeID.Width = 125
        '
        'OrderType
        '
        Me.OrderType.DataPropertyName = "colOrderType"
        Me.OrderType.HeaderText = "Order Type"
        Me.OrderType.MinimumWidth = 6
        Me.OrderType.Name = "OrderType"
        Me.OrderType.ReadOnly = True
        Me.OrderType.Width = 125
        '
        'OrderSource
        '
        Me.OrderSource.DataPropertyName = "colOrderSource"
        Me.OrderSource.HeaderText = "Order Source"
        Me.OrderSource.MinimumWidth = 6
        Me.OrderSource.Name = "OrderSource"
        Me.OrderSource.ReadOnly = True
        Me.OrderSource.Width = 125
        '
        'ReceiptNumber
        '
        Me.ReceiptNumber.DataPropertyName = "colReceiptNumber"
        Me.ReceiptNumber.HeaderText = "ReceiptNumber"
        Me.ReceiptNumber.MinimumWidth = 6
        Me.ReceiptNumber.Name = "ReceiptNumber"
        Me.ReceiptNumber.ReadOnly = True
        Me.ReceiptNumber.Width = 135
        '
        'NumberOfDiners
        '
        Me.NumberOfDiners.DataPropertyName = "colNumberOfDiners"
        Me.NumberOfDiners.HeaderText = "Number Of Diners"
        Me.NumberOfDiners.MinimumWidth = 6
        Me.NumberOfDiners.Name = "NumberOfDiners"
        Me.NumberOfDiners.ReadOnly = True
        Me.NumberOfDiners.Width = 145
        '
        'OrderDate
        '
        Me.OrderDate.DataPropertyName = "colOrderDate"
        Me.OrderDate.HeaderText = "Order Date"
        Me.OrderDate.MinimumWidth = 6
        Me.OrderDate.Name = "OrderDate"
        Me.OrderDate.ReadOnly = True
        Me.OrderDate.Width = 125
        '
        'OrderTime
        '
        Me.OrderTime.DataPropertyName = "colOrderTime"
        Me.OrderTime.HeaderText = "Order Time"
        Me.OrderTime.MinimumWidth = 6
        Me.OrderTime.Name = "OrderTime"
        Me.OrderTime.ReadOnly = True
        Me.OrderTime.Width = 125
        '
        'ItemsOrderedCount
        '
        Me.ItemsOrderedCount.DataPropertyName = "colItemsOrderedCount"
        Me.ItemsOrderedCount.HeaderText = "Items Ordered Count"
        Me.ItemsOrderedCount.MinimumWidth = 6
        Me.ItemsOrderedCount.Name = "ItemsOrderedCount"
        Me.ItemsOrderedCount.ReadOnly = True
        Me.ItemsOrderedCount.Width = 135
        '
        'TotalAmount
        '
        Me.TotalAmount.DataPropertyName = "colTotalAmount"
        Me.TotalAmount.HeaderText = "Total Amount"
        Me.TotalAmount.MinimumWidth = 6
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.ReadOnly = True
        Me.TotalAmount.Width = 125
        '
        'OrderStatus
        '
        Me.OrderStatus.DataPropertyName = "colOrderStatus"
        Me.OrderStatus.HeaderText = "Order Status"
        Me.OrderStatus.MinimumWidth = 6
        Me.OrderStatus.Name = "OrderStatus"
        Me.OrderStatus.ReadOnly = True
        Me.OrderStatus.Width = 125
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "colRemarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.MinimumWidth = 6
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        Me.Remarks.Width = 125
        '
        'OrderPriority
        '
        Me.OrderPriority.DataPropertyName = "colOrderPriority"
        Me.OrderPriority.HeaderText = "Order Priority"
        Me.OrderPriority.MinimumWidth = 6
        Me.OrderPriority.Name = "OrderPriority"
        Me.OrderPriority.ReadOnly = True
        Me.OrderPriority.Width = 125
        '
        'PreparationTimeEstimate
        '
        Me.PreparationTimeEstimate.DataPropertyName = "colPreparationTimeEstimate"
        Me.PreparationTimeEstimate.HeaderText = "Preparation Time Estimate"
        Me.PreparationTimeEstimate.MinimumWidth = 6
        Me.PreparationTimeEstimate.Name = "PreparationTimeEstimate"
        Me.PreparationTimeEstimate.ReadOnly = True
        Me.PreparationTimeEstimate.Width = 135
        '
        'SpecialRequestFlag
        '
        Me.SpecialRequestFlag.DataPropertyName = "colSpecialRequestFlag"
        Me.SpecialRequestFlag.HeaderText = "Special Request Flag"
        Me.SpecialRequestFlag.MinimumWidth = 6
        Me.SpecialRequestFlag.Name = "SpecialRequestFlag"
        Me.SpecialRequestFlag.ReadOnly = True
        Me.SpecialRequestFlag.Width = 125
        '
        'Costumer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1453, 864)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Splitter1)
        Me.Name = "Costumer"
        Me.Text = "Costumer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OrderID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeID As DataGridViewTextBoxColumn
    Friend WithEvents OrderType As DataGridViewTextBoxColumn
    Friend WithEvents OrderSource As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptNumber As DataGridViewTextBoxColumn
    Friend WithEvents NumberOfDiners As DataGridViewTextBoxColumn
    Friend WithEvents OrderDate As DataGridViewTextBoxColumn
    Friend WithEvents OrderTime As DataGridViewTextBoxColumn
    Friend WithEvents ItemsOrderedCount As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents OrderStatus As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents OrderPriority As DataGridViewTextBoxColumn
    Friend WithEvents PreparationTimeEstimate As DataGridViewTextBoxColumn
    Friend WithEvents SpecialRequestFlag As DataGridViewTextBoxColumn
End Class
