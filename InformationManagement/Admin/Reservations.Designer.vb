<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservations
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservations))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAddNewReservation = New System.Windows.Forms.Button()
        Me.ReservationID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignedStaffID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfGuests = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductSelection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialRequests = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryOption = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actions = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reservations Management"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReservationID, Me.CustomerID, Me.AssignedStaffID, Me.ReservationType, Me.EventType, Me.EventTime, Me.NumberOfGuests, Me.ProductSelection, Me.SpecialRequests, Me.ReservationStatus, Me.ReservationDate, Me.Address, Me.ServiceType, Me.DeliveryOption, Me.ContactNumber, Me.Actions})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(35, 79)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Size = New System.Drawing.Size(1150, 116)
        Me.DataGridView1.TabIndex = 5
        '
        'btnAddNewReservation
        '
        Me.btnAddNewReservation.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAddNewReservation.FlatAppearance.BorderSize = 0
        Me.btnAddNewReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewReservation.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewReservation.ForeColor = System.Drawing.Color.White
        Me.btnAddNewReservation.Image = CType(resources.GetObject("btnAddNewReservation.Image"), System.Drawing.Image)
        Me.btnAddNewReservation.Location = New System.Drawing.Point(953, 27)
        Me.btnAddNewReservation.Name = "btnAddNewReservation"
        Me.btnAddNewReservation.Size = New System.Drawing.Size(224, 44)
        Me.btnAddNewReservation.TabIndex = 6
        Me.btnAddNewReservation.Text = "   Add New Reservation"
        Me.btnAddNewReservation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddNewReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddNewReservation.UseVisualStyleBackColor = False
        '
        'ReservationID
        '
        Me.ReservationID.DataPropertyName = "colReservationID"
        Me.ReservationID.HeaderText = "Reservation ID"
        Me.ReservationID.MinimumWidth = 6
        Me.ReservationID.Name = "ReservationID"
        Me.ReservationID.Width = 75
        '
        'CustomerID
        '
        Me.CustomerID.DataPropertyName = "colCustomerID"
        Me.CustomerID.HeaderText = "CustomerID"
        Me.CustomerID.MinimumWidth = 6
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Width = 150
        '
        'AssignedStaffID
        '
        Me.AssignedStaffID.DataPropertyName = "colAssignedStaffID"
        Me.AssignedStaffID.HeaderText = "Assigned Staff ID"
        Me.AssignedStaffID.MinimumWidth = 6
        Me.AssignedStaffID.Name = "AssignedStaffID"
        Me.AssignedStaffID.Width = 150
        '
        'ReservationType
        '
        Me.ReservationType.DataPropertyName = "colReservationType"
        Me.ReservationType.HeaderText = "Reservation Type"
        Me.ReservationType.MinimumWidth = 6
        Me.ReservationType.Name = "ReservationType"
        Me.ReservationType.Width = 120
        '
        'EventType
        '
        Me.EventType.DataPropertyName = "colEventType"
        Me.EventType.HeaderText = "Event Type"
        Me.EventType.MinimumWidth = 6
        Me.EventType.Name = "EventType"
        Me.EventType.Width = 120
        '
        'EventTime
        '
        Me.EventTime.DataPropertyName = "colEventTime"
        Me.EventTime.HeaderText = "Event Time"
        Me.EventTime.MinimumWidth = 6
        Me.EventTime.Name = "EventTime"
        Me.EventTime.Width = 120
        '
        'NumberOfGuests
        '
        Me.NumberOfGuests.DataPropertyName = "colNumberOfGuests"
        Me.NumberOfGuests.HeaderText = "Number Of Guests"
        Me.NumberOfGuests.MinimumWidth = 6
        Me.NumberOfGuests.Name = "NumberOfGuests"
        Me.NumberOfGuests.Width = 120
        '
        'ProductSelection
        '
        Me.ProductSelection.DataPropertyName = "colProductSelection"
        Me.ProductSelection.HeaderText = "Product Selection"
        Me.ProductSelection.MinimumWidth = 6
        Me.ProductSelection.Name = "ProductSelection"
        Me.ProductSelection.Width = 125
        '
        'SpecialRequests
        '
        Me.SpecialRequests.DataPropertyName = "colSpecialRequests"
        Me.SpecialRequests.HeaderText = "Special Requests"
        Me.SpecialRequests.MinimumWidth = 6
        Me.SpecialRequests.Name = "SpecialRequests"
        Me.SpecialRequests.Width = 125
        '
        'ReservationStatus
        '
        Me.ReservationStatus.DataPropertyName = "colReservationStatus"
        Me.ReservationStatus.HeaderText = "Reservation Status"
        Me.ReservationStatus.MinimumWidth = 6
        Me.ReservationStatus.Name = "ReservationStatus"
        Me.ReservationStatus.Width = 125
        '
        'ReservationDate
        '
        Me.ReservationDate.DataPropertyName = "colReservationDate"
        Me.ReservationDate.HeaderText = "Reservation Date"
        Me.ReservationDate.MinimumWidth = 6
        Me.ReservationDate.Name = "ReservationDate"
        Me.ReservationDate.Width = 125
        '
        'Address
        '
        Me.Address.DataPropertyName = "colAddress"
        Me.Address.HeaderText = "Address"
        Me.Address.MinimumWidth = 6
        Me.Address.Name = "Address"
        Me.Address.Width = 125
        '
        'ServiceType
        '
        Me.ServiceType.DataPropertyName = "colServiceType"
        Me.ServiceType.HeaderText = "Service Type"
        Me.ServiceType.MinimumWidth = 6
        Me.ServiceType.Name = "ServiceType"
        Me.ServiceType.Width = 125
        '
        'DeliveryOption
        '
        Me.DeliveryOption.DataPropertyName = "colDeliveryOption"
        Me.DeliveryOption.HeaderText = "Delivery Option"
        Me.DeliveryOption.MinimumWidth = 6
        Me.DeliveryOption.Name = "DeliveryOption"
        Me.DeliveryOption.Width = 125
        '
        'ContactNumber
        '
        Me.ContactNumber.DataPropertyName = "colContactNumber"
        Me.ContactNumber.HeaderText = "Contact Number"
        Me.ContactNumber.MinimumWidth = 6
        Me.ContactNumber.Name = "ContactNumber"
        Me.ContactNumber.Width = 125
        '
        'Actions
        '
        Me.Actions.HeaderText = "Actions"
        Me.Actions.MinimumWidth = 6
        Me.Actions.Name = "Actions"
        Me.Actions.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Actions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Actions.Width = 150
        '
        'Reservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1189, 830)
        Me.Controls.Add(Me.btnAddNewReservation)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Reservations"
        Me.Text = "Reservations"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAddNewReservation As Button
    Friend WithEvents ReservationID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents AssignedStaffID As DataGridViewTextBoxColumn
    Friend WithEvents ReservationType As DataGridViewTextBoxColumn
    Friend WithEvents EventType As DataGridViewTextBoxColumn
    Friend WithEvents EventTime As DataGridViewTextBoxColumn
    Friend WithEvents NumberOfGuests As DataGridViewTextBoxColumn
    Friend WithEvents ProductSelection As DataGridViewTextBoxColumn
    Friend WithEvents SpecialRequests As DataGridViewTextBoxColumn
    Friend WithEvents ReservationStatus As DataGridViewTextBoxColumn
    Friend WithEvents ReservationDate As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents ServiceType As DataGridViewTextBoxColumn
    Friend WithEvents DeliveryOption As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumber As DataGridViewTextBoxColumn
    Friend WithEvents Actions As DataGridViewButtonColumn
End Class
