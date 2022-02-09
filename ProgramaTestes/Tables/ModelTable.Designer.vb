<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModelTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModelTable))
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.PanelMenusFerramentas = New System.Windows.Forms.Panel()
        Me.ButtonMinimize = New System.Windows.Forms.Button()
        Me.ButtonResize = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.DataGridViewModels = New System.Windows.Forms.DataGridView()
        Me.TextBoxTModel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Model = New System.Windows.Forms.Label()
        Me.TextBoxModel = New System.Windows.Forms.TextBox()
        Me.PanelMenusFerramentas.SuspendLayout()
        CType(Me.DataGridViewModels, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.FlatAppearance.BorderSize = 0
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.Location = New System.Drawing.Point(783, 71)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(64, 66)
        Me.ButtonSave.TabIndex = 28
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAdd.FlatAppearance.BorderSize = 0
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonAdd.Image = CType(resources.GetObject("ButtonAdd.Image"), System.Drawing.Image)
        Me.ButtonAdd.Location = New System.Drawing.Point(632, 71)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(64, 66)
        Me.ButtonAdd.TabIndex = 23
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDelete.FlatAppearance.BorderSize = 0
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
        Me.ButtonDelete.Location = New System.Drawing.Point(702, 71)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(64, 66)
        Me.ButtonDelete.TabIndex = 22
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEdit.FlatAppearance.BorderSize = 0
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonEdit.Image = CType(resources.GetObject("ButtonEdit.Image"), System.Drawing.Image)
        Me.ButtonEdit.Location = New System.Drawing.Point(783, 71)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(64, 66)
        Me.ButtonEdit.TabIndex = 21
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'PanelMenusFerramentas
        '
        Me.PanelMenusFerramentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PanelMenusFerramentas.Controls.Add(Me.ButtonMinimize)
        Me.PanelMenusFerramentas.Controls.Add(Me.ButtonResize)
        Me.PanelMenusFerramentas.Controls.Add(Me.CloseButton)
        Me.PanelMenusFerramentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenusFerramentas.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenusFerramentas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMenusFerramentas.Name = "PanelMenusFerramentas"
        Me.PanelMenusFerramentas.Size = New System.Drawing.Size(871, 49)
        Me.PanelMenusFerramentas.TabIndex = 20
        '
        'ButtonMinimize
        '
        Me.ButtonMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonMinimize.FlatAppearance.BorderSize = 0
        Me.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonMinimize.Image = CType(resources.GetObject("ButtonMinimize.Image"), System.Drawing.Image)
        Me.ButtonMinimize.Location = New System.Drawing.Point(718, 0)
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
        Me.ButtonResize.Location = New System.Drawing.Point(769, 0)
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
        Me.CloseButton.Location = New System.Drawing.Point(820, 0)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(51, 49)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'DataGridViewModels
        '
        Me.DataGridViewModels.AllowUserToAddRows = False
        Me.DataGridViewModels.AllowUserToDeleteRows = False
        Me.DataGridViewModels.AllowUserToResizeColumns = False
        Me.DataGridViewModels.AllowUserToResizeRows = False
        Me.DataGridViewModels.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewModels.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.DataGridViewModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewModels.Location = New System.Drawing.Point(-4, 179)
        Me.DataGridViewModels.Name = "DataGridViewModels"
        Me.DataGridViewModels.ReadOnly = True
        Me.DataGridViewModels.RowHeadersWidth = 51
        Me.DataGridViewModels.RowTemplate.Height = 24
        Me.DataGridViewModels.Size = New System.Drawing.Size(872, 419)
        Me.DataGridViewModels.TabIndex = 29
        '
        'TextBoxTModel
        '
        Me.TextBoxTModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTModel.Location = New System.Drawing.Point(320, 93)
        Me.TextBoxTModel.Name = "TextBoxTModel"
        Me.TextBoxTModel.Size = New System.Drawing.Size(115, 23)
        Me.TextBoxTModel.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(239, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "TModel :"
        '
        'Model
        '
        Me.Model.AutoSize = True
        Me.Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Model.ForeColor = System.Drawing.Color.White
        Me.Model.Location = New System.Drawing.Point(32, 96)
        Me.Model.Name = "Model"
        Me.Model.Size = New System.Drawing.Size(54, 17)
        Me.Model.TabIndex = 31
        Me.Model.Text = "Model :"
        '
        'TextBoxModel
        '
        Me.TextBoxModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxModel.Location = New System.Drawing.Point(101, 93)
        Me.TextBoxModel.Name = "TextBoxModel"
        Me.TextBoxModel.Size = New System.Drawing.Size(115, 23)
        Me.TextBoxModel.TabIndex = 30
        '
        'ModelTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(871, 599)
        Me.Controls.Add(Me.TextBoxTModel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Model)
        Me.Controls.Add(Me.TextBoxModel)
        Me.Controls.Add(Me.DataGridViewModels)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.PanelMenusFerramentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModelTable"
        Me.Text = "ModelTable"
        Me.PanelMenusFerramentas.ResumeLayout(False)
        CType(Me.DataGridViewModels, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents PanelMenusFerramentas As Panel
    Friend WithEvents ButtonMinimize As Button
    Friend WithEvents ButtonResize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents DataGridViewModels As DataGridView
    Friend WithEvents TextBoxTModel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Model As Label
    Friend WithEvents TextBoxModel As TextBox
End Class
