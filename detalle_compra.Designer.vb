<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detalle_compra
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvDetalle_compra = New DataGridView()
        id_detalle_compra = New DataGridViewTextBoxColumn()
        id_producto = New DataGridViewTextBoxColumn()
        nombre_producto = New DataGridViewTextBoxColumn()
        cantidad = New DataGridViewTextBoxColumn()
        precio_compra = New DataGridViewTextBoxColumn()
        subtotal = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        btnAdd = New Button()
        btnGuardar = New Button()
        btnBorrar = New Button()
        btnSalir = New Button()
        Label5 = New Label()
        cmbProductos = New ComboBox()
        Label6 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txtCantidad = New TextBox()
        txtStock = New TextBox()
        Label11 = New Label()
        GroupBox3 = New GroupBox()
        Label8 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtTotal = New TextBox()
        txtSubTotal = New TextBox()
        Label4 = New Label()
        Label7 = New Label()
        txtPrecioCompra = New TextBox()
        cmbProveedores = New ComboBox()
        btnNuevoProveedor = New Button()
        Label12 = New Label()
        TextBox1 = New TextBox()
        CType(dgvDetalle_compra, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvDetalle_compra
        ' 
        dgvDetalle_compra.AllowUserToOrderColumns = True
        dgvDetalle_compra.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDetalle_compra.BackgroundColor = SystemColors.ButtonFace
        dgvDetalle_compra.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
        dgvDetalle_compra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetalle_compra.Columns.AddRange(New DataGridViewColumn() {id_detalle_compra, id_producto, nombre_producto, cantidad, precio_compra, subtotal})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.Navy
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.Yellow
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvDetalle_compra.DefaultCellStyle = DataGridViewCellStyle1
        dgvDetalle_compra.GridColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        dgvDetalle_compra.Location = New Point(16, 50)
        dgvDetalle_compra.Name = "dgvDetalle_compra"
        dgvDetalle_compra.ReadOnly = True
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvDetalle_compra.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvDetalle_compra.Size = New Size(733, 214)
        dgvDetalle_compra.TabIndex = 24
        ' 
        ' id_detalle_compra
        ' 
        id_detalle_compra.HeaderText = "ID Detalle"
        id_detalle_compra.Name = "id_detalle_compra"
        id_detalle_compra.ReadOnly = True
        id_detalle_compra.Width = 50
        ' 
        ' id_producto
        ' 
        id_producto.HeaderText = "ID Producto"
        id_producto.Name = "id_producto"
        id_producto.ReadOnly = True
        id_producto.Width = 70
        ' 
        ' nombre_producto
        ' 
        nombre_producto.HeaderText = "Nombre producto"
        nombre_producto.Name = "nombre_producto"
        nombre_producto.ReadOnly = True
        nombre_producto.Width = 340
        ' 
        ' cantidad
        ' 
        cantidad.HeaderText = "Cantidad"
        cantidad.Name = "cantidad"
        cantidad.ReadOnly = True
        cantidad.Width = 70
        ' 
        ' precio_compra
        ' 
        precio_compra.HeaderText = "Precio Compra"
        precio_compra.Name = "precio_compra"
        precio_compra.ReadOnly = True
        precio_compra.Width = 80
        ' 
        ' subtotal
        ' 
        subtotal.HeaderText = "SubTotal"
        subtotal.Name = "subtotal"
        subtotal.ReadOnly = True
        subtotal.Width = 80
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 283)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 15)
        Label1.TabIndex = 26
        Label1.Text = "Nombre Proveedor"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(btnGuardar)
        GroupBox2.Controls.Add(btnBorrar)
        GroupBox2.ForeColor = Color.Navy
        GroupBox2.Location = New Point(599, 342)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(150, 121)
        GroupBox2.TabIndex = 35
        GroupBox2.TabStop = False
        GroupBox2.Text = "Acciones"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Navy
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(6, 30)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(69, 26)
        btnAdd.TabIndex = 50
        btnAdd.Text = "Agregar"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.ForeColor = Color.Green
        btnGuardar.Location = New Point(6, 69)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(138, 34)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "Guardar Compra"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnBorrar
        ' 
        btnBorrar.FlatStyle = FlatStyle.Flat
        btnBorrar.ForeColor = Color.Red
        btnBorrar.Location = New Point(81, 30)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(63, 26)
        btnBorrar.TabIndex = 7
        btnBorrar.Text = "Borrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.Maroon
        btnSalir.FlatStyle = FlatStyle.Popup
        btnSalir.ForeColor = Color.White
        btnSalir.Location = New Point(674, 12)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(75, 23)
        btnSalir.TabIndex = 8
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label5.ForeColor = Color.Navy
        Label5.Location = New Point(258, 8)
        Label5.Name = "Label5"
        Label5.Size = New Size(233, 28)
        Label5.TabIndex = 36
        Label5.Text = "Factura de proveedores"
        ' 
        ' cmbProductos
        ' 
        cmbProductos.FormattingEnabled = True
        cmbProductos.Location = New Point(68, 19)
        cmbProductos.Name = "cmbProductos"
        cmbProductos.Size = New Size(211, 23)
        cmbProductos.TabIndex = 37
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(7, 22)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 38
        Label6.Text = "Producto"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(142, 60)
        Label9.Name = "Label9"
        Label9.Size = New Size(40, 15)
        Label9.TabIndex = 41
        Label9.Text = "Precio"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 60)
        Label10.Name = "Label10"
        Label10.Size = New Size(55, 15)
        Label10.TabIndex = 42
        Label10.Text = "Cantidad"
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Location = New Point(68, 57)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(69, 23)
        txtCantidad.TabIndex = 44
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(347, 19)
        txtStock.Name = "txtStock"
        txtStock.ReadOnly = True
        txtStock.Size = New Size(73, 23)
        txtStock.TabIndex = 46
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(305, 22)
        Label11.Name = "Label11"
        Label11.Size = New Size(36, 15)
        Label11.TabIndex = 45
        Label11.Text = "Stock"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(TextBox1)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(cmbProductos)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(txtCantidad)
        GroupBox3.Controls.Add(txtTotal)
        GroupBox3.Controls.Add(txtStock)
        GroupBox3.Controls.Add(txtSubTotal)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(txtPrecioCompra)
        GroupBox3.Location = New Point(16, 309)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(569, 154)
        GroupBox3.TabIndex = 47
        GroupBox3.TabStop = False
        GroupBox3.Text = " "
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = Color.Navy
        Label8.Location = New Point(190, 61)
        Label8.Name = "Label8"
        Label8.Size = New Size(21, 15)
        Label8.TabIndex = 62
        Label8.Text = "C$"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.Navy
        Label3.Location = New Point(462, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(21, 15)
        Label3.TabIndex = 61
        Label3.Text = "C$"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(350, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(21, 15)
        Label2.TabIndex = 60
        Label2.Text = "C$"
        ' 
        ' txtTotal
        ' 
        txtTotal.ForeColor = Color.Navy
        txtTotal.Location = New Point(458, 57)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(91, 23)
        txtTotal.TabIndex = 60
        txtTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtSubTotal
        ' 
        txtSubTotal.Anchor = AnchorStyles.None
        txtSubTotal.Location = New Point(347, 57)
        txtSubTotal.Name = "txtSubTotal"
        txtSubTotal.ReadOnly = True
        txtSubTotal.Size = New Size(91, 23)
        txtSubTotal.TabIndex = 59
        txtSubTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.Navy
        Label4.Location = New Point(458, 41)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 15)
        Label4.TabIndex = 59
        Label4.Text = "Total a pagar"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Location = New Point(291, 60)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 15)
        Label7.TabIndex = 58
        Label7.Text = "SubTotal:"
        ' 
        ' txtPrecioCompra
        ' 
        txtPrecioCompra.Location = New Point(188, 57)
        txtPrecioCompra.Name = "txtPrecioCompra"
        txtPrecioCompra.PlaceholderText = "C$ 99.00  "
        txtPrecioCompra.Size = New Size(91, 23)
        txtPrecioCompra.TabIndex = 47
        txtPrecioCompra.TextAlign = HorizontalAlignment.Right
        ' 
        ' cmbProveedores
        ' 
        cmbProveedores.FormattingEnabled = True
        cmbProveedores.Location = New Point(131, 280)
        cmbProveedores.Name = "cmbProveedores"
        cmbProveedores.Size = New Size(245, 23)
        cmbProveedores.TabIndex = 48
        ' 
        ' btnNuevoProveedor
        ' 
        btnNuevoProveedor.FlatStyle = FlatStyle.Flat
        btnNuevoProveedor.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnNuevoProveedor.Location = New Point(617, 279)
        btnNuevoProveedor.Name = "btnNuevoProveedor"
        btnNuevoProveedor.Size = New Size(132, 23)
        btnNuevoProveedor.TabIndex = 49
        btnNuevoProveedor.Text = "Nuevo Proveedor"
        btnNuevoProveedor.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(8, 94)
        Label12.Name = "Label12"
        Label12.Size = New Size(143, 15)
        Label12.TabIndex = 63
        Label12.Text = "Descripción del producto:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(7, 112)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(542, 36)
        TextBox1.TabIndex = 64
        ' 
        ' detalle_compra
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(767, 475)
        ControlBox = False
        Controls.Add(btnSalir)
        Controls.Add(btnNuevoProveedor)
        Controls.Add(cmbProveedores)
        Controls.Add(Label5)
        Controls.Add(GroupBox2)
        Controls.Add(Label1)
        Controls.Add(GroupBox3)
        Controls.Add(dgvDetalle_compra)
        ForeColor = Color.Navy
        Name = "detalle_compra"
        Text = "detalle_compra"
        CType(dgvDetalle_compra, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSalir As Button

    Friend WithEvents dgvDetalle_compra As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtPrecioCompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbProveedores As ComboBox
    Friend WithEvents btnNuevoProveedor As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents id_detalle_compra As DataGridViewTextBoxColumn
    Friend WithEvents id_producto As DataGridViewTextBoxColumn
    Friend WithEvents nombre_producto As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio_compra As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
