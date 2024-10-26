Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class MenuPrincipal
    Private dbConnection As New ConexionBasedeDatos()
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        login.Show()
        Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        login.Show()
        Me.Hide()
    End Sub

End Class
