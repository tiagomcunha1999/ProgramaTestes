Public Class Testes

    Private objBanco As New SQLControlador
    Private Sub Testes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestesBdDataSet.Tests' table. You can move, or remove it, as needed.
        Me.TestsTableAdapter.Fill(Me.TestesBdDataSet.Tests)


        objBanco.Conectar()

        Dim ds As DataSet = objBanco.ExecuteQuery("SELECT * FROM dbo.TestsLines ")
        dvgTestes.DataSource = ds.Tables(0)

        objBanco.Fechar()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgTestes.CellContentClick

    End Sub

    Private Sub TestID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TestID.SelectedIndexChanged
        Try
            objBanco.Conectar()

            Dim ds As DataSet = objBanco.ExecuteQuery("SELECT * FROM dbo.TestsLines WHERE TestID LIKE '%" & TestID.Text & "%'")
            dvgTestes.DataSource = ds.Tables(0)


            objBanco.Fechar()
        Catch ex As Exception

            objBanco.Fechar()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub AdiocionarTeste_Click(sender As Object, e As EventArgs) Handles AdiocionarTeste.Click
        ''NewTest.Show()

        ReportAnalysis.TestID = TestID.Text
        ReportAnalysis.Show()
    End Sub

    Private Sub TestTypeTextBox_TextChanged(sender As Object, e As EventArgs) Handles TestTypeTextBox.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub StatusTextBox_TextChanged(sender As Object, e As EventArgs) Handles StatusTextBox.TextChanged

    End Sub
End Class