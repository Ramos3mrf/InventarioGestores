Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient


Public Class Compras


    Private dbConnection As New ConexionBasedeDatos()
    Private ConexionDB As MySqlConnection
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionDB = conectar()
        'cargar el datagridview con los datos del dataset
        Dim SQL As String
        SQL = "SELECT * from compras"
        dgvCompras.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub

    Private Sub limpiarCampos()
        Me.txtCompraID.Text = ""
        Me.txtProveedorID.Text = ""
        Me.txtFecha.Text = ""
        Me.txtTotal.Text = ""
        Me.txtFecha.Focus()
    End Sub

    Private Sub bloquearCampos()
        Me.txtCompraID.Enabled = False
        Me.txtProveedorID.Enabled = False
        Me.txtFecha.Enabled = False
        Me.txtTotal.Enabled = False
    End Sub

    Private Sub habilitarCampos()
        Me.txtCompraID.Enabled = True
        Me.txtProveedorID.Enabled = True
        Me.txtFecha.Enabled = True
        Me.txtTotal.Enabled = True
        Me.txtFecha.Focus()
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
        habilitarCampos()
    End Sub

    Private Function ValidarCampos() As Boolean
        If txtCompraID.Text = "" Then
            MessageBox.Show("Digite el Id de la compra")
            txtCompraID.Focus()
            Return False
        End If
        If txtProveedorID.Text = "" Then
            MessageBox.Show("Digite el Id del proveedor")
            txtProveedorID.Focus()
            Return False
        End If
        If txtFecha.Text = "" Then
            MessageBox.Show("Digite la fecha de la compra")
            txtFecha.Focus()
            Return False
        End If
        If txtTotal.Text = "" Then
            MessageBox.Show("Digite el total de la compra")
            txtTotal.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub GuardarCompra()
        ' Validar campos
        If Not ValidarCampos() Then Exit Sub

        ' Confirmación de guardado
        If MessageBox.Show("Desea guardar el registro?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        ' Determinar si se trata de una actualización o una inserción
        Dim SQL As String
        Dim var As String
        Using cmd As New MySqlCommand()
            cmd.Connection = ConexionDB

            ' Consulta para verificar si el producto existe
            SQL = "SELECT id_compra FROM compras WHERE id_compra = @id_compra"
            cmd.CommandText = SQL
            cmd.Parameters.AddWithValue("@id_compra", txtCompraID.Text)

            ' Ejecutar consulta de verificación
            Dim exists As Boolean = cmd.ExecuteScalar() IsNot Nothing

            If exists Then
                var = "Actualizado"
                ' Sentencia SQL para actualizar
                SQL = "UPDATE compras SET id_proveedor=@id_proveedor, fecha_compra=@fecha, total=@total WHERE id_compra=@id_compra"
            Else
                var = "Guardado"
                ' Sentencia SQL para insertar
                SQL = "INSERT INTO compras (id_proveedor, fecha_compra, total ) VALUES (@id_proveedor, @fecha_compra, @total)"
            End If

            ' Asignar el comando de SQL actualizado
            cmd.CommandText = SQL

            ' Asignar los parámetros para evitar SQL Injection
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@fecha", txtFecha.Text)
            cmd.Parameters.AddWithValue("@total", txtTotal.Text)
            cmd.Parameters.AddWithValue("@id_proveedor", txtProveedorID.Text)
            If exists Then
                cmd.Parameters.AddWithValue("@id_compra", txtCompraID.Text)
            End If

            ' Ejecutar el comando
            cmd.ExecuteNonQuery()
        End Using

        ' Mensaje de confirmación
        MessageBox.Show("Registro " & var)

        ' Actualizar el DataGridView
        Dim consultaSQL As String = "SELECT * FROM compras ORDER BY fecha_compra"
        dgvCompras.DataSource = cargar_grid(consultaSQL, ConexionDB)
        bloquearCampos()
    End Sub

    Private Sub dgvCompras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompras.CellClick
        bloquearCampos()
        ' Verifica que la fila seleccionada sea válida (que no sea el encabezado)
        If e.RowIndex >= 0 Then
            ' Obtiene la fila seleccionada
            Dim row As DataGridViewRow = dgvCompras.Rows(e.RowIndex)

            ' Asigna el ID del proveedor al TextBox idProveedor
            txtCompraID.Text = row.Cells("id_compra").Value.ToString()
            txtProveedorID.Text = row.Cells("id_proveedor").Value.ToString()

            ' Carga los demás datos en los TextBox correspondientes
            txtFecha.Text = row.Cells("fecha_compra").Value.ToString()
            txtTotal.Text = row.Cells("total").Value.ToString()

        End If
    End Sub
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If txtCompraID.Text = "" Then
            MessageBox.Show("Seleccione una compra")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el registro?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

            Exit Sub
        End If
        Dim SQL As String
        SQL = "delete from compras WHERE id_compra = '" & txtCompraID.Text & "'"
        Dim cmd As New MySqlCommand(SQL, ConexionDB)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro borrado")
        btnNuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from compras order by fecha_compra"
        dgvCompras.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarCompra()
    End Sub

End Class
