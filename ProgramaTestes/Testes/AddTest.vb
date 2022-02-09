Imports System.Data.SqlClient

Public Class AddTest

    Private objBanco As New SQLControlador2
    Private Sub AddTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection

        conn.ConnectionString = ("Data Source = TIAGO\SQLEXPRESS; INITIAL CATALOG = TestesFinal; USER ID = Admin; PASSWORD = Admin;")

        conn.Open()

        Dim strsql As String

        strsql = "Select top (1) ID from dbo.Helmets Order By ID desc"

        Dim cmd As New SqlCommand(strsql, conn)

        Dim myreader As SqlDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()

        LastTestID.Text = myreader("ID")


        conn.Close()
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

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Try
            objBanco.Conectar()

            Dim ds As DataSet = objBanco.ExecuteQuery("INSERT INTO dbo.Helmets(ID, 
                        Model, Date, TestType, HelmetNumber,
                        Size, Cond1, Cond2, LocalRejection, Status)
                        VALUES('" & TestIDTextBox.Text & "','" & ModelTextBox.Text & "','" & DateTextBox.Text & "',
                       '" & TestTypeTextBox.Text & "','" & HelmetNumberTextBox.Text & "','" & SizeTextBox.Text & "',
                       '" & Cond1TextBox.Text & "','" & Cond2TextBox.Text & "','" & LocalRejectionTextBox.Text & "',
                       '" & StatusTextBox.Text & "')")

            objBanco.Fechar()
            MessageBox.Show("Helmet Successfully Added")
            Me.Close()
        Catch ex As Exception
            objBanco.Fechar()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Fim do código para poder arrastar aplicação 
End Class