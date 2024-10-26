Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class Registro
    Private dbConnection As New ConexionBasedeDatos()

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim ConexionBD As MySqlConnection = Nothing

        Try
            ConexionBD = dbConnection.OpenConnection()

            Dim insertar As String = "insert into usuarios (username, password, rol) values (@Usuario,@Password, @Rol)"
            Dim command As New MySqlCommand(insertar, ConexionBD)
            command.Parameters.AddWithValue("@Usuario", TxtUser.Text)
            command.Parameters.AddWithValue("@Rol", cmbRoles.SelectedItem.ToString)
            command.Parameters.AddWithValue("@Password", TxtPassword.Text)

            Dim resultado As Integer = command.ExecuteNonQuery()

            If resultado > 0 Then
                MessageBox.Show("Registro con éxito")
                TxtPassword.Text = ""
                TxtUser.Text = ""
                cmbRoles.SelectedIndex = -1
            Else
                MessageBox.Show("Error al registrar el usuario")
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error en la conexión: " & ex.ToString)
        Finally

            If ConexionBD IsNot Nothing Then
                dbConnection.CloseConnection()
            End If
        End Try
    End Sub

    Private Sub gotoLogin_Click(sender As Object, e As EventArgs) Handles gotoLogin.Click
        Dim GotoLogin As New login()
        GotoLogin.Show()
        Me.Hide()
    End Sub
End Class
