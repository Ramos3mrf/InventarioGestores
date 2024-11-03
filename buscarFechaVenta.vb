Imports System.Data.Common
Imports MySql.Data.MySqlClient
Public Class buscarFechaVenta
    Private dbConnection As New ConexionBasedeDatos()
    Private ConexionDB As MySqlConnection

    Private Sub buscarFechaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionDB = Module1.ConexionDB
        Dim SQL As String
        SQL = "SELECT * FROM ventas"
        dgvReporteVentas.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub
End Class