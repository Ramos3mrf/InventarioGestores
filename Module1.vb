Imports System.Data.Common
Imports MySql.Data.MySqlClient

Module Module1
    Public GUsername, Grol As String
    Private dbConnection As New ConexionBasedeDatos()
    Public Function conectar()
        Try
            Dim ConexionBD As MySqlConnection = dbConnection.OpenConnection()
        Catch ex As MySqlException
            MessageBox.Show("Error en la conexión: " & ex.ToString)
        Finally
        End Try
        Return dbConnection.OpenConnection()
    End Function

    Function cargar_grid(ByVal sql As String, ByVal conn As MySqlConnection)
        Dim DaAdp As New MySqlDataAdapter(sql, conn)
        Dim DaSet As New DataSet
        'llenar el dataset
        DaAdp.Fill(DaSet)
        Return DaSet.Tables(0)
    End Function



End Module
