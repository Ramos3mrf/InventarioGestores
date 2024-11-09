<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscarFechaVenta
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
        dgvReporteVentas = New DataGridView()
        Label2 = New Label()
        dtpInicio = New Guna.UI2.WinForms.Guna2DateTimePicker()
        dtpFinal = New Guna.UI2.WinForms.Guna2DateTimePicker()
        btnBuscar = New Guna.UI2.WinForms.Guna2Button()
        btnExportar = New Guna.UI2.WinForms.Guna2Button()
        CType(dgvReporteVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(14, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 19)
        Label1.TabIndex = 0
        Label1.Text = "Fecha Inicial:"
        ' 
        ' dgvReporteVentas
        ' 
        dgvReporteVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReporteVentas.Location = New Point(12, 155)
        dgvReporteVentas.Name = "dgvReporteVentas"
        dgvReporteVentas.Size = New Size(398, 231)
        dgvReporteVentas.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(12, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 19)
        Label2.TabIndex = 5
        Label2.Text = "Fecha Final:"
        ' 
        ' dtpInicio
        ' 
        dtpInicio.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dtpInicio.BorderColor = Color.Navy
        dtpInicio.BorderRadius = 7
        dtpInicio.BorderThickness = 1
        dtpInicio.Checked = True
        dtpInicio.CustomizableEdges = CustomizableEdges1
        dtpInicio.FillColor = Color.White
        dtpInicio.Font = New Font("Segoe UI", 9F)
        dtpInicio.ForeColor = Color.Navy
        dtpInicio.Format = DateTimePickerFormat.Long
        dtpInicio.Location = New Point(14, 35)
        dtpInicio.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpInicio.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpInicio.Name = "dtpInicio"
        dtpInicio.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        dtpInicio.Size = New Size(227, 41)
        dtpInicio.TabIndex = 10
        dtpInicio.Value = New Date(2024, 11, 2, 23, 29, 12, 437)
        ' 
        ' dtpFinal
        ' 
        dtpFinal.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dtpFinal.BorderColor = Color.Navy
        dtpFinal.BorderRadius = 7
        dtpFinal.BorderThickness = 1
        dtpFinal.Checked = True
        dtpFinal.CustomizableEdges = CustomizableEdges3
        dtpFinal.FillColor = Color.White
        dtpFinal.Font = New Font("Segoe UI", 9F)
        dtpFinal.ForeColor = Color.Navy
        dtpFinal.Format = DateTimePickerFormat.Long
        dtpFinal.Location = New Point(14, 101)
        dtpFinal.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpFinal.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpFinal.Name = "dtpFinal"
        dtpFinal.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        dtpFinal.Size = New Size(227, 38)
        dtpFinal.TabIndex = 11
        dtpFinal.Value = New Date(2024, 11, 2, 23, 29, 12, 437)
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.Transparent
        btnBuscar.BorderColor = Color.Navy
        btnBuscar.BorderRadius = 10
        btnBuscar.BorderThickness = 1
        btnBuscar.CustomizableEdges = CustomizableEdges5
        btnBuscar.DisabledState.BorderColor = Color.DarkGray
        btnBuscar.DisabledState.CustomBorderColor = Color.DarkGray
        btnBuscar.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBuscar.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBuscar.FillColor = Color.White
        btnBuscar.Font = New Font("Segoe UI", 9F)
        btnBuscar.ForeColor = Color.Navy
        btnBuscar.Image = My.Resources.Resources.buscar
        btnBuscar.Location = New Point(304, 101)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.ShadowDecoration.Color = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnBuscar.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnBuscar.ShadowDecoration.Shadow = New Padding(5, 12, 5, 5)
        btnBuscar.Size = New Size(106, 38)
        btnBuscar.TabIndex = 13
        btnBuscar.Text = "Buscar"
        ' 
        ' btnExportar
        ' 
        btnExportar.BackColor = Color.Transparent
        btnExportar.BorderColor = Color.Green
        btnExportar.BorderRadius = 10
        btnExportar.BorderThickness = 1
        btnExportar.CustomizableEdges = CustomizableEdges7
        btnExportar.DisabledState.BorderColor = Color.DarkGray
        btnExportar.DisabledState.CustomBorderColor = Color.DarkGray
        btnExportar.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnExportar.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnExportar.FillColor = Color.White
        btnExportar.Font = New Font("Segoe UI", 9F)
        btnExportar.ForeColor = Color.Green
        btnExportar.Image = My.Resources.Resources.xls
        btnExportar.Location = New Point(162, 397)
        btnExportar.Name = "btnExportar"
        btnExportar.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnExportar.Size = New Size(100, 41)
        btnExportar.TabIndex = 12
        btnExportar.Text = "Exportar"
        ' 
        ' buscarFechaVenta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(422, 450)
        Controls.Add(btnBuscar)
        Controls.Add(btnExportar)
        Controls.Add(dtpFinal)
        Controls.Add(dtpInicio)
        Controls.Add(Label2)
        Controls.Add(dgvReporteVentas)
        Controls.Add(Label1)
        Name = "buscarFechaVenta"
        Text = "buscarFechaVenta"
        CType(dgvReporteVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvReporteVentas As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label

    Friend WithEvents dtpInicio As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpFinal As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExportar As Guna.UI2.WinForms.Guna2Button
End Class
