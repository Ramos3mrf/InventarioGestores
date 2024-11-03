<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscarFechaCompra
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Label2 = New Label()
        btnExportar = New Guna.UI2.WinForms.Guna2Button()
        btnBuscar = New Guna.UI2.WinForms.Guna2Button()
        dgvComprasVer = New DataGridView()
        dtpInicial = New Guna.UI2.WinForms.Guna2DateTimePicker()
        dtpFinal = New Guna.UI2.WinForms.Guna2DateTimePicker()
        CType(dgvComprasVer, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(17, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 19)
        Label1.TabIndex = 1
        Label1.Text = "Fecha Inicial:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(17, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 19)
        Label2.TabIndex = 4
        Label2.Text = "Fecha Final:"
        ' 
        ' btnExportar
        ' 
        btnExportar.BackColor = Color.Transparent
        btnExportar.BorderColor = Color.Green
        btnExportar.BorderRadius = 10
        btnExportar.BorderThickness = 1
        btnExportar.CustomizableEdges = CustomizableEdges1
        btnExportar.DisabledState.BorderColor = Color.DarkGray
        btnExportar.DisabledState.CustomBorderColor = Color.DarkGray
        btnExportar.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnExportar.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnExportar.FillColor = Color.White
        btnExportar.Font = New Font("Segoe UI", 9F)
        btnExportar.ForeColor = Color.Green
        btnExportar.Image = My.Resources.Resources.xls
        btnExportar.Location = New Point(150, 405)
        btnExportar.Name = "btnExportar"
        btnExportar.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnExportar.Size = New Size(100, 41)
        btnExportar.TabIndex = 6
        btnExportar.Text = "Exportar"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.Transparent
        btnBuscar.BorderColor = Color.Navy
        btnBuscar.BorderRadius = 10
        btnBuscar.BorderThickness = 1
        btnBuscar.CustomizableEdges = CustomizableEdges3
        btnBuscar.DisabledState.BorderColor = Color.DarkGray
        btnBuscar.DisabledState.CustomBorderColor = Color.DarkGray
        btnBuscar.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBuscar.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBuscar.FillColor = Color.White
        btnBuscar.Font = New Font("Segoe UI", 9F)
        btnBuscar.ForeColor = Color.Navy
        btnBuscar.Image = My.Resources.Resources.buscar
        btnBuscar.Location = New Point(284, 98)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.ShadowDecoration.Color = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnBuscar.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnBuscar.ShadowDecoration.Shadow = New Padding(5, 12, 5, 5)
        btnBuscar.Size = New Size(106, 38)
        btnBuscar.TabIndex = 7
        btnBuscar.Text = "Buscar"
        ' 
        ' dgvComprasVer
        ' 
        dgvComprasVer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvComprasVer.Location = New Point(17, 147)
        dgvComprasVer.Name = "dgvComprasVer"
        dgvComprasVer.Size = New Size(373, 237)
        dgvComprasVer.TabIndex = 8
        ' 
        ' dtpInicial
        ' 
        dtpInicial.BorderColor = Color.Navy
        dtpInicial.BorderRadius = 7
        dtpInicial.BorderThickness = 1
        dtpInicial.Checked = True
        dtpInicial.CustomizableEdges = CustomizableEdges5
        dtpInicial.FillColor = Color.White
        dtpInicial.Font = New Font("Segoe UI", 9F)
        dtpInicial.ForeColor = Color.Navy
        dtpInicial.Format = DateTimePickerFormat.Long
        dtpInicial.Location = New Point(17, 33)
        dtpInicial.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpInicial.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpInicial.Name = "dtpInicial"
        dtpInicial.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        dtpInicial.Size = New Size(226, 36)
        dtpInicial.TabIndex = 9
        dtpInicial.Value = New Date(2024, 11, 2, 23, 42, 59, 217)
        ' 
        ' dtpFinal
        ' 
        dtpFinal.BorderColor = Color.Navy
        dtpFinal.BorderRadius = 7
        dtpFinal.BorderThickness = 1
        dtpFinal.Checked = True
        dtpFinal.CustomizableEdges = CustomizableEdges7
        dtpFinal.FillColor = Color.White
        dtpFinal.Font = New Font("Segoe UI", 9F)
        dtpFinal.ForeColor = Color.Navy
        dtpFinal.Format = DateTimePickerFormat.Long
        dtpFinal.Location = New Point(17, 100)
        dtpFinal.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpFinal.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpFinal.Name = "dtpFinal"
        dtpFinal.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        dtpFinal.Size = New Size(226, 36)
        dtpFinal.TabIndex = 10
        dtpFinal.Value = New Date(2024, 11, 2, 23, 42, 59, 217)
        ' 
        ' buscarFechaCompra
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(402, 456)
        Controls.Add(dtpFinal)
        Controls.Add(dtpInicial)
        Controls.Add(dgvComprasVer)
        Controls.Add(btnBuscar)
        Controls.Add(btnExportar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "buscarFechaCompra"
        Text = "buscarFechaCompra"
        CType(dgvComprasVer, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExportar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvComprasVer As DataGridView
    Friend WithEvents dtpInicial As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpFinal As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
