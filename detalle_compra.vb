Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class detalle_compra

    Private dbConnection As New ConexionBasedeDatos()
    Private ConexionDB As MySqlConnection
    Private Sub dgvDetalle_compra_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle_compra.CellContentClick

    End Sub

    Private Sub detalle_compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionDB = Module1.ConexionDB()
        'cargar el datagridview con los datos del dataset
        Dim SQL As String
        SQL = "SELECT id_producto, nombre, descripcion from productos"
        dgvDetalle_compra.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub



End Class