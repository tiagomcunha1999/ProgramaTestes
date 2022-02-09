Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class ReportView
    Private Sub ReportView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestesBdDataSet.tReportWeekly' table. You can move, or remove it, as needed.
        Me.tReportWeeklyTableAdapter.Fill(Me.TestesBdDataSet.tReportWeekly)

        Me.ReportViewer.RefreshReport()
    End Sub

    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class