<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pasar
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
        btnSalir = New Button()
        txtPassR = New TextBox()
        btnAccederR = New Button()
        SuspendLayout()
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.Transparent
        btnSalir.FlatAppearance.BorderColor = Color.White
        btnSalir.FlatAppearance.MouseDownBackColor = Color.Red
        btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnSalir.Location = New Point(53, 49)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(70, 23)
        btnSalir.TabIndex = 3
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' txtPassR
        ' 
        txtPassR.Location = New Point(53, 20)
        txtPassR.Name = "txtPassR"
        txtPassR.PasswordChar = "*"c
        txtPassR.Size = New Size(155, 23)
        txtPassR.TabIndex = 1
        ' 
        ' btnAccederR
        ' 
        btnAccederR.FlatStyle = FlatStyle.Flat
        btnAccederR.ForeColor = Color.White
        btnAccederR.Location = New Point(133, 49)
        btnAccederR.Name = "btnAccederR"
        btnAccederR.Size = New Size(75, 23)
        btnAccederR.TabIndex = 2
        btnAccederR.Text = "Acceder"
        btnAccederR.UseVisualStyleBackColor = True
        ' 
        ' pasar
        ' 
        AcceptButton = btnAccederR
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkViolet
        ClientSize = New Size(265, 93)
        ControlBox = False
        Controls.Add(txtPassR)
        Controls.Add(btnAccederR)
        Controls.Add(btnSalir)
        FormBorderStyle = FormBorderStyle.None
        Name = "pasar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "pasar"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtPassR As TextBox
    Friend WithEvents btnAccederR As Button
End Class
