<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label8 = New Label()
        TxtUser = New TextBox()
        TxtPassword = New TextBox()
        BtnRegister = New Button()
        cmbRoles = New ComboBox()
        gotoLogin = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.NewUserWeb
        PictureBox1.Location = New Point(25, 77)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(147, 202)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(255, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 41)
        Label1.TabIndex = 1
        Label1.Text = "Registro"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(179, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 1
        Label2.Text = "Usuario:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(178, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(27, 15)
        Label3.TabIndex = 1
        Label3.Text = "Rol:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(179, 207)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 15)
        Label8.TabIndex = 1
        Label8.Text = "Contraseña:"
        ' 
        ' TxtUser
        ' 
        TxtUser.Location = New Point(179, 127)
        TxtUser.Name = "TxtUser"
        TxtUser.Size = New Size(207, 23)
        TxtUser.TabIndex = 2
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(179, 216)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(207, 23)
        TxtPassword.TabIndex = 2
        ' 
        ' BtnRegister
        ' 
        BtnRegister.BackColor = Color.Navy
        BtnRegister.FlatStyle = FlatStyle.Popup
        BtnRegister.ForeColor = SystemColors.ControlLightLight
        BtnRegister.Location = New Point(239, 262)
        BtnRegister.Name = "BtnRegister"
        BtnRegister.Size = New Size(147, 31)
        BtnRegister.TabIndex = 3
        BtnRegister.Text = "Registrarme"
        BtnRegister.UseVisualStyleBackColor = False
        ' 
        ' cmbRoles
        ' 
        cmbRoles.ForeColor = Color.Black
        cmbRoles.FormattingEnabled = True
        cmbRoles.Items.AddRange(New Object() {"administrador", "vendedor"})
        cmbRoles.Location = New Point(178, 171)
        cmbRoles.Name = "cmbRoles"
        cmbRoles.Size = New Size(208, 23)
        cmbRoles.TabIndex = 4
        ' 
        ' gotoLogin
        ' 
        gotoLogin.BackColor = Color.Transparent
        gotoLogin.FlatStyle = FlatStyle.Flat
        gotoLogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gotoLogin.ForeColor = Color.Navy
        gotoLogin.Location = New Point(25, 285)
        gotoLogin.Name = "gotoLogin"
        gotoLogin.Size = New Size(75, 33)
        gotoLogin.TabIndex = 5
        gotoLogin.Text = "Login"
        gotoLogin.UseVisualStyleBackColor = False
        ' 
        ' Registro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(417, 335)
        Controls.Add(gotoLogin)
        Controls.Add(Label8)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(BtnRegister)
        Controls.Add(TxtPassword)
        Controls.Add(TxtUser)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(cmbRoles)
        Name = "Registro"
        Text = "Registro"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnRegister As Button
    Friend WithEvents cmbRoles As ComboBox
    Friend WithEvents gotoLogin As Button
End Class
