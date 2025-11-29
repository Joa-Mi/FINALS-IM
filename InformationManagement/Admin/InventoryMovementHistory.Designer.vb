<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryMovementHistory
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()

        '--- Main Container ---
        Me.pnlMain = New Panel()

        '--- Header Panel ---
        Me.pnlHeader = New Panel()
        Me.lblTitle = New Label()
        Me.lblSubtitle = New Label()

        '--- Filter Panel ---
        Me.pnlFilters = New Panel()
        Me.lblFilterTitle = New Label()
        Me.grpDateRange = New GroupBox()
        Me.lblStartDate = New Label()
        Me.dtpStartDate = New DateTimePicker()
        Me.lblEndDate = New Label()
        Me.dtpEndDate = New DateTimePicker()
        Me.grpCategories = New GroupBox()
        Me.lblSource = New Label()
        Me.cmbSource = New ComboBox()
        Me.lblChangeType = New Label()
        Me.cmbChangeType = New ComboBox()
        Me.lblSearch = New Label()
        Me.txtSearch = New TextBox()
        Me.pnlFilterButtons = New Panel()
        Me.btnApplyFilters = New Button()
        Me.btnResetFilters = New Button()

        '--- Statistics Panel ---
        Me.pnlStats = New Panel()
        Me.lblStatsTitle = New Label()
        Me.pnlStatCards = New Panel()
        Me.pnlTotalCard = New Panel()
        Me.lblTotalValue = New Label()
        Me.lblTotalLabel = New Label()
        Me.pnlPOSCard = New Panel()
        Me.lblPOSValue = New Label()
        Me.lblPOSLabel = New Label()
        Me.pnlWebCard = New Panel()
        Me.lblWebValue = New Label()
        Me.lblWebLabel = New Label()
        Me.pnlAdminCard = New Panel()
        Me.lblAdminValue = New Label()
        Me.lblAdminLabel = New Label()

        '--- Data Grid Panel ---
        Me.pnlGrid = New Panel()
        Me.dgvMovements = New DataGridView()

        '--- Action Buttons Panel ---
        Me.pnlActions = New Panel()
        Me.btnExport = New Button()
        Me.btnRefresh = New Button()
        Me.btnClose = New Button()

        Me.SuspendLayout()

        '==============================
        '     FORM MAIN SETTINGS
        '==============================
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 800)
        Me.Text = "Inventory Movement History"
        Me.BackColor = Color.FromArgb(240, 242, 245)
        Me.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        Me.MinimumSize = New Size(1024, 600)
        Me.StartPosition = FormStartPosition.CenterScreen

        '==============================
        '     MAIN CONTAINER
        '==============================
        Me.pnlMain.Dock = DockStyle.Fill
        Me.pnlMain.Padding = New Padding(20)
        Me.pnlMain.BackColor = Color.FromArgb(240, 242, 245)

        '==============================
        '     HEADER PANEL
        '==============================
        Me.pnlHeader.Dock = DockStyle.Top
        Me.pnlHeader.Height = 80
        Me.pnlHeader.BackColor = Color.White
        Me.pnlHeader.Padding = New Padding(20, 15, 20, 15)

        Me.lblTitle.Text = "Inventory Movement History"
        Me.lblTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.FromArgb(33, 37, 41)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New Point(20, 15)

        Me.lblSubtitle.Text = "Track and analyze all inventory changes across your system"
        Me.lblSubtitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        Me.lblSubtitle.ForeColor = Color.FromArgb(108, 117, 125)
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Location = New Point(20, 48)

        Me.pnlHeader.Controls.AddRange(New Control() {lblTitle, lblSubtitle})

        '==============================
        '     FILTER PANEL
        '==============================
        Me.pnlFilters.Dock = DockStyle.Top
        Me.pnlFilters.Height = 200
        Me.pnlFilters.BackColor = Color.White
        Me.pnlFilters.Padding = New Padding(20)
        Me.pnlFilters.Margin = New Padding(0, 15, 0, 0)

        Me.lblFilterTitle.Text = "Filters"
        Me.lblFilterTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular
                                          )
        Me.lblFilterTitle.ForeColor = Color.FromArgb(33, 37, 41)
        Me.lblFilterTitle.Location = New Point(20, 15)
        Me.lblFilterTitle.AutoSize = True

        ' Date Range Group
        Me.grpDateRange.Text = "Date Range"
        Me.grpDateRange.Location = New Point(20, 45)
        Me.grpDateRange.Size = New Size(460, 100)
        Me.grpDateRange.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)

        Me.lblStartDate.Text = "Start Date:"
        Me.lblStartDate.Location = New Point(15, 25)
        Me.lblStartDate.AutoSize = True

        Me.dtpStartDate.Location = New Point(15, 48)
        Me.dtpStartDate.Width = 200
        Me.dtpStartDate.Format = DateTimePickerFormat.Short

        Me.lblEndDate.Text = "End Date:"
        Me.lblEndDate.Location = New Point(240, 25)
        Me.lblEndDate.AutoSize = True

        Me.dtpEndDate.Location = New Point(240, 48)
        Me.dtpEndDate.Width = 200
        Me.dtpEndDate.Format = DateTimePickerFormat.Short

        Me.grpDateRange.Controls.AddRange(New Control() {
            lblStartDate, dtpStartDate, lblEndDate, dtpEndDate
        })

        ' Categories Group
        Me.grpCategories.Text = "Categories & Search"
        Me.grpCategories.Location = New Point(500, 45)
        Me.grpCategories.Size = New Size(540, 100)
        Me.grpCategories.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)

        Me.lblSource.Text = "Source:"
        Me.lblSource.Location = New Point(15, 25)
        Me.lblSource.AutoSize = True

        Me.cmbSource.Location = New Point(15, 48)
        Me.cmbSource.Width = 150
        Me.cmbSource.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblChangeType.Text = "Change Type:"
        Me.lblChangeType.Location = New Point(185, 25)
        Me.lblChangeType.AutoSize = True

        Me.cmbChangeType.Location = New Point(185, 48)
        Me.cmbChangeType.Width = 150
        Me.cmbChangeType.DropDownStyle = ComboBoxStyle.DropDownList

        Me.lblSearch.Text = "Search:"
        Me.lblSearch.Location = New Point(355, 25)
        Me.lblSearch.AutoSize = True

        Me.txtSearch.Location = New Point(355, 48)
        Me.txtSearch.Width = 170


        Me.grpCategories.Controls.AddRange(New Control() {
            lblSource, cmbSource, lblChangeType, cmbChangeType,
            lblSearch, txtSearch
        })

        ' Filter Buttons Panel
        Me.pnlFilterButtons.Location = New Point(1060, 60)
        Me.pnlFilterButtons.Size = New Size(180, 85)

        Me.btnApplyFilters.Size = New Size(160, 35)
        Me.btnApplyFilters.Location = New Point(10, 10)
        Me.btnApplyFilters.Text = "Apply Filters"
        Me.btnApplyFilters.BackColor = Color.FromArgb(0, 123, 255)
        Me.btnApplyFilters.ForeColor = Color.White
        Me.btnApplyFilters.FlatStyle = FlatStyle.Flat
        Me.btnApplyFilters.FlatAppearance.BorderSize = 0
        Me.btnApplyFilters.Cursor = Cursors.Hand
        Me.btnApplyFilters.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)

        Me.btnResetFilters.Size = New Size(160, 35)
        Me.btnResetFilters.Location = New Point(10, 50)
        Me.btnResetFilters.Text = "Reset Filters"
        Me.btnResetFilters.BackColor = Color.FromArgb(108, 117, 125)
        Me.btnResetFilters.ForeColor = Color.White
        Me.btnResetFilters.FlatStyle = FlatStyle.Flat
        Me.btnResetFilters.FlatAppearance.BorderSize = 0
        Me.btnResetFilters.Cursor = Cursors.Hand
        Me.btnResetFilters.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)

        Me.pnlFilterButtons.Controls.AddRange(New Control() {
            btnApplyFilters, btnResetFilters
        })

        Me.pnlFilters.Controls.AddRange(New Control() {
            lblFilterTitle, grpDateRange, grpCategories, pnlFilterButtons
        })

        '==============================
        '     STATISTICS PANEL
        '==============================
        '==============================
        '     STATISTICS PANEL
        '==============================
        Me.pnlStats.Dock = DockStyle.Top
        Me.pnlStats.Height = 140  ' INCREASE FROM 130 to 140
        Me.pnlStats.BackColor = Color.Transparent
        Me.pnlStats.Padding = New Padding(0, 15, 0, 15)  ' CHANGE FROM (0, 15, 0, 0) to (0, 15, 0, 15)

        Me.lblStatsTitle.Text = "Statistics Overview"
        Me.lblStatsTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular
                                         )
        Me.lblStatsTitle.ForeColor = Color.FromArgb(33, 37, 41)
        Me.lblStatsTitle.Location = New Point(0, 0)
        Me.lblStatsTitle.AutoSize = True

        Me.pnlStatCards.Location = New Point(0, 30)
        Me.pnlStatCards.Size = New Size(1240, 90)

        ' Total Movements Card
        Me.pnlTotalCard.Location = New Point(0, 0)
        Me.pnlTotalCard.Size = New Size(295, 90)
        Me.pnlTotalCard.BackColor = Color.FromArgb(0, 123, 255)
        Me.pnlTotalCard.Padding = New Padding(20)

        Me.lblTotalValue.Text = "0"
        Me.lblTotalValue.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        Me.lblTotalValue.ForeColor = Color.White
        Me.lblTotalValue.Location = New Point(20, 15)
        Me.lblTotalValue.AutoSize = True

        Me.lblTotalLabel.Text = "Total Movements"
        Me.lblTotalLabel.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        Me.lblTotalLabel.ForeColor = Color.FromArgb(220, 230, 255)
        Me.lblTotalLabel.Location = New Point(20, 55)
        Me.lblTotalLabel.AutoSize = True

        Me.pnlTotalCard.Controls.AddRange(New Control() {
            lblTotalValue, lblTotalLabel
        })

        ' POS Card
        Me.pnlPOSCard.Location = New Point(310, 0)
        Me.pnlPOSCard.Size = New Size(295, 90)
        Me.pnlPOSCard.BackColor = Color.FromArgb(40, 167, 69)
        Me.pnlPOSCard.Padding = New Padding(20)

        Me.lblPOSValue.Text = "0"
        Me.lblPOSValue.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        Me.lblPOSValue.ForeColor = Color.White
        Me.lblPOSValue.Location = New Point(20, 15)
        Me.lblPOSValue.AutoSize = True

        Me.lblPOSLabel.Text = "POS Transactions"
        Me.lblPOSLabel.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        Me.lblPOSLabel.ForeColor = Color.FromArgb(220, 255, 230)
        Me.lblPOSLabel.Location = New Point(20, 55)
        Me.lblPOSLabel.AutoSize = True

        Me.pnlPOSCard.Controls.AddRange(New Control() {
            lblPOSValue, lblPOSLabel
        })

        ' Website Card
        Me.pnlWebCard.Location = New Point(620, 0)
        Me.pnlWebCard.Size = New Size(295, 90)
        Me.pnlWebCard.BackColor = Color.FromArgb(255, 193, 7)
        Me.pnlWebCard.Padding = New Padding(20)

        Me.lblWebValue.Text = "0"
        Me.lblWebValue.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        Me.lblWebValue.ForeColor = Color.White
        Me.lblWebValue.Location = New Point(20, 15)
        Me.lblWebValue.AutoSize = True

        Me.lblWebLabel.Text = "Website Orders"
        Me.lblWebLabel.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        Me.lblWebLabel.ForeColor = Color.FromArgb(255, 245, 220)
        Me.lblWebLabel.Location = New Point(20, 55)
        Me.lblWebLabel.AutoSize = True

        Me.pnlWebCard.Controls.AddRange(New Control() {
            lblWebValue, lblWebLabel
        })

        ' Admin Card
        Me.pnlAdminCard.Location = New Point(930, 0)
        Me.pnlAdminCard.Size = New Size(295, 90)
        Me.pnlAdminCard.BackColor = Color.FromArgb(220, 53, 69)
        Me.pnlAdminCard.Padding = New Padding(20)

        Me.lblAdminValue.Text = "0"
        Me.lblAdminValue.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        Me.lblAdminValue.ForeColor = Color.White
        Me.lblAdminValue.Location = New Point(20, 15)
        Me.lblAdminValue.AutoSize = True

        Me.lblAdminLabel.Text = "Admin Changes"
        Me.lblAdminLabel.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        Me.lblAdminLabel.ForeColor = Color.FromArgb(255, 220, 225)
        Me.lblAdminLabel.Location = New Point(20, 55)
        Me.lblAdminLabel.AutoSize = True

        Me.pnlAdminCard.Controls.AddRange(New Control() {
            lblAdminValue, lblAdminLabel
        })

        Me.pnlStatCards.Controls.AddRange(New Control() {
            pnlTotalCard, pnlPOSCard, pnlWebCard, pnlAdminCard
        })

        Me.pnlStats.Controls.AddRange(New Control() {
            lblStatsTitle, pnlStatCards
        })

        '==============================
        '     DATA GRID PANEL
        '==============================
        Me.pnlGrid.Dock = DockStyle.Fill
        Me.pnlGrid.BackColor = Color.White
        Me.pnlGrid.Padding = New Padding(20)

        Me.dgvMovements.Dock = DockStyle.Fill
        Me.dgvMovements.ReadOnly = True
        Me.dgvMovements.AllowUserToAddRows = False
        Me.dgvMovements.AllowUserToDeleteRows = False
        Me.dgvMovements.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovements.BackgroundColor = Color.White
        Me.dgvMovements.BorderStyle = BorderStyle.None
        Me.dgvMovements.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvMovements.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Me.dgvMovements.EnableHeadersVisualStyles = False
        Me.dgvMovements.GridColor = Color.FromArgb(222, 226, 230)
        Me.dgvMovements.RowHeadersVisible = False
        Me.dgvMovements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMovements.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)


        ' Column Headers Style
        Me.dgvMovements.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250)
        Me.dgvMovements.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(73, 80, 87)
        Me.dgvMovements.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)  ' CHANGE FROM Semibold to Regular
        Me.dgvMovements.ColumnHeadersDefaultCellStyle.Padding = New Padding(10)
        Me.dgvMovements.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft  ' ADD THIS LINE
        Me.dgvMovements.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False  ' ADD THIS LINE
        Me.dgvMovements.ColumnHeadersHeight = 45  ' INCREASE FROM 40 to 45

        ' Row Style
        Me.dgvMovements.DefaultCellStyle.BackColor = Color.White
        Me.dgvMovements.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41)
        Me.dgvMovements.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 244, 255)
        Me.dgvMovements.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 123, 255)
        Me.dgvMovements.DefaultCellStyle.Padding = New Padding(10, 5, 10, 5)
        Me.dgvMovements.RowTemplate.Height = 35

        ' Alternating Row Style
        Me.dgvMovements.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250)

        Me.pnlGrid.Controls.Add(Me.dgvMovements)

        '==============================
        '     ACTION BUTTONS PANEL
        '==============================
        Me.pnlActions.Dock = DockStyle.Bottom
        Me.pnlActions.Height = 70
        Me.pnlActions.BackColor = Color.White
        Me.pnlActions.Padding = New Padding(20, 15, 20, 15)

        Me.btnExport.Size = New Size(140, 40)
        Me.btnExport.Location = New Point(20, 15)
        Me.btnExport.Text = "📊 Export CSV"
        Me.btnExport.BackColor = Color.FromArgb(40, 167, 69)
        Me.btnExport.ForeColor = Color.White
        Me.btnExport.FlatStyle = FlatStyle.Flat
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.Cursor = Cursors.Hand
        Me.btnExport.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)

        Me.btnRefresh.Size = New Size(140, 40)
        Me.btnRefresh.Location = New Point(170, 15)
        Me.btnRefresh.Text = "🔄 Refresh"
        Me.btnRefresh.BackColor = Color.FromArgb(0, 123, 255)
        Me.btnRefresh.ForeColor = Color.White
        Me.btnRefresh.FlatStyle = FlatStyle.Flat
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.Cursor = Cursors.Hand
        Me.btnRefresh.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)

        Me.btnClose.Size = New Size(140, 40)
        Me.btnClose.Location = New Point(1100, 15)
        Me.btnClose.Text = "Close"
        Me.btnClose.BackColor = Color.FromArgb(108, 117, 125)
        Me.btnClose.ForeColor = Color.White
        Me.btnClose.FlatStyle = FlatStyle.Flat
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.Cursor = Cursors.Hand
        Me.btnClose.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)

        Me.pnlActions.Controls.AddRange(New Control() {
            btnExport, btnRefresh, btnClose
        })

        '==============================
        ' ASSEMBLE MAIN PANEL
        '==============================
        Me.pnlMain.Controls.Add(Me.pnlGrid)
        Me.pnlMain.Controls.Add(Me.pnlStats)
        Me.pnlMain.Controls.Add(Me.pnlFilters)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Controls.Add(Me.pnlActions)

        '==============================
        ' ADD TO FORM
        '==============================
        Me.Controls.Add(Me.pnlMain)

        Me.ResumeLayout(False)

    End Sub

    '==== Declare controls ====
    Friend WithEvents pnlMain As Panel

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label

    Friend WithEvents pnlFilters As Panel
    Friend WithEvents lblFilterTitle As Label
    Friend WithEvents grpDateRange As GroupBox
    Friend WithEvents lblStartDate As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents lblEndDate As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents grpCategories As GroupBox
    Friend WithEvents lblSource As Label
    Friend WithEvents cmbSource As ComboBox
    Friend WithEvents lblChangeType As Label
    Friend WithEvents cmbChangeType As ComboBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pnlFilterButtons As Panel
    Friend WithEvents btnApplyFilters As Button
    Friend WithEvents btnResetFilters As Button

    Friend WithEvents pnlStats As Panel
    Friend WithEvents lblStatsTitle As Label
    Friend WithEvents pnlStatCards As Panel
    Friend WithEvents pnlTotalCard As Panel
    Friend WithEvents lblTotalValue As Label
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents pnlPOSCard As Panel
    Friend WithEvents lblPOSValue As Label
    Friend WithEvents lblPOSLabel As Label
    Friend WithEvents pnlWebCard As Panel
    Friend WithEvents lblWebValue As Label
    Friend WithEvents lblWebLabel As Label
    Friend WithEvents pnlAdminCard As Panel
    Friend WithEvents lblAdminValue As Label
    Friend WithEvents lblAdminLabel As Label

    Friend WithEvents pnlGrid As Panel
    Friend WithEvents dgvMovements As DataGridView

    Friend WithEvents pnlActions As Panel
    Friend WithEvents btnExport As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClose As Button
End Class