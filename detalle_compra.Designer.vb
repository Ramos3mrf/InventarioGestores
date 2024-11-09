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
        GroupBox2 = New GroupBox()
        btnSalir = New Button()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnBorrar = New Button()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Label6 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        ComboBox2 = New ComboBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label11 = New Label()
        GroupBox3 = New GroupBox()
        CType(dgvDetalle_compra, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvDetalle_compra
        ' 
        dgvDetalle_compra.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDetalle_compra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetalle_compra.Location = New Point(16, 39)
        dgvDetalle_compra.Name = "dgvDetalle_compra"
        dgvDetalle_compra.Size = New Size(602, 175)
        dgvDetalle_compra.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 236)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 15)
        Label1.TabIndex = 26
        Label1.Text = "ID"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(40, 233)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(52, 23)
        TextBox1.TabIndex = 27
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.Controls.Add(btnSalir)
        GroupBox2.Controls.Add(btnNuevo)
        GroupBox2.Controls.Add(btnGuardar)
        GroupBox2.Controls.Add(btnBorrar)
        GroupBox2.ForeColor = Color.Navy
        GroupBox2.Location = New Point(512, 298)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(106, 152)
        GroupBox2.TabIndex = 35
        GroupBox2.TabStop = False
        GroupBox2.Text = "Acciones"
        ' 
        ' btnSalir
        ' 
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.Maroon
        btnSalir.Location = New Point(17, 116)
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
        btnGuardar.Location = New Point(17, 58)
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
        btnBorrar.Location = New Point(17, 87)
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
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(74, 25)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(127, 23)
        ComboBox1.TabIndex = 37
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(7, 28)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 15)
        Label6.TabIndex = 38
        Label6.Text = "Proveedor"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarForeColor = Color.Navy
        DateTimePicker1.Location = New Point(51, 67)
        DateTimePicker1.Margin = New Padding(2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(150, 23)
        DateTimePicker1.TabIndex = 39
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(7, 73)
        Label8.Name = "Label8"
        Label8.Size = New Size(38, 15)
        Label8.TabIndex = 40
        Label8.Text = "Fecha"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(223, 28)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 15)
        Label9.TabIndex = 41
        Label9.Text = "Producto"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(223, 73)
        Label10.Name = "Label10"
        Label10.Size = New Size(55, 15)
        Label10.TabIndex = 42
        Label10.Text = "Cantidad"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(285, 25)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(183, 23)
        ComboBox2.TabIndex = 43
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(285, 67)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(52, 23)
        TextBox5.TabIndex = 44
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(416, 67)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(52, 23)
        TextBox6.TabIndex = 46
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(370, 73)
        Label11.Name = "Label11"
        Label11.Size = New Size(40, 15)
        Label11.TabIndex = 45
        Label11.Text = "Precio"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextBox6)
        GroupBox3.Controls.Add(TextBox5)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(ComboBox1)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(ComboBox2)
        GroupBox3.Controls.Add(DateTimePicker1)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Location = New Point(16, 342)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(475, 108)
        GroupBox3.TabIndex = 47
        GroupBox3.TabStop = False
        GroupBox3.Text = " "
        ' 
        ' detalle_compra
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(636, 475)
        Controls.Add(Label5)
        Controls.Add(GroupBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(dgvDetalle_compra)
        Controls.Add(GroupBox3)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
