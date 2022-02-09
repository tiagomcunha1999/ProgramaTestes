<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PanelMenus = New System.Windows.Forms.Panel()
        Me.ButtonTabelas = New System.Windows.Forms.Button()
        Me.ButtonRelatorio = New System.Windows.Forms.Button()
        Me.ButtonAnalises = New System.Windows.Forms.Button()
        Me.ButtonInformacao = New System.Windows.Forms.Button()
        Me.ButtonTestes = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMenusFerramentas = New System.Windows.Forms.Panel()
        Me.ButtonMinimize = New System.Windows.Forms.Button()
        Me.ButtonResize = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.PainelPrincipal = New System.Windows.Forms.Panel()
        Me.TestesBdDataSet = New ProgramaTestes.TestesBdDataSet()
        Me.TestsLinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestsLinesTableAdapter = New ProgramaTestes.TestesBdDataSetTableAdapters.TestsLinesTableAdapter()
        Me.TableAdapterManager = New ProgramaTestes.TestesBdDataSetTableAdapters.TableAdapterManager()
        Me.PanelMenus.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenusFerramentas.SuspendLayout()
        CType(Me.TestesBdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestsLinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenus
        '
        Me.PanelMenus.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelMenus.Controls.Add(Me.ButtonTabelas)
        Me.PanelMenus.Controls.Add(Me.ButtonRelatorio)
        Me.PanelMenus.Controls.Add(Me.ButtonAnalises)
        Me.PanelMenus.Controls.Add(Me.ButtonInformacao)
        Me.PanelMenus.Controls.Add(Me.ButtonTestes)
        Me.PanelMenus.Controls.Add(Me.PictureBox1)
        Me.PanelMenus.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenus.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMenus.Name = "PanelMenus"
        Me.PanelMenus.Size = New System.Drawing.Size(249, 663)
        Me.PanelMenus.TabIndex = 0
        '
        'ButtonTabelas
        '
        Me.ButtonTabelas.FlatAppearance.BorderSize = 0
        Me.ButtonTabelas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ButtonTabelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTabelas.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTabelas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonTabelas.Image = CType(resources.GetObject("ButtonTabelas.Image"), System.Drawing.Image)
        Me.ButtonTabelas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTabelas.Location = New System.Drawing.Point(-1, 439)
        Me.ButtonTabelas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonTabelas.Name = "ButtonTabelas"
        Me.ButtonTabelas.Size = New System.Drawing.Size(251, 52)
        Me.ButtonTabelas.TabIndex = 5
        Me.ButtonTabelas.Text = "   Database Tables"
        Me.ButtonTabelas.UseVisualStyleBackColor = True
        '
        'ButtonRelatorio
        '
        Me.ButtonRelatorio.FlatAppearance.BorderSize = 0
        Me.ButtonRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ButtonRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRelatorio.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRelatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonRelatorio.Image = CType(resources.GetObject("ButtonRelatorio.Image"), System.Drawing.Image)
        Me.ButtonRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRelatorio.Location = New System.Drawing.Point(-1, 377)
        Me.ButtonRelatorio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonRelatorio.Name = "ButtonRelatorio"
        Me.ButtonRelatorio.Size = New System.Drawing.Size(251, 52)
        Me.ButtonRelatorio.TabIndex = 4
        Me.ButtonRelatorio.Text = "Report"
        Me.ButtonRelatorio.UseVisualStyleBackColor = True
        '
        'ButtonAnalises
        '
        Me.ButtonAnalises.FlatAppearance.BorderSize = 0
        Me.ButtonAnalises.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ButtonAnalises.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAnalises.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnalises.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonAnalises.Image = CType(resources.GetObject("ButtonAnalises.Image"), System.Drawing.Image)
        Me.ButtonAnalises.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAnalises.Location = New System.Drawing.Point(-1, 313)
        Me.ButtonAnalises.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonAnalises.Name = "ButtonAnalises"
        Me.ButtonAnalises.Size = New System.Drawing.Size(251, 52)
        Me.ButtonAnalises.TabIndex = 3
        Me.ButtonAnalises.Text = "Add Test"
        Me.ButtonAnalises.UseVisualStyleBackColor = True
        '
        'ButtonInformacao
        '
        Me.ButtonInformacao.FlatAppearance.BorderSize = 0
        Me.ButtonInformacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ButtonInformacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInformacao.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInformacao.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonInformacao.Image = CType(resources.GetObject("ButtonInformacao.Image"), System.Drawing.Image)
        Me.ButtonInformacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInformacao.Location = New System.Drawing.Point(-1, 250)
        Me.ButtonInformacao.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonInformacao.Name = "ButtonInformacao"
        Me.ButtonInformacao.Size = New System.Drawing.Size(251, 52)
        Me.ButtonInformacao.TabIndex = 2
        Me.ButtonInformacao.Text = "Daily Info"
        Me.ButtonInformacao.UseVisualStyleBackColor = True
        '
        'ButtonTestes
        '
        Me.ButtonTestes.FlatAppearance.BorderSize = 0
        Me.ButtonTestes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ButtonTestes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTestes.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTestes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonTestes.Image = CType(resources.GetObject("ButtonTestes.Image"), System.Drawing.Image)
        Me.ButtonTestes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTestes.Location = New System.Drawing.Point(0, 187)
        Me.ButtonTestes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonTestes.Name = "ButtonTestes"
        Me.ButtonTestes.Size = New System.Drawing.Size(251, 52)
        Me.ButtonTestes.TabIndex = 1
        Me.ButtonTestes.Text = "Tests"
        Me.ButtonTestes.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelMenusFerramentas
        '
        Me.PanelMenusFerramentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PanelMenusFerramentas.Controls.Add(Me.ButtonMinimize)
        Me.PanelMenusFerramentas.Controls.Add(Me.ButtonResize)
        Me.PanelMenusFerramentas.Controls.Add(Me.CloseButton)
        Me.PanelMenusFerramentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenusFerramentas.Location = New System.Drawing.Point(249, 0)
        Me.PanelMenusFerramentas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMenusFerramentas.Name = "PanelMenusFerramentas"
        Me.PanelMenusFerramentas.Size = New System.Drawing.Size(772, 49)
        Me.PanelMenusFerramentas.TabIndex = 1
        '
        'ButtonMinimize
        '
        Me.ButtonMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonMinimize.FlatAppearance.BorderSize = 0
        Me.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonMinimize.Image = CType(resources.GetObject("ButtonMinimize.Image"), System.Drawing.Image)
        Me.ButtonMinimize.Location = New System.Drawing.Point(619, 0)
        Me.ButtonMinimize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonMinimize.Name = "ButtonMinimize"
        Me.ButtonMinimize.Size = New System.Drawing.Size(51, 49)
        Me.ButtonMinimize.TabIndex = 5
        Me.ButtonMinimize.UseVisualStyleBackColor = True
        '
        'ButtonResize
        '
        Me.ButtonResize.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonResize.FlatAppearance.BorderSize = 0
        Me.ButtonResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonResize.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonResize.Image = CType(resources.GetObject("ButtonResize.Image"), System.Drawing.Image)
        Me.ButtonResize.Location = New System.Drawing.Point(670, 0)
        Me.ButtonResize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonResize.Name = "ButtonResize"
        Me.ButtonResize.Size = New System.Drawing.Size(51, 49)
        Me.ButtonResize.TabIndex = 4
        Me.ButtonResize.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CloseButton.Image = CType(resources.GetObject("CloseButton.Image"), System.Drawing.Image)
        Me.CloseButton.Location = New System.Drawing.Point(721, 0)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(51, 49)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'PainelPrincipal
        '
        Me.PainelPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PainelPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PainelPrincipal.Location = New System.Drawing.Point(249, 55)
        Me.PainelPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.PainelPrincipal.Name = "PainelPrincipal"
        Me.PainelPrincipal.Size = New System.Drawing.Size(772, 604)
        Me.PainelPrincipal.TabIndex = 2
        '
        'TestesBdDataSet
        '
        Me.TestesBdDataSet.DataSetName = "TestesBdDataSet"
        Me.TestesBdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.TestsLinesTableAdapter = Me.TestsLinesTableAdapter
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1021, 663)
        Me.Controls.Add(Me.PainelPrincipal)
        Me.Controls.Add(Me.PanelMenusFerramentas)
        Me.Controls.Add(Me.PanelMenus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programa de Testes"
        Me.PanelMenus.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenusFerramentas.ResumeLayout(False)
        CType(Me.TestesBdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestsLinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenus As Panel
    Friend WithEvents ButtonTestes As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelMenusFerramentas As Panel
    Friend WithEvents CloseButton As Button
    Friend WithEvents ButtonResize As Button
    Friend WithEvents ButtonMinimize As Button
    Friend WithEvents ButtonTabelas As Button
    Friend WithEvents ButtonRelatorio As Button
    Friend WithEvents ButtonAnalises As Button
    Friend WithEvents ButtonInformacao As Button
    Friend WithEvents PainelPrincipal As Panel
    Friend WithEvents TestesBdDataSet As TestesBdDataSet
    Friend WithEvents TestsLinesBindingSource As BindingSource
    Friend WithEvents TestsLinesTableAdapter As TestesBdDataSetTableAdapters.TestsLinesTableAdapter
    Friend WithEvents TableAdapterManager As TestesBdDataSetTableAdapters.TableAdapterManager
End Class
