Public Class FromBanco
    Private Sub btnRegistrarCliente_Click(sender As Object, e As EventArgs) Handles btnRegistrarCliente.Click
        Try
            Dim edadIngresada As Integer

            If Not Integer.TryParse(txtEdad.Text, edadIngresada) Then
                lblEstadoCliente.ForeColor = Color.Red
                lblEstadoCliente.Text = "Ingresa una edad válida (solo números)."
                Return
            End If

            Dim cliente As New Persona()
            cliente.Edad = edadIngresada

            lblEstadoCliente.ForeColor = Color.Green
            lblEstadoCliente.Text = $"Cliente registrado correctamente. Edad: {cliente.Edad}"

        Catch ex As ArgumentOutOfRangeException
            lblEstadoCliente.ForeColor = Color.Red
            lblEstadoCliente.Text = ex.Message

        Catch ex As Exception
            lblEstadoCliente.ForeColor = Color.Red
            lblEstadoCliente.Text = "Ocurrió un error al registrar el cliente."
        End Try
    End Sub

    Private Sub section1_Enter(sender As Object, e As EventArgs) Handles section1.Enter

    End Sub
End Class
