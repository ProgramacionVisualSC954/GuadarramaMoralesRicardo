Public Class FromBanco
    Private cuenta As CuentaBancaria

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

    Private Sub btnAbrirCuenta_Click(sender As Object, e As EventArgs) Handles btnAbrirCuenta.Click
        Try
            Dim saldoInicial As Decimal

            If Not Decimal.TryParse(txtSaldoInicial.Text, saldoInicial) Then
                MessageBox.Show("Ingresa un saldo inicial válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If saldoInicial < 0 Then
                MessageBox.Show("El saldo inicial no puede ser negativo.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            cuenta = New CuentaBancaria(saldoInicial)
            SaldoActual.Text = $"Saldo actual: {cuenta.Saldo:C}"
            litsMovimientos.Items.Add($"Cuenta abierta con saldo inicial de {cuenta.Saldo:C}")

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al abrir la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Try
            If cuenta Is Nothing Then
                MessageBox.Show("Primero debes abrir una cuenta.", "Sin cuenta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim monto As Decimal

            If Not Decimal.TryParse(txtMontoRetiro.Text, monto) Then
                MessageBox.Show("Ingresa un monto válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            cuenta.Retirar(monto)
            SaldoActual.Text = $"Saldo actual: {cuenta.Saldo:C}"
            litsMovimientos.Items.Add($"Retiro de {monto:C}")

        Catch ex As SaldoInsuficienteException
            MessageBox.Show(ex.Message, "Saldo insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al procesar el retiro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
