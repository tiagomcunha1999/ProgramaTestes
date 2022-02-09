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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AdiocionarTeste = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New ProgramaTestes.TestesFinalDataSetTableAdapters.TableAdapterManager()
        Me.dvgTestes = New System.Windows.Forms.DataGridView()
        Me.TextBoxModel = New System.Windows.Forms.TextBox()
        Me.TextBoxStatus = New System.Windows.Forms.TextBox()
        Me.TextBoxHelmet = New System.Windows.Forms.TextBox()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.TextBoxLocal = New System.Windows.Forms.TextBox()
        Me.TextBoxTestType = New System.Windows.Forms.TextBox()
        Me.TestID = New System.Windows.Forms.ComboBox()
        Me.TestesFinalDataSet = New ProgramaTestes.TestesFinalDataSet()
        Me.HelmetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HelmetsTableAdapter = New ProgramaTestes.TestesFinalDataSetTableAdapters.HelmetsTableAdapter()
        CType(Me.dvgTestes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestesFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HelmetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(29, 167)
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
        Me.AdiocionarTeste.Location = New System.Drawing.Point(661, 12)
        Me.AdiocionarTeste.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AdiocionarTeste.Name = "AdiocionarTeste"
        Me.AdiocionarTeste.Size = New System.Drawing.Size(157, 89)
        Me.AdiocionarTeste.TabIndex = 29
        Me.AdiocionarTeste.Text = "Report"
        Me.AdiocionarTeste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AdiocionarTeste.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(351, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Size"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(351, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Helmet Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(505, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Local Rejection"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(505, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Test Type "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Helmet ID"
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.ForeColor = System.Drawing.Color.White
        Me.Status.Location = New System.Drawing.Point(29, 96)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(48, 17)
        Me.Status.TabIndex = 23
        Me.Status.Text = "Status"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.HelmetsTableAdapter = Nothing
        Me.TableAdapterManager.OperatorTableAdapter = Nothing
        Me.TableAdapterManager.SizeTableAdapter = Nothing
        Me.TableAdapterManager.TestsLinesTableAdapter = Nothing
        Me.TableAdapterManager.tmodelsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProgramaTestes.TestesFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'dvgTestes
        '
        Me.dvgTestes.AllowUserToAddRows = False
        Me.dvgTestes.AllowUserToDeleteRows = False
        Me.dvgTestes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgTestes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dvgTestes.Location = New System.Drawing.Point(0, 281)
        Me.dvgTestes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dvgTestes.Name = "dvgTestes"
        Me.dvgTestes.ReadOnly = True
        Me.dvgTestes.RowHeadersWidth = 51
        Me.dvgTestes.RowTemplate.Height = 24
        Me.dvgTestes.Size = New System.Drawing.Size(829, 334)
        Me.dvgTestes.TabIndex = 50
        '
        'TextBoxModel
        '
        Me.TextBoxModel.Location = New System.Drawing.Point(33, 187)
        Me.TextBoxModel.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxModel.Name = "TextBoxModel"
        Me.TextBoxModel.ReadOnly = True
        Me.TextBoxModel.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxModel.TabIndex = 51
        '
        'TextBoxStatus
        '
        Me.TextBoxStatus.Location = New System.Drawing.Point(33, 116)
        Me.TextBoxStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxStatus.Name = "TextBoxStatus"
        Me.TextBoxStatus.ReadOnly = True
        Me.TextBoxStatus.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxStatus.TabIndex = 52
        '
        'TextBoxHelmet
        '
        Me.TextBoxHelmet.Location = New System.Drawing.Point(355, 187)
        Me.TextBoxHelmet.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxHelmet.Name = "TextBoxHelmet"
        Me.TextBoxHelmet.ReadOnly = True
        Me.TextBoxHelmet.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxHelmet.TabIndex = 53
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Location = New System.Drawing.Point(355, 116)
        Me.TextBoxDate.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.ReadOnly = True
        Me.TextBoxDate.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxDate.TabIndex = 54
        '
        'TextBoxLocal
        '
        Me.TextBoxLocal.Location = New System.Drawing.Point(509, 187)
        Me.TextBoxLocal.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxLocal.Name = "TextBoxLocal"
        Me.TextBoxLocal.ReadOnly = True
        Me.TextBoxLocal.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxLocal.TabIndex = 55
        '
        'TextBoxTestType
        '
        Me.TextBoxTestType.Location = New System.Drawing.Point(509, 116)
        Me.TextBoxTestType.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxTestType.Name = "TextBoxTestType"
        Me.TextBoxTestType.ReadOnly = True
        Me.TextBoxTestType.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxTestType.TabIndex = 56
        '
        'TestID
        '
        Me.TestID.DataSource = Me.HelmetsBindingSource
        Me.TestID.DisplayMember = "ID"
        Me.TestID.FormattingEnabled = True
        Me.TestID.Location = New System.Drawing.Point(33, 47)
        Me.TestID.Name = "TestID"
        Me.TestID.Size = New System.Drawing.Size(121, 24)
        Me.TestID.TabIndex = 57
        '
        'TestesFinalDataSet
        '
        Me.TestesFinalDataSet.DataSetName = "TestesFinalDataSet"
        Me.TestesFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HelmetsBindingSource
        '
        Me.HelmetsBindingSource.DataMember = "Helmets"
        Me.HelmetsBindingSource.DataSource = Me.TestesFinalDataSet
        '
        'HelmetsTableAdapter
        '
        Me.HelmetsTableAdapter.ClearBeforeFill = True
        '
        'Testes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(829, 615)
        Me.Controls.Add(Me.TestID)
        Me.Controls.Add(Me.TextBoxTestType)
        Me.Controls.Add(Me.TextBoxLocal)
        Me.Controls.Add(Me.TextBoxDate)
        Me.Controls.Add(Me.TextBoxHelmet)
        Me.Controls.Add(Me.TextBoxStatus)
        Me.Controls.Add(Me.TextBoxModel)
        Me.Controls.Add(Me.dvgTestes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AdiocionarTeste)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Status)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Testes"
        Me.Text = "Testes"
        CType(Me.dvgTestes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestesFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HelmetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TableAdapterManager As TestesFinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dvgTestes As DataGridView
    Friend WithEvents TextBoxModel As TextBox
    Friend WithEvents TextBoxStatus As TextBox
    Friend WithEvents TextBoxHelmet As TextBox
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents TextBoxLocal As TextBox
    Friend WithEvents TextBoxTestType As TextBox
    Friend WithEvents TestID As ComboBox
    Friend WithEvents TestesFinalDataSet As TestesFinalDataSet
    Friend WithEvents HelmetsBindingSource As BindingSource
    Friend WithEvents HelmetsTableAdapter As TestesFinalDataSetTableAdapters.HelmetsTableAdapter
End Class
