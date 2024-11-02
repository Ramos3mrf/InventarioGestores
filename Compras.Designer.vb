<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compras))
        dgvCompras = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtCompraID = New TextBox()
        txtFecha = New TextBox()
        txtProveedorID = New TextBox()
        txtTotal = New TextBox()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        CType(dgvCompras, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvCompras
        ' 
        dgvCompras.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.Navy
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvCompras.DefaultCellStyle = DataGridViewCellStyle1
        dgvCompras.Location = New Point(24, 49)
        dgvCompras.Name = "dgvCompras"
        dgvCompras.Size = New Size(622, 197)
        dgvCompras.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 1
        Label1.Text = "Id_Compra:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 2
        Label2.Text = "Id_Proveedor:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(233, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 15)
        Label3.TabIndex = 3
        Label3.Text = "Fecha de compra:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(296, 62)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 15)
        Label4.TabIndex = 7
        Label4.Text = "Total:"
        ' 
        ' txtCompraID
        ' 
        txtCompraID.Location = New Point(120, 28)
        txtCompraID.Name = "txtCompraID"
        txtCompraID.Size = New Size(100, 23)
        txtCompraID.TabIndex = 4
        ' 
        ' txtFecha
        ' 
        txtFecha.Location = New Point(340, 28)
        txtFecha.Name = "txtFecha"
        txtFecha.Size = New Size(100, 23)
        txtFecha.TabIndex = 6
        ' 
        ' txtProveedorID
        ' 
        txtProveedorID.Location = New Point(120, 57)
        txtProveedorID.Name = "txtProveedorID"
        txtProveedorID.Size = New Size(100, 23)
        txtProveedorID.TabIndex = 5
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(340, 59)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(100, 23)
        txtTotal.TabIndex = 8
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        GroupBox1.Controls.Add(txtTotal)
        GroupBox1.Controls.Add(txtFecha)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtProveedorID)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtCompraID)
        GroupBox1.Location = New Point(98, 278)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(484, 107)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = " "
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label5.Location = New Point(281, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 28)
        Label5.TabIndex = 10
        Label5.Text = "COMPRAS"
        ' 
        ' Compras
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(671, 407)
        Controls.Add(Label5)
        Controls.Add(GroupBox1)
        Controls.Add(dgvCompras)
        ForeColor = Color.Navy
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Compras"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Compras"
        CType(dgvCompras, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvCompras As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCompraID As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtProveedorID As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label

End Class
