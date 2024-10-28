<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        dgvProductos = New DataGridView()
        txtVenta = New TextBox()
        txtCompra = New TextBox()
        txtDescripcion = New TextBox()
        txtNombre = New TextBox()
        txtProductoID = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnSalir = New Button()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnBorrar = New Button()
        GroupBox2 = New GroupBox()
        txtProveedorID = New TextBox()
        txtStockMin = New TextBox()
        txtStock = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        txtGanancia = New TextBox()
        Label5 = New Label()
        Label9 = New Label()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvProductos
        ' 
        dgvProductos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
        dgvProductos.BorderStyle = BorderStyle.None
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.Location = New Point(38, 30)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.Size = New Size(838, 179)
        dgvProductos.TabIndex = 22
        ' 
        ' txtVenta
        ' 
        txtVenta.Anchor = AnchorStyles.Right
        txtVenta.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtVenta.BorderStyle = BorderStyle.None
        txtVenta.ForeColor = Color.Navy
        txtVenta.Location = New Point(465, 59)
        txtVenta.Name = "txtVenta"
        txtVenta.Size = New Size(91, 16)
        txtVenta.TabIndex = 19
        ' 
        ' txtCompra
        ' 
        txtCompra.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtCompra.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtCompra.BorderStyle = BorderStyle.None
        txtCompra.ForeColor = Color.Navy
        txtCompra.Location = New Point(124, 58)
        txtCompra.Name = "txtCompra"
        txtCompra.Size = New Size(239, 16)
        txtCompra.TabIndex = 17
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtDescripcion.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtDescripcion.BorderStyle = BorderStyle.None
        txtDescripcion.ForeColor = Color.Navy
        txtDescripcion.Location = New Point(26, 170)
        txtDescripcion.Multiline = True
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(703, 85)
        txtDescripcion.TabIndex = 15
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtNombre.BorderStyle = BorderStyle.None
        txtNombre.ForeColor = Color.Navy
        txtNombre.Location = New Point(100, 28)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(424, 16)
        txtNombre.TabIndex = 13
        ' 
        ' txtProductoID
        ' 
        txtProductoID.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtProductoID.BorderStyle = BorderStyle.None
        txtProductoID.Location = New Point(136, 229)
        txtProductoID.Name = "txtProductoID"
        txtProductoID.ReadOnly = True
        txtProductoID.Size = New Size(114, 16)
        txtProductoID.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.ForeColor = Color.Navy
        Label4.Location = New Point(371, 56)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 19)
        Label4.TabIndex = 18
        Label4.Text = "Precio Venta:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.ForeColor = Color.Navy
        Label3.Location = New Point(23, 56)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 19)
        Label3.TabIndex = 16
        Label3.Text = "Precio Compra:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(23, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 19)
        Label2.TabIndex = 14
        Label2.Text = "Descripción:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(23, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 19)
        Label1.TabIndex = 12
        Label1.Text = "Nombre:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnSalir)
        GroupBox1.Controls.Add(btnNuevo)
        GroupBox1.Controls.Add(btnGuardar)
        GroupBox1.Controls.Add(btnBorrar)
        GroupBox1.ForeColor = Color.Navy
        GroupBox1.Location = New Point(770, 361)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(106, 186)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Acciones"
        ' 
        ' btnSalir
        ' 
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.Maroon
        btnSalir.Location = New Point(15, 143)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(75, 23)
        btnSalir.TabIndex = 8
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.ForeColor = Color.Navy
        btnNuevo.Location = New Point(15, 39)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 5
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.ForeColor = Color.Green
        btnGuardar.Location = New Point(15, 74)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnBorrar
        ' 
        btnBorrar.FlatStyle = FlatStyle.Flat
        btnBorrar.ForeColor = Color.Red
        btnBorrar.Location = New Point(15, 108)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(75, 23)
        btnBorrar.TabIndex = 7
        btnBorrar.Text = "Borrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(txtProveedorID)
        GroupBox2.Controls.Add(txtStockMin)
        GroupBox2.Controls.Add(txtStock)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(txtGanancia)
        GroupBox2.Controls.Add(txtVenta)
        GroupBox2.Controls.Add(txtCompra)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtDescripcion)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtNombre)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(12, 271)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(752, 276)
        GroupBox2.TabIndex = 23
        GroupBox2.TabStop = False
        GroupBox2.Text = " "
        ' 
        ' txtProveedorID
        ' 
        txtProveedorID.Anchor = AnchorStyles.Right
        txtProveedorID.BorderStyle = BorderStyle.None
        txtProveedorID.Location = New Point(632, 29)
        txtProveedorID.Name = "txtProveedorID"
        txtProveedorID.Size = New Size(97, 16)
        txtProveedorID.TabIndex = 30
        ' 
        ' txtStockMin
        ' 
        txtStockMin.Anchor = AnchorStyles.Right
        txtStockMin.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtStockMin.BorderStyle = BorderStyle.None
        txtStockMin.ForeColor = Color.Navy
        txtStockMin.Location = New Point(425, 101)
        txtStockMin.Name = "txtStockMin"
        txtStockMin.Size = New Size(99, 16)
        txtStockMin.TabIndex = 29
        ' 
        ' txtStock
        ' 
        txtStock.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtStock.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtStock.BorderStyle = BorderStyle.None
        txtStock.ForeColor = Color.Navy
        txtStock.Location = New Point(73, 101)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(240, 16)
        txtStock.TabIndex = 28
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F)
        Label8.ForeColor = Color.Navy
        Label8.Location = New Point(537, 26)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 19)
        Label8.TabIndex = 28
        Label8.Text = "Id_proveedor"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.ForeColor = Color.Navy
        Label7.Location = New Point(327, 98)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 19)
        Label7.TabIndex = 27
        Label7.Text = "Stock mínimo"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.ForeColor = Color.Navy
        Label6.Location = New Point(25, 98)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 19)
        Label6.TabIndex = 26
        Label6.Text = "Stock"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtGanancia
        ' 
        txtGanancia.Anchor = AnchorStyles.Right
        txtGanancia.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtGanancia.BorderStyle = BorderStyle.None
        txtGanancia.ForeColor = Color.Navy
        txtGanancia.Location = New Point(635, 59)
        txtGanancia.Name = "txtGanancia"
        txtGanancia.Size = New Size(94, 16)
        txtGanancia.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.ForeColor = Color.Navy
        Label5.Location = New Point(561, 56)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 19)
        Label5.TabIndex = 24
        Label5.Text = "Ganancia:"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F)
        Label9.ForeColor = Color.Navy
        Label9.Location = New Point(42, 226)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 19)
        Label9.TabIndex = 29
        Label9.Text = "Id_producto"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Productos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(904, 571)
        Controls.Add(Label9)
        Controls.Add(dgvProductos)
        Controls.Add(txtProductoID)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Productos"
        Text = "Productos"
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents txtVenta As TextBox
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtProductoID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtGanancia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStockMin As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProveedorID As TextBox
End Class
