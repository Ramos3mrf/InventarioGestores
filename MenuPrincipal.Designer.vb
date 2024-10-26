<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        MenuStrip1 = New MenuStrip()
        tsmCatalogos = New ToolStripMenuItem()
        tsmCatProd = New ToolStripMenuItem()
        tsmCatCli = New ToolStripMenuItem()
        tsmCatPro = New ToolStripMenuItem()
        tsmReportes = New ToolStripMenuItem()
        tsmRepComRangoF = New ToolStripMenuItem()
        tsmRepVenRangoF = New ToolStripMenuItem()
        tsmRepGan = New ToolStripMenuItem()
        tsmRepExis = New ToolStripMenuItem()
        tsmExistenciasMin = New ToolStripMenuItem()
        CerrarSesiónToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {tsmCatalogos, tsmReportes, tsmExistenciasMin, CerrarSesiónToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(415, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' tsmCatalogos
        ' 
        tsmCatalogos.DropDownItems.AddRange(New ToolStripItem() {tsmCatProd, tsmCatCli, tsmCatPro})
        tsmCatalogos.ForeColor = Color.Navy
        tsmCatalogos.Name = "tsmCatalogos"
        tsmCatalogos.Size = New Size(72, 20)
        tsmCatalogos.Text = "Catálogos"
        ' 
        ' tsmCatProd
        ' 
        tsmCatProd.ForeColor = Color.Navy
        tsmCatProd.Name = "tsmCatProd"
        tsmCatProd.Size = New Size(206, 22)
        tsmCatProd.Text = "Catálogo de productos"
        ' 
        ' tsmCatCli
        ' 
        tsmCatCli.ForeColor = Color.Navy
        tsmCatCli.Name = "tsmCatCli"
        tsmCatCli.Size = New Size(206, 22)
        tsmCatCli.Text = "Catálogo de clientes"
        ' 
        ' tsmCatPro
        ' 
        tsmCatPro.ForeColor = Color.Navy
        tsmCatPro.Name = "tsmCatPro"
        tsmCatPro.Size = New Size(206, 22)
        tsmCatPro.Text = "Catálogo de proveedores"
        ' 
        ' tsmReportes
        ' 
        tsmReportes.DropDownItems.AddRange(New ToolStripItem() {tsmRepComRangoF, tsmRepVenRangoF, tsmRepGan, tsmRepExis})
        tsmReportes.ForeColor = Color.Navy
        tsmReportes.Name = "tsmReportes"
        tsmReportes.Size = New Size(65, 20)
        tsmReportes.Text = "Reportes"
        ' 
        ' tsmRepComRangoF
        ' 
        tsmRepComRangoF.ForeColor = Color.Navy
        tsmRepComRangoF.Name = "tsmRepComRangoF"
        tsmRepComRangoF.Size = New Size(283, 22)
        tsmRepComRangoF.Text = "Reporte de compras por rango de fecha"
        ' 
        ' tsmRepVenRangoF
        ' 
        tsmRepVenRangoF.ForeColor = Color.Navy
        tsmRepVenRangoF.Name = "tsmRepVenRangoF"
        tsmRepVenRangoF.Size = New Size(283, 22)
        tsmRepVenRangoF.Text = "Reporte de ventas por rango de fecha"
        ' 
        ' tsmRepGan
        ' 
        tsmRepGan.ForeColor = Color.Navy
        tsmRepGan.Name = "tsmRepGan"
        tsmRepGan.Size = New Size(283, 22)
        tsmRepGan.Text = "Reporte de ganancias"
        ' 
        ' tsmRepExis
        ' 
        tsmRepExis.ForeColor = Color.Navy
        tsmRepExis.Name = "tsmRepExis"
        tsmRepExis.Size = New Size(283, 22)
        tsmRepExis.Text = "Reporte de existencias"
        ' 
        ' tsmExistenciasMin
        ' 
        tsmExistenciasMin.ForeColor = Color.Navy
        tsmExistenciasMin.Name = "tsmExistenciasMin"
        tsmExistenciasMin.Size = New Size(133, 20)
        tsmExistenciasMin.Text = "Existencias al mínimo"
        ' 
        ' CerrarSesiónToolStripMenuItem
        ' 
        CerrarSesiónToolStripMenuItem.BackColor = Color.MistyRose
        CerrarSesiónToolStripMenuItem.ForeColor = Color.Navy
        CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        CerrarSesiónToolStripMenuItem.Size = New Size(87, 20)
        CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        ' 
        ' MenuPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(415, 393)
        ControlBox = False
        Controls.Add(MenuStrip1)
        ForeColor = Color.Navy
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "MenuPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menú Principal"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmCatalogos As ToolStripMenuItem
    Friend WithEvents tsmReportes As ToolStripMenuItem
    Friend WithEvents tsmCatProd As ToolStripMenuItem
    Friend WithEvents tsmCatCli As ToolStripMenuItem
    Friend WithEvents tsmCatPro As ToolStripMenuItem
    Friend WithEvents tsmRepComRangoF As ToolStripMenuItem
    Friend WithEvents tsmRepVenRangoF As ToolStripMenuItem
    Friend WithEvents tsmRepGan As ToolStripMenuItem
    Friend WithEvents tsmRepExis As ToolStripMenuItem
    Friend WithEvents tsmExistenciasMin As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem

End Class
