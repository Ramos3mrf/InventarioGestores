Imports System.Data.Common
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class buscarFechaVenta
    Private dbConnection As New ConexionBasedeDatos()
    Private ConexionDB As MySqlConnection
    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'cargar el datagridview con los datos del dataset
        Dim SQL As String
        SQL = "SELECT * FROM ventas a where fecha_venta between '" & dtpInicio.Text & "' and '" & dtpFinal.Text & "'"
        dgvReporteVentas.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub
    Private Sub buscarFechaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionDB = Module1.ConexionDB
        Dim SQL As String
        SQL = "SELECT * FROM ventas"
        dgvReporteVentas.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        GridAExcel(dgvReporteVentas)
    End Sub


End Class