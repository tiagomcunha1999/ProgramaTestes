Public Class YearTable

    Private Sub YearTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disp_data()
        ButtonSave.Hide()
    End Sub



    Public Sub disp_data()

        objBanco.Conectar()

        Dim ds As DataSet = objBanco.ExecuteQuery("SELECT * FROM dbo.Year")
        DataGridViewYear.DataSource = ds.Tables(0)

        objBanco.Fechar()

    End Sub




    'Codigo para poder arrastar aplicação 

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point

    Private objBanco As New SQLControlador


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



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        Try
            If (TextBoxYear.Text = "") Then
                MessageBox.Show("Year can´t be null")
            Else
                objBanco.Conectar()

                Dim ds As DataSet = objBanco.ExecuteQuery("INSERT INTO dbo.Year(Year, StartDate, EndDate, Enable)VALUES('" & TextBoxYear.Text & "','" & TextBoxStart.Text & "','" & TextBoxEnd.Text & "','" & CheckBoxEnable.Checked & "')")

                objBanco.Fechar()

                disp_data()
            End If
        Catch ex As Exception
            objBanco.Fechar()
            MessageBox.Show(ex.Message)
        End Try


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)

        disp_data()

    End Sub

    Private Sub DataGridViewYear_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewYear.CellContentClick


    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        Try
            Dim Year As Integer = DataGridViewYear.CurrentRow.Cells(0).Value.ToString

            objBanco.Conectar()

            Dim ds As DataSet = objBanco.ExecuteQuery("DELETE FROM dbo.Year WHERE Year LIKE '%" & Year & "%'")

            objBanco.Fechar()

            disp_data()

        Catch ex As Exception
            objBanco.Fechar()
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        ButtonAdd.Hide()
        ButtonDelete.Hide()
        ButtonEdit.Hide()
        ButtonSave.Show()

        TextBoxYear.Text = DataGridViewYear.CurrentRow.Cells(0).Value.ToString

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Try
            Dim Year As Integer = DataGridViewYear.CurrentRow.Cells(0).Value.ToString

            objBanco.Conectar()

            Dim teste As String = "UPDATE dbo.Year SET Year = '" & TextBoxYear.Text & "', StartDate = '" & TextBoxStart.Text & "', EndDate = '" & TextBoxEnd.Text & "' WHERE Year = '" & Year & "'"


            Dim ds As DataSet = objBanco.ExecuteQuery("UPDATE dbo.Year SET Year = '" & TextBoxYear.Text & "', StartDate = '" & TextBoxStart.Text & "', EndDate = '" & TextBoxEnd.Text & "' WHERE Year = '" & Year & "'")

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


    End Sub

    Private Sub TextBoxStart_TextChanged(sender As Object, e As EventArgs) Handles TextBoxStart.TextChanged

    End Sub

    Private Sub TextBoxEnd_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEnd.TextChanged

    End Sub
End Class