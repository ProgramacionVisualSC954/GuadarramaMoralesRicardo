Public Class Form1

    'Arrays del inventario
    Dim nombres(9) As String
    Dim precios(9) As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nombres(0) = "Laptop Dell Inspiron"
        precios(0) = 12500D

        nombres(1) = "Mouse Logitech M185"
        precios(1) = 250D

        nombres(2) = "Teclado Redragon K552"
        precios(2) = 850D

        nombres(3) = "Monitor Samsung 24"
        precios(3) = 3200D

        nombres(4) = "Disco SSD Kingston 480GB"
        precios(4) = 700D

        nombres(5) = "Memoria USB Kingston 64GB"
        precios(5) = 180D

        nombres(6) = "Laptop HP Pavilion"
        precios(6) = 14500D

        nombres(7) = "Audifonos Sony WH-CH520"
        precios(7) = 950D

        nombres(8) = "Impresora Epson L3250"
        precios(8) = 4200D

        nombres(9) = "Tablet Samsung Galaxy Tab A9"
        precios(9) = 3800D

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim busqueda As String
        Dim encontrado As Boolean = False

        busqueda = txtBusqueda1.Text.Trim().ToLower()

        If busqueda = "" Then
            MessageBox.Show("Ingrese un producto para buscar.")
            txtBusqueda1.Focus()
            Exit Sub
        End If

        For i As Integer = 0 To nombres.Length - 1

            If nombres(i).ToLower() = busqueda Then

                lblResultado.Text =
                    "Producto encontrado" & vbCrLf &
                    "Posición: " & i & vbCrLf &
                    "Nombre: " & nombres(i) & vbCrLf &
                    "Precio: " & precios(i).ToString("C")

                encontrado = True
                Exit For

            End If

        Next

        If Not encontrado Then

            lblResultado.Text =
                "El producto """ & txtBusqueda1.Text &
                """ no existe en el inventario."

        End If

    End Sub

End Class