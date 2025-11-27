Imports System.Windows.Forms.DataVisualization.Charting
Imports MySqlConnector

Public Class Dashboard
    Private WithEvents refreshTimer As New Timer()

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#F7F8FA")
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New Size(0, 1200)

        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or
            ControlStyles.AllPaintingInWmPaint Or
            ControlStyles.UserPaint, True)
        Me.UpdateStyles()

        ' Load all dashboard data
        LoadDashboardData()

        ' Setup auto-refresh timer (refresh every 30 seconds)
        refreshTimer.Interval = 30000 ' 30 seconds
        refreshTimer.Start()
    End Sub

    Private Sub refreshTimer_Tick(sender As Object, e As EventArgs) Handles refreshTimer.Tick
        ' Refresh only dynamic data (orders, reservations)
        LoadPendingOrders()
        LoadActiveReservations()
        LoadTotalOrders()
    End Sub

    Private Sub LoadDashboardData()
        Try
            ' Load metrics
            LoadTotalRevenue()
            LoadTotalOrders()
            LoadActiveReservations()

            ' Load charts and lists
            LoadSalesByChannel()
            LoadTopMenuItems()
            LoadRecentReservations()
            LoadPendingOrders()
            LoadQuickStats()

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ============================================
    ' TOP METRICS
    ' ============================================

    Private Sub LoadTotalRevenue()
        Try
            openConn()
            ' Use dashboard_metrics view if available, fallback to direct query
            cmd = New MySqlCommand("
                SELECT COALESCE(SUM(TotalAmount), 0) as TotalRevenue 
                FROM orders 
                WHERE OrderStatus = 'Completed'", conn)

            Dim revenue As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
            lblTotalRevenue.Text = "₱" & revenue.ToString("N2")
            closeConn()
        Catch ex As Exception
            lblTotalRevenue.Text = "₱0.00"
            closeConn()
        End Try
    End Sub

    Private Sub LoadTotalOrders()
        Try
            openConn()
            cmd = New MySqlCommand("SELECT COUNT(*) FROM orders", conn)
            Dim totalOrders As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Label14.Text = totalOrders.ToString("#,##0")
            closeConn()
        Catch ex As Exception
            Label14.Text = "0"
            closeConn()
        End Try
    End Sub

    Private Sub LoadActiveReservations()
        Try
            openConn()
            cmd = New MySqlCommand("
                SELECT COUNT(*) FROM reservations 
                WHERE ReservationStatus IN ('Pending', 'Confirmed')", conn)

            Dim activeReservations As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Label16.Text = activeReservations.ToString()
            closeConn()
        Catch ex As Exception
            Label16.Text = "0"
            closeConn()
        End Try
    End Sub

    ' ============================================
    ' ALTERNATIVE: Load All Metrics at Once
    ' ============================================

    Private Sub LoadAllMetricsOptimized()
        Try
            openConn()
            cmd = New MySqlCommand("
                SELECT 
                    (SELECT COALESCE(SUM(TotalAmount), 0) FROM orders WHERE OrderStatus = 'Completed') as total_revenue,
                    (SELECT COUNT(*) FROM orders) as total_orders,
                    (SELECT COUNT(*) FROM reservations WHERE ReservationStatus IN ('Pending', 'Confirmed')) as active_reservations
            ", conn)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                lblTotalRevenue.Text = "₱" & Convert.ToDecimal(reader("total_revenue")).ToString("N2")
                Label14.Text = Convert.ToInt32(reader("total_orders")).ToString("#,##0")
                Label16.Text = Convert.ToInt32(reader("active_reservations")).ToString()
            End If
            reader.Close()
            closeConn()
        Catch ex As Exception
            lblTotalRevenue.Text = "₱0.00"
            Label14.Text = "0"
            Label16.Text = "0"
            closeConn()
        End Try
    End Sub

    ' ============================================
    ' SALES BY CHANNEL PIE CHART
    ' ============================================

    Private Sub LoadSalesByChannel()
        Try
            openConn()
            cmd = New MySqlCommand("
                SELECT 
                    OrderType,
                    COALESCE(SUM(TotalAmount), 0) as TotalSales
                FROM orders 
                WHERE OrderStatus = 'Completed'
                GROUP BY OrderType", conn)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim dineInSales As Decimal = 0
            Dim takeoutSales As Decimal = 0
            Dim onlineSales As Decimal = 0

            While reader.Read()
                Dim orderType As String = reader("OrderType").ToString()
                Dim sales As Decimal = Convert.ToDecimal(reader("TotalSales"))

                Select Case orderType
                    Case "Dine-in"
                        dineInSales = sales
                    Case "Takeout"
                        takeoutSales = sales
                    Case "Online"
                        onlineSales = sales
                End Select
            End While
            reader.Close()
            closeConn()

            ' Calculate total and percentages
            Dim totalSales As Decimal = dineInSales + takeoutSales + onlineSales

            If totalSales > 0 Then
                Dim dineInPercent As Decimal = (dineInSales / totalSales) * 100
                Dim takeoutPercent As Decimal = (takeoutSales / totalSales) * 100
                Dim onlinePercent As Decimal = (onlineSales / totalSales) * 100

                ' Update chart
                Chart2.Series(0).Points.Clear()
                Chart2.Series(0).Points.AddXY("Dine-in", dineInPercent)
                Chart2.Series(0).Points.AddXY("Takeout", takeoutPercent)
                Chart2.Series(0).Points.AddXY("Catering", onlinePercent)

                ' Update legend labels
                lblPercentDineIn.Text = dineInPercent.ToString("0") & "%"
                lblValueDinein.Text = "₱" & dineInSales.ToString("N2")

                lblPercentTakeout.Text = takeoutPercent.ToString("0") & "%"
                lblValueTakeout.Text = "₱" & takeoutSales.ToString("N2")

                lblPercentCatering.Text = onlinePercent.ToString("0") & "%"
                lblValueCatering.Text = "₱" & onlineSales.ToString("N2")
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading sales by channel: " & ex.Message)
            closeConn()
        End Try
    End Sub

    ' ============================================
    ' TOP MENU ITEMS
    ' ============================================

    Private Sub LoadTopMenuItems()
        Try
            ' Clear existing items except the first 2 (headers/templates)
            For i = RoundedPane25.Controls.Count - 1 To 0 Step -1
                If TypeOf RoundedPane25.Controls(i) Is RoundedPane2 AndAlso
                   RoundedPane25.Controls(i).Name.StartsWith("RoundedPane2") AndAlso
                   RoundedPane25.Controls(i).Name <> "RoundedPane214" Then
                    RoundedPane25.Controls.RemoveAt(i)
                End If
            Next

            openConn()
            cmd = New MySqlCommand("
                SELECT 
                    p.ProductName,
                    p.OrderCount,
                    COALESCE(SUM(p.Price * p.OrderCount), 0) as TotalRevenue
                FROM products p
                WHERE p.OrderCount > 0
                GROUP BY p.ProductID, p.ProductName, p.OrderCount
                ORDER BY p.OrderCount DESC
                LIMIT 5", conn)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim yPosition As Integer = 61
            Dim itemCount As Integer = 0

            While reader.Read() AndAlso itemCount < 5
                Dim itemPanel As New RoundedPane2 With {
                    .BorderColor = Color.LightGray,
                    .BorderThickness = 1,
                    .CornerRadius = 15,
                    .FillColor = Color.White,
                    .Size = New Size(456, 67),
                    .Location = New Point(20, yPosition)
                }

                ' Icon
                Dim icon As New PictureBox With {
                    .BackColor = Color.Transparent,
                    .Image = My.Resources.fork_and_knife,
                    .Location = New Point(21, 25),
                    .Size = New Size(20, 17)
                }

                ' Product name
                Dim lblName As New Label With {
                    .AutoSize = True,
                    .BackColor = Color.Transparent,
                    .Font = New Font("Segoe UI Semibold", 11.25!, FontStyle.Bold),
                    .Location = New Point(53, 15),
                    .Text = reader("ProductName").ToString()
                }

                ' Order count
                Dim lblOrders As New Label With {
                    .AutoSize = True,
                    .BackColor = Color.Transparent,
                    .Font = New Font("Segoe UI", 9.75!),
                    .ForeColor = SystemColors.ControlDarkDark,
                    .Location = New Point(54, 35),
                    .Text = reader("OrderCount").ToString() & " orders"
                }

                ' Revenue
                Dim lblRevenue As New Label With {
                    .AutoSize = True,
                    .BackColor = Color.Transparent,
                    .Font = New Font("Segoe UI", 11.25!, FontStyle.Bold),
                    .Location = New Point(349, 25),
                    .Text = "₱" & Convert.ToDecimal(reader("TotalRevenue")).ToString("N2")
                }

                itemPanel.Controls.AddRange({icon, lblName, lblOrders, lblRevenue})
                RoundedPane25.Controls.Add(itemPanel)

                yPosition += 83
                itemCount += 1
            End While

            reader.Close()
            closeConn()

        Catch ex As Exception
            MessageBox.Show("Error loading top menu items: " & ex.Message)
            closeConn()
        End Try
    End Sub

    ' ============================================
    ' RECENT RESERVATIONS
    ' ============================================

    Private Sub LoadRecentReservations()
        Try
            openConn()
            cmd = New MySqlCommand("
                SELECT 
                    r.EventType,
                    r.EventDate,
                    r.NumberOfGuests,
                    r.ReservationStatus
                FROM reservations r
                WHERE r.ReservationStatus IN ('Pending', 'Confirmed')
                ORDER BY r.EventDate DESC
                LIMIT 2", conn)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' First reservation (Wedding)
            If reader.Read() Then
                lblEvent.Text = reader("EventType").ToString()
                lblDate.Text = Convert.ToDateTime(reader("EventDate")).ToString("yyyy-MM-dd")
                lblGuests.Text = reader("NumberOfGuests").ToString() & " Guests"
                Label17.Text = reader("ReservationStatus").ToString()
                Label17.BackColor = If(reader("ReservationStatus").ToString() = "Confirmed", Color.Black, Color.LightGray)
            End If


            reader.Close()
            closeConn()

        Catch ex As Exception
            MessageBox.Show("Error loading recent reservations: " & ex.Message)
            closeConn()
        End Try
    End Sub

    ' ============================================
    ' PENDING ORDERS
    ' ============================================
    Private Sub LoadPendingOrders()
        Try
            openConn()
            cmd = New MySqlCommand("
                SELECT 
                    o.ReceiptNumber,
                    o.OrderType,
                    o.TotalAmount,
                    TIMESTAMPDIFF(MINUTE, o.OrderDate, NOW()) as MinutesAgo
                FROM orders o
                WHERE o.OrderStatus = 'Preparing'
                ORDER BY o.OrderDate DESC
                LIMIT 4", conn)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim panels() As Panel = {pnlOrders}
            Dim panelIndex As Integer = 0

            While reader.Read() AndAlso panelIndex < panels.Length
                Dim panel As Panel = panels(panelIndex)

                ' Find and update labels in the panel
                For Each ctrl As Control In panel.Controls
                    If TypeOf ctrl Is Label Then
                        Dim lbl As Label = CType(ctrl, Label)

                        If lbl.Font.Bold AndAlso lbl.Font.Size > 10 Then
                            ' Order ID
                            lbl.Text = reader("ReceiptNumber").ToString()
                        ElseIf lbl.Text.Contains("Dine") Or lbl.Text.Contains("Takeout") Then
                            ' Order type and time
                            lbl.Text = reader("OrderType").ToString() & " -"
                        ElseIf lbl.Text.Contains("mins ago") Then
                            ' Minutes ago
                            lbl.Text = reader("MinutesAgo").ToString() & " mins ago"
                        ElseIf lbl.Text.StartsWith("₱") Then
                            ' Amount
                            lbl.Text = "₱" & Convert.ToDecimal(reader("TotalAmount")).ToString("N2")
                        End If
                    End If
                Next

                panelIndex += 1
            End While

            reader.Close()
            closeConn()

        Catch ex As Exception
            MessageBox.Show("Error loading pending orders: " & ex.Message)
            closeConn()
        End Try
    End Sub
    ' ============================================
    ' QUICK STATS
    ' ============================================

    Private Sub LoadQuickStats()
        Try
            openConn()

            ' Active Staff
            cmd = New MySqlCommand("SELECT COUNT(*) FROM employee WHERE EmploymentStatus = 'Active'", conn)
            Label39.Text = cmd.ExecuteScalar().ToString()

            ' Menu Items
            cmd = New MySqlCommand("SELECT COUNT(*) FROM products WHERE Availability = 'Available'", conn)
            Label38.Text = cmd.ExecuteScalar().ToString()

            ' Tables Available (you may need to create a tables table or use a fixed number)
            Label37.Text = "12/20" ' This would need a proper table management system

            ' Average Order Value
            cmd = New MySqlCommand("
                SELECT COALESCE(AVG(TotalAmount), 0) 
                FROM orders 
                WHERE OrderStatus = 'Completed'", conn)

            Dim avgValue As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
            Label36.Text = "₱" & avgValue.ToString("N2")

            closeConn()

        Catch ex As Exception
            MessageBox.Show("Error loading quick stats: " & ex.Message)
            closeConn()
        End Try
    End Sub

    ' ============================================
    ' HELPER CLASSES
    ' ============================================

    Public Class FlickerFreePanel
        Inherits Panel

        Public Sub New()
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            Me.UpdateStyles()
        End Sub
    End Class

    ' ============================================
    ' REFRESH DATA METHOD
    ' ============================================

    Public Sub RefreshDashboard()
        LoadDashboardData()
    End Sub

End Class