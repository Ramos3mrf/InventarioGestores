﻿Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient


Public Class MenuPrincipal
    Public Property UserRole As String
    Private dbConnection As New ConexionBasedeDatos()

    Public Sub New()
        InitializeComponent()
        Me.IsMdiContainer = True
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsslRol.Text = "Rol: " & Grol

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        login.Show()
        Me.Hide()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmCerrarSesion.Click
        login.Show()
        Me.Hide()
    End Sub


    Private Sub tsmCatPro_Click(sender As Object, e As EventArgs) Handles tsmCatPro.Click
        Dim proveedoresFormulario As New Proveedores()
        proveedoresFormulario.Show()
    End Sub

    Private Sub tsmUsuarios_Click(sender As Object, e As EventArgs) Handles tsmUsuarios.Click
        Dim usuarioFormulario As New Usuarios()
        usuarioFormulario.Show()
    End Sub
    Private Sub tsmCatProd_Click(sender As Object, e As EventArgs) Handles tsmCatProd.Click
        Dim productosForm As New Productos()
        productosForm.Show()
    End Sub
    Private Sub tsmCatcli_Click(sender As Object, e As EventArgs) Handles tsmCatCli.Click
        Dim ClientesForm As New Clientes()
        ClientesForm.Show()
    End Sub

    Private Sub tsmCompras_Click(sender As Object, e As EventArgs) Handles tsmCompras.Click
        Dim ComprasForm As New Compras()
        ComprasForm.Show()
    End Sub

    Private Sub tsmVentas_Click(sender As Object, e As EventArgs) Handles tsmVentas.Click
        Dim VentasForm As New Ventas()
        VentasForm.Show()
    End Sub

    Private Sub tlsDetalleCompra_Click(sender As Object, e As EventArgs) Handles tlsDetalleCompra.Click
        Dim compraNuevaProd As New detalle_compra()
        compraNuevaProd.Show()
    End Sub

    Private Sub tlsDetalleVenta_Click(sender As Object, e As EventArgs) Handles tlsDetalleVenta.Click
        Dim clienteCompra As New detalle_venta()
        clienteCompra.Show()
    End Sub

    Private Sub BuscarCompraPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarCompraPorFechaToolStripMenuItem.Click
        Dim reporteCompraFechas As New buscarFechaCompra()
        reporteCompraFechas.Show()
    End Sub

    Private Sub BuscarVentaPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarVentaPorFechaToolStripMenuItem.Click
        Dim reporteVentaFechas As New buscarFechaVenta()
        reporteVentaFechas.Show()
    End Sub
End Class
