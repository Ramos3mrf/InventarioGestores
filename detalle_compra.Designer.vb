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
        dgvDetalle_compra = New DataGridView()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox4 = New TextBox()
        Label4 = New Label()
        Label7 = New Label()
        TextBox7 = New TextBox()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        btnSalir = New Button()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnBorrar = New Button()
        Label5 = New Label()
        CType(dgvDetalle_compra, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvDetalle_compra
        ' 
        dgvDetalle_compra.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDetalle_compra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetalle_compra.Location = New Point(16, 39)
        dgvDetalle_compra.Name = "dgvDetalle_compra"
        dgvDetalle_compra.Size = New Size(575, 237)
        dgvDetalle_compra.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 298)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 15)
        Label1.TabIndex = 26
        Label1.Text = "Id_detalle_compra:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(126, 295)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(82, 23)
        TextBox1.TabIndex = 27
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(290, 71)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(77, 23)
        TextBox2.TabIndex = 29
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(195, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 15)
        Label2.TabIndex = 28
        Label2.Text = "Precio_compra:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(86, 66)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(87, 23)
        TextBox3.TabIndex = 31
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 15)
        Label3.TabIndex = 30
        Label3.Text = "Id_producto:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(86, 32)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(87, 23)
        TextBox4.TabIndex = 33
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 15)
        Label4.TabIndex = 32
        Label4.Text = "Id_compra:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(195, 40)
        Label7.Name = "Label7"
        Label7.Size = New Size(58, 15)
        Label7.TabIndex = 32
        Label7.Text = "Cantidad:"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(290, 37)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(77, 23)
        TextBox7.TabIndex = 33
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox7)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Location = New Point(16, 349)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(373, 114)
        GroupBox1.TabIndex = 34
        GroupBox1.TabStop = False
        GroupBox1.Text = " "
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.Controls.Add(btnSalir)
        GroupBox2.Controls.Add(btnNuevo)
        GroupBox2.Controls.Add(btnGuardar)
        GroupBox2.Controls.Add(btnBorrar)
        GroupBox2.ForeColor = Color.Navy
        GroupBox2.Location = New Point(399, 360)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(192, 103)
        GroupBox2.TabIndex = 35
        GroupBox2.TabStop = False
        GroupBox2.Text = "Acciones"
        ' 
        ' btnSalir
        ' 
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.Maroon
        btnSalir.Location = New Point(98, 63)
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
        btnNuevo.Location = New Point(17, 29)
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
        btnGuardar.Location = New Point(98, 29)
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
        btnBorrar.Location = New Point(17, 63)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(75, 23)
        btnBorrar.TabIndex = 7
        btnBorrar.Text = "Borrar"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label5.ForeColor = Color.Navy
        Label5.Location = New Point(199, 5)
        Label5.Name = "Label5"
        Label5.Size = New Size(233, 28)
        Label5.TabIndex = 36
        Label5.Text = "Factura de proveedores"
        ' 
        ' detalle_compra
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(609, 475)
        Controls.Add(Label5)
        Controls.Add(GroupBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(dgvDetalle_compra)
        Controls.Add(GroupBox1)
        Name = "detalle_compra"
        Text = "detalle_compra"
        CType(dgvDetalle_compra, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSalir As Button

    Friend WithEvents dgvDetalle_compra As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents Label5 As Label
End Class
