Public Class login
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        ' Crear una instancia del formulario de registro
        Dim registroForm As New Registro()

        ' Mostrar el formulario de registro
        registroForm.Show() ' Muestra el formulario de registro

        ' Opcional: Ocultar el formulario de login
        Me.Hide() ' Oculta el formulario de login
    End Sub

    Private Sub BtnAcceso_Click(sender As Object, e As EventArgs) Handles BtnAcceso.Click
        ' Validar las credenciales del usuario
        If TxtUser.Text = "edgardoramos236@gmail.com" AndAlso TxtPassword.Text = "1234" Then
            ' Si las credenciales son correctas, abrir el formulario principal
            Dim FormMenu As New Form1()
            FormMenu.Show() ' Mostrar el formulario principal
            Me.Hide() ' Ocultar el formulario de login
        Else
            MessageBox.Show("Usuario o contraseña no coinciden.")
        End If
    End Sub
End Class