Imports MySql.Data.MySqlClient
Imports System.Data.Common

Public Class Clientes
    'El objeto tipo conexión
    Private dbConnection As New ConexionBasedeDatos()
    Private ConexionDB As MySqlConnection

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionDB = Module1.ConexionDB()
        'cargar el datagridview con los datos del dataset
        Dim SQL As String
        SQL = "SELECT * from clientes"
        dgvClientes.DataSource = cargar_grid(SQL, ConexionDB)
        dgvClientes.Columns("id_cliente").Width = 50
        dgvClientes.Columns("nombre").Width = 150
    End Sub

    Private Sub limpiarCampos()
        Me.txtClienteID.Text = ""
        Me.txtNombre.Text = ""
        Me.txtDireccion.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtCorreo.Text = ""
        Me.txtNombre.Focus()
    End Sub

    Private Sub bloquearCampos()
        Me.txtNombre.Enabled = False
        Me.txtDireccion.Enabled = False
        Me.txtTelefono.Enabled = False
        Me.txtCorreo.Enabled = False
    End Sub

    Private Sub habilitarCampos()
        Me.txtNombre.Enabled = True
        Me.txtDireccion.Enabled = True
        Me.txtTelefono.Enabled = True
        Me.txtCorreo.Enabled = True
        Me.txtNombre.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
        habilitarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text = "" Then
            MessageBox.Show("Digite el nombre del cliente")
            txtNombre.Focus()
            Exit Sub
        End If
        If txtDireccion.Text = "" Then
            MessageBox.Show("Digite la dirección")
            txtDireccion.Focus()
            Exit Sub
        End If
        If txtTelefono.Text = "" Then
            MessageBox.Show("Digite el teléfono")
            txtTelefono.Focus()
            Exit Sub
        End If
        If txtCorreo.Text = "" Then
            MessageBox.Show("Digite el correo")
            txtCorreo.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Desea guardar el registro?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

            Exit Sub

        End If

        Dim SQL, var As String
        SQL = "select id_cliente from clientes WHERE id_cliente = '" & txtClienteID.Text & "'"
        Dim cmd As New MySqlCommand(SQL, ConexionDB)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        If lectura.HasRows Then
            var = "Actualizado"
            SQL = "UPDATE clientes set nombre='" & txtNombre.Text & "' " & ",direccion='" & txtDireccion.Text & "',telefono='" & txtTelefono.Text & "',email='" & txtCorreo.Text & "' where id_cliente='" & txtClienteID.Text & "'"
        Else
            var = "Guardado"
            SQL = "INSERT INTO clientes values(null,'" & txtNombre.Text & "','" & txtDireccion.Text & "','" & txtTelefono.Text & "','" & txtCorreo.Text & "')"
        End If
        lectura.Close()
        cmd.CommandText = SQL
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro " & var)
        btnNuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from clientes order by id_cliente"
        dgvClientes.DataSource = cargar_grid(SQL, ConexionDB)
        bloquearCampos()
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        bloquearCampos()
        ' Verifica que la fila seleccionada sea válida (que no sea el encabezado)
        If e.RowIndex >= 0 Then
            ' Obtiene la fila seleccionada
            Dim row As DataGridViewRow = dgvClientes.Rows(e.RowIndex)

            ' Asigna el ID del proveedor al TextBox idProveedor
            txtClienteID.Text = row.Cells("id_cliente").Value.ToString()

            ' Carga los demás datos en los TextBox correspondientes
            txtNombre.Text = row.Cells("nombre").Value.ToString()
            txtDireccion.Text = row.Cells("direccion").Value.ToString()
            txtTelefono.Text = row.Cells("telefono").Value.ToString()
            txtCorreo.Text = row.Cells("email").Value.ToString()
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If txtClienteID.Text = "" Then
            MessageBox.Show("Seleccione un cliente")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el registro?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

            Exit Sub
        End If
        Dim SQL As String
        SQL = "delete from clientes WHERE id_cliente = '" & txtClienteID.Text & "'"
        Dim cmd As New MySqlCommand(SQL, ConexionDB)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro borrado")
        btnNuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from clientes order by nombre"
        dgvClientes.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


End Class