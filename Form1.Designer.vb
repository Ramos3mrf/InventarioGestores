<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        BtnProductos = New Button()
        BtnClientes = New Button()
        BtnVentas = New Button()
        BtnCompras = New Button()
        BtnUsuarios = New Button()
        BtnSalir = New Button()
        BtnReports = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(132, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 32)
        Label1.TabIndex = 0
        Label1.Text = "BIENVENIDO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(140, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 25)
        Label2.TabIndex = 0
        Label2.Text = "Menú principal"
        ' 
        ' BtnProductos
        ' 
        BtnProductos.BackColor = Color.Blue
        BtnProductos.FlatStyle = FlatStyle.Popup
        BtnProductos.Font = New Font("Segoe UI", 10F)
        BtnProductos.ForeColor = Color.White
        BtnProductos.Location = New Point(132, 95)
        BtnProductos.Name = "BtnProductos"
        BtnProductos.Size = New Size(75, 27)
        BtnProductos.TabIndex = 1
        BtnProductos.Text = "Productos"
        BtnProductos.UseVisualStyleBackColor = False
        ' 
        ' BtnClientes
        ' 
        BtnClientes.BackColor = Color.Blue
        BtnClientes.FlatStyle = FlatStyle.Popup
        BtnClientes.Font = New Font("Segoe UI", 10F)
        BtnClientes.ForeColor = Color.White
        BtnClientes.Location = New Point(213, 95)
        BtnClientes.Name = "BtnClientes"
        BtnClientes.Size = New Size(80, 27)
        BtnClientes.TabIndex = 1
        BtnClientes.Text = "Clientes"
        BtnClientes.UseVisualStyleBackColor = False
        ' 
        ' BtnVentas
        ' 
        BtnVentas.BackColor = Color.Blue
        BtnVentas.FlatStyle = FlatStyle.Popup
        BtnVentas.Font = New Font("Segoe UI", 10F)
        BtnVentas.ForeColor = Color.White
        BtnVentas.Location = New Point(132, 128)
        BtnVentas.Name = "BtnVentas"
        BtnVentas.Size = New Size(75, 27)
        BtnVentas.TabIndex = 1
        BtnVentas.Text = "Ventas"
        BtnVentas.UseVisualStyleBackColor = False
        ' 
        ' BtnCompras
        ' 
        BtnCompras.BackColor = Color.Blue
        BtnCompras.FlatStyle = FlatStyle.Popup
        BtnCompras.Font = New Font("Segoe UI", 10F)
        BtnCompras.ForeColor = Color.White
        BtnCompras.Location = New Point(213, 128)
        BtnCompras.Name = "BtnCompras"
        BtnCompras.Size = New Size(80, 27)
        BtnCompras.TabIndex = 1
        BtnCompras.Text = "Compras"
        BtnCompras.UseVisualStyleBackColor = False
        ' 
        ' BtnUsuarios
        ' 
        BtnUsuarios.BackColor = Color.Blue
        BtnUsuarios.FlatStyle = FlatStyle.Popup
        BtnUsuarios.Font = New Font("Segoe UI", 10F)
        BtnUsuarios.ForeColor = Color.White
        BtnUsuarios.Location = New Point(132, 161)
        BtnUsuarios.Name = "BtnUsuarios"
        BtnUsuarios.Size = New Size(161, 27)
        BtnUsuarios.TabIndex = 1
        BtnUsuarios.Text = "Usuarios"
        BtnUsuarios.UseVisualStyleBackColor = False
        ' 
        ' BtnSalir
        ' 
        BtnSalir.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BtnSalir.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        BtnSalir.FlatStyle = FlatStyle.Popup
        BtnSalir.ForeColor = SystemColors.ButtonFace
        BtnSalir.Location = New Point(132, 267)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(161, 31)
        BtnSalir.TabIndex = 1
        BtnSalir.Text = "Cerrar Sesión"
        BtnSalir.UseVisualStyleBackColor = False
        ' 
        ' BtnReports
        ' 
        BtnReports.BackColor = Color.Green
        BtnReports.FlatStyle = FlatStyle.Popup
        BtnReports.Font = New Font("Segoe UI", 10F)
        BtnReports.ForeColor = Color.White
        BtnReports.Location = New Point(132, 194)
        BtnReports.Name = "BtnReports"
        BtnReports.Size = New Size(161, 27)
        BtnReports.TabIndex = 1
        BtnReports.Text = "Reportes"
        BtnReports.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(415, 320)
        Controls.Add(BtnSalir)
        Controls.Add(BtnReports)
        Controls.Add(BtnUsuarios)
        Controls.Add(BtnCompras)
        Controls.Add(BtnVentas)
        Controls.Add(BtnClientes)
        Controls.Add(BtnProductos)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Menú Principal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnProductos As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnVentas As Button
    Friend WithEvents BtnCompras As Button
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnReports As Button

End Class
