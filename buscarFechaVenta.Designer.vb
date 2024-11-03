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
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        dtpInicio = New Guna.UI2.WinForms.Guna2DateTimePicker()
        dtpFinal = New Guna.UI2.WinForms.Guna2DateTimePicker()
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
        ' Guna2Button1
        ' 
        Guna2Button1.BackColor = Color.Transparent
        Guna2Button1.BorderColor = Color.Navy
        Guna2Button1.BorderRadius = 10
        Guna2Button1.BorderThickness = 1
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.White
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.Navy
        Guna2Button1.Image = My.Resources.Resources.buscar
        Guna2Button1.Location = New Point(281, 101)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(129, 38)
        Guna2Button1.TabIndex = 9
        Guna2Button1.Text = "Buscar"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.BackColor = Color.Transparent
        Guna2Button2.BorderColor = Color.Green
        Guna2Button2.BorderRadius = 10
        Guna2Button2.BorderThickness = 1
        Guna2Button2.CustomizableEdges = CustomizableEdges3
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.White
        Guna2Button2.Font = New Font("Segoe UI", 9F)
        Guna2Button2.ForeColor = Color.Green
        Guna2Button2.Image = My.Resources.Resources.xls
        Guna2Button2.Location = New Point(161, 401)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button2.Size = New Size(100, 37)
        Guna2Button2.TabIndex = 8
        Guna2Button2.Text = "Exportar"
        ' 
        ' dtpInicio
        ' 
        dtpInicio.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dtpInicio.BorderColor = Color.Navy
        dtpInicio.BorderRadius = 7
        dtpInicio.BorderThickness = 1
        dtpInicio.Checked = True
        dtpInicio.CustomizableEdges = CustomizableEdges5
        dtpInicio.FillColor = Color.White
        dtpInicio.Font = New Font("Segoe UI", 9F)
        dtpInicio.ForeColor = Color.Navy
        dtpInicio.Format = DateTimePickerFormat.Long
        dtpInicio.Location = New Point(14, 35)
        dtpInicio.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpInicio.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpInicio.Name = "dtpInicio"
        dtpInicio.ShadowDecoration.CustomizableEdges = CustomizableEdges6
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
        dtpFinal.CustomizableEdges = CustomizableEdges7
        dtpFinal.FillColor = Color.White
        dtpFinal.Font = New Font("Segoe UI", 9F)
        dtpFinal.ForeColor = Color.Navy
        dtpFinal.Format = DateTimePickerFormat.Long
        dtpFinal.Location = New Point(14, 101)
        dtpFinal.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpFinal.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpFinal.Name = "dtpFinal"
        dtpFinal.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        dtpFinal.Size = New Size(227, 38)
        dtpFinal.TabIndex = 11
        dtpFinal.Value = New Date(2024, 11, 2, 23, 29, 12, 437)
        ' 
        ' buscarFechaVenta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(422, 450)
        Controls.Add(dtpFinal)
        Controls.Add(dtpInicio)
        Controls.Add(Guna2Button1)
        Controls.Add(Guna2Button2)
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
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnExportar As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpInicio As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpFinal As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
