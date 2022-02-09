Imports System.Data.SqlClient

Public Class InfoDiaria

    Private objBanco As New SQLControlador
    Private Sub Testes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        objBanco.Conectar()

        Dim ds As DataSet = objBanco.ExecuteQuery("SELECT * FROM dbo.tDailyInformation Order by Date desc")
        dgvTestes.DataSource = ds.Tables(0)

        objBanco.Fechar()


    End Sub

    ' 


    Private Sub dgvTestes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonInfo.Click
        If ButtonInfo.Text = "FY Total" Then
            objBanco.Conectar()

            Dim ds As DataSet = objBanco.ExecuteQuery("SELECT SUM (TotalProduction), SUM(TotalTests) FROM dbo.tDailyInformation Where Date  BETWEEN  '2019-10-01' and GETDATE()")


            ButtonInfo.Text = ds.Tables(0).Rows(0).Item(0).ToString()

            objBanco.Fechar()

        Else
            ButtonInfo.Text = "FY Total"
        End If
    End Sub

    Private Sub dgvTestes_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTestes.CellContentClick

    End Sub
End Class