<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableOperator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TableOperator))
        Me.PanelMenusFerramentas = New System.Windows.Forms.Panel()
        Me.ButtonMinimize = New System.Windows.Forms.Button()
        Me.ButtonResize = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.TextBoxNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Name = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.TextBoxMail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewOperator = New System.Windows.Forms.DataGridView()
        Me.PanelMenusFerramentas.SuspendLayout()
        CType(Me.DataGridViewOperator, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelMenusFerramentas.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMenusFerramentas.Name = "PanelMenusFerramentas"
        Me.PanelMenusFerramentas.Size = New System.Drawing.Size(572, 40)
        Me.PanelMenusFerramentas.TabIndex = 21
        '
        'ButtonMinimize
        '
        Me.ButtonMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonMinimize.FlatAppearance.BorderSize = 0
        Me.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonMinimize.Image = CType(resources.GetObject("ButtonMinimize.Image"), System.Drawing.Image)
        Me.ButtonMinimize.Location = New System.Drawing.Point(458, 0)
        Me.ButtonMinimize.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonMinimize.Name = "ButtonMinimize"
        Me.ButtonMinimize.Size = New System.Drawing.Size(38, 40)
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
        Me.ButtonResize.Location = New System.Drawing.Point(496, 0)
        Me.ButtonResize.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonResize.Name = "ButtonResize"
        Me.ButtonResize.Size = New System.Drawing.Size(38, 40)
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
        Me.CloseButton.Location = New System.Drawing.Point(534, 0)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(38, 40)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'TextBoxNumber
        '
        Me.TextBoxNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNumber.Location = New System.Drawing.Point(245, 70)
        Me.TextBoxNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNumber.Name = "TextBoxNumber"
        Me.TextBoxNumber.Size = New System.Drawing.Size(87, 20)
        Me.TextBoxNumber.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(184, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Number :"
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name.ForeColor = System.Drawing.Color.White
        Me.Name.Location = New System.Drawing.Point(29, 72)
        Me.Name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(41, 13)
        Me.Name.TabIndex = 39
        Me.Name.Text = "Name :"
        '
        'TextBoxName
        '
        Me.TextBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(81, 70)
        Me.TextBoxName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(87, 20)
        Me.TextBoxName.TabIndex = 38
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.FlatAppearance.BorderSize = 0
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.Location = New System.Drawing.Point(511, 63)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(48, 54)
        Me.ButtonSave.TabIndex = 37
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAdd.FlatAppearance.BorderSize = 0
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonAdd.Image = CType(resources.GetObject("ButtonAdd.Image"), System.Drawing.Image)
        Me.ButtonAdd.Location = New System.Drawing.Point(398, 63)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(48, 54)
        Me.ButtonAdd.TabIndex = 36
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDelete.FlatAppearance.BorderSize = 0
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
        Me.ButtonDelete.Location = New System.Drawing.Point(450, 63)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(48, 54)
        Me.ButtonDelete.TabIndex = 35
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEdit.FlatAppearance.BorderSize = 0
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonEdit.Image = CType(resources.GetObject("ButtonEdit.Image"), System.Drawing.Image)
        Me.ButtonEdit.Location = New System.Drawing.Point(511, 63)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(48, 54)
        Me.ButtonEdit.TabIndex = 34
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'TextBoxMail
        '
        Me.TextBoxMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMail.Location = New System.Drawing.Point(81, 102)
        Me.TextBoxMail.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxMail.Name = "TextBoxMail"
        Me.TextBoxMail.Size = New System.Drawing.Size(251, 20)
        Me.TextBoxMail.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Gmail :"
        '
        'DataGridViewOperator
        '
        Me.DataGridViewOperator.AllowUserToAddRows = False
        Me.DataGridViewOperator.AllowUserToDeleteRows = False
        Me.DataGridViewOperator.AllowUserToResizeColumns = False
        Me.DataGridViewOperator.AllowUserToResizeRows = False
        Me.DataGridViewOperator.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewOperator.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.DataGridViewOperator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOperator.Location = New System.Drawing.Point(0, 196)
        Me.DataGridViewOperator.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewOperator.Name = "DataGridViewOperator"
        Me.DataGridViewOperator.ReadOnly = True
        Me.DataGridViewOperator.RowHeadersWidth = 51
        Me.DataGridViewOperator.RowTemplate.Height = 24
        Me.DataGridViewOperator.Size = New System.Drawing.Size(572, 340)
        Me.DataGridViewOperator.TabIndex = 44
        '
        'TableOperator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(572, 536)
        Me.Controls.Add(Me.DataGridViewOperator)
        Me.Controls.Add(Me.TextBoxMail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.PanelMenusFerramentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        'Me.Name = "TableOperator"
        Me.Text = "Table Operator"
        Me.PanelMenusFerramentas.ResumeLayout(False)
        CType(Me.DataGridViewOperator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMenusFerramentas As Panel
    Friend WithEvents ButtonMinimize As Button
    Friend WithEvents ButtonResize As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents TextBoxNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Name As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents TextBoxMail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewOperator As DataGridView
End Class
