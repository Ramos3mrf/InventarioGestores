Imports MySql.Data.MySqlClient
Imports System.Data.Common
Public Class Usuarios

    'El objeto tipo conexión
    Private dbConnection As New ConexionBasedeDatos()
    Private ConexionDB As MySqlConnection

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionDB = conectar()
        'cargar el datagridview con los datos del dataset
        Dim SQL As String
        SQL = "SELECT * from usuarios"
        dgvUsuarios.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub

    Private Sub limpiarCampos()
        Me.txtUsuarioID.Text = ""
        Me.txtNombre.Text = ""
        Me.txtContrasena.Text = ""
        Me.txtRol.Text = ""
        Me.txtNombre.Focus()
    End Sub

    Private Sub bloquearCampos()
        Me.txtNombre.Enabled = False
        Me.txtContrasena.Enabled = False
        Me.txtRol.Enabled = False
    End Sub

    Private Sub habilitarCampos()
        Me.txtNombre.Enabled = True
        Me.txtContrasena.Enabled = True
        Me.txtRol.Enabled = True
        Me.txtNombre.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)
        limpiarCampos()
        habilitarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
        If txtNombre.Text = "" Then
            MessageBox.Show("Digite el nombre del Usuario")
            txtNombre.Focus()
            Exit Sub
        End If
        If txtContrasena.Text = "" Then
            MessageBox.Show("Digite el teléfono")
            txtContrasena.Focus()
            Exit Sub
        End If
        If txtRol.Text = "" Then
            MessageBox.Show("Digite el correo")
            txtRol.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Desea guardar el registro?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

            Exit Sub

        End If

        Dim SQL, var As String
        SQL = "select id_usuario from usuarios WHERE id_usuario = '" & txtUsuarioID.Text & "'"
        Dim cmd As New MySqlCommand(SQL, ConexionDB)
        cmd.CommandType = CommandType.Text
        Dim lectura = cmd.ExecuteReader
        If lectura.HasRows Then
            var = "Actualizado"
            SQL = "UPDATE usuarios set nombre='" & txtNombre.Text & "' " & "',telefono='" & txtContrasena.Text & "',email='" & txtRol.Text & "' where id_usuairo='" & txtUsuarioID.Text & "'"
        Else
            var = "Guardado"
            SQL = "INSERT INTO usuario values(null,'" & txtNombre.Text & "','" & "','" & txtContrasena.Text & "','" & txtRol.Text & "')"
        End If
        lectura.Close()
        cmd.CommandText = SQL
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro " & var)
        btnNuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from usuarios order by nombre"
        dgvUsuarios.DataSource = cargar_grid(SQL, ConexionDB)
        bloquearCampos()
    End Sub

    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        bloquearCampos()
        ' Verifica que la fila seleccionada sea válida (que no sea el encabezado)
        If e.RowIndex >= 0 Then
            ' Obtiene la fila seleccionada
            Dim row As DataGridViewRow = dgvUsuarios.Rows(e.RowIndex)

            ' Asigna el ID del proveedor al TextBox idProveedor
            txtUsuarioID.Text = row.Cells("id_usuario").Value.ToString()

            ' Carga los demás datos en los TextBox correspondientes
            txtNombre.Text = row.Cells("username").Value.ToString()
            txtContrasena.Text = row.Cells("password").Value.ToString()
            txtRol.Text = row.Cells("rol").Value.ToString()
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs)
        If txtUsuarioID.Text = "" Then
            MessageBox.Show("Seleccione un usuario")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el registro?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

            Exit Sub
        End If
        Dim SQL As String
        SQL = "delete from usuarios WHERE id_usuario = '" & txtUsuarioID.Text & "'"
        Dim cmd As New MySqlCommand(SQL, ConexionDB)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro borrado")
        btnNuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from usuarios order by nombre"
        dgvUsuarios.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


End Class