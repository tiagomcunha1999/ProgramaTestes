<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SizeTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SizeTable))
        Me.PanelMenusFerramentas = New System.Windows.Forms.Panel()
        Me.ButtonMinimize = New System.Windows.Forms.Button()
        Me.ButtonResize = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.DataGridViewSize = New System.Windows.Forms.DataGridView()
        Me.Size = New System.Windows.Forms.Label()
        Me.TextBoxSize = New System.Windows.Forms.TextBox()
        Me.PanelMenusFerramentas.SuspendLayout()
        CType(Me.DataGridViewSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelMenusFerramentas.Size = New System.Drawing.Size(461, 49)
        Me.PanelMenusFerramentas.TabIndex = 21
        '
        'ButtonMinimize
        '
        Me.ButtonMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonMinimize.FlatAppearance.BorderSize = 0
        Me.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonMinimize.Image = CType(resources.GetObject("ButtonMinimize.Image"), System.Drawing.Image)
        Me.ButtonMinimize.Location = New System.Drawing.Point(308, 0)
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
        Me.ButtonResize.Location = New System.Drawing.Point(359, 0)
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
        Me.CloseButton.Location = New System.Drawing.Point(410, 0)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(51, 49)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.FlatAppearance.BorderSize = 0
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.Location = New System.Drawing.Point(394, 53)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(64, 66)
        Me.ButtonSave.TabIndex = 32
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAdd.FlatAppearance.BorderSize = 0
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonAdd.Image = CType(resources.GetObject("ButtonAdd.Image"), System.Drawing.Image)
        Me.ButtonAdd.Location = New System.Drawing.Point(254, 53)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(64, 66)
        Me.ButtonAdd.TabIndex = 31
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDelete.FlatAppearance.BorderSize = 0
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
        Me.ButtonDelete.Location = New System.Drawing.Point(324, 53)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(64, 66)
        Me.ButtonDelete.TabIndex = 30
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEdit.FlatAppearance.BorderSize = 0
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonEdit.Image = CType(resources.GetObject("ButtonEdit.Image"), System.Drawing.Image)
        Me.ButtonEdit.Location = New System.Drawing.Point(394, 53)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(64, 66)
        Me.ButtonEdit.TabIndex = 29
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'DataGridViewSize
        '
        Me.DataGridViewSize.AllowUserToAddRows = False
        Me.DataGridViewSize.AllowUserToDeleteRows = False
        Me.DataGridViewSize.AllowUserToResizeColumns = False
        Me.DataGridViewSize.AllowUserToResizeRows = False
        Me.DataGridViewSize.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewSize.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.DataGridViewSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSize.Location = New System.Drawing.Point(0, 165)
        Me.DataGridViewSize.Name = "DataGridViewSize"
        Me.DataGridViewSize.ReadOnly = True
        Me.DataGridViewSize.RowHeadersWidth = 51
        Me.DataGridViewSize.RowTemplate.Height = 24
        Me.DataGridViewSize.Size = New System.Drawing.Size(461, 436)
        Me.DataGridViewSize.TabIndex = 33
        '
        'Size
        '
        Me.Size.AutoSize = True
        Me.Size.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size.ForeColor = System.Drawing.Color.White
        Me.Size.Location = New System.Drawing.Point(12, 81)
        Me.Size.Name = "Size"
        Me.Size.Size = New System.Drawing.Size(43, 17)
        Me.Size.TabIndex = 35
        Me.Size.Text = "Size :"
        '
        'TextBoxSize
        '
        Me.TextBoxSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSize.Location = New System.Drawing.Point(61, 78)
        Me.TextBoxSize.Name = "TextBoxSize"
        Me.TextBoxSize.Size = New System.Drawing.Size(115, 23)
        Me.TextBoxSize.TabIndex = 34
        '
        'SizeTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(461, 602)
        Me.Controls.Add(Me.Size)
        Me.Controls.Add(Me.TextBoxSize)
        Me.Controls.Add(Me.DataGridViewSize)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.PanelMenusFerramentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SizeTable"
        Me.Text = "Form1"
        Me.PanelMenusFerramentas.ResumeLayout(False)
        CType(Me.DataGridViewSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMenusFerramentas As Panel
    Friend WithEvents ButtonMinimize As Button
    Friend WithEvents ButtonResize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents DataGridViewSize As DataGridView
    Friend WithEvents Size As Label
    Friend WithEvents TextBoxSize As TextBox
End Class
