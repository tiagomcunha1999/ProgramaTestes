<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportView
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tReportWeeklyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestesBdDataSet = New ProgramaTestes.TestesBdDataSet()
        Me.tReportWeeklyTableAdapter = New ProgramaTestes.TestesBdDataSetTableAdapters.tReportWeeklyTableAdapter()
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.tReportWeeklyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestesBdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tReportWeeklyBindingSource
        '
        Me.tReportWeeklyBindingSource.DataMember = "tReportWeekly"
        Me.tReportWeeklyBindingSource.DataSource = Me.TestesBdDataSet
        '
        'TestesBdDataSet
        '
        Me.TestesBdDataSet.DataSetName = "TestesBdDataSet"
        Me.TestesBdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tReportWeeklyTableAdapter
        '
        Me.tReportWeeklyTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer
        '
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetReport"
        ReportDataSource1.Value = Me.tReportWeeklyBindingSource
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "ProgramaTestes.Report.rdlc"
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(800, 484)
        Me.ReportViewer.TabIndex = 0
        '
        'ReportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 484)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "ReportView"
        Me.Text = "ReportView"
        CType(Me.tReportWeeklyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestesBdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tReportWeeklyBindingSource As BindingSource
    Friend WithEvents TestesBdDataSet As TestesBdDataSet
    Friend WithEvents tReportWeeklyTableAdapter As TestesBdDataSetTableAdapters.tReportWeeklyTableAdapter
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
