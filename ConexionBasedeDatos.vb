Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class ConexionBasedeDatos
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("MiConexionBD").ConnectionString
    Dim connection As MySqlConnection

    ' Método para abrir la conexión
    Public Function OpenConnection() As MySqlConnection
        If connection Is Nothing Then
            connection = New MySqlConnection(connectionString)
        End If

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Return connection
    End Function

    ' Método para cerrar la conexión
    Public Sub CloseConnection()
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class


