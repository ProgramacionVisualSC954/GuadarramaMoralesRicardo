Public Class Form1

    Private Sub btnClasificar_Click(sender As Object, e As EventArgs) Handles btnClasificar.Click

        Dim nombre As String
        Dim precio As Decimal
        Dim categoria As String
        Dim iva As Decimal
        Dim precioFinal As Decimal

        nombre = txtNombre.Text.Trim()

        ' Validar precio
        If Not Decimal.TryParse(txtPrecio.Text, precio) OrElse precio <= 0 Then
            MessageBox.Show("Ingrese un precio válido mayor que cero.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrecio.Focus()
            txtPrecio.SelectAll()
            Exit Sub
        End If

        ' Clasificar producto
        If precio < 500 Then
            categoria = "Económico"
        ElseIf precio <= 2000 Then
            categoria = "Estándar"
        Else
            categoria = "Premium"
        End If

        ' Calcular IVA y precio final
        iva = precio * 0.16D
        precioFinal = precio + iva

        ' Mostrar resultados
        lblCategoria.Text = categoria
        lblIva.Text = iva.ToString("C")
        lblPrecioFinal.Text = precioFinal.ToString("C")

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtNombre.Clear()
        txtPrecio.Clear()

        lblCategoria.Text = ""
        lblIva.Text = ""
        lblPrecioFinal.Text = ""

        txtNombre.Focus()

    End Sub

End Class