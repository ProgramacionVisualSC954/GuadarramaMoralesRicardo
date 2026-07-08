Public Class Operaciones
    Public Shared Function CalcularPagoMensual(montoPrestamo As Decimal, numeroMeses As Integer) As Decimal
        If numeroMeses <= 0 Then
            Throw New DivideByZeroException("El numero de meses no puede ser cero")

        End If
        Return montoPrestamo / numeroMeses

    End Function

End Class