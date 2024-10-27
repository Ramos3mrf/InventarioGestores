Imports System.Data.Common
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
        Hide()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmCerrarSesion.Click
        login.Show()
        Me.Hide()
    End Sub

    'Public Sub AbrirHijo(proveedoresFormulario As Form)
    '    ' Cerrar cualquier formulario hijo que ya esté abierto en el panel
    '    For Each form As Form In Me.MdiChildren
    '        form.Close()
    '    Next

    '    ' Configurar el formulario hijo
    '    proveedoresFormulario.TopLevel = False ' Indica que el formulario no es una ventana superior
    '    proveedoresFormulario.FormBorderStyle = FormBorderStyle.None ' Quitar bordes
    '    proveedoresFormulario.Dock = DockStyle.Fill ' Llenar todo el panel

    '    ' Agregar el formulario hijo al panel contenedor y mostrarlo
    '    PanelContenedor.Controls.Add(proveedoresFormulario)
    '    PanelContenedor.Tag = proveedoresFormulario
    '    proveedoresFormulario.MdiParent = Me ' Establecer el formulario principal como contenedor MDI
    '    proveedoresFormulario.Show()
    'End Sub


    Private Sub tsmCatPro_Click(sender As Object, e As EventArgs) Handles tsmCatPro.Click
        Dim proveedoresFormulario As New Proveedores()
        proveedoresFormulario.Show()
    End Sub

    Private Sub tsmUsuarios_Click(sender As Object, e As EventArgs) Handles tsmUsuarios.Click
        Dim usuarioFormulario As New Usuarios()
        usuarioFormulario.Show()
    End Sub

    Private Sub tsmCatcli_Click(sender As Object, e As EventArgs) Handles tsmCatCli.Click
        Dim ClientesForm As New Clientes()
        ClientesForm.Show()
    End Sub
End Class
