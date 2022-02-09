Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class ReportAnalysisFinal

    Public Property TestID As String

    Private kon As New SqlConnection("Data Source = TIAGO\SQLEXPRESS; INITIAL CATALOG = TestesFinal; USER ID = Admin; PASSWORD = Admin;")
    Private Sub ReportAnalysisFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Using con As New SqlConnection("Data Source=TIAGO\SQLEXPRESS;Initial Catalog=TestesFinal;Persist Security Info=True;User ID=Admin;Password=Admin")
            con.Open()
            Using cmd As New SqlCommand("Select * From dbo.TestsLines where TestID = '" & TestID & "' ", con)
                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd
                da.Fill(dt)
            End Using
        End Using
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "C:\Users\hp\Desktop\Programa de Testes .vb\ProgramaTestes\ProgramaTestes\Report Analysis\ReportTeste2.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet", dt))
        End With
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
    'Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.TestsLinesTableAdapter.FillBy(Me.TestesFinalDataSet.TestsLines)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub
End Class