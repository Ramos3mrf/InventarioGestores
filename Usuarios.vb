Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Usuarios

    'El objeto tipo conexión
    Private dbConnection As New ConexionBasedeDatos()
    Private ConexionDB As MySqlConnection

    Public Sub Usuarios()
        InitializeComponent()
    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionDB = Module1.ConexionDB()
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

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
        habilitarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Validar campos
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("Digite el nombre del Usuario")
            txtNombre.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtContrasena.Text) Then
            MessageBox.Show("Digite la contraseña")
            txtContrasena.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtRol.Text) Then
            MessageBox.Show("Digite el rol")
            txtRol.Focus()
            Return
        End If

        ' Confirmar acción
        If MessageBox.Show("Desea guardar el registro?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        ' Preparar la consulta SQL
        Dim SQL As String
        Dim var As String

        If String.IsNullOrWhiteSpace(txtUsuarioID.Text) Then
            ' Insertar nuevo usuario
            SQL = "INSERT INTO usuarios (username, password, rol) VALUES (@username, MD5(@password), @rol)"
            var = "Guardado"
        Else
            ' Actualizar usuario existente
            SQL = "UPDATE usuarios SET username = @username, password = MD5(@password), rol = @rol WHERE id_usuario = @id_usuario"
            var = "Actualizado"
        End If

        ' Ejecutar la consulta
        Using cmd As New MySqlCommand(SQL, ConexionDB)
            cmd.Parameters.AddWithValue("@username", txtNombre.Text)
            cmd.Parameters.AddWithValue("@password", txtContrasena.Text)
            cmd.Parameters.AddWithValue("@rol", txtRol.Text)

            If Not String.IsNullOrWhiteSpace(txtUsuarioID.Text) Then
                cmd.Parameters.AddWithValue("@id_usuario", txtUsuarioID.Text)
            End If

            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Registro " & var)
        btnNuevo_Click(Nothing, Nothing)

        ' Actualizar el DataGridView
        Dim query As String = "SELECT * FROM usuarios ORDER BY username"
        dgvUsuarios.DataSource = cargar_grid(query, ConexionDB)

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

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
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
        SQL = "SELECT * from usuarios order by username"
        dgvUsuarios.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private mostrarPass As Boolean = False

    Private Sub lookP_Click(sender As Object, e As EventArgs) Handles lookP.Click
        If mostrarPass Then
            ' Ocultar contraseña
            txtContrasena.PasswordChar = "*"
            mostrarPass = False
        Else
            ' Mostrar contraseña
            txtContrasena.PasswordChar = vbNullChar
            mostrarPass = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If mostrarPass Then
            ' Ocultar contraseña
            txtContrasena.PasswordChar = "*"
            PictureBox1.Image = My.Resources.ocultar ' Asumir que tienes imágenes "ocultar.png" y "mostrar.png"
            ToolTip1.SetToolTip(PictureBox1, "Ocultar")
        Else
            ' Mostrar contraseña
            txtContrasena.PasswordChar = vbNullChar
            PictureBox1.Image = My.Resources.mostrar
            ToolTip1.SetToolTip(PictureBox1, "Mostrar")
        End If
        mostrarPass = Not mostrarPass
    End Sub
End Class