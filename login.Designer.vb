﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        TxtUser = New TextBox()
        TxtPassword = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        BtnAcceso = New Button()
        Label5 = New Label()
        BtnRegister = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Image = My.Resources.Resources.usuario_3d
        PictureBox1.Location = New Point(-15, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(171, 168)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(187, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 37)
        Label1.TabIndex = 1
        Label1.Text = "Login"
        ' 
        ' TxtUser
        ' 
        TxtUser.Anchor = AnchorStyles.None
        TxtUser.Location = New Point(136, 88)
        TxtUser.Name = "TxtUser"
        TxtUser.Size = New Size(195, 23)
        TxtUser.TabIndex = 1
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Anchor = AnchorStyles.None
        TxtPassword.Location = New Point(136, 144)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(195, 23)
        TxtPassword.TabIndex = 2
        TxtPassword.UseSystemPasswordChar = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(136, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 3
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(136, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 15)
        Label3.TabIndex = 3
        Label3.Text = "Contraseña"
        ' 
        ' BtnAcceso
        ' 
        BtnAcceso.Anchor = AnchorStyles.None
        BtnAcceso.BackColor = Color.Navy
        BtnAcceso.ForeColor = Color.AliceBlue
        BtnAcceso.Location = New Point(234, 190)
        BtnAcceso.Name = "BtnAcceso"
        BtnAcceso.Size = New Size(97, 35)
        BtnAcceso.TabIndex = 3
        BtnAcceso.Text = "Acceder"
        BtnAcceso.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Underline)
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label5.Location = New Point(177, 403)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 5
        ' 
        ' BtnRegister
        ' 
        BtnRegister.Anchor = AnchorStyles.None
        BtnRegister.BackColor = Color.SteelBlue
        BtnRegister.ForeColor = Color.AliceBlue
        BtnRegister.Location = New Point(136, 190)
        BtnRegister.Name = "BtnRegister"
        BtnRegister.Size = New Size(91, 35)
        BtnRegister.TabIndex = 4
        BtnRegister.Text = "Registrarme"
        BtnRegister.UseVisualStyleBackColor = False
        BtnRegister.Visible = False
        ' 
        ' login
        ' 
        AcceptButton = BtnAcceso
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(357, 275)
        Controls.Add(Label5)
        Controls.Add(BtnRegister)
        Controls.Add(BtnAcceso)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TxtPassword)
        Controls.Add(TxtUser)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAcceso As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnRegister As Button
End Class
