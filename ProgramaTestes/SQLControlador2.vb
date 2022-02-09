Imports System.Data.SqlClient

Public Class SQLControlador2
    Private objConexao As SqlClient.SqlConnection

    'Codigo para conectar à base de dados
    Public Sub Conectar()
        Try
            objConexao = New SqlClient.SqlConnection("Data Source = TIAGO\SQLEXPRESS; INITIAL CATALOG = TestesFinal; USER ID = Admin; PASSWORD = Admin;")

            objConexao.Open()


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Fechar()
        Try
            If Not IsNothing(objConexao) Then
                If objConexao.State = ConnectionState.Open Then
                    objConexao.Close()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Codigo para executar querys
    Public Function ExecuteQuery(ByVal Command As String) As DataSet
        Dim ds As New DataSet
        Dim objDataAdapter As New SqlDataAdapter
        Dim objCommand As New SqlClient.SqlCommand

        Try
            objCommand = objConexao.CreateCommand
            objCommand.CommandText = Command

            objDataAdapter = New SqlClient.SqlDataAdapter(objCommand)
            objDataAdapter.Fill(ds)
        Catch ex As Exception
            Throw ex
        End Try
        Return ds
    End Function
End Class
