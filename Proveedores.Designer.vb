<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedores))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtProveedorID = New TextBox()
        txtNombre = New TextBox()
        txtDireccion = New TextBox()
        txtTelefono = New TextBox()
        txtCorreo = New TextBox()
        btnNuevo = New Button()
        btnBorrar = New Button()
        btnGuardar = New Button()
        btnSalir = New Button()
        dgvProveedores = New DataGridView()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        CType(dgvProveedores, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F)
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(69, 288)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombre:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F)
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(69, 392)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 1
        Label2.Text = "Dirección:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F)
        Label3.ForeColor = Color.Navy
        Label3.Location = New Point(69, 325)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 2
        Label3.Text = "Teléfono:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F)
        Label4.ForeColor = Color.Navy
        Label4.Location = New Point(69, 360)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 3
        Label4.Text = "Correo:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtProveedorID
        ' 
        txtProveedorID.BorderStyle = BorderStyle.None
        txtProveedorID.Location = New Point(41, 229)
        txtProveedorID.Name = "txtProveedorID"
        txtProveedorID.ReadOnly = True
        txtProveedorID.Size = New Size(114, 16)
        txtProveedorID.TabIndex = 10
        ' 
        ' txtNombre
        ' 
        txtNombre.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtNombre.BorderStyle = BorderStyle.None
        txtNombre.ForeColor = Color.Navy
        txtNombre.Location = New Point(146, 290)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(187, 16)
        txtNombre.TabIndex = 1
        ' 
        ' txtDireccion
        ' 
        txtDireccion.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtDireccion.BorderStyle = BorderStyle.None
        txtDireccion.ForeColor = Color.Navy
        txtDireccion.Location = New Point(146, 394)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(328, 16)
        txtDireccion.TabIndex = 2
        ' 
        ' txtTelefono
        ' 
        txtTelefono.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtTelefono.BorderStyle = BorderStyle.None
        txtTelefono.ForeColor = Color.Navy
        txtTelefono.Location = New Point(146, 327)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(187, 16)
        txtTelefono.TabIndex = 3
        ' 
        ' txtCorreo
        ' 
        txtCorreo.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtCorreo.BorderStyle = BorderStyle.None
        txtCorreo.ForeColor = Color.Navy
        txtCorreo.Location = New Point(146, 361)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(256, 16)
        txtCorreo.TabIndex = 4
        ' 
        ' btnNuevo
        ' 
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.ForeColor = Color.Navy
        btnNuevo.Location = New Point(15, 29)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 5
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnBorrar
        ' 
        btnBorrar.FlatStyle = FlatStyle.Flat
        btnBorrar.ForeColor = Color.Red
        btnBorrar.Location = New Point(15, 98)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(75, 23)
        btnBorrar.TabIndex = 7
        btnBorrar.Text = "Borrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.ForeColor = Color.Green
        btnGuardar.Location = New Point(15, 64)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.Maroon
        btnSalir.Location = New Point(15, 133)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(75, 23)
        btnSalir.TabIndex = 8
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' dgvProveedores
        ' 
        dgvProveedores.BorderStyle = BorderStyle.None
        dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProveedores.GridColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvProveedores.Location = New Point(41, 28)
        dgvProveedores.Name = "dgvProveedores"
        dgvProveedores.ReadOnly = True
        dgvProveedores.Size = New Size(581, 184)
        dgvProveedores.TabIndex = 11
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnSalir)
        GroupBox1.Controls.Add(btnNuevo)
        GroupBox1.Controls.Add(btnGuardar)
        GroupBox1.Controls.Add(btnBorrar)
        GroupBox1.ForeColor = Color.Navy
        GroupBox1.Location = New Point(516, 256)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(106, 172)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Acciones"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.ForeColor = Color.Navy
        GroupBox2.Location = New Point(41, 256)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(455, 172)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "Datos del proveedor"
        ' 
        ' Proveedores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(661, 450)
        Controls.Add(dgvProveedores)
        Controls.Add(txtCorreo)
        Controls.Add(txtTelefono)
        Controls.Add(txtDireccion)
        Controls.Add(txtNombre)
        Controls.Add(txtProveedorID)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Proveedores"
        Text = "Proveedores"
        CType(dgvProveedores, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProveedorID As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents dgvProveedores As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
