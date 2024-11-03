<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        dgvClientes = New DataGridView()
        txtCorreo = New TextBox()
        txtTelefono = New TextBox()
        txtDireccion = New TextBox()
        txtNombre = New TextBox()
        txtClienteID = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnSalir = New Button()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnBorrar = New Button()
        Label5 = New Label()
        GroupBox2 = New GroupBox()
        CType(dgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvClientes
        ' 
        dgvClientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvClientes.BorderStyle = BorderStyle.None
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvClientes.Location = New Point(35, 25)
        dgvClientes.Name = "dgvClientes"
        dgvClientes.Size = New Size(559, 184)
        dgvClientes.TabIndex = 22
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtCorreo.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtCorreo.BorderStyle = BorderStyle.None
        txtCorreo.ForeColor = Color.Navy
        txtCorreo.Location = New Point(89, 121)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(300, 16)
        txtCorreo.TabIndex = 19
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtTelefono.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtTelefono.BorderStyle = BorderStyle.None
        txtTelefono.ForeColor = Color.Navy
        txtTelefono.Location = New Point(89, 87)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(300, 16)
        txtTelefono.TabIndex = 17
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtDireccion.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtDireccion.BorderStyle = BorderStyle.None
        txtDireccion.ForeColor = Color.Navy
        txtDireccion.Location = New Point(89, 54)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(300, 16)
        txtDireccion.TabIndex = 15
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtNombre.BorderStyle = BorderStyle.None
        txtNombre.ForeColor = Color.Navy
        txtNombre.Location = New Point(89, 22)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(300, 16)
        txtNombre.TabIndex = 13
        ' 
        ' txtClienteID
        ' 
        txtClienteID.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtClienteID.BorderStyle = BorderStyle.None
        txtClienteID.Location = New Point(107, 218)
        txtClienteID.Name = "txtClienteID"
        txtClienteID.Size = New Size(71, 16)
        txtClienteID.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.ForeColor = Color.Navy
        Label4.Location = New Point(12, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 19)
        Label4.TabIndex = 18
        Label4.Text = "Correo:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.ForeColor = Color.Navy
        Label3.Location = New Point(12, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 19)
        Label3.TabIndex = 16
        Label3.Text = "Teléfono:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(12, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 19)
        Label2.TabIndex = 14
        Label2.Text = "Dirección:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(12, 20)
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
        GroupBox1.Location = New Point(495, 246)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(103, 172)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Acciones"
        ' 
        ' btnSalir
        ' 
        btnSalir.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.Maroon
        btnSalir.Location = New Point(15, 133)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(72, 23)
        btnSalir.TabIndex = 8
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.ForeColor = Color.Navy
        btnNuevo.Location = New Point(15, 29)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(72, 23)
        btnNuevo.TabIndex = 5
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.ForeColor = Color.Green
        btnGuardar.Location = New Point(15, 64)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(72, 23)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnBorrar
        ' 
        btnBorrar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnBorrar.FlatStyle = FlatStyle.Flat
        btnBorrar.ForeColor = Color.Red
        btnBorrar.Location = New Point(15, 98)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(72, 23)
        btnBorrar.TabIndex = 7
        btnBorrar.Text = "Borrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.ForeColor = Color.Navy
        Label5.Location = New Point(39, 215)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 19)
        Label5.TabIndex = 23
        Label5.Text = "ID cliente"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(txtNombre)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtCorreo)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtTelefono)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtDireccion)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(35, 269)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(409, 149)
        GroupBox2.TabIndex = 24
        GroupBox2.TabStop = False
        GroupBox2.Text = " "
        ' 
        ' Clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(627, 450)
        Controls.Add(Label5)
        Controls.Add(dgvClientes)
        Controls.Add(txtClienteID)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Clientes"
        Text = "Clientes"
        CType(dgvClientes, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtClienteID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
