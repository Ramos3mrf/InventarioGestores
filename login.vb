Imports System.Data.Common
Imports Mysql.Data.MySqlClient
Public Class login
    Private dbConnection As New ConexionBasedeDatos()
    Private Sub BtnAcceso_Click(sender As Object, e As EventArgs) Handles BtnAcceso.Click
        Try
            Dim ConexionBD As MySqlConnection = dbConnection.OpenConnection()

            Dim query As String = "SELECT rol FROM Usuarios WHERE username = @Usuario AND password=md5(@Contraseña)"
            Dim command As New MySqlCommand(query, ConexionBD)
            command.Parameters.AddWithValue("@Usuario", TxtUser.Text)
            command.Parameters.AddWithValue("@Contraseña", TxtPassword.Text)

            Dim role As String = Convert.ToString(command.ExecuteScalar())

            If String.IsNullOrEmpty(role) Then
                MessageBox.Show("Usuario o contraseña incorrectos")
            Else
                ' Guardar el rol y el nombre del usuario en las variables globales
                Grol = role
                GUsername = TxtUser.Text
                TxtUser.Text = ""
                TxtPassword.Text = ""

                ' Abrir el formulario principal
                Dim FormMenu As New MenuPrincipal()
                FormMenu.Show()
                Me.Hide()
            End If
        Catch ex As MySqlException
            'lblTest.Text = "Error en la conexión " & ex.ToString

        Finally

        End Try
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim registroForm As New pasar()
        registroForm.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class