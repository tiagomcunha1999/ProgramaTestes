<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InfoDiaria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TestesBdDataSet = New ProgramaTestes.TestesBdDataSet()
        Me.TDailyInformationTotalsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TDailyInformationTotalsTableAdapter = New ProgramaTestes.TestesBdDataSetTableAdapters.tDailyInformationTotalsTableAdapter()
        Me.TableAdapterManager = New ProgramaTestes.TestesBdDataSetTableAdapters.TableAdapterManager()
        Me.ButtonInfo = New System.Windows.Forms.Button()
        Me.dgvTestes = New System.Windows.Forms.DataGridView()
        CType(Me.TestesBdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDailyInformationTotalsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTestes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TestesBdDataSet
        '
        Me.TestesBdDataSet.DataSetName = "TestesBdDataSet"
        Me.TestesBdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TDailyInformationTotalsBindingSource
        '
        Me.TDailyInformationTotalsBindingSource.DataMember = "tDailyInformationTotals"
        Me.TDailyInformationTotalsBindingSource.DataSource = Me.TestesBdDataSet
        '
        'TDailyInformationTotalsTableAdapter
        '
        Me.TDailyInformationTotalsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnalysisTableAdapter = Nothing
        Me.TableAdapterManager.ASerialNumbers_HistoryTableAdapter = Nothing
        Me.TableAdapterManager.ASerialNumbersTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BeginbyYearTableAdapter = Nothing
        Me.TableAdapterManager.Belt_ProductCodesTableAdapter = Nothing
        Me.TableAdapterManager.DailyInformation_TableAdapter = Nothing
        Me.TableAdapterManager.DailyInformationTableAdapter = Nothing
        Me.TableAdapterManager.Fields_v1015TableAdapter = Nothing
        Me.TableAdapterManager.Fields_v1026TableAdapter = Nothing
        Me.TableAdapterManager.Fields_v8TableAdapter = Nothing
        Me.TableAdapterManager.FinishProductsTableAdapter = Nothing
        Me.TableAdapterManager.ImportTableAdapter = Nothing
        Me.TableAdapterManager.MarketsStatusTableAdapter = Nothing
        Me.TableAdapterManager.MarketsTableAdapter = Nothing
        Me.TableAdapterManager.modelsTableAdapter = Nothing
        Me.TableAdapterManager.OptionListTableAdapter = Nothing
        Me.TableAdapterManager.Pri_DecalCodeHelmetCodeTableAdapter = Nothing
        Me.TableAdapterManager.Pri_TrackingTableAdapter = Nothing
        Me.TableAdapterManager.Pri_TRAV_InfoLab1TableAdapter = Nothing
        Me.TableAdapterManager.Pri_TRAV_InfoLab2TableAdapter = Nothing
        Me.TableAdapterManager.Pri_TRAV_InfoLab3TableAdapter = Nothing
        Me.TableAdapterManager.Pri_WorkCentreAreasTableAdapter = Nothing
        Me.TableAdapterManager.StandardsConstraintsTableAdapter = Nothing
        Me.TableAdapterManager.TamanhoTableAdapter = Nothing
        Me.TableAdapterManager.tAnalysisLimitsTableAdapter = Nothing
        Me.TableAdapterManager.tAnalysisTableAdapter = Nothing
        Me.TableAdapterManager.tDailyInformationTableAdapter = Nothing
        Me.TableAdapterManager.tDailyInformationTotalsTableAdapter = Me.TDailyInformationTotalsTableAdapter
        Me.TableAdapterManager.TestsBeltTableAdapter = Nothing
        Me.TableAdapterManager.TestsLinesTableAdapter = Nothing
        Me.TableAdapterManager.TestsTableAdapter = Nothing
        Me.TableAdapterManager.tImportTableAdapter = Nothing
        Me.TableAdapterManager.tLimitsTableAdapter = Nothing
        Me.TableAdapterManager.tmodelsTableAdapter = Nothing
        Me.TableAdapterManager.TrackingFP_HistoryTableAdapter = Nothing
        Me.TableAdapterManager.TrackingFPTableAdapter = Nothing
        Me.TableAdapterManager.TrackingRivet_HistoryTableAdapter = Nothing
        Me.TableAdapterManager.TrackingRivetTableAdapter = Nothing
        Me.TableAdapterManager.TrackingSewingTableAdapter = Nothing
        Me.TableAdapterManager.tReportWeeklyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProgramaTestes.TestesBdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ValidationTestsTableAdapter = Nothing
        Me.TableAdapterManager.YearTableAdapter = Nothing
        '
        'ButtonInfo
        '
        Me.ButtonInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ButtonInfo.FlatAppearance.BorderSize = 2
        Me.ButtonInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ButtonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInfo.Font = New System.Drawing.Font("Century Gothic", 13.0!)
        Me.ButtonInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInfo.Location = New System.Drawing.Point(706, 38)
        Me.ButtonInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonInfo.Name = "ButtonInfo"
        Me.ButtonInfo.Size = New System.Drawing.Size(246, 62)
        Me.ButtonInfo.TabIndex = 7
        Me.ButtonInfo.Text = "FY Total"
        Me.ButtonInfo.UseVisualStyleBackColor = True
        '
        'dgvTestes
        '
        Me.dgvTestes.AllowUserToAddRows = False
        Me.dgvTestes.AllowUserToDeleteRows = False
        Me.dgvTestes.AllowUserToResizeColumns = False
        Me.dgvTestes.AllowUserToResizeRows = False
        Me.dgvTestes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTestes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.dgvTestes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTestes.Location = New System.Drawing.Point(3, 133)
        Me.dgvTestes.Name = "dgvTestes"
        Me.dgvTestes.ReadOnly = True
        Me.dgvTestes.RowHeadersWidth = 51
        Me.dgvTestes.RowTemplate.Height = 24
        Me.dgvTestes.Size = New System.Drawing.Size(997, 519)
        Me.dgvTestes.TabIndex = 9
        '
        'InfoDiaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(999, 654)
        Me.Controls.Add(Me.dgvTestes)
        Me.Controls.Add(Me.ButtonInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "InfoDiaria"
        Me.Text = "Testes"
        CType(Me.TestesBdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDailyInformationTotalsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTestes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TestesBdDataSet As TestesBdDataSet
    Friend WithEvents TDailyInformationTotalsBindingSource As BindingSource
    Friend WithEvents TDailyInformationTotalsTableAdapter As TestesBdDataSetTableAdapters.tDailyInformationTotalsTableAdapter
    Friend WithEvents TableAdapterManager As TestesBdDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ButtonInfo As Button
    Friend WithEvents dgvTestes As DataGridView
End Class
