Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class detalle_compra

    Private ConexionDB As MySqlConnection
    Private preciosProductos As New Dictionary(Of Integer, Decimal)
    Private clientesDictionary As New Dictionary(Of Integer, String)
    Private idDetalle As Integer = 1


    Private Sub detalle_compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionDB = Module1.ConexionDB()
        LlenarComboBoxProductos()
        LlenarComboBoxProveedores()
    End Sub

    Private Sub LlenarComboBoxProductos()
        Dim SQL As String = "select id_producto, nombre, precio_venta, stock from productos"

        Try
            If Module1.ConexionDB.State = ConnectionState.Closed Then
                Module1.ConexionDB.Open()
            End If

            Using cmd As New MySqlCommand(SQL, Module1.ConexionDB)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    cmbProductos.Items.Clear()
                    preciosProductos.Clear()

                    While reader.Read()
                        Dim idProducto As Integer = reader("id_producto")
                        Dim nombreProducto As String = reader("nombre").ToString()
                        Dim precioProducto As Decimal = reader("precio_venta")
                        Dim stockPro As Integer = reader("stock")

                        ' Creamos un objeto anónimo o un objeto personalizado con las propiedades necesarias
                        Dim producto As New With {
                     .Id = idProducto,
                     .Nombre = nombreProducto,
                     .Precio = precioProducto,
                     .Stock = stockPro
                 }

                        ' Añadimos el objeto al ComboBox
                        cmbProductos.Items.Add(producto)

                        ' Guardamos el precio en el diccionario
                        preciosProductos(idProducto) = precioProducto
                    End While
                End Using
            End Using

            ' Establecemos el DisplayMember para que solo se muestre el nombre del producto
            cmbProductos.DisplayMember = "Nombre"
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        Finally
            If Module1.ConexionDB.State = ConnectionState.Open Then
                Module1.ConexionDB.Close()
            End If
        End Try
    End Sub

    Private Sub LlenarComboBoxProveedores()
        Dim SQL As String = "select id_proveedor, nombre from proveedores"
        Try
            If ConexionDB.State = ConnectionState.Closed Then
                ConexionDB.Open()
            End If

            Using consulta As New MySqlCommand(SQL, ConexionDB)
                Using reader As MySqlDataReader = consulta.ExecuteReader()
                    clientesDictionary.Clear()
                    cmbProveedores.Items.Clear()
                    While reader.Read()
                        Dim idCliente As Integer = reader.GetInt32(0)
                        Dim nombreCliente As String = reader.GetString(1)
                        clientesDictionary.Add(idCliente, nombreCliente)
                        cmbProveedores.Items.Add(nombreCliente)
                    End While
                End Using
            End Using

            If cmbProveedores.Items.Count > 0 Then
                cmbProveedores.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar Cliente: " & ex.Message)
        Finally
            If ConexionDB.State = ConnectionState.Open Then
                ConexionDB.Close()
            End If
        End Try
    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        If cmbProductos.SelectedItem IsNot Nothing Then
            Dim productoSeleccionado As Object = cmbProductos.SelectedItem
            Dim idProducto As Integer = CInt(productoSeleccionado.GetType().GetProperty("Id").GetValue(productoSeleccionado))

            If preciosProductos.ContainsKey(idProducto) Then
                txtPrecioCompra.Text = preciosProductos(idProducto).ToString()
                txtStock.Text = CStr(productoSeleccionado.GetType().GetProperty("Stock").GetValue(productoSeleccionado))
            End If
        End If
    End Sub

    Private Function ObtenerIdProveedorSeleccionado() As Integer
        Dim nombreProveedorSeleccionado As String = cmbProveedores.SelectedItem.ToString()

        ' Usamos el diccionario para obtener el ID correspondiente al nombre seleccionado
        Dim idProveedorSeleccionado As Integer = clientesDictionary.FirstOrDefault(Function(c) c.Value = nombreProveedorSeleccionado).Key

        Return idProveedorSeleccionado
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevoProveedor_Click(sender As Object, e As EventArgs) Handles btnNuevoProveedor.Click
        Dim formProveedores As New Proveedores()
        formProveedores.Show()
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Dim cantidad As Integer
        Dim precioUnitario As Decimal

        If Integer.TryParse(txtCantidad.Text, cantidad) AndAlso cantidad > 0 Then
            If Decimal.TryParse(txtPrecioCompra.Text, Globalization.NumberStyles.Currency, Globalization.CultureInfo.InvariantCulture, precioUnitario) Then
                txtSubTotal.Text = (cantidad * precioUnitario).ToString
            Else
                txtSubTotal.Text = ""
            End If
        Else
            txtSubTotal.Text = ""
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbProductos.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(txtCantidad.Text) Then
            MessageBox.Show("Por favor, seleccione un producto e ingrese una cantidad válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtén el objeto seleccionado en lugar de una cadena
        Dim productoSeleccionado As Object = cmbProductos.SelectedItem
        Dim idProducto As Integer = CInt(productoSeleccionado.GetType().GetProperty("Id").GetValue(productoSeleccionado))
        Dim nombreProducto As String = CStr(productoSeleccionado.GetType().GetProperty("Nombre").GetValue(productoSeleccionado))
        Dim cantidad As Integer = Integer.Parse(txtCantidad.Text)
        Dim precioUnitario As Decimal = preciosProductos(idProducto)

        Dim stockDisponible As Integer = CInt(productoSeleccionado.GetType().GetProperty("Stock").GetValue(productoSeleccionado))

        If cantidad > stockDisponible Then
            MessageBox.Show("Stock insuficiente para el producto seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim subtotal As Decimal = cantidad * precioUnitario
        dgvDetalle_compra.Rows.Add(idDetalle, idProducto, nombreProducto, cantidad, precioUnitario, subtotal)
        idDetalle += 1
        ActualizarTotal()
        txtCantidad.Clear()
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If Module1.ConexionDB.State = ConnectionState.Closed Then
                Module1.ConexionDB.Open()
            End If
            ' Verifica si hay productos en el DataGridView antes de continuar
            If dgvDetalle_compra.Rows.Count = 0 Then
                MessageBox.Show("Agrega al menos un producto a la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim idVenta As Integer = GuardarVenta(ObtenerIdProveedorSeleccionado(), txtTotal.Text.Replace("C$", "").Trim())

            For Each row As DataGridViewRow In dgvDetalle_compra.Rows

                If row.Cells("id_Producto").Value IsNot Nothing AndAlso
                   row.Cells("cantidad").Value IsNot Nothing AndAlso
                   row.Cells("precioU").Value IsNot Nothing Then


                    Dim idProducto As Integer = Convert.ToInt32(row.Cells("id_Producto").Value)
                    Dim cantidad As Integer = Convert.ToInt32(row.Cells("cantidad").Value)
                    Dim precioUnitario As Decimal = Convert.ToDecimal(row.Cells("precioU").Value)

                    Dim queryDetalle As String = "INSERT INTO Detalle_Ventas (id_venta, id_producto, cantidad, precio_unitario) VALUES (@id_venta, @id_producto, @cantidad, @precio_unitario)"
                    Using comandoDetalle As New MySqlCommand(queryDetalle, ConexionDB)
                        comandoDetalle.Parameters.AddWithValue("@id_venta", idVenta)
                        comandoDetalle.Parameters.AddWithValue("@id_producto", idProducto)
                        comandoDetalle.Parameters.AddWithValue("@cantidad", cantidad)
                        comandoDetalle.Parameters.AddWithValue("@precio_unitario", precioUnitario)
                        MessageBox.Show("ID Venta: " & idVenta & " - ID Producto: " & idProducto & " - Cantidad: " & cantidad & " - Precio Unitario: " & precioUnitario)
                        comandoDetalle.ExecuteNonQuery()
                    End Using

                    Dim queryActualizarStock As String = "UPDATE productos SET stock = stock - @cantidad WHERE id_producto = @id_producto"
                    Using comandoActualizarStock As New MySqlCommand(queryActualizarStock, ConexionDB)
                        comandoActualizarStock.Parameters.AddWithValue("@cantidad", cantidad)
                        comandoActualizarStock.Parameters.AddWithValue("@id_producto", idProducto)
                        comandoActualizarStock.ExecuteNonQuery()
                    End Using
                End If
            Next

            MessageBox.Show("Venta guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvDetalle_compra.Rows.Clear()
            txtTotal.Clear()
            cmbProveedores.Items.Clear()
            cmbProductos.Items.Clear()

        Catch ex As Exception
            MessageBox.Show("Error al guardar venta: " & ex.Message)
        Finally
            If Module1.ConexionDB.State = ConnectionState.Open Then
                Module1.ConexionDB.Close()
            End If
        End Try
    End Sub

    Private Function GuardarVenta(idCliente As String, total As String) As Integer
        Dim queryVenta As String = "INSERT INTO Ventas (fecha_venta, id_cliente, total) VALUES (@fecha_venta, @id_cliente, @total)"
        If ConexionDB.State = ConnectionState.Closed Then
            ConexionDB.Open()
        End If

        Using comandoVenta As New MySqlCommand(queryVenta, ConexionDB)
            comandoVenta.Parameters.AddWithValue("@fecha_venta", DateTime.Now)
            comandoVenta.Parameters.AddWithValue("@id_cliente", idCliente)
            comandoVenta.Parameters.AddWithValue("@total", total)
            comandoVenta.ExecuteNonQuery()
            Return Convert.ToInt32(comandoVenta.LastInsertedId)
        End Using
    End Function

    Private Sub ActualizarTotal()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvDetalle_compra.Rows
            If row.Cells("subtotal").Value IsNot Nothing Then
                total += Convert.ToDecimal(row.Cells("subtotal").Value)
            End If
        Next
        txtTotal.Text = total.ToString()
    End Sub

End Class