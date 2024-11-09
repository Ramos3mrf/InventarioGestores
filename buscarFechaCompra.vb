Imports System.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop



Public Class buscarFechaCompra

    Private dbConnection As New ConexionBasedeDatos()
    Private ConexionDB As MySqlConnection
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'cargar el datagridview con los datos del dataset
        Dim SQL As String
        SQL = "SELECT * FROM compras a where fecha_compra between '" & dtpInicial.Text & "' and '" & dtpFinal.Text & "'"
        dgvComprasVer.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub

    Private Sub buscarFechaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionDB = Module1.ConexionDB
        Dim SQL As String
        SQL = "SELECT * FROM compras"
        dgvComprasVer.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        GridAExcel(dgvComprasVer)
    End Sub
End Class