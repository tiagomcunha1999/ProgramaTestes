<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Testes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Testes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AdiocionarTeste = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.Label()
        Me.TestID = New System.Windows.Forms.ComboBox()
        Me.TestsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestesBdDataSet = New ProgramaTestes.TestesBdDataSet()
        Me.TestsTableAdapter = New ProgramaTestes.TestesBdDataSetTableAdapters.TestsTableAdapter()
        Me.TableAdapterManager = New ProgramaTestes.TestesBdDataSetTableAdapters.TableAdapterManager()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.TestTypeTextBox = New System.Windows.Forms.TextBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.WeekTextBox = New System.Windows.Forms.TextBox()
        Me.LaboratoryTextBox = New System.Windows.Forms.TextBox()
        Me.dvgTestes = New System.Windows.Forms.DataGridView()
        CType(Me.TestsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestesBdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgTestes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(30, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Model"
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
        Me.AdiocionarTeste.Location = New System.Drawing.Point(708, 12)
        Me.AdiocionarTeste.Name = "AdiocionarTeste"
        Me.AdiocionarTeste.Size = New System.Drawing.Size(157, 88)
        Me.AdiocionarTeste.TabIndex = 29
        Me.AdiocionarTeste.Text = "Report"
        Me.AdiocionarTeste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AdiocionarTeste.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(367, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(367, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Week"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(508, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Laboratory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(508, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Test Type "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Test ID"
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.ForeColor = System.Drawing.Color.White
        Me.Status.Location = New System.Drawing.Point(30, 96)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(48, 17)
        Me.Status.TabIndex = 23
        Me.Status.Text = "Status"
        '
        'TestID
        '
        Me.TestID.DataSource = Me.TestsBindingSource
        Me.TestID.DisplayMember = "TestID"
        Me.TestID.FormattingEnabled = True
        Me.TestID.Location = New System.Drawing.Point(33, 43)
        Me.TestID.Name = "TestID"
        Me.TestID.Size = New System.Drawing.Size(121, 24)
        Me.TestID.TabIndex = 17
        Me.TestID.ValueMember = "TestID"
        '
        'TestsBindingSource
        '
        Me.TestsBindingSource.DataMember = "Tests"
        Me.TestsBindingSource.DataSource = Me.TestesBdDataSet
        '
        'TestesBdDataSet
        '
        Me.TestesBdDataSet.DataSetName = "TestesBdDataSet"
        Me.TestesBdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestsTableAdapter
        '
        Me.TestsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tDailyInformationTotalsTableAdapter = Nothing
        Me.TableAdapterManager.TestsBeltTableAdapter = Nothing
        Me.TableAdapterManager.TestsLinesTableAdapter = Nothing
        Me.TableAdapterManager.TestsTableAdapter = Me.TestsTableAdapter
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
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestsBindingSource, "Date", True))
        Me.DateTextBox.Location = New System.Drawing.Point(370, 114)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.ReadOnly = True
        Me.DateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DateTextBox.TabIndex = 32
        '
        'TestTypeTextBox
        '
        Me.TestTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestsBindingSource, "TestType", True))
        Me.TestTypeTextBox.Location = New System.Drawing.Point(511, 114)
        Me.TestTypeTextBox.Name = "TestTypeTextBox"
        Me.TestTypeTextBox.ReadOnly = True
        Me.TestTypeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TestTypeTextBox.TabIndex = 33
        '
        'ModelTextBox
        '
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestsBindingSource, "Model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(33, 187)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.ReadOnly = True
        Me.ModelTextBox.Size = New System.Drawing.Size(141, 22)
        Me.ModelTextBox.TabIndex = 34
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestsBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(33, 118)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.ReadOnly = True
        Me.StatusTextBox.Size = New System.Drawing.Size(121, 22)
        Me.StatusTextBox.TabIndex = 35
        '
        'WeekTextBox
        '
        Me.WeekTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestsBindingSource, "Week", True))
        Me.WeekTextBox.Location = New System.Drawing.Point(370, 187)
        Me.WeekTextBox.Name = "WeekTextBox"
        Me.WeekTextBox.ReadOnly = True
        Me.WeekTextBox.Size = New System.Drawing.Size(100, 22)
        Me.WeekTextBox.TabIndex = 36
        '
        'LaboratoryTextBox
        '
        Me.LaboratoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestsBindingSource, "Laboratory", True))
        Me.LaboratoryTextBox.Location = New System.Drawing.Point(511, 187)
        Me.LaboratoryTextBox.Name = "LaboratoryTextBox"
        Me.LaboratoryTextBox.ReadOnly = True
        Me.LaboratoryTextBox.Size = New System.Drawing.Size(100, 22)
        Me.LaboratoryTextBox.TabIndex = 37
        '
        'dvgTestes
        '
        Me.dvgTestes.AllowUserToAddRows = False
        Me.dvgTestes.AllowUserToDeleteRows = False
        Me.dvgTestes.AllowUserToResizeColumns = False
        Me.dvgTestes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dvgTestes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dvgTestes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dvgTestes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.dvgTestes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgTestes.Location = New System.Drawing.Point(-69, 294)
        Me.dvgTestes.Name = "dvgTestes"
        Me.dvgTestes.ReadOnly = True
        Me.dvgTestes.RowHeadersWidth = 51
        Me.dvgTestes.RowTemplate.Height = 24
        Me.dvgTestes.Size = New System.Drawing.Size(945, 255)
        Me.dvgTestes.TabIndex = 38
        '
        'Testes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(877, 546)
        Me.Controls.Add(Me.dvgTestes)
        Me.Controls.Add(Me.LaboratoryTextBox)
        Me.Controls.Add(Me.WeekTextBox)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Me.ModelTextBox)
        Me.Controls.Add(Me.TestTypeTextBox)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AdiocionarTeste)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.TestID)
        Me.Name = "Testes"
        Me.Text = "Testes"
        CType(Me.TestsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestesBdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgTestes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents AdiocionarTeste As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Status As Label
    Friend WithEvents TestID As ComboBox
    Friend WithEvents TestesBdDataSet As TestesBdDataSet
    Friend WithEvents TestsBindingSource As BindingSource
    Friend WithEvents TestsTableAdapter As TestesBdDataSetTableAdapters.TestsTableAdapter
    Friend WithEvents TableAdapterManager As TestesBdDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents TestTypeTextBox As TextBox
    Friend WithEvents ModelTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents WeekTextBox As TextBox
    Friend WithEvents LaboratoryTextBox As TextBox
    Friend WithEvents dvgTestes As DataGridView
End Class
