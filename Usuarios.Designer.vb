<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        ConexionBasedeDatosBindingSource = New BindingSource(components)
        dgvUsuarios = New DataGridView()
        txtRol = New TextBox()
        txtContrasena = New TextBox()
        txtNombre = New TextBox()
        txtUsuarioID = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnSalir = New Button()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnBorrar = New Button()
        GroupBox2 = New GroupBox()
        CType(ConexionBasedeDatosBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ConexionBasedeDatosBindingSource
        ' 
        ConexionBasedeDatosBindingSource.DataSource = GetType(ConexionBasedeDatos)
        ' 
        ' dgvUsuarios
        ' 
        dgvUsuarios.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsuarios.Location = New Point(12, 12)
        dgvUsuarios.Name = "dgvUsuarios"
        dgvUsuarios.ReadOnly = True
        dgvUsuarios.Size = New Size(470, 243)
        dgvUsuarios.TabIndex = 4
        ' 
        ' txtRol
        ' 
        txtRol.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtRol.BorderStyle = BorderStyle.None
        txtRol.ForeColor = Color.Navy
        txtRol.Location = New Point(116, 56)
        txtRol.Name = "txtRol"
        txtRol.Size = New Size(138, 16)
        txtRol.TabIndex = 20
        ' 
        ' txtContrasena
        ' 
        txtContrasena.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtContrasena.BorderStyle = BorderStyle.None
        txtContrasena.ForeColor = Color.Navy
        txtContrasena.Location = New Point(116, 133)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.Size = New Size(176, 16)
        txtContrasena.TabIndex = 18
        ' 
        ' txtNombre
        ' 
        txtNombre.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtNombre.BorderStyle = BorderStyle.None
        txtNombre.ForeColor = Color.Navy
        txtNombre.Location = New Point(116, 94)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(187, 16)
        txtNombre.TabIndex = 14
        ' 
        ' txtUsuarioID
        ' 
        txtUsuarioID.BorderStyle = BorderStyle.None
        txtUsuarioID.Location = New Point(116, 22)
        txtUsuarioID.Name = "txtUsuarioID"
        txtUsuarioID.ReadOnly = True
        txtUsuarioID.Size = New Size(86, 16)
        txtUsuarioID.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F)
        Label4.ForeColor = Color.Navy
        Label4.Location = New Point(80, 52)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 20)
        Label4.TabIndex = 19
        Label4.Text = "Rol:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F)
        Label3.ForeColor = Color.Navy
        Label3.Location = New Point(28, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 17
        Label3.Text = "Contraseña:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F)
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(47, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 13
        Label1.Text = "Nombre:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnSalir)
        GroupBox1.Controls.Add(btnNuevo)
        GroupBox1.Controls.Add(btnGuardar)
        GroupBox1.Controls.Add(btnBorrar)
        GroupBox1.ForeColor = Color.Navy
        GroupBox1.Location = New Point(526, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(106, 206)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Acciones"
        ' 
        ' btnSalir
        ' 
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.Maroon
        btnSalir.Location = New Point(16, 147)
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
        btnNuevo.Location = New Point(16, 43)
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
        btnGuardar.Location = New Point(16, 78)
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
        btnBorrar.Location = New Point(16, 112)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(75, 23)
        btnBorrar.TabIndex = 7
        btnBorrar.Text = "Borrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(txtUsuarioID)
        GroupBox2.Controls.Add(txtRol)
        GroupBox2.Controls.Add(txtContrasena)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtNombre)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.ForeColor = Color.Navy
        GroupBox2.Location = New Point(24, 281)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(610, 172)
        GroupBox2.TabIndex = 23
        GroupBox2.TabStop = False
        GroupBox2.Text = "Datos del Usuario"
        ' 
        ' Usuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(678, 480)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Controls.Add(dgvUsuarios)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Usuarios"
        StartPosition = FormStartPosition.CenterParent
        Text = "Usuarios"
        CType(ConexionBasedeDatosBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents ConexionBasedeDatosBindingSource As BindingSource
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents txtRol As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtUsuarioID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
