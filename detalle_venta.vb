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

        ' Configurar el DataGridView para usar el DataTable modificado
        dgvDetalleVenta.DataSource = detalleVentaTable

        ' Configurar el ancho de las columnas
        dgvDetalleVenta.Columns("Nombre del producto").Width = 200
        dgvDetalleVenta.Columns("cantidad").Width = 70

        ' Cargar el DataGridView de Productos Cliente (izquierdo)
        SQL = "SELECT id_producto, nombre, precio_venta, stock from productos"
        dgvProdStock.DataSource = cargar_grid(SQL, ConexionDB)
    End Sub
    Private Sub LimpiarFormulario()
        txtIDventa.Clear()
        txtTotal.Clear()
        dgvDetalleVenta.Rows.Clear()
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

            ' Crear una nueva fila en el DataTable
            Dim nuevaFila As DataRow = detalleVentaTable.NewRow()

            ' Asignar valores a las columnas del DataTable y las columnas personalizadas
            nuevaFila("cantidad") = txtCantidad.Text
            nuevaFila("Nombre del producto") = dgvProdStock.CurrentRow.Cells("nombre").Value.ToString()
            nuevaFila("Precio") = txtPrecioU.Text

            ' Asignar valores a las columnas adicionales (id_producto y subtotal)
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
                Dim idProducto As Integer = Integer.Parse(row.Cells("id_producto").Value.ToString())
                Dim cantidad As Integer = Integer.Parse(row.Cells("cantidad").Value.ToString())
                Dim precioUnitario As Decimal = Decimal.Parse(row.Cells("Precio").Value.ToString())
                GuardarDetalleVenta(idVenta, idProducto, cantidad, precioUnitario)
            End If
        Next

        MessageBox.Show("Venta guardada exitosamente.")
        LimpiarFormulario()
    End Sub

    Private Function GuardarVenta(idCliente As String, total As String) As Integer
        Dim fechaVenta As String = DateTime.Now.ToString("yyyy-MM-dd") ' Fecha actual
        Dim SQL As String = "INSERT INTO Ventas (null, fecha_venta, id_cliente, total) VALUES (@fechaVenta, @idCliente, @total)"

        Using cmd As New MySqlCommand(SQL, Module1.ConexionDB)
            cmd.Parameters.AddWithValue("@fechaVenta", fechaVenta)
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            cmd.Parameters.AddWithValue("@total", total)

            Try
                ConexionDB.Open()
                cmd.ExecuteNonQuery()

                ' Obtener el ID de la venta recién insertada
                Dim idVentaGenerado As Integer
                Dim SQLSelect As String = "SELECT SCOPE_IDENTITY()"
                cmd.CommandText = SQLSelect
                idVentaGenerado = Convert.ToInt32(cmd.ExecuteScalar())
                Return idVentaGenerado
            Catch ex As Exception
                MessageBox.Show("Error al guardar la venta: " & ex.Message)
                Return -1
            Finally
                ConexionDB.Close()
            End Try
        End Using
    End Function

    Private Sub GuardarDetalleVenta(idVenta As Integer, idProducto As Integer, cantidad As Integer, precioUnitario As Decimal)
        Dim idDetalle As Integer = txtIdDetalle.Text
        Dim SQL As String = "INSERT INTO Detalle_Ventas (id_detalle, id_venta, id_producto, cantidad, precio_unitario, ) VALUES (@id_detalle, @idVenta, @idProducto, @cantidad, @precioUnitario)"

        Using cmd As New MySqlCommand(SQL, Module1.ConexionDB())
            cmd.Parameters.AddWithValue("@id_detalle", idDetalle)
            cmd.Parameters.AddWithValue("@idVenta", idVenta)
            cmd.Parameters.AddWithValue("@idProducto", idProducto)
            cmd.Parameters.AddWithValue("@cantidad", cantidad)
            cmd.Parameters.AddWithValue("@precioUnitario", precioUnitario)

            Try
                ConexionDB.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error al guardar el detalle de la venta: " & ex.Message)
            Finally
                ConexionDB.Close()
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

        ' Recorre todas las filas para sumar el subtotal de cada producto
        For Each row As DataGridViewRow In dgvDetalleVenta.Rows
            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells("subtotal").Value)
            End If
        Next

        ' Actualiza el campo de texto del total
        txtTotal.Text = total.ToString("0.00")
    End Sub

End Class