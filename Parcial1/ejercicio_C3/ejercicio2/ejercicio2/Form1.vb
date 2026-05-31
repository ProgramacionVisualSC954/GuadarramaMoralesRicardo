Public Class Form1

    'Listas para almacenar productos y precios
    Dim productos As New List(Of String)()
    Dim precios As New List(Of Decimal)()

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim nombre As String
        Dim precio As Decimal

        nombre = txtNombreProducto.Text.Trim()

        'Validar nombre
        If nombre = "" Then
            MessageBox.Show("Ingrese el nombre del producto.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombreProducto.Focus()
            Exit Sub
        End If

        'Validar precio
        If Not Decimal.TryParse(txtPrecioProducto.Text, precio) OrElse precio <= 0 Then
            MessageBox.Show("Ingrese un precio válido mayor que cero.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrecioProducto.Focus()
            txtPrecioProducto.SelectAll()
            Exit Sub
        End If

        'Guardar datos
        productos.Add(nombre)
        precios.Add(precio)

        'Mostrar en ListBox
        lstProductos.Items.Add(nombre & " - " & precio.ToString("C"))

        'Actualizar totales
        CalcularTotales()

        'Limpiar entradas
        txtNombreProducto.Clear()
        txtPrecioProducto.Clear()
        txtNombreProducto.Focus()

    End Sub

    Private Sub CalcularTotales()

        Dim subtotal As Decimal = 0

        For Each precio As Decimal In precios
            subtotal += precio
        Next

        Dim descuento As Decimal = 0

        'Descuento del 5% si hay 3 o más productos
        If productos.Count >= 3 Then
            descuento = subtotal * 0.05D
        End If

        Dim subtotalConDescuento As Decimal = subtotal - descuento
        Dim iva As Decimal = subtotalConDescuento * 0.16D
        Dim total As Decimal = subtotalConDescuento + iva

        lblSubtotal.Text = subtotalConDescuento.ToString("C")
        lblIva.Text = iva.ToString("C")
        lblTotal.Text = total.ToString("C")

    End Sub

    Private Sub btnGenerarTicket_Click(sender As Object, e As EventArgs) Handles btnGenerarTicket.Click

        If productos.Count = 0 Then
            MessageBox.Show("No hay productos agregados.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim ticket As String = ""
        Dim subtotal As Decimal = 0

        ticket &= "===== TICKET DE COMPRA =====" & vbCrLf & vbCrLf

        Dim indice As Integer = 1

        For Each producto As String In productos

            Dim precio As Decimal = precios(indice - 1)

            ticket &= indice & ". " &
                      producto & " - " &
                      precio.ToString("C") & vbCrLf

            subtotal += precio
            indice += 1

        Next

        Dim descuento As Decimal = 0

        If productos.Count >= 3 Then
            descuento = subtotal * 0.05D
        End If

        Dim subtotalConDescuento As Decimal = subtotal - descuento
        Dim iva As Decimal = subtotalConDescuento * 0.16D
        Dim total As Decimal = subtotalConDescuento + iva

        ticket &= vbCrLf
        ticket &= "Subtotal: " & subtotal.ToString("C") & vbCrLf

        If descuento > 0 Then
            ticket &= "Descuento (5%): -" & descuento.ToString("C") & vbCrLf
        End If

        ticket &= "IVA (16%): " & iva.ToString("C") & vbCrLf
        ticket &= "Total: " & total.ToString("C") & vbCrLf

        MessageBox.Show(ticket, "Ticket de Compra",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        'Limpiar listas
        productos.Clear()
        precios.Clear()

        'Limpiar ListBox
        lstProductos.Items.Clear()

        'Limpiar TextBox
        txtNombreProducto.Clear()
        txtPrecioProducto.Clear()

        'Reiniciar etiquetas
        lblSubtotal.Text = "$0.00"
        lblIva.Text = "$0.00"
        lblTotal.Text = "$0.00"

        'Regresar foco
        txtNombreProducto.Focus()

    End Sub
    Private Sub lstProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class