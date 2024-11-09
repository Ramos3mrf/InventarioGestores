<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detalle_venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        dgvDetalleVenta = New DataGridView()
        id_detalle = New DataGridViewTextBoxColumn()
        id_producto = New DataGridViewTextBoxColumn()
        nombreP = New DataGridViewTextBoxColumn()
        cantidad = New DataGridViewTextBoxColumn()
        precioU = New DataGridViewTextBoxColumn()
        subtotal = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        btnAdd = New Button()
        btnGuardar = New Button()
        btnBorrar = New Button()
        Label3 = New Label()
        txtCantidad = New TextBox()
        Label4 = New Label()
        txtPrecioU = New TextBox()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        txtStock = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        cmbProductos = New ComboBox()
        Label7 = New Label()
        txtTotal = New TextBox()
        txtSubTotal = New TextBox()
        Label9 = New Label()
        Label6 = New Label()
        GroupBox3 = New GroupBox()
        Label8 = New Label()
        Salir = New Guna.UI2.WinForms.Guna2Button()
        cmbClientes = New ComboBox()
        bntNuevoCliente = New Button()
        CType(dgvDetalleVenta, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvDetalleVenta
        ' 
        dgvDetalleVenta.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvDetalleVenta.BorderStyle = BorderStyle.None
        dgvDetalleVenta.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetalleVenta.Columns.AddRange(New DataGridViewColumn() {id_detalle, id_producto, nombreP, cantidad, precioU, subtotal})
        dgvDetalleVenta.Location = New Point(12, 20)
        dgvDetalleVenta.Name = "dgvDetalleVenta"
        dgvDetalleVenta.ReadOnly = True
        dgvDetalleVenta.RowHeadersWidth = 55
        dgvDetalleVenta.RowTemplate.Resizable = DataGridViewTriState.True
        dgvDetalleVenta.Size = New Size(742, 150)
        dgvDetalleVenta.TabIndex = 0
        ' 
        ' id_detalle
        ' 
        id_detalle.HeaderText = "ID Detalle"
        id_detalle.Name = "id_detalle"
        id_detalle.ReadOnly = True
        id_detalle.Width = 70
        ' 
        ' id_producto
        ' 
        id_producto.HeaderText = "ID Producto"
        id_producto.Name = "id_producto"
        id_producto.ReadOnly = True
        id_producto.Width = 70
        ' 
        ' nombreP
        ' 
        nombreP.HeaderText = "Nombre producto"
        nombreP.Name = "nombreP"
        nombreP.ReadOnly = True
        nombreP.Width = 333
        ' 
        ' cantidad
        ' 
        cantidad.HeaderText = "Cantidad"
        cantidad.Name = "cantidad"
        cantidad.ReadOnly = True
        cantidad.Width = 70
        ' 
        ' precioU
        ' 
        precioU.HeaderText = "Precio Unitario"
        precioU.Name = "precioU"
        precioU.ReadOnly = True
        precioU.Width = 70
        ' 
        ' subtotal
        ' 
        subtotal.HeaderText = "SubTotal"
        subtotal.Name = "subtotal"
        subtotal.ReadOnly = True
        subtotal.Width = 70
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(btnGuardar)
        GroupBox2.Controls.Add(btnBorrar)
        GroupBox2.ForeColor = Color.Navy
        GroupBox2.Location = New Point(577, 325)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(189, 99)
        GroupBox2.TabIndex = 36
        GroupBox2.TabStop = False
        GroupBox2.Text = "Acciones"
        ' 
        ' btnAdd
        ' 
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.ForeColor = Color.Green
        btnAdd.Location = New Point(17, 24)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 28)
        btnAdd.TabIndex = 9
        btnAdd.Text = "Agregar"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.Blue
        btnGuardar.FlatStyle = FlatStyle.Popup
        btnGuardar.ForeColor = Color.White
        btnGuardar.Location = New Point(17, 55)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(156, 28)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "Guardar venta"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnBorrar
        ' 
        btnBorrar.FlatStyle = FlatStyle.Flat
        btnBorrar.ForeColor = Color.Red
        btnBorrar.Location = New Point(98, 24)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(75, 28)
        btnBorrar.TabIndex = 7
        btnBorrar.Text = "Borrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.ForeColor = Color.Navy
        Label3.Location = New Point(10, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 41
        Label3.Text = "Producto:"
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Anchor = AnchorStyles.None
        txtCantidad.ForeColor = Color.Navy
        txtCantidad.Location = New Point(75, 52)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(70, 23)
        txtCantidad.TabIndex = 44
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.ForeColor = Color.Navy
        Label4.Location = New Point(11, 56)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 15)
        Label4.TabIndex = 43
        Label4.Text = "Cantidad:"
        ' 
        ' txtPrecioU
        ' 
        txtPrecioU.Anchor = AnchorStyles.None
        txtPrecioU.ForeColor = Color.Navy
        txtPrecioU.Location = New Point(343, 26)
        txtPrecioU.Name = "txtPrecioU"
        txtPrecioU.ReadOnly = True
        txtPrecioU.Size = New Size(91, 23)
        txtPrecioU.TabIndex = 46
        txtPrecioU.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.ForeColor = Color.Navy
        Label5.Location = New Point(301, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 45
        Label5.Text = "Precio:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtStock)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(cmbProductos)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtTotal)
        GroupBox1.Controls.Add(txtSubTotal)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(txtPrecioU)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtCantidad)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.ForeColor = Color.Navy
        GroupBox1.Location = New Point(18, 325)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(553, 99)
        GroupBox1.TabIndex = 47
        GroupBox1.TabStop = False
        GroupBox1.Text = " "
        ' 
        ' txtStock
        ' 
        txtStock.Anchor = AnchorStyles.None
        txtStock.ForeColor = Color.Navy
        txtStock.Location = New Point(343, 54)
        txtStock.Name = "txtStock"
        txtStock.ReadOnly = True
        txtStock.Size = New Size(53, 23)
        txtStock.TabIndex = 60
        txtStock.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.ForeColor = Color.Navy
        Label11.Location = New Point(305, 57)
        Label11.Name = "Label11"
        Label11.Size = New Size(39, 15)
        Label11.TabIndex = 59
        Label11.Text = "Stock:"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.ForeColor = Color.Navy
        Label10.Location = New Point(457, 58)
        Label10.Name = "Label10"
        Label10.Size = New Size(21, 15)
        Label10.TabIndex = 58
        Label10.Text = "C$"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(209, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(21, 15)
        Label2.TabIndex = 57
        Label2.Text = "C$"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(345, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(21, 15)
        Label1.TabIndex = 56
        Label1.Text = "C$"
        ' 
        ' cmbProductos
        ' 
        cmbProductos.FormattingEnabled = True
        cmbProductos.Location = New Point(75, 25)
        cmbProductos.Name = "cmbProductos"
        cmbProductos.Size = New Size(216, 23)
        cmbProductos.TabIndex = 55
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Location = New Point(151, 56)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 15)
        Label7.TabIndex = 50
        Label7.Text = "SubTotal:"
        ' 
        ' txtTotal
        ' 
        txtTotal.ForeColor = Color.Navy
        txtTotal.Location = New Point(453, 54)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(91, 23)
        txtTotal.TabIndex = 53
        txtTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtSubTotal
        ' 
        txtSubTotal.Anchor = AnchorStyles.None
        txtSubTotal.Location = New Point(208, 53)
        txtSubTotal.Name = "txtSubTotal"
        txtSubTotal.ReadOnly = True
        txtSubTotal.Size = New Size(83, 23)
        txtSubTotal.TabIndex = 51
        txtSubTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.ForeColor = Color.Navy
        Label9.Location = New Point(453, 37)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 15)
        Label9.TabIndex = 52
        Label9.Text = "Total a pagar"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label6.ForeColor = Color.Navy
        Label6.Location = New Point(259, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(208, 28)
        Label6.TabIndex = 48
        Label6.Text = "Factura Nueva Venta"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(dgvDetalleVenta)
        GroupBox3.ForeColor = Color.Navy
        GroupBox3.Location = New Point(12, 60)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(769, 182)
        GroupBox3.TabIndex = 50
        GroupBox3.TabStop = False
        GroupBox3.Text = "Productos cliente"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.Navy
        Label8.Location = New Point(28, 251)
        Label8.Name = "Label8"
        Label8.Size = New Size(89, 15)
        Label8.TabIndex = 52
        Label8.Text = "Nombre cliente"
        ' 
        ' Salir
        ' 
        Salir.BorderColor = Color.Navy
        Salir.BorderRadius = 20
        Salir.CustomizableEdges = CustomizableEdges3
        Salir.DisabledState.BorderColor = Color.DarkGray
        Salir.DisabledState.CustomBorderColor = Color.DarkGray
        Salir.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Salir.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Salir.FillColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Salir.Font = New Font("Segoe UI", 9F)
        Salir.ForeColor = Color.White
        Salir.Location = New Point(705, 10)
        Salir.Name = "Salir"
        Salir.PressedColor = Color.Red
        Salir.ShadowDecoration.Color = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Salir.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Salir.ShadowDecoration.Shadow = New Padding(50)
        Salir.Size = New Size(76, 36)
        Salir.TabIndex = 54
        Salir.Text = "Salir"
        ' 
        ' cmbClientes
        ' 
        cmbClientes.FormattingEnabled = True
        cmbClientes.Location = New Point(123, 248)
        cmbClientes.Name = "cmbClientes"
        cmbClientes.Size = New Size(329, 23)
        cmbClientes.TabIndex = 56
        ' 
        ' bntNuevoCliente
        ' 
        bntNuevoCliente.FlatStyle = FlatStyle.Flat
        bntNuevoCliente.ForeColor = Color.Navy
        bntNuevoCliente.Location = New Point(655, 243)
        bntNuevoCliente.Name = "bntNuevoCliente"
        bntNuevoCliente.Size = New Size(111, 23)
        bntNuevoCliente.TabIndex = 57
        bntNuevoCliente.Text = "Nuevo Cliente"
        bntNuevoCliente.UseVisualStyleBackColor = True
        ' 
        ' detalle_venta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(793, 436)
        ControlBox = False
        Controls.Add(bntNuevoCliente)
        Controls.Add(cmbClientes)
        Controls.Add(Salir)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Name = "detalle_venta"
        Text = "detalle_venta"
        CType(dgvDetalleVenta, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDetalleVenta As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrecioU As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Salir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents bntNuevoCliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents id_detalle As DataGridViewTextBoxColumn
    Friend WithEvents id_producto As DataGridViewTextBoxColumn
    Friend WithEvents nombreP As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precioU As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
End Class
