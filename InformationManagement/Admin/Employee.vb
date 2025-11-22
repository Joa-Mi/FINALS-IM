Imports MySqlConnector
Imports System.Data

Public Class Employee

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
        StyleDGV(DataGridView1)
    End Sub

    ' ===============================
    ' LOAD EMPLOYEES INTO DGV
    ' ===============================
    Private Sub LoadEmployees()
        Try
            Dim query As String = "SELECT * FROM Employee"
            LoadToDGV(query, DataGridView1)
        Catch ex As Exception
            MessageBox.Show("Error loading employees: " & ex.Message)
        End Try
    End Sub

    ' ===============================
    ' OPEN ADD EMPLOYEE FORM
    ' ===============================
    Private Sub AddEmployee_Click(sender As Object, e As EventArgs) Handles AddEmployee.Click
        With AddEmployee
            .Show()
            .BringToFront()
        End With
    End Sub

    ' ===============================
    ' BEAUTIFUL DATAGRIDVIEW STYLE
    ' ===============================
    Private Sub StyleDGV(dgv As DataGridView)
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.RowHeadersVisible = False

        ' Header style
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgv.ColumnHeadersHeight = 35

        ' Row style
        dgv.DefaultCellStyle.BackColor = Color.White
        dgv.DefaultCellStyle.ForeColor = Color.Black
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215)
        dgv.DefaultCellStyle.SelectionForeColor = Color.White
        dgv.DefaultCellStyle.Font = New Font("Segoe UI", 10)

        ' Alternate rows
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240)

        ' Grid line color
        dgv.GridColor = Color.LightGray

        ' Auto column fit
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

End Class
