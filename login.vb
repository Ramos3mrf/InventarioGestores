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
                MessageBox.Show("Login exitoso")
                Dim FormMenu As New Form1()
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
        ' Crear una instancia del formulario de registro
        Dim registroForm As New Registro()

        ' Mostrar el formulario de registro
        registroForm.Show() ' Muestra el formulario de registro

        ' Opcional: Ocultar el formulario de login
        Me.Hide() ' Oculta el formulario de login
    End Sub

    Private Sub Conexion_Click(sender As Object, e As EventArgs) Handles Conexion.Click
        Try
            'Dim server = "localhost"
            'Dim usuario = "root"
            'Dim pass = "1234"
            'Dim db = "inventario"
            Dim conexion = "server=localhost;Uid=root;pwd=1234;database=inventario;SslMode=none"
            'Dim cadena = "server=" & server & ";Uid=" & usuario & ";pwd=" & pass & ";database=" & db
            Dim ConexionBD = New MySqlConnection(conexion)
            ConexionBD.Open()
            lblTest.Text = "Conexión establecida"
            'Dim ConexionDB As New MySqlConnection()
            'ConexionDB.ConnectionString = "server=localhost;uid=admin;password=1234;database=inventario;SslMode=none;"

            'ConexionDB.Open()
            'MessageBox.Show("Se ha establecido la conexión a la base de datos")
            ''ConexionDB.Close()
            ''MessageBox.Show("Desconectado")
        Catch ex As MySqlException
            lblTest.Text = "Error en la conexión " & ex.ToString

        Finally

        End Try
    End Sub

End Class