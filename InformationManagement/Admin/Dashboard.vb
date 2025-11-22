Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#F7F8FA")
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New Size(0, 1200)


        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or
            ControlStyles.AllPaintingInWmPaint Or
            ControlStyles.UserPaint, True)
        Me.UpdateStyles()
        ' In Form_Load

    End Sub
    Public Class FlickerFreePanel
        Inherits Panel

        Public Sub New()
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            Me.UpdateStyles()
        End Sub
    End Class



End Class