Imports System.Data.Common
Imports Mysql.Data.MySqlClient
Public Class login
    Private dbConnection As New ConexionBasedeDatos()
    Private Sub BtnAcceso_Click(sender As Object, e As EventArgs) Handles BtnAcceso.Click
        Try

            Dim ConexionBD As MySqlConnection = dbConnection.OpenConnection()
            lblTest.Text = "Conexión establecida"

            Dim query As String = "SELECT * FROM Usuarios WHERE username = @Usuario AND password = @Contraseña"
            Dim command As New MySqlCommand(query, ConexionBD)
            command.Parameters.AddWithValue("@Usuario", TxtUser.Text)
            command.Parameters.AddWithValue("@Contraseña", TxtPassword.Text)

            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

            If result > 0 Then
                MessageBox.Show("BIENVENIDO")
                Dim FormMenu As New MenuPrincipal()
                FormMenu.Show()
                Me.Hide()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos")
            End If
        Catch ex As MySqlException
            lblTest.Text = "Error en la conexión " & ex.ToString

        Finally

        End Try
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim registroForm As New Registro()
        registroForm.Show()
        Me.Hide()
    End Sub

    Private Sub Conexion_Click(sender As Object, e As EventArgs) Handles Conexion.Click
        Try
            Dim conexion = "server=localhost;Uid=root;pwd=1234;database=inventario;SslMode=none"
            Dim ConexionBD = New MySqlConnection(conexion)
            ConexionBD.Open()
            lblTest.Text = "Conexión establecida"
        Catch ex As MySqlException
            lblTest.Text = "Error en la conexión " & ex.ToString

        Finally
            dbConnection.CloseConnection()
        End Try
    End Sub

End Class