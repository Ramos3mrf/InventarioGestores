Public Class pasar
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim loginF As New login()
        loginF.Show()
        Me.Hide()
    End Sub

    Private Sub btnAccederR_Click_1(sender As Object, e As EventArgs) Handles btnAccederR.Click
        If String.IsNullOrEmpty(txtPassR.Text) Then
            MessageBox.Show("Ingrese una contraseña")
            Exit Sub
        End If
        If txtPassR.Text = "edgardo" Then
            Dim RegistoN As New Registro()
            RegistoN.ShowDialog()
            Me.Hide()
        Else
            MessageBox.Show("Contraseña Incorrecta")
        End If
    End Sub


End Class