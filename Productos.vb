Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class Productos

    Private dbConnection As New ConexionBasedeDatos()
    Private ConexionDB As MySqlConnection
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionDB = Module1.ConexionDB()
        'cargar el datagridview con los datos del dataset
        Dim SQL As String
        SQL = "SELECT * from productos"
        dgvProductos.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub

    Private Sub limpiarCampos()
        Me.txtProductoID.Text = ""
        Me.txtProveedorID.Text = ""
        Me.txtNombre.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtCompra.Text = ""
        Me.txtGanancia.Text = ""
        Me.txtVenta.Text = ""
        Me.txtStock.Text = ""
        Me.txtStockMin.Text = ""
        Me.txtNombre.Focus()
    End Sub

    Private Sub bloquearCampos()
        Me.txtNombre.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.txtCompra.Enabled = False
        Me.txtGanancia.Enabled = False
        Me.txtVenta.Enabled = False
        Me.txtStock.Enabled = False
        Me.txtStockMin.Enabled = False
    End Sub

    Private Sub habilitarCampos()
        Me.txtNombre.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.txtCompra.Enabled = True
        Me.txtGanancia.Enabled = True
        Me.txtVenta.Enabled = True
        Me.txtStock.Enabled = True
        Me.txtStockMin.Enabled = True
        Me.txtNombre.Focus()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
        habilitarCampos()
    End Sub

    Private Function ValidarCampos() As Boolean
        If txtNombre.Text = "" Then
            MessageBox.Show("Digite el nombre del producto")
            txtNombre.Focus()
            Return False
        End If
        If txtProveedorID.Text = "" Then
            MessageBox.Show("Digite el Id del proveedor")
            txtProveedorID.Focus()
            Return False
        End If
        If txtDescripcion.Text = "" Then
            MessageBox.Show("Digite la descripción del producto")
            txtDescripcion.Focus()
            Return False
        End If
        If txtCompra.Text = "" Then
            MessageBox.Show("Digite el Precio de compra del producto")
            txtCompra.Focus()
            Return False
        End If
        If txtGanancia.Text = "" Then
            MessageBox.Show("Digite el porcentaje de ganancia del producto")
            txtGanancia.Focus()
            Return False
        End If
        If txtVenta.Text = "" Then
            MessageBox.Show("Digite el precio de venta del producto")
            txtVenta.Focus()
            Return False
        End If
        If txtStock.Text = "" Then
            MessageBox.Show("Digite la cantidad en Stock del producto")
            txtStock.Focus()
            Return False
        End If
        If txtStockMin.Text = "" Then
            MessageBox.Show("Digite la cantidad del Stock Mínimo del producto")
            txtStockMin.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub GuardarProducto()
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
            SQL = "SELECT id_producto FROM productos WHERE id_producto = @id_producto"
            cmd.CommandText = SQL
            cmd.Parameters.AddWithValue("@id_producto", txtProductoID.Text)

            ' Ejecutar consulta de verificación
            Dim exists As Boolean = cmd.ExecuteScalar() IsNot Nothing

            If exists Then
                var = "Actualizado"
                ' Sentencia SQL para actualizar
                SQL = "UPDATE productos SET nombre=@nombre, descripcion=@descripcion, precio_compra=@precio_compra, porcentaje_ganancia=@porcentaje_ganancia, precio_venta=@precio_venta, stock=@stock, stock_minimo=@stock_minimo, id_proveedor=@id_proveedor WHERE id_producto=@id_producto"
            Else
                var = "Guardado"
                ' Sentencia SQL para insertar
                SQL = "INSERT INTO productos (nombre, descripcion, precio_compra, porcentaje_ganancia, precio_venta, stock, stock_minimo, id_proveedor) VALUES (@nombre, @descripcion, @precio_compra, @porcentaje_ganancia, @precio_venta, @stock, @stock_minimo, @id_proveedor)"
            End If

            ' Asignar el comando de SQL actualizado
            cmd.CommandText = SQL

            ' Asignar los parámetros para evitar SQL Injection
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)
            cmd.Parameters.AddWithValue("@precio_compra", txtCompra.Text)
            cmd.Parameters.AddWithValue("@porcentaje_ganancia", txtGanancia.Text)
            cmd.Parameters.AddWithValue("@precio_venta", txtVenta.Text)
            cmd.Parameters.AddWithValue("@stock", txtStock.Text)
            cmd.Parameters.AddWithValue("@stock_minimo", txtStockMin.Text)
            cmd.Parameters.AddWithValue("@id_proveedor", txtProveedorID.Text)
            If exists Then
                cmd.Parameters.AddWithValue("@id_producto", txtProductoID.Text)
            End If

            ' Ejecutar el comando
            cmd.ExecuteNonQuery()
        End Using

        ' Mensaje de confirmación
        MessageBox.Show("Registro " & var)

        ' Actualizar el DataGridView
        Dim consultaSQL As String = "SELECT * FROM productos ORDER BY nombre"
        dgvProductos.DataSource = cargar_grid(consultaSQL, ConexionDB)
        bloquearCampos()
    End Sub

    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        bloquearCampos()
        ' Verifica que la fila seleccionada sea válida (que no sea el encabezado)
        If e.RowIndex >= 0 Then
            ' Obtiene la fila seleccionada
            Dim row As DataGridViewRow = dgvProductos.Rows(e.RowIndex)

            ' Asigna el ID del proveedor al TextBox idProveedor
            txtProductoID.Text = row.Cells("id_producto").Value.ToString()
            txtProveedorID.Text = row.Cells("id_proveedor").Value.ToString()

            ' Carga los demás datos en los TextBox correspondientes
            txtNombre.Text = row.Cells("nombre").Value.ToString()
            txtDescripcion.Text = row.Cells("descripcion").Value.ToString()
            txtCompra.Text = row.Cells("precio_compra").Value.ToString()
            txtGanancia.Text = row.Cells("porcentaje_ganancia").Value.ToString()
            txtVenta.Text = row.Cells("precio_venta").Value.ToString()
            txtStock.Text = row.Cells("stock").Value.ToString()
            txtStockMin.Text = row.Cells("stock_minimo").Value.ToString()

        End If
    End Sub
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If txtProveedorID.Text = "" Then
            MessageBox.Show("Seleccione un producto")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el registro?", "Sistema de Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

            Exit Sub
        End If
        Dim SQL As String
        SQL = "delete from producto WHERE id_producto = '" & txtProductoID.Text & "'"
        Dim cmd As New MySqlCommand(SQL, ConexionDB)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro borrado")
        btnNuevo_Click(Nothing, Nothing)
        SQL = "SELECT * from productos order by nombre"
        dgvProductos.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarProducto()
    End Sub
End Class