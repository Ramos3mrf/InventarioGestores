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
        dgvDetalleVenta = New DataGridView()
        GroupBox2 = New GroupBox()
        btnAdd = New Button()
        btnSalir = New Button()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnBorrar = New Button()
        Label1 = New Label()
        txtIdDetalle = New TextBox()
        txtIDventa = New TextBox()
        Label2 = New Label()
        txtIDprod = New TextBox()
        Label3 = New Label()
        txtCantidad = New TextBox()
        Label4 = New Label()
        txtPrecioU = New TextBox()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        txtSubTotal = New TextBox()
        Label6 = New Label()
        dgvProdStock = New DataGridView()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        txtID_Cliente = New TextBox()
        Label8 = New Label()
        txtTotal = New TextBox()
        Label9 = New Label()
        CType(dgvDetalleVenta, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(dgvProdStock, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDetalleVenta
        ' 
        dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetalleVenta.Location = New Point(18, 82)
        dgvDetalleVenta.Name = "dgvDetalleVenta"
        dgvDetalleVenta.RowHeadersWidth = 55
        dgvDetalleVenta.RowTemplate.Resizable = DataGridViewTriState.True
        dgvDetalleVenta.Size = New Size(429, 150)
        dgvDetalleVenta.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(btnSalir)
        GroupBox2.Controls.Add(btnNuevo)
        GroupBox2.Controls.Add(btnGuardar)
        GroupBox2.Controls.Add(btnBorrar)
        GroupBox2.ForeColor = Color.Navy
        GroupBox2.Location = New Point(467, 318)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(253, 99)
        GroupBox2.TabIndex = 36
        GroupBox2.TabStop = False
        GroupBox2.Text = "Acciones"
        ' 
        ' btnAdd
        ' 
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.ForeColor = Color.Green
        btnAdd.Location = New Point(94, 24)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 28)
        btnAdd.TabIndex = 9
        btnAdd.Text = "Agregar"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.Maroon
        btnSalir.Location = New Point(141, 58)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(106, 23)
        btnSalir.TabIndex = 8
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.ForeColor = Color.Navy
        btnNuevo.Location = New Point(17, 24)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 28)
        btnNuevo.TabIndex = 5
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.Blue
        btnGuardar.FlatStyle = FlatStyle.Popup
        btnGuardar.ForeColor = Color.White
        btnGuardar.Location = New Point(17, 58)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(118, 23)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "Guardar detalle"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnBorrar
        ' 
        btnBorrar.FlatStyle = FlatStyle.Flat
        btnBorrar.ForeColor = Color.Red
        btnBorrar.Location = New Point(172, 24)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(75, 28)
        btnBorrar.TabIndex = 7
        btnBorrar.Text = "Borrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(277, 241)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 37
        Label1.Text = "Id_detalle"
        ' 
        ' txtIdDetalle
        ' 
        txtIdDetalle.ForeColor = Color.Navy
        txtIdDetalle.Location = New Point(342, 238)
        txtIdDetalle.Name = "txtIdDetalle"
        txtIdDetalle.ReadOnly = True
        txtIdDetalle.Size = New Size(105, 23)
        txtIdDetalle.TabIndex = 38
        ' 
        ' txtIDventa
        ' 
        txtIDventa.ForeColor = Color.Navy
        txtIDventa.Location = New Point(71, 31)
        txtIDventa.Name = "txtIDventa"
        txtIDventa.Size = New Size(70, 23)
        txtIDventa.TabIndex = 40
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(8, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 39
        Label2.Text = "id_venta:"
        ' 
        ' txtIDprod
        ' 
        txtIDprod.Location = New Point(83, 68)
        txtIDprod.Name = "txtIDprod"
        txtIDprod.Size = New Size(74, 23)
        txtIDprod.TabIndex = 42
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Navy
        Label3.Location = New Point(8, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 15)
        Label3.TabIndex = 41
        Label3.Text = "id_producto:"
        ' 
        ' txtCantidad
        ' 
        txtCantidad.ForeColor = Color.Navy
        txtCantidad.Location = New Point(259, 31)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(73, 23)
        txtCantidad.TabIndex = 44
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Navy
        Label4.Location = New Point(199, 34)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 15)
        Label4.TabIndex = 43
        Label4.Text = "Cantidad:"
        ' 
        ' txtPrecioU
        ' 
        txtPrecioU.ForeColor = Color.Navy
        txtPrecioU.Location = New Point(259, 68)
        txtPrecioU.Name = "txtPrecioU"
        txtPrecioU.Size = New Size(73, 23)
        txtPrecioU.TabIndex = 46
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Navy
        Label5.Location = New Point(190, 71)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 45
        Label5.Text = "Precio unit:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtSubTotal)
        GroupBox1.Controls.Add(txtIDprod)
        GroupBox1.Controls.Add(txtPrecioU)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtIDventa)
        GroupBox1.Controls.Add(txtCantidad)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.ForeColor = Color.Navy
        GroupBox1.Location = New Point(18, 311)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(435, 106)
        GroupBox1.TabIndex = 47
        GroupBox1.TabStop = False
        GroupBox1.Text = " "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(353, 53)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 15)
        Label7.TabIndex = 50
        Label7.Text = "SubTotal:"
        ' 
        ' txtSubTotal
        ' 
        txtSubTotal.Location = New Point(353, 71)
        txtSubTotal.Name = "txtSubTotal"
        txtSubTotal.Size = New Size(71, 23)
        txtSubTotal.TabIndex = 51
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
        ' dgvProdStock
        ' 
        dgvProdStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProdStock.Location = New Point(465, 82)
        dgvProdStock.Name = "dgvProdStock"
        dgvProdStock.Size = New Size(255, 150)
        dgvProdStock.TabIndex = 49
        ' 
        ' GroupBox3
        ' 
        GroupBox3.ForeColor = Color.Navy
        GroupBox3.Location = New Point(12, 60)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(441, 182)
        GroupBox3.TabIndex = 50
        GroupBox3.TabStop = False
        GroupBox3.Text = "Productos cliente"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.ForeColor = Color.Navy
        GroupBox4.Location = New Point(459, 60)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(276, 182)
        GroupBox4.TabIndex = 51
        GroupBox4.TabStop = False
        GroupBox4.Text = "Productos en Stock"
        ' 
        ' txtID_Cliente
        ' 
        txtID_Cliente.ForeColor = Color.Navy
        txtID_Cliente.Location = New Point(84, 238)
        txtID_Cliente.Name = "txtID_Cliente"
        txtID_Cliente.Size = New Size(105, 23)
        txtID_Cliente.TabIndex = 53
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.Navy
        Label8.Location = New Point(17, 241)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 15)
        Label8.TabIndex = 52
        Label8.Text = "Cliente ID:"
        ' 
        ' txtTotal
        ' 
        txtTotal.ForeColor = Color.Navy
        txtTotal.Location = New Point(56, 273)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(73, 23)
        txtTotal.TabIndex = 53
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.Navy
        Label9.Location = New Point(18, 276)
        Label9.Name = "Label9"
        Label9.Size = New Size(32, 15)
        Label9.TabIndex = 52
        Label9.Text = "Total"
        ' 
        ' detalle_venta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(747, 436)
        Controls.Add(txtTotal)
        Controls.Add(txtID_Cliente)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(dgvProdStock)
        Controls.Add(Label6)
        Controls.Add(txtIdDetalle)
        Controls.Add(Label1)
        Controls.Add(GroupBox2)
        Controls.Add(dgvDetalleVenta)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox1)
        Name = "detalle_venta"
        Text = "detalle_venta"
        CType(dgvDetalleVenta, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvProdStock, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDetalleVenta As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdDetalle As TextBox
    Friend WithEvents txtIDventa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIDprod As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrecioU As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvProdStock As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtID_Cliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label9 As Label
End Class
