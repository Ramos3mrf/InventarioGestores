﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        tsmCompras = New ToolStripMenuItem()
        tsmVentas = New ToolStripMenuItem()
        tsmGanancias = New ToolStripMenuItem()
        tsmExistencias = New ToolStripMenuItem()
        tsmExistenciasMin = New ToolStripMenuItem()
        tsmUsuarios = New ToolStripMenuItem()
        tsmCerrarSesion = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        tsslRol = New ToolStripStatusLabel()
        PanelContenedor = New Panel()
        ToolStripSplitButton1 = New ToolStripSplitButton()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        PanelContenedor.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {tsmCatalogos, tsmReportes, tsmExistenciasMin, tsmUsuarios, tsmCerrarSesion})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(396, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' tsmCatalogos
        ' 
        tsmCatalogos.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsmCatalogos.DropDownItems.AddRange(New ToolStripItem() {tsmCatProd, tsmCatCli, tsmCatPro})
        tsmCatalogos.ForeColor = Color.Navy
        tsmCatalogos.Name = "tsmCatalogos"
        tsmCatalogos.Size = New Size(72, 20)
        tsmCatalogos.Text = "Catálogos"
        ' 
        ' tsmCatProd
        ' 
        tsmCatProd.ForeColor = Color.Navy
        tsmCatProd.Image = My.Resources.Resources.agregar_producto
        tsmCatProd.Name = "tsmCatProd"
        tsmCatProd.Size = New Size(139, 22)
        tsmCatProd.Text = "Productos"
        ' 
        ' tsmCatCli
        ' 
        tsmCatCli.ForeColor = Color.Navy
        tsmCatCli.Image = My.Resources.Resources.personas
        tsmCatCli.Name = "tsmCatCli"
        tsmCatCli.Size = New Size(139, 22)
        tsmCatCli.Text = " Clientes"
        ' 
        ' tsmCatPro
        ' 
        tsmCatPro.ForeColor = Color.Navy
        tsmCatPro.Image = My.Resources.Resources.servicio_de_administracion
        tsmCatPro.Name = "tsmCatPro"
        tsmCatPro.Size = New Size(139, 22)
        tsmCatPro.Text = "Proveedores"
        ' 
        ' tsmReportes
        ' 
        tsmReportes.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsmReportes.DropDownItems.AddRange(New ToolStripItem() {tsmCompras, tsmVentas, tsmGanancias, tsmExistencias})
        tsmReportes.ForeColor = Color.Navy
        tsmReportes.Name = "tsmReportes"
        tsmReportes.Size = New Size(72, 20)
        tsmReportes.Text = "Inventario"
        ' 
        ' tsmCompras
        ' 
        tsmCompras.ForeColor = Color.Navy
        tsmCompras.Image = My.Resources.Resources.orden
        tsmCompras.Name = "tsmCompras"
        tsmCompras.Size = New Size(146, 22)
        tsmCompras.Text = "Compras"
        ' 
        ' tsmVentas
        ' 
        tsmVentas.ForeColor = Color.Navy
        tsmVentas.Image = My.Resources.Resources.ventas
        tsmVentas.Name = "tsmVentas"
        tsmVentas.Size = New Size(146, 22)
        tsmVentas.Text = "Ventas"
        ' 
        ' tsmGanancias
        ' 
        tsmGanancias.ForeColor = Color.Navy
        tsmGanancias.Name = "tsmGanancias"
        tsmGanancias.Size = New Size(146, 22)
        tsmGanancias.Text = "Ganancias***"
        ' 
        ' tsmExistencias
        ' 
        tsmExistencias.ForeColor = Color.Navy
        tsmExistencias.Name = "tsmExistencias"
        tsmExistencias.Size = New Size(146, 22)
        tsmExistencias.Text = "Existencias***"
        ' 
        ' tsmExistenciasMin
        ' 
        tsmExistenciasMin.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsmExistenciasMin.ForeColor = Color.Navy
        tsmExistenciasMin.Name = "tsmExistenciasMin"
        tsmExistenciasMin.Size = New Size(148, 20)
        tsmExistenciasMin.Text = "Existencias al mínimo***"
        ' 
        ' tsmUsuarios
        ' 
        tsmUsuarios.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsmUsuarios.ForeColor = Color.Navy
        tsmUsuarios.Name = "tsmUsuarios"
        tsmUsuarios.Size = New Size(64, 20)
        tsmUsuarios.Text = "Usuarios"
        ' 
        ' tsmCerrarSesion
        ' 
        tsmCerrarSesion.BackColor = Color.MistyRose
        tsmCerrarSesion.BackgroundImage = My.Resources.Resources.boton
        tsmCerrarSesion.BackgroundImageLayout = ImageLayout.Zoom
        tsmCerrarSesion.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsmCerrarSesion.ForeColor = Color.Navy
        tsmCerrarSesion.Image = My.Resources.Resources.boton
        tsmCerrarSesion.Name = "tsmCerrarSesion"
        tsmCerrarSesion.Size = New Size(28, 20)
        tsmCerrarSesion.Text = " "
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        StatusStrip1.Dock = DockStyle.None
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripSplitButton1, tsslRol})
        StatusStrip1.LayoutStyle = ToolStripLayoutStyle.Flow
        StatusStrip1.Location = New Point(288, 58)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(108, 22)
        StatusStrip1.Stretch = False
        StatusStrip1.TabIndex = 5
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' tsslRol
        ' 
        tsslRol.Name = "tsslRol"
        tsslRol.Size = New Size(61, 17)
        tsslRol.Text = "rolUsuario"
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.Controls.Add(StatusStrip1)
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(0, 0)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(396, 80)
        PanelContenedor.TabIndex = 7
        ' 
        ' ToolStripSplitButton1
        ' 
        ToolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripSplitButton1.Image = My.Resources.Resources.pagina_de_inicio
        ToolStripSplitButton1.ImageTransparentColor = Color.Magenta
        ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        ToolStripSplitButton1.Size = New Size(32, 20)
        ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        ' 
        ' MenuPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(396, 80)
        ControlBox = False
        Controls.Add(MenuStrip1)
        Controls.Add(PanelContenedor)
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
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        PanelContenedor.ResumeLayout(False)
        PanelContenedor.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmCatalogos As ToolStripMenuItem
    Friend WithEvents tsmReportes As ToolStripMenuItem
    Friend WithEvents tsmCatProd As ToolStripMenuItem
    Friend WithEvents tsmCatCli As ToolStripMenuItem
    Friend WithEvents tsmCatPro As ToolStripMenuItem
    Friend WithEvents tsmCompras As ToolStripMenuItem
    Friend WithEvents tsmVentas As ToolStripMenuItem
    Friend WithEvents tsmGanancias As ToolStripMenuItem
    Friend WithEvents tsmExistencias As ToolStripMenuItem
    Friend WithEvents tsmExistenciasMin As ToolStripMenuItem
    Friend WithEvents tsmCerrarSesion As ToolStripMenuItem
    Friend WithEvents tsmUsuarios As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsslRol As ToolStripStatusLabel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton

End Class
