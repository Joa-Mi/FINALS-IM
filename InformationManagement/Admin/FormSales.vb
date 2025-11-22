
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class FormSales
    Private Sub FormSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeChart()
    End Sub
    Private Sub InitializeChart()

        Dim chart As New Chart()
        chart.Dock = DockStyle.Fill

        Dim chartArea As New ChartArea("MainArea")
        chartArea.AxisX.MajorGrid.LineColor = Color.LightGray
        chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot
        chartArea.AxisY.MajorGrid.LineColor = Color.LightGray
        chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot
        chartArea.AxisY.LabelStyle.Format = "N0"
        chart.ChartAreas.Add(chartArea)

        ' Add title
        Dim title As New Title("Financial Overview - Monthly")
        title.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        title.Alignment = ContentAlignment.TopLeft
        chart.Titles.Add(title)

        ' Create series for Revenue (Purple)
        Dim revenueSeries As New Series("Revenue")
        revenueSeries.ChartType = SeriesChartType.Column
        revenueSeries.Color = Color.FromArgb(139, 128, 233)
        revenueSeries.Points.AddXY("Jan", 2300000)
        revenueSeries.Points.AddXY("Feb", 2550000)
        revenueSeries.Points.AddXY("Mar", 2400000)
        revenueSeries.Points.AddXY("Apr", 3050000)
        revenueSeries.Points.AddXY("May", 2650000)
        revenueSeries.Points.AddXY("Jun", 3450000)
        chart.Series.Add(revenueSeries)

        ' Create series for Expenses (Green)
        Dim expensesSeries As New Series("Expenses")
        expensesSeries.ChartType = SeriesChartType.Column
        expensesSeries.Color = Color.FromArgb(104, 211, 145)
        expensesSeries.Points.AddXY("Jan", 1600000)
        expensesSeries.Points.AddXY("Feb", 1700000)
        expensesSeries.Points.AddXY("Mar", 1700000)
        expensesSeries.Points.AddXY("Apr", 1900000)
        expensesSeries.Points.AddXY("May", 1850000)
        expensesSeries.Points.AddXY("Jun", 2100000)
        chart.Series.Add(expensesSeries)

        ' Create series for Profit (Yellow/Orange)
        Dim profitSeries As New Series("Profit")
        profitSeries.ChartType = SeriesChartType.Column
        profitSeries.Color = Color.FromArgb(255, 193, 86)
        profitSeries.Points.AddXY("Jan", 700000)
        profitSeries.Points.AddXY("Feb", 850000)
        profitSeries.Points.AddXY("Mar", 700000)
        profitSeries.Points.AddXY("Apr", 1150000)
        profitSeries.Points.AddXY("May", 800000)
        profitSeries.Points.AddXY("Jun", 1350000)
        chart.Series.Add(profitSeries)

        ' Add legend
        Dim legend As New Legend()
        legend.Docking = Docking.Bottom
        chart.Legends.Add(legend)

        ' Enable tooltips
        revenueSeries.ToolTip = "Revenue: ₱#VALY{N2}"
        expensesSeries.ToolTip = "Expenses: ₱#VALY{N2}"
        profitSeries.ToolTip = "Profit: ₱#VALY{N2}"

        ' Add custom tooltip on hover (for the popup shown in your image)
        AddHandler chart.MouseMove, AddressOf Chart_MouseMove
    End Sub

    Private Sub Chart_MouseMove(sender As Object, e As MouseEventArgs)
        Dim chart As Chart = CType(sender, Chart)
        Dim result = chart.HitTest(e.X, e.Y)

        If result.ChartElementType = ChartElementType.DataPoint Then
            Dim point = result.Series.Points(result.PointIndex)
            Dim monthName = point.AxisLabel

            ' Get values for this month from all series
            Dim revenue As Double = chart.Series("Revenue").Points(result.PointIndex).YValues(0)
            Dim expenses As Double = chart.Series("Expenses").Points(result.PointIndex).YValues(0)
            Dim profit As Double = chart.Series("Profit").Points(result.PointIndex).YValues(0)

            ' Show custom tooltip or label
            Dim tooltip As String = $"{monthName}{vbCrLf}" &
                                   $"Expenses: ₱{expenses:N2}{vbCrLf}" &
                                   $"Profit: ₱{profit:N2}{vbCrLf}" &
                                   $"Revenue: ₱{revenue:N2}"

            chart.Series(0).ToolTip = tooltip
        End If
    End Sub

    ' Export functionality
    Private Sub ExportChart(chart As Chart)
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|PDF Document|*.pdf"
        saveDialog.Title = "Export Chart"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Select Case System.IO.Path.GetExtension(saveDialog.FileName).ToLower()
                Case ".png"
                    chart.SaveImage(saveDialog.FileName, ChartImageFormat.Png)
                Case ".jpg"
                    chart.SaveImage(saveDialog.FileName, ChartImageFormat.Jpeg)
                Case ".pdf"
                    ' For PDF, you'll need to use a library like iTextSharp
                    MessageBox.Show("PDF export requires additional library")
            End Select
        End If
    End Sub

    Private Sub lblTotalRevenue_Click(sender As Object, e As EventArgs) Handles lblTotalRevenue.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub
End Class