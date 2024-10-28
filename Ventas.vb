Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Ventas
    Private dbConnection As New ConexionBasedeDatos()
    Private ConexionDB As MySqlConnection

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionDB = conectar()
        'cargar el datagridview con los datos del dataset
        Dim SQL As String
        SQL = "SELECT * from ventas"
        dgvVentas.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub
End Class