<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportes))
        ConexionBasedeDatosBindingSource = New BindingSource(components)
        btnBuscarUsuario = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        CType(ConexionBasedeDatosBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ConexionBasedeDatosBindingSource
        ' 
        ConexionBasedeDatosBindingSource.DataSource = GetType(ConexionBasedeDatos)
        ' 
        ' btnBuscarUsuario
        ' 
        btnBuscarUsuario.BackColor = Color.White
        btnBuscarUsuario.FlatStyle = FlatStyle.Flat
        btnBuscarUsuario.ForeColor = Color.Navy
        btnBuscarUsuario.Location = New Point(436, 30)
        btnBuscarUsuario.Name = "btnBuscarUsuario"
        btnBuscarUsuario.Size = New Size(75, 24)
        btnBuscarUsuario.TabIndex = 1
        btnBuscarUsuario.Text = "Buscar"
        btnBuscarUsuario.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(148, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.ForeColor = Color.Navy
        TextBox1.Location = New Point(210, 35)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(221, 16)
        TextBox1.TabIndex = 3
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 83)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(639, 355)
        DataGridView1.TabIndex = 4
        ' 
        ' Reportes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(663, 450)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(btnBuscarUsuario)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Reportes"
        Text = "Usuarios"
        CType(ConexionBasedeDatosBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ConexionBasedeDatosBindingSource As BindingSource
    Friend WithEvents btnBuscarUsuario As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
