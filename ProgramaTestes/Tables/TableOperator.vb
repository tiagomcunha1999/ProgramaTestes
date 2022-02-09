Public Class TableOperator

    Private objBanco As New SQLControlador2
    Private Sub TableOperator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disp_data()
        ButtonSave.Hide()
    End Sub
    Public Sub disp_data()

        objBanco.Conectar()

        Dim ds As DataSet = objBanco.ExecuteQuery("SELECT * FROM dbo.Operator")
        DataGridViewOperator.DataSource = ds.Tables(0)

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
            Dim Ope As String = DataGridViewOperator.CurrentRow.Cells(0).Value.ToString

            objBanco.Conectar()

            Dim ds As DataSet = objBanco.ExecuteQuery("DELETE FROM dbo.Operator WHERE Operator LIKE '%" & Ope & "%'")

            objBanco.Fechar()

            disp_data()

        Catch ex As Exception
            objBanco.Fechar()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Try
            If (TextBoxName.Text = "" And TextBoxNumber.Text = "" And TextBoxMail.Text = "") Then
                MessageBox.Show("Value can not be null")
            Else
                objBanco.Conectar()

                Dim ds As DataSet = objBanco.ExecuteQuery("INSERT INTO dbo.Operator(Operator, Email, Number)VALUES('" & TextBoxName.Text & "','" & TextBoxMail.Text & "','" & TextBoxNumber.Text & "')")

                objBanco.Fechar()

                disp_data()
            End If
        Catch ex As Exception
            objBanco.Fechar()
            MessageBox.Show(ex.Message)
        End Try
        TextBoxName.Text = ""
        TextBoxMail.Text = ""
        TextBoxNumber.Text = ""
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Dim Name As String = DataGridViewOperator.CurrentRow.Cells(0).Value.ToString

            objBanco.Conectar()


            Dim ds As DataSet = objBanco.ExecuteQuery("UPDATE dbo.Operator SET Operator = '" & TextBoxName.Text & "', Email = '" & TextBoxMail.Text & "', Number = '" & TextBoxNumber.Text & "' WHERE Operator = '" & Name & "'")

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

        TextBoxName.Text = ""
        TextBoxMail.Text = ""
        TextBoxNumber.Text = ""
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        ButtonAdd.Hide()
        ButtonDelete.Hide()
        ButtonEdit.Hide()
        ButtonSave.Show()

        TextBoxName.Text = DataGridViewOperator.CurrentRow.Cells(0).Value.ToString
        TextBoxMail.Text = DataGridViewOperator.CurrentRow.Cells(1).Value.ToString
        TextBoxNumber.Text = DataGridViewOperator.CurrentRow.Cells(2).Value.ToString
    End Sub

End Class