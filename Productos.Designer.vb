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
        GroupBox1 = New GroupBox()
        btnSalir = New Button()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnBorrar = New Button()
        Label4 = New Label()
        Label3 = New Label()
        txtNombre = New TextBox()
        Label1 = New Label()
        txtDescripcion = New TextBox()
        Label5 = New Label()
        Label2 = New Label()
        txtCompra = New TextBox()
        txtPrecioVenta = New TextBox()
        txtGanancia = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        txtStock = New TextBox()
        txtStockMin = New TextBox()
        GroupBox2 = New GroupBox()
        Label8 = New Label()
        TextBox1 = New TextBox()
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
        dgvProductos.Location = New Point(24, 47)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.Size = New Size(695, 238)
        dgvProductos.TabIndex = 22
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnSalir)
        GroupBox1.Controls.Add(btnNuevo)
        GroupBox1.Controls.Add(btnGuardar)
        GroupBox1.Controls.Add(btnBorrar)
        GroupBox1.ForeColor = Color.Navy
        GroupBox1.Location = New Point(613, 300)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(106, 202)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Acciones"
        ' 
        ' btnSalir
        ' 
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.Maroon
        btnSalir.Location = New Point(17, 147)
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
        btnNuevo.Location = New Point(17, 43)
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
        btnGuardar.Location = New Point(17, 78)
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
        btnBorrar.Location = New Point(17, 112)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(75, 23)
        btnBorrar.TabIndex = 7
        btnBorrar.Text = "Borrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.ForeColor = Color.Navy
        Label4.Location = New Point(213, 47)
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
        Label3.Location = New Point(11, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 19)
        Label3.TabIndex = 16
        Label3.Text = "Precio Compra:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtNombre.BorderStyle = BorderStyle.None
        txtNombre.ForeColor = Color.Navy
        txtNombre.Location = New Point(88, 19)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(222, 16)
        txtNombre.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(11, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 19)
        Label1.TabIndex = 12
        Label1.Text = "Nombre:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtDescripcion.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtDescripcion.BorderStyle = BorderStyle.None
        txtDescripcion.ForeColor = Color.Navy
        txtDescripcion.Location = New Point(11, 148)
        txtDescripcion.Multiline = True
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(550, 43)
        txtDescripcion.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.ForeColor = Color.Navy
        Label5.Location = New Point(393, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 19)
        Label5.TabIndex = 24
        Label5.Text = "Ganancia:"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(11, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 19)
        Label2.TabIndex = 14
        Label2.Text = "Descripción:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtCompra
        ' 
        txtCompra.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtCompra.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtCompra.BorderStyle = BorderStyle.None
        txtCompra.ForeColor = Color.Navy
        txtCompra.Location = New Point(112, 49)
        txtCompra.Name = "txtCompra"
        txtCompra.Size = New Size(91, 16)
        txtCompra.TabIndex = 17
        ' 
        ' txtPrecioVenta
        ' 
        txtPrecioVenta.Anchor = AnchorStyles.Right
        txtPrecioVenta.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtPrecioVenta.BorderStyle = BorderStyle.None
        txtPrecioVenta.ForeColor = Color.Navy
        txtPrecioVenta.Location = New Point(307, 50)
        txtPrecioVenta.Name = "txtPrecioVenta"
        txtPrecioVenta.ReadOnly = True
        txtPrecioVenta.Size = New Size(78, 16)
        txtPrecioVenta.TabIndex = 19
        ' 
        ' txtGanancia
        ' 
        txtGanancia.Anchor = AnchorStyles.Right
        txtGanancia.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtGanancia.BorderStyle = BorderStyle.None
        txtGanancia.ForeColor = Color.Navy
        txtGanancia.Location = New Point(467, 50)
        txtGanancia.Name = "txtGanancia"
        txtGanancia.Size = New Size(94, 16)
        txtGanancia.TabIndex = 25
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.ForeColor = Color.Navy
        Label6.Location = New Point(11, 89)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 19)
        Label6.TabIndex = 26
        Label6.Text = "Cantidad:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.ForeColor = Color.Navy
        Label7.Location = New Point(209, 89)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 19)
        Label7.TabIndex = 27
        Label7.Text = "Stock mínimo"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtStock
        ' 
        txtStock.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtStock.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtStock.BorderStyle = BorderStyle.None
        txtStock.ForeColor = Color.Navy
        txtStock.Location = New Point(86, 92)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(104, 16)
        txtStock.TabIndex = 28
        ' 
        ' txtStockMin
        ' 
        txtStockMin.Anchor = AnchorStyles.Right
        txtStockMin.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtStockMin.BorderStyle = BorderStyle.None
        txtStockMin.ForeColor = Color.Navy
        txtStockMin.Location = New Point(307, 92)
        txtStockMin.Name = "txtStockMin"
        txtStockMin.Size = New Size(99, 16)
        txtStockMin.TabIndex = 29
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(txtStockMin)
        GroupBox2.Controls.Add(txtDescripcion)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtCompra)
        GroupBox2.Controls.Add(txtStock)
        GroupBox2.Controls.Add(txtPrecioVenta)
        GroupBox2.Controls.Add(txtNombre)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtGanancia)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Location = New Point(24, 300)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(569, 202)
        GroupBox2.TabIndex = 23
        GroupBox2.TabStop = False
        GroupBox2.Text = " "
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F)
        Label8.ForeColor = Color.Navy
        Label8.Location = New Point(316, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 19)
        Label8.TabIndex = 30
        Label8.Text = "Proveedor:"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.ForeColor = Color.Navy
        TextBox1.Location = New Point(393, 21)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(168, 16)
        TextBox1.TabIndex = 31
        ' 
        ' Productos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(746, 514)
        ControlBox = False
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(dgvProductos)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Productos"
        Text = "Productos"
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents txtGanancia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtStockMin As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
