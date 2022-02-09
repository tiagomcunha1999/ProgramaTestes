Public Class Testes

    Private objBanco As New SQLControlador2


    Private Sub Testes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestesFinalDataSet.Helmets' table. You can move, or remove it, as needed.
        Me.HelmetsTableAdapter.Fill(Me.TestesFinalDataSet.Helmets)
        objBanco.Conectar()

        Dim ds As DataSet = objBanco.ExecuteQuery("SELECT * FROM dbo.TestsLines ")
        dvgTestes.DataSource = ds.Tables(0)

        objBanco.Fechar()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub AdiocionarTeste_Click(sender As Object, e As EventArgs) Handles AdiocionarTeste.Click
        ''NewTest.Show()

        ReportAnalysisFinal.TestID = TestID.Text
        ReportAnalysisFinal.Show()
    End Sub



    Private Sub IDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TestID.SelectedIndexChanged
        Try
            objBanco.Conectar()

            Dim ds As DataSet = objBanco.ExecuteQuery("SELECT * FROM dbo.TestsLines WHERE TestID LIKE '%" & TestID.Text & "%'")
            dvgTestes.DataSource = ds.Tables(0)
            objBanco.Fechar()

        Catch ex As Exception

            objBanco.Fechar()
            MessageBox.Show(ex.Message)
        End Try

        Try
            objBanco.Conectar()

            Dim ds2 As DataSet = objBanco.ExecuteQuery("SELECT * FROM dbo.Helmets WHERE ID LIKE '%" & TestID.Text & "%'")

            TextBoxLocal.Text = ds2.Tables(0).Rows(0).Item(8).ToString()
            TextBoxModel.Text = ds2.Tables(0).Rows(0).Item(1).ToString()
            TextBoxTestType.Text = ds2.Tables(0).Rows(0).Item(3).ToString()
            TextBoxStatus.Text = ds2.Tables(0).Rows(0).Item(9).ToString()
            TextBoxDate.Text = ds2.Tables(0).Rows(0).Item(5).ToString()
            TextBoxHelmet.Text = ds2.Tables(0).Rows(0).Item(4).ToString()

            objBanco.Fechar()

        Catch ex As Exception

            objBanco.Fechar()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class