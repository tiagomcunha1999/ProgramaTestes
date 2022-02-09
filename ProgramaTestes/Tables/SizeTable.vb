Public Class SizeTable

    Private objBanco As New SQLControlador2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disp_data()
        ButtonSave.Hide()
    End Sub

    Public Sub disp_data()

        objBanco.Conectar()

        Dim ds As DataSet = objBanco.ExecuteQuery("SELECT * FROM dbo.Size")
        DataGridViewSize.DataSource = ds.Tables(0)

        objBanco.Fechar()

    End Sub


    'Codigo para poder arrastar aplicação 

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point

    Private Sub MouseDown(sender As Object, e As MouseEventArgs) Handles PanelMenusFerramentas.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Private Sub MouseUp(sender As Object, e As MouseEventArgs) Handles PanelMenusFerramentas.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub


    Private Sub MouseMove(sender As Object, e As MouseEventArgs) Handles PanelMenusFerramentas.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub ButtonResize_Click(sender As Object, e As EventArgs) Handles ButtonResize.Click

        If WindowState = vbNormal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub ButtonMinimize_Click(sender As Object, e As EventArgs) Handles ButtonMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelMenusFerramentas_DoubleClick(sender As Object, e As EventArgs) Handles PanelMenusFerramentas.DoubleClick

        If WindowState = vbNormal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    'Fim do código para poder arrastar aplicação 


    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try
            Dim Size As String = DataGridViewSize.CurrentRow.Cells(0).Value.ToString

            objBanco.Conectar()

            Dim ds As DataSet = objBanco.ExecuteQuery("DELETE FROM dbo.Size WHERE Size LIKE '%" & Size & "%'")

            objBanco.Fechar()

            disp_data()

        Catch ex As Exception
            objBanco.Fechar()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Try
            If (TextBoxSize.Text = "") Then
                MessageBox.Show("Size can´t be null")
            Else
                objBanco.Conectar()

                Dim ds As DataSet = objBanco.ExecuteQuery("INSERT INTO dbo.Size(Size)VALUES('" & TextBoxSize.Text & "')")

                objBanco.Fechar()

                disp_data()
            End If
        Catch ex As Exception
            objBanco.Fechar()
            MessageBox.Show(ex.Message)
        End Try
        TextBoxSize.Text = ""
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Dim Size As String = DataGridViewSize.CurrentRow.Cells(0).Value.ToString

            objBanco.Conectar()


            Dim ds As DataSet = objBanco.ExecuteQuery("UPDATE dbo.Size SET Size = '" & TextBoxSize.Text & "' WHERE Size = '" & Size & "'")

            objBanco.Fechar()

            disp_data()

            ButtonAdd.Show()
            ButtonDelete.Show()
            ButtonEdit.Show()
            ButtonSave.Hide()

        Catch ex As Exception

            objBanco.Fechar()
            MessageBox.Show(ex.Message)

        End Try

        TextBoxSize.Text = ""
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        ButtonAdd.Hide()
        ButtonDelete.Hide()
        ButtonEdit.Hide()
        ButtonSave.Show()

        TextBoxSize.Text = DataGridViewSize.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub TextBoxModel_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSize.TextChanged

    End Sub

    Private Sub DataGridViewModels_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSize.CellContentClick

    End Sub
End Class