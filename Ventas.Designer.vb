<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        dgvVentas = New DataGridView()
        txtVentaID = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        btnSalir = New Button()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnBorrar = New Button()
        CType(dgvVentas, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvVentas
        ' 
        dgvVentas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVentas.Location = New Point(12, 53)
        dgvVentas.Name = "dgvVentas"
        dgvVentas.Size = New Size(673, 214)
        dgvVentas.TabIndex = 0
        ' 
        ' txtVentaID
        ' 
        txtVentaID.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtVentaID.Location = New Point(101, 26)
        txtVentaID.Name = "txtVentaID"
        txtVentaID.Size = New Size(114, 23)
        txtVentaID.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 2
        Label1.Text = "Id_Venta"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(237, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 15)
        Label2.TabIndex = 3
        Label2.Text = "Fecha de venta:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 15)
        Label3.TabIndex = 4
        Label3.Text = "Id del cliente:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(291, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 15)
        Label4.TabIndex = 5
        Label4.Text = "Total:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(101, 55)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(114, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Right
        TextBox2.Location = New Point(332, 26)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Right
        TextBox3.Location = New Point(332, 60)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label5.Location = New Point(306, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 28)
        Label5.TabIndex = 9
        Label5.Text = "VENTAS"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtVentaID)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 283)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(464, 100)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = " "
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        GroupBox2.Controls.Add(btnSalir)
        GroupBox2.Controls.Add(btnNuevo)
        GroupBox2.Controls.Add(btnGuardar)
        GroupBox2.Controls.Add(btnBorrar)
        GroupBox2.ForeColor = Color.Navy
        GroupBox2.Location = New Point(493, 283)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(192, 100)
        GroupBox2.TabIndex = 23
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
        ' Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(697, 389)
        Controls.Add(GroupBox2)
        Controls.Add(Label5)
        Controls.Add(dgvVentas)
        Controls.Add(GroupBox1)
        ForeColor = Color.Navy
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Ventas"
        Text = "Ventas"
        CType(dgvVentas, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents txtVentaID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBorrar As Button
End Class
