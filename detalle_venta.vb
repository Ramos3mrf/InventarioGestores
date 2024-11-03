Imports System.Data.Common
Imports MySql.Data.MySqlClient
Public Class detalle_venta


    Private dbConnection As New ConexionBasedeDatos()
    Private ConexionDB As MySqlConnection
    Private Sub dgvDetalleVenta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleVenta.CellContentClick

    End Sub

    Private Sub detalle_venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionDB = Module1.ConexionDB()

        ' Cargar el DataTable con los datos
        Dim SQL As String = "SELECT dv.cantidad, nombre as 'Nombre del producto', precio_venta as 'Precio' from productos p join detalle_ventas dv using(id_producto)"
        Dim detalleVentaTable As DataTable = cargar_grid(SQL, ConexionDB)

        ' Agregar columnas personalizadas al DataTable si no existen
        If Not detalleVentaTable.Columns.Contains("id_producto") Then
            detalleVentaTable.Columns.Add("id_producto", GetType(String))
        End If
        If Not detalleVentaTable.Columns.Contains("subtotal") Then
            detalleVentaTable.Columns.Add("subtotal", GetType(Decimal))
        End If
        If Not detalleVentaTable.Columns.Contains("id_detalle") Then
            detalleVentaTable.Columns.Add("id_detalle", GetType(Integer))
        End If


        ' Configurar el DataGridView para usar el DataTable modificado
        dgvDetalleVenta.DataSource = detalleVentaTable

        ' Configurar el ancho de las columnas
        dgvDetalleVenta.Columns("Nombre del producto").Width = 200
        dgvDetalleVenta.Columns("cantidad").Width = 70
        dgvDetalleVenta.Columns("id_detalle").Width = 80

        ' Cargar el DataGridView de Productos Cliente (izquierdo)
        SQL = "SELECT id_producto, nombre, precio_venta, stock from productos"
        dgvProdStock.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub
    Private Sub LimpiarFormulario()
        txtIDventa.Clear()
        txtTotal.Clear()
    End Sub

    Private Sub dgvProdStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProdStock.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProdStock.Rows(e.RowIndex)

            txtIDprod.Text = row.Cells("id_producto").Value.ToString()
            txtPrecioU.Text = row.Cells("precio_venta").Value.ToString()
            txtCantidad.Text = ""
            txtSubTotal.Text = ""
        End If

    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Dim cantidad As Integer
        Dim precioUnitario As Decimal

        If Integer.TryParse(txtCantidad.Text, cantidad) AndAlso Decimal.TryParse(txtPrecioU.Text, precioUnitario) Then
            txtSubTotal.Text = (cantidad * precioUnitario).ToString("F2")
        Else
            txtSubTotal.Text = ""
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtIDprod.Text <> "" AndAlso txtCantidad.Text <> "" AndAlso txtSubTotal.Text <> "" Then
            ' Obtener el DataTable desde el DataGridView
            Dim detalleVentaTable As DataTable = CType(dgvDetalleVenta.DataSource, DataTable)

            ' Generar ID de detalle (basado en la cantidad de filas + 1)
            Dim nuevoIdDetalle As Integer = detalleVentaTable.Rows.Count + 1

            ' Crear una nueva fila en el DataTable
            Dim nuevaFila As DataRow = detalleVentaTable.NewRow()

            ' Asignar valores a las columnas del DataTable y las columnas personalizadas
            nuevaFila("id_detalle") = nuevoIdDetalle
            nuevaFila("cantidad") = txtCantidad.Text
            nuevaFila("Nombre del producto") = dgvProdStock.CurrentRow.Cells("nombre").Value.ToString()
            nuevaFila("Precio") = txtPrecioU.Text

            nuevaFila("id_producto") = txtIDprod.Text
            nuevaFila("subtotal") = txtSubTotal.Text

            ' Agregar la fila al DataTable
            detalleVentaTable.Rows.Add(nuevaFila)

            ' Actualizar el total
            Dim subtotal As Decimal = Decimal.Parse(txtSubTotal.Text)
            Dim totalActual As Decimal
            Decimal.TryParse(txtTotal.Text, totalActual)
            txtTotal.Text = (totalActual + subtotal).ToString("F2")

            ' Limpiar los campos de entrada
            txtIDprod.Clear()
            txtPrecioU.Clear()
            txtCantidad.Clear()
            txtSubTotal.Clear()
        Else
            MessageBox.Show("Por favor, complete todos los campos para agregar el producto.")
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Verificar que se haya ingresado un cliente y un total válido
        If txtTotal.Text = "" OrElse txtID_Cliente.Text = "" Then
            MessageBox.Show("Por favor, complete los campos de venta.")
            Return
        End If

        ' Guardar la venta en la tabla Ventas y obtener el ID generado
        Dim idVenta As Integer = GuardarVenta(txtID_Cliente.Text, txtTotal.Text)

        ' Guardar cada producto en el detalle de la venta
        For Each row As DataGridViewRow In dgvDetalleVenta.Rows
            If Not row.IsNewRow Then
                Dim idDetalle As Integer = Integer.Parse(row.Cells("id_detalle").Value.ToString())
                Dim idProducto As Integer = Integer.Parse(row.Cells("id_producto").Value.ToString())
                Dim cantidad As Integer = Integer.Parse(row.Cells("cantidad").Value.ToString())
                Dim precioUnitario As Decimal = Decimal.Parse(row.Cells("Precio").Value.ToString())
                GuardarDetalleVenta(idDetalle, idVenta, idProducto, cantidad, precioUnitario)
            End If
        Next

        MessageBox.Show("Venta guardada exitosamente.")
        LimpiarFormulario()
    End Sub

    Private Function GuardarVenta(idCliente As String, total As String) As Integer
        ' Prepara la fecha de venta en formato adecuado para la base de datos
        Dim fechaVenta As String = DateTime.Now.ToString("yyyy-MM-dd")

        ' Construye la consulta INSERT con parámetros para evitar la inyección SQL
        Dim sql = "INSERT INTO Ventas (fecha_venta, id_cliente, total) VALUES (@fechaVenta, @idCliente, @total)"

        Using connection = Module1.ConexionDB ' Abrir la conexión a la base de datos
            connection.Open()  ' Abrir la conexión

            Using command As New MySqlCommand(sql, connection) ' Crear el comando
                ' Agregar parámetros con valores seguros
                command.Parameters.AddWithValue("@fechaVenta", fechaVenta)
                command.Parameters.AddWithValue("@idCliente", idCliente)
                command.Parameters.AddWithValue("@total", total)

                ' Ejecutar la consulta y obtener el ID generado
                Dim idVentaGenerado As Integer = command.ExecuteScalar() ' Obtener el ID de la venta insertada

                If idVentaGenerado > 0 Then ' Verifica si se insertó correctamente
                    Return idVentaGenerado ' Retorna el ID generado
                Else
                    MessageBox.Show("Error al guardar la venta.")
                    Return -1 ' Indica un error
                End If
            End Using
        End Using
    End Function

    Private Sub GuardarDetalleVenta(idDetalle As Integer, idVenta As Integer, idProducto As Integer, cantidad As Integer, precioUnitario As Decimal)
        Dim SQL As String = "INSERT INTO detalle_Ventas (id_detalle, id_venta, id_producto, cantidad, precio_unitario) VALUES (null, null, @idProducto, @cantidad, @precioUnitario)"

        Using cmd As New MySqlCommand(SQL, Module1.ConexionDB())
            cmd.Parameters.AddWithValue("@id_detalle", idDetalle)
            cmd.Parameters.AddWithValue("@idVenta", idVenta)
            cmd.Parameters.AddWithValue("@idProducto", idProducto)
            cmd.Parameters.AddWithValue("@cantidad", cantidad)
            cmd.Parameters.AddWithValue("@precioUnitario", precioUnitario)

            Try
                ' Verificar si la conexión ya está abierta
                If ConexionDB.State = ConnectionState.Closed Then
                    ConexionDB.Open()
                End If

                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error al guardar el detalle de la venta: " & ex.Message)
            Finally
                ' Verificar si la conexión está abierta antes de cerrarla
                If ConexionDB.State = ConnectionState.Open Then
                    ConexionDB.Close()
                End If
            End Try
        End Using
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        ' Verifica que haya una fila seleccionada
        If dgvDetalleVenta.SelectedRows.Count > 0 Then
            ' Confirma si desea borrar el registro seleccionado
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar el producto seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Obtiene la fila seleccionada y la elimina
                dgvDetalleVenta.Rows.Remove(dgvDetalleVenta.SelectedRows(0))
                ' Actualiza el total después de borrar un producto
                ActualizarTotal()
            End If
        Else
            MessageBox.Show("Por favor, seleccione un producto para borrar.", "Eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ActualizarTotal()
        Dim total As Decimal = 0

        ' Recorremos cada fila del DataGridView
        For Each fila As DataGridViewRow In dgvDetalleVenta.Rows
            ' Si la fila no es una nueva fila (es decir, contiene datos)
            If Not fila.IsNewRow Then
                ' Intentamos convertir el valor de la columna "subtotal" a decimal
                If Decimal.TryParse(fila.Cells("subtotal").Value.ToString(), total) Then
                    ' Si la conversión es exitosa, sumamos el valor al total
                End If
            End If
        Next

        ' Mostramos el total formateado en el TextBox
        txtTotal.Text = total.ToString("C$") ' Formato de moneda según la configuración regional
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarFormulario()
        ' Asignar una fuente de datos vacía
        dgvDetalleVenta.DataSource = Nothing

        ' Opcional: Deshabilitar la edición del DataGridView
        dgvDetalleVenta.ReadOnly = True
    End Sub
End Class