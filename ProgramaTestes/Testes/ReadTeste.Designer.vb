<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReadTeste
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReadTeste))
        Me.TestesBdDataSet = New ProgramaTestes.TestesBdDataSet()
        Me.TDailyInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TDailyInformationTableAdapter = New ProgramaTestes.TestesBdDataSetTableAdapters.tDailyInformationTableAdapter()
        Me.TableAdapterManager = New ProgramaTestes.TestesBdDataSetTableAdapters.TableAdapterManager()
        Me.TestsLinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestsLinesTableAdapter = New ProgramaTestes.TestesBdDataSetTableAdapters.TestsLinesTableAdapter()
        Me.AdiocionarTeste = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        CType(Me.TestesBdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDailyInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestsLinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TestesBdDataSet
        '
        Me.TestesBdDataSet.DataSetName = "TestesBdDataSet"
        Me.TestesBdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TDailyInformationBindingSource
        '
        Me.TDailyInformationBindingSource.DataMember = "tDailyInformation"
        Me.TDailyInformationBindingSource.DataSource = Me.TestesBdDataSet
        '
        'TDailyInformationTableAdapter
        '
        Me.TDailyInformationTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tDailyInformationTableAdapter = Me.TDailyInformationTableAdapter
        Me.TableAdapterManager.tDailyInformationTotalsTableAdapter = Nothing
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
        'TestsLinesBindingSource
        '
        Me.TestsLinesBindingSource.DataMember = "TestsLines"
        Me.TestsLinesBindingSource.DataSource = Me.TestesBdDataSet
        '
        'TestsLinesTableAdapter
        '
        Me.TestsLinesTableAdapter.ClearBeforeFill = True
        '
        'AdiocionarTeste
        '
        Me.AdiocionarTeste.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdiocionarTeste.FlatAppearance.BorderSize = 0
        Me.AdiocionarTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdiocionarTeste.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdiocionarTeste.ForeColor = System.Drawing.Color.White
        Me.AdiocionarTeste.Image = CType(resources.GetObject("AdiocionarTeste.Image"), System.Drawing.Image)
        Me.AdiocionarTeste.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AdiocionarTeste.Location = New System.Drawing.Point(545, 18)
        Me.AdiocionarTeste.Name = "AdiocionarTeste"
        Me.AdiocionarTeste.Size = New System.Drawing.Size(178, 72)
        Me.AdiocionarTeste.TabIndex = 36
        Me.AdiocionarTeste.Text = "New Test"
        Me.AdiocionarTeste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AdiocionarTeste.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 96)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(721, 349)
        Me.RichTextBox1.TabIndex = 37
        Me.RichTextBox1.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAdd.FlatAppearance.BorderSize = 0
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonAdd.Image = CType(resources.GetObject("ButtonAdd.Image"), System.Drawing.Image)
        Me.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonAdd.Location = New System.Drawing.Point(307, 17)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(213, 73)
        Me.ButtonAdd.TabIndex = 84
        Me.ButtonAdd.Text = "New Helmet"
        Me.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ReadTeste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(745, 457)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.AdiocionarTeste)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReadTeste"
        Me.Text = "AddTeste"
        CType(Me.TestesBdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDailyInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestsLinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TestesBdDataSet As TestesBdDataSet
    Friend WithEvents TDailyInformationBindingSource As BindingSource
    Friend WithEvents TDailyInformationTableAdapter As TestesBdDataSetTableAdapters.tDailyInformationTableAdapter
    Friend WithEvents TableAdapterManager As TestesBdDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TestsLinesBindingSource As BindingSource
    Friend WithEvents TestsLinesTableAdapter As TestesBdDataSetTableAdapters.TestsLinesTableAdapter
    Friend WithEvents AdiocionarTeste As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ButtonAdd As Button
End Class
