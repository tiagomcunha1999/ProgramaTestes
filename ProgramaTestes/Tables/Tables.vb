Public Class Tables

    Private Sub Testes_Click(sender As Object, e As EventArgs) 
        YearTable.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ModelTable.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SizeTable.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TableOperator.Show()
    End Sub


    Private Sub Tables_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class