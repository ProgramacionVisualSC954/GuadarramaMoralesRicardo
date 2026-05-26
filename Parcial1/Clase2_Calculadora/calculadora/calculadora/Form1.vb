Option Strict On
Imports System.Data

Public Class Form1

    '========================
    ' AGREGAR TEXTO
    '========================
    Private Sub AgregarTexto(valor As String)

        If valor = "(" Then

            If proceso.Text.Length > 0 Then

                Dim ultimo As Char = proceso.Text(proceso.Text.Length - 1)

                If Char.IsDigit(ultimo) Then
                    proceso.Text &= "*("
                    Exit Sub
                End If

            End If

        End If

        proceso.Text &= valor

    End Sub

    '========================
    ' NUMEROS
    '========================
    Private Sub cero_Click(sender As Object, e As EventArgs) Handles cero.Click
        AgregarTexto("0")
    End Sub

    Private Sub uno_Click(sender As Object, e As EventArgs) Handles uno.Click
        AgregarTexto("1")
    End Sub

    Private Sub dos_Click(sender As Object, e As EventArgs) Handles dos.Click
        AgregarTexto("2")
    End Sub

    Private Sub tres_Click(sender As Object, e As EventArgs) Handles tres.Click
        AgregarTexto("3")
    End Sub

    Private Sub cuatro_Click(sender As Object, e As EventArgs) Handles cuatro.Click
        AgregarTexto("4")
    End Sub

    Private Sub cinco_Click(sender As Object, e As EventArgs) Handles cinco.Click
        AgregarTexto("5")
    End Sub

    Private Sub seis_Click(sender As Object, e As EventArgs) Handles seis.Click
        AgregarTexto("6")
    End Sub

    Private Sub siete_Click(sender As Object, e As EventArgs) Handles siete.Click
        AgregarTexto("7")
    End Sub

    Private Sub ocho_Click(sender As Object, e As EventArgs) Handles ocho.Click
        AgregarTexto("8")
    End Sub

    Private Sub nueve_Click(sender As Object, e As EventArgs) Handles nueve.Click
        AgregarTexto("9")
    End Sub

    '========================
    ' PUNTO
    '========================
    Private Sub punto_Click(sender As Object, e As EventArgs) Handles punto.Click
        AgregarTexto(".")
    End Sub

    '========================
    ' OPERADORES
    '========================
    Private Sub sumar_Click(sender As Object, e As EventArgs) Handles sumar.Click
        AgregarTexto("+")
    End Sub

    Private Sub restar_Click(sender As Object, e As EventArgs) Handles restar.Click
        AgregarTexto("-")
    End Sub

    Private Sub multiplicar_Click(sender As Object, e As EventArgs) Handles multiplicar.Click
        AgregarTexto("*")
    End Sub

    Private Sub dividir_Click(sender As Object, e As EventArgs) Handles dividir.Click
        AgregarTexto("/")
    End Sub

    '========================
    ' PARENTESIS
    '========================
    Private Sub parentesis_Click(sender As Object, e As EventArgs) Handles parentesis.Click

        If proceso.Text.Count(Function(c) c = "("c) >
           proceso.Text.Count(Function(c) c = ")"c) Then

            AgregarTexto(")")

        Else
            AgregarTexto("(")
        End If

    End Sub

    '========================
    ' IGUAL
    '========================
    Private Sub igual_Click(sender As Object, e As EventArgs) Handles igual.Click

        Try

            If proceso.Text.Trim = "" Then
                MessageBox.Show("No hay operación")
                Exit Sub
            End If

            'VALIDAR PARENTESIS
            Dim abrir As Integer = proceso.Text.Count(Function(c) c = "("c)
            Dim cerrar As Integer = proceso.Text.Count(Function(c) c = ")"c)

            If abrir <> cerrar Then
                MessageBox.Show("La expresión contiene paréntesis no balanceados")
                Exit Sub
            End If

            Dim dt As New DataTable()

            Dim res = dt.Compute(proceso.Text, "")

            resultado.Text = Convert.ToDecimal(res).ToString("N2")

        Catch ex As DivideByZeroException
            MessageBox.Show("No se puede dividir entre cero")

        Catch ex As OverflowException
            MessageBox.Show("El resultado está fuera del rango permitido")

        Catch ex As Exception
            MessageBox.Show("Expresión inválida")
        End Try

    End Sub

    '========================
    ' RAIZ
    '========================
    Private Sub raiz_Click(sender As Object, e As EventArgs) Handles raiz.Click

        Try

            Dim numero As Decimal

            If Decimal.TryParse(proceso.Text, numero) Then

                If numero < 0 Then
                    MessageBox.Show("La raíz cuadrada de un número negativo no es real")
                    Exit Sub
                End If

                Dim res As Double = Math.Sqrt(CDbl(numero))

                resultado.Text = res.ToString("N2")

            Else
                MessageBox.Show("Número inválido")
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la raíz")
        End Try

    End Sub

    '========================
    ' POTENCIA
    '========================
    Private Sub potencia_Click(sender As Object, e As EventArgs) Handles potencia.Click

        Dim numero As Decimal

        If Decimal.TryParse(proceso.Text, numero) Then

            Dim res As Decimal = numero * numero

            resultado.Text = res.ToString("N2")

        Else
            MessageBox.Show("Número inválido")
        End If

    End Sub

    '========================
    ' PORCENTAJE
    '========================
    Private Sub porcentaje_Click(sender As Object, e As EventArgs) Handles porcentaje.Click

        Dim numero As Decimal

        If Decimal.TryParse(proceso.Text, numero) Then

            resultado.Text = (numero / 100D).ToString("N2")

        Else
            MessageBox.Show("Número inválido")
        End If

    End Sub

    '========================
    ' POSITIVO / NEGATIVO
    '========================
    Private Sub pos_o_neg_Click(sender As Object, e As EventArgs) Handles pos_o_neg.Click

        Try

            Dim numero As Decimal

            If Decimal.TryParse(proceso.Text, numero) Then

                numero *= -1

                proceso.Text = numero.ToString()

            End If

        Catch ex As Exception
            MessageBox.Show("Error")
        End Try

    End Sub

    '========================
    ' BORRAR ULTIMO
    '========================
    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click

        If proceso.Text.Length > 0 Then
            proceso.Text = proceso.Text.Substring(0, proceso.Text.Length - 1)
        End If

    End Sub

End Class