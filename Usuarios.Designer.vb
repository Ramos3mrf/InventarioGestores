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
        lookP = New Button()
        PictureBox1 = New PictureBox()
        ToolTip1 = New ToolTip(components)
        CType(ConexionBasedeDatosBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ConexionBasedeDatosBindingSource
        ' 
        ConexionBasedeDatosBindingSource.DataSource = GetType(ConexionBasedeDatos)
        ' 
        ' dgvUsuarios
        ' 
        dgvUsuarios.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsuarios.Location = New Point(23, 12)
        dgvUsuarios.Name = "dgvUsuarios"
        dgvUsuarios.ReadOnly = True
        dgvUsuarios.Size = New Size(467, 243)
        dgvUsuarios.TabIndex = 4
        ' 
        ' txtRol
        ' 
        txtRol.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtRol.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtRol.BorderStyle = BorderStyle.None
        txtRol.ForeColor = Color.Navy
        txtRol.Location = New Point(100, 56)
        txtRol.Name = "txtRol"
        txtRol.Size = New Size(138, 16)
        txtRol.TabIndex = 1
        txtRol.Tag = ""
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtContrasena.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtContrasena.BorderStyle = BorderStyle.None
        txtContrasena.ForeColor = Color.Navy
        txtContrasena.Location = New Point(100, 133)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.PasswordChar = "*"c
        txtContrasena.Size = New Size(187, 16)
        txtContrasena.TabIndex = 3
        txtContrasena.Tag = ""
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtNombre.BorderStyle = BorderStyle.None
        txtNombre.ForeColor = Color.Navy
        txtNombre.Location = New Point(100, 94)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(187, 16)
        txtNombre.TabIndex = 2
        txtNombre.Tag = ""
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
        Label4.Location = New Point(64, 52)
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
        Label3.Location = New Point(12, 131)
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
        Label1.Location = New Point(31, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 13
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
        GroupBox1.Location = New Point(384, 277)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(106, 174)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Acciones"
        ' 
        ' btnSalir
        ' 
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.Maroon
        btnSalir.Location = New Point(16, 134)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(75, 23)
        btnSalir.TabIndex = 7
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.ForeColor = Color.Navy
        btnNuevo.Location = New Point(16, 30)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 4
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.ForeColor = Color.Green
        btnGuardar.Location = New Point(16, 65)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 5
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnBorrar
        ' 
        btnBorrar.FlatStyle = FlatStyle.Flat
        btnBorrar.ForeColor = Color.Red
        btnBorrar.Location = New Point(16, 99)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(75, 23)
        btnBorrar.TabIndex = 6
        btnBorrar.Text = "Borrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(lookP)
        GroupBox2.Controls.Add(PictureBox1)
        GroupBox2.Controls.Add(txtUsuarioID)
        GroupBox2.Controls.Add(txtRol)
        GroupBox2.Controls.Add(txtContrasena)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtNombre)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.ForeColor = Color.Navy
        GroupBox2.Location = New Point(23, 280)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(355, 172)
        GroupBox2.TabIndex = 23
        GroupBox2.TabStop = False
        GroupBox2.Text = "Datos del Usuario"
        ' 
        ' lookP
        ' 
        lookP.BackColor = Color.Transparent
        lookP.FlatStyle = FlatStyle.Flat
        lookP.Font = New Font("Segoe UI", 7F)
        lookP.ForeColor = Color.Navy
        lookP.Location = New Point(293, 133)
        lookP.Name = "lookP"
        lookP.Size = New Size(56, 21)
        lookP.TabIndex = 24
        lookP.Text = "Ocultar"
        lookP.UseVisualStyleBackColor = False
        lookP.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ocultar
        PictureBox1.Location = New Point(265, 132)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(22, 19)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' Usuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(517, 481)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Controls.Add(dgvUsuarios)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Usuarios"
        StartPosition = FormStartPosition.CenterParent
        Text = "Usuarios"
        CType(ConexionBasedeDatosBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lookP As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
