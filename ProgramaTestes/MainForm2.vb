Public Class MainForm2


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


    'Fim do código para poder arrastar aplicação 





    Private Sub PainelDosButoes(sender As Object, e As PaintEventArgs) Handles PanelMenus.Paint

    End Sub

    Private Sub PainelFerramentas(sender As Object, e As PaintEventArgs) Handles PanelMenusFerramentas.Paint


    End Sub







    'Codigo para maximizar, minimizar e fechar a aplicação


    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub


    Private Sub ButtonMaximize_Click(sender As Object, e As EventArgs) Handles ButtonResize.Click

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



    'Fim do codiogo para maximizar, minimizar e fechar a aplicação







    Private Sub AbrirFormEmPainel(ByVal Formhijo As Object)

        If Me.PainelPrincipal.Controls.Count > 0 Then
            Me.PainelPrincipal.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PainelPrincipal.Controls.Add(fh)
        Me.PainelPrincipal.Tag = fh
        fh.Show()

    End Sub





    'BOTOES MENU PRINCIPAIS 

    Private Sub ButtonVerTestes_Click(sender As Object, e As EventArgs) Handles ButtonTestes.Click
        AbrirFormEmPainel(New Testes)

    End Sub

    Private Sub ButtonInformacao_Click(sender As Object, e As EventArgs) Handles ButtonInformacao.Click
        AbrirFormEmPainel(New InfoDiaria)

    End Sub

    Private Sub ButtonAnalises_Click(sender As Object, e As EventArgs) Handles ButtonAnalises.Click
        AbrirFormEmPainel(New ReadTeste)
    End Sub

    Private Sub ButtonRelatorio_Click(sender As Object, e As EventArgs) Handles ButtonRelatorio.Click
        ReportView.Show()
    End Sub

    Private Sub ButtonTabelas_Click(sender As Object, e As EventArgs)
        AbrirFormEmPainel(New Tables)
    End Sub

    Private Sub PainelPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles PainelPrincipal.Paint

    End Sub



    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub



    'BOTOES MENU PRINCIPAIS FIM







End Class
