<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonTestes = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(315, 191)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(226, 22)
        Me.TextBoxName.TabIndex = 0
        '
        'TextBoxPass
        '
        Me.TextBoxPass.Location = New System.Drawing.Point(315, 279)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPass.Size = New System.Drawing.Size(226, 22)
        Me.TextBoxPass.TabIndex = 1
        Me.TextBoxPass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(217, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 60)
        Me.Label2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(217, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 65)
        Me.Label1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(322, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 50)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Login"
        '
        'ButtonTestes
        '
        Me.ButtonTestes.AutoSize = True
        Me.ButtonTestes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ButtonTestes.FlatAppearance.BorderSize = 0
        Me.ButtonTestes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ButtonTestes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTestes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTestes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonTestes.Image = CType(resources.GetObject("ButtonTestes.Image"), System.Drawing.Image)
        Me.ButtonTestes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTestes.Location = New System.Drawing.Point(315, 348)
        Me.ButtonTestes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonTestes.Name = "ButtonTestes"
        Me.ButtonTestes.Size = New System.Drawing.Size(215, 56)
        Me.ButtonTestes.TabIndex = 6
        Me.ButtonTestes.Text = "login"
        Me.ButtonTestes.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CloseButton.Image = CType(resources.GetObject("CloseButton.Image"), System.Drawing.Image)
        Me.CloseButton.Location = New System.Drawing.Point(713, 0)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(91, 70)
        Me.CloseButton.TabIndex = 7
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(804, 523)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ButtonTestes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxPass)
        Me.Controls.Add(Me.TextBoxName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonTestes As Button
    Friend WithEvents CloseButton As Button
End Class
